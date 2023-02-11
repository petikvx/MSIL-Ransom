using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Tm8;
using b8X2;
using o3C;

namespace c8DW;

[DesignerGenerated]
public class m5N4 : Form
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 25292)]
	private struct Ky4j
	{
	}

	private IContainer components;

	private Button _Button2;

	private Label _Label4;

	private GroupBox _GroupBox1;

	private TextBox _txt_Tension;

	private Label _Label7;

	private Label _Label9;

	private GroupBox _GroupBox2;

	private TextBox _txt_Analyse;

	private Label _Label2;

	private TextBox _TextBox2;

	private Label _Label3;

	private Button _Button16;

	private Label _labelp;

	private Label _Label13;

	private static readonly object e;

	private static readonly Array m;

	private static readonly Array q;

	internal static byte l/* Not supported: data(00) */;

	internal Panel q;

	internal TextBox X;

	internal TextBox d;

	internal TextBox n;

	internal TextBox e;

	internal TextBox p;

	internal Label K;

	internal Label B;

	internal Label o;

	internal Label G;

	internal Label U;

	internal TextBox M;

	internal Label a;

	internal Button w;

	internal Label F;

	public m5N4()
	{
		((Form)this).add_Load((EventHandler)k6AD);
		j0Y7();
	}

	protected override void Pa6y(bool Be18)
	{
		try
		{
			if (Be18 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Be18);
		}
	}

	private void j0Y7()
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
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0227: Expected O, but got Unknown
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_064d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_072b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0787: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Unknown result type (might be due to invalid IL or missing references)
		//IL_089b: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a29: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b2b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c84: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e29: Expected O, but got Unknown
		//IL_0e5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edd: Expected O, but got Unknown
		//IL_0f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1059: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139: Unknown result type (might be due to invalid IL or missing references)
		z8TX(new Panel());
		e8E7(new Label());
		Yn1o(new GroupBox());
		w2RB(new Label());
		f8ZR(new Label());
		Db2w(new Label());
		Gr2q(new Label());
		w4E1(new Label());
		x7Z9(new Label());
		y5A0(new TextBox());
		Jk6i(new TextBox());
		d4D8(new TextBox());
		y1M9(new TextBox());
		b5A1(new TextBox());
		q1FZ(new TextBox());
		Fc83(new GroupBox());
		Fo3e(new Label());
		p0H4(new Label());
		a4T8(new Label());
		s5B3(new Label());
		k1ZC(new TextBox());
		Jx47(new TextBox());
		Rf36(new Label());
		Jc02(new TextBox());
		Tm1n(new Button());
		Yq8m(new Button());
		Yg90(new Label());
		i0J6(new Label());
		Pd1m(new Button());
		((Control)Pp3i()).SuspendLayout();
		((Control)Ti79()).SuspendLayout();
		((Control)Fm4k()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Pp3i()).set_BackColor(Color.Black);
		((Control)Pp3i()).get_Controls().Add((Control)(object)Jx2r());
		((Control)Pp3i()).get_Controls().Add((Control)(object)a2Y5());
		((Control)Pp3i()).set_Location(new Point(-3, 0));
		((Control)Pp3i()).set_Margin(new Padding(4));
		((Control)Pp3i()).set_Name("Panel1");
		((Control)Pp3i()).set_Size(new Size(1224, 48));
		((Control)Pp3i()).set_TabIndex(9);
		((Control)a2Y5()).set_BackColor(Color.Black);
		((Control)a2Y5()).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)a2Y5()).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)a2Y5()).set_Location(new Point(381, 14));
		((Control)a2Y5()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)a2Y5()).set_Name("Label4");
		((Control)a2Y5()).set_Size(new Size(372, 26));
		((Control)a2Y5()).set_TabIndex(6);
		a2Y5().set_Text("Fin Consultation");
		((Control)Ti79()).get_Controls().Add((Control)(object)Zw82());
		((Control)Ti79()).get_Controls().Add((Control)(object)p9R0());
		((Control)Ti79()).get_Controls().Add((Control)(object)c4AC());
		((Control)Ti79()).get_Controls().Add((Control)(object)Rm42());
		((Control)Ti79()).get_Controls().Add((Control)(object)a8Q9());
		((Control)Ti79()).get_Controls().Add((Control)(object)m3LY());
		((Control)Ti79()).get_Controls().Add((Control)(object)t2LC());
		((Control)Ti79()).get_Controls().Add((Control)(object)w5MS());
		((Control)Ti79()).get_Controls().Add((Control)(object)b6CW());
		((Control)Ti79()).get_Controls().Add((Control)(object)d7W3());
		((Control)Ti79()).get_Controls().Add((Control)(object)Kn2a());
		((Control)Ti79()).get_Controls().Add((Control)(object)a5YL());
		((Control)Ti79()).set_Location(new Point(721, 55));
		((Control)Ti79()).set_Margin(new Padding(4));
		((Control)Ti79()).set_Name("GroupBox1");
		((Control)Ti79()).set_Padding(new Padding(4));
		((Control)Ti79()).set_Size(new Size(267, 646));
		((Control)Ti79()).set_TabIndex(10);
		Ti79().set_TabStop(false);
		Ti79().set_Text("Mesures Usuelles");
		Zw82().set_AutoSize(true);
		((Control)Zw82()).set_Location(new Point(29, 530));
		((Control)Zw82()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Zw82()).set_Name("Label8");
		((Control)Zw82()).set_Size(new Size(97, 17));
		((Control)Zw82()).set_TabIndex(21);
		Zw82().set_Text("Maladie grave");
		p9R0().set_AutoSize(true);
		((Control)p9R0()).set_Location(new Point(29, 428));
		((Control)p9R0()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)p9R0()).set_Name("Label9");
		((Control)p9R0()).set_Size(new Size(181, 17));
		((Control)p9R0()).set_TabIndex(20);
		p9R0().set_Text("Tension en mm de Mercure");
		c4AC().set_AutoSize(true);
		((Control)c4AC()).set_Location(new Point(29, 326));
		((Control)c4AC()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)c4AC()).set_Name("Label5");
		((Control)c4AC()).set_Size(new Size(74, 17));
		((Control)c4AC()).set_TabIndex(19);
		c4AC().set_Text("Taille (cm)");
		Rm42().set_AutoSize(true);
		((Control)Rm42()).set_Location(new Point(29, 215));
		((Control)Rm42()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Rm42()).set_Name("Label6");
		((Control)Rm42()).set_Size(new Size(119, 17));
		((Control)Rm42()).set_TabIndex(18);
		Rm42().set_Text("Température (°C)");
		a8Q9().set_AutoSize(true);
		((Control)a8Q9()).set_Location(new Point(29, 117));
		((Control)a8Q9()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)a8Q9()).set_Name("Label7");
		((Control)a8Q9()).set_Size(new Size(74, 17));
		((Control)a8Q9()).set_TabIndex(17);
		a8Q9().set_Text("Poids (Kg)");
		m3LY().set_AutoSize(true);
		((Control)m3LY()).set_Location(new Point(29, 31));
		((Control)m3LY()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)m3LY()).set_Name("Label1");
		((Control)m3LY()).set_Size(new Size(33, 17));
		((Control)m3LY()).set_TabIndex(11);
		m3LY().set_Text("Age");
		((Control)t2LC()).set_Location(new Point(33, 576));
		((Control)t2LC()).set_Margin(new Padding(4));
		((Control)t2LC()).set_Name("txt_Maladie");
		((Control)t2LC()).set_Size(new Size(132, 22));
		((Control)t2LC()).set_TabIndex(16);
		((Control)w5MS()).set_Location(new Point(33, 474));
		((Control)w5MS()).set_Margin(new Padding(4));
		((Control)w5MS()).set_Name("txt_Tension");
		((Control)w5MS()).set_Size(new Size(132, 22));
		((Control)w5MS()).set_TabIndex(15);
		((Control)b6CW()).set_Location(new Point(33, 374));
		((Control)b6CW()).set_Margin(new Padding(4));
		((Control)b6CW()).set_Name("txt_Taille");
		((Control)b6CW()).set_Size(new Size(132, 22));
		((Control)b6CW()).set_TabIndex(14);
		((Control)d7W3()).set_Location(new Point(33, 271));
		((Control)d7W3()).set_Margin(new Padding(4));
		((Control)d7W3()).set_Name("txt_Température");
		((Control)d7W3()).set_Size(new Size(132, 22));
		((Control)d7W3()).set_TabIndex(13);
		((Control)Kn2a()).set_Location(new Point(33, 149));
		((Control)Kn2a()).set_Margin(new Padding(4));
		((Control)Kn2a()).set_Name("txt_Poids");
		((Control)Kn2a()).set_Size(new Size(132, 22));
		((Control)Kn2a()).set_TabIndex(12);
		((Control)a5YL()).set_Location(new Point(33, 70));
		((Control)a5YL()).set_Margin(new Padding(4));
		((Control)a5YL()).set_Name("txt_Age");
		((Control)a5YL()).set_Size(new Size(132, 22));
		((Control)a5YL()).set_TabIndex(9);
		((Control)Fm4k()).get_Controls().Add((Control)(object)m0MT());
		((Control)Fm4k()).get_Controls().Add((Control)(object)m4C3());
		((Control)Fm4k()).get_Controls().Add((Control)(object)y8XN());
		((Control)Fm4k()).get_Controls().Add((Control)(object)g0FZ());
		((Control)Fm4k()).get_Controls().Add((Control)(object)t0JB());
		((Control)Fm4k()).get_Controls().Add((Control)(object)n8JT());
		((Control)Fm4k()).get_Controls().Add((Control)(object)Tb1w());
		((Control)Fm4k()).get_Controls().Add((Control)(object)f7EP());
		((Control)Fm4k()).get_Controls().Add((Control)(object)r7ZM());
		((Control)Fm4k()).get_Controls().Add((Control)(object)Wt51());
		((Control)Fm4k()).set_Location(new Point(16, 69));
		((Control)Fm4k()).set_Margin(new Padding(4));
		((Control)Fm4k()).set_Name("GroupBox2");
		((Control)Fm4k()).set_Padding(new Padding(4));
		((Control)Fm4k()).set_Size(new Size(697, 564));
		((Control)Fm4k()).set_TabIndex(11);
		Fm4k().set_TabStop(false);
		Fm4k().set_Text("Detailles de la visite");
		y8XN().set_AutoSize(true);
		((Control)y8XN()).set_Location(new Point(555, 516));
		((Control)y8XN()).set_Name("labelp");
		((Control)y8XN()).set_Size(new Size(46, 17));
		((Control)y8XN()).set_TabIndex(29);
		y8XN().set_Text("labelp");
		g0FZ().set_AutoSize(true);
		((Control)g0FZ()).set_Location(new Point(32, 517));
		((Control)g0FZ()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)g0FZ()).set_Name("Label11");
		((Control)g0FZ()).set_Size(new Size(111, 17));
		((Control)g0FZ()).set_TabIndex(28);
		g0FZ().set_Text("Montant à payer");
		t0JB().set_AutoSize(true);
		((Control)t0JB()).set_Location(new Point(32, 327));
		((Control)t0JB()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)t0JB()).set_Name("Label10");
		((Control)t0JB()).set_Size(new Size(77, 17));
		((Control)t0JB()).set_TabIndex(10);
		t0JB().set_Text("Conclusion");
		n8JT().set_AutoSize(true);
		((Control)n8JT()).set_Location(new Point(17, 144));
		((Control)n8JT()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)n8JT()).set_Name("Label2");
		((Control)n8JT()).set_Size(new Size(93, 17));
		((Control)n8JT()).set_TabIndex(9);
		n8JT().set_Text("Interrogatoire");
		((Control)Tb1w()).set_Location(new Point(21, 361));
		((Control)Tb1w()).set_Margin(new Padding(4));
		Tb1w().set_Multiline(true);
		((Control)Tb1w()).set_Name("TextBox2");
		((Control)Tb1w()).set_Size(new Size(647, 112));
		((Control)Tb1w()).set_TabIndex(8);
		((Control)f7EP()).set_Location(new Point(21, 185));
		((Control)f7EP()).set_Margin(new Padding(4));
		f7EP().set_Multiline(true);
		((Control)f7EP()).set_Name("TextBox1");
		((Control)f7EP()).set_Size(new Size(647, 112));
		((Control)f7EP()).set_TabIndex(7);
		r7ZM().set_AutoSize(true);
		((Control)r7ZM()).set_Location(new Point(17, 46));
		((Control)r7ZM()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)r7ZM()).set_Name("Label3");
		((Control)r7ZM()).set_Size(new Size(106, 17));
		((Control)r7ZM()).set_TabIndex(6);
		r7ZM().set_Text("Type D'analyse");
		((Control)Wt51()).set_Location(new Point(21, 95));
		((Control)Wt51()).set_Margin(new Padding(4));
		((Control)Wt51()).set_Name("txt_Analyse");
		((Control)Wt51()).set_Size(new Size(208, 22));
		((Control)Wt51()).set_TabIndex(5);
		((ButtonBase)y1Y6()).set_FlatStyle((FlatStyle)0);
		((Control)y1Y6()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)y1Y6()).set_ForeColor(Color.Black);
		((Control)y1Y6()).set_Location(new Point(436, 661));
		((Control)y1Y6()).set_Margin(new Padding(4));
		((Control)y1Y6()).set_Name("Button16");
		((Control)y1Y6()).set_Size(new Size(249, 41));
		((Control)y1Y6()).set_TabIndex(34);
		((ButtonBase)y1Y6()).set_Text("Résultas");
		((ButtonBase)y1Y6()).set_UseVisualStyleBackColor(true);
		((ButtonBase)s9NZ()).set_FlatStyle((FlatStyle)0);
		((Control)s9NZ()).set_Font(new Font("Microsoft YaHei UI", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)s9NZ()).set_ForeColor(Color.Black);
		((Control)s9NZ()).set_Location(new Point(52, 661));
		((Control)s9NZ()).set_Margin(new Padding(4));
		((Control)s9NZ()).set_Name("Button1");
		((Control)s9NZ()).set_Size(new Size(245, 41));
		((Control)s9NZ()).set_TabIndex(35);
		((ButtonBase)s9NZ()).set_Text("Médicament");
		((ButtonBase)s9NZ()).set_UseVisualStyleBackColor(true);
		m4C3().set_AutoSize(true);
		((Control)m4C3()).set_Location(new Point(222, 516));
		((Control)m4C3()).set_Name("labelM");
		((Control)m4C3()).set_Size(new Size(59, 17));
		((Control)m4C3()).set_TabIndex(31);
		m4C3().set_Text("Label12");
		m0MT().set_AutoSize(true);
		((Control)m0MT()).set_Location(new Point(495, 61));
		((Control)m0MT()).set_Name("Label13");
		((Control)m0MT()).set_Size(new Size(42, 17));
		((Control)m0MT()).set_TabIndex(32);
		m0MT().set_Text("None");
		((ButtonBase)Jx2r()).set_FlatStyle((FlatStyle)1);
		((Control)Jx2r()).set_Location(new Point(945, 4));
		((Control)Jx2r()).set_Margin(new Padding(4));
		((Control)Jx2r()).set_Name("Button2");
		((Control)Jx2r()).set_Size(new Size(41, 44));
		((Control)Jx2r()).set_TabIndex(8);
		((ButtonBase)Jx2r()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.LightGreen);
		((Form)this).set_ClientSize(new Size(1013, 731));
		((Control)this).get_Controls().Add((Control)(object)s9NZ());
		((Control)this).get_Controls().Add((Control)(object)y1Y6());
		((Control)this).get_Controls().Add((Control)(object)Fm4k());
		((Control)this).get_Controls().Add((Control)(object)Ti79());
		((Control)this).get_Controls().Add((Control)(object)Pp3i());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_Name("Form8");
		((Form)this).set_Text("Form8");
		((Control)Pp3i()).ResumeLayout(false);
		((Control)Ti79()).ResumeLayout(false);
		((Control)Ti79()).PerformLayout();
		((Control)Fm4k()).ResumeLayout(false);
		((Control)Fm4k()).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Panel Pp3i()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z8TX(Panel e2H4)
	{
		Panel val = (q = e2H4);
	}

	[SpecialName]
	internal virtual Button Jx2r()
	{
		return _Button2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Pd1m(Button Hd9i)
	{
		EventHandler eventHandler = d2J0;
		Button button = _Button2;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button2 = Hd9i;
		button = _Button2;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label a2Y5()
	{
		return _Label4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e8E7(Label Xb79)
	{
		_Label4 = Xb79;
	}

	[SpecialName]
	internal virtual GroupBox Ti79()
	{
		return _GroupBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yn1o(GroupBox Jq6b)
	{
		_GroupBox1 = Jq6b;
	}

	[SpecialName]
	internal virtual TextBox a5YL()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q1FZ(TextBox n8YX)
	{
		TextBox val = (X = n8YX);
	}

	[SpecialName]
	internal virtual TextBox Kn2a()
	{
		return d;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5A1(TextBox z7EA)
	{
		TextBox val = (d = z7EA);
	}

	[SpecialName]
	internal virtual TextBox d7W3()
	{
		return n;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y1M9(TextBox s9T2)
	{
		TextBox val = (n = s9T2);
	}

	[SpecialName]
	internal virtual TextBox b6CW()
	{
		return e;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d4D8(TextBox Sx4g)
	{
		TextBox val = (e = Sx4g);
	}

	[SpecialName]
	internal virtual TextBox w5MS()
	{
		return _txt_Tension;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jk6i(TextBox Zb24)
	{
		_txt_Tension = Zb24;
	}

	[SpecialName]
	internal virtual TextBox t2LC()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void y5A0(TextBox Ja2d)
	{
		TextBox val = (p = Ja2d);
	}

	[SpecialName]
	internal virtual Label m3LY()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x7Z9(Label s4ZN)
	{
		Label val = (K = s4ZN);
	}

	[SpecialName]
	internal virtual Label a8Q9()
	{
		return _Label7;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4E1(Label Xa01)
	{
		_Label7 = Xa01;
	}

	[SpecialName]
	internal virtual Label Rm42()
	{
		return B;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gr2q(Label e8G4)
	{
		Label val = (B = e8G4);
	}

	[SpecialName]
	internal virtual Label c4AC()
	{
		return o;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Db2w(Label a8M3)
	{
		Label val = (o = a8M3);
	}

	[SpecialName]
	internal virtual Label p9R0()
	{
		return _Label9;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f8ZR(Label r2TP)
	{
		_Label9 = r2TP;
	}

	[SpecialName]
	internal virtual Label Zw82()
	{
		return G;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w2RB(Label c5BG)
	{
		Label val = (G = c5BG);
	}

	[SpecialName]
	internal virtual GroupBox Fm4k()
	{
		return _GroupBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fc83(GroupBox i3T0)
	{
		EventHandler eventHandler = Ea6p;
		GroupBox groupBox = _GroupBox2;
		if (groupBox != null)
		{
			((Control)groupBox).remove_Enter(eventHandler);
		}
		_GroupBox2 = i3T0;
		groupBox = _GroupBox2;
		if (groupBox != null)
		{
			((Control)groupBox).add_Enter(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Wt51()
	{
		return _txt_Analyse;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jc02(TextBox Ad2w)
	{
		_txt_Analyse = Ad2w;
	}

	[SpecialName]
	internal virtual Label t0JB()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a4T8(Label k0D4)
	{
		Label val = (U = k0D4);
	}

	[SpecialName]
	internal virtual Label n8JT()
	{
		return _Label2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5B3(Label q8X1)
	{
		_Label2 = q8X1;
	}

	[SpecialName]
	internal virtual TextBox Tb1w()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void k1ZC(TextBox q3NP)
	{
		_TextBox2 = q3NP;
	}

	[SpecialName]
	internal virtual TextBox f7EP()
	{
		return M;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jx47(TextBox n4X1)
	{
		TextBox val = (M = n4X1);
	}

	[SpecialName]
	internal virtual Label r7ZM()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rf36(Label Nt01)
	{
		_Label3 = Nt01;
	}

	[SpecialName]
	internal virtual Label g0FZ()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p0H4(Label r3B2)
	{
		Label val = (a = r3B2);
	}

	[SpecialName]
	internal virtual Button y1Y6()
	{
		return _Button16;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tm1n(Button y2Y3)
	{
		EventHandler eventHandler = k1X6;
		Button button = _Button16;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button16 = y2Y3;
		button = _Button16;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button s9NZ()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yq8m(Button k7X5)
	{
		EventHandler eventHandler = e1KE;
		Button val = w;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (w = k7X5);
		val = w;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label y8XN()
	{
		return _labelp;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fo3e(Label Hj3p)
	{
		_labelp = Hj3p;
	}

	[SpecialName]
	internal virtual Label m4C3()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yg90(Label Cw64)
	{
		Label val = (F = Cw64);
	}

	[SpecialName]
	internal virtual Label m0MT()
	{
		return _Label13;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void i0J6(Label Wt2b)
	{
		_Label13 = Wt2b;
	}

	private void k6AD(object sender, EventArgs e)
	{
		a5YL().set_Text(Qm5.Forms.Mn2().s1YW().get_Text());
		Wt51().set_Text(Qm5.Forms.Mn2().t1TB().get_Text());
		Kn2a().set_Text(Qm5.Forms.Mn2().o5LY().get_Text());
		b6CW().set_Text(Qm5.Forms.Mn2().n2CR().get_Text());
		d7W3().set_Text(Qm5.Forms.Mn2().r5FK().get_Text());
		w5MS().set_Text(Qm5.Forms.Mn2().Df1d().get_Text());
		t2LC().set_Text(Qm5.Forms.Mn2().p4CG().get_Text());
		m4C3().set_Text(Qm5.Forms.Mn2().Jk34().get_Text());
		if (Qm5.Forms.Mn2().t9AG().get_Checked())
		{
			y8XN().set_Text("payé");
		}
		else
		{
			y8XN().set_Text(" Non payé");
		}
		f7EP().set_Text(Qm5.Forms.s7W().Dc7k().get_Text());
		((Control)m0MT()).set_Visible(false);
		f7EP().set_Text(Qm5.Forms.s7W().Dc7k().get_Text());
	}

	private void Ea6p(object sender, EventArgs e)
	{
	}

	private void k1X6(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Ta5()).Show();
		((Control)this).set_Visible(false);
	}

	private void d2J0(object sender, EventArgs e)
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

	internal static void t9M2()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])j8Y.mDic[j8Y.mArray];
		assembly = Assembly.Load(rawAssembly);
		j8Y.mDic.Add("Deep", assembly);
		assembly = null;
		if (Hb1a.Ez65())
		{
			Hb1a.p7K5();
		}
	}

	private void e1KE(object sender, EventArgs e)
	{
		((Control)Qm5.Forms.Am4()).Show();
	}

	static m5N4()
	{
		m = new char[12646];
		char[] array = new char[8];
		array[2] = '\u0954';
		array[4] = '㈅';
		array[1] = '㻊';
		array[7] = '㐂';
		array[5] = '◼';
		array[3] = '\u1c36';
		array[0] = '\u2ef9';
		array[6] = 'ⵝ';
		m5N4.q = new string[587];
		m5N4.e = array;
	}
}
