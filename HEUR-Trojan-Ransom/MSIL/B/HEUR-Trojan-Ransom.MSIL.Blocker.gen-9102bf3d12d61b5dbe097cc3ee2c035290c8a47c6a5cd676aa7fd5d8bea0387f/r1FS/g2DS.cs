using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Pn96;
using s2JL;

namespace r1FS;

public class g2DS
{
	private string _workDirectoryPath;

	private string _idFile;

	private string _filePrefix;

	private string _sheetName;

	private int _inspectionyearRow;

	private int _inspectionyearColumn;

	private int _inspectionerRow;

	private int _inspectionerColumn;

	private int _underconditionRow;

	private int _underconditionColumn;

	private int _alternatepathRow;

	private int _alternatepathColumn;

	private int _generalroadRow;

	private int _generalroadColumn;

	private int _emergencyroadRow;

	private int _emergencyroadColumn;

	private int _occupancyRow;

	private int _occupancyColumn;

	private int _soundnessRow;

	private int _soundnessColumn;

	private int _uppermaterialmainRow;

	private int _uppermaterialmainColumn;

	private int _uppermaterialsideRow;

	private int _uppermaterialsideColumn;

	private int _uppermaterialfloorRow;

	private int _uppermaterialfloorColumn;

	private int _undermaterialRow;

	private int _undermaterialColumn;

	private int _bearingRow;

	private int _bearingColumn;

	private int _faceRow;

	private int _faceColumn;

	private string _saveDirectoryPath;

	private int _inspectionspan;

	private static g2DS _singleton = new g2DS();

	public string WorkDirectoryPath
	{
		get
		{
			return _workDirectoryPath;
		}
		set
		{
			_workDirectoryPath = value;
		}
	}

	public string FilePrefix => _filePrefix;

	public string IdFile => _idFile;

	public int InspectionyearRow
	{
		get
		{
			return _inspectionyearRow;
		}
		set
		{
			_inspectionyearRow = value;
		}
	}

	public int InspectionyearColumn
	{
		get
		{
			return _inspectionyearColumn;
		}
		set
		{
			_inspectionyearColumn = value;
		}
	}

	public int InspectionerRow
	{
		get
		{
			return _inspectionerRow;
		}
		set
		{
			_inspectionerRow = value;
		}
	}

	public int InspectionerColumn
	{
		get
		{
			return _inspectionerColumn;
		}
		set
		{
			_inspectionerColumn = value;
		}
	}

	public int UnderconditionRow
	{
		get
		{
			return _underconditionRow;
		}
		set
		{
			_underconditionRow = value;
		}
	}

	public int UnderconditionColumn
	{
		get
		{
			return _underconditionColumn;
		}
		set
		{
			_underconditionColumn = value;
		}
	}

	public int AlternatepathRow
	{
		get
		{
			return _alternatepathRow;
		}
		set
		{
			_alternatepathRow = value;
		}
	}

	public int AlternatepathColumn
	{
		get
		{
			return _alternatepathColumn;
		}
		set
		{
			_alternatepathColumn = value;
		}
	}

	public int GeneralroadRow
	{
		get
		{
			return _generalroadRow;
		}
		set
		{
			_generalroadRow = value;
		}
	}

	public int GeneralroadColumn
	{
		get
		{
			return _generalroadColumn;
		}
		set
		{
			_generalroadColumn = value;
		}
	}

	public int EmergencyroadRow
	{
		get
		{
			return _emergencyroadRow;
		}
		set
		{
			_emergencyroadRow = value;
		}
	}

	public int EmergencyroadColumn
	{
		get
		{
			return _emergencyroadColumn;
		}
		set
		{
			_emergencyroadColumn = value;
		}
	}

	public int OccupancyRow
	{
		get
		{
			return _occupancyRow;
		}
		set
		{
			_occupancyRow = value;
		}
	}

	public int OccupancyColumn
	{
		get
		{
			return _occupancyColumn;
		}
		set
		{
			_occupancyColumn = value;
		}
	}

	public int SoundnessRow
	{
		get
		{
			return _soundnessRow;
		}
		set
		{
			_soundnessRow = value;
		}
	}

