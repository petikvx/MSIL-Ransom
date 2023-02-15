using System;

namespace CommandLine;

public sealed class SetValueExceptionError : NamedError
{
	private readonly Exception exception;

	private readonly object value;

	public Exception Exception => exception;

	public object Value => value;

	internal SetValueExceptionError(NameInfo nameInfo, Exception exception, object value)
		: base(ErrorType.SetValueExceptionError, nameInfo)
	{
		this.exception = exception;
		this.value = value;
	}
}
