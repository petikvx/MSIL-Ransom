using System;

namespace CommandLine;

public sealed class NameInfo : IEquatable<NameInfo>
{
	public static readonly NameInfo EmptyName = new NameInfo(string.Empty, string.Empty);

	private readonly string longName;

	private readonly string shortName;

	public string ShortName => shortName;

	public string LongName => longName;

	public string NameText
	{
		get
		{
			if (ShortName.Length > 0 && LongName.Length > 0)
			{
				return ShortName + ", " + LongName;
			}
			if (ShortName.Length <= 0)
			{
				return LongName;
			}
			return ShortName;
		}
	}

	internal NameInfo(string shortName, string longName)
	{
		if (shortName == null)
		{
			throw new ArgumentNullException("shortName");
		}
		if (longName == null)
		{
			throw new ArgumentNullException("longName");
		}
		this.longName = longName;
		this.shortName = shortName;
	}

	public override bool Equals(object obj)
	{
		if (obj is NameInfo other)
		{
			return Equals(other);
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return new { ShortName, LongName }.GetHashCode();
	}

	public bool Equals(NameInfo other)
	{
		if (other == null)
		{
			return false;
		}
		if (ShortName.Equals(other.ShortName))
		{
			return LongName.Equals(other.LongName);
		}
		return false;
	}
}
