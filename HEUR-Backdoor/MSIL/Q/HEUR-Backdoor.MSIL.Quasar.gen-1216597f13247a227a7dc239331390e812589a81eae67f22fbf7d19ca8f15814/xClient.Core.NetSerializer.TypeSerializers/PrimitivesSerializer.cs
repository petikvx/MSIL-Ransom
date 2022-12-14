using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace xClient.Core.NetSerializer.TypeSerializers;

public class PrimitivesSerializer : ITypeSerializer, IStaticTypeSerializer
{
	private static Type[] s_primitives = new Type[15]
	{
		typeof(bool),
		typeof(byte),
		typeof(sbyte),
		typeof(char),
		typeof(ushort),
		typeof(short),
		typeof(uint),
		typeof(int),
		typeof(ulong),
		typeof(long),
		typeof(float),
		typeof(double),
		typeof(string),
		typeof(DateTime),
		typeof(byte[])
	};

	public bool Handles(Type type)
	{
		return s_primitives.Contains(type);
	}

	public IEnumerable<Type> GetSubtypes(Type type)
	{
		yield break;
	}

	public void GetStaticMethods(Type type, out MethodInfo writer, out MethodInfo reader)
	{
		writer = Primitives.GetWritePrimitive(type);
		reader = Primitives.GetReaderPrimitive(type);
	}

	public static IEnumerable<Type> GetSupportedTypes()
	{
		return s_primitives;
	}
}
