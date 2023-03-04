using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace TankBattle;

public class Form2 : Form
{
	private IContainer components = null;

	private CheckBox checkBox1;

	private Button button1;

	private NotifyIcon notifyIcon1;

	private RadioButton radioButton1;

	private PictureBox pictureBox1;

	private CheckBox checkBox2;

	private RadioButton radioButton2;

	private MaskedTextBox maskedTextBox1;

	private LinkLabel linkLabel1;

	private ProgressBar progressBar1;

	private CheckedListBox checkedListBox1;

	public Form2()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
	}

	private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
	{
	}

	private void checkBox2_CheckedChanged(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		components = new Container();
		checkBox1 = new CheckBox();
		button1 = new Button();
		notifyIcon1 = new NotifyIcon(components);
		radioButton1 = new RadioButton();
		pictureBox1 = new PictureBox();
		checkBox2 = new CheckBox();
		radioButton2 = new RadioButton();
		maskedTextBox1 = new MaskedTextBox();
		linkLabel1 = new LinkLabel();
		progressBar1 = new ProgressBar();
		checkedListBox1 = new CheckedListBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)checkBox1).set_AutoSize(true);
		((Control)checkBox1).set_Location(new Point(455, 128));
		((Control)checkBox1).set_Name("checkBox1");
		((Control)checkBox1).set_Size(new Size(80, 17));
		((Control)checkBox1).set_TabIndex(0);
		((Control)checkBox1).set_Text("checkBox1");
		((ButtonBase)checkBox1).set_UseVisualStyleBackColor(true);
		((Control)button1).set_Location(new Point(415, 212));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(171, 51));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("button1");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		notifyIcon1.set_Text("notifyIcon1");
		notifyIcon1.set_Visible(true);
		((Control)radioButton1).set_AutoSize(true);
		((Control)radioButton1).set_Location(new Point(507, 294));
		((Control)radioButton1).set_Name("radioButton1");
		((Control)radioButton1).set_Size(new Size(85, 17));
		((Control)radioButton1).set_TabIndex(2);
		radioButton1.set_TabStop(true);
		((Control)radioButton1).set_Text("radioButton1");
		((ButtonBase)radioButton1).set_UseVisualStyleBackColor(true);
		((Control)pictureBox1).set_Location(new Point(231, 334));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(310, 55));
		pictureBox1.set_TabIndex(3);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).add_Click((EventHandler)pictureBox1_Click);
		((Control)checkBox2).set_AutoSize(true);
		((Control)checkBox2).set_Location(new Point(142, 0));
		((Control)checkBox2).set_Name("checkBox2");
		((Control)checkBox2).set_Size(new Size(80, 17));
		((Control)checkBox2).set_TabIndex(4);
		((Control)checkBox2).set_Text("checkBox2");
		((ButtonBase)checkBox2).set_UseVisualStyleBackColor(true);
		checkBox2.add_CheckedChanged((EventHandler)checkBox2_CheckedChanged);
		((Control)radioButton2).set_AutoSize(true);
		((Control)radioButton2).set_Location(new Point(605, 357));
		((Control)radioButton2).set_Name("radioButton2");
		((Control)radioButton2).set_Size(new Size(85, 17));
		((Control)radioButton2).set_TabIndex(5);
		radioButton2.set_TabStop(true);
		((Control)radioButton2).set_Text("radioButton2");
		((ButtonBase)radioButton2).set_UseVisualStyleBackColor(true);
		((Control)maskedTextBox1).set_Location(new Point(263, 90));
		((Control)maskedTextBox1).set_Name("maskedTextBox1");
		((Control)maskedTextBox1).set_Size(new Size(122, 20));
		((Control)maskedTextBox1).set_TabIndex(6);
		maskedTextBox1.add_MaskInputRejected(new MaskInputRejectedEventHandler(maskedTextBox1_MaskInputRejected));
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Location(new Point(621, 96));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(55, 13));
		((Control)linkLabel1).set_TabIndex(7);
		linkLabel1.set_TabStop(true);
		((Control)linkLabel1).set_Text("linkLabel1");
		((Control)progressBar1).set_Location(new Point(209, 417));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(243, 8));
		((Control)progressBar1).set_TabIndex(8);
		((ListControl)checkedListBox1).set_FormattingEnabled(true);
		((Control)checkedListBox1).set_Location(new Point(173, 162));
		((Control)checkedListBox1).set_Name("checkedListBox1");
		((Control)checkedListBox1).set_Size(new Size(155, 64));
		((Control)checkedListBox1).set_TabIndex(9);
		((ListBox)checkedListBox1).add_SelectedIndexChanged((EventHandler)checkedListBox1_SelectedIndexChanged);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)checkedListBox1);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)maskedTextBox1);
		((Control)this).get_Controls().Add((Control)(object)radioButton2);
		((Control)this).get_Controls().Add((Control)(object)checkBox2);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)radioButton1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)checkBox1);
		((Control)this).set_Name("Form2");
		((Control)this).set_Text("Form2");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
