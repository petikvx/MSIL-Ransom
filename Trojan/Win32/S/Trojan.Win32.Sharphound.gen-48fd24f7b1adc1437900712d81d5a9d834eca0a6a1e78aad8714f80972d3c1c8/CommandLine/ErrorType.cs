namespace CommandLine;

public enum ErrorType
{
	BadFormatTokenError,
	MissingValueOptionError,
	UnknownOptionError,
	MissingRequiredOptionError,
	MutuallyExclusiveSetError,
	BadFormatConversionError,
	SequenceOutOfRangeError,
	RepeatedOptionError,
	NoVerbSelectedError,
	BadVerbSelectedError,
	HelpRequestedError,
	HelpVerbRequestedError,
	VersionRequestedError,
	SetValueExceptionError,
	InvalidAttributeConfigurationError,
	MissingGroupOptionError
}
