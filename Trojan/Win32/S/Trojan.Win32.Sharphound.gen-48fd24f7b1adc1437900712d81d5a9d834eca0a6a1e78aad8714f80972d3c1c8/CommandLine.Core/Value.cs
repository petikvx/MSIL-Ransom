using System;

namespace CommandLine.Core;

internal class Value : Token, IEquatable<Value>
{
	private readonly bool explicitlyAssigned;

	public bool ExplicitlyAssigned => explicitlyAssigned;

	public Value(string text)
		: this(text, explicitlyAssigned: false)
	{
	}

	public Value(string text, bool explicitlyAssigned)
		: base(TokenType.Value, text)
	{
		this.explicitlyAssigned = explicitlyAssigned;
	}

	public override bool Equals(object obj)
	{
		if (obj is Value other)
		{
			return Equals(other);
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return new { base.Tag, base.Text }.GetHashCode();
	}

	public bool Equals(Value other)
	{
		if (other == null)
		{
			return false;
		}
		if (base.Tag.Equals(other.Tag))
		{
			return base.Text.Equals(other.Text);
		}
		return false;
	}
}
