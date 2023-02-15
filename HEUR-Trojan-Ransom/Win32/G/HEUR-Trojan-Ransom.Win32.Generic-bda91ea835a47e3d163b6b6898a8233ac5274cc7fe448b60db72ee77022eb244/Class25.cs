using System.Runtime.CompilerServices;

internal class Class25 : Interface1
{
	[SpecialName]
	public byte e32f22e7()
	{
		return Class57.dc08c79c;
	}

	public void imethod_0(Class50 class50_0, out Enum1 enum1_0)
	{
		uint num = class50_0.eeec9ad0[Class57.aae8806f].method_2();
		Struct2 @struct = class50_0.c271afef.method_0(num - 1);
		Struct2 struct2 = class50_0.c271afef.method_0(num);
		num--;
		class50_0.c271afef.method_2(num);
		class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
		byte b273411 = class50_0.eeec9ad0[Class57.ba3cd679].method_5();
		Struct2 struct2_ = default(Struct2);
		ulong num2 = @struct.method_0() * struct2.method_0();
		struct2_.method_1(num2);
		class50_0.c271afef.method_1(num, struct2_);
		byte byte_ = (byte)(Class57.byte_9 | Class57.byte_10 | Class57.byte_11);
		byte b273412 = (byte)(Class57.dd38edf7 | Class57.byte_8);
		byte b273413 = 0;
		if ((b273411 & Class57.byte_11) != 0)
		{
			if (smethod_0(@struct.method_0(), struct2.method_0()) > 0L)
			{
				b273413 = b273412;
			}
		}
		else if (num2 >> 63 != (@struct.method_0() ^ struct2.method_0()) >> 63)
		{
			b273413 = b273412;
		}
		b273411 = (byte)((b273411 & ~b273412) | b273413);
		Class0.a9be3721(@struct.method_2(), struct2.method_0(), struct2_.method_0(), struct2_.method_0(), ref b273411, byte_);
		class50_0.eeec9ad0[Class57.ba3cd679].method_6(b273411);
		enum1_0 = (Enum1)0;
	}

	private static ulong smethod_0(ulong ulong_0, ulong ulong_1)
	{
		ulong num = ulong_0 & 0xFFFFFFFFuL;
		ulong num2 = ulong_0 >> 32;
		ulong num3 = ulong_1 & 0xFFFFFFFFuL;
		ulong num4 = ulong_1 >> 32;
		ulong num5 = num * num3;
		num5 = num2 * num3 + (num5 >> 32);
		ulong num6 = num5 & 0xFFFFFFFFuL;
		ulong num7 = num5 >> 32;
		num5 = num6 + num * num4;
		num6 = num5 & 0xFFFFFFFFuL;
		return num7 + num2 * num4 + (num5 >> 32);
	}
}
