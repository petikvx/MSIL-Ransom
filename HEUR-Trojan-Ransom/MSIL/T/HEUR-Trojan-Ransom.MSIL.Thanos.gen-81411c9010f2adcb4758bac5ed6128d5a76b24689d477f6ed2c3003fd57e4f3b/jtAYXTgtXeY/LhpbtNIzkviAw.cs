using System;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

public sealed class LhpbtNIzkviAw
{
	[NonSerialized]
	internal static GetString getString_0;

	[DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool DeleteFile(string fxPkxqsUlk);

	public bool fJuJQKilYQO(string string_0)
	{
		return DeleteFile(string_0 + getString_0(107397419));
	}

	static LhpbtNIzkviAw()
	{
		Strings.CreateGetStringDelegate(typeof(LhpbtNIzkviAw));
	}
}
