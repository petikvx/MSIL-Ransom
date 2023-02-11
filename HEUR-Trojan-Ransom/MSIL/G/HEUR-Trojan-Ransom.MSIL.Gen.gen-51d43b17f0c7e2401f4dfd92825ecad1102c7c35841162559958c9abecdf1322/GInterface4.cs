using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComImport]
[Guid("6C497D62-8919-413C-82DB-E935FB3EC584")]
[TypeIdentifier]
[CompilerGenerated]
public interface GInterface4 : GInterface3
{
	[DispId(1)]
	string String_0
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(4)]
	GInterface0 GInterface0_0
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(5)]
	GInterface5 GInterface5_0
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_1();

	void _VtblGap2_2();
}
