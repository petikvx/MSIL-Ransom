using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Br3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d9B;
using f2J;

namespace Tp1;

[DesignerGenerated]
public class w9S : Form
{
	private IContainer components;

	private OleDbConnection conn;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("ComboBox2")]
	internal virtual ComboBox ComboBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox1")]
	internal virtual ComboBox ComboBox1
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
			EventHandler eventHandler = y9K;
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

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public w9S()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)i2R);
		conn = new OleDbConnection();
		c6X();
	}

	[DebuggerNonUserCode]
	protected override void Kf6(bool c3J)
	{
		try
		{
			if (c3J && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c3J);
		}
	}

	[DebuggerStepThrough]
	private void c6X()
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
		//IL_02dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e6: Expected O, but got Unknown
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Expected O, but got Unknown
		GroupBox1 = new GroupBox();
		TextBox2 = new TextBox();
		Label2 = new Label();
		Button1 = new Button();
		ComboBox2 = new ComboBox();
		ComboBox1 = new ComboBox();
		TextBox1 = new TextBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label1 = new Label();
		Label6 = new Label();
		Label7 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)GroupBox1).set_Location(new Point(17, 49));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(492, 281));
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Emergency Situation");
		((TextBoxBase)TextBox2).set_BackColor(SystemColors.ControlLight);
		((Control)TextBox2).set_Location(new Point(204, 27));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(263, 22));
		((Control)TextBox2).set_TabIndex(8);
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Label2).set_Location(new Point(38, 27));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(160, 17));
		((Control)Label2).set_TabIndex(7);
		Label2.set_Text("Patient Name(Optional):");
		((ButtonBase)Button1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(SystemColors.Desktop);
		((Control)Button1).set_Location(new Point(141, 199));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(213, 43));
		((Control)Button1).set_TabIndex(6);
		((ButtonBase)Button1).set_Text("SUBMIT");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		ComboBox2.set_BackColor(Color.White);
		ComboBox2.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		ComboBox2.get_Items().AddRange(new object[8] { "Accident", "Heart Attack", "Choking", "Breating Problem", "Pregnancy", "Mental Illnes", "Criminal Cases (Murder,theft etc)", "Other" });
		((Control)ComboBox2).set_Location(new Point(204, 57));
		((Control)ComboBox2).set_Name("ComboBox2");
		((Control)ComboBox2).set_Size(new Size(263, 24));
		((Control)ComboBox2).set_TabIndex(5);
		ComboBox1.set_BackColor(Color.White);
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[6] { "0-10", "11-18", "19-30", "30-40", "40-55", "Above 55" });
		((Control)ComboBox1).set_Location(new Point(204, 87));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(263, 24));
		((Control)ComboBox1).set_TabIndex(4);
		((TextBoxBase)TextBox1).set_BackColor(SystemColors.ControlLight);
		((Control)TextBox1).set_Location(new Point(204, 130));
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(263, 61));
		((Control)TextBox1).set_TabIndex(3);
		Label5.set_AutoSize(true);
		((Control)Label5).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Label5).set_Location(new Point(106, 87));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(92, 17));
		((Control)Label5).set_TabIndex(2);
		Label5.set_Text("Patients Age:");
		((Control)Label4).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Label4).set_Location(new Point(46, 133));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(152, 37));
		((Control)Label4).set_TabIndex(1);
		Label4.set_Text("Description of patients Situation(optional)      :");
		Label3.set_AutoSize(true);
		((Control)Label3).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Label3).set_Location(new Point(46, 57));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(152, 17));
		((Control)Label3).set_TabIndex(0);
		Label3.set_Text("Reason of Emergency:");
		((Control)Label1).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_ForeColor(Color.Red);
		((Control)Label1).set_Location(new Point(18, 9));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(492, 37));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("For AMBULANCE, Contact :  8249563271\r\n");
		Label1.set_TextAlign((ContentAlignment)32);
		((Control)Label6).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)Label6).set_ForeColor(SystemColors.ActiveCaptionText);
		((Control)Label6).set_Location(new Point(195, 346));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(314, 41));
		((Control)Label6).set_TabIndex(2);
		Label6.set_Text("Chinaveri,IIT Guwahati, Guwahati District,Assam\r\n9856423479  ,  7569863218\r\n\r\n");
		((Control)Label7).set_ForeColor(Color.Red);
		((Control)Label7).set_Location(new Point(14, 346));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(181, 41));
		((Control)Label7).set_TabIndex(3);
		Label7.set_Text("HOSPITAL ADDRESS :\r\nHOSPITAL CONTACT :\r\n");
		((Form)this).set_AcceptButton((IButtonControl)(object)Button1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(522, 396));
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_ForeColor(SystemColors.ButtonHighlight);
		((Control)this).set_Name("Form10");
		((Form)this).set_Text("Emergency");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void y9K(object sender, EventArgs e)
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_0188: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Expected O, but got Unknown
		//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ab: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0261: Expected O, but got Unknown
		//IL_0277: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		conn.Open();
		try
		{
			string text = "";
			List<string> list = Mt9();
			Console.WriteLine(list[0]);
			foreach (string item in list)
			{
				Console.WriteLine(item);
				if (Conversions.ToBoolean(Nt5(item)))
				{
					text = item;
					break;
				}
			}
			if (Operators.CompareString(text, "", false) == 0)
			{
				MessageBox.Show("No Doctor available", "Sorry");
				conn.Close();
				return;
			}
			string text2 = ComboBox1.get_Text();
			string text3 = ComboBox2.get_Text();
			string text4 = Conversions.ToString(DateAndTime.get_Now().Date);
			string text5 = DateAndTime.get_Now().TimeOfDay.ToString();
			string text6 = "No";
			string text7 = "INSERT INTO Emergency_DataBase([Reason],[Age],[Accident_Date],[Accident_Time],[Appointed_Doctor],[Completed]) VALUES('" + text3 + "','" + text2 + "','" + text4 + "','" + text5 + "','" + text + "','" + text6 + "')";
			OleDbCommand val = new OleDbCommand(text7, conn);
			val.get_Parameters().Add(new OleDbParameter("Reason", (object)text3));
			val.get_Parameters().Add(new OleDbParameter("Age", (object)text2));
			val.get_Parameters().Add(new OleDbParameter("Accident_Date", (object)text4));
			val.get_Parameters().Add(new OleDbParameter("Accident_Time", (object)text5));
			val.get_Parameters().Add(new OleDbParameter("Appointed_Doctor", (object)text));
			val.get_Parameters().Add(new OleDbParameter("Completed", (object)text6));
			int num = default(int);
			try
			{
				val.ExecuteNonQuery();
				val.set_CommandText("SELECT @@IDENTITY");
				num = Conversions.ToInteger(val.ExecuteScalar());
				MessageBox.Show("Emergency ID:" + Conversions.ToString(num) + "\r\nDoctor_Appointed:" + text);
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
			DataTable dataTable = new DataTable();
			OleDbDataAdapter val2 = new OleDbDataAdapter();
			val2 = new OleDbDataAdapter("Select * from Doctor_Database where Doc_Name like '%" + text + "%' ", conn);
			((DbDataAdapter)(object)val2).Fill(dataTable);
			IEnumerator enumerator2 = default(IEnumerator);
			string addresses = default(string);
			try
			{
				enumerator2 = dataTable.Rows.GetEnumerator();
				IEnumerator enumerator3 = default(IEnumerator);
				while (enumerator2.MoveNext())
				{
					DataRow dataRow = (DataRow)enumerator2.Current;
					try
					{
						enumerator3 = dataTable.Columns.GetEnumerator();
						while (enumerator3.MoveNext())
						{
							DataColumn dataColumn = (DataColumn)enumerator3.Current;
							if (Operators.CompareString(dataColumn.ColumnName, "Email", false) == 0)
							{
								addresses = Conversions.ToString(dataRow[dataColumn]);
							}
						}
					}
					finally
					{
						if (enumerator3 is IDisposable)
						{
							(enumerator3 as IDisposable).Dispose();
						}
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
			try
			{
				SmtpClient smtpClient = new SmtpClient();
				MailMessage mailMessage = new MailMessage();
				smtpClient.UseDefaultCredentials = false;
				smtpClient.Credentials = new NetworkCredential("softwarelab20192@gmail.com", "software2019");
				smtpClient.Port = 587;
				smtpClient.EnableSsl = true;
				smtpClient.Host = "smtp.gmail.com";
				mailMessage = new MailMessage();
				mailMessage.From = new MailAddress("softwarelab20192@gmail.com");
				mailMessage.To.Add(addresses);
				mailMessage.Subject = "Emergency_Situation@IITG Hospital";
				mailMessage.IsBodyHtml = true;
				mailMessage.Body = "You are appointed with an Emergency case of ID:" + Conversions.ToString(num) + "We require your presence at utmost emergency";
				smtpClient.Send(mailMessage);
				MessageBox.Show("Message has been sent to the allocated doctor.We will be ready with the requiremnets");
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				MessageBox.Show(ex4.Message);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception ex5)
		{
			ProjectData.SetProjectError(ex5);
			Exception ex6 = ex5;
			MessageBox.Show(ex6.Message);
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
		conn.Close();
	}

	public List<string> Mt9()
	{
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		List<string> list = new List<string>();
		try
		{
			string text = "Select * From Doctor_DataBase where Department like 'Emergency'";
			OleDbCommand val = new OleDbCommand(text, conn);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				list.Add(val2.GetString(1));
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
		return list;
	}

	private string Nt5(object Fi4)
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		bool flag = true;
		try
		{
			string text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Select * From Emergency_DataBase where Appointed_Doctor like '", Fi4), (object)"' and Completed like 'No'"));
			OleDbCommand val = new OleDbCommand(text, conn);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				flag = false;
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
		if (flag)
		{
			return Conversions.ToString(true);
		}
		return Conversions.ToString(false);
	}

	[STAThread]
	public static void d6Q()
	{
		int try0001_dispatch = -1;
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				}
				while (!g8C.Lq6(2) || !t4C.z6L())
				{
				}
				y4Z.a1L(1);
				break;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				try0001_dispatch = 16;
			}
		}
	}

	private void i2R(object sender, EventArgs e)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		conn.set_ConnectionString(connectionString);
	}
}
