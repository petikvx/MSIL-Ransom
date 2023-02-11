using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace frgoWklvEOSV;

public sealed class cqqMHKHKHQkt
{
	[ComImport]
	[TypeLibType(4160)]
	[Guid("F935DC23-1CF0-11D0-ADB9-00C04FD58A0B")]
	private interface EwjSRatTRKu
	{
		[DispId(0)]
		string sIvZbsnNomb
		{
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(1000)]
		string niIRnqpVGnT
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
		string ZLWyddHxMFyge
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
		string SMvQlKzDvuETjbc
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
		string mKUsCwvKzAZtkQYDq
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
		string FqQyLlkbxQRl
		{
			[DispId(1004)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1005)]
		string DsEqJLgUSBT
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
		int okmFpsEuznvS
		{
			[DispId(1006)]
			get;
			[DispId(1006)]
			[param: In]
			set;
		}

		[DispId(1007)]
		string ZLcgTlMiQx
		{
			[DispId(1007)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[DispId(1007)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[TypeLibFunc(64)]
		[DispId(2000)]
		void Load([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

		[DispId(2001)]
		void Save();
	}

	private static Type aWXYNLCcuqQO;

	private static object XBaNqhVcgn;

	[NonSerialized]
	internal static GetString _0017;

	public static void MzToDMiFBwaOs(string P_0, string P_1, string P_2, string P_3, string P_4, string P_5, string P_6)
	{
		try
		{
			EwjSRatTRKu ewjSRatTRKu = (EwjSRatTRKu)aWXYNLCcuqQO.InvokeMember(PFruJiQrcriiZ.GwTsezEgVAuVAU(_0017(107400057)), BindingFlags.InvokeMethod, null, XBaNqhVcgn, new object[1] { P_0 });
			ewjSRatTRKu.ZLWyddHxMFyge = P_4;
			ewjSRatTRKu.SMvQlKzDvuETjbc = P_5;
			ewjSRatTRKu.DsEqJLgUSBT = P_1;
			ewjSRatTRKu.ZLcgTlMiQx = P_3;
			ewjSRatTRKu.niIRnqpVGnT = P_2;
			if (!string.IsNullOrEmpty(P_6))
			{
				ewjSRatTRKu.mKUsCwvKzAZtkQYDq = P_6;
			}
			ewjSRatTRKu.Save();
		}
		catch (Exception ex)
		{
			if (PFruJiQrcriiZ.joesCNAxeHUI)
			{
				try
				{
					File.AppendAllText(PFruJiQrcriiZ.jnRLNtXuRRg, _0017(107399996) + ex.Message + _0017(107396365));
					return;
				}
				catch (Exception)
				{
					return;
				}
			}
		}
	}

	static cqqMHKHKHQkt()
	{
		Strings.CreateGetStringDelegate(typeof(cqqMHKHKHQkt));
		aWXYNLCcuqQO = Type.GetTypeFromProgID(PFruJiQrcriiZ.GwTsezEgVAuVAU(_0017(107399983)));
		XBaNqhVcgn = Activator.CreateInstance(aWXYNLCcuqQO);
	}
}
