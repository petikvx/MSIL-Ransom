using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Xy4;

namespace Sm0;

[ComImport]
[TypeIdentifier]
[Guid("000208D5-0000-0000-C000-000000000046")]
[CompilerGenerated]
[DefaultMember("_Default")]
public interface Hc6
{
	[DispId(572)]
	d4N Workbooks
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(572)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(0)]
	string _Default
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(558)]
	bool Visible
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[LCIDConversion(0)]
		[DispId(558)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[LCIDConversion(0)]
		[DispId(558)]
		[param: In]
		set;
	}

	void _VtblGap1_45();

	void _VtblGap2_60();

	void _VtblGap3_116();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(302)]
	void Quit();

	void _VtblGap4_51();
}