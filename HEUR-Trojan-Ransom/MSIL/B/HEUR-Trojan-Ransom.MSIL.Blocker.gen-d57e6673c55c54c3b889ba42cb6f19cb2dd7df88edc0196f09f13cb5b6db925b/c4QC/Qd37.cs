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
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using k4Z;

namespace c4QC;

[DesignerGenerated]
public class Qd37 : Form
{
	private IContainer components;

	private short check_flag;

	private short Flag_control;

	private OleDbConnection con;

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

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("DateTimePicker1")]
	internal virtual DateTimePicker DateTimePicker1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("CheckBox2")]
	internal virtual CheckBox CheckBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual FlowLayoutPanel FlowLayoutPanel1
	{
		[CompilerGenerated]
		get
		{
			return _FlowLayoutPanel1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Expected O, but got Unknown
			PaintEventHandler val = new PaintEventHandler(Wc6w);
			FlowLayoutPanel flowLayoutPanel = _FlowLayoutPanel1;
			if (flowLayoutPanel != null)
			{
				((Control)flowLayoutPanel).remove_Paint(val);
			}
			_FlowLayoutPanel1 = value;
			flowLayoutPanel = _FlowLayoutPanel1;
			if (flowLayoutPanel != null)
			{
				((Control)flowLayoutPanel).add_Paint(val);
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
			EventHandler eventHandler = Bp4x;
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
			EventHandler eventHandler = t0AR;
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

	public Qd37()
	{
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Ly0t);
		check_flag = 0;
		Flag_control = 0;
		con = new OleDbConnection();
		c0TJ();
	}

	[DebuggerNonUserCode]
	protected override void z3LC(bool Aj39)
	{
		try
		{
			if (Aj39 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Aj39);
		}
	}

	[DebuggerStepThrough]
	private void c0TJ()
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
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0356: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Expected O, but got Unknown
		Label2 = new Label();
		TextBox2 = new TextBox();
		Label5 = new Label();
		DateTimePicker1 = new DateTimePicker();
		CheckBox2 = new CheckBox();
		FlowLayoutPanel1 = new FlowLayoutPanel();
		Button1 = new Button();
		TextBox1 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(12, 9));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(100, 27));
		((Control)Label2).set_TabIndex(26);
		Label2.set_Text("Patient ID:");
		Label2.set_TextAlign((ContentAlignment)64);
		((Control)TextBox2).set_Enabled(false);
		((Control)TextBox2).set_Location(new Point(118, 9));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(86, 22));
		((Control)TextBox2).set_TabIndex(29);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(210, 9));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(158, 27));
		((Control)Label5).set_TabIndex(30);
		Label5.set_Text("Enter Search Date :");
		Label5.set_TextAlign((ContentAlignment)64);
		((Control)DateTimePicker1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		DateTimePicker1.set_Format((DateTimePickerFormat)8);
		((Control)DateTimePicker1).set_Location(new Point(374, 9));
		((Control)DateTimePicker1).set_Name("DateTimePicker1");
		((Control)DateTimePicker1).set_Size(new Size(140, 27));
		((Control)DateTimePicker1).set_TabIndex(31);
		DateTimePicker1.set_Value(new DateTime(2019, 2, 11, 0, 0, 0, 0));
		CheckBox2.set_Checked(true);
		CheckBox2.set_CheckState((CheckState)1);
		((Control)CheckBox2).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)CheckBox2).set_Location(new Point(520, 10));
		((Control)CheckBox2).set_Name("CheckBox2");
		((Control)CheckBox2).set_Size(new Size(99, 27));
		((Control)CheckBox2).set_TabIndex(32);
		((ButtonBase)CheckBox2).set_Text("Show All");
		((ButtonBase)CheckBox2).set_UseVisualStyleBackColor(true);
		((ScrollableControl)FlowLayoutPanel1).set_AutoScroll(true);
		((Control)FlowLayoutPanel1).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)FlowLayoutPanel1).set_Location(new Point(27, 46));
		((Control)FlowLayoutPanel1).set_Name("FlowLayoutPanel1");
		((Control)FlowLayoutPanel1).set_Size(new Size(726, 321));
		((Control)FlowLayoutPanel1).set_TabIndex(33);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_Location(new Point(624, 12));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(131, 28));
		((Control)Button1).set_TabIndex(34);
		((ButtonBase)Button1).set_Text("Close");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)TextBox1).set_Location(new Point(374, 9));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(128, 22));
		((Control)TextBox1).set_TabIndex(35);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(765, 377));
		((Control)this).get_Controls().Add((Control)(object)DateTimePicker1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)FlowLayoutPanel1);
		((Control)this).get_Controls().Add((Control)(object)CheckBox2);
		((Control)this).get_Controls().Add((Control)(object)Label5);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)Label2);
		((Control)this).set_Name("Form71");
		((Form)this).set_Text("Patient History");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void d5P2()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		DataTable dataTable = new DataTable();
		OleDbDataAdapter val = new OleDbDataAdapter();
		((Control)FlowLayoutPanel1).get_Controls().Clear();
		con.Open();
		val = new OleDbDataAdapter("Select * from Appointment_Database where Patient_ID like '%" + TextBox2.get_Text() + "%' And  Date_Of_Appointment like '%" + TextBox1.get_Text() + "%' ", con);
		((DbDataAdapter)(object)val).Fill(dataTable);
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				g1L g1L = new g1L();
				try
				{
					enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataColumn dataColumn = (DataColumn)enumerator2.Current;
						if (Operators.CompareString(dataColumn.ColumnName, "Doctor_Name", false) == 0)
						{
							((ButtonBase)g1L).set_Text(" Doctor_Name   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "Remarks", false) == 0)
						{
							((ButtonBase)g1L).set_Text(((ButtonBase)g1L).get_Text() + "        Remarks/Medicines  :  " + dataRow[dataColumn].ToString());
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
				((Control)FlowLayoutPanel1).get_Controls().Add((Control)(object)g1L);
			}
		}
		finally
		{
			if (enumerator is IDisposable)
			{
				(enumerator as IDisposable).Dispose();
			}
		}
		con.Close();
	}

	private void Ly0t(object sender, EventArgs e)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
		d5P2();
		Flag_control = 1;
	}

	private void Rn35(object sender, EventArgs e)
	{
		if ((Flag_control == 1) & !CheckBox2.get_Checked())
		{
			TextBox1.set_Text(DateTimePicker1.get_Value().ToShortDateString());
		}
	}

	private void t0AR(object sender, EventArgs e)
	{
		d5P2();
	}

	private void Bp4x(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void r0B4(object sender, EventArgs e)
	{
		if (CheckBox2.get_Checked())
		{
			((TextBoxBase)TextBox1).Clear();
		}
		if (!CheckBox2.get_Checked())
		{
			TextBox1.set_Text(DateTimePicker1.get_Value().ToShortDateString());
		}
	}

	private void Wc6w(object sender, PaintEventArgs e)
	{
	}
}
