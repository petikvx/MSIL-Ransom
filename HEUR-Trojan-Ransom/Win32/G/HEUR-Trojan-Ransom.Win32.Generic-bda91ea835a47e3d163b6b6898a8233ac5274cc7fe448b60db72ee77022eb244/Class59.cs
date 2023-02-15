using System;
using System.Collections.Generic;

internal static class Class59
{
	private static readonly Dictionary<byte, Interface1> dictionary_0;

	static Class59()
	{
		dictionary_0 = new Dictionary<byte, Interface1>();
		Type[] types = typeof(Class59).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(Interface1).IsAssignableFrom(type) && !type.IsAbstract)
			{
				Interface1 @interface = (Interface1)Activator.CreateInstance(type);
				dictionary_0[@interface.e32f22e7()] = @interface;
			}
		}
	}

	public static Interface1 smethod_0(byte byte_0)
	{
		return dictionary_0[byte_0];
	}
}
