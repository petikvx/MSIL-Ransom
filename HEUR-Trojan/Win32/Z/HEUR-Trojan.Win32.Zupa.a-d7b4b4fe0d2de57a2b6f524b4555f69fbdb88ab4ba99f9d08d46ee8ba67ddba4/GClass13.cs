using System;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using Microsoft.Win32.SafeHandles;

public static class GClass13
{
	private struct Struct22
	{
		public long long_0;

		public long long_1;

		public long long_2;

		public uint uint_0;

		public byte byte_0;
	}

	private static SafeFileHandle safeFileHandle_0 = null;

	private static string string_0 = Class60.smethod_0(-2050218902);

	private static string string_1 = Class60.smethod_0(-2050218881);

	private static uint uint_0 = GClass10.smethod_0(32776u, 2048u, 0u, 3u);

	public static GClass10.GEnum1 smethod_0(string string_2)
	{
		if (safeFileHandle_0 != null && !safeFileHandle_0.IsInvalid)
		{
			return (GClass10.GEnum1)0u;
		}
		safeFileHandle_0 = GClass10.CreateFile(string_0, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, (FileAttributes)0, IntPtr.Zero);
		if (safeFileHandle_0 != null && !safeFileHandle_0.IsInvalid)
		{
			return (GClass10.GEnum1)0u;
		}
		return smethod_5(string_2);
	}

	public static GClass10.GEnum1 smethod_1()
	{
		if (safeFileHandle_0 != null && !safeFileHandle_0.IsInvalid)
		{
			safeFileHandle_0.Close();
			safeFileHandle_0 = null;
		}
		return smethod_4(string_1);
	}

	public static GClass10.GEnum1 smethod_2(int int_0, long long_0, long long_1, object object_0)
	{
		if (safeFileHandle_0 != null && !safeFileHandle_0.IsInvalid)
		{
			Struct22 @struct = default(Struct22);
			GCHandle gCHandle = GCHandle.Alloc(object_0, GCHandleType.Pinned);
			@struct.uint_0 = (uint)int_0;
			@struct.long_2 = long_1;
			@struct.byte_0 = 0;
			@struct.long_0 = gCHandle.AddrOfPinnedObject().ToInt64();
			@struct.long_1 = long_0;
			int int_ = 0;
			if (!GClass10.DeviceIoControl(safeFileHandle_0, uint_0, @struct, (uint)Marshal.SizeOf((object)@struct), null, 0u, ref int_, IntPtr.Zero))
			{
				return (GClass10.GEnum1)Marshal.GetLastWin32Error();
			}
			return (GClass10.GEnum1)0u;
		}
		return (GClass10.GEnum1)3221225664u;
	}

	public static GClass10.GEnum1 smethod_3(string string_2, string string_3)
	{
		string text = Class60.smethod_0(-2050218944) + string_2;
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(Class60.smethod_0(-2050218974) + text);
		registryKey.SetValue(Class60.smethod_0(-2050218960), Class60.smethod_0(-2050219008) + string_3);
		registryKey.SetValue(Class60.smethod_0(-2050218981), 1);
		GClass10.GStruct2 gstruct2_ = default(GClass10.GStruct2);
		GClass10.RtlAdjustPrivilege(10, bool_0: true, (GClass10.GEnum0)0, out var _);
		GClass10.RtlInitUnicodeString(ref gstruct2_, Class60.smethod_0(-2050218986) + text);
		return GClass10.NtLoadDriver(ref gstruct2_);
	}

	private static GClass10.GEnum1 smethod_4(string string_2)
	{
		string text = Class60.smethod_0(-2050218944) + string_2;
		GClass10.GStruct2 gstruct2_ = default(GClass10.GStruct2);
		GClass10.GEnum1 gEnum = GClass10.RtlAdjustPrivilege(10, bool_0: true, (GClass10.GEnum0)0, out var _);
		GClass10.RtlInitUnicodeString(ref gstruct2_, Class60.smethod_0(-2050218986) + text);
		gEnum = GClass10.NtUnloadDriver(ref gstruct2_);
		Registry.LocalMachine.DeleteSubKeyTree(Class60.smethod_0(-2050218974) + text, throwOnMissingSubKey: false);
		return gEnum;
	}

	private static GClass10.GEnum1 smethod_5(string string_2)
	{
		smethod_1();
		if (string.IsNullOrWhiteSpace(string_2))
		{
			return (GClass10.GEnum1)3221225530u;
		}
		GClass10.GEnum1 gEnum = smethod_3(string_1, string_2);
		if (gEnum >= (GClass10.GEnum1)0u)
		{
			safeFileHandle_0 = GClass10.CreateFile(string_0, FileAccess.ReadWrite, FileShare.ReadWrite, IntPtr.Zero, FileMode.Open, (FileAttributes)0, IntPtr.Zero);
			if (safeFileHandle_0 == null || safeFileHandle_0.IsInvalid)
			{
				return (GClass10.GEnum1)Marshal.GetLastWin32Error();
			}
		}
		return (GClass10.GEnum1)0u;
	}
}
