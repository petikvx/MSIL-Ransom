using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks.Dataflow.Internal;

namespace System.Threading.Tasks.Dataflow;

[DebuggerTypeProxy(typeof(TransformManyBlock<, >.DebugView))]
[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
public sealed class TransformManyBlock<TInput, TOutput> : ITargetBlock<TInput>, ISourceBlock<TOutput>, IPropagatorBlock<TInput, TOutput>, IReceivableSourceBlock<TOutput>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class DebugView
	{
		private readonly TransformManyBlock<TInput, TOutput> _transformManyBlock;

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

		public int Id => Common.GetBlockId(_transformManyBlock);

		public TargetRegistry<TOutput> LinkedTargets => _sourceDebuggingInformation.LinkedTargets;

		public ITargetBlock<TOutput> NextMessageReservedFor => _sourceDebuggingInformation.NextMessageReservedFor;

		public DebugView(TransformManyBlock<TInput, TOutput> transformManyBlock)
		{
			_transformManyBlock = transformManyBlock;
			_targetDebuggingInformation = transformManyBlock._target.GetDebuggingInformation();
			_sourceDebuggingInformation = transformManyBlock._source.GetDebuggingInformation();
		}
	}

	private readonly TargetCore<TInput> _target;

	private readonly ReorderingBuffer<IEnumerable<TOutput>> _reorderingBuffer;

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

	public TransformManyBlock(Func<TInput, IEnumerable<TOutput>> transform)
		: this(transform, (Func<TInput, Task<IEnumerable<TOutput>>>)null, ExecutionDataflowBlockOptions.Default)
	{
	}

	public TransformManyBlock(Func<TInput, IEnumerable<TOutput>> transform, ExecutionDataflowBlockOptions dataflowBlockOptions)
		: this(transform, (Func<TInput, Task<IEnumerable<TOutput>>>)null, dataflowBlockOptions)
	{
	}

	public TransformManyBlock(Func<TInput, Task<IEnumerable<TOutput>>> transform)
		: this((Func<TInput, IEnumerable<TOutput>>)null, transform, ExecutionDataflowBlockOptions.Default)
	{
	}

	public TransformManyBlock(Func<TInput, Task<IEnumerable<TOutput>>> transform, ExecutionDataflowBlockOptions dataflowBlockOptions)
		: this((Func<TInput, IEnumerable<TOutput>>)null, transform, dataflowBlockOptions)
	{
	}

	private TransformManyBlock(Func<TInput, IEnumerable<TOutput>> transformSync, Func<TInput, Task<IEnumerable<TOutput>>> transformAsync, ExecutionDataflowBlockOptions dataflowBlockOptions)
	{
		TransformManyBlock<TInput, TOutput> transformManyBlock = this;
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
				((TransformManyBlock<TInput, TOutput>)owningSource)._target.ChangeBoundingCount(-count);
			};
		}
		_source = new SourceCore<TOutput>(this, dataflowBlockOptions, delegate(ISourceBlock<TOutput> owningSource)
		{
			((TransformManyBlock<TInput, TOutput>)owningSource)._target.Complete(null, dropPendingMessages: true);
		}, itemsRemovedAction);
		if (dataflowBlockOptions.SupportsParallelExecution && dataflowBlockOptions.EnsureOrdered)
		{
			_reorderingBuffer = new ReorderingBuffer<IEnumerable<TOutput>>(this, delegate(object source, IEnumerable<TOutput> messages)
			{
				((TransformManyBlock<TInput, TOutput>)source)._source.AddMessages(messages);
			});
		}
		if (transformSync != null)
		{
			_target = new TargetCore<TInput>(this, delegate(KeyValuePair<TInput, long> messageWithId)
			{
				transformManyBlock.ProcessMessage(transformSync, messageWithId);
			}, _reorderingBuffer, dataflowBlockOptions, TargetCoreOptions.None);
		}
		else
		{
			_target = new TargetCore<TInput>(this, delegate(KeyValuePair<TInput, long> messageWithId)
			{
				transformManyBlock.ProcessMessageWithTask(transformAsync, messageWithId);
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
			IDataflowBlock dataflowBlock = (TransformManyBlock<TInput, TOutput>)state;
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

	private void ProcessMessage(Func<TInput, IEnumerable<TOutput>> transformFunction, KeyValuePair<TInput, long> messageWithId)
	{
		bool flag = false;
		try
		{
			IEnumerable<TOutput> outputItems = transformFunction(messageWithId.Key);
			flag = true;
			StoreOutputItems(messageWithId, outputItems);
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
				StoreOutputItems(messageWithId, null);
			}
		}
	}

	private void ProcessMessageWithTask(Func<TInput, Task<IEnumerable<TOutput>>> function, KeyValuePair<TInput, long> messageWithId)
	{
		Task<IEnumerable<TOutput>> task = null;
		Exception ex = null;
		try
		{
			task = function(messageWithId.Key);
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
				StoreOutputItems(messageWithId, null);
				_target.SignalOneAsyncMessageCompleted();
			}
			else
			{
				_target.SignalOneAsyncMessageCompleted(-1);
			}
		}
		else
		{
			task.ContinueWith(delegate(Task<IEnumerable<TOutput>> completed, object state)
			{
				Tuple<TransformManyBlock<TInput, TOutput>, KeyValuePair<TInput, long>> tuple = (Tuple<TransformManyBlock<TInput, TOutput>, KeyValuePair<TInput, long>>)state;
				tuple.Item1.AsyncCompleteProcessMessageWithTask(completed, tuple.Item2);
			}, Tuple.Create(this, messageWithId), CancellationToken.None, Common.GetContinuationOptions(TaskContinuationOptions.ExecuteSynchronously), _source.DataflowBlockOptions.TaskScheduler);
		}
	}

	private void AsyncCompleteProcessMessageWithTask(Task<IEnumerable<TOutput>> completed, KeyValuePair<TInput, long> messageWithId)
	{
		switch (completed.Status)
		{
		case TaskStatus.RanToCompletion:
		{
			IEnumerable<TOutput> result = completed.Result;
			try
			{
				StoreOutputItems(messageWithId, result);
			}
			catch (Exception ex)
			{
				if (!Common.IsCooperativeCancellation(ex))
				{
					Common.StoreDataflowMessageValueIntoExceptionData(ex, messageWithId.Key);
					_target.Complete(ex, dropPendingMessages: true, storeExceptionEvenIfAlreadyCompleting: true);
				}
			}
			break;
		}
		case TaskStatus.Faulted:
		{
			AggregateException exception = completed.Exception;
			Common.StoreDataflowMessageValueIntoExceptionData(exception, messageWithId.Key, targetInnerExceptions: true);
			_target.Complete(exception, dropPendingMessages: true, storeExceptionEvenIfAlreadyCompleting: true, unwrapInnerExceptions: true);
			goto case TaskStatus.Canceled;
		}
		case TaskStatus.Canceled:
			StoreOutputItems(messageWithId, null);
			break;
		}
		_target.SignalOneAsyncMessageCompleted();
	}

	private void StoreOutputItems(KeyValuePair<TInput, long> messageWithId, IEnumerable<TOutput> outputItems)
	{
		if (_reorderingBuffer != null)
		{
			StoreOutputItemsReordered(messageWithId.Value, outputItems);
		}
		else if (outputItems != null)
		{
			if (!(outputItems is TOutput[]) && !(outputItems is List<TOutput>))
			{
				StoreOutputItemsNonReorderedWithIteration(outputItems);
			}
			else
			{
				StoreOutputItemsNonReorderedAtomic(outputItems);
			}
		}
		else if (_target.IsBounded)
		{
			_target.ChangeBoundingCount(-1);
		}
	}

	private void StoreOutputItemsReordered(long id, IEnumerable<TOutput> item)
	{
		TargetCore<TInput> target = _target;
		bool isBounded = target.IsBounded;
		if (item == null)
		{
			_reorderingBuffer.AddItem(id, null, itemIsValid: false);
			if (isBounded)
			{
				target.ChangeBoundingCount(-1);
			}
			return;
		}
		IList<TOutput> list = item as TOutput[];
		if (list == null)
		{
			list = item as List<TOutput>;
		}
		if (list != null && isBounded)
		{
			UpdateBoundingCountWithOutputCount(list.Count);
		}
		bool? flag = _reorderingBuffer.AddItemIfNextAndTrusted(id, list, list != null);
		if (!flag.HasValue)
		{
			return;
		}
		bool value = flag.Value;
		List<TOutput> list2 = null;
		try
		{
			if (value)
			{
				StoreOutputItemsNonReorderedWithIteration(item);
				return;
			}
			if (list == null)
			{
				int count = 0;
				try
				{
					list2 = Enumerable.ToList(item);
					count = list2.Count;
					return;
				}
				finally
				{
					if (isBounded)
					{
						UpdateBoundingCountWithOutputCount(count);
					}
				}
			}
			list2 = Enumerable.ToList(list);
		}
		finally
		{
			_reorderingBuffer.AddItem(id, list2, list2 != null);
		}
	}

	private void StoreOutputItemsNonReorderedAtomic(IEnumerable<TOutput> outputItems)
	{
		if (_target.IsBounded)
		{
			UpdateBoundingCountWithOutputCount(((ICollection<TOutput>)outputItems).Count);
		}
		if (_target.DataflowBlockOptions.MaxDegreeOfParallelism == 1)
		{
			_source.AddMessages(outputItems);
			return;
		}
		lock (ParallelSourceLock)
		{
			_source.AddMessages(outputItems);
		}
	}

	private void StoreOutputItemsNonReorderedWithIteration(IEnumerable<TOutput> outputItems)
	{
		bool flag = _target.DataflowBlockOptions.MaxDegreeOfParallelism == 1 || _reorderingBuffer != null;
		if (_target.IsBounded)
		{
			bool flag2 = false;
			try
			{
				foreach (TOutput outputItem in outputItems)
				{
					if (flag2)
					{
						_target.ChangeBoundingCount(1);
					}
					else
					{
						flag2 = true;
					}
					if (flag)
					{
						_source.AddMessage(outputItem);
						continue;
					}
					lock (ParallelSourceLock)
					{
						_source.AddMessage(outputItem);
					}
				}
				return;
			}
			finally
			{
				if (!flag2)
				{
					_target.ChangeBoundingCount(-1);
				}
			}
		}
		if (flag)
		{
			foreach (TOutput outputItem2 in outputItems)
			{
				_source.AddMessage(outputItem2);
			}
			return;
		}
		foreach (TOutput outputItem3 in outputItems)
		{
			lock (ParallelSourceLock)
			{
				_source.AddMessage(outputItem3);
			}
		}
	}

	private void UpdateBoundingCountWithOutputCount(int count)
	{
		if (count > 1)
		{
			_target.ChangeBoundingCount(count - 1);
		}
		else if (count == 0)
		{
			_target.ChangeBoundingCount(-1);
		}
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
