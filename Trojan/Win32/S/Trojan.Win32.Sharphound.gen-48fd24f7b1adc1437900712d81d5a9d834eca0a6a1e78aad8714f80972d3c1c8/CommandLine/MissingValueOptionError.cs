namespace CommandLine;

public sealed class MissingValueOptionError : NamedError
{
	internal MissingValueOptionError(NameInfo nameInfo)
		: base(ErrorType.MissingValueOptionError, nameInfo)
	{
	}
}
