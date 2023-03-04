using System;
using System.IO;

namespace FolderToGacIfDifferent;

internal class Comparisons
{
	public static bool FilesContentsAreEqual(FileInfo fileInfo1, FileInfo fileInfo2)
	{
		if (fileInfo1.Length != fileInfo2.Length)
		{
			return false;
		}
		using FileStream stream = fileInfo1.OpenRead();
		using FileStream stream2 = fileInfo2.OpenRead();
		return StreamsContentsAreEqual(stream, stream2);
	}

	private static bool StreamsContentsAreEqual(Stream stream1, Stream stream2)
	{
		byte[] array = new byte[4096];
		byte[] array2 = new byte[4096];
		while (true)
		{
			int num = stream1.Read(array, 0, 4096);
			int num2 = stream2.Read(array2, 0, 4096);
			if (num == num2)
			{
				if (num == 0)
				{
					break;
				}
				int num3 = (int)Math.Ceiling((double)num / 8.0);
				for (int i = 0; i < num3; i++)
				{
					if (BitConverter.ToInt64(array, i * 8) != BitConverter.ToInt64(array2, i * 8))
					{
						return false;
					}
				}
				continue;
			}
			return false;
		}
		return true;
	}
}
