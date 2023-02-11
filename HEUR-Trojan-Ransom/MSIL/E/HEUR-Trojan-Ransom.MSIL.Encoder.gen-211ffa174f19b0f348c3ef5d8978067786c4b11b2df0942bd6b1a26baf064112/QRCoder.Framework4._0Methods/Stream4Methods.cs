using System.IO;

namespace QRCoder.Framework4._0Methods;

internal class Stream4Methods
{
	public static void CopyTo(Stream input, Stream output)
	{
		byte[] array = new byte[16384];
		int count;
		while ((count = input.Read(array, 0, array.Length)) > 0)
		{
			output.Write(array, 0, count);
		}
	}
}
