using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Hb29;
using Microsoft.VisualBasic.CompilerServices;
using Rs6e;
using Zs65;
using e3K;
using f3D;
using n2WG;
using q3A;

namespace Gt5p;

public class b2E5
{
	private m1CE _inspectionExcel;

	private i4Z2 setting;

	public m1CE InspectionExcel
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

	public m1CE g3FJ()
	{
		return _inspectionExcel;
	}

	public b2E5(int ident, string datadir)
	{
		_inspectionExcel = new m1CE();
		setting = i4Z2.k0WJ();
		_inspectionExcel.ident = ident;
		_inspectionExcel.datadir = datadir;
		Go56();
	}

	private void Go56()
	{
		_inspectionExcel.id = Xi8r();
		Ss90();
		Hp35();
	}

	internal static string[] Fk3i()
	{
		Qp4o.e3P8();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		n2C.mDic.Add("Ann", value);
		return Lm6a();
	}

	private int Xi8r()
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

	private void Ss90()
	{
		try
		{
			m1XN m1XN = new m1XN();
			m1XN.Dp95(d5WA(), c1J8: true);
			m1XN.r6K5(setting.SheetName);
			object objectValue = RuntimeHelpers.GetObjectValue(m1XN.Ai60(setting.InspectionyearRow, setting.InspectionyearColumn).Text);
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
			_inspectionExcel.inspectioner = Conversions.ToString(m1XN.Ai60(setting.InspectionerRow, setting.InspectionerColumn).Text);
			_inspectionExcel.undercondition = Conversions.ToString(m1XN.Ai60(setting.UnderconditionRow, setting.UnderconditionColumn).Text);
			_inspectionExcel.alternatepath = Conversions.ToString(m1XN.Ai60(setting.AlternatepathRow, setting.AlternatepathColumn).Text);
			_inspectionExcel.generalroad = Conversions.ToString(m1XN.Ai60(setting.GeneralroadRow, setting.GeneralroadColumn).Text);
			_inspectionExcel.emergencyroad = Conversions.ToString(m1XN.Ai60(setting.EmergencyroadRow, setting.EmergencyroadColumn).Text);
			_inspectionExcel.occupancy = Conversions.ToString(m1XN.Ai60(setting.OccupancyRow, setting.OccupancyColumn).Text);
			_inspectionExcel.soundness = Conversions.ToString(m1XN.Ai60(setting.SoundnessRow, setting.SoundnessColumn).Text);
			_inspectionExcel.uppermaterialmain = Conversions.ToString(m1XN.Ai60(setting.UppermaterialmainRow, setting.UppermaterialmainColumn).Text);
			_inspectionExcel.uppermaterialside = Conversions.ToString(m1XN.Ai60(setting.UppermaterialsideRow, setting.UppermaterialsideColumn).Text);
			_inspectionExcel.uppermaterialfloor = Conversions.ToString(m1XN.Ai60(setting.UppermaterialfloorRow, setting.UppermaterialfloorColumn).Text);
			_inspectionExcel.undermaterial = Conversions.ToString(m1XN.Ai60(setting.UndermaterialRow, setting.UndermaterialColumn).Text);
			_inspectionExcel.bearing = Conversions.ToString(m1XN.Ai60(setting.BearingRow, setting.BearingColumn).Text);
			_inspectionExcel.face = Conversions.ToString(m1XN.Ai60(setting.FaceRow, setting.FaceColumn).Text);
			m1XN.m1E5(Sw81: false);
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

	private string d5WA()
	{
		string[] files = Directory.GetFiles(_inspectionExcel.datadir);
		IEnumerable<string> source = files.Where((string d1ZJ) => Path.GetFileName(d1ZJ)!.StartsWith(setting.FilePrefix));
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

	internal static string[] Lm6a()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)n2C.mDic["Ann"]).GetManifestResourceNames();
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

	private void Hp35()
	{
		d9GX();
	}

	private void d9GX()
	{
		o6Q o6Q = new o6Q();
		m9A m9A = o6Q.bridge.Find(new object[1] { _inspectionExcel.id });
		if (m9A == null)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "管理テーブルにデータが見つかりません。";
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool k2LH(string d1ZJ)
	{
		return Path.GetFileName(d1ZJ)!.StartsWith(setting.FilePrefix);
	}
}
