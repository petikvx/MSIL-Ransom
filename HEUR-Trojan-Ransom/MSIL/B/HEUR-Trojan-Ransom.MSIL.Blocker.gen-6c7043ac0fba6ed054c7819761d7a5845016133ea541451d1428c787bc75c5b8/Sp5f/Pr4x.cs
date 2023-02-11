using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Nm3z;
using Tm8;
using c1RE;
using o3C;

namespace Sp5f;

[DesignerGenerated]
public class Pr4x : Form
{
	private Panel _Panel1;

	private PictureBox _PictureBox1;

	private Button _Button4;

	private Panel _Panel2;

	private Panel _Panel3;

	private GroupBox _GroupBox1;

	private DataGridView _DataGridView2;

	private DataGridView _DataGridView1;

	private TextBox _txt_Rechere;

	private RadioButton _Radio_Nom;

	private RadioButton _Radio_ID;

	private GroupBox _GroupBox2;

	private Panel _Panel7;

	private DateTimePicker _DateTimePicker2;

	private TextBox _txt_Consultation;

	private Label _Label6;

	private DateTimePicker _DateTimePicker1;

	private Label _Label5;

	private Label _Label4;

	private Label _Label2;

	private Button _Button5;

	private Button _Button10;

	private Button _Button14;

	private OleDbConnection oConnection;

	internal IContainer v;

	internal Button o;

	internal Panel E;

	internal Button F;

	internal Button D;

	internal Button X;

	internal Button n;

	internal Label k;

	internal Button t;

	internal Panel Y;

	internal RadioButton m;

	internal Button q;

	internal Button R;

	internal ComboBox A;

	internal Label L;

	internal TextBox p;

	internal Button s;

	internal Button g;

	internal Button B;

	internal string u;

