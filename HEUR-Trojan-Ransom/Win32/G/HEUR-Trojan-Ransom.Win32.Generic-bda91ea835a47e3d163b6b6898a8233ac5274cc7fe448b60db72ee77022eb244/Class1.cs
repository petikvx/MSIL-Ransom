#define DEBUG
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class1
{
	[ThreadStatic]
	private static Dictionary<Module, Class1> dictionary_0;

	private static readonly object object_0 = new object();

	private static readonly Dictionary<Module, int> a88a0734 = new Dictionary<Module, int>();

	private readonly Stack<Class50> stack_0 = new Stack<Class50>();

	private Class50 class50_0;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly Class58 e83f302d;

	private Class1(Class58 class58_0)
	{
		e83f302d = class58_0;
	}

	[SpecialName]
	public Class58 b7ea69fb()
	{
		return e83f302d;
	}

	public static Class1 smethod_0(Module module_0)
	{
		if (dictionary_0 == null)
		{
			dictionary_0 = new Dictionary<Module, Class1>();
		}
		if (!dictionary_0.TryGetValue(module_0, out var value))
		{
			value = new Class1(Class58.smethod_0(module_0));
			dictionary_0[module_0] = value;
			lock (object_0)
			{
				if (!a88a0734.ContainsKey(module_0))
				{
					value.d2f37400();
					a88a0734.Add(module_0, a88a0734.Count);
				}
			}
		}
		return value;
	}

	public static Class1 smethod_1(int int_0)
	{
		foreach (KeyValuePair<Module, int> item in a88a0734)
		{
			if (item.Value == int_0)
			{
				return smethod_0(item.Key);
			}
		}
		return null;
	}

	public static int ab0e53e5(Module module_0)
	{
		return a88a0734[module_0];
	}

	private unsafe void d2f37400()
	{
		Struct4 @struct = b7ea69fb().a0bdbb28(Class57.byte_65);
		ulong ulong_ = (ulong)(b7ea69fb().method_1() + @struct.e4cdd96a);
		method_4(ulong_, @struct.uint_0, @struct.class60_0, new object[0]);
	}

	public unsafe object method_0(uint uint_0, object[] object_1)
	{
		Struct4 @struct = b7ea69fb().a0bdbb28(uint_0);
		ulong ulong_ = (ulong)(b7ea69fb().method_1() + @struct.e4cdd96a);
		return method_4(ulong_, @struct.uint_0, @struct.class60_0, object_1);
	}

	public object method_1(ulong ulong_0, uint uint_0, uint uint_1, object[] object_1)
	{
		Class60 class60_ = b7ea69fb().a0bdbb28(uint_1).class60_0;
		return method_4(ulong_0, uint_0, class60_, object_1);
	}

	public unsafe void method_2(uint uint_0, void*[] pVoid_0, void* pVoid_1)
	{
		Struct4 @struct = b7ea69fb().a0bdbb28(uint_0);
		ulong ulong_ = (ulong)(b7ea69fb().method_1() + @struct.e4cdd96a);
		method_5(ulong_, @struct.uint_0, @struct.class60_0, pVoid_0, pVoid_1);
	}

	public unsafe void method_3(ulong ulong_0, uint uint_0, uint uint_1, void*[] pVoid_0, void* pVoid_1)
	{
		Class60 class60_ = b7ea69fb().a0bdbb28(uint_1).class60_0;
		method_5(ulong_0, uint_0, class60_, pVoid_0, pVoid_1);
	}

	private object method_4(ulong ulong_0, uint uint_0, Class60 class60_0, object[] object_1)
	{
		if (class50_0 != null)
		{
			stack_0.Push(class50_0);
		}
		class50_0 = new Class50(this);
		try
		{
			Debug.Assert(class60_0.method_0().Length == object_1.Length);
			class50_0.c271afef.method_2((uint)(object_1.Length + 1));
			for (uint num = 0u; num < object_1.Length; num++)
			{
				class50_0.c271afef.method_1(num + 1, Struct2.dcafb951(object_1[num], class60_0.method_0()[num]));
			}
			d564e35d c271afef = class50_0.c271afef;
			int uint_ = object_1.Length + 1;
			Struct2 struct2_ = default(Struct2);
			struct2_.method_1(1uL);
			c271afef.method_1((uint)uint_, struct2_);
			Struct2[] eeec9ad = class50_0.eeec9ad0;
			byte e0cb0d = Class57.e0cb0d84;
			struct2_ = default(Struct2);
			struct2_.method_3(uint_0);
			eeec9ad[e0cb0d] = struct2_;
			Struct2[] eeec9ad2 = class50_0.eeec9ad0;
			byte byte_ = Class57.byte_5;
			struct2_ = default(Struct2);
			struct2_.method_3(0u);
			eeec9ad2[byte_] = struct2_;
			Struct2[] eeec9ad3 = class50_0.eeec9ad0;
			byte aae8806f = Class57.aae8806f;
			struct2_ = default(Struct2);
			struct2_.method_3((uint)(object_1.Length + 1));
			eeec9ad3[aae8806f] = struct2_;
			Struct2[] eeec9ad4 = class50_0.eeec9ad0;
			byte byte_2 = Class57.byte_6;
			struct2_ = default(Struct2);
			struct2_.method_1(ulong_0);
			eeec9ad4[byte_2] = struct2_;
			Class51.smethod_0(class50_0);
			Debug.Assert(class50_0.e98b396e.Count == 0);
			object result = null;
			if ((object)class60_0.c29cfcff() != typeof(void))
			{
				Struct2 @struct = class50_0.eeec9ad0[Class57.byte_0];
				result = ((Type.GetTypeCode(class60_0.c29cfcff()) != TypeCode.String || @struct.method_8() != null) ? @struct.method_10(class60_0.c29cfcff()) : b7ea69fb().method_4(@struct.method_2()));
			}
			return result;
		}
		finally
		{
			class50_0.c271afef.b2cbe5cc();
			if (stack_0.Count > 0)
			{
				class50_0 = stack_0.Pop();
			}
		}
	}

	private unsafe void method_5(ulong ulong_0, uint uint_0, Class60 class60_0, void*[] pVoid_0, void* pVoid_1)
	{
		if (class50_0 != null)
		{
			stack_0.Push(class50_0);
		}
		class50_0 = new Class50(this);
		try
		{
			Debug.Assert(class60_0.method_0().Length == pVoid_0.Length);
			class50_0.c271afef.method_2((uint)(pVoid_0.Length + 1));
			Struct2 struct2_;
			for (uint num = 0u; num < pVoid_0.Length; num++)
			{
				Type type = class60_0.method_0()[num];
				if (type.IsByRef)
				{
					d564e35d c271afef = class50_0.c271afef;
					uint uint_ = num + 1;
					struct2_ = default(Struct2);
					struct2_.e5a3833a(new Class48(Struct1.b4634c31(pVoid_0[num])));
					c271afef.method_1(uint_, struct2_);
				}
				else
				{
					TypedReference typedReference = *(TypedReference*)pVoid_0[num];
					class50_0.c271afef.method_1(num + 1, Struct2.dcafb951(TypedReference.ToObject(typedReference), __reftype(typedReference)));
				}
			}
			d564e35d c271afef2 = class50_0.c271afef;
			int uint_2 = pVoid_0.Length + 1;
			struct2_ = default(Struct2);
			struct2_.method_1(1uL);
			c271afef2.method_1((uint)uint_2, struct2_);
			Struct2[] eeec9ad = class50_0.eeec9ad0;
			byte e0cb0d = Class57.e0cb0d84;
			struct2_ = default(Struct2);
			struct2_.method_3(uint_0);
			eeec9ad[e0cb0d] = struct2_;
			Struct2[] eeec9ad2 = class50_0.eeec9ad0;
			byte byte_ = Class57.byte_5;
			struct2_ = default(Struct2);
			struct2_.method_3(0u);
			eeec9ad2[byte_] = struct2_;
			Struct2[] eeec9ad3 = class50_0.eeec9ad0;
			byte aae8806f = Class57.aae8806f;
			struct2_ = default(Struct2);
			struct2_.method_3((uint)(pVoid_0.Length + 1));
			eeec9ad3[aae8806f] = struct2_;
			Struct2[] eeec9ad4 = class50_0.eeec9ad0;
			byte byte_2 = Class57.byte_6;
			struct2_ = default(Struct2);
			struct2_.method_1(ulong_0);
			eeec9ad4[byte_2] = struct2_;
			Class51.smethod_0(class50_0);
			Debug.Assert(class50_0.e98b396e.Count == 0);
			if ((object)class60_0.c29cfcff() == typeof(void))
			{
				return;
			}
			if (class60_0.c29cfcff().IsByRef)
			{
				object obj = class50_0.eeec9ad0[Class57.byte_0].method_8();
				if (!(obj is c658c1b4))
				{
					throw new ExecutionEngineException();
				}
				((c658c1b4)obj).cdbadb47(class50_0, Struct1.b4634c31(pVoid_1), class60_0.c29cfcff().GetElementType());
			}
			else
			{
				Struct2 @struct = class50_0.eeec9ad0[Class57.byte_0];
				object obj2 = ((Type.GetTypeCode(class60_0.c29cfcff()) != TypeCode.String || @struct.method_8() != null) ? @struct.method_10(class60_0.c29cfcff()) : b7ea69fb().method_4(@struct.method_2()));
				Class54.smethod_3(obj2, Struct1.b4634c31(pVoid_1));
			}
		}
		finally
		{
			class50_0.c271afef.b2cbe5cc();
			if (stack_0.Count > 0)
			{
				class50_0 = stack_0.Pop();
			}
		}
	}
}
