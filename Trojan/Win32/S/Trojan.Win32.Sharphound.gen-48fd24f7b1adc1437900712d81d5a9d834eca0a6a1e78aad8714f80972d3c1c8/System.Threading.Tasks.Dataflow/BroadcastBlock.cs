using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks.Dataflow.Internal;

namespace System.Threading.Tasks.Dataflow;

[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
[DebuggerTypeProxy(typeof(BroadcastBlock<>.DebugView))]
public sealed class BroadcastBlock<T> : IPropagatorBlock<T, T>, ITargetBlock<T>, ISourceBlock<T>, IReceivableSourceBlock<T>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class DebugView
	{
		private readonly BroadcastBlock<T> _broadcastBlock;

		private readonly BroadcastingSourceCore<T>.DebuggingInformation _sourceDebuggingInformation;

		public IEnumerable<T> InputQueue => _sourceDebuggingInformation.InputQueue;

		public bool HasValue => _broadcastBlock.HasValueForDebugger;

		public T Value => _broadcastBlock.ValueForDebugger;

		public Task TaskForOutputProcessing => _sourceDebuggingInformation.TaskForOutputProcessing;

		public DataflowBlockOptions DataflowBlockOptions => _sourceDebuggingInformation.DataflowBlockOptions;

		public bool IsDecliningPermanently => _broadcastBlock._decliningPermanently;

		public bool IsCompleted => _sourceDebuggingInformation.IsCompleted;

		public int Id => Common.GetBlockId(_broadcastBlock);

		public TargetRegistry<T> LinkedTargets => _sourceDebuggingInformation.LinkedTargets;

		public ITargetBlock<T> NextMessageReservedFor => _sourceDebuggingInformation.NextMessageReservedFor;

		public DebugView(BroadcastBlock<T> broadcastBlock)
		{
			_broadcastBlock = broadcastBlock;
			_sourceDebuggingInformation = broadcastBlock._source.GetDebuggingInformation();
		}
	}

	[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
	private sealed class BroadcastingSourceCore<TOutput>
	{
		internal sealed class DebuggingInformation
		{
			private BroadcastingSourceCore<TOutput> _source;

			public bool HasValue => _source._currentMessageIsValid;

			public TOutput Value => _source._currentMessage;

			public IEnumerable<TOutput> InputQueue => Enumerable.ToList(_source._messages);

			public Task TaskForOutputProcessing => _source._taskForOutputProcessing;

			public DataflowBlockOptions DataflowBlockOptions => _source._dataflowBlockOptions;

			public bool IsCompleted => _source.Completion.IsCompleted;

			public TargetRegistry<TOutput> LinkedTargets => _source._targetRegistry;

			public ITargetBlock<TOutput> NextMessageReservedFor => _source._nextMessageReservedFor;

			public DebuggingInformation(BroadcastingSourceCore<TOutput> source)
			{
				_source = source;
			}
		}

		private readonly TargetRegistry<TOutput> _targetRegistry;

		private readonly Queue<TOutput> _messages = new Queue<TOutput>();

		private readonly TaskCompletionSource<VoidResult> _completionTask = new TaskCompletionSource<VoidResult>();

		private readonly Action<int> _itemsRemovedAction;

		private readonly BroadcastBlock<TOutput> _owningSource;

		private readonly DataflowBlockOptions _dataflowBlockOptions;

		private readonly Func<TOutput, TOutput> _cloningFunction;

		private bool _currentMessageIsValid;

		private TOutput _currentMessage;

		private ITargetBlock<TOutput> _nextMessageReservedFor;

		private bool _enableOffering;

		private bool _decliningPermanently;

		private Task _taskForOutputProcessing;

		private List<Exception> _exceptions;

		private long _nextMessageId = 1L;

		private bool _completionReserved;

		private object OutgoingLock => _completionTask;

		private object ValueLock => _targetRegistry;

		private bool CanceledOrFaulted
		{
			get
			{
				if (!_dataflowBlockOptions.CancellationToken.IsCancellationRequested)
				{
					if (Volatile.Read(ref _exceptions) != null)
					{
						return _decliningPermanently;
					}
					return false;
				}
				return true;
			}
		}

		internal Task Completion => _completionTask.Task;

		internal DataflowBlockOptions DataflowBlockOptions => _dataflowBlockOptions;

		private object DebuggerDisplayContent
		{
			get
			{
				IDebuggerDisplay owningSource = _owningSource;
				return $"Block=\"{((owningSource != null) ? owningSource.Content : _owningSource)}\"";
			}
		}

		internal BroadcastingSourceCore(BroadcastBlock<TOutput> owningSource, Func<TOutput, TOutput> cloningFunction, DataflowBlockOptions dataflowBlockOptions, Action<int> itemsRemovedAction)
		{
			_owningSource = owningSource;
			_cloningFunction = cloningFunction;
			_dataflowBlockOptions = dataflowBlockOptions;
			_itemsRemovedAction = itemsRemovedAction;
			_targetRegistry = new TargetRegistry<TOutput>(_owningSource);
		}

		internal bool TryReceive(Predicate<TOutput> filter, out TOutput item)
		{
			TOutput currentMessage;
			bool currentMessageIsValid;
			lock (OutgoingLock)
			{
				lock (ValueLock)
				{
					currentMessage = _currentMessage;
					currentMessageIsValid = _currentMessageIsValid;
				}
			}
			if (currentMessageIsValid && (filter == null || filter(currentMessage)))
			{
				item = CloneItem(currentMessage);
				return true;
			}
			item = default(TOutput);
			return false;
		}

		internal bool TryReceiveAll(out IList<TOutput> items)
		{
			if (TryReceive(null, out var item))
			{
				items = new TOutput[1] { item };
				return true;
			}
			items = null;
			return false;
		}

		internal void AddMessage(TOutput item)
		{
			lock (ValueLock)
			{
				if (!_decliningPermanently)
				{
					_messages.Enqueue(item);
					if (_messages.Count == 1)
					{
						_enableOffering = true;
					}
					OfferAsyncIfNecessary();
				}
			}
		}

		internal void Complete()
		{
			lock (ValueLock)
			{
				_decliningPermanently = true;
				Task.Factory.StartNew(delegate(object state)
				{
					BroadcastingSourceCore<TOutput> broadcastingSourceCore = (BroadcastingSourceCore<TOutput>)state;
					lock (broadcastingSourceCore.OutgoingLock)
					{
						lock (broadcastingSourceCore.ValueLock)
						{
							broadcastingSourceCore.CompleteBlockIfPossible();
						}
					}
				}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
			}
		}

		private TOutput CloneItem(TOutput item)
		{
			if (_cloningFunction == null)
			{
				return item;
			}
			return _cloningFunction(item);
		}

		private void OfferCurrentMessageToNewTarget(ITargetBlock<TOutput> target)
		{
			TOutput currentMessage;
			bool currentMessageIsValid;
			lock (ValueLock)
			{
				currentMessage = _currentMessage;
				currentMessageIsValid = _currentMessageIsValid;
			}
			if (!currentMessageIsValid)
			{
				return;
			}
			bool flag = _cloningFunction != null;
			switch (target.OfferMessage(new DataflowMessageHeader(_nextMessageId), currentMessage, _owningSource, flag))
			{
			case DataflowMessageStatus.Accepted:
				if (!flag)
				{
					_targetRegistry.Remove(target, onlyIfReachedMaxMessages: true);
				}
				break;
			case DataflowMessageStatus.DecliningPermanently:
				_targetRegistry.Remove(target);
				break;
			}
		}

		private bool OfferToTargets()
		{
			DataflowMessageHeader header = default(DataflowMessageHeader);
			TOutput message = default(TOutput);
			int num = 0;
			lock (ValueLock)
			{
				if (_nextMessageReservedFor != null || _messages.Count <= 0)
				{
					_enableOffering = false;
					return false;
				}
				if (_targetRegistry.FirstTargetNode == null)
				{
					while (_messages.Count > 1)
					{
						_messages.Dequeue();
						num++;
					}
				}
				message = (_currentMessage = _messages.Dequeue());
				num++;
				_currentMessageIsValid = true;
				header = new DataflowMessageHeader(++_nextMessageId);
				if (_messages.Count == 0)
				{
					_enableOffering = false;
				}
			}
			if (header.IsValid)
			{
				if (_itemsRemovedAction != null)
				{
					_itemsRemovedAction(num);
				}
				TargetRegistry<TOutput>.LinkedTargetInfo linkedTargetInfo = _targetRegistry.FirstTargetNode;
				while (linkedTargetInfo != null)
				{
					TargetRegistry<TOutput>.LinkedTargetInfo next = linkedTargetInfo.Next;
					ITargetBlock<TOutput> target = linkedTargetInfo.Target;
					OfferMessageToTarget(header, message, target);
					linkedTargetInfo = next;
				}
			}
			return true;
		}

		private void OfferMessageToTarget(DataflowMessageHeader header, TOutput message, ITargetBlock<TOutput> target)
		{
			bool flag = _cloningFunction != null;
			switch (target.OfferMessage(header, message, _owningSource, flag))
			{
			case DataflowMessageStatus.Accepted:
				if (!flag)
				{
					_targetRegistry.Remove(target, onlyIfReachedMaxMessages: true);
				}
				break;
			case DataflowMessageStatus.DecliningPermanently:
				_targetRegistry.Remove(target);
				break;
			case DataflowMessageStatus.Declined:
			case DataflowMessageStatus.Postponed:
			case DataflowMessageStatus.NotAvailable:
				break;
			}
		}

		private void OfferAsyncIfNecessary(bool isReplacementReplica = false)
		{
			bool flag = _taskForOutputProcessing != null;
			bool flag2 = _enableOffering && _messages.Count > 0;
			if (!(!flag && flag2) || CanceledOrFaulted)
			{
				return;
			}
			_taskForOutputProcessing = new Task(delegate(object thisSourceCore)
			{
				((BroadcastingSourceCore<TOutput>)thisSourceCore).OfferMessagesLoopCore();
			}, this, Common.GetCreationOptionsForTask(isReplacementReplica));
			DataflowEtwProvider log = DataflowEtwProvider.Log;
			if (log.IsEnabled())
			{
				log.TaskLaunchedForMessageHandling(_owningSource, _taskForOutputProcessing, DataflowEtwProvider.TaskLaunchedReason.OfferingOutputMessages, _messages.Count);
			}
			Exception ex = Common.StartTaskSafe(_taskForOutputProcessing, _dataflowBlockOptions.TaskScheduler);
			if (ex == null)
			{
				return;
			}
			AddException(ex);
			_decliningPermanently = true;
			_taskForOutputProcessing = null;
			Task.Factory.StartNew(delegate(object state)
			{
				BroadcastingSourceCore<TOutput> broadcastingSourceCore = (BroadcastingSourceCore<TOutput>)state;
				lock (broadcastingSourceCore.OutgoingLock)
				{
					lock (broadcastingSourceCore.ValueLock)
					{
						broadcastingSourceCore.CompleteBlockIfPossible();
					}
				}
			}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}

		private void OfferMessagesLoopCore()
		{
			try
			{
				int actualMaxMessagesPerTask = _dataflowBlockOptions.ActualMaxMessagesPerTask;
				lock (OutgoingLock)
				{
					for (int i = 0; i < actualMaxMessagesPerTask; i++)
					{
						if (CanceledOrFaulted)
						{
							break;
						}
						if (!OfferToTargets())
						{
							break;
						}
					}
				}
			}
			catch (Exception exception)
			{
				_owningSource.CompleteCore(exception, storeExceptionEvenIfAlreadyCompleting: true);
			}
			finally
			{
				lock (OutgoingLock)
				{
					lock (ValueLock)
					{
						_taskForOutputProcessing = null;
						OfferAsyncIfNecessary(isReplacementReplica: true);
						CompleteBlockIfPossible();
					}
				}
			}
		}

		private void CompleteBlockIfPossible()
		{
			if (!_completionReserved)
			{
				bool flag = _taskForOutputProcessing != null;
				bool flag2 = _decliningPermanently && _messages.Count == 0;
				if (!flag && (flag2 || CanceledOrFaulted))
				{
					CompleteBlockIfPossible_Slow();
				}
			}
		}

		private void CompleteBlockIfPossible_Slow()
		{
			_completionReserved = true;
			Task.Factory.StartNew(delegate(object thisSourceCore)
			{
				((BroadcastingSourceCore<TOutput>)thisSourceCore).CompleteBlockOncePossible();
			}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}

		private void CompleteBlockOncePossible()
		{
			TargetRegistry<TOutput>.LinkedTargetInfo firstTarget;
			List<Exception> exceptions;
			lock (OutgoingLock)
			{
				firstTarget = _targetRegistry.ClearEntryPoints();
				lock (ValueLock)
				{
					_messages.Clear();
					exceptions = _exceptions;
					_exceptions = null;
				}
			}
			if (exceptions != null)
			{
				_completionTask.TrySetException(exceptions);
			}
			else if (_dataflowBlockOptions.CancellationToken.IsCancellationRequested)
			{
				_completionTask.TrySetCanceled();
			}
			else
			{
				_completionTask.TrySetResult(default(VoidResult));
			}
			_targetRegistry.PropagateCompletion(firstTarget);
			DataflowEtwProvider log = DataflowEtwProvider.Log;
			if (log.IsEnabled())
			{
				log.DataflowBlockCompleted(_owningSource);
			}
		}

		internal IDisposable LinkTo(ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions)
		{
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (linkOptions == null)
			{
				throw new ArgumentNullException("linkOptions");
			}
			lock (OutgoingLock)
			{
				if (_completionReserved)
				{
					OfferCurrentMessageToNewTarget(target);
					if (linkOptions.PropagateCompletion)
					{
						Common.PropagateCompletionOnceCompleted(_completionTask.Task, target);
					}
					return Disposables.Nop;
				}
				_targetRegistry.Add(ref target, linkOptions);
				OfferCurrentMessageToNewTarget(target);
				return Common.CreateUnlinker(OutgoingLock, _targetRegistry, target);
			}
		}

		internal TOutput ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target, out bool messageConsumed)
		{
			if (!messageHeader.IsValid)
			{
				throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
			}
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			TOutput currentMessage;
			lock (OutgoingLock)
			{
				lock (ValueLock)
				{
					if (messageHeader.Id != _nextMessageId)
					{
						messageConsumed = false;
						return default(TOutput);
					}
					if (_nextMessageReservedFor == target)
					{
						_nextMessageReservedFor = null;
						_enableOffering = true;
					}
					_targetRegistry.Remove(target, onlyIfReachedMaxMessages: true);
					OfferAsyncIfNecessary();
					CompleteBlockIfPossible();
					currentMessage = _currentMessage;
				}
			}
			messageConsumed = true;
			return CloneItem(currentMessage);
		}

		internal bool ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target)
		{
			if (!messageHeader.IsValid)
			{
				throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
			}
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			lock (OutgoingLock)
			{
				if (_nextMessageReservedFor == null)
				{
					lock (ValueLock)
					{
						if (messageHeader.Id == _nextMessageId)
						{
							_nextMessageReservedFor = target;
							_enableOffering = false;
							return true;
						}
					}
				}
			}
			return false;
		}

		internal void ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target)
		{
			if (!messageHeader.IsValid)
			{
				throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
			}
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			lock (OutgoingLock)
			{
				if (_nextMessageReservedFor != target)
				{
					throw new InvalidOperationException(SR1.InvalidOperation_MessageNotReservedByTarget);
				}
				TOutput currentMessage;
				lock (ValueLock)
				{
					if (messageHeader.Id != _nextMessageId)
					{
						throw new InvalidOperationException(SR1.InvalidOperation_MessageNotReservedByTarget);
					}
					_nextMessageReservedFor = null;
					_enableOffering = true;
					currentMessage = _currentMessage;
					OfferAsyncIfNecessary();
				}
				OfferMessageToTarget(messageHeader, currentMessage, target);
			}
		}

		internal void AddException(Exception exception)
		{
			lock (ValueLock)
			{
				Common.AddException(ref _exceptions, exception);
			}
		}

		internal void AddExceptions(List<Exception> exceptions)
		{
			lock (ValueLock)
			{
				foreach (Exception exception in exceptions)
				{
					Common.AddException(ref _exceptions, exception);
				}
			}
		}

		internal DebuggingInformation GetDebuggingInformation()
		{
			return new DebuggingInformation(this);
		}
	}

	private readonly BroadcastingSourceCore<T> _source;

	private readonly BoundingStateWithPostponedAndTask<T> _boundingState;

	private bool _decliningPermanently;

	private bool _completionReserved;

	private object IncomingLock => _source;

	public Task Completion => _source.Completion;

	private bool HasValueForDebugger => _source.GetDebuggingInformation().HasValue;

	private T ValueForDebugger => _source.GetDebuggingInformation().Value;

	private object DebuggerDisplayContent => string.Format("{0}, HasValue={1}, Value={2}", new object[3]
	{
		Common.GetNameForDebugger(this, _source.DataflowBlockOptions),
		HasValueForDebugger,
		ValueForDebugger
	});

	object IDebuggerDisplay.Content => DebuggerDisplayContent;

	public BroadcastBlock(Func<T, T> cloningFunction)
		: this(cloningFunction, DataflowBlockOptions.Default)
	{
	}

	public BroadcastBlock(Func<T, T> cloningFunction, DataflowBlockOptions dataflowBlockOptions)
	{
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		dataflowBlockOptions = dataflowBlockOptions.DefaultOrClone();
		Action<int> itemsRemovedAction = null;
		if (dataflowBlockOptions.BoundedCapacity > 0)
		{
			itemsRemovedAction = OnItemsRemoved;
			_boundingState = new BoundingStateWithPostponedAndTask<T>(dataflowBlockOptions.BoundedCapacity);
		}
		_source = new BroadcastingSourceCore<T>(this, cloningFunction, dataflowBlockOptions, itemsRemovedAction);
		_source.Completion.ContinueWith(delegate(Task completed, object state)
		{
			IDataflowBlock dataflowBlock = (BroadcastBlock<T>)state;
			dataflowBlock.Fault(completed.Exception);
		}, this, CancellationToken.None, Common.GetContinuationOptions() | TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
		Common.WireCancellationToComplete(dataflowBlockOptions.CancellationToken, _source.Completion, delegate(object state)
		{
			((BroadcastBlock<T>)state).Complete();
		}, this);
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockCreated(this, dataflowBlockOptions);
		}
	}

	public void Complete()
	{
		CompleteCore(null, storeExceptionEvenIfAlreadyCompleting: false);
	}

	void IDataflowBlock.Fault(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		CompleteCore(exception, storeExceptionEvenIfAlreadyCompleting: false);
	}

	internal void CompleteCore(Exception exception, bool storeExceptionEvenIfAlreadyCompleting, bool revertProcessingState = false)
	{
		lock (IncomingLock)
		{
			if (exception != null && (!_decliningPermanently || storeExceptionEvenIfAlreadyCompleting))
			{
				_source.AddException(exception);
			}
			if (revertProcessingState)
			{
				_boundingState.TaskForInputProcessing = null;
			}
			_decliningPermanently = true;
			CompleteTargetIfPossible();
		}
	}

	public IDisposable LinkTo(ITargetBlock<T> target, DataflowLinkOptions linkOptions)
	{
		return _source.LinkTo(target, linkOptions);
	}

	public bool TryReceive(Predicate<T> filter, out T item)
	{
		return _source.TryReceive(filter, out item);
	}

	bool IReceivableSourceBlock<T>.TryReceiveAll(out IList<T> items)
	{
		return _source.TryReceiveAll(out items);
	}

	DataflowMessageStatus ITargetBlock<T>.OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept)
	{
		if (!messageHeader.IsValid)
		{
			throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
		}
		if (source == null && consumeToAccept)
		{
			throw new ArgumentException(SR1.Argument_CantConsumeFromANullSource, "consumeToAccept");
		}
		lock (IncomingLock)
		{
			if (_decliningPermanently)
			{
				CompleteTargetIfPossible();
				return DataflowMessageStatus.DecliningPermanently;
			}
			if (_boundingState != null && (!_boundingState.CountIsLessThanBound || _boundingState.PostponedMessages.Count != 0 || _boundingState.TaskForInputProcessing != null))
			{
				if (source != null)
				{
					_boundingState.PostponedMessages.Push(source, messageHeader);
					return DataflowMessageStatus.Postponed;
				}
				return DataflowMessageStatus.Declined;
			}
			if (consumeToAccept)
			{
				messageValue = source.ConsumeMessage(messageHeader, this, out var messageConsumed);
				if (!messageConsumed)
				{
					return DataflowMessageStatus.NotAvailable;
				}
			}
			_source.AddMessage(messageValue);
			if (_boundingState != null)
			{
				_boundingState.CurrentCount++;
			}
			return DataflowMessageStatus.Accepted;
		}
	}

	private void OnItemsRemoved(int numItemsRemoved)
	{
		if (_boundingState != null)
		{
			lock (IncomingLock)
			{
				_boundingState.CurrentCount -= numItemsRemoved;
				ConsumeAsyncIfNecessary();
				CompleteTargetIfPossible();
			}
		}
	}

	internal void ConsumeAsyncIfNecessary(bool isReplacementReplica = false)
	{
		if (_decliningPermanently || _boundingState.TaskForInputProcessing != null || _boundingState.PostponedMessages.Count <= 0 || !_boundingState.CountIsLessThanBound)
		{
			return;
		}
		_boundingState.TaskForInputProcessing = new Task(delegate(object state)
		{
			((BroadcastBlock<T>)state).ConsumeMessagesLoopCore();
		}, this, Common.GetCreationOptionsForTask(isReplacementReplica));
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.TaskLaunchedForMessageHandling(this, _boundingState.TaskForInputProcessing, DataflowEtwProvider.TaskLaunchedReason.ProcessingInputMessages, _boundingState.PostponedMessages.Count);
		}
		Exception ex = Common.StartTaskSafe(_boundingState.TaskForInputProcessing, _source.DataflowBlockOptions.TaskScheduler);
		if (ex != null)
		{
			Task.Factory.StartNew(delegate(object exc)
			{
				CompleteCore((Exception)exc, storeExceptionEvenIfAlreadyCompleting: true, revertProcessingState: true);
			}, ex, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}
	}

	private void ConsumeMessagesLoopCore()
	{
		try
		{
			int actualMaxMessagesPerTask = _source.DataflowBlockOptions.ActualMaxMessagesPerTask;
			for (int i = 0; i < actualMaxMessagesPerTask; i++)
			{
				if (!ConsumeAndStoreOneMessageIfAvailable())
				{
					break;
				}
			}
		}
		catch (Exception exception)
		{
			CompleteCore(exception, storeExceptionEvenIfAlreadyCompleting: true);
		}
		finally
		{
			lock (IncomingLock)
			{
				_boundingState.TaskForInputProcessing = null;
				ConsumeAsyncIfNecessary(isReplacementReplica: true);
				CompleteTargetIfPossible();
			}
		}
	}

	private bool ConsumeAndStoreOneMessageIfAvailable()
	{
		while (true)
		{
			KeyValuePair<ISourceBlock<T>, DataflowMessageHeader> item;
			lock (IncomingLock)
			{
				if (!_boundingState.CountIsLessThanBound)
				{
					return false;
				}
				if (!_boundingState.PostponedMessages.TryPop(out item))
				{
					return false;
				}
				_boundingState.CurrentCount++;
			}
			bool messageConsumed = false;
			try
			{
				T item2 = item.Key.ConsumeMessage(item.Value, this, out messageConsumed);
				if (messageConsumed)
				{
					_source.AddMessage(item2);
					return true;
				}
			}
			finally
			{
				if (!messageConsumed)
				{
					lock (IncomingLock)
					{
						_boundingState.CurrentCount--;
					}
				}
			}
		}
	}

	private void CompleteTargetIfPossible()
	{
		if (!_decliningPermanently || _completionReserved || (_boundingState != null && _boundingState.TaskForInputProcessing != null))
		{
			return;
		}
		_completionReserved = true;
		if (_boundingState != null && _boundingState.PostponedMessages.Count > 0)
		{
			Task.Factory.StartNew(delegate(object state)
			{
				BroadcastBlock<T> broadcastBlock = (BroadcastBlock<T>)state;
				List<Exception> exceptions = null;
				if (broadcastBlock._boundingState != null)
				{
					Common.ReleaseAllPostponedMessages(broadcastBlock, broadcastBlock._boundingState.PostponedMessages, ref exceptions);
				}
				if (exceptions != null)
				{
					broadcastBlock._source.AddExceptions(exceptions);
				}
				broadcastBlock._source.Complete();
			}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}
		else
		{
			_source.Complete();
		}
	}

	T ISourceBlock<T>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target, out bool messageConsumed)
	{
		return _source.ConsumeMessage(messageHeader, target, out messageConsumed);
	}

	bool ISourceBlock<T>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target)
	{
		return _source.ReserveMessage(messageHeader, target);
	}

	void ISourceBlock<T>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<T> target)
	{
		_source.ReleaseReservation(messageHeader, target);
	}

	public override string ToString()
	{
		return Common.GetNameForDebugger(this, _source.DataflowBlockOptions);
	}
}
