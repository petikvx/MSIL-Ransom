using System.Reflection;

internal struct Struct4
{
	public readonly uint e4cdd96a;

	public readonly uint uint_0;

	public readonly Class60 class60_0;

	public unsafe Struct4(ref byte* pByte_0, Module module_0)
	{
		e4cdd96a = *(uint*)pByte_0;
		pByte_0 += 4;
		if (e4cdd96a != 0)
		{
			uint_0 = *(uint*)pByte_0;
			pByte_0 += 4;
		}
		else
		{
			uint_0 = 0u;
		}
		class60_0 = new Class60(ref pByte_0, module_0);
	}
}
