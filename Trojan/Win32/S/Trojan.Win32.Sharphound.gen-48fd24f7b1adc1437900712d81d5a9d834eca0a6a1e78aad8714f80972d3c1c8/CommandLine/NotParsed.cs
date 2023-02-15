using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandLine;

public sealed class NotParsed<T> : ParserResult<T>, IEquatable<NotParsed<T>>
{
	private readonly IEnumerable<Error> errors;

	public IEnumerable<Error> Errors => errors;

	internal NotParsed(TypeInfo typeInfo, IEnumerable<Error> errors)
		: base(ParserResultType.NotParsed, typeInfo)
	{
		this.errors = errors;
	}

	public override bool Equals(object obj)
	{
		if (obj is NotParsed<T> other)
		{
			return Equals(other);
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return new { base.Tag, Errors }.GetHashCode();
	}

	public bool Equals(NotParsed<T> other)
	{
		if (other == null)
		{
			return false;
		}
		if (base.Tag.Equals(other.Tag))
		{
			return Enumerable.SequenceEqual(Errors, other.Errors);
		}
		return false;
	}
}