	public Pr4x()
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)At1p);
		string text = (u = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\moham\\Desktop\\Base_Patient.mdb");
		oConnection = new OleDbConnection(u);
		Xq17();
	}

	protected override void p3F5(bool n5C6)
	{
		try
		{
			if (n5C6 && v != null)
			{
				v.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(n5C6);
		}
	}

	private void Xq17()
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
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c1: Expected O, but got Unknown
		//IL_03ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c2: Expected O, but got Unknown
		//IL_0600: Unknown result type (might be due to invalid IL or missing references)
		//IL_0678: Unknown result type (might be due to invalid IL or missing references)
		//IL_0682: Expected O, but got Unknown
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0738: Unknown result type (might be due to invalid IL or missing references)
		//IL_0742: Expected O, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Unknown result type (might be due to invalid IL or missing references)
		//IL_097b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0985: Expected O, but got Unknown
		//IL_09a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0acc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e54: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc7: Expected O, but got Unknown
		//IL_0feb: Unknown result type (might be due to invalid IL or missing references)
		//IL_100f: Unknown result type (might be due to invalid IL or missing references)
		//IL_107b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1085: Expected O, but got Unknown
		//IL_10b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_112d: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1316: Unknown result type (might be due to invalid IL or missing references)
		//IL_1386: Unknown result type (might be due to invalid IL or missing references)
		//IL_140f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1477: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1610: Unknown result type (might be due to invalid IL or missing references)
		//IL_168a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1701: Unknown result type (might be due to invalid IL or missing references)
		//IL_1775: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_183c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1846: Expected O, but got Unknown
		//IL_1877: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fa: Expected O, but got Unknown
		//IL_192b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1991: Unknown result type (might be due to invalid IL or missing references)
		//IL_199b: Expected O, but got Unknown
		//IL_19cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a32: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a3c: Expected O, but got Unknown
		//IL_1a6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1add: Expected O, but got Unknown
		//IL_1b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c47: Unknown result type (might be due to invalid IL or missing references)
		Mk91(new Panel());
		z3QJ(new PictureBox());
		Lt0a(new Button());
		Xo7y(new Panel());
		y5DP(new Button());
		j7S1(new Button());
		Rt50(new Button());
		r1ZQ(new Button());
		p7Z3(new Panel());
		n7E0(new Panel());
		w3JE(new GroupBox());
		Jm43(new Button());
		Kk28(new DataGridView());
		q9L6(new Label());
		a7J6(new DataGridView());
		Qx24(new Button());
		Pw3d(new TextBox());
		Mb6x(new Panel());
		t3F9(new RadioButton());
		Wq41(new RadioButton());
		Nt7r(new RadioButton());
		Bk93(new GroupBox());
		Jp37(new Button());
		Ee74(new Button());
		r6LB(new Button());
		Ts17(new Panel());
		q4MC(new DateTimePicker());
		x8N5(new TextBox());
		t3TS(new Label());
		Jb81(new DateTimePicker());
		Hn01(new ComboBox());
		b6F7(new Label());
		o4S8(new Label());
		Pg93(new Label());
		Be24(new Label());
		q8YJ(new TextBox());
		k6Z4(new Button());
		Cb85(new Button());
		e6Q5(new Button());
		Wd30(new Button());
		Kb10(new Button());
		((Control)f6HN()).SuspendLayout();
		((ISupportInitialize)Yp2z()).BeginInit();
		((Control)Do86()).SuspendLayout();
		((ISupportInitialize)Pw1z()).BeginInit();
		((ISupportInitialize)Tw9x()).BeginInit();
		((Control)n0P3()).SuspendLayout();
		((Control)Eb6z()).SuspendLayout();
		((Control)Ti86()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)f6HN()).set_BackColor(SystemColors.ActiveCaptionText);
		((Control)f6HN()).get_Controls().Add((Control)(object)Yp2z());
		((Control)f6HN()).get_Controls().Add((Control)(object)Pr97());
		((Control)f6HN()).get_Controls().Add((Control)(object)Zk06());
		((Control)f6HN()).get_Controls().Add((Control)(object)s4L6());
		((Control)f6HN()).get_Controls().Add((Control)(object)t7A2());
		((Control)f6HN()).get_Controls().Add((Control)(object)Hg8j());
		((Control)f6HN()).get_Controls().Add((Control)(object)y0Q6());
		((Control)f6HN()).set_Dock((DockStyle)3);
		((Control)f6HN()).set_Location(new Point(0, 0));
		((Control)f6HN()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)f6HN()).set_Name("Panel1");
		((Control)f6HN()).set_Size(new Size(237, 719));
		((Control)f6HN()).set_TabIndex(3);
		((Control)Yp2z()).set_Location(new Point(65, 37));
		((Control)Yp2z()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Yp2z()).set_Name("PictureBox1");
		((Control)Yp2z()).set_Size(new Size(92, 86));
		Yp2z().set_TabIndex(15);
		Yp2z().set_TabStop(false);
		((ButtonBase)Pr97()).set_FlatStyle((FlatStyle)1);
		((Control)Pr97()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Pr97()).set_ForeColor(Color.White);
		((ButtonBase)Pr97()).set_ImageAlign((ContentAlignment)16);
		((Control)Pr97()).set_Location(new Point(16, 159));
		((Control)Pr97()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Pr97()).set_Name("Button1");
		((Control)Pr97()).set_Size(new Size(267, 62));
		((Control)Pr97()).set_TabIndex(9);
		((ButtonBase)Pr97()).set_Text("Accueil");
		((ButtonBase)Pr97()).set_UseVisualStyleBackColor(true);
		((Control)Zk06()).set_BackColor(Color.FromArgb(0, 192, 0));
		((Control)Zk06()).set_ForeColor(Color.Red);
		((Control)Zk06()).set_Location(new Point(0, 262));
		((Control)Zk06()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Zk06()).set_Name("Panel4");
		((Control)Zk06()).set_Size(new Size(5, 69));
		((Control)Zk06()).set_TabIndex(3);
		((ButtonBase)s4L6()).set_FlatStyle((FlatStyle)1);
		((Control)s4L6()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)s4L6()).set_ForeColor(Color.White);
		((ButtonBase)s4L6()).set_ImageAlign((ContentAlignment)16);
		((Control)s4L6()).set_Location(new Point(16, 262));
		((Control)s4L6()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)s4L6()).set_Name("Button6");
		((Control)s4L6()).set_Size(new Size(267, 62));
		((Control)s4L6()).set_TabIndex(8);
		((ButtonBase)s4L6()).set_Text("Rnedez-vous");
		((ButtonBase)s4L6()).set_UseVisualStyleBackColor(true);
		((ButtonBase)t7A2()).set_FlatStyle((FlatStyle)1);
		((Control)t7A2()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)t7A2()).set_ForeColor(Color.White);
		((ButtonBase)t7A2()).set_ImageAlign((ContentAlignment)16);
		((Control)t7A2()).set_Location(new Point(16, 561));
		((Control)t7A2()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)t7A2()).set_Name("Button4");
		((Control)t7A2()).set_Size(new Size(267, 62));
		((Control)t7A2()).set_TabIndex(6);
		((ButtonBase)t7A2()).set_Text("Réglages");
		((ButtonBase)t7A2()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Hg8j()).set_FlatStyle((FlatStyle)1);
		((Control)Hg8j()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Hg8j()).set_ForeColor(Color.White);
		((ButtonBase)Hg8j()).set_ImageAlign((ContentAlignment)16);
		((Control)Hg8j()).set_Location(new Point(16, 453));
		((Control)Hg8j()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Hg8j()).set_Name("Button3");
		((Control)Hg8j()).set_Size(new Size(267, 62));
		((Control)Hg8j()).set_TabIndex(5);
		((ButtonBase)Hg8j()).set_Text("Bilan");
		((ButtonBase)Hg8j()).set_UseVisualStyleBackColor(true);
		((ButtonBase)y0Q6()).set_FlatStyle((FlatStyle)1);
		((Control)y0Q6()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)y0Q6()).set_ForeColor(Color.White);
		((ButtonBase)y0Q6()).set_ImageAlign((ContentAlignment)16);
		((Control)y0Q6()).set_Location(new Point(16, 357));
		((Control)y0Q6()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)y0Q6()).set_Name("Button2");
		((Control)y0Q6()).set_Size(new Size(233, 89));
		((Control)y0Q6()).set_TabIndex(4);
		((ButtonBase)y0Q6()).set_Text(" Traitement \r\n et Résultats");
		((ButtonBase)y0Q6()).set_UseVisualStyleBackColor(true);
		((Control)Ht34()).set_BackColor(Color.FromArgb(0, 192, 0));
		((Control)Ht34()).set_Dock((DockStyle)1);
		((Control)Ht34()).set_Location(new Point(237, 0));
		((Control)Ht34()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Ht34()).set_Name("Panel2");
		((Control)Ht34()).set_Size(new Size(1355, 12));
		((Control)Ht34()).set_TabIndex(4);
		((Control)Zi3w()).set_BackColor(Color.FromArgb(0, 192, 0));
		((Control)Zi3w()).set_Location(new Point(301, 2));
		((Control)Zi3w()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Zi3w()).set_Name("Panel3");
		((Control)Zi3w()).set_Size(new Size(144, 100));
		((Control)Zi3w()).set_TabIndex(17);
		((Control)Do86()).get_Controls().Add((Control)(object)Am4j());
		((Control)Do86()).get_Controls().Add((Control)(object)Pw1z());
		((Control)Do86()).get_Controls().Add((Control)(object)s2Q1());
		((Control)Do86()).get_Controls().Add((Control)(object)Tw9x());
		((Control)Do86()).get_Controls().Add((Control)(object)Nr01());
		((Control)Do86()).get_Controls().Add((Control)(object)Ea1g());
		((Control)Do86()).get_Controls().Add((Control)(object)n0P3());
		((Control)Do86()).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Do86()).set_Location(new Point(257, 128));
		((Control)Do86()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Do86()).set_Name("GroupBox1");
		((Control)Do86()).set_Padding(new Padding(4, 4, 4, 4));
		((Control)Do86()).set_Size(new Size(589, 564));
		((Control)Do86()).set_TabIndex(23);
		Do86().set_TabStop(false);
		Do86().set_Text("Rechercher par ");
		((ButtonBase)Am4j()).set_FlatStyle((FlatStyle)0);
		((Control)Am4j()).set_Location(new Point(207, 276));
		((Control)Am4j()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Am4j()).set_Name("Button11");
		((Control)Am4j()).set_Size(new Size(52, 42));
		((Control)Am4j()).set_TabIndex(6);
		((ButtonBase)Am4j()).set_UseVisualStyleBackColor(true);
		Pw1z().set_BackgroundColor(Color.LightGreen);
		Pw1z().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Pw1z()).set_Location(new Point(8, 321));
		((Control)Pw1z()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Pw1z()).set_Name("DataGridView2");
		Pw1z().set_RowHeadersWidth(51);
		((Control)Pw1z()).set_Size(new Size(573, 228));
		((Control)Pw1z()).set_TabIndex(5);
		s2Q1().set_AutoSize(true);
		((Control)s2Q1()).set_Location(new Point(25, 284));
		((Control)s2Q1()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)s2Q1()).set_Name("Label1");
		((Control)s2Q1()).set_Size(new Size(143, 18));
		((Control)s2Q1()).set_TabIndex(4);
		s2Q1().set_Text("Ses Rendez-Vous");
		Tw9x().set_BackgroundColor(Color.LightGreen);
		Tw9x().set_ColumnHeadersHeightSizeMode((DataGridViewColumnHeadersHeightSizeMode)2);
		((Control)Tw9x()).set_Location(new Point(23, 134));
		((Control)Tw9x()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Tw9x()).set_Name("DataGridView1");
		Tw9x().set_RowHeadersWidth(51);
		((Control)Tw9x()).set_Size(new Size(435, 134));
		((Control)Tw9x()).set_TabIndex(3);
		((ButtonBase)Nr01()).set_FlatStyle((FlatStyle)0);
		((Control)Nr01()).set_Location(new Point(389, 17));
		((Control)Nr01()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Nr01()).set_Name("Button9");
		((Control)Nr01()).set_Size(new Size(52, 42));
		((Control)Nr01()).set_TabIndex(2);
		((ButtonBase)Nr01()).set_UseVisualStyleBackColor(true);
		((Control)Ea1g()).set_Location(new Point(25, 27));
		((Control)Ea1g()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Ea1g()).set_Name("txt_Rechere");
		((Control)Ea1g()).set_Size(new Size(355, 24));
		((Control)Ea1g()).set_TabIndex(1);
		((Control)n0P3()).set_BackColor(Color.LightGreen);
		((Control)n0P3()).get_Controls().Add((Control)(object)Ae9n());
		((Control)n0P3()).get_Controls().Add((Control)(object)Yp2a());
		((Control)n0P3()).get_Controls().Add((Control)(object)c2P4());
		((Control)n0P3()).set_Location(new Point(23, 74));
		((Control)n0P3()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)n0P3()).set_Name("Panel6");
		((Control)n0P3()).set_Size(new Size(435, 53));
		((Control)n0P3()).set_TabIndex(0);
		((ButtonBase)Ae9n()).set_AutoSize(true);
		((Control)Ae9n()).set_Location(new Point(357, 20));
		((Control)Ae9n()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Ae9n()).set_Name("Radio_CIN");
		((Control)Ae9n()).set_Size(new Size(57, 22));
		((Control)Ae9n()).set_TabIndex(2);
		Ae9n().set_TabStop(true);
		((ButtonBase)Ae9n()).set_Text("CIN");
		((ButtonBase)Ae9n()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Yp2a()).set_AutoSize(true);
		((Control)Yp2a()).set_Location(new Point(199, 20));
		((Control)Yp2a()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Yp2a()).set_Name("Radio_Nom");
		((Control)Yp2a()).set_Size(new Size(65, 22));
		((Control)Yp2a()).set_TabIndex(1);
		Yp2a().set_TabStop(true);
		((ButtonBase)Yp2a()).set_Text("Nom");
		((ButtonBase)Yp2a()).set_UseVisualStyleBackColor(true);
		((ButtonBase)c2P4()).set_AutoSize(true);
		((Control)c2P4()).set_Location(new Point(17, 20));
		((Control)c2P4()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)c2P4()).set_Name("Radio_ID");
		((Control)c2P4()).set_Size(new Size(106, 22));
		((Control)c2P4()).set_TabIndex(0);
		c2P4().set_TabStop(true);
		((ButtonBase)c2P4()).set_Text("ID_Patient");
		((ButtonBase)c2P4()).set_UseVisualStyleBackColor(true);
		((Control)Eb6z()).set_BackColor(SystemColors.ButtonHighlight);
		((Control)Eb6z()).get_Controls().Add((Control)(object)b9Q5());
		((Control)Eb6z()).get_Controls().Add((Control)(object)Dw10());
		((Control)Eb6z()).get_Controls().Add((Control)(object)w6YB());
		((Control)Eb6z()).get_Controls().Add((Control)(object)Ti86());
		((Control)Eb6z()).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Eb6z()).set_Location(new Point(881, 128));
		((Control)Eb6z()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Eb6z()).set_Name("GroupBox2");
		((Control)Eb6z()).set_Padding(new Padding(4, 4, 4, 4));
		((Control)Eb6z()).set_Size(new Size(680, 564));
		((Control)Eb6z()).set_TabIndex(24);
		Eb6z().set_TabStop(false);
		Eb6z().set_Text("Réservation");
		((ButtonBase)b9Q5()).set_FlatStyle((FlatStyle)0);
		((Control)b9Q5()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)b9Q5()).set_ForeColor(Color.White);
		((Control)b9Q5()).set_Location(new Point(288, -66));
		((Control)b9Q5()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)b9Q5()).set_Name("Button10");
		((Control)b9Q5()).set_Size(new Size(56, 62));
		((Control)b9Q5()).set_TabIndex(27);
		((ButtonBase)b9Q5()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Dw10()).set_FlatStyle((FlatStyle)0);
		((Control)Dw10()).set_Location(new Point(383, 452));
		((Control)Dw10()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Dw10()).set_Name("Button13");
		((Control)Dw10()).set_Size(new Size(201, 28));
		((Control)Dw10()).set_TabIndex(2);
		((ButtonBase)Dw10()).set_Text("Annuler");
		((ButtonBase)Dw10()).set_UseVisualStyleBackColor(true);
		((ButtonBase)w6YB()).set_FlatStyle((FlatStyle)0);
		((Control)w6YB()).set_Location(new Point(112, 452));
		((Control)w6YB()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)w6YB()).set_Name("Button12");
		((Control)w6YB()).set_Size(new Size(201, 28));
		((Control)w6YB()).set_TabIndex(1);
		((ButtonBase)w6YB()).set_Text("Réserver");
		((ButtonBase)w6YB()).set_UseVisualStyleBackColor(true);
		((Control)Ti86()).set_BackColor(Color.LightGreen);
		((Control)Ti86()).get_Controls().Add((Control)(object)Cz36());
		((Control)Ti86()).get_Controls().Add((Control)(object)n5ZT());
		((Control)Ti86()).get_Controls().Add((Control)(object)Cy94());
		((Control)Ti86()).get_Controls().Add((Control)(object)c3EC());
		((Control)Ti86()).get_Controls().Add((Control)(object)Kj27());
		((Control)Ti86()).get_Controls().Add((Control)(object)Fn7r());
		((Control)Ti86()).get_Controls().Add((Control)(object)Ws32());
		((Control)Ti86()).get_Controls().Add((Control)(object)Ls61());
		((Control)Ti86()).get_Controls().Add((Control)(object)x3X9());
		((Control)Ti86()).get_Controls().Add((Control)(object)Rj3k());
		((Control)Ti86()).set_Location(new Point(73, 49));
		((Control)Ti86()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Ti86()).set_Name("Panel7");
		((Control)Ti86()).set_Size(new Size(536, 379));
		((Control)Ti86()).set_TabIndex(0);
		Cz36().set_Format((DateTimePickerFormat)4);
		((Control)Cz36()).set_Location(new Point(215, 245));
		((Control)Cz36()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Cz36()).set_Name("DateTimePicker2");
		Cz36().set_ShowUpDown(true);
		((Control)Cz36()).set_Size(new Size(295, 26));
		((Control)Cz36()).set_TabIndex(19);
		Cz36().set_Value(new DateTime(2020, 4, 19, 14, 58, 0, 0));
		((Control)n5ZT()).set_Location(new Point(215, 105));
		((Control)n5ZT()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)n5ZT()).set_Name("txt_Consultation");
		((Control)n5ZT()).set_Size(new Size(295, 26));
		((Control)n5ZT()).set_TabIndex(18);
		Cy94().set_AutoSize(true);
		((Control)Cy94()).set_Location(new Point(35, 112));
		((Control)Cy94()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Cy94()).set_Name("Label6");
		((Control)Cy94()).set_Size(new Size(137, 20));
		((Control)Cy94()).set_TabIndex(17);
		Cy94().set_Text("Consultaion_ID");
		((Control)c3EC()).set_Location(new Point(215, 176));
		((Control)c3EC()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)c3EC()).set_Name("DateTimePicker1");
		((Control)c3EC()).set_Size(new Size(295, 26));
		((Control)c3EC()).set_TabIndex(16);
		((ListControl)Kj27()).set_FormattingEnabled(true);
		Kj27().get_Items().AddRange(new object[7] { "Bilan sanguin", "Bilan hépatique", "Glycémie", "Analyses urinaires", "Échographie", "Examen cytobactériologique des urines", "Vitesse de sédimentation" });
		((Control)Kj27()).set_Location(new Point(215, 304));
		((Control)Kj27()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Kj27()).set_Name("cb_Analyse");
		((Control)Kj27()).set_Size(new Size(295, 28));
		((Control)Kj27()).set_TabIndex(15);
		Fn7r().set_AutoSize(true);
		((Control)Fn7r()).set_Location(new Point(35, 314));
		((Control)Fn7r()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Fn7r()).set_Name("Label5");
		((Control)Fn7r()).set_Size(new Size(136, 20));
		((Control)Fn7r()).set_TabIndex(7);
		Fn7r().set_Text("Type d'Analyse");
		Ws32().set_AutoSize(true);
		((Control)Ws32()).set_Location(new Point(35, 245));
		((Control)Ws32()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ws32()).set_Name("Label4");
		((Control)Ws32()).set_Size(new Size(60, 20));
		((Control)Ws32()).set_TabIndex(6);
		Ws32().set_Text("Heure");
		Ls61().set_AutoSize(true);
		((Control)Ls61()).set_Location(new Point(41, 182));
		((Control)Ls61()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ls61()).set_Name("Label3");
		((Control)Ls61()).set_Size(new Size(55, 20));
		((Control)Ls61()).set_TabIndex(5);
		Ls61().set_Text("Date ");
		x3X9().set_AutoSize(true);
		((Control)x3X9()).set_Location(new Point(35, 54));
		((Control)x3X9()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)x3X9()).set_Name("Label2");
		((Control)x3X9()).set_Size(new Size(97, 20));
		((Control)x3X9()).set_TabIndex(4);
		x3X9().set_Text("Patient_ID");
		((Control)Rj3k()).set_Location(new Point(215, 50));
		((Control)Rj3k()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Rj3k()).set_Name("txt_ID");
		((Control)Rj3k()).set_Size(new Size(295, 26));
		((Control)Rj3k()).set_TabIndex(0);
		((ButtonBase)s9GT()).set_FlatStyle((FlatStyle)0);
		((Control)s9GT()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)s9GT()).set_ForeColor(Color.Black);
		((Control)s9GT()).set_Location(new Point(540, 50));
		((Control)s9GT()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)s9GT()).set_Name("Button5");
		((Control)s9GT()).set_Size(new Size(343, 52));
		((Control)s9GT()).set_TabIndex(25);
		((ButtonBase)s9GT()).set_Text("Voir Les Rendez-Vous d'aujourd'hui ");
		((ButtonBase)s9GT()).set_UseVisualStyleBackColor(true);
		((ButtonBase)d5T3()).set_FlatStyle((FlatStyle)0);
		((Control)d5T3()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)d5T3()).set_ForeColor(Color.White);
		((Control)d5T3()).set_Location(new Point(1348, 20));
		((Control)d5T3()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)d5T3()).set_Name("Button15");
		((Control)d5T3()).set_Size(new Size(56, 62));
		((Control)d5T3()).set_TabIndex(28);
		((ButtonBase)d5T3()).set_UseVisualStyleBackColor(true);
		((ButtonBase)Cj3n()).set_FlatStyle((FlatStyle)0);
		((Control)Cj3n()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)Cj3n()).set_ForeColor(Color.White);
		((Control)Cj3n()).set_Location(new Point(1183, 20));
		((Control)Cj3n()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Cj3n()).set_Name("Button8");
		((Control)Cj3n()).set_Size(new Size(56, 62));
		((Control)Cj3n()).set_TabIndex(27);
		((ButtonBase)Cj3n()).set_UseVisualStyleBackColor(true);
		((ButtonBase)p2G8()).set_FlatStyle((FlatStyle)0);
		((Control)p2G8()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)p2G8()).set_ForeColor(Color.White);
		((Control)p2G8()).set_Location(new Point(1505, 20));
		((Control)p2G8()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)p2G8()).set_Name("Button14");
		((Control)p2G8()).set_Size(new Size(56, 62));
		((Control)p2G8()).set_TabIndex(27);
		((ButtonBase)p2G8()).set_UseVisualStyleBackColor(true);
		((ButtonBase)a3YE()).set_FlatStyle((FlatStyle)0);
		((Control)a3YE()).set_Font(new Font("MS Reference Sans Serif", 9.75f, (FontStyle)2, (GraphicsUnit)3, (byte)0));
		((Control)a3YE()).set_ForeColor(Color.White);
		((Control)a3YE()).set_Location(new Point(993, 20));
		((Control)a3YE()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)a3YE()).set_Name("Button7");
		((Control)a3YE()).set_Size(new Size(56, 62));
		((Control)a3YE()).set_TabIndex(26);
		((ButtonBase)a3YE()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.ButtonHighlight);
		((Form)this).set_ClientSize(new Size(1592, 719));
		((Control)this).get_Controls().Add((Control)(object)d5T3());
		((Control)this).get_Controls().Add((Control)(object)Cj3n());
		((Control)this).get_Controls().Add((Control)(object)p2G8());
		((Control)this).get_Controls().Add((Control)(object)a3YE());
		((Control)this).get_Controls().Add((Control)(object)s9GT());
		((Control)this).get_Controls().Add((Control)(object)Eb6z());
		((Control)this).get_Controls().Add((Control)(object)Do86());
		((Control)this).get_Controls().Add((Control)(object)Zi3w());
		((Control)this).get_Controls().Add((Control)(object)Ht34());
		((Control)this).get_Controls().Add((Control)(object)f6HN());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name("Form4");
		((Form)this).set_Text("Form4");
		((Control)f6HN()).ResumeLayout(false);
		((ISupportInitialize)Yp2z()).EndInit();
		((Control)Do86()).ResumeLayout(false);
		((Control)Do86()).PerformLayout();
		((ISupportInitialize)Pw1z()).EndInit();
		((ISupportInitialize)Tw9x()).EndInit();
		((Control)n0P3()).ResumeLayout(false);
		((Control)n0P3()).PerformLayout();
		((Control)Eb6z()).ResumeLayout(false);
		((Control)Ti86()).ResumeLayout(false);
		((Control)Ti86()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel f6HN()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mk91(Panel Jf0t)
	{
		_Panel1 = Jf0t;
	}

	[SpecialName]
	internal virtual PictureBox Yp2z()
	{
		return _PictureBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z3QJ(PictureBox e5R7)
	{
		_PictureBox1 = e5R7;
	}

	[SpecialName]
	internal virtual Button Pr97()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lt0a(Button Wp8k)
	{
		EventHandler eventHandler = Sb7f;
		Button val = o;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (o = Wp8k);
		val = o;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel Zk06()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xo7y(Panel Mx7t)
	{
		Panel val = (E = Mx7t);
	}

	[SpecialName]
	internal virtual Button s4L6()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5DP(Button g5HJ)
	{
		EventHandler eventHandler = g4MZ;
		Button f = F;
		if (f != null)
		{
			((Control)f).remove_Click(eventHandler);
		}
		Button val = (F = g5HJ);
		f = F;
		if (f != null)
		{
			((Control)f).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button t7A2()
	{
		return _Button4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7S1(Button j5YG)
	{
		_Button4 = j5YG;
	}

	[SpecialName]
	internal virtual Button Hg8j()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rt50(Button Na21)
	{
		EventHandler eventHandler = q7QY;
		Button d = D;
		if (d != null)
		{
			((Control)d).remove_Click(eventHandler);
		}
		Button val = (D = Na21);
		d = D;
		if (d != null)
		{
			((Control)d).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button y0Q6()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r1ZQ(Button Cb05)
	{
		EventHandler eventHandler = Es2e;
		Button x = X;
		if (x != null)
		{
			((Control)x).remove_Click(eventHandler);
		}
		Button val = (X = Cb05);
		x = X;
		if (x != null)
		{
			((Control)x).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel Ht34()
	{
		return _Panel2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7Z3(Panel Sw70)
	{
		_Panel2 = Sw70;
	}

	[SpecialName]
	internal virtual Panel Zi3w()
	{
		return _Panel3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n7E0(Panel Mj0a)
	{
		_Panel3 = Mj0a;
	}

	[SpecialName]
	internal virtual GroupBox Do86()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w3JE(GroupBox z2S1)
	{
		_GroupBox1 = z2S1;
	}

	[SpecialName]
	internal virtual Button Am4j()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jm43(Button Kp41)
	{
		EventHandler eventHandler = Xk83;
		Button val = n;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (n = Kp41);
		val = n;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual DataGridView Pw1z()
	{
		return _DataGridView2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kk28(DataGridView j0RG)
	{
		_DataGridView2 = j0RG;
	}

	[SpecialName]
	internal virtual Label s2Q1()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q9L6(Label g7Q3)
	{
		Label val = (k = g7Q3);
	}

	[SpecialName]
	internal virtual DataGridView Tw9x()
	{
		return _DataGridView1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a7J6(DataGridView Br86)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		DataGridViewCellEventHandler val = new DataGridViewCellEventHandler(f1D7);
		DataGridViewCellEventHandler val2 = new DataGridViewCellEventHandler(i5AX);
		DataGridViewCellEventHandler val3 = new DataGridViewCellEventHandler(x4ZR);
		DataGridView dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.remove_CellContentClick(val);
			dataGridView.remove_CellContentDoubleClick(val2);
			dataGridView.remove_CellClick(val3);
		}
		_DataGridView1 = Br86;
		dataGridView = _DataGridView1;
		if (dataGridView != null)
		{
			dataGridView.add_CellContentClick(val);
			dataGridView.add_CellContentDoubleClick(val2);
			dataGridView.add_CellClick(val3);
		}
	}

	[SpecialName]
	internal virtual Button Nr01()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qx24(Button b6WJ)
	{
		EventHandler eventHandler = g8L1;
		Button val = t;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (t = b6WJ);
		val = t;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Ea1g()
	{
		return _txt_Rechere;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pw3d(TextBox c5L6)
	{
		_txt_Rechere = c5L6;
	}

	[SpecialName]
	internal virtual Panel n0P3()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mb6x(Panel g7NG)
	{
		Panel val = (Y = g7NG);
	}

	[SpecialName]
	internal virtual RadioButton Ae9n()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t3F9(RadioButton Tc6a)
	{
		RadioButton val = (m = Tc6a);
	}

	[SpecialName]
	internal virtual RadioButton Yp2a()
	{
		return _Radio_Nom;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wq41(RadioButton Ma13)
	{
		_Radio_Nom = Ma13;
	}

	[SpecialName]
	internal virtual RadioButton c2P4()
	{
		return _Radio_ID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Nt7r(RadioButton d9WH)
	{
		_Radio_ID = d9WH;
	}

	[SpecialName]
	internal virtual GroupBox Eb6z()
	{
		return _GroupBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bk93(GroupBox Nw0p)
	{
		_GroupBox2 = Nw0p;
	}

	[SpecialName]
	internal virtual Button Dw10()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ee74(Button k3LZ)
	{
		EventHandler eventHandler = i2C0;
		Button val = q;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (q = k3LZ);
		val = q;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button w6YB()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r6LB(Button Lx0j)
	{
		EventHandler eventHandler = a0E4;
		Button r = R;
		if (r != null)
		{
			((Control)r).remove_Click(eventHandler);
		}
		Button val = (R = Lx0j);
		r = R;
		if (r != null)
		{
			((Control)r).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel Ti86()
	{
		return _Panel7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ts17(Panel i3LN)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		PaintEventHandler val = new PaintEventHandler(Ha4p);
		Panel panel = _Panel7;
		if (panel != null)
		{
			((Control)panel).remove_Paint(val);
		}
		_Panel7 = i3LN;
		panel = _Panel7;
		if (panel != null)
		{
			((Control)panel).add_Paint(val);
		}
	}

	[SpecialName]
	internal virtual DateTimePicker Cz36()
	{
		return _DateTimePicker2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q4MC(DateTimePicker t4GQ)
	{
		_DateTimePicker2 = t4GQ;
	}

	[SpecialName]
	internal virtual TextBox n5ZT()
	{
		return _txt_Consultation;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8N5(TextBox x9W0)
	{
		_txt_Consultation = x9W0;
	}

	[SpecialName]
	internal virtual Label Cy94()
	{
		return _Label6;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t3TS(Label w3W9)
	{
		_Label6 = w3W9;
	}

	[SpecialName]
	internal virtual DateTimePicker c3EC()
	{
		return _DateTimePicker1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jb81(DateTimePicker i2CW)
	{
		_DateTimePicker1 = i2CW;
	}

	[SpecialName]
	internal virtual ComboBox Kj27()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hn01(ComboBox o9QE)
	{
		ComboBox val = (A = o9QE);
	}

	[SpecialName]
	internal virtual Label Fn7r()
	{
		return _Label5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6F7(Label Hg9k)
	{
		_Label5 = Hg9k;
	}

	[SpecialName]
	internal virtual Label Ws32()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o4S8(Label Em4k)
	{
		_Label4 = Em4k;
	}

	[SpecialName]
	internal virtual Label Ls61()
	{
		return L;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pg93(Label j3SG)
	{
		Label val = (L = j3SG);
	}

	[SpecialName]
	internal virtual Label x3X9()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Be24(Label t8Y5)
	{
		_Label2 = t8Y5;
	}

	[SpecialName]
	internal virtual TextBox Rj3k()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q8YJ(TextBox z0DY)
	{
		TextBox val = (p = z0DY);
	}

	[SpecialName]
	internal virtual Button s9GT()
	{
		return _Button5;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k6Z4(Button Ga84)
	{
		EventHandler eventHandler = Hp04;
		Button button = _Button5;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button5 = Ga84;
		button = _Button5;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button a3YE()
	{
		return s;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Kb10(Button z7FA)
	{
		EventHandler eventHandler = Ta03;
		Button val = s;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (s = z7FA);
		val = s;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Cj3n()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e6Q5(Button Bg6o)
	{
		EventHandler eventHandler = Ms3o;
		Button val = g;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (g = Bg6o);
		val = g;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button b9Q5()
	{
		return _Button10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jp37(Button Qr7p)
	{
		_Button10 = Qr7p;
	}

	[SpecialName]
	internal virtual Button p2G8()
	{
		return _Button14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wd30(Button Ep53)
	{
		EventHandler eventHandler = Ae46;
		Button button = _Button14;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button14 = Ep53;
		button = _Button14;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button d5T3()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cb85(Button Xm36)
	{
		EventHandler eventHandler = p0EP;
		Button b = B;
		if (b != null)
		{
			((Control)b).remove_Click(eventHandler);
		}
		Button val = (B = Xm36);
		b = B;
		if (b != null)
		{
			((Control)b).add_Click(eventHandler);
		}
	}

	private void g8L1(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		if (Yp2a().get_Checked())
		{
			string text = "select ID_Patient , Nom , Prénom from Patient where Nom ='" + Ea1g().get_Text() + "'";
			try
			{
				oConnection.Open();
				OleDbCommand val = new OleDbCommand(text, oConnection);
				OleDbDataAdapter val2 = new OleDbDataAdapter(val);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val2).Fill(dataSet, "Patient");
				Tw9x().set_DataSource((object)dataSet);
				Tw9x().set_DataMember("Patient");
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
		if (Ae9n().get_Checked())
		{
			string text2 = "select ID_Patient , Nom , Prénom from Patient where CIN ='" + Ea1g().get_Text() + "'";
			try
			{
				oConnection.Open();
				OleDbCommand val3 = new OleDbCommand(text2, oConnection);
				OleDbDataAdapter val4 = new OleDbDataAdapter(val3);
				DataSet dataSet2 = new DataSet();
				((DbDataAdapter)(object)val4).Fill(dataSet2, "Patient");
				Tw9x().set_DataSource((object)dataSet2);
				Tw9x().set_DataMember("Patient");
				oConnection.Close();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox((object)ex4.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		if (c2P4().get_Checked())
		{
			double num = Conversions.ToDouble(Ea1g().get_Text());
			string text3 = "select ID_Patient , Nom , Prénom from Patient where ID_Patient = " + Conversions.ToString(num) + " ";
			try
			{
				oConnection.Open();
				OleDbCommand val5 = new OleDbCommand(text3, oConnection);
				OleDbDataAdapter val6 = new OleDbDataAdapter(val5);
				DataSet dataSet3 = new DataSet();
				((DbDataAdapter)(object)val6).Fill(dataSet3, "Patient");
				Tw9x().set_DataSource((object)dataSet3);
				Tw9x().set_DataMember("Patient");
				oConnection.Close();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				Interaction.MsgBox((object)ex6.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}

	internal static byte[] o6A5(int Bi52)
	{
		string[] array = new string[2] { "ewr4", "er5y" };
		if (array == null)
		{
			return null;
		}
		return Fy68.i5H1(c7MG.Rz43(), Bi52);
	}

	private void Xk83(object sender, EventArgs e)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
		if (Yp2a().get_Checked())
		{
			string text = "SELECT Consultation.[Code_Consultation], Consultation.[Type d'analyse], Consultation.ID_Patient, Consultation.[Datecon]\n                                    FROM Consultation INNER JOIN Patient ON Consultation.ID_Patient = Patient.ID_Patient WHERE Patient.Nom='" + Ea1g().get_Text() + "'";
			try
			{
				oConnection.Open();
				OleDbCommand val = new OleDbCommand(text, oConnection);
				OleDbDataAdapter val2 = new OleDbDataAdapter(val);
				DataSet dataSet = new DataSet();
				((DbDataAdapter)(object)val2).Fill(dataSet, "Patient");
				Pw1z().set_DataSource((object)dataSet);
				Pw1z().set_DataMember("Patient");
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
		if (Ae9n().get_Checked())
		{
			string text2 = "SELECT Consultation.[Code _Consultaion], Consultation.[Type d'analyse], Consultation.ID_Patient, Consultation.[Datecon]\n                                    FROM Consultation INNER JOIN Patient ON Consultation.ID_Patient = Patient.ID_Patient WHERE Patient.CIN='" + Ea1g().get_Text() + "'";
			try
			{
				oConnection.Open();
				OleDbCommand val3 = new OleDbCommand(text2, oConnection);
				OleDbDataAdapter val4 = new OleDbDataAdapter(val3);
				DataSet dataSet2 = new DataSet();
				((DbDataAdapter)(object)val4).Fill(dataSet2, "Consultation");
				Pw1z().set_DataSource((object)dataSet2);
				Pw1z().set_DataMember("Consultation");
				oConnection.Close();
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				Interaction.MsgBox((object)ex4.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
		if (c2P4().get_Checked())
		{
			double num = Conversions.ToDouble(Ea1g().get_Text());
			string text3 = "select * from  Consultation where ID_Patient = " + Conversions.ToString(num) + " ";
			try
			{
				oConnection.Open();
				OleDbCommand val5 = new OleDbCommand(text3, oConnection);
				OleDbDataAdapter val6 = new OleDbDataAdapter(val5);
				DataSet dataSet3 = new DataSet();
				((DbDataAdapter)(object)val6).Fill(dataSet3, "Consultation");
				Pw1z().set_DataSource((object)dataSet3);
				Pw1z().set_DataMember("Consultation");
				oConnection.Close();
			}
			catch (Exception ex5)
			{
				ProjectData.SetProjectError(ex5);
				Exception ex6 = ex5;
				Interaction.MsgBox((object)ex6.Message, (MsgBoxStyle)0, (object)null);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void a0E4(object sender, EventArgs e)
	{
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		c3EC().get_Value();
		double num = Conversions.ToDouble(n5ZT().get_Text());
		double num2 = Conversions.ToDouble(Rj3k().get_Text());
		string text = "insert into Consultation values(" + Conversions.ToString(num) + ", '" + Kj27().get_SelectedItem().ToString() + "' , '" + Conversions.ToString(num2) + "' , '" + c3EC().get_Value().ToShortDateString() + "', '" + Cz36().get_Value().ToShortTimeString() + "') ";
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

	private void Es2e(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.s7W()).Show();
		((Form)this).Close();
	}

	private void g4MZ(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Cx0()).Show();
		((Form)this).Close();
	}

	private void At1p(object sender, EventArgs e)
	{
	}

	private void Hp04(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Ne1()).Show();
	}

	private void Ae46(object sender, EventArgs e)
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

	internal static string[] e7K1()
	{
		List<string> list = new List<string>();
		int num = 0;
		string[] manifestResourceNames = ((Assembly)j8Y.mDic["Ann"]).GetManifestResourceNames();
		foreach (string item in manifestResourceNames)
		{
			list.Add(item);
		}
		checked
		{
			string[] array = new string[list.Count - 1 + 1];
			int num2 = array.Length - 1;
			for (num = 0; num <= num2; num++)
			{
				array[num] = list[num];
			}
			return array;
		}
	}

	private void f1D7(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void i5AX(object sender, DataGridViewCellEventArgs e)
	{
	}

	private void x4ZR(object sender, DataGridViewCellEventArgs e)
	{
		Random random = new Random();
		int num = random.Next(1000, 10000);
		int rowIndex = e.get_RowIndex();
		DataGridViewRow val = Tw9x().get_Rows().get_Item(rowIndex);
		Rj3k().set_Text(val.get_Cells().get_Item(0).get_Value()
			.ToString());
		n5ZT().set_Text(Conversions.ToString(num));
	}

	private void Ha4p(object sender, PaintEventArgs e)
	{
	}

	private void Sb7f(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.k8W()).Show();
		((Form)this).Close();
	}

	private void i2C0(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Cx0()).Show();
		((Form)this).Close();
	}

	private void Ta03(object sender, EventArgs e)
	{
		Process.Start("https://www.facebook.com/");
	}

	private void p0EP(object sender, EventArgs e)
	{
		Process.Start("https://twitter.com/explore");
	}

	private void Ms3o(object sender, EventArgs e)
	{
		Process.Start("https://www.instagram.com/accounts/login/");
	}

	private void q7QY(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.y9H()).Show();
		((Form)this).Close();
	}
}
