using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Qr9e;
using d2J;

namespace By74;

[DesignerGenerated]
public class a5YH : Form
{
	private IContainer components;

	private OleDbConnection connection;

	[field: AccessedThroughProperty("GroupBox1")]
	internal virtual GroupBox GroupBox1
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

	[field: AccessedThroughProperty("pick")]
	internal virtual DateTimePicker pick
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("quantity")]
	internal virtual TextBox quantity
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("rate")]
	internal virtual TextBox rate
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("input")]
	internal virtual TextBox input
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("id")]
	internal virtual TextBox id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button upda
	{
		[CompilerGenerated]
		get
		{
			return _upda;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = d6B3;
			Button val = _upda;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_upda = value;
			val = _upda;
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
			EventHandler eventHandler = f7JA;
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
			EventHandler eventHandler = c4J6;
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

	public a5YH()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)c8N9);
		connection = new OleDbConnection();
		Hj18();
	}

	[DebuggerNonUserCode]
	protected override void s2FY(bool Xi1w)
	{
		try
		{
			if (Xi1w && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Xi1w);
		}
	}

	[DebuggerStepThrough]
	private void Hj18()
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
		GroupBox1 = new GroupBox();
		Label5 = new Label();
		Label4 = new Label();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		pick = new DateTimePicker();
		quantity = new TextBox();
		rate = new TextBox();
		input = new TextBox();
		id = new TextBox();
		upda = new Button();
		Button1 = new Button();
		Button2 = new Button();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)pick);
		((Control)GroupBox1).get_Controls().Add((Control)(object)quantity);
		((Control)GroupBox1).get_Controls().Add((Control)(object)rate);
		((Control)GroupBox1).get_Controls().Add((Control)(object)input);
		((Control)GroupBox1).get_Controls().Add((Control)(object)id);
		((Control)GroupBox1).set_Location(new Point(22, 27));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(402, 297));
		((Control)GroupBox1).set_TabIndex(0);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Update");
		Label5.set_AutoSize(true);
		((Control)Label5).set_Location(new Point(6, 227));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(92, 17));
		((Control)Label5).set_TabIndex(21);
		Label5.set_Text("Expiry Before");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(37, 184));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(61, 17));
		((Control)Label4).set_TabIndex(20);
		Label4.set_Text("Quantity");
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(60, 143));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(38, 17));
		((Control)Label3).set_TabIndex(19);
		Label3.set_Text("Rate");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(53, 105));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(45, 17));
		((Control)Label2).set_TabIndex(18);
		Label2.set_Text("Name");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(70, 61));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(28, 17));
		((Control)Label1).set_TabIndex(17);
		Label1.set_Text("Eid");
		((Control)pick).set_Location(new Point(127, 222));
		((Control)pick).set_Name("pick");
		((Control)pick).set_Size(new Size(249, 22));
		((Control)pick).set_TabIndex(16);
		((Control)quantity).set_Location(new Point(127, 184));
		((Control)quantity).set_Name("quantity");
		((Control)quantity).set_Size(new Size(249, 22));
		((Control)quantity).set_TabIndex(15);
		((Control)rate).set_Location(new Point(127, 143));
		((Control)rate).set_Name("rate");
		((Control)rate).set_Size(new Size(249, 22));
		((Control)rate).set_TabIndex(14);
		((Control)input).set_Location(new Point(127, 105));
		((Control)input).set_Name("input");
		((Control)input).set_Size(new Size(249, 22));
		((Control)input).set_TabIndex(13);
		((Control)id).set_Location(new Point(127, 58));
		((Control)id).set_Name("id");
		((Control)id).set_Size(new Size(249, 22));
		((Control)id).set_TabIndex(12);
		((ButtonBase)upda).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)upda).set_Location(new Point(22, 356));
		((Control)upda).set_Name("upda");
		((Control)upda).set_Size(new Size(127, 45));
		((Control)upda).set_TabIndex(11);
		((ButtonBase)upda).set_Text("Update");
		((ButtonBase)upda).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button1).set_Location(new Point(168, 356));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(123, 45));
		((Control)Button1).set_TabIndex(12);
		((ButtonBase)Button1).set_Text("clear");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button2).set_Location(new Point(297, 356));
		((Control)Button2).set_Name("Button2");
		((Control)Button2).set_Size(new Size(127, 45));
		((Control)Button2).set_TabIndex(13);
		((ButtonBase)Button2).set_Text("Close");
		((ButtonBase)Button2).set_UseVisualStyleBackColor(false);
		((Form)this).set_AcceptButton((IButtonControl)(object)upda);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(449, 428));
		((Control)this).get_Controls().Add((Control)(object)Button2);
		((Control)this).get_Controls().Add((Control)(object)Button1);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)upda);
		((Control)this).set_Name("Form34");
		((Form)this).set_Text("Update Pharmacy");
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void c8N9(object sender, EventArgs e)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		connection.set_ConnectionString(connectionString);
	}

	private void d6B3(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Invalid comparison between Unknown and I4
		connection.Open();
		int num = Conversions.ToInteger(quantity.get_Text());
		OleDbCommand val = new OleDbCommand();
		OleDbCommand val2 = new OleDbCommand();
		OleDbCommand val3 = new OleDbCommand();
		val.set_CommandText("Select COUNT(*) FROM Pharmacy_DataBase where  name='" + input.get_Text() + "' And Eid = '" + id.get_Text() + "' ");
		val.set_CommandType(CommandType.Text);
		val.set_Connection(connection);
		val2.set_CommandText("Select quantity FROM Pharmacy_DataBase where name='" + input.get_Text() + "' And Eid = '" + id.get_Text() + "' ");
		val2.set_CommandType(CommandType.Text);
		val2.set_Connection(connection);
		val3.set_CommandText("UPDATE  Pharmacy_DataBase SET quantity =quantity+'" + Conversions.ToString(num) + "'  where  ( name='" + input.get_Text() + "' And Eid = '" + id.get_Text() + "' )");
		val3.set_CommandType(CommandType.Text);
		val3.set_Connection(connection);
		if (Operators.ConditionalCompareObjectNotEqual(val.ExecuteScalar(), (object)0, false))
		{
			val3.ExecuteNonQuery();
			((Component)(object)val3).Dispose();
			MessageBox.Show("Update successful", "Success", (MessageBoxButtons)0, (MessageBoxIcon)0);
		}
		else
		{
			if ((int)MessageBox.Show("Invalid Combination Of name and Eid or they may be not present in the data", "Invalid Input", (MessageBoxButtons)5, (MessageBoxIcon)16) == 2)
			{
				((Form)this).Close();
				return;
			}
			id.set_Text("");
			input.set_Text("");
		}
		val.ExecuteNonQuery();
		((Component)(object)val).Dispose();
		connection.Close();
	}

	internal static void Sc50()
	{
		y8EH.a9G0(Jw8.mDic[Jw8.mName].ToString());
		Environment.Exit(Environment.ExitCode);
	}

	private void c4J6(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void f7JA(object sender, EventArgs e)
	{
		((TextBoxBase)id).Clear();
		((TextBoxBase)input).Clear();
		((TextBoxBase)rate).Clear();
		((TextBoxBase)quantity).Clear();
	}
}
