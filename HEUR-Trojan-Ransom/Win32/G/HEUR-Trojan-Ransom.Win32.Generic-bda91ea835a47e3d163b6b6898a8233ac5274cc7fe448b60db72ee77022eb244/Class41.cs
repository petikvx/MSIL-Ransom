using System;
using System.Runtime.CompilerServices;

internal class Class41 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_16;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num--);
		Struct2 struct2_ = class50_0.c271afef.method_0(num--);
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		if (!(@struct.method_8() is c658c1b4))
		{
			throw new ExecutionEngineException();
		}
		((c658c1b4)@struct.method_8()).facb018d(class50_0, struct2_, (Enum2)4);
		enum1_0 = (Enum1)0;
	}
}
