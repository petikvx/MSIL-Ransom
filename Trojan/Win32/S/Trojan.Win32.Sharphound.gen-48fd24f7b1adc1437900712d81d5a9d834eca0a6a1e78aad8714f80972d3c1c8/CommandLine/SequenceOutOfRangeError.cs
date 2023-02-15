namespace CommandLine;

public sealed class SequenceOutOfRangeError : NamedError
{
	internal SequenceOutOfRangeError(NameInfo nameInfo)
		: base(ErrorType.SequenceOutOfRangeError, nameInfo)
	{
	}
}
