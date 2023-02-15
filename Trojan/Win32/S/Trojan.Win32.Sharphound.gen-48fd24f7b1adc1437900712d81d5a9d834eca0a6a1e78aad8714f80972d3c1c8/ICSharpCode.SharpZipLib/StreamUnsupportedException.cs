using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib;

[Serializable]
public class StreamUnsupportedException : StreamDecodingException
{
	private const string GenericMessage = "Input stream is in a unsupported format";

	public StreamUnsupportedException()
		: base("Input stream is in a unsupported format")
	{
	}

	public StreamUnsupportedException(string message)
		: base(message)
	{
	}

	public StreamUnsupportedException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected StreamUnsupportedException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
