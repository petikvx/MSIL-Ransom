using System;
using System.Collections;
using System.Reflection.Emit;

internal class a036e439
{
	private static readonly Hashtable hashtable_0 = new Hashtable();

	public static int smethod_0(Type type_0)
	{
		object obj = hashtable_0[type_0];
		if (obj == null)
		{
			lock (hashtable_0)
			{
				obj = hashtable_0[type_0];
				if (obj == null)
				{
					obj = d1094ed3(type_0);
					hashtable_0[type_0] = obj;
				}
			}
		}
		return (int)obj;
	}

	private static int d1094ed3(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(int), Type.EmptyTypes, Class55.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Sizeof, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (int)dynamicMethod.Invoke(null, null);
	}
}
