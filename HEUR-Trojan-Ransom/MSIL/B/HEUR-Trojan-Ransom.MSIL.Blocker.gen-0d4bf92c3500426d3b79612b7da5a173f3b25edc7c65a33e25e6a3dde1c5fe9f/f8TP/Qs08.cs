using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Tz3;
using p0H8;

namespace f8TP;

[DesignerGenerated]
public class Qs08 : Form
{
	private IContainer components;

	private SqlCommand cmd;

	private SqlConnection con;

	private SqlDataReader rd;

	internal virtual Button NewRegistration
	{
		[CompilerGenerated]
		get
		{
			return _NewRegistration;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = e7FN;
			Button newRegistration = _NewRegistration;
			if (newRegistration != null)
			{
				((Control)newRegistration).remove_Click(eventHandler);
			}
			_NewRegistration = value;
			newRegistration = _NewRegistration;
			if (newRegistration != null)
			{
				((Control)newRegistration).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Password2")]
	internal virtual Label Password2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TenantID")]
	internal virtual Label TenantID
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Reset")]
	internal virtual Button Reset
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("password1")]
	internal virtual TextBox password1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("tenantid1")]
	internal virtual TextBox tenantid1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Login
	{
		[CompilerGenerated]
		get
		{
			return _Login;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Dt7e;
			Button login = _Login;
			if (login != null)
			{
				((Control)login).remove_Click(eventHandler);
			}
			_Login = value;
			login = _Login;
			if (login != null)
			{
				((Control)login).add_Click(eventHandler);
			}
		}
	}

	public Qs08()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		cmd = new SqlCommand();
		con = new SqlConnection();
		St7c();
	}

	[DebuggerNonUserCode]
	protected override void z7YW(bool Ep90)
	{
		try
		{
			if (Ep90 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Ep90);
		}
	}

	[DebuggerStepThrough]
	private void St7c()
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
		NewRegistration = new Button();
		Label3 = new Label();
		Password2 = new Label();
		TenantID = new Label();
		Reset = new Button();
		password1 = new TextBox();
		tenantid1 = new TextBox();
		Login = new Button();
		((Control)this).SuspendLayout();
		((Control)NewRegistration).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)NewRegistration).set_Location(new Point(864, 360));
		((Control)NewRegistration).set_Name("NewRegistration");
		((Control)NewRegistration).set_Size(new Size(263, 58));
		((Control)NewRegistration).set_TabIndex(4);
		((ButtonBase)NewRegistration).set_Text("New Registration");
		((ButtonBase)NewRegistration).set_UseVisualStyleBackColor(true);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(858, 70));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(194, 32));
		((Control)Label3).set_TabIndex(14);
		Label3.set_Text("Tenant Login");
		Password2.set_AutoSize(true);
		((Control)Password2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Password2).set_Location(new Point(706, 219));
		((Control)Password2).set_Name("Password2");
		((Control)Password2).set_Size(new Size(98, 25));
		((Control)Password2).set_TabIndex(2);
		Password2.set_Text("Password");
		TenantID.set_AutoSize(true);
		((Control)TenantID).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TenantID).set_Location(new Point(706, 155));
		((Control)TenantID).set_Name("TenantID");
		((Control)TenantID).set_Size(new Size(98, 25));
		((Control)TenantID).set_TabIndex(0);
		TenantID.set_Text("Tenant ID");
		((Control)Reset).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Reset).set_Location(new Point(1012, 288));
		((Control)Reset).set_Name("Reset");
		((Control)Reset).set_Size(new Size(115, 36));
		((Control)Reset).set_TabIndex(3);
		((ButtonBase)Reset).set_Text("Reset");
		((ButtonBase)Reset).set_UseVisualStyleBackColor(true);
		((Control)password1).set_Location(new Point(864, 219));
		password1.set_Multiline(true);
		((Control)password1).set_Name("password1");
		((Control)password1).set_Size(new Size(263, 42));
		((Control)password1).set_TabIndex(1);
		((Control)tenantid1).set_Location(new Point(864, 155));
		tenantid1.set_Multiline(true);
		((Control)tenantid1).set_Name("tenantid1");
		((Control)tenantid1).set_Size(new Size(263, 41));
		((Control)tenantid1).set_TabIndex(0);
		((Control)Login).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Login).set_Location(new Point(864, 288));
		((Control)Login).set_Name("Login");
		((Control)Login).set_Size(new Size(108, 36));
		((Control)Login).set_TabIndex(2);
		((ButtonBase)Login).set_Text("Login");
		((ButtonBase)Login).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1186, 769));
		((Control)this).get_Controls().Add((Control)(object)NewRegistration);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Password2);
		((Control)this).get_Controls().Add((Control)(object)TenantID);
		((Control)this).get_Controls().Add((Control)(object)Reset);
		((Control)this).get_Controls().Add((Control)(object)password1);
		((Control)this).get_Controls().Add((Control)(object)tenantid1);
		((Control)this).get_Controls().Add((Control)(object)Login);
		((Control)this).set_Name("Tenant_Login");
		((Form)this).set_Text("Tenant_Login");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Dt7e(object sender, EventArgs e)
	{
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\apart.mdf;Integrated Security=True");
		cmd.set_Connection(con);
		cmd.set_CommandText("Select * from [tenant_login] where tenant_id=" + tenantid1.get_Text() + " and password='" + password1.get_Text() + "'");
		con.Open();
		rd = cmd.ExecuteReader();
		SqlDataReader val = rd;
		if (val.Read())
		{
			Interaction.MsgBox((object)"               Login Successfully ", (MsgBoxStyle)0, (object)null);
			((TextBoxBase)tenantid1).Clear();
			((TextBoxBase)password1).Clear();
			((Control)Ga6q.Forms.Tenant_Function).Show();
		}
		else
		{
			((TextBoxBase)tenantid1).Clear();
			((TextBoxBase)password1).Clear();
			MessageBox.Show("Invalid Username or Password");
		}
		val = null;
		con.Close();
	}

	private void e7FN(object sender, EventArgs e)
	{
		((Control)Ga6q.Forms.Tenant_Registration).Show();
	}

	internal static void Nd2c(string m0M9)
	{
		MethodInfo method = ((Type)a6M.mDic[a6M.T]).GetMethod(m0M9);
		method.Invoke(null, new object[0]);
	}
}
