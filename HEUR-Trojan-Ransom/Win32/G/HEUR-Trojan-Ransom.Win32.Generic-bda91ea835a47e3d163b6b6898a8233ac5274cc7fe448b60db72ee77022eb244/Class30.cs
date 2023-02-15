using System.Runtime.CompilerServices;

internal class Class30 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.ad3108b9;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num - 1);
		Struct2 struct2 = class50_0.c271afef.method_0(num);
		num--;
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		byte byte_ = class50_0.eeec9ad0[Class57.ba3cd679].method_5();
		Struct2 struct2_ = default(Struct2);
		if ((byte_ & Class57.byte_11) != 0)
		{
			struct2_.method_3(@struct.method_2() % struct2.method_2());
		}
		else
		{
			struct2_.method_3((uint)((int)@struct.method_2() % (int)struct2.method_2()));
		}
		class50_0.c271afef.method_1(num, struct2_);
		byte byte_2 = (byte)(Class57.byte_9 | Class57.byte_10 | Class57.byte_11);
		Class0.a9be3721(@struct.method_2(), struct2.method_2(), struct2_.method_2(), struct2_.method_2(), ref byte_, byte_2);
		class50_0.eeec9ad0[Class57.ba3cd679].method_6(byte_);
		enum1_0 = (Enum1)0;
	}
}
