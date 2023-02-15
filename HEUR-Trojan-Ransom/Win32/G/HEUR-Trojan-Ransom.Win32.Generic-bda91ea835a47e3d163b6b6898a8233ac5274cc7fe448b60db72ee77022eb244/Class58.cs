using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

internal class Class58
{
	private struct Struct3
	{
		public readonly uint uint_0;

		public readonly uint uint_1;

		public readonly uint uint_2;

		public readonly uint a3537af9;
	}

	private class ccfc6804
	{
		public Module module_0;

		public MemberInfo memberInfo_0;

		public int d5afd978;

		[SpecialName]
		public MemberInfo method_0()
		{
			return memberInfo_0 ?? (memberInfo_0 = module_0.ResolveMember(d5afd978));
		}
	}

	private static readonly Dictionary<Module, Class58> dictionary_0 = new Dictionary<Module, Class58>();

	private readonly Dictionary<uint, Struct4> dictionary_1;

	private readonly Dictionary<uint, ccfc6804> dictionary_2;

	private readonly Dictionary<uint, string> c8396cdc;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private readonly Module ea35228b;

	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private unsafe byte* ac78166e;

	public unsafe Class58(Module module_0, void* pVoid_0)
	{
		if (((Struct3*)pVoid_0)->uint_0 != 1752394086)
		{
			throw new InvalidProgramException();
		}
		dictionary_2 = new Dictionary<uint, ccfc6804>();
		c8396cdc = new Dictionary<uint, string>();
		dictionary_1 = new Dictionary<uint, Struct4>();
		byte* pByte_ = (byte*)pVoid_0 + sizeof(Struct3);
		for (int i = 0; i < ((Struct3*)pVoid_0)->uint_1; i++)
		{
			uint key = Class0.aa1fdcd7(ref pByte_);
			int d5afd = (int)Class0.smethod_0(Class0.aa1fdcd7(ref pByte_));
			dictionary_2[key] = new ccfc6804
			{
				module_0 = module_0,
				d5afd978 = d5afd
			};
		}
		for (int j = 0; j < ((Struct3*)pVoid_0)->uint_2; j++)
		{
			uint key2 = Class0.aa1fdcd7(ref pByte_);
			uint num = Class0.aa1fdcd7(ref pByte_);
			c8396cdc[key2] = new string((char*)pByte_, 0, (int)num);
			pByte_ += num << 1;
		}
		for (int k = 0; k < ((Struct3*)pVoid_0)->a3537af9; k++)
		{
			dictionary_1[Class0.aa1fdcd7(ref pByte_)] = new Struct4(ref pByte_, module_0);
		}
		method_2((byte*)pVoid_0);
		ea35228b = module_0;
		dictionary_0[module_0] = this;
	}

	[SpecialName]
	public Module method_0()
	{
		return ea35228b;
	}

	[SpecialName]
	public unsafe byte* method_1()
	{
		return ac78166e;
	}

	[SpecialName]
	public unsafe void method_2(byte* pByte_0)
	{
		ac78166e = pByte_0;
	}

	public static Class58 smethod_0(Module module_0)
	{
		Class58 value;
		lock (dictionary_0)
		{
			if (!dictionary_0.TryGetValue(module_0, out value))
			{
				Class58 class2 = (dictionary_0[module_0] = Class61.f542cbc8(module_0));
				value = class2;
				return value;
			}
		}
		return value;
	}

	public MemberInfo method_3(uint uint_0)
	{
		return dictionary_2[uint_0].method_0();
	}

	public string method_4(uint uint_0)
	{
		if (uint_0 == 0)
		{
			return null;
		}
		return c8396cdc[uint_0];
	}

	public Struct4 a0bdbb28(uint uint_0)
	{
		return dictionary_1[uint_0];
	}
}
