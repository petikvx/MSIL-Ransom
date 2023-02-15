using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow.Internal;

namespace System.Threading.Tasks.Dataflow;

[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
[DebuggerTypeProxy(typeof(ActionBlock<>.DebugView))]
public sealed class ActionBlock<TInput> : ITargetBlock<TInput>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class DebugView
	{
		private readonly ActionBlock<TInput> _actionBlock;

		private readonly TargetCore<TInput>.DebuggingInformation _defaultDebugInfo;

		private readonly SpscTargetCore<TInput>.DebuggingInformation _spscDebugInfo;

		public IEnumerable<TInput> InputQueue
		{
			get
			{
				if (_defaultDebugInfo == null)
				{
					return _spscDebugInfo.InputQueue;
				}
				return _defaultDebugInfo.InputQueue;
			}
		}

		public QueuedMap<ISourceBlock<TInput>, DataflowMessageHeader> PostponedMessages
		{
			get
			{
				if (_defaultDebugInfo == null)
				{
					return null;
				}
				return _defaultDebugInfo.PostponedMessages;
			}
		}

		public int CurrentDegreeOfParallelism
		{
			get
			{
				if (_defaultDebugInfo == null)
				{
					return _spscDebugInfo.CurrentDegreeOfParallelism;
				}
				return _defaultDebugInfo.CurrentDegreeOfParallelism;
			}
		}

		public ExecutionDataflowBlockOptions DataflowBlockOptions
		{
			get
			{
				if (_defaultDebugInfo == null)
				{
					return _spscDebugInfo.DataflowBlockOptions;
				}
				return _defaultDebugInfo.DataflowBlockOptions;
			}
		}

		public bool IsDecliningPermanently
		{
			get
			{
				if (_defaultDebugInfo == null)
				{
					return _spscDebugInfo.IsDecliningPermanently;
				}
				return _defaultDebugInfo.IsDecliningPermanently;
			}
		}

		public bool IsCompleted
		{
			get
			{
				if (_defaultDebugInfo == null)
				{
					return _spscDebugInfo.IsCompleted;
				}
				return _defaultDebugInfo.IsCompleted;
			}
		}

		public int Id => Common.GetBlockId(_actionBlock);

		public DebugView(ActionBlock<TInput> actionBlock)
		{
			_actionBlock = actionBlock;
			if (_actionBlock._defaultTarget != null)
			{
				_defaultDebugInfo = actionBlock._defaultTarget.GetDebuggingInformation();
			}
			else
			{
				_spscDebugInfo = actionBlock._spscTarget.GetDebuggingInformation();
			}
		}
	}

	private readonly TargetCore<TInput> _defaultTarget;

	private readonly SpscTargetCore<TInput> _spscTarget;

	public Task Completion
	{
		get
		{
			if (_defaultTarget == null)
			{
				return _spscTarget.Completion;
			}
			return _defaultTarget.Completion;
		}
	}

	public int InputCount
	{
		get
		{
			if (_defaultTarget == null)
			{
				return _spscTarget.InputCount;
			}
			return _defaultTarget.InputCount;
		}
	}

	private int InputCountForDebugger
	{
		get
		{
			if (_defaultTarget == null)
			{
				return _spscTarget.InputCount;
			}
			return _defaultTarget.GetDebuggingInformation().InputCount;
		}
	}

	private object DebuggerDisplayContent => string.Format("{0}, InputCount={1}", new object[2]
	{
		Common.GetNameForDebugger(this, (_defaultTarget != null) ? _defaultTarget.DataflowBlockOptions : _spscTarget.DataflowBlockOptions),
		InputCountForDebugger
	});

	object IDebuggerDisplay.Content => DebuggerDisplayContent;

	public ActionBlock(Action<TInput> action)
		: this((Delegate)action, ExecutionDataflowBlockOptions.Default)
	{
	}

	public ActionBlock(Action<TInput> action, ExecutionDataflowBlockOptions dataflowBlockOptions)
		: this((Delegate)action, dataflowBlockOptions)
	{
	}

	public ActionBlock(Func<TInput, Task> action)
		: this((Delegate)action, ExecutionDataflowBlockOptions.Default)
	{
	}

	public ActionBlock(Func<TInput, Task> action, ExecutionDataflowBlockOptions dataflowBlockOptions)
		: this((Delegate)action, dataflowBlockOptions)
	{
	}

	private ActionBlock(Delegate action, ExecutionDataflowBlockOptions dataflowBlockOptions)
	{
		ActionBlock<TInput> actionBlock = this;
		if ((object)action == null)
		{
			throw new ArgumentNullException("action");
		}
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		dataflowBlockOptions = dataflowBlockOptions.DefaultOrClone();
		Action<TInput> syncAction = action as Action<TInput>;
		if (syncAction != null && dataflowBlockOptions.SingleProducerConstrained && dataflowBlockOptions.MaxDegreeOfParallelism == 1 && !dataflowBlockOptions.CancellationToken.CanBeCanceled && dataflowBlockOptions.BoundedCapacity == -1)
		{
			_spscTarget = new SpscTargetCore<TInput>(this, syncAction, dataflowBlockOptions);
		}
		else
		{
			if (syncAction != null)
			{
				_defaultTarget = new TargetCore<TInput>(this, delegate(KeyValuePair<TInput, long> messageWithId)
				{
					actionBlock.ProcessMessage(syncAction, messageWithId);
				}, null, dataflowBlockOptions, TargetCoreOptions.RepresentsBlockCompletion);
			}
			else
			{
				Func<TInput, Task> asyncAction = action as Func<TInput, Task>;
				_defaultTarget = new TargetCore<TInput>(this, delegate(KeyValuePair<TInput, long> messageWithId)
				{
					actionBlock.ProcessMessageWithTask(asyncAction, messageWithId);
				}, null, dataflowBlockOptions, TargetCoreOptions.UsesAsyncCompletion | TargetCoreOptions.RepresentsBlockCompletion);
			}
			Common.WireCancellationToComplete(dataflowBlockOptions.CancellationToken, Completion, delegate(object state)
			{
				((TargetCore<TInput>)state).Complete(null, dropPendingMessages: true);
			}, _defaultTarget);
		}
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockCreated(this, dataflowBlockOptions);
		}
	}

	private void ProcessMessage(Action<TInput> action, KeyValuePair<TInput, long> messageWithId)
	{
		try
		{
			action(messageWithId.Key);
		}
		catch (Exception exception)
		{
			if (!Common.IsCooperativeCancellation(exception))
			{
				throw;
			}
		}
		finally
		{
			if (_defaultTarget.IsBounded)
			{
				_defaultTarget.ChangeBoundingCount(-1);
			}
		}
	}

	private void ProcessMessageWithTask(Func<TInput, Task> action, KeyValuePair<TInput, long> messageWithId)
	{
		Task task = null;
		Exception ex = null;
		try
		{
			task = action(messageWithId.Key);
		}
		catch (Exception ex2)
		{
			ex = ex2;
		}
		if (task == null)
		{
			if (ex != null && !Common.IsCooperativeCancellation(ex))
			{
				Common.StoreDataflowMessageValueIntoExceptionData(ex, messageWithId.Key);
				_defaultTarget.Complete(ex, dropPendingMessages: true, storeExceptionEvenIfAlreadyCompleting: true);
			}
			_defaultTarget.SignalOneAsyncMessageCompleted(-1);
		}
		else if (task.IsCompleted)
		{
			AsyncCompleteProcessMessageWithTask(task);
		}
		else
		{
			task.ContinueWith(delegate(Task completed, object state)
			{
				((ActionBlock<TInput>)state).AsyncCompleteProcessMessageWithTask(completed);
			}, this, CancellationToken.None, Common.GetContinuationOptions(TaskContinuationOptions.ExecuteSynchronously), TaskScheduler.Default);
		}
	}

	private void AsyncCompleteProcessMessageWithTask(Task completed)
	{
		if (completed.IsFaulted)
		{
			_defaultTarget.Complete(completed.Exception, dropPendingMessages: true, storeExceptionEvenIfAlreadyCompleting: true, unwrapInnerExceptions: true);
		}
		_defaultTarget.SignalOneAsyncMessageCompleted(-1);
	}

	public void Complete()
	{
		if (_defaultTarget != null)
		{
			_defaultTarget.Complete(null, dropPendingMessages: false);
		}
		else
		{
			_spscTarget.Complete(null);
		}
	}

	void IDataflowBlock.Fault(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		if (_defaultTarget != null)
		{
			_defaultTarget.Complete(exception, dropPendingMessages: true);
		}
		else
		{
			_spscTarget.Complete(exception);
		}
	}

	public bool Post(TInput item)
	{
		if (_defaultTarget == null)
		{
			return _spscTarget.Post(item);
		}
		return _defaultTarget.OfferMessage(Common.SingleMessageHeader, item, null, consumeToAccept: false) == DataflowMessageStatus.Accepted;
	}

	DataflowMessageStatus ITargetBlock<TInput>.OfferMessage(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept)
	{
		if (_defaultTarget == null)
		{
			return _spscTarget.OfferMessage(messageHeader, messageValue, source, consumeToAccept);
		}
		return _defaultTarget.OfferMessage(messageHeader, messageValue, source, consumeToAccept);
	}

	public override string ToString()
	{
		return Common.GetNameForDebugger(this, (_defaultTarget != null) ? _defaultTarget.DataflowBlockOptions : _spscTarget.DataflowBlockOptions);
	}
}
