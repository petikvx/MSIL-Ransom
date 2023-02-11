using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Cd6;
using Microsoft.VisualBasic.CompilerServices;

namespace Yy36;

[DesignerGenerated]
public class Bt20 : Form
{
	private IContainer components;

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
			EventHandler eventHandler = Mr08;
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
			EventHandler eventHandler = Kn3m;
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
			EventHandler eventHandler = Ze9a;
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

	public Bt20()
	{
		((Form)this).add_Load((EventHandler)e0R3);
		n6HF();
	}

	[DebuggerNonUserCode]
	protected override void Hb2o(bool Jp69)
	{
		try
		{
			if (Jp69 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Jp69);
		}
	}

	[DebuggerStepThrough]
	private void n6HF()
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
		//IL_040a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Expected O, but got Unknown
		//IL_0487: Unknown result type (might be due to invalid IL or missing references)
		//IL_0491: Expected O, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Bt20));
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
		((Control)Panel1).set_Location(new Point(195, 42));
		((Control)Panel1).set_Name("Panel1");
		((Control)Panel1).set_Size(new Size(440, 303));
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
		((Control)Label4).set_Size(new Size(115, 17));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("DOCTOR LOGIN");
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
		((Control)TextBox2).set_Location(new Point(113, 171));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(255, 22));
		((Control)TextBox2).set_TabIndex(3);
		((Control)TextBox2).set_Tag((object)"");
		TextBox2.set_UseSystemPasswordChar(true);
		((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(678, 388));
		((Control)this).get_Controls().Add((Control)(object)Panel1);
		((Control)this).set_Name("Form7");
		((Form)this).set_Text("DOCTOR LOGIN");
		((Control)Panel1).ResumeLayout(false);
		((Control)Panel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private string d6B2(ref string j6JG)
	{
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(j6JG);
		bytes = mD5CryptoServiceProvider.ComputeHash(bytes);
		string text = null;
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	private void Kn3m(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			OleDbConnection val = new OleDbConnection();
			string currentDirectory = Directory.GetCurrentDirectory();
			currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
			currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
			string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
			val.set_ConnectionString(connectionString);
			DataTable dataTable = new DataTable();
			OleDbDataAdapter val2 = new OleDbDataAdapter();
			string text = TextBox1.get_Text();
			TextBox textBox;
			string j6JG = (textBox = TextBox2).get_Text();
			string text2 = d6B2(ref j6JG);
			textBox.set_Text(j6JG);
			string text3 = text2;
			string text4 = "";
			text4 = "Select * From Doctor_DataBase Where Username = '" + text + "' And Password_Doc = '" + text3 + "'; ";
			val.Open();
			OleDbCommand val3 = new OleDbCommand(text4, val);
			val2 = new OleDbDataAdapter(text4, val);
			((DbDataAdapter)(object)val2).Fill(dataTable);
			IEnumerator enumerator = default(IEnumerator);
			short num = default(short);
			try
			{
				enumerator = dataTable.Rows.GetEnumerator();
				IEnumerator enumerator2 = default(IEnumerator);
				while (enumerator.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator.Current;
					try
					{
						enumerator2 = dataTable.Columns.GetEnumerator();
						while (enumerator2.MoveNext())
						{
							DataColumn dataColumn = (DataColumn)enumerator2.Current;
							if (Operators.CompareString(dataColumn.ColumnName, "ID", false) == 0)
							{
								num = Conversions.ToShort(dataRow[dataColumn]);
							}
						}
					}
					finally
					{
						if (enumerator2 is IDisposable)
						{
							(enumerator2 as IDisposable).Dispose();
						}
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			OleDbDataReader val4 = val3.ExecuteReader();
			int num2 = 0;
			while (val4.Read())
			{
				num2 = checked(num2 + 1);
			}
			val.Close();
			if (num2 != 1)
			{
				MessageBox.Show("Username or Password is incorrect!");
				return;
			}
			Rg8.Forms.Form17.user.set_Text(Conversions.ToString((int)num));
			((Control)Rg8.Forms.Form17).Show();
			((Form)this).Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Mr08(object sender, EventArgs e)
	{
		((Form)this).Close();
		((Control)Rg8.Forms.Form1).Show();
	}

	private void Ze9a(object sender, EventArgs e)
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

	private void e0R3(object sender, EventArgs e)
	{
	}
}
