using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace StreamBaby;

public class SymmetricMethod
{
	private static SymmetricAlgorithm mobjCryptoService;

	private static string key;

	private static string stemp;

	static SymmetricMethod()
	{
		mobjCryptoService = new RijndaelManaged();
		key = "test";
		stemp = "test2";
	}

	private static byte[] GetLegalKey()
	{
		string text = key;
		mobjCryptoService.GenerateKey();
		byte[] array = mobjCryptoService.Key;
		int num = array.Length;
		if (text.Length > num)
		{
			text = text.Substring(0, num);
		}
		else if (text.Length < num)
		{
			text = text.PadRight(num, ' ');
		}
		return Encoding.ASCII.GetBytes(text);
	}

	private static byte[] GetLegalIV()
	{
		mobjCryptoService.GenerateIV();
		byte[] iV = mobjCryptoService.IV;
		int num = iV.Length;
		if (stemp.Length > num)
		{
			stemp = stemp.Substring(0, num);
		}
		else if (stemp.Length < num)
		{
			stemp = stemp.PadRight(num, ' ');
		}
		return Encoding.ASCII.GetBytes(stemp);
	}

	private static string Encrypto(string source)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(source);
		using MemoryStream memoryStream = new MemoryStream();
		mobjCryptoService.Key = GetLegalKey();
		mobjCryptoService.IV = GetLegalIV();
		ICryptoTransform transform = mobjCryptoService.CreateEncryptor();
		using CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
		cryptoStream.Write(bytes, 0, bytes.Length);
		cryptoStream.FlushFinalBlock();
		cryptoStream.Close();
		memoryStream.Close();
		byte[] inArray = memoryStream.ToArray();
		return Convert.ToBase64String(inArray);
	}

	private static string Decrypto(string source)
	{
		byte[] array = Convert.FromBase64String(source);
		using MemoryStream stream = new MemoryStream(array, 0, array.Length);
		mobjCryptoService.Key = GetLegalKey();
		mobjCryptoService.IV = GetLegalIV();
		ICryptoTransform transform = mobjCryptoService.CreateDecryptor();
		using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		using StreamReader streamReader = new StreamReader(stream2);
		return streamReader.ReadToEnd();
	}

	public static string Encrypt(string key)
	{
		try
		{
			return Encrypto(key);
		}
		catch
		{
			return key;
		}
	}

	public static string Decrypt(string key)
	{
		try
		{
			return Decrypto(key);
		}
		catch
		{
			return key;
		}
	}
}
