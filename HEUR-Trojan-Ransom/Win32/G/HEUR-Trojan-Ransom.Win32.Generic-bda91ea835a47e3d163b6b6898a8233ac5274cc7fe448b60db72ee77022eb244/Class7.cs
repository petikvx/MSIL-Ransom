using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class7 : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.f319286b;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num--);
		Struct2 struct2 = class50_0.c271afef.method_0(num);
		if (struct2.method_8() != null)
		{
			MethodInfo methodInfo = (MethodInfo)class50_0.class1_0.b7ea69fb().method_3(@struct.method_2());
			Type type = struct2.method_8().GetType();
			List<Type> list = new List<Type>();
			do
			{
				list.Add(type);
				type = type.BaseType;
			}
			while ((object)type != null && (object)type != methodInfo.DeclaringType);
			list.Reverse();
			MethodInfo methodInfo2 = methodInfo;
			foreach (Type item in list)
			{
				MethodInfo[] methods = item.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
				foreach (MethodInfo methodInfo3 in methods)
				{
					if ((object)methodInfo3.GetBaseDefinition() == methodInfo2)
					{
						methodInfo2 = methodInfo3;
						break;
					}
				}
			}
			d564e35d c271afef = class50_0.c271afef;
			uint uint_ = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.method_1((ulong)(long)methodInfo2.MethodHandle.GetFunctionPointer());
			c271afef.method_1(uint_, struct2_);
		}
		if (struct2.method_0() > 0L)
		{
			uint uint_2 = class50_0.c271afef.method_0(--num).method_2();
			ulong ulong_ = @struct.method_0();
			Class60 class60_ = class50_0.class1_0.b7ea69fb().a0bdbb28(struct2.method_2()).class60_0;
			IntPtr intPtr = Class56.smethod_0(class50_0.class1_0.b7ea69fb().method_0(), ulong_, uint_2, class60_, struct2.method_2());
			d564e35d c271afef2 = class50_0.c271afef;
			uint uint_3 = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.method_1((ulong)(long)intPtr);
			c271afef2.method_1(uint_3, struct2_);
		}
		else
		{
			MethodBase methodBase = (MethodBase)class50_0.class1_0.b7ea69fb().method_3(@struct.method_2());
			d564e35d c271afef3 = class50_0.c271afef;
			uint uint_4 = num;
			Struct2 struct2_ = default(Struct2);
			struct2_.method_1((ulong)(long)methodBase.MethodHandle.GetFunctionPointer());
			c271afef3.method_1(uint_4, struct2_);
		}
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		enum1_0 = (Enum1)0;
	}
}
