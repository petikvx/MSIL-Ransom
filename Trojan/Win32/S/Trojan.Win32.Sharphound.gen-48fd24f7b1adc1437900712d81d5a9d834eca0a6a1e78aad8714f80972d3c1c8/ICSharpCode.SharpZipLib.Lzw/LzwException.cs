using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Lzw;

[Serializable]
public class LzwException : SharpZipBaseException
{
	public LzwException()
	{
	}

	public LzwException(string message)
		: base(message)
	{
	}

	public LzwException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected LzwException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
