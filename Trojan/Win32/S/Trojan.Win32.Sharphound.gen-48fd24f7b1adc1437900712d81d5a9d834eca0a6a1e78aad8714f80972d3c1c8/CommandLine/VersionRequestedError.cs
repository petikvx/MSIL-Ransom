namespace CommandLine;

public sealed class VersionRequestedError : Error
{
	internal VersionRequestedError()
		: base(ErrorType.VersionRequestedError, stopsProcessing: true)
	{
	}
}
