using System.Runtime.CompilerServices;

internal class Class21 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.fe3a48af;
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
		struct2_.d38706c8(@struct.b61307cd() / struct2.b61307cd());
		class50_0.c271afef.method_1(num, struct2_);
		byte b273411 = (byte)(Class57.byte_9 | Class57.byte_10);
		byte b273412 = (byte)(class50_0.eeec9ad0[Class57.ba3cd679].method_5() & ~b273411);
		if (struct2_.b61307cd() == 0f)
		{
			b273412 = (byte)(b273412 | Class57.byte_9);
		}
		else if (struct2_.b61307cd() < 0f)
		{
			b273412 = (byte)(b273412 | Class57.byte_10);
		}
		class50_0.eeec9ad0[Class57.ba3cd679].method_6(b273412);
		enum1_0 = (Enum1)0;
	}
}