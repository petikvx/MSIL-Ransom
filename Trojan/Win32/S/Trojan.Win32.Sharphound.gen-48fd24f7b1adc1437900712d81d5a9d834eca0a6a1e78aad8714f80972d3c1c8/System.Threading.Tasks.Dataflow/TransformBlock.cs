using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow.Internal;

namespace System.Threading.Tasks.Dataflow;

[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
[DebuggerTypeProxy(typeof(TransformBlock<, >.DebugView))]
public sealed class TransformBlock<TInput, TOutput> : ITargetBlock<TInput>, ISourceBlock<TOutput>, IPropagatorBlock<TInput, TOutput>, IReceivableSourceBlock<TOutput>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class DebugView
	{
		private readonly TransformBlock<TInput, TOutput> _transformBlock;

		private readonly TargetCore<TInput>.DebuggingInformation _targetDebuggingInformation;

		private readonly SourceCore<TOutput>.DebuggingInformation _sourceDebuggingInformation;

		public IEnumerable<TInput> InputQueue => _targetDebuggingInformation.InputQueue;

		public QueuedMap<ISourceBlock<TInput>, DataflowMessageHeader> PostponedMessages => _targetDebuggingInformation.PostponedMessages;

		public IEnumerable<TOutput> OutputQueue => _sourceDebuggingInformation.OutputQueue;

		public int CurrentDegreeOfParallelism => _targetDebuggingInformation.CurrentDegreeOfParallelism;

		public Task TaskForOutputProcessing => _sourceDebuggingInformation.TaskForOutputProcessing;

		public ExecutionDataflowBlockOptions DataflowBlockOptions => _targetDebuggingInformation.DataflowBlockOptions;

		public bool IsDecliningPermanently => _targetDebuggingInformation.IsDecliningPermanently;

		public bool IsCompleted => _sourceDebuggingInformation.IsCompleted;

		public int Id => Common.GetBlockId(_transformBlock);

		public TargetRegistry<TOutput> LinkedTargets => _sourceDebuggingInformation.LinkedTargets;

		public ITargetBlock<TOutput> NextMessageReservedFor => _sourceDebuggingInformation.NextMessageReservedFor;

		public DebugView(TransformBlock<TInput, TOutput> transformBlock)
		{
			_transformBlock = transformBlock;
			_targetDebuggingInformation = transformBlock._target.GetDebuggingInformation();
			_sourceDebuggingInformation = transformBlock._source.GetDebuggingInformation();
		}
	}

	private readonly TargetCore<TInput> _target;

	private readonly ReorderingBuffer<TOutput> _reorderingBuffer;

	private readonly SourceCore<TOutput> _source;

	private object ParallelSourceLock => _source;

	public Task Completion => _source.Completion;

	public int InputCount => _target.InputCount;

	public int OutputCount => _source.OutputCount;

	private int InputCountForDebugger => _target.GetDebuggingInformation().InputCount;

	private int OutputCountForDebugger => _source.GetDebuggingInformation().OutputCount;

	private object DebuggerDisplayContent => string.Format("{0}, InputCount={1}, OutputCount={2}", new object[3]
	{
		Common.GetNameForDebugger(this, _source.DataflowBlockOptions),
		InputCountForDebugger,
		OutputCountForDebugger
	});

	object IDebuggerDisplay.Content => DebuggerDisplayContent;

	public TransformBlock(Func<TInput, TOutput> transform)
		: this(transform, (Func<TInput, Task<TOutput>>)null, ExecutionDataflowBlockOptions.Default)
	{
	}

	public TransformBlock(Func<TInput, TOutput> transform, ExecutionDataflowBlockOptions dataflowBlockOptions)
		: this(transform, (Func<TInput, Task<TOutput>>)null, dataflowBlockOptions)
	{
	}

	public TransformBlock(Func<TInput, Task<TOutput>> transform)
		: this((Func<TInput, TOutput>)null, transform, ExecutionDataflowBlockOptions.Default)
	{
	}

	public TransformBlock(Func<TInput, Task<TOutput>> transform, ExecutionDataflowBlockOptions dataflowBlockOptions)
		: this((Func<TInput, TOutput>)null, transform, dataflowBlockOptions)
	{
	}

	private TransformBlock(Func<TInput, TOutput> transformSync, Func<TInput, Task<TOutput>> transformAsync, ExecutionDataflowBlockOptions dataflowBlockOptions)
	{
		TransformBlock<TInput, TOutput> transformBlock = this;
		if (transformSync == null && transformAsync == null)
		{
			throw new ArgumentNullException("transform");
		}
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		dataflowBlockOptions = dataflowBlockOptions.DefaultOrClone();
		Action<ISourceBlock<TOutput>, int> itemsRemovedAction = null;
		if (dataflowBlockOptions.BoundedCapacity > 0)
		{
			itemsRemovedAction = delegate(ISourceBlock<TOutput> owningSource, int count)
			{
				((TransformBlock<TInput, TOutput>)owningSource)._target.ChangeBoundingCount(-count);
			};
		}
		_source = new SourceCore<TOutput>(this, dataflowBlockOptions, delegate(ISourceBlock<TOutput> owningSource)
		{
			((TransformBlock<TInput, TOutput>)owningSource)._target.Complete(null, dropPendingMessages: true);
		}, itemsRemovedAction);
		if (dataflowBlockOptions.SupportsParallelExecution && dataflowBlockOptions.EnsureOrdered)
		{
			_reorderingBuffer = new ReorderingBuffer<TOutput>(this, delegate(object owningSource, TOutput message)
			{
				((TransformBlock<TInput, TOutput>)owningSource)._source.AddMessage(message);
			});
		}
		if (transformSync != null)
		{
			_target = new TargetCore<TInput>(this, delegate(KeyValuePair<TInput, long> messageWithId)
			{
				transformBlock.ProcessMessage(transformSync, messageWithId);
			}, _reorderingBuffer, dataflowBlockOptions, TargetCoreOptions.None);
		}
		else
		{
			_target = new TargetCore<TInput>(this, delegate(KeyValuePair<TInput, long> messageWithId)
			{
				transformBlock.ProcessMessageWithTask(transformAsync, messageWithId);
			}, _reorderingBuffer, dataflowBlockOptions, TargetCoreOptions.UsesAsyncCompletion);
		}
		_target.Completion.ContinueWith(delegate(Task completed, object state)
		{
			SourceCore<TOutput> sourceCore = (SourceCore<TOutput>)state;
			if (completed.IsFaulted)
			{
				sourceCore.AddAndUnwrapAggregateException(completed.Exception);
			}
			sourceCore.Complete();
		}, _source, CancellationToken.None, Common.GetContinuationOptions(), TaskScheduler.Default);
		_source.Completion.ContinueWith(delegate(Task completed, object state)
		{
			IDataflowBlock dataflowBlock = (TransformBlock<TInput, TOutput>)state;
			dataflowBlock.Fault(completed.Exception);
		}, this, CancellationToken.None, Common.GetContinuationOptions() | TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
		Common.WireCancellationToComplete(dataflowBlockOptions.CancellationToken, Completion, delegate(object state)
		{
			((TargetCore<TInput>)state).Complete(null, dropPendingMessages: true);
		}, _target);
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockCreated(this, dataflowBlockOptions);
		}
	}

	private void ProcessMessage(Func<TInput, TOutput> transform, KeyValuePair<TInput, long> messageWithId)
	{
		TOutput item = default(TOutput);
		bool flag = false;
		try
		{
			item = transform(messageWithId.Key);
			flag = true;
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
			if (!flag)
			{
				_target.ChangeBoundingCount(-1);
			}
			if (_reorderingBuffer == null)
			{
				if (flag)
				{
					if (_target.DataflowBlockOptions.MaxDegreeOfParallelism == 1)
					{
						_source.AddMessage(item);
					}
					else
					{
						lock (ParallelSourceLock)
						{
							_source.AddMessage(item);
						}
					}
				}
			}
			else
			{
				_reorderingBuffer.AddItem(messageWithId.Value, item, flag);
			}
		}
	}

	private void ProcessMessageWithTask(Func<TInput, Task<TOutput>> transform, KeyValuePair<TInput, long> messageWithId)
	{
		Task<TOutput> task = null;
		Exception ex = null;
		try
		{
			task = transform(messageWithId.Key);
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
				_target.Complete(ex, dropPendingMessages: true, storeExceptionEvenIfAlreadyCompleting: true);
			}
			if (_reorderingBuffer != null)
			{
				_reorderingBuffer.IgnoreItem(messageWithId.Value);
			}
			_target.SignalOneAsyncMessageCompleted(-1);
		}
		else
		{
			task.ContinueWith(delegate(Task<TOutput> completed, object state)
			{
				Tuple<TransformBlock<TInput, TOutput>, KeyValuePair<TInput, long>> tuple = (Tuple<TransformBlock<TInput, TOutput>, KeyValuePair<TInput, long>>)state;
				tuple.Item1.AsyncCompleteProcessMessageWithTask(completed, tuple.Item2);
			}, Tuple.Create(this, messageWithId), CancellationToken.None, Common.GetContinuationOptions(TaskContinuationOptions.ExecuteSynchronously), TaskScheduler.Default);
		}
	}

	private void AsyncCompleteProcessMessageWithTask(Task<TOutput> completed, KeyValuePair<TInput, long> messageWithId)
	{
		bool isBounded = _target.IsBounded;
		bool flag = false;
		TOutput item = default(TOutput);
		switch (completed.Status)
		{
		case TaskStatus.Faulted:
		{
			AggregateException exception = completed.Exception;
			Common.StoreDataflowMessageValueIntoExceptionData(exception, messageWithId.Key, targetInnerExceptions: true);
			_target.Complete(exception, dropPendingMessages: true, storeExceptionEvenIfAlreadyCompleting: true, unwrapInnerExceptions: true);
			break;
		}
		case TaskStatus.RanToCompletion:
			item = completed.Result;
			flag = true;
			break;
		}
		if (!flag && isBounded)
		{
			_target.ChangeBoundingCount(-1);
		}
		if (_reorderingBuffer == null)
		{
			if (flag)
			{
				if (_target.DataflowBlockOptions.MaxDegreeOfParallelism == 1)
				{
					_source.AddMessage(item);
				}
				else
				{
					lock (ParallelSourceLock)
					{
						_source.AddMessage(item);
					}
				}
			}
		}
		else
		{
			_reorderingBuffer.AddItem(messageWithId.Value, item, flag);
		}
		_target.SignalOneAsyncMessageCompleted();
	}

	public void Complete()
	{
		_target.Complete(null, dropPendingMessages: false);
	}

	void IDataflowBlock.Fault(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		_target.Complete(exception, dropPendingMessages: true);
	}

	public IDisposable LinkTo(ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions)
	{
		return _source.LinkTo(target, linkOptions);
	}

	public bool TryReceive(Predicate<TOutput> filter, out TOutput item)
	{
		return _source.TryReceive(filter, out item);
	}

	public bool TryReceiveAll(out IList<TOutput> items)
	{
		return _source.TryReceiveAll(out items);
	}

	DataflowMessageStatus ITargetBlock<TInput>.OfferMessage(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept)
	{
		return _target.OfferMessage(messageHeader, messageValue, source, consumeToAccept);
	}

	TOutput ISourceBlock<TOutput>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target, out bool messageConsumed)
	{
		return _source.ConsumeMessage(messageHeader, target, out messageConsumed);
	}

	bool ISourceBlock<TOutput>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target)
	{
		return _source.ReserveMessage(messageHeader, target);
	}

	void ISourceBlock<TOutput>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target)
	{
		_source.ReleaseReservation(messageHeader, target);
	}

	public override string ToString()
	{
		return Common.GetNameForDebugger(this, _source.DataflowBlockOptions);
	}
}
