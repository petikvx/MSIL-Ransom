using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

internal static class Class60
{
	private enum Enum0
	{

	}

	private sealed class Class61
	{
		private Stream stream_0;

		private byte[] byte_0;

		public Class61(Stream stream_1)
		{
			stream_0 = stream_1;
			byte_0 = new byte[4];
		}

		public Stream method_0()
		{
			return stream_0;
		}

		public short method_1()
		{
			method_4(2);
			return (short)(byte_0[0] | (byte_0[1] << 8));
		}

		public int method_2()
		{
			method_4(4);
			return byte_0[0] | (byte_0[1] << 8) | (byte_0[2] << 16) | (byte_0[3] << 24);
		}

		private void method_3()
		{
			throw new EndOfStreamException();
		}

		private void method_4(int int_0)
		{
			int num = 0;
			int num2 = 0;
			if (int_0 == 1)
			{
				num2 = stream_0.ReadByte();
				if (num2 == -1)
				{
					method_3();
				}
				byte_0[0] = (byte)num2;
				return;
			}
			do
			{
				num2 = stream_0.Read(byte_0, num, int_0 - num);
				if (num2 == 0)
				{
					method_3();
				}
				num += num2;
			}
			while (num < int_0);
		}

		public void method_5()
		{
			Stream stream = stream_0;
			stream_0 = null;
			stream?.Close();
			byte_0 = null;
		}

		public byte[] method_6(int int_0)
		{
			if (int_0 < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[int_0];
			int num = 0;
			do
			{
				int num2 = stream_0.Read(array, num, int_0);
				if (num2 == 0)
				{
					break;
				}
				num += num2;
				int_0 -= num2;
			}
			while (int_0 > 0);
			if (num != array.Length)
			{
				byte[] array2 = new byte[num];
				Buffer.BlockCopy(array, 0, array2, 0, num);
				array = array2;
			}
			return array;
		}
	}

	private static byte[] byte_0;

	private static byte[] byte_1;

	private static Class61 class61_0;

	private static int int_0;

	private static Enum0 enum0_0;

	private static int int_1;

	private static short short_0;

	private static int int_2;

	private static Dictionary<int, string> dictionary_0;

