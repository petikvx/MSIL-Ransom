using System.Diagnostics;
using System.Linq;

namespace System.Threading.Tasks.Dataflow.Internal;

[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
internal sealed class JoinBlockTargetSharedResources
{
	internal readonly IDataflowBlock _ownerJoin;

	internal readonly JoinBlockTargetBase[] _targets;

	internal readonly Action<Exception> _exceptionAction;

	internal readonly Action _joinFilledAction;

	internal readonly GroupingDataflowBlockOptions _dataflowBlockOptions;

	internal readonly BoundingState _boundingState;

	internal bool _decliningPermanently;

	internal Task _taskForInputProcessing;

	internal bool _hasExceptions;

	internal long _joinsCreated;

	private bool _completionReserved;

	internal object IncomingLock => _targets;

	internal bool AllTargetsHaveAtLeastOneMessage
	{
		get
		{
			JoinBlockTargetBase[] targets = _targets;
			int num = 0;
			while (true)
			{
				if (num < targets.Length)
				{
					JoinBlockTargetBase joinBlockTargetBase = targets[num];
					if (!joinBlockTargetBase.HasAtLeastOneMessageAvailable)
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
	}

	private bool TargetsHaveAtLeastOneMessageQueuedOrPostponed
	{
		get
		{
			if (_boundingState == null)
			{
				JoinBlockTargetBase[] targets = _targets;
				int num = 0;
				while (true)
				{
					if (num < targets.Length)
					{
						JoinBlockTargetBase joinBlockTargetBase = targets[num];
						if (!joinBlockTargetBase.HasAtLeastOneMessageAvailable && (_decliningPermanently || joinBlockTargetBase.IsDecliningPermanently || !joinBlockTargetBase.HasAtLeastOnePostponedMessage))
						{
							break;
						}
						num++;
						continue;
					}
					return true;
				}
				return false;
			}
			bool countIsLessThanBound = _boundingState.CountIsLessThanBound;
			bool flag = true;
			bool flag2 = false;
			JoinBlockTargetBase[] targets2 = _targets;
			int num2 = 0;
			while (true)
			{
				if (num2 < targets2.Length)
				{
					JoinBlockTargetBase joinBlockTargetBase2 = targets2[num2];
					bool flag3 = !_decliningPermanently && !joinBlockTargetBase2.IsDecliningPermanently && joinBlockTargetBase2.HasAtLeastOnePostponedMessage;
					if (_dataflowBlockOptions.Greedy && flag3 && (countIsLessThanBound || !joinBlockTargetBase2.HasTheHighestNumberOfMessagesAvailable))
					{
						break;
					}
					bool hasAtLeastOneMessageAvailable = joinBlockTargetBase2.HasAtLeastOneMessageAvailable;
					flag = flag && (hasAtLeastOneMessageAvailable || flag3);
					if (hasAtLeastOneMessageAvailable)
					{
						flag2 = true;
					}
					num2++;
					continue;
				}
				if (flag)
				{
					return flag2 || countIsLessThanBound;
				}
				return false;
			}
			return true;
		}
	}

	private bool CanceledOrFaulted
	{
		get
		{
			if (!_dataflowBlockOptions.CancellationToken.IsCancellationRequested)
			{
				return _hasExceptions;
			}
			return true;
		}
	}

	internal bool JoinNeedsProcessing
	{
		get
		{
			if (_taskForInputProcessing == null && !CanceledOrFaulted)
			{
				return TargetsHaveAtLeastOneMessageQueuedOrPostponed;
			}
			return false;
		}
	}

	private object DebuggerDisplayContent
	{
		get
		{
			IDebuggerDisplay debuggerDisplay = _ownerJoin as IDebuggerDisplay;
			return $"Block=\"{((debuggerDisplay != null) ? debuggerDisplay.Content : _ownerJoin)}\"";
		}
	}

	internal JoinBlockTargetSharedResources(IDataflowBlock ownerJoin, JoinBlockTargetBase[] targets, Action joinFilledAction, Action<Exception> exceptionAction, GroupingDataflowBlockOptions dataflowBlockOptions)
	{
		_ownerJoin = ownerJoin;
		_targets = targets;
		_joinFilledAction = joinFilledAction;
		_exceptionAction = exceptionAction;
		_dataflowBlockOptions = dataflowBlockOptions;
		if (dataflowBlockOptions.BoundedCapacity > 0)
		{
			_boundingState = new BoundingState(dataflowBlockOptions.BoundedCapacity);
		}
	}

	internal void CompleteEachTarget()
	{
		JoinBlockTargetBase[] targets = _targets;
		foreach (JoinBlockTargetBase joinBlockTargetBase in targets)
		{
			joinBlockTargetBase.CompleteCore(null, dropPendingMessages: true, releaseReservedMessages: false);
		}
	}

	private bool RetrievePostponedItemsNonGreedy()
	{
		lock (IncomingLock)
		{
			if (!TargetsHaveAtLeastOneMessageQueuedOrPostponed)
			{
				return false;
			}
		}
		bool flag = true;
		JoinBlockTargetBase[] targets = _targets;
		foreach (JoinBlockTargetBase joinBlockTargetBase in targets)
		{
			if (!joinBlockTargetBase.ReserveOneMessage())
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			JoinBlockTargetBase[] targets2 = _targets;
			foreach (JoinBlockTargetBase joinBlockTargetBase2 in targets2)
			{
				if (!joinBlockTargetBase2.ConsumeReservedMessage())
				{
					flag = false;
					break;
				}
			}
		}
		if (!flag)
		{
			JoinBlockTargetBase[] targets3 = _targets;
			foreach (JoinBlockTargetBase joinBlockTargetBase3 in targets3)
			{
				joinBlockTargetBase3.ReleaseReservedMessage();
			}
		}
		return flag;
	}

	private bool RetrievePostponedItemsGreedyBounded()
	{
		bool flag = false;
		JoinBlockTargetBase[] targets = _targets;
		foreach (JoinBlockTargetBase joinBlockTargetBase in targets)
		{
			flag |= joinBlockTargetBase.ConsumeOnePostponedMessage();
		}
		return flag;
	}

	internal void ProcessAsyncIfNecessary(bool isReplacementReplica = false)
	{
		if (JoinNeedsProcessing)
		{
			ProcessAsyncIfNecessary_Slow(isReplacementReplica);
		}
	}

	private void ProcessAsyncIfNecessary_Slow(bool isReplacementReplica)
	{
		_taskForInputProcessing = new Task(delegate(object thisSharedResources)
		{
			((JoinBlockTargetSharedResources)thisSharedResources).ProcessMessagesLoopCore();
		}, this, Common.GetCreationOptionsForTask(isReplacementReplica));
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.TaskLaunchedForMessageHandling(_ownerJoin, _taskForInputProcessing, DataflowEtwProvider.TaskLaunchedReason.ProcessingInputMessages, Enumerable.Max(_targets, (JoinBlockTargetBase t) => t.NumberOfMessagesAvailableOrPostponed));
		}
		Exception ex = Common.StartTaskSafe(_taskForInputProcessing, _dataflowBlockOptions.TaskScheduler);
		if (ex != null)
		{
			_exceptionAction(ex);
			_taskForInputProcessing = null;
			CompleteBlockIfPossible();
		}
	}

	internal void CompleteBlockIfPossible()
	{
		if (_completionReserved)
		{
			return;
		}
		bool flag;
		if (!(flag = _decliningPermanently && !AllTargetsHaveAtLeastOneMessage))
		{
			JoinBlockTargetBase[] targets = _targets;
			foreach (JoinBlockTargetBase joinBlockTargetBase in targets)
			{
				if (joinBlockTargetBase.IsDecliningPermanently && !joinBlockTargetBase.HasAtLeastOneMessageAvailable)
				{
					flag = true;
					break;
				}
			}
		}
		if (_taskForInputProcessing != null || (!flag && !CanceledOrFaulted))
		{
			return;
		}
		_completionReserved = true;
		_decliningPermanently = true;
		Task.Factory.StartNew(delegate(object state)
		{
			JoinBlockTargetSharedResources joinBlockTargetSharedResources = (JoinBlockTargetSharedResources)state;
			JoinBlockTargetBase[] targets2 = joinBlockTargetSharedResources._targets;
			foreach (JoinBlockTargetBase joinBlockTargetBase2 in targets2)
			{
				joinBlockTargetBase2.CompleteOncePossible();
			}
		}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
	}

	private void ProcessMessagesLoopCore()
	{
		try
		{
			int num = 0;
			int actualMaxMessagesPerTask = _dataflowBlockOptions.ActualMaxMessagesPerTask;
			bool flag;
			do
			{
				if (flag = (_dataflowBlockOptions.Greedy ? RetrievePostponedItemsGreedyBounded() : RetrievePostponedItemsNonGreedy()))
				{
					lock (IncomingLock)
					{
						if (AllTargetsHaveAtLeastOneMessage)
						{
							_joinFilledAction();
							_joinsCreated++;
							if (!_dataflowBlockOptions.Greedy && _boundingState != null)
							{
								_boundingState.CurrentCount++;
							}
						}
					}
				}
				num++;
			}
			while (flag && num < actualMaxMessagesPerTask);
		}
		catch (Exception exception)
		{
			_targets[0].CompleteCore(exception, dropPendingMessages: true, releaseReservedMessages: true);
		}
		finally
		{
			lock (IncomingLock)
			{
				_taskForInputProcessing = null;
				ProcessAsyncIfNecessary(isReplacementReplica: true);
				CompleteBlockIfPossible();
			}
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
}
