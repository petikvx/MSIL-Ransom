using System.Runtime.CompilerServices;

internal class Class43 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_20;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num);
		class50_0.c271afef.method_2(--num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		byte b273411 = class50_0.method_0();
		if ((b273411 == Class57.aae8806f || b273411 == Class57.byte_5) && @struct.method_8() is a8e4b906)
		{
			Struct2[] eeec9ad = class50_0.eeec9ad0;
			Struct2 struct2 = default(Struct2);
			struct2.method_3(((a8e4b906)@struct.method_8()).method_0());
			eeec9ad[b273411] = struct2;
		}
		else
		{
			class50_0.eeec9ad0[b273411] = @struct;
		}
		enum1_0 = (Enum1)0;
	}
}
