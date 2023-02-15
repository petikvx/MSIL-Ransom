#define DEBUG
using System;
using System.Diagnostics;

internal static class Class52
{
	public static Interface2 e93b53a8(object object_0, Type type_0)
	{
		Debug.Assert(type_0.IsValueType);
		Type type = typeof(global::b273410<>).MakeGenericType(type_0);
		return (Interface2)Activator.CreateInstance(type, object_0);
	}

	public static object smethod_0(object object_0)
	{
		if (object_0 is Interface2)
		{
			return ((Interface2)object_0).imethod_0();
		}
		return object_0;
	}
}
