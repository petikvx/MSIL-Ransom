namespace CommandLine;

public sealed class HelpRequestedError : Error
{
	internal HelpRequestedError()
		: base(ErrorType.HelpRequestedError, stopsProcessing: true)
	{
	}
}
