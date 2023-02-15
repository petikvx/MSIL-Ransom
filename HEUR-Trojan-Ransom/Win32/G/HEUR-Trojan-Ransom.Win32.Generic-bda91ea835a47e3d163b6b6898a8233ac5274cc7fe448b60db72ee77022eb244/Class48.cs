using System;

internal class Class48 : c658c1b4
{
	private struct Struct0
	{
		public readonly IntPtr intptr_0;

		public readonly IntPtr intptr_1;
	}

	private Struct1? ae7992d5;

	private readonly Struct0 dfe94630;

	public Class48(Struct1 struct1_0)
	{
		ae7992d5 = struct1_0;
	}

	public unsafe Class48(TypedReference typedReference_0)
	{
		ae7992d5 = null;
		dfe94630 = *(Struct0*)(&typedReference_0);
	}

	public unsafe Struct2 imethod_0(Class50 class50_0, Enum2 enum2_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (ae7992d5.HasValue)
		{
			typedReference = *(TypedReference*)Struct1.b4634c31(ae7992d5.Value);
		}
		else
		{
			*(Struct0*)(&typedReference) = dfe94630;
		}
		return Struct2.dcafb951(TypedReference.ToObject(typedReference), __reftype(typedReference));
	}

	public unsafe void facb018d(Class50 class50_0, Struct2 struct2_0, Enum2 enum2_0)
	{
		TypedReference typedReference = default(TypedReference);
		if (ae7992d5.HasValue)
		{
			typedReference = *(TypedReference*)Struct1.b4634c31(ae7992d5.Value);
		}
		else
		{
			*(Struct0*)(&typedReference) = dfe94630;
		}
		Type typeFromHandle = __reftype(typedReference);
		object object_ = struct2_0.method_10(typeFromHandle);
		Class54.smethod_3(object_, Struct1.b4634c31(&typedReference));
	}

	public c658c1b4 imethod_1(uint uint_0)
	{
		return this;
	}

	public c658c1b4 imethod_2(ulong ulong_0)
	{
		return this;
	}

	public unsafe void cdbadb47(Class50 class50_0, Struct1 struct1_0, Type type_0)
	{
		if (ae7992d5.HasValue)
		{
			*(TypedReference*)Struct1.b4634c31(struct1_0) = *(TypedReference*)Struct1.b4634c31(ae7992d5.Value);
		}
		else
		{
			*(Struct0*)Struct1.b4634c31(struct1_0) = dfe94630;
		}
	}
}
