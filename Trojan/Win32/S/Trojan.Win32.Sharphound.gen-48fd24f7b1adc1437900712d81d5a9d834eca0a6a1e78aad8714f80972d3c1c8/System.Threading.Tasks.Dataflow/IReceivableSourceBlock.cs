using System.Collections.Generic;

namespace System.Threading.Tasks.Dataflow;

public interface IReceivableSourceBlock<TOutput> : ISourceBlock<TOutput>, IDataflowBlock
{
	bool TryReceive(Predicate<TOutput> filter, out TOutput item);

	bool TryReceiveAll(out IList<TOutput> items);
}
