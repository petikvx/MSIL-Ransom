using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using o3C;
using s9X;

namespace En4;

[DesignerGenerated]
public class j9J : Form
{
	private Panel _Panel1;

	private GroupBox _GroupBox1;

	private Label _Label3;

	private Label _Label2;

	private TextBox _txt_homme;

	private TextBox _txt_femme;

	private TextBox _txt_patient;

	private GroupBox _GroupBox2;

	private TextBox _txt_vitesse;

	private Label _Label10;

	private TextBox _txt_hepatique;

	private Label _Label8;

	private TextBox _txt_Glycemie;

	private Label _Label14;

	private Label _Label13;

	private TextBox _txt_absent;

	private TextBox _txt_rdv;

	private TextBox _txt_present;

	private PictureBox _PictureBox4;

	private Label _Label15;

	private Label _Label16;

	private Label _Label17;

	private TextBox _txt_paye;

	private TextBox _txt_revenue;

	private Button _Button2;

	private Button _Button4;

	private OleDbConnection oConnection;

	internal IContainer w;

	internal Button A;

	internal Label J;

	internal PictureBox k;

	internal Label r;

	internal PictureBox Y;

	internal Label c;

	internal TextBox B;

	internal TextBox P;

	internal Label l;

	internal Label X;

	internal Label o;

	internal Label u;

	internal TextBox Q;

	internal TextBox S;

	internal GroupBox m;

	internal PictureBox T;

	internal Label H;

	internal GroupBox V;

	internal TextBox d;

	internal Button i;

	internal DateTimePicker n;

	internal Label F;

	internal string E;

	public j9J()
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		string text = (E = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\moham\\Desktop\\Base_Patient.mdb");
		oConnection = new OleDbConnection(E);
		Mp6();
	}

