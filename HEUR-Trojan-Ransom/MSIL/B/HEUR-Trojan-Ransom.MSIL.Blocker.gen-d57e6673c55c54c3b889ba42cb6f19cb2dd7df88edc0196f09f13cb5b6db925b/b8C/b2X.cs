using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using d2J;
using z9K;

namespace b8C;

[DesignerGenerated]
public class b2X : Form
{
	private IContainer components;

	private OleDbConnection con;

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
			EventHandler eventHandler = k9D;
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = Wj2;
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
			EventHandler eventHandler = r3Q;
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

	[field: AccessedThroughProperty("FlowLayoutPanel2")]
	internal virtual FlowLayoutPanel FlowLayoutPanel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
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
			EventHandler eventHandler = Ey6;
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

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
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

	internal virtual Button clear
	{
		[CompilerGenerated]
		get
		{
			return _clear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Bm3;
			Button val = _clear;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_clear = value;
			val = _clear;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
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
			EventHandler eventHandler = w9P;
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

	internal virtual Button add_item
	{
		[CompilerGenerated]
		get
		{
			return _add_item;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = o6W;
			Button val = _add_item;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_add_item = value;
			val = _add_item;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	public b2X()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Fi1);
		con = new OleDbConnection();
		Le0();
	}

	[DebuggerNonUserCode]
	protected override void Qm6(bool c2K)
	{
		try
		{
			if (c2K && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(c2K);
		}
	}

	[DebuggerStepThrough]
	private void Le0()
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
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_0162: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_0531: Expected O, but got Unknown
		//IL_05c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_066c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0676: Expected O, but got Unknown
		//IL_0780: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b57: Unknown result type (might be due to invalid IL or missing references)
		Button8 = new Button();
		Label1 = new Label();
		ComboBox1 = new ComboBox();
		TextBox1 = new TextBox();
		FlowLayoutPanel2 = new FlowLayoutPanel();
		GroupBox1 = new GroupBox();
		clear = new Button();
		Button1 = new Button();
		add_item = new Button();
		TextBox3 = new TextBox();
		Label6 = new Label();
		ComboBox2 = new ComboBox();
		TextBox4 = new TextBox();
		TextBox2 = new TextBox();
		TextBox5 = new TextBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)Button8).set_Location(new Point(1030, 6));
		((Control)Button8).set_Name("Button8");
		((Control)Button8).set_Size(new Size(76, 27));
		((Control)Button8).set_TabIndex(16);
		((ButtonBase)Button8).set_Text("CLEAR");
		((ButtonBase)Button8).set_UseVisualStyleBackColor(true);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(386, 11));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(158, 27));
		((Control)Label1).set_TabIndex(15);
		Label1.set_Text("SEARCH Rooms BY");
		Label1.set_TextAlign((ContentAlignment)16);
		ComboBox1.set_BackColor(Color.White);
		ComboBox1.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox1).set_FormattingEnabled(true);
		ComboBox1.get_Items().AddRange(new object[5] { "Room_ID", "Floor", "Room_Number", "Patient_ID", "Emergency_ID" });
		((Control)ComboBox1).set_Location(new Point(550, 11));
		((Control)ComboBox1).set_Name("ComboBox1");
		((Control)ComboBox1).set_Size(new Size(199, 24));
		((Control)ComboBox1).set_TabIndex(14);
		((Control)TextBox1).set_Location(new Point(755, 13));
		((Control)TextBox1).set_Name("TextBox1");
		((Control)TextBox1).set_Size(new Size(269, 22));
		((Control)TextBox1).set_TabIndex(13);
		((ScrollableControl)FlowLayoutPanel2).set_AutoScroll(true);
		((Control)FlowLayoutPanel2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)FlowLayoutPanel2).set_Location(new Point(389, 41));
		((Control)FlowLayoutPanel2).set_Name("FlowLayoutPanel2");
		((Control)FlowLayoutPanel2).set_Size(new Size(717, 401));
		((Control)FlowLayoutPanel2).set_TabIndex(12);
		((Control)GroupBox1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox1).get_Controls().Add((Control)(object)clear);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Button1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)add_item);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label6);
		((Control)GroupBox1).get_Controls().Add((Control)(object)ComboBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)TextBox5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)GroupBox1).set_Location(new Point(13, 41));
		((Control)GroupBox1).set_Margin(new Padding(4));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Padding(new Padding(4));
		((Control)GroupBox1).set_Size(new Size(369, 401));
		((Control)GroupBox1).set_TabIndex(19);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Allocate Room");
		((ButtonBase)clear).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)clear).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)clear).set_ForeColor(SystemColors.InactiveCaptionText);
		((Control)clear).set_Location(new Point(127, 313));
		((Control)clear).set_Name("clear");
		((Control)clear).set_Size(new Size(101, 54));
		((Control)clear).set_TabIndex(25);
		((ButtonBase)clear).set_Text("Clear");
		((ButtonBase)clear).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(SystemColors.InactiveCaptionText);
		((Control)Button1).set_Location(new Point(270, 313));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(92, 54));
		((Control)Button1).set_TabIndex(24);
		((ButtonBase)Button1).set_Text("Close");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)add_item).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)add_item).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)add_item).set_ForeColor(SystemColors.InactiveCaptionText);
		((Control)add_item).set_Location(new Point(7, 313));
		((Control)add_item).set_Name("add_item");
		((Control)add_item).set_Size(new Size(114, 54));
		((Control)add_item).set_TabIndex(23);
		((ButtonBase)add_item).set_Text("Add into data");
		((ButtonBase)add_item).set_UseVisualStyleBackColor(false);
		((Control)TextBox3).set_Enabled(false);
		((Control)TextBox3).set_Location(new Point(166, 244));
		((Control)TextBox3).set_Name("TextBox3");
		((Control)TextBox3).set_Size(new Size(178, 27));
		((Control)TextBox3).set_TabIndex(22);
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label6).set_Location(new Point(24, 247));
		((Control)Label6).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(119, 20));
		((Control)Label6).set_TabIndex(21);
		Label6.set_Text("Emergency_ID");
		Label6.set_TextAlign((ContentAlignment)32);
		ComboBox2.set_BackColor(Color.White);
		ComboBox2.set_DropDownStyle((ComboBoxStyle)2);
		((ListControl)ComboBox2).set_FormattingEnabled(true);
		ComboBox2.get_Items().AddRange(new object[2] { "Normal_Patient", "Emergency" });
		((Control)ComboBox2).set_Location(new Point(166, 158));
		((Control)ComboBox2).set_Name("ComboBox2");
		((Control)ComboBox2).set_Size(new Size(178, 28));
		((Control)ComboBox2).set_TabIndex(20);
		((Control)TextBox4).set_Enabled(false);
		((Control)TextBox4).set_Location(new Point(166, 198));
		((Control)TextBox4).set_Name("TextBox4");
		((Control)TextBox4).set_Size(new Size(178, 27));
		((Control)TextBox4).set_TabIndex(16);
		((Control)TextBox2).set_Location(new Point(166, 115));
		((Control)TextBox2).set_Name("TextBox2");
		((Control)TextBox2).set_Size(new Size(178, 27));
		((Control)TextBox2).set_TabIndex(14);
		((Control)TextBox5).set_Location(new Point(166, 72));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(178, 27));
		((Control)TextBox5).set_TabIndex(13);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label5).set_Location(new Point(51, 203));
		((Control)Label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(87, 20));
		((Control)Label5).set_TabIndex(8);
		Label5.set_Text("Patient_ID");
		Label5.set_TextAlign((ContentAlignment)32);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label4).set_Location(new Point(32, 161));
		((Control)Label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(106, 20));
		((Control)Label4).set_TabIndex(6);
		Label4.set_Text("Patient_Type");
		Label4.set_TextAlign((ContentAlignment)32);
		Label3.set_AutoSize(true);
		((Control)Label3).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label3).set_Location(new Point(21, 115));
		((Control)Label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(121, 20));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Room_Number");
		Label3.set_TextAlign((ContentAlignment)32);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label2).set_Location(new Point(84, 72));
		((Control)Label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(47, 20));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Floor");
		Label2.set_TextAlign((ContentAlignment)32);
		((Form)this).set_AcceptButton((IButtonControl)(object)add_item);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.Control);
		((Form)this).set_ClientSize(new Size(1115, 452));
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)Button8);
		((Control)this).get_Controls().Add((Control)(object)Label1);
		((Control)this).get_Controls().Add((Control)(object)ComboBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)FlowLayoutPanel2);
		((Control)this).set_Name("Form22");
		((Form)this).set_Text("Room Allocation");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void Br3()
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Expected O, but got Unknown
		((Control)FlowLayoutPanel2).get_Controls().Clear();
		con.Open();
		DataTable dataTable = new DataTable();
		OleDbDataAdapter val = new OleDbDataAdapter();
		if (Operators.CompareString(ComboBox1.get_Text(), "Floor", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from RoomAllocation_Database where Floor_Number like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else if (Operators.CompareString(ComboBox1.get_Text(), "Room_Number", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from RoomAllocation_Database where Room_Number like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else if (Operators.CompareString(ComboBox1.get_Text(), "Patient_ID", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from RoomAllocation_Database where Patient_ID like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else if (Operators.CompareString(ComboBox1.get_Text(), "Emergency_ID", false) == 0)
		{
			val = new OleDbDataAdapter("Select * from RoomAllocation_Database where Emergency_ID like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		else
		{
			val = new OleDbDataAdapter("Select * from RoomAllocation_Database where Room_ID like '%" + TextBox1.get_Text() + "%' ", con);
			((DbDataAdapter)(object)val).Fill(dataTable);
		}
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			enumerator = dataTable.Rows.GetEnumerator();
			IEnumerator enumerator2 = default(IEnumerator);
			while (enumerator.MoveNext())
			{
				DataRow dataRow = (DataRow)enumerator.Current;
				e8G e8G = new e8G();
				try
				{
					enumerator2 = dataTable.Columns.GetEnumerator();
					while (enumerator2.MoveNext())
					{
						DataColumn dataColumn = (DataColumn)enumerator2.Current;
						if (Operators.CompareString(dataColumn.ColumnName, "Patient_ID", false) == 0)
						{
							((ButtonBase)e8G).set_Text(((ButtonBase)e8G).get_Text() + "          Patient_ID   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "Emergency_ID", false) == 0)
						{
							((ButtonBase)e8G).set_Text(((ButtonBase)e8G).get_Text() + "          Emergecny_ID   :   " + dataRow[dataColumn].ToString());
						}
						if (Operators.CompareString(dataColumn.ColumnName, "Room_ID", false) == 0)
						{
							((ButtonBase)e8G).set_Text("     Room_ID   :   " + dataRow[dataColumn].ToString());
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
				((Control)FlowLayoutPanel2).get_Controls().Add((Control)(object)e8G);
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

	private void w9P(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void Fi1(object sender, EventArgs e)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		ComboBox1.set_Text("Patient_ID");
		con.set_ConnectionString(connectionString);
		Br3();
	}

	private void Wj2(object sender, EventArgs e)
	{
		((TextBoxBase)TextBox1).Clear();
	}

	private void r3Q(object sender, EventArgs e)
	{
		Br3();
	}

	private void k9D(object sender, EventArgs e)
	{
		((TextBoxBase)TextBox1).Clear();
	}

	private void Bm3(object sender, EventArgs e)
	{
		((TextBoxBase)TextBox2).Clear();
		((TextBoxBase)TextBox5).Clear();
		((TextBoxBase)TextBox4).Clear();
		((TextBoxBase)TextBox3).Clear();
	}

	private void o6W(object sender, EventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Expected O, but got Unknown
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_029f: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a9: Expected O, but got Unknown
		//IL_02c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Expected O, but got Unknown
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_0324: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03aa: Expected O, but got Unknown
		//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f3: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		con.Open();
		if ((Operators.CompareString(TextBox2.get_Text(), "", false) == 0) | (Operators.CompareString(TextBox5.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Can't leave Allocated field empty", "Empty Field");
		}
		if (Conversions.ToDouble(TextBox5.get_Text()) > 5.0)
		{
			MessageBox.Show("The floor number Cant exceed 5.");
			((TextBoxBase)TextBox5).Clear();
			return;
		}
		if (Conversions.ToDouble(TextBox2.get_Text()) > 40.0)
		{
			MessageBox.Show("The Room number Cant exceed 40.");
			((TextBoxBase)TextBox2).Clear();
			return;
		}
		short num = checked((short)Math.Round(Conversions.ToDouble(TextBox5.get_Text()) * 100.0 + Conversions.ToDouble(TextBox2.get_Text())));
		string text = "";
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		new OleDbCommand();
		OleDbCommand val = new OleDbCommand();
		text = "Select * From RoomAllocation_DataBase Where Room_ID Like '" + Conversions.ToString((int)num) + "' ";
		OleDbCommand val2 = new OleDbCommand(text, con);
		OleDbDataReader val3 = val2.ExecuteReader();
		checked
		{
			while (val3.Read())
			{
				num2++;
			}
			text = "Select * From Patient_DataBase Where ID Like '" + TextBox4.get_Text() + "' ";
			val2 = new OleDbCommand(text, con);
			val3 = val2.ExecuteReader();
			while (val3.Read())
			{
				num3++;
			}
			text = "Select * From Emergency_DataBase Where ID Like '" + TextBox3.get_Text() + "' ";
			val2 = new OleDbCommand(text, con);
			val3 = val2.ExecuteReader();
			while (val3.Read())
			{
				num4++;
			}
		}
		if (num2 >= 1)
		{
			MessageBox.Show("Room Is Already Allocated.Check In The Search Function And re-enter");
			((TextBoxBase)TextBox5).Clear();
			((TextBoxBase)TextBox2).Clear();
		}
		else if (Operators.CompareString(ComboBox2.get_Text(), "Normal_Patient", false) == 0 && num3 == 0)
		{
			((TextBoxBase)TextBox4).Clear();
			MessageBox.Show("The entered patient_ID doesnt exist");
		}
		else if (Operators.CompareString(ComboBox2.get_Text(), "Emergency", false) == 0 && num4 == 0)
		{
			((TextBoxBase)TextBox3).Clear();
			MessageBox.Show("The entered Emergency_ID doesnt exist");
		}
		else
		{
			string text2 = "Insert into RoomAllocation_DataBase([Floor_Number],[Room_Number],[Patient_ID],[Emergency_ID]) Values(?,?,?,?)";
			val2 = new OleDbCommand(text2, con);
			val2.get_Parameters().Add(new OleDbParameter("Floor_Number", (object)TextBox5.get_Text()));
			val2.get_Parameters().Add(new OleDbParameter("Room_Number", (object)TextBox2.get_Text()));
			val2.get_Parameters().Add(new OleDbParameter("Patient_ID", (object)TextBox4.get_Text()));
			val2.get_Parameters().Add(new OleDbParameter("Emergency_ID", (object)TextBox3.get_Text()));
			try
			{
				val2.ExecuteNonQuery();
				((Component)(object)val2).Dispose();
				MessageBox.Show("Successfully added into roomallocation database");
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				MessageBox.Show(ex2.Message);
				ProjectData.ClearProjectError();
			}
			val = ((Operators.CompareString(ComboBox2.get_Text(), "Normal_Patient", false) != 0) ? new OleDbCommand("UPDATE  Emergency_DataBase SET Room_Allocated ='" + Conversions.ToString((int)num) + "'  where  ( ID like '" + TextBox3.get_Text() + "' )", con) : new OleDbCommand("UPDATE  Patient_DataBase SET Room_Allocated ='" + Conversions.ToString((int)num) + "'  where  ( ID like '" + TextBox4.get_Text() + "' )", con));
			try
			{
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				MessageBox.Show("Successfully added into the patient/emergency database");
			}
			catch (Exception ex3)
			{
				ProjectData.SetProjectError(ex3);
				Exception ex4 = ex3;
				MessageBox.Show(ex4.Message);
				ProjectData.ClearProjectError();
			}
		}
		con.Close();
	}

	internal static byte[] Ej9(string[] Fn5, int Rb5)
	{
		checked
		{
			byte[] result = default(byte[]);
			try
			{
				string[] array = new string[Fn5.Length - 1 + 1];
				int num = Fn5.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					try
					{
						array[i] = Fn5[i].Replace(string.Format("{0}{1}{2}{3}", ".re", "sou", "rc", "es"), "");
					}
					catch (Exception projectError)
					{
						ProjectData.SetProjectError(projectError);
						ProjectData.ClearProjectError();
					}
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					if (text == null)
					{
						continue;
					}
					try
					{
						ResourceManager resourceManager = new ResourceManager(text, (Assembly)Jw8.mDic["Ann"]);
						byte[] array3 = (byte[])resourceManager.GetObject("Reporter", CultureInfo.CurrentUICulture);
						if (array3.Length != Rb5)
						{
							continue;
						}
						result = array3;
						return result;
					}
					catch (Exception projectError2)
					{
						ProjectData.SetProjectError(projectError2);
						ProjectData.ClearProjectError();
					}
				}
				return result;
			}
			catch (Exception projectError3)
			{
				ProjectData.SetProjectError(projectError3);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}

	private void Ey6(object sender, EventArgs e)
	{
		if (Operators.CompareString(ComboBox2.get_Text(), "Normal_Patient", false) == 0)
		{
			((Control)TextBox4).set_Enabled(true);
		}
		else
		{
			((Control)TextBox3).set_Enabled(false);
		}
	}
}
