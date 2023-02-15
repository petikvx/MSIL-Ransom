using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns1;

namespace ns2;

internal sealed class Class3 : ReadOnlyCollectionBase
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	protected struct Struct0
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public Enum0 enum0_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;

		public int int_0;

		public int int_1;

		public int int_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_3;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	protected struct Struct1
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public Enum0 enum0_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected struct Struct2
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string string_0;

		public byte byte_0;

		public ushort ushort_0;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_1;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public string string_3;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public string string_4;

		[SpecialName]
		public Enum0 method_0()
		{
			return (Enum0)(byte_0 & 0x7F);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected struct Struct3
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string string_0;

		public byte byte_0;

		public ushort ushort_0;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_1;

		[SpecialName]
		public Enum0 method_0()
		{
			return (Enum0)(ushort_0 & 0x7FFF);
		}
	}

	private readonly string string_0;

	private static Class3 class3_0;

	public Class2 this[int int_0] => (Class2)base.InnerList[int_0];

	public Class2 this[string string_1]
	{
		get
		{
			if (string.IsNullOrEmpty(string_1))
			{
				return null;
			}
			string_1 = Path.GetFullPath(string_1);
			if (!smethod_5(string_1))
			{
				return null;
			}
			Class2 @class = null;
			foreach (Class2 inner in base.InnerList)
			{
				if (inner.method_5() && inner.method_0(string_1))
				{
					if (@class == null)
					{
						@class = inner;
					}
					else if (@class.method_3().Length < inner.method_3().Length && (inner.method_4() == Enum0.flag_0 || @class.method_4() != 0))
					{
						@class = inner;
					}
				}
			}
			return @class;
		}
	}

	[SpecialName]
	protected static bool smethod_0()
	{
		return PlatformID.Win32NT == Environment.OSVersion.Platform;
	}

	[SpecialName]
	protected static bool smethod_1()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		if (PlatformID.Win32NT == oSVersion.Platform && oSVersion.Version.Major >= 5)
		{
			return true;
		}
		return false;
	}

	[DllImport("netapi32", CharSet = CharSet.Unicode)]
	protected static extern int NetShareEnum(string string_1, int int_0, out IntPtr intptr_0, int int_1, out int int_2, out int int_3, ref int int_4);

	[DllImport("svrapi", CharSet = CharSet.Ansi, EntryPoint = "NetShareEnum")]
	protected static extern int NetShareEnum_1([MarshalAs(UnmanagedType.LPTStr)] string string_1, int int_0, IntPtr intptr_0, ushort ushort_0, out ushort ushort_1, out ushort ushort_2);

	[DllImport("netapi32")]
	protected static extern int NetApiBufferFree(IntPtr intptr_0);

	protected static void smethod_2(string string_1, Class3 class3_1)
	{
		int num = 2;
		int int_ = 0;
		IntPtr intptr_ = IntPtr.Zero;
		try
		{
			int int_2;
			int int_3;
			int num2 = NetShareEnum(string_1, num, out intptr_, -1, out int_2, out int_3, ref int_);
			if (5 == num2)
			{
				num = 1;
				num2 = NetShareEnum(string_1, 1, out intptr_, -1, out int_2, out int_3, ref int_);
			}
			if (num2 != 0 || int_2 <= 0)
			{
				return;
			}
			Type type = ((2 == num) ? typeof(Struct0) : typeof(Struct1));
			int num3 = Marshal.SizeOf(type);
			int num4 = 0;
			int num5 = intptr_.ToInt32();
			while (num4 < int_2)
			{
				IntPtr ptr = new IntPtr(num5);
				if (1 == num)
				{
					Struct1 @struct = (Struct1)Marshal.PtrToStructure(ptr, type);
					class3_1.method_0(@struct.string_0, string.Empty, @struct.enum0_0, @struct.string_1);
				}
				else
				{
					Struct0 struct2 = (Struct0)Marshal.PtrToStructure(ptr, type);
					class3_1.method_0(struct2.string_0, struct2.string_2, struct2.enum0_0, struct2.string_1);
				}
				num4++;
				num5 += num3;
			}
		}
		finally
		{
			if (IntPtr.Zero != intptr_)
			{
				NetApiBufferFree(intptr_);
			}
		}
	}

	protected static void smethod_3(string string_1, Class3 class3_1)
	{
		int num = 50;
		Type typeFromHandle = typeof(Struct2);
		int num2 = Marshal.SizeOf(typeFromHandle);
		ushort num3 = (ushort)(20 * num2);
		IntPtr intPtr = Marshal.AllocHGlobal(num3);
		try
		{
			ushort ushort_;
			ushort ushort_2;
			int num4 = NetShareEnum_1(string_1, num, intPtr, num3, out ushort_, out ushort_2);
			if (124 == num4)
			{
				num = 1;
				typeFromHandle = typeof(Struct3);
				num2 = Marshal.SizeOf(typeFromHandle);
				num4 = NetShareEnum_1(string_1, 1, intPtr, num3, out ushort_, out ushort_2);
			}
			if (num4 != 0 && 234 != num4)
			{
				Console.WriteLine(num4);
				return;
			}
			int num5 = 0;
			int num6 = intPtr.ToInt32();
			while (num5 < ushort_)
			{
				IntPtr ptr = new IntPtr(num6);
				if (1 == num)
				{
					Struct3 @struct = (Struct3)Marshal.PtrToStructure(ptr, typeFromHandle);
					class3_1.method_0(@struct.string_0, string.Empty, @struct.method_0(), @struct.string_1);
				}
				else
				{
					Struct2 struct2 = (Struct2)Marshal.PtrToStructure(ptr, typeFromHandle);
					class3_1.method_0(struct2.string_0, struct2.string_2, struct2.method_0(), struct2.string_1);
				}
				num5++;
				num6 += num2;
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	protected static void smethod_4(string string_1, Class3 class3_1)
	{
		if (!string.IsNullOrEmpty(string_1) && !smethod_1())
		{
			string_1 = string_1.ToUpper();
			if ('\\' != string_1[0] || '\\' != string_1[1])
			{
				string_1 = "\\\\" + string_1;
			}
		}
		if (smethod_0())
		{
			smethod_2(string_1, class3_1);
		}
		else
		{
			smethod_3(string_1, class3_1);
		}
	}

	public static bool smethod_5(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return false;
		}
		char c = char.ToUpper(string_1[0]);
		if ('A' <= c && c <= 'Z')
		{
			if (Path.VolumeSeparatorChar != string_1[1])
			{
				return false;
			}
			if (Path.DirectorySeparatorChar != string_1[2])
			{
				return false;
			}
			return true;
		}
		return false;
	}

	[SpecialName]
	public static Class3 smethod_6()
	{
		return class3_0 ?? (class3_0 = new Class3());
	}

	public Class3()
	{
		string_0 = string.Empty;
		smethod_4(string_0, this);
	}

	protected void Add(Class2 class2_0)
	{
		base.InnerList.Add(class2_0);
	}

	protected void method_0(string string_1, string string_2, Enum0 enum0_0, string string_3)
	{
		base.InnerList.Add(new Class2(string_0, string_1, string_2, enum0_0, string_3));
	}
}
