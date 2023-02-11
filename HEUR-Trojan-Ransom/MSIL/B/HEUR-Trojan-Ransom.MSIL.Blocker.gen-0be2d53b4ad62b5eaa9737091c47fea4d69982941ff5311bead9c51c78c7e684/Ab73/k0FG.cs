using System;
using System.ComponentModel;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Db9i;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d0D;
using s7KW;

namespace Ab73;

[DesignerGenerated]
public class k0FG : Form
{
	private IContainer components;

	private Zj9 db;

	private j5K6 bridgeManagementViewForm;

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
			EventHandler eventHandler = Rk6b;
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

	public k0FG()
	{
		db = new Zj9();
		m6ZJ();
	}

	[DebuggerNonUserCode]
	protected override void g4E8(bool x6AB)
	{
		try
		{
			if (x6AB && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(x6AB);
		}
	}

	[DebuggerStepThrough]
	private void m6ZJ()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_027d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0287: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0359: Expected O, but got Unknown
		//IL_048c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0496: Expected O, but got Unknown
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
		BridgeNoteBindingSource.set_DataSource((object)typeof(Po6j));
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

	public void b3BR(int Te86)
	{
		BridgeNoteBindingSource.Add((object)db.bridgenote.Find(new object[1] { Te86 }));
	}

	public void Tj96(j5K6 q9PZ)
	{
		bridgeManagementViewForm = q9PZ;
	}

	private void Rk6b(object sender, EventArgs e)
	{
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Po6j po6j = (Po6j)BridgeNoteBindingSource.get_Current();
			po6j.recorddate = DateAndTime.get_Now();
			po6j.recordprogram = ((Control)this).get_Name();
			po6j.recorduserid = Environment.UserName;
			po6j.recordvalid = true;
			BridgeNoteBindingSource.EndEdit();
			((DbContext)db).SaveChanges();
			((Form)this).Close();
			bridgeManagementViewForm.Nn06();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static byte[] z5E9(int[] w8A3, int s5TR)
	{
		checked
		{
			byte[] array = new byte[s5TR + 1];
			int num = w8A3.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)w8A3[i];
			}
			return array;
		}
	}
}
