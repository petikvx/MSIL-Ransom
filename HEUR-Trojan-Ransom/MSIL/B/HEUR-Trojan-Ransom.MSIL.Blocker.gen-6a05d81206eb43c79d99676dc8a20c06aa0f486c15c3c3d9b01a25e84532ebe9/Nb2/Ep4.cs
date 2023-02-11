using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Nb2;

[DesignerGenerated]
public class Ep4 : Form
{
	private IContainer components;

	private DataGridView _DataGridView1;

	private DataGridViewTextBoxColumn _Column5;

	private DataGridViewTextBoxColumn _Column7;

	private DataGridViewTextBoxColumn _Column8;

	private Button _Print;

	private Button _Back;

	internal Panel Y;

	internal DataGridViewTextBoxColumn h;

	internal DataGridViewTextBoxColumn G;

	internal DataGridViewTextBoxColumn K;

	internal DataGridViewTextBoxColumn I;

	internal DataGridViewTextBoxColumn A;

	public Ep4()
	{
		Fw4();
	}

	protected override void En3(bool w9W)
	{
		try
		{
			if (w9W && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w9W);
		}
	}

	private void Fw4()
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
		b1L(new Panel());
		p8B(new DataGridView());
		f8K(new DataGridViewTextBoxColumn());
		p4H(new DataGridViewTextBoxColumn());
		d5B(new DataGridViewTextBoxColumn());
		f6D(new DataGridViewTextBoxColumn());
		e9M(new DataGridViewTextBoxColumn());
		Am7(new DataGridViewTextBoxColumn());
		Qp3(new DataGridViewTextBoxColumn());
		Lg3(new DataGridViewTextBoxColumn());
		Nk8(new Button());
		e3B(new Button());
		((Control)y4R()).SuspendLayout();
		((ISupportInitialize)t8G()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)y4R()).get_Controls().Add((Control)(object)t8G());
		((Control)y4R()).set_Location(new Point(151, 185));
		((Control)y4R()).set_Name("Panel1");
		((Control)y4R()).set_Size(new Size(963, 480));
		((Control)y4R()).set_TabIndex(0);
		t8G().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		t8G().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)w9S(),
			(DataGridViewColumn)k1M(),
			(DataGridViewColumn)f2F(),
			(DataGridViewColumn)Nm6(),
			(DataGridViewColumn)Ry7(),
			(DataGridViewColumn)Ci9(),
			(DataGridViewColumn)Gb8(),
			(DataGridViewColumn)Pk5()
		});
		((Control)t8G()).set_Location(new Point(71, 50));
		((Control)t8G()).set_Name("DataGridView1");
		t8G().get_RowTemplate().set_Height(24);
		((Control)t8G()).set_Size(new Size(844, 386));
		((Control)t8G()).set_TabIndex(0);
		((DataGridViewColumn)w9S()).set_HeaderText("Tenant ID");
		((DataGridViewColumn)w9S()).set_Name("Column1");
		((DataGridViewColumn)k1M()).set_HeaderText("Name");
		((DataGridViewColumn)k1M()).set_Name("Column2");
		((DataGridViewColumn)f2F()).set_HeaderText("No. of Person");
		((DataGridViewColumn)f2F()).set_Name("Column3");
		((DataGridViewColumn)Nm6()).set_HeaderText("Flat Number");
		((DataGridViewColumn)Nm6()).set_Name("Column4");
		((DataGridViewColumn)Ry7()).set_HeaderText("Flat Type");
		((DataGridViewColumn)Ry7()).set_Name("Column5");
		((DataGridViewColumn)Ci9()).set_HeaderText("Rent Amount");
		((DataGridViewColumn)Ci9()).set_Name("Column6");
		((DataGridViewColumn)Gb8()).set_HeaderText("Date");
		((DataGridViewColumn)Gb8()).set_Name("Column7");
		((DataGridViewColumn)Pk5()).set_HeaderText("Phone");
		((DataGridViewColumn)Pk5()).set_Name("Column8");
		((Control)Rr8()).set_Location(new Point(389, 688));
		((Control)Rr8()).set_Name("Print");
		((Control)Rr8()).set_Size(new Size(126, 34));
		((Control)Rr8()).set_TabIndex(1);
		((ButtonBase)Rr8()).set_Text("Print");
		((ButtonBase)Rr8()).set_UseVisualStyleBackColor(true);
		((Control)e9A()).set_Location(new Point(694, 688));
		((Control)e9A()).set_Name("Back");
		((Control)e9A()).set_Size(new Size(126, 34));
		((Control)e9A()).set_TabIndex(2);
		((ButtonBase)e9A()).set_Text("Back");
		((ButtonBase)e9A()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1403, 734));
		((Control)this).get_Controls().Add((Control)(object)e9A());
		((Control)this).get_Controls().Add((Control)(object)Rr8());
		((Control)this).get_Controls().Add((Control)(object)y4R());
		((Control)this).set_Name("Block_A");
		((Form)this).set_Text("Block_A");
		((Control)y4R()).ResumeLayout(false);
		((ISupportInitialize)t8G()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel y4R()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1L(Panel n9D)
	{
		Panel val = (Y = n9D);
	}

	[SpecialName]
	internal virtual DataGridView t8G()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p8B(DataGridView Jc8)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(b5M);
		DataGridView dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.remove_CellContentClick(val);
		}
		_DataGridView1 = Jc8;
		dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.add_CellContentClick(val);
		}
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn w9S()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8K(DataGridViewTextBoxColumn Ce7)
	{
		DataGridViewTextBoxColumn val = (h = Ce7);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn k1M()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p4H(DataGridViewTextBoxColumn t7B)
	{
		DataGridViewTextBoxColumn val = (G = t7B);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn f2F()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d5B(DataGridViewTextBoxColumn f0R)
	{
		DataGridViewTextBoxColumn val = (K = f0R);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Nm6()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6D(DataGridViewTextBoxColumn a4Z)
	{
		DataGridViewTextBoxColumn val = (I = a4Z);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ry7()
	{
		return _Column5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9M(DataGridViewTextBoxColumn z1X)
	{
		_Column5 = z1X;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ci9()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Am7(DataGridViewTextBoxColumn Mw1)
	{
		DataGridViewTextBoxColumn val = (A = Mw1);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Gb8()
	{
		return _Column7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qp3(DataGridViewTextBoxColumn o9K)
	{
		_Column7 = o9K;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Pk5()
	{
		return _Column8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lg3(DataGridViewTextBoxColumn t5Y)
	{
		_Column8 = t5Y;
	}

	[SpecialName]
	internal virtual Button Rr8()
	{
		return _Print;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nk8(Button Qt4)
	{
		_Print = Qt4;
	}

	[SpecialName]
	internal virtual Button e9A()
	{
		return _Back;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3B(Button t8R)
	{
		_Back = t8R;
	}

	private void b5M(object sender, DataGridViewCellEventArgs e)
	{
	}
}
