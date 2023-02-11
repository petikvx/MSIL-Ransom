using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Af7;
using Hm3;
using Microsoft.VisualBasic.CompilerServices;
using Rm67;
using Sr8n;
using a3A1;
using c7AC;
using k7R;

namespace a0LR;

public class Hf4g
{
	private r0QH _inspectionExcel;

	private Xk42 setting;

	public r0QH InspectionExcel
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

	public r0QH Xt7i()
	{
		return _inspectionExcel;
	}

	public Hf4g(int ident, string datadir)
	{
		_inspectionExcel = new r0QH();
		setting = Xk42.Yd9g();
		_inspectionExcel.ident = ident;
		_inspectionExcel.datadir = datadir;
		r6AM();
	}

	private void r6AM()
	{
		_inspectionExcel.id = e0XG();
		Bb4c();
		Xa5g();
	}

	internal static string[] x5D4()
	{
		Mk49.a3J5();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		d5Q.mDic.Add("Ann", value);
		return Je9z();
	}

	private int e0XG()
	{
		int result = default(int);
		try
		{
			StreamReader streamReader = new StreamReader(Path.Combine(_inspectionExcel.datadir, setting.IdFile.ToString()));
			string s = streamReader.ReadLine();
			result = int.Parse(s);
			return result;
		}
		catch (FileNotFoundException ex)
		{
			ProjectData.SetProjectError((Exception)ex);
			FileNotFoundException ex2 = ex;
			_inspectionExcel.error = true;
			_inspectionExcel.message = _inspectionExcel.message + setting.IdFile + "が見つかりません。";
			ProjectData.ClearProjectError();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			_inspectionExcel.error = true;
			_inspectionExcel.message = _inspectionExcel.message + ex4.Message + "。";
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private void Bb4c()
	{
		try
		{
			Sa2y sa2y = new Sa2y();
			sa2y.Gk26(n5DB(), Xb20: true);
			sa2y.o6C9(setting.SheetName);
			object objectValue = RuntimeHelpers.GetObjectValue(sa2y.Cf3s(setting.InspectionyearRow, setting.InspectionyearColumn).Text);
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
			_inspectionExcel.inspectioner = Conversions.ToString(sa2y.Cf3s(setting.InspectionerRow, setting.InspectionerColumn).Text);
			_inspectionExcel.undercondition = Conversions.ToString(sa2y.Cf3s(setting.UnderconditionRow, setting.UnderconditionColumn).Text);
			_inspectionExcel.alternatepath = Conversions.ToString(sa2y.Cf3s(setting.AlternatepathRow, setting.AlternatepathColumn).Text);
			_inspectionExcel.generalroad = Conversions.ToString(sa2y.Cf3s(setting.GeneralroadRow, setting.GeneralroadColumn).Text);
			_inspectionExcel.emergencyroad = Conversions.ToString(sa2y.Cf3s(setting.EmergencyroadRow, setting.EmergencyroadColumn).Text);
			_inspectionExcel.occupancy = Conversions.ToString(sa2y.Cf3s(setting.OccupancyRow, setting.OccupancyColumn).Text);
			_inspectionExcel.soundness = Conversions.ToString(sa2y.Cf3s(setting.SoundnessRow, setting.SoundnessColumn).Text);
			_inspectionExcel.uppermaterialmain = Conversions.ToString(sa2y.Cf3s(setting.UppermaterialmainRow, setting.UppermaterialmainColumn).Text);
			_inspectionExcel.uppermaterialside = Conversions.ToString(sa2y.Cf3s(setting.UppermaterialsideRow, setting.UppermaterialsideColumn).Text);
			_inspectionExcel.uppermaterialfloor = Conversions.ToString(sa2y.Cf3s(setting.UppermaterialfloorRow, setting.UppermaterialfloorColumn).Text);
			_inspectionExcel.undermaterial = Conversions.ToString(sa2y.Cf3s(setting.UndermaterialRow, setting.UndermaterialColumn).Text);
			_inspectionExcel.bearing = Conversions.ToString(sa2y.Cf3s(setting.BearingRow, setting.BearingColumn).Text);
			_inspectionExcel.face = Conversions.ToString(sa2y.Cf3s(setting.FaceRow, setting.FaceColumn).Text);
			sa2y.Hs21(Sn9x: false);
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

	private string n5DB()
	{
		string[] files = Directory.GetFiles(_inspectionExcel.datadir);
		IEnumerable<string> source = files.Where((string o4YZ) => Path.GetFileName(o4YZ)!.StartsWith(setting.FilePrefix));
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

	internal static string[] Je9z()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)d5Q.mDic["Ann"]).GetManifestResourceNames();
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

	private void Xa5g()
	{
		t7YB();
	}

	private void t7YB()
	{
		Fp9 fp = new Fp9();
		Zo4 zo = fp.bridge.Find(new object[1] { _inspectionExcel.id });
		if (zo == null)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "管理テーブルにデータが見つかりません。";
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool r3YQ(string o4YZ)
	{
		return Path.GetFileName(o4YZ)!.StartsWith(setting.FilePrefix);
	}
}
