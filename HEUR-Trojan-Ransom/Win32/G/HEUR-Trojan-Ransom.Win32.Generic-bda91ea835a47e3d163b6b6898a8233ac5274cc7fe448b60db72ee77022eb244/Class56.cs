using System;
using System.Collections;
using System.Reflection;
using System.Reflection.Emit;
using KoiVM.Runtime;

internal static class Class56
{
	private delegate RuntimeMethodHandle Delegate4(DynamicMethod dynamicMethod_0);

	private static readonly Delegate4 delegate4_0;

	private static readonly MethodInfo methodInfo_0;

	private static readonly MethodInfo methodInfo_1;

	private static readonly Hashtable e1e1fa03;

	static Class56()
	{
		e1e1fa03 = new Hashtable();
		MethodInfo[] methods = typeof(VMEntry).GetMethods(BindingFlags.Static | BindingFlags.NonPublic);
		foreach (MethodInfo methodInfo in methods)
		{
			if ((object)methodInfo.ReturnType != typeof(void) && methodInfo.GetParameters().Length > 4)
			{
				methodInfo_0 = methodInfo;
			}
			else
			{
				methodInfo_1 = methodInfo;
			}
		}
		delegate4_0 = (Delegate4)Delegate.CreateDelegate(typeof(Delegate4), typeof(DynamicMethod).GetMethod("GetMethodDescriptor", BindingFlags.Instance | BindingFlags.NonPublic));
	}

	public static IntPtr smethod_0(Module module_0, ulong ulong_0, uint uint_0, Class60 class60_0, uint uint_1)
	{
		object obj = e1e1fa03[ulong_0];
		if (obj != null)
		{
			return delegate4_0((DynamicMethod)obj).GetFunctionPointer();
		}
		lock (e1e1fa03)
		{
			obj = (DynamicMethod)e1e1fa03[ulong_0];
			if (obj != null)
			{
				return delegate4_0((DynamicMethod)obj).GetFunctionPointer();
			}
			obj = ((!smethod_1(class60_0)) ? a6561900(Class1.ab0e53e5(module_0), ulong_0, uint_0, class60_0, uint_1) : smethod_2(Class1.ab0e53e5(module_0), ulong_0, uint_0, class60_0, uint_1));
			e1e1fa03[ulong_0] = obj;
			return delegate4_0((DynamicMethod)obj).GetFunctionPointer();
		}
	}

	private static bool smethod_1(Class60 class60_0)
	{
		Type[] array = class60_0.method_0();
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				Type type = array[num];
				if (type.IsByRef)
				{
					break;
				}
				num++;
				continue;
			}
			return class60_0.c29cfcff().IsByRef;
		}
		return true;
	}

	private static DynamicMethod a6561900(int int_0, ulong ulong_0, uint uint_0, Class60 class60_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class60_0.c29cfcff(), class60_0.method_0(), Class55.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class60_0.method_0().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(object));
		for (int i = 0; i < class60_0.method_0().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			iLGenerator.Emit(OpCodes.Ldarg, i);
			if (class60_0.method_0()[i].IsValueType)
			{
				iLGenerator.Emit(OpCodes.Box, class60_0.method_0()[i]);
			}
			iLGenerator.Emit(OpCodes.Stelem_Ref);
		}
		iLGenerator.Emit(OpCodes.Call, methodInfo_0);
		if ((object)class60_0.c29cfcff() == typeof(void))
		{
			iLGenerator.Emit(OpCodes.Pop);
		}
		else if (class60_0.c29cfcff().IsValueType)
		{
			iLGenerator.Emit(OpCodes.Unbox_Any, class60_0.c29cfcff());
		}
		else
		{
			iLGenerator.Emit(OpCodes.Castclass, class60_0.c29cfcff());
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}

	private unsafe static DynamicMethod smethod_2(int int_0, ulong ulong_0, uint uint_0, Class60 class60_0, uint uint_1)
	{
		DynamicMethod dynamicMethod = new DynamicMethod("", class60_0.c29cfcff(), class60_0.method_0(), Class55.module_0, skipVisibility: true);
		ILGenerator iLGenerator = dynamicMethod.GetILGenerator();
		iLGenerator.Emit(OpCodes.Ldc_I4, int_0);
		iLGenerator.Emit(OpCodes.Ldc_I8, (long)ulong_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_0);
		iLGenerator.Emit(OpCodes.Ldc_I4, (int)uint_1);
		iLGenerator.Emit(OpCodes.Ldc_I4, class60_0.method_0().Length);
		iLGenerator.Emit(OpCodes.Newarr, typeof(void*));
		for (int i = 0; i < class60_0.method_0().Length; i++)
		{
			iLGenerator.Emit(OpCodes.Dup);
			iLGenerator.Emit(OpCodes.Ldc_I4, i);
			if (class60_0.method_0()[i].IsByRef)
			{
				iLGenerator.Emit(OpCodes.Ldarg, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class60_0.method_0()[i].GetElementType());
			}
			else
			{
				iLGenerator.Emit(OpCodes.Ldarga, i);
				iLGenerator.Emit(OpCodes.Mkrefany, class60_0.method_0()[i]);
			}
			LocalBuilder local = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Stloc, local);
			iLGenerator.Emit(OpCodes.Ldloca, local);
			iLGenerator.Emit(OpCodes.Conv_I);
			iLGenerator.Emit(OpCodes.Stelem_I);
		}
		if ((object)class60_0.c29cfcff() != typeof(void))
		{
			LocalBuilder local2 = iLGenerator.DeclareLocal(class60_0.c29cfcff());
			LocalBuilder local3 = iLGenerator.DeclareLocal(typeof(TypedReference));
			iLGenerator.Emit(OpCodes.Ldloca, local2);
			iLGenerator.Emit(OpCodes.Mkrefany, class60_0.c29cfcff());
			iLGenerator.Emit(OpCodes.Stloc, local3);
			iLGenerator.Emit(OpCodes.Ldloca, local3);
			iLGenerator.Emit(OpCodes.Call, methodInfo_1);
			iLGenerator.Emit(OpCodes.Ldloc, local2);
		}
		else
		{
			iLGenerator.Emit(OpCodes.Ldnull);
			iLGenerator.Emit(OpCodes.Call, methodInfo_1);
		}
		iLGenerator.Emit(OpCodes.Ret);
		return dynamicMethod;
	}
}
