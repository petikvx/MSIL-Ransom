using System;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace LessonPlannerUninstaller;

public class UninstallerManager
{
	private string _appOrganization = ConfigurationManager.get_AppSettings()["AppOrganization"];

	private string _appName = ConfigurationManager.get_AppSettings()["AppName"];

	private string _appDisplayName = ConfigurationManager.get_AppSettings()["AppDisplayName"];

	private string _programs = ConfigurationManager.get_AppSettings()["Programs"];

	private string _processName = "ITWorx.Education.CPExpert.UI";

	private string portableEXE = string.Empty;

	public string DisplayName => _appDisplayName;

	public void Uninstall()
	{
		portableEXE = _appOrganization + "\\" + _appName + "\\ITWorx.Education.CPExpert.UI.exe";
		try
		{
			KillLessonPlannerProcessIfAny();
			RemoveRegistrykeyTree("LessonPlanner");
			DeleteShortcuts();
			DeleteInstallationFolder(_appName);
		}
		catch (Exception ex)
		{
			ExceptionLogger.FormatLogMessage(ex);
		}
	}

	public void RemoveRegistrykeyTree(string LessonPlannerRegKey)
	{
		try
		{
			string name = "Software\\Classes";
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(name, writable: true);
			if (registryKey != null)
			{
				int num = Array.IndexOf(registryKey.GetSubKeyNames(), LessonPlannerRegKey);
				if (num != -1)
				{
					registryKey.DeleteSubKeyTree(LessonPlannerRegKey);
				}
			}
		}
		catch (Exception ex)
		{
			ExceptionLogger.FormatLogMessage(ex);
		}
	}

	public void DeleteShortcuts()
	{
		try
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string path = Path.Combine(folderPath, _appDisplayName + ".lnk");
			if (File.Exists(path))
			{
				File.Delete(path);
			}
			string text = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\" + _programs + "\\" + _appOrganization;
			string path2 = text + "\\" + _appDisplayName;
			if (Directory.Exists(path2))
			{
				Directory.Delete(path2, recursive: true);
			}
			if (Directory.Exists(text))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				if (directoryInfo.GetFileSystemInfos().Length == 0)
				{
					Directory.Delete(text);
				}
			}
		}
		catch (Exception ex)
		{
			ExceptionLogger.FormatLogMessage(ex);
		}
	}

	public void DeleteInstallationFolder(string AppName)
	{
		try
		{
			AppName = _appOrganization + "\\" + AppName;
			string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), AppName);
			if (Directory.Exists(path))
			{
				Directory.Delete(path, recursive: true);
			}
		}
		catch (Exception ex)
		{
			ExceptionLogger.FormatLogMessage(ex);
		}
	}

	public void KillLessonPlannerProcessIfAny()
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Invalid comparison between Unknown and I4
		try
		{
			if (!IsLPInstanceRunning())
			{
				return;
			}
			DialogResult val = MessageBox.Show(_appName + " should be closed first. Clicking \"Ok\" will close " + _appName + ". Choose \"Cancel\" if you want to save your changes.", "Warning", (MessageBoxButtons)1, (MessageBoxIcon)48);
			if ((int)val == 1)
			{
				Process[] processesByName = Process.GetProcessesByName(_processName);
				Process[] array = processesByName;
				foreach (Process process in array)
				{
					process.Kill();
				}
			}
			else
			{
				Application.Exit();
			}
		}
		catch (Exception ex)
		{
			ExceptionLogger.FormatLogMessage(ex);
		}
	}

	private bool IsLPInstanceRunning()
	{
		Process[] processesByName = Process.GetProcessesByName(_processName);
		if (processesByName.Length > 0)
		{
			return true;
		}
		return false;
	}
}
