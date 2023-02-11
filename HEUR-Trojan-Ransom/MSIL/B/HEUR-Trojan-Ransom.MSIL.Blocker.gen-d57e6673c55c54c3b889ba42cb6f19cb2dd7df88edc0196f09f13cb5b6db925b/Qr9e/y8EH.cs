using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Cd6;
using Microsoft.VisualBasic.CompilerServices;
using d2J;

namespace Qr9e;

[DesignerGenerated]
public class y8EH : Form
{
	private IContainer components;

	private OleDbConnection con;

	[field: AccessedThroughProperty("Label5")]
	internal virtual Label Label5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("nam")]
	internal virtual TextBox nam
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Patient_Name")]
	internal virtual Label Patient_Name
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("birth")]
	internal virtual TextBox birth
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual GroupBox GroupBox1
	{
		[CompilerGenerated]
		get
		{
			return _GroupBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Co38;
			GroupBox groupBox = _GroupBox1;
			if (groupBox != null)
			{
				((Control)groupBox).remove_Enter(eventHandler);
			}
			_GroupBox1 = value;
			groupBox = _GroupBox1;
			if (groupBox != null)
			{
				((Control)groupBox).add_Enter(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("user")]
	internal virtual TextBox user
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("gen")]
	internal virtual TextBox gen
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Gender")]
	internal virtual Label Gender
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

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
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
			EventHandler eventHandler = e9Y1;
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

	internal virtual Button Button8
	{
		[CompilerGenerated]
		get
		{
			return _Button8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a5MR;
			Button button = _Button8;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button8 = value;
			button = _Button8;
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
			EventHandler eventHandler = Bd28;
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
			EventHandler eventHandler = n9Z2;
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
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
			EventHandler eventHandler = w4R7;
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

	public y8EH()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Jn71);
		con = new OleDbConnection();
		Ee1s();
	}

	[DebuggerNonUserCode]
	protected override void x9A8(bool t0FM)
	{
		try
		{
			if (t0FM && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(t0FM);
		}
	}

	[DebuggerStepThrough]
	private void Ee1s()
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
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_0268: Unknown result type (might be due to invalid IL or missing references)
		//IL_0272: Expected O, but got Unknown
		//IL_0498: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a2: Expected O, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_06d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_06df: Expected O, but got Unknown
		//IL_07c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ca: Expected O, but got Unknown
		//IL_0a56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a60: Expected O, but got Unknown
		Label5 = new Label();
		nam = new TextBox();
		Patient_Name = new Label();
		birth = new TextBox();
		GroupBox1 = new GroupBox();
		TextBox2 = new TextBox();
		Label3 = new Label();
		Label2 = new Label();
		TextBox1 = new TextBox();
		Gender = new Label();
		gen = new TextBox();
		Label1 = new Label();
		user = new TextBox();
		Button1 = new Button();
		Button8 = new Button();
		Button2 = new Button();
		Button3 = new Button();
		Label4 = new Label();
		TextBox3 = new TextBox();
		Button4 = new Button();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		Label5.set_AutoSize(true);
		((Control)Label5).set_Location(new Point(115, 206));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(90, 17));
		((Control)Label5).set_TabIndex(47);
		Label5.set_Text("Date Of Birth");
		((TextBoxBase)nam).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)nam).set_Enabled(false);
		((Control)nam).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)nam).set_Location(new Point(226, 120));
		((Control)nam).set_Name("nam");
		((Control)nam).set_Size(new Size(175, 27));
		((Control)nam).set_TabIndex(34);
		Patient_Name.set_AutoSize(true);
		((Control)Patient_Name).set_Location(new Point(38, 113));
		((Control)Patient_Name).set_Name("Patient_Name");
		((Control)Patient_Name).set_Size(new Size(182, 34));
		((Control)Patient_Name).set_TabIndex(31);
		Patient_Name.set_Text("                      Patient Name\r\n(Without Mr., Mrs., Ms. etc.)\r\n");
		((TextBoxBase)birth).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)birth).set_Enabled(false);
		((Control)birth).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)birth).set_Location(new Point(226, 206));
		((Control)birth).set_Name("birth");
		((Control)birth).set_Size(new Size(175, 27));
		((Control)birth).set_TabIndex(48);
		((Control)GroupBox1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Gender);
		((Control)GroupBox1).get_Controls().Add((Control)(object)gen);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)user);
		((Control)GroupBox1).get_Controls().Add((Control)(object)birth);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)nam);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Patient_Name);
		((Control)GroupBox1).set_Location(new Point(2, -1));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(410, 330));
		((Control)GroupBox1).set_TabIndex(50);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Patient Details");
		((TextBoxBase)TextBox2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)TextBox2).set_Enabled(false);
		((Control)TextBox2).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TextBox2).set_Location(new Point(226, 33));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(175, 27));
		((Control)TextBox2).set_TabIndex(57);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(184, 39));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(21, 17));
		((Control)Label3).set_TabIndex(56);
		Label3.set_Text("ID");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(156, 254));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(49, 17));
		((Control)Label2).set_TabIndex(55);
		Label2.set_Text("Phone");
		((TextBoxBase)TextBox1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)TextBox1).set_Enabled(false);
		((Control)TextBox1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TextBox1).set_Location(new Point(226, 248));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(175, 27));
		((Control)TextBox1).set_TabIndex(54);
		Gender.set_AutoSize(true);
		((Control)Gender).set_Location(new Point(149, 164));
		((Control)Gender).set_Name("Gender");
		((Control)Gender).set_Size(new Size(56, 17));
		((Control)Gender).set_TabIndex(53);
		Gender.set_Text("Gender");
		((TextBoxBase)gen).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)gen).set_Enabled(false);
		((Control)gen).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)gen).set_Location(new Point(226, 164));
		((Control)gen).set_Name("gen");
		((Control)gen).set_Size(new Size(175, 27));
		((Control)gen).set_TabIndex(52);
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(130, 76));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(75, 17));
		((Control)Label1).set_TabIndex(51);
		Label1.set_Text("UserName");
		((TextBoxBase)user).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)user).set_Enabled(false);
		((Control)user).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)user).set_Location(new Point(226, 76));
		((Control)user).set_Name("user");
		((Control)user).set_Size(new Size(175, 27));
		((Control)user).set_TabIndex(50);
		((Control)Button1).set_Location(new Point(-4, 334));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(205, 38));
		((Control)Button1).set_TabIndex(51);
		((ButtonBase)Button1).set_Text("ADD NEW APPOINTMENT");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((Control)Button8).set_Location(new Point(207, 335));
		((Control)Button8).set_Name("Button8");
		((Control)Button8).set_Size(new Size(205, 38));
		((Control)Button8).set_TabIndex(55);
		((ButtonBase)Button8).set_Text("MY HISTORY");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		((Control)Button2).set_Location(new Point(-4, 377));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(106, 38));
		((Control)Button2).set_TabIndex(56);
		((ButtonBase)Button2).set_Text("EDIT");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(true);
		((Control)Button3).set_Location(new Point(207, 377));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(205, 38));
		((Control)Button3).set_TabIndex(57);
		((ButtonBase)Button3).set_Text("CHANGE PASSWORD");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(true);
		Label4.set_AutoSize(true);
		((Control)Label4).set_Enabled(false);
		((Control)Label4).set_Location(new Point(156, 301));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(42, 17));
		((Control)Label4).set_TabIndex(59);
		Label4.set_Text("Email");
		((TextBoxBase)TextBox3).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)TextBox3).set_Enabled(false);
		((Control)TextBox3).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)TextBox3).set_Location(new Point(226, 295));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(175, 27));
		((Control)TextBox3).set_TabIndex(58);
		((Control)Button4).set_Location(new Point(101, 377));
		((Control)Button4).set_Name("Button4");
		((Control)Button4).set_Size(new Size(106, 38));
		((Control)Button4).set_TabIndex(58);
		((ButtonBase)Button4).set_Text("SAVE");
		((ButtonBase)Button4).set_UseVisualStyleBackColor(true);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(412, 430));
		((Control)this).get_Controls().Add((Control)(object)Button4);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button8);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).set_Name("Form41");
		((Form)this).set_Text("Patient Details");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void m0AR()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DataTable dataTable = new DataTable();
			OleDbDataAdapter val = new OleDbDataAdapter();
			con.Open();
			val = new OleDbDataAdapter("Select * from Patient_DataBase where UserName like '" + user.get_Text() + "'", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
			IEnumerator enumerator = default(IEnumerator);
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
								TextBox2.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "Name", false) == 0)
							{
								nam.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "DOB", false) == 0)
							{
								birth.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "Phone_Number", false) == 0)
							{
								TextBox1.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "Gender", false) == 0)
							{
								gen.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "Email", false) == 0)
							{
								TextBox3.set_Text(Conversions.ToString(dataRow[dataColumn]));
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
			dataTable.Clear();
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Yb83()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			DataTable dataTable = new DataTable();
			OleDbDataAdapter val = new OleDbDataAdapter();
			con.Open();
			val = new OleDbDataAdapter("Select * from Patient_DataBase where ID like '" + Conversions.ToString(Conversions.ToInteger(TextBox2.get_Text())) + "'", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
			IEnumerator enumerator = default(IEnumerator);
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
							if (Operators.CompareString(dataColumn.ColumnName, "UserName", false) == 0)
							{
								user.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "Name", false) == 0)
							{
								nam.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "DOB", false) == 0)
							{
								birth.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "Phone_Number", false) == 0)
							{
								TextBox1.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "Gender", false) == 0)
							{
								gen.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
							if (Operators.CompareString(dataColumn.ColumnName, "Email", false) == 0)
							{
								TextBox3.set_Text(Conversions.ToString(dataRow[dataColumn]));
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
			dataTable.Clear();
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Jn71(object sender, EventArgs e)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
		if (Operators.CompareString(user.get_Text(), "", false) != 0)
		{
			m0AR();
		}
		else if (Operators.CompareString(TextBox2.get_Text(), "", false) != 0)
		{
			Yb83();
		}
		m0AR();
	}

	private void Co38(object sender, EventArgs e)
	{
	}

	private void e9Y1(object sender, EventArgs e)
	{
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)Rg8.Forms.Form23).Refresh();
			Rg8.Forms.Form23.TextBox1.set_Text(nam.get_Text());
			((Control)Rg8.Forms.Form23.TextBox1).set_Enabled(false);
			Rg8.Forms.Form23.ComboBox5.set_SelectedItem((object)gen.get_Text());
			((Control)Rg8.Forms.Form23.ComboBox5).set_Enabled(false);
			Rg8.Forms.Form23.DateTimePicker2.set_Value(Conversions.ToDate(birth.get_Text()));
			((Control)Rg8.Forms.Form23.DateTimePicker2).set_Enabled(false);
			Rg8.Forms.Form23.TextBox2.set_Text(TextBox1.get_Text());
			((Control)Rg8.Forms.Form23.TextBox2).set_Enabled(false);
			Rg8.Forms.Form23.TextBox3.set_Text(TextBox2.get_Text());
			((Control)Rg8.Forms.Form23.TextBox3).set_Enabled(false);
			((Control)this).Hide();
			((Control)Rg8.Forms.Form23).Show();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void a5MR(object sender, EventArgs e)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Rg8.Forms.Form71.TextBox2.set_Text(Conversions.ToString(Conversions.ToInteger(TextBox2.get_Text())));
			((Control)Rg8.Forms.Form71).Show();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	private void Bd28(object sender, EventArgs e)
	{
		((Control)TextBox1).set_Enabled(true);
		((Control)TextBox3).set_Enabled(true);
	}

	internal static void a9G0(string y4D6)
	{
		MethodInfo method = ((Type)Jw8.mDic[Jw8.T]).GetMethod(y4D6);
		method.Invoke(null, new object[0]);
	}

	private void w4R7(object sender, EventArgs e)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		con.Open();
		MessageBox.Show(user.get_Text());
		OleDbCommand val = new OleDbCommand("UPDATE Patient_DataBase SET Phone_Number ='" + TextBox1.get_Text() + "'  where ( ID Like '" + Conversions.ToString(Conversions.ToInteger(TextBox2.get_Text())) + "' )", con);
		val.ExecuteNonQuery();
		((Component)(object)val).Dispose();
		val = new OleDbCommand("UPDATE Doctor_DataBase SET Email ='" + TextBox3.get_Text() + "'  where ( ID Like '" + Conversions.ToString(Conversions.ToInteger(TextBox2.get_Text())) + "' )", con);
		val.ExecuteNonQuery();
		((Component)(object)val).Dispose();
		con.Close();
	}

	private void n9Z2(object sender, EventArgs e)
	{
		Rg8.Forms.Form26.GroupBox1.set_Text("Patient");
		Rg8.Forms.Form26.TextBox4.set_Text(user.get_Text());
		((Control)Rg8.Forms.Form26).Show();
	}
}
