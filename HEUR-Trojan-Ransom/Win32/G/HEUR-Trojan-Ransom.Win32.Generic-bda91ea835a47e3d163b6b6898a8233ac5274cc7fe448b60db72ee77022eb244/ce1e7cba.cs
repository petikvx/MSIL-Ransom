using System.Runtime.CompilerServices;

internal class ce1e7cba : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.byte_53;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint uint_ = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 struct2_ = class50_0.c271afef.method_0(uint_);
		double num = struct2_.b9e547a3();
		struct2_.method_1((ulong)(long)num);
		byte b273411 = (byte)(class50_0.eeec9ad0[Class57.ba3cd679].method_5() & ~Class57.byte_8);
		if ((b273411 & Class57.byte_11) != 0)
		{
			if (!(num > -1.0) || !(num < 1.8446744073709552E+19))
			{
				b273411 = (byte)(b273411 | Class57.byte_8);
			}
			if (!(num < 9.223372036854776E+18))
			{
				struct2_.method_1((ulong)((double)(long)num - 9.223372036854776E+18) + 9223372036854775808uL);
			}
		}
		else if (!(num > -9.223372036854778E+18) || !(num < 9.223372036854776E+18))
		{
			b273411 = (byte)(b273411 | Class57.byte_8);
		}
		class50_0.eeec9ad0[Class57.ba3cd679].method_6((byte)(b273411 & ~Class57.byte_11));
		class50_0.c271afef.method_1(uint_, struct2_);
		enum1_0 = (Enum1)0;
	}
}
