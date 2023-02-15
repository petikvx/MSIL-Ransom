namespace CommandLine;

public sealed class NoVerbSelectedError : Error
{
	internal NoVerbSelectedError()
		: base(ErrorType.NoVerbSelectedError)
	{
	}
}
