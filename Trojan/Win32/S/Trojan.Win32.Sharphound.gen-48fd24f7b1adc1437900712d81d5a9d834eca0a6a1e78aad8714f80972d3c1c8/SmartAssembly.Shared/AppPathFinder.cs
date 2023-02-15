using SmartAssembly.Shared.RegHelper;

namespace SmartAssembly.Shared;

public class AppPathFinder
{
	public static string ReadInstalledSaPath()
	{
		try
		{
			object value;
			switch (FindKey("Path", AppRegistryKeys.SubkeyApplication, out value))
			{
			case RegStatus.NotSupported:
				return null;
			case RegStatus.Failed:
			{
				RegStatus regStatus = FindKey("Path", AppRegistryKeys.WowSubkeyApplication, out value);
				break;
			}
			}
			return (string)value;
		}
		catch
		{
			return null;
		}
	}

	public static RegStatus FindKey(string lpValueName, string lpSubKey, out object value)
	{
		value = null;
		try
		{
			RegStatus regStatus;
			using RegKey regKey = RegManager.OpenKey(RegConstants.HKEY_LOCAL_MACHINE, RegView.Default, RegRights.Read, lpSubKey, out regStatus);
			switch (regStatus)
			{
			case RegStatus.NotSupported:
				return RegStatus.NotSupported;
			default:
				return RegStatus.Failed;
			case RegStatus.Success:
				value = regKey.GetValue(lpValueName);
				break;
			}
		}
		catch
		{
			return RegStatus.Failed;
		}
		return RegStatus.Success;
	}
}
