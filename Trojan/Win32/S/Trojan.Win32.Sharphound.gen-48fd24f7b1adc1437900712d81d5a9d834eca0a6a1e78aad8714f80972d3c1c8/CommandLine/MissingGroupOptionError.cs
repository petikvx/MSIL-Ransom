using System.Collections.Generic;

namespace CommandLine;

public sealed class MissingGroupOptionError : Error
{
	public const string ErrorMessage = "At least one option in a group must have value.";

	private readonly string group;

	private readonly IEnumerable<NameInfo> names;

	public string Group => group;

	public IEnumerable<NameInfo> Names => names;

	internal MissingGroupOptionError(string group, IEnumerable<NameInfo> names)
		: base(ErrorType.MissingGroupOptionError)
	{
		this.group = group;
		this.names = names;
	}
}
