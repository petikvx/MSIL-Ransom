using System;
using System.Reflection;

internal class Class9
{
	internal delegate void Delegate0(object o);

	internal static Module xyRysJysh;

	internal static void qQAQIPKKW67Ec(int typemdt)
	{
		Type type = xyRysJysh.ResolveType(33554432 + typemdt);
		FieldInfo[] fields = type.GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			MethodInfo method = (MethodInfo)xyRysJysh.ResolveMethod(fieldInfo.MetadataToken + 100663296);
			fieldInfo.SetValue(null, (MulticastDelegate)Delegate.CreateDelegate(type, method));
		}
	}

	public Class9()
	{
		Class10.apRQIPKztvDS4();
		base._002Ector();
	}

	static Class9()
	{
		Class10.apRQIPKztvDS4();
		xyRysJysh = typeof(Class9).Assembly.ManifestModule;
	}
}
