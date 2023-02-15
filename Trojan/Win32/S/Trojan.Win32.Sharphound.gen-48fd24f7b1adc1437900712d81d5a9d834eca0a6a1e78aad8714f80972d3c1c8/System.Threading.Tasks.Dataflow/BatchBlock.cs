using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks.Dataflow.Internal;

namespace System.Threading.Tasks.Dataflow;

[DebuggerTypeProxy(typeof(BatchBlock<>.DebugView))]
[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
public sealed class BatchBlock<T> : ITargetBlock<T>, IPropagatorBlock<T, T[]>, ISourceBlock<T[]>, IReceivableSourceBlock<T[]>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class DebugView
	{
		private BatchBlock<T> _batchBlock;

		private readonly BatchBlockTargetCore.DebuggingInformation _targetDebuggingInformation;

		private readonly SourceCore<T[]>.DebuggingInformation _sourceDebuggingInformation;

		public IEnumerable<T> InputQueue => _targetDebuggingInformation.InputQueue;

		public IEnumerable<T[]> OutputQueue => _sourceDebuggingInformation.OutputQueue;

		public long BatchesCompleted => _targetDebuggingInformation.NumberOfBatchesCompleted;

		public Task TaskForInputProcessing => _targetDebuggingInformation.TaskForInputProcessing;

		public Task TaskForOutputProcessing => _sourceDebuggingInformation.TaskForOutputProcessing;

		public GroupingDataflowBlockOptions DataflowBlockOptions => _targetDebuggingInformation.DataflowBlockOptions;

		public int BatchSize => _batchBlock.BatchSize;

		public bool IsDecliningPermanently => _targetDebuggingInformation.IsDecliningPermanently;

		public bool IsCompleted => _sourceDebuggingInformation.IsCompleted;

		public int Id => Common.GetBlockId(_batchBlock);

		public QueuedMap<ISourceBlock<T>, DataflowMessageHeader> PostponedMessages => _targetDebuggingInformation.PostponedMessages;

		public TargetRegistry<T[]> LinkedTargets => _sourceDebuggingInformation.LinkedTargets;

		public ITargetBlock<T[]> NextMessageReservedFor => _sourceDebuggingInformation.NextMessageReservedFor;

		public DebugView(BatchBlock<T> batchBlock)
		{
			_batchBlock = batchBlock;
			_targetDebuggingInformation = batchBlock._target.GetDebuggingInformation();
			_sourceDebuggingInformation = batchBlock._source.GetDebuggingInformation();
		}
	}

	[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
	private sealed class BatchBlockTargetCore
	{
		private sealed class NonGreedyState
		{
			internal readonly QueuedMap<ISourceBlock<T>, DataflowMessageHeader> PostponedMessages;

			internal readonly KeyValuePair<ISourceBlock<T>, DataflowMessageHeader>[] PostponedMessagesTemp;

			internal readonly List<KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>> ReservedSourcesTemp;

			internal bool AcceptFewerThanBatchSize;

			internal Task TaskForInputProcessing;

			internal NonGreedyState(int batchSize)
			{
				PostponedMessages = new QueuedMap<ISourceBlock<T>, DataflowMessageHeader>(batchSize);
				PostponedMessagesTemp = new KeyValuePair<ISourceBlock<T>, DataflowMessageHeader>[batchSize];
				ReservedSourcesTemp = new List<KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>>(batchSize);
			}
		}

		internal sealed class DebuggingInformation
		{
			private BatchBlockTargetCore _target;

			public IEnumerable<T> InputQueue => Enumerable.ToList(_target._messages);

			public Task TaskForInputProcessing
			{
				get
				{
					if (_target._nonGreedyState == null)
					{
						return null;
					}
					return _target._nonGreedyState.TaskForInputProcessing;
				}
			}

			public QueuedMap<ISourceBlock<T>, DataflowMessageHeader> PostponedMessages
			{
				get
				{
					if (_target._nonGreedyState == null)
					{
						return null;
					}
					return _target._nonGreedyState.PostponedMessages;
				}
			}

			public bool IsDecliningPermanently => _target._decliningPermanently;

			public GroupingDataflowBlockOptions DataflowBlockOptions => _target._dataflowBlockOptions;

			public long NumberOfBatchesCompleted => _target._batchesCompleted;

			public DebuggingInformation(BatchBlockTargetCore target)
			{
				_target = target;
			}
		}

		private readonly Queue<T> _messages = new Queue<T>();

		private readonly TaskCompletionSource<VoidResult> _completionTask = new TaskCompletionSource<VoidResult>();

		private readonly BatchBlock<T> _owningBatch;

		private readonly int _batchSize;

		private readonly NonGreedyState _nonGreedyState;

		private readonly BoundingState _boundingState;

		private readonly GroupingDataflowBlockOptions _dataflowBlockOptions;

		private readonly Action<T[]> _batchCompletedAction;

		private bool _decliningPermanently;

		private long _batchesCompleted;

		private bool _completionReserved;

		private object IncomingLock => _completionTask;

		internal Task Completion => _completionTask.Task;

		internal int BatchSize => _batchSize;

		private bool CanceledOrFaulted
		{
			get
			{
				if (!_dataflowBlockOptions.CancellationToken.IsCancellationRequested)
				{
					return _owningBatch._source.HasExceptions;
				}
				return true;
			}
		}

		private int BoundedCapacityAvailable
		{
			get
			{
				if (_boundingState == null)
				{
					return _batchSize;
				}
				return _dataflowBlockOptions.BoundedCapacity - _boundingState.CurrentCount;
			}
		}

		private bool BatchesNeedProcessing
		{
			get
			{
				bool flag = _batchesCompleted >= _dataflowBlockOptions.ActualMaxNumberOfGroups;
				bool flag2 = _nonGreedyState != null && _nonGreedyState.TaskForInputProcessing != null;
				if (!(flag || flag2) && !CanceledOrFaulted)
				{
					int num = _batchSize - _messages.Count;
					int boundedCapacityAvailable = BoundedCapacityAvailable;
					if (num <= 0)
					{
						return true;
					}
					if (_nonGreedyState != null)
					{
						if (_nonGreedyState.AcceptFewerThanBatchSize && (_messages.Count > 0 || (_nonGreedyState.PostponedMessages.Count > 0 && boundedCapacityAvailable > 0)))
						{
							return true;
						}
						if (_dataflowBlockOptions.Greedy)
						{
							if (_nonGreedyState.PostponedMessages.Count > 0 && boundedCapacityAvailable > 0)
							{
								return true;
							}
						}
						else if (_nonGreedyState.PostponedMessages.Count >= num && boundedCapacityAvailable >= num)
						{
							return true;
						}
					}
					return false;
				}
				return false;
			}
		}

		private int InputCountForDebugger => _messages.Count;

		private object DebuggerDisplayContent
		{
			get
			{
				IDebuggerDisplay owningBatch = _owningBatch;
				return $"Block=\"{((owningBatch != null) ? owningBatch.Content : _owningBatch)}\"";
			}
		}

		internal BatchBlockTargetCore(BatchBlock<T> owningBatch, int batchSize, Action<T[]> batchCompletedAction, GroupingDataflowBlockOptions dataflowBlockOptions)
		{
			_owningBatch = owningBatch;
			_batchSize = batchSize;
			_batchCompletedAction = batchCompletedAction;
			_dataflowBlockOptions = dataflowBlockOptions;
			bool flag = dataflowBlockOptions.BoundedCapacity > 0;
			if (!_dataflowBlockOptions.Greedy || flag)
			{
				_nonGreedyState = new NonGreedyState(batchSize);
			}
			if (flag)
			{
				_boundingState = new BoundingState(dataflowBlockOptions.BoundedCapacity);
			}
		}

		internal void TriggerBatch()
		{
			lock (IncomingLock)
			{
				if (!_decliningPermanently && !_dataflowBlockOptions.CancellationToken.IsCancellationRequested)
				{
					if (_nonGreedyState == null)
					{
						MakeBatchIfPossible(evenIfFewerThanBatchSize: true);
					}
					else
					{
						_nonGreedyState.AcceptFewerThanBatchSize = true;
						ProcessAsyncIfNecessary();
					}
				}
				CompleteBlockIfPossible();
			}
		}

		internal DataflowMessageStatus OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept)
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
				if (_dataflowBlockOptions.Greedy && (_boundingState == null || (_boundingState.CountIsLessThanBound && _nonGreedyState.PostponedMessages.Count == 0 && _nonGreedyState.TaskForInputProcessing == null)))
				{
					if (consumeToAccept)
					{
						messageValue = source.ConsumeMessage(messageHeader, _owningBatch, out var messageConsumed);
						if (!messageConsumed)
						{
							return DataflowMessageStatus.NotAvailable;
						}
					}
					_messages.Enqueue(messageValue);
					if (_boundingState != null)
					{
						_boundingState.CurrentCount++;
					}
					if (!_decliningPermanently && _batchesCompleted + _messages.Count / _batchSize >= _dataflowBlockOptions.ActualMaxNumberOfGroups)
					{
						_decliningPermanently = true;
					}
					MakeBatchIfPossible(evenIfFewerThanBatchSize: false);
					CompleteBlockIfPossible();
					return DataflowMessageStatus.Accepted;
				}
				if (source != null)
				{
					_nonGreedyState.PostponedMessages.Push(source, messageHeader);
					if (!_dataflowBlockOptions.Greedy)
					{
						ProcessAsyncIfNecessary();
					}
					return DataflowMessageStatus.Postponed;
				}
				return DataflowMessageStatus.Declined;
			}
		}

		internal void Complete(Exception exception, bool dropPendingMessages, bool releaseReservedMessages, bool revertProcessingState = false)
		{
			lock (IncomingLock)
			{
				if (exception != null && (!_decliningPermanently || releaseReservedMessages))
				{
					_owningBatch._source.AddException(exception);
				}
				if (dropPendingMessages)
				{
					_messages.Clear();
				}
			}
			if (releaseReservedMessages)
			{
				try
				{
					ReleaseReservedMessages(throwOnFirstException: false);
				}
				catch (Exception exception2)
				{
					_owningBatch._source.AddException(exception2);
				}
			}
			lock (IncomingLock)
			{
				if (revertProcessingState)
				{
					_nonGreedyState.TaskForInputProcessing = null;
				}
				_decliningPermanently = true;
				CompleteBlockIfPossible();
			}
		}

		private void CompleteBlockIfPossible()
		{
			if (_completionReserved)
			{
				return;
			}
			bool flag = _nonGreedyState != null && _nonGreedyState.TaskForInputProcessing != null;
			bool flag2 = _batchesCompleted >= _dataflowBlockOptions.ActualMaxNumberOfGroups;
			bool flag3 = _decliningPermanently && _messages.Count < _batchSize;
			if (flag || (!(flag2 || flag3) && !CanceledOrFaulted))
			{
				return;
			}
			_completionReserved = true;
			_decliningPermanently = true;
			if (_messages.Count > 0)
			{
				MakeBatchIfPossible(evenIfFewerThanBatchSize: true);
			}
			Task.Factory.StartNew(delegate(object thisTargetCore)
			{
				BatchBlockTargetCore batchBlockTargetCore = (BatchBlockTargetCore)thisTargetCore;
				List<Exception> exceptions = null;
				if (batchBlockTargetCore._nonGreedyState != null)
				{
					Common.ReleaseAllPostponedMessages(batchBlockTargetCore._owningBatch, batchBlockTargetCore._nonGreedyState.PostponedMessages, ref exceptions);
				}
				if (exceptions != null)
				{
					batchBlockTargetCore._owningBatch._source.AddExceptions(exceptions);
				}
				batchBlockTargetCore._completionTask.TrySetResult(default(VoidResult));
			}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}

		private void ProcessAsyncIfNecessary(bool isReplacementReplica = false)
		{
			if (BatchesNeedProcessing)
			{
				ProcessAsyncIfNecessary_Slow(isReplacementReplica);
			}
		}

		private void ProcessAsyncIfNecessary_Slow(bool isReplacementReplica)
		{
			_nonGreedyState.TaskForInputProcessing = new Task(delegate(object thisBatchTarget)
			{
				((BatchBlockTargetCore)thisBatchTarget).ProcessMessagesLoopCore();
			}, this, Common.GetCreationOptionsForTask(isReplacementReplica));
			DataflowEtwProvider log = DataflowEtwProvider.Log;
			if (log.IsEnabled())
			{
				log.TaskLaunchedForMessageHandling(_owningBatch, _nonGreedyState.TaskForInputProcessing, DataflowEtwProvider.TaskLaunchedReason.ProcessingInputMessages, _messages.Count + _nonGreedyState.PostponedMessages.Count);
			}
			Exception ex = Common.StartTaskSafe(_nonGreedyState.TaskForInputProcessing, _dataflowBlockOptions.TaskScheduler);
			if (ex != null)
			{
				Task.Factory.StartNew(delegate(object exc)
				{
					Complete((Exception)exc, dropPendingMessages: true, releaseReservedMessages: true, revertProcessingState: true);
				}, ex, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
			}
		}

		private void ProcessMessagesLoopCore()
		{
			try
			{
				int actualMaxMessagesPerTask = _dataflowBlockOptions.ActualMaxMessagesPerTask;
				int num = 0;
				bool flag2;
				do
				{
					bool flag = Volatile.Read(ref _nonGreedyState.AcceptFewerThanBatchSize);
					if (_dataflowBlockOptions.Greedy)
					{
						RetrievePostponedItemsGreedyBounded(flag);
					}
					else
					{
						RetrievePostponedItemsNonGreedy(flag);
					}
					lock (IncomingLock)
					{
						if ((flag2 = MakeBatchIfPossible(flag)) || flag)
						{
							_nonGreedyState.AcceptFewerThanBatchSize = false;
						}
					}
					num++;
				}
				while (flag2 && num < actualMaxMessagesPerTask);
			}
			catch (Exception exception)
			{
				Complete(exception, dropPendingMessages: false, releaseReservedMessages: true);
			}
			finally
			{
				lock (IncomingLock)
				{
					_nonGreedyState.TaskForInputProcessing = null;
					ProcessAsyncIfNecessary(isReplacementReplica: true);
					CompleteBlockIfPossible();
				}
			}
		}

		private bool MakeBatchIfPossible(bool evenIfFewerThanBatchSize)
		{
			bool flag;
			if (!(flag = _messages.Count >= _batchSize) && (!evenIfFewerThanBatchSize || _messages.Count <= 0))
			{
				return false;
			}
			T[] array = new T[flag ? _batchSize : _messages.Count];
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = _messages.Dequeue();
			}
			_batchCompletedAction(array);
			_batchesCompleted++;
			if (_batchesCompleted >= _dataflowBlockOptions.ActualMaxNumberOfGroups)
			{
				_decliningPermanently = true;
			}
			return true;
		}

		private void RetrievePostponedItemsNonGreedy(bool allowFewerThanBatchSize)
		{
			QueuedMap<ISourceBlock<T>, DataflowMessageHeader> postponedMessages = _nonGreedyState.PostponedMessages;
			KeyValuePair<ISourceBlock<T>, DataflowMessageHeader>[] postponedMessagesTemp = _nonGreedyState.PostponedMessagesTemp;
			List<KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>> reservedSourcesTemp = _nonGreedyState.ReservedSourcesTemp;
			reservedSourcesTemp.Clear();
			int num;
			lock (IncomingLock)
			{
				int boundedCapacityAvailable = BoundedCapacityAvailable;
				if (_decliningPermanently || postponedMessages.Count == 0 || boundedCapacityAvailable <= 0 || (!allowFewerThanBatchSize && (postponedMessages.Count < _batchSize || boundedCapacityAvailable < _batchSize)))
				{
					return;
				}
				num = postponedMessages.PopRange(postponedMessagesTemp, 0, _batchSize);
			}
			for (int i = 0; i < num; i++)
			{
				KeyValuePair<ISourceBlock<T>, DataflowMessageHeader> keyValuePair = postponedMessagesTemp[i];
				if (keyValuePair.Key.ReserveMessage(keyValuePair.Value, _owningBatch))
				{
					KeyValuePair<DataflowMessageHeader, T> value = new KeyValuePair<DataflowMessageHeader, T>(keyValuePair.Value, default(T));
					KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>> item = new KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>(keyValuePair.Key, value);
					reservedSourcesTemp.Add(item);
				}
			}
			Array.Clear(postponedMessagesTemp, 0, postponedMessagesTemp.Length);
			while (reservedSourcesTemp.Count < _batchSize)
			{
				KeyValuePair<ISourceBlock<T>, DataflowMessageHeader> item2;
				lock (IncomingLock)
				{
					if (!postponedMessages.TryPop(out item2))
					{
						break;
					}
				}
				if (item2.Key.ReserveMessage(item2.Value, _owningBatch))
				{
					KeyValuePair<DataflowMessageHeader, T> value2 = new KeyValuePair<DataflowMessageHeader, T>(item2.Value, default(T));
					KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>> item3 = new KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>(item2.Key, value2);
					reservedSourcesTemp.Add(item3);
				}
			}
			if (reservedSourcesTemp.Count > 0)
			{
				bool flag = true;
				if (allowFewerThanBatchSize)
				{
					lock (IncomingLock)
					{
						if (!_decliningPermanently && _batchesCompleted + 1L >= _dataflowBlockOptions.ActualMaxNumberOfGroups)
						{
							flag = !_decliningPermanently;
							_decliningPermanently = true;
						}
					}
				}
				if (flag && (allowFewerThanBatchSize || reservedSourcesTemp.Count == _batchSize))
				{
					ConsumeReservedMessagesNonGreedy();
				}
				else
				{
					ReleaseReservedMessages(throwOnFirstException: true);
				}
			}
			reservedSourcesTemp.Clear();
		}

		private void RetrievePostponedItemsGreedyBounded(bool allowFewerThanBatchSize)
		{
			QueuedMap<ISourceBlock<T>, DataflowMessageHeader> postponedMessages = _nonGreedyState.PostponedMessages;
			KeyValuePair<ISourceBlock<T>, DataflowMessageHeader>[] postponedMessagesTemp = _nonGreedyState.PostponedMessagesTemp;
			List<KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>> reservedSourcesTemp = _nonGreedyState.ReservedSourcesTemp;
			reservedSourcesTemp.Clear();
			int num;
			int num2;
			lock (IncomingLock)
			{
				int boundedCapacityAvailable = BoundedCapacityAvailable;
				num = _batchSize - _messages.Count;
				if (_decliningPermanently || postponedMessages.Count == 0 || boundedCapacityAvailable <= 0)
				{
					return;
				}
				if (boundedCapacityAvailable < num)
				{
					num = boundedCapacityAvailable;
				}
				num2 = postponedMessages.PopRange(postponedMessagesTemp, 0, num);
			}
			for (int i = 0; i < num2; i++)
			{
				KeyValuePair<ISourceBlock<T>, DataflowMessageHeader> keyValuePair = postponedMessagesTemp[i];
				KeyValuePair<DataflowMessageHeader, T> value = new KeyValuePair<DataflowMessageHeader, T>(keyValuePair.Value, default(T));
				KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>> item = new KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>(keyValuePair.Key, value);
				reservedSourcesTemp.Add(item);
			}
			Array.Clear(postponedMessagesTemp, 0, postponedMessagesTemp.Length);
			while (reservedSourcesTemp.Count < num)
			{
				KeyValuePair<ISourceBlock<T>, DataflowMessageHeader> item2;
				lock (IncomingLock)
				{
					if (!postponedMessages.TryPop(out item2))
					{
						break;
					}
				}
				KeyValuePair<DataflowMessageHeader, T> value2 = new KeyValuePair<DataflowMessageHeader, T>(item2.Value, default(T));
				KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>> item3 = new KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>(item2.Key, value2);
				reservedSourcesTemp.Add(item3);
			}
			if (reservedSourcesTemp.Count > 0)
			{
				bool flag = true;
				if (allowFewerThanBatchSize)
				{
					lock (IncomingLock)
					{
						if (!_decliningPermanently && _batchesCompleted + 1L >= _dataflowBlockOptions.ActualMaxNumberOfGroups)
						{
							flag = !_decliningPermanently;
							_decliningPermanently = true;
						}
					}
				}
				if (flag)
				{
					ConsumeReservedMessagesGreedyBounded();
				}
			}
			reservedSourcesTemp.Clear();
		}

		private void ConsumeReservedMessagesNonGreedy()
		{
			List<KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>> reservedSourcesTemp = _nonGreedyState.ReservedSourcesTemp;
			int num = 0;
			while (true)
			{
				if (num < reservedSourcesTemp.Count)
				{
					KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>> keyValuePair = reservedSourcesTemp[num];
					reservedSourcesTemp[num] = default(KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>);
					bool messageConsumed;
					T value = keyValuePair.Key.ConsumeMessage(keyValuePair.Value.Key, _owningBatch, out messageConsumed);
					if (!messageConsumed)
					{
						break;
					}
					KeyValuePair<DataflowMessageHeader, T> value2 = new KeyValuePair<DataflowMessageHeader, T>(keyValuePair.Value.Key, value);
					KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>> keyValuePair3 = (reservedSourcesTemp[num] = new KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>(keyValuePair.Key, value2));
					num++;
					continue;
				}
				lock (IncomingLock)
				{
					if (_boundingState != null)
					{
						_boundingState.CurrentCount += reservedSourcesTemp.Count;
					}
					foreach (KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>> item in reservedSourcesTemp)
					{
						_messages.Enqueue(item.Value.Value);
					}
					return;
				}
			}
			for (int i = 0; i < num; i++)
			{
				reservedSourcesTemp[i] = default(KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>);
			}
			throw new InvalidOperationException(SR1.InvalidOperation_FailedToConsumeReservedMessage);
		}

		private void ConsumeReservedMessagesGreedyBounded()
		{
			int num = 0;
			List<KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>> reservedSourcesTemp = _nonGreedyState.ReservedSourcesTemp;
			for (int i = 0; i < reservedSourcesTemp.Count; i++)
			{
				KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>> keyValuePair = reservedSourcesTemp[i];
				reservedSourcesTemp[i] = default(KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>);
				bool messageConsumed;
				T value = keyValuePair.Key.ConsumeMessage(keyValuePair.Value.Key, _owningBatch, out messageConsumed);
				if (messageConsumed)
				{
					KeyValuePair<DataflowMessageHeader, T> value2 = new KeyValuePair<DataflowMessageHeader, T>(keyValuePair.Value.Key, value);
					KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>> keyValuePair3 = (reservedSourcesTemp[i] = new KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>(keyValuePair.Key, value2));
					num++;
				}
			}
			lock (IncomingLock)
			{
				if (_boundingState != null)
				{
					_boundingState.CurrentCount += num;
				}
				foreach (KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>> item in reservedSourcesTemp)
				{
					if (item.Key != null)
					{
						_messages.Enqueue(item.Value.Value);
					}
				}
			}
		}

		internal void ReleaseReservedMessages(bool throwOnFirstException)
		{
			List<Exception> list = null;
			List<KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>> reservedSourcesTemp = _nonGreedyState.ReservedSourcesTemp;
			for (int i = 0; i < reservedSourcesTemp.Count; i++)
			{
				KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>> keyValuePair = reservedSourcesTemp[i];
				reservedSourcesTemp[i] = default(KeyValuePair<ISourceBlock<T>, KeyValuePair<DataflowMessageHeader, T>>);
				ISourceBlock<T> key = keyValuePair.Key;
				KeyValuePair<DataflowMessageHeader, T> value = keyValuePair.Value;
				if (key == null || !value.Key.IsValid)
				{
					continue;
				}
				try
				{
					key.ReleaseReservation(value.Key, _owningBatch);
				}
				catch (Exception item)
				{
					if (throwOnFirstException)
					{
						throw;
					}
					if (list == null)
					{
						list = new List<Exception>(1);
					}
					list.Add(item);
				}
			}
			if (list != null)
			{
				throw new AggregateException(list);
			}
		}

		internal void OnItemsRemoved(int numItemsRemoved)
		{
			if (_boundingState != null)
			{
				lock (IncomingLock)
				{
					_boundingState.CurrentCount -= numItemsRemoved;
					ProcessAsyncIfNecessary();
					CompleteBlockIfPossible();
				}
			}
		}

		internal static int CountItems(T[] singleOutputItem, IList<T[]> multipleOutputItems)
		{
			if (multipleOutputItems == null)
			{
				return singleOutputItem.Length;
			}
			int num = 0;
			foreach (T[] multipleOutputItem in multipleOutputItems)
			{
				num += multipleOutputItem.Length;
			}
			return num;
		}

		internal DebuggingInformation GetDebuggingInformation()
		{
			return new DebuggingInformation(this);
		}
	}

	private readonly BatchBlockTargetCore _target;

	private readonly SourceCore<T[]> _source;

	public int OutputCount => _source.OutputCount;

	public Task Completion => _source.Completion;

	public int BatchSize => _target.BatchSize;

	private int OutputCountForDebugger => _source.GetDebuggingInformation().OutputCount;

	private object DebuggerDisplayContent => string.Format("{0}, BatchSize={1}, OutputCount={2}", new object[3]
	{
		Common.GetNameForDebugger(this, _source.DataflowBlockOptions),
		BatchSize,
		OutputCountForDebugger
	});

	object IDebuggerDisplay.Content => DebuggerDisplayContent;

	public BatchBlock(int batchSize)
		: this(batchSize, GroupingDataflowBlockOptions.Default)
	{
	}

	public BatchBlock(int batchSize, GroupingDataflowBlockOptions dataflowBlockOptions)
	{
		if (batchSize < 1)
		{
			throw new ArgumentOutOfRangeException("batchSize", SR1.ArgumentOutOfRange_GenericPositive);
		}
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		if (dataflowBlockOptions.BoundedCapacity > 0 && dataflowBlockOptions.BoundedCapacity < batchSize)
		{
			throw new ArgumentOutOfRangeException("batchSize", SR1.ArgumentOutOfRange_BatchSizeMustBeNoGreaterThanBoundedCapacity);
		}
		dataflowBlockOptions = dataflowBlockOptions.DefaultOrClone();
		Action<ISourceBlock<T[]>, int> itemsRemovedAction = null;
		Func<ISourceBlock<T[]>, T[], IList<T[]>, int> itemCountingFunc = null;
		if (dataflowBlockOptions.BoundedCapacity > 0)
		{
			itemsRemovedAction = delegate(ISourceBlock<T[]> owningSource, int count)
			{
				((BatchBlock<T>)owningSource)._target.OnItemsRemoved(count);
			};
			itemCountingFunc = (ISourceBlock<T[]> owningSource, T[] singleOutputItem, IList<T[]> multipleOutputItems) => BatchBlockTargetCore.CountItems(singleOutputItem, multipleOutputItems);
		}
		_source = new SourceCore<T[]>(this, dataflowBlockOptions, delegate(ISourceBlock<T[]> owningSource)
		{
			((BatchBlock<T>)owningSource)._target.Complete(null, dropPendingMessages: true, releaseReservedMessages: false);
		}, itemsRemovedAction, itemCountingFunc);
		_target = new BatchBlockTargetCore(this, batchSize, delegate(T[] batch)
		{
			_source.AddMessage(batch);
		}, dataflowBlockOptions);
		_target.Completion.ContinueWith(delegate
		{
			_source.Complete();
		}, CancellationToken.None, Common.GetContinuationOptions(), TaskScheduler.Default);
		_source.Completion.ContinueWith(delegate(Task completed, object state)
		{
			IDataflowBlock dataflowBlock = (BatchBlock<T>)state;
			dataflowBlock.Fault(completed.Exception);
		}, this, CancellationToken.None, Common.GetContinuationOptions() | TaskContinuationOptions.OnlyOnFaulted, TaskScheduler.Default);
		Common.WireCancellationToComplete(dataflowBlockOptions.CancellationToken, _source.Completion, delegate(object state)
		{
			((BatchBlockTargetCore)state).Complete(null, dropPendingMessages: true, releaseReservedMessages: false);
		}, _target);
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockCreated(this, dataflowBlockOptions);
		}
	}

	public void Complete()
	{
		_target.Complete(null, dropPendingMessages: false, releaseReservedMessages: false);
	}

	void IDataflowBlock.Fault(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		_target.Complete(exception, dropPendingMessages: true, releaseReservedMessages: false);
	}

	public void TriggerBatch()
	{
		_target.TriggerBatch();
	}

	public IDisposable LinkTo(ITargetBlock<T[]> target, DataflowLinkOptions linkOptions)
	{
		return _source.LinkTo(target, linkOptions);
	}

	public bool TryReceive(Predicate<T[]> filter, out T[] item)
	{
		return _source.TryReceive(filter, out item);
	}

	public bool TryReceiveAll(out IList<T[]> items)
	{
		return _source.TryReceiveAll(out items);
	}

	DataflowMessageStatus ITargetBlock<T>.OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept)
	{
		return _target.OfferMessage(messageHeader, messageValue, source, consumeToAccept);
	}

	T[] ISourceBlock<T[]>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<T[]> target, out bool messageConsumed)
	{
		return _source.ConsumeMessage(messageHeader, target, out messageConsumed);
	}

	bool ISourceBlock<T[]>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<T[]> target)
	{
		return _source.ReserveMessage(messageHeader, target);
	}

	void ISourceBlock<T[]>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<T[]> target)
	{
		_source.ReleaseReservation(messageHeader, target);
	}

	public override string ToString()
	{
		return Common.GetNameForDebugger(this, _source.DataflowBlockOptions);
	}
}
