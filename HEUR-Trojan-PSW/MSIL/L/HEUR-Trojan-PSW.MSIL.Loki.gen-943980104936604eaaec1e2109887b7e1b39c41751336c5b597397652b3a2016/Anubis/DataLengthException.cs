using System;

namespace Anubis;

public class DataLengthException : CryptoException
{
	public DataLengthException()
	{
	}

	public DataLengthException(string message)
		: base(message)
	{
	}

	public DataLengthException(string message, Exception exception)
		: base(message, exception)
	{
	}
}
