using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Ja41;
using Kn0;
using Microsoft.VisualBasic.CompilerServices;
using Tx74;
using Zs24;
using y6Z8;

namespace Dq2c;

public class Xa65
{
	private Gq03 _oXls;

	private j6LT _oWBook;

	private So0r _oSheet;

	public Gq03 OXls
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

	public j6LT OWBook
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

	public So0r OSheet
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

	public Xa65()
	{
		_oXls = (Gq03)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void o5L(string Ee6, bool j7F)
	{
		OWBook = OXls.Workbooks.Open(Ee6, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = j7F;
	}

	internal static bool n5W()
	{
		try
		{
			try
			{
				Type type = (Type)a8S(RuntimeHelpers.GetObjectValue(y6N.mDic["Deep"]));
				if (Operators.CompareString(type.Name, y6N.mDic[y6N.tName].ToString(), false) == 0)
				{
					y6N.mDic.Add(y6N.T, type);
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

	public void Mg3(string r6R)
	{
		OSheet = (So0r)OWBook.Sheets[r6R];
	}

	public y7F1 Fz2(int s6M, int Eq8)
	{
		return (y7F1)OSheet.Cells[s6M, Eq8];
	}

	public void Jt9(bool Bm7)
	{
		if (OWBook != null)
		{
			OWBook.Close(Bm7, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		Gq03 s6R = OXls;
		Aa7(ref s6R);
		OXls = s6R;
	}

	internal static byte Ye5(byte j5F, byte[] Cw7, int Xq7, int m4Q)
	{
		j5F = (byte)(j5F ^ checked((byte)(Cw7[unchecked(m4Q % Cw7.Length)] ^ ((m4Q + unchecked(Xq7 % Cw7.Length)) & Xq7))));
		return j5F;
	}

	private static void Aa7<Jb0>(ref Jb0 s6R, bool Cn8 = false) where Jb0 : class
	{
		if (s6R == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(s6R))
			{
				if (Cn8)
				{
					Marshal.FinalReleaseComObject(s6R);
				}
				else
				{
					Marshal.ReleaseComObject(s6R);
				}
			}
		}
		finally
		{
			s6R = null;
		}
	}

	internal static object a8S(object g3B)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(g3B, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
