using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Dlsbdzokygwszrbyphdiuxiy;

internal static class k
{
	private enum a
	{

	}

	private sealed class b
	{
		private Stream m_a;

		private byte[] m_b;

		public b(Stream a)
		{
			if (5u != 0)
			{
				this.m_a = a;
			}
			byte[] array = new byte[4];
			if (2u != 0)
			{
				m_b = array;
			}
		}

		public Stream a()
		{
			_ = 5;
			if (2 == 0)
			{
			}
			return this.m_a;
		}

		public short a()
		{
			if (uint.MaxValue != 0)
			{
				this.a(2);
			}
			return (short)(m_b[0] | (m_b[1] << 8));
		}

		public int a()
		{
			if (8u != 0)
			{
				this.a(4);
			}
			return m_b[0] | (m_b[1] << 8) | (m_b[2] << 16) | (m_b[3] << 24);
		}

		private static void a()
		{
			throw new EndOfStreamException();
		}

		private void a(int a)
		{
			int num = default(int);
			if (0 == 0)
			{
				num = 0;
			}
			if (true)
			{
				int num2 = 0;
			}
			if (a == 1)
			{
				int num3 = this.m_a.ReadByte();
				int num2;
				if (8u != 0)
				{
					num2 = num3;
				}
				if (num2 == -1)
				{
					k.b.a();
				}
				m_b[0] = (byte)num2;
				return;
			}
			do
			{
				int num2 = this.m_a.Read(m_b, num, a - num);
				if (num2 == 0)
				{
					k.b.a();
				}
				num += num2;
			}
			while (num < a);
		}

		public void a()
		{
			Stream stream = this.m_a;
			Stream stream2;
			if (7u != 0)
			{
				stream2 = stream;
			}
			if (uint.MaxValue != 0)
			{
				this.m_a = null;
			}
			stream2?.Close();
			if (true)
			{
				m_b = null;
			}
		}

		public byte[] a(int a)
		{
			if (a < 0)
			{
				throw new ArgumentOutOfRangeException();
			}
			byte[] array = new byte[a];
			byte[] array2;
			if (3u != 0)
			{
				array2 = array;
			}
			int num;
			if (6u != 0)
			{
				num = 0;
			}
			do
			{
				int num2 = this.m_a.Read(array2, num, a);
				int num3;
				if (2u != 0)
				{
					num3 = num2;
				}
				if (num3 == 0)
				{
					break;
				}
				num += num3;
				a -= num3;
			}
			while (a > 0);
			if (num != array2.Length)
			{
				byte[] array3 = new byte[num];
				Buffer.BlockCopy(array2, 0, array3, 0, num);
				array2 = array3;
			}
			return array2;
		}
	}

	private static int e;

	private static byte[] c;

	private static byte[] f;

	private static a i;

	private static short d;

	private static int g;

	private static b m_b;

	private static ConcurrentDictionary<int, string> m_a;

