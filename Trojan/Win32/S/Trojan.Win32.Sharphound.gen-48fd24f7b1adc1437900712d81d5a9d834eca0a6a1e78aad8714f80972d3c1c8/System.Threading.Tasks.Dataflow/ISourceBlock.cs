namespace System.Threading.Tasks.Dataflow;

public interface ISourceBlock<out TOutput> : IDataflowBlock
{
	IDisposable LinkTo(ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions);

	TOutput ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target, out bool messageConsumed);

	bool ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target);

	void ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target);
}
