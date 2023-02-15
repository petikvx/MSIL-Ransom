using System;

namespace SharpHound3.JSON;

internal class Session : IEquatable<Session>
{
	private string _computerId;

	private string _userId;

	public string UserId
	{
		get
		{
			return _userId;
		}
		set
		{
			_userId = value.ToUpper();
		}
	}

	public string ComputerId
	{
		get
		{
			return _computerId;
		}
		set
		{
			_computerId = value.ToUpper();
		}
	}

	public bool Equals(Session other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		return string.Equals(_computerId, other._computerId) && string.Equals(_userId, other._userId);
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
		return Equals((Session)obj);
	}

	public override int GetHashCode()
	{
		return (((_computerId != null) ? _computerId.GetHashCode() : 0) * 397) ^ ((_userId != null) ? _userId.GetHashCode() : 0);
	}
}
