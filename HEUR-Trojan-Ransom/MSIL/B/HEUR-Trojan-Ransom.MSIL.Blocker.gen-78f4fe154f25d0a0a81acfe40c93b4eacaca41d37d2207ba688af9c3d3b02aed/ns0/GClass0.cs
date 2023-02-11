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

	public string String_0
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set
		{
			//Discarded unreachable code: IL_0005, IL_0007, IL_0010, IL_0016, IL_001c, IL_001d
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Expected O, but got Unknown
			/*Error: Invalid metadata token*/;
		}
	}

	public string String_1
	{
		[CompilerGenerated]
		get
		{
			return (string)/*OpCode not supported: Nop*/;
		}
		[CompilerGenerated]
		set;
	}

	public extern GClass0();

	public extern void method_0(string string_2);

	public extern void method_1(string string_2);

	public extern void Dispose();

	static extern WebClient smethod_0();

	static extern void smethod_1(NameValueCollection nameValueCollection_1, string string_2, string string_3);

	static byte[] smethod_2(WebClient webClient_1, string string_2, NameValueCollection nameValueCollection_1)
	{
		//IL_0005: Expected O, but got I4
		checked
		{
			_ = (sbyte)/*Error near IL_0002: Stack underflow*/;
			return (byte[])3;
		}
	}

	static void smethod_3(NameValueCollection nameValueCollection_1)
	{
		//Discarded unreachable code: IL_000a, IL_0011, IL_0017
		//IL_0002: Invalid comparison between Unknown and O
		//IL_0007: Unsupported input type for neg.
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Expected F8, but got Unknown
		object obj;
		do
		{
			obj = ((object[])/*Error near IL_0001: Stack underflow*/)[/*Error near IL_0001: Stack underflow*/];
		}
		while ((object)/*Error near IL_0007: Stack underflow*/ == obj);
		_003F val = 0 - /*Error near IL_0008: Stack underflow*/;
		((double[])/*Error near IL_0009: Stack underflow*/)[/*Error near IL_0009: Stack underflow*/] = (double)val;
		/*Error near IL_0009: Unknown opcode: 0xFB*/;
	}

	static extern byte[] smethod_4(WebClient webClient_1, string string_2, string string_3);

	static extern void smethod_5(Component component_0);

	static extern NameValueCollection smethod_6();
}
