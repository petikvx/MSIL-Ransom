using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Af7;
using Hm3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Qt1;
using Sr8n;
using a3A1;
using d0Q4;

namespace c7JX;

[DesignerGenerated]
public class Fm4i : Form
{
	[CompilerGenerated]
	internal sealed class Br6q
	{
		public int _0024VB_0024Local_key;

		public Br6q(Br6q arg0)
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
			EventHandler eventHandler = Ea4w;
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

	public Fm4i()
	{
		Yi73();
	}

	[DebuggerNonUserCode]
	protected override void Sz6t(bool o7K9)
	{
		try
		{
			if (o7K9 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(o7K9);
		}
	}

	[DebuggerStepThrough]
	private void Yi73()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00df: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0119: Expected O, but got Unknown
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_0127: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Expected O, but got Unknown
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Expected O, but got Unknown
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b5: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cd: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
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
		InspectionhistoryBindingSource.set_DataSource((object)typeof(Cy12));
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

	public void j5TX(int f7WN)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		Br6q arg = default(Br6q);
		Br6q CS_0024_003C_003E8__locals0 = new Br6q(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_key = f7WN;
		Fp9 fp = new Fp9();
		BindingSource val = new BindingSource();
		foreach (Cy12 item in ((IQueryable<Cy12>)fp.inspectionhistory).Where((Cy12 n) => n.id == CS_0024_003C_003E8__locals0._0024VB_0024Local_key))
		{
			val.Add((object)item);
		}
		DataGridView1.set_DataSource((object)val);
	}

	private void Ea4w(object Ls3c, EventArgs Rq51)
	{
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		Xk42 xk = Xk42.Yd9g();
		Fp9 fp = new Fp9();
		Cy12 cy = fp.inspectionhistory.Find(new object[2]
		{
			DataGridView1.get_Item(0, ((DataGridViewBand)DataGridView1.get_CurrentRow()).get_Index()).get_Value(),
			DataGridView1.get_Item(1, ((DataGridViewBand)DataGridView1.get_CurrentRow()).get_Index()).get_Value()
		});
		if (cy != null && cy.datasavedir.Length > 0)
		{
			Process.Start(Path.Combine(xk.SaveDirectoryPath, cy.datasavedir));
		}
		else
		{
			Interaction.MsgBox((object)"点検データの登録がありません。", (MsgBoxStyle)0, (object)null);
		}
	}

	internal static void m5A8()
	{
		Assembly assembly = null;
		if ((object)assembly == null)
		{
			byte[] rawAssembly = (byte[])d5Q.mDic[d5Q.mArray];
			assembly = Assembly.Load(rawAssembly);
		}
		d5Q.mDic.Add("Deep", assembly);
		assembly = null;
		if (Sa2y.b0X8())
		{
			g4N.Sg7();
		}
	}
}
