using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using s3G8;

namespace Jf87;

[ComImport]
[CompilerGenerated]
[Guid("000208DB-0000-0000-C000-000000000046")]
[TypeIdentifier]
public interface Pm1d : IEnumerable
{
	[IndexerName("_Default")]
	[DispId(0)]
	r9HF this[[In][MarshalAs(UnmanagedType.Struct)] object Index]
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_10();

	void _VtblGap2_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1923)]
	[LCIDConversion(15)]
	[return: MarshalAs(UnmanagedType.Interface)]
	r9HF Open([In][MarshalAs(UnmanagedType.BStr)] string Filename, [Optional][In][MarshalAs(UnmanagedType.Struct)] object UpdateLinks, [Optional][In][MarshalAs(UnmanagedType.Struct)] object ReadOnly, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Format, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Password, [Optional][In][MarshalAs(UnmanagedType.Struct)] object WriteResPassword, [Optional][In][MarshalAs(UnmanagedType.Struct)] object IgnoreReadOnlyRecommended, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Origin, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Delimiter, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Editable, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Notify, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Converter, [Optional][In][MarshalAs(UnmanagedType.Struct)] object AddToMru, [Optional][In][MarshalAs(UnmanagedType.Struct)] object Local, [Optional][In][MarshalAs(UnmanagedType.Struct)] object CorruptLoad);
}
