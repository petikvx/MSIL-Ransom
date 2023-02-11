using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Cd6;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace a1J7;

[DesignerGenerated]
public class q3Q7 : Form
{
	private IContainer components;

	private OleDbConnection con;

	private string Username;

	private string Password;

	[field: AccessedThroughProperty("Panel1")]
	internal virtual Panel Panel1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button2
	{
		[CompilerGenerated]
		get
		{
			return _Button2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Rr3z;
			Button button = _Button2;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button2 = value;
			button = _Button2;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = o3S6;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button Button3
	{
		[CompilerGenerated]
		get
		{
			return _Button3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = n4MG;
			Button button = _Button3;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button3 = value;
			button = _Button3;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	public q3Q7()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Pw1d);
		con = new OleDbConnection();
		Username = "pharmacist";
		Ka3d();
	}

	[DebuggerNonUserCode]
	protected override void Hw20(bool q8BD)
	{
		try
		{
			if (q8BD && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(q8BD);
		}
	}

	[DebuggerStepThrough]
	private void Ka3d()
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a6: Expected O, but got Unknown
		//IL_0390: Unknown result type (might be due to invalid IL or missing references)
		//IL_039a: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0417: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ce: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(q3Q7));
		Panel1 = new Panel();
		Button2 = new Button();
		Button1 = new Button();
		Button3 = new Button();
		Label5 = new Label();
		Label4 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		((Control)Panel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Panel1).set_Anchor((AnchorStyles)13);
		((Control)Panel1).set_BackColor(Color.Transparent);
		((Control)Panel1).get_Controls().Add((Control)(object)Button2);
		((Control)Panel1).get_Controls().Add((Control)(object)Button1);
		((Control)Panel1).get_Controls().Add((Control)(object)Button3);
		((Control)Panel1).get_Controls().Add((Control)(object)Label5);
		((Control)Panel1).get_Controls().Add((Control)(object)Label4);
		((Control)Panel1).get_Controls().Add((Control)(object)Label2);
		((Control)Panel1).get_Controls().Add((Control)(object)Label1);
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox1);
		((Control)Panel1).get_Controls().Add((Control)(object)TextBox2);
		((Control)Panel1).set_Location(new Point(206, 53));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(434, 303));
		((Control)Panel1).set_TabIndex(10);
		((Control)Button2).set_Location(new Point(180, 213));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(123, 37));
		((Control)Button2).set_TabIndex(16);
		((ButtonBase)Button2).set_Text("Close");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button1).set_Location(new Point(30, 213));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(123, 37));
		((Control)Button1).set_TabIndex(15);
		((ButtonBase)Button1).set_Text("Login");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button3).set_Image((Image)componentResourceManager.GetObject("Button3.Image"));
		((Control)Button3).set_Location(new Point(374, 169));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(23, 23));
		((Control)Button3).set_TabIndex(10);
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(Color.Transparent);
		((Control)Label5).set_Location(new Point(27, 278));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(370, 17));
		((Control)Label5).set_TabIndex(9);
		Label5.set_Text("If you forgot your password , Please contact administrator");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 7.8f));
		((Control)Label4).set_Location(new Point(27, 55));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(143, 17));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("PHARMACIST LOGIN");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 7.8f));
		((Control)Label2).set_Location(new Point(27, 174));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(77, 17));
		((Control)Label2).set_TabIndex(1);
		Label2.set_Text("Password :");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 7.8f));
		((Control)Label1).set_Location(new Point(27, 101));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(83, 17));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("UserName :");
		((TextBoxBase)TextBox1).set_BackColor(Color.Azure);
		((Control)TextBox1).set_Location(new Point(113, 96));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(255, 22));
		((Control)TextBox1).set_TabIndex(2);
		((Control)TextBox2).set_Location(new Point(113, 169));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(255, 22));
		((Control)TextBox2).set_TabIndex(3);
		((Control)TextBox2).set_Tag((object)"");
		TextBox2.set_UseSystemPasswordChar(true);
		((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(667, 390));
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Name("Form9");
		((Form)this).set_Text("PHARMACIST LOGIN");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private string i6J1(ref string Xd03)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(Xd03);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = null;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	private string j9LX()
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		string result = "";
		try
		{
			con.Open();
			string text = "Select * From Password_DataBase where UserName like 'pharmacist'";
			OleDbCommand val = new OleDbCommand(text, con);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				Console.WriteLine(val2.GetString(1));
				result = val2.GetString(1);
			}
			val2.Close();
			((Component)(object)val).Dispose();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		finally
		{
			con.Close();
		}
		return result;
	}

	private void o3S6(object sender, EventArgs e)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		Password = j9LX();
		try
		{
			if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox2.get_Text(), "", false) == 0))
			{
				Interaction.MsgBox((object)"You Have Not Entered Username And Password , please Fill The Details", (MsgBoxStyle)0, (object)null);
				return;
			}
			bool num = Operators.CompareString(Username, TextBox1.get_Text(), false) == 0;
			string password = Password;
			TextBox textBox;
			string Xd = (textBox = TextBox2).get_Text();
			string text = i6J1(ref Xd);
			textBox.set_Text(Xd);
			if (num & (Operators.CompareString(password, text, false) == 0))
			{
				((Control)Rg8.Forms.Form31).Show();
				((Form)this).Close();
			}
			else
			{
				Interaction.MsgBox((object)"Invalid Username / Password Of Admin", (MsgBoxStyle)16, (object)"Error");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)64, (object)"Error");
			ProjectData.ClearProjectError();
		}
	}

	private void Rr3z(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Rg8.Forms.Form1).Show();
	}

	private void n4MG(object sender, EventArgs e)
	{
		if (TextBox2.get_UseSystemPasswordChar())
		{
			TextBox2.set_UseSystemPasswordChar(false);
		}
		else
		{
			TextBox2.set_UseSystemPasswordChar(true);
		}
	}

	private void Pw1d(object sender, EventArgs e)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
	}
}
