using System;
using System.Runtime.CompilerServices;

public sealed class GClass5
{
	private DateTime dateTime_0;

	private int int_0;

	public DateTime ExpireDate
	{
		[CompilerGenerated]
		get
		{
			return dateTime_0;
		}
		[CompilerGenerated]
		set
		{
			dateTime_0 = value;
		}
	}

	public int Flags
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public string License
	{
		get
		{
			if (Flags.Equals(4))
			{
				return Class60.smethod_0(-2050226499);
			}
			if (Flags.Equals(2))
			{
				return Class60.smethod_0(-2050226536);
			}
			if (!Flags.Equals(1) && !Flags.Equals(3))
			{
				return Class60.smethod_0(-2050226570);
			}
			return Class60.smethod_0(-2050226585);
		}
	}
}
