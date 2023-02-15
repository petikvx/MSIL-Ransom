namespace CommandLine;

public sealed class UnknownOptionError : TokenError
{
	internal UnknownOptionError(string token)
		: base(ErrorType.UnknownOptionError, token)
	{
	}
}
