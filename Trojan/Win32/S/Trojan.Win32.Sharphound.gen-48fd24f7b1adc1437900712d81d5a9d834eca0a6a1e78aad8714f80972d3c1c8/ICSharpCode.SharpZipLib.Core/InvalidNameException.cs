using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib.Core;

[Serializable]
public class InvalidNameException : SharpZipBaseException
{
	public InvalidNameException()
		: base("An invalid name was specified")
	{
	}

	public InvalidNameException(string message)
		: base(message)
	{
	}

	public InvalidNameException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected InvalidNameException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
