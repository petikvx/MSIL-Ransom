using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sp5f;
using Tm8;
using c1RE;
using o3C;

namespace Nm3z;

[DesignerGenerated]
public class c7MG : Form
{
	private DataGridView _DataGridView1;

	private GroupBox _GroupBox1;

	private Label _Label2;

	private Button _Button1;

	private DateTimePicker _DateTimePicker1;

	private Panel _Panel1;

	private Label _Label4;

	private Label _Label5;

	private Button _Button3;

	private Label _Label7;

	private TextBox _txt_consult;

	private TextBox _TextBox1;

	private OleDbConnection oConnection;

	internal IContainer R;

	internal TextBox N;

	internal TextBox T;

	internal Label g;

	internal TextBox C;

	internal Label u;

	internal Button S;

	internal TextBox P;

	internal Label H;

	internal Button L;

	internal TextBox J;

	internal TextBox M;

	internal string Y;

	public c7MG()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)k9CJ);
		string text = (Y = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\moham\\Desktop\\Base_Patient.mdb");
		oConnection = new OleDbConnection(Y);
		z4X0();
	}

	protected override void Cy9a(bool Wz80)
	{
		try
		{
			if (Wz80 && R != null)
			{
				R.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Wz80);
		}
	}

	private void z4X0()
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
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d0: Expected O, but got Unknown
		//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Unknown result type (might be due to invalid IL or missing references)
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_052d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_0558: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Unknown result type (might be due to invalid IL or missing references)
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0695: Expected O, but got Unknown
		//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0722: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected O, but got Unknown
		//IL_074d: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0814: Unknown result type (might be due to invalid IL or missing references)
		//IL_081e: Expected O, but got Unknown
		//IL_083c: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_08af: Expected O, but got Unknown
		//IL_08d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_093f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0949: Expected O, but got Unknown
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a75: Expected O, but got Unknown
		//IL_0aad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Expected O, but got Unknown
		//IL_0b44: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbb: Expected O, but got Unknown
		//IL_0bdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Unknown result type (might be due to invalid IL or missing references)
		Tg36(new DataGridView());
		Mc03(new GroupBox());
		g4J0(new TextBox());
		La36(new TextBox());
		f2TW(new Label());
		y1D6(new TextBox());
		Ky41(new Label());
		w4J6(new TextBox());
		Qz8p(new TextBox());
		Lr7m(new Label());
		Ba62(new Label());
		m3S8(new TextBox());
		Qb61(new Label());
		Cs5g(new Button());
		So87(new DateTimePicker());
		Rs0p(new Panel());
		a1JR(new Label());
		y1YN(new Label());
		k2Z9(new Button());
		j9X8(new Button());
		Lc0w(new Button());
		o4X1(new TextBox());
		Be0m(new TextBox());
		((ISupportInitialize)w5A6()).BeginInit();
		((Control)t9XY()).SuspendLayout();
		((Control)i2Y1()).SuspendLayout();
		((Control)this).SuspendLayout();
		w5A6().set_BackgroundColor(Color.LightGreen);
		w5A6().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)w5A6()).set_Location(new Point(520, 158));
		((Control)w5A6()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)w5A6()).set_Name("DataGridView1");
		w5A6().set_RowHeadersWidth(51);
		((Control)w5A6()).set_Size(new Size(617, 352));
		((Control)w5A6()).set_TabIndex(0);
		((Control)t9XY()).set_BackColor(Color.White);
		((Control)t9XY()).get_Controls().Add((Control)(object)Wk9s());
		((Control)t9XY()).get_Controls().Add((Control)(object)y9TX());
		((Control)t9XY()).get_Controls().Add((Control)(object)j8M0());
		((Control)t9XY()).get_Controls().Add((Control)(object)Tj14());
		((Control)t9XY()).get_Controls().Add((Control)(object)Yx68());
		((Control)t9XY()).get_Controls().Add((Control)(object)z3Q0());
		((Control)t9XY()).get_Controls().Add((Control)(object)Dc7k());
		((Control)t9XY()).get_Controls().Add((Control)(object)Hd41());
		((Control)t9XY()).get_Controls().Add((Control)(object)Dy79());
		((Control)t9XY()).get_Controls().Add((Control)(object)Lc4t());
		((Control)t9XY()).get_Controls().Add((Control)(object)f4A1());
		((Control)t9XY()).set_Font(new Font("Lucida Bright", 11.25f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)t9XY()).set_Location(new Point(16, 76));
		((Control)t9XY()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)t9XY()).set_Name("GroupBox1");
		((Control)t9XY()).set_Padding(new Padding(4, 4, 4, 4));
		((Control)t9XY()).set_Size(new Size(479, 519));
		((Control)t9XY()).set_TabIndex(1);
		t9XY().set_TabStop(false);
		t9XY().set_Text("Patient à Traiter");
		((Control)Wk9s()).set_Location(new Point(304, 145));
		((Control)Wk9s()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Wk9s()).set_Name("txt_consult");
		((Control)Wk9s()).set_Size(new Size(165, 30));
		((Control)Wk9s()).set_TabIndex(10);
		((Control)y9TX()).set_Location(new Point(39, 145));
		((Control)y9TX()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)y9TX()).set_Name("txt_ID");
		((Control)y9TX()).set_Size(new Size(255, 30));
		((Control)y9TX()).set_TabIndex(9);
		j8M0().set_AutoSize(true);
		((Control)j8M0()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)j8M0()).set_Location(new Point(35, 119));
		((Control)j8M0()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)j8M0()).set_Name("Label7");
		((Control)j8M0()).set_Size(new Size(98, 24));
		((Control)j8M0()).set_TabIndex(8);
		j8M0().set_Text("ID_Patient");
		((Control)Tj14()).set_Location(new Point(273, 69));
		((Control)Tj14()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Tj14()).set_Name("txt_Prénom");
		((Control)Tj14()).set_Size(new Size(165, 30));
		((Control)Tj14()).set_TabIndex(7);
		Yx68().set_AutoSize(true);
		((Control)Yx68()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Yx68()).set_Location(new Point(296, 26));
		((Control)Yx68()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Yx68()).set_Name("Label5");
		((Control)Yx68()).set_Size(new Size(77, 24));
		((Control)Yx68()).set_TabIndex(6);
		Yx68().set_Text("Prénom");
		((Control)z3Q0()).set_Location(new Point(39, 219));
		((Control)z3Q0()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)z3Q0()).set_Name("txt_Analyse");
		((Control)z3Q0()).set_Size(new Size(431, 30));
		((Control)z3Q0()).set_TabIndex(5);
		((Control)Dc7k()).set_Location(new Point(8, 302));
		((Control)Dc7k()).set_Margin(new Padding(4, 4, 4, 4));
		Dc7k().set_Multiline(true);
		((Control)Dc7k()).set_Name("TextBox2");
		((Control)Dc7k()).set_Size(new Size(431, 210));
		((Control)Dc7k()).set_TabIndex(4);
		Hd41().set_AutoSize(true);
		((Control)Hd41()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Hd41()).set_Location(new Point(35, 254));
		((Control)Hd41()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Hd41()).set_Name("Label3");
		((Control)Hd41()).set_Size(new Size(220, 24));
		((Control)Hd41()).set_TabIndex(3);
		Hd41().set_Text("Remarques  précedentes");
		Dy79().set_AutoSize(true);
		((Control)Dy79()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Dy79()).set_Location(new Point(35, 180));
		((Control)Dy79()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Dy79()).set_Name("Label2");
		((Control)Dy79()).set_Size(new Size(149, 24));
		((Control)Dy79()).set_TabIndex(2);
		Dy79().set_Text("Type D'analayse");
		((Control)Lc4t()).set_Location(new Point(39, 69));
		((Control)Lc4t()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Lc4t()).set_Name("txt_Nom");
		((Control)Lc4t()).set_Size(new Size(165, 30));
		((Control)Lc4t()).set_TabIndex(1);
		f4A1().set_AutoSize(true);
		((Control)f4A1()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)f4A1()).set_Location(new Point(35, 26));
		((Control)f4A1()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)f4A1()).set_Name("Label1");
		((Control)f4A1()).set_Size(new Size(52, 24));
		((Control)f4A1()).set_TabIndex(0);
		f4A1().set_Text("Nom");
		((ButtonBase)p2TK()).set_FlatStyle((FlatStyle)0);
		((Control)p2TK()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)p2TK()).set_Location(new Point(520, 532));
		((Control)p2TK()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)p2TK()).set_Name("Button1");
		((Control)p2TK()).set_Size(new Size(387, 64));
		((Control)p2TK()).set_TabIndex(2);
		((ButtonBase)p2TK()).set_Text("Traiter le cas ");
		((ButtonBase)p2TK()).set_UseVisualStyleBackColor(true);
		((Control)Hg49()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Hg49().set_Format((DateTimePickerFormat)2);
		((Control)Hg49()).set_Location(new Point(533, 76));
		((Control)Hg49()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Hg49()).set_Name("DateTimePicker1");
		((Control)Hg49()).set_Size(new Size(277, 23));
		((Control)Hg49()).set_TabIndex(3);
		((Control)i2Y1()).set_BackColor(Color.Black);
		((Control)i2Y1()).get_Controls().Add((Control)(object)At27());
		((Control)i2Y1()).get_Controls().Add((Control)(object)i5D1());
		((Control)i2Y1()).set_Location(new Point(0, 0));
		((Control)i2Y1()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)i2Y1()).set_Name("Panel1");
		((Control)i2Y1()).set_Size(new Size(1220, 48));
		((Control)i2Y1()).set_TabIndex(8);
		((Control)i5D1()).set_BackColor(Color.Black);
		((Control)i5D1()).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)i5D1()).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)i5D1()).set_Location(new Point(461, 11));
		((Control)i5D1()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)i5D1()).set_Name("Label4");
		((Control)i5D1()).set_Size(new Size(372, 26));
		((Control)i5D1()).set_TabIndex(6);
		i5D1().set_Text("Commencer la consultation");
		Nc78().set_AutoSize(true);
		((Control)Nc78()).set_Font(new Font("Microsoft JhengHei UI", 14.25f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)Nc78()).set_Location(new Point(713, 113));
		((Control)Nc78()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Nc78()).set_Name("Label6");
		((Control)Nc78()).set_Size(new Size(230, 30));
		((Control)Nc78()).set_TabIndex(9);
		Nc78().set_Text("Patients en attente");
		((ButtonBase)Mo30()).set_FlatStyle((FlatStyle)0);
		((Control)Mo30()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Mo30()).set_Location(new Point(927, 532));
		((Control)Mo30()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Mo30()).set_Name("Button3");
		((Control)Mo30()).set_Size(new Size(211, 64));
		((Control)Mo30()).set_TabIndex(10);
		((ButtonBase)Mo30()).set_Text("Retour ");
		((ButtonBase)Mo30()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Zm0y()).set_FlatStyle((FlatStyle)0);
		((Control)Zm0y()).set_Location(new Point(867, 68));
		((Control)Zm0y()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Zm0y()).set_Name("Button4");
		((Control)Zm0y()).set_Size(new Size(216, 42));
		((Control)Zm0y()).set_TabIndex(11);
		((ButtonBase)Zm0y()).set_Text("Afficher");
		((ButtonBase)Zm0y()).set_UseVisualStyleBackColor(true);
		((ButtonBase)At27()).set_FlatStyle((FlatStyle)1);
		((Control)At27()).set_Location(new Point(1084, 0));
		((Control)At27()).set_Margin(new Padding(4));
		((Control)At27()).set_Name("Button2");
		((Control)At27()).set_Size(new Size(41, 44));
		((Control)At27()).set_TabIndex(8);
		((ButtonBase)At27()).set_UseVisualStyleBackColor(true);
		((Control)c8L5()).set_Location(new Point(583, 106));
		((Control)c8L5()).set_Name("TextBox1");
		((Control)c8L5()).set_Size(new Size(100, 22));
		((Control)c8L5()).set_TabIndex(12);
		((Control)Fw80()).set_Location(new Point(583, 134));
		((Control)Fw80()).set_Name("TextBox3");
		((Control)Fw80()).set_Size(new Size(100, 22));
		((Control)Fw80()).set_TabIndex(13);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.LightGreen);
		((Form)this).set_ClientSize(new Size(1149, 610));
		((Control)this).get_Controls().Add((Control)(object)Fw80());
		((Control)this).get_Controls().Add((Control)(object)c8L5());
		((Control)this).get_Controls().Add((Control)(object)Zm0y());
		((Control)this).get_Controls().Add((Control)(object)Mo30());
		((Control)this).get_Controls().Add((Control)(object)Nc78());
		((Control)this).get_Controls().Add((Control)(object)i2Y1());
		((Control)this).get_Controls().Add((Control)(object)Hg49());
		((Control)this).get_Controls().Add((Control)(object)p2TK());
		((Control)this).get_Controls().Add((Control)(object)t9XY());
		((Control)this).get_Controls().Add((Control)(object)w5A6());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name("Form6");
		((Form)this).set_Text("Form6");
		((ISupportInitialize)w5A6()).EndInit();
		((Control)t9XY()).ResumeLayout(false);
		((Control)t9XY()).PerformLayout();
		((Control)i2Y1()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual DataGridView w5A6()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tg36(DataGridView Qb5t)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(Cf9m);
		DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(e7Q0);
		DataGridView dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.remove_CellClick(val);
			dataGridView.remove_CellContentClick(val2);
		}
		_DataGridView1 = Qb5t;
		dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.add_CellClick(val);
			dataGridView.add_CellContentClick(val2);
		}
	}

	[SpecialName]
	internal virtual GroupBox t9XY()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mc03(GroupBox z2LZ)
	{
		EventHandler eventHandler = m8FW;
		GroupBox groupBox = _GroupBox1;
		if (groupBox != null)
		{
			((Control)groupBox).remove_Enter(eventHandler);
		}
		_GroupBox1 = z2LZ;
		groupBox = _GroupBox1;
		if (groupBox != null)
		{
			((Control)groupBox).add_Enter(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox z3Q0()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4J6(TextBox y4T1)
	{
		TextBox val = (N = y4T1);
	}

	[SpecialName]
	internal virtual TextBox Dc7k()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qz8p(TextBox f9T7)
	{
		TextBox val = (T = f9T7);
	}

	[SpecialName]
	internal virtual Label Hd41()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lr7m(Label k7FZ)
	{
		Label val = (g = k7FZ);
	}

	[SpecialName]
	internal virtual Label Dy79()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ba62(Label Xb95)
	{
		_Label2 = Xb95;
	}

	[SpecialName]
	internal virtual TextBox Lc4t()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m3S8(TextBox Go4t)
	{
		TextBox val = (C = Go4t);
	}

	[SpecialName]
	internal virtual Label f4A1()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qb61(Label b1C5)
	{
		Label val = (u = b1C5);
	}

	[SpecialName]
	internal virtual Button p2TK()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cs5g(Button Ni8d)
	{
		EventHandler eventHandler = w0TP;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Ni8d;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual DateTimePicker Hg49()
	{
		return _DateTimePicker1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void So87(DateTimePicker He49)
	{
		_DateTimePicker1 = He49;
	}

	[SpecialName]
	internal virtual Panel i2Y1()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rs0p(Panel Kb4a)
	{
		_Panel1 = Kb4a;
	}

	[SpecialName]
	internal virtual Button At27()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lc0w(Button Pi28)
	{
		EventHandler eventHandler = j1QW;
		Button s = S;
		if (s != null)
		{
			((Control)s).remove_Click(eventHandler);
		}
		Button val = (S = Pi28);
		s = S;
		if (s != null)
		{
			((Control)s).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label i5D1()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a1JR(Label o1YE)
	{
		_Label4 = o1YE;
	}

	[SpecialName]
	internal virtual TextBox Tj14()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1D6(TextBox Yt4w)
	{
		TextBox val = (P = Yt4w);
	}

	[SpecialName]
	internal virtual Label Yx68()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ky41(Label b1MF)
	{
		_Label5 = b1MF;
	}

	[SpecialName]
	internal virtual Label Nc78()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1YN(Label m3GA)
	{
		Label val = (H = m3GA);
	}

	[SpecialName]
	internal virtual Button Mo30()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k2Z9(Button Zk1t)
	{
		EventHandler eventHandler = r1G6;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = Zk1t;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Zm0y()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j9X8(Button Wa8f)
	{
		EventHandler eventHandler = Wo1p;
		Button l = L;
		if (l != null)
		{
			((Control)l).remove_Click(eventHandler);
		}
		Button val = (L = Wa8f);
		l = L;
		if (l != null)
		{
			((Control)l).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox y9TX()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void La36(TextBox Yo5p)
	{
		TextBox val = (J = Yo5p);
	}

	[SpecialName]
	internal virtual Label j8M0()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2TW(Label o1BP)
	{
		_Label7 = o1BP;
	}

	[SpecialName]
	internal virtual TextBox Wk9s()
	{
		return _txt_consult;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4J0(TextBox j3R4)
	{
		EventHandler eventHandler = d9P4;
		TextBox txt_consult = _txt_consult;
		if (txt_consult != null)
		{
			((Control)txt_consult).remove_TextChanged(eventHandler);
		}
		_txt_consult = j3R4;
		txt_consult = _txt_consult;
		if (txt_consult != null)
		{
			((Control)txt_consult).add_TextChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox c8L5()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4X1(TextBox Pn1q)
	{
		_TextBox1 = Pn1q;
	}

	[SpecialName]
	internal virtual TextBox Fw80()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Be0m(TextBox Ai96)
	{
		TextBox val = (M = Ai96);
	}

	private void k9CJ(object sender, EventArgs e)
	{
		((Control)Fw80()).set_Visible(false);
		Hg49().set_Value(DateAndTime.get_Now().Date);
		((Control)c8L5()).set_Visible(false);
	}

	private void j1QW(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Invalid comparison between Unknown and I4
		MsgBoxResult val = Interaction.MsgBox((object)"Vous voulez vraiment quitte ", (MsgBoxStyle)68, (object)"Confiramation");
		if ((int)val == 6)
		{
			Application.Exit();
		}
	}

	private void Cf9m(object sender, DataGridViewCellEventArgs e)
	{
		int rowIndex = e.get_RowIndex();
		DataGridViewRow val = w5A6().get_Rows().get_Item(rowIndex);
		Lc4t().set_Text(val.get_Cells().get_Item(1).get_Value()
			.ToString());
		y9TX().set_Text(val.get_Cells().get_Item(0).get_Value()
			.ToString());
		Tj14().set_Text(val.get_Cells().get_Item(2).get_Value()
			.ToString());
		z3Q0().set_Text(val.get_Cells().get_Item(3).get_Value()
			.ToString());
		Wk9s().set_Text(val.get_Cells().get_Item(6).get_Value()
			.ToString());
		Fw80().set_Text(val.get_Cells().get_Item(5).get_Value()
			.ToString());
	}

	private void w0TP(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Mn2()).Show();
		((Control)this).set_Visible(false);
	}

	internal static string[] Rz43()
	{
		Fy68.n2PC();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		j8Y.mDic.Add("Ann", value);
		return Pr4x.e7K1();
	}

	private void r1G6(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Cx0()).Show();
		((Form)this).Close();
	}

	private void Wo1p(object sender, EventArgs e)
	{
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		c8L5().set_Text(Hg49().get_Value().ToShortDateString());
		string text = "SELECT Consultation.ID_Patient, Patient.Nom, Patient.Prénom, Consultation.[Type d'analyse], Consultation.Datecon, Consultation.heure, Consultation.[Code_Consultation] \nFROM Consultation INNER JOIN Patient ON Consultation.ID_Patient = Patient.ID_Patient WHERE (((Consultation.Datecon)='" + c8L5().get_Text() + "'));";
		Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)null);
		try
		{
			oConnection.Open();
			OleDbCommand val = new OleDbCommand(text, oConnection);
			OleDbDataAdapter val2 = new OleDbDataAdapter(val);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val2).Fill(dataSet, "Consultation");
			w5A6().set_DataSource((object)dataSet);
			w5A6().set_DataMember("Consultation");
			oConnection.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	private void e7Q0(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void d9P4(object sender, EventArgs e)
	{
	}

	private void m8FW(object sender, EventArgs e)
	{
	}
}
