using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Zip;

[Serializable]
public class ZipException : SharpZipBaseException
{
	public ZipException()
	{
	}

	public ZipException(string message)
		: base(message)
	{
	}

	public ZipException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected ZipException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
