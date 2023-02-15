using System.Runtime.CompilerServices;

internal class a4881681 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_39;
	}

	public unsafe void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num);
		Struct2 struct2 = class50_0.c271afef.method_0(num - 1);
		num -= 2;
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		uint num2 = struct2.method_2();
		ushort num3 = *(ushort*)(@struct.method_0() - 2L);
		if (num2 < num3)
		{
			ref Struct2 reference = ref class50_0.eeec9ad0[Class57.byte_6];
			reference.method_1(reference.method_0() + (ulong)(*(int*)((nint)@struct.method_0() + (nint)((long)num2 * 4L))));
		}
		enum1_0 = (Enum1)0;
	}
}
