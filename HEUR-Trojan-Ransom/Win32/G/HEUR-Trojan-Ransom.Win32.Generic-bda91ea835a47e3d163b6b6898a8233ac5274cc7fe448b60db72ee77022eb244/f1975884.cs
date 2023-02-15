using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class f1975884 : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.ed44c4cf;
	}

	public unsafe void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num--);
		Struct2 struct2 = class50_0.c271afef.method_0(num--);
		Struct2 struct3 = class50_0.c271afef.method_0(num--);
		FieldInfo fieldInfo = (FieldInfo)class50_0.class1_0.b7ea69fb().method_3(@struct.method_2());
		if (!fieldInfo.IsStatic && struct3.method_8() == null)
		{
			throw new NullReferenceException();
		}
		object value = ((Type.GetTypeCode(fieldInfo.FieldType) != TypeCode.String || struct2.method_8() != null) ? struct2.method_10(fieldInfo.FieldType) : class50_0.class1_0.b7ea69fb().method_4(struct2.method_2()));
		if (fieldInfo.DeclaringType!.IsValueType && struct3.method_8() is c658c1b4)
		{
			TypedReference obj = default(TypedReference);
			((c658c1b4)struct3.method_8()).cdbadb47(class50_0, Struct1.b4634c31(&obj), fieldInfo.DeclaringType);
			Class54.smethod_0(Struct1.b4634c31(&obj), fieldInfo.DeclaringType);
			fieldInfo.SetValueDirect(obj, value);
		}
		else
		{
			fieldInfo.SetValue(struct3.method_10(fieldInfo.DeclaringType), value);
		}
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		enum1_0 = (Enum1)0;
	}
}