	static Class60()
	{
		int num = 726760355;
		int num2 = -455067428;
		dictionary_0 = new Dictionary<int, string>(1036);
		int num3 = 2;
		StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
		num3 = 0;
		StackFrame frame = stackTrace.GetFrame(0);
		int int_ = 0;
		if (frame == null)
		{
			stackTrace = new StackTrace();
			int_ = 1;
			frame = stackTrace.GetFrame(1);
		}
		int num4 = -(~(-(~(~(-(-(~(~(0xA3AD42 ^ num ^ num2))))))))) ^ -(~(~(-(~(-(~(-(~(num + -1496031406 - num2)))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num4 ^= ~(-(~(-(-(~(~(-(~(-(~((888619715 - num) ^ num2)))))))))));
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			enum0_0 |= (Enum0)4;
			num4 ^= -1181826976 + num - num2 + num3;
		}
		else if ((object)type == null)
		{
			if (smethod_4(stackTrace, int_))
			{
				num4 ^= -(~(-(~(~(-(-(~(~(num ^ 0x304EE162 ^ num2))))))))) - num3;
				enum0_0 = (Enum0)16 | enum0_0;
			}
			else
			{
				enum0_0 |= (Enum0)1;
				num4 ^= ~(-(~(-(-(~(~(-(~(num + -1181864832 - num2)))))))));
			}
		}
		else
		{
			num4 ^= -(~(~(-(~(-(~(-(~((0x304E129E ^ num) + num2))))))))) - num3;
			enum0_0 = (Enum0)16 | enum0_0;
		}
		int_0 = num4 + int_0;
	}

	internal static string smethod_0(int int_3)
	{
		lock (dictionary_0)
		{
			if (dictionary_0.TryGetValue(int_3, out var value))
			{
				return value;
			}
			return smethod_1(int_3, bool_0: true);
		}
	}

	private static string smethod_1(int int_3, bool bool_0)
	{
		int num = -396432977;
		int num2 = 1414835546;
		string value = null;
		byte[] array;
		int num17;
		while (true)
		{
			int num3;
			if (class61_0 != null)
			{
				num3 = int_2;
			}
			else
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly callingAssembly = Assembly.GetCallingAssembly();
				int_1 |= -1016792199 + num + num2;
				StringBuilder stringBuilder = new StringBuilder();
				int num4 = (1555461897 - num) ^ num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = -481457922 + num + num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = (1555199751 - num) ^ num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = (num ^ 0x23EC9B06) + num2;
				stringBuilder.Append((char)num4).Append((char)(num4 >> 16));
				num4 = -1946491986 + num - num2;
				stringBuilder.Append((char)(num4 >> 16)).Append((char)num4);
				num4 = (1018394367 - num) ^ num2;
				stringBuilder.Append((char)num4);
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(stringBuilder.ToString());
				int num5 = 2;
				StackTrace stackTrace = new StackTrace(2, fNeedFileInfo: false);
				int_1 ^= ((num ^ 0x43F58243) + num2) | 2;
				num5 = 0;
				StackFrame frame = stackTrace.GetFrame(0);
				int int_4 = 0;
				if (frame == null)
				{
					stackTrace = new StackTrace();
					int_4 = 1;
					frame = stackTrace.GetFrame(1);
				}
				MethodBase methodBase = frame?.GetMethod();
				int_1 ^= num5 + (1018402697 - num - num2);
				Type type = methodBase?.DeclaringType;
				if (frame == null)
				{
					int_1 ^= -1018183254 + num + num2;
				}
				bool flag = (object)type == typeof(RuntimeMethodHandle);
				int_1 ^= 1018402729 - num - num2;
				if (!flag && (flag = (object)type == null))
				{
					if (smethod_4(stackTrace, int_4))
					{
						flag = false;
					}
					else
					{
						int_1 ^= num + -1018183286 + num2;
					}
				}
				if (flag == (stackTrace != null))
				{
					int_1 ^= 32;
				}
				int_1 ^= (num ^ -1140171373 ^ num2) | (1 + num5);
				class61_0 = new Class61(manifestResourceStream);
				short num6 = (short)(class61_0.method_1() ^ (short)(-(~(-(~(~(-(-(~(~(num + -1018429188 + num2)))))))))));
				if (num6 == 0)
				{
					short_0 = (short)(class61_0.method_1() ^ (short)(~(-(~(-(-(~(~(-(~(-(~(1018426350 - num - num2)))))))))))));
				}
				else
				{
					byte_0 = class61_0.method_6(num6);
				}
				callingAssembly = executingAssembly;
				AssemblyName assemblyName_ = smethod_2(callingAssembly);
				byte_1 = smethod_3(assemblyName_);
				num3 = int_0;
				int_0 = 0;
				long num7 = Class6.smethod_0();
				num3 ^= (int)num7;
				num3 ^= num + -586739984 + num2;
				num3 ^= (1070230258 - num) ^ num2;
				int num8 = (-1140177824 ^ num) - num2;
				int num9 = num3;
				int num10 = num9;
				int int_5 = num10;
				Interface4<int> enumerator = ((Interface1<int>)new Class0.Class3((-1018402571 + num) | num2)
				{
					int_4 = int_5
				}).GetEnumerator();
				try
				{
					while (enumerator.imethod_1())
					{
						int num11 = enumerator.imethod_3();
						num10 ^= num11 - num8;
						num8 -= 3 + num10 >> 8;
					}
				}
				finally
				{
					((Interface2)enumerator)?.imethod_0();
				}
				int num12 = num10;
				int num13 = (-849437855 - num + num2 + num12) ^ ((num ^ 0x7DE0C920) - num2);
				num3 ^= -(~(~(-(-(~(-(~(~((num + -1744730078) ^ num2)))))))));
				int num14 = ((1811271752 + num) ^ num2) * num13 % (-1783526846 - num + num2);
				num3 = (int_2 = num14 + num3);
				int_1 = (int_1 & (1286837883 - num - num2)) ^ (-1018395781 + num + num2);
				if (((uint)enum0_0 & (uint)(~(-(-(~(~(-(~(-(~(1018402550 - num - num2))))))))))) == 0)
				{
					int_1 = (num ^ 0x43F517CF) + num2;
				}
			}
			if (int_1 != ((1811225905 + num) ^ num2))
			{
				int num15 = int_3 ^ ((-487136341 - num) ^ num2) ^ num3;
				num15 ^= -568679030 + num - num2;
				class61_0.method_0().Position = num15;
				if (byte_0 != null)
				{
					array = byte_0;
				}
				else
				{
					short num16 = ((short_0 != -1) ? short_0 : ((short)(class61_0.method_1() ^ ((0x43F5D813 ^ num) + num2) ^ num15)));
					if (num16 == 0)
					{
						array = null;
					}
					else
					{
						array = class61_0.method_6(num16);
						for (int i = 0; i != array.Length; i++)
						{
							array[i] ^= (byte)(int_2 >> ((i & 3) << 3));
						}
					}
				}
				num17 = class61_0.method_2() ^ num15 ^ -(~(~(-(~(-(~(-(-(~(~(1158578296 - num - num2))))))))))) ^ num3;
				if (num17 != ((-1018402571 + num) | num2))
				{
					break;
				}
				byte[] array2 = class61_0.method_6(4);
				int_3 = ((num ^ 0x4B0E809A) + num2) ^ num3;
				int_3 = (array2[2] | (array2[3] << 16) | (array2[0] << 8) | (array2[1] << 24)) ^ -int_3;
				if (dictionary_0.TryGetValue(int_3, out value))
				{
					return value;
				}
				continue;
			}
			return new string(new char[3]
			{
				(char)((num ^ 0x43F5BB51) + num2),
				'0',
				(char)(1811268611 + num - num2)
			});
		}
		bool flag2 = (num17 & (-1129081079 - num - num2)) != 0;
		bool flag3 = (num17 & (num + -481531657 + num2)) != 0;
		bool flag4 = (num17 & ((-55339255 - num) ^ num2)) != 0;
		num17 &= 2079703978 + num - num2;
		byte[] array3 = array;
		byte[] array4 = class61_0.method_6(num17);
		byte[] array5 = array3;
		byte b = array5[1];
		int num18 = array4.Length;
		byte b2 = (byte)((num18 + 11) ^ (7 + b));
		uint num19 = (uint)((array5[0] | (array5[2] << 8)) + (b2 << 3));
		ushort num20 = 0;
		for (int j = 0; j < num18; j++)
		{
			if ((1 & j) == 0)
			{
				num19 = (uint)((int)num19 * (-1811054510 - num + num2) + (1813799534 + num - num2));
				num20 = (ushort)(num19 >> 16);
			}
			byte b3 = (byte)num20;
			num20 = (ushort)(num20 >> 8);
			byte b4 = array4[j];
			array4[j] = (byte)(b ^ b4 ^ (3 + b2) ^ b3);
			b2 = b4;
		}
		byte[] array6 = array4;
		if (byte_1 != null != (int_1 != -1809660709 - num + num2))
		{
			for (int k = 0; k < num17; k++)
			{
				byte b5 = byte_1[7 & k];
				b5 = (byte)((b5 << 3) | (b5 >> 5));
				array6[k] = (byte)(array6[k] ^ b5);
			}
		}
		int num21 = int_1 - 12;
		int num22;
		byte[] array7;
		if (!flag3)
		{
			num22 = num17;
			array7 = array6;
		}
		else
		{
			num22 = array6[2] | (array6[0] << 16) | (array6[3] << 8) | (array6[1] << 24);
			array7 = new byte[num22];
			smethod_5(array6, 4, array7);
		}
		if (flag2 && num21 == (num ^ -1139618673 ^ num2))
		{
			char[] array8 = new char[num22];
			for (int num23 = 0; num23 < num22; num23 = 1 + num23)
			{
				array8[num23] = (char)array7[num23];
			}
			value = new string(array8);
		}
		else
		{
			value = Encoding.Unicode.GetString(array7, 0, array7.Length);
		}
		num21 += 1018402696 - num - num2 + (3 & num21) << 5;
		if (num21 != (-1139614609 ^ num ^ num2))
		{
			int num24 = (num17 + int_3) ^ (-1810331955 - num + num2) ^ (num21 & (-1140178440 ^ num ^ num2));
			StringBuilder stringBuilder = new StringBuilder();
			int num4 = num + -1018402481 + num2;
			stringBuilder.Append((char)(byte)num4);
			value = num24.ToString(stringBuilder.ToString());
		}
		if (!flag4 && bool_0)
		{
			value = string.Intern(value);
			dictionary_0[int_3] = value;
			if (dictionary_0.Count == ((1018401541 - num) ^ num2))
			{
				class61_0.method_5();
				class61_0 = null;
				byte_0 = null;
				byte_1 = null;
			}
		}
		return value;
	}

	private static AssemblyName smethod_2(Assembly assembly_0)
	{
		try
		{
			return assembly_0.GetName();
		}
		catch
		{
			return new AssemblyName(assembly_0.FullName);
		}
	}

	private static byte[] smethod_3(AssemblyName assemblyName_0)
	{
		byte[] array = assemblyName_0.GetPublicKeyToken();
		if (array != null && array.Length == 0)
		{
			array = null;
		}
		return array;
	}

	private static bool smethod_4(StackTrace stackTrace_0, int int_3)
	{
		Assembly assembly = stackTrace_0.GetFrame(int_3 + 1)?.GetMethod()?.DeclaringType?.Assembly;
		if ((object)assembly != null)
		{
			AssemblyName assemblyName_ = smethod_2(assembly);
			byte[] array = smethod_3(assemblyName_);
			if (array != null && array.Length == 8 && array[0] == 183 && array[7] == 137)
			{
				return true;
			}
		}
		return false;
	}

	private static void smethod_5(byte[] byte_2, int int_3, byte[] byte_3)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 128;
		int num4 = byte_3.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = byte_2[int_3++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (byte_2[int_3] >> 2) + 3;
				int num6 = ((byte_2[int_3] << 8) | byte_2[int_3 + 1]) & 0x3FF;
				int_3 += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					byte_3[num++] = byte_3[num7++];
				}
			}
			else
			{
				byte_3[num++] = byte_2[int_3++];
			}
		}
	}
}
