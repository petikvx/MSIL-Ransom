using System;

namespace CommandLine;

public sealed class Parsed<T> : ParserResult<T>, IEquatable<Parsed<T>>
{
	private readonly T value;

	public T Value => value;

	internal Parsed(T value, TypeInfo typeInfo)
		: base(ParserResultType.Parsed, typeInfo)
	{
		this.value = value;
	}

	internal Parsed(T value)
		: this(value, TypeInfo.Create(value.GetType()))
	{
	}

	public override bool Equals(object obj)
	{
		if (obj is Parsed<T> other)
		{
			return Equals(other);
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return new { base.Tag, Value }.GetHashCode();
	}

	public bool Equals(Parsed<T> other)
	{
		if (other == null)
		{
			return false;
		}
		if (base.Tag.Equals(other.Tag))
		{
			return Value.Equals(other.Value);
		}
		return false;
	}
}
