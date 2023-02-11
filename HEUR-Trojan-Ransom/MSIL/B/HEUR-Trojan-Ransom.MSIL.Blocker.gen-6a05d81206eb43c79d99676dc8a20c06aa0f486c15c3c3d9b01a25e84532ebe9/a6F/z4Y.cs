using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace a6F;

[DesignerGenerated]
public class z4Y : Form
{
	private Panel _Panel1;

	private DataGridViewTextBoxColumn _Column1;

	private DataGridViewTextBoxColumn _Column3;

	private DataGridViewTextBoxColumn _Column6;

	private DataGridViewTextBoxColumn _Column8;

	private Button _PrintC;

	internal IContainer y;

	internal DataGridView o;

	internal DataGridViewTextBoxColumn N;

	internal DataGridViewTextBoxColumn k;

	internal DataGridViewTextBoxColumn T;

	internal DataGridViewTextBoxColumn b;

	internal Button W;

	public z4Y()
	{
		x2T();
	}

	protected override void z9F(bool y3G)
	{
		try
		{
			if (y3G && y != null)
			{
				y.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(y3G);
		}
	}

	private void x2T()
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
		e4K(new Panel());
		x0K(new DataGridView());
		d0E(new DataGridViewTextBoxColumn());
		f2Q(new DataGridViewTextBoxColumn());
		Hb5(new DataGridViewTextBoxColumn());
		Bd2(new DataGridViewTextBoxColumn());
		k6H(new DataGridViewTextBoxColumn());
		Sk3(new DataGridViewTextBoxColumn());
		Zb1(new DataGridViewTextBoxColumn());
		t5R(new DataGridViewTextBoxColumn());
		Yf0(new Button());
		z1Q(new Button());
		((Control)Ep9()).SuspendLayout();
		((ISupportInitialize)j1J()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Ep9()).get_Controls().Add((Control)(object)j1J());
		((Control)Ep9()).set_Location(new Point(158, 217));
		((Control)Ep9()).set_Name("Panel1");
		((Control)Ep9()).set_Size(new Size(963, 480));
		((Control)Ep9()).set_TabIndex(3);
		j1J().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		j1J().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)x8Q(),
			(DataGridViewColumn)r1Z(),
			(DataGridViewColumn)w9E(),
			(DataGridViewColumn)Hj2(),
			(DataGridViewColumn)n4D(),
			(DataGridViewColumn)r5L(),
			(DataGridViewColumn)Me3(),
			(DataGridViewColumn)z1Y()
		});
		((Control)j1J()).set_Location(new Point(71, 50));
		((Control)j1J()).set_Name("DataGridView1");
		j1J().get_RowTemplate().set_Height(24);
		((Control)j1J()).set_Size(new Size(844, 386));
		((Control)j1J()).set_TabIndex(0);
		((DataGridViewColumn)x8Q()).set_HeaderText("Tenant ID");
		((DataGridViewColumn)x8Q()).set_Name("Column1");
		((DataGridViewColumn)r1Z()).set_HeaderText("Name");
		((DataGridViewColumn)r1Z()).set_Name("Column2");
		((DataGridViewColumn)w9E()).set_HeaderText("No. of Person");
		((DataGridViewColumn)w9E()).set_Name("Column3");
		((DataGridViewColumn)Hj2()).set_HeaderText("Flat Number");
		((DataGridViewColumn)Hj2()).set_Name("Column4");
		((DataGridViewColumn)n4D()).set_HeaderText("Flat Type");
		((DataGridViewColumn)n4D()).set_Name("Column5");
		((DataGridViewColumn)r5L()).set_HeaderText("Rent Amount");
		((DataGridViewColumn)r5L()).set_Name("Column6");
		((DataGridViewColumn)Me3()).set_HeaderText("Date");
		((DataGridViewColumn)Me3()).set_Name("Column7");
		((DataGridViewColumn)z1Y()).set_HeaderText("Phone");
		((DataGridViewColumn)z1Y()).set_Name("Column8");
		((Control)y6T()).set_Location(new Point(706, 724));
		((Control)y6T()).set_Name("Back");
		((Control)y6T()).set_Size(new Size(126, 34));
		((Control)y6T()).set_TabIndex(5);
		((ButtonBase)y6T()).set_Text("Back");
		((ButtonBase)y6T()).set_UseVisualStyleBackColor(true);
		((Control)c6P()).set_Location(new Point(401, 724));
		((Control)c6P()).set_Name("PrintC");
		((Control)c6P()).set_Size(new Size(126, 34));
		((Control)c6P()).set_TabIndex(4);
		((ButtonBase)c6P()).set_Text("Print");
		((ButtonBase)c6P()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1386, 773));
		((Control)this).get_Controls().Add((Control)(object)Ep9());
		((Control)this).get_Controls().Add((Control)(object)y6T());
		((Control)this).get_Controls().Add((Control)(object)c6P());
		((Control)this).set_Name("Block_C");
		((Form)this).set_Text("Block_C");
		((Control)Ep9()).ResumeLayout(false);
		((ISupportInitialize)j1J()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Ep9()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4K(Panel Xa7)
	{
		_Panel1 = Xa7;
	}

	[SpecialName]
	internal virtual DataGridView j1J()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x0K(DataGridView Ao2)
	{
		DataGridView val = (o = Ao2);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn x8Q()
	{
		return _Column1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d0E(DataGridViewTextBoxColumn Lz7)
	{
		_Column1 = Lz7;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn r1Z()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2Q(DataGridViewTextBoxColumn y9R)
	{
		DataGridViewTextBoxColumn val = (N = y9R);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn w9E()
	{
		return _Column3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hb5(DataGridViewTextBoxColumn m9F)
	{
		_Column3 = m9F;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Hj2()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bd2(DataGridViewTextBoxColumn d9S)
	{
		DataGridViewTextBoxColumn val = (k = d9S);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn n4D()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6H(DataGridViewTextBoxColumn Lb8)
	{
		DataGridViewTextBoxColumn val = (T = Lb8);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn r5L()
	{
		return _Column6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sk3(DataGridViewTextBoxColumn Cm8)
	{
		_Column6 = Cm8;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Me3()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zb1(DataGridViewTextBoxColumn f0S)
	{
		DataGridViewTextBoxColumn val = (b = f0S);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn z1Y()
	{
		return _Column8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t5R(DataGridViewTextBoxColumn Bk4)
	{
		_Column8 = Bk4;
	}

	[SpecialName]
	internal virtual Button y6T()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yf0(Button Br1)
	{
		Button val = (W = Br1);
	}

	[SpecialName]
	internal virtual Button c6P()
	{
		return _PrintC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z1Q(Button Zq9)
	{
		_PrintC = Zq9;
	}
}
