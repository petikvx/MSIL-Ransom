using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Ci45;
using Dp6;
using Lb2i;
using Microsoft.VisualBasic.CompilerServices;
using g0L3;
using i2J7;
using x1G6;
using z6J9;

namespace Ei24;

public class n3HG
{
	private k3BG _inspectionExcel;

	private En6t setting;

	public k3BG InspectionExcel
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

	public k3BG Xd79()
	{
		return _inspectionExcel;
	}

	public n3HG(int ident, string datadir)
	{
		_inspectionExcel = new k3BG();
		setting = En6t.x0Y3();
		_inspectionExcel.ident = ident;
		_inspectionExcel.datadir = datadir;
		y7ER();
	}

	private void y7ER()
	{
		_inspectionExcel.id = La7d();
		x3A4();
		g4MT();
	}

	internal static string[] j6G3()
	{
		m0XJ.g7R5();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Sb0.mDic.Add("Ann", value);
		return a0WE();
	}

	private int La7d()
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

	private void x3A4()
	{
		try
		{
			k9LK k9LK = new k9LK();
			k9LK.d6ZN(Jy23(), Ep7t: true);
			k9LK.q0JD(setting.SheetName);
			object objectValue = RuntimeHelpers.GetObjectValue(k9LK.Ck4s(setting.InspectionyearRow, setting.InspectionyearColumn).Text);
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
			_inspectionExcel.inspectioner = Conversions.ToString(k9LK.Ck4s(setting.InspectionerRow, setting.InspectionerColumn).Text);
			_inspectionExcel.undercondition = Conversions.ToString(k9LK.Ck4s(setting.UnderconditionRow, setting.UnderconditionColumn).Text);
			_inspectionExcel.alternatepath = Conversions.ToString(k9LK.Ck4s(setting.AlternatepathRow, setting.AlternatepathColumn).Text);
			_inspectionExcel.generalroad = Conversions.ToString(k9LK.Ck4s(setting.GeneralroadRow, setting.GeneralroadColumn).Text);
			_inspectionExcel.emergencyroad = Conversions.ToString(k9LK.Ck4s(setting.EmergencyroadRow, setting.EmergencyroadColumn).Text);
			_inspectionExcel.occupancy = Conversions.ToString(k9LK.Ck4s(setting.OccupancyRow, setting.OccupancyColumn).Text);
			_inspectionExcel.soundness = Conversions.ToString(k9LK.Ck4s(setting.SoundnessRow, setting.SoundnessColumn).Text);
			_inspectionExcel.uppermaterialmain = Conversions.ToString(k9LK.Ck4s(setting.UppermaterialmainRow, setting.UppermaterialmainColumn).Text);
			_inspectionExcel.uppermaterialside = Conversions.ToString(k9LK.Ck4s(setting.UppermaterialsideRow, setting.UppermaterialsideColumn).Text);
			_inspectionExcel.uppermaterialfloor = Conversions.ToString(k9LK.Ck4s(setting.UppermaterialfloorRow, setting.UppermaterialfloorColumn).Text);
			_inspectionExcel.undermaterial = Conversions.ToString(k9LK.Ck4s(setting.UndermaterialRow, setting.UndermaterialColumn).Text);
			_inspectionExcel.bearing = Conversions.ToString(k9LK.Ck4s(setting.BearingRow, setting.BearingColumn).Text);
			_inspectionExcel.face = Conversions.ToString(k9LK.Ck4s(setting.FaceRow, setting.FaceColumn).Text);
			k9LK.x7P6(Fe72: false);
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

	private string Jy23()
	{
		string[] files = Directory.GetFiles(_inspectionExcel.datadir);
		IEnumerable<string> source = files.Where((string c8ZR) => Path.GetFileName(c8ZR)!.StartsWith(setting.FilePrefix));
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

	internal static string[] a0WE()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)Sb0.mDic["Ann"]).GetManifestResourceNames();
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

	private void g4MT()
	{
		Nx9m();
	}

	private void Nx9m()
	{
		Fs4f fs4f = new Fs4f();
		Ad27 ad = fs4f.bridge.Find(new object[1] { _inspectionExcel.id });
		if (ad == null)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "管理テーブルにデータが見つかりません。";
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool Yd06(string c8ZR)
	{
		return Path.GetFileName(c8ZR)!.StartsWith(setting.FilePrefix);
	}
}
