using System.CodeDom.Compiler;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ns0;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
internal sealed class Class14
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	internal Class14()
	{
	}

	[SpecialName]
	public static ResourceManager smethod_0()
	{
		if (resourceManager_0 == null)
		{
			resourceManager_0 = new ResourceManager("ns0.Class14", typeof(Class14).Assembly);
		}
		return resourceManager_0;
	}

	[SpecialName]
	public static byte[] smethod_1()
	{
		return (byte[])smethod_0().GetObject("data", cultureInfo_0);
	}
}
