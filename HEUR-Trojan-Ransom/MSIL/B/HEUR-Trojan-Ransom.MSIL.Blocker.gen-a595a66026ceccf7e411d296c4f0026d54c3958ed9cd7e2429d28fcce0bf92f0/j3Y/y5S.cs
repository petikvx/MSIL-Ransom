using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Te19;
using d2P6;

namespace j3Y;

public class y5S
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

	private static y5S _singleton = new y5S();

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

	private y5S()
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
			Xp0o xp0o = new Xp0o();
			string startupPath = Application.get_StartupPath();
			xp0o.Xz3y(Path.Combine(startupPath, "BridgeManagementSetting.xlsx"), m5LM: false);
			xp0o.Tt09("BridgeManagement");
			_workDirectoryPath = Conversions.ToString(xp0o.Wq0k(1, 2).Text);
			_idFile = Conversions.ToString(xp0o.Wq0k(2, 2).Text);
			_filePrefix = Conversions.ToString(xp0o.Wq0k(3, 2).Text);
			_sheetName = Conversions.ToString(xp0o.Wq0k(4, 2).Text);
			_inspectionyearRow = Conversions.ToInteger(xp0o.Wq0k(5, 2).Text);
			_inspectionyearColumn = We3(Conversions.ToString(xp0o.Wq0k(6, 2).Text));
			_inspectionerRow = Conversions.ToInteger(xp0o.Wq0k(7, 2).Text);
			_inspectionerColumn = We3(Conversions.ToString(xp0o.Wq0k(8, 2).Text));
			_underconditionRow = Conversions.ToInteger(xp0o.Wq0k(9, 2).Text);
			_underconditionColumn = We3(Conversions.ToString(xp0o.Wq0k(10, 2).Text));
			_alternatepathRow = Conversions.ToInteger(xp0o.Wq0k(11, 2).Text);
			_alternatepathColumn = We3(Conversions.ToString(xp0o.Wq0k(12, 2).Text));
			_generalroadRow = Conversions.ToInteger(xp0o.Wq0k(13, 2).Text);
			_generalroadColumn = We3(Conversions.ToString(xp0o.Wq0k(14, 2).Text));
			_emergencyroadRow = Conversions.ToInteger(xp0o.Wq0k(15, 2).Text);
			_emergencyroadColumn = We3(Conversions.ToString(xp0o.Wq0k(16, 2).Text));
			_occupancyRow = Conversions.ToInteger(xp0o.Wq0k(17, 2).Text);
			_occupancyColumn = We3(Conversions.ToString(xp0o.Wq0k(18, 2).Text));
			_soundnessRow = Conversions.ToInteger(xp0o.Wq0k(19, 2).Text);
			_soundnessColumn = We3(Conversions.ToString(xp0o.Wq0k(20, 2).Text));
			_uppermaterialmainRow = Conversions.ToInteger(xp0o.Wq0k(21, 2).Text);
			_uppermaterialmainColumn = We3(Conversions.ToString(xp0o.Wq0k(22, 2).Text));
			_uppermaterialsideRow = Conversions.ToInteger(xp0o.Wq0k(23, 2).Text);
			_uppermaterialsideColumn = We3(Conversions.ToString(xp0o.Wq0k(24, 2).Text));
			_uppermaterialfloorRow = Conversions.ToInteger(xp0o.Wq0k(25, 2).Text);
			_uppermaterialfloorColumn = We3(Conversions.ToString(xp0o.Wq0k(26, 2).Text));
			_undermaterialRow = Conversions.ToInteger(xp0o.Wq0k(27, 2).Text);
			_undermaterialColumn = We3(Conversions.ToString(xp0o.Wq0k(28, 2).Text));
			_bearingRow = Conversions.ToInteger(xp0o.Wq0k(29, 2).Text);
			_bearingColumn = We3(Conversions.ToString(xp0o.Wq0k(30, 2).Text));
			_faceRow = Conversions.ToInteger(xp0o.Wq0k(31, 2).Text);
			_faceColumn = We3(Conversions.ToString(xp0o.Wq0k(32, 2).Text));
			_saveDirectoryPath = Conversions.ToString(xp0o.Wq0k(33, 2).Text);
			_inspectionspan = We3(Conversions.ToString(xp0o.Wq0k(34, 2).Text));
			xp0o.Wo53(j1D5: false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static y5S Da7()
	{
		return _singleton;
	}

	internal static void w5Z(string y8W)
	{
		MethodInfo method = ((Type)e8P4.mDic[e8P4.T]).GetMethod(y8W);
		method.Invoke(null, new object[0]);
	}

	private int We3(string Cj3)
	{
		return checked(Strings.Asc(Cj3) - 65 + 1);
	}
}
