using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.GZip;

public static class GZip
{
	public static void Decompress(Stream inStream, Stream outStream, bool isStreamOwner)
	{
		if (inStream == null)
		{
			throw new ArgumentNullException("inStream", "Input stream is null");
		}
		if (outStream == null)
		{
			throw new ArgumentNullException("outStream", "Output stream is null");
		}
		try
		{
			using GZipInputStream gZipInputStream = new GZipInputStream(inStream);
			gZipInputStream.IsStreamOwner = isStreamOwner;
			StreamUtils.Copy(gZipInputStream, outStream, new byte[4096]);
		}
		finally
		{
			if (isStreamOwner)
			{
				outStream.Dispose();
			}
		}
	}

	public static void Compress(Stream inStream, Stream outStream, bool isStreamOwner, int bufferSize = 512, int level = 6)
	{
		if (inStream == null)
		{
			throw new ArgumentNullException("inStream", "Input stream is null");
		}
		if (outStream == null)
		{
			throw new ArgumentNullException("outStream", "Output stream is null");
		}
		if (bufferSize < 512)
		{
			throw new ArgumentOutOfRangeException("bufferSize", "Deflate buffer size must be >= 512");
		}
		if (level >= 0 && level <= 9)
		{
			try
			{
				using GZipOutputStream gZipOutputStream = new GZipOutputStream(outStream, bufferSize);
				gZipOutputStream.SetLevel(level);
				gZipOutputStream.IsStreamOwner = isStreamOwner;
				StreamUtils.Copy(inStream, gZipOutputStream, new byte[bufferSize]);
				return;
			}
			finally
			{
				if (isStreamOwner)
				{
					inStream.Dispose();
				}
			}
		}
		throw new ArgumentOutOfRangeException("level", "Compression level must be 0-9");
	}
}
