using System.Diagnostics;
using System.Runtime.InteropServices;

namespace System.Threading.Tasks.Dataflow.Internal;

[StructLayout(LayoutKind.Sequential, Size = 1)]
[DebuggerNonUserCode]
internal struct VoidResult
{
}
