using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.BZip2;

public static class BZip2
{
	public static void Decompress(Stream inStream, Stream outStream, bool isStreamOwner)
	{
		if (inStream != null && outStream != null)
		{
			try
			{
				using BZip2InputStream bZip2InputStream = new BZip2InputStream(inStream);
				bZip2InputStream.IsStreamOwner = isStreamOwner;
				StreamUtils.Copy(bZip2InputStream, outStream, new byte[4096]);
				return;
			}
			finally
			{
				if (isStreamOwner)
				{
					outStream.Dispose();
				}
			}
		}
		throw new Exception("Null Stream");
	}

	public static void Compress(Stream inStream, Stream outStream, bool isStreamOwner, int level)
	{
		if (inStream != null && outStream != null)
		{
			try
			{
				using BZip2OutputStream bZip2OutputStream = new BZip2OutputStream(outStream, level);
				bZip2OutputStream.IsStreamOwner = isStreamOwner;
				StreamUtils.Copy(inStream, bZip2OutputStream, new byte[4096]);
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
		throw new Exception("Null Stream");
	}
}
