using System;
using SharpHound3.Enums;

namespace SharpHound3.JSON;

internal class GenericMember : IEquatable<GenericMember>
{
	public string MemberId { get; set; }

	public LdapTypeEnum MemberType { get; set; }

	public override string ToString()
	{
		return $"{MemberId} - {MemberType}";
	}

	public bool Equals(GenericMember other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		return string.Equals(MemberId, other.MemberId) && MemberType == other.MemberType;
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() != GetType())
		{
			return false;
		}
		return Equals((GenericMember)obj);
	}

	public override int GetHashCode()
	{
		return (((MemberId != null) ? MemberId.GetHashCode() : 0) * 397) ^ (int)MemberType;
	}
}
