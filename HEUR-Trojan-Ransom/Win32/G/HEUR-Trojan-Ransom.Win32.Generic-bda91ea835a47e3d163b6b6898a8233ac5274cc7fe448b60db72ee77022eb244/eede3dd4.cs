using System.Runtime.CompilerServices;

internal class eede3dd4 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_33;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num - 1);
		Struct2 struct2 = class50_0.c271afef.method_0(num);
		num -= 2;
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		ulong num2 = @struct.method_0() - struct2.method_0();
		byte byte_ = (byte)(Class57.byte_9 | Class57.byte_10 | Class57.byte_8 | Class57.dd38edf7);
		byte byte_2 = class50_0.eeec9ad0[Class57.ba3cd679].method_5();
		Class0.a9be3721(num2, struct2.method_0(), @struct.method_0(), num2, ref byte_2, byte_);
		class50_0.eeec9ad0[Class57.ba3cd679].method_6(byte_2);
		enum1_0 = (Enum1)0;
	}
}
