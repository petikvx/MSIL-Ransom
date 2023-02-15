namespace CommandLine;

public sealed class BadFormatConversionError : NamedError
{
	internal BadFormatConversionError(NameInfo nameInfo)
		: base(ErrorType.BadFormatConversionError, nameInfo)
	{
	}
}