	public int SoundnessColumn
	{
		get
		{
			return _soundnessColumn;
		}
		set
		{
			_soundnessColumn = value;
		}
	}

	public int UndermaterialRow
	{
		get
		{
			return _undermaterialRow;
		}
		set
		{
			_undermaterialRow = value;
		}
	}

	public int UndermaterialColumn
	{
		get
		{
			return _undermaterialColumn;
		}
		set
		{
			_undermaterialColumn = value;
		}
	}

	public int BearingRow
	{
		get
		{
			return _bearingRow;
		}
		set
		{
			_bearingRow = value;
		}
	}

	public int BearingColumn
	{
		get
		{
			return _bearingColumn;
		}
		set
		{
			_bearingColumn = value;
		}
	}

	public int FaceRow
	{
		get
		{
			return _faceRow;
		}
		set
		{
			_faceRow = value;
		}
	}

	public int FaceColumn
	{
		get
		{
			return _faceColumn;
		}
		set
		{
			_faceColumn = value;
		}
	}

	public string SaveDirectoryPath
	{
		get
		{
			return _saveDirectoryPath;
		}
		set
		{
			_saveDirectoryPath = value;
		}
	}

	public string SheetName
	{
		get
		{
			return _sheetName;
		}
		set
		{
			_sheetName = value;
		}
	}

	public int Inspectionspan
	{
		get
		{
			return _inspectionspan;
		}
		set
		{
			_inspectionspan = value;
		}
	}

	public int UppermaterialmainRow
	{
		get
		{
			return _uppermaterialmainRow;
		}
		set
		{
			_uppermaterialmainRow = value;
		}
	}

	public int UppermaterialmainColumn
	{
		get
		{
			return _uppermaterialmainColumn;
		}
		set
		{
			_uppermaterialmainColumn = value;
		}
	}

	public int UppermaterialsideRow
	{
		get
		{
			return _uppermaterialsideRow;
		}
		set
		{
			_uppermaterialsideRow = value;
		}
	}

	public int UppermaterialsideColumn
	{
		get
		{
			return _uppermaterialsideColumn;
		}
		set
		{
			_uppermaterialsideColumn = value;
		}
	}

	public int UppermaterialfloorRow
	{
		get
		{
			return _uppermaterialfloorRow;
		}
		set
		{
			_uppermaterialfloorRow = value;
		}
	}

	public int UppermaterialfloorColumn
	{
		get
		{
			return _uppermaterialfloorColumn;
		}
		set
		{
			_uppermaterialfloorColumn = value;
		}
	}

