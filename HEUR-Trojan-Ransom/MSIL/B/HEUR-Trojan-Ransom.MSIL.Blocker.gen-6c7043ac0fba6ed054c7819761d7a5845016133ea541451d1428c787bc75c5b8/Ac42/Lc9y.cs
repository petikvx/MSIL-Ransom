using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Tm8;
using o3C;

namespace Ac42;

[DesignerGenerated]
public class Lc9y : Form
{
	private IContainer components;

	private PictureBox _PictureBox1;

	private Label _Label3;

	private Label _Label4;

	private Label _Label5;

	private Label _Label9;

	private Label _Label8;

	private Label _Label13;

	private Label _lbl_2;

	private Label _lbl_3;

	private Label _u_3;

	private Label _lbl_4;

	private Label _u_4;

	private Label _lbl_6;

	private Label _u_5;

	private Label _lbl_maladie;

	private Label _lbl_temperature;

	private Label _lbl_age;

	private Label _l3;

	private Label _lbl_analyse;

	private Label _lbl_date;

	private Button _Button1;

	private Button _Button2;

	private Button _Button10;

	private Button _Button3;

	private TextBox _txt_id;

	private Label _l44;

	private Label _l55;

	private Label _l66;

	private Label _Label22;

	private Label _Label20;

	private Label _Label19;

	private Label _Label18;

	private Label _Label15;

	private Label _Label14;

	private OleDbConnection oConnection;

	internal Label B;

	internal PictureBox e;

	internal Label i;

	internal GroupBox a;

	internal Label r;

	internal Label y;

	internal Label H;

	internal Label U;

	internal Label m;

	internal Label f;

	internal Label N;

	internal Label O;

	internal Label K;

	internal Label V;

	internal GroupBox w;

	internal Label P;

	internal Label j;

	internal Label T;

	internal Label s;

	internal Label G;

	internal Label X;

	internal Label d;

	internal Label C;

	internal Label l;

	internal Label Q;

	internal Label Z;

	internal Label eB;

	internal Label ee;

	internal Label ei;

	internal Label ea;

	internal Label er;

	internal Label ey;

	internal GroupBox eH;

	internal string eU;

