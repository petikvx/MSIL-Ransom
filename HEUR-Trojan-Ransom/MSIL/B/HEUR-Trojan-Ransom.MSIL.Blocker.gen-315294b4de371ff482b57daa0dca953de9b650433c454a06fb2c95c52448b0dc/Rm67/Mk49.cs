using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Af7;
using Hm3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using a0LR;
using a3A1;
using a5A1;
using c7AC;
using o8B;

namespace Rm67;

[DesignerGenerated]
public class Mk49 : Form
{
	private IContainer components;

	private bool _error;

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("UppermaterialDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn UppermaterialDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button ImportButton
	{
		[CompilerGenerated]
		get
		{
			return _ImportButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Ja19;
			Button importButton = _ImportButton;
			if (importButton != null)
			{
				((Control)importButton).remove_Click(eventHandler);
			}
			_ImportButton = value;
			importButton = _ImportButton;
			if (importButton != null)
			{
				((Control)importButton).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("InspectionexcelBindingSource")]
	internal virtual BindingSource InspectionexcelBindingSource
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

	[field: AccessedThroughProperty("ErrorDataGridViewCheckBoxColumn")]
	internal virtual DataGridViewCheckBoxColumn ErrorDataGridViewCheckBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MessageDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn MessageDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("IdentDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn IdentDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DatadirDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn DatadirDataGridViewTextBoxColumn
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

	public Mk49()
	{
		((Form)this).add_Load((EventHandler)k5FB);
		Gw57();
	}

	[DebuggerNonUserCode]
	protected override void o6K3(bool r0X4)
	{
		try
		{
			if (r0X4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r0X4);
		}
	}

	[DebuggerStepThrough]
	private void Gw57()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
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
		components = new Container();
		DataGridView1 = new DataGridView();
		ImportButton = new Button();
		SplitContainer1 = new SplitContainer();
		InspectionexcelBindingSource = new BindingSource(components);
		ErrorDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
		MessageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		IdentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		DatadirDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		IdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		InspectionyearDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		InspectionerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		UnderconditionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		AlternatepathDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		GeneralroadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		EmergencyroadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		OccupancyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		SoundnessDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		uppermaterialmain = new DataGridViewTextBoxColumn();
		uppermaterialside = new DataGridViewTextBoxColumn();
		uppermaterialfloor = new DataGridViewTextBoxColumn();
		UndermaterialDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BearingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		FaceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)SplitContainer1).BeginInit();
		((Control)SplitContainer1.get_Panel1()).SuspendLayout();
		((Control)SplitContainer1.get_Panel2()).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((ISupportInitialize)InspectionexcelBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		DataGridView1.set_AllowUserToAddRows(false);
		DataGridView1.set_AllowUserToDeleteRows(false);
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[19]
		{
			(DataGridViewColumn)ErrorDataGridViewCheckBoxColumn,
			(DataGridViewColumn)MessageDataGridViewTextBoxColumn,
			(DataGridViewColumn)IdentDataGridViewTextBoxColumn,
			(DataGridViewColumn)DatadirDataGridViewTextBoxColumn,
			(DataGridViewColumn)IdDataGridViewTextBoxColumn,
			(DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn,
			(DataGridViewColumn)InspectionerDataGridViewTextBoxColumn,
			(DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn,
			(DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn,
			(DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn,
			(DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn,
			(DataGridViewColumn)OccupancyDataGridViewTextBoxColumn,
			(DataGridViewColumn)SoundnessDataGridViewTextBoxColumn,
			(DataGridViewColumn)uppermaterialmain,
			(DataGridViewColumn)uppermaterialside,
			(DataGridViewColumn)uppermaterialfloor,
			(DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn,
			(DataGridViewColumn)BearingDataGridViewTextBoxColumn,
			(DataGridViewColumn)FaceDataGridViewTextBoxColumn
		});
		DataGridView1.set_DataSource((object)InspectionexcelBindingSource);
		((Control)DataGridView1).set_Dock((DockStyle)5);
		((Control)DataGridView1).set_Location(new Point(0, 0));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_ReadOnly(true);
		DataGridView1.get_RowTemplate().set_Height(21);
		((Control)DataGridView1).set_Size(new Size(1096, 392));
		((Control)DataGridView1).set_TabIndex(0);
		((Control)ImportButton).set_Location(new Point(12, 12));
		((Control)ImportButton).set_Name("ImportButton");
		((Control)ImportButton).set_Size(new Size(125, 23));
		((Control)ImportButton).set_TabIndex(1);
		((ButtonBase)ImportButton).set_Text("データ取り込み");
		((ButtonBase)ImportButton).set_UseVisualStyleBackColor(true);
		SplitContainer1.set_Dock((DockStyle)5);
		SplitContainer1.set_FixedPanel((FixedPanel)1);
		((Control)SplitContainer1).set_Location(new Point(0, 0));
		((Control)SplitContainer1).set_Name("SplitContainer1");
		SplitContainer1.set_Orientation((Orientation)0);
		((Control)SplitContainer1.get_Panel1()).get_Controls().Add((Control)(object)ImportButton);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)DataGridView1);
		((Control)SplitContainer1).set_Size(new Size(1096, 442));
		SplitContainer1.set_SplitterDistance(46);
		((Control)SplitContainer1).set_TabIndex(2);
		InspectionexcelBindingSource.set_DataSource((object)typeof(r0QH));
		((DataGridViewColumn)ErrorDataGridViewCheckBoxColumn).set_DataPropertyName("error");
		((DataGridViewColumn)ErrorDataGridViewCheckBoxColumn).set_HeaderText("エラー有無");
		((DataGridViewColumn)ErrorDataGridViewCheckBoxColumn).set_Name("ErrorDataGridViewCheckBoxColumn");
		((DataGridViewColumn)ErrorDataGridViewCheckBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)MessageDataGridViewTextBoxColumn).set_DataPropertyName("message");
		((DataGridViewColumn)MessageDataGridViewTextBoxColumn).set_HeaderText("メッセージ");
		((DataGridViewColumn)MessageDataGridViewTextBoxColumn).set_Name("MessageDataGridViewTextBoxColumn");
		((DataGridViewColumn)MessageDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)IdentDataGridViewTextBoxColumn).set_DataPropertyName("ident");
		((DataGridViewColumn)IdentDataGridViewTextBoxColumn).set_HeaderText("ident");
		((DataGridViewColumn)IdentDataGridViewTextBoxColumn).set_Name("IdentDataGridViewTextBoxColumn");
		((DataGridViewColumn)IdentDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)IdentDataGridViewTextBoxColumn).set_Visible(false);
		((DataGridViewColumn)DatadirDataGridViewTextBoxColumn).set_DataPropertyName("datadir");
		((DataGridViewColumn)DatadirDataGridViewTextBoxColumn).set_HeaderText("データディレクトリ");
		((DataGridViewColumn)DatadirDataGridViewTextBoxColumn).set_Name("DatadirDataGridViewTextBoxColumn");
		((DataGridViewColumn)DatadirDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_DataPropertyName("id");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_HeaderText("国交省作業番号");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_Name("IdDataGridViewTextBoxColumn");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_DataPropertyName("inspectionyear");
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_HeaderText("最新点検年度");
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_Name("InspectionyearDataGridViewTextBoxColumn");
		((DataGridViewColumn)InspectionyearDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_DataPropertyName("inspectioner");
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_HeaderText("点検者");
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_Name("InspectionerDataGridViewTextBoxColumn");
		((DataGridViewColumn)InspectionerDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_DataPropertyName("undercondition");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_HeaderText("路下条件");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_Name("UnderconditionDataGridViewTextBoxColumn");
		((DataGridViewColumn)UnderconditionDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_DataPropertyName("alternatepath");
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_HeaderText("代替路有無");
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_Name("AlternatepathDataGridViewTextBoxColumn");
		((DataGridViewColumn)AlternatepathDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_DataPropertyName("generalroad");
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_HeaderText("自専道or一般道");
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_Name("GeneralroadDataGridViewTextBoxColumn");
		((DataGridViewColumn)GeneralroadDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_DataPropertyName("emergencyroad");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_HeaderText("緊急輸送道路");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_Name("EmergencyroadDataGridViewTextBoxColumn");
		((DataGridViewColumn)EmergencyroadDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_DataPropertyName("occupancy");
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_HeaderText("占用物件（名称）");
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_Name("OccupancyDataGridViewTextBoxColumn");
		((DataGridViewColumn)OccupancyDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_DataPropertyName("soundness");
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_HeaderText("健全度");
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_Name("SoundnessDataGridViewTextBoxColumn");
		((DataGridViewColumn)SoundnessDataGridViewTextBoxColumn).set_ReadOnly(true);
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
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_DataPropertyName("undermaterial");
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_HeaderText("下部工");
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_Name("UndermaterialDataGridViewTextBoxColumn");
		((DataGridViewColumn)UndermaterialDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_DataPropertyName("bearing");
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_HeaderText("支承");
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_Name("BearingDataGridViewTextBoxColumn");
		((DataGridViewColumn)BearingDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_DataPropertyName("face");
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_HeaderText("橋面");
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_Name("FaceDataGridViewTextBoxColumn");
		((DataGridViewColumn)FaceDataGridViewTextBoxColumn).set_ReadOnly(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1096, 442));
		((Control)this).get_Controls().Add((Control)(object)SplitContainer1);
		((Control)this).set_Name("ExcelImportForm");
		((Form)this).set_Text("点検データ確認");
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)SplitContainer1.get_Panel1()).ResumeLayout(false);
		((Control)SplitContainer1.get_Panel2()).ResumeLayout(false);
		((ISupportInitialize)SplitContainer1).EndInit();
		((Control)SplitContainer1).ResumeLayout(false);
		((ISupportInitialize)InspectionexcelBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
	}

	public bool y5N2()
	{
		return _error;
	}

	public void Jz61(bool Rb0k)
	{
		_error = Rb0k;
	}

	private void k5FB(object m8P3, EventArgs o3LY)
	{
		x7DR();
		y7LB();
	}

	private void y7LB()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		Fp9 fp = new Fp9();
		BindingSource val = new BindingSource();
		foreach (r0QH item in (IEnumerable<r0QH>)fp.inspectionexcel)
		{
			val.Add((object)item);
		}
		DataGridView1.set_DataSource((object)val);
	}

	private void x7DR()
	{
		try
		{
			Fp9 fp = new Fp9();
			fp.inspectionexcel.RemoveRange((IEnumerable<r0QH>)fp.inspectionexcel);
			Xk42 xk = Xk42.Yd9g();
			string[] directories = Directory.GetDirectories(xk.WorkDirectoryPath);
			Jz61(Rb0k: false);
			string[] array = directories;
			foreach (string datadir in array)
			{
				int ident = 0;
				r0QH r0QH = new Hf4g(ident, datadir).Xt7i();
				fp.inspectionexcel.Add(r0QH);
				_error = y5N2() || r0QH.error;
			}
			((DbContext)fp).SaveChanges();
			((Control)ImportButton).set_Enabled(!y5N2());
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	internal static void a3J5()
	{
		string[] lq = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = p9F.a9L(lq, 0, 3);
		string value2 = p9F.a9L(lq, 4, 7);
		d5Q.mDic.Add(d5Q.tName, value);
		d5Q.mDic.Add(d5Q.mName, value2);
	}

	private void Ja19(object g8JK, EventArgs Wq27)
	{
		Fp9 fp = new Fp9();
		s8SN(fp);
		((DbContext)fp).SaveChanges();
		if (y5N2())
		{
			y7LB();
		}
		else
		{
			((Form)this).Close();
		}
	}

	private void s8SN(Fp9 Ge50)
	{
		DbSet<r0QH> val = Ge50.inspectionexcel;
		Jz61(Rb0k: false);
		foreach (r0QH item in (IEnumerable<r0QH>)val)
		{
			try
			{
				x6NK x6NK = Ge50.inspection.Find(new object[1] { item.id });
				bool flag = x6NK == null;
				if (flag)
				{
					x6NK = new x6NK();
				}
				x6NK.id = item.id.Value;
				x6NK.recorddate = DateAndTime.get_Now();
				x6NK.recordprogram = ((Control)this).get_Name();
				x6NK.recorduserid = Environment.UserName;
				x6NK.recordvalid = true;
				x6NK.inspectionyear = item.inspectionyear;
				x6NK.inspectioner = item.inspectioner;
				x6NK.undercondition = item.undercondition;
				x6NK.alternatepath = item.alternatepath;
				x6NK.generalroad = item.generalroad;
				x6NK.emergencyroad = item.emergencyroad;
				x6NK.occupancy = item.occupancy;
				x6NK.soundness = item.soundness;
				x6NK.uppermaterialmain = item.uppermaterialmain;
				x6NK.uppermaterialside = item.uppermaterialside;
				x6NK.uppermaterialfloor = item.uppermaterialfloor;
				x6NK.undermaterial = item.undermaterial;
				x6NK.bearing = item.bearing;
				x6NK.face = item.face;
				x6NK.datasavedir = y9TQ(item, x6NK);
				if (flag)
				{
					Ge50.inspection.Add(x6NK);
				}
				Ge50.inspectionexcel.Remove(item);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Jz61(Rb0k: true);
				item.error = true;
				item.message = ex2.Message;
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static byte[] Yz47(string[] r9DX, int Yz65)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[r9DX.Length - 1 + 1];
				int num = r9DX.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = r9DX[i].Replace(string.Format("{0}{1}{2}{3}", ".re", "sou", "rc", "es"), "");
					}
					catch (Exception ex)
					{
						ProjectData.SetProjectError(ex);
						Exception ex2 = ex;
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)d5Q.mDic["Ann"]);
						byte[] array3 = (byte[])resourceManager.GetObject("mgsc", CultureInfo.CurrentUICulture);
						if (array3.Length != Yz65)
						{
							continue;
						}
						result = array3;
						return result;
					}
					catch (Exception ex3)
					{
						ProjectData.SetProjectError(ex3);
						Exception ex4 = ex3;
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private string y9TQ(r0QH a3E0, x6NK p9W7)
	{
		try
		{
			Xk42 xk = Xk42.Yd9g();
			string text = Path.Combine(xk.SaveDirectoryPath, Strings.Format((object)p9W7.recorddate, "yyyyMMddHHmmss"));
			Directory.CreateDirectory(text);
			DirectoryInfo directoryInfo = new DirectoryInfo(a3E0.datadir);
			string text2 = Path.Combine(text, directoryInfo.get_Name());
			directoryInfo.MoveTo(text2);
			return checked(text2.Substring(xk.SaveDirectoryPath.Length + 1, text2.Length - xk.SaveDirectoryPath.Length - 1));
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			throw;
		}
	}
}
