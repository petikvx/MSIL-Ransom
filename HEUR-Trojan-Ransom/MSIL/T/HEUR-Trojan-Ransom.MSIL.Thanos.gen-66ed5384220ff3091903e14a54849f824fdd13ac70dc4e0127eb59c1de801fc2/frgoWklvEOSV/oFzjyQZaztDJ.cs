using System;
using System.Diagnostics;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public static class oFzjyQZaztDJ
{
	[NonSerialized]
	internal static GetString _000E;

	public static void QdsUxwYDRCW(string P_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, _000E(107402593) + P_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static oFzjyQZaztDJ()
	{
		Strings.CreateGetStringDelegate(typeof(oFzjyQZaztDJ));
	}
}
