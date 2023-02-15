using System.Runtime.CompilerServices;

internal class a4765e99 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_26;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint uint_ = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 struct2_ = class50_0.c271afef.method_0(uint_);
		if ((struct2_.method_4() & 0x8000u) != 0)
		{
			struct2_.method_3(struct2_.method_4() | 0xFFFF0000u);
		}
		class50_0.c271afef.method_1(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
