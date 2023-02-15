using System.Runtime.CompilerServices;

internal class Class42 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_37;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num);
		Struct2 struct2 = class50_0.c271afef.method_0(num - 1);
		num -= 2;
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		if (struct2.method_0() > 0L)
		{
			class50_0.eeec9ad0[Class57.byte_6].method_1(@struct.method_0());
		}
		enum1_0 = (Enum1)0;
	}
}
