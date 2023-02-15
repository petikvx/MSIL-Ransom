using System;

namespace SharpHound3;

internal class UserDomainKey : IEquatable<UserDomainKey>
{
	private string _accountName;

	private string _accountDomain;

	public string AccountName
	{
		get
		{
			return _accountName;
		}
		set
		{
			_accountName = value.ToUpper();
		}
	}

	public string AccountDomain
	{
		get
		{
			return _accountDomain;
		}
		set
		{
			_accountDomain = value.ToUpper();
		}
	}

	public bool Equals(UserDomainKey other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		return _accountName == other._accountName && _accountDomain == other._accountDomain;
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
		return Equals((UserDomainKey)obj);
	}

	public override int GetHashCode()
	{
		return (((_accountName != null) ? _accountName.GetHashCode() : 0) * 397) ^ ((_accountDomain != null) ? _accountDomain.GetHashCode() : 0);
	}

	public override string ToString()
	{
		return AccountDomain + "\\" + AccountName;
	}
}
