using System;
using System.Runtime.CompilerServices;

internal class Class9 : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_63;
	}

	public unsafe void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num--);
		Struct2 struct2 = class50_0.c271afef.method_0(num);
		bool flag = (@struct.method_2() & 0x80000000u) != 0;
		Type type = (Type)class50_0.class1_0.b7ea69fb().method_3(@struct.method_2() & 0x7FFFFFFFu);
		if (flag)
		{
			TypedReference typedReference_ = default(TypedReference);
			Class54.smethod_1(struct2.method_8(), Struct1.b4634c31(&typedReference_));
			new Class48(typedReference_);
			struct2 = Struct2.dcafb951(struct2.method_8(), type);
			class50_0.c271afef.method_1(num, struct2);
		}
		else
		{
			if ((object)type == typeof(object) && struct2.method_8() != null)
			{
				type = struct2.method_8().GetType();
			}
			struct2 = Struct2.dcafb951(struct2.method_8(), type);
			class50_0.c271afef.method_1(num, struct2);
		}
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		enum1_0 = (Enum1)0;
	}
}
