using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using z9M;

namespace Ro0;

[ComImport]
[CompilerGenerated]
[Guid("000208D8-0000-0000-C000-000000000046")]
[TypeIdentifier]
public interface Cn3
{
	[DispId(238)]
	Pz2 Cells
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(238)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_45();
}
