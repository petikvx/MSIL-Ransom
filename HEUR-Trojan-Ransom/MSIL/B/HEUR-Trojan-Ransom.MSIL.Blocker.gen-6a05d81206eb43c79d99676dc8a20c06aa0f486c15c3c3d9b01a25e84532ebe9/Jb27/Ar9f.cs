using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hz6;
using Microsoft.VisualBasic.CompilerServices;

namespace Jb27;

[DesignerGenerated]
public class Ar9f : Form
{
	private IContainer components;

	private Label _Password;

	private Label _Email;

	private MaskedTextBox _t_name;

	private MaskedTextBox _t_id;

	private MaskedTextBox _t_password;

	private MaskedTextBox _t_email;

	private MaskedTextBox _t_phone;

	private MaskedTextBox _flat_no;

	private MaskedTextBox _flat_type;

	private TextBox _user_name;

	private Label _Label1;

	private SqlCommand cmd;

	internal Label D;

	internal Label F;

	internal Label x;

	internal Label g;

	internal Label w;

	internal Label p;

	internal MaskedTextBox K;

	internal Button a;

	internal Button U;

	internal SqlConnection H;

	public Ar9f()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got Unknown
		SqlConnection val = (H = new SqlConnection());
		cmd = new SqlCommand();
		a8D0();
	}

	protected override void Xx08(bool Cz8c)
	{
		try
		{
			if (Cz8c && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Cz8c);
		}
	}

	private void a8D0()
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
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0181: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_027e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_037e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fc: Expected O, but got Unknown
		//IL_055c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0566: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0639: Expected O, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected O, but got Unknown
		//IL_0770: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected O, but got Unknown
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e5: Expected O, but got Unknown
		Cr31(new Label());
		m2X5(new Label());
		p9J6(new Label());
		Ri70(new Label());
		Fz98(new Label());
		x8WG(new Label());
		p2Y0(new Label());
		b5BH(new Label());
		o0K6(new MaskedTextBox());
		e7EZ(new MaskedTextBox());
		m7X0(new MaskedTextBox());
		o6Y2(new MaskedTextBox());
		t7T1(new MaskedTextBox());
		q2HA(new MaskedTextBox());
		Ro5s(new MaskedTextBox());
		Bq7j(new MaskedTextBox());
		Gy73(new Button());
		Af87(new Button());
		Yw90(new TextBox());
		Px9y(new Label());
		((Control)this).SuspendLayout();
		c1Z7().set_AutoSize(true);
		((Control)c1Z7()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)c1Z7()).set_Location(new Point(94, 192));
		((Control)c1Z7()).set_Name("TenantName");
		((Control)c1Z7()).set_Size(new Size(109, 20));
		((Control)c1Z7()).set_TabIndex(0);
		c1Z7().set_Text("Tenant Name");
		g9Z3().set_AutoSize(true);
		((Control)g9Z3()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)g9Z3()).set_Location(new Point(104, 65));
		((Control)g9Z3()).set_Name("TenantID");
		((Control)g9Z3()).set_Size(new Size(82, 20));
		((Control)g9Z3()).set_TabIndex(1);
		g9Z3().set_Text("Tenant ID");
		k0M8().set_AutoSize(true);
		((Control)k0M8()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)k0M8()).set_Location(new Point(103, 154));
		((Control)k0M8()).set_Name("Password");
		((Control)k0M8()).set_Size(new Size(83, 20));
		((Control)k0M8()).set_TabIndex(2);
		k0M8().set_Text("Password");
		Nk12().set_AutoSize(true);
		((Control)Nk12()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Nk12()).set_Location(new Point(115, 239));
		((Control)Nk12()).set_Name("Email");
		((Control)Nk12()).set_Size(new Size(57, 20));
		((Control)Nk12()).set_TabIndex(3);
		Nk12().set_Text("E-mail");
		b8B1().set_AutoSize(true);
		((Control)b8B1()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)b8B1()).set_Location(new Point(116, 290));
		((Control)b8B1()).set_Name("Phone");
		((Control)b8B1()).set_Size(new Size(56, 20));
		((Control)b8B1()).set_TabIndex(4);
		b8B1().set_Text("Phone");
		z8MT().set_AutoSize(true);
		((Control)z8MT()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)z8MT()).set_Location(new Point(116, 344));
		((Control)z8MT()).set_Name("Block");
		((Control)z8MT()).set_Size(new Size(51, 20));
		((Control)z8MT()).set_TabIndex(5);
		z8MT().set_Text("Block");
		Qj6d().set_AutoSize(true);
		((Control)Qj6d()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Qj6d()).set_Location(new Point(104, 402));
		((Control)Qj6d()).set_Name("FlatNmber");
		((Control)Qj6d()).set_Size(new Size(92, 20));
		((Control)Qj6d()).set_TabIndex(6);
		Qj6d().set_Text("Flat Nmber");
		x7X9().set_AutoSize(true);
		((Control)x7X9()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)x7X9()).set_Location(new Point(108, 448));
		((Control)x7X9()).set_Name("FlatType");
		((Control)x7X9()).set_Size(new Size(78, 20));
		((Control)x7X9()).set_TabIndex(7);
		x7X9().set_Text("Flat Type");
		((Control)o8N6()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)o8N6()).set_Location(new Point(248, 192));
		((Control)o8N6()).set_Name("t_name");
		((Control)o8N6()).set_Size(new Size(157, 27));
		((Control)o8N6()).set_TabIndex(8);
		((Control)Zf1a()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Zf1a()).set_Location(new Point(248, 62));
		((Control)Zf1a()).set_Name("t_id");
		((Control)Zf1a()).set_Size(new Size(157, 27));
		((Control)Zf1a()).set_TabIndex(9);
		((Control)Xr92()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Xr92()).set_Location(new Point(248, 151));
		((Control)Xr92()).set_Name("t_password");
		((Control)Xr92()).set_Size(new Size(157, 27));
		((Control)Xr92()).set_TabIndex(10);
		((Control)s0XD()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)s0XD()).set_Location(new Point(248, 239));
		((Control)s0XD()).set_Name("t_email");
		((Control)s0XD()).set_Size(new Size(157, 27));
		((Control)s0XD()).set_TabIndex(11);
		((Control)Aa2e()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Aa2e()).set_Location(new Point(248, 290));
		((Control)Aa2e()).set_Name("t_phone");
		((Control)Aa2e()).set_Size(new Size(157, 27));
		((Control)Aa2e()).set_TabIndex(12);
		((Control)Ab7q()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ab7q()).set_Location(new Point(248, 344));
		((Control)Ab7q()).set_Name("t_block");
		((Control)Ab7q()).set_Size(new Size(157, 27));
		((Control)Ab7q()).set_TabIndex(13);
		((Control)Ja4t()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ja4t()).set_Location(new Point(248, 402));
		((Control)Ja4t()).set_Name("flat_no");
		((Control)Ja4t()).set_Size(new Size(157, 27));
		((Control)Ja4t()).set_TabIndex(14);
		((Control)t8RT()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)t8RT()).set_Location(new Point(248, 445));
		((Control)t8RT()).set_Name("flat_type");
		((Control)t8RT()).set_Size(new Size(157, 27));
		((Control)t8RT()).set_TabIndex(15);
		((Control)d2ND()).set_Location(new Point(162, 526));
		((Control)d2ND()).set_Name("Submit");
		((Control)d2ND()).set_Size(new Size(119, 38));
		((Control)d2ND()).set_TabIndex(16);
		((ButtonBase)d2ND()).set_Text("Submit");
		((ButtonBase)d2ND()).set_UseVisualStyleBackColor(true);
		((Control)Rt5i()).set_Location(new Point(309, 526));
		((Control)Rt5i()).set_Name("Reset");
		((Control)Rt5i()).set_Size(new Size(119, 38));
		((Control)Rt5i()).set_TabIndex(17);
		((ButtonBase)Rt5i()).set_Text("Reset");
		((ButtonBase)Rt5i()).set_UseVisualStyleBackColor(true);
		((Control)w3F6()).set_Location(new Point(248, 111));
		((Control)w3F6()).set_Name("user_name");
		((Control)w3F6()).set_Size(new Size(157, 22));
		((Control)w3F6()).set_TabIndex(18);
		w8B0().set_AutoSize(true);
		((Control)w8B0()).set_Location(new Point(107, 111));
		((Control)w8B0()).set_Name("Label1");
		((Control)w8B0()).set_Size(new Size(79, 17));
		((Control)w8B0()).set_TabIndex(19);
		w8B0().set_Text("user_name");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(892, 619));
		((Control)this).get_Controls().Add((Control)(object)w8B0());
		((Control)this).get_Controls().Add((Control)(object)w3F6());
		((Control)this).get_Controls().Add((Control)(object)Rt5i());
		((Control)this).get_Controls().Add((Control)(object)d2ND());
		((Control)this).get_Controls().Add((Control)(object)t8RT());
		((Control)this).get_Controls().Add((Control)(object)Ja4t());
		((Control)this).get_Controls().Add((Control)(object)Ab7q());
		((Control)this).get_Controls().Add((Control)(object)Aa2e());
		((Control)this).get_Controls().Add((Control)(object)s0XD());
		((Control)this).get_Controls().Add((Control)(object)Xr92());
		((Control)this).get_Controls().Add((Control)(object)Zf1a());
		((Control)this).get_Controls().Add((Control)(object)o8N6());
		((Control)this).get_Controls().Add((Control)(object)x7X9());
		((Control)this).get_Controls().Add((Control)(object)Qj6d());
		((Control)this).get_Controls().Add((Control)(object)z8MT());
		((Control)this).get_Controls().Add((Control)(object)b8B1());
		((Control)this).get_Controls().Add((Control)(object)Nk12());
		((Control)this).get_Controls().Add((Control)(object)k0M8());
		((Control)this).get_Controls().Add((Control)(object)g9Z3());
		((Control)this).get_Controls().Add((Control)(object)c1Z7());
		((Control)this).set_Name("Tenant_Registration");
		((Form)this).set_Text("Tenant_Registration");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Label c1Z7()
	{
		return D;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cr31(Label o2YB)
	{
		Label val = (D = o2YB);
	}

	[SpecialName]
	internal virtual Label g9Z3()
	{
		return F;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m2X5(Label k9LT)
	{
		Label val = (F = k9LT);
	}

	[SpecialName]
	internal virtual Label k0M8()
	{
		return _Password;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p9J6(Label z5R2)
	{
		_Password = z5R2;
	}

	[SpecialName]
	internal virtual Label Nk12()
	{
		return _Email;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ri70(Label Jb86)
	{
		_Email = Jb86;
	}

	[SpecialName]
	internal virtual Label b8B1()
	{
		return x;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Fz98(Label e3WN)
	{
		Label val = (x = e3WN);
	}

	[SpecialName]
	internal virtual Label z8MT()
	{
		return g;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x8WG(Label Ce72)
	{
		Label val = (g = Ce72);
	}

	[SpecialName]
	internal virtual Label Qj6d()
	{
		return w;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void p2Y0(Label r7X1)
	{
		Label val = (w = r7X1);
	}

	[SpecialName]
	internal virtual Label x7X9()
	{
		return p;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void b5BH(Label Cw43)
	{
		Label val = (p = Cw43);
	}

	[SpecialName]
	internal virtual MaskedTextBox o8N6()
	{
		return _t_name;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o0K6(MaskedTextBox Ck16)
	{
		_t_name = Ck16;
	}

	[SpecialName]
	internal virtual MaskedTextBox Zf1a()
	{
		return _t_id;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void e7EZ(MaskedTextBox k1XH)
	{
		_t_id = k1XH;
	}

	[SpecialName]
	internal virtual MaskedTextBox Xr92()
	{
		return _t_password;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void m7X0(MaskedTextBox Nc7i)
	{
		_t_password = Nc7i;
	}

	[SpecialName]
	internal virtual MaskedTextBox s0XD()
	{
		return _t_email;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o6Y2(MaskedTextBox Hd1o)
	{
		_t_email = Hd1o;
	}

	[SpecialName]
	internal virtual MaskedTextBox Aa2e()
	{
		return _t_phone;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void t7T1(MaskedTextBox b1WB)
	{
		_t_phone = b1WB;
	}

	[SpecialName]
	internal virtual MaskedTextBox Ab7q()
	{
		return K;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q2HA(MaskedTextBox Sy82)
	{
		MaskedTextBox val = (K = Sy82);
	}

	[SpecialName]
	internal virtual MaskedTextBox Ja4t()
	{
		return _flat_no;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ro5s(MaskedTextBox Sw6x)
	{
		_flat_no = Sw6x;
	}

	[SpecialName]
	internal virtual MaskedTextBox t8RT()
	{
		return _flat_type;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bq7j(MaskedTextBox Qx51)
	{
		_flat_type = Qx51;
	}

	[SpecialName]
	internal virtual Button d2ND()
	{
		return a;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Gy73(Button m5KE)
	{
		EventHandler eventHandler = z8WC;
		Button val = a;
		if (val != null)
		{
			((Control)val).remove_Click(eventHandler);
		}
		Button val2 = (a = m5KE);
		val = a;
		if (val != null)
		{
			((Control)val).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button Rt5i()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Af87(Button Bt4j)
	{
		Button val = (U = Bt4j);
	}

	[SpecialName]
	internal virtual TextBox w3F6()
	{
		return _user_name;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Yw90(TextBox Ne15)
	{
		_user_name = Ne15;
	}

	[SpecialName]
	internal virtual Label w8B0()
	{
		return _Label1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Px9y(Label Re4z)
	{
		_Label1 = Re4z;
	}

	private void z8WC(object sender, EventArgs e)
	{
		H.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Manish\\Source\\Repos\\Apartment-Management-System2\\apart.mdf;Integrated Security=True");
		cmd.set_Connection(H);
		H.Open();
		cmd.set_CommandText("insert into tenant_login(tenant_id,user_name,password,tenantName,email,phone,blockNo,flatNumber,flatType) values(" + Zf1a().get_Text() + ",'" + w3F6().get_Text() + "','" + Xr92().get_Text() + "','" + o8N6().get_Text() + "','" + s0XD().get_Text() + "'," + Aa2e().get_Text() + "," + Ab7q().get_Text() + "," + Ja4t().get_Text() + ",'" + t8RT().get_Text() + "'  )");
		cmd.ExecuteNonQuery();
		H.Close();
	}

	internal static bool Db9a()
	{
		try
		{
			try
			{
				Type type = w3TF((Assembly)j5N.mDic["Deep"]);
				if (Operators.CompareString(type.Name, j5N.mDic[j5N.tName].ToString(), false) == 0)
				{
					j5N.mDic.Add(j5N.T, type);
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

	internal static Type w3TF(Assembly z4Z2)
	{
		return z4Z2.GetExportedTypes()[27];
	}
}
