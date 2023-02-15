using System;
using System.Runtime.CompilerServices;

internal class Class28 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_55;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		byte b273411 = class50_0.c271afef.method_0(num--).method_5();
		d91f6464 item = default(d91f6464);
		item.byte_0 = b273411;
		if (b273411 == Class57.byte_68)
		{
			item.f09b6bd8 = (Type)class50_0.class1_0.b7ea69fb().method_3(class50_0.c271afef.method_0(num--).method_2());
		}
		else if (b273411 == Class57.ae3b258c)
		{
			item.d6fd5f36 = class50_0.c271afef.method_0(num--).method_0();
		}
		item.ulong_0 = class50_0.c271afef.method_0(num--).method_0();
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		item.e9637d57 = class50_0.eeec9ad0[Class57.byte_5];
		item.f7ebfaca = class50_0.eeec9ad0[Class57.aae8806f];
		class50_0.e98b396e.Add(item);
		enum1_0 = (Enum1)0;
	}
}
