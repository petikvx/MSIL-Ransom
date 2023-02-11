using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using p9K;

namespace j4FQ;

[DesignerGenerated]
public class Qd2o : Form
{
	private IContainer components;

	private Button _TenantLogin;

	internal Button q;

	internal Button Y;

	internal Panel x;

	public Qd2o()
	{
		Yc9s();
	}

	protected override void c0W5(bool n5K4)
	{
		try
		{
			if (n5K4 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(n5K4);
		}
	}

	private void Yc9s()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Qd2o));
		Tp94(new Button());
		Lt8y(new Button());
		Fr68(new Button());
		Wp5b(new Panel());
		((Control)this).SuspendLayout();
		((ButtonBase)t9F1()).set_BackColor(SystemColors.ControlLightLight);
		((Control)t9F1()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t9F1()).set_Location(new Point(652, 121));
		((Control)t9F1()).set_Name("AdminLogin");
		((Control)t9F1()).set_Size(new Size(168, 50));
		((Control)t9F1()).set_TabIndex(0);
		((ButtonBase)t9F1()).set_Text("Admin Login");
		((ButtonBase)t9F1()).set_UseVisualStyleBackColor(false);
		((ButtonBase)a3XG()).set_BackColor(SystemColors.ControlLightLight);
		((Control)a3XG()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)a3XG()).set_Location(new Point(652, 222));
		((Control)a3XG()).set_Name("TenantLogin");
		((Control)a3XG()).set_Size(new Size(168, 47));
		((Control)a3XG()).set_TabIndex(1);
		((ButtonBase)a3XG()).set_Text("Tenant Login");
		((ButtonBase)a3XG()).set_UseVisualStyleBackColor(false);
		((ButtonBase)Ni79()).set_BackColor(SystemColors.ControlLightLight);
		((Control)Ni79()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ni79()).set_Location(new Point(652, 331));
		((Control)Ni79()).set_Name("ApartmentDetails");
		((Control)Ni79()).set_Size(new Size(168, 51));
		((Control)Ni79()).set_TabIndex(2);
		((ButtonBase)Ni79()).set_Text("Apartment Details");
		((ButtonBase)Ni79()).set_UseVisualStyleBackColor(false);
		((Control)Zo39()).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel1.BackgroundImage"));
		((Control)Zo39()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Zo39()).set_Location(new Point(12, 12));
		((Control)Zo39()).set_Name("Panel1");
		((Control)Zo39()).set_Size(new Size(634, 501));
		((Control)Zo39()).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(893, 583));
		((Control)this).get_Controls().Add((Control)(object)Zo39());
		((Control)this).get_Controls().Add((Control)(object)Ni79());
		((Control)this).get_Controls().Add((Control)(object)a3XG());
		((Control)this).get_Controls().Add((Control)(object)t9F1());
		((Control)this).set_Name("first_page");
		((Form)this).set_Text("first_page");
		((Control)this).ResumeLayout(false);
	}

	[SpecialName]
	internal virtual Button t9F1()
	{
		return q;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Tp94(Button w5C0)
	{
		EventHandler eventHandler = y3D0;
		Button val = q;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (q = w5C0);
		val = q;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button a3XG()
	{
		return _TenantLogin;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Lt8y(Button b1YF)
	{
		EventHandler eventHandler = Qz69;
		Button tenantLogin = _TenantLogin;
		if (tenantLogin != null)
		{
			((Control)tenantLogin).remove_Click(eventHandler);
		}
		_TenantLogin = b1YF;
		tenantLogin = _TenantLogin;
		if (tenantLogin != null)
		{
			((Control)tenantLogin).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Ni79()
	{
		return Y;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fr68(Button a1R8)
	{
		EventHandler eventHandler = Zj8d;
		Button y = Y;
		if (y != null)
		{
			((Control)y).remove_Click(eventHandler);
		}
		Button val = (Y = a1R8);
		y = Y;
		if (y != null)
		{
			((Control)y).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Panel Zo39()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Wp5b(Panel St0w)
	{
		Panel val = (x = St0w);
	}

	private void y3D0(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.Ys4()).Show();
	}

	private void Qz69(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.p1T()).Show();
	}

	private void Zj8d(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.x8F()).Show();
	}

	internal static byte z9XE(byte Xa15, byte[] Hx2y, int z4NL, int Hs58)
	{
		Xa15 = (byte)(Xa15 ^ checked((byte)(Hx2y[unchecked(Hs58 % Hx2y.Length)] ^ ((Hs58 + unchecked(z4NL % Hx2y.Length)) & z4NL))));
		return Xa15;
	}
}
