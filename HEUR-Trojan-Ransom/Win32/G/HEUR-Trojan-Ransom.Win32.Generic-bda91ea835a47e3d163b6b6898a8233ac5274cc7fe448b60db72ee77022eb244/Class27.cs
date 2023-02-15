using System;
using System.Runtime.CompilerServices;

internal class Class27 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.b9ecf49;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		ulong num2 = class50_0.c271afef.method_0(num--).method_0();
		int index = class50_0.e98b396e.Count - 1;
		d91f6464 d91f6465 = class50_0.e98b396e[index];
		if (d91f6465.ulong_0 != num2)
		{
			throw new InvalidProgramException();
		}
		class50_0.e98b396e.RemoveAt(index);
		if (d91f6465.byte_0 == Class57.byte_70)
		{
			class50_0.c271afef.method_1(++num, class50_0.eeec9ad0[Class57.byte_6]);
			class50_0.eeec9ad0[Class57.e0cb0d84].method_6(0);
			class50_0.eeec9ad0[Class57.byte_6].method_1(d91f6465.ulong_0);
		}
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		enum1_0 = (Enum1)0;
	}
}
