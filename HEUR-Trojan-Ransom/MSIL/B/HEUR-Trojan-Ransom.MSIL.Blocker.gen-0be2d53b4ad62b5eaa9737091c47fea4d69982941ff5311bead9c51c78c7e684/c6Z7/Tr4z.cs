using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using e0J8;

namespace c6Z7;

[ComImport]
[CompilerGenerated]
[Guid("000208DA-0000-0000-C000-000000000046")]
[TypeIdentifier]
public interface Tr4z
{
	[DispId(485)]
	g6S5 Sheets
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(485)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_20();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[LCIDConversion(3)]
	[DispId(277)]
	void Close([Optional][In][MarshalAs(UnmanagedType.Struct)] object SaveChanges, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object RouteWorkbook);

	void _VtblGap2_84();
}
