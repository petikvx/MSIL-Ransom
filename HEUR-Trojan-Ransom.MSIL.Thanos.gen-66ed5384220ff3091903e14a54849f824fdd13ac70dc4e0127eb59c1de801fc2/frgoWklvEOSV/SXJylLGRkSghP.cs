using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

internal sealed class SXJylLGRkSghP
{
	[NonSerialized]
	internal static GetString _0011;

	public static void AfvdtDeOuqUqWT()
	{
		if (jeNVzYHbQf() || uwPVrcVobWimW() || LiMBvErHaWG() || PcGjaEFrQtsdx())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool LiMBvErHaWG()
	{
		try
		{
			long num = 61000000000L;
			if (new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize <= num)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool PcGjaEFrQtsdx()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(_0011(107403032)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool jeNVzYHbQf()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(_0011(107403027));
			try
			{
				ManagementObjectCollection val2 = val.Get();
				try
				{
					ManagementObjectEnumerator enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementBaseObject current = enumerator.get_Current();
							string text = current.get_Item(_0011(107403010)).ToString()!.ToLower();
							if ((text == _0011(107402961) && current.get_Item(_0011(107402932)).ToString()!.ToUpperInvariant().Contains(_0011(107402955))) || text.Contains(_0011(107402942)) || current.get_Item(_0011(107402932)).ToString() == _0011(107402901))
							{
								return true;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool uwPVrcVobWimW()
	{
		try
		{
			if (GDuxaPadSRip(_0011(107402916)).ToInt32() != 0)
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	[DllImport("kernel32.dll", EntryPoint = "GetModuleHandle")]
	public static extern IntPtr GDuxaPadSRip(string P_0);

	static SXJylLGRkSghP()
	{
		Strings.CreateGetStringDelegate(typeof(SXJylLGRkSghP));
	}
}
