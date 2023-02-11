using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hz6;
using Microsoft.VisualBasic.CompilerServices;

namespace m1G3;

[DesignerGenerated]
public class Qr4m : Form
{
	private Label _Label2;

	private Label _Label4;

	private Label _CurrentReading;

	private MaskedTextBox _t_id;

	private MaskedTextBox _flatNo;

	private MaskedTextBox _p_reading;

	private MaskedTextBox _current_reading;

	private MaskedTextBox _this_m_reading;

	private Button _CalculateReading;

	private MaskedTextBox _amount_to_pay;

	private MaskedTextBox _cardNo;

	private MaskedTextBox _MaskedTextBox11;

	internal IContainer i;

	internal Label g;

	internal Label n;

	internal Label c;

	internal Label X;

	internal Label K;

	internal MaskedTextBox T;

	internal MaskedTextBox H;

	internal MaskedTextBox j;

	internal Label f;

	internal Button s;

	internal Label e;

	internal Label m;

	internal Button V;

	internal Button U;

	internal MonthCalendar d;

	public Qr4m()
	{
		Fw3r();
	}

	protected override void Jw10(bool Zq49)
	{
		try
		{
			if (Zq49 && i != null)
			{
				i.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Zq49);
		}
	}

	private void Fw3r()
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
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		x2Z7(new Label());
		Yb8o(new Label());
		i3W1(new Label());
		k4CG(new Label());
		Ks12(new Label());
		g7Z6(new Label());
		j1K8(new Label());
		Zg4i(new Label());
		Qw04(new MaskedTextBox());
		k7A1(new MaskedTextBox());
		Dq9d(new MaskedTextBox());
		Fp3g(new MaskedTextBox());
		Eb2f(new MaskedTextBox());
		Bn81(new MaskedTextBox());
		c2H9(new MaskedTextBox());
		w5WP(new MaskedTextBox());
		k1Q9(new Label());
		Hm46(new Button());
		q3ND(new MaskedTextBox());
		Tn51(new Button());
		s5Q4(new Label());
		Jo7z(new Label());
		e0X2(new MaskedTextBox());
		x4BC(new MaskedTextBox());
		c4Y0(new Button());
		i2X1(new Button());
		z0HM(new MonthCalendar());
		((Control)this).SuspendLayout();
		o3YH().set_AutoSize(true);
		((Control)o3YH()).set_Location(new Point(77, 128));
		((Control)o3YH()).set_Name("Label1");
		((Control)o3YH()).set_Size(new Size(70, 17));
		((Control)o3YH()).set_TabIndex(0);
		o3YH().set_Text("Tenant ID");
		r4X5().set_AutoSize(true);
		((Control)r4X5()).set_Location(new Point(77, 180));
		((Control)r4X5()).set_Name("Label2");
		((Control)r4X5()).set_Size(new Size(85, 17));
		((Control)r4X5()).set_TabIndex(1);
		r4X5().set_Text("Flat Number");
		Jx7t().set_AutoSize(true);
		((Control)Jx7t()).set_Location(new Point(77, 233));
		((Control)Jx7t()).set_Name("Label3");
		((Control)Jx7t()).set_Size(new Size(67, 17));
		((Control)Jx7t()).set_TabIndex(2);
		Jx7t().set_Text("Flat Type");
		b0TP().set_AutoSize(true);
		((Control)b0TP()).set_Location(new Point(77, 282));
		((Control)b0TP()).set_Name("Label4");
		((Control)b0TP()).set_Size(new Size(83, 17));
		((Control)b0TP()).set_TabIndex(3);
		b0TP().set_Text("Block Name");
		j7E4().set_AutoSize(true);
		((Control)j7E4()).set_Location(new Point(77, 336));
		((Control)j7E4()).set_Name("Date1");
		((Control)j7E4()).set_Size(new Size(38, 17));
		((Control)j7E4()).set_TabIndex(4);
		j7E4().set_Text("Date");
		q4S9().set_AutoSize(true);
		((Control)q4S9()).set_Location(new Point(449, 128));
		((Control)q4S9()).set_Name("PreviousReading");
		((Control)q4S9()).set_Size(new Size(120, 17));
		((Control)q4S9()).set_TabIndex(5);
		q4S9().set_Text("Previous Reading");
		Cw6e().set_AutoSize(true);
		((Control)Cw6e()).set_Location(new Point(449, 180));
		((Control)Cw6e()).set_Name("CurrentReading");
		((Control)Cw6e()).set_Size(new Size(112, 17));
		((Control)Cw6e()).set_TabIndex(6);
		Cw6e().set_Text("Current Reading");
		Cm04().set_AutoSize(true);
		((Control)Cm04()).set_Location(new Point(449, 233));
		((Control)Cm04()).set_Name("ThisMonthReading");
		((Control)Cm04()).set_Size(new Size(135, 17));
		((Control)Cm04()).set_TabIndex(7);
		Cm04().set_Text("This Month Reading");
		((Control)d7F8()).set_Location(new Point(190, 128));
		((Control)d7F8()).set_Name("t_id");
		((Control)d7F8()).set_Size(new Size(175, 22));
		((Control)d7F8()).set_TabIndex(8);
		((Control)Bi0c()).set_Location(new Point(190, 180));
		((Control)Bi0c()).set_Name("flatNo");
		((Control)Bi0c()).set_Size(new Size(175, 22));
		((Control)Bi0c()).set_TabIndex(9);
		((Control)Jf7b()).set_Location(new Point(190, 233));
		((Control)Jf7b()).set_Name("flatType");
		((Control)Jf7b()).set_Size(new Size(175, 22));
		((Control)Jf7b()).set_TabIndex(10);
		((Control)Zk5d()).set_Location(new Point(190, 282));
		((Control)Zk5d()).set_Name("blockNo");
		((Control)Zk5d()).set_Size(new Size(175, 22));
		((Control)Zk5d()).set_TabIndex(11);
		((Control)e8RB()).set_Location(new Point(190, 336));
		((Control)e8RB()).set_Name("date2");
		((Control)e8RB()).set_Size(new Size(175, 22));
		((Control)e8RB()).set_TabIndex(12);
		((Control)s7F5()).set_Location(new Point(613, 128));
		((Control)s7F5()).set_Name("p_reading");
		((Control)s7F5()).set_Size(new Size(175, 22));
		((Control)s7F5()).set_TabIndex(13);
		((Control)Mo49()).set_Location(new Point(613, 180));
		((Control)Mo49()).set_Name("current_reading");
		((Control)Mo49()).set_Size(new Size(175, 22));
		((Control)Mo49()).set_TabIndex(14);
		((Control)Lz57()).set_Location(new Point(613, 233));
		((Control)Lz57()).set_Name("this_m_reading");
		((Control)Lz57()).set_Size(new Size(175, 22));
		((Control)Lz57()).set_TabIndex(15);
		Mk6p().set_AutoSize(true);
		((Control)Mk6p()).set_Location(new Point(449, 399));
		((Control)Mk6p()).set_Name("AmounttoPay");
		((Control)Mk6p()).set_Size(new Size(100, 17));
		((Control)Mk6p()).set_TabIndex(9);
		Mk6p().set_Text("Amount to Pay");
		((Control)o2S7()).set_Location(new Point(622, 304));
		((Control)o2S7()).set_Name("CalculateReading");
		((Control)o2S7()).set_Size(new Size(166, 37));
		((Control)o2S7()).set_TabIndex(8);
		((ButtonBase)o2S7()).set_Text("Calculate Reading");
		((ButtonBase)o2S7()).set_UseVisualStyleBackColor(true);
		((Control)n3XZ()).set_Location(new Point(613, 394));
		((Control)n3XZ()).set_Name("amount_to_pay");
		((Control)n3XZ()).set_Size(new Size(175, 22));
		((Control)n3XZ()).set_TabIndex(18);
		((Control)y3N7()).set_Location(new Point(622, 454));
		((Control)y3N7()).set_Name("CalculateAmount");
		((Control)y3N7()).set_Size(new Size(166, 37));
		((Control)y3N7()).set_TabIndex(10);
		((ButtonBase)y3N7()).set_Text("Calculate Amount");
		((ButtonBase)y3N7()).set_UseVisualStyleBackColor(true);
		s9QL().set_AutoSize(true);
		((Control)s9QL()).set_Location(new Point(449, 527));
		((Control)s9QL()).set_Name("CardNumber");
		((Control)s9QL()).set_Size(new Size(92, 17));
		((Control)s9QL()).set_TabIndex(11);
		s9QL().set_Text("Card Number");
		p4P0().set_AutoSize(true);
		((Control)p4P0()).set_Location(new Point(449, 594));
		((Control)p4P0()).set_Name("PINNumber");
		((Control)p4P0()).set_Size(new Size(84, 17));
		((Control)p4P0()).set_TabIndex(12);
		p4P0().set_Text("PIN Number");
		((Control)Md6q()).set_Location(new Point(613, 527));
		((Control)Md6q()).set_Name("cardNo");
		((Control)Md6q()).set_Size(new Size(175, 22));
		((Control)Md6q()).set_TabIndex(22);
		((Control)w3FY()).set_Location(new Point(613, 594));
		((Control)w3FY()).set_Name("MaskedTextBox11");
		((Control)w3FY()).set_Size(new Size(175, 22));
		((Control)w3FY()).set_TabIndex(23);
		((Control)c8WZ()).set_Location(new Point(452, 664));
		((Control)c8WZ()).set_Name("PAY");
		((Control)c8WZ()).set_Size(new Size(119, 43));
		((Control)c8WZ()).set_TabIndex(13);
		((ButtonBase)c8WZ()).set_Text("PAY");
		((ButtonBase)c8WZ()).set_UseVisualStyleBackColor(true);
		((Control)o3Y6()).set_Location(new Point(632, 664));
		((Control)o3Y6()).set_Name("BACK");
		((Control)o3Y6()).set_Size(new Size(119, 43));
		((Control)o3Y6()).set_TabIndex(14);
		((ButtonBase)o3Y6()).set_Text("BACK");
		((ButtonBase)o3Y6()).set_UseVisualStyleBackColor(true);
		((Control)x9KN()).set_Location(new Point(103, 399));
		((Control)x9KN()).set_Name("MonthCalendar1");
		((Control)x9KN()).set_TabIndex(24);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(887, 775));
		((Control)this).get_Controls().Add((Control)(object)x9KN());
		((Control)this).get_Controls().Add((Control)(object)o3Y6());
		((Control)this).get_Controls().Add((Control)(object)c8WZ());
		((Control)this).get_Controls().Add((Control)(object)w3FY());
		((Control)this).get_Controls().Add((Control)(object)Md6q());
		((Control)this).get_Controls().Add((Control)(object)p4P0());
		((Control)this).get_Controls().Add((Control)(object)s9QL());
		((Control)this).get_Controls().Add((Control)(object)y3N7());
		((Control)this).get_Controls().Add((Control)(object)n3XZ());
		((Control)this).get_Controls().Add((Control)(object)o2S7());
		((Control)this).get_Controls().Add((Control)(object)Mk6p());
		((Control)this).get_Controls().Add((Control)(object)Lz57());
		((Control)this).get_Controls().Add((Control)(object)Mo49());
		((Control)this).get_Controls().Add((Control)(object)s7F5());
		((Control)this).get_Controls().Add((Control)(object)e8RB());
		((Control)this).get_Controls().Add((Control)(object)Zk5d());
		((Control)this).get_Controls().Add((Control)(object)Jf7b());
		((Control)this).get_Controls().Add((Control)(object)Bi0c());
		((Control)this).get_Controls().Add((Control)(object)d7F8());
		((Control)this).get_Controls().Add((Control)(object)Cm04());
		((Control)this).get_Controls().Add((Control)(object)Cw6e());
		((Control)this).get_Controls().Add((Control)(object)q4S9());
		((Control)this).get_Controls().Add((Control)(object)j7E4());
		((Control)this).get_Controls().Add((Control)(object)b0TP());
		((Control)this).get_Controls().Add((Control)(object)Jx7t());
		((Control)this).get_Controls().Add((Control)(object)r4X5());
		((Control)this).get_Controls().Add((Control)(object)o3YH());
		((Control)this).set_Name("Pay_eletricity");
		((Form)this).set_Text("Pay_eletricity");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label o3YH()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2Z7(Label Xa67)
	{
		Label val = (g = Xa67);
	}

	[SpecialName]
	internal virtual Label r4X5()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yb8o(Label Xp0c)
	{
		_Label2 = Xp0c;
	}

	[SpecialName]
	internal virtual Label Jx7t()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3W1(Label f8W9)
	{
		Label val = (n = f8W9);
	}

	[SpecialName]
	internal virtual Label b0TP()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4CG(Label Ld26)
	{
		_Label4 = Ld26;
	}

	[SpecialName]
	internal virtual Label j7E4()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ks12(Label Ac31)
	{
		Label val = (c = Ac31);
	}

	[SpecialName]
	internal virtual Label q4S9()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7Z6(Label Tq9k)
	{
		Label val = (X = Tq9k);
	}

	[SpecialName]
	internal virtual Label Cw6e()
	{
		return _CurrentReading;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j1K8(Label Kf1s)
	{
		_CurrentReading = Kf1s;
	}

	[SpecialName]
	internal virtual Label Cm04()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zg4i(Label w8QE)
	{
		Label val = (K = w8QE);
	}

	[SpecialName]
	internal virtual MaskedTextBox d7F8()
	{
		return _t_id;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qw04(MaskedTextBox d1LB)
	{
		_t_id = d1LB;
	}

	[SpecialName]
	internal virtual MaskedTextBox Bi0c()
	{
		return _flatNo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k7A1(MaskedTextBox i7Q6)
	{
		_flatNo = i7Q6;
	}

	[SpecialName]
	internal virtual MaskedTextBox Jf7b()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dq9d(MaskedTextBox Db0a)
	{
		MaskedTextBox val = (T = Db0a);
	}

	[SpecialName]
	internal virtual MaskedTextBox Zk5d()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fp3g(MaskedTextBox Nd5y)
	{
		MaskedTextBox val = (H = Nd5y);
	}

	[SpecialName]
	internal virtual MaskedTextBox e8RB()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eb2f(MaskedTextBox r2D9)
	{
		MaskedTextBox val = (j = r2D9);
	}

	[SpecialName]
	internal virtual MaskedTextBox s7F5()
	{
		return _p_reading;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bn81(MaskedTextBox c8F5)
	{
		_p_reading = c8F5;
	}

	[SpecialName]
	internal virtual MaskedTextBox Mo49()
	{
		return _current_reading;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2H9(MaskedTextBox r1GD)
	{
		_current_reading = r1GD;
	}

	[SpecialName]
	internal virtual MaskedTextBox Lz57()
	{
		return _this_m_reading;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w5WP(MaskedTextBox Tj7g)
	{
		_this_m_reading = Tj7g;
	}

	[SpecialName]
	internal virtual Label Mk6p()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1Q9(Label p7C5)
	{
		Label val = (f = p7C5);
	}

	[SpecialName]
	internal virtual Button o2S7()
	{
		return _CalculateReading;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hm46(Button c6R5)
	{
		_CalculateReading = c6R5;
	}

	[SpecialName]
	internal virtual MaskedTextBox n3XZ()
	{
		return _amount_to_pay;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q3ND(MaskedTextBox f3Q0)
	{
		_amount_to_pay = f3Q0;
	}

	[SpecialName]
	internal virtual Button y3N7()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tn51(Button p6PX)
	{
		Button val = (s = p6PX);
	}

	[SpecialName]
	internal virtual Label s9QL()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5Q4(Label Tm56)
	{
		Label val = (e = Tm56);
	}

	[SpecialName]
	internal virtual Label p4P0()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jo7z(Label z8XL)
	{
		Label val = (m = z8XL);
	}

	[SpecialName]
	internal virtual MaskedTextBox Md6q()
	{
		return _cardNo;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0X2(MaskedTextBox St28)
	{
		_cardNo = St28;
	}

	[SpecialName]
	internal virtual MaskedTextBox w3FY()
	{
		return _MaskedTextBox11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4BC(MaskedTextBox Jk0a)
	{
		_MaskedTextBox11 = Jk0a;
	}

	[SpecialName]
	internal virtual Button c8WZ()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4Y0(Button m3AR)
	{
		EventHandler eventHandler = i5ZK;
		Button v = V;
		if (v != null)
		{
			((Control)v).remove_Click(eventHandler);
		}
		Button val = (V = m3AR);
		v = V;
		if (v != null)
		{
			((Control)v).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button o3Y6()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i2X1(Button s4J2)
	{
		Button val = (U = s4J2);
	}

	[SpecialName]
	internal virtual MonthCalendar x9KN()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z0HM(MonthCalendar Em73)
	{
		MonthCalendar val = (d = Em73);
	}

	private void i5ZK(object sender, EventArgs e)
	{
	}

	internal static void Ec54()
	{
		string[] q4E = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = j5N.Ys5(q4E, 0, 3);
		string value2 = j5N.Ys5(q4E, 4, 7);
		j5N.mDic.Add(j5N.tName, value);
		j5N.mDic.Add(j5N.mName, value2);
	}
}
