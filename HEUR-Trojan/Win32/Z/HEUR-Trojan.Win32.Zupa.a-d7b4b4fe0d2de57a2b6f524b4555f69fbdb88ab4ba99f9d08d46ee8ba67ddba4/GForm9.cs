using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

public sealed class GForm9 : Form
{
	public int int_0;

	public int int_1;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private Button button_0;

	private TableLayoutPanel tableLayoutPanel_2;

	private ComboBox comboBox_0;

	public GForm9()
	{
		method_0();
	}

	private void GForm9_Load(object sender, EventArgs e)
	{
		int num = 3;
		if (int_1.Equals(7))
		{
			num += 67;
			if (int_0.Equals(1))
			{
				File.WriteAllBytes(Class60.smethod_0(-2050196720), Class41.smethod_16());
			}
			else if (int_0.Equals(5))
			{
				File.WriteAllBytes(Class60.smethod_0(-2050196805), Class41.smethod_15());
			}
		}
		for (int i = 1; i <= num; i++)
		{
			comboBox_0.get_Items().Add((object)i);
		}
		((ListControl)comboBox_0).set_SelectedIndex(0);
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Control)button_0).set_Enabled(false);
		Process[] processesByName = Process.GetProcessesByName(Class60.smethod_0(-2050204785));
		if (int_1.Equals(7))
		{
			for (int i = 0; i <= ((ListControl)comboBox_0).get_SelectedIndex(); i++)
			{
				if (int_0.Equals(1))
				{
					Process.Start(Environment.ExpandEnvironmentVariables(Class60.smethod_0(-2050196871)));
				}
				else if (int_0.Equals(5))
				{
					Process.Start(Environment.ExpandEnvironmentVariables(Class60.smethod_0(-2050196805)));
				}
				Thread.Sleep(4000);
				processesByName = Process.GetProcessesByName(Class60.smethod_0(-2050204785));
				while (processesByName.Length == i)
				{
					Thread.Sleep(4000);
					processesByName = Process.GetProcessesByName(Class60.smethod_0(-2050204785));
				}
			}
		}
		for (int j = 0; j < ((ListControl)comboBox_0).get_SelectedIndex(); j++)
		{
			Process.Start(new ProcessStartInfo(AppDomain.CurrentDomain.BaseDirectory + Class60.smethod_0(-2050196991), Class60.smethod_0(-2050196971) + (j + 2)));
			Thread.Sleep(3000);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void method_0()
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
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_013c: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bf: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f7: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_03ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b8: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f0: Expected O, but got Unknown
		//IL_0459: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Expected O, but got Unknown
		//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d1: Expected O, but got Unknown
		//IL_0583: Unknown result type (might be due to invalid IL or missing references)
		//IL_058d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm9));
		tableLayoutPanel_0 = new TableLayoutPanel();
		tableLayoutPanel_1 = new TableLayoutPanel();
		button_0 = new Button();
		tableLayoutPanel_2 = new TableLayoutPanel();
		comboBox_0 = new ComboBox();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((Control)this).SuspendLayout();
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_1, 0, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_2, 0, 1);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(4);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 5f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 40f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 50f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 5f));
		((Control)tableLayoutPanel_0).set_Size(new Size(284, 91));
		((Control)tableLayoutPanel_0).set_TabIndex(2);
		tableLayoutPanel_1.set_ColumnCount(3);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 80f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)button_0, 1, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(3, 43));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_1.set_RowCount(1);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_1).set_Size(new Size(278, 39));
		((Control)tableLayoutPanel_1).set_TabIndex(1);
		((Control)button_0).set_BackColor(Color.LightSeaGreen);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((ButtonBase)button_0).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)0);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050208051), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)222));
		((Control)button_0).set_ForeColor(SystemColors.ControlLightLight);
		((Control)button_0).set_Location(new Point(30, 3));
		((Control)button_0).set_Name(Class60.smethod_0(-2050197009));
		((Control)button_0).set_Size(new Size(216, 33));
		((Control)button_0).set_TabIndex(0);
		((Control)button_0).set_Text(Class60.smethod_0(-2050196996));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		tableLayoutPanel_2.set_ColumnCount(3);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 80f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 10f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)comboBox_0, 1, 0);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(3, 7));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_2.set_RowCount(1);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_2).set_Size(new Size(278, 30));
		((Control)tableLayoutPanel_2).set_TabIndex(2);
		((Control)comboBox_0).set_Cursor(Cursors.get_Hand());
		((Control)comboBox_0).set_Dock((DockStyle)5);
		comboBox_0.set_DropDownStyle((ComboBoxStyle)2);
		((Control)comboBox_0).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((ListControl)comboBox_0).set_FormattingEnabled(true);
		((Control)comboBox_0).set_Location(new Point(30, 3));
		((Control)comboBox_0).set_Name(Class60.smethod_0(-2050197031));
		((Control)comboBox_0).set_Size(new Size(216, 29));
		((Control)comboBox_0).set_TabIndex(7);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Form)this).set_ClientSize(new Size(284, 91));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class60.smethod_0(-2050208183)));
		((Control)this).set_Name(Class60.smethod_0(-2050197078));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class60.smethod_0(-2050197070));
		((Form)this).add_Load((EventHandler)GForm9_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
