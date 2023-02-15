namespace System.Threading.Tasks.Dataflow;

public interface IPropagatorBlock<in TInput, out TOutput> : ITargetBlock<TInput>, ISourceBlock<TOutput>, IDataflowBlock
{
}
