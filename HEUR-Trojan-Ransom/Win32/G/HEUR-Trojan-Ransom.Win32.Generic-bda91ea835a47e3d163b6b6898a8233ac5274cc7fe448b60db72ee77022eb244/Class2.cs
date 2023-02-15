using System;
using System.Runtime.CompilerServices;

internal class Class2 : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_58;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num--);
		byte b273411 = class50_0.eeec9ad0[Class57.ba3cd679].method_5();
		if ((b273411 & Class57.byte_11) != 0)
		{
			float f1975885 = @struct.b61307cd();
			if (float.IsNaN(f1975885) || float.IsInfinity(f1975885))
			{
				throw new ArithmeticException();
			}
		}
		else
		{
			double d4557946 = @struct.b9e547a3();
			if (double.IsNaN(d4557946) || double.IsInfinity(d4557946))
			{
				throw new ArithmeticException();
			}
		}
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		enum1_0 = (Enum1)0;
	}
}
