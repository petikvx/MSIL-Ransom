namespace CommandLine;

public sealed class InvalidAttributeConfigurationError : Error
{
	public const string ErrorMessage = "Check if Option or Value attribute values are set properly for the given type.";

	internal InvalidAttributeConfigurationError()
		: base(ErrorType.InvalidAttributeConfigurationError, stopsProcessing: true)
	{
	}
}
