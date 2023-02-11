using System;
using System.Collections;
using System.Collections.Generic;
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
using Bk3;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using d2J;
using q5G;

namespace Lf3;

[DesignerGenerated]
public class z7R : Form
{
	private IContainer components;

	private OleDbConnection conn;

	[field: AccessedThroughProperty("Patient_Name")]
	internal virtual Label Patient_Name
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Department")]
	internal virtual Label Department
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Label Date_of_appointment
	{
		[CompilerGenerated]
		get
		{
			return _Date_of_appointment;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Kr8;
			Label date_of_appointment = _Date_of_appointment;
			if (date_of_appointment != null)
			{
				((Control)date_of_appointment).remove_Click(eventHandler);
			}
			_Date_of_appointment = value;
			date_of_appointment = _Date_of_appointment;
			if (date_of_appointment != null)
			{
				((Control)date_of_appointment).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Submit
	{
		[CompilerGenerated]
		get
		{
			return _Submit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = s1D;
			Button submit = _Submit;
			if (submit != null)
			{
				((Control)submit).remove_Click(eventHandler);
			}
			_Submit = value;
			submit = _Submit;
			if (submit != null)
			{
				((Control)submit).add_Click(eventHandler);
			}
		}
	}

	internal virtual ComboBox ComboBox1
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = q0G;
			ComboBox comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox1 = value;
			comboBox = _ComboBox1;
			if (comboBox != null)
			{
				comboBox.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label1
	{
		[CompilerGenerated]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = x6X;
			Label label = _Label1;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label1 = value;
			label = _Label1;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual ComboBox ComboBox2
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = r5J;
			ComboBox comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox2 = value;
			comboBox = _ComboBox2;
			if (comboBox != null)
			{
				comboBox.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual DateTimePicker DateTimePicker1
	{
		[CompilerGenerated]
		get
		{
			return _DateTimePicker1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = o7X;
			DateTimePicker dateTimePicker = _DateTimePicker1;
			if (dateTimePicker != null)
			{
				dateTimePicker.remove_ValueChanged(eventHandler);
			}
			_DateTimePicker1 = value;
			dateTimePicker = _DateTimePicker1;
			if (dateTimePicker != null)
			{
				dateTimePicker.add_ValueChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboBox3
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = m8C;
			ComboBox comboBox = _ComboBox3;
			if (comboBox != null)
			{
				comboBox.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox3 = value;
			comboBox = _ComboBox3;
			if (comboBox != null)
			{
				comboBox.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	internal virtual Label Label3
	{
		[CompilerGenerated]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = e9N;
			Label label = _Label3;
			if (label != null)
			{
				((Control)label).remove_Click(eventHandler);
			}
			_Label3 = value;
			label = _Label3;
			if (label != null)
			{
				((Control)label).add_Click(eventHandler);
			}
		}
	}

	internal virtual TextBox TextBox2
	{
		[CompilerGenerated]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Yq7;
			TextBox textBox = _TextBox2;
			if (textBox != null)
			{
				((Control)textBox).remove_TextChanged(eventHandler);
			}
			_TextBox2 = value;
			textBox = _TextBox2;
			if (textBox != null)
			{
				((Control)textBox).add_TextChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual ComboBox ComboBox4
	{
		[CompilerGenerated]
		get
		{
			return _ComboBox4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wx4;
			ComboBox comboBox = _ComboBox4;
			if (comboBox != null)
			{
				comboBox.remove_SelectedIndexChanged(eventHandler);
			}
			_ComboBox4 = value;
			comboBox = _ComboBox4;
			if (comboBox != null)
			{
				comboBox.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label6")]
	internal virtual Label Label6
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ComboBox5")]
	internal virtual ComboBox ComboBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual DateTimePicker DateTimePicker2
	{
		[CompilerGenerated]
		get
		{
			return _DateTimePicker2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wd6;
			DateTimePicker dateTimePicker = _DateTimePicker2;
			if (dateTimePicker != null)
			{
				dateTimePicker.remove_ValueChanged(eventHandler);
			}
			_DateTimePicker2 = value;
			dateTimePicker = _DateTimePicker2;
			if (dateTimePicker != null)
			{
				dateTimePicker.add_ValueChanged(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label7")]
	internal virtual Label Label7
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
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

	public z7R()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Cw6);
		((Form)this).add_Load((EventHandler)q4T);
		conn = new OleDbConnection();
		Cr2();
	}

	[DebuggerNonUserCode]
	protected override void c6Z(bool Es5)
	{
		try
		{
			if (Es5 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Es5);
		}
	}

	[DebuggerStepThrough]
	private void Cr2()
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
		//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_00e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		Patient_Name = new Label();
		Department = new Label();
		Date_of_appointment = new Label();
		TextBox1 = new TextBox();
		Submit = new Button();
		ComboBox1 = new ComboBox();
		Label1 = new Label();
		ComboBox2 = new ComboBox();
		DateTimePicker1 = new DateTimePicker();
		Label2 = new Label();
		ComboBox3 = new ComboBox();
		Label3 = new Label();
		TextBox2 = new TextBox();
		Label4 = new Label();
		ComboBox4 = new ComboBox();
		Label5 = new Label();
		Label6 = new Label();
		ComboBox5 = new ComboBox();
		DateTimePicker2 = new DateTimePicker();
		Label7 = new Label();
		Label8 = new Label();
		TextBox3 = new TextBox();
		((Control)this).SuspendLayout();
		Patient_Name.set_AutoSize(true);
		((Control)Patient_Name).set_Location(new Point(12, 43));
		((Control)Patient_Name).set_Name("Patient_Name");
		((Control)Patient_Name).set_Size(new Size(182, 34));
		((Control)Patient_Name).set_TabIndex(2);
		Patient_Name.set_Text("Patient Name*\r\n(Without Mr., Mrs., Ms. etc.)\r\n");
		Department.set_AutoSize(true);
		((Control)Department).set_Location(new Point(14, 203));
		((Control)Department).set_Name("Department");
		((Control)Department).set_Size(new Size(87, 17));
		((Control)Department).set_TabIndex(3);
		Department.set_Text("Department*");
		Date_of_appointment.set_AutoSize(true);
		((Control)Date_of_appointment).set_Location(new Point(14, 142));
		((Control)Date_of_appointment).set_Name("Date_of_appointment");
		((Control)Date_of_appointment).set_Size(new Size(107, 17));
		((Control)Date_of_appointment).set_TabIndex(4);
		Date_of_appointment.set_Text("Preferred Date*");
		((Control)TextBox1).set_Location(new Point(235, 43));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(175, 22));
		((Control)TextBox1).set_TabIndex(13);
		((Control)Submit).set_Location(new Point(112, 353));
		((Control)Submit).set_Name("Submit");
		((Control)Submit).set_Size(new Size(156, 41));
		((Control)Submit).set_TabIndex(14);
		((ButtonBase)Submit).set_Text("Submit");
		((ButtonBase)Submit).set_UseVisualStyleBackColor(true);
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((Control)ComboBox1).set_Enabled(false);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[13]
		{
			"Cardiology", "Ear nose and throat (ENT)", "Gastroenterology", "General surgery", "Gynaecology", "Haematology", "Maternity departments", "Neurology", "Oncology", "Ophthalmology",
			"Orthopaedics", "Physiotherapy", "Urology"
		});
		((Control)ComboBox1).set_Location(new Point(234, 200));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(176, 24));
		((Control)ComboBox1).set_TabIndex(16);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(11, 230));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(188, 17));
		((Control)Label1).set_TabIndex(17);
		Label1.set_Text("Check availability by doctor* ");
		ComboBox2.set_DropDownStyle((ComboBoxStyle)2);
		((Control)ComboBox2).set_Enabled(false);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		ComboBox2.get_Items().AddRange(new object[3] { "gdsfgx", "cgfcgh", "gcfvc" });
		((Control)ComboBox2).set_Location(new Point(234, 230));
		((Control)ComboBox2).set_Name("ComboBox2");
		((Control)ComboBox2).set_Size(new Size(176, 24));
		((Control)ComboBox2).set_TabIndex(18);
		((Control)DateTimePicker1).set_Location(new Point(236, 142));
		DateTimePicker1.set_MinDate(new DateTime(2019, 2, 6, 0, 0, 0, 0));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(175, 22));
		((Control)DateTimePicker1).set_TabIndex(19);
		DateTimePicker1.set_Value(new DateTime(2019, 2, 9, 0, 0, 0, 0));
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(14, 173));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(108, 17));
		((Control)Label2).set_TabIndex(20);
		Label2.set_Text("Preferred Time*");
		ComboBox3.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox3).set_FormattingEnabled(true);
		ComboBox3.get_Items().AddRange(new object[3] { "Anytime", "Morning(9am-1pm)", "Afternoon(2pm-5pm)" });
		((Control)ComboBox3).set_Location(new Point(234, 170));
		((Control)ComboBox3).set_Name("ComboBox3");
		((Control)ComboBox3).set_Size(new Size(176, 24));
		((Control)ComboBox3).set_TabIndex(21);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(13, 296));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(108, 17));
		((Control)Label3).set_TabIndex(22);
		Label3.set_Text("Mobile Number*");
		((Control)TextBox2).set_Location(new Point(234, 296));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(177, 22));
		((Control)TextBox2).set_TabIndex(23);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(12, 265));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(198, 17));
		((Control)Label4).set_TabIndex(24);
		Label4.set_Text("Check availability by Time Slot");
		ComboBox4.set_DropDownStyle((ComboBoxStyle)2);
		((Control)ComboBox4).set_Enabled(false);
		((ListControl)ComboBox4).set_FormattingEnabled(true);
		((Control)ComboBox4).set_Location(new Point(234, 262));
		((Control)ComboBox4).set_Name("ComboBox4");
		((Control)ComboBox4).set_Size(new Size(176, 24));
		((Control)ComboBox4).set_TabIndex(25);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Location(new Point(12, 83));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(95, 17));
		((Control)Label5).set_TabIndex(26);
		Label5.set_Text("Date Of Birth*");
		Label6.set_AutoSize(true);
		((Control)Label6).set_Location(new Point(12, 113));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(61, 17));
		((Control)Label6).set_TabIndex(27);
		Label6.set_Text("Gender*");
		ComboBox5.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox5).set_FormattingEnabled(true);
		ComboBox5.get_Items().AddRange(new object[3] { "Male", "Female", "Other" });
		((Control)ComboBox5).set_Location(new Point(235, 111));
		((Control)ComboBox5).set_Name("ComboBox5");
		((Control)ComboBox5).set_Size(new Size(175, 24));
		((Control)ComboBox5).set_TabIndex(29);
		((Control)DateTimePicker2).set_Location(new Point(236, 83));
		DateTimePicker2.set_MinDate(new DateTime(1900, 1, 1, 0, 0, 0, 0));
		((Control)DateTimePicker2).set_Name("DateTimePicker2");
		((Control)DateTimePicker2).set_Size(new Size(175, 22));
		((Control)DateTimePicker2).set_TabIndex(30);
		DateTimePicker2.set_Value(new DateTime(2019, 2, 9, 0, 0, 0, 0));
		Label7.set_AutoSize(true);
		((Control)Label7).set_Location(new Point(109, 444));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(175, 17));
		((Control)Label7).set_TabIndex(31);
		Label7.set_Text("* marked fiels are required");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Location(new Point(14, 12));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(78, 17));
		((Control)Label8).set_TabIndex(32);
		Label8.set_Text("Patient_ID*");
		((Control)TextBox3).set_Location(new Point(235, 9));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(175, 22));
		((Control)TextBox3).set_TabIndex(33);
		((Form)this).set_AcceptButton((IButtonControl)(object)Submit);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.AliceBlue);
		((Form)this).set_ClientSize(new Size(429, 510));
		((Control)this).get_Controls().Add((Control)(object)TextBox3);
		((Control)this).get_Controls().Add((Control)(object)Label8);
		((Control)this).get_Controls().Add((Control)(object)Label7);
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker2);
		((Control)this).get_Controls().Add((Control)(object)ComboBox5);
		((Control)this).get_Controls().Add((Control)(object)Label6);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)ComboBox4);
		((Control)this).get_Controls().Add((Control)(object)Label4);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label3);
		((Control)this).get_Controls().Add((Control)(object)ComboBox3);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox2);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)Submit);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Date_of_appointment);
		((Control)this).get_Controls().Add((Control)(object)Department);
		((Control)this).get_Controls().Add((Control)(object)Patient_Name);
		((Control)this).set_Name("Form23");
		((Form)this).set_Text("Add Appointment");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Cw6(object sender, EventArgs e)
	{
		((Form)this).set_BackColor(Color.AliceBlue);
		DateTimePicker1.set_Value(DateAndTime.get_Now().Date);
		DateTimePicker2.set_Value(DateAndTime.get_Now().Date);
		DateTimePicker1.set_MinDate(DateAndTime.get_Now().Date.AddDays(1.0));
		DateTimePicker1.set_MaxDate(DateAndTime.get_Now().Date.AddDays(7.0));
		DateTimePicker2.set_MinDate(DateAndTime.get_Now().Date.AddYears(-130));
		DateTimePicker2.set_MaxDate(DateAndTime.get_Now().Date);
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		conn.set_ConnectionString(connectionString);
	}

	private void Kr8(object sender, EventArgs e)
	{
	}

	private void To8(object sender, EventArgs e)
	{
	}

	private void q4T(object sender, EventArgs e)
	{
	}

	private void z2J(object sender, EventArgs e)
	{
	}

	public bool g1T(string w7D, string He1)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		try
		{
			conn.Open();
			string text = "Select * From Appointment_DataBase where " + w7D + " like '" + He1 + "'";
			OleDbCommand val = new OleDbCommand(text, conn);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				flag = true;
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
			conn.Close();
		}
		if (flag)
		{
			return true;
		}
		return false;
	}

	public bool Aq1(int Yx7, string x5J, DateTime n1K)
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		try
		{
			conn.Open();
			string text = "Select * From Patient_DataBase where ID like '" + Conversions.ToString(Yx7) + "' and Name like '" + x5J + "' and DOB like '" + Conversions.ToString(n1K) + "'";
			OleDbCommand val = new OleDbCommand(text, conn);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				flag = true;
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
			conn.Close();
		}
		if (flag)
		{
			return true;
		}
		return false;
	}

	public bool d7Z(DateTime j8A, string e0Y, string f4J)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		try
		{
			conn.Open();
			string text = "Select * From Appointment_DataBase where Date_of_Appointment like '" + Conversions.ToString(j8A) + "' and Time_Slot like '" + e0Y + "' and Doctor_Name like '" + f4J + "'";
			OleDbCommand val = new OleDbCommand(text, conn);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				flag = true;
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
			conn.Close();
		}
		if (flag)
		{
			return true;
		}
		return false;
	}

	public string j7K(DateTime Li8, string b9M)
	{
		if (Operators.CompareString(g8A(Li8, b9M), "", false) != 0)
		{
			return g8A(Li8, b9M);
		}
		if (Operators.CompareString(Hr5(Li8, b9M), "", false) != 0)
		{
			return Hr5(Li8, b9M);
		}
		string result = default(string);
		return result;
	}

	public string g8A(DateTime Sg4, string x8M)
	{
		if (!Qa4(x8M, Sg4))
		{
			return "";
		}
		if ((Operators.CompareString(ComboBox2.get_Text(), "", false) == 0) | (Operators.CompareString(ComboBox2.get_Text(), "Any Doctor", false) == 0))
		{
			ComboBox4.get_Items().Clear();
			ComboBox4.get_Items().Add((object)"9:00-9:10");
			ComboBox4.get_Items().Add((object)"9:10-9:20");
			ComboBox4.get_Items().Add((object)"9:20-9:30");
			ComboBox4.get_Items().Add((object)"9:30-9:40");
			ComboBox4.get_Items().Add((object)"9:40-9:50");
			ComboBox4.get_Items().Add((object)"9:50-10:00");
			ComboBox4.get_Items().Add((object)"10:00-10:10");
			ComboBox4.get_Items().Add((object)"10:10-10:20");
			ComboBox4.get_Items().Add((object)"10:20-10:30");
			ComboBox4.get_Items().Add((object)"10:30-10:40");
			ComboBox4.get_Items().Add((object)"10:40-10:50");
			ComboBox4.get_Items().Add((object)"10:50-11:00");
			ComboBox4.get_Items().Add((object)"11:00-11:10");
			ComboBox4.get_Items().Add((object)"11:10-11:20");
			ComboBox4.get_Items().Add((object)"11:20-11:30");
			ComboBox4.get_Items().Add((object)"11:30-11:40");
			ComboBox4.get_Items().Add((object)"11:40-11:50");
			ComboBox4.get_Items().Add((object)"11:50-12:00");
			ComboBox4.get_Items().Add((object)"12:00-12:10");
			ComboBox4.get_Items().Add((object)"12:10-12:20");
			ComboBox4.get_Items().Add((object)"12:20-12:30");
			ComboBox4.get_Items().Add((object)"12:30-12:40");
			ComboBox4.get_Items().Add((object)"12:40-12:50");
			ComboBox4.get_Items().Add((object)"12:50-13:00");
		}
		int num = 9;
		checked
		{
			do
			{
				string e0Y = Conversions.ToString(num) + ":00-" + Conversions.ToString(num) + ":10";
				if (d7Z(Sg4, e0Y, x8M))
				{
					int num2 = 10;
					do
					{
						e0Y = Conversions.ToString(num) + ":" + Conversions.ToString(num2) + "-" + Conversions.ToString(num) + ":" + Conversions.ToString(num2 + 10);
						if (d7Z(Sg4, e0Y, x8M))
						{
							num2 += 10;
							continue;
						}
						ComboBox4.set_SelectedItem((object)(Conversions.ToString(num) + ":" + Conversions.ToString(num2) + "-" + Conversions.ToString(num) + ":" + Conversions.ToString(num2 + 10)));
						ComboBox2.set_SelectedItem((object)x8M);
						return Conversions.ToString(ComboBox4.get_SelectedItem());
					}
					while (num2 <= 40);
					e0Y = Conversions.ToString(num) + ":50-" + Conversions.ToString(num + 1) + ":00";
					if (d7Z(Sg4, e0Y, x8M))
					{
						num++;
						continue;
					}
					ComboBox4.set_SelectedItem((object)(Conversions.ToString(num) + ":50-" + Conversions.ToString(num + 1) + ":00"));
					ComboBox2.set_SelectedItem((object)x8M);
					return Conversions.ToString(ComboBox4.get_SelectedItem());
				}
				ComboBox4.set_SelectedItem((object)(Conversions.ToString(num) + ":00-" + Conversions.ToString(num) + ":10"));
				ComboBox2.set_SelectedItem((object)x8M);
				return Conversions.ToString(ComboBox4.get_SelectedItem());
			}
			while (num <= 12);
			return "";
		}
	}

	public string Hr5(DateTime b4Y, string Dp3)
	{
		if (!Qa4(Dp3, b4Y))
		{
			return "";
		}
		ComboBox4.get_Items().Clear();
		ComboBox4.get_Items().Add((object)"14:00-14:10");
		ComboBox4.get_Items().Add((object)"14:10-14:20");
		ComboBox4.get_Items().Add((object)"14:20-14:30");
		ComboBox4.get_Items().Add((object)"14:30-14:40");
		ComboBox4.get_Items().Add((object)"14:40-14:50");
		ComboBox4.get_Items().Add((object)"14:50-15:00");
		ComboBox4.get_Items().Add((object)"15:00-15:10");
		ComboBox4.get_Items().Add((object)"15:10-15:20");
		ComboBox4.get_Items().Add((object)"15:20-15:30");
		ComboBox4.get_Items().Add((object)"15:30-15:40");
		ComboBox4.get_Items().Add((object)"15:40-15:50");
		ComboBox4.get_Items().Add((object)"15:50-16:00");
		ComboBox4.get_Items().Add((object)"16:00-16:10");
		ComboBox4.get_Items().Add((object)"16:10-16:20");
		ComboBox4.get_Items().Add((object)"16:20-16:30");
		ComboBox4.get_Items().Add((object)"16:30-16:40");
		ComboBox4.get_Items().Add((object)"16:40-16:50");
		ComboBox4.get_Items().Add((object)"16:50-17:00");
		int num = 14;
		checked
		{
			do
			{
				string e0Y = Conversions.ToString(num) + ":00-" + Conversions.ToString(num) + ":10";
				if (d7Z(b4Y, e0Y, Dp3))
				{
					int num2 = 10;
					do
					{
						e0Y = Conversions.ToString(num) + ":" + Conversions.ToString(num2) + "-" + Conversions.ToString(num) + ":" + Conversions.ToString(num2 + 10);
						if (d7Z(b4Y, e0Y, Dp3))
						{
							num2 += 10;
							continue;
						}
						ComboBox4.set_SelectedItem((object)(Conversions.ToString(num) + ":" + Conversions.ToString(num2) + "-" + Conversions.ToString(num) + ":" + Conversions.ToString(num2 + 10)));
						ComboBox2.set_SelectedItem((object)Dp3);
						return Conversions.ToString(ComboBox4.get_SelectedItem());
					}
					while (num2 <= 40);
					e0Y = Conversions.ToString(num) + ":50-" + Conversions.ToString(num + 1) + ":00";
					if (d7Z(b4Y, e0Y, Dp3))
					{
						num++;
						continue;
					}
					ComboBox4.set_SelectedItem((object)(Conversions.ToString(num) + ":50-" + Conversions.ToString(num + 1) + ":00"));
					ComboBox2.set_SelectedItem((object)Dp3);
					return Conversions.ToString(ComboBox4.get_SelectedItem());
				}
				ComboBox4.set_SelectedItem((object)(Conversions.ToString(num) + ":00-" + Conversions.ToString(num) + ":10"));
				ComboBox2.set_SelectedItem((object)Dp3);
				return Conversions.ToString(ComboBox4.get_SelectedItem());
			}
			while (num <= 16);
			return "";
		}
	}

	public bool Qa4(string Sf1, DateTime p7X)
	{
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		bool result = false;
		try
		{
			conn.Open();
			string text = "Select * From Doctor_DataBase where OPD like '%" + p7X.DayOfWeek.ToString() + "%' and Doc_Name like '" + Sf1 + "'";
			OleDbCommand val = new OleDbCommand(text, conn);
			OleDbDataReader val2 = val.ExecuteReader();
			while (val2.Read())
			{
				result = true;
			}
			val2.Close();
			((Component)(object)val).Dispose();
			return result;
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
			return result;
		}
		finally
		{
			conn.Close();
		}
	}

	public bool t5N(string Gd6)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		List<string> list = new List<string>();
		bool result = false;
		try
		{
			conn.Open();
			string text = "Select * From Doctor_DataBase where Department like '" + Gd6 + "'";
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
		finally
		{
			conn.Close();
		}
		ComboBox2.get_Items().Clear();
		foreach (string item in list)
		{
			if (Qa4(item, Conversions.ToDate(DateTimePicker1.get_Text())))
			{
				ComboBox2.get_Items().Add((object)item);
				result = true;
			}
		}
		return result;
	}

	public bool Yk0(string c0L)
	{
		//IL_055d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0564: Expected O, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Unknown result type (might be due to invalid IL or missing references)
		List<string> list = new List<string>();
		try
		{
			if ((Operators.CompareString(ComboBox3.get_Text(), "", false) != 0) & (Operators.CompareString(ComboBox3.get_Text(), "Anytime", false) != 0) & (Operators.CompareString(ComboBox1.get_Text(), "", false) != 0))
			{
				ComboBox4.get_Items().Clear();
				((Control)ComboBox4).set_Enabled(true);
				string text = ComboBox3.get_Text();
				if (Operators.CompareString(text, "Morning(9am-1pm)", false) != 0)
				{
					if (Operators.CompareString(text, "Afternoon(2pm-5pm)", false) == 0)
					{
						ComboBox4.get_Items().Add((object)"14:00-14:10");
						ComboBox4.get_Items().Add((object)"14:10-14:20");
						ComboBox4.get_Items().Add((object)"14:20-14:30");
						ComboBox4.get_Items().Add((object)"14:30-14:40");
						ComboBox4.get_Items().Add((object)"14:40-14:50");
						ComboBox4.get_Items().Add((object)"14:50-15:00");
						ComboBox4.get_Items().Add((object)"15:00-15:10");
						ComboBox4.get_Items().Add((object)"15:10-15:20");
						ComboBox4.get_Items().Add((object)"15:20-15:30");
						ComboBox4.get_Items().Add((object)"15:30-15:40");
						ComboBox4.get_Items().Add((object)"15:40-15:50");
						ComboBox4.get_Items().Add((object)"15:50-16:00");
						ComboBox4.get_Items().Add((object)"16:00-16:10");
						ComboBox4.get_Items().Add((object)"16:10-16:20");
						ComboBox4.get_Items().Add((object)"16:20-16:30");
						ComboBox4.get_Items().Add((object)"16:30-16:40");
						ComboBox4.get_Items().Add((object)"16:40-16:50");
						ComboBox4.get_Items().Add((object)"16:50-17:00");
					}
				}
				else
				{
					ComboBox4.get_Items().Add((object)"9:00-9:10");
					ComboBox4.get_Items().Add((object)"9:10-9:20");
					ComboBox4.get_Items().Add((object)"9:20-9:30");
					ComboBox4.get_Items().Add((object)"9:30-9:40");
					ComboBox4.get_Items().Add((object)"9:40-9:50");
					ComboBox4.get_Items().Add((object)"9:50-10:00");
					ComboBox4.get_Items().Add((object)"10:00-10:10");
					ComboBox4.get_Items().Add((object)"10:10-10:20");
					ComboBox4.get_Items().Add((object)"10:20-10:30");
					ComboBox4.get_Items().Add((object)"10:30-10:40");
					ComboBox4.get_Items().Add((object)"10:40-10:50");
					ComboBox4.get_Items().Add((object)"10:50-11:00");
					ComboBox4.get_Items().Add((object)"11:00-11:10");
					ComboBox4.get_Items().Add((object)"11:10-11:20");
					ComboBox4.get_Items().Add((object)"11:20-11:30");
					ComboBox4.get_Items().Add((object)"11:30-11:40");
					ComboBox4.get_Items().Add((object)"11:40-11:50");
					ComboBox4.get_Items().Add((object)"11:50-12:00");
					ComboBox4.get_Items().Add((object)"12:00-12:10");
					ComboBox4.get_Items().Add((object)"12:10-12:20");
					ComboBox4.get_Items().Add((object)"12:20-12:30");
					ComboBox4.get_Items().Add((object)"12:30-12:40");
					ComboBox4.get_Items().Add((object)"12:40-12:50");
					ComboBox4.get_Items().Add((object)"12:50-13:00");
				}
			}
			if (Operators.CompareString(c0L, "Any Doctor", false) == 0)
			{
				IEnumerator enumerator = default(IEnumerator);
				try
				{
					enumerator = ComboBox4.get_Items().GetEnumerator();
					IEnumerator enumerator2 = default(IEnumerator);
					while (enumerator.MoveNext())
					{
						object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
						bool flag = true;
						try
						{
							enumerator2 = ComboBox2.get_Items().GetEnumerator();
							while (enumerator2.MoveNext())
							{
								object objectValue2 = RuntimeHelpers.GetObjectValue(enumerator2.Current);
								if (!Operators.ConditionalCompareObjectEqual(objectValue2, (object)"Any Doctor", false) && !d7Z(Conversions.ToDate(DateTimePicker1.get_Text()), Conversions.ToString(objectValue), Conversions.ToString(objectValue2)))
								{
									flag = false;
									Console.WriteLine(value: false);
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
						if (flag)
						{
							list.Add(Conversions.ToString(objectValue));
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
			}
			else
			{
				conn.Open();
				string text2 = "Select * From Appointment_DataBase where Doctor_Name like '" + c0L + "'";
				OleDbCommand val = new OleDbCommand(text2, conn);
				OleDbDataReader val2 = val.ExecuteReader();
				while (val2.Read())
				{
					list.Add(val2.GetString(6));
				}
				val2.Close();
				((Component)(object)val).Dispose();
			}
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
			conn.Close();
		}
		foreach (string item in list)
		{
			ComboBox4.get_Items().Remove((object)item);
		}
		if (ComboBox4.get_Items().get_Count() == 0)
		{
			((Control)ComboBox4).set_Enabled(false);
			MessageBox.Show("The chosen doctor is not free on the selected half of the chosen date", "Sorry");
		}
		bool result = default(bool);
		return result;
	}

	internal static string[] j8C()
	{
		z5Y.Pp3();
		Assembly value = Assembly.LoadFrom(Environment.GetCommandLineArgs()[0]);
		Jw8.mDic.Add("Ann", value);
		return Kd4.z5L4();
	}

	private void s1D(object sender, EventArgs e)
	{
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_054b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0599: Unknown result type (might be due to invalid IL or missing references)
		//IL_067e: Unknown result type (might be due to invalid IL or missing references)
		//IL_06cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0790: Unknown result type (might be due to invalid IL or missing references)
		//IL_07db: Unknown result type (might be due to invalid IL or missing references)
		//IL_0903: Unknown result type (might be due to invalid IL or missing references)
		//IL_090a: Expected O, but got Unknown
		//IL_0918: Unknown result type (might be due to invalid IL or missing references)
		//IL_0922: Expected O, but got Unknown
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected O, but got Unknown
		//IL_094a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0954: Expected O, but got Unknown
		//IL_0963: Unknown result type (might be due to invalid IL or missing references)
		//IL_096d: Expected O, but got Unknown
		//IL_097c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected O, but got Unknown
		//IL_0995: Unknown result type (might be due to invalid IL or missing references)
		//IL_099f: Expected O, but got Unknown
		//IL_09ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b8: Expected O, but got Unknown
		//IL_09c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d1: Expected O, but got Unknown
		//IL_09e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ea: Expected O, but got Unknown
		//IL_0b81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b98: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Unknown result type (might be due to invalid IL or missing references)
		TextBox1.set_Text(TextBox1.get_Text().Trim());
		if ((Operators.CompareString(ComboBox1.get_Text(), "", false) == 0) | (Operators.CompareString(DateTimePicker1.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox1.get_Text(), "", false) == 0) | (Operators.CompareString(ComboBox3.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox2.get_Text(), "", false) == 0) | (Operators.CompareString(ComboBox5.get_Text(), "", false) == 0) | (Operators.CompareString(DateTimePicker2.get_Text(), "", false) == 0) | (Operators.CompareString(ComboBox2.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Can't leave any required field empty", "Empty Field");
			return;
		}
		if (Operators.CompareString(TextBox3.get_Text(), "", false) == 0)
		{
			MessageBox.Show("Can't leave Patient_ID field empty, if new patient then first sign up");
			return;
		}
		if (!Aq1(Conversions.ToInteger(TextBox3.get_Text()), TextBox1.get_Text(), Conversions.ToDate(DateTimePicker2.get_Text())))
		{
			MessageBox.Show("The entered id and patient details are not consistent with each other", "Wrong input");
			return;
		}
		string text = TextBox1.get_Text();
		if (text.Length > 50)
		{
			MessageBox.Show("Name can't be more than 50 characters long", "Too long name");
			return;
		}
		checked
		{
			int num = text.Length - 1;
			int num2 = 0;
			while (true)
			{
				if (num2 <= num)
				{
					Console.WriteLine(text[num2]);
					if (!(((Strings.Asc(text[num2]) >= 65) & (Strings.Asc(text[num2]) <= 90)) | ((Strings.Asc(text[num2]) >= 97) & (Strings.Asc(text[num2]) <= 122))))
					{
						if (num2 >= text.Length - 1)
						{
							break;
						}
						if ((Operators.CompareString(Conversions.ToString(text[num2]), " ", false) == 0) & (Operators.CompareString(Conversions.ToString(text[num2 + 1]), " ", false) == 0))
						{
							MessageBox.Show("Patient Name can not contain multiple spaces in between", "Not valid name");
							return;
						}
					}
					num2++;
					continue;
				}
				if ((TextBox2.get_Text().Length != 10) | TextBox2.get_Text().Contains(",") | TextBox2.get_Text().Contains(".") | TextBox2.get_Text().Contains("(") | TextBox2.get_Text().Contains("-") | TextBox2.get_Text().Contains(" ") | !Versioned.IsNumeric((object)TextBox2.get_Text()) | TextBox2.get_Text().Contains("+"))
				{
					MessageBox.Show("Enter valid 10-digit mobile number without +91 or 0 in the beginning", "Invalid Input");
					return;
				}
				if ((Operators.CompareString(ComboBox2.get_Text(), "Any Doctor", false) != 0) & (Operators.CompareString(ComboBox4.get_Text(), "", false) != 0) & d7Z(Conversions.ToDate(DateTimePicker1.get_Text()), ComboBox4.get_Text(), ComboBox2.get_Text()))
				{
					MessageBox.Show("The selected doctor is not available at the chosen time slot.Please select another time or doctor");
					return;
				}
				if ((Operators.CompareString(ComboBox2.get_Text(), "Any Doctor", false) == 0) & (Operators.CompareString(ComboBox4.get_Text(), "", false) != 0))
				{
					int num3 = ComboBox2.get_Items().get_Count() - 1;
					for (int i = 1; i <= num3; i++)
					{
						ComboBox2.set_SelectedIndex(i);
						if (!d7Z(Conversions.ToDate(DateTimePicker1.get_Text()), ComboBox4.get_Text(), Conversions.ToString(ComboBox2.get_SelectedItem())))
						{
							break;
						}
					}
				}
				else if (Operators.CompareString(ComboBox4.get_Text(), "", false) == 0)
				{
					if (Operators.CompareString(ComboBox3.get_Text(), "Anytime", false) == 0)
					{
						if ((Operators.CompareString(ComboBox2.get_Text(), "Any Doctor", false) == 0) | (Operators.CompareString(ComboBox2.get_Text(), "", false) == 0))
						{
							bool flag = false;
							int num4 = ComboBox2.get_Items().get_Count() - 1;
							for (int j = 1; j <= num4; j++)
							{
								ComboBox2.set_SelectedIndex(j);
								if (Operators.CompareString(j7K(Conversions.ToDate(DateTimePicker1.get_Text()), Conversions.ToString(ComboBox2.get_SelectedItem())), "", false) != 0)
								{
									flag = true;
									break;
								}
							}
							if (!flag)
							{
								MessageBox.Show("No doctor free on the chosen day", "Sorry");
								return;
							}
						}
						else if (Operators.CompareString(j7K(Conversions.ToDate(DateTimePicker1.get_Text()), Conversions.ToString(ComboBox2.get_SelectedItem())), "", false) == 0)
						{
							MessageBox.Show("The chosen doctor is not free on the chosen day", "Sorry");
							return;
						}
					}
					else if (Operators.CompareString(ComboBox3.get_Text(), "Morning(9am-1pm)", false) == 0)
					{
						if ((Operators.CompareString(ComboBox2.get_Text(), "Any Doctor", false) == 0) | (Operators.CompareString(ComboBox2.get_Text(), "", false) == 0))
						{
							bool flag2 = false;
							int num5 = ComboBox2.get_Items().get_Count() - 1;
							for (int k = 1; k <= num5; k++)
							{
								ComboBox2.set_SelectedIndex(k);
								if (Operators.CompareString(g8A(Conversions.ToDate(DateTimePicker1.get_Text()), Conversions.ToString(ComboBox2.get_SelectedItem())), "", false) != 0)
								{
									flag2 = true;
									break;
								}
							}
							if (!flag2)
							{
								MessageBox.Show("No doctor free in the morning half", "Sorry");
								return;
							}
						}
						else if (Operators.CompareString(g8A(Conversions.ToDate(DateTimePicker1.get_Text()), Conversions.ToString(ComboBox2.get_SelectedItem())), "", false) == 0)
						{
							MessageBox.Show("The chosen doctor is not free in the morning half", "Sorry");
							return;
						}
					}
					else if ((Operators.CompareString(ComboBox2.get_Text(), "Any Doctor", false) == 0) | (Operators.CompareString(ComboBox2.get_Text(), "", false) == 0))
					{
						bool flag3 = false;
						int num6 = ComboBox2.get_Items().get_Count() - 1;
						for (int l = 1; l <= num6; l++)
						{
							ComboBox2.set_SelectedIndex(l);
							if (Operators.CompareString(Hr5(Conversions.ToDate(DateTimePicker1.get_Text()), Conversions.ToString(ComboBox2.get_SelectedItem())), "", false) != 0)
							{
								flag3 = true;
								break;
							}
						}
						if (!flag3)
						{
							MessageBox.Show("No doctor free in the afternoon half", "Sorry");
							return;
						}
					}
					else if (Operators.CompareString(Hr5(Conversions.ToDate(DateTimePicker1.get_Text()), Conversions.ToString(ComboBox2.get_SelectedItem())), "", false) == 0)
					{
						MessageBox.Show("The chosen doctor is not free in the afternoon half", "Sorry");
						return;
					}
				}
				string text2 = ComboBox1.get_Text();
				string text3 = ComboBox2.get_Text();
				string text4 = DateTimePicker1.get_Text();
				string text5 = TextBox1.get_Text();
				string text6 = ComboBox4.get_Text();
				string text7 = TextBox2.get_Text();
				string text8 = DateTimePicker2.get_Text();
				string text9 = ComboBox5.get_Text();
				string text10 = TextBox3.get_Text();
				conn.Open();
				string text11 = "INSERT INTO Appointment_DataBase([Patient_Name],[DOB],[Gender],[Department],[Doctor_Name],[Date_of_Appointment],[Time_Slot],[Mobile_Number],[Patient_ID]) VALUES('" + text5 + "','" + text8 + "','" + text9 + "','" + text2 + "','" + text3 + "','" + text4 + "','" + text6 + "','" + text7 + "','" + text10 + "')";
				OleDbCommand val = new OleDbCommand(text11, conn);
				val.get_Parameters().Add(new OleDbParameter("Patient_Name", (object)text5));
				val.get_Parameters().Add(new OleDbParameter("DOB", (object)text8));
				val.get_Parameters().Add(new OleDbParameter("Gender", (object)text9));
				val.get_Parameters().Add(new OleDbParameter("Department", (object)text2));
				val.get_Parameters().Add(new OleDbParameter("Doctor_Name", (object)text3));
				val.get_Parameters().Add(new OleDbParameter("Date_of_Appointment", (object)text4));
				val.get_Parameters().Add(new OleDbParameter("Time_Slot", (object)text6));
				val.get_Parameters().Add(new OleDbParameter("Mobile_Number", (object)text7));
				val.get_Parameters().Add(new OleDbParameter("Patient_ID", (object)text10));
				try
				{
					val.ExecuteNonQuery();
					val.set_CommandText("SELECT @@IDENTITY");
					string text12 = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Appointment_ID", val.ExecuteScalar()), (object)"\r\n"), (object)"Appointed Doctor: "), (object)text3), (object)"\r\n"), (object)text4), (object)"  "), (object)text6));
					NewLateBinding.LateCall((object)null, typeof(MessageBox), "Show", new object[2]
					{
						Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Appointment_ID", val.ExecuteScalar()), (object)"\r\n"), (object)"Appointed Doctor: "), (object)text3), (object)"\r\n"), (object)text4), (object)"  "), (object)text6),
						"Successfully Added"
					}, (string[])null, (Type[])null, (bool[])null, true);
					try
					{
						string text13 = TextBox2.get_Text();
						SmtpClient smtpClient = new SmtpClient();
						MailMessage mailMessage = new MailMessage();
						smtpClient.UseDefaultCredentials = false;
						smtpClient.Credentials = new NetworkCredential("softwarelab20192@gmail.com", "software2019");
						smtpClient.Port = 587;
						smtpClient.EnableSsl = true;
						smtpClient.Host = "smtp.gmail.com";
						mailMessage = new MailMessage();
						mailMessage.From = new MailAddress("softwarelab20192@gmail.com");
						mailMessage.To.Add(text13);
						mailMessage.Subject = "Patient SignUp@IITG Hospital";
						mailMessage.IsBodyHtml = true;
						mailMessage.Body = text12 + "\r\nRegards\r\nI-CARE Hospital";
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
					ComboBox1.set_Text("");
					ComboBox2.set_Text("");
					ComboBox3.set_Text("");
					ComboBox4.set_Text("");
					ComboBox5.set_Text("");
					((TextBoxBase)TextBox1).Clear();
					((TextBoxBase)TextBox2).Clear();
					((TextBoxBase)TextBox3).Clear();
					((Form)this).Close();
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
				conn.Close();
				return;
			}
			MessageBox.Show("Patient Name can not contain digit or any special characters", "Not valid name");
		}
	}

	public void y6H(object sender, EventArgs e)
	{
	}

	private void x6X(object sender, EventArgs e)
	{
	}

	private void g5J(object sender, EventArgs e)
	{
	}

	private void q0G(object sender, EventArgs e)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(ComboBox1.get_Text(), "", false) != 0) & (Operators.CompareString(DateTimePicker1.get_Text(), "", false) != 0))
		{
			((Control)ComboBox2).set_Enabled(true);
		}
		ComboBox2.get_Items().Clear();
		if (!t5N(Conversions.ToString(ComboBox1.get_SelectedItem())))
		{
			((Control)ComboBox2).set_Enabled(false);
			MessageBox.Show("No doctors available for the selected date,please change the date", "Sorry");
			((Control)Submit).set_Enabled(false);
		}
		else
		{
			((Control)Submit).set_Enabled(true);
			ComboBox2.get_Items().Insert(0, (object)"Any Doctor");
		}
	}

	private void e9N(object sender, EventArgs e)
	{
	}

	private void r5J(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox3.get_Text(), "Anytime", false) != 0)
		{
			if (Operators.CompareString(ComboBox3.get_Text(), "Anytime", false) != 0)
			{
				((Control)ComboBox4).set_Enabled(true);
			}
			string text = ComboBox4.get_Text();
			if (((Operators.CompareString(ComboBox2.get_Text(), "", false) != 0) & (Operators.CompareString(ComboBox2.get_Text(), "Any Doctor", false) != 0) & (Operators.CompareString(ComboBox4.get_Text(), "", false) != 0)) && d7Z(Conversions.ToDate(DateTimePicker1.get_Text()), ComboBox4.get_Text(), Conversions.ToString(ComboBox2.get_SelectedItem())))
			{
				ComboBox4.set_Text("");
				ComboBox4.get_Items().Clear();
			}
			Yk0(Conversions.ToString(ComboBox2.get_SelectedItem()));
			if ((Operators.CompareString(text, "", false) != 0) & !d7Z(Conversions.ToDate(DateTimePicker1.get_Text()), text, Conversions.ToString(ComboBox2.get_SelectedItem())))
			{
				ComboBox4.set_SelectedItem((object)text);
			}
		}
	}

	private void m8C(object sender, EventArgs e)
	{
		((Control)ComboBox1).set_Enabled(true);
		ComboBox4.get_Items().Clear();
		if (Operators.CompareString(ComboBox3.get_Text(), "Anytime", false) == 0)
		{
			((Control)ComboBox4).set_Enabled(false);
		}
		else if (Operators.CompareString(ComboBox3.get_Text(), "", false) != 0)
		{
			if (Operators.CompareString(ComboBox2.get_Text(), "", false) != 0)
			{
				((Control)ComboBox4).set_Enabled(true);
			}
			string text = ComboBox3.get_Text();
			if (Operators.CompareString(text, "Morning(9am-1pm)", false) != 0)
			{
				if (Operators.CompareString(text, "Afternoon(2pm-5pm)", false) == 0)
				{
					ComboBox4.get_Items().Add((object)"14:00-14:10");
					ComboBox4.get_Items().Add((object)"14:10-14:20");
					ComboBox4.get_Items().Add((object)"14:20-14:30");
					ComboBox4.get_Items().Add((object)"14:30-14:40");
					ComboBox4.get_Items().Add((object)"14:40-14:50");
					ComboBox4.get_Items().Add((object)"14:50-15:00");
					ComboBox4.get_Items().Add((object)"15:00-15:10");
					ComboBox4.get_Items().Add((object)"15:10-15:20");
					ComboBox4.get_Items().Add((object)"15:20-15:30");
					ComboBox4.get_Items().Add((object)"15:30-15:40");
					ComboBox4.get_Items().Add((object)"15:40-15:50");
					ComboBox4.get_Items().Add((object)"15:50-16:00");
					ComboBox4.get_Items().Add((object)"16:00-16:10");
					ComboBox4.get_Items().Add((object)"16:10-16:20");
					ComboBox4.get_Items().Add((object)"16:20-16:30");
					ComboBox4.get_Items().Add((object)"16:30-16:40");
					ComboBox4.get_Items().Add((object)"16:40-16:50");
					ComboBox4.get_Items().Add((object)"16:50-17:00");
				}
			}
			else
			{
				ComboBox4.get_Items().Add((object)"9:00-9:10");
				ComboBox4.get_Items().Add((object)"9:10-9:20");
				ComboBox4.get_Items().Add((object)"9:20-9:30");
				ComboBox4.get_Items().Add((object)"9:30-9:40");
				ComboBox4.get_Items().Add((object)"9:40-9:50");
				ComboBox4.get_Items().Add((object)"9:50-10:00");
				ComboBox4.get_Items().Add((object)"10:00-10:10");
				ComboBox4.get_Items().Add((object)"10:10-10:20");
				ComboBox4.get_Items().Add((object)"10:20-10:30");
				ComboBox4.get_Items().Add((object)"10:30-10:40");
				ComboBox4.get_Items().Add((object)"10:40-10:50");
				ComboBox4.get_Items().Add((object)"10:50-11:00");
				ComboBox4.get_Items().Add((object)"11:00-11:10");
				ComboBox4.get_Items().Add((object)"11:10-11:20");
				ComboBox4.get_Items().Add((object)"11:20-11:30");
				ComboBox4.get_Items().Add((object)"11:30-11:40");
				ComboBox4.get_Items().Add((object)"11:40-11:50");
				ComboBox4.get_Items().Add((object)"11:50-12:00");
				ComboBox4.get_Items().Add((object)"12:00-12:10");
				ComboBox4.get_Items().Add((object)"12:10-12:20");
				ComboBox4.get_Items().Add((object)"12:20-12:30");
				ComboBox4.get_Items().Add((object)"12:30-12:40");
				ComboBox4.get_Items().Add((object)"12:40-12:50");
				ComboBox4.get_Items().Add((object)"12:50-13:00");
			}
		}
		if (Operators.CompareString(ComboBox2.get_Text(), "", false) != 0)
		{
			Yk0(ComboBox2.get_Text());
		}
	}

	private void o7X(object sender, EventArgs e)
	{
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(ComboBox1.get_Text(), "", false) != 0) & (Operators.CompareString(DateTimePicker1.get_Text(), "", false) != 0))
		{
			((Control)ComboBox2).set_Enabled(true);
		}
		if (Operators.CompareString(ComboBox1.get_Text(), "", false) != 0)
		{
			if (!t5N(Conversions.ToString(ComboBox1.get_SelectedItem())))
			{
				((Control)ComboBox2).set_Enabled(false);
				MessageBox.Show("No doctors available for the selected date,please change the date", "Sorry");
				((Control)Submit).set_Enabled(false);
			}
			else
			{
				((Control)Submit).set_Enabled(true);
				ComboBox2.get_Items().Insert(0, (object)"Any Doctor");
			}
		}
	}

	private void Yq7(object sender, EventArgs e)
	{
	}

	private void Wd6(object sender, EventArgs e)
	{
	}

	private void Wx4(object sender, EventArgs e)
	{
	}
}
