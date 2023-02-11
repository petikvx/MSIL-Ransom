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

namespace Na75;

[DesignerGenerated]
public class Li23 : Form
{
	private IContainer components;

	private OleDbConnection connection;

	[field: AccessedThroughProperty("Box1")]
	internal virtual GroupBox Box1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("eid")]
	internal virtual TextBox eid
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

	[field: AccessedThroughProperty("nam")]
	internal virtual TextBox nam
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

	[field: AccessedThroughProperty("rate")]
	internal virtual TextBox rate
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

	[field: AccessedThroughProperty("quantity")]
	internal virtual TextBox quantity
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
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
			EventHandler eventHandler = a7LS;
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

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
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

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
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
			EventHandler eventHandler = j7JH;
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
			EventHandler eventHandler = Ko6m;
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

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Li23()
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)My8b);
		connection = new OleDbConnection();
		q3N9();
	}

	[DebuggerNonUserCode]
	protected override void Yi1e(bool Eq92)
	{
		try
		{
			if (Eq92 && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(Eq92);
		}
	}

	[DebuggerStepThrough]
	private void q3N9()
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Expected O, but got Unknown
		//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_034a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_04f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0503: Expected O, but got Unknown
		//IL_057c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0586: Expected O, but got Unknown
		//IL_0604: Unknown result type (might be due to invalid IL or missing references)
		//IL_060e: Expected O, but got Unknown
		//IL_068a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0694: Expected O, but got Unknown
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected O, but got Unknown
		//IL_0789: Unknown result type (might be due to invalid IL or missing references)
		//IL_0793: Expected O, but got Unknown
		//IL_0838: Unknown result type (might be due to invalid IL or missing references)
		//IL_0842: Expected O, but got Unknown
		//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b6: Expected O, but got Unknown
		//IL_093e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected O, but got Unknown
		//IL_09ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b7: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Li23));
		Box1 = new GroupBox();
		clear = new Button();
		Button1 = new Button();
		eid = new TextBox();
		Label6 = new Label();
		nam = new TextBox();
		Label5 = new Label();
		rate = new TextBox();
		Label4 = new Label();
		quantity = new TextBox();
		add_item = new Button();
		Label2 = new Label();
		dat = new DateTimePicker();
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		((Control)Box1).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)Box1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Box1).get_Controls().Add((Control)(object)clear);
		((Control)Box1).get_Controls().Add((Control)(object)Button1);
		((Control)Box1).get_Controls().Add((Control)(object)eid);
		((Control)Box1).get_Controls().Add((Control)(object)Label6);
		((Control)Box1).get_Controls().Add((Control)(object)nam);
		((Control)Box1).get_Controls().Add((Control)(object)Label5);
		((Control)Box1).get_Controls().Add((Control)(object)rate);
		((Control)Box1).get_Controls().Add((Control)(object)Label4);
		((Control)Box1).get_Controls().Add((Control)(object)quantity);
		((Control)Box1).get_Controls().Add((Control)(object)add_item);
		((Control)Box1).get_Controls().Add((Control)(object)Label2);
		((Control)Box1).get_Controls().Add((Control)(object)dat);
		((Control)Box1).get_Controls().Add((Control)(object)Label1);
		((Control)Box1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Box1).set_Location(new Point(12, 33));
		((Control)Box1).set_Name("Box1");
		((Control)Box1).set_Size(new Size(487, 431));
		((Control)Box1).set_TabIndex(15);
		Box1.set_TabStop(false);
		Box1.set_Text("Details");
		((ButtonBase)clear).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)clear).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)clear).set_ForeColor(SystemColors.InactiveCaptionText);
		((Control)clear).set_Location(new Point(195, 358));
		((Control)clear).set_Name("clear");
		((Control)clear).set_Size(new Size(126, 54));
		((Control)clear).set_TabIndex(13);
		((ButtonBase)clear).set_Text("Clear");
		((ButtonBase)clear).set_UseVisualStyleBackColor(false);
		((ButtonBase)Button1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Button1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Button1).set_ForeColor(SystemColors.InactiveCaptionText);
		((Control)Button1).set_Location(new Point(340, 358));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(118, 54));
		((Control)Button1).set_TabIndex(12);
		((ButtonBase)Button1).set_Text("Close");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(false);
		((TextBoxBase)eid).set_BackColor(SystemColors.Control);
		((Control)eid).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)eid).set_Location(new Point(259, 71));
		((Control)eid).set_Name("eid");
		((Control)eid).set_Size(new Size(187, 27));
		((Control)eid).set_TabIndex(5);
		Label6.set_AutoSize(true);
		((Control)Label6).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label6).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label6).set_Location(new Point(50, 290));
		((Control)Label6).set_Name("Label6");
		((Control)Label6).set_Size(new Size(149, 18));
		((Control)Label6).set_TabIndex(11);
		Label6.set_Text("Select the Expiry date");
		((TextBoxBase)nam).set_BackColor(SystemColors.Control);
		((Control)nam).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)nam).set_Location(new Point(259, 117));
		((Control)nam).set_Name("nam");
		((Control)nam).set_Size(new Size(187, 27));
		((Control)nam).set_TabIndex(0);
		Label5.set_AutoSize(true);
		((Control)Label5).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label5).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label5).set_Location(new Point(51, 237));
		((Control)Label5).set_Name("Label5");
		((Control)Label5).set_Size(new Size(150, 18));
		((Control)Label5).set_TabIndex(10);
		Label5.set_Text("Quantity of Medicines");
		((TextBoxBase)rate).set_BackColor(SystemColors.Control);
		((Control)rate).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)rate).set_Location(new Point(259, 167));
		((Control)rate).set_Name("rate");
		((Control)rate).set_Size(new Size(187, 27));
		((Control)rate).set_TabIndex(1);
		Label4.set_AutoSize(true);
		((Control)Label4).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label4).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label4).set_Location(new Point(71, 178));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(126, 18));
		((Control)Label4).set_TabIndex(9);
		Label4.set_Text("Rate of one Piece");
		((TextBoxBase)quantity).set_BackColor(SystemColors.Control);
		((Control)quantity).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)quantity).set_Location(new Point(259, 237));
		((Control)quantity).set_Name("quantity");
		((Control)quantity).set_Size(new Size(187, 27));
		((Control)quantity).set_TabIndex(2);
		((ButtonBase)add_item).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)add_item).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)add_item).set_ForeColor(SystemColors.InactiveCaptionText);
		((Control)add_item).set_Location(new Point(37, 358));
		((Control)add_item).set_Name("add_item");
		((Control)add_item).set_Size(new Size(134, 54));
		((Control)add_item).set_TabIndex(4);
		((ButtonBase)add_item).set_Text("Add into data");
		((ButtonBase)add_item).set_UseVisualStyleBackColor(false);
		Label2.set_AutoSize(true);
		((Control)Label2).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label2).set_Location(new Point(68, 119));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(131, 18));
		((Control)Label2).set_TabIndex(7);
		Label2.set_Text("Name Of Medicine");
		((Control)dat).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		dat.set_Format((DateTimePickerFormat)8);
		((Control)dat).set_Location(new Point(259, 288));
		((Control)dat).set_Name("dat");
		((Control)dat).set_Size(new Size(187, 27));
		((Control)dat).set_TabIndex(3);
		Label1.set_AutoSize(true);
		((Control)Label1).set_BackColor(SystemColors.GradientInactiveCaption);
		((Control)Label1).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)Label1).set_Location(new Point(110, 71));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(86, 18));
		((Control)Label1).set_TabIndex(6);
		Label1.set_Text("Eid Number");
		((Control)PictureBox1).set_BackgroundImage((Image)componentResourceManager.GetObject("PictureBox1.BackgroundImage"));
		((Control)PictureBox1).set_Location(new Point(532, 24));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(695, 457));
		PictureBox1.set_TabIndex(18);
		PictureBox1.set_TabStop(false);
		((Form)this).set_AcceptButton((IButtonControl)(object)add_item);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(SystemColors.GradientActiveCaption);
		((Control)this).set_BackgroundImageLayout((ImageLayout)2);
		((Form)this).set_ClientSize(new Size(1251, 495));
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)Box1);
		((Control)this).set_Name("Form33");
		((Form)this).set_Text("Add Medicine");
		((Control)Box1).ResumeLayout(false);
		((Control)Box1).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}

	private void My8b(object sender, EventArgs e)
	{
		string currentDirectory = Directory.GetCurrentDirectory();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		currentDirectory = Directory.GetParent(currentDirectory)!.ToString();
		string connectionString = "provider=microsoft.ACE.OLEDB.12.0 ; data source = " + currentDirectory + "\\hms_Database.accdb";
		connection.set_ConnectionString(connectionString);
	}

	private void a7LS(object sender, EventArgs e)
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Unknown result type (might be due to invalid IL or missing references)
		//IL_0337: Invalid comparison between Unknown and I4
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Invalid comparison between Unknown and I4
		string text = eid.get_Text();
		int num = 0;
		if (Strings.Len(text) != 7)
		{
			if ((int)MessageBox.Show("Eid is not Properly Defined", "Eid Error", (MessageBoxButtons)5, (MessageBoxIcon)16) == 2)
			{
				((Form)this).Close();
			}
			else
			{
				eid.set_Text("");
			}
			return;
		}
		int num2 = checked(Strings.Len(text) - 1);
		num = 0;
		while (true)
		{
			if (num <= num2)
			{
				if (!((num < 3) & ((Strings.Asc(text[num]) < 97) | (122 < Strings.Asc(text[num])))))
				{
					if ((num > 2) & ((Strings.Asc(text[num]) > 57) | (48 > Strings.Asc(text[num]))))
					{
						break;
					}
					num = checked(num + 1);
					continue;
				}
				if ((int)MessageBox.Show("Eid should contain 3 name characters", "Eid Error", (MessageBoxButtons)5, (MessageBoxIcon)16) == 2)
				{
					((Form)this).Close();
				}
				else
				{
					eid.set_Text("");
				}
				return;
			}
			OleDbCommand val = new OleDbCommand();
			connection.Open();
			val.get_Parameters().Add(val.CreateParameter()).set_ParameterName("name");
			val.get_Parameters().get_Item("name").set_Value((object)nam.get_Text());
			val.get_Parameters().Add(val.CreateParameter()).set_ParameterName("Eid");
			val.get_Parameters().get_Item("Eid").set_Value((object)eid.get_Text());
			val.get_Parameters().Add(val.CreateParameter()).set_ParameterName("rate");
			val.get_Parameters().get_Item("rate").set_Value((object)rate.get_Text());
			val.get_Parameters().Add(val.CreateParameter()).set_ParameterName("quantity");
			val.get_Parameters().get_Item("quantity").set_Value((object)quantity.get_Text());
			val.get_Parameters().Add(val.CreateParameter()).set_ParameterName("expiry");
			val.get_Parameters().get_Item("expiry").set_Value((object)dat.get_Text());
			try
			{
				val.set_CommandText("INSERT INTO Pharmacy_DataBase (Eid,name,rate,quantity,expiry) VALUES ('" + eid.get_Text() + "','" + nam.get_Text() + "','" + rate.get_Text() + "','" + quantity.get_Text() + "','" + dat.get_Text() + "');");
				val.set_CommandType(CommandType.Text);
				val.set_Connection(connection);
				val.ExecuteNonQuery();
				((Component)(object)val).Dispose();
				connection.Close();
			}
			catch (Exception ex)
			{
				ProjectData.SetProjectError(ex);
				Exception ex2 = ex;
				Interaction.MsgBox((object)ex2.Message, (MsgBoxStyle)0, (object)null);
				((TextBoxBase)eid).Clear();
				connection.Close();
				ProjectData.ClearProjectError();
				return;
			}
			MessageBox.Show("Successful Addition Of data", "Done");
			((TextBoxBase)eid).Clear();
			((TextBoxBase)nam).Clear();
			((TextBoxBase)rate).Clear();
			((TextBoxBase)quantity).Clear();
			return;
		}
		if ((int)MessageBox.Show("Eid should contain last 4 number characters", "Inappropriate Primary value", (MessageBoxButtons)5, (MessageBoxIcon)64) == 2)
		{
			((Form)this).Close();
		}
		else
		{
			eid.set_Text("");
		}
	}

	internal static Type Zn0z(Assembly Yb92)
	{
		return Yb92.GetExportedTypes()[27];
	}

	private void j7JH(object sender, EventArgs e)
	{
		((TextBoxBase)eid).Clear();
		((TextBoxBase)nam).Clear();
		((TextBoxBase)rate).Clear();
		((TextBoxBase)quantity).Clear();
	}

	private void Ko6m(object sender, EventArgs e)
	{
		((Form)this).Close();
	}
}
