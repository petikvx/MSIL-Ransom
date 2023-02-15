#define DEBUG
using System;
using System.Diagnostics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

internal class Class10 : Interface0
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.cc257666;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint uint_ = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(uint_--);
		uint uint_2 = @struct.method_2() & 0x3FFFFFFFu;
		byte b273411 = (byte)(@struct.method_2() >> 30);
		MethodBase methodBase_ = (MethodBase)class50_0.class1_0.b7ea69fb().method_3(uint_2);
		bool flag;
		if (!(flag = b273411 == Class57.c27dbe57))
		{
			flag = smethod_1(class50_0, uint_, methodBase_, b273411 == Class57.e82770d8);
		}
		if (flag)
		{
			method_0(class50_0, methodBase_, b273411, ref uint_, out enum1_0);
		}
		else
		{
			ceffc8ac(class50_0, methodBase_, b273411, ref uint_, out enum1_0);
		}
	}

	private static object smethod_0(Class50 class50_0, Type type_0, ref uint uint_0)
	{
		Struct2 @struct = class50_0.c271afef.method_0(uint_0--);
		if (Type.GetTypeCode(type_0) == TypeCode.String && @struct.method_8() == null)
		{
			return class50_0.class1_0.b7ea69fb().method_4(@struct.method_2());
		}
		return @struct.method_10(type_0);
	}

	private unsafe static c658c1b4 cc22a5ea(Class50 class50_0, Type type_0, ref uint uint_0)
	{
		Struct2 struct2_ = class50_0.c271afef.method_0(uint_0);
		if (type_0.IsByRef)
		{
			uint_0--;
			type_0 = type_0.GetElementType();
			if (struct2_.method_8() is Pointer)
			{
				void* pVoid_ = Pointer.Unbox(struct2_.method_8());
				return new c1adcb63(pVoid_);
			}
			if (struct2_.method_8() is c658c1b4)
			{
				return (c658c1b4)struct2_.method_8();
			}
			return new c1adcb63((void*)struct2_.method_0());
		}
		if (Type.GetTypeCode(type_0) == TypeCode.String && struct2_.method_8() == null)
		{
			struct2_.e5a3833a(class50_0.class1_0.b7ea69fb().method_4(struct2_.method_2()));
			class50_0.c271afef.method_1(uint_0, struct2_);
		}
		return new a8e4b906(uint_0--);
	}

	private static bool smethod_1(Class50 class50_0, uint uint_0, MethodBase methodBase_0, bool bool_0)
	{
		if (!bool_0 && !methodBase_0.IsStatic && methodBase_0.DeclaringType!.IsValueType)
		{
			return true;
		}
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = 0;
		while (true)
		{
			if (num < parameters.Length)
			{
				ParameterInfo parameterInfo = parameters[num];
				if (parameterInfo.ParameterType.IsByRef)
				{
					break;
				}
				num++;
				continue;
			}
			if (methodBase_0 is MethodInfo && ((MethodInfo)methodBase_0).ReturnType.IsByRef)
			{
				return true;
			}
			return false;
		}
		return true;
	}

	private void ceffc8ac(Class50 class50_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out Enum1 enum1_0)
	{
		uint uint_ = uint_0;
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		object obj = null;
		object[] array = new object[parameters.Length];
		if (byte_0 == Class57.byte_66 && methodBase_0.IsVirtual)
		{
			int num = ((!methodBase_0.IsStatic) ? 1 : 0);
			array = new object[parameters.Length + num];
			for (int num2 = parameters.Length - 1; num2 >= 0; num2--)
			{
				array[num2 + num] = smethod_0(class50_0, parameters[num2].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic)
			{
				array[0] = smethod_0(class50_0, methodBase_0.DeclaringType, ref uint_0);
			}
			methodBase_0 = Class53.aefda86c(methodBase_0);
		}
		else
		{
			array = new object[parameters.Length];
			for (int num3 = parameters.Length - 1; num3 >= 0; num3--)
			{
				array[num3] = smethod_0(class50_0, parameters[num3].ParameterType, ref uint_0);
			}
			if (!methodBase_0.IsStatic && byte_0 != Class57.e82770d8)
			{
				obj = smethod_0(class50_0, methodBase_0.DeclaringType, ref uint_0);
				if (obj != null && !methodBase_0.DeclaringType!.IsInstanceOfType(obj))
				{
					method_0(class50_0, methodBase_0, byte_0, ref uint_, out enum1_0);
					return;
				}
			}
		}
		object object_;
		if (byte_0 == Class57.e82770d8)
		{
			try
			{
				object_ = ((ConstructorInfo)methodBase_0).Invoke(array);
			}
			catch (TargetInvocationException ex)
			{
				a5cd2846.abbe23a7(ex.InnerException, null);
				throw;
			}
		}
		else
		{
			if (!methodBase_0.IsStatic && obj == null)
			{
				throw new NullReferenceException();
			}
			Type type;
			if (obj != null && (type = obj.GetType()).IsArray && methodBase_0.Name == "SetValue")
			{
				d1f1067d.facb018d(type_0: (array[0] != null) ? array[0].GetType() : type.GetElementType(), array_0: (Array)obj, int_0: (int)array[1], object_0: array[0], type_1: type.GetElementType());
				object_ = null;
			}
			else
			{
				try
				{
					object_ = methodBase_0.Invoke(obj, array);
				}
				catch (TargetInvocationException ex2)
				{
					Class51.a32d503d(class50_0, ex2.InnerException);
					throw;
				}
			}
		}
		if (methodBase_0 is MethodInfo && (object)((MethodInfo)methodBase_0).ReturnType != typeof(void))
		{
			class50_0.c271afef.method_1(++uint_0, Struct2.dcafb951(object_, ((MethodInfo)methodBase_0).ReturnType));
		}
		else if (byte_0 == Class57.e82770d8)
		{
			class50_0.c271afef.method_1(++uint_0, Struct2.dcafb951(object_, methodBase_0.DeclaringType));
		}
		class50_0.c271afef.method_2(uint_0);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(uint_0);
		enum1_0 = (Enum1)0;
	}

	private void method_0(Class50 class50_0, MethodBase methodBase_0, byte byte_0, ref uint uint_0, out Enum1 enum1_0)
	{
		ParameterInfo[] parameters = methodBase_0.GetParameters();
		int num = parameters.Length;
		if (!methodBase_0.IsStatic && byte_0 != Class57.e82770d8)
		{
			num++;
		}
		Type type = null;
		if (byte_0 == Class57.c27dbe57)
		{
			type = (Type)class50_0.class1_0.b7ea69fb().method_3(class50_0.c271afef.method_0(uint_0--).method_2());
		}
		if (!methodBase_0.IsStatic && byte_0 != Class57.e82770d8)
		{
			_ = 1;
		}
		else
			_ = 0;
		c658c1b4[] array = new c658c1b4[num];
		Type[] array2 = new Type[num];
		for (int num2 = num - 1; num2 >= 0; num2--)
		{
			Type type2;
			if (!methodBase_0.IsStatic && byte_0 != Class57.e82770d8)
			{
				if (num2 == 0)
				{
					if (!methodBase_0.IsStatic)
					{
						Struct2 @struct = class50_0.c271afef.method_0(uint_0);
						if (@struct.method_8() is ValueType && !methodBase_0.DeclaringType!.IsValueType)
						{
							Debug.Assert(methodBase_0.DeclaringType!.IsInterface);
							Debug.Assert(byte_0 == Class57.byte_67);
							type = @struct.method_8().GetType();
						}
					}
					type2 = (((object)type != null) ? type.MakeByRefType() : ((!methodBase_0.DeclaringType!.IsValueType) ? methodBase_0.DeclaringType : methodBase_0.DeclaringType!.MakeByRefType()));
				}
				else
				{
					type2 = parameters[num2 - 1].ParameterType;
				}
			}
			else
			{
				type2 = parameters[num2].ParameterType;
			}
			array[num2] = cc22a5ea(class50_0, type2, ref uint_0);
			if (type2.IsByRef)
			{
				type2 = type2.GetElementType();
			}
			array2[num2] = type2;
		}
		OpCode opCode_;
		Type type3;
		if (byte_0 == Class57.byte_66)
		{
			opCode_ = OpCodes.Call;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else if (byte_0 == Class57.byte_67 || byte_0 == Class57.c27dbe57)
		{
			opCode_ = OpCodes.Callvirt;
			type3 = ((methodBase_0 is MethodInfo) ? ((MethodInfo)methodBase_0).ReturnType : typeof(void));
		}
		else
		{
			if (byte_0 != Class57.e82770d8)
			{
				throw new InvalidProgramException();
			}
			opCode_ = OpCodes.Newobj;
			type3 = methodBase_0.DeclaringType;
		}
		Class53.c581594 c = Class53.a2f788db(methodBase_0, opCode_, type);
		object object_ = c(class50_0, array, array2);
		if ((object)type3 != typeof(void))
		{
			class50_0.c271afef.method_1(++uint_0, Struct2.dcafb951(object_, type3));
		}
		else if (byte_0 == Class57.e82770d8)
		{
			class50_0.c271afef.method_1(++uint_0, Struct2.dcafb951(object_, type3));
		}
		class50_0.c271afef.method_2(uint_0);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(uint_0);
		enum1_0 = (Enum1)0;
	}
}
