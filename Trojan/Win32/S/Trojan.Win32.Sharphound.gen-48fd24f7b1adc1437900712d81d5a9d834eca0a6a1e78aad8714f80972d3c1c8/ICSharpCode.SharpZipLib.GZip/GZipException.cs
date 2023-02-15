using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.GZip;

[Serializable]
public class GZipException : SharpZipBaseException
{
	public GZipException()
	{
	}

	public GZipException(string message)
		: base(message)
	{
	}

	public GZipException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected GZipException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
