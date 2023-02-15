using System;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;

namespace Loki.Pinvoke;

internal class ZZZZy
{
	[Flags]
	internal enum ZZZZI
	{
		None = 0,
		ChainCalls = 1,
		InProgress = 2
	}

	internal struct ZZZZJ
	{
		internal int ZZZZK;

		internal int ZZZZL;

		internal IntPtr ZZZZM;

		internal int ZZZZN;

		internal IntPtr ZZZZO;

		internal int ZZZZP;

		internal IntPtr ZZZZQ;

		internal int ZZZZR;

		internal IntPtr ZZZZS;

		internal int ZZZZT;

		internal int ZZZZU;

		internal long ZZZZV;

		internal ZZZZI ZZZZW;
	}

	[DllImport("bcrypt.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int BCryptCloseAlgorithmProvider(IntPtr intptr_0, int int_0);

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	public static extern int BCryptOpenAlgorithmProvider(out IntPtr intptr_0, string string_0, string string_1, uint uint_0);

	[DllImport("bcrypt.dll")]
	public static extern int BCryptGenRandom(IntPtr intptr_0, IntPtr intptr_1, int int_0, uint uint_0);

	[DllImport("bcrypt.dll")]
	public static extern int BCryptEncrypt(IntPtr intptr_0, IntPtr intptr_1, int int_0, [In] ref ZZZZJ zzzzj_0, IntPtr intptr_2, int int_1, IntPtr intptr_3, int int_2, out int int_3, uint uint_0);

	[DllImport("bcrypt.dll")]
	public static extern int BCryptDecrypt(IntPtr intptr_0, IntPtr intptr_1, int int_0, [In] ref ZZZZJ zzzzj_0, IntPtr intptr_2, int int_1, IntPtr intptr_3, int int_2, out int int_3, uint uint_0);

	[DllImport("bcrypt.dll", CharSet = CharSet.Unicode)]
	public static extern int BCryptSetProperty(IntPtr intptr_0, string string_0, [In][MarshalAs(UnmanagedType.LPArray)] byte[] byte_0, int int_0, uint uint_0);

	[DllImport("bcrypt.dll")]
	internal static extern int BCryptGenerateSymmetricKey(IntPtr intptr_0, out IntPtr intptr_1, IntPtr intptr_2, int int_0, IntPtr intptr_3, int int_1, int int_2);

	[SecuritySafeCritical]
	[SecurityCritical]
	internal unsafe static void ZZZZG(ref ZZZZJ zzzzj_0)
	{
		//Discarded unreachable code: IL_0011
		while (true)
		{
			*(_003F*)(nint)/*Error near IL_0001: Stack underflow*/ = /*Error near IL_0001: Stack underflow*/;
			if ((int)/*Error near IL_0006: Stack underflow*/ != 0 && /*Error near IL_000c: Stack underflow*/> /*Error near IL_000c: Stack underflow*/)
			{
			}
		}
	}

	[DllImport("bcrypt.dll")]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[SuppressUnmanagedCodeSecurity]
	public static extern int BCryptDestroyKey(IntPtr intptr_0);

	public extern ZZZZy();
}
