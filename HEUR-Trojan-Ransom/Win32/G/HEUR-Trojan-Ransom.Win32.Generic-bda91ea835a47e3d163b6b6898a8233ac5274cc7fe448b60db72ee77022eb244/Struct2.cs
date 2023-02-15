using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
internal struct Struct2
{
	[FieldOffset(0)]
	private ulong ab026115;

	[FieldOffset(0)]
	private double double_0;

	[FieldOffset(0)]
	private uint uint_0;

	[FieldOffset(0)]
	private float float_0;

	[FieldOffset(0)]
	private ushort ushort_0;

	[FieldOffset(0)]
	private byte byte_0;

	[FieldOffset(8)]
	private object object_0;

	public static readonly Struct2 struct2_0;

	[SpecialName]
	public ulong method_0()
	{
		return ab026115;
	}

	[SpecialName]
	public void method_1(ulong ulong_0)
	{
		ab026115 = ulong_0;
		object_0 = null;
	}

	[SpecialName]
	public uint method_2()
	{
		return uint_0;
	}

	[SpecialName]
	public void method_3(uint uint_1)
	{
		uint_0 = uint_1;
		object_0 = null;
	}

	[SpecialName]
	public ushort method_4()
	{
		return ushort_0;
	}

	[SpecialName]
	public void e7c8f952(ushort ushort_1)
	{
		ushort_0 = ushort_1;
		object_0 = null;
	}

	[SpecialName]
	public byte method_5()
	{
		return byte_0;
	}

	[SpecialName]
	public void method_6(byte byte_1)
	{
		byte_0 = byte_1;
		object_0 = null;
	}

	[SpecialName]
	public double b9e547a3()
	{
		return double_0;
	}

	[SpecialName]
	public void method_7(double double_1)
	{
		double_0 = double_1;
		object_0 = null;
	}

	[SpecialName]
	public float b61307cd()
	{
		return float_0;
	}

	[SpecialName]
	public void d38706c8(float float_1)
	{
		float_0 = float_1;
		object_0 = null;
	}

	[SpecialName]
	public object method_8()
	{
		return object_0;
	}

	[SpecialName]
	public void e5a3833a(object object_1)
	{
		object_0 = object_1;
		ab026115 = 0uL;
	}

	public unsafe static Struct2 dcafb951(object object_1, Type type_0)
	{
		if (type_0.IsEnum)
		{
			Type underlyingType = Enum.GetUnderlyingType(type_0);
			return dcafb951(Convert.ChangeType(object_1, underlyingType), underlyingType);
		}
		switch (Type.GetTypeCode(type_0))
		{
		default:
		{
			Struct2 result;
			if (object_1 is Pointer)
			{
				result = default(Struct2);
				result.ab026115 = (ulong)Pointer.Unbox(object_1);
				return result;
			}
			if (object_1 is IntPtr)
			{
				result = default(Struct2);
				result.ab026115 = (ulong)(long)(IntPtr)object_1;
				return result;
			}
			if (object_1 is UIntPtr)
			{
				result = default(Struct2);
				result.ab026115 = (ulong)(UIntPtr)object_1;
				return result;
			}
			if (type_0.IsValueType)
			{
				result = default(Struct2);
				result.object_0 = Class52.e93b53a8(object_1, type_0);
				return result;
			}
			result = default(Struct2);
			result.object_0 = object_1;
			return result;
		}
		case TypeCode.Boolean:
		{
			Struct2 result = default(Struct2);
			result.byte_0 = (byte)(((bool)object_1) ? 1u : 0u);
			return result;
		}
		case TypeCode.Char:
		{
			Struct2 result = default(Struct2);
			result.ushort_0 = (char)object_1;
			return result;
		}
		case TypeCode.SByte:
		{
			Struct2 result = default(Struct2);
			result.byte_0 = (byte)(sbyte)object_1;
			return result;
		}
		case TypeCode.Byte:
		{
			Struct2 result = default(Struct2);
			result.byte_0 = (byte)object_1;
			return result;
		}
		case TypeCode.Int16:
		{
			Struct2 result = default(Struct2);
			result.ushort_0 = (ushort)(short)object_1;
			return result;
		}
		case TypeCode.UInt16:
		{
			Struct2 result = default(Struct2);
			result.ushort_0 = (ushort)object_1;
			return result;
		}
		case TypeCode.Int32:
		{
			Struct2 result = default(Struct2);
			result.uint_0 = (uint)(int)object_1;
			return result;
		}
		case TypeCode.UInt32:
		{
			Struct2 result = default(Struct2);
			result.uint_0 = (uint)object_1;
			return result;
		}
		case TypeCode.Int64:
		{
			Struct2 result = default(Struct2);
			result.ab026115 = (ulong)(long)object_1;
			return result;
		}
		case TypeCode.UInt64:
		{
			Struct2 result = default(Struct2);
			result.ab026115 = (ulong)object_1;
			return result;
		}
		case TypeCode.Single:
		{
			Struct2 result = default(Struct2);
			result.float_0 = (float)object_1;
			return result;
		}
		case TypeCode.Double:
		{
			Struct2 result = default(Struct2);
			result.double_0 = (double)object_1;
			return result;
		}
		}
	}

	public unsafe void method_9(Struct1 struct1_0)
	{
		*(TypedReference*)Struct1.b4634c31(struct1_0) = __makeref(uint_0);
	}

	public unsafe void eea29bab(Struct1 struct1_0, Type type_0)
	{
		if (object_0 is ValueType && type_0.IsValueType)
		{
			Class54.smethod_1(object_0, struct1_0);
		}
		else
		{
			*(TypedReference*)Struct1.b4634c31(struct1_0) = __makeref(object_0);
		}
	}

	public unsafe object method_10(Type type_0)
	{
		if (type_0.IsEnum)
		{
			return Enum.ToObject(type_0, method_10(Enum.GetUnderlyingType(type_0)));
		}
		switch (Type.GetTypeCode(type_0))
		{
		default:
			if (type_0.IsPointer)
			{
				return Pointer.Box((void*)ab026115, type_0);
			}
			if ((object)type_0 == typeof(IntPtr))
			{
				return c2748bf3.bool_0 ? new IntPtr((long)ab026115) : new IntPtr((int)uint_0);
			}
			if ((object)type_0 == typeof(UIntPtr))
			{
				return c2748bf3.bool_0 ? new UIntPtr(ab026115) : new UIntPtr(uint_0);
			}
			return Class52.smethod_0(object_0);
		case TypeCode.Boolean:
			return byte_0 != 0;
		case TypeCode.Char:
			return (char)ushort_0;
		case TypeCode.SByte:
			return (sbyte)byte_0;
		case TypeCode.Byte:
			return byte_0;
		case TypeCode.Int16:
			return (short)ushort_0;
		case TypeCode.UInt16:
			return ushort_0;
		case TypeCode.Int32:
			return (int)uint_0;
		case TypeCode.UInt32:
			return uint_0;
		case TypeCode.Int64:
			return (long)ab026115;
		case TypeCode.UInt64:
			return ab026115;
		case TypeCode.Single:
			return float_0;
		case TypeCode.Double:
			return double_0;
		}
	}
}
