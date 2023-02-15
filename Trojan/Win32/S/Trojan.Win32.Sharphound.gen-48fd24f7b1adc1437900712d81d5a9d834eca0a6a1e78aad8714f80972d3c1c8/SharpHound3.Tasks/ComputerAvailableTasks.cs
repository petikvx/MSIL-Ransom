using System;
using System.Threading.Tasks;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;

namespace SharpHound3.Tasks;

internal class ComputerAvailableTasks
{
	internal static async Task<LdapWrapper> CheckSMBOpen(LdapWrapper wrapper)
	{
		if (wrapper is Computer computer)
		{
			if (Options.Instance.Stealth && !computer.IsStealthTarget)
			{
				return wrapper;
			}
			if (Options.Instance.WindowsOnly)
			{
				string os = wrapper.SearchResult.GetProperty("operatingsystem");
				if (os == null || os.IndexOf("windows", StringComparison.CurrentCultureIgnoreCase) <= -1)
				{
					computer.IsWindows = false;
					OutputTasks.AddComputerStatus(new ComputerStatus
					{
						ComputerName = computer.DisplayName,
						Status = "NotWindows",
						Task = "SMBCheck"
					});
					return wrapper;
				}
			}
			if (Options.Instance.SkipPortScan)
			{
				return wrapper;
			}
			computer.PingFailed = !Helpers.CheckPort(computer.APIName, 445);
			if (computer.PingFailed && Options.Instance.DumpComputerStatus)
			{
				OutputTasks.AddComputerStatus(new ComputerStatus
				{
					ComputerName = computer.DisplayName,
					Status = "SMBNotAvailable",
					Task = "SMBCheck"
				});
			}
			await Helpers.DoDelay();
		}
		return wrapper;
	}
}
