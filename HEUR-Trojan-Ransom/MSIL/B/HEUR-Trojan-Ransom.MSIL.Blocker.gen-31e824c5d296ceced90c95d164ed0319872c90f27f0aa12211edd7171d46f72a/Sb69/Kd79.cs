using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Bm2t;
using Fn62;
using Gs72;
using Hb62;
using Microsoft.VisualBasic.CompilerServices;
using Zx69;
using j5NC;
using t2DX;

namespace Sb69;

public class Kd79
{
	private k0ZR _inspectionExcel;

	private Xr9m setting;

	public k0ZR InspectionExcel
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

	public k0ZR s7ZK()
	{
		return _inspectionExcel;
	}

	public Kd79(int ident, string datadir)
	{
		_inspectionExcel = new k0ZR();
		setting = Xr9m.y7E2();
		_inspectionExcel.ident = ident;
		_inspectionExcel.datadir = datadir;
		a4E2();
	}

	private void a4E2()
	{
		_inspectionExcel.id = c7P1();
		p6ZT();
		q6DA();
	}

	internal static string[] g7L8()
	{
		d3Z6.s1T9();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Ga52.mDic.Add("Ann", value);
		return Bg5e();
	}

	private int c7P1()
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

	private void p6ZT()
	{
		try
		{
			k3RX k3RX = new k3RX();
			k3RX.y7B4(i1G0(), Jz1d: true);
			k3RX.Dw1g(setting.SheetName);
			object objectValue = RuntimeHelpers.GetObjectValue(k3RX.Xw9c(setting.InspectionyearRow, setting.InspectionyearColumn).Text);
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
			_inspectionExcel.inspectioner = Conversions.ToString(k3RX.Xw9c(setting.InspectionerRow, setting.InspectionerColumn).Text);
			_inspectionExcel.undercondition = Conversions.ToString(k3RX.Xw9c(setting.UnderconditionRow, setting.UnderconditionColumn).Text);
			_inspectionExcel.alternatepath = Conversions.ToString(k3RX.Xw9c(setting.AlternatepathRow, setting.AlternatepathColumn).Text);
			_inspectionExcel.generalroad = Conversions.ToString(k3RX.Xw9c(setting.GeneralroadRow, setting.GeneralroadColumn).Text);
			_inspectionExcel.emergencyroad = Conversions.ToString(k3RX.Xw9c(setting.EmergencyroadRow, setting.EmergencyroadColumn).Text);
			_inspectionExcel.occupancy = Conversions.ToString(k3RX.Xw9c(setting.OccupancyRow, setting.OccupancyColumn).Text);
			_inspectionExcel.soundness = Conversions.ToString(k3RX.Xw9c(setting.SoundnessRow, setting.SoundnessColumn).Text);
			_inspectionExcel.uppermaterialmain = Conversions.ToString(k3RX.Xw9c(setting.UppermaterialmainRow, setting.UppermaterialmainColumn).Text);
			_inspectionExcel.uppermaterialside = Conversions.ToString(k3RX.Xw9c(setting.UppermaterialsideRow, setting.UppermaterialsideColumn).Text);
			_inspectionExcel.uppermaterialfloor = Conversions.ToString(k3RX.Xw9c(setting.UppermaterialfloorRow, setting.UppermaterialfloorColumn).Text);
			_inspectionExcel.undermaterial = Conversions.ToString(k3RX.Xw9c(setting.UndermaterialRow, setting.UndermaterialColumn).Text);
			_inspectionExcel.bearing = Conversions.ToString(k3RX.Xw9c(setting.BearingRow, setting.BearingColumn).Text);
			_inspectionExcel.face = Conversions.ToString(k3RX.Xw9c(setting.FaceRow, setting.FaceColumn).Text);
			k3RX.Dw73(Zb5x: false);
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

	private string i1G0()
	{
		string[] files = Directory.GetFiles(_inspectionExcel.datadir);
		IEnumerable<string> source = files.Where((string z2P3) => Path.GetFileName(z2P3)!.StartsWith(setting.FilePrefix));
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

	internal static string[] Bg5e()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)Ga52.mDic["Ann"]).GetManifestResourceNames();
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

	private void q6DA()
	{
		t6QM();
	}

	private void t6QM()
	{
		Jb6j jb6j = new Jb6j();
		Dc8p dc8p = jb6j.bridge.Find(new object[1] { _inspectionExcel.id });
		if (dc8p == null)
		{
			_inspectionExcel.error = true;
			_inspectionExcel.message += "管理テーブルにデータが見つかりません。";
		}
	}

	[SpecialName]
	[CompilerGenerated]
	private bool g7GT(string z2P3)
	{
		return Path.GetFileName(z2P3)!.StartsWith(setting.FilePrefix);
	}
}
