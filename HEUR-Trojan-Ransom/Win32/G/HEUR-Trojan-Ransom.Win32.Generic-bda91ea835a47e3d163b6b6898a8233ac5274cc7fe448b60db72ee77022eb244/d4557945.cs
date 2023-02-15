using System.Runtime.CompilerServices;

internal class d4557945 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_22;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		class50_0.c271afef.method_2(++num);
		byte b273411 = class50_0.method_0();
		Struct2 @struct = class50_0.eeec9ad0[b273411];
		d564e35d c271afef = class50_0.c271afef;
		uint uint_ = num;
		Struct2 struct2_ = default(Struct2);
		struct2_.e7c8f952(@struct.method_4());
		c271afef.method_1(uint_, struct2_);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		enum1_0 = (Enum1)0;
	}
}
