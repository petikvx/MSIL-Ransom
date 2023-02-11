using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Program;

internal class Cryptor
{
	public static byte[] CreateMD5(string input)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(input);
		return mD.ComputeHash(bytes);
	}

	public static byte[] AESEncryptBytes(byte[] clearBytes, byte[] passBytes, byte[] saltBytes)
	{
		byte[] array = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passBytes, saltBytes, 32768);
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(clearBytes, 0, clearBytes.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static byte[] AESDecryptBytes(byte[] cryptBytes, byte[] passBytes, byte[] saltBytes)
	{
		byte[] array = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passBytes, saltBytes, 32768);
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		using MemoryStream memoryStream = new MemoryStream();
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateDecryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(cryptBytes, 0, cryptBytes.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
	{
		if (plainText != null && plainText.Length > 0)
		{
			if (Key != null && Key.Length > 0)
			{
				if (IV != null && IV.Length > 0)
				{
					using (Aes aes = Aes.Create())
					{
						aes.Key = Key;
						aes.IV = IV;
						ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
						using MemoryStream memoryStream = new MemoryStream();
						using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
						using (StreamWriter streamWriter = new StreamWriter(stream))
						{
							streamWriter.Write(plainText);
						}
						return memoryStream.ToArray();
					}
				}
				throw new ArgumentNullException("IV");
			}
			throw new ArgumentNullException("Key");
		}
		throw new ArgumentNullException("plainText");
	}

	public static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
	{
		if (cipherText != null && cipherText.Length > 0)
		{
			if (Key != null && Key.Length > 0)
			{
				if (IV != null && IV.Length > 0)
				{
					string text = null;
					using Aes aes = Aes.Create();
					aes.Key = Key;
					aes.IV = IV;
					ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
					using MemoryStream stream = new MemoryStream(cipherText);
					using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
					using StreamReader streamReader = new StreamReader(stream2);
					return streamReader.ReadToEnd();
				}
				throw new ArgumentNullException("IV");
			}
			throw new ArgumentNullException("Key");
		}
		throw new ArgumentNullException("cipherText");
	}
}
