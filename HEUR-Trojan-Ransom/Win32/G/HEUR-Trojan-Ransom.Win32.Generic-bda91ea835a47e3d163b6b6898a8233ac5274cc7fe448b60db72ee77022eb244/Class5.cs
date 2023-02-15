using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

internal class Class5 : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.cb631811;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num--);
		Struct2 struct2 = class50_0.c271afef.method_0(num--);
		Type type = (Type)class50_0.class1_0.b7ea69fb().method_3(@struct.method_2());
		if (struct2.method_8() is c658c1b4)
		{
			c658c1b4 c658c1b5 = (c658c1b4)struct2.method_8();
			Struct2 struct2_ = default(Struct2);
			if (type.IsValueType)
			{
				object object_ = null;
				if ((object)Nullable.GetUnderlyingType(type) == null)
				{
					object_ = FormatterServices.GetUninitializedObject(type);
				}
				struct2_.e5a3833a(Class52.e93b53a8(object_, type));
			}
			else
			{
				struct2_.e5a3833a(null);
			}
			c658c1b5.facb018d(class50_0, struct2_, (Enum2)4);
			class50_0.c271afef.method_2(num);
			class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
			enum1_0 = (Enum1)0;
			return;
		}
		throw new NotSupportedException();
	}
}
