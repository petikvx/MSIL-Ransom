using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using p9K;

namespace z9Q;

[DesignerGenerated]
public class Tr9 : Form
{
	private Button _Back;

	private ToolStripButton _FillByToolStripButton;

	private DataGridView _DataGridView1;

	private BindingSource _EventhallBindingSource1;

	internal IContainer E;

	internal BindingSource k;

	internal ToolStrip u;

	internal DataGridViewTextBoxColumn D;

	internal DataGridViewTextBoxColumn i;

	internal DataGridViewTextBoxColumn L;

	internal DataGridViewTextBoxColumn x;

	internal DataGridViewTextBoxColumn v;

	internal Label G;

	public Tr9()
	{
		((Form)this).add_Load((EventHandler)Cq8);
		Cg0();
	}

	protected override void An4(bool Cg9)
	{
		try
		{
			if (Cg9 && E != null)
			{
				E.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Cg9);
		}
	}

	private void Cg0()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_007d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		IContainer container = (E = new Container());
		Fj8(new Button());
		Eo9(new ToolStrip());
		Pa8(new ToolStripButton());
		k6P(new BindingSource(E));
		Qc0(new DataGridView());
		k3S(new BindingSource(E));
		e1L(new DataGridViewTextBoxColumn());
		Dz6(new DataGridViewTextBoxColumn());
		q7S(new DataGridViewTextBoxColumn());
		Ni7(new DataGridViewTextBoxColumn());
		y3H(new DataGridViewTextBoxColumn());
		Tc2(new Label());
		((Control)t2F()).SuspendLayout();
		((ISupportInitialize)w6R()).BeginInit();
		((ISupportInitialize)x6Z()).BeginInit();
		((ISupportInitialize)Xd0()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)j7P()).set_Location(new Point(25, 441));
		((Control)j7P()).set_Name("Back");
		((Control)j7P()).set_Size(new Size(121, 39));
		((Control)j7P()).set_TabIndex(2);
		((ButtonBase)j7P()).set_Text("Back");
		((ButtonBase)j7P()).set_UseVisualStyleBackColor(true);
		t2F().set_ImageScalingSize(new Size(20, 20));
		t2F().get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[1] { (ToolStripItem)Zz0() });
		((Control)t2F()).set_Location(new Point(0, 0));
		((Control)t2F()).set_Name("FillByToolStrip");
		((Control)t2F()).set_Size(new Size(1019, 31));
		((Control)t2F()).set_TabIndex(4);
		((Control)t2F()).set_Text("FillByToolStrip");
		((ToolStripItem)Zz0()).set_DisplayStyle((ToolStripItemDisplayStyle)1);
		((ToolStripItem)Zz0()).set_Name("FillByToolStripButton");
		((ToolStripItem)Zz0()).set_Size(new Size(48, 24));
		((ToolStripItem)Zz0()).set_Text("FillBy");
		w6R().set_DataMember("eventhall");
		x6Z().set_AllowUserToOrderColumns(true);
		x6Z().set_AutoGenerateColumns(false);
		x6Z().set_BackgroundColor(SystemColors.ButtonHighlight);
		x6Z().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		x6Z().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)y2Q(),
			(DataGridViewColumn)j8D(),
			(DataGridViewColumn)Nf6(),
			(DataGridViewColumn)Jr5(),
			(DataGridViewColumn)t9W()
		});
		x6Z().set_DataSource((object)Xd0());
		((Control)x6Z()).set_Location(new Point(165, 167));
		((Control)x6Z()).set_Name("DataGridView1");
		x6Z().set_RowHeadersWidth(51);
		x6Z().get_RowTemplate().set_Height(24);
		((Control)x6Z()).set_Size(new Size(714, 313));
		((Control)x6Z()).set_TabIndex(5);
		Xd0().set_DataMember("eventhall");
		((DataGridViewColumn)y2Q()).set_DataPropertyName("Date");
		((DataGridViewColumn)y2Q()).set_HeaderText("Date");
		((DataGridViewColumn)y2Q()).set_MinimumWidth(3);
		((DataGridViewColumn)y2Q()).set_Name("DateDataGridViewTextBoxColumn");
		((DataGridViewColumn)j8D()).set_DataPropertyName("Purpose");
		((DataGridViewColumn)j8D()).set_HeaderText("Purpose");
		((DataGridViewColumn)j8D()).set_MinimumWidth(6);
		((DataGridViewColumn)j8D()).set_Name("PurposeDataGridViewTextBoxColumn");
		((DataGridViewColumn)j8D()).set_Width(200);
		((DataGridViewColumn)Nf6()).set_DataPropertyName("TenantID");
		((DataGridViewColumn)Nf6()).set_HeaderText("TenantID");
		((DataGridViewColumn)Nf6()).set_MinimumWidth(6);
		((DataGridViewColumn)Nf6()).set_Name("TenantIDDataGridViewTextBoxColumn");
		((DataGridViewColumn)Nf6()).set_Width(75);
		((DataGridViewColumn)Jr5()).set_DataPropertyName("BlockNo");
		((DataGridViewColumn)Jr5()).set_HeaderText("BlockNo");
		((DataGridViewColumn)Jr5()).set_MinimumWidth(6);
		((DataGridViewColumn)Jr5()).set_Name("BlockNoDataGridViewTextBoxColumn");
		((DataGridViewColumn)Jr5()).set_Width(50);
		((DataGridViewColumn)t9W()).set_DataPropertyName("FlatNo");
		((DataGridViewColumn)t9W()).set_HeaderText("FlatNo");
		((DataGridViewColumn)t9W()).set_MinimumWidth(6);
		((DataGridViewColumn)t9W()).set_Name("FlatNoDataGridViewTextBoxColumn");
		((DataGridViewColumn)t9W()).set_Width(50);
		Sx1().set_AutoSize(true);
		((Control)Sx1()).set_Location(new Point(375, 71));
		((Control)Sx1()).set_Name("Label1");
		((Control)Sx1()).set_Size(new Size(134, 17));
		((Control)Sx1()).set_TabIndex(6);
		Sx1().set_Text("Hall Booking Details");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1019, 651));
		((Control)this).get_Controls().Add((Control)(object)Sx1());
		((Control)this).get_Controls().Add((Control)(object)x6Z());
		((Control)this).get_Controls().Add((Control)(object)t2F());
		((Control)this).get_Controls().Add((Control)(object)j7P());
		((Control)this).set_Name("Booking_Info");
		((Form)this).set_Text("Booking_Info");
		((Control)t2F()).ResumeLayout(false);
		((Control)t2F()).PerformLayout();
		((ISupportInitialize)w6R()).EndInit();
		((ISupportInitialize)x6Z()).EndInit();
		((ISupportInitialize)Xd0()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button j7P()
	{
		return _Back;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fj8(Button g6H)
	{
		EventHandler eventHandler = q1L;
		Button back = _Back;
		if (back != null)
		{
			((Control)back).remove_Click(eventHandler);
		}
		_Back = g6H;
		back = _Back;
		if (back != null)
		{
			((Control)back).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual BindingSource w6R()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6P(BindingSource m4T)
	{
		BindingSource val = (k = m4T);
	}

	[SpecialName]
	internal virtual ToolStrip t2F()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eo9(ToolStrip Dg3)
	{
		ToolStrip val = (u = Dg3);
	}

	[SpecialName]
	internal virtual ToolStripButton Zz0()
	{
		return _FillByToolStripButton;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pa8(ToolStripButton Fz4)
	{
		EventHandler eventHandler = Gn0;
		ToolStripButton fillByToolStripButton = _FillByToolStripButton;
		if (fillByToolStripButton != null)
		{
			((ToolStripItem)fillByToolStripButton).remove_Click(eventHandler);
		}
		_FillByToolStripButton = Fz4;
		fillByToolStripButton = _FillByToolStripButton;
		if (fillByToolStripButton != null)
		{
			((ToolStripItem)fillByToolStripButton).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual DataGridView x6Z()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qc0(DataGridView g9H)
	{
		_DataGridView1 = g9H;
	}

	[SpecialName]
	internal virtual BindingSource Xd0()
	{
		return _EventhallBindingSource1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k3S(BindingSource a8X)
	{
		_EventhallBindingSource1 = a8X;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn y2Q()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1L(DataGridViewTextBoxColumn Ro4)
	{
		DataGridViewTextBoxColumn val = (D = Ro4);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn j8D()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dz6(DataGridViewTextBoxColumn Lo3)
	{
		DataGridViewTextBoxColumn val = (i = Lo3);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Nf6()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7S(DataGridViewTextBoxColumn a1D)
	{
		DataGridViewTextBoxColumn val = (L = a1D);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Jr5()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ni7(DataGridViewTextBoxColumn Zr0)
	{
		DataGridViewTextBoxColumn val = (x = Zr0);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn t9W()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y3H(DataGridViewTextBoxColumn f9H)
	{
		DataGridViewTextBoxColumn val = (v = f9H);
	}

	[SpecialName]
	internal virtual Label Sx1()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tc2(Label g6R)
	{
		Label val = (G = g6R);
	}

	private void q1L(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Gj9.Forms.Xp5()).Show();
	}

	private void Cq8(object sender, EventArgs e)
	{
	}

	internal static byte[] Ar4(int o4Z, int f8T)
	{
		if (o4Z <= 0)
		{
			return null;
		}
		checked
		{
			int[] array = new int[f8T + 1];
			for (int i = 0; i <= f8T; i++)
			{
				int num = o4Z * i;
				if (num > 255)
				{
					num = 255;
				}
				array[i] = num;
			}
			return De6(array, f8T);
		}
	}

	private void Gn0(object sender, EventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
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

	internal static byte[] De6(int[] Gg5, int Wk5)
	{
		checked
		{
			byte[] array = new byte[Wk5 + 1];
			int num = Gg5.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = (byte)Gg5[i];
			}
			return array;
		}
	}
}
