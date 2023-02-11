using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Gkdlku;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class j
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal j()
	{
		_ = 3;
		if (5 == 0)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (j.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager(k.a(-1973262815), typeof(j).Assembly);
			if (true)
			{
				j.m_a = resourceManager;
			}
		}
		return j.m_a;
	}

	internal static CultureInfo a()
	{
		return b;
	}

	internal static void a(CultureInfo a)
	{
		if (true)
		{
			b = a;
		}
	}
}
