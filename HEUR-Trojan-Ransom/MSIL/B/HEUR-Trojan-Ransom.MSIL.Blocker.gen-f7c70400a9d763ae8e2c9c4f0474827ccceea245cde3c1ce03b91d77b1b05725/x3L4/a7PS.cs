using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Kx0e;
using Microsoft.VisualBasic.CompilerServices;
using Py9e;
using f6C;
using f7C4;

namespace x3L4;

[DesignerGenerated]
public class a7PS : Form
{
	[CompilerGenerated]
	internal sealed class p1EC
	{
		public int _0024VB_0024Local_key;

		public p1EC(p1EC arg0)
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

	[field: AccessedThroughProperty("BridgenotehistoryBindingSource")]
	internal virtual BindingSource BridgenotehistoryBindingSource
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

	[field: AccessedThroughProperty("recorddate")]
	internal virtual DataGridViewTextBoxColumn recorddate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("RepairDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn RepairDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("NextinspectionDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn NextinspectionDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("InspectionwayDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn InspectionwayDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("MemoDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn MemoDataGridViewTextBoxColumn
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

	public a7PS()
	{
		p5A4();
	}

	[DebuggerNonUserCode]
	protected override void Rp0f(bool i9S1)
	{
		try
		{
			if (i9S1 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(i9S1);
		}
	}

	[DebuggerStepThrough]
	private void p5A4()
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
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		components = new Container();
		DataGridView1 = new DataGridView();
		IdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		recorddate = new DataGridViewTextBoxColumn();
		RepairDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		NextinspectionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		InspectionwayDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		MemoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BridgenotehistoryBindingSource = new BindingSource(components);
		SplitContainer1 = new SplitContainer();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)BridgenotehistoryBindingSource).BeginInit();
		((ISupportInitialize)SplitContainer1).BeginInit();
		((Control)SplitContainer1.get_Panel2()).SuspendLayout();
		((Control)SplitContainer1).SuspendLayout();
		((Control)this).SuspendLayout();
		DataGridView1.set_AllowUserToAddRows(false);
		DataGridView1.set_AllowUserToDeleteRows(false);
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[6]
		{
			(DataGridViewColumn)IdDataGridViewTextBoxColumn,
			(DataGridViewColumn)recorddate,
			(DataGridViewColumn)RepairDataGridViewTextBoxColumn,
			(DataGridViewColumn)NextinspectionDataGridViewTextBoxColumn,
			(DataGridViewColumn)InspectionwayDataGridViewTextBoxColumn,
			(DataGridViewColumn)MemoDataGridViewTextBoxColumn
		});
		DataGridView1.set_DataSource((object)BridgenotehistoryBindingSource);
		((Control)DataGridView1).set_Dock((DockStyle)5);
		((Control)DataGridView1).set_Location(new Point(0, 0));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_ReadOnly(true);
		DataGridView1.get_RowTemplate().set_Height(21);
		((Control)DataGridView1).set_Size(new Size(989, 452));
		((Control)DataGridView1).set_TabIndex(0);
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_DataPropertyName("id");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_HeaderText("国交省作業番号");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_Name("IdDataGridViewTextBoxColumn");
		((DataGridViewColumn)IdDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)recorddate).set_DataPropertyName("recorddate");
		((DataGridViewColumn)recorddate).set_HeaderText("データ保存日時");
		((DataGridViewColumn)recorddate).set_Name("recorddate");
		((DataGridViewColumn)recorddate).set_ReadOnly(true);
		((DataGridViewColumn)RepairDataGridViewTextBoxColumn).set_DataPropertyName("repair");
		((DataGridViewColumn)RepairDataGridViewTextBoxColumn).set_HeaderText("修繕履歴");
		((DataGridViewColumn)RepairDataGridViewTextBoxColumn).set_Name("RepairDataGridViewTextBoxColumn");
		((DataGridViewColumn)RepairDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)NextinspectionDataGridViewTextBoxColumn).set_DataPropertyName("nextinspection");
		((DataGridViewColumn)NextinspectionDataGridViewTextBoxColumn).set_HeaderText("次回点検年度");
		((DataGridViewColumn)NextinspectionDataGridViewTextBoxColumn).set_Name("NextinspectionDataGridViewTextBoxColumn");
		((DataGridViewColumn)NextinspectionDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)InspectionwayDataGridViewTextBoxColumn).set_DataPropertyName("inspectionway");
		((DataGridViewColumn)InspectionwayDataGridViewTextBoxColumn).set_HeaderText("点検方法");
		((DataGridViewColumn)InspectionwayDataGridViewTextBoxColumn).set_Name("InspectionwayDataGridViewTextBoxColumn");
		((DataGridViewColumn)InspectionwayDataGridViewTextBoxColumn).set_ReadOnly(true);
		((DataGridViewColumn)MemoDataGridViewTextBoxColumn).set_DataPropertyName("memo");
		((DataGridViewColumn)MemoDataGridViewTextBoxColumn).set_HeaderText("備考");
		((DataGridViewColumn)MemoDataGridViewTextBoxColumn).set_Name("MemoDataGridViewTextBoxColumn");
		((DataGridViewColumn)MemoDataGridViewTextBoxColumn).set_ReadOnly(true);
		BridgenotehistoryBindingSource.set_DataSource((object)typeof(a4D8));
		SplitContainer1.set_Dock((DockStyle)5);
		SplitContainer1.set_FixedPanel((FixedPanel)1);
		((Control)SplitContainer1).set_Location(new Point(0, 0));
		((Control)SplitContainer1).set_Name("SplitContainer1");
		SplitContainer1.set_Orientation((Orientation)0);
		((Control)SplitContainer1.get_Panel2()).get_Controls().Add((Control)(object)DataGridView1);
		((Control)SplitContainer1).set_Size(new Size(989, 487));
		SplitContainer1.set_SplitterDistance(31);
		((Control)SplitContainer1).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(989, 487));
		((Control)this).get_Controls().Add((Control)(object)SplitContainer1);
		((Control)this).set_Name("BridgeNoteHistoryForm");
		((Form)this).set_Text("橋梁メモ履歴");
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)BridgenotehistoryBindingSource).EndInit();
		((Control)SplitContainer1.get_Panel2()).ResumeLayout(false);
		((ISupportInitialize)SplitContainer1).EndInit();
		((Control)SplitContainer1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	public void k3R1(int r5RH)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		p1EC arg = default(p1EC);
		p1EC CS_0024_003C_003E8__locals0 = new p1EC(arg);
		CS_0024_003C_003E8__locals0._0024VB_0024Local_key = r5RH;
		Fr2b fr2b = new Fr2b();
		BindingSource val = new BindingSource();
		foreach (a4D8 item in ((IQueryable<a4D8>)fr2b.bridgenotehistory).Where((a4D8 n) => n.id == CS_0024_003C_003E8__locals0._0024VB_0024Local_key))
		{
			val.Add((object)item);
		}
		DataGridView1.set_DataSource((object)val);
	}

	internal static byte[] Ds15(int y0XL)
	{
		string[] array = new string[2] { "ewr4", "er5y" };
		if (array == null)
		{
			return null;
		}
		return x3C.z3T6(Gd35.b1WP(), y0XL);
	}
}