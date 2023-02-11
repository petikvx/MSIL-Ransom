using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace ns0;

internal class Class5
{
	public static bool bool_0;

	public static bool bool_1;

	public static bool bool_2;

	public static bool bool_3;

	public static bool bool_4;

	public static string string_0;

	public static string string_1;

	public static string string_2;

	public static string string_3;

	private static FileSystemWatcher fileSystemWatcher_0;

	private static extern void smethod_0();

	private static extern void smethod_1(string string_4, string string_5, bool bool_5);

	public static string smethod_2(string string_4)
	{
		//Discarded unreachable code: IL_0018, IL_001c, IL_001d, IL_0023, IL_0028, IL_0032
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Invalid comparison between Unknown and I4
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Incompatible stack heights: 0 vs 1
		while (true)
		{
			if (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
			{
				continue;
			}
			_003F val = /*Error near IL_0005: ldarg 3 (out-of-bounds)*/;
			int num = /*Error near IL_0008: Stack underflow*/>> (int)val;
			if ((int)/*Error near IL_000f: Stack underflow*/ >= num)
			{
				_003F val2 = /*Error near IL_0011: Stack underflow*// 4;
				if (/*Error near IL_0016: Stack underflow*/ >= val2)
				{
					break;
				}
			}
		}
		/*Error near IL_0017: Unknown opcode: 0xF9*/;
	}

	private static extern string smethod_3();

	private static extern void Main();

	private static extern string smethod_4();

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	private static extern bool smethod_5();

	private static extern void smethod_6();

	private static void smethod_7(object sender, FileSystemEventArgs e)
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Invalid comparison between Unknown and I4
		while (true)
		{
		}
	}

