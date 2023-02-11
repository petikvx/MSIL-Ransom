using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using At48;
using Dq2c;
using Kn0;
using Microsoft.VisualBasic.CompilerServices;
using Xm80;
using o4X;
using p8CM;
using t6G;

namespace Nf4;

public class a9K
{
	private Xw53 _inspectionExcel;

	private o7E3 setting;

	public Xw53 InspectionExcel
	{
		get
		{
			return _inspectionExcel;
		}
		set
		{
			_inspectionExcel = value;
		}
	}

	public Xw53 n6A()
	{
		return _inspectionExcel;
	}

	public a9K(int ident, string datadir)
	{
		_inspectionExcel = new Xw53();
		setting = o7E3.Zs34();
		_inspectionExcel.ident = ident;
		_inspectionExcel.datadir = datadir;
		j0T();
	}

	private void j0T()
	{
		_inspectionExcel.id = Xa6();
		Ye0();
		Ta9();
	}

	internal static string[] i2X()
	{
		Ns0.Kp7();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		y6N.mDic.Add("Ann", value);
		return t6J();
	}

	private int Xa6()
	{
		int result = default(int);
		try
		{
			StreamReader streamReader = new StreamReader(Path.Combine(_inspectionExcel.datadir, setting.IdFile.ToString()));
			string s = streamReader.ReadLine();
			result = int.Parse(s);
			return result;
		}
		catch (FileNotFoundException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			_inspectionExcel.error = true;
			_inspectionExcel.message = _inspectionExcel.message + setting.IdFile + "が見つかりません。";
			ProjectData.ClearProjectError();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			_inspectionExcel.error = true;
			_inspectionExcel.message = _inspectionExcel.message + ex2.Message + "。";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void Ye0()
	{
		try
		{
			Xa65 xa = new Xa65();
			xa.o5L(Db1(), j7F: true);
			xa.Mg3(setting.SheetName);
			object objectValue = RuntimeHelpers.GetObjectValue(xa.Fz2(setting.InspectionyearRow, setting.InspectionyearColumn).Text);
			if (DateTime.TryParse(Conversions.ToString(objectValue), out var result))
			{
				result = result.AddMonths(-3);
				_inspectionExcel.inspectionyear = result.Year;
			}
			else
			{
				_inspectionExcel.error = true;
				_inspectionExcel.message += "点検年度が取得できません。";
			}
			_inspectionExcel.inspectioner = Conversions.ToString(xa.Fz2(setting.InspectionerRow, setting.InspectionerColumn).Text);
			_inspectionExcel.undercondition = Conversions.ToString(xa.Fz2(setting.UnderconditionRow, setting.UnderconditionColumn).Text);
			_inspectionExcel.alternatepath = Conversions.ToString(xa.Fz2(setting.AlternatepathRow, setting.AlternatepathColumn).Text);
			_inspectionExcel.generalroad = Conversions.ToString(xa.Fz2(setting.GeneralroadRow, setting.GeneralroadColumn).Text);
			_inspectionExcel.emergencyroad = Conversions.ToString(xa.Fz2(setting.EmergencyroadRow, setting.EmergencyroadColumn).Text);
			_inspectionExcel.occupancy = Conversions.ToString(xa.Fz2(setting.OccupancyRow, setting.OccupancyColumn).Text);
			_inspectionExcel.soundness = Conversions.ToString(xa.Fz2(setting.SoundnessRow, setting.SoundnessColumn).Text);
			_inspectionExcel.uppermaterialmain = Conversions.ToString(xa.Fz2(setting.UppermaterialmainRow, setting.UppermaterialmainColumn).Text);
			_inspectionExcel.uppermaterialside = Conversions.ToString(xa.Fz2(setting.UppermaterialsideRow, setting.UppermaterialsideColumn).Text);
			_inspectionExcel.uppermaterialfloor = Conversions.ToString(xa.Fz2(setting.UppermaterialfloorRow, setting.UppermaterialfloorColumn).Text);
			_inspectionExcel.undermaterial = Conversions.ToString(xa.Fz2(setting.UndermaterialRow, setting.UndermaterialColumn).Text);
			_inspectionExcel.bearing = Conversions.ToString(xa.Fz2(setting.BearingRow, setting.BearingColumn).Text);
			_inspectionExcel.face = Conversions.ToString(xa.Fz2(setting.FaceRow, setting.FaceColumn).Text);
			xa.Jt9(Bm7: false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			_inspectionExcel.error = true;
			_inspectionExcel.message += ex2.Message;
			ProjectData.ClearProjectError();
		}
	}

	private string Db1()
	{
		string[] files = Directory.GetFiles(_inspectionExcel.datadir);
		IEnumerable<string> source = files.Where((string e5N) => Path.GetFileName(e5N)!.StartsWith(setting.FilePrefix));
		if (source.Count() > 1)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "Excelのデータファイルが複数あります。";
			return "";
		}
		if (source.Count() < 1)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "Excelのデータファイルが見つかりません。";
			return "";
		}
		return source.First();
	}

	internal static string[] t6J()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)y6N.mDic["Ann"]).GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}

	private void Ta9()
	{
		e9P();
	}

	private void e9P()
	{
		r3E r3E = new r3E();
		p1W4 p1W = r3E.bridge.Find(new object[1] { _inspectionExcel.id });
		if (p1W == null)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "管理テーブルにデータが見つかりません。";
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool Bg3(string e5N)
	{
		return Path.GetFileName(e5N)!.StartsWith(setting.FilePrefix);
	}
}
