using System.Runtime.CompilerServices;

internal class Class35 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_14;
	}

	public unsafe void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint uint_ = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(uint_);
		Struct2 struct2_;
		if (@struct.method_8() is c658c1b4)
		{
			struct2_ = ((c658c1b4)@struct.method_8()).imethod_0(class50_0, (Enum2)1);
		}
		else
		{
			ushort* ptr = (ushort*)@struct.method_0();
			Struct2 struct2 = default(Struct2);
			struct2.e7c8f952(*ptr);
			struct2_ = struct2;
		}
		class50_0.c271afef.method_1(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}