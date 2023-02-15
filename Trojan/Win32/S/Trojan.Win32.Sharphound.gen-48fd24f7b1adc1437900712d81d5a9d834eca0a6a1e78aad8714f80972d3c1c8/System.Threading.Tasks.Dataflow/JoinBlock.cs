using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow.Internal;

namespace System.Threading.Tasks.Dataflow;

[DebuggerTypeProxy(typeof(JoinBlock<, >.DebugView))]
[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
public sealed class JoinBlock<T1, T2> : IReceivableSourceBlock<Tuple<T1, T2>>, ISourceBlock<Tuple<T1, T2>>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class DebugView
	{
		private readonly JoinBlock<T1, T2> _joinBlock;

		private readonly SourceCore<Tuple<T1, T2>>.DebuggingInformation _sourceDebuggingInformation;

		public IEnumerable<Tuple<T1, T2>> OutputQueue => _sourceDebuggingInformation.OutputQueue;

		public long JoinsCreated => _joinBlock._sharedResources._joinsCreated;

		public Task TaskForInputProcessing => _joinBlock._sharedResources._taskForInputProcessing;

		public Task TaskForOutputProcessing => _sourceDebuggingInformation.TaskForOutputProcessing;

		public GroupingDataflowBlockOptions DataflowBlockOptions => (GroupingDataflowBlockOptions)_sourceDebuggingInformation.DataflowBlockOptions;

		public bool IsDecliningPermanently => _joinBlock._sharedResources._decliningPermanently;

		public bool IsCompleted => _sourceDebuggingInformation.IsCompleted;

		public int Id => Common.GetBlockId(_joinBlock);

		public ITargetBlock<T1> Target1 => _joinBlock._target1;

		public ITargetBlock<T2> Target2 => _joinBlock._target2;

		public TargetRegistry<Tuple<T1, T2>> LinkedTargets => _sourceDebuggingInformation.LinkedTargets;

		public ITargetBlock<Tuple<T1, T2>> NextMessageReservedFor => _sourceDebuggingInformation.NextMessageReservedFor;

		public DebugView(JoinBlock<T1, T2> joinBlock)
		{
			_joinBlock = joinBlock;
			_sourceDebuggingInformation = joinBlock._source.GetDebuggingInformation();
		}
	}

	private readonly JoinBlockTargetSharedResources _sharedResources;

	private readonly SourceCore<Tuple<T1, T2>> _source;

	private readonly JoinBlockTarget<T1> _target1;

	private readonly JoinBlockTarget<T2> _target2;

	public int OutputCount => _source.OutputCount;

	public Task Completion => _source.Completion;

	public ITargetBlock<T1> Target1 => _target1;

	public ITargetBlock<T2> Target2 => _target2;

	private int OutputCountForDebugger => _source.GetDebuggingInformation().OutputCount;

	private object DebuggerDisplayContent => string.Format("{0}, OutputCount={1}", new object[2]
	{
		Common.GetNameForDebugger(this, _source.DataflowBlockOptions),
		OutputCountForDebugger
	});

	object IDebuggerDisplay.Content => DebuggerDisplayContent;

	public JoinBlock()
		: this(GroupingDataflowBlockOptions.Default)
	{
	}

	public JoinBlock(GroupingDataflowBlockOptions dataflowBlockOptions)
	{
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		dataflowBlockOptions = dataflowBlockOptions.DefaultOrClone();
		Action<ISourceBlock<Tuple<T1, T2>>, int> itemsRemovedAction = null;
		if (dataflowBlockOptions.BoundedCapacity > 0)
		{
			itemsRemovedAction = delegate(ISourceBlock<Tuple<T1, T2>> owningSource, int count)
			{
				((JoinBlock<T1, T2>)owningSource)._sharedResources.OnItemsRemoved(count);
			};
		}
		_source = new SourceCore<Tuple<T1, T2>>(this, dataflowBlockOptions, delegate(ISourceBlock<Tuple<T1, T2>> owningSource)
		{
			((JoinBlock<T1, T2>)owningSource)._sharedResources.CompleteEachTarget();
		}, itemsRemovedAction);
		JoinBlockTargetBase[] array = new JoinBlockTargetBase[2];
		_sharedResources = new JoinBlockTargetSharedResources(this, array, delegate
		{
			_source.AddMessage(Tuple.Create(_target1.GetOneMessage(), _target2.GetOneMessage()));
		}, delegate(Exception exception)
		{
			Volatile.Write(ref _sharedResources._hasExceptions, value: true);
			_source.AddException(exception);
		}, dataflowBlockOptions);
		array[0] = (_target1 = new JoinBlockTarget<T1>(_sharedResources));
		array[1] = (_target2 = new JoinBlockTarget<T2>(_sharedResources));
		Task.Factory.ContinueWhenAll(new Task[2] { _target1.CompletionTaskInternal, _target2.CompletionTaskInternal }, delegate
		{
			_source.Complete();
		}, CancellationToken.None, Common.GetContinuationOptions(), TaskScheduler.Default);
		_source.Completion.ContinueWith(delegate(Task completed, object state)
		{
			IDataflowBlock dataflowBlock = (JoinBlock<T1, T2>)state;
			dataflowBlock.Fault(completed.Exception);
		}, this, CancellationToken.None, Common.GetContinuationOptions() | TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
		Common.WireCancellationToComplete(dataflowBlockOptions.CancellationToken, _source.Completion, delegate(object state)
		{
			((JoinBlock<T1, T2>)state)._sharedResources.CompleteEachTarget();
		}, this);
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockCreated(this, dataflowBlockOptions);
		}
	}

	public IDisposable LinkTo(ITargetBlock<Tuple<T1, T2>> target, DataflowLinkOptions linkOptions)
	{
		return _source.LinkTo(target, linkOptions);
	}

	public bool TryReceive(Predicate<Tuple<T1, T2>> filter, out Tuple<T1, T2> item)
	{
		return _source.TryReceive(filter, out item);
	}

	public bool TryReceiveAll(out IList<Tuple<T1, T2>> items)
	{
		return _source.TryReceiveAll(out items);
	}

	public void Complete()
	{
		_target1.CompleteCore(null, dropPendingMessages: false, releaseReservedMessages: false);
		_target2.CompleteCore(null, dropPendingMessages: false, releaseReservedMessages: false);
	}

	void IDataflowBlock.Fault(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		lock (_sharedResources.IncomingLock)
		{
			if (!_sharedResources._decliningPermanently)
			{
				_sharedResources._exceptionAction(exception);
			}
		}
		Complete();
	}

	Tuple<T1, T2> ISourceBlock<Tuple<T1, T2>>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<T1, T2>> target, out bool messageConsumed)
	{
		return _source.ConsumeMessage(messageHeader, target, out messageConsumed);
	}

	bool ISourceBlock<Tuple<T1, T2>>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<T1, T2>> target)
	{
		return _source.ReserveMessage(messageHeader, target);
	}

	void ISourceBlock<Tuple<T1, T2>>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<T1, T2>> target)
	{
		_source.ReleaseReservation(messageHeader, target);
	}

	public override string ToString()
	{
		return Common.GetNameForDebugger(this, _source.DataflowBlockOptions);
	}
}
[DebuggerTypeProxy(typeof(JoinBlock<, , >.DebugView))]
[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
public sealed class JoinBlock<T1, T2, T3> : IReceivableSourceBlock<Tuple<T1, T2, T3>>, ISourceBlock<Tuple<T1, T2, T3>>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class DebugView
	{
		private readonly JoinBlock<T1, T2, T3> _joinBlock;

		private readonly SourceCore<Tuple<T1, T2, T3>>.DebuggingInformation _sourceDebuggingInformation;

		public IEnumerable<Tuple<T1, T2, T3>> OutputQueue => _sourceDebuggingInformation.OutputQueue;

		public long JoinsCreated => _joinBlock._sharedResources._joinsCreated;

		public Task TaskForInputProcessing => _joinBlock._sharedResources._taskForInputProcessing;

		public Task TaskForOutputProcessing => _sourceDebuggingInformation.TaskForOutputProcessing;

		public GroupingDataflowBlockOptions DataflowBlockOptions => (GroupingDataflowBlockOptions)_sourceDebuggingInformation.DataflowBlockOptions;

		public bool IsDecliningPermanently => _joinBlock._sharedResources._decliningPermanently;

		public bool IsCompleted => _sourceDebuggingInformation.IsCompleted;

		public int Id => Common.GetBlockId(_joinBlock);

		public ITargetBlock<T1> Target1 => _joinBlock._target1;

		public ITargetBlock<T2> Target2 => _joinBlock._target2;

		public ITargetBlock<T3> Target3 => _joinBlock._target3;

		public TargetRegistry<Tuple<T1, T2, T3>> LinkedTargets => _sourceDebuggingInformation.LinkedTargets;

		public ITargetBlock<Tuple<T1, T2, T3>> NextMessageReservedFor => _sourceDebuggingInformation.NextMessageReservedFor;

		public DebugView(JoinBlock<T1, T2, T3> joinBlock)
		{
			_joinBlock = joinBlock;
			_sourceDebuggingInformation = joinBlock._source.GetDebuggingInformation();
		}
	}

	private readonly JoinBlockTargetSharedResources _sharedResources;

	private readonly SourceCore<Tuple<T1, T2, T3>> _source;

	private readonly JoinBlockTarget<T1> _target1;

	private readonly JoinBlockTarget<T2> _target2;

	private readonly JoinBlockTarget<T3> _target3;

	public int OutputCount => _source.OutputCount;

	public Task Completion => _source.Completion;

	public ITargetBlock<T1> Target1 => _target1;

	public ITargetBlock<T2> Target2 => _target2;

	public ITargetBlock<T3> Target3 => _target3;

	private int OutputCountForDebugger => _source.GetDebuggingInformation().OutputCount;

	private object DebuggerDisplayContent => string.Format("{0} OutputCount={1}", new object[2]
	{
		Common.GetNameForDebugger(this, _source.DataflowBlockOptions),
		OutputCountForDebugger
	});

	object IDebuggerDisplay.Content => DebuggerDisplayContent;

	public JoinBlock()
		: this(GroupingDataflowBlockOptions.Default)
	{
	}

	public JoinBlock(GroupingDataflowBlockOptions dataflowBlockOptions)
	{
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		dataflowBlockOptions = dataflowBlockOptions.DefaultOrClone();
		Action<ISourceBlock<Tuple<T1, T2, T3>>, int> itemsRemovedAction = null;
		if (dataflowBlockOptions.BoundedCapacity > 0)
		{
			itemsRemovedAction = delegate(ISourceBlock<Tuple<T1, T2, T3>> owningSource, int count)
			{
				((JoinBlock<T1, T2, T3>)owningSource)._sharedResources.OnItemsRemoved(count);
			};
		}
		_source = new SourceCore<Tuple<T1, T2, T3>>(this, dataflowBlockOptions, delegate(ISourceBlock<Tuple<T1, T2, T3>> owningSource)
		{
			((JoinBlock<T1, T2, T3>)owningSource)._sharedResources.CompleteEachTarget();
		}, itemsRemovedAction);
		JoinBlockTargetBase[] array = new JoinBlockTargetBase[3];
		_sharedResources = new JoinBlockTargetSharedResources(this, array, delegate
		{
			_source.AddMessage(Tuple.Create(_target1.GetOneMessage(), _target2.GetOneMessage(), _target3.GetOneMessage()));
		}, delegate(Exception exception)
		{
			Volatile.Write(ref _sharedResources._hasExceptions, value: true);
			_source.AddException(exception);
		}, dataflowBlockOptions);
		array[0] = (_target1 = new JoinBlockTarget<T1>(_sharedResources));
		array[1] = (_target2 = new JoinBlockTarget<T2>(_sharedResources));
		array[2] = (_target3 = new JoinBlockTarget<T3>(_sharedResources));
		Task.Factory.ContinueWhenAll(new Task[3] { _target1.CompletionTaskInternal, _target2.CompletionTaskInternal, _target3.CompletionTaskInternal }, delegate
		{
			_source.Complete();
		}, CancellationToken.None, Common.GetContinuationOptions(), TaskScheduler.Default);
		_source.Completion.ContinueWith(delegate(Task completed, object state)
		{
			IDataflowBlock dataflowBlock = (JoinBlock<T1, T2, T3>)state;
			dataflowBlock.Fault(completed.Exception);
		}, this, CancellationToken.None, Common.GetContinuationOptions() | TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
		Common.WireCancellationToComplete(dataflowBlockOptions.CancellationToken, _source.Completion, delegate(object state)
		{
			((JoinBlock<T1, T2, T3>)state)._sharedResources.CompleteEachTarget();
		}, this);
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockCreated(this, dataflowBlockOptions);
		}
	}

	public IDisposable LinkTo(ITargetBlock<Tuple<T1, T2, T3>> target, DataflowLinkOptions linkOptions)
	{
		return _source.LinkTo(target, linkOptions);
	}

	public bool TryReceive(Predicate<Tuple<T1, T2, T3>> filter, out Tuple<T1, T2, T3> item)
	{
		return _source.TryReceive(filter, out item);
	}

	public bool TryReceiveAll(out IList<Tuple<T1, T2, T3>> items)
	{
		return _source.TryReceiveAll(out items);
	}

	public void Complete()
	{
		_target1.CompleteCore(null, dropPendingMessages: false, releaseReservedMessages: false);
		_target2.CompleteCore(null, dropPendingMessages: false, releaseReservedMessages: false);
		_target3.CompleteCore(null, dropPendingMessages: false, releaseReservedMessages: false);
	}

	void IDataflowBlock.Fault(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		lock (_sharedResources.IncomingLock)
		{
			if (!_sharedResources._decliningPermanently)
			{
				_sharedResources._exceptionAction(exception);
			}
		}
		Complete();
	}

	Tuple<T1, T2, T3> ISourceBlock<Tuple<T1, T2, T3>>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<T1, T2, T3>> target, out bool messageConsumed)
	{
		return _source.ConsumeMessage(messageHeader, target, out messageConsumed);
	}

	bool ISourceBlock<Tuple<T1, T2, T3>>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<T1, T2, T3>> target)
	{
		return _source.ReserveMessage(messageHeader, target);
	}

	void ISourceBlock<Tuple<T1, T2, T3>>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<T1, T2, T3>> target)
	{
		_source.ReleaseReservation(messageHeader, target);
	}

	public override string ToString()
	{
		return Common.GetNameForDebugger(this, _source.DataflowBlockOptions);
	}
}
