namespace System.Threading.Tasks.Dataflow.Internal;

internal abstract class JoinBlockTargetBase
{
	internal abstract bool IsDecliningPermanently { get; }

	internal abstract bool HasAtLeastOneMessageAvailable { get; }

	internal abstract bool HasAtLeastOnePostponedMessage { get; }

	internal abstract int NumberOfMessagesAvailableOrPostponed { get; }

	internal abstract bool HasTheHighestNumberOfMessagesAvailable { get; }

	internal abstract bool ReserveOneMessage();

	internal abstract bool ConsumeReservedMessage();

	internal abstract bool ConsumeOnePostponedMessage();

	internal abstract void ReleaseReservedMessage();

	internal abstract void ClearReservation();

	public void Complete()
	{
		CompleteCore(null, dropPendingMessages: false, releaseReservedMessages: false);
	}

	internal abstract void CompleteCore(Exception exception, bool dropPendingMessages, bool releaseReservedMessages);

	internal abstract void CompleteOncePossible();
}
