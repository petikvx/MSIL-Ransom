using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace System.Threading.Tasks.Dataflow.Internal;

[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
internal sealed class SpscTargetCore<TInput>
{
	internal sealed class DebuggingInformation
	{
		private readonly SpscTargetCore<TInput> _target;

		internal IEnumerable<TInput> InputQueue => Enumerable.ToList(_target._messages);

		internal int CurrentDegreeOfParallelism
		{
			get
			{
				if (_target._activeConsumer != null && !_target.Completion.IsCompleted)
				{
					return 1;
				}
				return 0;
			}
		}

		internal ExecutionDataflowBlockOptions DataflowBlockOptions => _target._dataflowBlockOptions;

		internal bool IsDecliningPermanently => _target._decliningPermanently;

		internal bool IsCompleted => _target.Completion.IsCompleted;

		internal DebuggingInformation(SpscTargetCore<TInput> target)
		{
			_target = target;
		}
	}

	private readonly ITargetBlock<TInput> _owningTarget;

	private readonly SingleProducerSingleConsumerQueue<TInput> _messages = new SingleProducerSingleConsumerQueue<TInput>();

	private readonly ExecutionDataflowBlockOptions _dataflowBlockOptions;

	private readonly Action<TInput> _action;

	private volatile List<Exception> _exceptions;

	private volatile bool _decliningPermanently;

	private volatile bool _completionReserved;

	private volatile Task _activeConsumer;

	private TaskCompletionSource<VoidResult> _completionTask;

	internal int InputCount => _messages.Count;

	internal Task Completion => CompletionSource.Task;

	private TaskCompletionSource<VoidResult> CompletionSource => LazyInitializer.EnsureInitialized(ref _completionTask, () => new TaskCompletionSource<VoidResult>());

	internal ExecutionDataflowBlockOptions DataflowBlockOptions => _dataflowBlockOptions;

	private object DebuggerDisplayContent
	{
		get
		{
			IDebuggerDisplay debuggerDisplay = _owningTarget as IDebuggerDisplay;
			return $"Block=\"{((debuggerDisplay != null) ? debuggerDisplay.Content : _owningTarget)}\"";
		}
	}

	internal SpscTargetCore(ITargetBlock<TInput> owningTarget, Action<TInput> action, ExecutionDataflowBlockOptions dataflowBlockOptions)
	{
		_owningTarget = owningTarget;
		_action = action;
		_dataflowBlockOptions = dataflowBlockOptions;
	}

	internal bool Post(TInput messageValue)
	{
		if (_decliningPermanently)
		{
			return false;
		}
		_messages.Enqueue(messageValue);
		Interlocked.MemoryBarrier();
		if (_activeConsumer == null)
		{
			ScheduleConsumerIfNecessary(isReplica: false);
		}
		return true;
	}

	internal DataflowMessageStatus OfferMessage(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept)
	{
		if (!consumeToAccept && Post(messageValue))
		{
			return DataflowMessageStatus.Accepted;
		}
		return OfferMessage_Slow(messageHeader, messageValue, source, consumeToAccept);
	}

	private DataflowMessageStatus OfferMessage_Slow(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept)
	{
		if (_decliningPermanently)
		{
			return DataflowMessageStatus.DecliningPermanently;
		}
		if (!messageHeader.IsValid)
		{
			throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
		}
		if (consumeToAccept)
		{
			if (source == null)
			{
				throw new ArgumentException(SR1.Argument_CantConsumeFromANullSource, "consumeToAccept");
			}
			messageValue = source.ConsumeMessage(messageHeader, _owningTarget, out var messageConsumed);
			if (!messageConsumed)
			{
				return DataflowMessageStatus.NotAvailable;
			}
		}
		_messages.Enqueue(messageValue);
		Interlocked.MemoryBarrier();
		if (_activeConsumer == null)
		{
			ScheduleConsumerIfNecessary(isReplica: false);
		}
		return DataflowMessageStatus.Accepted;
	}

	private void ScheduleConsumerIfNecessary(bool isReplica)
	{
		if (_activeConsumer != null)
		{
			return;
		}
		Task task = new Task(delegate(object state)
		{
			((SpscTargetCore<TInput>)state).ProcessMessagesLoopCore();
		}, this, CancellationToken.None, Common.GetCreationOptionsForTask(isReplica));
		if (Interlocked.CompareExchange(ref _activeConsumer, task, null) == null)
		{
			DataflowEtwProvider log = DataflowEtwProvider.Log;
			if (log.IsEnabled())
			{
				log.TaskLaunchedForMessageHandling(_owningTarget, task, DataflowEtwProvider.TaskLaunchedReason.ProcessingInputMessages, _messages.Count);
			}
			task.Start(_dataflowBlockOptions.TaskScheduler);
		}
	}

	private void ProcessMessagesLoopCore()
	{
		int num = 0;
		int actualMaxMessagesPerTask = _dataflowBlockOptions.ActualMaxMessagesPerTask;
		bool flag = true;
		while (flag)
		{
			flag = false;
			TInput result = default(TInput);
			try
			{
				while (_exceptions == null && num < actualMaxMessagesPerTask && _messages.TryDequeue(out result))
				{
					num++;
					_action(result);
				}
			}
			catch (Exception ex)
			{
				if (!Common.IsCooperativeCancellation(ex))
				{
					_decliningPermanently = true;
					Common.StoreDataflowMessageValueIntoExceptionData(ex, result);
					StoreException(ex);
				}
			}
			finally
			{
				bool decliningPermanently;
				if (!_messages.IsEmpty && _exceptions == null && num < actualMaxMessagesPerTask)
				{
					flag = true;
				}
				else if (((decliningPermanently = _decliningPermanently) && _messages.IsEmpty) || _exceptions != null)
				{
					if (!_completionReserved)
					{
						_completionReserved = true;
						CompleteBlockOncePossible();
					}
				}
				else
				{
					Interlocked.Exchange(ref _activeConsumer, null);
					if (!_messages.IsEmpty || (!decliningPermanently && _decliningPermanently) || _exceptions != null)
					{
						ScheduleConsumerIfNecessary(isReplica: true);
					}
				}
			}
		}
	}

	internal void Complete(Exception exception)
	{
		if (!_decliningPermanently)
		{
			if (exception != null)
			{
				StoreException(exception);
			}
			_decliningPermanently = true;
			ScheduleConsumerIfNecessary(isReplica: false);
		}
	}

	private void StoreException(Exception exception)
	{
		lock (LazyInitializer.EnsureInitialized(ref _exceptions, () => new List<Exception>()))
		{
			_exceptions.Add(exception);
		}
	}

	private void CompleteBlockOncePossible()
	{
		TInput result;
		while (_messages.TryDequeue(out result))
		{
		}
		if (_exceptions != null)
		{
			Exception[] exceptions;
			lock (_exceptions)
			{
				exceptions = _exceptions.ToArray();
			}
			CompletionSource.TrySetException(exceptions);
		}
		else
		{
			CompletionSource.TrySetResult(default(VoidResult));
		}
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockCompleted(_owningTarget);
		}
	}

	internal DebuggingInformation GetDebuggingInformation()
	{
		return new DebuggingInformation(this);
	}
}
