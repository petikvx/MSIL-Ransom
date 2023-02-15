using System.Collections.Generic;

internal class Class50
{
	public readonly List<d91f6464> e98b396e = new List<d91f6464>();

	public readonly List<Class49> list_0 = new List<Class49>();

	public readonly Class1 class1_0;

	public readonly Struct2[] eeec9ad0 = new Struct2[16];

	public readonly d564e35d c271afef = new d564e35d();

	public Class50(Class1 class1_1)
	{
		class1_0 = class1_1;
	}

	public unsafe byte method_0()
	{
		uint num = eeec9ad0[Class57.e0cb0d84].method_2();
		ref Struct2 reference = ref eeec9ad0[Class57.byte_6];
		ulong num2 = reference.method_0();
		reference.method_1(num2 + 1L);
		byte* ptr = (byte*)num2;
		byte b273411 = (byte)(*ptr ^ num);
		num = num * 7 + b273411;
		eeec9ad0[Class57.e0cb0d84].method_3(num);
		return b273411;
	}
}
