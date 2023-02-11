using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace jtAYXTgtXeY;

public sealed class zqQKRDaaTjO
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface LtBJgftTQAhMSP
	{
		[DispId(0)]
		string LEGZVLjUQgw
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string kgZakKYcWEvgI
		{
			[DispId(1000)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1000)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1001)]
		string VpQodcoiNf
		{
			[DispId(1001)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1001)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1002)]
		string tFnpxICPVXd
		{
			[DispId(1002)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1002)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1003)]
		string yzgjxImZjlHo
		{
			[DispId(1003)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1003)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1004)]
		string nelBpLQZYGb
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string eTXUqmUVnCG
		{
			[DispId(1005)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1005)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1006)]
		int JmazMUXuYhN
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string dPjEBkzELuQ
		{
			[DispId(1007)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1007)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(2000)]
		[TypeLibFunc(64)]
		void Load([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

		[DispId(2001)]
		void Save();
	}

	private static Type tfXnbiPuSzVyb;

	private static object dWSkfqPMsqGBFzzB;

	[NonSerialized]
	internal static GetString getString_0;

	public static void EUXcyRIMMkZ(string string_0, string string_1, string string_2, string string_3, string string_4, string string_5, string string_6)
	{
		try
		{
			LtBJgftTQAhMSP ltBJgftTQAhMSP = (LtBJgftTQAhMSP)tfXnbiPuSzVyb.InvokeMember(efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107398568)), BindingFlags.InvokeMethod, null, dWSkfqPMsqGBFzzB, new object[1] { string_0 });
			ltBJgftTQAhMSP.VpQodcoiNf = string_4;
			ltBJgftTQAhMSP.tFnpxICPVXd = string_5;
			ltBJgftTQAhMSP.eTXUqmUVnCG = string_1;
			ltBJgftTQAhMSP.dPjEBkzELuQ = string_3;
			ltBJgftTQAhMSP.kgZakKYcWEvgI = string_2;
			if (!string.IsNullOrEmpty(string_6))
			{
				ltBJgftTQAhMSP.yzgjxImZjlHo = string_6;
			}
			ltBJgftTQAhMSP.Save();
		}
		catch (Exception ex)
		{
			if (efoRmwagKuQD.WkkVnLAdbtG)
			{
				try
				{
					File.AppendAllText(efoRmwagKuQD.PhOHjwgFpwoPkI, getString_0(107398571) + ex.Message + getString_0(107396459));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static zqQKRDaaTjO()
	{
		Strings.CreateGetStringDelegate(typeof(zqQKRDaaTjO));
		tfXnbiPuSzVyb = Type.GetTypeFromProgID(efoRmwagKuQD.UPTUMFgiFSZjXAR(getString_0(107398494)));
		dWSkfqPMsqGBFzzB = Activator.CreateInstance(tfXnbiPuSzVyb);
	}
}
