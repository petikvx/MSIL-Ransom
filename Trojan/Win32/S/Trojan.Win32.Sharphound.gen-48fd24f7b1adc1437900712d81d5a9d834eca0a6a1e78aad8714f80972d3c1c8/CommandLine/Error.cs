using System;

namespace CommandLine;

public abstract class Error : IEquatable<Error>
{
	private readonly ErrorType tag;

	private readonly bool stopsProcessing;

	public ErrorType Tag => tag;

	public bool StopsProcessing => stopsProcessing;

	protected internal Error(ErrorType tag, bool stopsProcessing)
	{
		this.tag = tag;
		this.stopsProcessing = stopsProcessing;
	}

	protected internal Error(ErrorType tag)
		: this(tag, stopsProcessing: false)
	{
	}

	public override bool Equals(object obj)
	{
		if (obj is Error other)
		{
			return Equals(other);
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return new { Tag, StopsProcessing }.GetHashCode();
	}

	public bool Equals(Error other)
	{
		if (other == null)
		{
			return false;
		}
		return Tag.Equals(other.Tag);
	}
}
