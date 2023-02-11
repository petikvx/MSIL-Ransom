using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace q2SA;

[ComImport]
[TypeIdentifier]
[InterfaceType(2)]
[CompilerGenerated]
[Guid("00020846-0000-0000-C000-000000000046")]
public interface w7M2 : IEnumerable
{
	[IndexerName("_Default")]
	[DispId(0)]
	object this[[Optional][In][MarshalAs(UnmanagedType.Struct)] object RowIndex, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ColumnIndex]
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(0)]
		[param: Optional]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(138)]
	object Text
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall)]
		[DispId(138)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
	}

	void _VtblGap1_45();

	void _VtblGap2_117();
}
