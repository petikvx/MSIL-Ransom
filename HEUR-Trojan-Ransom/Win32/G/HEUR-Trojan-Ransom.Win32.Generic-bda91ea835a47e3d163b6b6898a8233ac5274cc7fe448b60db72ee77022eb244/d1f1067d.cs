#define DEBUG
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Emit;

internal class d1f1067d
{
	private delegate void b9fb9faa(Array array_0, int int_0, object object_0);

	private static readonly Hashtable hashtable_0 = new Hashtable();

	public static void facb018d(Array array_0, int int_0, object object_0, Type type_0, Type type_1)
	{
		Debug.Assert(object_0 == null || (object)object_0.GetType() == type_0);
		KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(type_0, type_1);
		object obj = hashtable_0[keyValuePair];
		if (obj == null)
		{
			lock (hashtable_0)
			{
				obj = hashtable_0[keyValuePair];
				if (obj == null)
				{
					obj = smethod_0(type_0, type_1);
					hashtable_0[keyValuePair] = obj;
				}
			}
		}
		((b9fb9faa)obj)(array_0, int_0, object_0);
	}

	private static b9fb9faa smethod_0(Type type_0, Type type_1)
	{
		Type[] parameterTypes = new Type[3]
		{
			typeof(Array),
			typeof(int),
			typeof(object)
		};
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), parameterTypes, Class55.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Ldarg_1);
		iLGenerator.Emit(OpCodes.Ldarg_2);
		if (type_1.IsValueType)
		{
			iLGenerator.Emit(OpCodes.Unbox_Any, type_0);
		}
		iLGenerator.Emit(OpCodes.Stelem, type_1);
		iLGenerator.Emit(OpCodes.Ret);
		return (b9fb9faa)dynamicMethod.CreateDelegate(typeof(b9fb9faa));
	}
}
