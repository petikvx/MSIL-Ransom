#define DEBUG
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

internal class e93b53a8 : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.e78e6be2;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num--);
		Struct2 struct2_ = class50_0.c271afef.method_0(num);
		Type type = (Type)class50_0.class1_0.b7ea69fb().method_3(@struct.method_2());
		if (Type.GetTypeCode(type) == TypeCode.String && struct2_.method_8() == null)
		{
			struct2_.e5a3833a(class50_0.class1_0.b7ea69fb().method_4(struct2_.method_2()));
		}
		else
		{
			Debug.Assert(type.IsValueType);
			struct2_.e5a3833a(struct2_.method_10(type));
		}
		class50_0.c271afef.method_1(num, struct2_);
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		enum1_0 = (Enum1)0;
	}
}
