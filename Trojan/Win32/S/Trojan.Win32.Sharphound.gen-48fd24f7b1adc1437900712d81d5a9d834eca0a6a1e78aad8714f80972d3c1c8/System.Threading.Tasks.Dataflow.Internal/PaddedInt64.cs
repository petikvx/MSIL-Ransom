using System.Runtime.InteropServices;

namespace System.Threading.Tasks.Dataflow.Internal;

[StructLayout(LayoutKind.Explicit, Size = 256)]
internal struct PaddedInt64
{
	[FieldOffset(128)]
	internal long Value;
}
