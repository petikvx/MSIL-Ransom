using System;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;
using UNIVERSALGAME.Properties;

public sealed class GControl5 : UserControl
{
	public int int_0;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private GroupBox groupBox_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private Label label_0;

	private ComboBox comboBox_0;

	private Label label_1;

	private TextBox textBox_0;

	private GroupBox groupBox_1;

	private TableLayoutPanel tableLayoutPanel_2;

	private Label label_2;

	private ComboBox comboBox_1;

	private Label label_3;

	private TextBox textBox_1;

	private GroupBox groupBox_2;

	private TableLayoutPanel tableLayoutPanel_3;

	private Label label_4;

	private TextBox textBox_2;

	private GroupBox groupBox_3;

	private TableLayoutPanel tableLayoutPanel_4;

	private ComboBox comboBox_2;

	private Label label_5;

	private ComboBox comboBox_3;

	private Label label_6;

	private ComboBox comboBox_4;

	private Label label_7;

	private TextBox textBox_3;

	private Label label_8;

	private GroupBox groupBox_4;

	private TableLayoutPanel tableLayoutPanel_5;

	private ComboBox comboBox_5;

	private Label label_9;

	private Label label_10;

	private ComboBox comboBox_6;

	private GroupBox groupBox_5;

	private TableLayoutPanel tableLayoutPanel_6;

	private Label label_11;

	private TextBox textBox_4;

	private Button button_0;

	private Label label_12;

	private ComboBox comboBox_7;

	private GroupBox groupBox_6;

	private TableLayoutPanel tableLayoutPanel_7;

	private Label label_13;

	private Label label_14;

	private TextBox textBox_5;

	private TextBox textBox_6;

	private GroupBox groupBox_7;

	private TableLayoutPanel tableLayoutPanel_8;

	private Label label_15;

	private ComboBox comboBox_8;

	public GControl5()
	{
		method_1();
	}

