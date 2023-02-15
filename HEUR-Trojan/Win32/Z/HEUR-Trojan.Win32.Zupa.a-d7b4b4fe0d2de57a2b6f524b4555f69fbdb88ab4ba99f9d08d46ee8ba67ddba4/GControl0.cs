using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using UNIVERSALGAME.Properties;

public sealed class GControl0 : UserControl
{
	public GClass14 gclass14_0;

	public GClass12 gclass12_0;

	public IntPtr intptr_0;

	public int int_0;

	public int int_1;

	private Class55.Struct25 struct25_0;

	private bool bool_0 = true;

	private int[] int_2 = new int[3600];

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private GroupBox groupBox_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private GroupBox groupBox_1;

	private TableLayoutPanel tableLayoutPanel_2;

	private Label label_0;

	private ComboBox comboBox_0;

	private Label label_1;

	private GroupBox groupBox_2;

	private TableLayoutPanel tableLayoutPanel_3;

	private Label label_2;

	private ComboBox comboBox_1;

	private Label label_3;

	private Label label_4;

	private Label label_5;

	private Label label_6;

	private Label label_7;

	private Label label_8;

	private Label label_9;

	private Label label_10;

	private Label label_11;

	private Label label_12;

	private Label label_13;

	private ComboBox comboBox_2;

	private ComboBox comboBox_3;

	private ComboBox comboBox_4;

	private ComboBox comboBox_5;

	private ComboBox comboBox_6;

	private Button button_0;

	private Button button_1;

	private Button button_2;

	private Label label_14;

	private GroupBox groupBox_3;

	private TableLayoutPanel tableLayoutPanel_4;

	private Label label_15;

	private ComboBox comboBox_7;

	private Label label_16;

	private Label label_17;

	private Label label_18;

	private Label label_19;

	private Label label_20;

	private ComboBox comboBox_8;

	private ComboBox comboBox_9;

	private ComboBox comboBox_10;

	private Label label_21;

	private Label label_22;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private TextBox textBox_2;

	private TextBox textBox_3;

	private ComboBox comboBox_11;

	private ComboBox comboBox_12;

	private ComboBox comboBox_13;

	private ComboBox comboBox_14;

	private GroupBox groupBox_4;

	private TableLayoutPanel tableLayoutPanel_5;

	private ComboBox comboBox_15;

	private Button button_3;

	private ComboBox comboBox_16;

	private Label label_23;

	private TableLayoutPanel tableLayoutPanel_6;

	private TableLayoutPanel tableLayoutPanel_7;

	private Label label_24;

	private ComboBox comboBox_17;