	protected override void Gc9(bool a6F)
	{
		try
		{
			if (a6F && w != null)
			{
				w.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(a6F);
		}
	}

	private void Mp6()
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
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cf: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Unknown result type (might be due to invalid IL or missing references)
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Unknown result type (might be due to invalid IL or missing references)
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a49: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c09: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c65: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1020: Unknown result type (might be due to invalid IL or missing references)
		//IL_1115: Unknown result type (might be due to invalid IL or missing references)
		//IL_1136: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_122b: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_1312: Unknown result type (might be due to invalid IL or missing references)
		//IL_136a: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_141a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1543: Unknown result type (might be due to invalid IL or missing references)
		//IL_1564: Unknown result type (might be due to invalid IL or missing references)
		//IL_15de: Unknown result type (might be due to invalid IL or missing references)
		//IL_1668: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_175b: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1823: Unknown result type (might be due to invalid IL or missing references)
		//IL_187c: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1954: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a24: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2e: Expected O, but got Unknown
		//IL_1aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1aac: Expected O, but got Unknown
		//IL_1aca: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c02: Unknown result type (might be due to invalid IL or missing references)
		s6L(new Panel());
		Aa1(new PictureBox());
		p6B(new Label());
		y8P(new Button());
		w2H(new GroupBox());
		Ne2(new Label());
		Le8(new Label());
		Jr4(new Label());
		c5E(new TextBox());
		c4P(new TextBox());
		Sk9(new TextBox());
		d7T(new PictureBox());
		g6A(new GroupBox());
		Ry8(new TextBox());
		e1R(new Label());
		Hd0(new Label());
		f0K(new TextBox());
		Fq0(new TextBox());
		t8P(new TextBox());
		Tw4(new Label());
		Rz4(new Label());
		i0N(new Label());
		Ng6(new Label());
		Xx6(new Label());
		w7C(new TextBox());
		Wg0(new TextBox());
		Xd3(new TextBox());
		My2(new GroupBox());
		Tt8(new Label());
		p9P(new Label());
		Jz7(new Label());
		r9E(new TextBox());
		Ts7(new TextBox());
		Bn4(new TextBox());
		n8S(new PictureBox());
		t4K(new GroupBox());
		Jx9(new Button());
		Fb1(new Label());
		Xr4(new Label());
		Gy1(new Label());
		g5W(new TextBox());
		c7J(new TextBox());
		m2W(new TextBox());
		Aw1(new PictureBox());
		p9T(new Button());
		b6A(new DateTimePicker());
		Qi8(new Label());
		f8Y(new Button());
		((Control)No2()).SuspendLayout();
		((ISupportInitialize)d7Q()).BeginInit();
		((Control)w8K()).SuspendLayout();
		((ISupportInitialize)p3R()).BeginInit();
		((Control)Hw1()).SuspendLayout();
		((Control)Cy0()).SuspendLayout();
		((ISupportInitialize)r5G()).BeginInit();
		((Control)d1P()).SuspendLayout();
		((ISupportInitialize)Aa9()).BeginInit();
		((Control)this).SuspendLayout();
		((Control)No2()).set_BackColor(Color.Black);
		((Control)No2()).get_Controls().Add((Control)(object)d7Q());
		((Control)No2()).get_Controls().Add((Control)(object)Lj1());
		((Control)No2()).get_Controls().Add((Control)(object)this.Nf6());
		((Control)No2()).set_ForeColor(SystemColors.ControlText);
		((Control)No2()).set_Location(new Point(-1, 0));
		((Control)No2()).set_Margin(new Padding(4));
		((Control)No2()).set_Name("Panel1");
		((Control)No2()).set_Size(new Size(1125, 80));
		((Control)No2()).set_TabIndex(8);
		((Control)d7Q()).set_Location(new Point(340, 16));
		((Control)d7Q()).set_Margin(new Padding(4));
		((Control)d7Q()).set_Name("PictureBox1");
		((Control)d7Q()).set_Size(new Size(47, 38));
		d7Q().set_SizeMode((PictureBoxSizeMode)1);
		d7Q().set_TabIndex(9);
		d7Q().set_TabStop(false);
		((Control)Lj1()).set_BackColor(Color.Black);
		((Control)Lj1()).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Lj1()).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)Lj1()).set_Location(new Point(411, 28));
		((Control)Lj1()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Lj1()).set_Name("Label1");
		((Control)Lj1()).set_Size(new Size(372, 26));
		((Control)Lj1()).set_TabIndex(6);
		Lj1().set_Text("Statistique  2020");
		((ButtonBase)this.Nf6()).set_FlatStyle((FlatStyle)1);
		((Control)this.Nf6()).set_Location(new Point(1065, 10));
		((Control)this.Nf6()).set_Margin(new Padding(4));
		((Control)this.Nf6()).set_Name("Button1");
		((Control)this.Nf6()).set_Size(new Size(41, 44));
		((Control)this.Nf6()).set_TabIndex(8);
		((ButtonBase)this.Nf6()).set_UseVisualStyleBackColor(true);
		((Control)w8K()).get_Controls().Add((Control)(object)a1Z());
		((Control)w8K()).get_Controls().Add((Control)(object)x0G());
		((Control)w8K()).get_Controls().Add((Control)(object)Ja8());
		((Control)w8K()).get_Controls().Add((Control)(object)Aj7());
		((Control)w8K()).get_Controls().Add((Control)(object)m6E());
		((Control)w8K()).get_Controls().Add((Control)(object)i8W());
		((Control)w8K()).get_Controls().Add((Control)(object)p3R());
		((Control)w8K()).set_Location(new Point(39, 140));
		((Control)w8K()).set_Margin(new Padding(4));
		((Control)w8K()).set_Name("GroupBox1");
		((Control)w8K()).set_Padding(new Padding(4));
		((Control)w8K()).set_Size(new Size(569, 238));
		((Control)w8K()).set_TabIndex(9);
		w8K().set_TabStop(false);
		w8K().set_Text("Patients");
		a1Z().set_AutoSize(true);
		((Control)a1Z()).set_Location(new Point(207, 113));
		((Control)a1Z()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)a1Z()).set_Name("Label4");
		((Control)a1Z()).set_Size(new Size(177, 17));
		((Control)a1Z()).set_TabIndex(6);
		a1Z().set_Text("Nombre de patient Homme");
		x0G().set_AutoSize(true);
		((Control)x0G()).set_Location(new Point(207, 166));
		((Control)x0G()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)x0G()).set_Name("Label3");
		((Control)x0G()).set_Size(new Size(171, 17));
		((Control)x0G()).set_TabIndex(5);
		x0G().set_Text("Nombre de patinet femme");
		Ja8().set_AutoSize(true);
		((Control)Ja8()).set_Location(new Point(207, 69));
		((Control)Ja8()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ja8()).set_Name("Label2");
		((Control)Ja8()).set_Size(new Size(126, 17));
		((Control)Ja8()).set_TabIndex(4);
		Ja8().set_Text("Nombre de Patient");
		((Control)Aj7()).set_Location(new Point(441, 110));
		((Control)Aj7()).set_Margin(new Padding(4));
		((Control)Aj7()).set_Name("txt_homme");
		((Control)Aj7()).set_Size(new Size(73, 22));
		((Control)Aj7()).set_TabIndex(3);
		((Control)m6E()).set_Location(new Point(441, 162));
		((Control)m6E()).set_Margin(new Padding(4));
		((Control)m6E()).set_Name("txt_femme");
		((Control)m6E()).set_Size(new Size(73, 22));
		((Control)m6E()).set_TabIndex(2);
		((Control)i8W()).set_Location(new Point(441, 60));
		((Control)i8W()).set_Margin(new Padding(4));
		((Control)i8W()).set_Name("txt_patient");
		((Control)i8W()).set_Size(new Size(73, 22));
		((Control)i8W()).set_TabIndex(1);
		((Control)p3R()).set_Location(new Point(28, 36));
		((Control)p3R()).set_Margin(new Padding(4));
		((Control)p3R()).set_Name("PictureBox2");
		((Control)p3R()).set_Size(new Size(171, 151));
		p3R().set_SizeMode((PictureBoxSizeMode)1);
		p3R().set_TabIndex(0);
		p3R().set_TabStop(false);
		((Control)Hw1()).get_Controls().Add((Control)(object)q3K());
		((Control)Hw1()).get_Controls().Add((Control)(object)Gz1());
		((Control)Hw1()).get_Controls().Add((Control)(object)x5D());
		((Control)Hw1()).get_Controls().Add((Control)(object)Yw7());
		((Control)Hw1()).get_Controls().Add((Control)(object)Nn2());
		((Control)Hw1()).get_Controls().Add((Control)(object)Zi7());
		((Control)Hw1()).get_Controls().Add((Control)(object)Rb4());
		((Control)Hw1()).get_Controls().Add((Control)(object)a6E());
		((Control)Hw1()).get_Controls().Add((Control)(object)y8C());
		((Control)Hw1()).get_Controls().Add((Control)(object)Ms3());
		((Control)Hw1()).get_Controls().Add((Control)(object)Dd8());
		((Control)Hw1()).get_Controls().Add((Control)(object)s5J());
		((Control)Hw1()).get_Controls().Add((Control)(object)f2Q());
		((Control)Hw1()).get_Controls().Add((Control)(object)this.Nf6());
		((Control)Hw1()).set_Location(new Point(39, 424));
		((Control)Hw1()).set_Margin(new Padding(4));
		((Control)Hw1()).set_Name("GroupBox2");
		((Control)Hw1()).set_Padding(new Padding(4));
		((Control)Hw1()).set_Size(new Size(569, 276));
		((Control)Hw1()).set_TabIndex(10);
		Hw1().set_TabStop(false);
		Hw1().set_Text("Analyse");
		((Control)q3K()).set_Location(new Point(489, 219));
		((Control)q3K()).set_Margin(new Padding(4));
		((Control)q3K()).set_Name("txt_vitesse");
		((Control)q3K()).set_Size(new Size(65, 22));
		((Control)q3K()).set_TabIndex(17);
		Gz1().set_AutoSize(true);
		((Control)Gz1()).set_Location(new Point(311, 162));
		((Control)Gz1()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Gz1()).set_Name("Label11");
		((Control)Gz1()).set_Size(new Size(124, 17));
		((Control)Gz1()).set_TabIndex(16);
		Gz1().set_Text("Analyses urinaires");
		x5D().set_AutoSize(true);
		((Control)x5D()).set_Location(new Point(311, 223));
		((Control)x5D()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)x5D()).set_Name("Label10");
		((Control)x5D()).set_Size(new Size(166, 17));
		((Control)x5D()).set_TabIndex(15);
		x5D().set_Text("Vitesse de sédimentation");
		((Control)Yw7()).set_Location(new Point(489, 91));
		((Control)Yw7()).set_Margin(new Padding(4));
		((Control)Yw7()).set_Name("txt_hepatique");
		((Control)Yw7()).set_Size(new Size(63, 22));
		((Control)Yw7()).set_TabIndex(14);
		((Control)Nn2()).set_Location(new Point(489, 154));
		((Control)Nn2()).set_Margin(new Padding(4));
		((Control)Nn2()).set_Name("txt_urines");
		((Control)Nn2()).set_Size(new Size(63, 22));
		((Control)Nn2()).set_TabIndex(13);
		((Control)Zi7()).set_Location(new Point(207, 214));
		((Control)Zi7()).set_Margin(new Padding(4));
		((Control)Zi7()).set_Name("txt_echographie");
		((Control)Zi7()).set_Size(new Size(65, 22));
		((Control)Zi7()).set_TabIndex(12);
		Rb4().set_AutoSize(true);
		((Control)Rb4()).set_Location(new Point(24, 91));
		((Control)Rb4()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Rb4()).set_Name("Label9");
		((Control)Rb4()).set_Size(new Size(93, 17));
		((Control)Rb4()).set_TabIndex(11);
		Rb4().set_Text("Bilan sanguin");
		a6E().set_AutoSize(true);
		((Control)a6E()).set_Location(new Point(24, 158));
		((Control)a6E()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)a6E()).set_Name("Label8");
		((Control)a6E()).set_Size(new Size(66, 17));
		((Control)a6E()).set_TabIndex(10);
		a6E().set_Text("Glycémie");
		y8C().set_AutoSize(true);
		((Control)y8C()).set_Location(new Point(28, 223));
		((Control)y8C()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)y8C()).set_Name("Label7");
		((Control)y8C()).set_Size(new Size(88, 17));
		((Control)y8C()).set_TabIndex(9);
		y8C().set_Text("Échographie");
		Ms3().set_AutoSize(true);
		((Control)Ms3()).set_Location(new Point(311, 95));
		((Control)Ms3()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Ms3()).set_Name("Label6");
		((Control)Ms3()).set_Size(new Size(106, 17));
		((Control)Ms3()).set_TabIndex(8);
		Ms3().set_Text("Bilan hépatique");
		Dd8().set_AutoSize(true);
		((Control)Dd8()).set_Location(new Point(28, 32));
		((Control)Dd8()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Dd8()).set_Name("Label5");
		((Control)Dd8()).set_Size(new Size(196, 17));
		((Control)Dd8()).set_TabIndex(7);
		Dd8().set_Text("Nombre d'analyse effectuées ");
		((Control)s5J()).set_Location(new Point(209, 91));
		((Control)s5J()).set_Margin(new Padding(4));
		((Control)s5J()).set_Name("txt_sang");
		((Control)s5J()).set_Size(new Size(63, 22));
		((Control)s5J()).set_TabIndex(4);
		((Control)f2Q()).set_Location(new Point(211, 149));
		((Control)f2Q()).set_Margin(new Padding(4));
		((Control)f2Q()).set_Name("txt_Glycemie");
		((Control)f2Q()).set_Size(new Size(61, 22));
		((Control)f2Q()).set_TabIndex(3);
		((Control)this.Nf6()).set_Location(new Point(235, 28));
		((Control)this.Nf6()).set_Margin(new Padding(4));
		((Control)this.Nf6()).set_Name("txt_nbrvisite");
		((Control)this.Nf6()).set_Size(new Size(123, 22));
		((Control)this.Nf6()).set_TabIndex(2);
		((Control)Cy0()).get_Controls().Add((Control)(object)t0A());
		((Control)Cy0()).get_Controls().Add((Control)(object)Kr1());
		((Control)Cy0()).get_Controls().Add((Control)(object)m3W());
		((Control)Cy0()).get_Controls().Add((Control)(object)Dz2());
		((Control)Cy0()).get_Controls().Add((Control)(object)d0R());
		((Control)Cy0()).get_Controls().Add((Control)(object)Lq2());
		((Control)Cy0()).get_Controls().Add((Control)(object)r5G());
		((Control)Cy0()).set_Location(new Point(645, 140));
		((Control)Cy0()).set_Margin(new Padding(4));
		((Control)Cy0()).set_Name("Rendez_Vous");
		((Control)Cy0()).set_Padding(new Padding(4));
		((Control)Cy0()).set_Size(new Size(443, 238));
		((Control)Cy0()).set_TabIndex(11);
		Cy0().set_TabStop(false);
		Cy0().set_Text("Rendez_Vous");
		t0A().set_AutoSize(true);
		((Control)t0A()).set_Location(new Point(209, 171));
		((Control)t0A()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)t0A()).set_Name("Label14");
		((Control)t0A()).set_Size(new Size(59, 17));
		((Control)t0A()).set_TabIndex(20);
		t0A().set_Text("Absents");
		Kr1().set_AutoSize(true);
		((Control)Kr1()).set_Location(new Point(209, 110));
		((Control)Kr1()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Kr1()).set_Name("Label12");
		((Control)Kr1()).set_Size(new Size(64, 17));
		((Control)Kr1()).set_TabIndex(18);
		Kr1().set_Text("Présents");
		m3W().set_AutoSize(true);
		((Control)m3W()).set_Location(new Point(209, 36));
		((Control)m3W()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)m3W()).set_Name("Label13");
		((Control)m3W()).set_Size(new Size(159, 17));
		((Control)m3W()).set_TabIndex(19);
		m3W().set_Text("Rendez_vous Réservés");
		((Control)Dz2()).set_Location(new Point(213, 194));
		((Control)Dz2()).set_Margin(new Padding(4));
		((Control)Dz2()).set_Name("txt_absent");
		((Control)Dz2()).set_Size(new Size(123, 22));
		((Control)Dz2()).set_TabIndex(5);
		((Control)d0R()).set_Location(new Point(213, 60));
		((Control)d0R()).set_Margin(new Padding(4));
		((Control)d0R()).set_Name("txt_rdv");
		((Control)d0R()).set_Size(new Size(123, 22));
		((Control)d0R()).set_TabIndex(4);
		((Control)Lq2()).set_Location(new Point(213, 132));
		((Control)Lq2()).set_Margin(new Padding(4));
		((Control)Lq2()).set_Name("txt_present");
		((Control)Lq2()).set_Size(new Size(123, 22));
		((Control)Lq2()).set_TabIndex(3);
		((Control)r5G()).set_Location(new Point(31, 60));
		((Control)r5G()).set_Margin(new Padding(4));
		((Control)r5G()).set_Name("PictureBox3");
		((Control)r5G()).set_Size(new Size(155, 132));
		r5G().set_SizeMode((PictureBoxSizeMode)1);
		r5G().set_TabIndex(0);
		r5G().set_TabStop(false);
		((Control)d1P()).get_Controls().Add((Control)(object)k0C());
		((Control)d1P()).get_Controls().Add((Control)(object)t7E());
		((Control)d1P()).get_Controls().Add((Control)(object)o5W());
		((Control)d1P()).get_Controls().Add((Control)(object)Gr0());
		((Control)d1P()).get_Controls().Add((Control)(object)g3F());
		((Control)d1P()).get_Controls().Add((Control)(object)z2S());
		((Control)d1P()).get_Controls().Add((Control)(object)Mr6());
		((Control)d1P()).get_Controls().Add((Control)(object)Aa9());
		((Control)d1P()).set_Location(new Point(645, 422));
		((Control)d1P()).set_Margin(new Padding(4));
		((Control)d1P()).set_Name("GroupBox4");
		((Control)d1P()).set_Padding(new Padding(4));
		((Control)d1P()).set_Size(new Size(443, 278));
		((Control)d1P()).set_TabIndex(12);
		d1P().set_TabStop(false);
		d1P().set_Text("Réglement");
		((ButtonBase)k0C()).set_FlatStyle((FlatStyle)0);
		((Control)k0C()).set_Location(new Point(129, 242));
		((Control)k0C()).set_Margin(new Padding(4));
		((Control)k0C()).set_Name("Button3");
		((Control)k0C()).set_Size(new Size(175, 28));
		((Control)k0C()).set_TabIndex(14);
		((ButtonBase)k0C()).set_Text("Bilan des paiements");
		((ButtonBase)k0C()).set_UseVisualStyleBackColor(true);
		t7E().set_AutoSize(true);
		((Control)t7E()).set_Location(new Point(209, 186));
		((Control)t7E()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)t7E()).set_Name("Label15");
		((Control)t7E()).set_Size(new Size(70, 17));
		((Control)t7E()).set_TabIndex(21);
		t7E().set_Text("Non-payé");
		o5W().set_AutoSize(true);
		((Control)o5W()).set_Location(new Point(209, 129));
		((Control)o5W()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)o5W()).set_Name("Label16");
		((Control)o5W()).set_Size(new Size(40, 17));
		((Control)o5W()).set_TabIndex(22);
		o5W().set_Text("Payé");
		Gr0().set_AutoSize(true);
		((Control)Gr0()).set_Location(new Point(209, 41));
		((Control)Gr0()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Gr0()).set_Name("Label17");
		((Control)Gr0()).set_Size(new Size(120, 17));
		((Control)Gr0()).set_TabIndex(23);
		Gr0().set_Text("Totale Revenues ");
		((Control)g3F()).set_Location(new Point(213, 209));
		((Control)g3F()).set_Margin(new Padding(4));
		((Control)g3F()).set_Name("txt_npaye");
		((Control)g3F()).set_Size(new Size(123, 22));
		((Control)g3F()).set_TabIndex(21);
		((Control)z2S()).set_Location(new Point(213, 149));
		((Control)z2S()).set_Margin(new Padding(4));
		((Control)z2S()).set_Name("txt_paye");
		((Control)z2S()).set_Size(new Size(123, 22));
		((Control)z2S()).set_TabIndex(22);
		((Control)Mr6()).set_Location(new Point(213, 74));
		((Control)Mr6()).set_Margin(new Padding(4));
		((Control)Mr6()).set_Name("txt_revenue");
		((Control)Mr6()).set_Size(new Size(123, 22));
		((Control)Mr6()).set_TabIndex(23);
		((Control)Aa9()).set_Location(new Point(31, 81));
		((Control)Aa9()).set_Margin(new Padding(4));
		((Control)Aa9()).set_Name("PictureBox4");
		((Control)Aa9()).set_Size(new Size(133, 121));
		Aa9().set_SizeMode((PictureBoxSizeMode)1);
		Aa9().set_TabIndex(0);
		Aa9().set_TabStop(false);
		((ButtonBase)j4Q()).set_FlatStyle((FlatStyle)0);
		((Control)j4Q()).set_Location(new Point(548, 725));
		((Control)j4Q()).set_Margin(new Padding(4));
		((Control)j4Q()).set_Name("Button2");
		((Control)j4Q()).set_Size(new Size(175, 28));
		((Control)j4Q()).set_TabIndex(13);
		((ButtonBase)j4Q()).set_Text("Retour");
		((ButtonBase)j4Q()).set_UseVisualStyleBackColor(true);
		j9W().set_Format((DateTimePickerFormat)2);
		((Control)j9W()).set_Location(new Point(300, 111));
		((Control)j9W()).set_Name("DateTimePicker1");
		((Control)j9W()).set_Size(new Size(200, 22));
		((Control)j9W()).set_TabIndex(14);
		d0W().set_AutoSize(true);
		((Control)d0W()).set_Font(new Font("Microsoft YaHei", 7.8f, (FontStyle)3, (GraphicsUnit)3, (byte)0));
		((Control)d0W()).set_Location(new Point(53, 111));
		((Control)d0W()).set_Name("Label18");
		((Control)d0W()).set_Size(new Size(180, 19));
		((Control)d0W()).set_TabIndex(15);
		d0W().set_Text("Veuillez Choisir une date");
		((ButtonBase)Zk7()).set_FlatStyle((FlatStyle)0);
		((Control)Zk7()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Zk7()).set_Location(new Point(548, 102));
		((Control)Zk7()).set_Margin(new Padding(4));
		((Control)Zk7()).set_Name("Button4");
		((Control)Zk7()).set_Size(new Size(175, 28));
		((Control)Zk7()).set_TabIndex(16);
		((ButtonBase)Zk7()).set_Text("Afficher");
		((ButtonBase)Zk7()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.LightGreen);
		((Form)this).set_ClientSize(new Size(1121, 793));
		((Control)this).get_Controls().Add((Control)(object)Zk7());
		((Control)this).get_Controls().Add((Control)(object)d0W());
		((Control)this).get_Controls().Add((Control)(object)j9W());
		((Control)this).get_Controls().Add((Control)(object)j4Q());
		((Control)this).get_Controls().Add((Control)(object)d1P());
		((Control)this).get_Controls().Add((Control)(object)Cy0());
		((Control)this).get_Controls().Add((Control)(object)Hw1());
		((Control)this).get_Controls().Add((Control)(object)w8K());
		((Control)this).get_Controls().Add((Control)(object)No2());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("Form10");
		((Form)this).set_Text("Form10");
		((Control)No2()).ResumeLayout(false);
		((ISupportInitialize)d7Q()).EndInit();
		((Control)w8K()).ResumeLayout(false);
		((Control)w8K()).PerformLayout();
		((ISupportInitialize)p3R()).EndInit();
		((Control)Hw1()).ResumeLayout(false);
		((Control)Hw1()).PerformLayout();
		((Control)Cy0()).ResumeLayout(false);
		((Control)Cy0()).PerformLayout();
		((ISupportInitialize)r5G()).EndInit();
		((Control)d1P()).ResumeLayout(false);
		((Control)d1P()).PerformLayout();
		((ISupportInitialize)Aa9()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel No2()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s6L(Panel Zc1)
	{
		_Panel1 = Zc1;
	}

	[SpecialName]
	internal virtual Button Nf6()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y8P(Button a8F)
	{
		EventHandler eventHandler = Zx4;
		Button a = A;
		if (a != null)
		{
			((Control)a).remove_Click(eventHandler);
		}
		Button val = (A = a8F);
		a = A;
		if (a != null)
		{
			((Control)a).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Lj1()
	{
		return J;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p6B(Label Gx8)
	{
		Label val = (J = Gx8);
	}

	[SpecialName]
	internal virtual PictureBox d7Q()
	{
		return k;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aa1(PictureBox b7S)
	{
		PictureBox val = (k = b7S);
	}

	[SpecialName]
	internal virtual GroupBox w8K()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2H(GroupBox Kz0)
	{
		_GroupBox1 = Kz0;
	}

	[SpecialName]
	internal virtual Label a1Z()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ne2(Label a6L)
	{
		Label val = (r = a6L);
	}

	[SpecialName]
	internal virtual Label x0G()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Le8(Label Yt2)
	{
		_Label3 = Yt2;
	}

	[SpecialName]
	internal virtual Label Ja8()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jr4(Label Tw8)
	{
		_Label2 = Tw8;
	}

	[SpecialName]
	internal virtual TextBox Aj7()
	{
		return _txt_homme;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5E(TextBox m5X)
	{
		_txt_homme = m5X;
	}

	[SpecialName]
	internal virtual TextBox m6E()
	{
		return _txt_femme;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c4P(TextBox Aa4)
	{
		_txt_femme = Aa4;
	}

	[SpecialName]
	internal virtual TextBox i8W()
	{
		return _txt_patient;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Sk9(TextBox Sx4)
	{
		_txt_patient = Sx4;
	}

	[SpecialName]
	internal virtual PictureBox p3R()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d7T(PictureBox En8)
	{
		PictureBox val = (Y = En8);
	}

	[SpecialName]
	internal virtual GroupBox Hw1()
	{
		return _GroupBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g6A(GroupBox Dp8)
	{
		_GroupBox2 = Dp8;
	}

	[SpecialName]
	internal virtual TextBox q3K()
	{
		return _txt_vitesse;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ry8(TextBox x3S)
	{
		_txt_vitesse = x3S;
	}

	[SpecialName]
	internal virtual Label Gz1()
	{
		return c;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e1R(Label z7D)
	{
		Label val = (c = z7D);
	}

	[SpecialName]
	internal virtual Label x5D()
	{
		return _Label10;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hd0(Label Te7)
	{
		_Label10 = Te7;
	}

	[SpecialName]
	internal virtual TextBox Yw7()
	{
		return _txt_hepatique;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f0K(TextBox p5K)
	{
		_txt_hepatique = p5K;
	}

	[SpecialName]
	internal virtual TextBox Nn2()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fq0(TextBox Tx8)
	{
		TextBox val = (B = Tx8);
	}

	[SpecialName]
	internal virtual TextBox Zi7()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t8P(TextBox Ds3)
	{
		TextBox val = (P = Ds3);
	}

	[SpecialName]
	internal virtual Label Rb4()
	{
		return l;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tw4(Label r9C)
	{
		Label val = (l = r9C);
	}

	[SpecialName]
	internal virtual Label a6E()
	{
		return _Label8;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rz4(Label Sb6)
	{
		_Label8 = Sb6;
	}

	[SpecialName]
	internal virtual Label y8C()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i0N(Label p4E)
	{
		Label val = (X = p4E);
	}

	[SpecialName]
	internal virtual Label Ms3()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ng6(Label Zk5)
	{
		Label val = (o = Zk5);
	}

	[SpecialName]
	internal virtual Label Dd8()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xx6(Label a2M)
	{
		Label val = (u = a2M);
	}

	[SpecialName]
	internal virtual TextBox s5J()
	{
		return Q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w7C(TextBox y3M)
	{
		TextBox val = (Q = y3M);
	}

	[SpecialName]
	internal virtual TextBox f2Q()
	{
		return _txt_Glycemie;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wg0(TextBox Dr1)
	{
		_txt_Glycemie = Dr1;
	}

	[SpecialName]
	internal virtual TextBox Nf6()
	{
		return S;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xd3(TextBox Lp8)
	{
		TextBox val = (S = Lp8);
	}

	[SpecialName]
	internal virtual GroupBox Cy0()
	{
		return m;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void My2(GroupBox f9N)
	{
		EventHandler eventHandler = m4F;
		GroupBox val = m;
		if (val != null)
		{
			((Control)val).remove_Enter(eventHandler);
		}
		GroupBox val2 = (m = f9N);
		val = m;
		if (val != null)
		{
			((Control)val).add_Enter(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox r5G()
	{
		return T;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void n8S(PictureBox g9A)
	{
		PictureBox val = (T = g9A);
	}

	[SpecialName]
	internal virtual Label t0A()
	{
		return _Label14;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tt8(Label j9Y)
	{
		_Label14 = j9Y;
	}

	[SpecialName]
	internal virtual Label Kr1()
	{
		return H;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9P(Label Zx2)
	{
		Label val = (H = Zx2);
	}

	[SpecialName]
	internal virtual Label m3W()
	{
		return _Label13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jz7(Label Zt3)
	{
		_Label13 = Zt3;
	}

	[SpecialName]
	internal virtual TextBox Dz2()
	{
		return _txt_absent;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void r9E(TextBox j2C)
	{
		_txt_absent = j2C;
	}

	[SpecialName]
	internal virtual TextBox d0R()
	{
		return _txt_rdv;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ts7(TextBox Ao0)
	{
		_txt_rdv = Ao0;
	}

	[SpecialName]
	internal virtual TextBox Lq2()
	{
		return _txt_present;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bn4(TextBox r9C)
	{
		_txt_present = r9C;
	}

	[SpecialName]
	internal virtual GroupBox d1P()
	{
		return V;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t4K(GroupBox a8T)
	{
		EventHandler eventHandler = r0F;
		GroupBox v = V;
		if (v != null)
		{
			((Control)v).remove_Enter(eventHandler);
		}
		GroupBox val = (V = a8T);
		v = V;
		if (v != null)
		{
			((Control)v).add_Enter(eventHandler);
		}
	}

	[SpecialName]
	internal virtual PictureBox Aa9()
	{
		return _PictureBox4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Aw1(PictureBox Sx1)
	{
		_PictureBox4 = Sx1;
	}

	[SpecialName]
	internal virtual Label t7E()
	{
		return _Label15;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fb1(Label n8K)
	{
		_Label15 = n8K;
	}

	[SpecialName]
	internal virtual Label o5W()
	{
		return _Label16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xr4(Label Dj3)
	{
		_Label16 = Dj3;
	}

	[SpecialName]
	internal virtual Label Gr0()
	{
		return _Label17;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gy1(Label Kq2)
	{
		_Label17 = Kq2;
	}

	[SpecialName]
	internal virtual TextBox g3F()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5W(TextBox Ym7)
	{
		TextBox val = (d = Ym7);
	}

	[SpecialName]
	internal virtual TextBox z2S()
	{
		return _txt_paye;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c7J(TextBox y4Y)
	{
		_txt_paye = y4Y;
	}

	[SpecialName]
	internal virtual TextBox Mr6()
	{
		return _txt_revenue;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2W(TextBox j0P)
	{
		_txt_revenue = j0P;
	}

	[SpecialName]
	internal virtual Button j4Q()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9T(Button i6Q)
	{
		EventHandler eventHandler = Bq7;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = i6Q;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button k0C()
	{
		return i;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jx9(Button Ti3)
	{
		EventHandler eventHandler = e4W;
		Button val = i;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (i = Ti3);
		val = i;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual DateTimePicker j9W()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b6A(DateTimePicker Hf7)
	{
		EventHandler eventHandler = Bp7;
		DateTimePicker val = n;
		if (val != null)
		{
			val.remove_ValueChanged(eventHandler);
		}
		DateTimePicker val2 = (n = Hf7);
		val = n;
		if (val != null)
		{
			val.add_ValueChanged(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label d0W()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qi8(Label Fs2)
	{
		Label val = (F = Fs2);
	}

	[SpecialName]
	internal virtual Button Zk7()
	{
		return _Button4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8Y(Button Hy9)
	{
		EventHandler eventHandler = o7A;
		Button button = _Button4;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button4 = Hy9;
		button = _Button4;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	private void Zx4(object sender, EventArgs e)
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

	private void Bq7(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.k8W()).Show();
		((Form)this).Close();
	}

	private void m4F(object sender, EventArgs e)
	{
	}

	private void e4W(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.e9P()).Show();
		((Form)this).Close();
	}

	private void r0F(object sender, EventArgs e)
	{
	}

	private void Bp7(object sender, EventArgs e)
	{
	}

	internal static bool m8P(int n4Y)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(n4Y + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				n4Y = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				n4Y = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				n4Y = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void o7A(object sender, EventArgs e)
	{
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0132: Expected O, but got Unknown
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_01df: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_0315: Unknown result type (might be due to invalid IL or missing references)
		//IL_031c: Expected O, but got Unknown
		//IL_036f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0376: Expected O, but got Unknown
		//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d0: Expected O, but got Unknown
		//IL_0423: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Expected O, but got Unknown
		//IL_047d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0484: Expected O, but got Unknown
		//IL_04d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04de: Expected O, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_0538: Expected O, but got Unknown
		//IL_058b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0592: Expected O, but got Unknown
		//IL_05e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_0654: Unknown result type (might be due to invalid IL or missing references)
		string text = "Bilan sanguin";
		string text2 = "Bilan hépatique";
		string text3 = "Glycémie";
		string text4 = "Vitesse de sédimentation";
		string text5 = "Analyses urinaires";
		string text6 = "Échographie";
		string text7 = "Homme";
		string text8 = "Femme";
		string text9 = "Oui";
		string text10 = "Non";
		string text11 = "SELECT Count(ID_Patient) AS NumberPatient FROM Patient ";
		string text12 = "SELECT Count(ID_Patient) AS NumberPatientH FROM Patient where Sexe= '" + text7 + "'";
		string text13 = "SELECT Count(ID_Patient) AS NumberPatientF FROM Patient where Sexe='" + text8 + "'";
		string text14 = "SELECT COUNT( *) AS NumberConst FROM Consultation";
		string text15 = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" + text + "')); ";
		string text16 = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" + text2 + "')); ";
		string text17 = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" + text3 + "')); ";
		string text18 = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" + text4 + "')); ";
		string text19 = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" + text5 + "')); ";
		string text20 = "SELECT COUNT(*) AS NumberConstB FROM Consultation WHERE (((Consultation.[Type d'analyse])='" + text6 + "')); ";
		string text21 = "SELECT SUM(Montant) FROM Reglement";
		string text22 = "SELECT SUM(Montant) FROM Reglement WHERE payé= '" + text9 + "' ";
		string text23 = "SELECT SUM(Montant) FROM Reglement WHERE payé= '" + text10 + "' ";
		string text24 = "SELECT COUNT(*) FROM Reglement";
		try
		{
			oConnection.Open();
			OleDbCommand val = new OleDbCommand(text11, oConnection);
			OleDbDataReader val2 = val.ExecuteReader();
			int num = default(int);
			while (val2.Read())
			{
				num = Conversions.ToInteger(val2.GetValue(0));
			}
			i8W().set_Text(Conversions.ToString(num));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val3 = new OleDbCommand(text12, oConnection);
			OleDbDataReader val4 = val3.ExecuteReader();
			int num2 = default(int);
			while (val4.Read())
			{
				num2 = Conversions.ToInteger(val4.GetValue(0));
			}
			Aj7().set_Text(Conversions.ToString(num2));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val5 = new OleDbCommand(text13, oConnection);
			OleDbDataReader val6 = val5.ExecuteReader();
			int num3 = default(int);
			while (val6.Read())
			{
				num3 = Conversions.ToInteger(val6.GetValue(0));
			}
			m6E().set_Text(Conversions.ToString(num3));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val7 = new OleDbCommand(text14, oConnection);
			OleDbDataReader val8 = val7.ExecuteReader();
			while (val8.Read())
			{
				num3 = Conversions.ToInteger(val8.GetValue(0));
			}
			this.Nf6().set_Text(Conversions.ToString(num3));
			Lq2().set_Text(this.Nf6().get_Text());
			Lq2().set_Text(Conversions.ToString(num));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val9 = new OleDbCommand(text15, oConnection);
			OleDbDataReader val10 = val9.ExecuteReader();
			while (val10.Read())
			{
				num3 = Conversions.ToInteger(val10.GetValue(0));
			}
			s5J().set_Text(Conversions.ToString(num3));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val11 = new OleDbCommand(text16, oConnection);
			OleDbDataReader val12 = val11.ExecuteReader();
			while (val12.Read())
			{
				num3 = Conversions.ToInteger(val12.GetValue(0));
			}
			Yw7().set_Text(Conversions.ToString(num3));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val13 = new OleDbCommand(text17, oConnection);
			OleDbDataReader val14 = val13.ExecuteReader();
			while (val14.Read())
			{
				num3 = Conversions.ToInteger(val14.GetValue(0));
			}
			f2Q().set_Text(Conversions.ToString(num3));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val15 = new OleDbCommand(text18, oConnection);
			OleDbDataReader val16 = val15.ExecuteReader();
			while (val16.Read())
			{
				num3 = Conversions.ToInteger(val16.GetValue(0));
			}
			q3K().set_Text(Conversions.ToString(num3));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val17 = new OleDbCommand(text19, oConnection);
			OleDbDataReader val18 = val17.ExecuteReader();
			while (val18.Read())
			{
				num3 = Conversions.ToInteger(val18.GetValue(0));
			}
			Nn2().set_Text(Conversions.ToString(num3));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val19 = new OleDbCommand(text20, oConnection);
			OleDbDataReader val20 = val19.ExecuteReader();
			while (val20.Read())
			{
				num3 = Conversions.ToInteger(val20.GetValue(0));
			}
			Zi7().set_Text(Conversions.ToString(num3));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val21 = new OleDbCommand(text21, oConnection);
			OleDbDataReader val22 = val21.ExecuteReader();
			while (val22.Read())
			{
				num3 = Conversions.ToInteger(val22.GetValue(0));
			}
			Mr6().set_Text(Conversions.ToString(num3));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val23 = new OleDbCommand(text22, oConnection);
			OleDbDataReader val24 = val23.ExecuteReader();
			while (val24.Read())
			{
				num3 = Conversions.ToInteger(val24.GetValue(0));
			}
			z2S().set_Text(Conversions.ToString(num3));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val25 = new OleDbCommand(text23, oConnection);
			OleDbDataReader val26 = val25.ExecuteReader();
			while (val26.Read())
			{
				num3 = Conversions.ToInteger(val26.GetValue(0));
			}
			g3F().set_Text(Conversions.ToString(num3));
			oConnection.Close();
			oConnection.Open();
			OleDbCommand val27 = new OleDbCommand(text24, oConnection);
			OleDbDataReader val28 = val27.ExecuteReader();
			while (val28.Read())
			{
				num3 = Conversions.ToInteger(val28.GetValue(0));
			}
			d0R().set_Text(Conversions.ToString(num3));
			Dz2().set_Text(Conversions.ToString(checked(num3 - num)));
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

	internal static bool Cc9()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string lt in array2)
				{
					if (!d0F.j7X(lt))
					{
						if (num > 0)
						{
							num--;
						}
						Task.Delay(30000).Wait();
					}
					else
					{
						num++;
					}
				}
			}
			if (num == 2)
			{
				return true;
			}
			return false;
		}
	}
}
