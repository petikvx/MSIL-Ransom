using System.Runtime.CompilerServices;

internal class Class6 : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_62;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint uint_ = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		uint num = class50_0.c271afef.method_0(uint_--).method_2();
		class50_0.eeec9ad0[Class57.aae8806f].method_3(uint_);
		if (num == 1)
		{
			enum1_0 = (Enum1)3;
		}
		else
		{
			enum1_0 = (Enum1)2;
		}
	}
}
