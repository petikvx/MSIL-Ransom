namespace CommandLine;

public sealed class MutuallyExclusiveSetError : NamedError
{
	private readonly string setName;

	public string SetName => setName;

	internal MutuallyExclusiveSetError(NameInfo nameInfo, string setName)
		: base(ErrorType.MutuallyExclusiveSetError, nameInfo)
	{
		this.setName = setName;
	}
}
