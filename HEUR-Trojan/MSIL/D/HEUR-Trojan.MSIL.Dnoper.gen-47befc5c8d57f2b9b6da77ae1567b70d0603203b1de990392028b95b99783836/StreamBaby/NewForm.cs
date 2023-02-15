using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using System.Web.Security;
using System.Windows.Forms;
using Microsoft.Win32;

namespace StreamBaby;

public class NewForm : Form
{
	private double seoncds = 3600.0;

	private int giveSleep = 1000;

	private decimal giveScoreCount = 500m;

	private bool isComplete = false;

	private bool isLowSpeed = false;

	private string ReadDate = string.Empty;

	private string c = string.Empty;

	private decimal giveScore = 0m;

	private decimal lastScore = 0m;

	private decimal currentScore = 0m;

	private Random random = new Random((int)DateTime.Now.ToFileTimeUtc());

	private string exe1Path = string.Empty;

	private string exe2Path = string.Empty;

	private string configPath = string.Empty;

	private bool isAutoRun = false;

	private bool isVisiable = true;

	private bool isLogin = false;

	private List<string> clientIdList = new List<string>();

	private static object lockObj = new object();

	private bool isStartGiveScore = false;

	private bool isOnline = false;

	private static object startLock = new object();

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

	private WebBrowser webBrowser1;

	private TextBox txtMsg;

	private CheckBox chkLowSpeed;

	public NewForm()
	{
		InitializeComponent();
		Control.set_CheckForIllegalCrossThreadCalls(false);
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
	}

