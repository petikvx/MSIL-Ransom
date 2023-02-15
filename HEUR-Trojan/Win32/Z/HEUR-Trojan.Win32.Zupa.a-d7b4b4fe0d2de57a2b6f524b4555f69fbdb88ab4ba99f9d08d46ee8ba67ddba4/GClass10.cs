using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

public sealed class GClass10
{
	public enum GEnum0
	{

	}

	public enum GEnum1 : uint
	{

	}

	public struct GStruct2 : IDisposable
	{
		public ushort ushort_0;

		public ushort ushort_1;

		private IntPtr intptr_0;

		public GStruct2(string string_0)
		{
			ushort_0 = (ushort)(string_0.Length * 2);
			ushort_1 = (ushort)(ushort_0 + 2);
			intptr_0 = Marshal.StringToHGlobalUni(string_0);
		}

		public void Dispose()
		{
			Marshal.FreeHGlobal(intptr_0);
			intptr_0 = IntPtr.Zero;
		}

		public override string ToString()
		{
			return Marshal.PtrToStringUni(intptr_0);
		}
	}

	[DllImport("ntdll.dll")]
	public static extern GEnum1 RtlInitUnicodeString(ref GStruct2 gstruct2_0, [MarshalAs(UnmanagedType.LPWStr)] string string_0);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern GEnum1 RtlAdjustPrivilege(int int_0, bool bool_0, GEnum0 genum0_0, out bool bool_1);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern GEnum1 NtLoadDriver(ref GStruct2 gstruct2_0);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern GEnum1 NtUnloadDriver(ref GStruct2 gstruct2_0);

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern SafeFileHandle CreateFile(string string_0, [MarshalAs(UnmanagedType.U4)] FileAccess fileAccess_0, [MarshalAs(UnmanagedType.U4)] FileShare fileShare_0, IntPtr intptr_0, [MarshalAs(UnmanagedType.U4)] FileMode fileMode_0, [MarshalAs(UnmanagedType.U4)] FileAttributes fileAttributes_0, IntPtr intptr_1);

	[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool DeviceIoControl(SafeFileHandle safeFileHandle_0, uint uint_0, [In][MarshalAs(UnmanagedType.AsAny)] object object_0, uint uint_1, [Out][MarshalAs(UnmanagedType.AsAny)] object object_1, uint uint_2, ref int int_0, IntPtr intptr_0);

	public static uint smethod_0(uint uint_0, uint uint_1, uint uint_2, uint uint_3)
	{
		return (uint_0 << 16) | (uint_3 << 14) | (uint_1 << 2) | uint_2;
	}
}
