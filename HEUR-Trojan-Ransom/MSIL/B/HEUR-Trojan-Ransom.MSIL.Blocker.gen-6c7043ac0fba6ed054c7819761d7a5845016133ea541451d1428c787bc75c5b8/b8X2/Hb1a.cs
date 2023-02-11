using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ac42;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Tm8;
using o3C;

namespace b8X2;

[DesignerGenerated]
public class Hb1a : Form
{
	private Panel _Panel1;

	private PictureBox _PictureBox1;

	private Panel _Panel4;

	private Button _Button4;

	private Button _Button2;

	private Button _Button7;

	private Panel _Panel3;

	private Label _u_5;

	private Label _u_6;

	private Label _lbl_5;

	private Label _u_4;

	private Label _u_3;

	private Label _lbl_3;

	private Label _u_2;

	private Label _lbl_2;

	private Label _u_1;

	private TextBox _txt_5;

	private TextBox _txt_6;

	private TextBox _txt_Analyse;

	private TextBox _txt_Patient;

	private Label _Label3;

	private Label _Label2;

	private Label _Label1;

	private TextBox _txt_Age;

	private Label _Label9;

	private Label _Label8;

	private Label _Label7;

	private Label _Label5;

	private TextBox _txt_Montant;

	private Button _Button11;

	private TextBox _txt_ID;

	private Button _Button15;

	private RadioButton _RadioButton1;

	private RadioButton _RadioButton2;

	private TextBox _txt_consult;

	private OleDbConnection oConnection;

	internal IContainer a;

	internal Button K;

	internal Button E;

	internal Button T;

	internal Panel r;

	internal Button C;

	internal Button n;

	internal Button j;

	internal GroupBox G;

	internal Button b;

	internal Label d;

	internal Label W;

	internal Label P;

	internal TextBox u;

	internal TextBox M;

	internal TextBox V;

	internal TextBox O;

	internal TextBox f;

	internal GroupBox Q;

	internal TextBox y;

	internal TextBox i;

	internal TextBox H;

	internal TextBox s;

	internal TextBox x;

	internal Label L;

	internal Label z;

	internal Label Ka;

	internal Label KK;

	internal Button KE;

	internal Button KT;

	internal Button Kr;

	internal Button KC;

	internal Button Kn;

	internal string Kj;

