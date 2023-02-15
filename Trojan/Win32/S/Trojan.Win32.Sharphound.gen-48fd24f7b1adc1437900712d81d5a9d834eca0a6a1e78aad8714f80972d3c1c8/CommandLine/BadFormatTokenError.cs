namespace CommandLine;

public sealed class BadFormatTokenError : TokenError
{
	internal BadFormatTokenError(string token)
		: base(ErrorType.BadFormatTokenError, token)
	{
	}
}
