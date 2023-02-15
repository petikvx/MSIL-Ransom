using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow.Internal;

namespace System.Threading.Tasks.Dataflow;

[DebuggerTypeProxy(typeof(BufferBlock<>.DebugView))]
[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
public sealed class BufferBlock<T> : IPropagatorBlock<T, T>, ITargetBlock<T>, ISourceBlock<T>, IReceivableSourceBlock<T>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class DebugView
	{
		private readonly BufferBlock<T> _bufferBlock;

		private readonly SourceCore<T>.DebuggingInformation _sourceDebuggingInformation;

		public QueuedMap<ISourceBlock<T>, DataflowMessageHeader> PostponedMessages
		{
			get
			{
				if (_bufferBlock._boundingState == null)
				{
					return null;
				}
				return _bufferBlock._boundingState.PostponedMessages;
			}
		}

		public IEnumerable<T> Queue => _sourceDebuggingInformation.OutputQueue;

		public Task TaskForInputProcessing
		{
			get
			{
				if (_bufferBlock._boundingState == null)
				{
					return null;
				}
				return _bufferBlock._boundingState.TaskForInputProcessing;
			}
		}

		public Task TaskForOutputProcessing => _sourceDebuggingInformation.TaskForOutputProcessing;

		public DataflowBlockOptions DataflowBlockOptions => _sourceDebuggingInformation.DataflowBlockOptions;

		public bool IsDecliningPermanently => _bufferBlock._targetDecliningPermanently;

		public bool IsCompleted => _sourceDebuggingInformation.IsCompleted;

		public int Id => Common.GetBlockId(_bufferBlock);

		public TargetRegistry<T> LinkedTargets => _sourceDebuggingInformation.LinkedTargets;

		public ITargetBlock<T> NextMessageReservedFor => _sourceDebuggingInformation.NextMessageReservedFor;

		public DebugView(BufferBlock<T> bufferBlock)
		{
			_bufferBlock = bufferBlock;
			_sourceDebuggingInformation = bufferBlock._source.GetDebuggingInformation();
		}
	}

	private readonly SourceCore<T> _source;

	private readonly BoundingStateWithPostponedAndTask<T> _boundingState;

	private bool _targetDecliningPermanently;

	private bool _targetCompletionReserved;

	private object IncomingLock => _source;

	public int Count => _source.OutputCount;

	public Task Completion => _source.Completion;

	private int CountForDebugger => _source.GetDebuggingInformation().OutputCount;

	private object DebuggerDisplayContent => string.Format("{0}, Count={1}", new object[2]
	{
		Common.GetNameForDebugger(this, _source.DataflowBlockOptions),
		CountForDebugger
	});

	object IDebuggerDisplay.Content => DebuggerDisplayContent;

	public BufferBlock()
		: this(DataflowBlockOptions.Default)
	{
	}

	public BufferBlock(DataflowBlockOptions dataflowBlockOptions)
	{
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		dataflowBlockOptions = dataflowBlockOptions.DefaultOrClone();
		Action<ISourceBlock<T>, int> itemsRemovedAction = null;
		if (dataflowBlockOptions.BoundedCapacity > 0)
		{
			itemsRemovedAction = delegate(ISourceBlock<T> owningSource, int count)
			{
				((BufferBlock<T>)owningSource).OnItemsRemoved(count);
			};
			_boundingState = new BoundingStateWithPostponedAndTask<T>(dataflowBlockOptions.BoundedCapacity);
		}
		_source = new SourceCore<T>(this, dataflowBlockOptions, delegate(ISourceBlock<T> owningSource)
		{
			((BufferBlock<T>)owningSource).Complete();
		}, itemsRemovedAction);
		_source.Completion.ContinueWith(delegate(Task completed, object state)
		{
			IDataflowBlock dataflowBlock = (BufferBlock<T>)state;
			dataflowBlock.Fault(completed.Exception);
		}, this, CancellationToken.None, Common.GetContinuationOptions() | TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
		Common.WireCancellationToComplete(dataflowBlockOptions.CancellationToken, _source.Completion, delegate(object owningSource)
		{
			((BufferBlock<T>)owningSource).Complete();
		}, this);
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockCreated(this, dataflowBlockOptions);
		}
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
			if (_targetDecliningPermanently)
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

	private void CompleteCore(Exception exception, bool storeExceptionEvenIfAlreadyCompleting, bool revertProcessingState = false)
	{
		lock (IncomingLock)
		{
			if (exception != null && (!_targetDecliningPermanently || storeExceptionEvenIfAlreadyCompleting))
			{
				_source.AddException(exception);
			}
			if (revertProcessingState)
			{
				_boundingState.TaskForInputProcessing = null;
			}
			_targetDecliningPermanently = true;
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

	public bool TryReceiveAll(out IList<T> items)
	{
		return _source.TryReceiveAll(out items);
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
		if (_targetDecliningPermanently || _boundingState.TaskForInputProcessing != null || _boundingState.PostponedMessages.Count <= 0 || !_boundingState.CountIsLessThanBound)
		{
			return;
		}
		_boundingState.TaskForInputProcessing = new Task(delegate(object state)
		{
			((BufferBlock<T>)state).ConsumeMessagesLoopCore();
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
				if (_targetDecliningPermanently)
				{
					return false;
				}
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
		if (!_targetDecliningPermanently || _targetCompletionReserved || (_boundingState != null && _boundingState.TaskForInputProcessing != null))
		{
			return;
		}
		_targetCompletionReserved = true;
		if (_boundingState != null && _boundingState.PostponedMessages.Count > 0)
		{
			Task.Factory.StartNew(delegate(object state)
			{
				BufferBlock<T> bufferBlock = (BufferBlock<T>)state;
				List<Exception> exceptions = null;
				if (bufferBlock._boundingState != null)
				{
					Common.ReleaseAllPostponedMessages(bufferBlock, bufferBlock._boundingState.PostponedMessages, ref exceptions);
				}
				if (exceptions != null)
				{
					bufferBlock._source.AddExceptions(exceptions);
				}
				bufferBlock._source.Complete();
			}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}
		else
		{
			_source.Complete();
		}
	}

	public override string ToString()
	{
		return Common.GetNameForDebugger(this, _source.DataflowBlockOptions);
	}
}
