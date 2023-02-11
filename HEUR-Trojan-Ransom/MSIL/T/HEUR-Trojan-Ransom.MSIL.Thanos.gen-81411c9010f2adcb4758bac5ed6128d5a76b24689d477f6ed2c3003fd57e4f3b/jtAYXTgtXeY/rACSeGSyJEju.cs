using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

public static class rACSeGSyJEju
{
	[NonSerialized]
	internal static GetString getString_0;

	public static void ZKlsHJXKgfSGeH(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107401795) + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static rACSeGSyJEju()
	{
		Strings.CreateGetStringDelegate(typeof(rACSeGSyJEju));
	}
}
