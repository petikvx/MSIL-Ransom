using System.Runtime.CompilerServices;

internal class Class12 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_40;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num - 1);
		Struct2 struct2 = class50_0.c271afef.method_0(num);
		num--;
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		Struct2 struct2_ = default(Struct2);
		if (@struct.method_8() is c658c1b4)
		{
			struct2_.e5a3833a(((c658c1b4)@struct.method_8()).imethod_2(struct2.method_0()));
		}
		else if (struct2.method_8() is c658c1b4)
		{
			struct2_.e5a3833a(((c658c1b4)struct2.method_8()).imethod_2(@struct.method_0()));
		}
		else
		{
			struct2_.method_1(struct2.method_0() + @struct.method_0());
		}
		class50_0.c271afef.method_1(num, struct2_);
		byte byte_ = (byte)(Class57.byte_9 | Class57.byte_10 | Class57.byte_8 | Class57.dd38edf7);
		byte byte_2 = class50_0.eeec9ad0[Class57.ba3cd679].method_5();
		Class0.a9be3721(@struct.method_0(), struct2.method_0(), struct2_.method_0(), struct2_.method_0(), ref byte_2, byte_);
		class50_0.eeec9ad0[Class57.ba3cd679].method_6(byte_2);
		enum1_0 = (Enum1)0;
	}
}