	public Lc9y()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Lj2d);
		string text = (eU = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\moham\\Desktop\\Base_Patient.mdb");
		oConnection = new OleDbConnection(eU);
		Aw30();
	}

	protected override void t4CG(bool s7EX)
	{
		try
		{
			if (s7EX && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(s7EX);
		}
	}

	private void Aw30()
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
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_02d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e1: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0347: Expected O, but got Unknown
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0446: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected O, but got Unknown
		//IL_0866: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_08da: Expected O, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Unknown result type (might be due to invalid IL or missing references)
		//IL_0972: Expected O, but got Unknown
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a07: Expected O, but got Unknown
		//IL_0a2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9f: Expected O, but got Unknown
		//IL_0ac3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2b: Expected O, but got Unknown
		//IL_0c4c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0daf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e23: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1005: Unknown result type (might be due to invalid IL or missing references)
		//IL_107d: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_116d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1263: Unknown result type (might be due to invalid IL or missing references)
		//IL_12de: Unknown result type (might be due to invalid IL or missing references)
		//IL_1356: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_144f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_180e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1818: Expected O, but got Unknown
		//IL_1836: Unknown result type (might be due to invalid IL or missing references)
		//IL_1857: Unknown result type (might be due to invalid IL or missing references)
		//IL_18cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d7: Expected O, but got Unknown
		//IL_1963: Unknown result type (might be due to invalid IL or missing references)
		//IL_196d: Expected O, but got Unknown
		//IL_198b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a55: Expected O, but got Unknown
		//IL_1a75: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aec: Expected O, but got Unknown
		//IL_1b0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b77: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b81: Expected O, but got Unknown
		//IL_1ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c0f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c19: Expected O, but got Unknown
		//IL_1c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ca7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb1: Expected O, but got Unknown
		//IL_1cd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d46: Expected O, but got Unknown
		//IL_1d6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dd4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dde: Expected O, but got Unknown
		//IL_1e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e76: Expected O, but got Unknown
		//IL_1e9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f04: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f0e: Expected O, but got Unknown
		//IL_1f32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fa6: Expected O, but got Unknown
		//IL_1fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_2034: Unknown result type (might be due to invalid IL or missing references)
		//IL_203e: Expected O, but got Unknown
		//IL_205f: Unknown result type (might be due to invalid IL or missing references)
		//IL_20c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_20d3: Expected O, but got Unknown
		//IL_20f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_2161: Unknown result type (might be due to invalid IL or missing references)
		//IL_216b: Expected O, but got Unknown
		//IL_218c: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2200: Expected O, but got Unknown
		//IL_2224: Unknown result type (might be due to invalid IL or missing references)
		//IL_228e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2298: Expected O, but got Unknown
		//IL_22b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2323: Unknown result type (might be due to invalid IL or missing references)
		//IL_232d: Expected O, but got Unknown
		//IL_2351: Unknown result type (might be due to invalid IL or missing references)
		//IL_23bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_23c5: Expected O, but got Unknown
		//IL_23e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2453: Unknown result type (might be due to invalid IL or missing references)
		//IL_245d: Expected O, but got Unknown
		//IL_2481: Unknown result type (might be due to invalid IL or missing references)
		//IL_24eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_24f5: Expected O, but got Unknown
		//IL_2516: Unknown result type (might be due to invalid IL or missing references)
		//IL_2580: Unknown result type (might be due to invalid IL or missing references)
		//IL_258a: Expected O, but got Unknown
		//IL_25ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_2615: Unknown result type (might be due to invalid IL or missing references)
		//IL_261f: Expected O, but got Unknown
		//IL_2643: Unknown result type (might be due to invalid IL or missing references)
		//IL_26ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b7: Expected O, but got Unknown
		//IL_26db: Unknown result type (might be due to invalid IL or missing references)
		//IL_2745: Unknown result type (might be due to invalid IL or missing references)
		//IL_274f: Expected O, but got Unknown
		//IL_2770: Unknown result type (might be due to invalid IL or missing references)
		//IL_27da: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e4: Expected O, but got Unknown
		//IL_2808: Unknown result type (might be due to invalid IL or missing references)
		//IL_2872: Unknown result type (might be due to invalid IL or missing references)
		//IL_287c: Expected O, but got Unknown
		//IL_289d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2924: Unknown result type (might be due to invalid IL or missing references)
		//IL_299d: Unknown result type (might be due to invalid IL or missing references)
		//IL_29a7: Expected O, but got Unknown
		//IL_29d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ac4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cac: Unknown result type (might be due to invalid IL or missing references)
		f2J9(new Label());
		z7B1(new PictureBox());
		d7Q8(new PictureBox());
		Ei97(new Label());
		Hq6z(new Label());
		Qj2g(new Label());
		j8EJ(new Label());
		d8QL(new GroupBox());
		Kr1y(new Label());
		d4G9(new Label());
		Cg05(new Label());
		Ji3e(new Label());
		Ns2n(new Label());
		g5M4(new Label());
		Py8o(new Label());
		Ls20(new Label());
		Wi19(new Label());
		Hc0e(new Label());
		z6P0(new Label());
		t0XN(new Label());
		d3E4(new Label());
		Ne70(new Label());
		b3WJ(new Label());
		Jw45(new Label());
		x5Y4(new Label());
		Qe56(new Label());
		g9PN(new Label());
		w2B0(new Label());
		e6K5(new Label());
		Bj1a(new Label());
		w0W7(new Label());
		Hp3w(new Label());
		Lm8r(new Label());
		Xd0g(new Label());
		Zz98(new GroupBox());
		k4P1(new GroupBox());
		Td1n(new Label());
		q2CH(new Label());
		o8GP(new Label());
		e9HZ(new Label());
		d4J1(new Label());
		Dz0r(new Label());
		Cn6p(new Label());
		y5S3(new Label());
		b1DA(new Label());
		Bi02(new Label());
		m0RX(new Label());
		Mc75(new Label());
		Hm1c(new Label());
		Zq84(new Label());
		k9X1(new Label());
		p5MG(new Label());
		Ro3g(new Label());
		Ek40(new Label());
		Yt90(new Label());
		m6C1(new Label());
		c2SK(new Label());
		Mt70(new Label());
		Eg02(new Label());
		Jk8i(new Label());
		Aa1t(new Label());
		a6S7(new Label());
		To79(new Button());
		Fg4t(new Button());
		r5M6(new Button());
		Ar30(new Button());
		r8B6(new TextBox());
		((ISupportInitialize)y1QG()).BeginInit();
		((ISupportInitialize)k6WY()).BeginInit();
		((Control)Qq27()).SuspendLayout();
		((Control)Hd1o()).SuspendLayout();
		((Control)Bp5r()).SuspendLayout();
		((Control)this).SuspendLayout();
		De8q().set_AutoSize(true);
		((Control)De8q()).set_Font(new Font("Microsoft YaHei UI", 20.25f, (FontStyle)7, (GraphicsUnit)3, (byte)0));
		((Control)De8q()).set_Location(new Point(475, 31));
		((Control)De8q()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)De8q()).set_Name("Label1");
		((Control)De8q()).set_Size(new Size(384, 45));
		((Control)De8q()).set_TabIndex(0);
		De8q().set_Text("Laboratoire Médicale");
		((Control)y1QG()).set_Location(new Point(1139, 13));
		((Control)y1QG()).set_Margin(new Padding(4));
		((Control)y1QG()).set_Name("PictureBox2");
		((Control)y1QG()).set_Size(new Size(257, 177));
		y1QG().set_SizeMode((PictureBoxSizeMode)1);
		y1QG().set_TabIndex(2);
		y1QG().set_TabStop(false);
		((Control)k6WY()).set_Location(new Point(24, 31));
		((Control)k6WY()).set_Margin(new Padding(4));
		((Control)k6WY()).set_Name("PictureBox1");
		((Control)k6WY()).set_Size(new Size(257, 177));
		k6WY().set_SizeMode((PictureBoxSizeMode)1);
		k6WY().set_TabIndex(1);
		k6WY().set_TabStop(false);
		Fy9e().set_AutoSize(true);
		((Control)Fy9e()).set_Location(new Point(427, 123));
		((Control)Fy9e()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Fy9e()).set_Name("Label2");
		((Control)Fy9e()).set_Size(new Size(0, 17));
		((Control)Fy9e()).set_TabIndex(3);
		Xm78().set_AutoSize(true);
		((Control)Xm78()).set_Location(new Point(333, 119));
		((Control)Xm78()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Xm78()).set_Name("Label3");
		((Control)Xm78()).set_Size(new Size(45, 17));
		((Control)Xm78()).set_TabIndex(4);
		Xm78().set_Text("Nom :");
		Kr4m().set_AutoSize(true);
		((Control)Kr4m()).set_Location(new Point(333, 171));
		((Control)Kr4m()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Kr4m()).set_Name("Label4");
		((Control)Kr4m()).set_Size(new Size(65, 17));
		((Control)Kr4m()).set_TabIndex(5);
		Kr4m().set_Text("Prénom :");
		Pt0w().set_AutoSize(true);
		((Control)Pt0w()).set_Location(new Point(333, 225));
		((Control)Pt0w()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Pt0w()).set_Name("Label5");
		((Control)Pt0w()).set_Size(new Size(173, 17));
		((Control)Pt0w()).set_TabIndex(6);
		Pt0w().set_Text("Type D'analyse effectuée:");
		((Control)Qq27()).set_BackColor(SystemColors.ButtonHighlight);
		((Control)Qq27()).get_Controls().Add((Control)(object)Xw83());
		((Control)Qq27()).get_Controls().Add((Control)(object)x0M2());
		((Control)Qq27()).get_Controls().Add((Control)(object)Lb27());
		((Control)Qq27()).get_Controls().Add((Control)(object)b0RS());
		((Control)Qq27()).get_Controls().Add((Control)(object)Kk24());
		((Control)Qq27()).get_Controls().Add((Control)(object)b5PW());
		((Control)Qq27()).get_Controls().Add((Control)(object)q9MZ());
		((Control)Qq27()).get_Controls().Add((Control)(object)o0A5());
		((Control)Qq27()).get_Controls().Add((Control)(object)r0RC());
		((Control)Qq27()).get_Controls().Add((Control)(object)g1P2());
		((Control)Qq27()).get_Controls().Add((Control)(object)a2YJ());
		((Control)Qq27()).get_Controls().Add((Control)(object)n5KG());
		((Control)Qq27()).set_Location(new Point(1117, 271));
		((Control)Qq27()).set_Margin(new Padding(4));
		((Control)Qq27()).set_Name("GroupBox2");
		((Control)Qq27()).set_Padding(new Padding(4));
		((Control)Qq27()).set_Size(new Size(419, 455));
		((Control)Qq27()).set_TabIndex(28);
		Qq27().set_TabStop(false);
		Qq27().set_Text("Mesures Usueles");
		Xw83().set_AutoSize(true);
		((Control)Xw83()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Xw83()).set_Location(new Point(237, 362));
		((Control)Xw83()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Xw83()).set_Name("lbl_maladie");
		((Control)Xw83()).set_Size(new Size(120, 26));
		((Control)Xw83()).set_TabIndex(44);
		Xw83().set_Text("lbl_maladit");
		x0M2().set_AutoSize(true);
		((Control)x0M2()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)x0M2()).set_Location(new Point(237, 302));
		((Control)x0M2()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)x0M2()).set_Name("lbl_tension");
		((Control)x0M2()).set_Size(new Size(116, 26));
		((Control)x0M2()).set_TabIndex(43);
		x0M2().set_Text("lbl_tension");
		Lb27().set_AutoSize(true);
		((Control)Lb27()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Lb27()).set_Location(new Point(237, 81));
		((Control)Lb27()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Lb27()).set_Name("lbl_poids");
		((Control)Lb27()).set_Size(new Size(99, 26));
		((Control)Lb27()).set_TabIndex(42);
		Lb27().set_Text("lbl_poids");
		b0RS().set_AutoSize(true);
		((Control)b0RS()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)b0RS()).set_Location(new Point(237, 147));
		((Control)b0RS()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)b0RS()).set_Name("lbl_taille");
		((Control)b0RS()).set_Size(new Size(94, 26));
		((Control)b0RS()).set_TabIndex(41);
		b0RS().set_Text("lbl_taille");
		Kk24().set_AutoSize(true);
		((Control)Kk24()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Kk24()).set_Location(new Point(237, 227));
		((Control)Kk24()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Kk24()).set_Name("lbl_temperature");
		((Control)Kk24()).set_Size(new Size(166, 26));
		((Control)Kk24()).set_TabIndex(40);
		Kk24().set_Text("lbl_temperature");
		b5PW().set_AutoSize(true);
		((Control)b5PW()).set_Location(new Point(20, 311));
		((Control)b5PW()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)b5PW()).set_Name("Label9");
		((Control)b5PW()).set_Size(new Size(181, 17));
		((Control)b5PW()).set_TabIndex(5);
		b5PW().set_Text("Tension en mm de Mercure");
		q9MZ().set_AutoSize(true);
		((Control)q9MZ()).set_Location(new Point(20, 362));
		((Control)q9MZ()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)q9MZ()).set_Name("Label8");
		((Control)q9MZ()).set_Size(new Size(97, 17));
		((Control)q9MZ()).set_TabIndex(4);
		q9MZ().set_Text("Maladie grave");
		o0A5().set_AutoSize(true);
		((Control)o0A5()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)o0A5()).set_Location(new Point(237, 37));
		((Control)o0A5()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)o0A5()).set_Name("lbl_age");
		((Control)o0A5()).set_Size(new Size(81, 26));
		((Control)o0A5()).set_TabIndex(39);
		o0A5().set_Text("lbl_age");
		r0RC().set_AutoSize(true);
		((Control)r0RC()).set_Location(new Point(20, 109));
		((Control)r0RC()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)r0RC()).set_Name("Label7");
		((Control)r0RC()).set_Size(new Size(74, 17));
		((Control)r0RC()).set_TabIndex(3);
		r0RC().set_Text("Poids (Kg)");
		g1P2().set_AutoSize(true);
		((Control)g1P2()).set_Location(new Point(20, 248));
		((Control)g1P2()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)g1P2()).set_Name("Label6");
		((Control)g1P2()).set_Size(new Size(119, 17));
		((Control)g1P2()).set_TabIndex(2);
		g1P2().set_Text("Température (°C)");
		a2YJ().set_AutoSize(true);
		((Control)a2YJ()).set_Location(new Point(20, 192));
		((Control)a2YJ()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)a2YJ()).set_Name("Label10");
		((Control)a2YJ()).set_Size(new Size(74, 17));
		((Control)a2YJ()).set_TabIndex(1);
		a2YJ().set_Text("Taille (cm)");
		n5KG().set_AutoSize(true);
		((Control)n5KG()).set_Location(new Point(20, 46));
		((Control)n5KG()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)n5KG()).set_Name("Label11");
		((Control)n5KG()).set_Size(new Size(33, 17));
		((Control)n5KG()).set_TabIndex(0);
		n5KG().set_Text("Age");
		q7M2().set_AutoSize(true);
		((Control)q7M2()).set_Location(new Point(771, 182));
		((Control)q7M2()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)q7M2()).set_Name("mo");
		((Control)q7M2()).set_Size(new Size(106, 17));
		((Control)q7M2()).set_TabIndex(29);
		q7M2().set_Text("Date De Visite :");
		Kg87().set_AutoSize(true);
		((Control)Kg87()).set_Location(new Point(771, 110));
		((Control)Kg87()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Kg87()).set_Name("Label13");
		((Control)Kg87()).set_Size(new Size(137, 17));
		((Control)Kg87()).set_TabIndex(32);
		Kg87().set_Text("Numéro de la visite :");
		Ko17().set_AutoSize(true);
		((Control)Ko17()).set_Location(new Point(13, 58));
		((Control)Ko17()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ko17()).set_Name("lbl_1");
		((Control)Ko17()).set_Size(new Size(89, 23));
		((Control)Ko17()).set_TabIndex(14);
		Ko17().set_Text("Albumine");
		Gj56().set_AutoSize(true);
		((Control)Gj56()).set_Location(new Point(401, 53));
		((Control)Gj56()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Gj56()).set_Name("u_1");
		((Control)Gj56()).set_Size(new Size(44, 23));
		((Control)Gj56()).set_TabIndex(15);
		Gj56().set_Text("g/dl");
		Wi76().set_AutoSize(true);
		((Control)Wi76()).set_Location(new Point(576, 63));
		((Control)Wi76()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Wi76()).set_Name("lbl_2");
		((Control)Wi76()).set_Size(new Size(48, 23));
		((Control)Wi76()).set_TabIndex(16);
		Wi76().set_Text("BUN");
		w2D6().set_AutoSize(true);
		((Control)w2D6()).set_Location(new Point(983, 62));
		((Control)w2D6()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)w2D6()).set_Name("u_2");
		((Control)w2D6()).set_Size(new Size(60, 23));
		((Control)w2D6()).set_TabIndex(17);
		w2D6().set_Text("mg/dl");
		k8TF().set_AutoSize(true);
		((Control)k8TF()).set_Location(new Point(13, 158));
		((Control)k8TF()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)k8TF()).set_Name("lbl_3");
		((Control)k8TF()).set_Size(new Size(92, 23));
		((Control)k8TF()).set_TabIndex(18);
		k8TF().set_Text("Créatinine");
		Kc4g().set_AutoSize(true);
		((Control)Kc4g()).set_Location(new Point(397, 150));
		((Control)Kc4g()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Kc4g()).set_Name("u_3");
		((Control)Kc4g()).set_Size(new Size(49, 23));
		((Control)Kc4g()).set_TabIndex(19);
		Kc4g().set_Text("mg/l");
		Ri8r().set_AutoSize(true);
		((Control)Ri8r()).set_Location(new Point(576, 153));
		((Control)Ri8r()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ri8r()).set_Name("lbl_4");
		((Control)Ri8r()).set_Size(new Size(41, 23));
		((Control)Ri8r()).set_TabIndex(20);
		Ri8r().set_Text("PAL");
		Hd7i().set_AutoSize(true);
		((Control)Hd7i()).set_Location(new Point(1007, 161));
		((Control)Hd7i()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Hd7i()).set_Name("u_4");
		((Control)Hd7i()).set_Size(new Size(35, 23));
		((Control)Hd7i()).set_TabIndex(21);
		Hd7i().set_Text("U/l");
		t6D0().set_AutoSize(true);
		((Control)t6D0()).set_Location(new Point(13, 263));
		((Control)t6D0()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)t6D0()).set_Name("lbl_5");
		((Control)t6D0()).set_Size(new Size(144, 23));
		((Control)t6D0()).set_TabIndex(22);
		t6D0().set_Text("Bilirubine Totale");
		p7E5().set_AutoSize(true);
		((Control)p7E5()).set_Location(new Point(13, 352));
		((Control)p7E5()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)p7E5()).set_Name("lbl_6");
		((Control)p7E5()).set_Size(new Size(134, 23));
		((Control)p7E5()).set_TabIndex(23);
		p7E5().set_Text("Proténie Totale");
		q2C6().set_AutoSize(true);
		((Control)q2C6()).set_Location(new Point(401, 358));
		((Control)q2C6()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)q2C6()).set_Name("u_6");
		((Control)q2C6()).set_Size(new Size(33, 23));
		((Control)q2C6()).set_TabIndex(24);
		q2C6().set_Text("g/l");
		q0SY().set_AutoSize(true);
		((Control)q0SY()).set_Location(new Point(397, 256));
		((Control)q0SY()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)q0SY()).set_Name("u_5");
		((Control)q0SY()).set_Size(new Size(60, 23));
		((Control)q0SY()).set_TabIndex(25);
		q0SY().set_Text("mg/dl");
		((Control)Hd1o()).set_BackColor(SystemColors.ButtonHighlight);
		((Control)Hd1o()).get_Controls().Add((Control)(object)Bp5r());
		((Control)Hd1o()).get_Controls().Add((Control)(object)c9Q6());
		((Control)Hd1o()).get_Controls().Add((Control)(object)p4FQ());
		((Control)Hd1o()).get_Controls().Add((Control)(object)i9X4());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Lw9e());
		((Control)Hd1o()).get_Controls().Add((Control)(object)d4H2());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Ts93());
		((Control)Hd1o()).get_Controls().Add((Control)(object)k5S0());
		((Control)Hd1o()).get_Controls().Add((Control)(object)c7G5());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Wn2r());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Ga85());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Nn48());
		((Control)Hd1o()).get_Controls().Add((Control)(object)r7N2());
		((Control)Hd1o()).get_Controls().Add((Control)(object)i1KD());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Dx05());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Bn3y());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Qg0s());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Ej8b());
		((Control)Hd1o()).get_Controls().Add((Control)(object)q6SF());
		((Control)Hd1o()).get_Controls().Add((Control)(object)q0SY());
		((Control)Hd1o()).get_Controls().Add((Control)(object)q2C6());
		((Control)Hd1o()).get_Controls().Add((Control)(object)p7E5());
		((Control)Hd1o()).get_Controls().Add((Control)(object)t6D0());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Hd7i());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Ti9z());
		((Control)Hd1o()).get_Controls().Add((Control)(object)m4HY());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Ri8r());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Kc4g());
		((Control)Hd1o()).get_Controls().Add((Control)(object)k8TF());
		((Control)Hd1o()).get_Controls().Add((Control)(object)w2D6());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Wi76());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Gj56());
		((Control)Hd1o()).get_Controls().Add((Control)(object)Ko17());
		((Control)Hd1o()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Hd1o()).set_Location(new Point(13, 253));
		((Control)Hd1o()).set_Margin(new Padding(4));
		((Control)Hd1o()).set_Name("GroupBox1");
		((Control)Hd1o()).set_Padding(new Padding(4));
		((Control)Hd1o()).set_Size(new Size(1096, 511));
		((Control)Hd1o()).set_TabIndex(33);
		Hd1o().set_TabStop(false);
		Hd1o().set_Text("Résultas");
		((Control)Bp5r()).get_Controls().Add((Control)(object)Jj2i());
		((Control)Bp5r()).set_Font(new Font("Microsoft YaHei UI", 10.8f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)Bp5r()).set_Location(new Point(522, 224));
		((Control)Bp5r()).set_Name("GroupBox3");
		((Control)Bp5r()).set_Size(new Size(548, 210));
		((Control)Bp5r()).set_TabIndex(67);
		Bp5r().set_TabStop(false);
		Bp5r().set_Text("Intérprétation du docteur");
		Jj2i().set_AutoSize(true);
		((Control)Jj2i()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Jj2i()).set_Location(new Point(20, 37));
		((Control)Jj2i()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Jj2i()).set_Name("Label122");
		((Control)Jj2i()).set_Size(new Size(0, 26));
		((Control)Jj2i()).set_TabIndex(46);
		c9Q6().set_AutoSize(true);
		((Control)c9Q6()).set_Location(new Point(383, 468));
		((Control)c9Q6()).set_Name("Label15");
		((Control)c9Q6()).set_Size(new Size(55, 23));
		((Control)c9Q6()).set_TabIndex(66);
		c9Q6().set_Text("None");
		p4FQ().set_AutoSize(true);
		((Control)p4FQ()).set_Font(new Font("Perpetua Titling MT", 12f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)p4FQ()).set_Location(new Point(8, 468));
		((Control)p4FQ()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)p4FQ()).set_Name("Label14");
		((Control)p4FQ()).set_Size(new Size(294, 24));
		((Control)p4FQ()).set_TabIndex(65);
		p4FQ().set_Text("Médiacement Ordonné:");
		i9X4().set_AutoSize(true);
		((Control)i9X4()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)i9X4()).set_Location(new Point(260, 53));
		((Control)i9X4()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)i9X4()).set_Name("l11");
		((Control)i9X4()).set_Size(new Size(89, 26));
		((Control)i9X4()).set_TabIndex(64);
		i9X4().set_Text("[3.4,5.4]");
		Lw9e().set_AutoSize(true);
		((Control)Lw9e()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Lw9e()).set_Location(new Point(260, 263));
		((Control)Lw9e()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Lw9e()).set_Name("l33");
		((Control)Lw9e()).set_Size(new Size(89, 26));
		((Control)Lw9e()).set_TabIndex(63);
		Lw9e().set_Text("[0.3,1.9]");
		d4H2().set_AutoSize(true);
		((Control)d4H2()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)d4H2()).set_Location(new Point(260, 361));
		((Control)d4H2()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)d4H2()).set_Name("l44");
		((Control)d4H2()).set_Size(new Size(79, 26));
		((Control)d4H2()).set_TabIndex(62);
		d4H2().set_Text("[65,80]");
		Ts93().set_AutoSize(true);
		((Control)Ts93()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ts93()).set_Location(new Point(860, 60));
		((Control)Ts93()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ts93()).set_Name("l55");
		((Control)Ts93()).set_Size(new Size(89, 26));
		((Control)Ts93()).set_TabIndex(61);
		Ts93().set_Text("[2.5,7.6]");
		k5S0().set_AutoSize(true);
		((Control)k5S0()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)k5S0()).set_Location(new Point(860, 159));
		((Control)k5S0()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)k5S0()).set_Name("l66");
		((Control)k5S0()).set_Size(new Size(91, 26));
		((Control)k5S0()).set_TabIndex(60);
		k5S0().set_Text("[30,100]");
		c7G5().set_AutoSize(true);
		((Control)c7G5()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)c7G5()).set_Location(new Point(260, 155));
		((Control)c7G5()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)c7G5()).set_Name("l22");
		((Control)c7G5()).set_Size(new Size(67, 26));
		((Control)c7G5()).set_TabIndex(57);
		c7G5().set_Text("[7,13]");
		Wn2r().set_AutoSize(true);
		((Control)Wn2r()).set_Font(new Font("Microsoft YaHei UI", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Wn2r()).set_Location(new Point(227, 150));
		((Control)Wn2r()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Wn2r()).set_Name("Label22");
		((Control)Wn2r()).set_Size(new Size(25, 31));
		((Control)Wn2r()).set_TabIndex(56);
		Wn2r().set_Text("/");
		Ga85().set_AutoSize(true);
		((Control)Ga85()).set_Font(new Font("Microsoft YaHei UI", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ga85()).set_Location(new Point(227, 256));
		((Control)Ga85()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ga85()).set_Name("Label21");
		((Control)Ga85()).set_Size(new Size(25, 31));
		((Control)Ga85()).set_TabIndex(55);
		Ga85().set_Text("/");
		Nn48().set_AutoSize(true);
		((Control)Nn48()).set_Font(new Font("Microsoft YaHei UI", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Nn48()).set_Location(new Point(227, 356));
		((Control)Nn48()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Nn48()).set_Name("Label20");
		((Control)Nn48()).set_Size(new Size(25, 31));
		((Control)Nn48()).set_TabIndex(54);
		Nn48().set_Text("/");
		r7N2().set_AutoSize(true);
		((Control)r7N2()).set_Font(new Font("Microsoft YaHei UI", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)r7N2()).set_Location(new Point(805, 52));
		((Control)r7N2()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)r7N2()).set_Name("Label19");
		((Control)r7N2()).set_Size(new Size(25, 31));
		((Control)r7N2()).set_TabIndex(53);
		r7N2().set_Text("/");
		i1KD().set_AutoSize(true);
		((Control)i1KD()).set_Font(new Font("Microsoft YaHei UI", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)i1KD()).set_Location(new Point(805, 153));
		((Control)i1KD()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)i1KD()).set_Name("Label18");
		((Control)i1KD()).set_Size(new Size(25, 31));
		((Control)i1KD()).set_TabIndex(52);
		i1KD().set_Text("/");
		Dx05().set_AutoSize(true);
		((Control)Dx05()).set_Font(new Font("Microsoft YaHei UI", 14.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Dx05()).set_Location(new Point(227, 53));
		((Control)Dx05()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Dx05()).set_Name("Label12");
		((Control)Dx05()).set_Size(new Size(25, 31));
		((Control)Dx05()).set_TabIndex(47);
		Dx05().set_Text("/");
		Bn3y().set_AutoSize(true);
		((Control)Bn3y()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Bn3y()).set_Location(new Point(728, 150));
		((Control)Bn3y()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Bn3y()).set_Name("L6");
		((Control)Bn3y()).set_Size(new Size(30, 26));
		((Control)Bn3y()).set_TabIndex(42);
		Bn3y().set_Text("l7");
		Qg0s().set_AutoSize(true);
		((Control)Qg0s()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Qg0s()).set_Location(new Point(728, 53));
		((Control)Qg0s()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Qg0s()).set_Name("l5");
		((Control)Qg0s()).set_Size(new Size(30, 26));
		((Control)Qg0s()).set_TabIndex(43);
		Qg0s().set_Text("l5");
		Ej8b().set_AutoSize(true);
		((Control)Ej8b()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ej8b()).set_Location(new Point(189, 356));
		((Control)Ej8b()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ej8b()).set_Name("l4");
		((Control)Ej8b()).set_Size(new Size(30, 26));
		((Control)Ej8b()).set_TabIndex(44);
		Ej8b().set_Text("l4");
		q6SF().set_AutoSize(true);
		((Control)q6SF()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)q6SF()).set_Location(new Point(189, 261));
		((Control)q6SF()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)q6SF()).set_Name("l3");
		((Control)q6SF()).set_Size(new Size(30, 26));
		((Control)q6SF()).set_TabIndex(45);
		q6SF().set_Text("l3");
		Ti9z().set_AutoSize(true);
		((Control)Ti9z()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ti9z()).set_Location(new Point(189, 155));
		((Control)Ti9z()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ti9z()).set_Name("l2");
		((Control)Ti9z()).set_Size(new Size(30, 26));
		((Control)Ti9z()).set_TabIndex(36);
		Ti9z().set_Text("l2");
		m4HY().set_AutoSize(true);
		((Control)m4HY()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)m4HY()).set_Location(new Point(189, 55));
		((Control)m4HY()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)m4HY()).set_Name("l1");
		((Control)m4HY()).set_Size(new Size(30, 26));
		((Control)m4HY()).set_TabIndex(37);
		m4HY().set_Text("l1");
		Wm54().set_AutoSize(true);
		((Control)Wm54()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Wm54()).set_Location(new Point(555, 110));
		((Control)Wm54()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Wm54()).set_Name("lbl_nom");
		((Control)Wm54()).set_Size(new Size(89, 26));
		((Control)Wm54()).set_TabIndex(34);
		Wm54().set_Text("lbl_nom");
		Hk58().set_AutoSize(true);
		((Control)Hk58()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Hk58()).set_Location(new Point(555, 164));
		((Control)Hk58()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Hk58()).set_Name("lbl_prenom");
		((Control)Hk58()).set_Size(new Size(121, 26));
		((Control)Hk58()).set_TabIndex(35);
		Hk58().set_Text("lbl_prénom");
		j5G9().set_AutoSize(true);
		((Control)j5G9()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)j5G9()).set_Location(new Point(555, 225));
		((Control)j5G9()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)j5G9()).set_Name("lbl_analyse");
		((Control)j5G9()).set_Size(new Size(117, 26));
		((Control)j5G9()).set_TabIndex(38);
		j5G9().set_Text("lbl_analyse");
		n4K9().set_AutoSize(true);
		((Control)n4K9()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)n4K9()).set_Location(new Point(938, 103));
		((Control)n4K9()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)n4K9()).set_Name("lbl_nume");
		((Control)n4K9()).set_Size(new Size(89, 26));
		((Control)n4K9()).set_TabIndex(40);
		n4K9().set_Text("lbl_date");
		Tf83().set_AutoSize(true);
		((Control)Tf83()).set_Font(new Font("Microsoft YaHei UI", 11.25f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Tf83()).set_Location(new Point(932, 175));
		((Control)Tf83()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Tf83()).set_Name("lbl_date");
		((Control)Tf83()).set_Size(new Size(140, 26));
		((Control)Tf83()).set_TabIndex(41);
		Tf83().set_Text("lbl_numvisite");
		((ButtonBase)Mf7z()).set_FlatStyle((FlatStyle)1);
		((Control)Mf7z()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Mf7z()).set_Location(new Point(560, 771));
		((Control)Mf7z()).set_Margin(new Padding(4));
		((Control)Mf7z()).set_Name("Button1");
		((Control)Mf7z()).set_Size(new Size(249, 47));
		((Control)Mf7z()).set_TabIndex(42);
		((ButtonBase)Mf7z()).set_Text("Retour");
		((ButtonBase)Mf7z()).set_UseVisualStyleBackColor(true);
		((ButtonBase)j7X2()).set_FlatStyle((FlatStyle)1);
		((Control)j7X2()).set_Location(new Point(894, 771));
		((Control)j7X2()).set_Margin(new Padding(4));
		((Control)j7X2()).set_Name("Button2");
		((Control)j7X2()).set_Size(new Size(249, 47));
		((Control)j7X2()).set_TabIndex(43);
		((ButtonBase)j7X2()).set_Text("Génerer un fichier pdf");
		((ButtonBase)j7X2()).set_UseVisualStyleBackColor(true);
		((ButtonBase)s5B7()).set_FlatStyle((FlatStyle)0);
		((Control)s5B7()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)s5B7()).set_ForeColor(Color.White);
		((Control)s5B7()).set_Location(new Point(1480, 13));
		((Control)s5B7()).set_Margin(new Padding(4));
		((Control)s5B7()).set_Name("Button10");
		((Control)s5B7()).set_Size(new Size(56, 62));
		((Control)s5B7()).set_TabIndex(44);
		((ButtonBase)s5B7()).set_UseVisualStyleBackColor(true);
		((ButtonBase)e7DF()).set_FlatStyle((FlatStyle)1);
		((Control)e7DF()).set_Location(new Point(262, 772));
		((Control)e7DF()).set_Margin(new Padding(4));
		((Control)e7DF()).set_Name("Button3");
		((Control)e7DF()).set_Size(new Size(249, 47));
		((Control)e7DF()).set_TabIndex(45);
		((ButtonBase)e7DF()).set_Text("Acceuil");
		((ButtonBase)e7DF()).set_UseVisualStyleBackColor(true);
		((Control)Dd8e()).set_Location(new Point(895, 220));
		((Control)Dd8e()).set_Margin(new Padding(4));
		((Control)Dd8e()).set_Name("txt_id");
		((Control)Dd8e()).set_Size(new Size(132, 22));
		((Control)Dd8e()).set_TabIndex(46);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ButtonHighlight);
		((Form)this).set_ClientSize(new Size(1551, 845));
		((Control)this).get_Controls().Add((Control)(object)Dd8e());
		((Control)this).get_Controls().Add((Control)(object)e7DF());
		((Control)this).get_Controls().Add((Control)(object)s5B7());
		((Control)this).get_Controls().Add((Control)(object)j7X2());
		((Control)this).get_Controls().Add((Control)(object)Mf7z());
		((Control)this).get_Controls().Add((Control)(object)Tf83());
		((Control)this).get_Controls().Add((Control)(object)n4K9());
		((Control)this).get_Controls().Add((Control)(object)j5G9());
		((Control)this).get_Controls().Add((Control)(object)Hk58());
		((Control)this).get_Controls().Add((Control)(object)Wm54());
		((Control)this).get_Controls().Add((Control)(object)Hd1o());
		((Control)this).get_Controls().Add((Control)(object)Kg87());
		((Control)this).get_Controls().Add((Control)(object)q7M2());
		((Control)this).get_Controls().Add((Control)(object)Qq27());
		((Control)this).get_Controls().Add((Control)(object)Pt0w());
		((Control)this).get_Controls().Add((Control)(object)Kr4m());
		((Control)this).get_Controls().Add((Control)(object)Xm78());
		((Control)this).get_Controls().Add((Control)(object)Fy9e());
		((Control)this).get_Controls().Add((Control)(object)y1QG());
		((Control)this).get_Controls().Add((Control)(object)k6WY());
		((Control)this).get_Controls().Add((Control)(object)De8q());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("Form9");
		((Form)this).set_Text("Form9");
		((ISupportInitialize)y1QG()).EndInit();
		((ISupportInitialize)k6WY()).EndInit();
		((Control)Qq27()).ResumeLayout(false);
		((Control)Qq27()).PerformLayout();
		((Control)Hd1o()).ResumeLayout(false);
		((Control)Hd1o()).PerformLayout();
		((Control)Bp5r()).ResumeLayout(false);
		((Control)Bp5r()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label De8q()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f2J9(Label Cy9t)
	{
		EventHandler eventHandler = f3R5;
		Label b = B;
		if (b != null)
		{
			((Control)b).remove_Click(eventHandler);
		}
		Label val = (B = Cy9t);
		b = B;
		if (b != null)
		{
			((Control)b).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox k6WY()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d7Q8(PictureBox g1FS)
	{
		_PictureBox1 = g1FS;
	}

	[SpecialName]
	internal virtual PictureBox y1QG()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7B1(PictureBox Lj60)
	{
		PictureBox val = (e = Lj60);
	}

	[SpecialName]
	internal virtual Label Fy9e()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ei97(Label Aq78)
	{
		Label val = (i = Aq78);
	}

	[SpecialName]
	internal virtual Label Xm78()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hq6z(Label d3MX)
	{
		_Label3 = d3MX;
	}

	[SpecialName]
	internal virtual Label Kr4m()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qj2g(Label Dg3p)
	{
		_Label4 = Dg3p;
	}

	[SpecialName]
	internal virtual Label Pt0w()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8EJ(Label Eo3w)
	{
		_Label5 = Eo3w;
	}

	[SpecialName]
	internal virtual GroupBox Qq27()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d8QL(GroupBox Ma10)
	{
		GroupBox val = (a = Ma10);
	}

	[SpecialName]
	internal virtual Label b5PW()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5M4(Label c5B8)
	{
		_Label9 = c5B8;
	}

	[SpecialName]
	internal virtual Label q9MZ()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Py8o(Label t1WZ)
	{
		_Label8 = t1WZ;
	}

	[SpecialName]
	internal virtual Label r0RC()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wi19(Label Fg70)
	{
		Label val = (r = Fg70);
	}

	[SpecialName]
	internal virtual Label g1P2()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hc0e(Label Xj8a)
	{
		Label val = (y = Xj8a);
	}

	[SpecialName]
	internal virtual Label a2YJ()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z6P0(Label z6J3)
	{
		Label val = (H = z6J3);
	}

	[SpecialName]
	internal virtual Label n5KG()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0XN(Label t3QS)
	{
		Label val = (U = t3QS);
	}

	[SpecialName]
	internal virtual Label q7M2()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d3E4(Label Tb7w)
	{
		Label val = (m = Tb7w);
	}

	[SpecialName]
	internal virtual Label Kg87()
	{
		return _Label13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ne70(Label w4Z7)
	{
		_Label13 = w4Z7;
	}

	[SpecialName]
	internal virtual Label Ko17()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b3WJ(Label Nn78)
	{
		Label val = (f = Nn78);
	}

	[SpecialName]
	internal virtual Label Gj56()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jw45(Label Fn3w)
	{
		Label val = (N = Fn3w);
	}

	[SpecialName]
	internal virtual Label Wi76()
	{
		return _lbl_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x5Y4(Label Ny79)
	{
		_lbl_2 = Ny79;
	}

	[SpecialName]
	internal virtual Label w2D6()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qe56(Label b8LG)
	{
		Label val = (O = b8LG);
	}

	[SpecialName]
	internal virtual Label k8TF()
	{
		return _lbl_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g9PN(Label m0P4)
	{
		_lbl_3 = m0P4;
	}

	[SpecialName]
	internal virtual Label Kc4g()
	{
		return _u_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2B0(Label b7SY)
	{
		_u_3 = b7SY;
	}

	[SpecialName]
	internal virtual Label Ri8r()
	{
		return _lbl_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6K5(Label Wk1f)
	{
		_lbl_4 = Wk1f;
	}

	[SpecialName]
	internal virtual Label Hd7i()
	{
		return _u_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bj1a(Label Fs9r)
	{
		_u_4 = Fs9r;
	}

	[SpecialName]
	internal virtual Label t6D0()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w0W7(Label a6E3)
	{
		Label val = (K = a6E3);
	}

	[SpecialName]
	internal virtual Label p7E5()
	{
		return _lbl_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hp3w(Label r7EA)
	{
		_lbl_6 = r7EA;
	}

	[SpecialName]
	internal virtual Label q2C6()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lm8r(Label z4N5)
	{
		Label val = (V = z4N5);
	}

	[SpecialName]
	internal virtual Label q0SY()
	{
		return _u_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xd0g(Label p9A7)
	{
		_u_5 = p9A7;
	}

	[SpecialName]
	internal virtual GroupBox Hd1o()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zz98(GroupBox Xw6f)
	{
		EventHandler eventHandler = Sa09;
		GroupBox val = w;
		if (val != null)
		{
			((Control)val).remove_Enter(eventHandler);
		}
		GroupBox val2 = (w = Xw6f);
		val = w;
		if (val != null)
		{
			((Control)val).add_Enter(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Xw83()
	{
		return _lbl_maladie;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kr1y(Label Yy9a)
	{
		_lbl_maladie = Yy9a;
	}

	[SpecialName]
	internal virtual Label x0M2()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4G9(Label n9Q0)
	{
		Label val = (P = n9Q0);
	}

	[SpecialName]
	internal virtual Label Lb27()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cg05(Label Gs83)
	{
		Label val = (j = Gs83);
	}

	[SpecialName]
	internal virtual Label b0RS()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ji3e(Label g0ZA)
	{
		Label val = (T = g0ZA);
	}

	[SpecialName]
	internal virtual Label Kk24()
	{
		return _lbl_temperature;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ns2n(Label Sj30)
	{
		_lbl_temperature = Sj30;
	}

	[SpecialName]
	internal virtual Label o0A5()
	{
		return _lbl_age;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ls20(Label Zt7j)
	{
		_lbl_age = Zt7j;
	}

	[SpecialName]
	internal virtual Label Jj2i()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Td1n(Label k3X9)
	{
		Label val = (s = k3X9);
	}

	[SpecialName]
	internal virtual Label Bn3y()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5MG(Label w9P6)
	{
		Label val = (G = w9P6);
	}

	[SpecialName]
	internal virtual Label Qg0s()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ro3g(Label Bz81)
	{
		Label val = (X = Bz81);
	}

	[SpecialName]
	internal virtual Label Ej8b()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ek40(Label a1R4)
	{
		Label val = (d = a1R4);
	}

	[SpecialName]
	internal virtual Label q6SF()
	{
		return _l3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yt90(Label Hw8a)
	{
		_l3 = Hw8a;
	}

	[SpecialName]
	internal virtual Label Ti9z()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m6C1(Label Gx3a)
	{
		Label val = (C = Gx3a);
	}

	[SpecialName]
	internal virtual Label m4HY()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2SK(Label Nq43)
	{
		Label val = (l = Nq43);
	}

	[SpecialName]
	internal virtual Label Wm54()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mt70(Label Ds67)
	{
		Label val = (Q = Ds67);
	}

	[SpecialName]
	internal virtual Label Hk58()
	{
		return Z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eg02(Label o0D5)
	{
		Label val = (Z = o0D5);
	}

	[SpecialName]
	internal virtual Label j5G9()
	{
		return _lbl_analyse;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jk8i(Label Sx7o)
	{
		_lbl_analyse = Sx7o;
	}

	[SpecialName]
	internal virtual Label n4K9()
	{
		return eB;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aa1t(Label Dn6x)
	{
		Label val = (eB = Dn6x);
	}

	[SpecialName]
	internal virtual Label Tf83()
	{
		return _lbl_date;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6S7(Label Sd06)
	{
		_lbl_date = Sd06;
	}

	[SpecialName]
	internal virtual Button Mf7z()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void To79(Button g7Q0)
	{
		EventHandler eventHandler = Pk7o;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = g7Q0;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button j7X2()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fg4t(Button a3RE)
	{
		_Button2 = a3RE;
	}

	[SpecialName]
	internal virtual Button s5B7()
	{
		return _Button10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r5M6(Button Jb89)
	{
		EventHandler eventHandler = x1D5;
		Button button = _Button10;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button10 = Jb89;
		button = _Button10;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button e7DF()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ar30(Button s7NJ)
	{
		EventHandler eventHandler = p0WM;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = s7NJ;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Dd8e()
	{
		return _txt_id;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8B6(TextBox x8J4)
	{
		_txt_id = x8J4;
	}

	[SpecialName]
	internal virtual Label i9X4()
	{
		return ee;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e9HZ(Label Gy26)
	{
		Label val = (ee = Gy26);
	}

	[SpecialName]
	internal virtual Label Lw9e()
	{
		return ei;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4J1(Label Ap1n)
	{
		Label val = (ei = Ap1n);
	}

	[SpecialName]
	internal virtual Label d4H2()
	{
		return _l44;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dz0r(Label Jn28)
	{
		_l44 = Jn28;
	}

	[SpecialName]
	internal virtual Label Ts93()
	{
		return _l55;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cn6p(Label Ai9p)
	{
		_l55 = Ai9p;
	}

	[SpecialName]
	internal virtual Label k5S0()
	{
		return _l66;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5S3(Label Mf06)
	{
		_l66 = Mf06;
	}

	[SpecialName]
	internal virtual Label c7G5()
	{
		return ea;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b1DA(Label e9Q1)
	{
		Label val = (ea = e9Q1);
	}

	[SpecialName]
	internal virtual Label Wn2r()
	{
		return _Label22;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bi02(Label Lw07)
	{
		_Label22 = Lw07;
	}

	[SpecialName]
	internal virtual Label Ga85()
	{
		return er;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m0RX(Label Lo9g)
	{
		Label val = (er = Lo9g);
	}

	[SpecialName]
	internal virtual Label Nn48()
	{
		return _Label20;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mc75(Label Ra6t)
	{
		_Label20 = Ra6t;
	}

	[SpecialName]
	internal virtual Label r7N2()
	{
		return _Label19;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hm1c(Label f5ZN)
	{
		_Label19 = f5ZN;
	}

	[SpecialName]
	internal virtual Label i1KD()
	{
		return _Label18;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zq84(Label n5DW)
	{
		_Label18 = n5DW;
	}

	[SpecialName]
	internal virtual Label Dx05()
	{
		return ey;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k9X1(Label s9Q0)
	{
		Label val = (ey = s9Q0);
	}

	[SpecialName]
	internal virtual GroupBox Bp5r()
	{
		return eH;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k4P1(GroupBox Cc05)
	{
		GroupBox val = (eH = Cc05);
	}

	[SpecialName]
	internal virtual Label c9Q6()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2CH(Label Fc17)
	{
		_Label15 = Fc17;
	}

	[SpecialName]
	internal virtual Label p4FQ()
	{
		return _Label14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o8GP(Label d1Q7)
	{
		_Label14 = d1Q7;
	}

	private void p0WM(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Cx0()).Show();
		((Form)this).Close();
	}

	private void x1D5(object sender, EventArgs e)
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

	private void Lj2d(object sender, EventArgs e)
	{
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023f: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d5: Expected O, but got Unknown
		//IL_0669: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_0885: Unknown result type (might be due to invalid IL or missing references)
		Wm54().set_Text(Qm5.Forms.s7W().Lc4t().get_Text());
		Hk58().set_Text(Qm5.Forms.s7W().Tj14().get_Text());
		Tf83().set_Text(Qm5.Forms.Mn2().Ax5r().get_Text());
		n4K9().set_Text(Qm5.Forms.s7W().Wk9s().get_Text());
		Dd8e().set_Text(Qm5.Forms.s7W().y9TX().get_Text());
		Jj2i().set_Text(Qm5.Forms.Xp1().Tb1w().get_Text());
		j5G9().set_Text(Qm5.Forms.Xp1().Wt51().get_Text());
		((Control)Dd8e()).set_Visible(false);
		Tf83().set_Text(Conversions.ToString(Qm5.Forms.s7W().Hg49().get_Value()));
		o0A5().set_Text(Qm5.Forms.Xp1().a5YL().get_Text());
		Xw83().set_Text(Qm5.Forms.Xp1().t2LC().get_Text());
		b0RS().set_Text(Qm5.Forms.Xp1().b6CW().get_Text());
		x0M2().set_Text(Qm5.Forms.Xp1().w5MS().get_Text());
		Kk24().set_Text(Qm5.Forms.Xp1().d7W3().get_Text());
		Lb27().set_Text(Qm5.Forms.Xp1().Kn2a().get_Text());
		c9Q6().set_Text(Qm5.Forms.Xp1().m0MT().get_Text());
		double num = Conversions.ToDouble(Dd8e().get_Text());
		if (Operators.CompareString(j5G9().get_Text(), "Bilan sanguin", false) == 0)
		{
			string text = "select * from Sang where ID_Patient =  " + Conversions.ToString(num) + " ";
			try
			{
				oConnection.Open();
				OleDbCommand val = new OleDbCommand(text, oConnection);
				OleDbDataReader val2 = val.ExecuteReader();
				while (val2.Read())
				{
					m4HY().set_Text(val2.GetString(0));
					Ti9z().set_Text(val2.GetString(1));
					q6SF().set_Text(val2.GetString(2));
					Ej8b().set_Text(val2.GetString(3));
					Qg0s().set_Text(val2.GetString(4));
					Bn3y().set_Text(val2.GetString(5));
				}
				Interaction.MsgBox((object)Bn3y().get_Text(), (MsgBoxStyle)0, (object)null);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		if (Operators.CompareString(j5G9().get_Text(), "Bilan hépatique", false) == 0)
		{
			string text2 = "select * from Hypatique where ID_Patient = " + Conversions.ToString(num) + "  ";
			Ko17().set_Text("Albumine");
			Wi76().set_Text("INR");
			k8TF().set_Text("Bilirubine");
			Ri8r().set_Text("Encéphalopathie");
			((Control)p7E5()).set_Visible(false);
			t6D0().set_Text("Aciste");
			((Control)p7E5()).set_Visible(false);
			i9X4().set_Text("[3.4,5.4]");
			c7G5().set_Text("[0.8,2]");
			Lw9e().set_Text("[10,12]");
			d4H2().set_Text("[10,50]");
			Ts93().set_Text("[5,11]");
			try
			{
				oConnection.Open();
				OleDbCommand val3 = new OleDbCommand(text2, oConnection);
				OleDbDataReader val4 = val3.ExecuteReader();
				while (val4.Read())
				{
					m4HY().set_Text(val4.GetString(0));
					Ti9z().set_Text(val4.GetString(1));
					q6SF().set_Text(val4.GetString(2));
					Ej8b().set_Text(val4.GetString(3));
					Qg0s().set_Text(val4.GetString(4));
				}
				oConnection.Close();
				return;
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox((object)ex4.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(j5G9().get_Text(), "Glycémie", false) == 0)
		{
			string text3 = "select * from Glycémie where ID_Patient = " + Conversions.ToString(num) + "  ";
			Ko17().set_Text("Triglycérides");
			Wi76().set_Text("INR");
			k8TF().set_Text("Choléstérol LDL");
			Ri8r().set_Text("Choléstérol HDL");
			Hd7i().set_Text("mmol/l");
			((Control)p7E5()).set_Visible(false);
			t6D0().set_Text("Choléstérol Total");
			((Control)p7E5()).set_Visible(false);
			((Control)q2C6()).set_Visible(false);
			i9X4().set_Text("< 1.5");
			c7G5().set_Text("[0.8,2]");
			Lw9e().set_Text("< 1.6");
			k5S0().set_Text("> 0.4");
			Ts93().set_Text("[5,11]");
			((Control)d4H2()).set_Visible(false);
			((Control)Ej8b()).set_Visible(false);
			try
			{
				oConnection.Open();
				OleDbCommand val5 = new OleDbCommand(text3, oConnection);
				OleDbDataReader val6 = val5.ExecuteReader();
				while (val6.Read())
				{
					m4HY().set_Text(val6.GetString(0));
					Ti9z().set_Text(val6.GetString(1));
					q6SF().set_Text(val6.GetString(2));
					Bn3y().set_Text(val6.GetString(3));
					Qg0s().set_Text(val6.GetString(4));
				}
				oConnection.Close();
				return;
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				Interaction.MsgBox((object)ex6.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(j5G9().get_Text(), "Hematologie", false) != 0)
		{
			return;
		}
		string text4 = "select * from  Hematologie where ID_Patient = " + Conversions.ToString(num) + "  ";
		Ko17().set_Text("Hémaglobie");
		Wi76().set_Text("Hémathie");
		k8TF().set_Text("Hématocrite");
		Ri8r().set_Text("VGM");
		Hd7i().set_Text("fl");
		Gj56().set_Text("G/I");
		Kc4g().set_Text("%");
		q0SY().set_Text("pg");
		w2D6().set_Text("T/I");
		((Control)p7E5()).set_Visible(false);
		t6D0().set_Text("TGHM");
		((Control)p7E5()).set_Visible(false);
		((Control)q2C6()).set_Visible(false);
		i9X4().set_Text("[4,10]");
		c7G5().set_Text("[3,5]");
		Lw9e().set_Text("[30,40]");
		k5S0().set_Text("[80,100]");
		Ts93().set_Text("[27,32]");
		((Control)d4H2()).set_Visible(false);
		((Control)Ej8b()).set_Visible(false);
		try
		{
			oConnection.Open();
			OleDbCommand val7 = new OleDbCommand(text4, oConnection);
			OleDbDataReader val8 = val7.ExecuteReader();
			while (val8.Read())
			{
				m4HY().set_Text(val8.GetString(0));
				Ti9z().set_Text(val8.GetString(1));
				q6SF().set_Text(val8.GetString(2));
				Bn3y().set_Text(val8.GetString(3));
				Qg0s().set_Text(val8.GetString(4));
			}
			oConnection.Close();
		}
		catch (Exception ex7)
		{
			ProjectData.SetProjectError(ex7);
			Exception ex8 = ex7;
			Interaction.MsgBox((object)ex8.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static void d8R7(string Tk3r)
	{
		MethodInfo method = ((Type)j8Y.mDic[j8Y.T]).GetMethod(Tk3r);
		method.Invoke(null, new object[0]);
	}

	private void Pk7o(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Xp1()).Show();
		((Form)this).Close();
	}

	private void f3R5(object sender, EventArgs e)
	{
	}

	private void Sa09(object sender, EventArgs e)
	{
	}
}
