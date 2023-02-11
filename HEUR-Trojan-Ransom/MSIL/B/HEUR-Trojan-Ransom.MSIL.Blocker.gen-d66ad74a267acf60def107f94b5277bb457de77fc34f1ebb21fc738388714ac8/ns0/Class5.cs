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

	private static string smethod_1()
	{
		//Discarded unreachable code: IL_0009, IL_0015, IL_001a
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			_ = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0004: Invalid metadata token*/;
		}
	}

	private static extern void Main();

	private static extern string smethod_2();

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	private static extern bool smethod_3();

	private static void smethod_4()
	{
		//Discarded unreachable code: IL_0007, IL_000f, IL_0016
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected F8, but got Unknown
		checked
		{
			_ = (nuint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0001: stloc 2 (out-of-bounds)*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	private static extern void smethod_5(object sender, FileSystemEventArgs e);

	public extern Class5();

	unsafe static byte[] smethod_6(string string_4)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			/*Error near IL_0001: stloc 1 (out-of-bounds)*/;
			val = /*Error near IL_0009: Stack underflow*// "";
		}
		while (/*Error near IL_000e: Stack underflow*/ != val || /*Error near IL_0013: Stack underflow*/<= /*Error near IL_0013: Stack underflow*/);
		/*Error near IL_0013: stloc 1 (out-of-bounds)*/;
		*(_003F*)(nint)/*Error near IL_0015: Stack underflow*/ = /*Error near IL_0015: Stack underflow*/;
		throw /*Error near IL_0016: Stack underflow*// /*Error near IL_0016: Stack underflow*/;
	}

	unsafe static RijndaelManaged smethod_7()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			ushort num = *(ushort*)(nint)/*Error near IL_0001: Stack underflow*/;
			checked
			{
				_003F val = /*Error near IL_0003: Stack underflow*/- num;
				_003F val2 = /*Error near IL_0004: Stack underflow*/+ val;
				if (/*Error near IL_000a: Stack underflow*/ >= val2 && -70 == 0 && /*Error near IL_001c: Stack underflow*/== /*Error near IL_001c: Stack underflow*/&& /*Error near IL_0021: Stack underflow*/<= /*Error near IL_0021: Stack underflow*/)
				{
					/*Error: Could not find block for branch target IL_0021*/;
				}
			}
		}
	}

	static extern void smethod_8(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_9(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static Encoding smethod_10()
	{
		//Discarded unreachable code: IL_0009, IL_000a, IL_000e, IL_0015
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		_ = ((uint[])/*Error: ldarg 1 (out-of-bounds)*/)[/*Error near IL_0001: ldloca 0 (out-of-bounds)*/];
		/*Error near IL_0004: Invalid metadata token*/;
	}

	static extern byte[] smethod_11(Encoding encoding_0, string string_4);

	static extern void smethod_12(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static void smethod_13(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0009, IL_0011, IL_001e, IL_0025
		//IL_0004: Incompatible stack heights: 0 vs 1
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and F8
		//IL_0020: Invalid comparison between Unknown and I4
		while (true)
		{
			((IntPtr[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (IntPtr)/*Error near IL_0001: Stack underflow*/;
			float num = ((float[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
			_ = ((IntPtr[])/*Error near IL_0003: Stack underflow*/)[num];
		}
	}

	static extern void smethod_14(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_15(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_16(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_17(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern ICryptoTransform smethod_18(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1);

	static extern byte[] smethod_19(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1);

	static extern Encoding smethod_20();

	static string smethod_21(Encoding encoding_0, byte[] byte_0)
	{
		checked
		{
			_ = (ushort)/*Error near IL_0002: Stack underflow*/;
			/*Error: Unexpected end of block*/;
		}
	}

	static extern void smethod_22(IDisposable idisposable_0);

	static extern string smethod_23(string string_4);

	static extern WebClient smethod_24();

	static extern string smethod_25(string string_4, string string_5);

	unsafe static void smethod_26(WebClient webClient_0, string string_4, string string_5)
	{
		//Discarded unreachable code: IL_0016, IL_001b, IL_0021, IL_002c, IL_0031, IL_003a
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Invalid comparison between Unknown and F8
		//IL_0025: Expected O, but got I8
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unsupported input type for neg.
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		do
		{
			_003F val = /*Error: ldloc 3 (out-of-bounds)*/;
			((sbyte[])/*Error near IL_0003: Stack underflow*/)[val] = 2;
		}
		while (/*Error near IL_0008: Stack underflow*/ == /*Error near IL_0008: Stack underflow*/|| /*Error near IL_000d: Stack underflow*/> /*Error near IL_000d: Stack underflow*/|| /*Error near IL_0012: Stack underflow*/> /*Error near IL_0012: Stack underflow*/);
		_ = /*Error near IL_0015: Stack underflow*/<< (int)(&webClient_0);
		/*Error near IL_0015: Unknown opcode: 0xFD*/;
	}

	static void smethod_27(Component component_0)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_003F val;
		do
		{
			val = checked(/*Error near IL_0001: Stack underflow*/ * /*Error near IL_0001: Stack underflow*/);
		}
		while (/*Error near IL_0006: Stack underflow*/ >= val);
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern Process smethod_28();

	static ProcessStartInfo smethod_29()
	{
		//Discarded unreachable code: IL_0008, IL_0011, IL_0020
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unsupported input type for neg.
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		_ = -(/*Error near IL_0001: Stack underflow*/ & /*Error near IL_0001: Stack underflow*/);
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern void smethod_30(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static void smethod_31(ProcessStartInfo processStartInfo_0, string string_4)
	{
		throw /*Error near IL_0001: Stack underflow*/;
	}

	static extern string smethod_32(string string_4, string string_5, string string_6);

	static void smethod_33(ProcessStartInfo processStartInfo_0, string string_4)
	{
		//IL_0004: Invalid comparison between Unknown and I8
		//IL_0010: Invalid comparison between I4 and F4
		while (true)
		{
			long num = ((long[])/*Error near IL_0002: Stack underflow*/)[4];
			if ((long)/*Error near IL_0009: Stack underflow*/ == (num | 1))
			{
				((int[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = (int)/*Error near IL_000a: Stack underflow*/;
				if (!((float)(int)checked((uint)/*Error near IL_000b: Stack underflow*/) > -4.0223746E-37f))
				{
					/*Error: Could not find block for branch target IL_0015*/;
				}
			}
		}
	}

	static extern void smethod_34(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern bool smethod_35(Process process_0);

	static extern void smethod_36(int int_0);

	static extern void smethod_37(string string_4);

	static extern string smethod_38(string string_4);

	static Rectangle smethod_39(Point point_0)
	{
		//Discarded unreachable code: IL_0005, IL_000c, IL_001a, IL_0025, IL_002b
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected I, but got Unknown
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I8
		//IL_0018: Incompatible stack heights: 1 vs 0
		//IL_002b: Unsupported input type for neg.
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		_003F val = /*Error near IL_0001: Stack underflow*/^ /*Error near IL_0001: Stack underflow*/;
		if (/*Error near IL_0003: Stack underflow*/ != val)
		{
		}
		/*Error near IL_0004: Unknown opcode: 0xFD*/;
	}

	static extern Bitmap smethod_40(int int_0, int int_1);

	static extern Graphics smethod_41(Image image_0);

	static extern void smethod_42(Graphics graphics_0, Point point_0, Point point_1, Size size_0);

	static extern ImageFormat smethod_43();

	static extern void smethod_44(Image image_0, string string_4, ImageFormat imageFormat_0);

	static extern bool smethod_45(string string_4);

	static extern void smethod_46(Process process_0);

	static extern Assembly smethod_47();

	static extern string smethod_48(Assembly assembly_0);

	static void smethod_49(string string_4, string string_5, bool bool_5)
	{
		//Discarded unreachable code: IL_0005
		/*Error: Invalid metadata token*/;
	}

	static extern RegistryKey smethod_50(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_51(RegistryKey registryKey_0, string string_4, object object_0);

	static extern DialogResult smethod_52(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern string[] smethod_53(string string_4, char[] char_0);

	static extern string smethod_54(WebClient webClient_0, string string_4);

	static extern string smethod_55();

	static extern string smethod_56(string[] string_4);

	static extern void smethod_57(string string_4, string string_5);

	static extern NetworkInterface[] smethod_58();

	static extern OperationalStatus smethod_59(NetworkInterface networkInterface_0);

	static extern PhysicalAddress smethod_60(NetworkInterface networkInterface_0);

	static string smethod_61(object object_0)
	{
		/*Error: Invalid metadata token*/;
	}

	static extern string smethod_62(string string_4, char[] char_0);

	static Process smethod_63()
	{
		//Discarded unreachable code: IL_0001, IL_0007, IL_0013, IL_0022, IL_0027, IL_002e
		//IL_000e: Invalid comparison between Unknown and I4
		//IL_0015: Expected native int or pointer, but got O
		//IL_0018: Expected native int or pointer, but got O
		//IL_0030: Expected I4, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected F8, but got I4
		/*Error: Unknown opcode: 0xFF*/;
	}

	unsafe static IntPtr smethod_64(Process process_0)
	{
		//Discarded unreachable code: IL_000e
		//IL_0001: Expected native int or pointer, but got O
		//IL_0004: Expected native int or pointer, but got O
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		double num = *(double*)(nint)(*(object*)unchecked((nint)null));
		_ = /*Error near IL_0007: Stack underflow*// num;
		/*Error near IL_0007: stloc 3 (out-of-bounds)*/;
		_ = 2;
		/*Error near IL_0009: Invalid metadata token*/;
	}

	static extern FileSystemWatcher smethod_65();

	static extern string smethod_66(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_67(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_68(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	unsafe static void smethod_69(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//Discarded unreachable code: IL_000a
		checked
		{
			_ = (long)unchecked((uint)((short[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/]);
			_ = 1;
		}
		_ = *(object*)(nint)/*Error near IL_0007: ldloc 2 (out-of-bounds)*/;
		/*Error near IL_0009: Unknown opcode: 0xFC*/;
	}

	static extern void smethod_70(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_71(FileSystemWatcher fileSystemWatcher_1, bool bool_5);

	unsafe static bool smethod_72(string string_4, string string_5)
	{
		//Discarded unreachable code: IL_000b, IL_001b, IL_0021
		//IL_0019: Expected I8, but got I4
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = ((short[])/*Error near IL_0002: Stack underflow*/)[/*Error near IL_0002: Stack underflow*/];
		_ = null;
		_ = -69;
		/*Error near IL_0006: Invalid metadata token*/;
	}
}
