using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using p9K;

namespace m2Q;

[DesignerGenerated]
public class Mq9 : Form
{
	private SqlCommand cmd;

	private TextBox _TextBox1;

	private TextBox _TextBox2;

	private Button _Reset;

	private Label _Password;

	private Label _Label3;

	private Panel _Panel1;

	private Panel _Panel2;

	internal SqlConnection C;

	internal SqlDataReader I;

	internal IContainer p;

	internal Button U;

	internal Label r;

	public Mq9()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		cmd = new SqlCommand();
		SqlConnection val = (C = new SqlConnection());
		p1F();
	}

	private void Hr4(object sender, EventArgs e)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			C.set_ConnectionString("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\USERS\\MANISH\\SOURCE\\REPOS\\APARTMENT-MANAGEMENT-SYSTEM2\\APART.MDF;Integrated Security=True");
			cmd.set_Connection(C);
			cmd.set_CommandText("Select * from [login] where UserName='" + t1L().get_Text() + "' and password='" + q9E().get_Text() + "'");
			C.Close();
			C.Open();
			SqlDataReader val = (I = cmd.ExecuteReader());
			SqlDataReader i = I;
			if (i.Read())
			{
				Interaction.MsgBox((object)"               Login Successfully ", (MsgBoxStyle)0, (object)null);
				((Control)Gj9.Forms.Xp5()).Show();
				((TextBoxBase)t1L()).Clear();
				((TextBoxBase)q9E()).Clear();
			}
			else
			{
				((TextBoxBase)t1L()).Clear();
				((TextBoxBase)q9E()).Clear();
				MessageBox.Show("Invalid Username or Password");
			}
			i = null;
			C.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"invalid access", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
	}

	internal static bool Lr3()
	{
		string[] array = new string[2] { "https://www.google.com/", "https://www.bing.com/" };
		int num = 0;
		checked
		{
			while (num != 2)
			{
				string[] array2 = array;
				foreach (string x8H in array2)
				{
					if (!y2B(x8H))
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

	private void p6L(object sender, EventArgs e)
	{
		((TextBoxBase)t1L()).Clear();
		((TextBoxBase)q9E()).Clear();
	}

	internal static bool y2B(string x8H)
	{
		try
		{
			WebRequest webRequest = WebRequest.Create(x8H);
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

	protected override void t7X(bool Re5)
	{
		try
		{
			if (Re5 && p != null)
			{
				p.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Re5);
		}
	}

	private void p1F()
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
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Mq9));
		Xf9(new Button());
		Mj4(new TextBox());
		w4C(new TextBox());
		Cn2(new Button());
		c5X(new Label());
		d6G(new Label());
		x3F(new Label());
		j1C(new Panel());
		g5Q(new Panel());
		((Control)this).SuspendLayout();
		((ButtonBase)x2W()).set_BackColor(SystemColors.ControlLightLight);
		((Control)x2W()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)x2W()).set_Location(new Point(863, 253));
		((Control)x2W()).set_Name("Login");
		((Control)x2W()).set_Size(new Size(108, 36));
		((Control)x2W()).set_TabIndex(2);
		((ButtonBase)x2W()).set_Text("Login");
		((ButtonBase)x2W()).set_UseVisualStyleBackColor(false);
		((Control)t1L()).set_Location(new Point(863, 120));
		t1L().set_Multiline(true);
		((Control)t1L()).set_Name("TextBox1");
		((Control)t1L()).set_Size(new Size(263, 25));
		((Control)t1L()).set_TabIndex(0);
		((Control)q9E()).set_Location(new Point(863, 184));
		q9E().set_Multiline(true);
		((Control)q9E()).set_Name("TextBox2");
		((Control)q9E()).set_Size(new Size(263, 25));
		((Control)q9E()).set_TabIndex(1);
		((ButtonBase)a8E()).set_BackColor(SystemColors.ControlLightLight);
		((Control)a8E()).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)a8E()).set_Location(new Point(1011, 253));
		((Control)a8E()).set_Name("Reset");
		((Control)a8E()).set_Size(new Size(115, 36));
		((Control)a8E()).set_TabIndex(3);
		((ButtonBase)a8E()).set_Text("Reset");
		((ButtonBase)a8E()).set_UseVisualStyleBackColor(false);
		Fm5().set_AutoSize(true);
		((Control)Fm5()).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Fm5()).set_Location(new Point(732, 120));
		((Control)Fm5()).set_Name("UserName");
		((Control)Fm5()).set_Size(new Size(110, 25));
		((Control)Fm5()).set_TabIndex(4);
		Fm5().set_Text("User Name");
		Ef2().set_AutoSize(true);
		((Control)Ef2()).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Ef2()).set_Location(new Point(732, 184));
		((Control)Ef2()).set_Name("Password");
		((Control)Ef2()).set_Size(new Size(98, 25));
		((Control)Ef2()).set_TabIndex(5);
		Ef2().set_Text("Password");
		q1M().set_AutoSize(true);
		((Control)q1M()).set_Font(new Font("Microsoft Sans Serif", 16.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)q1M()).set_Location(new Point(857, 35));
		((Control)q1M()).set_Name("Label3");
		((Control)q1M()).set_Size(new Size(185, 32));
		((Control)q1M()).set_TabIndex(6);
		q1M().set_Text("Admin Login");
		((Control)t4L()).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel1.BackgroundImage"));
		((Control)t4L()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)t4L()).set_Location(new Point(-66, -48));
		((Control)t4L()).set_Name("Panel1");
		((Control)t4L()).set_Size(new Size(792, 775));
		((Control)t4L()).set_TabIndex(7);
		((Control)b8X()).set_BackgroundImage((Image)componentResourceManager.GetObject("Panel2.BackgroundImage"));
		((Control)b8X()).set_BackgroundImageLayout((ImageLayout)3);
		((Control)b8X()).set_Location(new Point(723, 309));
		((Control)b8X()).set_Name("Panel2");
		((Control)b8X()).set_Size(new Size(424, 401));
		((Control)b8X()).set_TabIndex(8);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1147, 710));
		((Control)this).get_Controls().Add((Control)(object)b8X());
		((Control)this).get_Controls().Add((Control)(object)t4L());
		((Control)this).get_Controls().Add((Control)(object)q1M());
		((Control)this).get_Controls().Add((Control)(object)Ef2());
		((Control)this).get_Controls().Add((Control)(object)Fm5());
		((Control)this).get_Controls().Add((Control)(object)a8E());
		((Control)this).get_Controls().Add((Control)(object)q9E());
		((Control)this).get_Controls().Add((Control)(object)t1L());
		((Control)this).get_Controls().Add((Control)(object)x2W());
		((Control)this).set_Name("Form1");
		((Form)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	internal virtual Button x2W()
	{
		return U;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Xf9(Button Mk8)
	{
		EventHandler eventHandler = Hr4;
		Button u = U;
		if (u != null)
		{
			((Control)u).remove_Click(eventHandler);
		}
		Button val = (U = Mk8);
		u = U;
		if (u != null)
		{
			((Control)u).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual TextBox t1L()
	{
		return _TextBox1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Mj4(TextBox p0M)
	{
		_TextBox1 = p0M;
	}

	[SpecialName]
	internal virtual TextBox q9E()
	{
		return _TextBox2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void w4C(TextBox k3G)
	{
		_TextBox2 = k3G;
	}

	[SpecialName]
	internal virtual Button a8E()
	{
		return _Reset;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void Cn2(Button Dy1)
	{
		EventHandler eventHandler = p6L;
		Button reset = _Reset;
		if (reset != null)
		{
			((Control)reset).remove_Click(eventHandler);
		}
		_Reset = Dy1;
		reset = _Reset;
		if (reset != null)
		{
			((Control)reset).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Label Fm5()
	{
		return r;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void c5X(Label Cc1)
	{
		Label val = (r = Cc1);
	}

	[SpecialName]
	internal virtual Label Ef2()
	{
		return _Password;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void d6G(Label Kj6)
	{
		_Password = Kj6;
	}

	[SpecialName]
	internal virtual Label q1M()
	{
		return _Label3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void x3F(Label s1Y)
	{
		_Label3 = s1Y;
	}

	[SpecialName]
	internal virtual Panel t4L()
	{
		return _Panel1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void j1C(Panel i5G)
	{
		_Panel1 = i5G;
	}

	[SpecialName]
	internal virtual Panel b8X()
	{
		return _Panel2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void g5Q(Panel Hr0)
	{
		_Panel2 = Hr0;
	}
}
