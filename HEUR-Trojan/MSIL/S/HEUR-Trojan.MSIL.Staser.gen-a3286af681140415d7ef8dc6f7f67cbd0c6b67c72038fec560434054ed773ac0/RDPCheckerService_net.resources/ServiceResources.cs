using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace RDPCheckerService_net.resources;

[CompilerGenerated]
[DebuggerNonUserCode]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
internal class ServiceResources
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
				ResourceManager resourceManager = (resourceMan = new ResourceManager("RDPCheckerService_net.resources.ServiceResources", typeof(ServiceResources).Assembly));
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

	internal static byte[] checker
	{
		get
		{
			object @object = ResourceManager.GetObject("checker", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static byte[] computer_info
	{
		get
		{
			object @object = ResourceManager.GetObject("computer_info", resourceCulture);
			return (byte[])@object;
		}
	}

	internal ServiceResources()
	{
	}
}
