using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class c08bdf6f : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_61;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint uint_ = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 struct2_ = class50_0.c271afef.method_0(uint_);
		MemberInfo memberInfo = class50_0.class1_0.b7ea69fb().method_3(struct2_.method_2());
		if (memberInfo is Type)
		{
			struct2_.e5a3833a(Class52.e93b53a8(((Type)memberInfo).TypeHandle, typeof(RuntimeTypeHandle)));
		}
		else if (memberInfo is MethodBase)
		{
			struct2_.e5a3833a(Class52.e93b53a8(((MethodBase)memberInfo).MethodHandle, typeof(RuntimeMethodHandle)));
		}
		else if (memberInfo is FieldInfo)
		{
			struct2_.e5a3833a(Class52.e93b53a8(((FieldInfo)memberInfo).FieldHandle, typeof(RuntimeFieldHandle)));
		}
		class50_0.c271afef.method_1(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
