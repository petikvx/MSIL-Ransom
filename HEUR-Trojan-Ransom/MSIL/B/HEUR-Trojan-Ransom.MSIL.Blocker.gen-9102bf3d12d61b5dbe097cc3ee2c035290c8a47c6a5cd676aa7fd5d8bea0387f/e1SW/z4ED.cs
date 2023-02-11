using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Dx12;
using Microsoft.VisualBasic.CompilerServices;
using Pn96;
using j1ET;
using m6FE;
using o0H6;
using r1FS;
using s2JL;

namespace e1SW;

public class z4ED
{
	private c1BQ _inspectionExcel;

	private g2DS setting;

	public c1BQ InspectionExcel
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

	public c1BQ Bi1c()
	{
		return _inspectionExcel;
	}

	public z4ED(int ident, string datadir)
	{
		_inspectionExcel = new c1BQ();
		setting = g2DS.i0M4();
		_inspectionExcel.ident = ident;
		_inspectionExcel.datadir = datadir;
		Bf74();
	}

	private void Bf74()
	{
		_inspectionExcel.id = d9R4();
		Cw19();
		t9RP();
	}

	internal static string[] e8BF()
	{
		s4QA.s3R1();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		t2ZE.mDic.Add("Ann", value);
		return Zf7a();
	}

	private int d9R4()
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

	private void Cw19()
	{
		try
		{
			r5TX r5TX = new r5TX();
			r5TX.f3LZ(o2J7(), a7M2: true);
			r5TX.x9CS(setting.SheetName);
			object objectValue = RuntimeHelpers.GetObjectValue(r5TX.Js2n(setting.InspectionyearRow, setting.InspectionyearColumn).Text);
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
			_inspectionExcel.inspectioner = Conversions.ToString(r5TX.Js2n(setting.InspectionerRow, setting.InspectionerColumn).Text);
			_inspectionExcel.undercondition = Conversions.ToString(r5TX.Js2n(setting.UnderconditionRow, setting.UnderconditionColumn).Text);
			_inspectionExcel.alternatepath = Conversions.ToString(r5TX.Js2n(setting.AlternatepathRow, setting.AlternatepathColumn).Text);
			_inspectionExcel.generalroad = Conversions.ToString(r5TX.Js2n(setting.GeneralroadRow, setting.GeneralroadColumn).Text);
			_inspectionExcel.emergencyroad = Conversions.ToString(r5TX.Js2n(setting.EmergencyroadRow, setting.EmergencyroadColumn).Text);
			_inspectionExcel.occupancy = Conversions.ToString(r5TX.Js2n(setting.OccupancyRow, setting.OccupancyColumn).Text);
			_inspectionExcel.soundness = Conversions.ToString(r5TX.Js2n(setting.SoundnessRow, setting.SoundnessColumn).Text);
			_inspectionExcel.uppermaterialmain = Conversions.ToString(r5TX.Js2n(setting.UppermaterialmainRow, setting.UppermaterialmainColumn).Text);
			_inspectionExcel.uppermaterialside = Conversions.ToString(r5TX.Js2n(setting.UppermaterialsideRow, setting.UppermaterialsideColumn).Text);
			_inspectionExcel.uppermaterialfloor = Conversions.ToString(r5TX.Js2n(setting.UppermaterialfloorRow, setting.UppermaterialfloorColumn).Text);
			_inspectionExcel.undermaterial = Conversions.ToString(r5TX.Js2n(setting.UndermaterialRow, setting.UndermaterialColumn).Text);
			_inspectionExcel.bearing = Conversions.ToString(r5TX.Js2n(setting.BearingRow, setting.BearingColumn).Text);
			_inspectionExcel.face = Conversions.ToString(r5TX.Js2n(setting.FaceRow, setting.FaceColumn).Text);
			r5TX.Sq8n(Jm36: false);
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

	private string o2J7()
	{
		string[] files = Directory.GetFiles(_inspectionExcel.datadir);
		IEnumerable<string> source = files.Where((string Ci86) => Path.GetFileName(Ci86)!.StartsWith(setting.FilePrefix));
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

	internal static string[] Zf7a()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)t2ZE.mDic["Ann"]).GetManifestResourceNames();
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

	private void t9RP()
	{
		k2Y5();
	}

	private void k2Y5()
	{
		Gy4n gy4n = new Gy4n();
		s1X8 s1X = gy4n.bridge.Find(new object[1] { _inspectionExcel.id });
		if (s1X == null)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "管理テーブルにデータが見つかりません。";
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool Qm4z(string Ci86)
	{
		return Path.GetFileName(Ci86)!.StartsWith(setting.FilePrefix);
	}
}