	public GControl0()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_024b: Expected O, but got Unknown
		method_1();
		struct25_0.method_44();
		for (int i = 1; i <= 3600; i++)
		{
			int_2[i - 1] = i;
		}
		comboBox_0.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_16.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_5.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_6.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_1.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_2.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_3.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_4.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_7.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_8.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_9.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_10.set_DataSource((object)new BindingSource((object)int_2, (string)null));
		comboBox_12.set_DataSource((object)new BindingSource((object)struct25_0.method_43(), (string)null));
		((ListControl)comboBox_12).set_DisplayMember(Class60.smethod_0(-2050195496));
		((ListControl)comboBox_12).set_ValueMember(Class60.smethod_0(-2050195500));
		comboBox_13.set_DataSource((object)new BindingSource((object)struct25_0.method_43(), (string)null));
		((ListControl)comboBox_13).set_DisplayMember(Class60.smethod_0(-2050195496));
		((ListControl)comboBox_13).set_ValueMember(Class60.smethod_0(-2050195500));
		comboBox_14.set_DataSource((object)new BindingSource((object)struct25_0.method_43(), (string)null));
		((ListControl)comboBox_14).set_DisplayMember(Class60.smethod_0(-2050195496));
		((ListControl)comboBox_14).set_ValueMember(Class60.smethod_0(-2050195500));
		comboBox_11.set_DataSource((object)new BindingSource((object)struct25_0.method_43(), (string)null));
		((ListControl)comboBox_11).set_DisplayMember(Class60.smethod_0(-2050195496));
		((ListControl)comboBox_11).set_ValueMember(Class60.smethod_0(-2050195500));
	}

	public void method_0()
	{
		try
		{
			if (int_0 == 0)
			{
				((ListControl)comboBox_0).set_SelectedIndex(Settings.Default.AB_Freq);
				((ListControl)comboBox_15).set_SelectedIndex(Settings.Default.ATK_Skill_Mode);
				((ListControl)comboBox_17).set_SelectedIndex(Settings.Default.ATK_Floor_Skill_Mode);
				((ListControl)comboBox_16).set_SelectedIndex(Settings.Default.ATK_Floor_Freq);
				((ListControl)comboBox_5).set_SelectedIndex(Settings.Default.SKILLBUFF_1_Freq);
				((ListControl)comboBox_6).set_SelectedIndex(Settings.Default.SKILLBUFF_2_Freq);
				((ListControl)comboBox_1).set_SelectedIndex(Settings.Default.SKILLBUFF_3_Freq);
				((ListControl)comboBox_2).set_SelectedIndex(Settings.Default.SKILLBUFF_4_Freq);
				((ListControl)comboBox_3).set_SelectedIndex(Settings.Default.SKILLBUFF_5_Freq);
				((ListControl)comboBox_4).set_SelectedIndex(Settings.Default.SKILLBUFF_6_Freq);
				((ListControl)comboBox_12).set_SelectedValue((object)Settings.Default.SKILLBUFF_3);
				((ListControl)comboBox_13).set_SelectedValue((object)Settings.Default.SKILLBUFF_4);
				((ListControl)comboBox_14).set_SelectedValue((object)Settings.Default.SKILLBUFF_5);
				((ListControl)comboBox_11).set_SelectedValue((object)Settings.Default.SKILLBUFF_6);
				((ListControl)comboBox_7).set_SelectedIndex(Settings.Default.Macro1_Freq);
				((Control)textBox_1).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.Macro1_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_8).set_SelectedIndex(Settings.Default.Macro2_Freq);
				((Control)textBox_2).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.Macro2_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_9).set_SelectedIndex(Settings.Default.Macro3_Freq);
				((Control)textBox_3).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.Macro3_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_10).set_SelectedIndex(Settings.Default.Macro4_Freq);
				((Control)textBox_0).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.Macro4_Hotkey + Class60.smethod_0(-2050195546));
				if (Settings.Default.ATK_Skill > 0)
				{
					((Control)button_2).set_BackColor(Color.LightSeaGreen);
				}
				if (Settings.Default.ATK_Floor_Skill > 0)
				{
					((Control)button_3).set_BackColor(Color.LightSeaGreen);
				}
				if (Settings.Default.SKILLBUFF_1 > 1)
				{
					((Control)button_0).set_BackColor(Color.LightSeaGreen);
				}
				if (Settings.Default.SKILLBUFF_2 > 1)
				{
					((Control)button_1).set_BackColor(Color.LightSeaGreen);
				}
			}
			else if (int_0 == 1)
			{
				((ListControl)comboBox_0).set_SelectedIndex(Settings.Default._2_AB_Freq);
				((ListControl)comboBox_15).set_SelectedIndex(Settings.Default._2_ATK_Skill_Mode);
				((ListControl)comboBox_17).set_SelectedIndex(Settings.Default._2_ATK_Floor_Skill_Mode);
				((ListControl)comboBox_16).set_SelectedIndex(Settings.Default._2_ATK_Floor_Freq);
				((ListControl)comboBox_5).set_SelectedIndex(Settings.Default._2_SKILLBUFF_1_Freq);
				((ListControl)comboBox_6).set_SelectedIndex(Settings.Default._2_SKILLBUFF_2_Freq);
				((ListControl)comboBox_1).set_SelectedIndex(Settings.Default._2_SKILLBUFF_3_Freq);
				((ListControl)comboBox_2).set_SelectedIndex(Settings.Default._2_SKILLBUFF_4_Freq);
				((ListControl)comboBox_3).set_SelectedIndex(Settings.Default._2_SKILLBUFF_5_Freq);
				((ListControl)comboBox_4).set_SelectedIndex(Settings.Default._2_SKILLBUFF_6_Freq);
				((ListControl)comboBox_12).set_SelectedValue((object)Settings.Default._2_SKILLBUFF_3);
				((ListControl)comboBox_13).set_SelectedValue((object)Settings.Default._2_SKILLBUFF_4);
				((ListControl)comboBox_14).set_SelectedValue((object)Settings.Default._2_SKILLBUFF_5);
				((ListControl)comboBox_11).set_SelectedValue((object)Settings.Default._2_SKILLBUFF_6);
				((ListControl)comboBox_7).set_SelectedIndex(Settings.Default._2_Macro1_Freq);
				((Control)textBox_1).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._2_Macro1_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_8).set_SelectedIndex(Settings.Default._2_Macro2_Freq);
				((Control)textBox_2).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._2_Macro2_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_9).set_SelectedIndex(Settings.Default._2_Macro3_Freq);
				((Control)textBox_3).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._2_Macro3_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_10).set_SelectedIndex(Settings.Default._2_Macro4_Freq);
				((Control)textBox_0).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._2_Macro4_Hotkey + Class60.smethod_0(-2050195546));
				if (Settings.Default._2_ATK_Skill > 0)
				{
					((Control)button_2).set_BackColor(Color.LightSeaGreen);
				}
				if (Settings.Default._2_ATK_Floor_Skill > 0)
				{
					((Control)button_3).set_BackColor(Color.LightSeaGreen);
				}
				if (Settings.Default._2_SKILLBUFF_1 > 1)
				{
					((Control)button_0).set_BackColor(Color.LightSeaGreen);
				}
				if (Settings.Default._2_SKILLBUFF_2 > 1)
				{
					((Control)button_1).set_BackColor(Color.LightSeaGreen);
				}
			}
			else if (int_0 == 2)
			{
				((ListControl)comboBox_0).set_SelectedIndex(Settings.Default._3_AB_Freq);
				((ListControl)comboBox_15).set_SelectedIndex(Settings.Default._3_ATK_Skill_Mode);
				((ListControl)comboBox_17).set_SelectedIndex(Settings.Default._3_ATK_Floor_Skill_Mode);
				((ListControl)comboBox_16).set_SelectedIndex(Settings.Default._3_ATK_Floor_Freq);
				((ListControl)comboBox_5).set_SelectedIndex(Settings.Default._3_SKILLBUFF_1_Freq);
				((ListControl)comboBox_6).set_SelectedIndex(Settings.Default._3_SKILLBUFF_2_Freq);
				((ListControl)comboBox_1).set_SelectedIndex(Settings.Default._3_SKILLBUFF_3_Freq);
				((ListControl)comboBox_2).set_SelectedIndex(Settings.Default._3_SKILLBUFF_4_Freq);
				((ListControl)comboBox_3).set_SelectedIndex(Settings.Default._3_SKILLBUFF_5_Freq);
				((ListControl)comboBox_4).set_SelectedIndex(Settings.Default._3_SKILLBUFF_6_Freq);
				((ListControl)comboBox_12).set_SelectedValue((object)Settings.Default._3_SKILLBUFF_3);
				((ListControl)comboBox_13).set_SelectedValue((object)Settings.Default._3_SKILLBUFF_4);
				((ListControl)comboBox_14).set_SelectedValue((object)Settings.Default._3_SKILLBUFF_5);
				((ListControl)comboBox_11).set_SelectedValue((object)Settings.Default._3_SKILLBUFF_6);
				((ListControl)comboBox_7).set_SelectedIndex(Settings.Default._3_Macro1_Freq);
				((Control)textBox_1).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._3_Macro1_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_8).set_SelectedIndex(Settings.Default._3_Macro2_Freq);
				((Control)textBox_2).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._3_Macro2_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_9).set_SelectedIndex(Settings.Default._3_Macro3_Freq);
				((Control)textBox_3).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._3_Macro3_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_10).set_SelectedIndex(Settings.Default._3_Macro4_Freq);
				((Control)textBox_0).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._3_Macro4_Hotkey + Class60.smethod_0(-2050195546));
				if (Settings.Default._3_ATK_Skill > 0)
				{
					((Control)button_2).set_BackColor(Color.LightSeaGreen);
				}
				if (Settings.Default._3_ATK_Floor_Skill > 0)
				{
					((Control)button_3).set_BackColor(Color.LightSeaGreen);
				}
				if (Settings.Default._3_SKILLBUFF_1 > 1)
				{
					((Control)button_0).set_BackColor(Color.LightSeaGreen);
				}
				if (Settings.Default._3_SKILLBUFF_2 > 1)
				{
					((Control)button_1).set_BackColor(Color.LightSeaGreen);
				}
			}
			bool_0 = false;
		}
		catch
		{
		}
	}

	private void GControl0_Load(object sender, EventArgs e)
	{
		method_0();
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.AB_Freq = ((ListControl)comboBox_0).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_AB_Freq = ((ListControl)comboBox_0).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_AB_Freq = ((ListControl)comboBox_0).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_019e: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		if (gclass14_0 != null)
		{
			try
			{
				if (gclass14_0.method_9(gclass12_0.SKILL_ID) > 0)
				{
					if (int_0 == 0)
					{
						Settings.Default.ATK_Skill = gclass14_0.method_9(gclass12_0.SKILL_ID);
						Settings.Default.ATK_Skill_Lv = gclass14_0.method_9(gclass12_0.SKILL_LEVEL);
						((SettingsBase)Settings.Default).Save();
					}
					else if (int_0 == 1)
					{
						Settings.Default._2_ATK_Skill = gclass14_0.method_9(gclass12_0.SKILL_ID);
						Settings.Default._2_ATK_Skill_Lv = gclass14_0.method_9(gclass12_0.SKILL_LEVEL);
						((SettingsBase)Settings.Default).Save();
					}
					else if (int_0 == 2)
					{
						Settings.Default._3_ATK_Skill = gclass14_0.method_9(gclass12_0.SKILL_ID);
						Settings.Default._3_ATK_Skill_Lv = gclass14_0.method_9(gclass12_0.SKILL_LEVEL);
						((SettingsBase)Settings.Default).Save();
					}
					((Control)button_2).set_BackColor(Color.LightSeaGreen);
				}
				else
				{
					Form val = new Form();
					val.set_TopMost(true);
					MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050216067), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				return;
			}
			catch
			{
				((Control)button_2).set_BackColor(Color.DarkGray);
				return;
			}
		}
		Form val2 = new Form();
		val2.set_TopMost(true);
		MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050216182), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void comboBox_15_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.ATK_Skill_Mode = ((ListControl)comboBox_15).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_ATK_Skill_Mode = ((ListControl)comboBox_15).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_ATK_Skill_Mode = ((ListControl)comboBox_15).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_17_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.ATK_Floor_Skill_Mode = ((ListControl)comboBox_17).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_ATK_Floor_Skill_Mode = ((ListControl)comboBox_17).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_ATK_Floor_Skill_Mode = ((ListControl)comboBox_17).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_0209: Unknown result type (might be due to invalid IL or missing references)
		//IL_022c: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_026a: Expected O, but got Unknown
		//IL_0265: Unknown result type (might be due to invalid IL or missing references)
		if (gclass14_0 != null)
		{
			try
			{
				if (gclass14_0.method_9(gclass12_0.SKILL_ID) > 0)
				{
					if (int_0 == 0)
					{
						Settings.Default.ATK_Floor_Skill = gclass14_0.method_9(gclass12_0.SKILL_ID);
						Settings.Default.ATK_Floor_Skill_Lv = gclass14_0.method_9(gclass12_0.SKILL_LEVEL);
						Settings.Default.ATK_Floor_Skill_X = gclass14_0.method_9(gclass12_0.SKILL_FLOOR_X);
						Settings.Default.ATK_Floor_Skill_Y = gclass14_0.method_9(gclass12_0.SKILL_FLOOR_Y);
						((SettingsBase)Settings.Default).Save();
					}
					else if (int_0 == 1)
					{
						Settings.Default._2_ATK_Floor_Skill = gclass14_0.method_9(gclass12_0.SKILL_ID);
						Settings.Default._2_ATK_Floor_Skill_Lv = gclass14_0.method_9(gclass12_0.SKILL_LEVEL);
						Settings.Default._2_ATK_Floor_Skill_X = gclass14_0.method_9(gclass12_0.SKILL_FLOOR_X);
						Settings.Default._2_ATK_Floor_Skill_Y = gclass14_0.method_9(gclass12_0.SKILL_FLOOR_Y);
						((SettingsBase)Settings.Default).Save();
					}
					else if (int_0 == 2)
					{
						Settings.Default._3_ATK_Floor_Skill = gclass14_0.method_9(gclass12_0.SKILL_ID);
						Settings.Default._3_ATK_Floor_Skill_Lv = gclass14_0.method_9(gclass12_0.SKILL_LEVEL);
						Settings.Default._3_ATK_Floor_Skill_X = gclass14_0.method_9(gclass12_0.SKILL_FLOOR_X);
						Settings.Default._3_ATK_Floor_Skill_Y = gclass14_0.method_9(gclass12_0.SKILL_FLOOR_Y);
						((SettingsBase)Settings.Default).Save();
					}
					((Control)button_3).set_BackColor(Color.LightSeaGreen);
				}
				else
				{
					Form val = new Form();
					val.set_TopMost(true);
					MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050216067), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				return;
			}
			catch
			{
				((Control)button_2).set_BackColor(Color.DarkGray);
				return;
			}
		}
		Form val2 = new Form();
		val2.set_TopMost(true);
		MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050216182), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void comboBox_16_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.ATK_Floor_Freq = ((ListControl)comboBox_16).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_ATK_Floor_Freq = ((ListControl)comboBox_16).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_ATK_Floor_Freq = ((ListControl)comboBox_16).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_5_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SKILLBUFF_1_Freq = ((ListControl)comboBox_5).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SKILLBUFF_1_Freq = ((ListControl)comboBox_5).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SKILLBUFF_1_Freq = ((ListControl)comboBox_5).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_6_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SKILLBUFF_2_Freq = ((ListControl)comboBox_6).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SKILLBUFF_2_Freq = ((ListControl)comboBox_6).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SKILLBUFF_2_Freq = ((ListControl)comboBox_6).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SKILLBUFF_3_Freq = ((ListControl)comboBox_1).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SKILLBUFF_3_Freq = ((ListControl)comboBox_1).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SKILLBUFF_3_Freq = ((ListControl)comboBox_1).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SKILLBUFF_4_Freq = ((ListControl)comboBox_2).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SKILLBUFF_4_Freq = ((ListControl)comboBox_2).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SKILLBUFF_4_Freq = ((ListControl)comboBox_2).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SKILLBUFF_5_Freq = ((ListControl)comboBox_3).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SKILLBUFF_5_Freq = ((ListControl)comboBox_3).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SKILLBUFF_5_Freq = ((ListControl)comboBox_3).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_4_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SKILLBUFF_6_Freq = ((ListControl)comboBox_4).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SKILLBUFF_6_Freq = ((ListControl)comboBox_4).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SKILLBUFF_6_Freq = ((ListControl)comboBox_4).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if (gclass14_0 != null)
		{
			try
			{
				int num = gclass14_0.method_9(gclass12_0.SKILL_ID);
				int num2 = gclass14_0.method_9(gclass12_0.SKILL_LEVEL);
				if (num > 1 && num < 6000 && num2 > 0 && num2 <= 10)
				{
					if (int_0 == 0)
					{
						Settings.Default.SKILLBUFF_1 = num;
						((SettingsBase)Settings.Default).Save();
					}
					else if (int_0 == 1)
					{
						Settings.Default._2_SKILLBUFF_1 = num;
						((SettingsBase)Settings.Default).Save();
					}
					else if (int_0 == 2)
					{
						Settings.Default._3_SKILLBUFF_1 = num;
						((SettingsBase)Settings.Default).Save();
					}
					((Control)button_0).set_BackColor(Color.LightSeaGreen);
				}
				else
				{
					Form val = new Form();
					val.set_TopMost(true);
					MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050216067), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				return;
			}
			catch
			{
				((Control)button_0).set_BackColor(Color.DarkGray);
				return;
			}
		}
		Form val2 = new Form();
		val2.set_TopMost(true);
		MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050216182), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		if (gclass14_0 != null)
		{
			try
			{
				int num = gclass14_0.method_9(gclass12_0.SKILL_ID);
				int num2 = gclass14_0.method_9(gclass12_0.SKILL_LEVEL);
				if (num > 1 && num < 6000 && num2 > 0 && num2 <= 10)
				{
					if (int_0 == 0)
					{
						Settings.Default.SKILLBUFF_2 = num;
						((SettingsBase)Settings.Default).Save();
					}
					else if (int_0 == 1)
					{
						Settings.Default._2_SKILLBUFF_2 = num;
						((SettingsBase)Settings.Default).Save();
					}
					else if (int_0 == 2)
					{
						Settings.Default._3_SKILLBUFF_2 = num;
						((SettingsBase)Settings.Default).Save();
					}
					((Control)button_1).set_BackColor(Color.LightSeaGreen);
				}
				else
				{
					Form val = new Form();
					val.set_TopMost(true);
					MessageBox.Show((IWin32Window)val, Class60.smethod_0(-2050216067), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
				}
				return;
			}
			catch
			{
				((Control)button_1).set_BackColor(Color.DarkGray);
				return;
			}
		}
		Form val2 = new Form();
		val2.set_TopMost(true);
		MessageBox.Show((IWin32Window)val2, Class60.smethod_0(-2050216182), Class60.smethod_0(-2050208545), (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void comboBox_12_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SKILLBUFF_3 = int.Parse(((ListControl)comboBox_12).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SKILLBUFF_3 = int.Parse(((ListControl)comboBox_12).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SKILLBUFF_3 = int.Parse(((ListControl)comboBox_12).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_13_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SKILLBUFF_4 = int.Parse(((ListControl)comboBox_13).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SKILLBUFF_4 = int.Parse(((ListControl)comboBox_13).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SKILLBUFF_4 = int.Parse(((ListControl)comboBox_13).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_14_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SKILLBUFF_5 = int.Parse(((ListControl)comboBox_14).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SKILLBUFF_5 = int.Parse(((ListControl)comboBox_14).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SKILLBUFF_5 = int.Parse(((ListControl)comboBox_14).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_11_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SKILLBUFF_6 = int.Parse(((ListControl)comboBox_11).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SKILLBUFF_6 = int.Parse(((ListControl)comboBox_11).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SKILLBUFF_6 = int.Parse(((ListControl)comboBox_11).get_SelectedValue().ToString());
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_7_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.Macro1_Freq = ((ListControl)comboBox_7).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_Macro1_Freq = ((ListControl)comboBox_7).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_Macro1_Freq = ((ListControl)comboBox_7).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_8_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.Macro2_Freq = ((ListControl)comboBox_8).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_Macro2_Freq = ((ListControl)comboBox_8).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_Macro2_Freq = ((ListControl)comboBox_8).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_9_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.Macro3_Freq = ((ListControl)comboBox_9).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_Macro3_Freq = ((ListControl)comboBox_9).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_Macro3_Freq = ((ListControl)comboBox_9).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_10_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (bool_0)
		{
			return;
		}
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.Macro4_Freq = ((ListControl)comboBox_10).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_Macro4_Freq = ((ListControl)comboBox_10).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_Macro4_Freq = ((ListControl)comboBox_10).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void textBox_1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)textBox_1).set_Text(string.Concat(Class60.smethod_0(-2050195538), e.get_KeyCode(), Class60.smethod_0(-2050195546)));
			Keys keyCode;
			if (int_0 == 0)
			{
				Settings @default = Settings.Default;
				keyCode = e.get_KeyCode();
				@default.Macro1_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings default2 = Settings.Default;
				keyCode = e.get_KeyCode();
				default2._2_Macro1_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings default3 = Settings.Default;
				keyCode = e.get_KeyCode();
				default3._3_Macro1_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	private void textBox_2_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)textBox_2).set_Text(string.Concat(Class60.smethod_0(-2050195538), e.get_KeyCode(), Class60.smethod_0(-2050195546)));
			Keys keyCode;
			if (int_0 == 0)
			{
				Settings @default = Settings.Default;
				keyCode = e.get_KeyCode();
				@default.Macro2_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings default2 = Settings.Default;
				keyCode = e.get_KeyCode();
				default2._2_Macro2_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings default3 = Settings.Default;
				keyCode = e.get_KeyCode();
				default3._3_Macro2_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	private void textBox_3_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)textBox_3).set_Text(string.Concat(Class60.smethod_0(-2050195538), e.get_KeyCode(), Class60.smethod_0(-2050195546)));
			Keys keyCode;
			if (int_0 == 0)
			{
				Settings @default = Settings.Default;
				keyCode = e.get_KeyCode();
				@default.Macro3_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings default2 = Settings.Default;
				keyCode = e.get_KeyCode();
				default2._2_Macro3_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings default3 = Settings.Default;
				keyCode = e.get_KeyCode();
				default3._3_Macro3_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	private void textBox_0_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			((Control)textBox_0).set_Text(string.Concat(Class60.smethod_0(-2050195538), e.get_KeyCode(), Class60.smethod_0(-2050195546)));
			Keys keyCode;
			if (int_0 == 0)
			{
				Settings @default = Settings.Default;
				keyCode = e.get_KeyCode();
				@default.Macro4_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings default2 = Settings.Default;
				keyCode = e.get_KeyCode();
				default2._2_Macro4_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings default3 = Settings.Default;
				keyCode = e.get_KeyCode();
				default3._3_Macro4_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
	}

	private void method_1()
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
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0155: Expected O, but got Unknown
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0160: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_016b: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0176: Expected O, but got Unknown
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a2: Expected O, but got Unknown
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ad: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_01e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fa: Expected O, but got Unknown
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0205: Expected O, but got Unknown
		//IL_0206: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0211: Unknown result type (might be due to invalid IL or missing references)
		//IL_021b: Expected O, but got Unknown
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0226: Expected O, but got Unknown
		//IL_0227: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0247: Expected O, but got Unknown
		//IL_0248: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_0253: Unknown result type (might be due to invalid IL or missing references)
		//IL_025d: Expected O, but got Unknown
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0268: Expected O, but got Unknown
		//IL_0269: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027e: Expected O, but got Unknown
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_028a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0294: Expected O, but got Unknown
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029f: Expected O, but got Unknown
		//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02aa: Expected O, but got Unknown
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_0372: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Expected O, but got Unknown
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_0460: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_048e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b4: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_0531: Unknown result type (might be due to invalid IL or missing references)
		//IL_053b: Expected O, but got Unknown
		//IL_0568: Unknown result type (might be due to invalid IL or missing references)
		//IL_05eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f5: Expected O, but got Unknown
		//IL_0607: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_0623: Unknown result type (might be due to invalid IL or missing references)
		//IL_062d: Expected O, but got Unknown
		//IL_063f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_081b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0825: Expected O, but got Unknown
		//IL_0837: Unknown result type (might be due to invalid IL or missing references)
		//IL_0841: Expected O, but got Unknown
		//IL_0853: Unknown result type (might be due to invalid IL or missing references)
		//IL_085d: Expected O, but got Unknown
		//IL_086f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0879: Expected O, but got Unknown
		//IL_08d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08db: Expected O, but got Unknown
		//IL_0954: Unknown result type (might be due to invalid IL or missing references)
		//IL_095e: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		//IL_0a43: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4d: Expected O, but got Unknown
		//IL_0aeb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af5: Expected O, but got Unknown
		//IL_0b8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b99: Expected O, but got Unknown
		//IL_0c35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3f: Expected O, but got Unknown
		//IL_0cda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce4: Expected O, but got Unknown
		//IL_0d80: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d8a: Expected O, but got Unknown
		//IL_0e36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e40: Expected O, but got Unknown
		//IL_0ef0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efa: Expected O, but got Unknown
		//IL_0faa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb4: Expected O, but got Unknown
		//IL_1054: Unknown result type (might be due to invalid IL or missing references)
		//IL_105e: Expected O, but got Unknown
		//IL_10fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1104: Expected O, but got Unknown
		//IL_11a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11ae: Expected O, but got Unknown
		//IL_1226: Unknown result type (might be due to invalid IL or missing references)
		//IL_1230: Expected O, but got Unknown
		//IL_1264: Unknown result type (might be due to invalid IL or missing references)
		//IL_126e: Expected O, but got Unknown
		//IL_12e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f1: Expected O, but got Unknown
		//IL_1325: Unknown result type (might be due to invalid IL or missing references)
		//IL_132f: Expected O, but got Unknown
		//IL_13a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b2: Expected O, but got Unknown
		//IL_13ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f6: Expected O, but got Unknown
		//IL_1423: Unknown result type (might be due to invalid IL or missing references)
		//IL_14a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14b0: Expected O, but got Unknown
		//IL_14c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14cc: Expected O, but got Unknown
		//IL_14de: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e8: Expected O, but got Unknown
		//IL_14fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1504: Expected O, but got Unknown
		//IL_16d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e0: Expected O, but got Unknown
		//IL_16f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fc: Expected O, but got Unknown
		//IL_170e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1718: Expected O, but got Unknown
		//IL_172a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1734: Expected O, but got Unknown
		//IL_1798: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a2: Expected O, but got Unknown
		//IL_1845: Unknown result type (might be due to invalid IL or missing references)
		//IL_184f: Expected O, but got Unknown
		//IL_18fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1904: Expected O, but got Unknown
		//IL_19a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ac: Expected O, but got Unknown
		//IL_1a46: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a50: Expected O, but got Unknown
		//IL_1aec: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af6: Expected O, but got Unknown
		//IL_1b91: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9b: Expected O, but got Unknown
		//IL_1c37: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c41: Expected O, but got Unknown
		//IL_1ced: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cf7: Expected O, but got Unknown
		//IL_1da7: Unknown result type (might be due to invalid IL or missing references)
		//IL_1db1: Expected O, but got Unknown
		//IL_1e61: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e6b: Expected O, but got Unknown
		//IL_1f0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f15: Expected O, but got Unknown
		//IL_1fb1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fbb: Expected O, but got Unknown
		//IL_2067: Unknown result type (might be due to invalid IL or missing references)
		//IL_2071: Expected O, but got Unknown
		//IL_2123: Unknown result type (might be due to invalid IL or missing references)
		//IL_212d: Expected O, but got Unknown
		//IL_21e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_21ea: Expected O, but got Unknown
		//IL_2297: Unknown result type (might be due to invalid IL or missing references)
		//IL_22a1: Expected O, but got Unknown
		//IL_22ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_2351: Unknown result type (might be due to invalid IL or missing references)
		//IL_235b: Expected O, but got Unknown
		//IL_236d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2377: Expected O, but got Unknown
		//IL_2389: Unknown result type (might be due to invalid IL or missing references)
		//IL_2393: Expected O, but got Unknown
		//IL_23a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_23af: Expected O, but got Unknown
		//IL_2509: Unknown result type (might be due to invalid IL or missing references)
		//IL_2513: Expected O, but got Unknown
		//IL_2525: Unknown result type (might be due to invalid IL or missing references)
		//IL_252f: Expected O, but got Unknown
		//IL_2541: Unknown result type (might be due to invalid IL or missing references)
		//IL_254b: Expected O, but got Unknown
		//IL_25bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_25c9: Expected O, but got Unknown
		//IL_2681: Unknown result type (might be due to invalid IL or missing references)
		//IL_268b: Expected O, but got Unknown
		//IL_2737: Unknown result type (might be due to invalid IL or missing references)
		//IL_2741: Expected O, but got Unknown
		//IL_27df: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e9: Expected O, but got Unknown
		//IL_2883: Unknown result type (might be due to invalid IL or missing references)
		//IL_288d: Expected O, but got Unknown
		//IL_2928: Unknown result type (might be due to invalid IL or missing references)
		//IL_2932: Expected O, but got Unknown
		//IL_29ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d8: Expected O, but got Unknown
		//IL_2a74: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a7e: Expected O, but got Unknown
		//IL_2b2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2b34: Expected O, but got Unknown
		//IL_2be4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bee: Expected O, but got Unknown
		//IL_2cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_2cb8: Expected O, but got Unknown
		//IL_2d7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2d84: Expected O, but got Unknown
		//IL_2dad: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e37: Expected O, but got Unknown
		//IL_2e49: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e53: Expected O, but got Unknown
		//IL_2e65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e6f: Expected O, but got Unknown
		//IL_2e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e8b: Expected O, but got Unknown
		//IL_2f25: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f2f: Expected O, but got Unknown
		//IL_2fa3: Unknown result type (might be due to invalid IL or missing references)
		//IL_2fad: Expected O, but got Unknown
		//IL_3074: Unknown result type (might be due to invalid IL or missing references)
		//IL_307e: Expected O, but got Unknown
		//IL_3181: Unknown result type (might be due to invalid IL or missing references)
		//IL_318b: Expected O, but got Unknown
		//IL_322e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3238: Expected O, but got Unknown
		//IL_3262: Unknown result type (might be due to invalid IL or missing references)
		//IL_32e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_32ec: Expected O, but got Unknown
		//IL_32fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_3308: Expected O, but got Unknown
		//IL_338a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3394: Expected O, but got Unknown
		//IL_33a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_33b0: Expected O, but got Unknown
		//IL_33f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_33fb: Expected O, but got Unknown
		//IL_340d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3417: Expected O, but got Unknown
		//IL_3429: Unknown result type (might be due to invalid IL or missing references)
		//IL_3433: Expected O, but got Unknown
		//IL_348a: Unknown result type (might be due to invalid IL or missing references)
		//IL_34c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_34d0: Expected O, but got Unknown
		//IL_34e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_34ec: Expected O, but got Unknown
		//IL_354d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3557: Expected O, but got Unknown
		//IL_35f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_35fd: Expected O, but got Unknown
		//IL_3684: Unknown result type (might be due to invalid IL or missing references)
		//IL_368e: Expected O, but got Unknown
		//IL_36a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_36aa: Expected O, but got Unknown
		//IL_36bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_36c6: Expected O, but got Unknown
		//IL_3734: Unknown result type (might be due to invalid IL or missing references)
		//IL_3770: Unknown result type (might be due to invalid IL or missing references)
		//IL_377a: Expected O, but got Unknown
		//IL_37ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_37f6: Expected O, but got Unknown
		//IL_38aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_38b4: Expected O, but got Unknown
		//IL_395b: Unknown result type (might be due to invalid IL or missing references)
		//IL_3965: Expected O, but got Unknown
		tableLayoutPanel_0 = new TableLayoutPanel();
		groupBox_3 = new GroupBox();
		tableLayoutPanel_4 = new TableLayoutPanel();
		textBox_0 = new TextBox();
		label_15 = new Label();
		comboBox_7 = new ComboBox();
		label_16 = new Label();
		label_17 = new Label();
		label_18 = new Label();
		label_19 = new Label();
		label_20 = new Label();
		comboBox_8 = new ComboBox();
		comboBox_9 = new ComboBox();
		comboBox_10 = new ComboBox();
		label_21 = new Label();
		label_22 = new Label();
		textBox_1 = new TextBox();
		textBox_2 = new TextBox();
		textBox_3 = new TextBox();
		groupBox_2 = new GroupBox();
		tableLayoutPanel_3 = new TableLayoutPanel();
		comboBox_11 = new ComboBox();
		label_2 = new Label();
		comboBox_1 = new ComboBox();
		label_3 = new Label();
		label_6 = new Label();
		label_7 = new Label();
		label_8 = new Label();
		label_9 = new Label();
		comboBox_2 = new ComboBox();
		comboBox_3 = new ComboBox();
		comboBox_4 = new ComboBox();
		label_5 = new Label();
		label_4 = new Label();
		comboBox_12 = new ComboBox();
		comboBox_13 = new ComboBox();
		comboBox_14 = new ComboBox();
		groupBox_1 = new GroupBox();
		tableLayoutPanel_2 = new TableLayoutPanel();
		button_1 = new Button();
		label_10 = new Label();
		comboBox_0 = new ComboBox();
		label_0 = new Label();
		label_1 = new Label();
		label_11 = new Label();
		label_12 = new Label();
		label_13 = new Label();
		comboBox_5 = new ComboBox();
		comboBox_6 = new ComboBox();
		button_0 = new Button();
		groupBox_0 = new GroupBox();
		tableLayoutPanel_1 = new TableLayoutPanel();
		button_2 = new Button();
		comboBox_15 = new ComboBox();
		label_14 = new Label();
		groupBox_4 = new GroupBox();
		tableLayoutPanel_6 = new TableLayoutPanel();
		tableLayoutPanel_5 = new TableLayoutPanel();
		comboBox_16 = new ComboBox();
		label_23 = new Label();
		tableLayoutPanel_7 = new TableLayoutPanel();
		button_3 = new Button();
		label_24 = new Label();
		comboBox_17 = new ComboBox();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)groupBox_3).SuspendLayout();
		((Control)tableLayoutPanel_4).SuspendLayout();
		((Control)groupBox_2).SuspendLayout();
		((Control)tableLayoutPanel_3).SuspendLayout();
		((Control)groupBox_1).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((Control)groupBox_0).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)groupBox_4).SuspendLayout();
		((Control)tableLayoutPanel_6).SuspendLayout();
		((Control)tableLayoutPanel_5).SuspendLayout();
		((Control)tableLayoutPanel_7).SuspendLayout();
		((Control)this).SuspendLayout();
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_3, 0, 4);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_2, 0, 3);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_1, 0, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_0, 0, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_4, 0, 1);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_0).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(5);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 11f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 17f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 22f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		((Control)tableLayoutPanel_0).set_Size(new Size(400, 600));
		((Control)tableLayoutPanel_0).set_TabIndex(0);
		((Control)groupBox_3).get_Controls().Add((Control)(object)tableLayoutPanel_4);
		((Control)groupBox_3).set_Dock((DockStyle)5);
		((Control)groupBox_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_3).set_ForeColor(SystemColors.Control);
		((Control)groupBox_3).set_Location(new Point(0, 450));
		((Control)groupBox_3).set_Margin(new Padding(0));
		((Control)groupBox_3).set_Name(Class60.smethod_0(-2050207223));
		((Control)groupBox_3).set_Size(new Size(400, 150));
		((Control)groupBox_3).set_TabIndex(6);
		groupBox_3.set_TabStop(false);
		((Control)groupBox_3).set_Text(Class60.smethod_0(-2050216249));
		tableLayoutPanel_4.set_ColumnCount(4);
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 35f));
		tableLayoutPanel_4.get_Controls().Add((Control)(object)textBox_0, 3, 3);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_15, 1, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)comboBox_7, 2, 0);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_16, 1, 0);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_17, 1, 2);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_18, 0, 0);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_19, 0, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_20, 0, 2);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)comboBox_8, 2, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)comboBox_9, 2, 2);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)comboBox_10, 2, 3);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_21, 1, 3);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_22, 0, 3);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)textBox_1, 3, 0);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)textBox_2, 3, 1);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)textBox_3, 3, 2);
		((Control)tableLayoutPanel_4).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_4).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_4).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_4.set_RowCount(4);
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		((Control)tableLayoutPanel_4).set_Size(new Size(394, 125));
		((Control)tableLayoutPanel_4).set_TabIndex(0);
		((Control)textBox_0).set_Cursor(Cursors.get_IBeam());
		((Control)textBox_0).set_Dock((DockStyle)5);
		((Control)textBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_ForeColor(SystemColors.WindowText);
		((Control)textBox_0).set_Location(new Point(257, 96));
		((TextBoxBase)textBox_0).set_MaxLength(3);
		((Control)textBox_0).set_Name(Class60.smethod_0(-2050216272));
		((Control)textBox_0).set_Size(new Size(134, 24));
		((Control)textBox_0).set_TabIndex(25);
		((Control)textBox_0).add_KeyDown(new KeyEventHandler(textBox_0_KeyDown));
		((Control)label_15).set_AutoSize(true);
		((Control)label_15).set_Dock((DockStyle)4);
		((Control)label_15).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_15).set_Location(new Point(96, 31));
		((Control)label_15).set_Name(Class60.smethod_0(-2050225725));
		((Control)label_15).set_Size(new Size(77, 31));
		((Control)label_15).set_TabIndex(6);
		((Control)label_15).set_Text(Class60.smethod_0(-2050225361));
		label_15.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_7).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_7).set_Dock((DockStyle)5);
		comboBox_7.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_7).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_7).set_FormattingEnabled(true);
		((Control)comboBox_7).set_Location(new Point(179, 3));
		((Control)comboBox_7).set_Name(Class60.smethod_0(-2050216296));
		((Control)comboBox_7).set_Size(new Size(72, 25));
		((Control)comboBox_7).set_TabIndex(3);
		comboBox_7.add_SelectedIndexChanged((EventHandler)comboBox_7_SelectedIndexChanged);
		((Control)label_16).set_AutoSize(true);
		((Control)label_16).set_Dock((DockStyle)4);
		((Control)label_16).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_16).set_Location(new Point(96, 0));
		((Control)label_16).set_Name(Class60.smethod_0(-2050225675));
		((Control)label_16).set_Size(new Size(77, 31));
		((Control)label_16).set_TabIndex(2);
		((Control)label_16).set_Text(Class60.smethod_0(-2050225361));
		label_16.set_TextAlign((ContentAlignment)64);
		((Control)label_17).set_AutoSize(true);
		((Control)label_17).set_Dock((DockStyle)4);
		((Control)label_17).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_17).set_Location(new Point(96, 62));
		((Control)label_17).set_Name(Class60.smethod_0(-2050225662));
		((Control)label_17).set_Size(new Size(77, 31));
		((Control)label_17).set_TabIndex(13);
		((Control)label_17).set_Text(Class60.smethod_0(-2050225361));
		label_17.set_TextAlign((ContentAlignment)64);
		((Control)label_18).set_AutoSize(true);
		((Control)label_18).set_Dock((DockStyle)4);
		((Control)label_18).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_18).set_Location(new Point(24, 0));
		((Control)label_18).set_Name(Class60.smethod_0(-2050225612));
		((Control)label_18).set_Size(new Size(51, 31));
		((Control)label_18).set_TabIndex(14);
		((Control)label_18).set_Text(Class60.smethod_0(-2050216338));
		label_18.set_TextAlign((ContentAlignment)64);
		((Control)label_19).set_AutoSize(true);
		((Control)label_19).set_Dock((DockStyle)4);
		((Control)label_19).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_19).set_Location(new Point(24, 31));
		((Control)label_19).set_Name(Class60.smethod_0(-2050225591));
		((Control)label_19).set_Size(new Size(51, 31));
		((Control)label_19).set_TabIndex(16);
		((Control)label_19).set_Text(Class60.smethod_0(-2050216333));
		label_19.set_TextAlign((ContentAlignment)64);
		((Control)label_20).set_AutoSize(true);
		((Control)label_20).set_Dock((DockStyle)4);
		((Control)label_20).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_20).set_Location(new Point(24, 62));
		((Control)label_20).set_Name(Class60.smethod_0(-2050225541));
		((Control)label_20).set_Size(new Size(51, 31));
		((Control)label_20).set_TabIndex(15);
		((Control)label_20).set_Text(Class60.smethod_0(-2050216360));
		label_20.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_8).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_8).set_Dock((DockStyle)5);
		comboBox_8.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_8).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_8).set_FormattingEnabled(true);
		((Control)comboBox_8).set_Location(new Point(179, 34));
		((Control)comboBox_8).set_Name(Class60.smethod_0(-2050216403));
		((Control)comboBox_8).set_Size(new Size(72, 25));
		((Control)comboBox_8).set_TabIndex(19);
		comboBox_8.add_SelectedIndexChanged((EventHandler)comboBox_8_SelectedIndexChanged);
		((Control)comboBox_9).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_9).set_Dock((DockStyle)5);
		comboBox_9.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_9).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_9).set_FormattingEnabled(true);
		((Control)comboBox_9).set_Location(new Point(179, 65));
		((Control)comboBox_9).set_Name(Class60.smethod_0(-2050216397));
		((Control)comboBox_9).set_Size(new Size(72, 25));
		((Control)comboBox_9).set_TabIndex(20);
		comboBox_9.add_SelectedIndexChanged((EventHandler)comboBox_9_SelectedIndexChanged);
		((Control)comboBox_10).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_10).set_Dock((DockStyle)5);
		comboBox_10.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_10).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_10).set_FormattingEnabled(true);
		((Control)comboBox_10).set_Location(new Point(179, 96));
		((Control)comboBox_10).set_Name(Class60.smethod_0(-2050216423));
		((Control)comboBox_10).set_Size(new Size(72, 25));
		((Control)comboBox_10).set_TabIndex(21);
		comboBox_10.add_SelectedIndexChanged((EventHandler)comboBox_10_SelectedIndexChanged);
		((Control)label_21).set_AutoSize(true);
		((Control)label_21).set_Dock((DockStyle)4);
		((Control)label_21).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_21).set_Location(new Point(96, 93));
		((Control)label_21).set_Name(Class60.smethod_0(-2050225536));
		((Control)label_21).set_Size(new Size(77, 32));
		((Control)label_21).set_TabIndex(17);
		((Control)label_21).set_Text(Class60.smethod_0(-2050225361));
		label_21.set_TextAlign((ContentAlignment)64);
		((Control)label_22).set_AutoSize(true);
		((Control)label_22).set_Dock((DockStyle)4);
		((Control)label_22).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_22).set_Location(new Point(24, 93));
		((Control)label_22).set_Name(Class60.smethod_0(-2050225486));
		((Control)label_22).set_Size(new Size(51, 32));
		((Control)label_22).set_TabIndex(18);
		((Control)label_22).set_Text(Class60.smethod_0(-2050216465));
		label_22.set_TextAlign((ContentAlignment)64);
		((Control)textBox_1).set_Cursor(Cursors.get_IBeam());
		((Control)textBox_1).set_Dock((DockStyle)5);
		((Control)textBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_1).set_ForeColor(SystemColors.WindowText);
		((Control)textBox_1).set_Location(new Point(257, 3));
		((TextBoxBase)textBox_1).set_MaxLength(3);
		((Control)textBox_1).set_Name(Class60.smethod_0(-2050216460));
		((Control)textBox_1).set_Size(new Size(134, 24));
		((Control)textBox_1).set_TabIndex(22);
		((Control)textBox_1).add_KeyDown(new KeyEventHandler(textBox_1_KeyDown));
		((Control)textBox_2).set_Cursor(Cursors.get_IBeam());
		((Control)textBox_2).set_Dock((DockStyle)5);
		((Control)textBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_2).set_ForeColor(SystemColors.WindowText);
		((Control)textBox_2).set_Location(new Point(257, 34));
		((TextBoxBase)textBox_2).set_MaxLength(3);
		((Control)textBox_2).set_Name(Class60.smethod_0(-2050216484));
		((Control)textBox_2).set_Size(new Size(134, 24));
		((Control)textBox_2).set_TabIndex(23);
		((Control)textBox_2).add_KeyDown(new KeyEventHandler(textBox_2_KeyDown));
		((Control)textBox_3).set_Cursor(Cursors.get_IBeam());
		((Control)textBox_3).set_Dock((DockStyle)5);
		((Control)textBox_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_3).set_ForeColor(SystemColors.WindowText);
		((Control)textBox_3).set_Location(new Point(257, 65));
		((TextBoxBase)textBox_3).set_MaxLength(3);
		((Control)textBox_3).set_Name(Class60.smethod_0(-2050216540));
		((Control)textBox_3).set_Size(new Size(134, 24));
		((Control)textBox_3).set_TabIndex(24);
		((Control)textBox_3).add_KeyDown(new KeyEventHandler(textBox_3_KeyDown));
		((Control)groupBox_2).get_Controls().Add((Control)(object)tableLayoutPanel_3);
		((Control)groupBox_2).set_Dock((DockStyle)5);
		((Control)groupBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_2).set_ForeColor(SystemColors.Control);
		((Control)groupBox_2).set_Location(new Point(0, 300));
		((Control)groupBox_2).set_Margin(new Padding(0));
		((Control)groupBox_2).set_Name(Class60.smethod_0(-2050210886));
		((Control)groupBox_2).set_Size(new Size(400, 150));
		((Control)groupBox_2).set_TabIndex(5);
		groupBox_2.set_TabStop(false);
		((Control)groupBox_2).set_Text(Class60.smethod_0(-2050216564));
		tableLayoutPanel_3.set_ColumnCount(4);
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 35f));
		tableLayoutPanel_3.get_Controls().Add((Control)(object)comboBox_11, 3, 3);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_2, 1, 1);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)comboBox_1, 2, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_3, 1, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_6, 1, 2);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_7, 0, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_8, 0, 1);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_9, 0, 2);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)comboBox_2, 2, 1);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)comboBox_3, 2, 2);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)comboBox_4, 2, 3);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_5, 1, 3);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_4, 0, 3);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)comboBox_12, 3, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)comboBox_13, 3, 1);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)comboBox_14, 3, 2);
		((Control)tableLayoutPanel_3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_3).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_3).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_3.set_RowCount(4);
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		((Control)tableLayoutPanel_3).set_Size(new Size(394, 125));
		((Control)tableLayoutPanel_3).set_TabIndex(0);
		((Control)comboBox_11).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_11).set_Dock((DockStyle)5);
		comboBox_11.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_11).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_11).set_FormattingEnabled(true);
		((Control)comboBox_11).set_Location(new Point(257, 96));
		((Control)comboBox_11).set_Name(Class60.smethod_0(-2050216605));
		((Control)comboBox_11).set_Size(new Size(134, 25));
		((Control)comboBox_11).set_TabIndex(25);
		comboBox_11.add_SelectedIndexChanged((EventHandler)comboBox_11_SelectedIndexChanged);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Dock((DockStyle)4);
		((Control)label_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_Location(new Point(96, 31));
		((Control)label_2).set_Name(Class60.smethod_0(-2050226038));
		((Control)label_2).set_Size(new Size(77, 31));
		((Control)label_2).set_TabIndex(6);
		((Control)label_2).set_Text(Class60.smethod_0(-2050225361));
		label_2.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_1).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_1).set_Dock((DockStyle)5);
		comboBox_1.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_1).set_FormattingEnabled(true);
		((Control)comboBox_1).set_Location(new Point(179, 3));
		((Control)comboBox_1).set_Name(Class60.smethod_0(-2050216629));
		((Control)comboBox_1).set_Size(new Size(72, 25));
		((Control)comboBox_1).set_TabIndex(3);
		comboBox_1.add_SelectedIndexChanged((EventHandler)comboBox_1_SelectedIndexChanged);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Dock((DockStyle)4);
		((Control)label_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_3).set_Location(new Point(96, 0));
		((Control)label_3).set_Name(Class60.smethod_0(-2050225987));
		((Control)label_3).set_Size(new Size(77, 31));
		((Control)label_3).set_TabIndex(2);
		((Control)label_3).set_Text(Class60.smethod_0(-2050225361));
		label_3.set_TextAlign((ContentAlignment)64);
		((Control)label_6).set_AutoSize(true);
		((Control)label_6).set_Dock((DockStyle)4);
		((Control)label_6).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_6).set_Location(new Point(96, 62));
		((Control)label_6).set_Name(Class60.smethod_0(-2050202302));
		((Control)label_6).set_Size(new Size(77, 31));
		((Control)label_6).set_TabIndex(13);
		((Control)label_6).set_Text(Class60.smethod_0(-2050225361));
		label_6.set_TextAlign((ContentAlignment)64);
		((Control)label_7).set_AutoSize(true);
		((Control)label_7).set_Dock((DockStyle)4);
		((Control)label_7).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_7).set_Location(new Point(20, 0));
		((Control)label_7).set_Name(Class60.smethod_0(-2050207199));
		((Control)label_7).set_Size(new Size(55, 31));
		((Control)label_7).set_TabIndex(14);
		((Control)label_7).set_Text(Class60.smethod_0(-2050216624));
		label_7.set_TextAlign((ContentAlignment)64);
		((Control)label_8).set_AutoSize(true);
		((Control)label_8).set_Dock((DockStyle)4);
		((Control)label_8).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_8).set_Location(new Point(20, 31));
		((Control)label_8).set_Name(Class60.smethod_0(-2050225881));
		((Control)label_8).set_Size(new Size(55, 31));
		((Control)label_8).set_TabIndex(16);
		((Control)label_8).set_Text(Class60.smethod_0(-2050216647));
		label_8.set_TextAlign((ContentAlignment)64);
		((Control)label_9).set_AutoSize(true);
		((Control)label_9).set_Dock((DockStyle)4);
		((Control)label_9).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_9).set_Location(new Point(20, 62));
		((Control)label_9).set_Name(Class60.smethod_0(-2050225950));
		((Control)label_9).set_Size(new Size(55, 31));
		((Control)label_9).set_TabIndex(15);
		((Control)label_9).set_Text(Class60.smethod_0(-2050216702));
		label_9.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_2).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_2).set_Dock((DockStyle)5);
		comboBox_2.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_2).set_FormattingEnabled(true);
		((Control)comboBox_2).set_Location(new Point(179, 34));
		((Control)comboBox_2).set_Name(Class60.smethod_0(-2050216725));
		((Control)comboBox_2).set_Size(new Size(72, 25));
		((Control)comboBox_2).set_TabIndex(19);
		comboBox_2.add_SelectedIndexChanged((EventHandler)comboBox_2_SelectedIndexChanged);
		((Control)comboBox_3).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_3).set_Dock((DockStyle)5);
		comboBox_3.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_3).set_FormattingEnabled(true);
		((Control)comboBox_3).set_Location(new Point(179, 65));
		((Control)comboBox_3).set_Name(Class60.smethod_0(-2050216720));
		((Control)comboBox_3).set_Size(new Size(72, 25));
		((Control)comboBox_3).set_TabIndex(20);
		comboBox_3.add_SelectedIndexChanged((EventHandler)comboBox_3_SelectedIndexChanged);
		((Control)comboBox_4).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_4).set_Dock((DockStyle)5);
		comboBox_4.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_4).set_FormattingEnabled(true);
		((Control)comboBox_4).set_Location(new Point(179, 96));
		((Control)comboBox_4).set_Name(Class60.smethod_0(-2050216763));
		((Control)comboBox_4).set_Size(new Size(72, 25));
		((Control)comboBox_4).set_TabIndex(21);
		comboBox_4.add_SelectedIndexChanged((EventHandler)comboBox_4_SelectedIndexChanged);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Dock((DockStyle)4);
		((Control)label_5).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_5).set_Location(new Point(96, 93));
		((Control)label_5).set_Name(Class60.smethod_0(-2050225879));
		((Control)label_5).set_Size(new Size(77, 32));
		((Control)label_5).set_TabIndex(17);
		((Control)label_5).set_Text(Class60.smethod_0(-2050225361));
		label_5.set_TextAlign((ContentAlignment)64);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Dock((DockStyle)4);
		((Control)label_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_4).set_Location(new Point(20, 93));
		((Control)label_4).set_Name(Class60.smethod_0(-2050225766));
		((Control)label_4).set_Size(new Size(55, 32));
		((Control)label_4).set_TabIndex(18);
		((Control)label_4).set_Text(Class60.smethod_0(-2050216790));
		label_4.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_12).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_12).set_Dock((DockStyle)5);
		comboBox_12.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_12).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_12).set_FormattingEnabled(true);
		((Control)comboBox_12).set_Location(new Point(257, 3));
		((Control)comboBox_12).set_Name(Class60.smethod_0(-2050216781));
		((Control)comboBox_12).set_Size(new Size(134, 25));
		((Control)comboBox_12).set_TabIndex(22);
		comboBox_12.add_SelectedIndexChanged((EventHandler)comboBox_12_SelectedIndexChanged);
		((Control)comboBox_13).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_13).set_Dock((DockStyle)5);
		comboBox_13.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_13).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_13).set_FormattingEnabled(true);
		((Control)comboBox_13).set_Location(new Point(257, 34));
		((Control)comboBox_13).set_Name(Class60.smethod_0(-2050216805));
		((Control)comboBox_13).set_Size(new Size(134, 25));
		((Control)comboBox_13).set_TabIndex(23);
		comboBox_13.add_SelectedIndexChanged((EventHandler)comboBox_13_SelectedIndexChanged);
		((Control)comboBox_14).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_14).set_Dock((DockStyle)5);
		comboBox_14.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_14).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_14).set_FormattingEnabled(true);
		((Control)comboBox_14).set_Location(new Point(257, 65));
		((Control)comboBox_14).set_Name(Class60.smethod_0(-2050216861));
		((Control)comboBox_14).set_Size(new Size(134, 25));
		((Control)comboBox_14).set_TabIndex(24);
		comboBox_14.add_SelectedIndexChanged((EventHandler)comboBox_14_SelectedIndexChanged);
		((Control)groupBox_1).get_Controls().Add((Control)(object)tableLayoutPanel_2);
		((Control)groupBox_1).set_Dock((DockStyle)5);
		((Control)groupBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_1).set_ForeColor(SystemColors.Control);
		((Control)groupBox_1).set_Location(new Point(0, 168));
		((Control)groupBox_1).set_Margin(new Padding(0));
		((Control)groupBox_1).set_Name(Class60.smethod_0(-2050198717));
		((Control)groupBox_1).set_Size(new Size(400, 132));
		((Control)groupBox_1).set_TabIndex(2);
		groupBox_1.set_TabStop(false);
		((Control)groupBox_1).set_Text(Class60.smethod_0(-2050216885));
		tableLayoutPanel_2.set_ColumnCount(4);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 35f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)button_1, 3, 2);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_10, 0, 2);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)comboBox_0, 2, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_0, 1, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_1, 0, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_11, 0, 1);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_12, 1, 1);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_13, 1, 2);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)comboBox_5, 2, 1);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)comboBox_6, 2, 2);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)button_0, 3, 1);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050211259));
		tableLayoutPanel_2.set_RowCount(3);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 34f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		((Control)tableLayoutPanel_2).set_Size(new Size(394, 107));
		((Control)tableLayoutPanel_2).set_TabIndex(0);
		((Control)button_1).set_BackColor(Color.DarkGray);
		((Control)button_1).set_Cursor(Cursors.get_Hand());
		((Control)button_1).set_Dock((DockStyle)5);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)0);
		((Control)button_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_1).set_Location(new Point(257, 74));
		((Control)button_1).set_Name(Class60.smethod_0(-2050216922));
		((Control)button_1).set_Size(new Size(134, 30));
		((Control)button_1).set_TabIndex(17);
		((Control)button_1).set_Text(Class60.smethod_0(-2050216949));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(false);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)label_10).set_AutoSize(true);
		((Control)label_10).set_Dock((DockStyle)4);
		((Control)label_10).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_10).set_Location(new Point(20, 71));
		((Control)label_10).set_Name(Class60.smethod_0(-2050210921));
		((Control)label_10).set_Size(new Size(55, 36));
		((Control)label_10).set_TabIndex(11);
		((Control)label_10).set_Text(Class60.smethod_0(-2050216944));
		label_10.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_0).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_0).set_Dock((DockStyle)5);
		comboBox_0.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		((Control)comboBox_0).set_Location(new Point(179, 3));
		((Control)comboBox_0).set_Name(Class60.smethod_0(-2050219015));
		((Control)comboBox_0).set_Size(new Size(72, 25));
		((Control)comboBox_0).set_TabIndex(3);
		comboBox_0.add_SelectedIndexChanged((EventHandler)comboBox_0_SelectedIndexChanged);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Dock((DockStyle)4);
		((Control)label_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(96, 0));
		((Control)label_0).set_Name(Class60.smethod_0(-2050198190));
		((Control)label_0).set_Size(new Size(77, 36));
		((Control)label_0).set_TabIndex(2);
		((Control)label_0).set_Text(Class60.smethod_0(-2050225361));
		label_0.set_TextAlign((ContentAlignment)64);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Dock((DockStyle)4);
		((Control)label_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_Location(new Point(50, 0));
		((Control)label_1).set_Name(Class60.smethod_0(-2050225816));
		((Control)label_1).set_Size(new Size(25, 36));
		((Control)label_1).set_TabIndex(9);
		((Control)label_1).set_Text(Class60.smethod_0(-2050219061));
		label_1.set_TextAlign((ContentAlignment)64);
		((Control)label_11).set_AutoSize(true);
		((Control)label_11).set_Dock((DockStyle)4);
		((Control)label_11).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_11).set_Location(new Point(20, 36));
		((Control)label_11).set_Name(Class60.smethod_0(-2050208088));
		((Control)label_11).set_Size(new Size(55, 35));
		((Control)label_11).set_TabIndex(10);
		((Control)label_11).set_Text(Class60.smethod_0(-2050219068));
		label_11.set_TextAlign((ContentAlignment)64);
		((Control)label_12).set_AutoSize(true);
		((Control)label_12).set_Dock((DockStyle)4);
		((Control)label_12).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_12).set_Location(new Point(96, 36));
		((Control)label_12).set_Name(Class60.smethod_0(-2050210999));
		((Control)label_12).set_Size(new Size(77, 35));
		((Control)label_12).set_TabIndex(12);
		((Control)label_12).set_Text(Class60.smethod_0(-2050225361));
		label_12.set_TextAlign((ContentAlignment)64);
		((Control)label_13).set_AutoSize(true);
		((Control)label_13).set_Dock((DockStyle)4);
		((Control)label_13).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_13).set_Location(new Point(96, 71));
		((Control)label_13).set_Name(Class60.smethod_0(-2050207156));
		((Control)label_13).set_Size(new Size(77, 36));
		((Control)label_13).set_TabIndex(13);
		((Control)label_13).set_Text(Class60.smethod_0(-2050225361));
		label_13.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_5).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_5).set_Dock((DockStyle)5);
		comboBox_5.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_5).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_5).set_FormattingEnabled(true);
		((Control)comboBox_5).set_Location(new Point(179, 39));
		((Control)comboBox_5).set_Name(Class60.smethod_0(-2050219091));
		((Control)comboBox_5).set_Size(new Size(72, 25));
		((Control)comboBox_5).set_TabIndex(14);
		comboBox_5.add_SelectedIndexChanged((EventHandler)comboBox_5_SelectedIndexChanged);
		((Control)comboBox_6).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_6).set_Dock((DockStyle)5);
		comboBox_6.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_6).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_6).set_FormattingEnabled(true);
		((Control)comboBox_6).set_Location(new Point(179, 74));
		((Control)comboBox_6).set_Name(Class60.smethod_0(-2050219086));
		((Control)comboBox_6).set_Size(new Size(72, 25));
		((Control)comboBox_6).set_TabIndex(15);
		comboBox_6.add_SelectedIndexChanged((EventHandler)comboBox_6_SelectedIndexChanged);
		((Control)button_0).set_BackColor(Color.DarkGray);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)0);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_0).set_Location(new Point(257, 39));
		((Control)button_0).set_Name(Class60.smethod_0(-2050219129));
		((Control)button_0).set_Size(new Size(134, 29));
		((Control)button_0).set_TabIndex(16);
		((Control)button_0).set_Text(Class60.smethod_0(-2050216949));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)groupBox_0).get_Controls().Add((Control)(object)tableLayoutPanel_1);
		((Control)groupBox_0).set_Dock((DockStyle)5);
		((Control)groupBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_0).set_ForeColor(SystemColors.Control);
		((Control)groupBox_0).set_Location(new Point(0, 0));
		((Control)groupBox_0).set_Margin(new Padding(0));
		((Control)groupBox_0).set_Name(Class60.smethod_0(-2050198412));
		((Control)groupBox_0).set_Size(new Size(400, 66));
		((Control)groupBox_0).set_TabIndex(4);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050219156));
		tableLayoutPanel_1.set_ColumnCount(3);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 45f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 35f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)button_2, 2, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)comboBox_15, 1, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_14, 0, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050206985));
		tableLayoutPanel_1.set_RowCount(1);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_1).set_Size(new Size(394, 41));
		((Control)tableLayoutPanel_1).set_TabIndex(0);
		((Control)button_2).set_BackColor(Color.DarkGray);
		((Control)button_2).set_Cursor(Cursors.get_Hand());
		((Control)button_2).set_Dock((DockStyle)5);
		((ButtonBase)button_2).set_FlatStyle((FlatStyle)0);
		((Control)button_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_2).set_Location(new Point(258, 3));
		((Control)button_2).set_Name(Class60.smethod_0(-2050219173));
		((Control)button_2).set_Size(new Size(133, 35));
		((Control)button_2).set_TabIndex(17);
		((Control)button_2).set_Text(Class60.smethod_0(-2050216949));
		((ButtonBase)button_2).set_UseVisualStyleBackColor(false);
		((Control)button_2).add_Click((EventHandler)button_2_Click);
		((Control)comboBox_15).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_15).set_Dock((DockStyle)5);
		comboBox_15.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_15).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_15).set_FormattingEnabled(true);
		comboBox_15.get_Items().AddRange(new object[6]
		{
			Class60.smethod_0(-2050219217),
			Class60.smethod_0(-2050219256),
			Class60.smethod_0(-2050219281),
			Class60.smethod_0(-2050219322),
			Class60.smethod_0(-2050219331),
			Class60.smethod_0(-2050219372)
		});
		((Control)comboBox_15).set_Location(new Point(81, 3));
		((Control)comboBox_15).set_Name(Class60.smethod_0(-2050219445));
		((Control)comboBox_15).set_Size(new Size(171, 26));
		((Control)comboBox_15).set_TabIndex(20);
		comboBox_15.add_SelectedIndexChanged((EventHandler)comboBox_15_SelectedIndexChanged);
		((Control)label_14).set_AutoSize(true);
		((Control)label_14).set_Dock((DockStyle)4);
		((Control)label_14).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_14).set_Location(new Point(36, 0));
		((Control)label_14).set_Name(Class60.smethod_0(-2050225936));
		((Control)label_14).set_Size(new Size(39, 41));
		((Control)label_14).set_TabIndex(18);
		((Control)label_14).set_Text(Class60.smethod_0(-2050219426));
		label_14.set_TextAlign((ContentAlignment)64);
		((Control)groupBox_4).get_Controls().Add((Control)(object)tableLayoutPanel_6);
		((Control)groupBox_4).set_Dock((DockStyle)5);
		((Control)groupBox_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5));
		((Control)groupBox_4).set_ForeColor(SystemColors.Control);
		((Control)groupBox_4).set_Location(new Point(0, 66));
		((Control)groupBox_4).set_Margin(new Padding(0));
		((Control)groupBox_4).set_Name(Class60.smethod_0(-2050225208));
		((Control)groupBox_4).set_Size(new Size(400, 102));
		((Control)groupBox_4).set_TabIndex(7);
		groupBox_4.set_TabStop(false);
		((Control)groupBox_4).set_Text(Class60.smethod_0(-2050219479));
		tableLayoutPanel_6.set_ColumnCount(1);
		tableLayoutPanel_6.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_6.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel_6.get_Controls().Add((Control)(object)tableLayoutPanel_5, 0, 1);
		tableLayoutPanel_6.get_Controls().Add((Control)(object)tableLayoutPanel_7, 0, 0);
		((Control)tableLayoutPanel_6).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_6).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_6).set_Name(Class60.smethod_0(-2050200260));
		tableLayoutPanel_6.set_RowCount(2);
		tableLayoutPanel_6.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		tableLayoutPanel_6.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		((Control)tableLayoutPanel_6).set_Size(new Size(394, 77));
		((Control)tableLayoutPanel_6).set_TabIndex(0);
		tableLayoutPanel_5.set_ColumnCount(3);
		tableLayoutPanel_5.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 45f));
		tableLayoutPanel_5.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_5.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 35f));
		tableLayoutPanel_5.get_Controls().Add((Control)(object)comboBox_16, 1, 0);
		tableLayoutPanel_5.get_Controls().Add((Control)(object)label_23, 0, 0);
		((Control)tableLayoutPanel_5).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_5).set_Location(new Point(0, 38));
		((Control)tableLayoutPanel_5).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_5).set_Name(Class60.smethod_0(-2050211375));
		tableLayoutPanel_5.set_RowCount(1);
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)1, 39f));
		((Control)tableLayoutPanel_5).set_Size(new Size(394, 39));
		((Control)tableLayoutPanel_5).set_TabIndex(0);
		((Control)comboBox_16).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_16).set_Dock((DockStyle)5);
		comboBox_16.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_16).set_Font(new Font(Class60.smethod_0(-2050211150), 9f));
		((ListControl)comboBox_16).set_FormattingEnabled(true);
		((Control)comboBox_16).set_Location(new Point(180, 3));
		((Control)comboBox_16).set_Name(Class60.smethod_0(-2050219506));
		((Control)comboBox_16).set_Size(new Size(72, 25));
		((Control)comboBox_16).set_TabIndex(1);
		comboBox_16.add_SelectedIndexChanged((EventHandler)comboBox_16_SelectedIndexChanged);
		((Control)label_23).set_AutoSize(true);
		((Control)label_23).set_Dock((DockStyle)4);
		((Control)label_23).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_23).set_Location(new Point(97, 0));
		((Control)label_23).set_Name(Class60.smethod_0(-2050225471));
		((Control)label_23).set_Size(new Size(77, 39));
		((Control)label_23).set_TabIndex(2);
		((Control)label_23).set_Text(Class60.smethod_0(-2050225361));
		label_23.set_TextAlign((ContentAlignment)64);
		tableLayoutPanel_7.set_ColumnCount(3);
		tableLayoutPanel_7.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_7.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 45f));
		tableLayoutPanel_7.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 35f));
		tableLayoutPanel_7.get_Controls().Add((Control)(object)button_3, 2, 0);
		tableLayoutPanel_7.get_Controls().Add((Control)(object)label_24, 0, 0);
		tableLayoutPanel_7.get_Controls().Add((Control)(object)comboBox_17, 1, 0);
		((Control)tableLayoutPanel_7).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_7).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_7).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_7).set_Name(Class60.smethod_0(-2050198489));
		tableLayoutPanel_7.set_RowCount(1);
		tableLayoutPanel_7.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_7).set_Size(new Size(394, 38));
		((Control)tableLayoutPanel_7).set_TabIndex(1);
		((Control)button_3).set_BackColor(Color.DarkGray);
		((Control)button_3).set_Cursor(Cursors.get_Hand());
		((Control)button_3).set_Dock((DockStyle)5);
		((ButtonBase)button_3).set_FlatStyle((FlatStyle)0);
		((Control)button_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)1));
		((Control)button_3).set_Location(new Point(258, 3));
		((Control)button_3).set_Name(Class60.smethod_0(-2050219497));
		((Control)button_3).set_Size(new Size(133, 32));
		((Control)button_3).set_TabIndex(0);
		((Control)button_3).set_Text(Class60.smethod_0(-2050216949));
		((ButtonBase)button_3).set_UseVisualStyleBackColor(false);
		((Control)button_3).add_Click((EventHandler)button_3_Click);
		((Control)label_24).set_AutoSize(true);
		((Control)label_24).set_Dock((DockStyle)4);
		((Control)label_24).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_24).set_Location(new Point(36, 0));
		((Control)label_24).set_Name(Class60.smethod_0(-2050225421));
		((Control)label_24).set_Size(new Size(39, 38));
		((Control)label_24).set_TabIndex(0);
		((Control)label_24).set_Text(Class60.smethod_0(-2050219426));
		label_24.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_17).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_17).set_Dock((DockStyle)5);
		comboBox_17.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_17).set_Font(new Font(Class60.smethod_0(-2050211150), 9f));
		((ListControl)comboBox_17).set_FormattingEnabled(true);
		comboBox_17.get_Items().AddRange(new object[2]
		{
			Class60.smethod_0(-2050219535),
			Class60.smethod_0(-2050219568)
		});
		((Control)comboBox_17).set_Location(new Point(81, 3));
		((Control)comboBox_17).set_Name(Class60.smethod_0(-2050219609));
		((Control)comboBox_17).set_Size(new Size(171, 25));
		((Control)comboBox_17).set_TabIndex(1);
		comboBox_17.add_SelectedIndexChanged((EventHandler)comboBox_17_SelectedIndexChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Control)this).set_Name(Class60.smethod_0(-2050219648));
		((Control)this).set_Size(new Size(400, 600));
		((UserControl)this).add_Load((EventHandler)GControl0_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)groupBox_3).ResumeLayout(false);
		((Control)tableLayoutPanel_4).ResumeLayout(false);
		((Control)tableLayoutPanel_4).PerformLayout();
		((Control)groupBox_2).ResumeLayout(false);
		((Control)tableLayoutPanel_3).ResumeLayout(false);
		((Control)tableLayoutPanel_3).PerformLayout();
		((Control)groupBox_1).ResumeLayout(false);
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((Control)tableLayoutPanel_2).PerformLayout();
		((Control)groupBox_0).ResumeLayout(false);
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_1).PerformLayout();
		((Control)groupBox_4).ResumeLayout(false);
		((Control)tableLayoutPanel_6).ResumeLayout(false);
		((Control)tableLayoutPanel_5).ResumeLayout(false);
		((Control)tableLayoutPanel_5).PerformLayout();
		((Control)tableLayoutPanel_7).ResumeLayout(false);
		((Control)tableLayoutPanel_7).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
