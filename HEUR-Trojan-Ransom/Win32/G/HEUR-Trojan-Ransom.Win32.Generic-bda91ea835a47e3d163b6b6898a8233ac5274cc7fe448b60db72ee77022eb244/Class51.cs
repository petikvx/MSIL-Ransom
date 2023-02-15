using System;
using System.Text;

internal static class Class51
{
	private static uint cdfd0c1 = (uint)Environment.TickCount;

	public static Enum1 smethod_0(Class50 class50_0)
	{
		Enum1 enum1_ = (Enum1)0;
		bool flag = true;
		do
		{
			try
			{
				enum1_ = smethod_1(class50_0);
				switch (enum1_)
				{
				case (Enum1)3:
				{
					uint uint_2 = class50_0.eeec9ad0[Class57.aae8806f].method_2();
					Struct2 struct2 = class50_0.c271afef.method_0(uint_2--);
					class50_0.eeec9ad0[Class57.aae8806f].method_3(uint_2);
					f215a293(class50_0, struct2.method_8());
					return enum1_;
				}
				case (Enum1)2:
				{
					uint uint_ = class50_0.eeec9ad0[Class57.aae8806f].method_2();
					Struct2 @struct = class50_0.c271afef.method_0(uint_--);
					class50_0.eeec9ad0[Class57.aae8806f].method_3(uint_);
					a32d503d(class50_0, @struct.method_8());
					break;
				}
				}
				flag = false;
			}
			catch (object object_)
			{
				fafeb304(class50_0, object_);
				flag = false;
			}
			finally
			{
				if (flag)
				{
					smethod_4(class50_0);
					enum1_ = (Enum1)1;
				}
				else if (class50_0.list_0.Count > 0)
				{
					do
					{
						smethod_3(class50_0, ref enum1_);
					}
					while (enum1_ == (Enum1)3);
				}
			}
		}
		while (enum1_ != (Enum1)1);
		return enum1_;
	}

	private static Enum1 smethod_1(Class50 class50_0)
	{
		Enum1 enum1_;
		do
		{
			byte byte_ = class50_0.method_0();
			class50_0.method_0();
			Class59.smethod_0(byte_).imethod_0(class50_0, out enum1_);
			if (class50_0.eeec9ad0[Class57.byte_6].method_0() == 1L)
			{
				enum1_ = (Enum1)1;
			}
		}
		while (enum1_ == (Enum1)0);
		return enum1_;
	}

	private static void fafeb304(Class50 class50_0, object object_0)
	{
		Class49 @class;
		if (class50_0.list_0.Count != 0)
		{
			@class = class50_0.list_0[class50_0.list_0.Count - 1];
			if (@class.c269508c.HasValue)
			{
				if (@class.ef8bd27b == (Class49.Enum0)0)
				{
					class50_0.eeec9ad0[Class57.cafba3e7].method_6(0);
				}
				else if (@class.ef8bd27b == (Class49.Enum0)1)
				{
					@class.aa68a59e = object_0;
				}
				return;
			}
		}
		@class = new Class49
		{
			ce7a4680 = class50_0.eeec9ad0[Class57.byte_5],
			struct2_0 = class50_0.eeec9ad0[Class57.aae8806f],
			aa68a59e = object_0,
			ef8bd27b = (Class49.Enum0)0,
			c269508c = null,
			c22a5065 = null
		};
		class50_0.list_0.Add(@class);
	}

	private static void f215a293(Class50 class50_0, object object_0)
	{
		if (class50_0.list_0.Count > 0)
		{
			fafeb304(class50_0, object_0);
		}
		else
		{
			a32d503d(class50_0, object_0);
		}
	}

	private unsafe static string smethod_2(Class50 class50_0)
	{
		uint num = (uint)(class50_0.eeec9ad0[Class57.byte_6].method_0() - (ulong)class50_0.class1_0.b7ea69fb().method_1());
		uint num2 = class50_0.eeec9ad0[Class57.byte_5].method_2();
		StringBuilder stringBuilder = new StringBuilder();
		do
		{
			cdfd0c1 = cdfd0c1 * 1664525 + 1013904223;
			ulong num3 = cdfd0c1 | 1u;
			stringBuilder.AppendFormat("|{0:x16}", (num * num3 << 32) | (num3 & 0xFFFFFFFFFFFFFFFEuL));
			if (num2 <= 1)
			{
				break;
			}
			num = (uint)(class50_0.c271afef.method_0(num2 - 1).method_0() - (ulong)class50_0.class1_0.b7ea69fb().method_1());
			if (!(class50_0.c271afef.method_0(num2).method_8() is a8e4b906 a8e4b907))
			{
				break;
			}
			num2 = a8e4b907.method_0();
		}
		while (num2 != 0);
		return stringBuilder.ToString(1, stringBuilder.Length - 1);
	}

	internal static void a32d503d(Class50 class50_0, object object_0)
	{
		if (object_0 is Exception)
		{
			a5cd2846.abbe23a7((Exception)object_0, null);
		}
		throw object_0;
	}

