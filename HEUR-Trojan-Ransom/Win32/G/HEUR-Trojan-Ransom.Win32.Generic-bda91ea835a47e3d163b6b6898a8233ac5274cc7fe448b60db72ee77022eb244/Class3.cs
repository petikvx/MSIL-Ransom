using System.Runtime.CompilerServices;

internal class Class3 : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.a63d6cfa;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 struct2_ = class50_0.c271afef.method_0(num--);
		Struct2 @struct = class50_0.c271afef.method_0(num--);
		Struct2 struct2 = class50_0.c271afef.method_0(num);
		struct2_.method_1(((long)struct2_.method_0() > (long)@struct.method_0() || (long)struct2_.method_0() < (long)struct2.method_0()) ? 1u : 0u);
		class50_0.c271afef.method_1(num, struct2_);
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		enum1_0 = (Enum1)0;
	}
}
