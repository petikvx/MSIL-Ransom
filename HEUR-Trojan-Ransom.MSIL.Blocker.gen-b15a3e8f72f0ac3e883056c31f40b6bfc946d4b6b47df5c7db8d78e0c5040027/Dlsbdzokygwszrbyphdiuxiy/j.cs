using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;

namespace Dlsbdzokygwszrbyphdiuxiy;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class j
{
	private static ResourceManager m_a;

	private static CultureInfo b;

	internal j()
	{
		_ = 2;
		if (false)
		{
		}
		base._002Ector();
	}

	internal static ResourceManager a()
	{
		if (j.m_a == null)
		{
			ResourceManager resourceManager = new ResourceManager(k.a(491276014), typeof(j).Assembly);
			if (0 == 0)
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
		if (5u != 0)
		{
			b = a;
		}
	}
}
