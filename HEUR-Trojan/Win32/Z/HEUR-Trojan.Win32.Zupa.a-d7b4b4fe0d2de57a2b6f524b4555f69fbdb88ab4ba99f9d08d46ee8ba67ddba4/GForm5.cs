using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public sealed class GForm5 : Form
{
	public int int_0;

	public string string_0;

	public string string_1;

	private IContainer icontainer_0;

	private TableLayoutPanel tableLayoutPanel_0;

	private GroupBox groupBox_0;

	private TableLayoutPanel tableLayoutPanel_1;

	private Label label_0;

	private Label label_1;

	private TextBox textBox_0;

	private TextBox textBox_1;

	private TableLayoutPanel tableLayoutPanel_2;

	private PictureBox pictureBox_0;

	private Label label_2;

	private Button button_0;

	private Button button_1;

	private Label label_3;

	private TextBox textBox_2;

	private Label label_4;

	private TableLayoutPanel tableLayoutPanel_3;

	private LinkLabel linkLabel_0;

	private PictureBox pictureBox_1;

	private TextBox textBox_3;

	private Label label_5;

	public GForm5()
	{
		method_0();
	}

	private void GForm5_Load(object sender, EventArgs e)
	{
		if (int_0.Equals(1))
		{
			((Control)groupBox_0).set_Text(Class60.smethod_0(-2050227860));
			((Control)label_1).set_Text(Class60.smethod_0(-2050227903));
			((Control)label_3).set_Text(Class60.smethod_0(-2050227936));
			((Control)button_0).set_Text(Class60.smethod_0(-2050227941));
		}
		else if (int_0.Equals(2))
		{
			((Control)groupBox_0).set_Text(Class60.smethod_0(-2050228020));
			((Control)textBox_0).set_Text(string_1);
			((Control)textBox_0).set_Enabled(false);
			((Control)textBox_1).set_Visible(false);
			((Control)textBox_2).set_Visible(false);
			((Control)label_1).set_Visible(false);
			((Control)label_3).set_Visible(false);
			((Control)button_1).set_Visible(false);
			((Control)button_0).set_Text(Class60.smethod_0(-2050228063));
		}
	}

	private void button_0_Click(object sender, EventArgs e)
	{
	}

	private void button_1_Click(object sender, EventArgs e)
	{
	}

	private void linkLabel_0_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel_0.set_LinkVisited(true);
		Process.Start(Class60.smethod_0(-2050208733));
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
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Unknown result type (might be due to invalid IL or missing references)
		//IL_027b: Expected O, but got Unknown
		//IL_028d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cf: Expected O, but got Unknown
		//IL_02e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0307: Expected O, but got Unknown
		//IL_0319: Unknown result type (might be due to invalid IL or missing references)
		//IL_0323: Expected O, but got Unknown
		//IL_0335: Unknown result type (might be due to invalid IL or missing references)
		//IL_033f: Expected O, but got Unknown
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_038d: Expected O, but got Unknown
		//IL_039f: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a9: Expected O, but got Unknown
		//IL_042f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_0542: Unknown result type (might be due to invalid IL or missing references)
		//IL_054c: Expected O, but got Unknown
		//IL_0634: Unknown result type (might be due to invalid IL or missing references)
		//IL_063e: Expected O, but got Unknown
		//IL_070f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0719: Expected O, but got Unknown
		//IL_07b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c3: Expected O, but got Unknown
		//IL_07d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_07df: Expected O, but got Unknown
		//IL_08f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fb: Expected O, but got Unknown
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0917: Expected O, but got Unknown
		//IL_0929: Unknown result type (might be due to invalid IL or missing references)
		//IL_0933: Expected O, but got Unknown
		//IL_0945: Unknown result type (might be due to invalid IL or missing references)
		//IL_094f: Expected O, but got Unknown
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected O, but got Unknown
		//IL_09bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c9: Expected O, but got Unknown
		//IL_0a64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a6e: Expected O, but got Unknown
		//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b06: Expected O, but got Unknown
		//IL_0b83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b8d: Expected O, but got Unknown
		//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2c: Expected O, but got Unknown
		//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc5: Expected O, but got Unknown
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected O, but got Unknown
		//IL_0de0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dea: Expected O, but got Unknown
		//IL_0e81: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e8b: Expected O, but got Unknown
		//IL_0e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea7: Expected O, but got Unknown
		//IL_0eb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec3: Expected O, but got Unknown
		//IL_0f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Expected O, but got Unknown
		//IL_0f4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f54: Expected O, but got Unknown
		//IL_1037: Unknown result type (might be due to invalid IL or missing references)
		//IL_1041: Expected O, but got Unknown
		//IL_1123: Unknown result type (might be due to invalid IL or missing references)
		//IL_112d: Expected O, but got Unknown
		//IL_11f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fe: Expected O, but got Unknown
		//IL_12d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e0: Expected O, but got Unknown
		//IL_12f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1302: Expected O, but got Unknown
		//IL_1304: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(GForm5));
		tableLayoutPanel_0 = new TableLayoutPanel();
		tableLayoutPanel_3 = new TableLayoutPanel();
		linkLabel_0 = new LinkLabel();
		pictureBox_1 = new PictureBox();
		button_1 = new Button();
		groupBox_0 = new GroupBox();
		tableLayoutPanel_1 = new TableLayoutPanel();
		label_0 = new Label();
		label_1 = new Label();
		textBox_0 = new TextBox();
		textBox_1 = new TextBox();
		label_3 = new Label();
		textBox_2 = new TextBox();
		textBox_3 = new TextBox();
		label_5 = new Label();
		tableLayoutPanel_2 = new TableLayoutPanel();
		pictureBox_0 = new PictureBox();
		label_2 = new Label();
		button_0 = new Button();
		label_4 = new Label();
		((Control)tableLayoutPanel_0).SuspendLayout();
		((Control)tableLayoutPanel_3).SuspendLayout();
		((ISupportInitialize)pictureBox_1).BeginInit();
		((Control)groupBox_0).SuspendLayout();
		((Control)tableLayoutPanel_1).SuspendLayout();
		((Control)tableLayoutPanel_2).SuspendLayout();
		((ISupportInitialize)pictureBox_0).BeginInit();
		((Control)this).SuspendLayout();
		tableLayoutPanel_0.set_ColumnCount(1);
		tableLayoutPanel_0.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 100f));
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_3, 0, 7);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)button_1, 0, 4);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)groupBox_0, 0, 2);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)tableLayoutPanel_2, 0, 0);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_2, 0, 1);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)button_0, 0, 5);
		tableLayoutPanel_0.get_Controls().Add((Control)(object)label_4, 0, 3);
		((Control)tableLayoutPanel_0).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_0).set_Location(new Point(0, 0));
		((Control)tableLayoutPanel_0).set_Name(Class60.smethod_0(-2050208027));
		((Control)tableLayoutPanel_0).set_Padding(new Padding(10));
		tableLayoutPanel_0.set_RowCount(8);
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 25f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 7f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 33f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 5f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 9f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 9f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 4f));
		tableLayoutPanel_0.get_RowStyles().Add(new RowStyle((SizeType)2, 8f));
		((Control)tableLayoutPanel_0).set_Size(new Size(340, 500));
		((Control)tableLayoutPanel_0).set_TabIndex(1);
		tableLayoutPanel_3.set_ColumnCount(2);
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 15f));
		tableLayoutPanel_3.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 85f));
		tableLayoutPanel_3.get_Controls().Add((Control)(object)linkLabel_0, 1, 0);
		tableLayoutPanel_3.get_Controls().Add((Control)(object)pictureBox_1, 0, 0);
		((Control)tableLayoutPanel_3).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_3).set_Location(new Point(13, 453));
		((Control)tableLayoutPanel_3).set_Name(Class60.smethod_0(-2050211259));
		tableLayoutPanel_3.set_RowCount(1);
		tableLayoutPanel_3.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		((Control)tableLayoutPanel_3).set_Size(new Size(314, 34));
		((Control)tableLayoutPanel_3).set_TabIndex(9);
		((Control)linkLabel_0).set_AutoSize(true);
		((Control)linkLabel_0).set_Dock((DockStyle)5);
		((Control)linkLabel_0).set_Font(new Font(Class60.smethod_0(-2050208051), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)222));
		linkLabel_0.set_LinkColor(SystemColors.ControlLightLight);
		((Control)linkLabel_0).set_Location(new Point(50, 0));
		((Control)linkLabel_0).set_Name(Class60.smethod_0(-2050211283));
		((Control)linkLabel_0).set_Size(new Size(261, 34));
		((Control)linkLabel_0).set_TabIndex(0);
		linkLabel_0.set_TabStop(true);
		((Control)linkLabel_0).set_Text(Class60.smethod_0(-2050211265));
		((Label)linkLabel_0).set_TextAlign((ContentAlignment)16);
		linkLabel_0.set_VisitedLinkColor(Color.Blue);
		linkLabel_0.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel_0_LinkClicked));
		((Control)pictureBox_1).set_BackgroundImageLayout((ImageLayout)3);
		((Control)pictureBox_1).set_Dock((DockStyle)5);
		pictureBox_1.set_Image((Image)(object)Class41.smethod_7());
		((Control)pictureBox_1).set_Location(new Point(3, 3));
		((Control)pictureBox_1).set_Name(Class60.smethod_0(-2050211308));
		((Control)pictureBox_1).set_Size(new Size(41, 28));
		pictureBox_1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox_1.set_TabIndex(1);
		pictureBox_1.set_TabStop(false);
		((Control)button_1).set_BackColor(Color.Salmon);
		((Control)button_1).set_Cursor(Cursors.get_Hand());
		((Control)button_1).set_Dock((DockStyle)5);
		((ButtonBase)button_1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)0);
		((Control)button_1).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_1).set_ForeColor(SystemColors.Window);
		((Control)button_1).set_Location(new Point(13, 348));
		((Control)button_1).set_Name(Class60.smethod_0(-2050228090));
		((Control)button_1).set_Size(new Size(314, 37));
		((Control)button_1).set_TabIndex(5);
		((Control)button_1).set_Text(Class60.smethod_0(-2050228075));
		((ButtonBase)button_1).set_UseVisualStyleBackColor(false);
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)groupBox_0).get_Controls().Add((Control)(object)tableLayoutPanel_1);
		((Control)groupBox_0).set_Dock((DockStyle)5);
		((Control)groupBox_0).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)groupBox_0).set_ForeColor(SystemColors.Window);
		((Control)groupBox_0).set_Location(new Point(13, 166));
		((Control)groupBox_0).set_Name(Class60.smethod_0(-2050210886));
		((Control)groupBox_0).set_Size(new Size(314, 152));
		((Control)groupBox_0).set_TabIndex(0);
		groupBox_0.set_TabStop(false);
		((Control)groupBox_0).set_Text(Class60.smethod_0(-2050228124));
		tableLayoutPanel_1.set_ColumnCount(2);
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 40f));
		tableLayoutPanel_1.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 60f));
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_0, 0, 1);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_1, 0, 2);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)textBox_0, 1, 1);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)textBox_1, 1, 2);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_3, 0, 3);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)textBox_2, 1, 3);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)textBox_3, 1, 0);
		tableLayoutPanel_1.get_Controls().Add((Control)(object)label_5, 0, 0);
		((Control)tableLayoutPanel_1).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_1).set_Location(new Point(3, 23));
		((Control)tableLayoutPanel_1).set_Name(Class60.smethod_0(-2050208091));
		tableLayoutPanel_1.set_RowCount(5);
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 24f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 24f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 24f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 24f));
		tableLayoutPanel_1.get_RowStyles().Add(new RowStyle((SizeType)2, 4f));
		((Control)tableLayoutPanel_1).set_Size(new Size(308, 126));
		((Control)tableLayoutPanel_1).set_TabIndex(0);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Dock((DockStyle)4);
		((Control)label_0).set_Font(new Font(Class60.smethod_0(-2050210859), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(63, 30));
		((Control)label_0).set_Name(Class60.smethod_0(-2050210921));
		((Control)label_0).set_Size(new Size(57, 30));
		((Control)label_0).set_TabIndex(0);
		((Control)label_0).set_Text(Class60.smethod_0(-2050228159));
		label_0.set_TextAlign((ContentAlignment)64);
		((Control)label_1).set_AutoSize(true);
		((Control)label_1).set_Dock((DockStyle)5);
		((Control)label_1).set_Font(new Font(Class60.smethod_0(-2050210859), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_1).set_Location(new Point(3, 60));
		((Control)label_1).set_Name(Class60.smethod_0(-2050210999));
		((Control)label_1).set_Size(new Size(117, 30));
		((Control)label_1).set_TabIndex(1);
		((Control)label_1).set_Text(Class60.smethod_0(-2050211002));
		label_1.set_TextAlign((ContentAlignment)64);
		((Control)textBox_0).set_Dock((DockStyle)5);
		((Control)textBox_0).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_0).set_Location(new Point(126, 33));
		((TextBoxBase)textBox_0).set_MaxLength(20);
		((Control)textBox_0).set_Name(Class60.smethod_0(-2050211039));
		((Control)textBox_0).set_Size(new Size(179, 27));
		((Control)textBox_0).set_TabIndex(2);
		((Control)textBox_1).set_Dock((DockStyle)5);
		((Control)textBox_1).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_1).set_Location(new Point(126, 63));
		((TextBoxBase)textBox_1).set_MaxLength(20);
		((Control)textBox_1).set_Name(Class60.smethod_0(-2050211020));
		((Control)textBox_1).set_Size(new Size(179, 27));
		((Control)textBox_1).set_TabIndex(3);
		textBox_1.set_UseSystemPasswordChar(true);
		((Control)label_3).set_AutoSize(true);
		((Control)label_3).set_Dock((DockStyle)4);
		((Control)label_3).set_Font(new Font(Class60.smethod_0(-2050210859), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_3).set_Location(new Point(22, 90));
		((Control)label_3).set_Name(Class60.smethod_0(-2050207156));
		((Control)label_3).set_Size(new Size(98, 30));
		((Control)label_3).set_TabIndex(4);
		((Control)label_3).set_Text(Class60.smethod_0(-2050228192));
		label_3.set_TextAlign((ContentAlignment)64);
		((Control)textBox_2).set_Dock((DockStyle)5);
		((Control)textBox_2).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_2).set_Location(new Point(126, 93));
		((TextBoxBase)textBox_2).set_MaxLength(20);
		((Control)textBox_2).set_Name(Class60.smethod_0(-2050228217));
		((Control)textBox_2).set_Size(new Size(179, 27));
		((Control)textBox_2).set_TabIndex(4);
		textBox_2.set_UseSystemPasswordChar(true);
		((Control)textBox_3).set_Dock((DockStyle)5);
		((Control)textBox_3).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox_3).set_Location(new Point(126, 3));
		((TextBoxBase)textBox_3).set_MaxLength(50);
		((Control)textBox_3).set_Name(Class60.smethod_0(-2050226199));
		((Control)textBox_3).set_Size(new Size(179, 27));
		((Control)textBox_3).set_TabIndex(1);
		((Control)label_5).set_AutoSize(true);
		((Control)label_5).set_Dock((DockStyle)4);
		((Control)label_5).set_Font(new Font(Class60.smethod_0(-2050210859), 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_5).set_Location(new Point(76, 0));
		((Control)label_5).set_Name(Class60.smethod_0(-2050198190));
		((Control)label_5).set_Size(new Size(44, 30));
		((Control)label_5).set_TabIndex(7);
		((Control)label_5).set_Text(Class60.smethod_0(-2050226183));
		label_5.set_TextAlign((ContentAlignment)64);
		((Control)tableLayoutPanel_2).set_BackColor(Color.DarkSlateGray);
		tableLayoutPanel_2.set_ColumnCount(3);
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 50f));
		tableLayoutPanel_2.get_ColumnStyles().Add(new ColumnStyle((SizeType)2, 25f));
		tableLayoutPanel_2.get_Controls().Add((Control)(object)pictureBox_0, 1, 0);
		((Control)tableLayoutPanel_2).set_Dock((DockStyle)5);
		((Control)tableLayoutPanel_2).set_Location(new Point(13, 13));
		((Control)tableLayoutPanel_2).set_Name(Class60.smethod_0(-2050211088));
		tableLayoutPanel_2.set_RowCount(1);
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)2, 100f));
		tableLayoutPanel_2.get_RowStyles().Add(new RowStyle((SizeType)1, 114f));
		((Control)tableLayoutPanel_2).set_Size(new Size(314, 114));
		((Control)tableLayoutPanel_2).set_TabIndex(1);
		((Control)pictureBox_0).set_Dock((DockStyle)5);
		pictureBox_0.set_Image((Image)(object)Class41.smethod_10());
		((Control)pictureBox_0).set_Location(new Point(81, 3));
		((Control)pictureBox_0).set_Name(Class60.smethod_0(-2050211112));
		((Control)pictureBox_0).set_Size(new Size(151, 108));
		pictureBox_0.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox_0.set_TabIndex(0);
		pictureBox_0.set_TabStop(false);
		((Control)label_2).set_AutoSize(true);
		((Control)label_2).set_BackColor(Color.Firebrick);
		((Control)label_2).set_Dock((DockStyle)5);
		((Control)label_2).set_Font(new Font(Class60.smethod_0(-2050211150), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_2).set_ForeColor(Color.Goldenrod);
		((Control)label_2).set_Location(new Point(13, 130));
		((Control)label_2).set_Name(Class60.smethod_0(-2050208088));
		((Control)label_2).set_Size(new Size(314, 33));
		((Control)label_2).set_TabIndex(2);
		((Control)label_2).set_Text(Class60.smethod_0(-2050226240));
		label_2.set_TextAlign((ContentAlignment)32);
		((Control)button_0).set_BackColor(Color.LightSeaGreen);
		((Control)button_0).set_Cursor(Cursors.get_Hand());
		((Control)button_0).set_Dock((DockStyle)5);
		((ButtonBase)button_0).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)0);
		((Control)button_0).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)button_0).set_ForeColor(SystemColors.Window);
		((Control)button_0).set_Location(new Point(13, 391));
		((Control)button_0).set_Name(Class60.smethod_0(-2050226279));
		((Control)button_0).set_Size(new Size(314, 37));
		((Control)button_0).set_TabIndex(6);
		((Control)button_0).set_Text(Class60.smethod_0(-2050226326));
		((ButtonBase)button_0).set_UseVisualStyleBackColor(false);
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)label_4).set_AutoSize(true);
		((Control)label_4).set_Dock((DockStyle)5);
		((Control)label_4).set_Font(new Font(Class60.smethod_0(-2050210859), 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label_4).set_ForeColor(Color.Red);
		((Control)label_4).set_Location(new Point(13, 321));
		((Control)label_4).set_Name(Class60.smethod_0(-2050211212));
		((Control)label_4).set_Size(new Size(314, 24));
		((Control)label_4).set_TabIndex(6);
		label_4.set_TextAlign((ContentAlignment)32);
		((Control)label_4).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(10f, 21f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.DarkSlateGray);
		((Form)this).set_ClientSize(new Size(340, 500));
		((Control)this).get_Controls().Add((Control)(object)tableLayoutPanel_0);
		((Control)this).set_Font(new Font(Class60.smethod_0(-2050210859), 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject(Class60.smethod_0(-2050208183)));
		((Form)this).set_Margin(new Padding(5));
		((Control)this).set_Name(Class60.smethod_0(-2050226365));
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class60.smethod_0(-2050226365));
		((Form)this).add_Load((EventHandler)GForm5_Load);
		((Control)tableLayoutPanel_0).ResumeLayout(false);
		((Control)tableLayoutPanel_0).PerformLayout();
		((Control)tableLayoutPanel_3).ResumeLayout(false);
		((Control)tableLayoutPanel_3).PerformLayout();
		((ISupportInitialize)pictureBox_1).EndInit();
		((Control)groupBox_0).ResumeLayout(false);
		((Control)tableLayoutPanel_1).ResumeLayout(false);
		((Control)tableLayoutPanel_1).PerformLayout();
		((Control)tableLayoutPanel_2).ResumeLayout(false);
		((ISupportInitialize)pictureBox_0).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
