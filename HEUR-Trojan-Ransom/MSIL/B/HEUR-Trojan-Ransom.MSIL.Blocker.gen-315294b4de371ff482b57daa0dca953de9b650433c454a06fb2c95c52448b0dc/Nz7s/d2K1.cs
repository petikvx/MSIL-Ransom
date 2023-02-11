using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Ta1z;

namespace Nz7s;

[ComImport]
[CompilerGenerated]
[Guid("000208DA-0000-0000-C000-000000000046")]
[TypeIdentifier]
public interface d2K1
{
	[DispId(485)]
	Xg5o Sheets
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
