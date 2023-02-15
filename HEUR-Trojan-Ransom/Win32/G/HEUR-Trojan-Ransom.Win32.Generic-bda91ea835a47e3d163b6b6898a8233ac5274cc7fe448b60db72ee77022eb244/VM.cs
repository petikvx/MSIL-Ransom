using System;
using System.Runtime.InteropServices;
using KoiVM.Runtime;

internal class VM
{
	static void VM()
	{
		VMEntry.Run(typeof(VM).TypeHandle, 2u, new object[0]);
	}

	[DllImport("kernel32.dll")]
	internal static extern IntPtr ZeroMemory(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll")]
	internal static extern IntPtr VirtualProtect(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, ref IntPtr intptr_3);
}
