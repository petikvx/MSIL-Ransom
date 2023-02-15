using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace System.Threading.Tasks.Dataflow.Internal;

[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
internal sealed class SourceCore<TOutput>
{
	internal sealed class DebuggingInformation
	{
		private SourceCore<TOutput> _source;

		internal int OutputCount => _source._messages.Count;

		internal IEnumerable<TOutput> OutputQueue => Enumerable.ToList(_source._messages);

		internal Task TaskForOutputProcessing => _source._taskForOutputProcessing;

		internal DataflowBlockOptions DataflowBlockOptions => _source._dataflowBlockOptions;

		internal bool IsCompleted => _source.Completion.IsCompleted;

		internal TargetRegistry<TOutput> LinkedTargets => _source._targetRegistry;

		internal ITargetBlock<TOutput> NextMessageReservedFor => _source._nextMessageReservedFor;

		internal DebuggingInformation(SourceCore<TOutput> source)
		{
			_source = source;
		}
	}

	private readonly TaskCompletionSource<VoidResult> _completionTask = new TaskCompletionSource<VoidResult>();

	private readonly TargetRegistry<TOutput> _targetRegistry;

	private readonly SingleProducerSingleConsumerQueue<TOutput> _messages = new SingleProducerSingleConsumerQueue<TOutput>();

	private readonly ISourceBlock<TOutput> _owningSource;

	private readonly DataflowBlockOptions _dataflowBlockOptions;

	private readonly Action<ISourceBlock<TOutput>> _completeAction;

	private readonly Action<ISourceBlock<TOutput>, int> _itemsRemovedAction;

	private readonly Func<ISourceBlock<TOutput>, TOutput, IList<TOutput>, int> _itemCountingFunc;

	private Task _taskForOutputProcessing;

	private PaddedInt64 _nextMessageId = new PaddedInt64
	{
		Value = 1L
	};

	private ITargetBlock<TOutput> _nextMessageReservedFor;

	private bool _decliningPermanently;

	private bool _enableOffering = true;

	private bool _completionReserved;

	private List<Exception> _exceptions;

	private object OutgoingLock => _completionTask;

	private object ValueLock => _targetRegistry;

	internal Task Completion => _completionTask.Task;

	internal int OutputCount
	{
		get
		{
			lock (OutgoingLock)
			{
				lock (ValueLock)
				{
					return _messages.Count;
				}
			}
		}
	}

	internal bool HasExceptions => Volatile.Read(ref _exceptions) != null;

	internal DataflowBlockOptions DataflowBlockOptions => _dataflowBlockOptions;

	private bool CanceledOrFaulted
	{
		get
		{
			if (!_dataflowBlockOptions.CancellationToken.IsCancellationRequested)
			{
				if (HasExceptions)
				{
					return _decliningPermanently;
				}
				return false;
			}
			return true;
		}
	}

	private object DebuggerDisplayContent
	{
		get
		{
			IDebuggerDisplay debuggerDisplay = _owningSource as IDebuggerDisplay;
			return $"Block=\"{((debuggerDisplay != null) ? debuggerDisplay.Content : _owningSource)}\"";
		}
	}

	internal SourceCore(ISourceBlock<TOutput> owningSource, DataflowBlockOptions dataflowBlockOptions, Action<ISourceBlock<TOutput>> completeAction, Action<ISourceBlock<TOutput>, int> itemsRemovedAction = null, Func<ISourceBlock<TOutput>, TOutput, IList<TOutput>, int> itemCountingFunc = null)
	{
		_owningSource = owningSource;
		_dataflowBlockOptions = dataflowBlockOptions;
		_itemsRemovedAction = itemsRemovedAction;
		_itemCountingFunc = itemCountingFunc;
		_completeAction = completeAction;
		_targetRegistry = new TargetRegistry<TOutput>(_owningSource);
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
		if (_completionTask.Task.IsCompleted)
		{
			if (linkOptions.PropagateCompletion)
			{
				Common.PropagateCompletion(_completionTask.Task, target, null);
			}
			return Disposables.Nop;
		}
		lock (OutgoingLock)
		{
			if (!_completionReserved)
			{
				_targetRegistry.Add(ref target, linkOptions);
				OfferToTargets(target);
				return Common.CreateUnlinker(OutgoingLock, _targetRegistry, target);
			}
		}
		if (linkOptions.PropagateCompletion)
		{
			Common.PropagateCompletionOnceCompleted(_completionTask.Task, target);
		}
		return Disposables.Nop;
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
		TOutput result = default(TOutput);
		lock (OutgoingLock)
		{
			if (_nextMessageReservedFor != target && _nextMessageReservedFor != null)
			{
				messageConsumed = false;
				return default(TOutput);
			}
			lock (ValueLock)
			{
				if (messageHeader.Id != _nextMessageId.Value || !_messages.TryDequeue(out result))
				{
					messageConsumed = false;
					return default(TOutput);
				}
				_nextMessageReservedFor = null;
				_targetRegistry.Remove(target, onlyIfReachedMaxMessages: true);
				_enableOffering = true;
				_nextMessageId.Value++;
				CompleteBlockIfPossible();
				OfferAsyncIfNecessary(isReplacementReplica: false, outgoingLockKnownAcquired: true);
			}
		}
		if (_itemsRemovedAction != null)
		{
			int arg = ((_itemCountingFunc == null) ? 1 : _itemCountingFunc(_owningSource, result, null));
			_itemsRemovedAction(_owningSource, arg);
		}
		messageConsumed = true;
		return result;
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
					if (messageHeader.Id == _nextMessageId.Value && !_messages.IsEmpty)
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
			lock (ValueLock)
			{
				if (messageHeader.Id != _nextMessageId.Value || _messages.IsEmpty)
				{
					throw new InvalidOperationException(SR1.InvalidOperation_MessageNotReservedByTarget);
				}
				_nextMessageReservedFor = null;
				_enableOffering = true;
				OfferAsyncIfNecessary(isReplacementReplica: false, outgoingLockKnownAcquired: true);
				CompleteBlockIfPossible();
			}
		}
	}

	internal bool TryReceive(Predicate<TOutput> filter, out TOutput item)
	{
		item = default(TOutput);
		bool flag = false;
		lock (OutgoingLock)
		{
			if (_nextMessageReservedFor == null)
			{
				lock (ValueLock)
				{
					if (_messages.TryDequeueIf(filter, out item))
					{
						_nextMessageId.Value++;
						_enableOffering = true;
						CompleteBlockIfPossible();
						OfferAsyncIfNecessary(isReplacementReplica: false, outgoingLockKnownAcquired: true);
						flag = true;
					}
				}
			}
		}
		if (flag && _itemsRemovedAction != null)
		{
			int arg = ((_itemCountingFunc == null) ? 1 : _itemCountingFunc(_owningSource, item, null));
			_itemsRemovedAction(_owningSource, arg);
		}
		return flag;
	}

	internal bool TryReceiveAll(out IList<TOutput> items)
	{
		items = null;
		int num = 0;
		lock (OutgoingLock)
		{
			if (_nextMessageReservedFor == null)
			{
				lock (ValueLock)
				{
					if (!_messages.IsEmpty)
					{
						List<TOutput> list = new List<TOutput>();
						TOutput result;
						while (_messages.TryDequeue(out result))
						{
							list.Add(result);
						}
						num = list.Count;
						items = list;
						_nextMessageId.Value++;
						_enableOffering = true;
						CompleteBlockIfPossible();
					}
				}
			}
		}
		if (num > 0)
		{
			if (_itemsRemovedAction != null)
			{
				int arg = ((_itemCountingFunc != null) ? _itemCountingFunc(_owningSource, default(TOutput), items) : num);
				_itemsRemovedAction(_owningSource, arg);
			}
			return true;
		}
		return false;
	}

	internal void AddMessage(TOutput item)
	{
		if (!_decliningPermanently)
		{
			_messages.Enqueue(item);
			Interlocked.MemoryBarrier();
			if (_taskForOutputProcessing == null)
			{
				OfferAsyncIfNecessaryWithValueLock();
			}
		}
	}

	internal void AddMessages(IEnumerable<TOutput> items)
	{
		if (_decliningPermanently)
		{
			return;
		}
		if (items is List<TOutput> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				_messages.Enqueue(list[i]);
			}
		}
		else if (items is TOutput[] array)
		{
			for (int j = 0; j < array.Length; j++)
			{
				_messages.Enqueue(array[j]);
			}
		}
		else
		{
			foreach (TOutput item in items)
			{
				_messages.Enqueue(item);
			}
		}
		Interlocked.MemoryBarrier();
		if (_taskForOutputProcessing == null)
		{
			OfferAsyncIfNecessaryWithValueLock();
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

	internal void AddAndUnwrapAggregateException(AggregateException aggregateException)
	{
		lock (ValueLock)
		{
			Common.AddException(ref _exceptions, aggregateException, unwrapInnerExceptions: true);
		}
	}

	internal void Complete()
	{
		lock (ValueLock)
		{
			_decliningPermanently = true;
			Task.Factory.StartNew(delegate(object state)
			{
				SourceCore<TOutput> sourceCore = (SourceCore<TOutput>)state;
				lock (sourceCore.OutgoingLock)
				{
					lock (sourceCore.ValueLock)
					{
						sourceCore.CompleteBlockIfPossible();
					}
				}
			}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}
	}

	private bool OfferToTargets(ITargetBlock<TOutput> linkToTarget = null)
	{
		if (_nextMessageReservedFor != null)
		{
			return false;
		}
		DataflowMessageHeader header = default(DataflowMessageHeader);
		TOutput result = default(TOutput);
		bool flag = false;
		if (!Volatile.Read(ref _enableOffering))
		{
			if (linkToTarget == null)
			{
				return false;
			}
			flag = true;
		}
		if (_messages.TryPeek(out result))
		{
			header = new DataflowMessageHeader(_nextMessageId.Value);
		}
		bool messageWasAccepted = false;
		if (header.IsValid)
		{
			if (flag)
			{
				OfferMessageToTarget(header, result, linkToTarget, out messageWasAccepted);
			}
			else
			{
				TargetRegistry<TOutput>.LinkedTargetInfo linkedTargetInfo = _targetRegistry.FirstTargetNode;
				while (linkedTargetInfo != null)
				{
					TargetRegistry<TOutput>.LinkedTargetInfo next = linkedTargetInfo.Next;
					if (OfferMessageToTarget(header, result, linkedTargetInfo.Target, out messageWasAccepted))
					{
						break;
					}
					linkedTargetInfo = next;
				}
				if (!messageWasAccepted)
				{
					lock (ValueLock)
					{
						_enableOffering = false;
					}
				}
			}
		}
		if (messageWasAccepted)
		{
			lock (ValueLock)
			{
				if (_nextMessageId.Value == header.Id)
				{
					_messages.TryDequeue(out var _);
				}
				_nextMessageId.Value++;
				_enableOffering = true;
				if (linkToTarget != null)
				{
					CompleteBlockIfPossible();
					OfferAsyncIfNecessary(isReplacementReplica: false, outgoingLockKnownAcquired: true);
				}
			}
			if (_itemsRemovedAction != null)
			{
				int arg = ((_itemCountingFunc == null) ? 1 : _itemCountingFunc(_owningSource, result, null));
				_itemsRemovedAction(_owningSource, arg);
			}
		}
		return messageWasAccepted;
	}

	private bool OfferMessageToTarget(DataflowMessageHeader header, TOutput message, ITargetBlock<TOutput> target, out bool messageWasAccepted)
	{
		DataflowMessageStatus dataflowMessageStatus = target.OfferMessage(header, message, _owningSource, consumeToAccept: false);
		messageWasAccepted = false;
		switch (dataflowMessageStatus)
		{
		case DataflowMessageStatus.Accepted:
			_targetRegistry.Remove(target, onlyIfReachedMaxMessages: true);
			messageWasAccepted = true;
			return true;
		case DataflowMessageStatus.DecliningPermanently:
			_targetRegistry.Remove(target);
			break;
		default:
			if (_nextMessageReservedFor != null)
			{
				return true;
			}
			break;
		}
		return false;
	}

	private void OfferAsyncIfNecessaryWithValueLock()
	{
		lock (ValueLock)
		{
			OfferAsyncIfNecessary(isReplacementReplica: false, outgoingLockKnownAcquired: false);
		}
	}

	private void OfferAsyncIfNecessary(bool isReplacementReplica, bool outgoingLockKnownAcquired)
	{
		if (_taskForOutputProcessing == null && _enableOffering && !_messages.IsEmpty)
		{
			OfferAsyncIfNecessary_Slow(isReplacementReplica, outgoingLockKnownAcquired);
		}
	}

	private void OfferAsyncIfNecessary_Slow(bool isReplacementReplica, bool outgoingLockKnownAcquired)
	{
		bool flag = true;
		if (outgoingLockKnownAcquired || Monitor.IsEntered(OutgoingLock))
		{
			flag = _targetRegistry.FirstTargetNode != null;
		}
		if (!flag || CanceledOrFaulted)
		{
			return;
		}
		_taskForOutputProcessing = new Task(delegate(object thisSourceCore)
		{
			((SourceCore<TOutput>)thisSourceCore).OfferMessagesLoopCore();
		}, this, Common.GetCreationOptionsForTask(isReplacementReplica));
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.TaskLaunchedForMessageHandling(_owningSource, _taskForOutputProcessing, DataflowEtwProvider.TaskLaunchedReason.OfferingOutputMessages, _messages.Count);
		}
		Exception ex = Common.StartTaskSafe(_taskForOutputProcessing, _dataflowBlockOptions.TaskScheduler);
		if (ex != null)
		{
			AddException(ex);
			_taskForOutputProcessing = null;
			_decliningPermanently = true;
			Task.Factory.StartNew(delegate(object state)
			{
				SourceCore<TOutput> sourceCore = (SourceCore<TOutput>)state;
				lock (sourceCore.OutgoingLock)
				{
					lock (sourceCore.ValueLock)
					{
						sourceCore.CompleteBlockIfPossible();
					}
				}
			}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}
		if (ex != null)
		{
			AddException(ex);
		}
	}

	private void OfferMessagesLoopCore()
	{
		try
		{
			int actualMaxMessagesPerTask = _dataflowBlockOptions.ActualMaxMessagesPerTask;
			int num = ((_dataflowBlockOptions.MaxMessagesPerTask == -1) ? 10 : actualMaxMessagesPerTask);
			int num2 = 0;
			while (num2 < actualMaxMessagesPerTask && !CanceledOrFaulted)
			{
				lock (OutgoingLock)
				{
					int num3 = 0;
					while (num2 < actualMaxMessagesPerTask && num3 < num && !CanceledOrFaulted)
					{
						if (OfferToTargets())
						{
							num2++;
							num3++;
							continue;
						}
						return;
					}
				}
			}
		}
		catch (Exception exception)
		{
			AddException(exception);
			_completeAction(_owningSource);
		}
		finally
		{
			lock (OutgoingLock)
			{
				lock (ValueLock)
				{
					_taskForOutputProcessing = null;
					Interlocked.MemoryBarrier();
					OfferAsyncIfNecessary(isReplacementReplica: true, outgoingLockKnownAcquired: true);
					CompleteBlockIfPossible();
				}
			}
		}
	}

	private void CompleteBlockIfPossible()
	{
		if (!_completionReserved && _decliningPermanently && _taskForOutputProcessing == null && _nextMessageReservedFor == null)
		{
			CompleteBlockIfPossible_Slow();
		}
	}

	private void CompleteBlockIfPossible_Slow()
	{
		if (_messages.IsEmpty || CanceledOrFaulted)
		{
			_completionReserved = true;
			Task.Factory.StartNew(delegate(object state)
			{
				((SourceCore<TOutput>)state).CompleteBlockOncePossible();
			}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}
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

	internal DebuggingInformation GetDebuggingInformation()
	{
		return new DebuggingInformation(this);
	}
}
