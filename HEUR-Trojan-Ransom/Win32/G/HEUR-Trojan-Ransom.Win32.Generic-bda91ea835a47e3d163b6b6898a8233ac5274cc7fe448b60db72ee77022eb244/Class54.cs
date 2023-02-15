using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

internal static class Class54
{
	private delegate void f34fddb6(Struct1 struct1_0);

	private unsafe delegate void Delegate1(void* pVoid_0, Struct1 struct1_0);

	private delegate void Delegate2(object object_0, Struct1 struct1_0);

	private delegate void Delegate3(object object_0, Struct1 struct1_0);

	private delegate void bd4b214a(Struct1 struct1_0, Struct1 struct1_1);

	private static readonly Hashtable c4ae78b0 = new Hashtable();

	private static readonly Hashtable hashtable_0 = new Hashtable();

	private static readonly Hashtable hashtable_1 = new Hashtable();

	private static readonly Hashtable d6401559 = new Hashtable();

	private static readonly Hashtable bbe27ee4 = new Hashtable();

	private static readonly FieldInfo fieldInfo_0 = typeof(Struct1).GetFields()[0];

	public unsafe static void smethod_0(Struct1 struct1_0, Type type_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)Struct1.b4634c31(struct1_0));
		KeyValuePair<Type, Type> keyValuePair = new KeyValuePair<Type, Type>(targetType, type_0);
		object obj = c4ae78b0[keyValuePair];
		if (obj == null)
		{
			lock (c4ae78b0)
			{
				obj = c4ae78b0[keyValuePair];
				if (obj == null)
				{
					obj = smethod_4(targetType, type_0);
					c4ae78b0[keyValuePair] = obj;
				}
			}
		}
		((f34fddb6)obj)(struct1_0);
	}

	public unsafe static void c51d4e0d(void* pVoid_0, Struct1 struct1_0, Type type_0)
	{
		object obj = hashtable_0[type_0];
		if (obj == null)
		{
			lock (hashtable_0)
			{
				obj = hashtable_0[type_0];
				if (obj == null)
				{
					obj = f6827bc(type_0);
					hashtable_0[type_0] = obj;
				}
			}
		}
		((Delegate1)obj)(pVoid_0, struct1_0);
	}

	public static void smethod_1(object object_0, Struct1 struct1_0)
	{
		smethod_2(object_0, struct1_0, object_0.GetType());
		if (object_0 is Interface2)
		{
			smethod_0(struct1_0, ((Interface2)object_0).imethod_1());
		}
	}

	public static void smethod_2(object object_0, Struct1 struct1_0, Type type_0)
	{
		object obj = hashtable_1[type_0];
		if (obj == null)
		{
			lock (hashtable_1)
			{
				obj = hashtable_1[type_0];
				if (obj == null)
				{
					obj = smethod_5(type_0);
					hashtable_1[type_0] = obj;
				}
			}
		}
		((Delegate2)obj)(object_0, struct1_0);
	}

	public unsafe static void smethod_3(object object_0, Struct1 struct1_0)
	{
		Type targetType = TypedReference.GetTargetType(*(TypedReference*)Struct1.b4634c31(struct1_0));
		object obj = d6401559[targetType];
		if (obj == null)
		{
			lock (d6401559)
			{
				obj = d6401559[targetType];
				if (obj == null)
				{
					obj = smethod_6(targetType);
					d6401559[targetType] = obj;
				}
			}
		}
		((Delegate3)obj)(object_0, struct1_0);
	}

	public unsafe static void d59ce67a(Class50 class50_0, object object_0, FieldInfo fieldInfo_1, Struct1 struct1_0)
	{
		object obj = bbe27ee4[fieldInfo_1];
		if (obj == null)
		{
			lock (bbe27ee4)
			{
				obj = bbe27ee4[fieldInfo_1];
				if (obj == null)
				{
					obj = b3956f55(fieldInfo_1);
					bbe27ee4[fieldInfo_1] = obj;
				}
			}
		}
		TypedReference typedReference = default(TypedReference);
		if (object_0 == null)
		{
			typedReference = default(TypedReference);
		}
		else if (object_0 is c658c1b4)
		{
			((c658c1b4)object_0).cdbadb47(class50_0, Struct1.b4634c31(&typedReference), fieldInfo_1.DeclaringType);
		}
		else
		{
			typedReference = __makeref(object_0);
			smethod_0(Struct1.b4634c31(&typedReference), object_0.GetType());
		}
		((bd4b214a)obj)(Struct1.b4634c31(&typedReference), struct1_0);
	}

	private static f34fddb6 smethod_4(Type type_0, Type type_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[1] { typeof(Struct1) }, Class55.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 0);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Dup);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_1);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (f34fddb6)dynamicMethod.CreateDelegate(typeof(f34fddb6));
	}

	private unsafe static Delegate1 f6827bc(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(void*),
			typeof(Struct1)
		}, Class55.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate1)dynamicMethod.CreateDelegate(typeof(Delegate1));
	}

	private static Delegate2 smethod_5(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(Struct1)
		}, Class55.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox, type_0);
		iLGenerator.Emit(OpCodes.Mkrefany, type_0);
		iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate2)dynamicMethod.CreateDelegate(typeof(Delegate2));
	}

	private static Delegate3 smethod_6(Type type_0)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(object),
			typeof(Struct1)
		}, Class55.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldarga, 1);
		iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
		iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
		iLGenerator.Emit(OpCodes.Refanyval, type_0);
		iLGenerator.Emit(OpCodes.Ldarg_0);
		iLGenerator.Emit(OpCodes.Unbox_Any, type_0);
		iLGenerator.Emit(OpCodes.Stobj, type_0);
		iLGenerator.Emit(OpCodes.Ret);
		return (Delegate3)dynamicMethod.CreateDelegate(typeof(Delegate3));
	}

	private static bd4b214a b3956f55(FieldInfo fieldInfo_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", typeof(void), new Type[2]
		{
			typeof(Struct1),
			typeof(Struct1)
		}, Class55.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		if (fieldInfo_1.IsStatic)
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
			iLGenerator.Emit(OpCodes.Ldsflda, fieldInfo_1);
			iLGenerator.Emit(OpCodes.Mkrefany, fieldInfo_1.FieldType);
			iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ret);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Ldarga, 1);
			iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
			iLGenerator.Emit(OpCodes.Ldarga, 0);
			iLGenerator.Emit(OpCodes.Ldfld, fieldInfo_0);
			iLGenerator.Emit(OpCodes.Ldobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Refanyval, fieldInfo_1.DeclaringType);
			if (!fieldInfo_1.DeclaringType!.IsValueType)
			{
				iLGenerator.Emit(OpCodes.Ldobj, fieldInfo_1.DeclaringType);
			}
			iLGenerator.Emit(OpCodes.Ldflda, fieldInfo_1);
			iLGenerator.Emit(OpCodes.Mkrefany, fieldInfo_1.FieldType);
			iLGenerator.Emit(OpCodes.Stobj, typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ret);
		}
		return (bd4b214a)dynamicMethod.CreateDelegate(typeof(bd4b214a));
	}
}
