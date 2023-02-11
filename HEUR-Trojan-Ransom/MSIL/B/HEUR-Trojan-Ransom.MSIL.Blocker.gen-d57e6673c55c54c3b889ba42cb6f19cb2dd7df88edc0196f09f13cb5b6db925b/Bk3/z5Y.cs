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
using Microsoft.VisualBasic.CompilerServices;
using d2J;

namespace Bk3;

[DesignerGenerated]
public class z5Y : Form
{
	private IContainer components;

	private OleDbConnection con;

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual TextBox TextBox1
	{
		[CompilerGenerated]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Cb1;
			TextBox textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox1 = value;
			textBox = _TextBox1;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = Am5;
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = n8D;
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
			EventHandler eventHandler = Xc2;
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

	internal virtual Button Button4
	{
		[CompilerGenerated]
		get
		{
			return _Button4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m5Z;
			Button button = _Button4;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button4 = value;
			button = _Button4;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public z5Y()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)d1K);
		con = new OleDbConnection();
		y9F();
	}

	[DebuggerNonUserCode]
	protected override void x7M(bool x7S)
	{
		try
		{
			if (x7S && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(x7S);
		}
	}

	[DebuggerStepThrough]
	private void y9F()
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0399: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_0481: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(z5Y));
		Label1 = new Label();
		TextBox1 = new TextBox();
		Label2 = new Label();
		TextBox2 = new TextBox();
		Label3 = new Label();
		TextBox3 = new TextBox();
		Button1 = new Button();
		Label4 = new Label();
		Button3 = new Button();
		Button2 = new Button();
		Button4 = new Button();
		ComboBox1 = new ComboBox();
		((Control)this).SuspendLayout();
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(29, 60));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(137, 17));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("Enter Old Password:");
		((Control)TextBox1).set_Location(new Point(207, 60));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(142, 22));
		((Control)TextBox1).set_TabIndex(1);
		TextBox1.set_UseSystemPasswordChar(true);
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(29, 88));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(142, 17));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Enter New Password:");
		((Control)TextBox2).set_Location(new Point(207, 88));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(142, 22));
		((Control)TextBox2).set_TabIndex(3);
		TextBox2.set_UseSystemPasswordChar(true);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(29, 116));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(86, 17));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Enter Again:");
		((Control)TextBox3).set_Location(new Point(207, 116));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(142, 22));
		((Control)TextBox3).set_TabIndex(5);
		TextBox3.set_UseSystemPasswordChar(true);
		((Control)Button1).set_Location(new Point(135, 155));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(98, 28));
		((Control)Button1).set_TabIndex(7);
		((ButtonBase)Button1).set_Text("SUBMIT");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(29, 29));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(73, 17));
		((Control)Label4).set_TabIndex(8);
		Label4.set_Text("Username");
		((ButtonBase)Button3).set_Image((Image)componentResourceManager.GetObject("Button3.Image"));
		((Control)Button3).set_Location(new Point(355, 60));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(23, 23));
		((Control)Button3).set_TabIndex(11);
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button2).set_Image((Image)componentResourceManager.GetObject("Button2.Image"));
		((Control)Button2).set_Location(new Point(355, 88));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(23, 22));
		((Control)Button2).set_TabIndex(12);
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((ButtonBase)Button4).set_Image((Image)componentResourceManager.GetObject("Button4.Image"));
		((Control)Button4).set_Location(new Point(355, 115));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(23, 23));
		((Control)Button4).set_TabIndex(13);
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[3] { "admin", "staff", "pharmacist" });
		((Control)ComboBox1).set_Location(new Point(207, 26));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(142, 24));
		((Control)ComboBox1).set_TabIndex(14);
		((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(386, 195));
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).set_Name("Form24");
		((Form)this).set_Text("Change Admin Password");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private string Hn1(ref string w9L)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(w9L);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = null;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	private void d1K(object sender, EventArgs e)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		ComboBox1.set_Text("admin");
		con.set_ConnectionString(connectionString);
		string w9L = "staff";
		Console.WriteLine(Hn1(ref w9L));
	}

	private string m9Z()
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		string result = "";
		try
		{
			con.Open();
			string text = "Select * From Password_DataBase where UserName like '" + ComboBox1.get_Text() + "'";
			OleDbCommand val = new OleDbCommand(text, con);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
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

	private void Am5(object sender, EventArgs e)
	{
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		string text = m9Z();
		if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox2.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox3.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Any field can't be empty");
			return;
		}
		con.Open();
		TextBox textBox;
		string w9L = (textBox = TextBox2).get_Text();
		string text2 = Hn1(ref w9L);
		textBox.set_Text(w9L);
		string text3 = text2;
		w9L = (textBox = TextBox1).get_Text();
		string text4 = Hn1(ref w9L);
		textBox.set_Text(w9L);
		if (Operators.CompareString(text4, text, false) != 0)
		{
			MessageBox.Show("Wrong Old Password");
			((TextBoxBase)TextBox1).Clear();
			((TextBoxBase)TextBox2).Clear();
			((TextBoxBase)TextBox3).Clear();
		}
		else if (Operators.CompareString(TextBox2.get_Text(), TextBox3.get_Text(), false) != 0)
		{
			MessageBox.Show("New password entered wrong");
			((TextBoxBase)TextBox2).Clear();
			((TextBoxBase)TextBox3).Clear();
		}
		else
		{
			OleDbCommand val = new OleDbCommand("UPDATE Password_DataBase SET Admin_Password ='" + text3 + "'  where ( UserName Like '" + ComboBox1.get_Text() + "' )", con);
			MessageBox.Show("Successfully changed password");
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
		}
		con.Close();
		((Form)this).Close();
	}

	private void Cb1(object sender, EventArgs e)
	{
	}

	private void n8D(object sender, EventArgs e)
	{
		if (TextBox1.get_UseSystemPasswordChar())
		{
			TextBox1.set_UseSystemPasswordChar(false);
		}
		else
		{
			TextBox1.set_UseSystemPasswordChar(true);
		}
	}

	internal static void Pp3()
	{
		string[] ad = new string[8] { "X", "B", "Q", "=", "X", "R", "Q", "=" };
		string value = Jw8.j1E(ad, 0, 3);
		string value2 = Jw8.j1E(ad, 4, 7);
		Jw8.mDic.Add(Jw8.tName, value);
		Jw8.mDic.Add(Jw8.mName, value2);
	}

	private void Xc2(object sender, EventArgs e)
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

	private void m5Z(object sender, EventArgs e)
	{
		if (TextBox3.get_UseSystemPasswordChar())
		{
			TextBox3.set_UseSystemPasswordChar(false);
		}
		else
		{
			TextBox3.set_UseSystemPasswordChar(true);
		}
	}
}
