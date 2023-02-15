using System;

namespace CommandLine;

public abstract class NamedError : Error, IEquatable<NamedError>
{
	private readonly NameInfo nameInfo;

	public NameInfo NameInfo => nameInfo;

	protected internal NamedError(ErrorType tag, NameInfo nameInfo)
		: base(tag)
	{
		this.nameInfo = nameInfo;
	}

	public override bool Equals(object obj)
	{
		if (obj is NamedError other)
		{
			return Equals(other);
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return new { base.Tag, base.StopsProcessing, NameInfo }.GetHashCode();
	}

	public bool Equals(NamedError other)
	{
		if (other == null)
		{
			return false;
		}
		if (base.Tag.Equals(other.Tag))
		{
			return NameInfo.Equals(other.NameInfo);
		}
		return false;
	}
}
