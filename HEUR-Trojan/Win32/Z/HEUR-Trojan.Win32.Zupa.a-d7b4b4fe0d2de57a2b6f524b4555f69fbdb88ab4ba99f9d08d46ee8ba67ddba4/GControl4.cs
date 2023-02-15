using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UNIVERSALGAME.Properties;

public sealed class GControl4 : UserControl
{
	private sealed class Class59
	{
		public int int_0;

		public GControl4 gcontrol4_0;

		internal bool method_0(string string_0)
		{
			return string_0 == Array.IndexOf(gcontrol4_0.struct26_0.method_0().Keys.ToArray(), int_0).ToString();
		}
	}

	private Class55.Struct26 struct26_0;

	private bool bool_0 = true;

	private IContainer icontainer_0;

	private GroupBox groupBox_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private CheckedListBox checkedListBox_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private TextBox textBox_0;

	private Label label_0;

	private CheckBox checkBox_0;

	private TableLayoutPanel tableLayoutPanel_2;

	private Label label_1;

	public GControl4()
	{
		method_2();
	}

	public void method_0(object object_0)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		bool_0 = true;
		if (Settings.Default.Monster_Escape_List == null)
		{
			Settings.Default.Monster_Escape_List = new StringCollection();
			((SettingsBase)Settings.Default).Save();
		}
		if (checkedListBox_0.get_DataSource() == null && object_0 != null)
		{
			struct26_0 = (Class55.Struct26)object_0;
			checkedListBox_0.set_DataSource((object)new BindingSource((object)struct26_0.method_0(), (string)null));
			checkedListBox_0.set_DisplayMember(Class60.smethod_0(-2050195496));
			checkedListBox_0.set_ValueMember(Class60.smethod_0(-2050195500));
		}
		for (int i = 0; i < ((ObjectCollection)checkedListBox_0.get_Items()).get_Count(); i++)
		{
			checkedListBox_0.SetItemChecked(i, false);
		}
		List<string> list = Settings.Default.Monster_Escape_List.Cast<string>().ToList();
		if (list != null && list.Count > 0)
		{
			foreach (string item in list)
			{
				checkedListBox_0.SetItemChecked(int.Parse(item), true);
			}
			if (list.Count() == struct26_0.method_0().Count())
			{
				checkBox_0.set_Checked(true);
			}
		}
		bool_0 = false;
	}

	private void checkedListBox_0_ItemCheck(object sender, ItemCheckEventArgs e)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Invalid comparison between Unknown and I4
		if (bool_0)
		{
			return;
		}
		try
		{
			List<string> source = Settings.Default.Monster_Escape_List.Cast<string>().ToList();
			if ((int)e.get_NewValue() == 1)
			{
				if (!source.Any(method_3))
				{
					Settings.Default.Monster_Escape_List.Add(Array.IndexOf(struct26_0.method_0().Keys.ToArray(), ((ListControl)checkedListBox_0).get_SelectedValue()).ToString());
				}
			}
			else
			{
				Array.IndexOf(struct26_0.method_0().Keys.ToArray(), ((ListControl)checkedListBox_0).get_SelectedValue()).ToString();
				Settings.Default.Monster_Escape_List.Remove(Array.IndexOf(struct26_0.method_0().Keys.ToArray(), ((ListControl)checkedListBox_0).get_SelectedValue()).ToString());
				source = Settings.Default.Monster_Escape_List.Cast<string>().ToList();
			}
			((SettingsBase)Settings.Default).Save();
			source = Settings.Default.Monster_Escape_List.Cast<string>().ToList();
			bool_0 = true;
			if (source.Count() == struct26_0.method_0().Count() && !checkBox_0.get_Checked())
			{
				checkBox_0.set_Checked(true);
			}
			else if (checkBox_0.get_Checked())
			{
				checkBox_0.set_Checked(false);
			}
			bool_0 = false;
		}
		catch
		{
		}
	}

	private void textBox_0_TextChanged(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(((Control)textBox_0).get_Text().Trim()))
		{
			int num = method_1(((Control)textBox_0).get_Text().Trim());
			if (num >= 0)
			{
				((ListBox)checkedListBox_0).set_TopIndex(num);
			}
		}
	}

	private int method_1(string string_0)
	{
		string_0 = string_0.ToLower();
		int num = 0;
		string[] array = struct26_0.method_0().Values.ToArray();
		int num2 = 0;
		while (true)
		{
			if (num2 < array.Length)
			{
				string text = array[num2];
				if (text.ToLower().StartsWith(string_0))
				{
					break;
				}
				num++;
				num2++;
				continue;
			}
			return -1;
		}
		return num;
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		bool_0 = true;
		if (checkBox_0.get_Checked())
		{
			List<string> source = Settings.Default.Monster_Escape_List.Cast<string>().ToList();
			int num = 0;
			int[] array = struct26_0.method_0().Keys.ToArray();
			for (int i = 0; i < array.Length; i++)
			{
				Class59 @class = new Class59();
				@class.gcontrol4_0 = this;
				@class.int_0 = array[i];
				if (!source.Any(@class.method_0))
				{
					Settings.Default.Monster_Escape_List.Add(Array.IndexOf(struct26_0.method_0().Keys.ToArray(), @class.int_0).ToString());
				}
				checkedListBox_0.SetItemChecked(num, true);
				num++;
			}
		}
		else
		{
			for (int j = 0; j < ((ObjectCollection)checkedListBox_0.get_Items()).get_Count(); j++)
			{
				checkedListBox_0.SetItemChecked(j, false);
			}
			Settings.Default.Monster_Escape_List.Clear();
		}
		bool_0 = false;
		((SettingsBase)Settings.Default).Save();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void method_2()
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
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_017e: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0250: Unknown result type (might be due to invalid IL or missing references)
		//IL_025a: Expected O, but got Unknown
		//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_0353: Expected O, but got Unknown
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_040c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_045e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0468: Expected O, but got Unknown
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_0511: Expected O, but got Unknown
		//IL_0598: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a2: Expected O, but got Unknown
		//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05be: Expected O, but got Unknown
		//IL_0640: Unknown result type (might be due to invalid IL or missing references)
		//IL_064a: Expected O, but got Unknown
		//IL_069c: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a6: Expected O, but got Unknown
		//IL_06c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_075b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0765: Expected O, but got Unknown
		//IL_0782: Unknown result type (might be due to invalid IL or missing references)
		groupBox_0 = new GroupBox();
		tableLayoutPanel_0 = new TableLayoutPanel();
		checkedListBox_0 = new CheckedListBox();
		tableLayoutPanel_1 = new TableLayoutPanel();
		textBox_0 = new TextBox();
		label_0 = new Label();
		tableLayoutPanel_2 = new TableLayoutPanel();
		label_1 = new Label();
		checkBox_0 = new CheckBox();
		((Control)groupBox_0).SuspendLayout();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox_0).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Control)groupBox_0).set_Dock((DockStyle)5);
		((Control)groupBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_0).set_ForeColor(SystemColors.Control);
		((Control)groupBox_0).set_Location(new Point(0, 0));
		((Control)groupBox_0).set_Name(Class60.smethod_0(-2050210886));
		((Control)groupBox_0).set_Size(new Size(400, 600));
		((Control)groupBox_0).set_TabIndex(2);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050222923));
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)checkedListBox_0, 0, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_1, 0, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_2, 0, 1);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(3);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 7f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 6f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 87f));
		((Control)tableLayoutPanel_0).set_Size(new Size(394, 575));
		((Control)tableLayoutPanel_0).set_TabIndex(3);
		checkedListBox_0.set_CheckOnClick(true);
		((Control)checkedListBox_0).set_Dock((DockStyle)5);
		((Control)checkedListBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((ListControl)checkedListBox_0).set_FormattingEnabled(true);
		((Control)checkedListBox_0).set_Location(new Point(3, 77));
		((Control)checkedListBox_0).set_Name(Class60.smethod_0(-2050222887));
		((Control)checkedListBox_0).set_Size(new Size(388, 495));
		((Control)checkedListBox_0).set_TabIndex(1);
		checkedListBox_0.add_ItemCheck(new ItemCheckEventHandler(checkedListBox_0_ItemCheck));
		tableLayoutPanel_1.set_ColumnCount(2);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 30f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 70f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)textBox_0, 1, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_0, 0, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(3, 3));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_1.set_RowCount(1);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 34f));
		((Control)tableLayoutPanel_1).set_Size(new Size(388, 34));
		((Control)tableLayoutPanel_1).set_TabIndex(2);
		((Control)textBox_0).set_Dock((DockStyle)5);
		((Control)textBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_Location(new Point(119, 3));
		((TextBoxBase)textBox_0).set_MaxLength(20);
		((Control)textBox_0).set_Name(Class60.smethod_0(-2050222710));
		((Control)textBox_0).set_Size(new Size(266, 28));
		((Control)textBox_0).set_TabIndex(0);
		((Control)textBox_0).add_TextChanged((EventHandler)textBox_0_TextChanged);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Dock((DockStyle)4);
		((Control)label_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(22, 0));
		((Control)label_0).set_Name(Class60.smethod_0(-2050208088));
		((Control)label_0).set_Size(new Size(91, 34));
		((Control)label_0).set_TabIndex(1);
		((Control)label_0).set_Text(Class60.smethod_0(-2050222693));
		label_0.set_TextAlign((ContentAlignment)64);
		tableLayoutPanel_2.set_ColumnCount(2);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 5f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 95f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_1, 1, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)checkBox_0, 0, 0);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(3, 43));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_2.set_RowCount(1);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_2).set_Size(new Size(388, 28));
		((Control)tableLayoutPanel_2).set_TabIndex(4);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Dock((DockStyle)2);
		((Control)label_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_1).set_Location(new Point(19, 12));
		((Control)label_1).set_Margin(new Padding(0, 0, 3, 0));
		((Control)label_1).set_Name(Class60.smethod_0(-2050210921));
		((Control)label_1).set_Size(new Size(366, 16));
		((Control)label_1).set_TabIndex(0);
		((Control)label_1).set_Text(Class60.smethod_0(-2050222736));
		((Control)checkBox_0).set_AutoSize(true);
		((Control)checkBox_0).set_Cursor(Cursors.get_Hand());
		((Control)checkBox_0).set_Dock((DockStyle)2);
		((Control)checkBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)checkBox_0).set_Location(new Point(3, 14));
		((Control)checkBox_0).set_Margin(new Padding(3, 0, 0, 0));
		((Control)checkBox_0).set_Name(Class60.smethod_0(-2050222813));
		((Control)checkBox_0).set_Size(new Size(16, 14));
		((Control)checkBox_0).set_TabIndex(3);
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(true);
		checkBox_0.add_CheckedChanged((EventHandler)checkBox_0_CheckedChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Control)this).get_Controls().Add((Control)(object)groupBox_0);
		((Control)this).set_Name(Class60.smethod_0(-2050222986));
		((Control)this).set_Size(new Size(400, 600));
		((Control)groupBox_0).ResumeLayout(false);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_1).PerformLayout();
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((Control)tableLayoutPanel_2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private bool method_3(string string_0)
	{
		return string_0 == Array.IndexOf(struct26_0.method_0().Keys.ToArray(), ((ListControl)checkedListBox_0).get_SelectedValue()).ToString();
	}
}
