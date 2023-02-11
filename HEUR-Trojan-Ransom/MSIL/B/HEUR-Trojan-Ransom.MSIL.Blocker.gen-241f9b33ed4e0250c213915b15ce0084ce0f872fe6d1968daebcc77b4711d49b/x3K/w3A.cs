using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Fc0;
using Ke7q;
using Microsoft.VisualBasic.CompilerServices;
using Xw5;
using Zk30;
using e8F;
using j3E;
using m0BW;

namespace x3K;

public class w3A
{
	private Gb6 _inspectionExcel;

	private Ns4 setting;

	public Gb6 InspectionExcel
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

	public Gb6 w3S()
	{
		return _inspectionExcel;
	}

	public w3A(int ident, string datadir)
	{
		_inspectionExcel = new Gb6();
		setting = Ns4.g6N();
		_inspectionExcel.ident = ident;
		_inspectionExcel.datadir = datadir;
		Jd7();
	}

	private void Jd7()
	{
		_inspectionExcel.id = Bw4();
		Lz9();
		i7H();
	}

	internal static string[] Xc4()
	{
		Az5.Sp9();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		i2HW.mDic.Add("Ann", value);
		return Yk0();
	}

	private int Bw4()
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

	private void Lz9()
	{
		try
		{
			Jg3 jg = new Jg3();
			jg.d1B(y2J(), m6J: true);
			jg.z2B(setting.SheetName);
			object objectValue = RuntimeHelpers.GetObjectValue(jg.x6G(setting.InspectionyearRow, setting.InspectionyearColumn).Text);
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
			_inspectionExcel.inspectioner = Conversions.ToString(jg.x6G(setting.InspectionerRow, setting.InspectionerColumn).Text);
			_inspectionExcel.undercondition = Conversions.ToString(jg.x6G(setting.UnderconditionRow, setting.UnderconditionColumn).Text);
			_inspectionExcel.alternatepath = Conversions.ToString(jg.x6G(setting.AlternatepathRow, setting.AlternatepathColumn).Text);
			_inspectionExcel.generalroad = Conversions.ToString(jg.x6G(setting.GeneralroadRow, setting.GeneralroadColumn).Text);
			_inspectionExcel.emergencyroad = Conversions.ToString(jg.x6G(setting.EmergencyroadRow, setting.EmergencyroadColumn).Text);
			_inspectionExcel.occupancy = Conversions.ToString(jg.x6G(setting.OccupancyRow, setting.OccupancyColumn).Text);
			_inspectionExcel.soundness = Conversions.ToString(jg.x6G(setting.SoundnessRow, setting.SoundnessColumn).Text);
			_inspectionExcel.uppermaterialmain = Conversions.ToString(jg.x6G(setting.UppermaterialmainRow, setting.UppermaterialmainColumn).Text);
			_inspectionExcel.uppermaterialside = Conversions.ToString(jg.x6G(setting.UppermaterialsideRow, setting.UppermaterialsideColumn).Text);
			_inspectionExcel.uppermaterialfloor = Conversions.ToString(jg.x6G(setting.UppermaterialfloorRow, setting.UppermaterialfloorColumn).Text);
			_inspectionExcel.undermaterial = Conversions.ToString(jg.x6G(setting.UndermaterialRow, setting.UndermaterialColumn).Text);
			_inspectionExcel.bearing = Conversions.ToString(jg.x6G(setting.BearingRow, setting.BearingColumn).Text);
			_inspectionExcel.face = Conversions.ToString(jg.x6G(setting.FaceRow, setting.FaceColumn).Text);
			jg.t3M(Hb6: false);
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

	private string y2J()
	{
		string[] files = Directory.GetFiles(_inspectionExcel.datadir);
		IEnumerable<string> source = files.Where((string j3Q) => Path.GetFileName(j3Q)!.StartsWith(setting.FilePrefix));
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

	internal static string[] Yk0()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)i2HW.mDic["Ann"]).GetManifestResourceNames();
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

	private void i7H()
	{
		Kt3();
	}

	private void Kt3()
	{
		i6C1 i6C = new i6C1();
		c7P9 c7P = i6C.bridge.Find(new object[1] { _inspectionExcel.id });
		if (c7P == null)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "管理テーブルにデータが見つかりません。";
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool g0L(string j3Q)
	{
		return Path.GetFileName(j3Q)!.StartsWith(setting.FilePrefix);
	}
}
