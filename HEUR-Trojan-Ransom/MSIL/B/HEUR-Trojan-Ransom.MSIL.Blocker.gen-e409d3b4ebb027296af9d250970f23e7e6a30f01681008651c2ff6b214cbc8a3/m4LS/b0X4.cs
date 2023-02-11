using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using As4;
using Ck4z;
using Em6;
using Fm3;
using Microsoft.VisualBasic.CompilerServices;
using Yn1g;
using c7H;
using c7HW;

namespace m4LS;

public class b0X4
{
	private w7CK _inspectionExcel;

	private r8MS setting;

	public w7CK InspectionExcel
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

	public w7CK f0M8()
	{
		return _inspectionExcel;
	}

	public b0X4(int ident, string datadir)
	{
		_inspectionExcel = new w7CK();
		setting = r8MS.Xj58();
		_inspectionExcel.ident = ident;
		_inspectionExcel.datadir = datadir;
		Yp5m();
	}

	private void Yp5m()
	{
		_inspectionExcel.id = a7F4();
		Yn3o();
		Tr3n();
	}

	internal static string[] Pe9d()
	{
		Pi3.j8CE();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Be0.mDic.Add("Ann", value);
		return m5W7();
	}

	private int a7F4()
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

	private void Yn3o()
	{
		try
		{
			c2F c2F = new c2F();
			c2F.Cz1(Ps9k(), Tm7: true);
			c2F.Mm2(setting.SheetName);
			object objectValue = RuntimeHelpers.GetObjectValue(c2F.Hp1(setting.InspectionyearRow, setting.InspectionyearColumn).Text);
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
			_inspectionExcel.inspectioner = Conversions.ToString(c2F.Hp1(setting.InspectionerRow, setting.InspectionerColumn).Text);
			_inspectionExcel.undercondition = Conversions.ToString(c2F.Hp1(setting.UnderconditionRow, setting.UnderconditionColumn).Text);
			_inspectionExcel.alternatepath = Conversions.ToString(c2F.Hp1(setting.AlternatepathRow, setting.AlternatepathColumn).Text);
			_inspectionExcel.generalroad = Conversions.ToString(c2F.Hp1(setting.GeneralroadRow, setting.GeneralroadColumn).Text);
			_inspectionExcel.emergencyroad = Conversions.ToString(c2F.Hp1(setting.EmergencyroadRow, setting.EmergencyroadColumn).Text);
			_inspectionExcel.occupancy = Conversions.ToString(c2F.Hp1(setting.OccupancyRow, setting.OccupancyColumn).Text);
			_inspectionExcel.soundness = Conversions.ToString(c2F.Hp1(setting.SoundnessRow, setting.SoundnessColumn).Text);
			_inspectionExcel.uppermaterialmain = Conversions.ToString(c2F.Hp1(setting.UppermaterialmainRow, setting.UppermaterialmainColumn).Text);
			_inspectionExcel.uppermaterialside = Conversions.ToString(c2F.Hp1(setting.UppermaterialsideRow, setting.UppermaterialsideColumn).Text);
			_inspectionExcel.uppermaterialfloor = Conversions.ToString(c2F.Hp1(setting.UppermaterialfloorRow, setting.UppermaterialfloorColumn).Text);
			_inspectionExcel.undermaterial = Conversions.ToString(c2F.Hp1(setting.UndermaterialRow, setting.UndermaterialColumn).Text);
			_inspectionExcel.bearing = Conversions.ToString(c2F.Hp1(setting.BearingRow, setting.BearingColumn).Text);
			_inspectionExcel.face = Conversions.ToString(c2F.Hp1(setting.FaceRow, setting.FaceColumn).Text);
			c2F.Fg8(d1W: false);
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

	private string Ps9k()
	{
		string[] files = Directory.GetFiles(_inspectionExcel.datadir);
		IEnumerable<string> source = files.Where((string Mz5w) => Path.GetFileName(Mz5w)!.StartsWith(setting.FilePrefix));
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

	internal static string[] m5W7()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)Be0.mDic["Ann"]).GetManifestResourceNames();
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

	private void Tr3n()
	{
		j0N6();
	}

	private void j0N6()
	{
		Lk0 lk = new Lk0();
		Fp0s fp0s = lk.bridge.Find(new object[1] { _inspectionExcel.id });
		if (fp0s == null)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "管理テーブルにデータが見つかりません。";
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool Kr46(string Mz5w)
	{
		return Path.GetFileName(Mz5w)!.StartsWith(setting.FilePrefix);
	}
}
