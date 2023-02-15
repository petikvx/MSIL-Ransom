using System;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class60
{
	private readonly int[] int_0;

	private readonly int int_1;

	public byte aec52d54;

	private readonly Module module_0;

	private Type[] type_0;

	private Type fa2545a6;

	public unsafe Class60(ref byte* pByte_0, Module module_1)
	{
		module_0 = module_1;
		aec52d54 = *(pByte_0++);
		int_0 = new int[Class0.aa1fdcd7(ref pByte_0)];
		for (int i = 0; i < int_0.Length; i++)
		{
			int_0[i] = (int)Class0.smethod_0(Class0.aa1fdcd7(ref pByte_0));
		}
		int_1 = (int)Class0.smethod_0(Class0.aa1fdcd7(ref pByte_0));
	}

	[SpecialName]
	public Type[] method_0()
	{
		if (type_0 != null)
		{
			return type_0;
		}
		Type[] array = new Type[int_0.Length];
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = module_0.ResolveType(int_0[i]);
		}
		type_0 = array;
		return array;
	}

	[SpecialName]
	public Type c29cfcff()
	{
		return fa2545a6 ?? (fa2545a6 = module_0.ResolveType(int_1));
	}
}
