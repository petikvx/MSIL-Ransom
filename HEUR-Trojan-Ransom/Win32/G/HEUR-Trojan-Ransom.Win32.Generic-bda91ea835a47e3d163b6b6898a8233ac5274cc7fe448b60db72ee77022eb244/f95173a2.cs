using System.Runtime.CompilerServices;

internal class f95173a2 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_27;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint uint_ = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 struct2_ = class50_0.c271afef.method_0(uint_);
		if ((struct2_.method_2() & 0x80000000u) != 0)
		{
			struct2_.method_1(0xFFFFFFFF00000000uL | struct2_.method_2());
		}
		class50_0.c271afef.method_1(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