	private void btnLogin_Click(object sender, EventArgs e)
	{
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		if (!string.IsNullOrEmpty(((Control)txtUserName).get_Text().Trim()))
		{
			isLogin = true;
			((Control)btnLogin).set_Text("赚分中...");
			((Control)lblCurrent).set_Text("读取中...");
			try
			{
				Thread thread = new Thread(BrowseRun);
				thread.IsBackground = true;
				thread.Start();
				ShowMsg("运行更新和配置");
				Thread thread2 = new Thread(UpdateUI);
				thread2.IsBackground = true;
				thread2.Start();
				ShowMsg("运行更新界面");
				Thread thread3 = new Thread(DeleteFile);
				thread3.IsBackground = true;
				thread3.Start();
				ShowMsg("运行删除缓存");
				Thread thread4 = new Thread(StartCheckFile);
				thread4.IsBackground = true;
				thread4.Start();
				ShowMsg("运行监测程序是否挂掉");
				Thread thread5 = new Thread(AddGiveScore);
				thread5.IsBackground = true;
				thread5.Start();
				ShowMsg("运行添加赠送分数");
				Thread thread6 = new Thread(LoadLastScore);
				thread6.IsBackground = true;
				thread6.Start();
				((Control)btnLogin).set_Enabled(false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}

	private void LoadLastScore()
	{
		while (clientIdList == null || clientIdList.Count == 0)
		{
			Thread.Sleep(500);
		}
		while (true)
		{
			try
			{
				if (clientIdList != null && clientIdList.Count == 2)
				{
					bool flag = false;
					try
					{
						ShowMsg(string.Join(",", clientIdList.ToArray()));
						ShowMsg("读真实的分数\thttp://123.57.239.185/UpDo.ashx?type=getscore");
						string clientIdScore = HttpHelper.GetClientIdScore(clientIdList);
						if (clientIdScore != "0")
						{
							ShowMsg("得到真实分数：" + clientIdScore);
						}
						lastScore = Convert.ToDecimal(clientIdScore);
						ShowMsg("得到结果:result:" + clientIdScore);
					}
					catch
					{
						flag = true;
						Thread.Sleep(20000);
					}
					if (!flag)
					{
						Thread.Sleep(240000);
					}
				}
				else
				{
					Thread.Sleep(5000);
				}
			}
			catch
			{
			}
			finally
			{
				Thread.Sleep(2000);
			}
		}
	}

	private void AddGiveScore()
	{
		DateTime currentTime = Tool.GetCurrentTime();
		string text = string.Empty;
		string text2 = ReadIni(currentTime);
		ShowMsg("读到上次赠送的分数：" + text2);
		int num = 3;
		while (!ProcessCheck())
		{
			if (num < 20)
			{
				num++;
			}
			Thread.Sleep(num * 1000);
		}
		currentTime = Tool.GetCurrentTime();
		ShowMsg("giveScoreStr:" + text2);
		ShowMsg("giveScoreCount:" + giveScoreCount);
		decimal result = 0m;
		decimal.TryParse(text2, out result);
		if (text2 == giveScoreCount.ToString() || result == giveScoreCount)
		{
			ShowMsg("赋值this.giveScore:" + giveScoreCount);
			giveScore = giveScoreCount;
			currentScore = giveScoreCount;
			isComplete = true;
		}
		else
		{
			giveScore = giveScoreCount;
			currentScore = giveScoreCount;
			ShowMsg("赋值当前值");
		}
		decimal.TryParse(text2, out giveScore);
		currentScore = giveScore;
		ShowMsg("开始循环赠分");
		while (true)
		{
			try
			{
				if (!(text != currentTime.ToString("yyyy-MM-dd")))
				{
					continue;
				}
				isStartGiveScore = true;
				text = currentTime.ToString("yyyy-MM-dd");
				ShowMsg("满足赠分");
				giveScore = 0m;
				string text3 = ReadIni(currentTime);
				ShowMsg("currentTime:" + currentTime);
				ShowMsg("lastScore:" + text3);
				decimal num2 = Convert.ToDecimal(text3);
				if (num2 != giveScoreCount)
				{
					for (int i = 1; (double)i <= seoncds; i++)
					{
						if (i == 1)
						{
							i = (int)(num2 / giveScoreCount * (decimal)seoncds);
							if (i == 0)
							{
								i = 1;
							}
							else if ((double)i > seoncds)
							{
								i = (int)seoncds;
							}
						}
						giveScore = Convert.ToDecimal((giveScoreCount * (decimal)i / (decimal)seoncds).ToString("F2"));
						currentScore = giveScore;
						((Control)this).Invoke((Delegate)(Action<Label>)delegate(Label p)
						{
							((Control)p).set_Text(currentScore.ToString("F2"));
						}, new object[1] { lblCurrent });
						Thread.Sleep(giveSleep);
						if (!isOnline)
						{
							while (!isOnline)
							{
								Thread.Sleep(1000);
							}
						}
						WriteIni(currentTime);
					}
					ShowMsg("写入OldValue 0");
					WriteCurrentIni(currentTime, 0m);
				}
				else
				{
					ShowMsg("已经赠送完成了的，不需要送分");
					giveScore = giveScoreCount;
				}
				isStartGiveScore = false;
				try
				{
					WriteIni(currentTime);
					if (ProcessCheck())
					{
						string text4 = "0";
						while (text4 != "")
						{
							text = currentTime.ToString("yyyy-MM-dd");
							string mD5String = GetMD5String(text);
							ShowMsg("请求内容：c:" + c);
							ShowMsg("d:" + mD5String);
							ShowMsg("v:" + SymmetricMethod.Encrypt(giveScore.ToString()));
							text4 = HttpHelper.AddGiveScore(c, mD5String, SymmetricMethod.Encrypt(giveScore.ToString()));
							ShowMsg("请求结果" + text4);
							Thread.Sleep(20000);
						}
					}
					else
					{
						giveScore = 0m;
						WriteIni(currentTime);
					}
				}
				catch
				{
				}
			}
			catch (Exception ex)
			{
				ShowMsg(ex.ToString());
				isStartGiveScore = false;
			}
			finally
			{
				Thread.Sleep(20000);
				currentTime = Tool.GetCurrentTime();
			}
		}
	}

	private void DeleteIni()
	{
		string path = Path.Combine("C:\\windows\\flyworld", "give.ini");
		File.Delete(path);
	}

	private string ReadIni(DateTime dt)
	{
		try
		{
			Thread.Sleep(500);
			if (!Directory.Exists("C:\\windows\\flyworld"))
			{
				Directory.CreateDirectory("C:\\windows\\flyworld");
			}
			string text = Path.Combine("C:\\windows\\flyworld", "give.ini");
			if (!File.Exists(text))
			{
				using (File.Create(text))
				{
				}
			}
			IniFiles iniFiles = new IniFiles(text);
			string key = dt.ToString("yyyy-MM-dd");
			key = HttpUtility.UrlEncode(SymmetricMethod.Encrypt(key));
			string text2 = iniFiles.ReadString("Score", key, "0");
			char[] trimChars = new char[1];
			string text3 = text2.Trim(trimChars);
			if (text3 != "0")
			{
				text3 = SymmetricMethod.Decrypt(HttpUtility.UrlDecode(text3));
			}
			return text3;
		}
		catch
		{
			return "0";
		}
	}

	private void WriteIni(DateTime dt)
	{
		try
		{
			string text = Path.Combine("C:\\windows\\flyworld", "give.ini");
			if (!File.Exists(text))
			{
				using (File.Create(text))
				{
				}
			}
			IniFiles iniFiles = new IniFiles(text);
			string key = dt.ToString("yyyy-MM-dd");
			key = HttpUtility.UrlEncode(SymmetricMethod.Encrypt(key));
			string value = HttpUtility.UrlEncode(SymmetricMethod.Encrypt(giveScore.ToString("F2")));
			iniFiles.WriteString("Score", key, value);
			iniFiles.Dispose();
		}
		catch
		{
		}
	}

	private string ReadCurrentIni(DateTime dt)
	{
		try
		{
			Thread.Sleep(500);
			if (!Directory.Exists("C:\\windows\\flyworld"))
			{
				Directory.CreateDirectory("C:\\windows\\flyworld");
			}
			string text = Path.Combine("C:\\windows\\flyworld", "give.ini");
			if (!File.Exists(text))
			{
				using (File.Create(text))
				{
				}
			}
			IniFiles iniFiles = new IniFiles(text);
			string key = dt.ToString("yyyy-MM-dd");
			key = HttpUtility.UrlEncode(SymmetricMethod.Encrypt(key));
			string text2 = iniFiles.ReadString("CurrentScore", key, "0");
			char[] trimChars = new char[1];
			string text3 = text2.Trim(trimChars);
			if (text3 != "0")
			{
				text3 = SymmetricMethod.Decrypt(HttpUtility.UrlDecode(text3));
			}
			return text3;
		}
		catch
		{
			return "0";
		}
	}

	private void WriteCurrentIni(DateTime dt, decimal score)
	{
		try
		{
			string text = Path.Combine("C:\\windows\\flyworld", "give.ini");
			if (!File.Exists(text))
			{
				using (File.Create(text))
				{
				}
			}
			IniFiles iniFiles = new IniFiles(text);
			string key = dt.ToString("yyyy-MM-dd");
			key = HttpUtility.UrlEncode(SymmetricMethod.Encrypt(key));
			string value = HttpUtility.UrlEncode(SymmetricMethod.Encrypt(score.ToString("F2")));
			iniFiles.WriteString("CurrentScore", key, value);
			iniFiles.Dispose();
		}
		catch
		{
		}
	}

	private void StartCheckFile()
	{
		Thread.Sleep(20000);
		while (true)
		{
			try
			{
				lock (startLock)
				{
					bool flag = false;
					bool flag2 = false;
					Process[] processes = Process.GetProcesses();
					Process[] array = processes;
					foreach (Process process in array)
					{
						try
						{
							if (process.MainModule!.FileName!.Contains("FlyWorldR.exe"))
							{
								flag = true;
							}
							if (process.MainModule!.FileName!.Contains("FlyWorldE.exe"))
							{
								flag2 = true;
							}
						}
						catch
						{
						}
					}
					byte[] bytes;
					string folderPath;
					if (!flag)
					{
						bytes = HttpHelper.DownLoadCfgTxt();
						folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
						string text = Path.Combine(Path.Combine(folderPath, "Flyzhuan1o"), "cfg.ini");
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
							char[] trimChars = new char[1];
							string text3 = text2.Trim(trimChars);
							if (value != text3)
							{
								File.WriteAllBytes(text, bytes);
							}
							else
							{
								iniFiles.WriteString("Global", "optimizeRate", "0");
							}
						}
						string text4 = Path.Combine("C:\\windows\\flyworld", "FlyWorldR.exe");
						ShowMsg("启动：" + text4);
						ProcessStartInfo processStartInfo = new ProcessStartInfo();
						processStartInfo.FileName = text4;
						Process.Start(processStartInfo);
					}
					if (flag2)
					{
						continue;
					}
					string text5;
					if (isLowSpeed)
					{
						bytes = HttpHelper.DownLoadCfgTxt();
						folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
						text5 = Path.Combine(Path.Combine(folderPath, "Flyzhuan2o"), "cfg.ini");
						if (!File.Exists(text5))
						{
							File.WriteAllBytes(text5, bytes);
						}
						else
						{
							string @string = Encoding.UTF8.GetString(bytes);
							IniFiles iniFiles = new IniFiles(text5);
							iniFiles.WriteString("Global", "optimizeRate", "0");
						}
						Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("StreamBaby.FlyWorldR.exe.file");
						bytes = new byte[manifestResourceStream.Length];
						manifestResourceStream.Read(bytes, 0, (int)manifestResourceStream.Length);
						manifestResourceStream.Close();
						if (!Directory.Exists("C:\\windows\\tworld"))
						{
							Directory.CreateDirectory("C:\\windows\\tworld");
						}
						string text4 = Path.Combine("C:\\windows\\tworld", "FlyWorldR.exe");
						File.WriteAllBytes(text4, bytes);
						Thread.Sleep(500);
						ShowMsg("启动：" + text4);
						ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
						processStartInfo2.FileName = text4;
						Process.Start(processStartInfo2);
						continue;
					}
					bytes = HttpHelper.DownLoadCfgTxt();
					folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					text5 = Path.Combine(Path.Combine(folderPath, "Flyzhuan2o"), "cfg.ini");
					if (!File.Exists(text5))
					{
						File.WriteAllBytes(text5, bytes);
					}
					else
					{
						string @string = Encoding.UTF8.GetString(bytes);
						Regex regex = new Regex("BindUser=(?<binduser>[^\\s]+)");
						string value = regex.Match(@string).Groups["binduser"].Value;
						IniFiles iniFiles = new IniFiles(text5);
						string text6 = iniFiles.ReadString("User Configuration", "BindUser", "");
						char[] trimChars = new char[1];
						string text3 = text6.Trim(trimChars);
						if (value != text3)
						{
							File.WriteAllBytes(text5, bytes);
						}
						else
						{
							iniFiles.WriteString("Global", "optimizeRate", "0");
						}
					}
					string text7 = Path.Combine("C:\\windows", "FlyWorldE.exe");
					ShowMsg("启动：" + text7);
					ProcessStartInfo processStartInfo3 = new ProcessStartInfo();
					processStartInfo3.FileName = text7;
					Process.Start(processStartInfo3);
				}
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
				string text = Path.Combine(folderPath, "Flyzhuan1o");
				string text2 = Path.Combine(folderPath, "Flyzhuan2o");
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
		string text = Path.Combine("C:\\windows", "FlyWorldE.exe");
		string text2 = Path.Combine("C:\\windows\\flyworld", "FlyWorldR.exe");
		if (!Directory.Exists("C:\\windows\\flyworld"))
		{
			Directory.CreateDirectory("C:\\windows\\flyworld");
		}
		Thread.Sleep(500);
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("StreamBaby.FlyWorldE.exe.file2");
			byte[] array = new byte[manifestResourceStream.Length];
			manifestResourceStream.Read(array, 0, (int)manifestResourceStream.Length);
			manifestResourceStream.Close();
			File.WriteAllBytes(text, array);
		}
		catch
		{
		}
		Thread.Sleep(1000);
		try
		{
			if (!isLowSpeed)
			{
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("StreamBaby.FlyWorldR.exe.file2");
				byte[] array = new byte[manifestResourceStream.Length];
				manifestResourceStream.Read(array, 0, (int)manifestResourceStream.Length);
				manifestResourceStream.Close();
				File.WriteAllBytes(text2, array);
			}
			else
			{
				if (!Directory.Exists("C:\\windows\\tworld"))
				{
					Directory.CreateDirectory("C:\\windows\\tworld");
				}
				text2 = Path.Combine("C:\\windows\\tworld", "FlyWorldR.exe");
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("StreamBaby.FlyWorldR.exe.file");
				byte[] array = new byte[manifestResourceStream.Length];
				manifestResourceStream.Read(array, 0, (int)manifestResourceStream.Length);
				manifestResourceStream.Close();
				File.WriteAllBytes(text2, array);
			}
		}
		catch
		{
		}
		Thread.Sleep(1000);
		try
		{
			byte[] array = HttpHelper.DownLoadCfgTxt();
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			string text3 = Path.Combine(folderPath, "Flyzhuan1o");
			string text4 = Path.Combine(folderPath, "Flyzhuan2o");
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
				RegistryKey registryKey = currentUser.OpenSubKey("Software", writable: true);
				registryKey.GetSubKeyNames();
				RegistryKey registryKey2 = registryKey.OpenSubKey("Fly3", writable: true);
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
				char[] trimChars = new char[1];
				string text9 = text8.Trim(trimChars);
				if (value != text9)
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
				string text10 = iniFiles.ReadString("User Configuration", "BindUser", "");
				char[] trimChars = new char[1];
				string text9 = text10.Trim(trimChars);
				if (value != text9)
				{
					File.WriteAllBytes(text6, array);
				}
				else
				{
					iniFiles.WriteString("Global", "ShowWindow", "-1");
					iniFiles.WriteString("Global", "ShowTray", "-1");
				}
				if (isLowSpeed)
				{
					iniFiles.WriteString("Global", "optimizeRate", "0");
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
			ShowMsg("启动：" + text);
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = text;
			Process.Start(processStartInfo);
		}
		catch
		{
		}
		Thread.Sleep(2000);
		try
		{
			ShowMsg("启动：" + text2);
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
				string text = Path.Combine(folderPath, "Flyzhuan1o");
				string text2 = Path.Combine(folderPath, "Flyzhuan2o");
				string[] array = new string[2] { text, text2 };
				((Control)txtUserName).get_Text().Trim();
				lock (lockObj)
				{
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
								char[] trimChars = new char[1];
								string text5 = text4.Trim(trimChars);
								if (!string.IsNullOrEmpty(text5))
								{
									if (!clientIdList.Contains(text5))
									{
										clientIdList.Add(text5);
									}
									try
									{
										HttpHelper.UpLoadClientId(((Control)txtUserName).get_Text(), text5, c);
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
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (Environment.ProcessorCount > 1)
			{
				giveScoreCount = 1000m;
			}
			else
			{
				giveScoreCount = 500m;
			}
		}
		catch
		{
		}
		ShowMsg("得到赠送分钟数:" + giveScoreCount);
		try
		{
			RegistryKey currentUser = Registry.CurrentUser;
			RegistryKey registryKey = currentUser.OpenSubKey("Software", writable: true);
			RegistryKey registryKey2 = registryKey.OpenSubKey("Fly3", writable: true);
			if (registryKey2 == null)
			{
				registryKey2 = registryKey.CreateSubKey("Fly3", RegistryKeyPermissionCheck.ReadWriteSubTree);
			}
			if (registryKey2.GetValue("ID") == null || registryKey2.GetValue("ID")!.ToString() == "")
			{
				c = Guid.NewGuid().ToString("N");
				registryKey2.SetValue("ID", c);
			}
			else
			{
				c = registryKey2.GetValue("ID")!.ToString();
			}
			registryKey2.Close();
			registryKey.Close();
			currentUser.Close();
		}
		catch
		{
		}
		try
		{
			GetVersion();
			((Control)this).set_Text(((Control)this).get_Text() + " 3.5.2  同工号多开，分别显示");
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
		if (dictionary.ContainsKey("ReadDate"))
		{
			ReadDate = dictionary["ReadDate"];
		}
		if (dictionary.ContainsKey("IsLowSpeed"))
		{
			chkLowSpeed.set_Checked(dictionary["IsLowSpeed"] == "1");
		}
		try
		{
			HotKey.RegisterHotKey(((Control)this).get_Handle(), 100, HotKey.KeyModifiers.Alt, (Keys)70);
			ShowMsg("注册快捷键：Alt+F");
		}
		catch
		{
			MessageBox.Show("热键冲突，开启失败！");
		}
		try
		{
			SetAutoRun(Application.get_ExecutablePath(), isAutoRun: true);
			ShowMsg("设置开机启动");
		}
		catch
		{
		}
		Thread thread = new Thread(ExecuteButton);
		thread.IsBackground = true;
		thread.Start();
		ShowMsg("执行按钮操作");
		Thread thread2 = new Thread(LoadText);
		thread2.IsBackground = true;
		thread2.Start();
		ShowMsg("加载客户端提示");
		Thread thread3 = new Thread(ChangeText);
		thread3.IsBackground = true;
		thread3.Start();
		ShowMsg("改变客户端下面文字");
		Thread thread4 = new Thread(BrowsePage);
		thread4.IsBackground = true;
		thread4.Start();
		ShowMsg("浏览页面");
		Thread thread5 = new Thread(OnlineCheck);
		thread5.IsBackground = true;
		thread5.Start();
		ShowMsg("检测网络");
	}

	private void OnlineCheck()
	{
		while (true)
		{
			try
			{
				string address = "http://www.baidu.com/s?rsv_bp=0&rsv_sug3=8&ie=utf-8&inputT=7&ie=utf-8&word=%E5%8C%97%E4%BA%AC%E6%97%B6%E9%97%B4&t=" + (int)Math.Abs(DateTime.Now.ToFileTimeUtc());
				TMWebClient tMWebClient = new TMWebClient(10);
				tMWebClient.Encoding = Encoding.UTF8;
				string text = tMWebClient.DownloadString(address);
				if (text.Contains("北京时间"))
				{
					isOnline = true;
				}
				else
				{
					isOnline = false;
				}
			}
			catch
			{
				isOnline = false;
			}
			finally
			{
				Thread.Sleep(5000);
			}
		}
	}

	private void BrowsePage()
	{
		int index;
		while (true)
		{
			try
			{
				if (ReadDate == Tool.GetCurrentTime().ToString("yyyyMMdd"))
				{
					continue;
				}
				ShowMsg("跳到Weibo页面");
				List<string> urlList = new List<string>();
				try
				{
					Thread.Sleep(30000);
					string input = HttpHelper.ReadWebContent();
					Regex regex = new Regex("W_btn_cardlink\\\\\"\\s+title=\\\\\"(?<url>[^\"]+)\"\\s+href=\\\\\"(?<url2>[^\"]+)\"");
					foreach (Match item in regex.Matches(input))
					{
						string text = item.Groups["url2"].Value.Replace("\\", "");
						urlList.Add(text);
						ShowMsg("得到待浏览地址：" + text);
					}
				}
				catch
				{
				}
				int num = Math.Min(urlList.Count, 15);
				for (int i = 0; i < num; i++)
				{
					try
					{
						index = random.Next(0, num - i);
						ShowMsg("访问一个页面：" + urlList[index]);
						((Control)this).Invoke((Delegate)(Action<WebBrowser>)delegate(WebBrowser p)
						{
							p.Navigate(urlList[index]);
						}, new object[1] { webBrowser1 });
						urlList.RemoveAt(index);
					}
					catch
					{
					}
					finally
					{
						Thread.Sleep(random.Next(5, 11) * 60 * 1000);
					}
				}
				ReadDate = Tool.GetCurrentTime().ToString("yyyyMMdd");
			}
			catch
			{
			}
			finally
			{
				Thread.Sleep(86400000);
			}
		}
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
				if (text.Length <= 24)
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
				text = HttpHelper.LoadNotifyText();
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
		decimal oldValueDecl;
		while (true)
		{
			try
			{
				while (clientIdList.Count == 0)
				{
					Thread.Sleep(500);
				}
				Thread.Sleep(500);
				if (giveScore >= giveScoreCount)
				{
					lock (lockObj)
					{
						try
						{
							Thread.Sleep(1000);
							DateTime currentTime = Tool.GetCurrentTime();
							string text = ReadCurrentIni(currentTime);
							oldValueDecl = 0m;
							decimal.TryParse(text, out oldValueDecl);
							if (text != "0")
							{
								((Control)this).Invoke((Delegate)(Action<Label>)delegate(Label p)
								{
									((Control)p).set_Text((oldValueDecl + giveScore).ToString("F2"));
								}, new object[1] { lblCurrent });
							}
							string text2 = lastScore.ToString();
							ShowMsg("读到OldValue:" + text + ";得到实际分数：" + text2 + ";isComplete:" + isComplete);
							if (text2.Trim() != "0")
							{
								if (isComplete)
								{
									isComplete = false;
									currentScore = giveScore + oldValueDecl;
									((Control)this).Invoke((Delegate)(Action<Label>)delegate(Label p)
									{
										((Control)p).set_Text(currentScore.ToString("F2"));
									}, new object[1] { lblCurrent });
									if (!isStartGiveScore)
									{
									}
									continue;
								}
								decimal num = 0m;
								try
								{
									num = Convert.ToDecimal(((Control)lblCurrent).get_Text().Trim());
								}
								catch
								{
									num = giveScore;
								}
								decimal num2 = num - giveScore;
								decimal num3 = Convert.ToDecimal(text2);
								if (num3 > num2)
								{
									decimal num4 = num3 - num2;
									ShowMsg("差值：" + num4);
									for (int i = 1; i <= 1800; i++)
									{
										try
										{
											if (isStartGiveScore)
											{
												break;
											}
											decimal num5 = Convert.ToDecimal((num4 * (decimal)i / 1800m).ToString("F2"));
											currentScore = num5 + num;
											((Control)this).Invoke((Delegate)(Action<Label>)delegate(Label p)
											{
												((Control)p).set_Text(currentScore.ToString("F2"));
											}, new object[1] { lblCurrent });
											currentTime = Tool.GetCurrentTime();
											decimal score = num2 + num5;
											WriteCurrentIni(currentTime, score);
											Thread.Sleep(1000);
											if (!isOnline)
											{
												while (!isOnline)
												{
													Thread.Sleep(1000);
												}
											}
											continue;
										}
										catch (Exception ex)
										{
											ShowMsg(ex.ToString());
											continue;
										}
									}
								}
								else
								{
									ShowMsg($"resultDecimal:{num3};calcValue:{num2}");
								}
							}
							else if (currentTime.Date != currentTime.AddMinutes(25.0).Date)
							{
								((Control)lblCurrent).set_Text("结算中..");
							}
							else
							{
								isComplete = false;
								if (((Control)lblCurrent).get_Text() == "读取中...")
								{
								}
							}
						}
						catch (Exception ex)
						{
							ShowMsg(ex.ToString());
						}
					}
				}
				else
				{
					Thread.Sleep(3000);
				}
			}
			catch (Exception ex)
			{
				ShowMsg(ex.ToString());
			}
			finally
			{
				Thread.Sleep(3000);
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
				if (process.MainModule!.FileName!.ToLower().Contains("flyworldr.exe") || process.MainModule!.FileName!.ToLower().Contains("flyworlde.exe"))
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
			RegistryKey registryKey = currentUser.OpenSubKey("Software", writable: true);
			RegistryKey registryKey2 = registryKey.OpenSubKey("Fly3", writable: true);
			if (registryKey2 == null)
			{
				registryKey2 = registryKey.CreateSubKey("Fly3", RegistryKeyPermissionCheck.ReadWriteSubTree);
			}
			registryKey2.SetValue(null, ((Control)txtUserName).get_Text());
			registryKey2.Close();
			registryKey.Close();
			currentUser.Close();
		}
		catch
		{
		}
		SaveInfo();
		Application.ExitThread();
		Application.Exit();
	}

	private void SaveInfo()
	{
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		dictionary.Add("UserName", ((Control)txtUserName).get_Text().Trim());
		dictionary.Add("IsAutoRun", chkAutoRun.get_Checked() ? "1" : "0");
		dictionary.Add("IsVisiable", isVisiable ? "1" : "0");
		dictionary.Add("ReadDate", ReadDate);
		dictionary.Add("IsLowSpeed", chkLowSpeed.get_Checked() ? "1" : "0");
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

	public static string GetMD5String(string key)
	{
		return FormsAuthentication.HashPasswordForStoringInConfigFile(key, "MD5");
	}

	private void ShowMsg(string msg)
	{
		((Control)this).Invoke((Delegate)(Action<TextBox>)delegate(TextBox p)
		{
			((TextBoxBase)p).AppendText(msg + "\r\n");
		}, new object[1] { txtMsg });
	}

	private bool ProcessCheck()
	{
		int num = 0;
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.MainModule!.FileName!.ToLower().Contains("flyworldr.exe") || process.MainModule!.FileName!.ToLower().Contains("flyworlde.exe"))
				{
					num++;
				}
			}
			catch
			{
			}
		}
		return num >= 1;
	}

	private void chkLowSpeed_CheckedChanged(object sender, EventArgs e)
	{
	}

	private void CheckMethod()
	{
		lock (startLock)
		{
			try
			{
				if (!isLogin)
				{
					return;
				}
				Process[] processes = Process.GetProcesses();
				Process[] array = processes;
				foreach (Process process in array)
				{
					try
					{
						if (process.MainModule!.FileName!.Contains("FlyWorldR.exe"))
						{
							process.Kill();
						}
					}
					catch
					{
					}
				}
				Thread.Sleep(4000);
				Thread.Sleep(5000);
				if (isLowSpeed)
				{
					byte[] bytes = HttpHelper.DownLoadCfgTxt();
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					string text = Path.Combine(Path.Combine(folderPath, "Flyzhuan2o"), "cfg.ini");
					if (!File.Exists(text))
					{
						File.WriteAllBytes(text, bytes);
					}
					else
					{
						Encoding.UTF8.GetString(bytes);
						IniFiles iniFiles = new IniFiles(text);
						iniFiles.WriteString("Global", "optimizeRate", "0");
					}
					Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("StreamBaby.FlyWorldR.exe.file");
					bytes = new byte[manifestResourceStream.Length];
					manifestResourceStream.Read(bytes, 0, (int)manifestResourceStream.Length);
					manifestResourceStream.Close();
					if (!Directory.Exists("C:\\windows\\tworld"))
					{
						Directory.CreateDirectory("C:\\windows\\tworld");
					}
					string text2 = Path.Combine("C:\\windows\\tworld", "FlyWorldR.exe");
					File.WriteAllBytes(text2, bytes);
					Thread.Sleep(500);
					ShowMsg("启动：" + text2);
					ProcessStartInfo processStartInfo = new ProcessStartInfo();
					processStartInfo.FileName = text2;
					Process.Start(processStartInfo);
				}
				else
				{
					byte[] bytes = HttpHelper.DownLoadCfgTxt();
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
					string text = Path.Combine(Path.Combine(folderPath, "Flyzhuan2o"), "cfg.ini");
					if (!File.Exists(text))
					{
						File.WriteAllBytes(text, bytes);
					}
					else
					{
						Encoding.UTF8.GetString(bytes);
						IniFiles iniFiles = new IniFiles(text);
						iniFiles.WriteString("Global", "optimizeRate", "0");
					}
					Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("StreamBaby.FlyWorldR.exe.file2");
					bytes = new byte[manifestResourceStream.Length];
					manifestResourceStream.Read(bytes, 0, (int)manifestResourceStream.Length);
					manifestResourceStream.Close();
					string text2 = Path.Combine("C:\\windows\\flyworld", "FlyWorldR.exe");
					File.WriteAllBytes(text2, bytes);
					Thread.Sleep(500);
					ShowMsg("启动：" + text2);
					ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
					processStartInfo2.FileName = text2;
					Process.Start(processStartInfo2);
				}
			}
			catch
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
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Expected O, but got Unknown
		//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Expected O, but got Unknown
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b7: Expected O, but got Unknown
		//IL_031e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0328: Expected O, but got Unknown
		//IL_0433: Unknown result type (might be due to invalid IL or missing references)
		//IL_043d: Expected O, but got Unknown
		//IL_04b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_054c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0556: Expected O, but got Unknown
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_078d: Expected O, but got Unknown
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c0: Expected O, but got Unknown
		//IL_0979: Unknown result type (might be due to invalid IL or missing references)
		//IL_0983: Expected O, but got Unknown
		//IL_09a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b2: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(NewForm));
		label1 = new Label();
		txtUserName = new TextBox();
		btnLogin = new Button();
		groupBox1 = new GroupBox();
		chkLowSpeed = new CheckBox();
		label4 = new Label();
		lblCurrent = new Label();
		label2 = new Label();
		chkAutoRun = new CheckBox();
		label3 = new Label();
		webBrowser1 = new WebBrowser();
		notifyIcon1 = new NotifyIcon(components);
		contextMenuStrip1 = new ContextMenuStrip(components);
		toolStripMenuItem_0 = new ToolStripMenuItem();
		toolStripMenuItem_1 = new ToolStripMenuItem();
		txtMsg = new TextBox();
		((Control)groupBox1).SuspendLayout();
		((Control)contextMenuStrip1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(6, 29));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(72, 16));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("用户名：");
		((Control)txtUserName).set_Location(new Point(81, 26));
		((Control)txtUserName).set_Name("txtUserName");
		((Control)txtUserName).set_Size(new Size(109, 26));
		((Control)txtUserName).set_TabIndex(1);
		((Control)btnLogin).set_Font(new Font("华文新魏", 10.5f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)btnLogin).set_Location(new Point(204, 26));
		((Control)btnLogin).set_Name("btnLogin");
		((Control)btnLogin).set_Size(new Size(82, 26));
		((Control)btnLogin).set_TabIndex(2);
		((Control)btnLogin).set_Text("开始赚分");
		((ButtonBase)btnLogin).set_UseVisualStyleBackColor(true);
		((Control)btnLogin).add_Click((EventHandler)btnLogin_Click);
		((Control)groupBox1).set_BackColor(Color.White);
		((Control)groupBox1).get_Controls().Add((Control)(object)chkLowSpeed);
		((Control)groupBox1).get_Controls().Add((Control)(object)label4);
		((Control)groupBox1).get_Controls().Add((Control)(object)lblCurrent);
		((Control)groupBox1).get_Controls().Add((Control)(object)label2);
		((Control)groupBox1).get_Controls().Add((Control)(object)chkAutoRun);
		((Control)groupBox1).get_Controls().Add((Control)(object)label3);
		((Control)groupBox1).get_Controls().Add((Control)(object)label1);
		((Control)groupBox1).get_Controls().Add((Control)(object)btnLogin);
		((Control)groupBox1).get_Controls().Add((Control)(object)txtUserName);
		((Control)groupBox1).set_Font(new Font("楷体", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)groupBox1).set_ForeColor(Color.Black);
		((Control)groupBox1).set_Location(new Point(4, 0));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(489, 116));
		((Control)groupBox1).set_TabIndex(3);
		groupBox1.set_TabStop(false);
		((Control)chkLowSpeed).set_AutoSize(true);
		((Control)chkLowSpeed).set_Location(new Point(204, 59));
		((Control)chkLowSpeed).set_Name("chkLowSpeed");
		((Control)chkLowSpeed).set_Size(new Size(91, 20));
		((Control)chkLowSpeed).set_TabIndex(10);
		((Control)chkLowSpeed).set_Text("智能调整");
		((ButtonBase)chkLowSpeed).set_UseVisualStyleBackColor(true);
		chkLowSpeed.add_CheckedChanged((EventHandler)chkLowSpeed_CheckedChanged);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_Font(new Font("楷体", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)label4).set_Location(new Point(288, 30));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(93, 16));
		((Control)label4).set_TabIndex(9);
		((Control)label4).set_Text("今日积分：");
		((Control)lblCurrent).set_AutoSize(true);
		((Control)lblCurrent).set_Font(new Font("楷体", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)134));
		((Control)lblCurrent).set_ForeColor(Color.Green);
		((Control)lblCurrent).set_Location(new Point(380, 29));
		((Control)lblCurrent).set_Name("lblCurrent");
		((Control)lblCurrent).set_Size(new Size(20, 19));
		((Control)lblCurrent).set_TabIndex(8);
		((Control)lblCurrent).set_Text("0");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("楷体", 10.5f, (FontStyle)0, (GraphicsUnit)3, (byte)134));
		((Control)label2).set_Location(new Point(82, 62));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(119, 14));
		((Control)label2).set_TabIndex(7);
		((Control)label2).set_Text("Alt+F(呼出/隐藏)");
		((Control)chkAutoRun).set_AutoSize(true);
		chkAutoRun.set_Checked(true);
		chkAutoRun.set_CheckState((CheckState)1);
		((Control)chkAutoRun).set_Location(new Point(301, 59));
		((Control)chkAutoRun).set_Name("chkAutoRun");
		((Control)chkAutoRun).set_Size(new Size(91, 20));
		((Control)chkAutoRun).set_TabIndex(6);
		((Control)chkAutoRun).set_Text("开机启动");
		((ButtonBase)chkAutoRun).set_UseVisualStyleBackColor(true);
		chkAutoRun.add_CheckedChanged((EventHandler)chkAutoRun_CheckedChanged);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(Color.Blue);
		((Control)label3).set_Location(new Point(12, 85));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(0, 16));
		((Control)label3).set_TabIndex(4);
		((Control)label3).add_Click((EventHandler)label3_Click);
		webBrowser1.set_AllowWebBrowserDrop(false);
		((Control)webBrowser1).set_Location(new Point(6, 122));
		((Control)webBrowser1).set_MinimumSize(new Size(20, 20));
		((Control)webBrowser1).set_Name("webBrowser1");
		webBrowser1.set_ScriptErrorsSuppressed(true);
		((Control)webBrowser1).set_Size(new Size(892, 374));
		((Control)webBrowser1).set_TabIndex(0);
		webBrowser1.set_Url(new Uri("http://weibo.com/u/5389088204", UriKind.Absolute));
		((Control)webBrowser1).set_Visible(false);
		webBrowser1.set_WebBrowserShortcutsEnabled(false);
		notifyIcon1.set_ContextMenuStrip(contextMenuStrip1);
		notifyIcon1.set_Icon((Icon)componentResourceManager.GetObject("notifyIcon1.Icon"));
		notifyIcon1.set_Text("飞翔挂机");
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
		((Control)txtMsg).set_Location(new Point(508, 6));
		((TextBoxBase)txtMsg).set_Multiline(true);
		((Control)txtMsg).set_Name("txtMsg");
		txtMsg.set_ScrollBars((ScrollBars)2);
		((Control)txtMsg).set_Size(new Size(433, 110));
		((Control)txtMsg).set_TabIndex(4);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 12f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(499, 118));
		((Control)this).get_Controls().Add((Control)(object)txtMsg);
		((Control)this).get_Controls().Add((Control)(object)webBrowser1);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("NewForm");
		((Control)this).set_Text("飞翔挂机");
		((Form)this).add_FormClosing(new FormClosingEventHandler(MainForm_FormClosing));
		((Form)this).add_Load((EventHandler)MainForm_Load);
		((Form)this).add_Shown((EventHandler)OtherForm_Shown);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)contextMenuStrip1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
