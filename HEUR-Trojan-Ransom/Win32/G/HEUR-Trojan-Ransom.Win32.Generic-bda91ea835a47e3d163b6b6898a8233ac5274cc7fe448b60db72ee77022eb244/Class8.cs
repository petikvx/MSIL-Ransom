using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class8 : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_60;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num--);
		Struct2 struct2 = class50_0.c271afef.method_0(num);
		bool flag = (@struct.method_2() & 0x80000000u) != 0;
		FieldInfo fieldInfo = (FieldInfo)class50_0.class1_0.b7ea69fb().method_3(@struct.method_2() & 0x7FFFFFFFu);
		if (!fieldInfo.IsStatic && struct2.method_8() == null)
		{
			throw new NullReferenceException();
		}
		if (flag)
		{
			d564e35d c271afef = class50_0.c271afef;
			uint uint_ = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.e5a3833a(new Class47(struct2.method_8(), fieldInfo));
			c271afef.method_1(uint_, struct2_);
		}
		else
		{
			object obj = ((!fieldInfo.DeclaringType!.IsValueType || !(struct2.method_8() is c658c1b4)) ? struct2.method_10(fieldInfo.DeclaringType) : ((c658c1b4)struct2.method_8()).imethod_0(class50_0, (Enum2)4).method_10(fieldInfo.DeclaringType));
			class50_0.c271afef.method_1(num, Struct2.dcafb951(fieldInfo.GetValue(obj), fieldInfo.FieldType));
		}
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		enum1_0 = (Enum1)0;
	}
}
