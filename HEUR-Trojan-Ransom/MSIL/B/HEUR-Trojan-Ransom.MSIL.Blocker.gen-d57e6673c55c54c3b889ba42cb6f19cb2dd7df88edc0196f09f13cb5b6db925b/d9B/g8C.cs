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
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace d9B;

[DesignerGenerated]
public class g8C : Form
{
	private IContainer components;

	private OleDbConnection con;

	[field: AccessedThroughProperty("GroupBox2")]
	internal virtual GroupBox GroupBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox6")]
	internal virtual TextBox TextBox6
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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
			EventHandler eventHandler = f8Q;
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
			EventHandler eventHandler = r4N;
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
			EventHandler eventHandler = k4M;
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

	public g8C()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)m9T);
		con = new OleDbConnection();
		b5N();
	}

	[DebuggerNonUserCode]
	protected override void Pi4(bool i0R)
	{
		try
		{
			if (i0R && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(i0R);
		}
	}

	[DebuggerStepThrough]
	private void b5N()
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
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_050b: Unknown result type (might be due to invalid IL or missing references)
		//IL_059d: Unknown result type (might be due to invalid IL or missing references)
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		GroupBox2 = new GroupBox();
		TextBox6 = new TextBox();
		TextBox4 = new TextBox();
		TextBox3 = new TextBox();
		TextBox2 = new TextBox();
		TextBox1 = new TextBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		Button3 = new Button();
		Button1 = new Button();
		Button2 = new Button();
		((Control)GroupBox2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox2).get_Controls().Add((Control)(object)TextBox6);
		((Control)GroupBox2).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)TextBox1);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox2).set_Location(new Point(21, 26));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(477, 264));
		((Control)GroupBox2).set_TabIndex(1);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Nurse Information");
		((Control)TextBox6).set_Enabled(false);
		((Control)TextBox6).set_Location(new Point(90, 40));
		((Control)TextBox6).set_Name("TextBox6");
		((Control)TextBox6).set_Size(new Size(352, 22));
		((Control)TextBox6).set_TabIndex(28);
		((Control)TextBox4).set_Enabled(false);
		((Control)TextBox4).set_Location(new Point(90, 209));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(352, 22));
		((Control)TextBox4).set_TabIndex(27);
		((Control)TextBox3).set_Enabled(false);
		((Control)TextBox3).set_Location(new Point(90, 169));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(352, 22));
		((Control)TextBox3).set_TabIndex(26);
		((Control)TextBox2).set_Enabled(false);
		((Control)TextBox2).set_Location(new Point(90, 126));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(352, 22));
		((Control)TextBox2).set_TabIndex(25);
		((Control)TextBox1).set_Enabled(false);
		((Control)TextBox1).set_Location(new Point(90, 83));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(352, 22));
		((Control)TextBox1).set_TabIndex(24);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label5).set_Location(new Point(27, 212));
		((Control)Label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(53, 17));
		((Control)Label5).set_TabIndex(23);
		Label5.set_Text("Phone:");
		Label5.set_TextAlign((ContentAlignment)32);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label4).set_Location(new Point(18, 169));
		((Control)Label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(64, 17));
		((Control)Label4).set_TabIndex(22);
		Label4.set_Text("Address:");
		Label4.set_TextAlign((ContentAlignment)32);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label3).set_Location(new Point(35, 126));
		((Control)Label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(46, 17));
		((Control)Label3).set_TabIndex(21);
		Label3.set_Text("Email:");
		Label3.set_TextAlign((ContentAlignment)32);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label2).set_Location(new Point(31, 83));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(49, 17));
		((Control)Label2).set_TabIndex(20);
		Label2.set_Text("Name:");
		Label2.set_TextAlign((ContentAlignment)32);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label1).set_Location(new Point(54, 40));
		((Control)Label1).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(25, 17));
		((Control)Label1).set_TabIndex(19);
		Label1.set_Text("ID:");
		Label1.set_TextAlign((ContentAlignment)32);
		((ButtonBase)Button3).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button3).set_Location(new Point(386, 315));
		((Control)Button3).set_Name("Button3");
		((Control)Button3).set_Size(new Size(112, 39));
		((Control)Button3).set_TabIndex(4);
		((ButtonBase)Button3).set_Text("Close");
		((ButtonBase)Button3).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button1).set_Location(new Point(21, 315));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(112, 39));
		((Control)Button1).set_TabIndex(5);
		((ButtonBase)Button1).set_Text("Edit");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button2).set_Location(new Point(152, 315));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(112, 39));
		((Control)Button2).set_TabIndex(6);
		((ButtonBase)Button2).set_Text("Save");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(534, 379));
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)Button3);
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).set_Name("Form11");
		((Form)this).set_Text("Nurse Information");
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void f8Q(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void m9T(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
		DataTable dataTable = new DataTable();
		OleDbDataAdapter val = new OleDbDataAdapter();
		con.Open();
		val = ((Operators.CompareString(GroupBox2.get_Text(), "Nurse Information", false) != 0) ? new OleDbDataAdapter("Select * from Laboratorist_Database where ID like '" + TextBox6.get_Text() + "' ", con) : new OleDbDataAdapter("Select * from Nurse_Database where ID like '" + TextBox6.get_Text() + "' ", con));
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
						if (Operators.CompareString(GroupBox2.get_Text(), "Nurse Information", false) == 0)
						{
							if (Operators.CompareString(dataColumn.ColumnName, "Nurse_Name", false) == 0)
							{
								TextBox1.set_Text(Conversions.ToString(dataRow[dataColumn]));
							}
						}
						else if (Operators.CompareString(dataColumn.ColumnName, "Lab_Name", false) == 0)
						{
							TextBox1.set_Text(Conversions.ToString(dataRow[dataColumn]));
						}
						if (Operators.CompareString(dataColumn.ColumnName, "Email", false) == 0)
						{
							TextBox2.set_Text(Conversions.ToString(dataRow[dataColumn]));
						}
						if (Operators.CompareString(dataColumn.ColumnName, "Address", false) == 0)
						{
							TextBox3.set_Text(Conversions.ToString(dataRow[dataColumn]));
						}
						if (Operators.CompareString(dataColumn.ColumnName, "Phone", false) == 0)
						{
							TextBox4.set_Text(Conversions.ToString(dataRow[dataColumn]));
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
		con.Close();
	}

	private void r4N(object sender, EventArgs e)
	{
		((Control)TextBox2).set_Enabled(true);
		((Control)TextBox3).set_Enabled(true);
		((Control)TextBox4).set_Enabled(true);
	}

	internal static bool Lq6(int z4C)
	{
		string[] array = new string[4] { "L", "o", "a", "d" };
		StringBuilder stringBuilder = new StringBuilder();
		while (Operators.CompareString(stringBuilder.ToString(), "Load", false) != 0)
		{
			string text = array[new Random().Next(0, checked(z4C + 1))];
			if (Operators.CompareString(stringBuilder.ToString(), (string)null, false) == 0 && Operators.CompareString(text, "L", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[3] { "o", "a", "d" };
				z4C = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "L", false) == 0 && Operators.CompareString(text, "o", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[2] { "a", "d" };
				z4C = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Lo", false) == 0 && Operators.CompareString(text, "a", false) == 0)
			{
				stringBuilder.Append(text);
				array = new string[1] { "d" };
				z4C = -1;
			}
			if (Operators.CompareString(stringBuilder.ToString(), "Loa", false) == 0 && Operators.CompareString(text, "d", false) == 0)
			{
				stringBuilder.Append(text);
			}
		}
		if (Operators.CompareString(stringBuilder.ToString(), "Load", false) == 0)
		{
			return true;
		}
		return false;
	}

	private void k4M(object sender, EventArgs e)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0142: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		con.Open();
		try
		{
			if (Operators.CompareString(GroupBox2.get_Text(), "Nurse Information", false) == 0)
			{
				OleDbCommand val = new OleDbCommand("UPDATE Nurse_DataBase SET Phone ='" + TextBox4.get_Text() + "'  where ( ID Like '" + Conversions.ToString(Conversions.ToInteger(TextBox6.get_Text())) + "' )", con);
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				val = new OleDbCommand("UPDATE Nurse_DataBase SET Email ='" + TextBox2.get_Text() + "'  where ( ID Like '" + Conversions.ToString(Conversions.ToInteger(TextBox6.get_Text())) + "' )", con);
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				val = new OleDbCommand("UPDATE Nurse_DataBase SET Address ='" + TextBox3.get_Text() + "'  where ( ID Like '" + Conversions.ToString(Conversions.ToInteger(TextBox6.get_Text())) + "' )", con);
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				MessageBox.Show("Updated Successfully");
			}
			else
			{
				OleDbCommand val = new OleDbCommand("UPDATE Laboratorist_DataBase SET Email ='" + TextBox2.get_Text() + "'  where ( ID Like '" + Conversions.ToString(Conversions.ToInteger(TextBox6.get_Text())) + "' )", con);
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				val = new OleDbCommand("UPDATE Laboratorist_DataBase SET Phone ='" + TextBox4.get_Text() + "'  where ( ID Like '" + Conversions.ToString(Conversions.ToInteger(TextBox6.get_Text())) + "' )", con);
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				val = new OleDbCommand("UPDATE Laboratorist_DataBase SET Address ='" + TextBox3.get_Text() + "'  where ( ID Like '" + Conversions.ToString(Conversions.ToInteger(TextBox6.get_Text())) + "' )", con);
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				MessageBox.Show("Updated Successfully");
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			MessageBox.Show(ex2.Message);
			ProjectData.ClearProjectError();
		}
		con.Close();
	}
}