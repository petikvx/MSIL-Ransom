using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Er8;
using Microsoft.VisualBasic.CompilerServices;
using So2b;
using Tc1;
using d0D;
using f9K0;
using g0J9;
using z1A;

namespace Bn6;

public class Bm9
{
	private m2F _inspectionExcel;

	private Cz4m setting;

	public m2F InspectionExcel
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

	public m2F Fb2()
	{
		return _inspectionExcel;
	}

	public Bm9(int ident, string datadir)
	{
		_inspectionExcel = new m2F();
		setting = Cz4m.e9A4();
		_inspectionExcel.ident = ident;
		_inspectionExcel.datadir = datadir;
		Qf8();
	}

	private void Qf8()
	{
		_inspectionExcel.id = Rs9();
		b1P();
		Qp5();
	}

	internal static string[] Nm9()
	{
		Qi68.Td0();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Er8.Pt8.mDic.Add("Ann", value);
		return Js2();
	}

	private int Rs9()
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

	private void b1P()
	{
		try
		{
			Nq6y nq6y = new Nq6y();
			nq6y.Po92(Qo4(), f6A9: true);
			nq6y.Pd3q(setting.SheetName);
			object objectValue = RuntimeHelpers.GetObjectValue(nq6y.Ea4b(setting.InspectionyearRow, setting.InspectionyearColumn).Text);
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
			_inspectionExcel.inspectioner = Conversions.ToString(nq6y.Ea4b(setting.InspectionerRow, setting.InspectionerColumn).Text);
			_inspectionExcel.undercondition = Conversions.ToString(nq6y.Ea4b(setting.UnderconditionRow, setting.UnderconditionColumn).Text);
			_inspectionExcel.alternatepath = Conversions.ToString(nq6y.Ea4b(setting.AlternatepathRow, setting.AlternatepathColumn).Text);
			_inspectionExcel.generalroad = Conversions.ToString(nq6y.Ea4b(setting.GeneralroadRow, setting.GeneralroadColumn).Text);
			_inspectionExcel.emergencyroad = Conversions.ToString(nq6y.Ea4b(setting.EmergencyroadRow, setting.EmergencyroadColumn).Text);
			_inspectionExcel.occupancy = Conversions.ToString(nq6y.Ea4b(setting.OccupancyRow, setting.OccupancyColumn).Text);
			_inspectionExcel.soundness = Conversions.ToString(nq6y.Ea4b(setting.SoundnessRow, setting.SoundnessColumn).Text);
			_inspectionExcel.uppermaterialmain = Conversions.ToString(nq6y.Ea4b(setting.UppermaterialmainRow, setting.UppermaterialmainColumn).Text);
			_inspectionExcel.uppermaterialside = Conversions.ToString(nq6y.Ea4b(setting.UppermaterialsideRow, setting.UppermaterialsideColumn).Text);
			_inspectionExcel.uppermaterialfloor = Conversions.ToString(nq6y.Ea4b(setting.UppermaterialfloorRow, setting.UppermaterialfloorColumn).Text);
			_inspectionExcel.undermaterial = Conversions.ToString(nq6y.Ea4b(setting.UndermaterialRow, setting.UndermaterialColumn).Text);
			_inspectionExcel.bearing = Conversions.ToString(nq6y.Ea4b(setting.BearingRow, setting.BearingColumn).Text);
			_inspectionExcel.face = Conversions.ToString(nq6y.Ea4b(setting.FaceRow, setting.FaceColumn).Text);
			nq6y.Jq82(La6i: false);
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

	private string Qo4()
	{
		string[] files = Directory.GetFiles(_inspectionExcel.datadir);
		IEnumerable<string> source = files.Where((string Wg6) => Path.GetFileName(Wg6)!.StartsWith(setting.FilePrefix));
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

	internal static string[] Js2()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)Er8.Pt8.mDic["Ann"]).GetManifestResourceNames();
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

	private void Qp5()
	{
		Pt8();
	}

	private void Pt8()
	{
		Zj9 zj = new Zj9();
		p5N p5N = zj.bridge.Find(new object[1] { _inspectionExcel.id });
		if (p5N == null)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "管理テーブルにデータが見つかりません。";
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool Pj2(string Wg6)
	{
		return Path.GetFileName(Wg6)!.StartsWith(setting.FilePrefix);
	}
}
