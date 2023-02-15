using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib;

[Serializable]
public class UnexpectedEndOfStreamException : StreamDecodingException
{
	private const string GenericMessage = "Input stream ended unexpectedly";

	public UnexpectedEndOfStreamException()
		: base("Input stream ended unexpectedly")
	{
	}

	public UnexpectedEndOfStreamException(string message)
		: base(message)
	{
	}

	public UnexpectedEndOfStreamException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected UnexpectedEndOfStreamException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
