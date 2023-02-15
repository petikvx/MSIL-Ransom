using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class a8e4b906 : c658c1b4
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private uint eadce367;

	public a8e4b906(uint uint_0)
	{
		fc1c7628(uint_0);
	}

	[SpecialName]
	public uint method_0()
	{
		return eadce367;
	}

	[SpecialName]
	public void fc1c7628(uint uint_0)
	{
		eadce367 = uint_0;
	}

	public Struct2 imethod_0(Class50 class50_0, Enum2 enum2_0)
	{
		Struct2 result = class50_0.c271afef.method_0(method_0());
		switch (enum2_0)
		{
		case (Enum2)0:
			result.method_1(result.method_5());
			break;
		case (Enum2)1:
			result.method_1(result.method_4());
			break;
		case (Enum2)2:
			result.method_1(result.method_2());
			break;
		default:
			if (result.method_8() is Interface2)
			{
				result.e5a3833a(((Interface2)result.method_8()).a2e6a035());
			}
			break;
		}
		return result;
	}

	public void facb018d(Class50 class50_0, Struct2 struct2_0, Enum2 enum2_0)
	{
		switch (enum2_0)
		{
		case (Enum2)0:
			struct2_0.method_1(struct2_0.method_5());
			break;
		case (Enum2)1:
			struct2_0.method_1(struct2_0.method_4());
			break;
		case (Enum2)2:
			struct2_0.method_1(struct2_0.method_2());
			break;
		}
		class50_0.c271afef.method_1(method_0(), struct2_0);
	}

	public c658c1b4 imethod_1(uint uint_0)
	{
		return new a8e4b906(method_0() + uint_0);
	}

	public c658c1b4 imethod_2(ulong ulong_0)
	{
		return new a8e4b906(method_0() + (uint)(int)ulong_0);
	}

	public void cdbadb47(Class50 class50_0, Struct1 struct1_0, Type type_0)
	{
		class50_0.c271afef.cdbadb47(method_0(), struct1_0, type_0);
	}
}
