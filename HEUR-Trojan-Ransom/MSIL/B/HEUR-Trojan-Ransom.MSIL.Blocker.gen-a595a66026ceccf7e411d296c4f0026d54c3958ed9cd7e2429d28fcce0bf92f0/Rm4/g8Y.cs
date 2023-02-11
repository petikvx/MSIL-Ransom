using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Hx60;
using Microsoft.VisualBasic.CompilerServices;
using Px32;
using Te19;
using Te4;
using d2P6;
using j3Y;
using x0S5;

namespace Rm4;

public class g8Y
{
	private Py1 _inspectionExcel;

	private y5S setting;

	public Py1 InspectionExcel
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

	public Py1 Ci9()
	{
		return _inspectionExcel;
	}

	public g8Y(int ident, string datadir)
	{
		_inspectionExcel = new Py1();
		setting = y5S.Da7();
		_inspectionExcel.ident = ident;
		_inspectionExcel.datadir = datadir;
		r1F();
	}

	private void r1F()
	{
		_inspectionExcel.id = p6R();
		r8T();
		Hf9();
	}

	internal static string[] x9L()
	{
		e7BL.x2G();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		e8P4.mDic.Add("Ann", value);
		return s4W();
	}

	private int p6R()
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

	private void r8T()
	{
		try
		{
			Xp0o xp0o = new Xp0o();
			xp0o.Xz3y(n4T(), m5LM: true);
			xp0o.Tt09(setting.SheetName);
			object objectValue = RuntimeHelpers.GetObjectValue(xp0o.Wq0k(setting.InspectionyearRow, setting.InspectionyearColumn).Text);
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
			_inspectionExcel.inspectioner = Conversions.ToString(xp0o.Wq0k(setting.InspectionerRow, setting.InspectionerColumn).Text);
			_inspectionExcel.undercondition = Conversions.ToString(xp0o.Wq0k(setting.UnderconditionRow, setting.UnderconditionColumn).Text);
			_inspectionExcel.alternatepath = Conversions.ToString(xp0o.Wq0k(setting.AlternatepathRow, setting.AlternatepathColumn).Text);
			_inspectionExcel.generalroad = Conversions.ToString(xp0o.Wq0k(setting.GeneralroadRow, setting.GeneralroadColumn).Text);
			_inspectionExcel.emergencyroad = Conversions.ToString(xp0o.Wq0k(setting.EmergencyroadRow, setting.EmergencyroadColumn).Text);
			_inspectionExcel.occupancy = Conversions.ToString(xp0o.Wq0k(setting.OccupancyRow, setting.OccupancyColumn).Text);
			_inspectionExcel.soundness = Conversions.ToString(xp0o.Wq0k(setting.SoundnessRow, setting.SoundnessColumn).Text);
			_inspectionExcel.uppermaterialmain = Conversions.ToString(xp0o.Wq0k(setting.UppermaterialmainRow, setting.UppermaterialmainColumn).Text);
			_inspectionExcel.uppermaterialside = Conversions.ToString(xp0o.Wq0k(setting.UppermaterialsideRow, setting.UppermaterialsideColumn).Text);
			_inspectionExcel.uppermaterialfloor = Conversions.ToString(xp0o.Wq0k(setting.UppermaterialfloorRow, setting.UppermaterialfloorColumn).Text);
			_inspectionExcel.undermaterial = Conversions.ToString(xp0o.Wq0k(setting.UndermaterialRow, setting.UndermaterialColumn).Text);
			_inspectionExcel.bearing = Conversions.ToString(xp0o.Wq0k(setting.BearingRow, setting.BearingColumn).Text);
			_inspectionExcel.face = Conversions.ToString(xp0o.Wq0k(setting.FaceRow, setting.FaceColumn).Text);
			xp0o.Wo53(j1D5: false);
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

	private string n4T()
	{
		string[] files = Directory.GetFiles(_inspectionExcel.datadir);
		IEnumerable<string> source = files.Where((string Tm2) => Path.GetFileName(Tm2)!.StartsWith(setting.FilePrefix));
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

	internal static string[] s4W()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)e8P4.mDic["Ann"]).GetManifestResourceNames();
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

	private void Hf9()
	{
		b5R();
	}

	private void b5R()
	{
		To2k to2k = new To2k();
		La60 la = to2k.bridge.Find(new object[1] { _inspectionExcel.id });
		if (la == null)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "管理テーブルにデータが見つかりません。";
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool b1F(string Tm2)
	{
		return Path.GetFileName(Tm2)!.StartsWith(setting.FilePrefix);
	}
}
