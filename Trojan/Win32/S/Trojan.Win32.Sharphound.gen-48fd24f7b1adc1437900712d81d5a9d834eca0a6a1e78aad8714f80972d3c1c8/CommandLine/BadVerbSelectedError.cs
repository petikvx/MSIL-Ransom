namespace CommandLine;

public sealed class BadVerbSelectedError : TokenError
{
	internal BadVerbSelectedError(string token)
		: base(ErrorType.BadVerbSelectedError, token)
	{
	}
}
