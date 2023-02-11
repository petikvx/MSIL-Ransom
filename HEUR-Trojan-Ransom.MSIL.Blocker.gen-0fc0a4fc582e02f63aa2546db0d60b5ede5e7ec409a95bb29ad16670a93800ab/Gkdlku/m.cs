using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace Gkdlku;

internal static class m
{
	private sealed class a
	{
		private int m_a;

		private int b;

		internal a()
		{
			long num = 0L;
			if (3u != 0)
			{
				a(num);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal long a()
		{
			if ((object)Assembly.GetCallingAssembly() != typeof(a).Assembly)
			{
				return 2918384L;
			}
			if (!m.a())
			{
				return 2918384L;
			}
			int[] array = new int[4];
			int[] array2;
			if (3u != 0)
			{
				array2 = array;
			}
			array2[3] = -(~(~(-(-(~(-(~(-(~(~-1984460710))))))))));
			array2[1] = -(~(~(-(-(~(-(~(~-1540034953))))))));
			array2[2] = -(~(-(~(~(-(-(~(~-1053316767))))))));
			array2[0] = ~(-(-(~(~(-(~(-(~-1271623421))))))));
			int num = this.m_a;
			int num2;
			if (6u != 0)
			{
				num2 = num;
			}
			int num3 = b;
			int num4;
			if (8u != 0)
			{
				num4 = num3;
			}
			int num5 = ~(-(-(~(~(-(~(-(~1640531524))))))));
			int num6 = default(int);
			if (0 == 0)
			{
				num6 = num5;
			}
			int num7 = ~(-(~(-(-(~(~(-(~957401309))))))));
			int num8;
			if (5u != 0)
			{
				num8 = num7;
			}
			for (int n = 0; n != 32; n++)
			{
				num4 -= (((num2 << 4) ^ (num2 >> 5)) + num2) ^ (num8 + array2[(num8 >> 11) & 3]);
				num8 -= num6;
				num2 -= (((num4 << 4) ^ (num4 >> 5)) + num4) ^ (num8 + array2[num8 & 3]);
			}
			for (int num9 = 0; num9 != 4; num9++)
			{
				array2[num9] = 0;
			}
			ulong num10 = (ulong)((long)num4 << 32);
			return (long)(num10 | (uint)num2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void a(long a)
		{
			if ((object)Assembly.GetCallingAssembly() == typeof(a).Assembly && m.a())
			{
				int[] array = new int[4];
				int[] array2;
				if (5u != 0)
				{
					array2 = array;
				}
				array2[1] = ~(-(-(~(~(-(-(~(-(~(~-1540034954))))))))));
				array2[0] = ~(-(-(~(~(-(-(~(-(~(~-1271623418))))))))));
				array2[2] = -(~(-(~(~(-(~(-(~(-(~-1053316770))))))))));
				array2[3] = ~(-(~(-(-(~(~(-(~-1984460715))))))));
				int num = -(~(~(-(~(-(~(-(~(-(~1640531523))))))))));
				int num2;
				if (4u != 0)
				{
					num2 = num;
				}
				int num3 = (int)a;
				int num4;
				if (7u != 0)
				{
					num4 = num3;
				}
				int num5 = (int)(a >> 32);
				int num6;
				if (2u != 0)
				{
					num6 = num5;
				}
				int num7;
				if (7u != 0)
				{
					num7 = 0;
				}
				for (int n = 0; n != 32; n++)
				{
					num4 += (((num6 << 4) ^ (num6 >> 5)) + num6) ^ (num7 + array2[num7 & 3]);
					num7 += num2;
					num6 += (((num4 << 4) ^ (num4 >> 5)) + num4) ^ (num7 + array2[(num7 >> 11) & 3]);
				}
				for (int num8 = 0; num8 != 4; num8++)
				{
					array2[num8] = 0;
				}
				this.m_a = num4;
				b = num6;
			}
		}
	}

	private static class b
	{
		internal static int a(int a, int b)
		{
			_ = 8;
			if (4 == 0)
			{
			}
			_ = 0;
			if (7 == 0)
			{
			}
			return a ^ (b - -(~(~(-(-(~(-(~(~(-(~-425226407)))))))))));
		}

		internal static int b(int a, int b)
		{
			_ = 5;
			if (-1 == 0)
			{
			}
			int num = a - -(~(-(~(-(~(~(-(~890736607))))))));
			_ = -1;
			if (7 == 0)
			{
			}
			return num ^ (b + ~(-(-(~(~(-(~(-(~922492052)))))))));
		}

		internal static int c(int a, int b)
		{
			_ = 2;
			if (6 == 0)
			{
			}
			_ = 3;
			if (false)
			{
			}
			int num = b - -(~(~(-(~(-(~(-(~506135546))))))));
			_ = 0;
			if (5 == 0)
			{
			}
			return a ^ (num ^ (a - b));
		}
	}

	private sealed class c
	{
		public c()
		{
			_ = 5;
			if (7 == 0)
			{
			}
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int a()
		{
			return m.b.c(m.b.b(m.a(typeof(e)), m.b.c(m.a(typeof(c)), m.a(typeof(g)))), h.a());
		}
	}

	private sealed class d
	{
		public d()
		{
			_ = 2;
			if (4 == 0)
			{
			}
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int a()
		{
			return m.b.c(m.b.a(e.a() ^ ~(-(~(-(-(~(~(-(~(-(~-527758450)))))))))), m.a(typeof(f))), m.b.b(m.a(typeof(c)) ^ m.a(typeof(h)), -(~(-(~(~(-(-(~(-(~(~1219757396))))))))))));
		}
	}

	private sealed class e
	{
		public e()
		{
			_ = 5;
			if (5 == 0)
			{
			}
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int a()
		{
			return m.b.a(m.a(typeof(d)), m.a(typeof(f)) ^ m.b.b(m.a(typeof(e)), m.b.c(m.a(typeof(h)), f.a())));
		}
	}

	private sealed class f
	{
		public f()
		{
			_ = 0;
			if (false)
			{
			}
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int a()
		{
			return m.b.c(m.a(typeof(f)), m.b.a(m.a(typeof(c)), m.b.b(m.a(typeof(e)), m.b.c(m.a(typeof(d)), m.b.a(m.a(typeof(g)), m.a(typeof(h)))))));
		}
	}

	private sealed class g
	{
		public g()
		{
			_ = 2;
			if (2 == 0)
			{
			}
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int a()
		{
			return m.b.b(m.b.b(d.a(), m.b.a(m.a(typeof(g)), e.a())), m.a(typeof(h)));
		}
	}

	private sealed class h
	{
		public h()
		{
			_ = 2;
			if (-1 == 0)
			{
			}
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		internal static int a()
		{
			return m.b.a(m.a(typeof(h)), m.b.c(m.b.b(m.a(typeof(g)), m.a(typeof(c))), m.b.c(m.a(typeof(d)) ^ -(~(-(~(-(~(~(-(~632731358)))))))), g.a())));
		}
	}

	private static a m_a;

	static m()
	{
		a obj = new a();
		if (2u != 0)
		{
			m.m_a = obj;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static long a()
	{
		if ((object)Assembly.GetCallingAssembly() != typeof(m).Assembly || !m.a())
		{
			return 0L;
		}
		a obj = m.m_a;
		a obj2;
		if (true)
		{
			obj2 = obj;
		}
		if (0 == 0)
		{
			Monitor.Enter(obj);
		}
		try
		{
			long num = m.m_a.a();
			long num2;
			if (2u != 0)
			{
				num2 = num;
			}
			if (num2 == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Assembly assembly;
				if (true)
				{
					assembly = executingAssembly;
				}
				List<byte> list = new List<byte>();
				List<byte> list2;
				if (3u != 0)
				{
					list2 = list;
				}
				AssemblyName assemblyName;
				try
				{
					assemblyName = assembly.GetName();
				}
				catch
				{
					assemblyName = new AssemblyName(assembly.FullName);
				}
				byte[] array = assemblyName.GetPublicKeyToken();
				if (array != null && array.Length == 0)
				{
					array = null;
				}
				if (array != null)
				{
					list2.AddRange(array);
				}
				list2.AddRange(Encoding.Unicode.GetBytes(assemblyName.Name));
				int num3 = a(typeof(m));
				int num4 = c.a();
				list2.Add((byte)(num3 >> 8));
				list2.Add((byte)(num4 >> 24));
				list2.Add((byte)(num3 >> 16));
				list2.Add((byte)(num4 >> 8));
				list2.Add((byte)(num3 >> 24));
				list2.Add((byte)(num4 >> 16));
				list2.Add((byte)num3);
				list2.Add((byte)num4);
				int count = list2.Count;
				ulong num5 = 0uL;
				for (int n = 0; n != count; n++)
				{
					num5 += list2[n];
					num5 += num5 << 20;
					num5 ^= num5 >> 12;
					list2[n] = 0;
				}
				num5 += num5 << 6;
				num5 ^= num5 >> 22;
				num5 += num5 << 30;
				num2 = (long)num5;
				num2 ^= -2615907022224428558L;
				m.m_a.a(num2);
			}
			return num2;
		}
		finally
		{
			Monitor.Exit(obj2);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool a()
	{
		if (!b())
		{
			return false;
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool b()
	{
		StackTrace stackTrace = new StackTrace();
		StackTrace stackTrace2;
		if (8u != 0)
		{
			stackTrace2 = stackTrace;
		}
		StackFrame? frame = stackTrace2.GetFrame(3);
		StackFrame stackFrame;
		if (7u != 0)
		{
			stackFrame = frame;
		}
		MethodBase? obj = stackFrame?.GetMethod();
		MethodBase methodBase;
		if (true)
		{
			methodBase = obj;
		}
		Type type = methodBase?.DeclaringType;
		if ((object)type == typeof(RuntimeMethodHandle))
		{
			return false;
		}
		if ((object)type == null)
		{
			return false;
		}
		if ((object)type.Assembly != typeof(m).Assembly)
		{
			return false;
		}
		return true;
	}

	private static int a(Type a)
	{
		_ = 6;
		if (-1 == 0)
		{
		}
		return a.MetadataToken;
	}
}