	public void method_0()
	{
		try
		{
			if (int_0 == 0)
			{
				((ListControl)comboBox_8).set_SelectedIndex(Settings.Default.Distance_Attack);
				((ListControl)comboBox_0).set_SelectedIndex(Settings.Default.HP_Percent);
				((ListControl)comboBox_3).set_SelectedIndex(Settings.Default.HP_Escape);
				((ListControl)comboBox_5).set_SelectedIndex(Settings.Default.HP_Sitdown);
				((Control)textBox_0).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.HP_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_1).set_SelectedIndex(Settings.Default.SP_Percent);
				((ListControl)comboBox_6).set_SelectedIndex(Settings.Default.SP_Sitdown);
				((Control)textBox_1).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.SP_Hotkey + Class60.smethod_0(-2050195546));
				((Control)textBox_2).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.Wing_Hotkey + Class60.smethod_0(-2050195546));
				((Control)textBox_3).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.BWing_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_2).set_SelectedIndex(Settings.Default.Over_Weight);
				((ListControl)comboBox_4).set_SelectedIndex(Settings.Default.Scrum_Escape);
				((ListControl)comboBox_7).set_SelectedIndex(Settings.Default.Monster_Over_Escape);
				((Control)textBox_5).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.Arrow_Box_Hotkey + Class60.smethod_0(-2050195546));
				((Control)textBox_6).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.Arrow_Hotkey + Class60.smethod_0(-2050195546));
			}
			else if (int_0 == 1)
			{
				((ListControl)comboBox_8).set_SelectedIndex(Settings.Default.Distance_Attack);
				((ListControl)comboBox_0).set_SelectedIndex(Settings.Default._2_HP_Percent);
				((ListControl)comboBox_3).set_SelectedIndex(Settings.Default._2_HP_Escape);
				((ListControl)comboBox_5).set_SelectedIndex(Settings.Default._2_HP_Sitdown);
				((Control)textBox_0).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._2_HP_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_1).set_SelectedIndex(Settings.Default._2_SP_Percent);
				((ListControl)comboBox_6).set_SelectedIndex(Settings.Default._2_SP_Sitdown);
				((Control)textBox_1).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._2_SP_Hotkey + Class60.smethod_0(-2050195546));
				((Control)textBox_2).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._2_Wing_Hotkey + Class60.smethod_0(-2050195546));
				((Control)textBox_3).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._2_BWing_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_2).set_SelectedIndex(Settings.Default._2_Over_Weight);
				((ListControl)comboBox_4).set_SelectedIndex(Settings.Default._2_Scrum_Escape);
				((ListControl)comboBox_7).set_SelectedIndex(Settings.Default._2_Monster_Over_Escape);
				((Control)textBox_5).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.Arrow_Box_Hotkey + Class60.smethod_0(-2050195546));
				((Control)textBox_6).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.Arrow_Hotkey + Class60.smethod_0(-2050195546));
				if (!string.IsNullOrEmpty(Settings.Default.Line_Token))
				{
					((Control)textBox_4).set_Text(Settings.Default.Line_Token);
					((Control)button_0).set_BackColor(Color.LightSeaGreen);
				}
				((Control)textBox_4).set_Enabled(false);
				((Control)button_0).set_Enabled(false);
			}
			else if (int_0 == 2)
			{
				((ListControl)comboBox_8).set_SelectedIndex(Settings.Default.Distance_Attack);
				((ListControl)comboBox_0).set_SelectedIndex(Settings.Default._3_HP_Percent);
				((ListControl)comboBox_3).set_SelectedIndex(Settings.Default._3_HP_Escape);
				((ListControl)comboBox_5).set_SelectedIndex(Settings.Default._3_HP_Sitdown);
				((Control)textBox_0).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._3_HP_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_1).set_SelectedIndex(Settings.Default._3_SP_Percent);
				((ListControl)comboBox_6).set_SelectedIndex(Settings.Default._3_SP_Sitdown);
				((Control)textBox_1).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._3_SP_Hotkey + Class60.smethod_0(-2050195546));
				((Control)textBox_2).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._3_Wing_Hotkey + Class60.smethod_0(-2050195546));
				((Control)textBox_3).set_Text(Class60.smethod_0(-2050195538) + Settings.Default._3_BWing_Hotkey + Class60.smethod_0(-2050195546));
				((ListControl)comboBox_2).set_SelectedIndex(Settings.Default._3_Over_Weight);
				((ListControl)comboBox_4).set_SelectedIndex(Settings.Default._3_Scrum_Escape);
				((ListControl)comboBox_7).set_SelectedIndex(Settings.Default._3_Monster_Over_Escape);
				((Control)textBox_5).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.Arrow_Box_Hotkey + Class60.smethod_0(-2050195546));
				((Control)textBox_6).set_Text(Class60.smethod_0(-2050195538) + Settings.Default.Arrow_Hotkey + Class60.smethod_0(-2050195546));
				((Control)textBox_4).set_Enabled(false);
				((Control)button_0).set_Enabled(false);
			}
			if (!string.IsNullOrEmpty(Settings.Default.Line_Token))
			{
				((Control)textBox_4).set_Text(Settings.Default.Line_Token);
				((Control)button_0).set_BackColor(Color.LightSeaGreen);
			}
		}
		catch
		{
		}
	}

	private void GControl5_Load(object sender, EventArgs e)
	{
		method_0();
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
				@default.HP_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings default2 = Settings.Default;
				keyCode = e.get_KeyCode();
				default2._2_HP_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings default3 = Settings.Default;
				keyCode = e.get_KeyCode();
				default3._3_HP_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			e.set_SuppressKeyPress(true);
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
				@default.SP_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings default2 = Settings.Default;
				keyCode = e.get_KeyCode();
				default2._2_SP_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings default3 = Settings.Default;
				keyCode = e.get_KeyCode();
				default3._3_SP_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
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
				@default.Wing_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings default2 = Settings.Default;
				keyCode = e.get_KeyCode();
				default2._2_Wing_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings default3 = Settings.Default;
				keyCode = e.get_KeyCode();
				default3._3_Wing_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
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
				@default.BWing_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings default2 = Settings.Default;
				keyCode = e.get_KeyCode();
				default2._2_BWing_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings default3 = Settings.Default;
				keyCode = e.get_KeyCode();
				default3._3_BWing_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	private void textBox_5_KeyDown(object sender, KeyEventArgs e)
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
			((Control)textBox_5).set_Text(string.Concat(Class60.smethod_0(-2050195538), e.get_KeyCode(), Class60.smethod_0(-2050195546)));
			Keys keyCode;
			if (int_0 == 0)
			{
				Settings @default = Settings.Default;
				keyCode = e.get_KeyCode();
				@default.Arrow_Box_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings default2 = Settings.Default;
				keyCode = e.get_KeyCode();
				default2.Arrow_Box_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings default3 = Settings.Default;
				keyCode = e.get_KeyCode();
				default3.Arrow_Box_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	private void textBox_6_KeyDown(object sender, KeyEventArgs e)
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
			((Control)textBox_6).set_Text(string.Concat(Class60.smethod_0(-2050195538), e.get_KeyCode(), Class60.smethod_0(-2050195546)));
			Keys keyCode;
			if (int_0 == 0)
			{
				Settings @default = Settings.Default;
				keyCode = e.get_KeyCode();
				@default.Arrow_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings default2 = Settings.Default;
				keyCode = e.get_KeyCode();
				default2.Arrow_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings default3 = Settings.Default;
				keyCode = e.get_KeyCode();
				default3.Arrow_Hotkey = ((object)(Keys)(ref keyCode)).ToString();
				((SettingsBase)Settings.Default).Save();
			}
			e.set_SuppressKeyPress(true);
		}
		catch
		{
		}
	}

	private void comboBox_8_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.Distance_Attack = ((ListControl)comboBox_8).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default.Distance_Attack = ((ListControl)comboBox_8).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default.Distance_Attack = ((ListControl)comboBox_8).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_0_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.HP_Percent = ((ListControl)comboBox_0).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_HP_Percent = ((ListControl)comboBox_0).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_HP_Percent = ((ListControl)comboBox_0).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_5_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.HP_Sitdown = ((ListControl)comboBox_5).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_HP_Sitdown = ((ListControl)comboBox_5).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_HP_Sitdown = ((ListControl)comboBox_5).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_3_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.HP_Escape = ((ListControl)comboBox_3).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_HP_Escape = ((ListControl)comboBox_3).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_HP_Escape = ((ListControl)comboBox_3).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_1_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SP_Percent = ((ListControl)comboBox_1).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SP_Percent = ((ListControl)comboBox_1).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SP_Percent = ((ListControl)comboBox_1).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_6_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.SP_Sitdown = ((ListControl)comboBox_6).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_SP_Sitdown = ((ListControl)comboBox_6).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_SP_Sitdown = ((ListControl)comboBox_6).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_2_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.Over_Weight = ((ListControl)comboBox_2).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_Over_Weight = ((ListControl)comboBox_2).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_Over_Weight = ((ListControl)comboBox_2).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_4_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.Scrum_Escape = ((ListControl)comboBox_4).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_Scrum_Escape = ((ListControl)comboBox_4).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_Scrum_Escape = ((ListControl)comboBox_4).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void comboBox_7_SelectedIndexChanged(object sender, EventArgs e)
	{
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.Monster_Over_Escape = ((ListControl)comboBox_7).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 1)
			{
				Settings.Default._2_Monster_Over_Escape = ((ListControl)comboBox_7).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
			else if (int_0 == 2)
			{
				Settings.Default._3_Monster_Over_Escape = ((ListControl)comboBox_7).get_SelectedIndex();
				((SettingsBase)Settings.Default).Save();
			}
		}
		catch
		{
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		try
		{
			if (int_0 == 0)
			{
				Settings.Default.Line_Token = ((Control)textBox_4).get_Text().Trim();
				((SettingsBase)Settings.Default).Save();
				((Control)button_0).set_BackColor(Color.LightSeaGreen);
			}
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
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_031e: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_040d: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Unknown result type (might be due to invalid IL or missing references)
		//IL_046c: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_049a: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c0: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_04ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f8: Expected O, but got Unknown
		//IL_050a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Expected O, but got Unknown
		//IL_0642: Unknown result type (might be due to invalid IL or missing references)
		//IL_064c: Expected O, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_0702: Unknown result type (might be due to invalid IL or missing references)
		//IL_070c: Expected O, but got Unknown
		//IL_0760: Unknown result type (might be due to invalid IL or missing references)
		//IL_076a: Expected O, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_0812: Expected O, but got Unknown
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a11: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1b: Expected O, but got Unknown
		//IL_0a2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a37: Expected O, but got Unknown
		//IL_0b19: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b23: Expected O, but got Unknown
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3f: Expected O, but got Unknown
		//IL_0b51: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b5b: Expected O, but got Unknown
		//IL_0b6d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b77: Expected O, but got Unknown
		//IL_0b89: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b93: Expected O, but got Unknown
		//IL_0ba5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0baf: Expected O, but got Unknown
		//IL_0c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c1d: Expected O, but got Unknown
		//IL_0d27: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d31: Expected O, but got Unknown
		//IL_0ddf: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de9: Expected O, but got Unknown
		//IL_0ea6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb0: Expected O, but got Unknown
		//IL_0fed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff7: Expected O, but got Unknown
		//IL_1099: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a3: Expected O, but got Unknown
		//IL_111b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1125: Expected O, but got Unknown
		//IL_1174: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fe: Expected O, but got Unknown
		//IL_1210: Unknown result type (might be due to invalid IL or missing references)
		//IL_121a: Expected O, but got Unknown
		//IL_129c: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a6: Expected O, but got Unknown
		//IL_12fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1304: Expected O, but got Unknown
		//IL_13a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_13af: Expected O, but got Unknown
		//IL_1426: Unknown result type (might be due to invalid IL or missing references)
		//IL_1430: Expected O, but got Unknown
		//IL_147f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1502: Unknown result type (might be due to invalid IL or missing references)
		//IL_150c: Expected O, but got Unknown
		//IL_151e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1528: Expected O, but got Unknown
		//IL_160a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1614: Expected O, but got Unknown
		//IL_1626: Unknown result type (might be due to invalid IL or missing references)
		//IL_1630: Expected O, but got Unknown
		//IL_1642: Unknown result type (might be due to invalid IL or missing references)
		//IL_164c: Expected O, but got Unknown
		//IL_16a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16aa: Expected O, but got Unknown
		//IL_1758: Unknown result type (might be due to invalid IL or missing references)
		//IL_1762: Expected O, but got Unknown
		//IL_181f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1829: Expected O, but got Unknown
		//IL_1966: Unknown result type (might be due to invalid IL or missing references)
		//IL_1970: Expected O, but got Unknown
		//IL_1a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1c: Expected O, but got Unknown
		//IL_1a94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a9e: Expected O, but got Unknown
		//IL_1ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae8: Expected O, but got Unknown
		//IL_1c10: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c90: Unknown result type (might be due to invalid IL or missing references)
		//IL_1c9a: Expected O, but got Unknown
		//IL_1cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_1cb6: Expected O, but got Unknown
		//IL_1d38: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d42: Expected O, but got Unknown
		//IL_1d54: Unknown result type (might be due to invalid IL or missing references)
		//IL_1d5e: Expected O, but got Unknown
		//IL_1dc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1dcc: Expected O, but got Unknown
		//IL_1f09: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f13: Expected O, but got Unknown
		//IL_1fdf: Unknown result type (might be due to invalid IL or missing references)
		//IL_205f: Unknown result type (might be due to invalid IL or missing references)
		//IL_2069: Expected O, but got Unknown
		//IL_207b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2085: Expected O, but got Unknown
		//IL_2107: Unknown result type (might be due to invalid IL or missing references)
		//IL_2111: Expected O, but got Unknown
		//IL_2123: Unknown result type (might be due to invalid IL or missing references)
		//IL_212d: Expected O, but got Unknown
		//IL_2175: Unknown result type (might be due to invalid IL or missing references)
		//IL_217f: Expected O, but got Unknown
		//IL_21e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_21f0: Expected O, but got Unknown
		//IL_221e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2228: Expected O, but got Unknown
		//IL_22e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_2365: Unknown result type (might be due to invalid IL or missing references)
		//IL_236f: Expected O, but got Unknown
		//IL_2381: Unknown result type (might be due to invalid IL or missing references)
		//IL_238b: Expected O, but got Unknown
		//IL_243d: Unknown result type (might be due to invalid IL or missing references)
		//IL_2447: Expected O, but got Unknown
		//IL_2459: Unknown result type (might be due to invalid IL or missing references)
		//IL_2463: Expected O, but got Unknown
		//IL_24b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_24bf: Expected O, but got Unknown
		//IL_255a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2564: Expected O, but got Unknown
		//IL_25f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_2600: Expected O, but got Unknown
		//IL_2667: Unknown result type (might be due to invalid IL or missing references)
		//IL_2671: Expected O, but got Unknown
		//IL_2695: Unknown result type (might be due to invalid IL or missing references)
		//IL_269f: Expected O, but got Unknown
		//IL_2707: Unknown result type (might be due to invalid IL or missing references)
		//IL_2711: Expected O, but got Unknown
		//IL_275c: Unknown result type (might be due to invalid IL or missing references)
		//IL_27e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_27ea: Expected O, but got Unknown
		//IL_27fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_2806: Expected O, but got Unknown
		//IL_2918: Unknown result type (might be due to invalid IL or missing references)
		//IL_2922: Expected O, but got Unknown
		//IL_2934: Unknown result type (might be due to invalid IL or missing references)
		//IL_293e: Expected O, but got Unknown
		//IL_2950: Unknown result type (might be due to invalid IL or missing references)
		//IL_295a: Expected O, but got Unknown
		//IL_296c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2976: Expected O, but got Unknown
		//IL_29cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_29d7: Expected O, but got Unknown
		//IL_2a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a9f: Expected O, but got Unknown
		//IL_2bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bcc: Expected O, but got Unknown
		//IL_2c8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2c94: Expected O, but got Unknown
		//IL_2df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_2dfa: Expected O, but got Unknown
		//IL_2f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f4d: Expected O, but got Unknown
		//IL_2fea: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ff4: Expected O, but got Unknown
		//IL_30a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_30af: Expected O, but got Unknown
		tableLayoutPanel_0 = new TableLayoutPanel();
		groupBox_5 = new GroupBox();
		tableLayoutPanel_6 = new TableLayoutPanel();
		label_11 = new Label();
		textBox_4 = new TextBox();
		button_0 = new Button();
		groupBox_0 = new GroupBox();
		tableLayoutPanel_1 = new TableLayoutPanel();
		comboBox_5 = new ComboBox();
		label_9 = new Label();
		label_0 = new Label();
		comboBox_0 = new ComboBox();
		label_1 = new Label();
		textBox_0 = new TextBox();
		groupBox_2 = new GroupBox();
		tableLayoutPanel_3 = new TableLayoutPanel();
		label_4 = new Label();
		textBox_2 = new TextBox();
		groupBox_1 = new GroupBox();
		tableLayoutPanel_2 = new TableLayoutPanel();
		label_10 = new Label();
		label_2 = new Label();
		comboBox_1 = new ComboBox();
		label_3 = new Label();
		textBox_1 = new TextBox();
		comboBox_6 = new ComboBox();
		groupBox_3 = new GroupBox();
		tableLayoutPanel_4 = new TableLayoutPanel();
		comboBox_2 = new ComboBox();
		label_5 = new Label();
		groupBox_4 = new GroupBox();
		tableLayoutPanel_5 = new TableLayoutPanel();
		textBox_3 = new TextBox();
		label_8 = new Label();
		groupBox_6 = new GroupBox();
		tableLayoutPanel_7 = new TableLayoutPanel();
		label_13 = new Label();
		label_14 = new Label();
		textBox_5 = new TextBox();
		textBox_6 = new TextBox();
		groupBox_7 = new GroupBox();
		tableLayoutPanel_8 = new TableLayoutPanel();
		label_6 = new Label();
		comboBox_3 = new ComboBox();
		label_7 = new Label();
		comboBox_4 = new ComboBox();
		comboBox_7 = new ComboBox();
		label_12 = new Label();
		label_15 = new Label();
		comboBox_8 = new ComboBox();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)groupBox_5).SuspendLayout();
		((Control)tableLayoutPanel_6).SuspendLayout();
		((Control)groupBox_0).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)groupBox_2).SuspendLayout();
		((Control)tableLayoutPanel_3).SuspendLayout();
		((Control)groupBox_1).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((Control)groupBox_3).SuspendLayout();
		((Control)tableLayoutPanel_4).SuspendLayout();
		((Control)groupBox_4).SuspendLayout();
		((Control)tableLayoutPanel_5).SuspendLayout();
		((Control)groupBox_6).SuspendLayout();
		((Control)tableLayoutPanel_7).SuspendLayout();
		((Control)groupBox_7).SuspendLayout();
		((Control)tableLayoutPanel_8).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)tableLayoutPanel_0).set_BackColor(Color.DarkSlateGray);
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_5, 0, 7);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_0, 0, 1);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_2, 0, 4);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_1, 0, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_3, 0, 6);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_4, 0, 5);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_6, 0, 3);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_7, 0, 0);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)0));
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_0).set_Margin(new Padding(0));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(8);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 21f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 17f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 17f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 12f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 8f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 8f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 8f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 9f));
		((Control)tableLayoutPanel_0).set_Size(new Size(450, 768));
		((Control)tableLayoutPanel_0).set_TabIndex(0);
		((Control)groupBox_5).get_Controls().Add((Control)(object)tableLayoutPanel_6);
		((Control)groupBox_5).set_Dock((DockStyle)5);
		((Control)groupBox_5).set_ForeColor(SystemColors.Control);
		((Control)groupBox_5).set_Location(new Point(0, 696));
		((Control)groupBox_5).set_Margin(new Padding(0));
		((Control)groupBox_5).set_Name(Class60.smethod_0(-2050198412));
		((Control)groupBox_5).set_Size(new Size(450, 72));
		((Control)groupBox_5).set_TabIndex(8);
		groupBox_5.set_TabStop(false);
		((Control)groupBox_5).set_Text(Class60.smethod_0(-2050223021));
		tableLayoutPanel_6.set_ColumnCount(3);
		tableLayoutPanel_6.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 15f));
		tableLayoutPanel_6.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 65f));
		tableLayoutPanel_6.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_6.get_Controls().Add((Control)(object)label_11, 0, 0);
		tableLayoutPanel_6.get_Controls().Add((Control)(object)textBox_4, 1, 0);
		tableLayoutPanel_6.get_Controls().Add((Control)(object)button_0, 2, 0);
		((Control)tableLayoutPanel_6).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_6).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_6).set_Name(Class60.smethod_0(-2050206985));
		tableLayoutPanel_6.set_RowCount(1);
		tableLayoutPanel_6.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_6).set_Size(new Size(444, 47));
		((Control)tableLayoutPanel_6).set_TabIndex(0);
		((Control)label_11).set_AutoSize(true);
		((Control)label_11).set_Dock((DockStyle)4);
		((Control)label_11).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_11).set_ForeColor(SystemColors.Control);
		((Control)label_11).set_Location(new Point(12, 0));
		((Control)label_11).set_Name(Class60.smethod_0(-2050225881));
		((Control)label_11).set_Size(new Size(51, 47));
		((Control)label_11).set_TabIndex(0);
		((Control)label_11).set_Text(Class60.smethod_0(-2050223050));
		label_11.set_TextAlign((ContentAlignment)64);
		((Control)textBox_4).set_Dock((DockStyle)5);
		((Control)textBox_4).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_4).set_Location(new Point(69, 3));
		((Control)textBox_4).set_Name(Class60.smethod_0(-2050223100));
		((Control)textBox_4).set_Size(new Size(282, 23));
		((Control)textBox_4).set_TabIndex(1);
		((Control)button_0).set_BackColor(Color.DarkGray);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button_0).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)0);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_0).set_Location(new Point(357, 3));
		((Control)button_0).set_Name(Class60.smethod_0(-2050216984));
		((Control)button_0).set_Size(new Size(84, 24));
		((Control)button_0).set_TabIndex(2);
		((Control)button_0).set_Text(Class60.smethod_0(-2050225268));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)groupBox_0).get_Controls().Add((Control)(object)tableLayoutPanel_1);
		((Control)groupBox_0).set_Dock((DockStyle)5);
		((Control)groupBox_0).set_ForeColor(SystemColors.Control);
		((Control)groupBox_0).set_Location(new Point(0, 161));
		((Control)groupBox_0).set_Margin(new Padding(0));
		((Control)groupBox_0).set_Name(Class60.smethod_0(-2050210886));
		((Control)groupBox_0).set_Size(new Size(450, 130));
		((Control)groupBox_0).set_TabIndex(0);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050216964));
		tableLayoutPanel_1.set_ColumnCount(2);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)comboBox_5, 1, 2);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_9, 0, 2);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_0, 0, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)comboBox_0, 1, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_1, 0, 1);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)textBox_0, 1, 1);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_1.set_RowCount(3);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 34f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 20f));
		((Control)tableLayoutPanel_1).set_Size(new Size(444, 105));
		((Control)tableLayoutPanel_1).set_TabIndex(0);
		((Control)comboBox_5).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_5).set_Dock((DockStyle)5);
		comboBox_5.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_5).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)comboBox_5).set_ForeColor(SystemColors.WindowText);
		((ListControl)comboBox_5).set_FormattingEnabled(true);
		comboBox_5.get_Items().AddRange(new object[5]
		{
			Class60.smethod_0(-2050205620),
			Class60.smethod_0(-2050216997),
			Class60.smethod_0(-2050217004),
			Class60.smethod_0(-2050195886),
			Class60.smethod_0(-2050195879)
		});
		((Control)comboBox_5).set_Location(new Point(269, 71));
		((Control)comboBox_5).set_Name(Class60.smethod_0(-2050217043));
		((Control)comboBox_5).set_Size(new Size(172, 23));
		((Control)comboBox_5).set_TabIndex(9);
		comboBox_5.add_SelectedIndexChanged((EventHandler)comboBox_5_SelectedIndexChanged);
		((Control)label_9).set_AutoSize(true);
		((Control)label_9).set_Dock((DockStyle)4);
		((Control)label_9).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_9).set_ForeColor(SystemColors.Control);
		((Control)label_9).set_Location(new Point(143, 68));
		((Control)label_9).set_Name(Class60.smethod_0(-2050225987));
		((Control)label_9).set_Size(new Size(120, 37));
		((Control)label_9).set_TabIndex(8);
		((Control)label_9).set_Text(Class60.smethod_0(-2050217038));
		label_9.set_TextAlign((ContentAlignment)64);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Dock((DockStyle)4);
		((Control)label_0).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_ForeColor(SystemColors.Control);
		((Control)label_0).set_Location(new Point(159, 0));
		((Control)label_0).set_Name(Class60.smethod_0(-2050208088));
		((Control)label_0).set_Size(new Size(104, 34));
		((Control)label_0).set_TabIndex(0);
		((Control)label_0).set_Text(Class60.smethod_0(-2050217095));
		label_0.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_0).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_0).set_Dock((DockStyle)5);
		comboBox_0.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)comboBox_0).set_ForeColor(SystemColors.WindowText);
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		comboBox_0.get_Items().AddRange(new object[9]
		{
			Class60.smethod_0(-2050205620),
			Class60.smethod_0(-2050216997),
			Class60.smethod_0(-2050217004),
			Class60.smethod_0(-2050195886),
			Class60.smethod_0(-2050195879),
			Class60.smethod_0(-2050195904),
			Class60.smethod_0(-2050195849),
			Class60.smethod_0(-2050195842),
			Class60.smethod_0(-2050195867)
		});
		((Control)comboBox_0).set_Location(new Point(269, 3));
		((Control)comboBox_0).set_Name(Class60.smethod_0(-2050196120));
		((Control)comboBox_0).set_Size(new Size(172, 23));
		((Control)comboBox_0).set_TabIndex(1);
		comboBox_0.add_SelectedIndexChanged((EventHandler)comboBox_0_SelectedIndexChanged);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Dock((DockStyle)4);
		((Control)label_1).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_ForeColor(SystemColors.Control);
		((Control)label_1).set_Location(new Point(144, 34));
		((Control)label_1).set_Name(Class60.smethod_0(-2050210921));
		((Control)label_1).set_Size(new Size(119, 34));
		((Control)label_1).set_TabIndex(2);
		((Control)label_1).set_Text(Class60.smethod_0(-2050217130));
		label_1.set_TextAlign((ContentAlignment)64);
		((Control)textBox_0).set_Dock((DockStyle)5);
		((Control)textBox_0).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_ForeColor(SystemColors.WindowText);
		((Control)textBox_0).set_Location(new Point(269, 37));
		((TextBoxBase)textBox_0).set_MaxLength(3);
		((Control)textBox_0).set_Name(Class60.smethod_0(-2050196099));
		((Control)textBox_0).set_Size(new Size(172, 23));
		((Control)textBox_0).set_TabIndex(3);
		((Control)textBox_0).add_KeyDown(new KeyEventHandler(textBox_0_KeyDown));
		((Control)groupBox_2).get_Controls().Add((Control)(object)tableLayoutPanel_3);
		((Control)groupBox_2).set_Dock((DockStyle)5);
		((Control)groupBox_2).set_ForeColor(SystemColors.Control);
		((Control)groupBox_2).set_Location(new Point(0, 513));
		((Control)groupBox_2).set_Margin(new Padding(0));
		((Control)groupBox_2).set_Name(Class60.smethod_0(-2050198717));
		((Control)groupBox_2).set_Size(new Size(450, 61));
		((Control)groupBox_2).set_TabIndex(2);
		groupBox_2.set_TabStop(false);
		((Control)groupBox_2).set_Text(Class60.smethod_0(-2050217191));
		tableLayoutPanel_3.set_ColumnCount(2);
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_3.get_Controls().Add((Control)(object)label_4, 0, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)textBox_2, 1, 0);
		((Control)tableLayoutPanel_3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_3).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_3).set_Name(Class60.smethod_0(-2050211259));
		tableLayoutPanel_3.set_RowCount(1);
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_3).set_Size(new Size(444, 36));
		((Control)tableLayoutPanel_3).set_TabIndex(0);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Dock((DockStyle)4);
		((Control)label_4).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_4).set_ForeColor(SystemColors.Control);
		((Control)label_4).set_Location(new Point(144, 0));
		((Control)label_4).set_Name(Class60.smethod_0(-2050198190));
		((Control)label_4).set_Size(new Size(119, 36));
		((Control)label_4).set_TabIndex(0);
		((Control)label_4).set_Text(Class60.smethod_0(-2050217130));
		label_4.set_TextAlign((ContentAlignment)64);
		((Control)textBox_2).set_Dock((DockStyle)5);
		((Control)textBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_2).set_ForeColor(SystemColors.WindowText);
		((Control)textBox_2).set_Location(new Point(269, 3));
		((TextBoxBase)textBox_2).set_MaxLength(3);
		((Control)textBox_2).set_Name(Class60.smethod_0(-2050217248));
		((Control)textBox_2).set_Size(new Size(172, 23));
		((Control)textBox_2).set_TabIndex(1);
		((Control)textBox_2).add_KeyDown(new KeyEventHandler(textBox_2_KeyDown));
		((Control)groupBox_1).get_Controls().Add((Control)(object)tableLayoutPanel_2);
		((Control)groupBox_1).set_Dock((DockStyle)5);
		((Control)groupBox_1).set_ForeColor(SystemColors.Control);
		((Control)groupBox_1).set_Location(new Point(0, 291));
		((Control)groupBox_1).set_Margin(new Padding(0));
		((Control)groupBox_1).set_Name(Class60.smethod_0(-2050207223));
		((Control)groupBox_1).set_Size(new Size(450, 130));
		((Control)groupBox_1).set_TabIndex(1);
		groupBox_1.set_TabStop(false);
		((Control)groupBox_1).set_Text(Class60.smethod_0(-2050217226));
		tableLayoutPanel_2.set_ColumnCount(2);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_10, 0, 2);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_2, 0, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)comboBox_1, 1, 0);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)label_3, 0, 1);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)textBox_1, 1, 1);
		tableLayoutPanel_2.get_Controls().Add((Control)(object)comboBox_6, 1, 2);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_2.set_RowCount(3);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 34f));
		((Control)tableLayoutPanel_2).set_Size(new Size(444, 105));
		((Control)tableLayoutPanel_2).set_TabIndex(0);
		((Control)label_10).set_AutoSize(true);
		((Control)label_10).set_Dock((DockStyle)4);
		((Control)label_10).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_10).set_ForeColor(SystemColors.Control);
		((Control)label_10).set_Location(new Point(144, 68));
		((Control)label_10).set_Name(Class60.smethod_0(-2050225936));
		((Control)label_10).set_Size(new Size(119, 37));
		((Control)label_10).set_TabIndex(5);
		((Control)label_10).set_Text(Class60.smethod_0(-2050217261));
		label_10.set_TextAlign((ContentAlignment)64);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_Dock((DockStyle)4);
		((Control)label_2).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_ForeColor(SystemColors.Control);
		((Control)label_2).set_Location(new Point(160, 0));
		((Control)label_2).set_Name(Class60.smethod_0(-2050210999));
		((Control)label_2).set_Size(new Size(103, 34));
		((Control)label_2).set_TabIndex(0);
		((Control)label_2).set_Text(Class60.smethod_0(-2050217318));
		label_2.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_1).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_1).set_Dock((DockStyle)5);
		comboBox_1.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)comboBox_1).set_ForeColor(SystemColors.WindowText);
		((ListControl)comboBox_1).set_FormattingEnabled(true);
		comboBox_1.get_Items().AddRange(new object[9]
		{
			Class60.smethod_0(-2050205620),
			Class60.smethod_0(-2050216997),
			Class60.smethod_0(-2050217004),
			Class60.smethod_0(-2050195886),
			Class60.smethod_0(-2050195879),
			Class60.smethod_0(-2050195904),
			Class60.smethod_0(-2050195849),
			Class60.smethod_0(-2050195842),
			Class60.smethod_0(-2050195867)
		});
		((Control)comboBox_1).set_Location(new Point(269, 3));
		((Control)comboBox_1).set_Name(Class60.smethod_0(-2050195925));
		((Control)comboBox_1).set_Size(new Size(172, 23));
		((Control)comboBox_1).set_TabIndex(1);
		comboBox_1.add_SelectedIndexChanged((EventHandler)comboBox_1_SelectedIndexChanged);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Dock((DockStyle)4);
		((Control)label_3).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_3).set_ForeColor(SystemColors.Control);
		((Control)label_3).set_Location(new Point(144, 34));
		((Control)label_3).set_Name(Class60.smethod_0(-2050207156));
		((Control)label_3).set_Size(new Size(119, 34));
		((Control)label_3).set_TabIndex(2);
		((Control)label_3).set_Text(Class60.smethod_0(-2050217130));
		label_3.set_TextAlign((ContentAlignment)64);
		((Control)textBox_1).set_Dock((DockStyle)5);
		((Control)textBox_1).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_1).set_ForeColor(SystemColors.WindowText);
		((Control)textBox_1).set_Location(new Point(269, 37));
		((TextBoxBase)textBox_1).set_MaxLength(3);
		((Control)textBox_1).set_Name(Class60.smethod_0(-2050195920));
		((Control)textBox_1).set_Size(new Size(172, 23));
		((Control)textBox_1).set_TabIndex(3);
		((Control)textBox_1).add_KeyDown(new KeyEventHandler(textBox_1_KeyDown));
		((Control)comboBox_6).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_6).set_Dock((DockStyle)5);
		comboBox_6.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_6).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)comboBox_6).set_ForeColor(SystemColors.WindowText);
		((ListControl)comboBox_6).set_FormattingEnabled(true);
		comboBox_6.get_Items().AddRange(new object[5]
		{
			Class60.smethod_0(-2050205620),
			Class60.smethod_0(-2050216997),
			Class60.smethod_0(-2050217004),
			Class60.smethod_0(-2050195886),
			Class60.smethod_0(-2050195879)
		});
		((Control)comboBox_6).set_Location(new Point(269, 71));
		((Control)comboBox_6).set_Name(Class60.smethod_0(-2050217353));
		((Control)comboBox_6).set_Size(new Size(172, 23));
		((Control)comboBox_6).set_TabIndex(4);
		comboBox_6.add_SelectedIndexChanged((EventHandler)comboBox_6_SelectedIndexChanged);
		((Control)groupBox_3).get_Controls().Add((Control)(object)tableLayoutPanel_4);
		((Control)groupBox_3).set_Dock((DockStyle)5);
		((Control)groupBox_3).set_ForeColor(SystemColors.Control);
		((Control)groupBox_3).set_Location(new Point(0, 635));
		((Control)groupBox_3).set_Margin(new Padding(0));
		((Control)groupBox_3).set_Name(Class60.smethod_0(-2050198080));
		((Control)groupBox_3).set_Size(new Size(450, 61));
		((Control)groupBox_3).set_TabIndex(6);
		groupBox_3.set_TabStop(false);
		((Control)groupBox_3).set_Text(Class60.smethod_0(-2050217380));
		tableLayoutPanel_4.set_ColumnCount(2);
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_4.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_4.get_Controls().Add((Control)(object)comboBox_2, 0, 0);
		tableLayoutPanel_4.get_Controls().Add((Control)(object)label_5, 0, 0);
		((Control)tableLayoutPanel_4).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_4).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_4).set_Name(Class60.smethod_0(-2050198489));
		tableLayoutPanel_4.set_RowCount(1);
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_4.get_RowStyles().Add(new RowStyle((SizeType)1, 36f));
		((Control)tableLayoutPanel_4).set_Size(new Size(444, 36));
		((Control)tableLayoutPanel_4).set_TabIndex(0);
		((Control)comboBox_2).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_2).set_Dock((DockStyle)5);
		comboBox_2.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_2).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)comboBox_2).set_ForeColor(SystemColors.WindowText);
		((ListControl)comboBox_2).set_FormattingEnabled(true);
		comboBox_2.get_Items().AddRange(new object[9]
		{
			Class60.smethod_0(-2050205620),
			Class60.smethod_0(-2050216997),
			Class60.smethod_0(-2050217004),
			Class60.smethod_0(-2050195886),
			Class60.smethod_0(-2050195879),
			Class60.smethod_0(-2050195904),
			Class60.smethod_0(-2050195849),
			Class60.smethod_0(-2050195842),
			Class60.smethod_0(-2050195867)
		});
		((Control)comboBox_2).set_Location(new Point(269, 3));
		((Control)comboBox_2).set_Name(Class60.smethod_0(-2050217409));
		((Control)comboBox_2).set_Size(new Size(172, 23));
		((Control)comboBox_2).set_TabIndex(2);
		comboBox_2.add_SelectedIndexChanged((EventHandler)comboBox_2_SelectedIndexChanged);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Dock((DockStyle)4);
		((Control)label_5).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_5).set_ForeColor(SystemColors.Control);
		((Control)label_5).set_Location(new Point(172, 0));
		((Control)label_5).set_Name(Class60.smethod_0(-2050225950));
		((Control)label_5).set_Size(new Size(91, 36));
		((Control)label_5).set_TabIndex(0);
		((Control)label_5).set_Text(Class60.smethod_0(-2050217468));
		label_5.set_TextAlign((ContentAlignment)64);
		((Control)groupBox_4).get_Controls().Add((Control)(object)tableLayoutPanel_5);
		((Control)groupBox_4).set_Dock((DockStyle)5);
		((Control)groupBox_4).set_ForeColor(SystemColors.Control);
		((Control)groupBox_4).set_Location(new Point(0, 574));
		((Control)groupBox_4).set_Margin(new Padding(0));
		((Control)groupBox_4).set_Name(Class60.smethod_0(-2050225208));
		((Control)groupBox_4).set_Size(new Size(450, 61));
		((Control)groupBox_4).set_TabIndex(7);
		groupBox_4.set_TabStop(false);
		((Control)groupBox_4).set_Text(Class60.smethod_0(-2050217475));
		tableLayoutPanel_5.set_ColumnCount(2);
		tableLayoutPanel_5.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_5.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_5.get_Controls().Add((Control)(object)textBox_3, 1, 0);
		tableLayoutPanel_5.get_Controls().Add((Control)(object)label_8, 0, 0);
		((Control)tableLayoutPanel_5).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_5).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_5).set_Name(Class60.smethod_0(-2050211375));
		tableLayoutPanel_5.set_RowCount(1);
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_5.get_RowStyles().Add(new RowStyle((SizeType)1, 36f));
		((Control)tableLayoutPanel_5).set_Size(new Size(444, 36));
		((Control)tableLayoutPanel_5).set_TabIndex(0);
		((Control)textBox_3).set_Dock((DockStyle)5);
		((Control)textBox_3).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_3).set_Location(new Point(269, 3));
		((TextBoxBase)textBox_3).set_MaxLength(3);
		((Control)textBox_3).set_Name(Class60.smethod_0(-2050217508));
		((Control)textBox_3).set_Size(new Size(172, 23));
		((Control)textBox_3).set_TabIndex(3);
		((Control)textBox_3).add_KeyDown(new KeyEventHandler(textBox_3_KeyDown));
		((Control)label_8).set_AutoSize(true);
		((Control)label_8).set_Dock((DockStyle)4);
		((Control)label_8).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_8).set_Location(new Point(144, 0));
		((Control)label_8).set_Name(Class60.smethod_0(-2050226038));
		((Control)label_8).set_Size(new Size(119, 36));
		((Control)label_8).set_TabIndex(4);
		((Control)label_8).set_Text(Class60.smethod_0(-2050217130));
		label_8.set_TextAlign((ContentAlignment)64);
		((Control)groupBox_6).get_Controls().Add((Control)(object)tableLayoutPanel_7);
		((Control)groupBox_6).set_Dock((DockStyle)5);
		((Control)groupBox_6).set_ForeColor(SystemColors.Control);
		((Control)groupBox_6).set_Location(new Point(0, 421));
		((Control)groupBox_6).set_Margin(new Padding(0));
		((Control)groupBox_6).set_Name(Class60.smethod_0(-2050198296));
		((Control)groupBox_6).set_Size(new Size(450, 92));
		((Control)groupBox_6).set_TabIndex(9);
		groupBox_6.set_TabStop(false);
		((Control)groupBox_6).set_Text(Class60.smethod_0(-2050217565));
		tableLayoutPanel_7.set_ColumnCount(2);
		tableLayoutPanel_7.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_7.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_7.get_Controls().Add((Control)(object)label_13, 0, 0);
		tableLayoutPanel_7.get_Controls().Add((Control)(object)label_14, 0, 1);
		tableLayoutPanel_7.get_Controls().Add((Control)(object)textBox_5, 1, 0);
		tableLayoutPanel_7.get_Controls().Add((Control)(object)textBox_6, 1, 1);
		((Control)tableLayoutPanel_7).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_7).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_7).set_Name(Class60.smethod_0(-2050200260));
		tableLayoutPanel_7.set_RowCount(2);
		tableLayoutPanel_7.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		tableLayoutPanel_7.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		((Control)tableLayoutPanel_7).set_Size(new Size(444, 67));
		((Control)tableLayoutPanel_7).set_TabIndex(0);
		((Control)label_13).set_AutoSize(true);
		((Control)label_13).set_Dock((DockStyle)4);
		((Control)label_13).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_13).set_Location(new Point(120, 0));
		((Control)label_13).set_Name(Class60.smethod_0(-2050225816));
		((Control)label_13).set_Size(new Size(143, 33));
		((Control)label_13).set_TabIndex(0);
		((Control)label_13).set_Text(Class60.smethod_0(-2050217570));
		label_13.set_TextAlign((ContentAlignment)64);
		((Control)label_14).set_AutoSize(true);
		((Control)label_14).set_Dock((DockStyle)4);
		((Control)label_14).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_14).set_Location(new Point(149, 33));
		((Control)label_14).set_Name(Class60.smethod_0(-2050225766));
		((Control)label_14).set_Size(new Size(114, 34));
		((Control)label_14).set_TabIndex(1);
		((Control)label_14).set_Text(Class60.smethod_0(-2050217659));
		label_14.set_TextAlign((ContentAlignment)64);
		((Control)textBox_5).set_Dock((DockStyle)5);
		((Control)textBox_5).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_5).set_Location(new Point(269, 3));
		((TextBoxBase)textBox_5).set_MaxLength(3);
		((Control)textBox_5).set_Name(Class60.smethod_0(-2050217674));
		((Control)textBox_5).set_Size(new Size(172, 23));
		((Control)textBox_5).set_TabIndex(2);
		((Control)textBox_5).add_KeyDown(new KeyEventHandler(textBox_5_KeyDown));
		((Control)textBox_6).set_Dock((DockStyle)5);
		((Control)textBox_6).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_6).set_Location(new Point(269, 36));
		((TextBoxBase)textBox_6).set_MaxLength(3);
		((Control)textBox_6).set_Name(Class60.smethod_0(-2050217711));
		((Control)textBox_6).set_Size(new Size(172, 23));
		((Control)textBox_6).set_TabIndex(3);
		((Control)textBox_6).add_KeyDown(new KeyEventHandler(textBox_6_KeyDown));
		((Control)groupBox_7).get_Controls().Add((Control)(object)tableLayoutPanel_8);
		((Control)groupBox_7).set_Dock((DockStyle)5);
		((Control)groupBox_7).set_ForeColor(SystemColors.Control);
		((Control)groupBox_7).set_Location(new Point(0, 0));
		((Control)groupBox_7).set_Margin(new Padding(0));
		((Control)groupBox_7).set_Name(Class60.smethod_0(-2050225288));
		((Control)groupBox_7).set_Size(new Size(450, 161));
		((Control)groupBox_7).set_TabIndex(10);
		groupBox_7.set_TabStop(false);
		((Control)groupBox_7).set_Text(Class60.smethod_0(-2050202701));
		tableLayoutPanel_8.set_ColumnCount(2);
		tableLayoutPanel_8.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_8.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_8.get_Controls().Add((Control)(object)label_6, 0, 1);
		tableLayoutPanel_8.get_Controls().Add((Control)(object)comboBox_3, 1, 1);
		tableLayoutPanel_8.get_Controls().Add((Control)(object)label_7, 0, 2);
		tableLayoutPanel_8.get_Controls().Add((Control)(object)comboBox_4, 1, 2);
		tableLayoutPanel_8.get_Controls().Add((Control)(object)comboBox_7, 1, 3);
		tableLayoutPanel_8.get_Controls().Add((Control)(object)label_12, 0, 3);
		tableLayoutPanel_8.get_Controls().Add((Control)(object)label_15, 0, 0);
		tableLayoutPanel_8.get_Controls().Add((Control)(object)comboBox_8, 1, 0);
		((Control)tableLayoutPanel_8).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_8).set_Location(new Point(3, 22));
		((Control)tableLayoutPanel_8).set_Name(Class60.smethod_0(-2050198317));
		tableLayoutPanel_8.set_RowCount(4);
		tableLayoutPanel_8.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_8.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_8.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_8.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		((Control)tableLayoutPanel_8).set_Size(new Size(444, 136));
		((Control)tableLayoutPanel_8).set_TabIndex(0);
		((Control)label_6).set_AutoSize(true);
		((Control)label_6).set_Dock((DockStyle)4);
		((Control)label_6).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_6).set_ForeColor(SystemColors.Control);
		((Control)label_6).set_Location(new Point(122, 34));
		((Control)label_6).set_Name(Class60.smethod_0(-2050202302));
		((Control)label_6).set_Size(new Size(141, 34));
		((Control)label_6).set_TabIndex(4);
		((Control)label_6).set_Text(Class60.smethod_0(-2050217736));
		label_6.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_3).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_3).set_Dock((DockStyle)5);
		comboBox_3.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_3).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)comboBox_3).set_ForeColor(SystemColors.WindowText);
		((ListControl)comboBox_3).set_FormattingEnabled(true);
		comboBox_3.get_Items().AddRange(new object[7]
		{
			Class60.smethod_0(-2050205620),
			Class60.smethod_0(-2050216997),
			Class60.smethod_0(-2050217004),
			Class60.smethod_0(-2050195886),
			Class60.smethod_0(-2050195879),
			Class60.smethod_0(-2050195904),
			Class60.smethod_0(-2050195849)
		});
		((Control)comboBox_3).set_Location(new Point(269, 37));
		((Control)comboBox_3).set_Name(Class60.smethod_0(-2050217819));
		((Control)comboBox_3).set_Size(new Size(172, 23));
		((Control)comboBox_3).set_TabIndex(5);
		comboBox_3.add_SelectedIndexChanged((EventHandler)comboBox_3_SelectedIndexChanged);
		((Control)label_7).set_AutoSize(true);
		((Control)label_7).set_Dock((DockStyle)4);
		((Control)label_7).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_7).set_ForeColor(SystemColors.Control);
		((Control)label_7).set_Location(new Point(123, 68));
		((Control)label_7).set_Name(Class60.smethod_0(-2050207199));
		((Control)label_7).set_Size(new Size(140, 34));
		((Control)label_7).set_TabIndex(6);
		((Control)label_7).set_Text(Class60.smethod_0(-2050217847));
		label_7.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_4).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_4).set_Dock((DockStyle)5);
		comboBox_4.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_4).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)comboBox_4).set_ForeColor(SystemColors.WindowText);
		((ListControl)comboBox_4).set_FormattingEnabled(true);
		comboBox_4.get_Items().AddRange(new object[10]
		{
			Class60.smethod_0(-2050205598),
			Class60.smethod_0(-2050205567),
			Class60.smethod_0(-2050205550),
			Class60.smethod_0(-2050205627),
			Class60.smethod_0(-2050205590),
			Class60.smethod_0(-2050198162),
			Class60.smethod_0(-2050198170),
			Class60.smethod_0(-2050198146),
			Class60.smethod_0(-2050198154),
			Class60.smethod_0(-2050205620)
		});
		((Control)comboBox_4).set_Location(new Point(269, 71));
		((Control)comboBox_4).set_Name(Class60.smethod_0(-2050217912));
		((Control)comboBox_4).set_Size(new Size(172, 23));
		((Control)comboBox_4).set_TabIndex(7);
		comboBox_4.add_SelectedIndexChanged((EventHandler)comboBox_4_SelectedIndexChanged);
		((Control)comboBox_7).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_7).set_Dock((DockStyle)5);
		comboBox_7.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_7).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_7).set_FormattingEnabled(true);
		comboBox_7.get_Items().AddRange(new object[11]
		{
			Class60.smethod_0(-2050205567),
			Class60.smethod_0(-2050205550),
			Class60.smethod_0(-2050205627),
			Class60.smethod_0(-2050205590),
			Class60.smethod_0(-2050198162),
			Class60.smethod_0(-2050198170),
			Class60.smethod_0(-2050198146),
			Class60.smethod_0(-2050198154),
			Class60.smethod_0(-2050205620),
			Class60.smethod_0(-2050217889),
			Class60.smethod_0(-2050217944)
		});
		((Control)comboBox_7).set_Location(new Point(269, 105));
		((Control)comboBox_7).set_Name(Class60.smethod_0(-2050217951));
		((Control)comboBox_7).set_Size(new Size(172, 23));
		((Control)comboBox_7).set_TabIndex(11);
		comboBox_7.add_SelectedIndexChanged((EventHandler)comboBox_7_SelectedIndexChanged);
		((Control)label_12).set_AutoSize(true);
		((Control)label_12).set_Dock((DockStyle)4);
		((Control)label_12).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_12).set_Location(new Point(91, 102));
		((Control)label_12).set_Name(Class60.smethod_0(-2050225879));
		((Control)label_12).set_Size(new Size(172, 34));
		((Control)label_12).set_TabIndex(10);
		((Control)label_12).set_Text(Class60.smethod_0(-2050217969));
		label_12.set_TextAlign((ContentAlignment)64);
		((Control)label_15).set_AutoSize(true);
		((Control)label_15).set_Dock((DockStyle)4);
		((Control)label_15).set_Font(new Font(Class60.smethod_0(-2050211150), 9f, (FontStyle)1));
		((Control)label_15).set_Location(new Point(132, 0));
		((Control)label_15).set_Name(Class60.smethod_0(-2050225725));
		((Control)label_15).set_Size(new Size(131, 34));
		((Control)label_15).set_TabIndex(12);
		((Control)label_15).set_Text(Class60.smethod_0(-2050215976));
		label_15.set_TextAlign((ContentAlignment)64);
		((Control)comboBox_8).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_8).set_Dock((DockStyle)5);
		comboBox_8.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_8).set_Font(new Font(Class60.smethod_0(-2050211150), 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_8).set_FormattingEnabled(true);
		comboBox_8.get_Items().AddRange(new object[11]
		{
			Class60.smethod_0(-2050205567),
			Class60.smethod_0(-2050205550),
			Class60.smethod_0(-2050205627),
			Class60.smethod_0(-2050205590),
			Class60.smethod_0(-2050198162),
			Class60.smethod_0(-2050198170),
			Class60.smethod_0(-2050198146),
			Class60.smethod_0(-2050198154),
			Class60.smethod_0(-2050205620),
			Class60.smethod_0(-2050217889),
			Class60.smethod_0(-2050217944)
		});
		((Control)comboBox_8).set_Location(new Point(269, 3));
		((Control)comboBox_8).set_Name(Class60.smethod_0(-2050216063));
		((Control)comboBox_8).set_Size(new Size(172, 23));
		((Control)comboBox_8).set_TabIndex(13);
		comboBox_8.add_SelectedIndexChanged((EventHandler)comboBox_8_SelectedIndexChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Control)this).set_Name(Class60.smethod_0(-2050216085));
		((Control)this).set_Size(new Size(450, 768));
		((UserControl)this).add_Load((EventHandler)GControl5_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)groupBox_5).ResumeLayout(false);
		((Control)tableLayoutPanel_6).ResumeLayout(false);
		((Control)tableLayoutPanel_6).PerformLayout();
		((Control)groupBox_0).ResumeLayout(false);
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_1).PerformLayout();
		((Control)groupBox_2).ResumeLayout(false);
		((Control)tableLayoutPanel_3).ResumeLayout(false);
		((Control)tableLayoutPanel_3).PerformLayout();
		((Control)groupBox_1).ResumeLayout(false);
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((Control)tableLayoutPanel_2).PerformLayout();
		((Control)groupBox_3).ResumeLayout(false);
		((Control)tableLayoutPanel_4).ResumeLayout(false);
		((Control)tableLayoutPanel_4).PerformLayout();
		((Control)groupBox_4).ResumeLayout(false);
		((Control)tableLayoutPanel_5).ResumeLayout(false);
		((Control)tableLayoutPanel_5).PerformLayout();
		((Control)groupBox_6).ResumeLayout(false);
		((Control)tableLayoutPanel_7).ResumeLayout(false);
		((Control)tableLayoutPanel_7).PerformLayout();
		((Control)groupBox_7).ResumeLayout(false);
		((Control)tableLayoutPanel_8).ResumeLayout(false);
		((Control)tableLayoutPanel_8).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