	private static void smethod_3(Class50 class50_0, ref Enum1 enum1_0)
	{
		Class49 @class = class50_0.list_0[class50_0.list_0.Count - 1];
		switch (@class.ef8bd27b)
		{
		default:
			throw new ExecutionEngineException();
		case (Class49.Enum0)0:
		{
			if (@class.c269508c.HasValue)
			{
				if (class50_0.eeec9ad0[Class57.cafba3e7].method_5() != 0)
				{
					@class.ef8bd27b = (Class49.Enum0)1;
					@class.c22a5065 = @class.c269508c;
					@class.c269508c = class50_0.e98b396e.Count;
					enum1_0 = (Enum1)0;
					goto case (Class49.Enum0)1;
				}
				@class.c269508c--;
			}
			else
			{
				@class.c269508c = class50_0.e98b396e.Count - 1;
			}
			Type type = @class.aa68a59e.GetType();
			while (true)
			{
				if (@class.c269508c >= 0 && !@class.c22a5065.HasValue)
				{
					d91f6464 d91f6465 = class50_0.e98b396e[@class.c269508c.Value];
					if (d91f6465.byte_0 != Class57.ae3b258c)
					{
						if (d91f6465.byte_0 == Class57.byte_68 && d91f6465.f09b6bd8.IsAssignableFrom(type))
						{
							break;
						}
						@class.c269508c--;
						continue;
					}
					uint num = @class.struct2_0.method_2();
					class50_0.c271afef.method_2(++num);
					d564e35d c271afef = class50_0.c271afef;
					uint uint_ = num;
					Struct2 struct2_ = default(Struct2);
					struct2_.e5a3833a(@class.aa68a59e);
					c271afef.method_1(uint_, struct2_);
					class50_0.eeec9ad0[Class57.e0cb0d84].method_6(0);
					class50_0.eeec9ad0[Class57.aae8806f].method_3(num);
					class50_0.eeec9ad0[Class57.byte_5] = d91f6465.e9637d57;
					class50_0.eeec9ad0[Class57.byte_6].method_1(d91f6465.d6fd5f36);
				}
				if (@class.c269508c == -1 && !@class.c22a5065.HasValue)
				{
					class50_0.list_0.RemoveAt(class50_0.list_0.Count - 1);
					enum1_0 = (Enum1)3;
					if (class50_0.list_0.Count == 0)
					{
						f215a293(class50_0, @class.aa68a59e);
					}
				}
				else
				{
					enum1_0 = (Enum1)0;
				}
				return;
			}
			@class.ef8bd27b = (Class49.Enum0)1;
			@class.c22a5065 = @class.c269508c;
			@class.c269508c = class50_0.e98b396e.Count;
			goto case (Class49.Enum0)1;
		}
		case (Class49.Enum0)1:
		{
			@class.c269508c--;
			int num2 = @class.c269508c.Value;
			while (num2 > @class.c22a5065.Value)
			{
				d91f6464 d91f6464_ = class50_0.e98b396e[num2];
				class50_0.e98b396e.RemoveAt(num2);
				if (d91f6464_.byte_0 != Class57.byte_69 && d91f6464_.byte_0 != Class57.byte_70)
				{
					num2--;
					continue;
				}
				smethod_5(class50_0, d91f6464_);
				break;
			}
			@class.c269508c = num2;
			if (@class.c269508c == @class.c22a5065)
			{
				d91f6464 d91f6466 = class50_0.e98b396e[@class.c22a5065.Value];
				class50_0.e98b396e.RemoveAt(@class.c22a5065.Value);
				ref Struct2 f7ebfaca = ref d91f6466.f7ebfaca;
				uint num3 = f7ebfaca.method_2();
				f7ebfaca.method_3(num3 + 1);
				class50_0.c271afef.method_2(d91f6466.f7ebfaca.method_2());
				d564e35d c271afef2 = class50_0.c271afef;
				uint uint_2 = d91f6466.f7ebfaca.method_2();
				Struct2 struct2_ = default(Struct2);
				struct2_.e5a3833a(@class.aa68a59e);
				c271afef2.method_1(uint_2, struct2_);
				class50_0.eeec9ad0[Class57.e0cb0d84].method_6(0);
				class50_0.eeec9ad0[Class57.aae8806f] = d91f6466.f7ebfaca;
				class50_0.eeec9ad0[Class57.byte_5] = d91f6466.e9637d57;
				class50_0.eeec9ad0[Class57.byte_6].method_1(d91f6466.ulong_0);
				class50_0.list_0.RemoveAt(class50_0.list_0.Count - 1);
			}
			enum1_0 = (Enum1)0;
			break;
		}
		}
	}

	private static void smethod_4(Class50 class50_0)
	{
		for (int num = class50_0.e98b396e.Count - 1; num >= 0; num--)
		{
			d91f6464 d91f6464_ = class50_0.e98b396e[num];
			if (d91f6464_.byte_0 == Class57.byte_69 || d91f6464_.byte_0 == Class57.byte_70)
			{
				smethod_5(class50_0, d91f6464_);
				smethod_0(class50_0);
			}
		}
		class50_0.e98b396e.Clear();
	}

	private static void smethod_5(Class50 class50_0, d91f6464 d91f6464_0)
	{
		ref Struct2 f7ebfaca = ref d91f6464_0.f7ebfaca;
		uint num = f7ebfaca.method_2();
		f7ebfaca.method_3(num + 1);
		class50_0.eeec9ad0[Class57.e0cb0d84].method_6(0);
		class50_0.eeec9ad0[Class57.aae8806f] = d91f6464_0.f7ebfaca;
		class50_0.eeec9ad0[Class57.byte_5] = d91f6464_0.e9637d57;
		class50_0.eeec9ad0[Class57.byte_6].method_1(d91f6464_0.ulong_0);
		d564e35d c271afef = class50_0.c271afef;
		uint uint_ = d91f6464_0.f7ebfaca.method_2();
		Struct2 struct2_ = default(Struct2);
		struct2_.method_1(1uL);
		c271afef.method_1(uint_, struct2_);
	}
}
