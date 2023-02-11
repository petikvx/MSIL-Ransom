using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Ed6;

[DesignerGenerated]
public class Xb0 : Form
{
	private IContainer components;

	private Panel _Panel1;

	private DataGridView _DataGridView1;

	private DataGridViewTextBoxColumn _Column1;

	private DataGridViewTextBoxColumn _Column4;

	private DataGridViewTextBoxColumn _Column6;

	private Button _PrintB;

	internal DataGridViewTextBoxColumn h;

	internal DataGridViewTextBoxColumn j;

	internal DataGridViewTextBoxColumn o;

	internal DataGridViewTextBoxColumn y;

	internal DataGridViewTextBoxColumn L;

	internal Button E;

	public Xb0()
	{
		d5Y();
	}

	protected override void Yf0(bool Qm7)
	{
		try
		{
			if (Qm7 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Qm7);
		}
	}

	private void d5Y()
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
		c0Y(new Panel());
		w1Z(new DataGridView());
		Ys4(new DataGridViewTextBoxColumn());
		Ci3(new DataGridViewTextBoxColumn());
		t6X(new DataGridViewTextBoxColumn());
		a4M(new DataGridViewTextBoxColumn());
		o7H(new DataGridViewTextBoxColumn());
		s5E(new DataGridViewTextBoxColumn());
		z4E(new DataGridViewTextBoxColumn());
		e0A(new DataGridViewTextBoxColumn());
		n3L(new Button());
		b3Q(new Button());
		((Control)b5J()).SuspendLayout();
		((ISupportInitialize)x3P()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)b5J()).get_Controls().Add((Control)(object)x3P());
		((Control)b5J()).set_Location(new Point(134, 220));
		((Control)b5J()).set_Name("Panel1");
		((Control)b5J()).set_Size(new Size(963, 480));
		((Control)b5J()).set_TabIndex(3);
		x3P().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		x3P().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)q4F(),
			(DataGridViewColumn)s5Z(),
			(DataGridViewColumn)Ma8(),
			(DataGridViewColumn)Ze2(),
			(DataGridViewColumn)y2M(),
			(DataGridViewColumn)Lz1(),
			(DataGridViewColumn)Gq1(),
			(DataGridViewColumn)s5A()
		});
		((Control)x3P()).set_Location(new Point(71, 50));
		((Control)x3P()).set_Name("DataGridView1");
		x3P().get_RowTemplate().set_Height(24);
		((Control)x3P()).set_Size(new Size(844, 386));
		((Control)x3P()).set_TabIndex(0);
		((DataGridViewColumn)q4F()).set_HeaderText("Tenant ID");
		((DataGridViewColumn)q4F()).set_Name("Column1");
		((DataGridViewColumn)s5Z()).set_HeaderText("Name");
		((DataGridViewColumn)s5Z()).set_Name("Column2");
		((DataGridViewColumn)Ma8()).set_HeaderText("No. of Person");
		((DataGridViewColumn)Ma8()).set_Name("Column3");
		((DataGridViewColumn)Ze2()).set_HeaderText("Flat Number");
		((DataGridViewColumn)Ze2()).set_Name("Column4");
		((DataGridViewColumn)y2M()).set_HeaderText("Flat Type");
		((DataGridViewColumn)y2M()).set_Name("Column5");
		((DataGridViewColumn)Lz1()).set_HeaderText("Rent Amount");
		((DataGridViewColumn)Lz1()).set_Name("Column6");
		((DataGridViewColumn)Gq1()).set_HeaderText("Date");
		((DataGridViewColumn)Gq1()).set_Name("Column7");
		((DataGridViewColumn)s5A()).set_HeaderText("Phone");
		((DataGridViewColumn)s5A()).set_Name("Column8");
		((Control)w2K()).set_Location(new Point(677, 723));
		((Control)w2K()).set_Name("Back");
		((Control)w2K()).set_Size(new Size(126, 34));
		((Control)w2K()).set_TabIndex(5);
		((ButtonBase)w2K()).set_Text("Back");
		((ButtonBase)w2K()).set_UseVisualStyleBackColor(true);
		((Control)k6S()).set_Location(new Point(372, 723));
		((Control)k6S()).set_Name("PrintB");
		((Control)k6S()).set_Size(new Size(126, 34));
		((Control)k6S()).set_TabIndex(4);
		((ButtonBase)k6S()).set_Text("Print");
		((ButtonBase)k6S()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1356, 769));
		((Control)this).get_Controls().Add((Control)(object)b5J());
		((Control)this).get_Controls().Add((Control)(object)w2K());
		((Control)this).get_Controls().Add((Control)(object)k6S());
		((Control)this).set_Name("Block_B");
		((Form)this).set_Text("Block_B");
		((Control)b5J()).ResumeLayout(false);
		((ISupportInitialize)x3P()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel b5J()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c0Y(Panel e2W)
	{
		_Panel1 = e2W;
	}

	[SpecialName]
	internal virtual DataGridView x3P()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1Z(DataGridView f4K)
	{
		_DataGridView1 = f4K;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn q4F()
	{
		return _Column1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ys4(DataGridViewTextBoxColumn Mg6)
	{
		_Column1 = Mg6;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn s5Z()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ci3(DataGridViewTextBoxColumn Af8)
	{
		DataGridViewTextBoxColumn val = (h = Af8);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ma8()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t6X(DataGridViewTextBoxColumn e5B)
	{
		DataGridViewTextBoxColumn val = (j = e5B);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ze2()
	{
		return _Column4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4M(DataGridViewTextBoxColumn Qp8)
	{
		_Column4 = Qp8;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn y2M()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o7H(DataGridViewTextBoxColumn Ey5)
	{
		DataGridViewTextBoxColumn val = (o = Ey5);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Lz1()
	{
		return _Column6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5E(DataGridViewTextBoxColumn d7P)
	{
		_Column6 = d7P;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Gq1()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4E(DataGridViewTextBoxColumn Hr5)
	{
		DataGridViewTextBoxColumn val = (y = Hr5);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn s5A()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0A(DataGridViewTextBoxColumn Tq6)
	{
		DataGridViewTextBoxColumn val = (L = Tq6);
	}

	[SpecialName]
	internal virtual Button w2K()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n3L(Button Kn0)
	{
		Button val = (E = Kn0);
	}

	[SpecialName]
	internal virtual Button k6S()
	{
		return _PrintB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3Q(Button s9B)
	{
		_PrintB = s9B;
	}
}
