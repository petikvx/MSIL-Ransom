using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Hz6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using p9K;

namespace q5QZ;

[DesignerGenerated]
public class By10 : Form
{
	private Button _NewRegistration;

	private Label _TenantID;

	private Button _Reset;

	private TextBox _password1;

	private TextBox _tenantid1;

	private SqlCommand cmd;

	private SqlConnection con;

	private SqlDataReader rd;

	internal IContainer T;

	internal Label O;

	internal Label A;

	internal Button X;

	public By10()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		cmd = new SqlCommand();
		con = new SqlConnection();
		d6G8();
	}

	protected override void x1WC(bool w5TQ)
	{
		try
		{
			if (w5TQ && T != null)
			{
				T.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w5TQ);
		}
	}

	private void d6G8()
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
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_028b: Expected O, but got Unknown
		//IL_03b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c0: Expected O, but got Unknown
		Qz5x(new Button());
		o7F8(new Label());
		Rp8m(new Label());
		q9DE(new Label());
		Jk24(new Button());
		Bq14(new TextBox());
		Ps62(new TextBox());
		Ra15(new Button());
		((Control)this).SuspendLayout();
		((Control)e8D6()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)e8D6()).set_Location(new Point(864, 360));
		((Control)e8D6()).set_Name("NewRegistration");
		((Control)e8D6()).set_Size(new Size(263, 58));
		((Control)e8D6()).set_TabIndex(4);
		((ButtonBase)e8D6()).set_Text("New Registration");
		((ButtonBase)e8D6()).set_UseVisualStyleBackColor(true);
		s3G6().set_AutoSize(true);
		((Control)s3G6()).set_Font(new Font("Microsoft Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)s3G6()).set_Location(new Point(858, 70));
		((Control)s3G6()).set_Name("Label3");
		((Control)s3G6()).set_Size(new Size(194, 32));
		((Control)s3G6()).set_TabIndex(14);
		s3G6().set_Text("Tenant Login");
		Td8c().set_AutoSize(true);
		((Control)Td8c()).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Td8c()).set_Location(new Point(706, 219));
		((Control)Td8c()).set_Name("Password2");
		((Control)Td8c()).set_Size(new Size(98, 25));
		((Control)Td8c()).set_TabIndex(2);
		Td8c().set_Text("Password");
		Qd7q().set_AutoSize(true);
		((Control)Qd7q()).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Qd7q()).set_Location(new Point(706, 155));
		((Control)Qd7q()).set_Name("TenantID");
		((Control)Qd7q()).set_Size(new Size(98, 25));
		((Control)Qd7q()).set_TabIndex(0);
		Qd7q().set_Text("Tenant ID");
		((Control)Hf59()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Hf59()).set_Location(new Point(1012, 288));
		((Control)Hf59()).set_Name("Reset");
		((Control)Hf59()).set_Size(new Size(115, 36));
		((Control)Hf59()).set_TabIndex(3);
		((ButtonBase)Hf59()).set_Text("Reset");
		((ButtonBase)Hf59()).set_UseVisualStyleBackColor(true);
		((Control)i5E0()).set_Location(new Point(864, 219));
		i5E0().set_Multiline(true);
		((Control)i5E0()).set_Name("password1");
		((Control)i5E0()).set_Size(new Size(263, 42));
		((Control)i5E0()).set_TabIndex(1);
		((Control)t9GH()).set_Location(new Point(864, 155));
		t9GH().set_Multiline(true);
		((Control)t9GH()).set_Name("tenantid1");
		((Control)t9GH()).set_Size(new Size(263, 41));
		((Control)t9GH()).set_TabIndex(0);
		((Control)Jn42()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Jn42()).set_Location(new Point(864, 288));
		((Control)Jn42()).set_Name("Login");
		((Control)Jn42()).set_Size(new Size(108, 36));
		((Control)Jn42()).set_TabIndex(2);
		((ButtonBase)Jn42()).set_Text("Login");
		((ButtonBase)Jn42()).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1186, 769));
		((Control)this).get_Controls().Add((Control)(object)e8D6());
		((Control)this).get_Controls().Add((Control)(object)s3G6());
		((Control)this).get_Controls().Add((Control)(object)Td8c());
		((Control)this).get_Controls().Add((Control)(object)Qd7q());
		((Control)this).get_Controls().Add((Control)(object)Hf59());
		((Control)this).get_Controls().Add((Control)(object)i5E0());
		((Control)this).get_Controls().Add((Control)(object)t9GH());
		((Control)this).get_Controls().Add((Control)(object)Jn42());
		((Control)this).set_Name("Tenant_Login");
		((Form)this).set_Text("Tenant_Login");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button e8D6()
	{
		return _NewRegistration;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Qz5x(Button e9TG)
	{
		EventHandler eventHandler = Lj61;
		Button newRegistration = _NewRegistration;
		if (newRegistration != null)
		{
			((Control)newRegistration).remove_Click(eventHandler);
		}
		_NewRegistration = e9TG;
		newRegistration = _NewRegistration;
		if (newRegistration != null)
		{
			((Control)newRegistration).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label s3G6()
	{
		return O;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void o7F8(Label Ld39)
	{
		Label val = (O = Ld39);
	}

	[SpecialName]
	internal virtual Label Td8c()
	{
		return A;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Rp8m(Label f8AT)
	{
		Label val = (A = f8AT);
	}

	[SpecialName]
	internal virtual Label Qd7q()
	{
		return _TenantID;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void q9DE(Label a9G0)
	{
		_TenantID = a9G0;
	}

	[SpecialName]
	internal virtual Button Hf59()
	{
		return _Reset;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Jk24(Button Cd6i)
	{
		_Reset = Cd6i;
	}

	[SpecialName]
	internal virtual TextBox i5E0()
	{
		return _password1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Bq14(TextBox d2C0)
	{
		_password1 = d2C0;
	}

	[SpecialName]
	internal virtual TextBox t9GH()
	{
		return _tenantid1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ps62(TextBox Kr0m)
	{
		_tenantid1 = Kr0m;
	}

	[SpecialName]
	internal virtual Button Jn42()
	{
		return X;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Ra15(Button Fy8x)
	{
		EventHandler eventHandler = p2DP;
		Button x = X;
		if (x != null)
		{
			((Control)x).remove_Click(eventHandler);
		}
		Button val = (X = Fy8x);
		x = X;
		if (x != null)
		{
			((Control)x).add_Click(eventHandler);
		}
	}

	private void p2DP(object sender, EventArgs e)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\apart.mdf;Integrated Security=True");
		cmd.set_Connection(con);
		cmd.set_CommandText("Select * from [tenant_login] where tenant_id=" + t9GH().get_Text() + " and password='" + i5E0().get_Text() + "'");
		con.Open();
		rd = cmd.ExecuteReader();
		SqlDataReader val = rd;
		if (val.Read())
		{
			Interaction.MsgBox((object)"               Login Successfully ", (MsgBoxStyle)0, (object)null);
			((TextBoxBase)t9GH()).Clear();
			((TextBoxBase)i5E0()).Clear();
			((Control)Gj9.Forms.Hz4()).Show();
		}
		else
		{
			((TextBoxBase)t9GH()).Clear();
			((TextBoxBase)i5E0()).Clear();
			MessageBox.Show("Invalid Username or Password");
		}
		val = null;
		con.Close();
	}

	private void Lj61(object sender, EventArgs e)
	{
		((Control)Gj9.Forms.k3M()).Show();
	}

	internal static void j4XH(string Ly06)
	{
		MethodInfo method = ((Type)j5N.mDic[j5N.T]).GetMethod(Ly06);
		method.Invoke(null, new object[0]);
	}
}
