using System;
using System.Security.Cryptography;
using System.Text;

namespace Stub;

public class AlgorithmAES
{
	public static object Decrypt(string input)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		byte[] array = new byte[32];
		byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(UTF8SB(Settings.Mutex));
		Array.Copy(sourceArray, 0, array, 0, 16);
		Array.Copy(sourceArray, 0, array, 15, 16);
		rijndaelManaged.Key = array;
		rijndaelManaged.Mode = CipherMode.ECB;
		ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
		byte[] array2 = Convert.FromBase64String(input);
		return UTF8BS(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
	}

	private static byte[] UTF8SB(string s)
	{
		return Encoding.UTF8.GetBytes(s);
	}

	private static string UTF8BS(byte[] b)
	{
		return Encoding.UTF8.GetString(b);
	}
}
