using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Intel_R__Dynamic_Application_filter.My.Resources;

[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
[DebuggerNonUserCode]
internal class Resource13
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (object.ReferenceEquals(resourceMan, null))
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("Intel_R__Dynamic_Application_filter.Resource13", typeof(Resource13).Assembly));
			}
			return resourceMan;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return resourceCulture;
		}
		set
		{
			resourceCulture = value;
		}
	}

	internal static byte[] dControl
	{
		get
		{
			object objectValue = RuntimeHelpers.GetObjectValue(ResourceManager.GetObject("dControl", resourceCulture));
			return (byte[])objectValue;
		}
	}

	internal Resource13()
	{
	}
}
