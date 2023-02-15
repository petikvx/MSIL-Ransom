using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public sealed class GForm10 : Form
{
	public string string_0;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private Label label_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private Button button_0;

	public GForm10()
	{
		method_0();
	}

	private void GForm10_Load(object sender, EventArgs e)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			((Control)label_0).set_Text(Class60.smethod_0(-2050207891) + string_0 + Class60.smethod_0(-2050207930));
		}
		else
		{
			((Form)this).Close();
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		Process.Start(Class60.smethod_0(-2050207993));
		Application.Exit();
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
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_017a: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0196: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Expected O, but got Unknown
		//IL_02e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ef: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037f: Expected O, but got Unknown
		//IL_0408: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_050a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm10));
		tableLayoutPanel_0 = new TableLayoutPanel();
		label_0 = new Label();
		tableLayoutPanel_1 = new TableLayoutPanel();
		button_0 = new Button();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)this).SuspendLayout();
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)1, 20f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_0, 0, 1);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_1, 0, 2);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		tableLayoutPanel_0.set_RowCount(4);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 5f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 45f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 45f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 5f));
		((Control)tableLayoutPanel_0).set_Size(new Size(434, 111));
		((Control)tableLayoutPanel_0).set_TabIndex(0);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Dock((DockStyle)5);
		((Control)label_0).set_Font(new Font(Class60.smethod_0(-2050208051), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		((Control)label_0).set_ForeColor(Color.Goldenrod);
		((Control)label_0).set_Location(new Point(3, 5));
		((Control)label_0).set_Name(Class60.smethod_0(-2050208088));
		((Control)label_0).set_Size(new Size(428, 49));
		((Control)label_0).set_TabIndex(0);
		((Control)label_0).set_Text(Class60.smethod_0(-2050208088));
		label_0.set_TextAlign((ContentAlignment)32);
		tableLayoutPanel_1.set_ColumnCount(3);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 20f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)button_0, 1, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(3, 57));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_1.set_RowCount(1);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)1, 43f));
		((Control)tableLayoutPanel_1).set_Size(new Size(428, 43));
		((Control)tableLayoutPanel_1).set_TabIndex(1);
		((Control)button_0).set_BackColor(Color.LightSeaGreen);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((ButtonBase)button_0).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)0);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050208051), 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)222));
		((Control)button_0).set_ForeColor(SystemColors.ControlLightLight);
		((Control)button_0).set_Location(new Point(88, 3));
		((Control)button_0).set_Name(Class60.smethod_0(-2050208115));
		((Control)button_0).set_Size(new Size(250, 37));
		((Control)button_0).set_TabIndex(0);
		((Control)button_0).set_Text(Class60.smethod_0(-2050208112));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Form)this).set_ClientSize(new Size(434, 111));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class60.smethod_0(-2050208183)));
		((Control)this).set_Name(Class60.smethod_0(-2050208166));
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class60.smethod_0(-2050208224));
		((Form)this).add_Load((EventHandler)GForm10_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)tableLayoutPanel_0).PerformLayout();
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
