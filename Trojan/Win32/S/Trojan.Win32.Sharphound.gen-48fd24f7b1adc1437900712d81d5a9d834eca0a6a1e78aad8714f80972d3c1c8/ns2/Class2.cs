using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using SmartAssembly.Shared.RegHelper;

namespace ns2;

internal static class Class2
{
	[DllImport("advapi32.dll", CharSet = CharSet.Unicode)]
	private static extern int RegOpenKeyEx(UIntPtr uintptr_0, string string_0, int int_0, int int_1, out UIntPtr uintptr_1);

	[DllImport("advapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int RegQueryValueEx(UIntPtr uintptr_0, string string_0, int[] int_0, ref int int_1, [Out] byte[] byte_0, ref int int_2);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern int RegCloseKey(UIntPtr uintptr_0);

	internal static RegKey smethod_0(UIntPtr uintptr_0, RegView regView_0, RegRights regRights_0, string string_0, out RegStatus regStatus_0)
	{
		try
		{
			UIntPtr uintptr_;
			switch (RegOpenKeyEx(uintptr_0, string_0, 0, (int)regRights_0 | (int)regView_0, out uintptr_))
			{
			default:
				regStatus_0 = RegStatus.Failed;
				break;
			case 0:
				regStatus_0 = RegStatus.Success;
				return new RegNetFrameworkKey(uintptr_);
			case 1:
				regStatus_0 = RegStatus.InvalidFunction;
				break;
			case 2:
				regStatus_0 = RegStatus.FileNotFound;
				break;
			}
		}
		catch
		{
			regStatus_0 = RegStatus.Failed;
		}
		return null;
	}

	internal static object smethod_1(UIntPtr uintptr_0, string string_0)
	{
		try
		{
			int int_ = -1;
			int int_2 = -1;
			if (RegQueryValueEx(uintptr_0, string_0, null, ref int_, null, ref int_2) == 0)
			{
				switch (int_)
				{
				case 1:
				{
					byte[] array4 = new byte[int_2];
					if (RegQueryValueEx(uintptr_0, string_0, null, ref int_, array4, ref int_2) != 0)
					{
						return null;
					}
					return Encoding.Unicode.GetString(array4).TrimEnd(new char[1]);
				}
				case 2:
				{
					byte[] array5 = new byte[int_2];
					if (RegQueryValueEx(uintptr_0, string_0, null, ref int_, array5, ref int_2) != 0)
					{
						return null;
					}
					return Environment.ExpandEnvironmentVariables(Encoding.Unicode.GetString(array5).TrimEnd(new char[1]));
				}
				case 4:
					if (int_2 <= 4)
					{
						byte[] array2 = new byte[int_2];
						if (RegQueryValueEx(uintptr_0, string_0, null, ref int_, array2, ref int_2) != 0)
						{
							return null;
						}
						return BitConverter.ToInt32(array2, 0);
					}
					goto case 11;
				case 7:
				{
					byte[] array = new byte[int_2];
					if (RegQueryValueEx(uintptr_0, string_0, null, ref int_, array, ref int_2) != 0)
					{
						return null;
					}
					int num = 0;
					List<string> list = new List<string>();
					for (int i = 0; i < int_2; i++)
					{
						if (array[i] == 0)
						{
							list.Add(Encoding.Unicode.GetString(array, num, i - num).TrimEnd(new char[1]));
							num = i + 1;
						}
					}
					return list;
				}
				default:
					return null;
				case 11:
					if (int_2 <= 8)
					{
						byte[] array3 = new byte[int_2];
						if (RegQueryValueEx(uintptr_0, string_0, null, ref int_, array3, ref int_2) != 0)
						{
							return null;
						}
						return BitConverter.ToInt64(array3, 0);
					}
					break;
				case 0:
				case 3:
				case 5:
					break;
				}
				byte[] array6 = new byte[int_2];
				if (RegQueryValueEx(uintptr_0, string_0, null, ref int_, array6, ref int_2) != 0)
				{
					return null;
				}
				return array6;
			}
		}
		catch
		{
		}
		return null;
	}

	internal static RegStatus smethod_2(UIntPtr uintptr_0)
	{
		try
		{
			if (RegCloseKey(uintptr_0) == 0)
			{
				return RegStatus.Success;
			}
		}
		catch
		{
		}
		return RegStatus.Failed;
	}
}
