using System.Runtime.CompilerServices;

internal class f29bd9fd : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.e629d44d;
	}

	public unsafe void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num--);
		Struct2 struct2_ = class50_0.c271afef.method_0(num--);
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		if (@struct.method_8() is c658c1b4)
		{
			((c658c1b4)@struct.method_8()).facb018d(class50_0, struct2_, c2748bf3.bool_0 ? ((Enum2)3) : ((Enum2)2));
		}
		else if (c2748bf3.bool_0)
		{
			ulong* ptr = (ulong*)@struct.method_0();
			*ptr = struct2_.method_0();
		}
		else
		{
			uint* ptr2 = (uint*)@struct.method_0();
			*ptr2 = struct2_.method_2();
		}
		enum1_0 = (Enum1)0;
	}
}
