using System.IO;
using ns0;

namespace ns1;

internal static class Class23
{
	internal sealed class Class24
	{
		internal static readonly int[] int_0 = new int[29]
		{
			3, 4, 5, 6, 7, 8, 9, 10, 11, 13,
			15, 17, 19, 23, 27, 31, 35, 43, 51, 59,
			67, 83, 99, 115, 131, 163, 195, 227, 258
		};

		internal static readonly int[] int_1 = new int[29]
		{
			0, 0, 0, 0, 0, 0, 0, 0, 1, 1,
			1, 1, 2, 2, 2, 2, 3, 3, 3, 3,
			4, 4, 4, 4, 5, 5, 5, 5, 0
		};

		internal static readonly int[] int_2 = new int[30]
		{
			1, 2, 3, 4, 5, 7, 9, 13, 17, 25,
			33, 49, 65, 97, 129, 193, 257, 385, 513, 769,
			1025, 1537, 2049, 3073, 4097, 6145, 8193, 12289, 16385, 24577
		};

		internal static readonly int[] int_3 = new int[30]
		{
			0, 0, 0, 0, 1, 1, 2, 2, 3, 3,
			4, 4, 5, 5, 6, 6, 7, 7, 8, 8,
			9, 9, 10, 10, 11, 11, 12, 12, 13, 13
		};

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal int int_8;

		internal bool bool_0;

		internal Class25 class25_0;

		internal Class26 class26_0;

		internal Class28 class28_0;

		internal Class27 class27_0;

		internal Class27 class27_1;

		public Class24(byte[] byte_0)
		{
			class25_0 = new Class25();
			class26_0 = new Class26();
			int_4 = 2;
			Class21.smethod_28(byte_0.Length, class25_0, byte_0, 0);
		}
	}

	internal sealed class Class25
	{
		internal byte[] byte_0;

		internal int int_0;

		internal int int_1;

		internal uint uint_0;

		internal int int_2;
	}

	internal sealed class Class26
	{
		internal byte[] byte_0 = new byte[32768];

		internal int int_0;

		internal int int_1;
	}

	internal sealed class Class27
	{
		internal short[] short_0;

		public static readonly Class27 class27_0;

		public static readonly Class27 class27_1;

		static Class27()
		{
			byte[] array = new byte[288];
			int num = 0;
			while (num < 144)
			{
				array[num++] = 8;
			}
			while (num < 256)
			{
				array[num++] = 9;
			}
			while (num < 280)
			{
				array[num++] = 7;
			}
			while (num < 288)
			{
				array[num++] = 8;
			}
			class27_0 = new Class27(array);
			array = new byte[32];
			num = 0;
			while (num < 32)
			{
				array[num++] = 5;
			}
			class27_1 = new Class27(array);
		}

		public Class27(byte[] byte_0)
		{
			Class21.smethod_16(this, byte_0);
		}
	}

	internal sealed class Class28
	{
		internal static readonly int[] int_0 = new int[3] { 3, 3, 11 };

		internal static readonly int[] int_1 = new int[3] { 2, 3, 7 };

		internal byte[] byte_0;

		internal byte[] byte_1;

		internal Class27 class27_0;

		internal int int_2;

		internal int int_3;

		internal int int_4;

		internal int int_5;

		internal int int_6;

		internal int int_7;

		internal byte byte_2;

		internal int int_8;

		internal static readonly int[] int_9 = new int[19]
		{
			16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
			11, 4, 12, 3, 13, 2, 14, 1, 15
		};
	}

	internal sealed class Class29
	{
		private static readonly int[] int_0;

		internal static readonly byte[] byte_0;

		private static readonly short[] short_0;

		private static readonly byte[] byte_1;

		private static readonly short[] short_1;

		private static readonly byte[] byte_2;

		static Class29()
		{
			int_0 = new int[19]
			{
				16, 17, 18, 0, 8, 7, 9, 6, 10, 5,
				11, 4, 12, 3, 13, 2, 14, 1, 15
			};
			byte_0 = new byte[16]
			{
				0, 8, 4, 12, 2, 10, 6, 14, 1, 9,
				5, 13, 3, 11, 7, 15
			};
			short_0 = new short[286];
			byte_1 = new byte[286];
			int num = 0;
			while (num < 144)
			{
				short_0[num] = Class21.smethod_38(48 + num << 8);
				byte_1[num++] = 8;
			}
			while (num < 256)
			{
				short_0[num] = Class21.smethod_38(256 + num << 7);
				byte_1[num++] = 9;
			}
			while (num < 280)
			{
				short_0[num] = Class21.smethod_38(-256 + num << 9);
				byte_1[num++] = 7;
			}
			while (num < 286)
			{
				short_0[num] = Class21.smethod_38(-88 + num << 8);
				byte_1[num++] = 8;
			}
			short_1 = new short[30];
			byte_2 = new byte[30];
			for (num = 0; num < 30; num++)
			{
				short_1[num] = Class21.smethod_38(num << 11);
				byte_2[num] = 5;
			}
		}
	}

	internal sealed class Stream0 : MemoryStream
	{
		public Stream0(byte[] byte_0)
			: base(byte_0, writable: false)
		{
		}
	}
}