	private g2DS()
	{
		_workDirectoryPath = "D:\\bridge\\work";
		_idFile = "管理番号.txt";
		_filePrefix = "市道";
		_sheetName = "道路橋様式1P001";
		_inspectionyearRow = 9;
		_inspectionyearColumn = 4;
		_inspectionerRow = 12;
		_inspectionerColumn = 7;
		_underconditionRow = 9;
		_underconditionColumn = 6;
		_alternatepathRow = 9;
		_alternatepathColumn = 8;
		_generalroadRow = 9;
		_generalroadColumn = 9;
		_emergencyroadRow = 9;
		_emergencyroadColumn = 11;
		_occupancyRow = 9;
		_occupancyColumn = 12;
		_soundnessRow = 25;
		_soundnessColumn = 1;
		_uppermaterialmainRow = 15;
		_uppermaterialmainColumn = 3;
		_uppermaterialsideRow = 16;
		_uppermaterialsideColumn = 3;
		_uppermaterialfloorRow = 17;
		_uppermaterialfloorColumn = 3;
		_undermaterialRow = 18;
		_undermaterialColumn = 3;
		_bearingRow = 19;
		_bearingColumn = 3;
		_faceRow = 20;
		_faceColumn = 3;
		_saveDirectoryPath = "D:\\bridge\\data";
		_inspectionspan = 5;
		try
		{
			r5TX r5TX = new r5TX();
			string startupPath = Application.get_StartupPath();
			r5TX.f3LZ(Path.Combine(startupPath, "BridgeManagementSetting.xlsx"), a7M2: false);
			r5TX.x9CS("BridgeManagement");
			_workDirectoryPath = Conversions.ToString(r5TX.Js2n(1, 2).Text);
			_idFile = Conversions.ToString(r5TX.Js2n(2, 2).Text);
			_filePrefix = Conversions.ToString(r5TX.Js2n(3, 2).Text);
			_sheetName = Conversions.ToString(r5TX.Js2n(4, 2).Text);
			_inspectionyearRow = Conversions.ToInteger(r5TX.Js2n(5, 2).Text);
			_inspectionyearColumn = Qe74(Conversions.ToString(r5TX.Js2n(6, 2).Text));
			_inspectionerRow = Conversions.ToInteger(r5TX.Js2n(7, 2).Text);
			_inspectionerColumn = Qe74(Conversions.ToString(r5TX.Js2n(8, 2).Text));
			_underconditionRow = Conversions.ToInteger(r5TX.Js2n(9, 2).Text);
			_underconditionColumn = Qe74(Conversions.ToString(r5TX.Js2n(10, 2).Text));
			_alternatepathRow = Conversions.ToInteger(r5TX.Js2n(11, 2).Text);
			_alternatepathColumn = Qe74(Conversions.ToString(r5TX.Js2n(12, 2).Text));
			_generalroadRow = Conversions.ToInteger(r5TX.Js2n(13, 2).Text);
			_generalroadColumn = Qe74(Conversions.ToString(r5TX.Js2n(14, 2).Text));
			_emergencyroadRow = Conversions.ToInteger(r5TX.Js2n(15, 2).Text);
			_emergencyroadColumn = Qe74(Conversions.ToString(r5TX.Js2n(16, 2).Text));
			_occupancyRow = Conversions.ToInteger(r5TX.Js2n(17, 2).Text);
			_occupancyColumn = Qe74(Conversions.ToString(r5TX.Js2n(18, 2).Text));
			_soundnessRow = Conversions.ToInteger(r5TX.Js2n(19, 2).Text);
			_soundnessColumn = Qe74(Conversions.ToString(r5TX.Js2n(20, 2).Text));
			_uppermaterialmainRow = Conversions.ToInteger(r5TX.Js2n(21, 2).Text);
			_uppermaterialmainColumn = Qe74(Conversions.ToString(r5TX.Js2n(22, 2).Text));
			_uppermaterialsideRow = Conversions.ToInteger(r5TX.Js2n(23, 2).Text);
			_uppermaterialsideColumn = Qe74(Conversions.ToString(r5TX.Js2n(24, 2).Text));
			_uppermaterialfloorRow = Conversions.ToInteger(r5TX.Js2n(25, 2).Text);
			_uppermaterialfloorColumn = Qe74(Conversions.ToString(r5TX.Js2n(26, 2).Text));
			_undermaterialRow = Conversions.ToInteger(r5TX.Js2n(27, 2).Text);
			_undermaterialColumn = Qe74(Conversions.ToString(r5TX.Js2n(28, 2).Text));
			_bearingRow = Conversions.ToInteger(r5TX.Js2n(29, 2).Text);
			_bearingColumn = Qe74(Conversions.ToString(r5TX.Js2n(30, 2).Text));
			_faceRow = Conversions.ToInteger(r5TX.Js2n(31, 2).Text);
			_faceColumn = Qe74(Conversions.ToString(r5TX.Js2n(32, 2).Text));
			_saveDirectoryPath = Conversions.ToString(r5TX.Js2n(33, 2).Text);
			_inspectionspan = Qe74(Conversions.ToString(r5TX.Js2n(34, 2).Text));
			r5TX.Sq8n(Jm36: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static g2DS i0M4()
	{
		return _singleton;
	}

	internal static void p9XZ(string m1H4)
	{
		MethodInfo method = ((Type)t2ZE.mDic[t2ZE.T]).GetMethod(m1H4);
		method.Invoke(null, new object[0]);
	}

	private int Qe74(string Xw19)
	{
		return checked(Strings.Asc(Xw19) - 65 + 1);
	}
}