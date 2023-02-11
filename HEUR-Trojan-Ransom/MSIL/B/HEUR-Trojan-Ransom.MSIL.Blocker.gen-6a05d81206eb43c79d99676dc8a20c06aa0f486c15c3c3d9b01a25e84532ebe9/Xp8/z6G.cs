using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Ly6n;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using r0C3;

namespace Xp8;

[DesignerGenerated]
public class z6G : Form
{
	private Label _Datee;

	private Label _Purpose;

	private MaskedTextBox _flatn;

	private MaskedTextBox _purpose1;

	private Button _Logout;

	private Button _Button1;

	private DateTimePicker _DateTimePicker1;

	internal IContainer W;

	internal Label y;

	internal Label P;

	internal Label q;

	internal MaskedTextBox E;

	internal MaskedTextBox u;

	internal Button j;

	internal SqlConnection o;

	internal SqlCommand N;

	public z6G()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		SqlConnection val = (o = new SqlConnection());
		SqlCommand val2 = (N = new SqlCommand());
		Aa7();
	}

	protected override void e3Z(bool Lb9)
	{
		try
		{
			if (Lb9 && W != null)
			{
				W.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Lb9);
		}
	}

	private void Aa7()
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
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bb: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_038c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0400: Expected O, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d3: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		z7K(new Label());
		Fq2(new Label());
		Cm8(new Label());
		a6S(new Label());
		Dw3(new Label());
		s5Z(new MaskedTextBox());
		p7C(new MaskedTextBox());
		j6P(new MaskedTextBox());
		e4J(new MaskedTextBox());
		Mz4(new Button());
		a5J(new Button());
		a6P(new Button());
		e7D(new DateTimePicker());
		((Control)this).SuspendLayout();
		z7N().set_AutoSize(true);
		((Control)z7N()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)z7N()).set_Location(new Point(55, 93));
		((Control)z7N()).set_Name("TenantID");
		((Control)z7N()).set_Size(new Size(82, 20));
		((Control)z7N()).set_TabIndex(0);
		z7N().set_Text("Tenant ID");
		Cc9().set_AutoSize(true);
		((Control)Cc9()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Cc9()).set_Location(new Point(55, 213));
		((Control)Cc9()).set_Name("FlatNumber");
		((Control)Cc9()).set_Size(new Size(101, 20));
		((Control)Cc9()).set_TabIndex(1);
		Cc9().set_Text("Flat Number");
		Xs9().set_AutoSize(true);
		((Control)Xs9()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Xs9()).set_Location(new Point(55, 155));
		((Control)Xs9()).set_Name("BlockNumber");
		((Control)Xs9()).set_Size(new Size(115, 20));
		((Control)Xs9()).set_TabIndex(3);
		Xs9().set_Text("Block Number");
		Zi9().set_AutoSize(true);
		((Control)Zi9()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Zi9()).set_Location(new Point(55, 257));
		((Control)Zi9()).set_Name("Datee");
		((Control)Zi9()).set_Size(new Size(45, 20));
		((Control)Zi9()).set_TabIndex(4);
		Zi9().set_Text("Date");
		q8C().set_AutoSize(true);
		((Control)q8C()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)q8C()).set_Location(new Point(55, 304));
		((Control)q8C()).set_Name("Purpose");
		((Control)q8C()).set_Size(new Size(71, 20));
		((Control)q8C()).set_TabIndex(5);
		q8C().set_Text("Purpose");
		((Control)a4Z()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)a4Z()).set_Location(new Point(176, 93));
		((Control)a4Z()).set_Name("t_id");
		((Control)a4Z()).set_Size(new Size(169, 27));
		((Control)a4Z()).set_TabIndex(6);
		((Control)Zd0()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Zd0()).set_Location(new Point(176, 210));
		((Control)Zd0()).set_Name("flatn");
		((Control)Zd0()).set_Size(new Size(169, 27));
		((Control)Zd0()).set_TabIndex(7);
		((Control)Py2()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Py2()).set_Location(new Point(176, 155));
		((Control)Py2()).set_Name("blockno");
		((Control)Py2()).set_Size(new Size(169, 27));
		((Control)Py2()).set_TabIndex(9);
		((Control)Mr4()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Mr4()).set_Location(new Point(176, 304));
		((Control)Mr4()).set_Name("purpose1");
		((Control)Mr4()).set_Size(new Size(169, 27));
		((Control)Mr4()).set_TabIndex(11);
		((Control)Qg6()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)Qg6()).set_Location(new Point(451, 81));
		((Control)Qg6()).set_Name("Back");
		((Control)Qg6()).set_Size(new Size(129, 46));
		((Control)Qg6()).set_TabIndex(12);
		((ButtonBase)Qg6()).set_Text("Back");
		((ButtonBase)Qg6()).set_UseVisualStyleBackColor(true);
		((Control)c4J()).set_Font(new Font("Microsoft Sans Serif", 8.25f));
		((Control)c4J()).set_Location(new Point(631, 83));
		((Control)c4J()).set_Name("Logout");
		((Control)c4J()).set_Size(new Size(129, 46));
		((Control)c4J()).set_TabIndex(13);
		((ButtonBase)c4J()).set_Text("Logout");
		((ButtonBase)c4J()).set_UseVisualStyleBackColor(true);
		((Control)Bf4()).set_Location(new Point(167, 410));
		((Control)Bf4()).set_Name("Button1");
		((Control)Bf4()).set_Size(new Size(178, 57));
		((Control)Bf4()).set_TabIndex(14);
		((ButtonBase)Bf4()).set_Text("Button1");
		((ButtonBase)Bf4()).set_UseVisualStyleBackColor(true);
		((Control)m1X()).set_Location(new Point(176, 254));
		((Control)m1X()).set_Name("DateTimePicker1");
		((Control)m1X()).set_Size(new Size(200, 22));
		((Control)m1X()).set_TabIndex(15);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(823, 685));
		((Control)this).get_Controls().Add((Control)(object)m1X());
		((Control)this).get_Controls().Add((Control)(object)Bf4());
		((Control)this).get_Controls().Add((Control)(object)c4J());
		((Control)this).get_Controls().Add((Control)(object)Qg6());
		((Control)this).get_Controls().Add((Control)(object)Mr4());
		((Control)this).get_Controls().Add((Control)(object)Py2());
		((Control)this).get_Controls().Add((Control)(object)Zd0());
		((Control)this).get_Controls().Add((Control)(object)a4Z());
		((Control)this).get_Controls().Add((Control)(object)q8C());
		((Control)this).get_Controls().Add((Control)(object)Zi9());
		((Control)this).get_Controls().Add((Control)(object)Xs9());
		((Control)this).get_Controls().Add((Control)(object)Cc9());
		((Control)this).get_Controls().Add((Control)(object)z7N());
		((Control)this).set_Name("Event_Hall");
		((Form)this).set_Text("Event_Hall");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label z7N()
	{
		return y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void z7K(Label x3T)
	{
		Label val = (y = x3T);
	}

	[SpecialName]
	internal virtual Label Cc9()
	{
		return P;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fq2(Label Rd5)
	{
		Label val = (P = Rd5);
	}

	[SpecialName]
	internal virtual Label Xs9()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cm8(Label Jr1)
	{
		Label val = (q = Jr1);
	}

	[SpecialName]
	internal virtual Label Zi9()
	{
		return _Datee;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6S(Label Ss5)
	{
		_Datee = Ss5;
	}

	[SpecialName]
	internal virtual Label q8C()
	{
		return _Purpose;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Dw3(Label Hw6)
	{
		_Purpose = Hw6;
	}

	[SpecialName]
	internal virtual MaskedTextBox a4Z()
	{
		return E;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void s5Z(MaskedTextBox r1R)
	{
		MaskedTextBox val = (E = r1R);
	}

	[SpecialName]
	internal virtual MaskedTextBox Zd0()
	{
		return _flatn;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p7C(MaskedTextBox a3R)
	{
		_flatn = a3R;
	}

	[SpecialName]
	internal virtual MaskedTextBox Py2()
	{
		return u;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j6P(MaskedTextBox Ya8)
	{
		MaskedTextBox val = (u = Ya8);
	}

	[SpecialName]
	internal virtual MaskedTextBox Mr4()
	{
		return _purpose1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e4J(MaskedTextBox Ln4)
	{
		_purpose1 = Ln4;
	}

	[SpecialName]
	internal virtual Button Qg6()
	{
		return j;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mz4(Button Xw3)
	{
		Button val = (j = Xw3);
	}

	[SpecialName]
	internal virtual Button c4J()
	{
		return _Logout;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a5J(Button k4A)
	{
		_Logout = k4A;
	}

	[SpecialName]
	internal virtual Button Bf4()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void a6P(Button s0P)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		EventHandler eventHandler = Ft7;
		KeyEventHandler val = new KeyEventHandler(Xi9);
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
			((Control)button).remove_KeyDown(val);
		}
		_Button1 = s0P;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
			((Control)button).add_KeyDown(val);
		}
	}

	[SpecialName]
	internal virtual DateTimePicker m1X()
	{
		return _DateTimePicker1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7D(DateTimePicker Pf9)
	{
		_DateTimePicker1 = Pf9;
	}

	private void Ft7(object sender, EventArgs e)
	{
		q4AE();
	}

	private void Xi9(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Invalid comparison between Unknown and I4
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Invalid comparison between Unknown and I4
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 27)
		{
			DialogResult val = MessageBox.Show("Do you want to exit", "press yes for exit", (MessageBoxButtons)4, (MessageBoxIcon)32);
			if ((int)val == 6)
			{
				((Form)this).Close();
			}
		}
		if (e.get_Control() & ((int)e.get_KeyCode() == 83))
		{
			DialogResult val = MessageBox.Show("Do you want to SAVE", "press yes for SAVE", (MessageBoxButtons)4, (MessageBoxIcon)32);
			if ((int)val == 6)
			{
				q4AE();
			}
		}
		if ((int)e.get_KeyCode() != 116)
		{
		}
		if ((int)e.get_KeyCode() == 119)
		{
		}
	}

	public object q4AE()
	{
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		o.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manish\\Source\\Repos\\Apartment-Management-System2\\apart.mdf;Integrated Security=True");
		N.set_Connection(o);
		N.set_CommandText("insert into eventhall(TenantID,BlockNo,FlatNo,Date,Purpose) values(" + a4Z().get_Text() + "," + Py2().get_Text() + "," + Zd0().get_Text() + ",'" + Conversions.ToString(m1X().get_Value()) + "','" + Mr4().get_Text() + "')");
		o.Open();
		N.ExecuteNonQuery();
		Interaction.MsgBox((object)"done", (MsgBoxStyle)0, (object)null);
		o.Close();
		object result = default(object);
		return result;
	}

	internal static byte[] c9F6(int r0JA)
	{
		string[] array = new string[2] { "mkolk", "putin" };
		if (array == null)
		{
			return null;
		}
		return Be4z.a1H4(Zd85.y3A0(), r0JA);
	}
}
