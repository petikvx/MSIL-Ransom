using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using p0H8;

namespace Pb62;

[DesignerGenerated]
public class t3KL : Form
{
	private IContainer components;

	internal virtual Button AdminLogin
	{
		[CompilerGenerated]
		get
		{
			return _AdminLogin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = j0WT;
			Button adminLogin = _AdminLogin;
			if (adminLogin != null)
			{
				((Control)adminLogin).remove_Click(eventHandler);
			}
			_AdminLogin = value;
			adminLogin = _AdminLogin;
			if (adminLogin != null)
			{
				((Control)adminLogin).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button TenantLogin
	{
		[CompilerGenerated]
		get
		{
			return _TenantLogin;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Sn6i;
			Button tenantLogin = _TenantLogin;
			if (tenantLogin != null)
			{
				((Control)tenantLogin).remove_Click(eventHandler);
			}
			_TenantLogin = value;
			tenantLogin = _TenantLogin;
			if (tenantLogin != null)
			{
				((Control)tenantLogin).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ApartmentDetails
	{
		[CompilerGenerated]
		get
		{
			return _ApartmentDetails;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = k7E4;
			Button apartmentDetails = _ApartmentDetails;
			if (apartmentDetails != null)
			{
				((Control)apartmentDetails).remove_Click(eventHandler);
			}
			_ApartmentDetails = value;
			apartmentDetails = _ApartmentDetails;
			if (apartmentDetails != null)
			{
				((Control)apartmentDetails).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public t3KL()
	{
		Pd5b();
	}

	[DebuggerNonUserCode]
	protected override void g8DK(bool Sb53)
	{
		try
		{
			if (Sb53 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Sb53);
		}
	}

	[DebuggerStepThrough]
	private void Pd5b()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(t3KL));
		AdminLogin = new Button();
		TenantLogin = new Button();
		ApartmentDetails = new Button();
		Panel1 = new Panel();
		((Control)this).SuspendLayout();
		((ButtonBase)AdminLogin).set_BackColor(SystemColors.ControlLightLight);
		((Control)AdminLogin).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)AdminLogin).set_Location(new Point(652, 121));
		((Control)AdminLogin).set_Name("AdminLogin");
		((Control)AdminLogin).set_Size(new Size(168, 50));
		((Control)AdminLogin).set_TabIndex(0);
		((ButtonBase)AdminLogin).set_Text("Admin Login");
		((ButtonBase)AdminLogin).set_UseVisualStyleBackColor(false);
		((ButtonBase)TenantLogin).set_BackColor(SystemColors.ControlLightLight);
		((Control)TenantLogin).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TenantLogin).set_Location(new Point(652, 222));
		((Control)TenantLogin).set_Name("TenantLogin");
		((Control)TenantLogin).set_Size(new Size(168, 47));
		((Control)TenantLogin).set_TabIndex(1);
		((ButtonBase)TenantLogin).set_Text("Tenant Login");
		((ButtonBase)TenantLogin).set_UseVisualStyleBackColor(false);
		((ButtonBase)ApartmentDetails).set_BackColor(SystemColors.ControlLightLight);
		((Control)ApartmentDetails).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)ApartmentDetails).set_Location(new Point(652, 331));
		((Control)ApartmentDetails).set_Name("ApartmentDetails");
		((Control)ApartmentDetails).set_Size(new Size(168, 51));
		((Control)ApartmentDetails).set_TabIndex(2);
		((ButtonBase)ApartmentDetails).set_Text("Apartment Details");
		((ButtonBase)ApartmentDetails).set_UseVisualStyleBackColor(false);
		((Control)Panel1).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel1.BackgroundImage"));
		((Control)Panel1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Panel1).set_Location(new Point(12, 12));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(634, 501));
		((Control)Panel1).set_TabIndex(3);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(893, 583));
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)ApartmentDetails);
		((Control)this).get_Controls().Add((Control)(object)TenantLogin);
		((Control)this).get_Controls().Add((Control)(object)AdminLogin);
		((Control)this).set_Name("first_page");
		((Form)this).set_Text("first_page");
		((Control)this).ResumeLayout(false);
	}

	private void j0WT(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Form1).Show();
	}

	private void Sn6i(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Tenant_Login).Show();
	}

	private void k7E4(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Apartment_Details).Show();
	}

	internal static byte Gr4a(byte m6H8, byte[] e5W8, int Bk4x, int Pw5o)
	{
		m6H8 = (byte)(m6H8 ^ checked((byte)(e5W8[unchecked(Pw5o % e5W8.Length)] ^ ((Pw5o + unchecked(Bk4x % e5W8.Length)) & Bk4x))));
		return m6H8;
	}
}
