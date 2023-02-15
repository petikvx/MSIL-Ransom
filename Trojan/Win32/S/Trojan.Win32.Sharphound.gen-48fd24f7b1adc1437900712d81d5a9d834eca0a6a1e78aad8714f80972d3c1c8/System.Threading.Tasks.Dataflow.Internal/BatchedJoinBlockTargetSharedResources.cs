namespace System.Threading.Tasks.Dataflow.Internal;

internal sealed class BatchedJoinBlockTargetSharedResources
{
	internal readonly object _incomingLock;

	internal readonly int _batchSize;

	internal readonly Action _batchSizeReachedAction;

	internal readonly Action _allTargetsDecliningPermanentlyAction;

	internal readonly Action<Exception> _exceptionAction;

	internal readonly Action _completionAction;

	internal int _remainingItemsInBatch;

	internal int _remainingAliveTargets;

	internal bool _decliningPermanently;

	internal long _batchesCreated;

	internal BatchedJoinBlockTargetSharedResources(int batchSize, GroupingDataflowBlockOptions dataflowBlockOptions, Action batchSizeReachedAction, Action allTargetsDecliningAction, Action<Exception> exceptionAction, Action completionAction)
	{
		BatchedJoinBlockTargetSharedResources batchedJoinBlockTargetSharedResources = this;
		_incomingLock = new object();
		_batchSize = batchSize;
		_remainingAliveTargets = 0;
		_remainingItemsInBatch = batchSize;
		_allTargetsDecliningPermanentlyAction = delegate
		{
			allTargetsDecliningAction();
			batchedJoinBlockTargetSharedResources._decliningPermanently = true;
		};
		_batchSizeReachedAction = delegate
		{
			batchSizeReachedAction();
			batchedJoinBlockTargetSharedResources._batchesCreated++;
			if (batchedJoinBlockTargetSharedResources._batchesCreated >= dataflowBlockOptions.ActualMaxNumberOfGroups)
			{
				batchedJoinBlockTargetSharedResources._allTargetsDecliningPermanentlyAction();
			}
			else
			{
				batchedJoinBlockTargetSharedResources._remainingItemsInBatch = batchedJoinBlockTargetSharedResources._batchSize;
			}
		};
		_exceptionAction = exceptionAction;
		_completionAction = completionAction;
	}
}
