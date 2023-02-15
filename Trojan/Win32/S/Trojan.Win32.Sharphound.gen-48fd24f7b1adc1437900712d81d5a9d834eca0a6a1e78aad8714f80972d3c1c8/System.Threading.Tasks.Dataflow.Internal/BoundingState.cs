using System.Diagnostics;

namespace System.Threading.Tasks.Dataflow.Internal;

[DebuggerDisplay("BoundedCapacity={BoundedCapacity}}")]
internal class BoundingState
{
	internal readonly int BoundedCapacity;

	internal int CurrentCount;

	internal bool CountIsLessThanBound => CurrentCount < BoundedCapacity;

	internal BoundingState(int boundedCapacity)
	{
		BoundedCapacity = boundedCapacity;
	}
}
