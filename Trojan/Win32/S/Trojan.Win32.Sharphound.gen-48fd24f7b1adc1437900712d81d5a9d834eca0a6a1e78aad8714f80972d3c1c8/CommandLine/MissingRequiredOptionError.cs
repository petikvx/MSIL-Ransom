namespace CommandLine;

public sealed class MissingRequiredOptionError : NamedError
{
	internal MissingRequiredOptionError(NameInfo nameInfo)
		: base(ErrorType.MissingRequiredOptionError, nameInfo)
	{
	}
}
