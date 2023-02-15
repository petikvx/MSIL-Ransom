using System;
using System.Collections.Generic;

internal static class f29d4965
{
	private static readonly Dictionary<byte, Interface0> dictionary_0;

	static f29d4965()
	{
		dictionary_0 = new Dictionary<byte, Interface0>();
		Type[] types = typeof(f29d4965).Assembly.GetTypes();
		foreach (Type type in types)
		{
			if (typeof(Interface0).IsAssignableFrom(type) && !type.IsAbstract)
			{
				Interface0 @interface = (Interface0)Activator.CreateInstance(type);
				dictionary_0[@interface.e32f22e7()] = @interface;
			}
		}
	}

	public static Interface0 smethod_0(byte byte_0)
	{
		return dictionary_0[byte_0];
	}
}
