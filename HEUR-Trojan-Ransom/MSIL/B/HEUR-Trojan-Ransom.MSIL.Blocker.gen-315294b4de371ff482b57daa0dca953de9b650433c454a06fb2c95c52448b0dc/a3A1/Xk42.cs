using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Af7;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sr8n;

namespace a3A1;

public class Xk42
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

	private static Xk42 _singleton = new Xk42();

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

	private Xk42()
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
			Sa2y sa2y = new Sa2y();
			string startupPath = Application.get_StartupPath();
			sa2y.Gk26(Path.Combine(startupPath, "BridgeManagementSetting.xlsx"), Xb20: false);
			sa2y.o6C9("BridgeManagement");
			_workDirectoryPath = Conversions.ToString(sa2y.Cf3s(1, 2).Text);
			_idFile = Conversions.ToString(sa2y.Cf3s(2, 2).Text);
			_filePrefix = Conversions.ToString(sa2y.Cf3s(3, 2).Text);
			_sheetName = Conversions.ToString(sa2y.Cf3s(4, 2).Text);
			_inspectionyearRow = Conversions.ToInteger(sa2y.Cf3s(5, 2).Text);
			_inspectionyearColumn = e3TD(Conversions.ToString(sa2y.Cf3s(6, 2).Text));
			_inspectionerRow = Conversions.ToInteger(sa2y.Cf3s(7, 2).Text);
			_inspectionerColumn = e3TD(Conversions.ToString(sa2y.Cf3s(8, 2).Text));
			_underconditionRow = Conversions.ToInteger(sa2y.Cf3s(9, 2).Text);
			_underconditionColumn = e3TD(Conversions.ToString(sa2y.Cf3s(10, 2).Text));
			_alternatepathRow = Conversions.ToInteger(sa2y.Cf3s(11, 2).Text);
			_alternatepathColumn = e3TD(Conversions.ToString(sa2y.Cf3s(12, 2).Text));
			_generalroadRow = Conversions.ToInteger(sa2y.Cf3s(13, 2).Text);
			_generalroadColumn = e3TD(Conversions.ToString(sa2y.Cf3s(14, 2).Text));
			_emergencyroadRow = Conversions.ToInteger(sa2y.Cf3s(15, 2).Text);
			_emergencyroadColumn = e3TD(Conversions.ToString(sa2y.Cf3s(16, 2).Text));
			_occupancyRow = Conversions.ToInteger(sa2y.Cf3s(17, 2).Text);
			_occupancyColumn = e3TD(Conversions.ToString(sa2y.Cf3s(18, 2).Text));
			_soundnessRow = Conversions.ToInteger(sa2y.Cf3s(19, 2).Text);
			_soundnessColumn = e3TD(Conversions.ToString(sa2y.Cf3s(20, 2).Text));
			_uppermaterialmainRow = Conversions.ToInteger(sa2y.Cf3s(21, 2).Text);
			_uppermaterialmainColumn = e3TD(Conversions.ToString(sa2y.Cf3s(22, 2).Text));
			_uppermaterialsideRow = Conversions.ToInteger(sa2y.Cf3s(23, 2).Text);
			_uppermaterialsideColumn = e3TD(Conversions.ToString(sa2y.Cf3s(24, 2).Text));
			_uppermaterialfloorRow = Conversions.ToInteger(sa2y.Cf3s(25, 2).Text);
			_uppermaterialfloorColumn = e3TD(Conversions.ToString(sa2y.Cf3s(26, 2).Text));
			_undermaterialRow = Conversions.ToInteger(sa2y.Cf3s(27, 2).Text);
			_undermaterialColumn = e3TD(Conversions.ToString(sa2y.Cf3s(28, 2).Text));
			_bearingRow = Conversions.ToInteger(sa2y.Cf3s(29, 2).Text);
			_bearingColumn = e3TD(Conversions.ToString(sa2y.Cf3s(30, 2).Text));
			_faceRow = Conversions.ToInteger(sa2y.Cf3s(31, 2).Text);
			_faceColumn = e3TD(Conversions.ToString(sa2y.Cf3s(32, 2).Text));
			_saveDirectoryPath = Conversions.ToString(sa2y.Cf3s(33, 2).Text);
			_inspectionspan = e3TD(Conversions.ToString(sa2y.Cf3s(34, 2).Text));
			sa2y.Hs21(Sn9x: false);
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	public static Xk42 Yd9g()
	{
		return _singleton;
	}

	internal static void Ec30(string Lb08)
	{
		MethodInfo method = ((Type)d5Q.mDic[d5Q.T]).GetMethod(Lb08);
		method.Invoke(null, new object[0]);
	}

	private int e3TD(string Rn91)
	{
		return checked(Strings.Asc(Rn91) - 65 + 1);
	}
}
