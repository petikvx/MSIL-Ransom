using System.Runtime.CompilerServices;

internal class f0e8d338 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_38;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num);
		class50_0.c271afef.method_2(--num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		class50_0.eeec9ad0[Class57.byte_6].method_1(@struct.method_0());
		enum1_0 = (Enum1)0;
	}
}
