using System.Diagnostics;

namespace System.Threading.Tasks.Dataflow.Internal;

[DebuggerDisplay("BoundedCapacity={BoundedCapacity}, PostponedMessages={PostponedMessagesCountForDebugger}")]
internal class BoundingStateWithPostponed<TInput> : BoundingState
{
	internal readonly QueuedMap<ISourceBlock<TInput>, DataflowMessageHeader> PostponedMessages = new QueuedMap<ISourceBlock<TInput>, DataflowMessageHeader>();

	internal int OutstandingTransfers;

	private int PostponedMessagesCountForDebugger => PostponedMessages.Count;

	internal BoundingStateWithPostponed(int boundedCapacity)
		: base(boundedCapacity)
	{
	}
}
