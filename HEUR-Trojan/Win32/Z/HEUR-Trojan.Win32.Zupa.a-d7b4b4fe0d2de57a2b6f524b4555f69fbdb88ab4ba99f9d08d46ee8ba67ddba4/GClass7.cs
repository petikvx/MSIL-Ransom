public sealed class GClass7
{
	public int int_0;

	public int int_1;

	public GClass7()
	{
		int_0 = 0;
		int_1 = 0;
	}

	public GClass7(int int_2, int int_3)
	{
		int_0 = int_2;
		int_1 = int_3;
	}

	public GClass7(GClass7 gclass7_0)
	{
		int_0 = gclass7_0.int_0;
		int_1 = gclass7_0.int_1;
	}

	public override int GetHashCode()
	{
		return int_0 ^ int_1;
	}

	public override bool Equals(object obj)
	{
		GClass7 gClass = (GClass7)obj;
		if ((object)gClass == null)
		{
			return false;
		}
		if (int_0 == gClass.int_0)
		{
			return int_1 == gClass.int_1;
		}
		return false;
	}

	public bool method_0(GClass7 gclass7_0)
	{
		if ((object)gclass7_0 == null)
		{
			return false;
		}
		if (int_0 == gclass7_0.int_0)
		{
			return int_1 == gclass7_0.int_1;
		}
		return false;
	}

	public static bool operator ==(GClass7 gclass7_0, GClass7 gclass7_1)
	{
		if ((object)gclass7_0 == gclass7_1)
		{
			return true;
		}
		if ((object)gclass7_0 == null)
		{
			return false;
		}
		if ((object)gclass7_1 == null)
		{
			return false;
		}
		if (gclass7_0.int_0 == gclass7_1.int_0)
		{
			return gclass7_0.int_1 == gclass7_1.int_1;
		}
		return false;
	}

	public static bool operator !=(GClass7 gclass7_0, GClass7 gclass7_1)
	{
		return !(gclass7_0 == gclass7_1);
	}

	public GClass7 method_1(int int_2, int int_3)
	{
		int_0 = int_2;
		int_1 = int_3;
		return this;
	}
}
