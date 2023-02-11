using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;

namespace ns0;

public class GClass0 : IDisposable
{
	private readonly WebClient webClient_0;

	private static NameValueCollection nameValueCollection_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	public extern string String_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public unsafe string String_1
	{
		[CompilerGenerated]
		get
		{
			//Discarded unreachable code: IL_0007
			this = (GClass0)/*Error near IL_0002: Stack underflow*/;
			/*Error near IL_0002: stloc 3 (out-of-bounds)*/;
			_ = *(short*)(nint)/*Error near IL_0004: Stack underflow*/;
			_ = 1;
			/*Error near IL_0006: Unknown opcode: 0xFB*/;
		}
		[CompilerGenerated]
		set;
	}

	public extern GClass0();

	public extern void method_0(string string_2);

	public extern void method_1(string string_2);

	public extern void Dispose();

	static GClass0()
	{
		/*Error: Invalid metadata token*/;
	}

	static extern WebClient smethod_0();

	static extern void smethod_1(NameValueCollection nameValueCollection_1, string string_2, string string_3);

	static extern byte[] smethod_2(WebClient webClient_1, string string_2, NameValueCollection nameValueCollection_1);

	unsafe static void smethod_3(NameValueCollection nameValueCollection_1)
	{
		//IL_0006: Invalid comparison between Unknown and F4
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Expected O, but got I4
		while (true)
		{
			*(_003F*)(nint)/*Error near IL_0002: Stack underflow*/ = /*Error near IL_0002: Stack underflow*/;
			_003F val = /*Error near IL_0002: ldarg 1 (out-of-bounds)*/;
			float num = ((float[])/*Error near IL_0005: Stack underflow*/)[val];
			if (!((float)/*Error near IL_000b: Stack underflow*/ < num))
			{
				uint num2 = checked((uint)/*Error near IL_000c: Stack underflow*/);
				if ((int)/*Error near IL_0011: Stack underflow*/ <= (int)num2)
				{
					break;
				}
			}
		}
		ulong num3 = (ulong)/*Error near IL_0013: Stack underflow*/;
		_003F val2 = checked(/*Error near IL_0015: Stack underflow*/ * num3);
		if (/*Error near IL_0017: Stack underflow*/ < val2)
		{
			*(_003F*)(nint)/*Error near IL_001a: Stack underflow*/ = /*Error near IL_001a: Stack underflow*/;
			nameValueCollection_1 = (NameValueCollection)1;
		}
		_ = *(uint*)(nint)/*Error near IL_0020: Stack underflow*/;
		/*Error near IL_0020: stloc 0 (out-of-bounds)*/;
		/*Error: Unexpected end of block*/;
	}

	unsafe static byte[] smethod_4(WebClient webClient_1, string string_2, string string_3)
	{
		//Discarded unreachable code: IL_0013
		//IL_0004: Expected O, but got I4
		webClient_1 = (WebClient)1;
		_ = *(uint*)(nint)/*Error near IL_0006: Stack underflow*/;
		/*Error near IL_0006: stloc 0 (out-of-bounds)*/;
		_ = *(IntPtr*)(nint)/*Error near IL_0008: Stack underflow*/;
		/*Error near IL_000e: Invalid metadata token*/;
	}

	unsafe static void smethod_5(Component component_0)
	{
		//Discarded unreachable code: IL_000a, IL_0011, IL_0016, IL_001b
		//IL_0005: Expected O, but got I4
		((float[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/] = (float)/*Error near IL_0001: Stack underflow*/;
		_ = ((Array)(*(ushort*)checked((int)/*Error near IL_0002: Stack underflow*/))).LongLength;
		/*Error near IL_0005: Invalid metadata token*/;
	}

	static extern NameValueCollection smethod_6();
}
