using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Apaepukpjbsrly;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class j
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal j()
	{
		_ = 6;
		if (4 == 0)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (j.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager(k.a(117708247), typeof(j).Assembly);
			if (7u != 0)
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
		if (uint.MaxValue != 0)
		{
			b = a;
		}
	}
}
