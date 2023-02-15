using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow.Internal;

namespace System.Threading.Tasks.Dataflow;

[DebuggerTypeProxy(typeof(BatchedJoinBlock<, >.DebugView))]
[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
public sealed class BatchedJoinBlock<T1, T2> : IReceivableSourceBlock<Tuple<IList<T1>, IList<T2>>>, ISourceBlock<Tuple<IList<T1>, IList<T2>>>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class DebugView
	{
		private readonly BatchedJoinBlock<T1, T2> _batchedJoinBlock;

		private readonly SourceCore<Tuple<IList<T1>, IList<T2>>>.DebuggingInformation _sourceDebuggingInformation;

		public IEnumerable<Tuple<IList<T1>, IList<T2>>> OutputQueue => _sourceDebuggingInformation.OutputQueue;

		public long BatchesCreated => _batchedJoinBlock._sharedResources._batchesCreated;

		public int RemainingItemsForBatch => _batchedJoinBlock._sharedResources._remainingItemsInBatch;

		public int BatchSize => _batchedJoinBlock._batchSize;

		public ITargetBlock<T1> Target1 => _batchedJoinBlock._target1;

		public ITargetBlock<T2> Target2 => _batchedJoinBlock._target2;

		public Task TaskForOutputProcessing => _sourceDebuggingInformation.TaskForOutputProcessing;

		public GroupingDataflowBlockOptions DataflowBlockOptions => (GroupingDataflowBlockOptions)_sourceDebuggingInformation.DataflowBlockOptions;

		public bool IsCompleted => _sourceDebuggingInformation.IsCompleted;

		public int Id => Common.GetBlockId(_batchedJoinBlock);

		public TargetRegistry<Tuple<IList<T1>, IList<T2>>> LinkedTargets => _sourceDebuggingInformation.LinkedTargets;

		public ITargetBlock<Tuple<IList<T1>, IList<T2>>> NextMessageReservedFor => _sourceDebuggingInformation.NextMessageReservedFor;

		public DebugView(BatchedJoinBlock<T1, T2> batchedJoinBlock)
		{
			_batchedJoinBlock = batchedJoinBlock;
			_sourceDebuggingInformation = batchedJoinBlock._source.GetDebuggingInformation();
		}
	}

	private readonly int _batchSize;

	private readonly BatchedJoinBlockTargetSharedResources _sharedResources;

	private readonly BatchedJoinBlockTarget<T1> _target1;

	private readonly BatchedJoinBlockTarget<T2> _target2;

	private readonly SourceCore<Tuple<IList<T1>, IList<T2>>> _source;

	public int BatchSize => _batchSize;

	public ITargetBlock<T1> Target1 => _target1;

	public ITargetBlock<T2> Target2 => _target2;

	public int OutputCount => _source.OutputCount;

	public Task Completion => _source.Completion;

	private int OutputCountForDebugger => _source.GetDebuggingInformation().OutputCount;

	private object DebuggerDisplayContent => string.Format("{0}, BatchSize={1}, OutputCount={2}", new object[3]
	{
		Common.GetNameForDebugger(this, _source.DataflowBlockOptions),
		BatchSize,
		OutputCountForDebugger
	});

	object IDebuggerDisplay.Content => DebuggerDisplayContent;

	public BatchedJoinBlock(int batchSize)
		: this(batchSize, GroupingDataflowBlockOptions.Default)
	{
	}

	public BatchedJoinBlock(int batchSize, GroupingDataflowBlockOptions dataflowBlockOptions)
	{
		if (batchSize < 1)
		{
			throw new ArgumentOutOfRangeException("batchSize", SR1.ArgumentOutOfRange_GenericPositive);
		}
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		if (!dataflowBlockOptions.Greedy)
		{
			throw new ArgumentException(SR1.Argument_NonGreedyNotSupported, "dataflowBlockOptions");
		}
		if (dataflowBlockOptions.BoundedCapacity != -1)
		{
			throw new ArgumentException(SR1.Argument_BoundedCapacityNotSupported, "dataflowBlockOptions");
		}
		_batchSize = batchSize;
		dataflowBlockOptions = dataflowBlockOptions.DefaultOrClone();
		_source = new SourceCore<Tuple<IList<T1>, IList<T2>>>(this, dataflowBlockOptions, delegate(ISourceBlock<Tuple<IList<T1>, IList<T2>>> owningSource)
		{
			((BatchedJoinBlock<T1, T2>)owningSource).CompleteEachTarget();
		});
		Action createBatchAction = delegate
		{
			if (_target1.Count > 0 || _target2.Count > 0)
			{
				_source.AddMessage(Tuple.Create(_target1.GetAndEmptyMessages(), _target2.GetAndEmptyMessages()));
			}
		};
		_sharedResources = new BatchedJoinBlockTargetSharedResources(batchSize, dataflowBlockOptions, createBatchAction, delegate
		{
			createBatchAction();
			_source.Complete();
		}, _source.AddException, Complete);
		_target1 = new BatchedJoinBlockTarget<T1>(_sharedResources);
		_target2 = new BatchedJoinBlockTarget<T2>(_sharedResources);
		_source.Completion.ContinueWith(delegate(Task completed, object state)
		{
			IDataflowBlock dataflowBlock = (BatchedJoinBlock<T1, T2>)state;
			dataflowBlock.Fault(completed.Exception);
		}, this, CancellationToken.None, Common.GetContinuationOptions() | TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
		Common.WireCancellationToComplete(dataflowBlockOptions.CancellationToken, _source.Completion, delegate(object state)
		{
			((BatchedJoinBlock<T1, T2>)state).CompleteEachTarget();
		}, this);
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockCreated(this, dataflowBlockOptions);
		}
	}

	public IDisposable LinkTo(ITargetBlock<Tuple<IList<T1>, IList<T2>>> target, DataflowLinkOptions linkOptions)
	{
		return _source.LinkTo(target, linkOptions);
	}

	public bool TryReceive(Predicate<Tuple<IList<T1>, IList<T2>>> filter, out Tuple<IList<T1>, IList<T2>> item)
	{
		return _source.TryReceive(filter, out item);
	}

	public bool TryReceiveAll(out IList<Tuple<IList<T1>, IList<T2>>> items)
	{
		return _source.TryReceiveAll(out items);
	}

	public void Complete()
	{
		_target1.Complete();
		_target2.Complete();
	}

	void IDataflowBlock.Fault(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		lock (_sharedResources._incomingLock)
		{
			if (!_sharedResources._decliningPermanently)
			{
				_source.AddException(exception);
			}
		}
		Complete();
	}

	Tuple<IList<T1>, IList<T2>> ISourceBlock<Tuple<IList<T1>, IList<T2>>>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<IList<T1>, IList<T2>>> target, out bool messageConsumed)
	{
		return _source.ConsumeMessage(messageHeader, target, out messageConsumed);
	}

	bool ISourceBlock<Tuple<IList<T1>, IList<T2>>>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<IList<T1>, IList<T2>>> target)
	{
		return _source.ReserveMessage(messageHeader, target);
	}

	void ISourceBlock<Tuple<IList<T1>, IList<T2>>>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<IList<T1>, IList<T2>>> target)
	{
		_source.ReleaseReservation(messageHeader, target);
	}

	private void CompleteEachTarget()
	{
		_target1.Complete();
		_target2.Complete();
	}

	public override string ToString()
	{
		return Common.GetNameForDebugger(this, _source.DataflowBlockOptions);
	}
}
[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
[DebuggerTypeProxy(typeof(BatchedJoinBlock<, , >.DebugView))]
public sealed class BatchedJoinBlock<T1, T2, T3> : IReceivableSourceBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>>, ISourceBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class DebugView
	{
		private readonly BatchedJoinBlock<T1, T2, T3> _batchedJoinBlock;

		private readonly SourceCore<Tuple<IList<T1>, IList<T2>, IList<T3>>>.DebuggingInformation _sourceDebuggingInformation;

		public IEnumerable<Tuple<IList<T1>, IList<T2>, IList<T3>>> OutputQueue => _sourceDebuggingInformation.OutputQueue;

		public long BatchesCreated => _batchedJoinBlock._sharedResources._batchesCreated;

		public int RemainingItemsForBatch => _batchedJoinBlock._sharedResources._remainingItemsInBatch;

		public int BatchSize => _batchedJoinBlock._batchSize;

		public ITargetBlock<T1> Target1 => _batchedJoinBlock._target1;

		public ITargetBlock<T2> Target2 => _batchedJoinBlock._target2;

		public ITargetBlock<T3> Target3 => _batchedJoinBlock._target3;

		public Task TaskForOutputProcessing => _sourceDebuggingInformation.TaskForOutputProcessing;

		public GroupingDataflowBlockOptions DataflowBlockOptions => (GroupingDataflowBlockOptions)_sourceDebuggingInformation.DataflowBlockOptions;

		public bool IsCompleted => _sourceDebuggingInformation.IsCompleted;

		public int Id => Common.GetBlockId(_batchedJoinBlock);

		public TargetRegistry<Tuple<IList<T1>, IList<T2>, IList<T3>>> LinkedTargets => _sourceDebuggingInformation.LinkedTargets;

		public ITargetBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>> NextMessageReservedFor => _sourceDebuggingInformation.NextMessageReservedFor;

		public DebugView(BatchedJoinBlock<T1, T2, T3> batchedJoinBlock)
		{
			_sourceDebuggingInformation = batchedJoinBlock._source.GetDebuggingInformation();
			_batchedJoinBlock = batchedJoinBlock;
		}
	}

	private readonly int _batchSize;

	private readonly BatchedJoinBlockTargetSharedResources _sharedResources;

	private readonly BatchedJoinBlockTarget<T1> _target1;

	private readonly BatchedJoinBlockTarget<T2> _target2;

	private readonly BatchedJoinBlockTarget<T3> _target3;

	private readonly SourceCore<Tuple<IList<T1>, IList<T2>, IList<T3>>> _source;

	public int BatchSize => _batchSize;

	public ITargetBlock<T1> Target1 => _target1;

	public ITargetBlock<T2> Target2 => _target2;

	public ITargetBlock<T3> Target3 => _target3;

	public int OutputCount => _source.OutputCount;

	public Task Completion => _source.Completion;

	private int OutputCountForDebugger => _source.GetDebuggingInformation().OutputCount;

	private object DebuggerDisplayContent => string.Format("{0}, BatchSize={1}, OutputCount={2}", new object[3]
	{
		Common.GetNameForDebugger(this, _source.DataflowBlockOptions),
		BatchSize,
		OutputCountForDebugger
	});

	object IDebuggerDisplay.Content => DebuggerDisplayContent;

	public BatchedJoinBlock(int batchSize)
		: this(batchSize, GroupingDataflowBlockOptions.Default)
	{
	}

	public BatchedJoinBlock(int batchSize, GroupingDataflowBlockOptions dataflowBlockOptions)
	{
		if (batchSize < 1)
		{
			throw new ArgumentOutOfRangeException("batchSize", SR1.ArgumentOutOfRange_GenericPositive);
		}
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		if (dataflowBlockOptions.Greedy && dataflowBlockOptions.BoundedCapacity == -1)
		{
			_batchSize = batchSize;
			dataflowBlockOptions = dataflowBlockOptions.DefaultOrClone();
			_source = new SourceCore<Tuple<IList<T1>, IList<T2>, IList<T3>>>(this, dataflowBlockOptions, delegate(ISourceBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>> owningSource)
			{
				((BatchedJoinBlock<T1, T2, T3>)owningSource).CompleteEachTarget();
			});
			Action createBatchAction = delegate
			{
				if (_target1.Count > 0 || _target2.Count > 0 || _target3.Count > 0)
				{
					_source.AddMessage(Tuple.Create(_target1.GetAndEmptyMessages(), _target2.GetAndEmptyMessages(), _target3.GetAndEmptyMessages()));
				}
			};
			_sharedResources = new BatchedJoinBlockTargetSharedResources(batchSize, dataflowBlockOptions, createBatchAction, delegate
			{
				createBatchAction();
				_source.Complete();
			}, _source.AddException, Complete);
			_target1 = new BatchedJoinBlockTarget<T1>(_sharedResources);
			_target2 = new BatchedJoinBlockTarget<T2>(_sharedResources);
			_target3 = new BatchedJoinBlockTarget<T3>(_sharedResources);
			_source.Completion.ContinueWith(delegate(Task completed, object state)
			{
				IDataflowBlock dataflowBlock = (BatchedJoinBlock<T1, T2, T3>)state;
				dataflowBlock.Fault(completed.Exception);
			}, this, CancellationToken.None, Common.GetContinuationOptions() | TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
			Common.WireCancellationToComplete(dataflowBlockOptions.CancellationToken, _source.Completion, delegate(object state)
			{
				((BatchedJoinBlock<T1, T2, T3>)state).CompleteEachTarget();
			}, this);
			DataflowEtwProvider log = DataflowEtwProvider.Log;
			if (log.IsEnabled())
			{
				log.DataflowBlockCreated(this, dataflowBlockOptions);
			}
			return;
		}
		throw new ArgumentException(SR1.Argument_NonGreedyNotSupported, "dataflowBlockOptions");
	}

	public IDisposable LinkTo(ITargetBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>> target, DataflowLinkOptions linkOptions)
	{
		return _source.LinkTo(target, linkOptions);
	}

	public bool TryReceive(Predicate<Tuple<IList<T1>, IList<T2>, IList<T3>>> filter, out Tuple<IList<T1>, IList<T2>, IList<T3>> item)
	{
		return _source.TryReceive(filter, out item);
	}

	public bool TryReceiveAll(out IList<Tuple<IList<T1>, IList<T2>, IList<T3>>> items)
	{
		return _source.TryReceiveAll(out items);
	}

	public void Complete()
	{
		_target1.Complete();
		_target2.Complete();
		_target3.Complete();
	}

	void IDataflowBlock.Fault(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		lock (_sharedResources._incomingLock)
		{
			if (!_sharedResources._decliningPermanently)
			{
				_source.AddException(exception);
			}
		}
		Complete();
	}

	Tuple<IList<T1>, IList<T2>, IList<T3>> ISourceBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>> target, out bool messageConsumed)
	{
		return _source.ConsumeMessage(messageHeader, target, out messageConsumed);
	}

	bool ISourceBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>> target)
	{
		return _source.ReserveMessage(messageHeader, target);
	}

	void ISourceBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<Tuple<IList<T1>, IList<T2>, IList<T3>>> target)
	{
		_source.ReleaseReservation(messageHeader, target);
	}

	private void CompleteEachTarget()
	{
		_target1.Complete();
		_target2.Complete();
		_target3.Complete();
	}

	public override string ToString()
	{
		return Common.GetNameForDebugger(this, _source.DataflowBlockOptions);
	}
}