	private static int h;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static k()
	{
		int num;
		if (5u != 0)
		{
			num = -1974570844;
		}
		int num2 = -19290422 - num;
		int num3;
		if (7u != 0)
		{
			num3 = num2;
		}
		ConcurrentDictionary<int, string> concurrentDictionary = new ConcurrentDictionary<int, string>();
		if (3u != 0)
		{
			k.m_a = concurrentDictionary;
		}
		int num4;
		if (7u != 0)
		{
			num4 = 2;
		}
		StackTrace stackTrace = new StackTrace(num4, fNeedFileInfo: false);
		StackTrace stackTrace2 = default(StackTrace);
		if (0 == 0)
		{
			stackTrace2 = stackTrace;
		}
		int num5 = num4 - 2;
		if (5u != 0)
		{
			num4 = num5;
		}
		StackFrame frame = stackTrace2.GetFrame(num4);
		int index = num4;
		if (frame == null)
		{
			stackTrace2 = new StackTrace();
			index = 1;
			frame = stackTrace2.GetFrame(index);
		}
		int num6 = -(~(-(~(~(-(~(-(-(~(~(num + 1281967514 + num3))))))))))) ^ -(~(-(~(-(~(~(-(~(-333494041 - num - num3)))))))));
		MethodBase methodBase = frame?.GetMethod();
		if (frame != null)
		{
			num6 ^= -(~(-(~(~(-(-(~(~((259966339 + num) ^ num3)))))))));
		}
		Type type = methodBase?.DeclaringType;
		if (type == typeof(RuntimeMethodHandle))
		{
			i = (a)4 | i;
			num6 ^= (0x13ABDA5 ^ num) + num3 + num4;
		}
		else if (type == null)
		{
			if (a(stackTrace2, index))
			{
				num6 ^= ~(-(-(~(~(-(~(-(~(-19314461 - num - num3))))))))) - num4;
				i = (a)16 | i;
			}
			else
			{
				i |= (a)1;
				num6 ^= -(~(-(~(-(~(~(-(~((0x13A4981 ^ num) + num3)))))))));
			}
		}
		else
		{
			i = (a)16 | i;
			num6 ^= -(~(-(~(~(-(-(~(-(~(~((365102300 - num) ^ num3))))))))))) - num4;
		}
		h = num6 + h;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static string a(int a)
	{
		ConcurrentDictionary<int, string> concurrentDictionary = k.m_a;
		_ = -1;
		if (8 == 0)
		{
		}
		if (concurrentDictionary.TryGetValue(a, out var value))
		{
			string result = value;
			_ = 6;
			if (8 == 0)
			{
			}
			return result;
		}
		_ = 0;
		if (4 == 0)
		{
		}
		return k.a(a, b: true);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static string a(int a, bool b)
	{
		int num;
		if (4u != 0)
		{
			num = -1243520275;
		}
		int num2 = 687941712 - num;
		int num3 = default(int);
		if (0 == 0)
		{
			num3 = num2;
		}
		string value;
		if (2u != 0)
		{
			value = null;
		}
		byte[] array;
		int num20;
		int num21;
		int num22;
		int num23;
		byte[] array3;
		byte[] array2;
		int num24;
		while (true)
		{
			bool lockTaken;
			if (6u != 0)
			{
				lockTaken = false;
			}
			ConcurrentDictionary<int, string> concurrentDictionary = k.m_a;
			ConcurrentDictionary<int, string> obj;
			if (4u != 0)
			{
				obj = concurrentDictionary;
			}
			try
			{
				if (3u != 0)
				{
					Monitor.Enter(obj, ref lockTaken);
				}
				int num8;
				if (k.m_b == null)
				{
					Assembly executingAssembly = Assembly.GetExecutingAssembly();
					Assembly assembly;
					if (6u != 0)
					{
						assembly = executingAssembly;
					}
					Assembly callingAssembly = Assembly.GetCallingAssembly();
					Assembly assembly2;
					if (0 == 0)
					{
						assembly2 = callingAssembly;
					}
					int num4 = e | ((-958843640 ^ num) - num3);
					if (5u != 0)
					{
						e = num4;
					}
					StringBuilder stringBuilder = new StringBuilder();
					StringBuilder stringBuilder2;
					if (4u != 0)
					{
						stringBuilder2 = stringBuilder;
					}
					int num5 = (150358094 - num) ^ num3;
					stringBuilder2.Append((char)(num5 >> 16)).Append((char)num5);
					num5 = (num ^ 0x26C28785) - num3;
					stringBuilder2.Append((char)(num5 >> 16)).Append((char)num5);
					num5 = (num + -1657372036) ^ num3;
					stringBuilder2.Append((char)num5).Append((char)(num5 >> 16));
					num5 = (0x26C38789 ^ num) - num3;
					stringBuilder2.Append((char)num5).Append((char)(num5 >> 16));
					num5 = -687933515 + num + num3;
					stringBuilder2.Append((char)num5);
					Stream manifestResourceStream = assembly.GetManifestResourceStream(stringBuilder2.ToString());
					int num6 = 2;
					StackTrace stackTrace = new StackTrace(num6, fNeedFileInfo: false);
					e ^= ((687947538 - num) ^ num3) | num6;
					num6 -= 2;
					StackFrame frame = stackTrace.GetFrame(num6);
					int index = num6;
					if (frame == null)
					{
						stackTrace = new StackTrace();
						index = 1;
						frame = stackTrace.GetFrame(index);
					}
					MethodBase methodBase = frame?.GetMethod();
					e ^= num6 + (-687941584 + num + num3);
					Type type = methodBase?.DeclaringType;
					if (frame == null)
					{
						e ^= 688161027 - num - num3;
					}
					bool flag = type == typeof(RuntimeMethodHandle);
					e ^= num + -687941552 + num3;
					if (!flag)
					{
						flag = type == null;
						if (flag)
						{
							if (k.a(stackTrace, index))
							{
								flag = false;
							}
							else
							{
								e ^= (-960332005 ^ num) - num3;
							}
						}
					}
					if (flag == (stackTrace != null))
					{
						e = 0x20 ^ e;
					}
					e ^= (-687935210 + num + num3) | (num6 + 1);
					k.m_b = new b(manifestResourceStream);
					short num7 = (short)(k.m_b.a() ^ (short)(~(-(-(~(~(-(~(-(~(-(~(-956395966 ^ num ^ num3)))))))))))));
					if (num7 == 0)
					{
						d = (short)(k.m_b.a() ^ (short)(-(~(-(~(-(~(~(-(~(-(~(687940150 - num - num3)))))))))))));
					}
					else
					{
						c = k.m_b.a(num7);
					}
					assembly2 = assembly;
					AssemblyName assemblyName = k.a(assembly2);
					f = k.a(assemblyName);
					num8 = h;
					num8 ^= num + 971453012 + num3;
					h = 0;
					long num9 = m.a();
					num8 ^= (int)num9;
					num8 ^= 1607468749 - num - num3;
					num8 ^= (num + -1170241907) ^ num3;
					int num10 = num8;
					int num11 = num10;
					int num12 = (num11 + ((-1758544825 ^ num) - num3)) ^ ((num + 418899081) ^ num3);
					int num13 = ((-956385027 ^ num) - num3) * num12 % ((681175931 - num) ^ num3);
					int num14 = 0;
					int num15 = num13;
					Dlsbdzokygwszrbyphdiuxiy.f<int> enumerator = ((Dlsbdzokygwszrbyphdiuxiy.c<int>)new Dlsbdzokygwszrbyphdiuxiy.a.b(num + -687941714 + num3)
					{
						j = num15
					}).GetEnumerator();
					try
					{
						while (((d)enumerator).zf2q78n7ba5trmcrxdajry2y6angsfasI9Na())
						{
							int num16 = enumerator.zf2q78n7ba5trmcrxdajry2y6angsfasI9Na();
							num13 ^= num14 + num16;
							num14 += num13 >> 3;
						}
					}
					finally
					{
						enumerator?.z4pbymtdqwf8pvs84u8dtbna43p3gkh6I9Na();
					}
					num8 ^= -(~(~(-(-(~(-(~(~((1557295221 - num) ^ num3)))))))));
					int num17 = num13;
					num8 = (g = num8 + num17);
					e = (e & (-419506398 + num + num3)) ^ ((687948500 - num) ^ num3);
					if (((uint)i & (uint)(-(~(~(-(~(-(-(~(-(~(~(num + -687941728 + num3))))))))))))) == 0)
					{
						e = 687985674 - num - num3;
					}
				}
				else
				{
					num8 = g;
				}
				if (e == (-956429260 ^ num ^ num3))
				{
					value = new string(new char[3]
					{
						(char)(-687941624 + num + num3),
						'0',
						(char)(0xC6FEA7D6u ^ (uint)num ^ (uint)num3)
					});
					return value;
				}
				int num18 = a ^ (-610569910 - num + num3) ^ num8;
				num18 ^= (num + -1684436150) ^ num3;
				k.m_b.a().Position = num18;
				if (c != null)
				{
					array = c;
				}
				else
				{
					short num19 = ((d != -1) ? d : ((short)(k.m_b.a() ^ (1119971500 - num + num3) ^ num18)));
					if (num19 == 0)
					{
						array = null;
					}
					else
					{
						array = k.m_b.a(num19);
						for (int n = 0; n != array.Length; n++)
						{
							array[n] ^= (byte)(g >> ((3 & n) << 3));
						}
					}
				}
				num20 = k.m_b.a() ^ num18 ^ ~(-(-(~(~(-(~(-(~(num + -2031109931 - num3))))))))) ^ num8;
				if (num20 != 1119985032 - num + num3)
				{
					num21 = e;
					num22 = -1118377220 + num - num3;
					num23 = num20;
					num24 = num21 - 12;
					num20 &= num ^ -922658703 ^ num3;
					array2 = k.m_b.a(num20);
					array3 = f;
					break;
				}
				byte[] array4 = k.m_b.a(4);
				a = -256897520 ^ num ^ num3 ^ num8;
				a = (array4[2] | (array4[3] << 16) | (array4[0] << 8) | (array4[1] << 24)) ^ -a;
			}
			finally
			{
				if (lockTaken)
				{
					Monitor.Exit(obj);
				}
			}
			if (k.m_a.TryGetValue(a, out value))
			{
				return value;
			}
		}
		bool flag2 = (num23 & (num + -583114122 - num3)) != 0;
		bool flag3 = (num23 & ((0x79015870 ^ num) + num3)) != 0;
		bool flag4 = (num23 & (-1459541936 - num - num3)) != 0;
		byte[] array5 = array;
		byte[] array6 = array2;
		byte[] array7 = array5;
		byte b2 = array7[1];
		int num25 = array6.Length;
		byte b3 = (byte)((11 + num25) ^ (7 + b2));
		uint num26 = (uint)((array7[0] | (array7[2] << 8)) + (b3 << 3));
		ushort num27 = 0;
		for (int num28 = 0; num28 < num25; num28 = 1 + num28)
		{
			if ((1 & num28) == 0)
			{
				num26 = (uint)((int)num26 * (-956439437 ^ num ^ num3) + (num + -685410701 + num3));
				num27 = (ushort)(num26 >> 16);
			}
			byte b4 = (byte)num27;
			num27 = (ushort)(num27 >> 8);
			byte b5 = array6[num28];
			array6[num28] = (byte)(b5 ^ b2 ^ (3 + b3) ^ b4);
			b3 = b5;
		}
		array2 = array6;
		if (array3 != null != (num22 != num21))
		{
			for (int num29 = 0; num29 < num20; num29 = 1 + num29)
			{
				byte b6 = array3[7 & num29];
				b6 = (byte)((b6 << 3) | (b6 >> 5));
				array2[num29] = (byte)(array2[num29] ^ b6);
			}
		}
		int num30;
		byte[] array8;
		if (!flag3)
		{
			num30 = num20;
			array8 = array2;
		}
		else
		{
			num30 = array2[2] | (array2[0] << 16) | (array2[3] << 8) | (array2[1] << 24);
			array8 = new byte[num30];
			k.a(array2, 4, array8);
		}
		if (flag2 && num24 == num22 - 12)
		{
			char[] array9 = new char[num30];
			for (int num31 = 0; num31 < num30; num31 = 1 + num31)
			{
				array9[num31] = (char)array8[num31];
			}
			value = new string(array9);
		}
		else
		{
			value = Encoding.Unicode.GetString(array8, 0, array8.Length);
		}
		num24 += 687941839 - num - num3 + (3 & num24) << 5;
		if (num24 != num22 - 12 + (-687941585 + num + num3 + ((num22 - 12) & 3) << 5))
		{
			int num32 = (a + num20) ^ (688878280 - num - num3) ^ (num24 & (-687940419 + num + num3));
			StringBuilder stringBuilder2 = new StringBuilder();
			int num5 = 687941800 - num - num3;
			stringBuilder2.Append((char)(byte)num5);
			value = num32.ToString(stringBuilder2.ToString());
		}
		if (!flag4 && b)
		{
			value = string.Intern(value);
			k.m_a[a] = value;
			if (k.m_a.Count == 11)
			{
				lock (k.m_a)
				{
					k.m_b.a();
					k.m_b = null;
					c = null;
					f = null;
					return value;
				}
			}
		}
		return value;
	}

	private static AssemblyName a(Assembly a)
	{
		AssemblyName result = default(AssemblyName);
		try
		{
			AssemblyName name = a.GetName();
			if (5u != 0)
			{
				result = name;
				return result;
			}
			return result;
		}
		catch
		{
			AssemblyName result2 = new AssemblyName(a.FullName);
			if (0 == 0)
			{
				return result2;
			}
			return result;
		}
	}

	private static byte[] a(AssemblyName a)
	{
		byte[]? publicKeyToken = a.GetPublicKeyToken();
		byte[] array;
		if (uint.MaxValue != 0)
		{
			array = publicKeyToken;
		}
		if (array != null && array.Length == 0)
		{
			if (7u != 0)
			{
				array = null;
			}
		}
		return array;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool a(StackTrace a, int b)
	{
		int num = b + 1;
		if (uint.MaxValue != 0)
		{
			b = num;
		}
		StackFrame? frame = a.GetFrame(num);
		StackFrame stackFrame;
		if (8u != 0)
		{
			stackFrame = frame;
		}
		Assembly obj = stackFrame?.GetMethod()?.DeclaringType?.Assembly;
		Assembly assembly;
		if (uint.MaxValue != 0)
		{
			assembly = obj;
		}
		if (assembly != null)
		{
			AssemblyName assemblyName = k.a(assembly);
			byte[] array = k.a(assemblyName);
			if (array != null && array.Length == 8 && array[0] == 183 && array[7] == 137)
			{
				return true;
			}
		}
		while (true)
		{
			stackFrame = a.GetFrame(++b);
			if (stackFrame == null)
			{
				break;
			}
			assembly = stackFrame.GetMethod()?.DeclaringType?.Assembly;
			if (assembly != null && assembly == typeof(k).Assembly)
			{
				return true;
			}
		}
		return false;
	}

	private static void a(byte[] a, int b, byte[] c)
	{
		int num;
		if (4u != 0)
		{
			num = 0;
		}
		int num2;
		if (8u != 0)
		{
			num2 = 0;
		}
		int num3;
		if (8u != 0)
		{
			num3 = 128;
		}
		int num4 = c.Length;
		while (num < num4)
		{
			if ((num3 <<= 1) == 256)
			{
				num3 = 1;
				num2 = a[b++];
			}
			if ((num2 & num3) != 0)
			{
				int num5 = (a[b] >> 2) + 3;
				int num6 = ((a[b] << 8) | a[b + 1]) & 0x3FF;
				b += 2;
				int num7 = num - num6;
				if (num7 < 0)
				{
					break;
				}
				while (--num5 >= 0 && num < num4)
				{
					c[num++] = c[num7++];
				}
			}
			else
			{
				c[num++] = a[b++];
			}
		}
	}
}
