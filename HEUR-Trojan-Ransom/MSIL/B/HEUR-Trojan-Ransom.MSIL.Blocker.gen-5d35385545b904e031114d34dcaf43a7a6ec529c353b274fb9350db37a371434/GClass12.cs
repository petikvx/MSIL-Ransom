using System.Collections.Generic;

public class GClass12
{
	private enum Enum0
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	private const int int_0 = 8;

	private const int int_1 = 24;

	private const uint uint_0 = 3u;

	private readonly int int_2;

	private readonly List<uint> list_0;

	public GClass12()
	{
		//Discarded unreachable code: IL_0007, IL_000e
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected native int or pointer, but got O
		checked
		{
			_ = (ushort)(uint)/*Error near IL_0001: Stack underflow*/;
			/*Error near IL_0002: Invalid metadata token*/;
		}
	}

	public override extern string ToString();
}
