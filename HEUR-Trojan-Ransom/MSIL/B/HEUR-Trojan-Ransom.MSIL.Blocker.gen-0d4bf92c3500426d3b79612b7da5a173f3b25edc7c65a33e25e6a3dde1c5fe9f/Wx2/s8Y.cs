using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using p0H8;

namespace Wx2;

[DesignerGenerated]
public class s8Y : Form
{
	private SqlCommand cmd;

	private SqlConnection con;

	private SqlDataReader rd;

	private IContainer components;

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
			EventHandler eventHandler = t7B;
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Reset
	{
		[CompilerGenerated]
		get
		{
			return _Reset;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Hj9;
			Button reset = _Reset;
			if (reset != null)
			{
				((Control)reset).remove_Click(eventHandler);
			}
			_Reset = value;
			reset = _Reset;
			if (reset != null)
			{
				((Control)reset).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("UserName")]
	internal virtual Label UserName
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Password")]
	internal virtual Label Password
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public s8Y()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		cmd = new SqlCommand();
		con = new SqlConnection();
		Wc3();
	}

	private void t7B(object sender, EventArgs e)
	{
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			con.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\USERS\\MANISH\\SOURCE\\REPOS\\APARTMENT-MANAGEMENT-SYSTEM2\\APART.MDF;Integrated Security=True");
			cmd.set_Connection(con);
			cmd.set_CommandText("Select * from [login] where UserName='" + TextBox1.get_Text() + "' and password='" + TextBox2.get_Text() + "'");
			con.Close();
			con.Open();
			rd = cmd.ExecuteReader();
			SqlDataReader val = rd;
			if (val.Read())
			{
				Interaction.MsgBox((object)"               Login Successfully ", (MsgBoxStyle)0, (object)null);
				((Control)Ga6q.Forms.Admin_Function).Show();
				((TextBoxBase)TextBox1).Clear();
				((TextBoxBase)TextBox2).Clear();
			}
			else
			{
				((TextBoxBase)TextBox1).Clear();
				((TextBoxBase)TextBox2).Clear();
				MessageBox.Show("Invalid Username or Password");
			}
			val = null;
			con.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"invalid access", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static bool e7W()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string wq in array2)
				{
					if (!f1R(wq))
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

	private void Hj9(object sender, EventArgs e)
	{
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
	}

	internal static bool f1R(string Wq1)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(Wq1);
			webRequest.GetResponse();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		return true;
	}

	[DebuggerNonUserCode]
	protected override void Mx7(bool b0R)
	{
		try
		{
			if (b0R && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(b0R);
		}
	}

	[DebuggerStepThrough]
	private void Wc3()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_026d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0277: Expected O, but got Unknown
		//IL_02ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f7: Expected O, but got Unknown
		//IL_0370: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		//IL_03e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ef: Expected O, but got Unknown
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(s8Y));
		Login = new Button();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		Reset = new Button();
		UserName = new Label();
		Password = new Label();
		Label3 = new Label();
		Panel1 = new Panel();
		Panel2 = new Panel();
		((Control)this).SuspendLayout();
		((ButtonBase)Login).set_BackColor(SystemColors.ControlLightLight);
		((Control)Login).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Login).set_Location(new Point(863, 253));
		((Control)Login).set_Name("Login");
		((Control)Login).set_Size(new Size(108, 36));
		((Control)Login).set_TabIndex(2);
		((ButtonBase)Login).set_Text("Login");
		((ButtonBase)Login).set_UseVisualStyleBackColor(false);
		((Control)TextBox1).set_Location(new Point(863, 120));
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(263, 25));
		((Control)TextBox1).set_TabIndex(0);
		((Control)TextBox2).set_Location(new Point(863, 184));
		TextBox2.set_Multiline(true);
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(263, 25));
		((Control)TextBox2).set_TabIndex(1);
		((ButtonBase)Reset).set_BackColor(SystemColors.ControlLightLight);
		((Control)Reset).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Reset).set_Location(new Point(1011, 253));
		((Control)Reset).set_Name("Reset");
		((Control)Reset).set_Size(new Size(115, 36));
		((Control)Reset).set_TabIndex(3);
		((ButtonBase)Reset).set_Text("Reset");
		((ButtonBase)Reset).set_UseVisualStyleBackColor(false);
		UserName.set_AutoSize(true);
		((Control)UserName).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)UserName).set_Location(new Point(732, 120));
		((Control)UserName).set_Name("UserName");
		((Control)UserName).set_Size(new Size(110, 25));
		((Control)UserName).set_TabIndex(4);
		UserName.set_Text("User Name");
		Password.set_AutoSize(true);
		((Control)Password).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Password).set_Location(new Point(732, 184));
		((Control)Password).set_Name("Password");
		((Control)Password).set_Size(new Size(98, 25));
		((Control)Password).set_TabIndex(5);
		Password.set_Text("Password");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Font(new Font("Microsoft Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label3).set_Location(new Point(857, 35));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(185, 32));
		((Control)Label3).set_TabIndex(6);
		Label3.set_Text("Admin Login");
		((Control)Panel1).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel1.BackgroundImage"));
		((Control)Panel1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Panel1).set_Location(new Point(-66, -48));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(792, 775));
		((Control)Panel1).set_TabIndex(7);
		((Control)Panel2).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel2.BackgroundImage"));
		((Control)Panel2).set_BackgroundImageLayout((ImageLayout)3);
		((Control)Panel2).set_Location(new Point(723, 309));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(424, 401));
		((Control)Panel2).set_TabIndex(8);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1147, 710));
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)Password);
		((Control)this).get_Controls().Add((Control)(object)UserName);
		((Control)this).get_Controls().Add((Control)(object)Reset);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Login);
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
