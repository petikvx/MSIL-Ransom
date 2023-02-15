using System.Runtime.CompilerServices;

internal class ecebfb07 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_52;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint uint_ = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 struct2_ = class50_0.c271afef.method_0(uint_);
		byte b273411 = (byte)(class50_0.eeec9ad0[Class57.ba3cd679].method_5() & ~Class57.byte_8);
		if (!c2748bf3.bool_0 && struct2_.method_0() >> 32 > 0L)
		{
			b273411 = (byte)(b273411 | Class57.byte_8);
		}
		class50_0.eeec9ad0[Class57.ba3cd679].method_6(b273411);
		class50_0.c271afef.method_1(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
