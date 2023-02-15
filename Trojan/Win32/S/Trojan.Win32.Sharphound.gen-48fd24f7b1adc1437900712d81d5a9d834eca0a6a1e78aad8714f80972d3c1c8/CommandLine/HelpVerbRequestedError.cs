using System;

namespace CommandLine;

public sealed class HelpVerbRequestedError : Error
{
	private readonly string verb;

	private readonly Type type;

	private readonly bool matched;

	public string Verb => verb;

	public Type Type => type;

	public bool Matched => matched;

	internal HelpVerbRequestedError(string verb, Type type, bool matched)
		: base(ErrorType.HelpVerbRequestedError, stopsProcessing: true)
	{
		this.verb = verb;
		this.type = type;
		this.matched = matched;
	}
}
