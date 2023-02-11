using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

internal sealed class zCfylsHdiOAalsC
{
	public enum xmUhmglkoULLQQ
	{
		muiTHKFzSzDWG = 1,
		gxxaCWqraUGMak,
		pEqswhJrxANT,
		llVxRMgPCZrnHQH,
		IRNqCHDazH
	}

	public enum jCzDMhEMsmTb
	{
		AvLYqVLTjqtv,
		DYuMSRgcNiCDx,
		HecORviocT,
		TugHuhhMpBqcw
	}

	public enum YdPGbBBbjcnel
	{
		DjJFPAGfwJD = 1,
		sUErqnyxeMGe = 2,
		FxsphDYmjKH = 4,
		UFFOJOkaymAgkP = 8,
		aNFDXSlDcBXwkM = 16,
		VoBTpCkLoSmllnO = 19
	}

	public enum qxlfRAnOsOG
	{
		GiovhfRIQEYKqve,
		wGygsVxAAkI,
		pWVuzzjCzmbKY,
		SAiJYXvifqNiS,
		IPAuvBjaMX,
		jRYiqnutmSPXGLm,
		KExOAnVdklg,
		RsIrbdXLKy,
		aNEWusjSKaT,
		PkmWpvhcxDs,
		TuMXSFwCaN,
		ZcvHLjJNCZFaM
	}

	public sealed class fwmZFrEmnsyKJsJw : IEnumerable
	{
		private enum fdanuVDwbRo
		{
			tDxCwRMPrIN = 0,
			vDxbJOaWKWFRzZ = 259
		}

		[StructLayout(LayoutKind.Sequential)]
		private sealed class UXrEzJVgVaOW
		{
			public xmUhmglkoULLQQ wtYkFLHeZRgTiP;

			public jCzDMhEMsmTb DjWfybqpfMov;

			public qxlfRAnOsOG ScVIzeQMSZjSGbF;

			public YdPGbBBbjcnel eaEBciriPASovqeB;

			public string FQnBYjOfuP;

			public string WLlKuLkivRP;

			public string LGFCfUmIxPGll;

			public string AuNvjaLATrBt;
		}

		private ArrayList nEfmwUZknYbP = new ArrayList();

		[DllImport("Mpr.dll")]
		private static extern fdanuVDwbRo WNetOpenEnumA(xmUhmglkoULLQQ dwScope, jCzDMhEMsmTb dwType, YdPGbBBbjcnel dwUsage, UXrEzJVgVaOW p, out IntPtr lphEnum);

		[DllImport("Mpr.dll")]
		private static extern fdanuVDwbRo WNetCloseEnum(IntPtr intptr_0);

		[DllImport("Mpr.dll")]
		private static extern fdanuVDwbRo WNetEnumResourceA(IntPtr intptr_0, ref uint uint_0, IntPtr intptr_1, ref uint uint_1);

		private void EnumerateServers(UXrEzJVgVaOW uxrEzJVgVaOW_0, xmUhmglkoULLQQ xmUhmglkoULLQQ_0, jCzDMhEMsmTb jCzDMhEMsmTb_0, YdPGbBBbjcnel ydPGbBBbjcnel_0, qxlfRAnOsOG qxlfRAnOsOG_0)
		{
			uint uint_ = 16384u;
			IntPtr intPtr = Marshal.AllocHGlobal(16384);
			IntPtr lphEnum = IntPtr.Zero;
			uint uint_2 = 1u;
			if (WNetOpenEnumA(xmUhmglkoULLQQ_0, jCzDMhEMsmTb_0, ydPGbBBbjcnel_0, uxrEzJVgVaOW_0, out lphEnum) == fdanuVDwbRo.tDxCwRMPrIN)
			{
				fdanuVDwbRo fdanuVDwbRo;
				do
				{
					fdanuVDwbRo = WNetEnumResourceA(lphEnum, ref uint_2, intPtr, ref uint_);
					switch (fdanuVDwbRo)
					{
					case fdanuVDwbRo.vDxbJOaWKWFRzZ:
						continue;
					case fdanuVDwbRo.tDxCwRMPrIN:
						Marshal.PtrToStructure(intPtr, uxrEzJVgVaOW_0);
						if (uxrEzJVgVaOW_0.ScVIzeQMSZjSGbF == qxlfRAnOsOG_0)
						{
							nEfmwUZknYbP.Add(uxrEzJVgVaOW_0.WLlKuLkivRP);
						}
						if ((uxrEzJVgVaOW_0.eaEBciriPASovqeB & YdPGbBBbjcnel.sUErqnyxeMGe) == YdPGbBBbjcnel.sUErqnyxeMGe)
						{
							EnumerateServers(uxrEzJVgVaOW_0, xmUhmglkoULLQQ_0, jCzDMhEMsmTb_0, ydPGbBBbjcnel_0, qxlfRAnOsOG_0);
						}
						continue;
					}
					break;
				}
				while (fdanuVDwbRo != fdanuVDwbRo.vDxbJOaWKWFRzZ);
				WNetCloseEnum(lphEnum);
			}
			Marshal.FreeHGlobal(intPtr);
		}

		public fwmZFrEmnsyKJsJw(xmUhmglkoULLQQ xmUhmglkoULLQQ_0, jCzDMhEMsmTb jCzDMhEMsmTb_0, YdPGbBBbjcnel ydPGbBBbjcnel_0, qxlfRAnOsOG qxlfRAnOsOG_0)
		{
			UXrEzJVgVaOW uxrEzJVgVaOW_ = new UXrEzJVgVaOW();
			EnumerateServers(uxrEzJVgVaOW_, xmUhmglkoULLQQ_0, jCzDMhEMsmTb_0, ydPGbBBbjcnel_0, qxlfRAnOsOG_0);
		}

		public IEnumerator GetEnumerator()
		{
			return nEfmwUZknYbP.GetEnumerator();
		}
	}

	public static List<string> lRpqlUsMWX;

	public static string XESveGKIDckrdo;

	public static List<string> epCdRbBHLhIcBW;

	public static List<string> TlOJzYOQWrLeSd;

	public static List<string> kBiashfbBUQorp;

	public List<string> IFZRQoZygVoYo = new List<string>();

	public List<string> aKJYafvebTy = new List<string>();

	public List<string> GfknRuiljSf = new List<string>();

	[NonSerialized]
	internal static GetString getString_0;

	public static bool vumdNHowDgN(string string_0)
	{
		bool result = false;
		Ping ping = null;
		try
		{
			using (ping = new Ping())
			{
				PingReply pingReply = ping.Send(string_0);
				result = pingReply.Status == IPStatus.Success;
				return result;
			}
		}
		catch (PingException)
		{
			return result;
		}
		finally
		{
			ping?.Dispose();
		}
	}

	static zCfylsHdiOAalsC()
	{
		Strings.CreateGetStringDelegate(typeof(zCfylsHdiOAalsC));
		lRpqlUsMWX = new List<string>();
		XESveGKIDckrdo = getString_0(107388138);
		epCdRbBHLhIcBW = new List<string>();
		TlOJzYOQWrLeSd = new List<string>();
		kBiashfbBUQorp = new List<string>();
	}
}
