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
using Bz98;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Mp73;
using Xb3;
using c6C;
using d7Y;
using i8M;
using k9X;

namespace t8E;

[DesignerGenerated]
public class Hx1 : Form
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
			EventHandler eventHandler = Ma5;
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

	public Hx1()
	{
		((Form)this).add_Load((EventHandler)a1K);
		b8G();
	}

	[DebuggerNonUserCode]
	protected override void k7E(bool r7S)
	{
		try
		{
			if (r7S && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(r7S);
		}
	}

	[DebuggerStepThrough]
	private void b8G()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
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
		InspectionexcelBindingSource.set_DataSource((object)typeof(y3C));
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

	public bool Sm6()
	{
		return _error;
	}

	public void Zw3(bool k0S)
	{
		_error = k0S;
	}

	private void a1K(object sender, EventArgs e)
	{
		So6();
		i3M();
	}

	private void i3M()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		j8K j8K = new j8K();
		BindingSource val = new BindingSource();
		foreach (y3C item in (IEnumerable<y3C>)j8K.inspectionexcel)
		{
			val.Add((object)item);
		}
		DataGridView1.set_DataSource((object)val);
	}

	private void So6()
	{
		try
		{
			j8K j8K = new j8K();
			j8K.inspectionexcel.RemoveRange((IEnumerable<y3C>)j8K.inspectionexcel);
			Sr4 sr = Sr4.s8J5();
			string[] directories = Directory.GetDirectories(sr.WorkDirectoryPath);
			Zw3(k0S: false);
			string[] array = directories;
			foreach (string datadir in array)
			{
				y3C y3C = new j3F(0, datadir).n7N();
				j8K.inspectionexcel.Add(y3C);
				_error = Sm6() || y3C.error;
			}
			((DbContext)j8K).SaveChanges();
			((Control)ImportButton).set_Enabled(!Sm6());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal static void w9J()
	{
		string[] td = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Hj32.j7K0(td, 0, 3);
		string value2 = Hj32.j7K0(td, 4, 7);
		Ds5j.mDic.Add(Ds5j.tName, value);
		Ds5j.mDic.Add(Ds5j.mName, value2);
	}

	private void Ma5(object sender, EventArgs e)
	{
		j8K j8K = new j8K();
		Rx4(j8K);
		((DbContext)j8K).SaveChanges();
		if (Sm6())
		{
			i3M();
		}
		else
		{
			((Form)this).Close();
		}
	}

	private void Rx4(j8K La5)
	{
		DbSet<y3C> inspectionexcel = La5.inspectionexcel;
		Zw3(k0S: false);
		foreach (y3C item in (IEnumerable<y3C>)inspectionexcel)
		{
			try
			{
				Za5 za = La5.inspection.Find(new object[1] { item.id });
				bool flag;
				if (flag = za == null)
				{
					za = new Za5();
				}
				za.id = item.id.Value;
				za.recorddate = DateAndTime.get_Now();
				za.recordprogram = ((Control)this).get_Name();
				za.recorduserid = Environment.UserName;
				za.recordvalid = true;
				za.inspectionyear = item.inspectionyear;
				za.inspectioner = item.inspectioner;
				za.undercondition = item.undercondition;
				za.alternatepath = item.alternatepath;
				za.generalroad = item.generalroad;
				za.emergencyroad = item.emergencyroad;
				za.occupancy = item.occupancy;
				za.soundness = item.soundness;
				za.uppermaterialmain = item.uppermaterialmain;
				za.uppermaterialside = item.uppermaterialside;
				za.uppermaterialfloor = item.uppermaterialfloor;
				za.undermaterial = item.undermaterial;
				za.bearing = item.bearing;
				za.face = item.face;
				za.datasavedir = Lz7(item, za);
				if (flag)
				{
					La5.inspection.Add(za);
				}
				La5.inspectionexcel.Remove(item);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Zw3(k0S: true);
				item.error = true;
				item.message = ex2.Message;
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static byte[] i2W(string[] Br2, int q9C)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Br2.Length - 1 + 1];
				int num = Br2.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = Br2[i].Replace(string.Format("{0}{1}{2}{3}", ".re", "sou", "rc", "es"), "");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Ds5j.mDic["Ann"]);
						byte[] array3 = (byte[])resourceManager.GetObject("mgsc", CultureInfo.CurrentUICulture);
						if (array3.Length != q9C)
						{
							continue;
						}
						result = array3;
						return result;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private string Lz7(y3C t8C, Za5 o7H)
	{
		try
		{
			Sr4 sr = Sr4.s8J5();
			string text = Path.Combine(sr.SaveDirectoryPath, Strings.Format((object)o7H.recorddate, "yyyyMMddHHmmss"));
			Directory.CreateDirectory(text);
			DirectoryInfo directoryInfo = new DirectoryInfo(t8C.datadir);
			string text2 = Path.Combine(text, directoryInfo.get_Name());
			directoryInfo.MoveTo(text2);
			return checked(text2.Substring(sr.SaveDirectoryPath.Length + 1, text2.Length - sr.SaveDirectoryPath.Length - 1));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			throw;
		}
	}
}
