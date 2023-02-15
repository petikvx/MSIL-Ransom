using System;

namespace CommandLine;

public abstract class TokenError : Error, IEquatable<TokenError>
{
	private readonly string token;

	public string Token => token;

	protected internal TokenError(ErrorType tag, string token)
		: base(tag)
	{
		if (token == null)
		{
			throw new ArgumentNullException("token");
		}
		this.token = token;
	}

	public override bool Equals(object obj)
	{
		if (obj is TokenError other)
		{
			return Equals(other);
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return new { base.Tag, base.StopsProcessing, Token }.GetHashCode();
	}

	public bool Equals(TokenError other)
	{
		if (other == null)
		{
			return false;
		}
		if (base.Tag.Equals(other.Tag))
		{
			return Token.Equals(other.Token);
		}
		return false;
	}
}
