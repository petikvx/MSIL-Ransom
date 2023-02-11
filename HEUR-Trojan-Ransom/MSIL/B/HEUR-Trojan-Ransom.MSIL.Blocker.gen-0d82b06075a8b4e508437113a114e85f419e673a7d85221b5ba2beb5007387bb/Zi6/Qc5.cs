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
using Bm6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Mq7;
using Pg1;
using Yp0k;
using f5CH;
using n4K;
using n4R5;

namespace Zi6;

[DesignerGenerated]
public class Qc5 : Form
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
			EventHandler eventHandler = s9D;
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

	public Qc5()
	{
		((Form)this).add_Load((EventHandler)a5H);
		Fr3();
	}

	[DebuggerNonUserCode]
	protected override void e5R(bool Jb2)
	{
		try
		{
			if (Jb2 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Jb2);
		}
	}

	[DebuggerStepThrough]
	private void Fr3()
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
		InspectionexcelBindingSource.set_DataSource((object)typeof(m3A));
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

	public bool p6X()
	{
		return _error;
	}

	public void n4Y(bool Bt2)
	{
		_error = Bt2;
	}

	private void a5H(object sender, EventArgs e)
	{
		Lp3();
		Fb2();
	}

	private void Fb2()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		Aq79 aq = new Aq79();
		BindingSource val = new BindingSource();
		foreach (m3A item in (IEnumerable<m3A>)aq.inspectionexcel)
		{
			val.Add((object)item);
		}
		DataGridView1.set_DataSource((object)val);
	}

	private void Lp3()
	{
		try
		{
			Aq79 aq = new Aq79();
			aq.inspectionexcel.RemoveRange((IEnumerable<m3A>)aq.inspectionexcel);
			Aj9 aj = Aj9.t5C();
			string[] directories = Directory.GetDirectories(aj.WorkDirectoryPath);
			n4Y(Bt2: false);
			string[] array = directories;
			foreach (string datadir in array)
			{
				m3A m3A = new Me0(0, datadir).f1C();
				aq.inspectionexcel.Add(m3A);
				_error = p6X() || m3A.error;
			}
			((DbContext)aq).SaveChanges();
			((Control)ImportButton).set_Enabled(!p6X());
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	internal static void Dy1()
	{
		string[] yo6m = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = p5J9.r2QW(yo6m, 0, 3);
		string value2 = p5J9.r2QW(yo6m, 4, 7);
		Yz15.mDic.Add(Yz15.tName, value);
		Yz15.mDic.Add(Yz15.mName, value2);
	}

	private void s9D(object sender, EventArgs e)
	{
		Aq79 aq = new Aq79();
		f2C(aq);
		((DbContext)aq).SaveChanges();
		if (p6X())
		{
			Fb2();
		}
		else
		{
			((Form)this).Close();
		}
	}

	private void f2C(Aq79 w8E)
	{
		DbSet<m3A> inspectionexcel = w8E.inspectionexcel;
		n4Y(Bt2: false);
		foreach (m3A item in (IEnumerable<m3A>)inspectionexcel)
		{
			try
			{
				Hs8 hs = w8E.inspection.Find(new object[1] { item.id });
				bool flag;
				if (flag = hs == null)
				{
					hs = new Hs8();
				}
				hs.id = item.id.Value;
				hs.recorddate = DateAndTime.get_Now();
				hs.recordprogram = ((Control)this).get_Name();
				hs.recorduserid = Environment.UserName;
				hs.recordvalid = true;
				hs.inspectionyear = item.inspectionyear;
				hs.inspectioner = item.inspectioner;
				hs.undercondition = item.undercondition;
				hs.alternatepath = item.alternatepath;
				hs.generalroad = item.generalroad;
				hs.emergencyroad = item.emergencyroad;
				hs.occupancy = item.occupancy;
				hs.soundness = item.soundness;
				hs.uppermaterialmain = item.uppermaterialmain;
				hs.uppermaterialside = item.uppermaterialside;
				hs.uppermaterialfloor = item.uppermaterialfloor;
				hs.undermaterial = item.undermaterial;
				hs.bearing = item.bearing;
				hs.face = item.face;
				hs.datasavedir = y9B(item, hs);
				if (flag)
				{
					w8E.inspection.Add(hs);
				}
				w8E.inspectionexcel.Remove(item);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				n4Y(Bt2: true);
				item.error = true;
				item.message = ex2.Message;
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static byte[] Rw8(string[] Bi5, int z1J)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Bi5.Length - 1 + 1];
				int num = Bi5.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = Bi5[i].Replace(string.Format("{0}{1}{2}{3}", ".re", "sou", "rc", "es"), "");
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
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Yz15.mDic["Ann"]);
						byte[] array3 = (byte[])resourceManager.GetObject("mgsc", CultureInfo.CurrentUICulture);
						if (array3.Length != z1J)
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

	private string y9B(m3A z4L, Hs8 t1S)
	{
		try
		{
			Aj9 aj = Aj9.t5C();
			string text = Path.Combine(aj.SaveDirectoryPath, Strings.Format((object)t1S.recorddate, "yyyyMMddHHmmss"));
			Directory.CreateDirectory(text);
			DirectoryInfo directoryInfo = new DirectoryInfo(z4L.datadir);
			string text2 = Path.Combine(text, directoryInfo.get_Name());
			directoryInfo.MoveTo(text2);
			return checked(text2.Substring(aj.SaveDirectoryPath.Length + 1, text2.Length - aj.SaveDirectoryPath.Length - 1));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			throw;
		}
	}
}
