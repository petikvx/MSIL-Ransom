using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using p0H8;

namespace j7F0;

[DesignerGenerated]
public class Cn4k : Form
{
	private IContainer components;

	internal virtual Button Back
	{
		[CompilerGenerated]
		get
		{
			return _Back;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = x0XR;
			Button back = _Back;
			if (back != null)
			{
				((Control)back).remove_Click(eventHandler);
			}
			_Back = value;
			back = _Back;
			if (back != null)
			{
				((Control)back).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("EventhallBindingSource")]
	internal virtual BindingSource EventhallBindingSource
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FillByToolStrip")]
	internal virtual ToolStrip FillByToolStrip
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ToolStripButton FillByToolStripButton
	{
		[CompilerGenerated]
		get
		{
			return _FillByToolStripButton;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = w8YH;
			ToolStripButton fillByToolStripButton = _FillByToolStripButton;
			if (fillByToolStripButton != null)
			{
				((ToolStripItem)fillByToolStripButton).remove_Click(eventHandler);
			}
			_FillByToolStripButton = value;
			fillByToolStripButton = _FillByToolStripButton;
			if (fillByToolStripButton != null)
			{
				((ToolStripItem)fillByToolStripButton).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("DataGridView1")]
	internal virtual DataGridView DataGridView1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("EventhallBindingSource1")]
	internal virtual BindingSource EventhallBindingSource1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn DateDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PurposeDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn PurposeDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TenantIDDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn TenantIDDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("BlockNoDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn BlockNoDataGridViewTextBoxColumn
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("FlatNoDataGridViewTextBoxColumn")]
	internal virtual DataGridViewTextBoxColumn FlatNoDataGridViewTextBoxColumn
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

	public Cn4k()
	{
		((Form)this).add_Load((EventHandler)Tq8o);
		Ys4m();
	}

	[DebuggerNonUserCode]
	protected override void j0WQ(bool Sr52)
	{
		try
		{
			if (Sr52 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Sr52);
		}
	}

	[DebuggerStepThrough]
	private void Ys4m()
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
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		components = new Container();
		Back = new Button();
		FillByToolStrip = new ToolStrip();
		FillByToolStripButton = new ToolStripButton();
		EventhallBindingSource = new BindingSource(components);
		DataGridView1 = new DataGridView();
		EventhallBindingSource1 = new BindingSource(components);
		DateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		PurposeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		TenantIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		BlockNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		FlatNoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
		Label1 = new Label();
		((Control)FillByToolStrip).SuspendLayout();
		((ISupportInitialize)EventhallBindingSource).BeginInit();
		((ISupportInitialize)DataGridView1).BeginInit();
		((ISupportInitialize)EventhallBindingSource1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Back).set_Location(new Point(25, 441));
		((Control)Back).set_Name("Back");
		((Control)Back).set_Size(new Size(121, 39));
		((Control)Back).set_TabIndex(2);
		((ButtonBase)Back).set_Text("Back");
		((ButtonBase)Back).set_UseVisualStyleBackColor(true);
		FillByToolStrip.set_ImageScalingSize(new Size(20, 20));
		FillByToolStrip.get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)FillByToolStripButton });
		((Control)FillByToolStrip).set_Location(new Point(0, 0));
		((Control)FillByToolStrip).set_Name("FillByToolStrip");
		((Control)FillByToolStrip).set_Size(new Size(1019, 31));
		((Control)FillByToolStrip).set_TabIndex(4);
		((Control)FillByToolStrip).set_Text("FillByToolStrip");
		((ToolStripItem)FillByToolStripButton).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)FillByToolStripButton).set_Name("FillByToolStripButton");
		((ToolStripItem)FillByToolStripButton).set_Size(new Size(48, 24));
		((ToolStripItem)FillByToolStripButton).set_Text("FillBy");
		EventhallBindingSource.set_DataMember("eventhall");
		DataGridView1.set_AllowUserToOrderColumns(true);
		DataGridView1.set_AutoGenerateColumns(false);
		DataGridView1.set_BackgroundColor(SystemColors.ButtonHighlight);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)DateDataGridViewTextBoxColumn,
			(DataGridViewColumn)PurposeDataGridViewTextBoxColumn,
			(DataGridViewColumn)TenantIDDataGridViewTextBoxColumn,
			(DataGridViewColumn)BlockNoDataGridViewTextBoxColumn,
			(DataGridViewColumn)FlatNoDataGridViewTextBoxColumn
		});
		DataGridView1.set_DataSource((object)EventhallBindingSource1);
		((Control)DataGridView1).set_Location(new Point(165, 167));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.set_RowHeadersWidth(51);
		DataGridView1.get_RowTemplate().set_Height(24);
		((Control)DataGridView1).set_Size(new Size(714, 313));
		((Control)DataGridView1).set_TabIndex(5);
		EventhallBindingSource1.set_DataMember("eventhall");
		((DataGridViewColumn)DateDataGridViewTextBoxColumn).set_DataPropertyName("Date");
		((DataGridViewColumn)DateDataGridViewTextBoxColumn).set_HeaderText("Date");
		((DataGridViewColumn)DateDataGridViewTextBoxColumn).set_MinimumWidth(3);
		((DataGridViewColumn)DateDataGridViewTextBoxColumn).set_Name("DateDataGridViewTextBoxColumn");
		((DataGridViewColumn)PurposeDataGridViewTextBoxColumn).set_DataPropertyName("Purpose");
		((DataGridViewColumn)PurposeDataGridViewTextBoxColumn).set_HeaderText("Purpose");
		((DataGridViewColumn)PurposeDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)PurposeDataGridViewTextBoxColumn).set_Name("PurposeDataGridViewTextBoxColumn");
		((DataGridViewColumn)PurposeDataGridViewTextBoxColumn).set_Width(200);
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_DataPropertyName("TenantID");
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_HeaderText("TenantID");
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_Name("TenantIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)TenantIDDataGridViewTextBoxColumn).set_Width(75);
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_DataPropertyName("BlockNo");
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_HeaderText("BlockNo");
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_Name("BlockNoDataGridViewTextBoxColumn");
		((DataGridViewColumn)BlockNoDataGridViewTextBoxColumn).set_Width(50);
		((DataGridViewColumn)FlatNoDataGridViewTextBoxColumn).set_DataPropertyName("FlatNo");
		((DataGridViewColumn)FlatNoDataGridViewTextBoxColumn).set_HeaderText("FlatNo");
		((DataGridViewColumn)FlatNoDataGridViewTextBoxColumn).set_MinimumWidth(6);
		((DataGridViewColumn)FlatNoDataGridViewTextBoxColumn).set_Name("FlatNoDataGridViewTextBoxColumn");
		((DataGridViewColumn)FlatNoDataGridViewTextBoxColumn).set_Width(50);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(375, 71));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(134, 17));
		((Control)Label1).set_TabIndex(6);
		Label1.set_Text("Hall Booking Details");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1019, 651));
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)DataGridView1);
		((Control)this).get_Controls().Add((Control)(object)FillByToolStrip);
		((Control)this).get_Controls().Add((Control)(object)Back);
		((Control)this).set_Name("Booking_Info");
		((Form)this).set_Text("Booking_Info");
		((Control)FillByToolStrip).ResumeLayout(false);
		((Control)FillByToolStrip).PerformLayout();
		((ISupportInitialize)EventhallBindingSource).EndInit();
		((ISupportInitialize)DataGridView1).EndInit();
		((ISupportInitialize)EventhallBindingSource1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void x0XR(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Ga6q.Forms.Admin_Function).Show();
	}

	private void y7ZR(object sender, EventArgs e)
	{
	}

	private void Tq8o(object sender, EventArgs e)
	{
	}

	internal static byte[] w6SL(int Kt56, int g5G4)
	{
		if (Kt56 <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[g5G4 + 1];
			for (int i = 0; i <= g5G4; i++)
			{
				int num = Kt56 * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return q5ZM(array, g5G4);
		}
	}

	private void w8YH(object sender, EventArgs e)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		try
		{
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	internal static byte[] q5ZM(int[] n2XT, int y9HK)
	{
		checked
		{
			byte[] array = new byte[y9HK + 1];
			int num = n2XT.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)n2XT[i];
			}
			return array;
		}
	}
}
