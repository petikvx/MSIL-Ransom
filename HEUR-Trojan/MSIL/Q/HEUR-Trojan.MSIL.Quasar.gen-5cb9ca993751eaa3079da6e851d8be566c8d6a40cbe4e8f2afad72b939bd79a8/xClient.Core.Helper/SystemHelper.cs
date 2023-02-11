using System;
using System.Management;

namespace xClient.Core.Helper;

public static class SystemHelper
{
	public static string GetUptime()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = string.Empty;
			ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem WHERE Primary='true'");
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					if (enumerator.MoveNext())
					{
						DateTime dateTime = ManagementDateTimeConverter.ToDateTime(((ManagementBaseObject)(ManagementObject)enumerator.get_Current()).get_Item("LastBootUpTime").ToString());
						TimeSpan timeSpan = TimeSpan.FromTicks((DateTime.Now - dateTime).Ticks);
						text = $"{timeSpan.Days}d : {timeSpan.Hours}h : {timeSpan.Minutes}m : {timeSpan.Seconds}s";
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			if (string.IsNullOrEmpty(text))
			{
				throw new Exception("Getting uptime failed");
			}
			return text;
		}
		catch (Exception)
		{
			return $"{0}d : {0}h : {0}m : {0}s";
		}
	}

	public static string GetPcName()
	{
		return Environment.MachineName;
	}

	public static string GetAntivirus()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			string obj = (PlatformHelper.VistaOrHigher ? "root\\SecurityCenter2" : "root\\SecurityCenter");
			string text2 = "SELECT * FROM AntivirusProduct";
			ManagementObjectSearcher val = new ManagementObjectSearcher(obj, text2);
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						text = text + ((ManagementBaseObject)val2).get_Item("displayName").ToString() + "; ";
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			text = FormatHelper.RemoveEnd(text);
			return (!string.IsNullOrEmpty(text)) ? text : "N/A";
		}
		catch
		{
			return "Unknown";
		}
	}

	public static string GetFirewall()
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			string obj = (PlatformHelper.VistaOrHigher ? "root\\SecurityCenter2" : "root\\SecurityCenter");
			string text2 = "SELECT * FROM FirewallProduct";
			ManagementObjectSearcher val = new ManagementObjectSearcher(obj, text2);
			try
			{
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementObject val2 = (ManagementObject)enumerator.get_Current();
						text = text + ((ManagementBaseObject)val2).get_Item("displayName").ToString() + "; ";
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
			text = FormatHelper.RemoveEnd(text);
			return (!string.IsNullOrEmpty(text)) ? text : "N/A";
		}
		catch
		{
			return "Unknown";
		}
	}
}
