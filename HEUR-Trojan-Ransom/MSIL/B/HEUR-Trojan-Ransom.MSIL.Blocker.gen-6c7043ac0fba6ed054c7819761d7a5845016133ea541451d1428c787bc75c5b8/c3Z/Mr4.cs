using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using En4;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Tm8;
using o3C;

namespace c3Z;

[DesignerGenerated]
public class Mr4 : Form
{
	private IContainer components;

	private Label _Label1;

	private Button _Button1;

	private TextBox _txt_Nom;

	private Label _Label3;

	internal Panel R;

	internal Label a;

	internal Button b;

	internal TextBox t;

	public Mr4()
	{
		((Form)this).add_Load((EventHandler)m4D);
		r1G();
	}

	private void m4D(object sender, EventArgs e)
	{
	}

	private void c8E(object sender, EventArgs e)
	{
	}

	private void k2K(object sender, EventArgs e)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(t4L().get_Text(), "Admin", false) == 0) & (Operators.CompareString(Ze9().get_Text(), "App123", false) == 0))
		{
			((Control)Qm5.Forms.k8W()).Show();
			((Control)this).set_Visible(false);
		}
		else
		{
			Interaction.MsgBox((object)"le Nom d'utilisateur ou le Mot de passe sont incorrecte ", (MsgBoxStyle)16, (object)null);
		}
	}

	private void g9T(object sender, EventArgs e)
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

	[STAThread]
	public static void Yr3()
	{
		int try0000_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				}
				while (!j9J.m8P(2) || !j9J.Cc9())
				{
				}
				j8Y.t5B(1);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0000_dispatch = 15;
			}
		}
	}

	protected override void q3K(bool d2Z)
	{
		try
		{
			if (d2Z && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(d2Z);
		}
	}

	private void r1G()
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
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b1: Expected O, but got Unknown
		//IL_02d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		e2B(new Panel());
		f6E(new Button());
		j7H(new Label());
		Ax6(new TextBox());
		Hp2(new Label());
		Xj1(new Label());
		j8Q(new Button());
		Te5(new TextBox());
		((Control)c5L()).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)c5L()).set_BackColor(Color.Black);
		((Control)c5L()).get_Controls().Add((Control)(object)b6S());
		((Control)c5L()).get_Controls().Add((Control)(object)Qd0());
		((Control)c5L()).set_Location(new Point(-1, 0));
		((Control)c5L()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)c5L()).set_Name("Panel1");
		((Control)c5L()).set_Size(new Size(911, 58));
		((Control)c5L()).set_TabIndex(7);
		((ButtonBase)b6S()).set_FlatStyle((FlatStyle)1);
		((Control)b6S()).set_Location(new Point(852, 10));
		((Control)b6S()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)b6S()).set_Name("Button1");
		((Control)b6S()).set_Size(new Size(41, 44));
		((Control)b6S()).set_TabIndex(8);
		((ButtonBase)b6S()).set_UseVisualStyleBackColor(true);
		((Control)Qd0()).set_BackColor(Color.Black);
		((Control)Qd0()).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Qd0()).set_ForeColor(Color.FromArgb(0, 192, 0));
		((Control)Qd0()).set_Location(new Point(271, 17));
		((Control)Qd0()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Qd0()).set_Name("Label1");
		((Control)Qd0()).set_Size(new Size(457, 26));
		((Control)Qd0()).set_TabIndex(6);
		Qd0().set_Text("Bienveue Dans votre  espace laboratoire ");
		((Control)t4L()).set_Location(new Point(364, 174));
		((Control)t4L()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)t4L()).set_Name("txt_Nom");
		((Control)t4L()).set_Size(new Size(241, 22));
		((Control)t4L()).set_TabIndex(8);
		((Control)Cr2()).set_BackColor(Color.Transparent);
		((Control)Cr2()).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Cr2()).set_Location(new Point(97, 174));
		((Control)Cr2()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Cr2()).set_Name("Label3");
		((Control)Cr2()).set_Size(new Size(177, 26));
		((Control)Cr2()).set_TabIndex(10);
		Cr2().set_Text("Nom d'utilsateur");
		((Control)o4W()).set_BackColor(Color.Transparent);
		((Control)o4W()).set_Font(new Font("Microsoft Sans Serif", 11.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)o4W()).set_Location(new Point(97, 304));
		((Control)o4W()).set_Margin(new Padding(4, 0, 4, 0));
		((Control)o4W()).set_Name("Label2");
		((Control)o4W()).set_Size(new Size(227, 26));
		((Control)o4W()).set_TabIndex(11);
		o4W().set_Text("Mot de Passe");
		((ButtonBase)Kt7()).set_BackColor(Color.Transparent);
		((ButtonBase)Kt7()).set_FlatStyle((FlatStyle)0);
		((Control)Kt7()).set_Location(new Point(555, 388));
		((Control)Kt7()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Kt7()).set_Name("Button2");
		((Control)Kt7()).set_Size(new Size(172, 53));
		((Control)Kt7()).set_TabIndex(9);
		((ButtonBase)Kt7()).set_Text("Se Connecter");
		((ButtonBase)Kt7()).set_UseVisualStyleBackColor(false);
		((Control)Ze9()).set_Location(new Point(364, 305));
		((Control)Ze9()).set_Margin(new Padding(4, 4, 4, 4));
		((Control)Ze9()).set_Name("txt_pswrd");
		Ze9().set_PasswordChar('*');
		((Control)Ze9()).set_Size(new Size(241, 22));
		((Control)Ze9()).set_TabIndex(12);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Lime);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(905, 471));
		((Control)this).get_Controls().Add((Control)(object)Ze9());
		((Control)this).get_Controls().Add((Control)(object)Kt7());
		((Control)this).get_Controls().Add((Control)(object)o4W());
		((Control)this).get_Controls().Add((Control)(object)Cr2());
		((Control)this).get_Controls().Add((Control)(object)t4L());
		((Control)this).get_Controls().Add((Control)(object)c5L());
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4, 4, 4, 4));
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)c5L()).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Panel c5L()
	{
		return R;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e2B(Panel f8Y)
	{
		Panel val = (R = f8Y);
	}

	[SpecialName]
	internal virtual Label Qd0()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j7H(Label Zc3)
	{
		_Label1 = Zc3;
	}

	[SpecialName]
	internal virtual Button b6S()
	{
		return _Button1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void f6E(Button Ma1)
	{
		EventHandler eventHandler = g9T;
		Button button = _Button1;
		if (button != null)
		{
			((Control)button).remove_Click(eventHandler);
		}
		_Button1 = Ma1;
		button = _Button1;
		if (button != null)
		{
			((Control)button).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox t4L()
	{
		return _txt_Nom;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ax6(TextBox Ss4)
	{
		_txt_Nom = Ss4;
	}

	[SpecialName]
	internal virtual Label Cr2()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Hp2(Label i0C)
	{
		EventHandler eventHandler = c8E;
		Label label = _Label3;
		if (label != null)
		{
			((Control)label).remove_Click(eventHandler);
		}
		_Label3 = i0C;
		label = _Label3;
		if (label != null)
		{
			((Control)label).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label o4W()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xj1(Label Pc1)
	{
		Label val = (a = Pc1);
	}

	[SpecialName]
	internal virtual Button Kt7()
	{
		return b;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j8Q(Button q8G)
	{
		EventHandler eventHandler = k2K;
		Button val = b;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (b = q8G);
		val = b;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox Ze9()
	{
		return t;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Te5(TextBox o9S)
	{
		TextBox val = (t = o9S);
	}
}
