using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Ji0;

[DesignerGenerated]
public class b4W : Form
{
	private IContainer components;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DataGridView DataGridView1
	{
		[CompilerGenerated]
		get
		{
			return _DataGridView1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(c4Y);
			DataGridView dataGridView = _DataGridView1;
			if (dataGridView != null)
			{
				dataGridView.remove_CellContentClick(val);
			}
			_DataGridView1 = value;
			dataGridView = _DataGridView1;
			if (dataGridView != null)
			{
				dataGridView.add_CellContentClick(val);
			}
		}
	}

	[field: AccessedThroughProperty("Column1")]
	internal virtual DataGridViewTextBoxColumn Column1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column2")]
	internal virtual DataGridViewTextBoxColumn Column2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column3")]
	internal virtual DataGridViewTextBoxColumn Column3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column4")]
	internal virtual DataGridViewTextBoxColumn Column4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column5")]
	internal virtual DataGridViewTextBoxColumn Column5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column6")]
	internal virtual DataGridViewTextBoxColumn Column6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column7")]
	internal virtual DataGridViewTextBoxColumn Column7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Column8")]
	internal virtual DataGridViewTextBoxColumn Column8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Print")]
	internal virtual Button Print
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Back")]
	internal virtual Button Back
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public b4W()
	{
		Qg9();
	}

	[DebuggerNonUserCode]
	protected override void r4Z(bool s5H)
	{
		try
		{
			if (s5H && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(s5H);
		}
	}

	[DebuggerStepThrough]
	private void Qg9()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
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
		Panel1 = new Panel();
		DataGridView1 = new DataGridView();
		Column1 = new DataGridViewTextBoxColumn();
		Column2 = new DataGridViewTextBoxColumn();
		Column3 = new DataGridViewTextBoxColumn();
		Column4 = new DataGridViewTextBoxColumn();
		Column5 = new DataGridViewTextBoxColumn();
		Column6 = new DataGridViewTextBoxColumn();
		Column7 = new DataGridViewTextBoxColumn();
		Column8 = new DataGridViewTextBoxColumn();
		Print = new Button();
		Back = new Button();
		((Control)Panel1).SuspendLayout();
		((ISupportInitialize)DataGridView1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Panel1).get_Controls().Add((Control)(object)DataGridView1);
		((Control)Panel1).set_Location(new Point(151, 185));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(963, 480));
		((Control)Panel1).set_TabIndex(0);
		DataGridView1.set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		DataGridView1.get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)Column1,
			(DataGridViewColumn)Column2,
			(DataGridViewColumn)Column3,
			(DataGridViewColumn)Column4,
			(DataGridViewColumn)Column5,
			(DataGridViewColumn)Column6,
			(DataGridViewColumn)Column7,
			(DataGridViewColumn)Column8
		});
		((Control)DataGridView1).set_Location(new Point(71, 50));
		((Control)DataGridView1).set_Name("DataGridView1");
		DataGridView1.get_RowTemplate().set_Height(24);
		((Control)DataGridView1).set_Size(new Size(844, 386));
		((Control)DataGridView1).set_TabIndex(0);
		((DataGridViewColumn)Column1).set_HeaderText("Tenant ID");
		((DataGridViewColumn)Column1).set_Name("Column1");
		((DataGridViewColumn)Column2).set_HeaderText("Name");
		((DataGridViewColumn)Column2).set_Name("Column2");
		((DataGridViewColumn)Column3).set_HeaderText("No. of Person");
		((DataGridViewColumn)Column3).set_Name("Column3");
		((DataGridViewColumn)Column4).set_HeaderText("Flat Number");
		((DataGridViewColumn)Column4).set_Name("Column4");
		((DataGridViewColumn)Column5).set_HeaderText("Flat Type");
		((DataGridViewColumn)Column5).set_Name("Column5");
		((DataGridViewColumn)Column6).set_HeaderText("Rent Amount");
		((DataGridViewColumn)Column6).set_Name("Column6");
		((DataGridViewColumn)Column7).set_HeaderText("Date");
		((DataGridViewColumn)Column7).set_Name("Column7");
		((DataGridViewColumn)Column8).set_HeaderText("Phone");
		((DataGridViewColumn)Column8).set_Name("Column8");
		((Control)Print).set_Location(new Point(389, 688));
		((Control)Print).set_Name("Print");
		((Control)Print).set_Size(new Size(126, 34));
		((Control)Print).set_TabIndex(1);
		((ButtonBase)Print).set_Text("Print");
		((ButtonBase)Print).set_UseVisualStyleBackColor(true);
		((Control)Back).set_Location(new Point(694, 688));
		((Control)Back).set_Name("Back");
		((Control)Back).set_Size(new Size(126, 34));
		((Control)Back).set_TabIndex(2);
		((ButtonBase)Back).set_Text("Back");
		((ButtonBase)Back).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1403, 734));
		((Control)this).get_Controls().Add((Control)(object)Back);
		((Control)this).get_Controls().Add((Control)(object)Print);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Name("Block_A");
		((Form)this).set_Text("Block_A");
		((Control)Panel1).ResumeLayout(false);
		((ISupportInitialize)DataGridView1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void c4Y(object sender, DataGridViewCellEventArgs e)
	{
	}
}
