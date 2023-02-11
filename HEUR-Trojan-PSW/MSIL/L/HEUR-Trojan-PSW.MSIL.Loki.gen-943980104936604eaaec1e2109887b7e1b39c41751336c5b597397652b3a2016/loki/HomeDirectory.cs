using System.IO;

namespace loki;

public class HomeDirectory
{
	public static void Create(string HomeDir, bool Recursive)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(HomeDir);
		if (directoryInfo.Exists)
		{
			FileInfo[] files = directoryInfo.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				fileInfo.Delete();
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			foreach (DirectoryInfo directoryInfo2 in directories)
			{
				directoryInfo2.Delete(Recursive);
			}
			directoryInfo.Attributes |= FileAttributes.Hidden;
		}
		else
		{
			directoryInfo.Create();
			directoryInfo.Refresh();
			directoryInfo.Attributes |= FileAttributes.Hidden;
		}
	}
}
