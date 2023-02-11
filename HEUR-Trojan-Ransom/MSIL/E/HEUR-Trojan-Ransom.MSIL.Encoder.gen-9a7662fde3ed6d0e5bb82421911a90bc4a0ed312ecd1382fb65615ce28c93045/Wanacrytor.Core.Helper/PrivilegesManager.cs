using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Wanacrytor.Core.Helper;

public class PrivilegesManager
{
	public struct LUID
	{
		public uint LowPart;

		public uint HighPart;
	}

	public struct LUID_AND_ATTRIBUTES
	{
		public LUID Luid;

		public uint Attributes;
	}

	public struct TOKEN_PRIVILEGES
	{
		public uint PrivilegeCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
		public LUID_AND_ATTRIBUTES[] Privileges;
	}

	public const int ANYSIZE_ARRAY = 1;

	public const int TOKEN_QUERY = 8;

	public const int TOKEN_ADJUST_PRIVILEGES = 32;

	public const string SE_SHUTDOWN_NAME = "SeShutdownPrivilege";

	public const int SE_PRIVILEGE_ENABLED = 2;

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool LookupPrivilegeValue(string lpSystemName, string lpName, ref LUID lpLuid);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool OpenProcessToken(IntPtr ProcessHandle, int DesiredAccess, ref IntPtr TokenHandle);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool CloseHandle(IntPtr hHandle);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern bool AdjustTokenPrivileges(IntPtr TokenHandle, bool DisableAllPrivileges, ref TOKEN_PRIVILEGES NewState, int BufferLength, ref TOKEN_PRIVILEGES PreviousState, ref IntPtr ReturnLength);

	public void AcquireShutdownPrivilege(IntPtr hProc)
	{
		int num = 0;
		LUID lpLuid = default(LUID);
		if (!LookupPrivilegeValue(null, "SeShutdownPrivilege", ref lpLuid))
		{
			num = Marshal.GetLastWin32Error();
			throw new Win32Exception(num, "LookupPrivilegeValue failed with error " + num + ".");
		}
		IntPtr TokenHandle = default(IntPtr);
		if (!OpenProcessToken(hProc, 40, ref TokenHandle))
		{
			num = Marshal.GetLastWin32Error();
			throw new Win32Exception(num, "OpenProcessToken failed with error " + num + ".");
		}
		try
		{
			LUID_AND_ATTRIBUTES lUID_AND_ATTRIBUTES = default(LUID_AND_ATTRIBUTES);
			lUID_AND_ATTRIBUTES.Luid = lpLuid;
			lUID_AND_ATTRIBUTES.Attributes = 2u;
			TOKEN_PRIVILEGES NewState = default(TOKEN_PRIVILEGES);
			NewState.PrivilegeCount = 1u;
			NewState.Privileges = new LUID_AND_ATTRIBUTES[1] { lUID_AND_ATTRIBUTES };
			TOKEN_PRIVILEGES PreviousState = default(TOKEN_PRIVILEGES);
			PreviousState.Privileges = new LUID_AND_ATTRIBUTES[checked((int)NewState.PrivilegeCount + 1)];
			IntPtr ReturnLength = default(IntPtr);
			if (!AdjustTokenPrivileges(TokenHandle, DisableAllPrivileges: false, ref NewState, Marshal.SizeOf((object)PreviousState), ref PreviousState, ref ReturnLength))
			{
				num = Marshal.GetLastWin32Error();
				throw new Win32Exception(num, "AdjustTokenPrivileges failed with error " + num + ".");
			}
		}
		finally
		{
			CloseHandle(TokenHandle);
		}
	}
}
