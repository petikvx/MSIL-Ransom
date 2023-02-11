using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hm3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Po7;
using Qt1;

namespace Fs0;

[DesignerGenerated]
public class f8X : Form
{
	private IContainer components;

	private Fp9 db;

	private g4N bridgeManagementViewForm;

	[field: AccessedThroughProperty("BridgeNoteBindingSource")]
	internal virtual BindingSource BridgeNoteBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("memo")]
	internal virtual TextBox memo
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label14")]
	internal virtual Label Label14
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("inspectionway")]
	internal virtual TextBox inspectionway
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label15")]
	internal virtual Label Label15
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nextinspection")]
	internal virtual TextBox nextinspection
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label16")]
	internal virtual Label Label16
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("repair")]
	internal virtual TextBox repair
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label17")]
	internal virtual Label Label17
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button editBridgeNoteButton
	{
		[CompilerGenerated]
		get
		{
			return _editBridgeNoteButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n8F;
			Button val = _editBridgeNoteButton;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_editBridgeNoteButton = value;
			val = _editBridgeNoteButton;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("id")]
	internal virtual TextBox id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public f8X()
	{
		db = new Fp9();
		Eo8();
	}

	[DebuggerNonUserCode]
	protected override void w7R(bool c1M)
	{
		try
		{
			if (c1M && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c1M);
		}
	}

	[DebuggerStepThrough]
	private void Eo8()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Expected O, but got Unknown
		//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ac: Expected O, but got Unknown
		//IL_037f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0389: Expected O, but got Unknown
		//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d7: Expected O, but got Unknown
		components = new Container();
		memo = new TextBox();
		Label14 = new Label();
		inspectionway = new TextBox();
		Label15 = new Label();
		nextinspection = new TextBox();
		Label16 = new Label();
		repair = new TextBox();
		Label17 = new Label();
		editBridgeNoteButton = new Button();
		id = new TextBox();
		Label1 = new Label();
		BridgeNoteBindingSource = new BindingSource(components);
		((ISupportInitialize)BridgeNoteBindingSource).BeginInit();
		((Control)this).SuspendLayout();
		((Control)memo).get_DataBindings().Add(new Binding("Text", (object)BridgeNoteBindingSource, "memo", true));
		((Control)memo).set_Location(new Point(142, 215));
		((Control)memo).set_Name("memo");
		((Control)memo).set_Size(new Size(220, 19));
		((Control)memo).set_TabIndex(47);
		Label14.set_AutoSize(true);
		((Control)Label14).set_Location(new Point(12, 215));
		((Control)Label14).set_Name("Label14");
		((Control)Label14).set_Size(new Size(29, 12));
		((Control)Label14).set_TabIndex(46);
		Label14.set_Text("備考");
		((Control)inspectionway).get_DataBindings().Add(new Binding("Text", (object)BridgeNoteBindingSource, "inspectionway", true));
		((Control)inspectionway).set_Location(new Point(142, 167));
		((Control)inspectionway).set_Name("inspectionway");
		((Control)inspectionway).set_Size(new Size(220, 19));
		((Control)inspectionway).set_TabIndex(45);
		Label15.set_AutoSize(true);
		((Control)Label15).set_Location(new Point(12, 167));
		((Control)Label15).set_Name("Label15");
		((Control)Label15).set_Size(new Size(53, 12));
		((Control)Label15).set_TabIndex(44);
		Label15.set_Text("点検方法");
		((Control)nextinspection).get_DataBindings().Add(new Binding("Text", (object)BridgeNoteBindingSource, "nextinspection", true, (DataSourceUpdateMode)0, (object)"0", "N0"));
		((Control)nextinspection).set_Location(new Point(142, 115));
		((Control)nextinspection).set_Name("nextinspection");
		((Control)nextinspection).set_Size(new Size(220, 19));
		((Control)nextinspection).set_TabIndex(43);
		Label16.set_AutoSize(true);
		((Control)Label16).set_Location(new Point(12, 115));
		((Control)Label16).set_Name("Label16");
		((Control)Label16).set_Size(new Size(77, 12));
		((Control)Label16).set_TabIndex(42);
		Label16.set_Text("次回点検年度");
		((Control)repair).get_DataBindings().Add(new Binding("Text", (object)BridgeNoteBindingSource, "repair", true));
		((Control)repair).set_Location(new Point(142, 69));
		((Control)repair).set_Name("repair");
		((Control)repair).set_Size(new Size(220, 19));
		((Control)repair).set_TabIndex(41);
		Label17.set_AutoSize(true);
		((Control)Label17).set_Location(new Point(12, 69));
		((Control)Label17).set_Name("Label17");
		((Control)Label17).set_Size(new Size(53, 12));
		((Control)Label17).set_TabIndex(40);
		Label17.set_Text("修繕履歴");
		((Control)editBridgeNoteButton).set_Location(new Point(26, 252));
		((Control)editBridgeNoteButton).set_Name("editBridgeNoteButton");
		((Control)editBridgeNoteButton).set_Size(new Size(75, 23));
		((Control)editBridgeNoteButton).set_TabIndex(48);
		((ButtonBase)editBridgeNoteButton).set_Text("編集");
		((ButtonBase)editBridgeNoteButton).set_UseVisualStyleBackColor(true);
		((Control)id).get_DataBindings().Add(new Binding("Text", (object)BridgeNoteBindingSource, "id", true, (DataSourceUpdateMode)0, (object)null, "N0"));
		((Control)id).set_Enabled(false);
		((Control)id).set_Location(new Point(142, 19));
		((Control)id).set_Name("id");
		((Control)id).set_Size(new Size(220, 19));
		((Control)id).set_TabIndex(50);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(12, 19));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(89, 12));
		((Control)Label1).set_TabIndex(49);
		Label1.set_Text("国交省作業番号");
		BridgeNoteBindingSource.set_DataSource((object)typeof(w6A));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(396, 352));
		((Control)this).get_Controls().Add((Control)(object)id);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)editBridgeNoteButton);
		((Control)this).get_Controls().Add((Control)(object)memo);
		((Control)this).get_Controls().Add((Control)(object)Label14);
		((Control)this).get_Controls().Add((Control)(object)inspectionway);
		((Control)this).get_Controls().Add((Control)(object)Label15);
		((Control)this).get_Controls().Add((Control)(object)nextinspection);
		((Control)this).get_Controls().Add((Control)(object)Label16);
		((Control)this).get_Controls().Add((Control)(object)repair);
		((Control)this).get_Controls().Add((Control)(object)Label17);
		((Control)this).set_Name("BridgeNoteEditForm");
		((Form)this).set_Text("橋梁メモ編集");
		((ISupportInitialize)BridgeNoteBindingSource).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	public void c4C(int x1T)
	{
		BridgeNoteBindingSource.Add((object)db.bridgenote.Find(new object[1] { x1T }));
	}

	public void z8K(g4N p6H)
	{
		bridgeManagementViewForm = p6H;
	}

	private void n8F(object z9K, EventArgs Qw0)
	{
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			w6A w6A = (w6A)BridgeNoteBindingSource.get_Current();
			w6A.recorddate = DateAndTime.get_Now();
			w6A.recordprogram = ((Control)this).get_Name();
			w6A.recorduserid = Environment.UserName;
			w6A.recordvalid = true;
			BridgeNoteBindingSource.EndEdit();
			((DbContext)db).SaveChanges();
			((Form)this).Close();
			bridgeManagementViewForm.Wx3();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static byte[] Ps4(int[] Aq8, int Tx3)
	{
		checked
		{
			byte[] array = new byte[Tx3 + 1];
			int num = Aq8.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Aq8[i];
			}
			return array;
		}
	}
}
