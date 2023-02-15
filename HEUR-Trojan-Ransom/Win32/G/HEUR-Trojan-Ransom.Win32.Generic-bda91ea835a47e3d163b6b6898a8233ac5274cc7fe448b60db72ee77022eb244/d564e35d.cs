using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

internal class d564e35d
{
	private class e95c01f
	{
		public uint uint_0;

		public IntPtr intptr_0;

		public e95c01f f3ce1dc3;

		protected override void ff44e6bb()
		{
			try
			{
				if (intptr_0 != IntPtr.Zero)
				{
					Marshal.FreeHGlobal(intptr_0);
					intptr_0 = IntPtr.Zero;
				}
			}
			finally
			{
				base.Finalize();
			}
		}

		public e95c01f method_0()
		{
			if (intptr_0 != IntPtr.Zero)
			{
				Marshal.FreeHGlobal(intptr_0);
				intptr_0 = IntPtr.Zero;
			}
			return f3ce1dc3;
		}
	}

	private e95c01f e95c01f_0;

	private readonly List<Struct2[]> d49faea5 = new List<Struct2[]>();

	private uint b63d8fc0;

	[SpecialName]
	public Struct2 method_0(uint uint_0)
	{
		if (uint_0 > b63d8fc0)
		{
			return Struct2.struct2_0;
		}
		uint index = uint_0 >> 6;
		return d49faea5[(int)index][uint_0 & 0x3F];
	}

	[SpecialName]
	public void method_1(uint uint_0, Struct2 struct2_0)
	{
		if (uint_0 <= b63d8fc0)
		{
			uint index = uint_0 >> 6;
			d49faea5[(int)index][uint_0 & 0x3F] = struct2_0;
		}
	}

	public void method_2(uint uint_0)
	{
		if (uint_0 > int.MaxValue)
		{
			throw new StackOverflowException();
		}
		uint num = uint_0 >> 6;
		if (num >= d49faea5.Count)
		{
			do
			{
				d49faea5.Add(new Struct2[64]);
			}
			while (num >= d49faea5.Count);
		}
		else if (num < d49faea5.Count - 2)
		{
			do
			{
				d49faea5.RemoveAt(d49faea5.Count - 1);
			}
			while (num < d49faea5.Count - 2);
		}
		uint num2 = (uint_0 & 0x3F) + 1;
		Struct2[] array = d49faea5[(int)num];
		while (num2 < array.Length && array[num2].method_8() != null)
		{
			array[num2++] = Struct2.struct2_0;
		}
		if (num2 == array.Length && num + 1 < d49faea5.Count)
		{
			num2 = 0u;
			array = d49faea5[(int)(num + 1)];
			while (num2 < array.Length && array[num2].method_8() != null)
			{
				array[num2++] = Struct2.struct2_0;
			}
		}
		b63d8fc0 = uint_0;
		method_3();
	}

	private void method_3()
	{
		while (e95c01f_0 != null && e95c01f_0.uint_0 > b63d8fc0)
		{
			e95c01f_0 = e95c01f_0.method_0();
		}
	}

	public IntPtr method_4(uint uint_0, uint uint_1)
	{
		e95c01f e95c01f = new e95c01f
		{
			uint_0 = uint_0,
			intptr_0 = Marshal.AllocHGlobal((int)uint_1)
		};
		e95c01f f3ce1dc = e95c01f_0;
		while (f3ce1dc != null && f3ce1dc.f3ce1dc3 != null && f3ce1dc.f3ce1dc3.uint_0 >= uint_0)
		{
			f3ce1dc = f3ce1dc.f3ce1dc3;
		}
		if (f3ce1dc == null)
		{
			e95c01f_0 = e95c01f;
		}
		else
		{
			e95c01f.f3ce1dc3 = f3ce1dc.f3ce1dc3;
			f3ce1dc.f3ce1dc3 = e95c01f;
		}
		return e95c01f.intptr_0;
	}

	public void b2cbe5cc()
	{
		for (e95c01f e95c01f = e95c01f_0; e95c01f != null; e95c01f = e95c01f.method_0())
		{
		}
		e95c01f_0 = null;
	}

	protected override void ff44e6bb()
	{
		try
		{
			b2cbe5cc();
		}
		finally
		{
			base.Finalize();
		}
	}

	public void cdbadb47(uint uint_0, Struct1 struct1_0, Type type_0)
	{
		if (uint_0 > b63d8fc0)
		{
			throw new ExecutionEngineException();
		}
		Struct2[] array = d49faea5[(int)(uint_0 >> 6)];
		uint num = uint_0 & 0x3Fu;
		if (type_0.IsEnum)
		{
			type_0 = Enum.GetUnderlyingType(type_0);
		}
		if (type_0.IsPrimitive || type_0.IsPointer)
		{
			array[num].method_9(struct1_0);
			Class54.smethod_0(struct1_0, type_0);
		}
		else
		{
			array[num].eea29bab(struct1_0, type_0);
		}
	}
}
