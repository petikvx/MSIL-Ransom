using System;

namespace SharpHound3.JSON;

internal class SPNTarget : IEquatable<SPNTarget>
{
	public string ComputerSid { get; set; }

	public int Port { get; set; }

	public string Service { get; set; }

	public bool Equals(SPNTarget other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		return ComputerSid == other.ComputerSid && Port == other.Port && Service == other.Service;
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
		return Equals((SPNTarget)obj);
	}

	public override int GetHashCode()
	{
		int num = ((ComputerSid != null) ? ComputerSid.GetHashCode() : 0);
		num = (num * 397) ^ Port;
		return (num * 397) ^ ((Service != null) ? Service.GetHashCode() : 0);
	}
}
