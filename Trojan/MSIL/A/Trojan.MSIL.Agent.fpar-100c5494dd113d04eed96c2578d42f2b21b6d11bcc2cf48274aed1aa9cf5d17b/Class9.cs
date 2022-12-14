using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class Class9
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct0
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public IntPtr intptr_2;

		public IntPtr intptr_3;

		public IntPtr intptr_4;

		public IntPtr intptr_5;
	}

	[DllImport("kernel32.dll")]
	public static extern uint SetThreadExecutionState(uint uint_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int int_0, bool bool_0, int int_1);

	[DllImport("kernel32.dll")]
	public static extern bool CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode)]
	public static extern int QueryDosDevice(string string_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("psapi.dll", CharSet = CharSet.Unicode)]
	public static extern int GetProcessImageFileName(IntPtr intptr_0, StringBuilder stringBuilder_0, int int_0);

	[DllImport("ntdll.dll")]
	public static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	[DllImport("advapi32.dll")]
	public static extern bool GetKernelObjectSecurity(IntPtr intptr_0, int int_0, byte[] byte_0, int int_1, ref int int_2);

	[DllImport("advapi32.dll")]
	public static extern bool SetKernelObjectSecurity(IntPtr intptr_0, int int_0, byte[] byte_0);

	[DllImport("advapi32.dll")]
	public static extern int RegOpenKeyEx(UIntPtr uintptr_0, string string_0, int int_0, int int_1, ref IntPtr intptr_0);

	[DllImport("advapi32.dll")]
	public static extern int RegQueryValueEx(IntPtr intptr_0, string string_0, int int_0, ref int int_1, StringBuilder stringBuilder_0, ref int int_2);

	[DllImport("advapi32.dll")]
	public static extern int RegCloseKey(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr FindResourceEx(IntPtr intptr_0, int int_0, int int_1, short short_0);

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	public static extern int SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	public static extern IntPtr LockResource(IntPtr intptr_0);

	[DllImport("kernel32.dll")]
	public static extern bool AllocConsole();

	[DllImport("kernel32.dll")]
	public static extern bool DeleteFile(string string_0);
}
