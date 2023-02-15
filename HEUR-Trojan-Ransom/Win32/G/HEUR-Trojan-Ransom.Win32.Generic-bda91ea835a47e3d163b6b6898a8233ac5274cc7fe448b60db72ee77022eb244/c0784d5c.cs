using System;
using System.Runtime.CompilerServices;

internal class c0784d5c : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_59;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		if (class50_0.c271afef.method_0(num--).method_2() != 0)
		{
			throw new OverflowException();
		}
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		enum1_0 = (Enum1)0;
	}
}
