using System;

namespace CommandLine.Core;

internal class Name : Token, IEquatable<Name>
{
	public Name(string text)
		: base(TokenType.Name, text)
	{
	}

	public override bool Equals(object obj)
	{
		if (obj is Name other)
		{
			return Equals(other);
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return new { base.Tag, base.Text }.GetHashCode();
	}

	public bool Equals(Name other)
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
