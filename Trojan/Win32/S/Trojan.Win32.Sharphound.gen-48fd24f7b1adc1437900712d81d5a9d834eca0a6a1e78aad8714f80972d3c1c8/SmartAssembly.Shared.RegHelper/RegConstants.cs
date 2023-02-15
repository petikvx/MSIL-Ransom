using System;

namespace SmartAssembly.Shared.RegHelper;

public static class RegConstants
{
	public static readonly UIntPtr HKEY_CLASSES_ROOT = new UIntPtr(2147483648u);

	public static readonly UIntPtr HKEY_CURRENT_USER = new UIntPtr(2147483649u);

	public static readonly UIntPtr HKEY_LOCAL_MACHINE = new UIntPtr(2147483650u);

	public static readonly UIntPtr HKEY_USERS = new UIntPtr(2147483651u);

	public static readonly UIntPtr HKEY_PERFORMANCE_DATA = new UIntPtr(2147483652u);

	public static readonly UIntPtr HKEY_CURRENT_CONFIG = new UIntPtr(2147483653u);

	public static readonly UIntPtr HKEY_DYN_DATA = new UIntPtr(2147483654u);
}
