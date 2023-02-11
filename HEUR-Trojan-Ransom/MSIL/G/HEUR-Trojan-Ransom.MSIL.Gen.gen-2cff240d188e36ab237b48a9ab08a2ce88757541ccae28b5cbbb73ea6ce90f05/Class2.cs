using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class Class2
{
	internal static uint smethod_0(string string_0)
	{
		uint num = default(uint);
		if (string_0 != null)
		{
			num = 2166136261u;
			for (int i = 0; i < Class2.smethod_2(string_0); i++)
			{
				num = (Class2.smethod_1(string_0, i) ^ num) * 16777619;
			}
		}
		return num;
	}

	static char smethod_1(string string_0, int int_0)
	{
		return string_0[int_0];
	}

	static int smethod_2(string string_0)
	{
		return string_0.Length;
	}
}
