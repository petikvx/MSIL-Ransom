namespace CommandLine;

public sealed class RepeatedOptionError : NamedError
{
	internal RepeatedOptionError(NameInfo nameInfo)
		: base(ErrorType.RepeatedOptionError, nameInfo)
	{
	}
}