	public Hb1a()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)d2AJ);
		string text = (Kj = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\moham\\Desktop\\Base_Patient.mdb");
		oConnection = new OleDbConnection(Kj);
		Pq36();
	}

	protected override void o1F7(bool t1E4)
	{
		try
		{
			if (t1E4 && a != null)
			{
				a.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t1E4);
		}
	}

	private void Pq36()
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
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b3: Expected O, but got Unknown
		//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f4: Expected O, but got Unknown
		//IL_0632: Unknown result type (might be due to invalid IL or missing references)
		//IL_06aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b4: Expected O, but got Unknown
		//IL_06f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0774: Expected O, but got Unknown
		//IL_07b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0834: Expected O, but got Unknown
		//IL_0872: Unknown result type (might be due to invalid IL or missing references)
		//IL_090e: Unknown result type (might be due to invalid IL or missing references)
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected O, but got Unknown
		//IL_09a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a15: Expected O, but got Unknown
		//IL_0a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab6: Expected O, but got Unknown
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Expected O, but got Unknown
		//IL_0b88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eef: Expected O, but got Unknown
		//IL_0f13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f37: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fad: Expected O, but got Unknown
		//IL_0fe1: Unknown result type (might be due to invalid IL or missing references)
		//IL_105a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1064: Expected O, but got Unknown
		//IL_1095: Unknown result type (might be due to invalid IL or missing references)
		//IL_110e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected O, but got Unknown
		//IL_114c: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1241: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1337: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1430: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1526: Unknown result type (might be due to invalid IL or missing references)
		//IL_159d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1618: Unknown result type (might be due to invalid IL or missing references)
		//IL_1693: Unknown result type (might be due to invalid IL or missing references)
		//IL_170e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1786: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1857: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_191b: Unknown result type (might be due to invalid IL or missing references)
		//IL_197d: Unknown result type (might be due to invalid IL or missing references)
		//IL_19de: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bd9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cc3: Expected O, but got Unknown
		//IL_1cf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eda: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f50: Expected O, but got Unknown
		//IL_1f84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ffd: Unknown result type (might be due to invalid IL or missing references)
		//IL_2007: Expected O, but got Unknown
		//IL_2038: Unknown result type (might be due to invalid IL or missing references)
		//IL_20b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2112: Unknown result type (might be due to invalid IL or missing references)
		//IL_2174: Unknown result type (might be due to invalid IL or missing references)
		//IL_21d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2234: Unknown result type (might be due to invalid IL or missing references)
		//IL_228f: Unknown result type (might be due to invalid IL or missing references)
		//IL_22f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_2376: Unknown result type (might be due to invalid IL or missing references)
		//IL_23ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_2464: Unknown result type (might be due to invalid IL or missing references)
		//IL_24de: Unknown result type (might be due to invalid IL or missing references)
		//IL_2552: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_261d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2627: Expected O, but got Unknown
		//IL_264b: Unknown result type (might be due to invalid IL or missing references)
		//IL_26b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_26c2: Expected O, but got Unknown
		//IL_26f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2759: Unknown result type (might be due to invalid IL or missing references)
		//IL_2763: Expected O, but got Unknown
		//IL_2787: Unknown result type (might be due to invalid IL or missing references)
		//IL_27f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_27fb: Expected O, but got Unknown
		//IL_282f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b38: Unknown result type (might be due to invalid IL or missing references)
		m9M2(new Panel());
		Gx6i(new PictureBox());
		Tc07(new Button());
		e0AB(new Panel());
		i0SH(new Button());
		p5QC(new Button());
		o7G4(new Button());
		Kr1t(new Button());
		Xc6m(new Panel());
		r8H1(new Button());
		p0DG(new Button());
		Jz3w(new Button());
		d6DK(new Button());
		i7ZH(new Panel());
		Hq85(new GroupBox());
		i8N2(new Button());
		o1BY(new Button());
		Fo6e(new Button());
		Qm4j(new TextBox());
		y1M7(new Label());
		e1WC(new Label());
		Pm3f(new Label());
		Qn9d(new Label());
		x1P3(new Label());
		Rj3d(new Label());
		Ge5x(new Label());
		s5Y7(new Label());
		Lj8s(new Label());
		Pr5a(new Label());
		w1P2(new Label());
		c9XH(new Label());
		e8W9(new TextBox());
		q7NP(new TextBox());
		Lr0w(new TextBox());
		i7LX(new TextBox());
		n5GX(new TextBox());
		x7FD(new TextBox());
		Pn2k(new TextBox());
		Ge2t(new TextBox());
		Jn82(new TextBox());
		Te4n(new Label());
		b2A8(new Label());
		p1T4(new Label());
		Tr62(new Button());
		No7a(new GroupBox());
		x8K3(new Button());
		Lj24(new Button());
		f8RA(new TextBox());
		Xd6m(new TextBox());
		t0Q3(new TextBox());
		z7K8(new TextBox());
		Nt73(new TextBox());
		m7C2(new TextBox());
		Ck40(new Label());
		Ma6b(new Label());
		w7QT(new Label());
		c4PF(new Label());
		z3H5(new Label());
		e3C4(new Label());
		Sx70(new TextBox());
		g4Q0(new Label());
		x4K5(new Button());
		Eb08(new Label());
		s0GR(new Button());
		r1J5(new RadioButton());
		Lt90(new RadioButton());
		Gx4o(new TextBox());
		((Control)c4S9()).SuspendLayout();
		((ISupportInitialize)Gd38()).BeginInit();
		((Control)o9LE()).SuspendLayout();
		((Control)p3P0()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)c4S9()).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)c4S9()).get_Controls().Add((Control)(object)Gd38());
		((Control)c4S9()).get_Controls().Add((Control)(object)m8TR());
		((Control)c4S9()).get_Controls().Add((Control)(object)Ca6r());
		((Control)c4S9()).get_Controls().Add((Control)(object)m0S9());
		((Control)c4S9()).get_Controls().Add((Control)(object)Nb6j());
		((Control)c4S9()).get_Controls().Add((Control)(object)g8J9());
		((Control)c4S9()).get_Controls().Add((Control)(object)Zt38());
		((Control)c4S9()).set_Dock((DockStyle)3);
		((Control)c4S9()).set_Location(new Point(0, 0));
		((Control)c4S9()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)c4S9()).set_Name("Panel1");
		((Control)c4S9()).set_Size(new Size(237, 775));
		((Control)c4S9()).set_TabIndex(3);
		((Control)Gd38()).set_Location(new Point(65, 37));
		((Control)Gd38()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Gd38()).set_Name("PictureBox1");
		((Control)Gd38()).set_Size(new Size(92, 86));
		Gd38().set_TabIndex(15);
		Gd38().set_TabStop(false);
		((ButtonBase)m8TR()).set_FlatStyle((FlatStyle)1);
		((Control)m8TR()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)m8TR()).set_ForeColor(Color.White);
		((ButtonBase)m8TR()).set_ImageAlign((ContentAlignment)16);
		((Control)m8TR()).set_Location(new Point(16, 153));
		((Control)m8TR()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)m8TR()).set_Name("Button1");
		((Control)m8TR()).set_Size(new Size(267, 62));
		((Control)m8TR()).set_TabIndex(9);
		((ButtonBase)m8TR()).set_Text("Accueil");
		((ButtonBase)m8TR()).set_UseVisualStyleBackColor(true);
		((Control)Ca6r()).set_BackColor(Color.FromArgb(0, 192, 0));
		((Control)Ca6r()).set_ForeColor(Color.Red);
		((Control)Ca6r()).set_Location(new Point(3, 377));
		((Control)Ca6r()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Ca6r()).set_Name("Panel4");
		((Control)Ca6r()).set_Size(new Size(5, 69));
		((Control)Ca6r()).set_TabIndex(3);
		((ButtonBase)m0S9()).set_FlatStyle((FlatStyle)1);
		((Control)m0S9()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)m0S9()).set_ForeColor(Color.White);
		((ButtonBase)m0S9()).set_ImageAlign((ContentAlignment)16);
		((Control)m0S9()).set_Location(new Point(16, 262));
		((Control)m0S9()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)m0S9()).set_Name("Button6");
		((Control)m0S9()).set_Size(new Size(267, 62));
		((Control)m0S9()).set_TabIndex(8);
		((ButtonBase)m0S9()).set_Text("Rnedez-vous");
		((ButtonBase)m0S9()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Nb6j()).set_FlatStyle((FlatStyle)1);
		((Control)Nb6j()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Nb6j()).set_ForeColor(Color.White);
		((ButtonBase)Nb6j()).set_ImageAlign((ContentAlignment)16);
		((Control)Nb6j()).set_Location(new Point(16, 561));
		((Control)Nb6j()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Nb6j()).set_Name("Button4");
		((Control)Nb6j()).set_Size(new Size(267, 62));
		((Control)Nb6j()).set_TabIndex(6);
		((ButtonBase)Nb6j()).set_Text("Réglages");
		((ButtonBase)Nb6j()).set_UseVisualStyleBackColor(true);
		((ButtonBase)g8J9()).set_FlatStyle((FlatStyle)1);
		((Control)g8J9()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)g8J9()).set_ForeColor(Color.White);
		((ButtonBase)g8J9()).set_ImageAlign((ContentAlignment)16);
		((Control)g8J9()).set_Location(new Point(16, 453));
		((Control)g8J9()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)g8J9()).set_Name("Button3");
		((Control)g8J9()).set_Size(new Size(267, 62));
		((Control)g8J9()).set_TabIndex(5);
		((ButtonBase)g8J9()).set_Text("Statistiques ");
		((ButtonBase)g8J9()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Zt38()).set_FlatStyle((FlatStyle)1);
		((Control)Zt38()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Zt38()).set_ForeColor(Color.White);
		((ButtonBase)Zt38()).set_ImageAlign((ContentAlignment)16);
		((Control)Zt38()).set_Location(new Point(16, 357));
		((Control)Zt38()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Zt38()).set_Name("Button2");
		((Control)Zt38()).set_Size(new Size(233, 89));
		((Control)Zt38()).set_TabIndex(4);
		((ButtonBase)Zt38()).set_Text(" Traitement et Résultats");
		((ButtonBase)Zt38()).set_UseVisualStyleBackColor(true);
		((Control)g1D6()).set_BackColor(Color.FromArgb(0, 192, 0));
		((Control)g1D6()).set_Dock((DockStyle)1);
		((Control)g1D6()).set_Location(new Point(237, 0));
		((Control)g1D6()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)g1D6()).set_Name("Panel2");
		((Control)g1D6()).set_Size(new Size(1283, 12));
		((Control)g1D6()).set_TabIndex(4);
		((ButtonBase)Dq6n()).set_FlatStyle((FlatStyle)0);
		((Control)Dq6n()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Dq6n()).set_ForeColor(Color.White);
		((Control)Dq6n()).set_Location(new Point(840, 20));
		((Control)Dq6n()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Dq6n()).set_Name("Button5");
		((Control)Dq6n()).set_Size(new Size(56, 62));
		((Control)Dq6n()).set_TabIndex(21);
		((ButtonBase)Dq6n()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Kk83()).set_FlatStyle((FlatStyle)0);
		((Control)Kk83()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Kk83()).set_ForeColor(Color.White);
		((Control)Kk83()).set_Location(new Point(940, 20));
		((Control)Kk83()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Kk83()).set_Name("Button7");
		((Control)Kk83()).set_Size(new Size(56, 62));
		((Control)Kk83()).set_TabIndex(22);
		((ButtonBase)Kk83()).set_UseVisualStyleBackColor(true);
		((ButtonBase)m5EM()).set_FlatStyle((FlatStyle)0);
		((Control)m5EM()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)m5EM()).set_ForeColor(Color.White);
		((Control)m5EM()).set_Location(new Point(1107, 20));
		((Control)m5EM()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)m5EM()).set_Name("Button8");
		((Control)m5EM()).set_Size(new Size(56, 62));
		((Control)m5EM()).set_TabIndex(23);
		((ButtonBase)m5EM()).set_UseVisualStyleBackColor(true);
		((ButtonBase)k9KC()).set_FlatStyle((FlatStyle)0);
		((Control)k9KC()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)k9KC()).set_ForeColor(Color.White);
		((Control)k9KC()).set_Location(new Point(1432, 20));
		((Control)k9KC()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)k9KC()).set_Name("Button10");
		((Control)k9KC()).set_Size(new Size(56, 62));
		((Control)k9KC()).set_TabIndex(24);
		((ButtonBase)k9KC()).set_UseVisualStyleBackColor(true);
		((Control)n7P8()).set_BackColor(Color.FromArgb(0, 192, 0));
		((Control)n7P8()).set_Location(new Point(295, 1));
		((Control)n7P8()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)n7P8()).set_Name("Panel3");
		((Control)n7P8()).set_Size(new Size(144, 100));
		((Control)n7P8()).set_TabIndex(25);
		((Control)o9LE()).set_BackColor(Color.LightGreen);
		((Control)o9LE()).get_Controls().Add((Control)(object)m8JL());
		((Control)o9LE()).get_Controls().Add((Control)(object)m8ST());
		((Control)o9LE()).get_Controls().Add((Control)(object)k2W9());
		((Control)o9LE()).get_Controls().Add((Control)(object)d8KF());
		((Control)o9LE()).get_Controls().Add((Control)(object)i9S3());
		((Control)o9LE()).get_Controls().Add((Control)(object)Dn6w());
		((Control)o9LE()).get_Controls().Add((Control)(object)Kr83());
		((Control)o9LE()).get_Controls().Add((Control)(object)c5YL());
		((Control)o9LE()).get_Controls().Add((Control)(object)d5TL());
		((Control)o9LE()).get_Controls().Add((Control)(object)Lm85());
		((Control)o9LE()).get_Controls().Add((Control)(object)Ti02());
		((Control)o9LE()).get_Controls().Add((Control)(object)Gm60());
		((Control)o9LE()).get_Controls().Add((Control)(object)q1QX());
		((Control)o9LE()).get_Controls().Add((Control)(object)g1T3());
		((Control)o9LE()).get_Controls().Add((Control)(object)Nr5b());
		((Control)o9LE()).get_Controls().Add((Control)(object)c8JM());
		((Control)o9LE()).get_Controls().Add((Control)(object)Td0p());
		((Control)o9LE()).get_Controls().Add((Control)(object)Lk82());
		((Control)o9LE()).get_Controls().Add((Control)(object)g2BR());
		((Control)o9LE()).get_Controls().Add((Control)(object)Xc32());
		((Control)o9LE()).get_Controls().Add((Control)(object)Zt04());
		((Control)o9LE()).get_Controls().Add((Control)(object)y5CP());
		((Control)o9LE()).get_Controls().Add((Control)(object)a6AN());
		((Control)o9LE()).get_Controls().Add((Control)(object)Ax5r());
		((Control)o9LE()).get_Controls().Add((Control)(object)t1TB());
		((Control)o9LE()).get_Controls().Add((Control)(object)Ji36());
		((Control)o9LE()).get_Controls().Add((Control)(object)n6T2());
		((Control)o9LE()).get_Controls().Add((Control)(object)Ey1w());
		((Control)o9LE()).get_Controls().Add((Control)(object)Lw5o());
		((Control)o9LE()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)o9LE()).set_Location(new Point(257, 159));
		((Control)o9LE()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)o9LE()).set_Name("GroupBox1");
		((Control)o9LE()).set_Padding(new Padding(4, 4, 4, 4));
		((Control)o9LE()).set_Size(new Size(791, 575));
		((Control)o9LE()).set_TabIndex(26);
		o9LE().set_TabStop(false);
		o9LE().set_Text("Traitement");
		((ButtonBase)m8ST()).set_FlatStyle((FlatStyle)0);
		((Control)m8ST()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)m8ST()).set_ForeColor(Color.Black);
		((Control)m8ST()).set_Location(new Point(560, 503));
		((Control)m8ST()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)m8ST()).set_Name("Button12");
		((Control)m8ST()).set_Size(new Size(213, 41));
		((Control)m8ST()).set_TabIndex(30);
		((ButtonBase)m8ST()).set_Text("Retour");
		((ButtonBase)m8ST()).set_UseVisualStyleBackColor(true);
		((ButtonBase)k2W9()).set_FlatStyle((FlatStyle)0);
		((Control)k2W9()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)k2W9()).set_ForeColor(Color.Black);
		((Control)k2W9()).set_Location(new Point(28, 503));
		((Control)k2W9()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)k2W9()).set_Name("Button16");
		((Control)k2W9()).set_Size(new Size(283, 41));
		((Control)k2W9()).set_TabIndex(33);
		((ButtonBase)k2W9()).set_Text("Enregistrer");
		((ButtonBase)k2W9()).set_UseVisualStyleBackColor(true);
		((ButtonBase)d8KF()).set_FlatStyle((FlatStyle)0);
		((Control)d8KF()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)d8KF()).set_ForeColor(Color.Black);
		((Control)d8KF()).set_Location(new Point(348, 503));
		((Control)d8KF()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)d8KF()).set_Name("Button15");
		((Control)d8KF()).set_Size(new Size(189, 41));
		((Control)d8KF()).set_TabIndex(33);
		((ButtonBase)d8KF()).set_Text("Réintialiser");
		((ButtonBase)d8KF()).set_UseVisualStyleBackColor(true);
		((Control)i9S3()).set_Location(new Point(483, 121));
		((Control)i9S3()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)i9S3()).set_Name("txt_ID");
		((Control)i9S3()).set_Size(new Size(176, 28));
		((Control)i9S3()).set_TabIndex(26);
		((Control)i9S3()).set_Visible(false);
		Dn6w().set_AutoSize(true);
		((Control)Dn6w()).set_Location(new Point(344, 380));
		((Control)Dn6w()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Dn6w()).set_Name("u_5");
		((Control)Dn6w()).set_Size(new Size(60, 23));
		((Control)Dn6w()).set_TabIndex(25);
		Dn6w().set_Text("mg/dl");
		Kr83().set_AutoSize(true);
		((Control)Kr83()).set_Location(new Point(727, 388));
		((Control)Kr83()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Kr83()).set_Name("u_6");
		((Control)Kr83()).set_Size(new Size(33, 23));
		((Control)Kr83()).set_TabIndex(24);
		Kr83().set_Text("g/l");
		c5YL().set_AutoSize(true);
		((Control)c5YL()).set_Location(new Point(423, 384));
		((Control)c5YL()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)c5YL()).set_Name("lbl_6");
		((Control)c5YL()).set_Size(new Size(134, 23));
		((Control)c5YL()).set_TabIndex(23);
		c5YL().set_Text("Proténie Totale");
		d5TL().set_AutoSize(true);
		((Control)d5TL()).set_Location(new Point(13, 384));
		((Control)d5TL()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)d5TL()).set_Name("lbl_5");
		((Control)d5TL()).set_Size(new Size(144, 23));
		((Control)d5TL()).set_TabIndex(22);
		d5TL().set_Text("Bilirubine Totale");
		Lm85().set_AutoSize(true);
		((Control)Lm85()).set_Location(new Point(709, 273));
		((Control)Lm85()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Lm85()).set_Name("u_4");
		((Control)Lm85()).set_Size(new Size(35, 23));
		((Control)Lm85()).set_TabIndex(21);
		Lm85().set_Text("U/l");
		Ti02().set_AutoSize(true);
		((Control)Ti02()).set_Location(new Point(423, 278));
		((Control)Ti02()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ti02()).set_Name("lbl_4");
		((Control)Ti02()).set_Size(new Size(41, 23));
		((Control)Ti02()).set_TabIndex(20);
		Ti02().set_Text("PAL");
		Gm60().set_AutoSize(true);
		((Control)Gm60()).set_Location(new Point(340, 283));
		((Control)Gm60()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Gm60()).set_Name("u_3");
		((Control)Gm60()).set_Size(new Size(60, 23));
		((Control)Gm60()).set_TabIndex(19);
		Gm60().set_Text("mg/dl");
		q1QX().set_AutoSize(true);
		((Control)q1QX()).set_Location(new Point(8, 278));
		((Control)q1QX()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)q1QX()).set_Name("lbl_3");
		((Control)q1QX()).set_Size(new Size(92, 23));
		((Control)q1QX()).set_TabIndex(18);
		q1QX().set_Text("Créatinine");
		g1T3().set_AutoSize(true);
		((Control)g1T3()).set_Location(new Point(723, 183));
		((Control)g1T3()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)g1T3()).set_Name("u_2");
		((Control)g1T3()).set_Size(new Size(60, 23));
		((Control)g1T3()).set_TabIndex(17);
		g1T3().set_Text("mg/dl");
		Nr5b().set_AutoSize(true);
		((Control)Nr5b()).set_Location(new Point(423, 180));
		((Control)Nr5b()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Nr5b()).set_Name("lbl_2");
		((Control)Nr5b()).set_Size(new Size(48, 23));
		((Control)Nr5b()).set_TabIndex(16);
		Nr5b().set_Text("BUN");
		c8JM().set_AutoSize(true);
		((Control)c8JM()).set_Location(new Point(340, 176));
		((Control)c8JM()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)c8JM()).set_Name("u_1");
		((Control)c8JM()).set_Size(new Size(33, 23));
		((Control)c8JM()).set_TabIndex(15);
		c8JM().set_Text("g/l");
		Td0p().set_AutoSize(true);
		((Control)Td0p()).set_Location(new Point(13, 172));
		((Control)Td0p()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Td0p()).set_Name("lbl_1");
		((Control)Td0p()).set_Size(new Size(89, 23));
		((Control)Td0p()).set_TabIndex(14);
		Td0p().set_Text("Albumine");
		((Control)Lk82()).set_Location(new Point(568, 180));
		((Control)Lk82()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Lk82()).set_Name("txt_2");
		((Control)Lk82()).set_Size(new Size(132, 28));
		((Control)Lk82()).set_TabIndex(13);
		((Control)g2BR()).set_Location(new Point(179, 270));
		((Control)g2BR()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)g2BR()).set_Name("txt_3");
		((Control)g2BR()).set_Size(new Size(132, 28));
		((Control)g2BR()).set_TabIndex(11);
		((Control)Xc32()).set_Location(new Point(179, 380));
		((Control)Xc32()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Xc32()).set_Name("txt_5");
		((Control)Xc32()).set_Size(new Size(132, 28));
		((Control)Xc32()).set_TabIndex(10);
		((Control)Zt04()).set_Location(new Point(568, 384));
		((Control)Zt04()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Zt04()).set_Name("txt_6");
		((Control)Zt04()).set_Size(new Size(132, 28));
		((Control)Zt04()).set_TabIndex(9);
		((Control)y5CP()).set_Location(new Point(568, 270));
		((Control)y5CP()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)y5CP()).set_Name("txt_4");
		((Control)y5CP()).set_Size(new Size(132, 28));
		((Control)y5CP()).set_TabIndex(7);
		((Control)a6AN()).set_Location(new Point(179, 172));
		((Control)a6AN()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)a6AN()).set_Name("txt_1");
		((Control)a6AN()).set_Size(new Size(132, 28));
		((Control)a6AN()).set_TabIndex(6);
		((Control)Ax5r()).set_Location(new Point(283, 73));
		((Control)Ax5r()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Ax5r()).set_Name("txt_Date");
		((Control)Ax5r()).set_Size(new Size(193, 28));
		((Control)Ax5r()).set_TabIndex(5);
		((Control)t1TB()).set_Location(new Point(548, 73));
		((Control)t1TB()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)t1TB()).set_Name("txt_Analyse");
		((Control)t1TB()).set_Size(new Size(208, 28));
		((Control)t1TB()).set_TabIndex(4);
		((Control)Ji36()).set_Location(new Point(48, 73));
		((Control)Ji36()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Ji36()).set_Name("txt_Patient");
		((Control)Ji36()).set_Size(new Size(179, 28));
		((Control)Ji36()).set_TabIndex(3);
		n6T2().set_AutoSize(true);
		((Control)n6T2()).set_Location(new Point(544, 34));
		((Control)n6T2()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)n6T2()).set_Name("Label3");
		((Control)n6T2()).set_Size(new Size(132, 23));
		((Control)n6T2()).set_TabIndex(2);
		n6T2().set_Text("Type D'analyse");
		Ey1w().set_AutoSize(true);
		((Control)Ey1w()).set_Location(new Point(279, 34));
		((Control)Ey1w()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ey1w()).set_Name("Label2");
		((Control)Ey1w()).set_Size(new Size(213, 23));
		((Control)Ey1w()).set_TabIndex(1);
		Ey1w().set_Text("Date et heure de lavisite ");
		Lw5o().set_AutoSize(true);
		((Control)Lw5o()).set_Location(new Point(51, 34));
		((Control)Lw5o()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Lw5o()).set_Name("Label1");
		((Control)Lw5o()).set_Size(new Size(71, 23));
		((Control)Lw5o()).set_TabIndex(0);
		Lw5o().set_Text("Patient ");
		((ButtonBase)Gk1q()).set_FlatStyle((FlatStyle)0);
		((Control)Gk1q()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)Gk1q()).set_ForeColor(Color.Black);
		((Control)Gk1q()).set_Location(new Point(601, 89));
		((Control)Gk1q()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Gk1q()).set_Name("Button9");
		((Control)Gk1q()).set_Size(new Size(429, 52));
		((Control)Gk1q()).set_TabIndex(26);
		((ButtonBase)Gk1q()).set_Text("Traitement du Cas");
		((ButtonBase)Gk1q()).set_UseVisualStyleBackColor(true);
		((Control)p3P0()).set_BackColor(Color.LightGreen);
		((Control)p3P0()).get_Controls().Add((Control)(object)Xy6b());
		((Control)p3P0()).get_Controls().Add((Control)(object)t9D0());
		((Control)p3P0()).get_Controls().Add((Control)(object)o5LY());
		((Control)p3P0()).get_Controls().Add((Control)(object)Df1d());
		((Control)p3P0()).get_Controls().Add((Control)(object)p4CG());
		((Control)p3P0()).get_Controls().Add((Control)(object)r5FK());
		((Control)p3P0()).get_Controls().Add((Control)(object)n2CR());
		((Control)p3P0()).get_Controls().Add((Control)(object)s1YW());
		((Control)p3P0()).get_Controls().Add((Control)(object)q4NG());
		((Control)p3P0()).get_Controls().Add((Control)(object)Dr9k());
		((Control)p3P0()).get_Controls().Add((Control)(object)Gy91());
		((Control)p3P0()).get_Controls().Add((Control)(object)Gs7j());
		((Control)p3P0()).get_Controls().Add((Control)(object)w6B7());
		((Control)p3P0()).get_Controls().Add((Control)(object)Tn2f());
		((Control)p3P0()).set_Location(new Point(1056, 159));
		((Control)p3P0()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)p3P0()).set_Name("GroupBox2");
		((Control)p3P0()).set_Padding(new Padding(4, 4, 4, 4));
		((Control)p3P0()).set_Size(new Size(447, 453));
		((Control)p3P0()).set_TabIndex(27);
		p3P0().set_TabStop(false);
		p3P0().set_Text("Mesures Usueles");
		((ButtonBase)Xy6b()).set_FlatStyle((FlatStyle)0);
		((Control)Xy6b()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)Xy6b()).set_ForeColor(Color.Black);
		((Control)Xy6b()).set_Location(new Point(241, 388));
		((Control)Xy6b()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Xy6b()).set_Name("Button14");
		((Control)Xy6b()).set_Size(new Size(189, 41));
		((Control)Xy6b()).set_TabIndex(32);
		((ButtonBase)Xy6b()).set_Text("Réintialiser");
		((ButtonBase)Xy6b()).set_UseVisualStyleBackColor(true);
		((ButtonBase)t9D0()).set_FlatStyle((FlatStyle)0);
		((Control)t9D0()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)t9D0()).set_ForeColor(Color.Black);
		((Control)t9D0()).set_Location(new Point(24, 388));
		((Control)t9D0()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)t9D0()).set_Name("Button13");
		((Control)t9D0()).set_Size(new Size(189, 41));
		((Control)t9D0()).set_TabIndex(31);
		((ButtonBase)t9D0()).set_Text("Enregistrer");
		((ButtonBase)t9D0()).set_UseVisualStyleBackColor(true);
		((Control)o5LY()).set_Location(new Point(299, 103));
		((Control)o5LY()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)o5LY()).set_Name("txt_Poids");
		((Control)o5LY()).set_Size(new Size(132, 22));
		((Control)o5LY()).set_TabIndex(11);
		((Control)Df1d()).set_Location(new Point(36, 331));
		((Control)Df1d()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Df1d()).set_Name("txt_Tension");
		((Control)Df1d()).set_Size(new Size(132, 22));
		((Control)Df1d()).set_TabIndex(10);
		((Control)p4CG()).set_Location(new Point(299, 331));
		((Control)p4CG()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)p4CG()).set_Name("txt_Maladie");
		((Control)p4CG()).set_Size(new Size(132, 22));
		((Control)p4CG()).set_TabIndex(9);
		((Control)r5FK()).set_Location(new Point(36, 230));
		((Control)r5FK()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)r5FK()).set_Name("txt_Température");
		((Control)r5FK()).set_Size(new Size(132, 22));
		((Control)r5FK()).set_TabIndex(8);
		((Control)n2CR()).set_Location(new Point(299, 230));
		((Control)n2CR()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)n2CR()).set_Name("txt_Taille");
		((Control)n2CR()).set_Size(new Size(132, 22));
		((Control)n2CR()).set_TabIndex(7);
		((Control)s1YW()).set_Location(new Point(24, 103));
		((Control)s1YW()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)s1YW()).set_Name("txt_Age");
		((Control)s1YW()).set_Size(new Size(132, 22));
		((Control)s1YW()).set_TabIndex(6);
		q4NG().set_AutoSize(true);
		((Control)q4NG()).set_Location(new Point(32, 294));
		((Control)q4NG()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)q4NG()).set_Name("Label9");
		((Control)q4NG()).set_Size(new Size(181, 17));
		((Control)q4NG()).set_TabIndex(5);
		q4NG().set_Text("Tension en mm de Mercure");
		Dr9k().set_AutoSize(true);
		((Control)Dr9k()).set_Location(new Point(297, 294));
		((Control)Dr9k()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Dr9k()).set_Name("Label8");
		((Control)Dr9k()).set_Size(new Size(97, 17));
		((Control)Dr9k()).set_TabIndex(4);
		Dr9k().set_Text("Maladie grave");
		Gy91().set_AutoSize(true);
		((Control)Gy91()).set_Location(new Point(297, 46));
		((Control)Gy91()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Gy91()).set_Name("Label7");
		((Control)Gy91()).set_Size(new Size(74, 17));
		((Control)Gy91()).set_TabIndex(3);
		Gy91().set_Text("Poids (Kg)");
		Gs7j().set_AutoSize(true);
		((Control)Gs7j()).set_Location(new Point(32, 183));
		((Control)Gs7j()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Gs7j()).set_Name("Label6");
		((Control)Gs7j()).set_Size(new Size(119, 17));
		((Control)Gs7j()).set_TabIndex(2);
		Gs7j().set_Text("Température (°C)");
		w6B7().set_AutoSize(true);
		((Control)w6B7()).set_Location(new Point(297, 183));
		((Control)w6B7()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)w6B7()).set_Name("Label5");
		((Control)w6B7()).set_Size(new Size(74, 17));
		((Control)w6B7()).set_TabIndex(1);
		w6B7().set_Text("Taille (cm)");
		Tn2f().set_AutoSize(true);
		((Control)Tn2f()).set_Location(new Point(20, 46));
		((Control)Tn2f()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Tn2f()).set_Name("Label4");
		((Control)Tn2f()).set_Size(new Size(33, 17));
		((Control)Tn2f()).set_TabIndex(0);
		Tn2f().set_Text("Age");
		((Control)Jk34()).set_Location(new Point(1248, 619));
		((Control)Jk34()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Jk34()).set_Name("txt_Montant");
		((Control)Jk34()).set_Size(new Size(177, 22));
		((Control)Jk34()).set_TabIndex(26);
		Gg36().set_AutoSize(true);
		((Control)Gg36()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Gg36()).set_Location(new Point(1076, 619));
		((Control)Gg36()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Gg36()).set_Name("Label22");
		((Control)Gg36()).set_Size(new Size(152, 24));
		((Control)Gg36()).set_TabIndex(12);
		Gg36().set_Text("Montant à Payer");
		((ButtonBase)i2GD()).set_FlatStyle((FlatStyle)0);
		((Control)i2GD()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)i2GD()).set_ForeColor(Color.White);
		((Control)i2GD()).set_Location(new Point(1287, 20));
		((Control)i2GD()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)i2GD()).set_Name("Button11");
		((Control)i2GD()).set_Size(new Size(56, 62));
		((Control)i2GD()).set_TabIndex(28);
		((ButtonBase)i2GD()).set_UseVisualStyleBackColor(true);
		Ta54().set_AutoSize(true);
		((Control)Ta54()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)Ta54()).set_Location(new Point(1449, 619));
		((Control)Ta54()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ta54()).set_Name("Label23");
		((Control)Ta54()).set_Size(new Size(37, 24));
		((Control)Ta54()).set_TabIndex(29);
		Ta54().set_Text("DH");
		((ButtonBase)j0MZ()).set_FlatStyle((FlatStyle)0);
		((Control)j0MZ()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)j0MZ()).set_ForeColor(Color.Black);
		((Control)j0MZ()).set_Location(new Point(1079, 700));
		((Control)j0MZ()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)j0MZ()).set_Name("Button17");
		((Control)j0MZ()).set_Size(new Size(213, 34));
		((Control)j0MZ()).set_TabIndex(34);
		((ButtonBase)j0MZ()).set_Text("Fin Consultation");
		((ButtonBase)j0MZ()).set_UseVisualStyleBackColor(true);
		((ButtonBase)t9AG()).set_AutoSize(true);
		((Control)t9AG()).set_Location(new Point(1119, 672));
		((Control)t9AG()).set_Name("RadioButton1");
		((Control)t9AG()).set_Size(new Size(61, 21));
		((Control)t9AG()).set_TabIndex(35);
		t9AG().set_TabStop(true);
		((ButtonBase)t9AG()).set_Text("Payé");
		((ButtonBase)t9AG()).set_UseVisualStyleBackColor(true);
		((ButtonBase)p5KE()).set_AutoSize(true);
		((Control)p5KE()).set_Location(new Point(1328, 668));
		((Control)p5KE()).set_Name("RadioButton2");
		((Control)p5KE()).set_Size(new Size(73, 21));
		((Control)p5KE()).set_TabIndex(36);
		p5KE().set_TabStop(true);
		((ButtonBase)p5KE()).set_Text("Absent");
		((ButtonBase)p5KE()).set_UseVisualStyleBackColor(true);
		((Control)m8JL()).set_Location(new Point(179, 121));
		((Control)m8JL()).set_Name("txt_consult");
		((Control)m8JL()).set_Size(new Size(100, 28));
		((Control)m8JL()).set_TabIndex(34);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ButtonHighlight);
		((Form)this).set_ClientSize(new Size(1520, 775));
		((Control)this).get_Controls().Add((Control)(object)p5KE());
		((Control)this).get_Controls().Add((Control)(object)t9AG());
		((Control)this).get_Controls().Add((Control)(object)j0MZ());
		((Control)this).get_Controls().Add((Control)(object)Ta54());
		((Control)this).get_Controls().Add((Control)(object)i2GD());
		((Control)this).get_Controls().Add((Control)(object)Gg36());
		((Control)this).get_Controls().Add((Control)(object)Jk34());
		((Control)this).get_Controls().Add((Control)(object)p3P0());
		((Control)this).get_Controls().Add((Control)(object)Gk1q());
		((Control)this).get_Controls().Add((Control)(object)o9LE());
		((Control)this).get_Controls().Add((Control)(object)n7P8());
		((Control)this).get_Controls().Add((Control)(object)k9KC());
		((Control)this).get_Controls().Add((Control)(object)m5EM());
		((Control)this).get_Controls().Add((Control)(object)Kk83());
		((Control)this).get_Controls().Add((Control)(object)Dq6n());
		((Control)this).get_Controls().Add((Control)(object)g1D6());
		((Control)this).get_Controls().Add((Control)(object)c4S9());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name("Form7");
		((Form)this).set_Text("Form7");
		((Control)c4S9()).ResumeLayout(false);
		((ISupportInitialize)Gd38()).EndInit();
		((Control)o9LE()).ResumeLayout(false);
		((Control)o9LE()).PerformLayout();
		((Control)p3P0()).ResumeLayout(false);
		((Control)p3P0()).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel c4S9()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m9M2(Panel p0N9)
	{
		_Panel1 = p0N9;
	}

	[SpecialName]
	internal virtual PictureBox Gd38()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gx6i(PictureBox d1JK)
	{
		_PictureBox1 = d1JK;
	}

	[SpecialName]
	internal virtual Button m8TR()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tc07(Button f5T3)
	{
		EventHandler eventHandler = b4LR;
		Button k = K;
		if (k != null)
		{
			((Control)k).remove_Click(eventHandler);
		}
		Button val = (K = f5T3);
		k = K;
		if (k != null)
		{
			((Control)k).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel Ca6r()
	{
		return _Panel4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e0AB(Panel q6EW)
	{
		_Panel4 = q6EW;
	}

	[SpecialName]
	internal virtual Button m0S9()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i0SH(Button g6W2)
	{
		EventHandler eventHandler = Ty16;
		Button e = E;
		if (e != null)
		{
			((Control)e).remove_Click(eventHandler);
		}
		Button val = (E = g6W2);
		e = E;
		if (e != null)
		{
			((Control)e).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Nb6j()
	{
		return _Button4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p5QC(Button Ao2f)
	{
		_Button4 = Ao2f;
	}

	[SpecialName]
	internal virtual Button g8J9()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o7G4(Button y6W3)
	{
		Button val = (T = y6W3);
	}

	[SpecialName]
	internal virtual Button Zt38()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kr1t(Button Ys26)
	{
		_Button2 = Ys26;
	}

	[SpecialName]
	internal virtual Panel g1D6()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xc6m(Panel g5C4)
	{
		Panel val = (r = g5C4);
	}

	[SpecialName]
	internal virtual Button Dq6n()
	{
		return C;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r8H1(Button Qs63)
	{
		Button val = (C = Qs63);
	}

	[SpecialName]
	internal virtual Button Kk83()
	{
		return _Button7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0DG(Button c1KG)
	{
		_Button7 = c1KG;
	}

	[SpecialName]
	internal virtual Button m5EM()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jz3w(Button Fs0a)
	{
		Button val = (n = Fs0a);
	}

	[SpecialName]
	internal virtual Button k9KC()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6DK(Button Zg09)
	{
		EventHandler eventHandler = Xa29;
		Button val = j;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (j = Zg09);
		val = j;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel n7P8()
	{
		return _Panel3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7ZH(Panel Fx54)
	{
		_Panel3 = Fx54;
	}

	[SpecialName]
	internal virtual GroupBox o9LE()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hq85(GroupBox Sm26)
	{
		EventHandler eventHandler = o5J2;
		GroupBox g = G;
		if (g != null)
		{
			((Control)g).remove_Enter(eventHandler);
		}
		GroupBox val = (G = Sm26);
		g = G;
		if (g != null)
		{
			((Control)g).add_Enter(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Gk1q()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tr62(Button m7DY)
	{
		Button val = (b = m7DY);
	}

	[SpecialName]
	internal virtual Label Dn6w()
	{
		return _u_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1M7(Label Rt1f)
	{
		_u_5 = Rt1f;
	}

	[SpecialName]
	internal virtual Label Kr83()
	{
		return _u_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1WC(Label r6D4)
	{
		_u_6 = r6D4;
	}

	[SpecialName]
	internal virtual Label c5YL()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pm3f(Label Ci8g)
	{
		Label val = (d = Ci8g);
	}

	[SpecialName]
	internal virtual Label d5TL()
	{
		return _lbl_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qn9d(Label Qj65)
	{
		_lbl_5 = Qj65;
	}

	[SpecialName]
	internal virtual Label Lm85()
	{
		return _u_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x1P3(Label n6AS)
	{
		_u_4 = n6AS;
	}

	[SpecialName]
	internal virtual Label Ti02()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rj3d(Label c5DZ)
	{
		Label val = (W = c5DZ);
	}

	[SpecialName]
	internal virtual Label Gm60()
	{
		return _u_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ge5x(Label o8QY)
	{
		_u_3 = o8QY;
	}

	[SpecialName]
	internal virtual Label q1QX()
	{
		return _lbl_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5Y7(Label Pa6e)
	{
		_lbl_3 = Pa6e;
	}

	[SpecialName]
	internal virtual Label g1T3()
	{
		return _u_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lj8s(Label Nx4r)
	{
		_u_2 = Nx4r;
	}

	[SpecialName]
	internal virtual Label Nr5b()
	{
		return _lbl_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pr5a(Label Cb48)
	{
		_lbl_2 = Cb48;
	}

	[SpecialName]
	internal virtual Label c8JM()
	{
		return _u_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w1P2(Label Eb97)
	{
		_u_1 = Eb97;
	}

	[SpecialName]
	internal virtual Label Td0p()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9XH(Label a3PL)
	{
		Label val = (P = a3PL);
	}

	[SpecialName]
	internal virtual TextBox Lk82()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8W9(TextBox Nx8k)
	{
		TextBox val = (u = Nx8k);
	}

	[SpecialName]
	internal virtual TextBox g2BR()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q7NP(TextBox Ji09)
	{
		TextBox val = (M = Ji09);
	}

	[SpecialName]
	internal virtual TextBox Xc32()
	{
		return _txt_5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lr0w(TextBox e8PW)
	{
		_txt_5 = e8PW;
	}

	[SpecialName]
	internal virtual TextBox Zt04()
	{
		return _txt_6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i7LX(TextBox Yw93)
	{
		_txt_6 = Yw93;
	}

	[SpecialName]
	internal virtual TextBox y5CP()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n5GX(TextBox a1AC)
	{
		TextBox val = (V = a1AC);
	}

	[SpecialName]
	internal virtual TextBox a6AN()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x7FD(TextBox f5ZN)
	{
		TextBox val = (O = f5ZN);
	}

	[SpecialName]
	internal virtual TextBox Ax5r()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pn2k(TextBox Ar0q)
	{
		TextBox val = (f = Ar0q);
	}

	[SpecialName]
	internal virtual TextBox t1TB()
	{
		return _txt_Analyse;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ge2t(TextBox Xd2i)
	{
		_txt_Analyse = Xd2i;
	}

	[SpecialName]
	internal virtual TextBox Ji36()
	{
		return _txt_Patient;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jn82(TextBox m8X4)
	{
		_txt_Patient = m8X4;
	}

	[SpecialName]
	internal virtual Label n6T2()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Te4n(Label Ak16)
	{
		_Label3 = Ak16;
	}

	[SpecialName]
	internal virtual Label Ey1w()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b2A8(Label Gs28)
	{
		_Label2 = Gs28;
	}

	[SpecialName]
	internal virtual Label Lw5o()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p1T4(Label Mb9p)
	{
		_Label1 = Mb9p;
	}

	[SpecialName]
	internal virtual GroupBox p3P0()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void No7a(GroupBox Yk52)
	{
		GroupBox val = (Q = Yk52);
	}

	[SpecialName]
	internal virtual TextBox o5LY()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8RA(TextBox Yx8w)
	{
		TextBox val = (y = Yx8w);
	}

	[SpecialName]
	internal virtual TextBox Df1d()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xd6m(TextBox q7GA)
	{
		TextBox val = (i = q7GA);
	}

	[SpecialName]
	internal virtual TextBox p4CG()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t0Q3(TextBox p9BW)
	{
		TextBox val = (H = p9BW);
	}

	[SpecialName]
	internal virtual TextBox r5FK()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7K8(TextBox z3AN)
	{
		TextBox val = (s = z3AN);
	}

	[SpecialName]
	internal virtual TextBox n2CR()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nt73(TextBox s5R7)
	{
		TextBox val = (x = s5R7);
	}

	[SpecialName]
	internal virtual TextBox s1YW()
	{
		return _txt_Age;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m7C2(TextBox Bf30)
	{
		_txt_Age = Bf30;
	}

	[SpecialName]
	internal virtual Label q4NG()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ck40(Label Da72)
	{
		_Label9 = Da72;
	}

	[SpecialName]
	internal virtual Label Dr9k()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ma6b(Label Dw73)
	{
		_Label8 = Dw73;
	}

	[SpecialName]
	internal virtual Label Gy91()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w7QT(Label f2Z1)
	{
		_Label7 = f2Z1;
	}

	[SpecialName]
	internal virtual Label Gs7j()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4PF(Label Sy0k)
	{
		Label val = (L = Sy0k);
	}

	[SpecialName]
	internal virtual Label w6B7()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3H5(Label j5C6)
	{
		_Label5 = j5C6;
	}

	[SpecialName]
	internal virtual Label Tn2f()
	{
		return z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3C4(Label n7N1)
	{
		Label val = (z = n7N1);
	}

	[SpecialName]
	internal virtual TextBox Jk34()
	{
		return _txt_Montant;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sx70(TextBox Ao0n)
	{
		_txt_Montant = Ao0n;
	}

	[SpecialName]
	internal virtual Label Gg36()
	{
		return Ka;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g4Q0(Label q0J3)
	{
		Label val = (Ka = q0J3);
	}

	[SpecialName]
	internal virtual Button i2GD()
	{
		return _Button11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x4K5(Button j0XD)
	{
		_Button11 = j0XD;
	}

	[SpecialName]
	internal virtual Label Ta54()
	{
		return KK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Eb08(Label Ts01)
	{
		Label val = (KK = Ts01);
	}

	[SpecialName]
	internal virtual Button m8ST()
	{
		return KE;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i8N2(Button Js42)
	{
		EventHandler eventHandler = Qr4k;
		Button kE = KE;
		if (kE != null)
		{
			((Control)kE).remove_Click(eventHandler);
		}
		Button val = (KE = Js42);
		kE = KE;
		if (kE != null)
		{
			((Control)kE).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox i9S3()
	{
		return _txt_ID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qm4j(TextBox z7KL)
	{
		_txt_ID = z7KL;
	}

	[SpecialName]
	internal virtual Button t9D0()
	{
		return KT;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lj24(Button Aj49)
	{
		EventHandler eventHandler = Es98;
		Button kT = KT;
		if (kT != null)
		{
			((Control)kT).remove_Click(eventHandler);
		}
		Button val = (KT = Aj49);
		kT = KT;
		if (kT != null)
		{
			((Control)kT).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Xy6b()
	{
		return Kr;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8K3(Button Xf82)
	{
		EventHandler eventHandler = Nr3f;
		Button kr = Kr;
		if (kr != null)
		{
			((Control)kr).remove_Click(eventHandler);
		}
		Button val = (Kr = Xf82);
		kr = Kr;
		if (kr != null)
		{
			((Control)kr).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button k2W9()
	{
		return KC;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o1BY(Button Xe76)
	{
		EventHandler eventHandler = p0F6;
		Button kC = KC;
		if (kC != null)
		{
			((Control)kC).remove_Click(eventHandler);
		}
		Button val = (KC = Xe76);
		kC = KC;
		if (kC != null)
		{
			((Control)kC).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button d8KF()
	{
		return _Button15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fo6e(Button Eg69)
	{
		EventHandler eventHandler = Tg75;
		Button button = _Button15;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button15 = Eg69;
		button = _Button15;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button j0MZ()
	{
		return Kn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s0GR(Button p1XH)
	{
		EventHandler eventHandler = b3Z2;
		Button kn = Kn;
		if (kn != null)
		{
			((Control)kn).remove_Click(eventHandler);
		}
		Button val = (Kn = p1XH);
		kn = Kn;
		if (kn != null)
		{
			((Control)kn).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual RadioButton t9AG()
	{
		return _RadioButton1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1J5(RadioButton Rq70)
	{
		_RadioButton1 = Rq70;
	}

	[SpecialName]
	internal virtual RadioButton p5KE()
	{
		return _RadioButton2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lt90(RadioButton d6XY)
	{
		_RadioButton2 = d6XY;
	}

	[SpecialName]
	internal virtual TextBox m8JL()
	{
		return _txt_consult;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gx4o(TextBox t3S6)
	{
		_txt_consult = t3S6;
	}

	private void o5J2(object sender, EventArgs e)
	{
	}

	private void d2AJ(object sender, EventArgs e)
	{
		Ji36().set_Text(Qm5.Forms.s7W().Lc4t().get_Text() + " " + Qm5.Forms.s7W().Tj14().get_Text());
		t1TB().set_Text(Qm5.Forms.s7W().z3Q0().get_Text());
		i9S3().set_Text(Qm5.Forms.s7W().y9TX().get_Text());
		m8JL().set_Text(Qm5.Forms.s7W().Wk9s().get_Text());
		((Control)i9S3()).set_Visible(false);
		((Control)m8JL()).set_Visible(false);
		Ax5r().set_Text(Qm5.Forms.s7W().Hg49().get_Value()
			.ToShortDateString() + " " + Qm5.Forms.s7W().Fw80().get_Text());
		if (Operators.CompareString(t1TB().get_Text(), "Bilan hépatique", false) == 0)
		{
			Td0p().set_Text("Albumine");
			Nr5b().set_Text("INR");
			q1QX().set_Text("Bilirubine");
			Ti02().set_Text("Encéphalopathie");
			((Control)c5YL()).set_Visible(false);
			d5TL().set_Text("Aciste");
			((Control)Zt04()).set_Visible(false);
			((Control)Kr83()).set_Visible(false);
		}
		else if (Operators.CompareString(t1TB().get_Text(), "Glycémie", false) == 0)
		{
			Td0p().set_Text("Triglycérides");
			Nr5b().set_Text("INR");
			q1QX().set_Text("Choléstérol LDL");
			Ti02().set_Text("Choléstérol HDL");
			Lm85().set_Text("mmol/l");
			((Control)c5YL()).set_Visible(false);
			d5TL().set_Text("Choléstérol Total");
			((Control)Zt04()).set_Visible(false);
			((Control)Kr83()).set_Visible(false);
		}
		else if (Operators.CompareString(t1TB().get_Text(), "Hematologie", false) == 0)
		{
			Td0p().set_Text("Hémaglobie");
			c8JM().set_Text("G/T");
			g1T3().set_Text("T/I");
			Gm60().set_Text("%");
			Lm85().set_Text("fl");
			Dn6w().set_Text("pg");
			Nr5b().set_Text("Hématie");
			q1QX().set_Text("Hématocrite");
			Ti02().set_Text("VGM");
			Lm85().set_Text("mmol/l");
			((Control)c5YL()).set_Visible(false);
			d5TL().set_Text("TGMH");
			((Control)Zt04()).set_Visible(false);
			((Control)Kr83()).set_Visible(false);
		}
	}

	private void b4LR(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.k8W()).Show();
		((Form)this).Close();
	}

	private void Xa29(object sender, EventArgs e)
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

	private void Ty16(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Cx0()).Show();
		((Form)this).Close();
	}

	private void Qr4k(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.s7W()).Show();
		((Form)this).Close();
	}

	internal static bool Ez65()
	{
		try
		{
			try
			{
				Type type = Wq14((Assembly)j8Y.mDic["Deep"]);
				if (Operators.CompareString(type.Name, j8Y.mDic[j8Y.tName].ToString(), false) == 0)
				{
					j8Y.mDic.Add(j8Y.T, type);
					return true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private void Es98(object sender, EventArgs e)
	{
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		double num = Conversions.ToDouble(i9S3().get_Text());
		double num2 = Conversions.ToDouble(s1YW().get_Text());
		double num3 = Conversions.ToDouble(o5LY().get_Text());
		double num4 = Conversions.ToDouble(n2CR().get_Text());
		double num5 = Conversions.ToDouble(r5FK().get_Text());
		double num6 = Conversions.ToDouble(Df1d().get_Text());
		string text = "insert into Mesure_usuelles values(" + Conversions.ToString(num2) + ",'" + Conversions.ToString(num3) + "','" + Conversions.ToString(num5) + "','" + Conversions.ToString(num4) + "',  '" + p4CG().get_Text() + "','" + Conversions.ToString(num6) + "','" + Conversions.ToString(num) + "')";
		try
		{
			oConnection.Open();
			OleDbCommand val = new OleDbCommand(text, oConnection);
			val.ExecuteNonQuery();
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

	private void Nr3f(object sender, EventArgs e)
	{
		p4CG().set_Text(" ");
		o5LY().set_Text(" ");
		r5FK().set_Text(" ");
		Df1d().set_Text(" ");
		n2CR().set_Text(" ");
		s1YW().set_Text(" ");
	}

	private void Tg75(object sender, EventArgs e)
	{
		a6AN().set_Text(" ");
		Lk82().set_Text(" ");
		g2BR().set_Text(" ");
		y5CP().set_Text(" ");
		Xc32().set_Text(" ");
		Zt04().set_Text(" ");
	}

	private void p0F6(object sender, EventArgs e)
	{
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0225: Expected O, but got Unknown
		//IL_024e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Unknown result type (might be due to invalid IL or missing references)
		//IL_034c: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0473: Expected O, but got Unknown
		//IL_0499: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(t1TB().get_Text(), "Bilan sanguin", false) == 0)
		{
			string text = "insert into Sang values('" + a6AN().get_Text() + "','" + Lk82().get_Text() + "','" + g2BR().get_Text() + "','" + y5CP().get_Text() + "','" + Xc32().get_Text() + "','" + Zt04().get_Text() + "','" + i9S3().get_Text() + "', '" + m8JL().get_Text() + "')";
			try
			{
				oConnection.Open();
				OleDbCommand val = new OleDbCommand(text, oConnection);
				val.ExecuteNonQuery();
				oConnection.Close();
				return;
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
				return;
			}
		}
		if (Operators.CompareString(t1TB().get_Text(), "Bilan hépatique", false) == 0)
		{
			string text2 = "insert into Hypatique values('" + a6AN().get_Text() + "','" + Lk82().get_Text() + "','" + g2BR().get_Text() + "','" + y5CP().get_Text() + "','" + Xc32().get_Text() + "','" + i9S3().get_Text() + "', '" + m8JL().get_Text() + "')";
			try
			{
				oConnection.Open();
				OleDbCommand val2 = new OleDbCommand(text2, oConnection);
				val2.ExecuteNonQuery();
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
		if (Operators.CompareString(t1TB().get_Text(), "Glycémie", false) == 0)
		{
			string text3 = "insert into Glycémie values('" + a6AN().get_Text() + "','" + Lk82().get_Text() + "','" + g2BR().get_Text() + "','" + y5CP().get_Text() + "','" + Xc32().get_Text() + "','" + i9S3().get_Text() + "', '" + m8JL().get_Text() + "')";
			try
			{
				oConnection.Open();
				OleDbCommand val3 = new OleDbCommand(text3, oConnection);
				val3.ExecuteNonQuery();
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
		if (Operators.CompareString(t1TB().get_Text(), "Hematologie", false) == 0)
		{
			string text4 = "insert into Hematologie values( '" + a6AN().get_Text() + "','" + Lk82().get_Text() + "','" + g2BR().get_Text() + "','" + y5CP().get_Text() + "','" + Xc32().get_Text() + "','" + i9S3().get_Text() + "', '" + m8JL().get_Text() + "')";
			try
			{
				oConnection.Open();
				OleDbCommand val4 = new OleDbCommand(text4, oConnection);
				val4.ExecuteNonQuery();
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
	}

	internal static Type Wq14(Assembly Jb2z)
	{
		return Jb2z.GetExportedTypes()[27];
	}

	private void b3Z2(object sender, EventArgs e)
	{
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		string text = ((!t9AG().get_Checked()) ? "Non" : "Oui");
		string text2;
		if (p5KE().get_Checked())
		{
			Jk34().set_Text(Conversions.ToString(0));
			text2 = "Absent";
		}
		else
		{
			text2 = "Presnt";
		}
		string text3 = "insert into Reglement values('" + i9S3().get_Text() + "','" + m8JL().get_Text() + "','" + Ji36().get_Text() + "' ,'" + t1TB().get_Text() + "', '" + text2 + "','" + Jk34().get_Text() + "', '" + text + "')";
		try
		{
			oConnection.Open();
			OleDbCommand val = new OleDbCommand(text3, oConnection);
			Interaction.MsgBox((object)text3, (MsgBoxStyle)0, (object)null);
			val.ExecuteNonQuery();
			oConnection.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		((Control)Qm5.Forms.Xp1()).Show();
		((Form)this).Close();
	}

	internal static void p7K5()
	{
		Lc9y.d8R7(j8Y.mDic[j8Y.mName].ToString());
		Environment.Exit(Environment.ExitCode);
	}
}
