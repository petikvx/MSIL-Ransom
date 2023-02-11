using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Et0n;

[ComImport]
[CompilerGenerated]
[Guid("000208D7-0000-0000-C000-000000000046")]
[TypeIdentifier]
public interface Ee32 : IEnumerable
{
	[IndexerName("_Default")]
	[DispId(0)]
	object this[[In][MarshalAs(UnmanagedType.Struct)] object Index]
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
	}

	void _VtblGap1_18();
}
