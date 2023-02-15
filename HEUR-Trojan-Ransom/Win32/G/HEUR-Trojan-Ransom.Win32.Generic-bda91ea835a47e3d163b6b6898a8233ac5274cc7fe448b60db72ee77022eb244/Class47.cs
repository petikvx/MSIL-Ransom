using System;
using System.Reflection;

internal class Class47 : c658c1b4
{
	private readonly FieldInfo ec5e5d3c;

	private readonly object f13b976b;

	public Class47(object object_0, FieldInfo fieldInfo_0)
	{
		f13b976b = object_0;
		ec5e5d3c = fieldInfo_0;
	}

	public Struct2 imethod_0(Class50 class50_0, Enum2 enum2_0)
	{
		object obj = f13b976b;
		if (ec5e5d3c.DeclaringType!.IsValueType && f13b976b is c658c1b4)
		{
			obj = ((c658c1b4)f13b976b).imethod_0(class50_0, (Enum2)4).method_10(ec5e5d3c.DeclaringType);
		}
		return Struct2.dcafb951(ec5e5d3c.GetValue(obj), ec5e5d3c.FieldType);
	}

	public unsafe void facb018d(Class50 class50_0, Struct2 struct2_0, Enum2 enum2_0)
	{
		if (ec5e5d3c.DeclaringType!.IsValueType && f13b976b is c658c1b4)
		{
			TypedReference obj = default(TypedReference);
			((c658c1b4)f13b976b).cdbadb47(class50_0, Struct1.b4634c31(&obj), ec5e5d3c.DeclaringType);
			ec5e5d3c.SetValueDirect(obj, struct2_0.method_10(ec5e5d3c.FieldType));
		}
		else
		{
			ec5e5d3c.SetValue(f13b976b, struct2_0.method_10(ec5e5d3c.FieldType));
		}
	}

	public c658c1b4 imethod_1(uint uint_0)
	{
		return this;
	}

	public c658c1b4 imethod_2(ulong ulong_0)
	{
		return this;
	}

	public void cdbadb47(Class50 class50_0, Struct1 struct1_0, Type type_0)
	{
		Class54.d59ce67a(class50_0, f13b976b, ec5e5d3c, struct1_0);
	}
}
