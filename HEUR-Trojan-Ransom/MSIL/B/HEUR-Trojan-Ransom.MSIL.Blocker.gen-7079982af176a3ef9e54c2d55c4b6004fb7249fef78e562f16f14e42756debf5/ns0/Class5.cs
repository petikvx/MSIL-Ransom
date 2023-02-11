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
using System.Windows.Forms;
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

	public static extern string smethod_0(string string_4);

	private static extern string smethod_1();

	private static extern void Main();

	private static extern string smethod_2();

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	private static extern bool smethod_3();

	private static extern void smethod_4();

	private static extern void smethod_5(object sender, FileSystemEventArgs e);

	private static extern void smethod_6();

	private static void smethod_7()
	{
		//Discarded unreachable code: IL_0029, IL_002f
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected F4, but got I4
		while (true)
		{
			_003F val = /*Error near IL_0001: Stack underflow*/% /*Error near IL_0001: Stack underflow*/;
			_ = (uint)/*Error near IL_0001: ldarg 0 (out-of-bounds)*/;
			/*Error near IL_0006: stloc 1 (out-of-bounds)*/;
			if (val <= /*Error near IL_0007: ldarg 2 (out-of-bounds)*/&& /*Error near IL_0012: Stack underflow*/>= /*Error near IL_0012: Stack underflow*/&& (int)/*Error near IL_0019: Stack underflow*/ != 0)
			{
				_003F val2 = /*Error near IL_001d: Stack underflow*/>> 8;
				/*OpCode not supported: Ckfinite*/;
				if (/*Error near IL_0023: Stack underflow*/ != val2 && (int)/*Error near IL_0028: Stack underflow*/ == 0)
				{
					break;
				}
			}
		}
		/*Error near IL_0028: Unknown opcode: 0xFA*/;
	}

	public static extern bool smethod_8(string string_4);

	private static extern void smethod_9();

	public extern Class5();

	static extern byte[] smethod_10(string string_4);

	static extern RijndaelManaged smethod_11();

	static extern void smethod_12(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_13(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_14();

	static extern byte[] smethod_15(Encoding encoding_0, string string_4);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	unsafe static void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0)
	{
		//Discarded unreachable code: IL_000f, IL_0014, IL_0018, IL_001e, IL_0032
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected native int or pointer, but got F4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected F8, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Invalid comparison between Unknown and F8
		while (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/)
		{
		}
		checked
		{
			_ = (sbyte)(*unchecked((byte*)(&paddingMode_0)));
			/*Error near IL_000a: Invalid metadata token*/;
		}
	}

	static extern void smethod_19(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_20(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_21(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_22(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static byte[] smethod_23(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		//Discarded unreachable code: IL_0007, IL_0011
		//IL_0001: Invalid comparison between Unknown and I
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		nint num;
		do
		{
			num = (nint)/*Error near IL_0001: Stack underflow*/;
		}
		while ((nint)/*Error near IL_0006: Stack underflow*/ > num);
		/*Error near IL_0006: Unknown opcode: 0xFB*/;
	}

	unsafe static Encoding smethod_24()
	{
		_ = *(double*)(nint)/*Error near IL_0001: Stack underflow*/;
		/*Error: Unexpected end of block*/;
	}

	static extern string smethod_25(Encoding encoding_0, byte[] byte_0);

	static extern void smethod_26(IDisposable idisposable_0);

	static extern string smethod_27(string string_4);

	static extern WebClient smethod_28();

	static extern string smethod_29(string string_4, string string_5);

	static extern void smethod_30(WebClient webClient_0, string string_4, string string_5);

	static extern void smethod_31(Component component_0);

	static Process smethod_32()
	{
		//Discarded unreachable code: IL_0010, IL_0012, IL_001c
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected F8, but got I8
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Invalid comparison between Unknown and O
		/*OpCode not supported: Ckfinite*/;
		checked
		{
			ulong num = (ulong)/*Error near IL_0002: Stack underflow*/;
			_003F val = /*Error near IL_0003: Stack underflow*/* num;
			ushort num2 = ((ushort[])/*Error near IL_0004: Stack underflow*/)[val];
			_ = (double)(uint)(/*Error near IL_0005: Stack underflow*/ + num2);
			/*Error near IL_0009: Stack underflow*/;
			/*Error near IL_000a: ldarg 1 (out-of-bounds)*/;
			/*Error near IL_000b: Invalid metadata token*/;
		}
	}

	static extern ProcessStartInfo smethod_33();

	static extern void smethod_34(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_35(ProcessStartInfo processStartInfo_0, string string_4);

	static extern string smethod_36(string string_4, string string_5, string string_6);

	static extern void smethod_37(ProcessStartInfo processStartInfo_0, string string_4);

	static void smethod_38(Process process_0, ProcessStartInfo processStartInfo_0)
	{
		//Discarded unreachable code: IL_0005, IL_000a, IL_000d, IL_0017, IL_001c, IL_0021, IL_0026, IL_002c, IL_0033
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern bool smethod_39(Process process_0);

	static extern void smethod_40(int int_0);

	static extern void smethod_41(string string_4);

	static extern string smethod_42(string string_4);

	static extern Rectangle smethod_43(Point point_0);

	static extern Bitmap smethod_44(int int_0, int int_1);

	unsafe static Graphics smethod_45(Image image_0)
	{
		*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static void smethod_46(Graphics graphics_0, Point point_0, Point point_1, Size size_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0010, IL_0013
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		/*Error: Invalid metadata token*/;
	}

	static extern ImageFormat smethod_47();

	static extern void smethod_48(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_49(string string_4);

	static extern void smethod_50(Process process_0);

	static Assembly smethod_51()
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_52(Assembly assembly_0);

	static extern void smethod_53(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_54(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_55(RegistryKey registryKey_0, string string_4, object object_0);

	static extern void smethod_56(string string_4, FileAttributes fileAttributes_0);

	static extern DialogResult smethod_57(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern RegistryKey smethod_58(RegistryKey registryKey_0, string string_4);

	static void smethod_59(RegistryKey registryKey_0)
	{
		//Discarded unreachable code: IL_000b, IL_0013, IL_0021, IL_0026, IL_002f, IL_0034, IL_003e
		//IL_0001: Invalid comparison between Unknown and I4
		//IL_0018: Expected F4, but got O
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0039: Invalid comparison between Unknown and I4
		byte num;
		do
		{
			num = checked((byte)/*Error near IL_0001: Stack underflow*/);
		}
		while ((int)/*Error near IL_0006: Stack underflow*/ == num);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern string[] smethod_60(string string_4, char[] char_0);

	static extern string smethod_61(WebClient webClient_0, string string_4);

	static extern string smethod_62();

	static extern string smethod_63(string[] string_4);

	static extern void smethod_64(string string_4, string string_5);

	static extern NetworkInterface[] smethod_65();

	static extern OperationalStatus smethod_66(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_67(NetworkInterface networkInterface_0);

	static extern string smethod_68(object object_0);

	static string smethod_69(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0006, IL_000b, IL_0010
		//IL_0016: Expected F8, but got I4
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		_ = -1;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern Process smethod_70();

	static IntPtr smethod_71(Process process_0)
	{
		//Discarded unreachable code: IL_0008
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error: ldloc 0 (out-of-bounds)*/* 1;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	static extern FileSystemWatcher smethod_72();

	static string smethod_73(Environment.SpecialFolder specialFolder_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/- /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	static extern void smethod_74(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_75(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_76(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_77(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_78(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static extern bool smethod_79(string string_4, string string_5);

	static extern bool smethod_80(string string_4);

	static extern string[] smethod_81(string string_4, string string_5);

	static extern bool smethod_82(string string_4, string string_5);

	static extern Match smethod_83(string string_4, string string_5);

	static extern WebHeaderCollection smethod_84(WebClient webClient_0);

	static extern void smethod_85(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4);

	static byte[] smethod_86(string string_4)
	{
		//Discarded unreachable code: IL_0006, IL_000d
		//IL_0000: Unsupported input type for neg.
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_ = 0 - /*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	static extern Encoding smethod_87();

	static extern int smethod_88(string string_4, string string_5);

	static extern string smethod_89(string string_4, int int_0, int int_1);

	static extern string smethod_90(string string_4, int int_0, string string_5);

	static extern void smethod_91(string string_4, byte[] byte_0);
}
