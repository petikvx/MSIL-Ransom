using System;
using ns2;

namespace SmartAssembly.Shared.RegHelper;

public static class RegManager
{
	public static RegKey OpenKey(UIntPtr hKey, RegView regView, RegRights regRights, string lpSubKey, out RegStatus regStatus)
	{
		return Class2.smethod_0(hKey, regView, regRights, lpSubKey, out regStatus);
	}
}
