using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using SmartAssembly.Shared.RegHelper;

namespace SmartAssembly.Shared.ReportHelper;

public static class OsInformation
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct Struct29
	{
		public string string_0;

		public int int_0;
	}

	public static string GetPlatformName(Version osVersion)
	{
		return smethod_0(osVersion);
	}

	private static string smethod_0(Version version_0)
	{
		bool flag = OsVersionInformation.smethod_0();
		bool isX = OsVersionInformation.IsX64;
		switch (version_0.Major)
		{
		case 10:
			if (version_0.Minor != 0)
			{
				break;
			}
			if (!flag)
			{
				if (version_0.Build < 17623)
				{
					return "Windows Server 2016";
				}
				return "Windows Server 2019";
			}
			return "Windows 10";
		case 6:
			switch (version_0.Minor)
			{
			case 0:
				if (!flag)
				{
					return "Windows Server 2008";
				}
				return "Windows Vista";
			case 1:
				if (!flag)
				{
					return "Windows Server 2008 R2";
				}
				return "Windows 7";
			case 2:
				if (!flag)
				{
					return "Windows Server 2012";
				}
				return "Windows 8";
			case 3:
				if (!flag)
				{
					return "Windows Server 2012 R2";
				}
				return "Windows 8.1";
			case 4:
				return "Windows 10";
			}
			break;
		case 5:
			switch (version_0.Minor)
			{
			case 0:
				return "Windows 2000";
			case 1:
				return "Windows XP";
			case 2:
				if (!(flag && isX))
				{
					return "Windows Server 2003";
				}
				return "Windows XP 64-Bit Edition";
			}
			break;
		}
		return $"Windows {version_0.Major}.{version_0.Minor}.{version_0.Build}.{version_0.Revision}";
	}

	public static Version FixOsVersion(Version osVersion)
	{
		return smethod_2(smethod_1(), osVersion);
	}

	public static void GetOsDescription(out OsPlatform osPlatform, ref Version netVersion, ref Version osVersion, ref string osPlatformId, out string osDescription, out bool isX64)
	{
		osPlatform = smethod_1();
		osVersion = smethod_2(osPlatform, osVersion);
		osDescription = GetOsDetails(osVersion);
		isX64 = OsVersionInformation.IsX64;
	}

	public static string GetOsDetails(Version osVersion)
	{
		return $"Microsoft Windows {osVersion.Major}.{osVersion.Minor}.{osVersion.Build}.{osVersion.Revision}";
	}

	private static OsPlatform smethod_1()
	{
		return OsPlatform.Windows;
	}

	private static Version smethod_2(OsPlatform osPlatform_0, Version version_0)
	{
		return smethod_3(version_0);
	}

	private static Version smethod_3(Version version_0)
	{
		try
		{
			if (!(version_0 >= new Version(6, 2)))
			{
				if (version_0.Major != 0)
				{
					return version_0;
				}
				if (version_0.Minor != 0)
				{
					return version_0;
				}
			}
			RegStatus regStatus;
			using RegKey regKey = RegManager.OpenKey(RegConstants.HKEY_LOCAL_MACHINE, RegView.Default, RegRights.Read, "SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion", out regStatus) ?? RegManager.OpenKey(RegConstants.HKEY_LOCAL_MACHINE, RegView.Default, RegRights.Read, "SOFTWARE\\WOW6432Node\\Microsoft\\Windows NT\\CurrentVersion", out regStatus);
			if (regStatus == RegStatus.Success)
			{
				int major = 0;
				int minor = 0;
				int build = 0;
				int revision = 0;
				object value3;
				if (regKey.TryGetValue("CurrentMajorVersionNumber", out var value) && regKey.TryGetValue("CurrentMinorVersionNumber", out var value2))
				{
					if (value is int num)
					{
						major = num;
					}
					if (value2 is int num2)
					{
						minor = num2;
					}
				}
				else if (regKey.TryGetValue("CurrentVersion", out value3) && value3 is string string_)
				{
					Version version = smethod_4(string_);
					major = version.Major;
					minor = version.Minor;
				}
				if (regKey.TryGetValue("CurrentBuildNumber", out var value4) && value4 is string string_2)
				{
					build = smethod_4(string_2).Major;
				}
				if (regKey.TryGetValue("UBR", out var value5) && value5 is int num3)
				{
					revision = num3;
				}
				return new Version(major, minor, build, revision);
			}
			return version_0;
		}
		catch
		{
			return version_0;
		}
	}

	private static Version smethod_4(string string_0)
	{
		Struct29 struct29_ = default(Struct29);
		struct29_.string_0 = string_0;
		struct29_.int_0 = 0;
		int[] array = new int[4];
		for (int i = 0; i < 4; i++)
		{
			smethod_5(ref struct29_);
			int num = smethod_6(ref struct29_);
			if (num == 0)
			{
				break;
			}
			if (int.TryParse(struct29_.string_0.Substring(struct29_.int_0, num), out var result))
			{
				array[i] = result;
			}
			struct29_.int_0 += num;
		}
		return new Version(array[0], array[1], array[2], array[3]);
	}

	[CompilerGenerated]
	internal static void smethod_5(ref Struct29 struct29_0)
	{
		while (struct29_0.int_0 < struct29_0.string_0.Length && !char.IsNumber(struct29_0.string_0[struct29_0.int_0]))
		{
			struct29_0.int_0++;
		}
	}

	[CompilerGenerated]
	internal static int smethod_6(ref Struct29 struct29_0)
	{
		int i;
		for (i = struct29_0.int_0; i < struct29_0.string_0.Length && char.IsNumber(struct29_0.string_0[i]); i++)
		{
		}
		return i - struct29_0.int_0;
	}
}
