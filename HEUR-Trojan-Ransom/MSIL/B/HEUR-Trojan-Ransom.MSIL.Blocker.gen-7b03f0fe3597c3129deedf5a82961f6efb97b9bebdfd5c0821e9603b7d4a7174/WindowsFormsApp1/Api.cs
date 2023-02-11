using System.IO;
using System.IO.Compression;

namespace WindowsFormsApp1;

internal class Api
{
	internal byte[] GzipStream(byte[] data)
	{
		using MemoryStream stream = new MemoryStream(data);
		using MemoryStream memoryStream = new MemoryStream();
		using BufferedStream bufferedStream = new BufferedStream(new GZipStream(stream, CompressionMode.Decompress));
		bufferedStream.CopyTo(memoryStream);
		return memoryStream.ToArray();
	}
}
