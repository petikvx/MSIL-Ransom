using System;
using System.Runtime.CompilerServices;

internal class Class37 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.f3a42fd2;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint uint_ = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(uint_);
		if (!(@struct.method_8() is c658c1b4))
		{
			throw new ExecutionEngineException();
		}
		Struct2 struct2_ = ((c658c1b4)@struct.method_8()).imethod_0(class50_0, (Enum2)4);
		class50_0.c271afef.method_1(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
