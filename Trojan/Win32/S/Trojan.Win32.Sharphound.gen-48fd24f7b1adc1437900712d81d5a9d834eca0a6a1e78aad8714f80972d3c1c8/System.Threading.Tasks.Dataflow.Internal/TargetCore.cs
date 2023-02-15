using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace System.Threading.Tasks.Dataflow.Internal;

[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
internal sealed class TargetCore<TInput>
{
	internal sealed class DebuggingInformation
	{
		private readonly TargetCore<TInput> _target;

		internal int InputCount => _target._messages.Count;

		internal IEnumerable<TInput> InputQueue => Enumerable.ToList(Enumerable.Select(_target._messages, (KeyValuePair<TInput, long> kvp) => kvp.Key));

		internal QueuedMap<ISourceBlock<TInput>, DataflowMessageHeader> PostponedMessages
		{
			get
			{
				if (_target._boundingState == null)
				{
					return null;
				}
				return _target._boundingState.PostponedMessages;
			}
		}

		internal int CurrentDegreeOfParallelism => _target._numberOfOutstandingOperations - _target._numberOfOutstandingServiceTasks;

		internal ExecutionDataflowBlockOptions DataflowBlockOptions => _target._dataflowBlockOptions;

		internal bool IsDecliningPermanently => _target._decliningPermanently;

		internal bool IsCompleted => _target.Completion.IsCompleted;

		internal DebuggingInformation(TargetCore<TInput> target)
		{
			_target = target;
		}
	}

	private static readonly Common.KeepAlivePredicate<TargetCore<TInput>, KeyValuePair<TInput, long>> _keepAlivePredicate = delegate(TargetCore<TInput> thisTargetCore, out KeyValuePair<TInput, long> messageWithId)
	{
		return thisTargetCore.TryGetNextAvailableOrPostponedMessage(out messageWithId);
	};

	private readonly TaskCompletionSource<VoidResult> _completionSource = new TaskCompletionSource<VoidResult>();

	private readonly ITargetBlock<TInput> _owningTarget;

	private readonly IProducerConsumerQueue<KeyValuePair<TInput, long>> _messages;

	private readonly ExecutionDataflowBlockOptions _dataflowBlockOptions;

	private readonly Action<KeyValuePair<TInput, long>> _callAction;

	private readonly TargetCoreOptions _targetCoreOptions;

	private readonly BoundingStateWithPostponed<TInput> _boundingState;

	private readonly IReorderingBuffer _reorderingBuffer;

	private List<Exception> _exceptions;

	private bool _decliningPermanently;

	private int _numberOfOutstandingOperations;

	private int _numberOfOutstandingServiceTasks;

	private PaddedInt64 _nextAvailableInputMessageId;

	private bool _completionReserved;

	private int _keepAliveBanCounter;

	private object IncomingLock => _messages;

	internal Task Completion => _completionSource.Task;

	internal int InputCount => _messages.GetCountSafe(IncomingLock);

	private bool UsesAsyncCompletion => (_targetCoreOptions & TargetCoreOptions.UsesAsyncCompletion) != 0;

	private bool HasRoomForMoreOperations => _numberOfOutstandingOperations - _numberOfOutstandingServiceTasks < _dataflowBlockOptions.ActualMaxDegreeOfParallelism;

	private bool HasRoomForMoreServiceTasks
	{
		get
		{
			if (!UsesAsyncCompletion)
			{
				return HasRoomForMoreOperations;
			}
			if (HasRoomForMoreOperations)
			{
				return _numberOfOutstandingServiceTasks < _dataflowBlockOptions.ActualMaxDegreeOfParallelism;
			}
			return false;
		}
	}

	private bool CanceledOrFaulted
	{
		get
		{
			if (!_dataflowBlockOptions.CancellationToken.IsCancellationRequested)
			{
				return Volatile.Read(ref _exceptions) != null;
			}
			return true;
		}
	}

	internal bool IsBounded => _boundingState != null;

	private object DebuggerDisplayContent
	{
		get
		{
			IDebuggerDisplay debuggerDisplay = _owningTarget as IDebuggerDisplay;
			return $"Block=\"{((debuggerDisplay != null) ? debuggerDisplay.Content : _owningTarget)}\"";
		}
	}

	internal ExecutionDataflowBlockOptions DataflowBlockOptions => _dataflowBlockOptions;

	internal TargetCore(ITargetBlock<TInput> owningTarget, Action<KeyValuePair<TInput, long>> callAction, IReorderingBuffer reorderingBuffer, ExecutionDataflowBlockOptions dataflowBlockOptions, TargetCoreOptions targetCoreOptions)
	{
		_owningTarget = owningTarget;
		_callAction = callAction;
		_reorderingBuffer = reorderingBuffer;
		_dataflowBlockOptions = dataflowBlockOptions;
		_targetCoreOptions = targetCoreOptions;
		IProducerConsumerQueue<KeyValuePair<TInput, long>> messages;
		if (dataflowBlockOptions.MaxDegreeOfParallelism != 1)
		{
			IProducerConsumerQueue<KeyValuePair<TInput, long>> producerConsumerQueue = new MultiProducerMultiConsumerQueue<KeyValuePair<TInput, long>>();
			messages = producerConsumerQueue;
		}
		else
		{
			IProducerConsumerQueue<KeyValuePair<TInput, long>> producerConsumerQueue = new SingleProducerSingleConsumerQueue<KeyValuePair<TInput, long>>();
			messages = producerConsumerQueue;
		}
		_messages = messages;
		if (_dataflowBlockOptions.BoundedCapacity != -1)
		{
			_boundingState = new BoundingStateWithPostponed<TInput>(_dataflowBlockOptions.BoundedCapacity);
		}
	}

	internal void Complete(Exception exception, bool dropPendingMessages, bool storeExceptionEvenIfAlreadyCompleting = false, bool unwrapInnerExceptions = false, bool revertProcessingState = false)
	{
		lock (IncomingLock)
		{
			if (exception != null && (!_decliningPermanently || storeExceptionEvenIfAlreadyCompleting))
			{
				Common.AddException(ref _exceptions, exception, unwrapInnerExceptions);
			}
			if (dropPendingMessages)
			{
				KeyValuePair<TInput, long> result;
				while (_messages.TryDequeue(out result))
				{
				}
			}
			if (revertProcessingState)
			{
				_numberOfOutstandingOperations--;
				if (UsesAsyncCompletion)
				{
					_numberOfOutstandingServiceTasks--;
				}
			}
			_decliningPermanently = true;
			CompleteBlockIfPossible();
		}
	}

	internal DataflowMessageStatus OfferMessage(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept)
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
				CompleteBlockIfPossible();
				return DataflowMessageStatus.DecliningPermanently;
			}
			if (_boundingState != null && (_boundingState.OutstandingTransfers != 0 || !_boundingState.CountIsLessThanBound || _boundingState.PostponedMessages.Count != 0))
			{
				if (source != null)
				{
					_boundingState.PostponedMessages.Push(source, messageHeader);
					ProcessAsyncIfNecessary();
					return DataflowMessageStatus.Postponed;
				}
				return DataflowMessageStatus.Declined;
			}
			if (consumeToAccept)
			{
				messageValue = source.ConsumeMessage(messageHeader, _owningTarget, out var messageConsumed);
				if (!messageConsumed)
				{
					return DataflowMessageStatus.NotAvailable;
				}
			}
			long value = _nextAvailableInputMessageId.Value++;
			if (_boundingState != null)
			{
				_boundingState.CurrentCount++;
			}
			_messages.Enqueue(new KeyValuePair<TInput, long>(messageValue, value));
			ProcessAsyncIfNecessary();
			return DataflowMessageStatus.Accepted;
		}
	}

	internal void SignalOneAsyncMessageCompleted()
	{
		SignalOneAsyncMessageCompleted(0);
	}

	internal void SignalOneAsyncMessageCompleted(int boundingCountChange)
	{
		lock (IncomingLock)
		{
			if (_numberOfOutstandingOperations > 0)
			{
				_numberOfOutstandingOperations--;
			}
			if (_boundingState != null && boundingCountChange != 0)
			{
				_boundingState.CurrentCount += boundingCountChange;
			}
			ProcessAsyncIfNecessary(repeat: true);
			CompleteBlockIfPossible();
		}
	}

	private void ProcessAsyncIfNecessary(bool repeat = false)
	{
		if (HasRoomForMoreServiceTasks)
		{
			ProcessAsyncIfNecessary_Slow(repeat);
		}
	}

	private void ProcessAsyncIfNecessary_Slow(bool repeat)
	{
		if ((_messages.IsEmpty && (_decliningPermanently || _boundingState == null || !_boundingState.CountIsLessThanBound || _boundingState.PostponedMessages.Count <= 0)) || CanceledOrFaulted)
		{
			return;
		}
		_numberOfOutstandingOperations++;
		if (UsesAsyncCompletion)
		{
			_numberOfOutstandingServiceTasks++;
		}
		Task task = new Task(delegate(object thisTargetCore)
		{
			((TargetCore<TInput>)thisTargetCore).ProcessMessagesLoopCore();
		}, this, Common.GetCreationOptionsForTask(repeat));
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.TaskLaunchedForMessageHandling(_owningTarget, task, DataflowEtwProvider.TaskLaunchedReason.ProcessingInputMessages, _messages.Count + ((_boundingState != null) ? _boundingState.PostponedMessages.Count : 0));
		}
		Exception ex = Common.StartTaskSafe(task, _dataflowBlockOptions.TaskScheduler);
		if (ex != null)
		{
			Task.Factory.StartNew(delegate(object exc)
			{
				Complete((Exception)exc, dropPendingMessages: true, storeExceptionEvenIfAlreadyCompleting: true, unwrapInnerExceptions: false, revertProcessingState: true);
			}, ex, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}
	}

	private void ProcessMessagesLoopCore()
	{
		KeyValuePair<TInput, long> messageWithId = default(KeyValuePair<TInput, long>);
		try
		{
			bool usesAsyncCompletion = UsesAsyncCompletion;
			bool flag = _boundingState != null && _boundingState.BoundedCapacity > 1;
			int num = 0;
			int num2 = 0;
			int actualMaxMessagesPerTask = _dataflowBlockOptions.ActualMaxMessagesPerTask;
			while (num < actualMaxMessagesPerTask && !CanceledOrFaulted)
			{
				if (flag && TryConsumePostponedMessage(forPostponementTransfer: true, out var result))
				{
					lock (IncomingLock)
					{
						_boundingState.OutstandingTransfers--;
						_messages.Enqueue(result);
						ProcessAsyncIfNecessary();
					}
				}
				if (usesAsyncCompletion)
				{
					if (!TryGetNextMessageForNewAsyncOperation(out messageWithId))
					{
						break;
					}
				}
				else if (!TryGetNextAvailableOrPostponedMessage(out messageWithId))
				{
					if (_dataflowBlockOptions.MaxDegreeOfParallelism != 1 || num2 > 1)
					{
						break;
					}
					if (_keepAliveBanCounter > 0)
					{
						_keepAliveBanCounter--;
						break;
					}
					num2 = 0;
					if (!Common.TryKeepAliveUntil(_keepAlivePredicate, this, out messageWithId))
					{
						_keepAliveBanCounter = 1000;
						break;
					}
				}
				num++;
				num2++;
				_callAction(messageWithId);
			}
		}
		catch (Exception ex)
		{
			Common.StoreDataflowMessageValueIntoExceptionData(ex, messageWithId.Key);
			Complete(ex, dropPendingMessages: true, storeExceptionEvenIfAlreadyCompleting: true);
		}
		finally
		{
			lock (IncomingLock)
			{
				_numberOfOutstandingOperations--;
				if (UsesAsyncCompletion)
				{
					_numberOfOutstandingServiceTasks--;
				}
				ProcessAsyncIfNecessary(repeat: true);
				CompleteBlockIfPossible();
			}
		}
	}

	private bool TryGetNextMessageForNewAsyncOperation(out KeyValuePair<TInput, long> messageWithId)
	{
		bool hasRoomForMoreOperations;
		lock (IncomingLock)
		{
			if (hasRoomForMoreOperations = HasRoomForMoreOperations)
			{
				_numberOfOutstandingOperations++;
			}
		}
		messageWithId = default(KeyValuePair<TInput, long>);
		if (hasRoomForMoreOperations)
		{
			bool flag = false;
			try
			{
				flag = TryGetNextAvailableOrPostponedMessage(out messageWithId);
			}
			catch
			{
				SignalOneAsyncMessageCompleted();
				throw;
			}
			if (!flag)
			{
				SignalOneAsyncMessageCompleted();
			}
			return flag;
		}
		return false;
	}

	private bool TryGetNextAvailableOrPostponedMessage(out KeyValuePair<TInput, long> messageWithId)
	{
		if (_messages.TryDequeue(out messageWithId))
		{
			return true;
		}
		if (_boundingState != null && TryConsumePostponedMessage(forPostponementTransfer: false, out messageWithId))
		{
			return true;
		}
		messageWithId = default(KeyValuePair<TInput, long>);
		return false;
	}

	private bool TryConsumePostponedMessage(bool forPostponementTransfer, out KeyValuePair<TInput, long> result)
	{
		bool flag = false;
		long num = -1L;
		while (true)
		{
			KeyValuePair<ISourceBlock<TInput>, DataflowMessageHeader> item;
			lock (IncomingLock)
			{
				if (_decliningPermanently)
				{
					break;
				}
				if (!forPostponementTransfer && _messages.TryDequeue(out result))
				{
					return true;
				}
				if (_boundingState.CountIsLessThanBound && _boundingState.PostponedMessages.TryPop(out item))
				{
					if (!flag)
					{
						flag = true;
						num = _nextAvailableInputMessageId.Value++;
						_boundingState.CurrentCount++;
						if (forPostponementTransfer)
						{
							_boundingState.OutstandingTransfers++;
						}
					}
					goto IL_00d6;
				}
				if (flag)
				{
					flag = false;
					_boundingState.CurrentCount--;
				}
			}
			break;
			IL_00d6:
			bool messageConsumed;
			TInput key = item.Key.ConsumeMessage(item.Value, _owningTarget, out messageConsumed);
			if (!messageConsumed)
			{
				if (forPostponementTransfer)
				{
					_boundingState.OutstandingTransfers--;
				}
				continue;
			}
			result = new KeyValuePair<TInput, long>(key, num);
			return true;
		}
		if (_reorderingBuffer != null && num != -1L)
		{
			_reorderingBuffer.IgnoreItem(num);
		}
		if (flag)
		{
			ChangeBoundingCount(-1);
		}
		result = default(KeyValuePair<TInput, long>);
		return false;
	}

	private void CompleteBlockIfPossible()
	{
		if ((_decliningPermanently && _messages.IsEmpty) || CanceledOrFaulted)
		{
			CompleteBlockIfPossible_Slow();
		}
	}

	private void CompleteBlockIfPossible_Slow()
	{
		if (_numberOfOutstandingOperations == 0 && !_completionReserved)
		{
			_completionReserved = true;
			_decliningPermanently = true;
			Task.Factory.StartNew(delegate(object state)
			{
				((TargetCore<TInput>)state).CompleteBlockOncePossible();
			}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}
	}

	private void CompleteBlockOncePossible()
	{
		if (_boundingState != null)
		{
			Common.ReleaseAllPostponedMessages(_owningTarget, _boundingState.PostponedMessages, ref _exceptions);
		}
		IProducerConsumerQueue<KeyValuePair<TInput, long>> messages = _messages;
		KeyValuePair<TInput, long> result;
		while (messages.TryDequeue(out result))
		{
		}
		if (Volatile.Read(ref _exceptions) != null)
		{
			_completionSource.TrySetException(Volatile.Read(ref _exceptions));
		}
		else if (_dataflowBlockOptions.CancellationToken.IsCancellationRequested)
		{
			_completionSource.TrySetCanceled();
		}
		else
		{
			_completionSource.TrySetResult(default(VoidResult));
		}
		DataflowEtwProvider log;
		if ((_targetCoreOptions & TargetCoreOptions.RepresentsBlockCompletion) != 0 && (log = DataflowEtwProvider.Log).IsEnabled())
		{
			log.DataflowBlockCompleted(_owningTarget);
		}
	}

	internal void ChangeBoundingCount(int count)
	{
		if (_boundingState != null)
		{
			lock (IncomingLock)
			{
				_boundingState.CurrentCount += count;
				ProcessAsyncIfNecessary();
				CompleteBlockIfPossible();
			}
		}
	}

	internal DebuggingInformation GetDebuggingInformation()
	{
		return new DebuggingInformation(this);
	}
}
