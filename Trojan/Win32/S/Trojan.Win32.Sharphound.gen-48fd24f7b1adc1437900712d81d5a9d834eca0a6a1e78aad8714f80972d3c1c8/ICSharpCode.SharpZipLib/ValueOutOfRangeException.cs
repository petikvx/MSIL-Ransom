using System;
using System.Runtime.Serialization;

namespace ICSharpCode.SharpZipLib;

[Serializable]
public class ValueOutOfRangeException : StreamDecodingException
{
	public ValueOutOfRangeException(string nameOfValue)
		: base(nameOfValue + " out of range")
	{
	}

	public ValueOutOfRangeException(string nameOfValue, long value, long maxValue, long minValue = 0L)
		: this(nameOfValue, value.ToString(), maxValue.ToString(), minValue.ToString())
	{
	}

	public ValueOutOfRangeException(string nameOfValue, string value, string maxValue, string minValue = "0")
		: base(nameOfValue + " out of range: " + value + ", should be " + minValue + ".." + maxValue)
	{
	}

	private ValueOutOfRangeException()
	{
	}

	private ValueOutOfRangeException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	protected ValueOutOfRangeException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
