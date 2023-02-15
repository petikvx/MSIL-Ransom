using System;
using System.Management;

namespace StreamBaby;

public class MachineCode
{
	public string GetCpuInfo()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		string text = " ";
		ManagementClass val = new ManagementClass("Win32_Processor");
		try
		{
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = ((ManagementBaseObject)val2).get_Properties().get_Item("ProcessorId").get_Value()
						.ToString();
					val2.Dispose();
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
		return text.ToString();
	}

	public string GetHDid()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		string text = " ";
		ManagementClass val = new ManagementClass("Win32_DiskDrive");
		try
		{
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					text = (string)((ManagementBaseObject)val2).get_Properties().get_Item("Model").get_Value();
					val2.Dispose();
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
		return text.ToString();
	}

	public string GetMoAddress()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		string text = " ";
		ManagementClass val = new ManagementClass("Win32_NetworkAdapterConfiguration");
		try
		{
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if ((bool)((ManagementBaseObject)val2).get_Item("IPEnabled"))
					{
						text = ((ManagementBaseObject)val2).get_Item("MacAddress").ToString();
					}
					val2.Dispose();
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
		return text.ToString();
	}
}
