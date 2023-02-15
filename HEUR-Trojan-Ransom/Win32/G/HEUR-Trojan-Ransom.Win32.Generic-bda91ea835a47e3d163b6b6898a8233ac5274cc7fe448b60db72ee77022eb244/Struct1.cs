using System.Runtime.CompilerServices;

internal struct Struct1
{
	public unsafe void* pVoid_0;

	[SpecialName]
	public unsafe static Struct1 b4634c31(void* pVoid_1)
	{
		Struct1 result = default(Struct1);
		result.pVoid_0 = pVoid_1;
		return result;
	}

	[SpecialName]
	public unsafe static void* b4634c31(Struct1 struct1_0)
	{
		return struct1_0.pVoid_0;
	}
}
