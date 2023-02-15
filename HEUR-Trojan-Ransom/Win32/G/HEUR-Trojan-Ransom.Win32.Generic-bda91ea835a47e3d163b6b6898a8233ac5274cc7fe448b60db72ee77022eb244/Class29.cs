using System.Runtime.CompilerServices;

internal class Class29 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_54;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num);
		class50_0.c271afef.method_2(--num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		Interface0 @interface = f29d4965.smethod_0(@struct.method_5());
		@interface.imethod_0(class50_0, out enum1_0);
	}
}
