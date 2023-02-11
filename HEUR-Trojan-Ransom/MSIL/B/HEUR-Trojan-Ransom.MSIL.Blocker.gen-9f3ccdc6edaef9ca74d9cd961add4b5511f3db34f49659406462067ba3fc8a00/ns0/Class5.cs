using System;
using System.Diagnostics;
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

	private static extern void smethod_0();

	private static extern void smethod_1(string string_4, string string_5, bool bool_5);

	public static extern string smethod_2(string string_4);

	private static void Main()
	{
		//Discarded unreachable code: IL_0008
		/*Error near IL_0003: Invalid metadata token*/;
	}

	private static extern string smethod_3();

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_5);

	private static extern bool smethod_4();

	private static extern void smethod_5();

	private static extern void smethod_6(object sender, FileSystemEventArgs e);

	public extern Class5();

	static extern string smethod_7(string string_4);

	static extern Assembly smethod_8();

	static Stream smethod_9(Assembly assembly_0, string string_4)
	{
		//Discarded unreachable code: IL_0001, IL_0006, IL_000b
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected F8, but got I4
		/*Error: Unknown opcode: 0xFF*/;
	}

	static extern string smethod_10(string string_4, string string_5, string string_6);

	static extern FileStream smethod_11(string string_4, FileMode fileMode_0, FileAccess fileAccess_0);

	static extern void smethod_12(Stream stream_0, Stream stream_1);

	static void smethod_13(Stream stream_0)
	{
		//Discarded unreachable code: IL_0002, IL_0007
		_ = (ushort)/*Error near IL_0001: Stack underflow*/;
		/*Error near IL_0001: Unknown opcode: 0xFD*/;
	}

	static extern void smethod_14(IDisposable idisposable_0);

	static extern Process smethod_15();

	static extern ProcessStartInfo smethod_16(Process process_0);

	static extern void smethod_17(ProcessStartInfo processStartInfo_0, string string_4);

	unsafe static void smethod_18(ProcessStartInfo processStartInfo_0, bool bool_5)
	{
		//Discarded unreachable code: IL_0017, IL_001c, IL_0021, IL_0026
		//IL_000a: Incompatible stack heights: 0 vs 1
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected F8, but got Unknown
		do
		{
			_ = (uint)(double)(*(ulong*)(nint)/*Error near IL_0001: Stack underflow*/);
		}
		while (true);
		_ = (float)(int)(*(ushort*)checked((nint)/*Error near IL_0010: Stack underflow*/));
		/*Error near IL_0012: Invalid metadata token*/;
	}

	static extern void smethod_19(ProcessStartInfo processStartInfo_0, string string_4);

	unsafe static bool smethod_20(Process process_0)
	{
		//Discarded unreachable code: IL_000b
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0004: Expected F8, but got Unknown
		_003F val = /*Error near IL_0001: Stack underflow*/+ /*Error near IL_0001: Stack underflow*/;
		ushort num = ((ushort[])/*Error near IL_0002: Stack underflow*/)[val];
		_003F val2 = /*Error near IL_0002: ldarg 2 (out-of-bounds)*/;
		((double[])/*Error near IL_0004: Stack underflow*/)[num] = (double)val2;
		*(_003F*)(nint)/*Error near IL_0005: Stack underflow*/ = /*Error near IL_0005: Stack underflow*/;
		/*Error near IL_0006: Invalid metadata token*/;
	}

	static extern Process smethod_21(string string_4);

	static extern byte[] smethod_22(string string_4);

	static extern RijndaelManaged smethod_23();

	static extern void smethod_24(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern void smethod_25(SymmetricAlgorithm symmetricAlgorithm_0, int int_0);

	static extern Encoding smethod_26();

	static byte[] smethod_27(Encoding encoding_0, string string_4)
	{
		//Discarded unreachable code: IL_000a, IL_0018, IL_001f, IL_0024, IL_002d
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0028: Invalid comparison between Unknown and I8
		while (/*Error near IL_0005: Stack underflow*/ < /*Error near IL_0005: Stack underflow*/)
		{
		}
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern void smethod_28(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0);

	static void smethod_29(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0005, IL_000b, IL_0010, IL_0018, IL_0023, IL_002a
		//IL_0006: Invalid comparison between Unknown and I4
		//IL_0013: Incompatible stack heights: 0 vs 1
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected I, but got Unknown
		/*Error: Invalid metadata token*/;
	}

	static extern void smethod_30(SymmetricAlgorithm symmetricAlgorithm_0, PaddingMode paddingMode_0);

	static extern void smethod_31(SymmetricAlgorithm symmetricAlgorithm_0, CipherMode cipherMode_0);

	static extern byte[] smethod_32(SymmetricAlgorithm symmetricAlgorithm_0);

	static extern byte[] smethod_33(SymmetricAlgorithm symmetricAlgorithm_0);

	static ICryptoTransform smethod_34(SymmetricAlgorithm symmetricAlgorithm_0, byte[] byte_0, byte[] byte_1)
	{
		//Discarded unreachable code: IL_0010
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		object obj;
		checked
		{
			nint num = (nint)unchecked((int)/*Error near IL_0003: Stack underflow*/);
			((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = unchecked((sbyte)num);
			byte num2 = (byte)/*Error near IL_0006: Stack underflow*/;
			obj = ((object[])/*Error near IL_0007: Stack underflow*/)[num2];
		}
		IntPtr intPtr = (nint)((Array)(/*Error near IL_0008: Stack underflow*/ / obj)).LongLength;
		((IntPtr[])/*Error near IL_000a: Stack underflow*/)[/*Error near IL_000a: Stack underflow*/] = intPtr;
		/*OpCode not supported: Ckfinite*/;
		_ = -1;
		_ = -27;
		/*Error near IL_000f: Unknown opcode: 0xFC*/;
	}

	static byte[] smethod_35(ICryptoTransform icryptoTransform_0, byte[] byte_0, int int_0, int int_1)
	{
		//Discarded unreachable code: IL_0010, IL_0015, IL_0034
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		_ = ((int[])/*Error near IL_000a: Stack underflow*/)[8776521057330506342L];
		/*Error near IL_000b: Invalid metadata token*/;
	}

	static extern Encoding smethod_36();

	static string smethod_37(Encoding encoding_0, byte[] byte_0)
	{
		//Discarded unreachable code: IL_0008, IL_000d, IL_000f, IL_0014, IL_0019, IL_0027, IL_0030, IL_003e
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Invalid comparison between Unknown and I8
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		float num = (float)/*Error near IL_0002: Stack underflow*/;
		checked
		{
			_ = /*Error near IL_0003: Stack underflow*/* num;
			/*Error near IL_0003: Invalid metadata token*/;
		}
	}

	static extern WebClient smethod_38();

	static extern string smethod_39(string string_4, string string_5);

	static extern bool smethod_40(string string_4);

	unsafe static void smethod_41(string string_4)
	{
		//Discarded unreachable code: IL_0008, IL_0016
		*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
		_ = (uint)/*Error near IL_0002: Stack underflow*/;
		_ = 8;
		/*Error near IL_0003: Invalid metadata token*/;
	}

	static extern void smethod_42(WebClient webClient_0, string string_4, string string_5);

	static ProcessStartInfo smethod_43()
	{
		//Discarded unreachable code: IL_0005
		while (true)
		{
		}
	}

	static extern void smethod_44(ProcessStartInfo processStartInfo_0, ProcessWindowStyle processWindowStyle_0);

	static extern void smethod_45(Process process_0, ProcessStartInfo processStartInfo_0);

	static extern void smethod_46(Process process_0);

	static extern string smethod_47(Assembly assembly_0);

	static extern void smethod_48(string string_4, string string_5, bool bool_5);

	static extern RegistryKey smethod_49(RegistryKey registryKey_0, string string_4, bool bool_5);

	static extern void smethod_50(RegistryKey registryKey_0, string string_4, object object_0);

	static extern DialogResult smethod_51(string string_4, string string_5, MessageBoxButtons messageBoxButtons_0, MessageBoxIcon messageBoxIcon_0);

	static extern Assembly smethod_52();

	static string smethod_53(string string_4)
	{
		//Discarded unreachable code: IL_000a
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		_003F val2;
		checked
		{
			_003F val = /*Error near IL_0001: Stack underflow*/* /*Error near IL_0001: Stack underflow*/;
			val2 = /*Error near IL_0002: Stack underflow*/- val;
		}
		((sbyte[])/*Error near IL_0005: Stack underflow*/)[/*Error near IL_0005: Stack underflow*/] = (sbyte)(int)val2;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern bool smethod_54(string string_4, string string_5);

	static extern string smethod_55(string string_4);

	static extern string[] smethod_56(string string_4, char[] char_0);

	static extern string smethod_57(WebClient webClient_0, string string_4);

	static extern string smethod_58();

	static string smethod_59(string[] string_4)
	{
		throw (float)/*Error near IL_0001: Stack underflow*/;
	}

	static extern void smethod_60(int int_0);

	static extern NetworkInterface[] smethod_61();

	static extern OperationalStatus smethod_62(NetworkInterface networkInterface_0);

	static PhysicalAddress smethod_63(NetworkInterface networkInterface_0)
	{
		return (PhysicalAddress)/*OpCode not supported: Nop*/;
	}

	static extern string smethod_64(object object_0);

	static string smethod_65(string string_4, char[] char_0)
	{
		//Discarded unreachable code: IL_0015, IL_0026, IL_002c, IL_0032
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0021: Incompatible stack heights: 0 vs 3
		//IL_002d: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		uint num;
		do
		{
			num = ((uint[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		}
		while ((int)/*Error near IL_0008: Stack underflow*/ >= (int)num);
		checked
		{
			uint num2 = (uint)((long[])/*Error near IL_000e: Stack underflow*/)[(object)""];
			_ = /*Error near IL_0010: Stack underflow*/+ num2;
			/*Error near IL_0010: Invalid metadata token*/;
		}
	}

	static extern Process smethod_66();

	static extern IntPtr smethod_67(Process process_0);

	static extern FileSystemWatcher smethod_68();

	static extern string smethod_69(Environment.SpecialFolder specialFolder_0);

	static extern void smethod_70(FileSystemWatcher fileSystemWatcher_1, string string_4);

	static extern void smethod_71(FileSystemWatcher fileSystemWatcher_1, NotifyFilters notifyFilters_0);

	static void smethod_72(FileSystemWatcher fileSystemWatcher_1, string string_4)
	{
		//IL_0002: Invalid comparison between I8 and Unknown
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		while ((long)/*Error near IL_0001: Stack underflow*/ >= (long)/*Error near IL_0001: ldloc 3 (out-of-bounds)*/)
		{
		}
		_ = (ulong)checked(/*Error near IL_0008: Stack underflow*/ + /*Error near IL_0008: Stack underflow*/);
		/*Error: Unexpected end of block*/;
	}

	static extern void smethod_73(FileSystemWatcher fileSystemWatcher_1, FileSystemEventHandler fileSystemEventHandler_0);

	static extern void smethod_74(FileSystemWatcher fileSystemWatcher_1, bool bool_5);
}
