using System.Runtime.CompilerServices;

internal class ce6d4649 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_24;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		class50_0.c271afef.method_2(++num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		ulong num2 = class50_0.method_0();
		num2 |= (ulong)class50_0.method_0() << 8;
		num2 |= (ulong)class50_0.method_0() << 16;
		num2 |= (ulong)class50_0.method_0() << 24;
		ulong num3 = (((num2 & 0x80000000L) != 0L) ? 18446744069414584320uL : 0uL);
		d564e35d c271afef = class50_0.c271afef;
		uint uint_ = num;
		Struct2 struct2_ = default(Struct2);
		struct2_.method_1(num3 | num2);
		c271afef.method_1(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
