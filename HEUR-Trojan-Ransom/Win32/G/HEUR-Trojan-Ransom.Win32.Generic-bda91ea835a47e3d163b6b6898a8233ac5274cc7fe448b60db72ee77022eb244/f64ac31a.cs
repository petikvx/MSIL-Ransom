using System;
using System.Runtime.CompilerServices;

internal class f64ac31a : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_57;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num--);
		Struct2 struct2_ = class50_0.c271afef.method_0(num);
		bool flag = (@struct.method_2() & 0x80000000u) != 0;
		Type type = (Type)class50_0.class1_0.b7ea69fb().method_3(@struct.method_2() & 0x7FFFFFFFu);
		if (Type.GetTypeCode(type) == TypeCode.String && struct2_.method_8() == null)
		{
			struct2_.e5a3833a(class50_0.class1_0.b7ea69fb().method_4(struct2_.method_2()));
		}
		else if (struct2_.method_8() == null)
		{
			struct2_.e5a3833a(null);
		}
		else if (!type.IsInstanceOfType(struct2_.method_8()))
		{
			struct2_.e5a3833a(null);
			if (flag)
			{
				throw new InvalidCastException();
			}
		}
		class50_0.c271afef.method_1(num, struct2_);
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		enum1_0 = (Enum1)0;
	}
}