	private static void smethod_8()
	{
		//Discarded unreachable code: IL_0010, IL_0016, IL_001d, IL_0026, IL_002d
		//IL_000b: Incompatible stack heights: 0 vs 1
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = /*Error near IL_0002: ldarga 0 (out-of-bounds)*/;
			if (/*Error near IL_0009: Stack underflow*/ < val)
			{
				_ = ((byte[])/*Error near IL_000b: Stack underflow*/)[8];
			}
		}
	}

	private static extern void smethod_9();

	public static extern bool smethod_10(string string_4);

	public extern Class5();

	static extern string smethod_11(string string_4);

	static extern Assembly smethod_12();

	static Stream smethod_13(Assembly assembly_0, string string_4)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static extern string smethod_14(string string_4, string string_5, string string_6);

	unsafe static FileStream smethod_15(string string_4, FileMode fileMode_0, FileAccess fileAccess_0)
	{
		_ = *(ushort*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern void smethod_16(Stream stream_0, Stream stream_1);

	static void smethod_17(Stream stream_0)
	{
		throw (ulong)/*Error near IL_0001: Stack underflow*/;
	}

	static extern void smethod_18(IDisposable idisposable_0);

	static extern Process smethod_19();

	static extern ProcessStartInfo smethod_20(Process process_0);

	static void smethod_21(ProcessStartInfo processStartInfo_0, string string_4)
	{
	}

	static extern void smethod_22(ProcessStartInfo processStartInfo_0, bool bool_5);

	static extern void smethod_23(ProcessStartInfo processStartInfo_0, string string_4);

	static extern bool smethod_24(Process process_0);

	static extern Process smethod_25(string string_4);

	static extern byte[] smethod_26(string string_4);

	static extern RijndaelManaged smethod_27();

	static void smethod_28(SymmetricAlgorithm symmetricAlgorithm_0, int int_0)
	{
		//Discarded unreachable code: IL_000c, IL_0014, IL_001b, IL_0024, IL_0029, IL_002e
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_ = ((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
			/*Error near IL_0001: stloc 1 (out-of-bounds)*/;
			if (/*Error near IL_0007: Stack underflow*/ > /*Error near IL_0007: Stack underflow*/)
			{
			}
		}
	}

	static extern void smethod_29(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static Encoding smethod_30()
	{
		return (Encoding)/*OpCode not supported: Nop*/;
	}

	static extern byte[] smethod_31(Encoding encoding_0, string string_4);

	static extern void smethod_32(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static void smethod_33(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0014, IL_0018
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		while (/*Error near IL_0005: Stack underflow*/ >= /*Error near IL_0005: Stack underflow*/|| checked((nuint)/*Error near IL_0008: Stack underflow*/) >= (nuint)(nint)byte_0 || (int)/*Error near IL_0013: Stack underflow*/ == 0)
		{
		}
		/*Error near IL_0013: Unknown opcode: 0xFC*/;
	}

	static extern void smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_35(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_36(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_37(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_38(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_39(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_40();

	static string smethod_41(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0008, IL_0010, IL_0019
		//IL_0003: Incompatible stack heights: 0 vs 1
		//IL_0014: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		checked
		{
			while (true)
			{
				_ = (ulong)/*Error: ldloca 0 (out-of-bounds)*/;
			}
		}
	}

	static extern WebClient smethod_42();

	static extern string smethod_43(string string_4, string string_5);

	static extern void smethod_44(WebClient webClient_0, string string_4, string string_5);

	static extern void smethod_45(Component component_0);

	static ProcessStartInfo smethod_46()
	{
		//Discarded unreachable code: IL_0009, IL_0011, IL_0012, IL_0016, IL_001b, IL_001e, IL_002f
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected I4, but got Unknown
		//IL_002a: Expected I, but got I8
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		_ = null;
		checked
		{
			_ = (nint)uint.MaxValue;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	static extern void smethod_47(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_48(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_49(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern void smethod_50(int int_0);

	static extern void smethod_51(string string_4);

	static extern string smethod_52(string string_4);

	static extern Rectangle smethod_53(Point point_0);

	static extern Bitmap smethod_54(int int_0, int int_1);

	static Graphics smethod_55(Image image_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = (uint)unchecked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
			/*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern void smethod_56(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_57();

	static extern void smethod_58(Image image_0, string string_4, ImageFormat imageFormat_0);

	static bool smethod_59(string string_4)
	{
		_ = ((sbyte[])/*Error near IL_0003: Stack underflow*/)[(object)null];
		/*Error near IL_0003: ldloc 2 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_60(Process process_0);

	static string smethod_61(Assembly assembly_0)
	{
		//Discarded unreachable code: IL_0007, IL_000d, IL_0013, IL_0019
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static void smethod_62(string string_4, string string_5, bool bool_5)
	{
		//Discarded unreachable code: IL_0005, IL_0011, IL_0016
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern RegistryKey smethod_63(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_64(RegistryKey registryKey_0, string string_4, object object_0);

	static void smethod_65(string string_4, FileAttributes fileAttributes_0)
	{
		_003F val;
		do
		{
			val = /*Error: ldarg 3 (out-of-bounds)*/;
		}
		while (/*Error near IL_0006: Stack underflow*/ <= val);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern Assembly smethod_66();

	static extern string smethod_67(string string_4);

	static extern bool smethod_68(string string_4, string string_5);

	static string[] smethod_69(string string_4, char[] char_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0001: Stack underflow*/<< (int)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: ldarg 3 (out-of-bounds)*/;
		_ = -6.190093116057429E+257;
		/*Error: Unexpected end of block*/;
	}

	unsafe static string smethod_70(WebClient webClient_0, string string_4)
	{
		//Discarded unreachable code: IL_001d
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			_003F val = /*Error: ldloc 2 (out-of-bounds)*/;
			if (/*Error near IL_0006: Stack underflow*/ <= val && (long)checked((ulong)(*unchecked((sbyte*)(nint)/*Error near IL_0007: Stack underflow*/))) <= (long)(&webClient_0))
			{
				_003F val2 = /*Error near IL_0010: Stack underflow*/& /*Error near IL_0010: Stack underflow*/;
				if (/*Error near IL_0017: Stack underflow*/ > val2)
				{
					break;
				}
			}
		}
		/*OpCode not supported: Ckfinite*/;
		/*Error near IL_0018: Invalid metadata token*/;
	}

	static extern string smethod_71();

	static extern string smethod_72(string[] string_4);

	static void smethod_73(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_001f, IL_0021, IL_002f
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got F8
		//IL_0029: Expected F4, but got I
		while (true)
		{
			if ((int)/*Error near IL_0005: Stack underflow*/ != 0)
			{
				continue;
			}
			_003F val = /*Error near IL_0006: Stack underflow*/& /*Error near IL_0006: Stack underflow*/;
			IntPtr intPtr = ((IntPtr[])/*Error near IL_0007: Stack underflow*/)[val];
			if ((nint)/*Error near IL_000c: Stack underflow*/ <= (nint)intPtr)
			{
				double num = (double)/*Error near IL_000d: Stack underflow*/;
				_003F val2 = /*Error near IL_000e: Stack underflow*/% num;
				if (/*Error near IL_0015: Stack underflow*/ > val2)
				{
					break;
				}
			}
		}
		checked
		{
			_ = (ushort)(/*Error near IL_0017: Stack underflow*/ + 8);
			/*Error near IL_001a: Invalid metadata token*/;
		}
	}

	static extern NetworkInterface[] smethod_74();

	static extern OperationalStatus smethod_75(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_76(NetworkInterface networkInterface_0);

	static extern string smethod_77(object object_0);

	static string smethod_78(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_000e, IL_001c, IL_0024, IL_0030, IL_0036, IL_003b
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Invalid comparison between Unknown and I4
		//IL_001e: Expected F4, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Invalid comparison between Unknown and I4
		//IL_0031: Invalid comparison between Unknown and I4
		//IL_0041: Expected O, but got I4
		_003F val;
		do
		{
			val = /*Error near IL_0002: Stack underflow*/| /*Error near IL_0002: Stack underflow*/;
		}
		while (/*Error near IL_0003: Stack underflow*/ / val > 7);
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern Process smethod_79();

	static extern IntPtr smethod_80(Process process_0);

	static extern FileSystemWatcher smethod_81();

	static extern string smethod_82(Environment.SpecialFolder specialFolder_0);

	static void smethod_83(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//Discarded unreachable code: IL_0001, IL_000a, IL_0017, IL_001e
		//IL_0005: Invalid comparison between Unknown and F8
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Invalid comparison between Ref and Unknown
		//IL_0012: Incompatible stack heights: 0 vs 1
		/*Error: Unknown opcode: 0xFF*/;
	}

	unsafe static void smethod_84(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0)
	{
		//Discarded unreachable code: IL_0007
		//IL_0014: Expected F4, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = *(double*)(nint)/*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern void smethod_85(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_86(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	unsafe static void smethod_87(FileSystemWatcher fileSystemWatcher_1, bool bool_5)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			val = /*Error near IL_0001: Stack underflow*/;
		}
		while (/*Error near IL_0007: Stack underflow*/ <= val);
		nint num = checked((nint)/*Error near IL_0008: Stack underflow*/);
		throw *(long*)(nint)(/*Error near IL_0009: Stack underflow*/ % num);
	}

	static extern bool smethod_88(string string_4);

	static string[] smethod_89(string string_4, string string_5)
	{
		/*Error: Unexpected end of block*/;
	}

	static extern bool smethod_90(string string_4, string string_5);

	static extern Match smethod_91(string string_4, string string_5);

	static extern WebHeaderCollection smethod_92(WebClient webClient_0);

	static extern void smethod_93(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);
}
