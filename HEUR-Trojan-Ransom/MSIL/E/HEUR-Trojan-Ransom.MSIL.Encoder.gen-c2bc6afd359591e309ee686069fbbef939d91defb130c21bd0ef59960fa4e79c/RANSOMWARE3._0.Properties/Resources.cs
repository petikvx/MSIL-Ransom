using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace RANSOMWARE3._0.Properties;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
[DebuggerNonUserCode]
[CompilerGenerated]
internal class Resources
{
	private static ResourceManager resourceMan;

	private static CultureInfo resourceCulture;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (resourceMan == null)
			{
				ResourceManager resourceManager = (resourceMan = new ResourceManager("RANSOMWARE3._0.Properties.Resources", typeof(Resources).Assembly));
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

	internal static Bitmap Bez_tytułu
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("Bez tytułu", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static byte[] BSOD
	{
		get
		{
			object @object = ResourceManager.GetObject("BSOD", resourceCulture);
			return (byte[])@object;
		}
	}

	internal static Bitmap i
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("i", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal static Bitmap i1
	{
		get
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			object @object = ResourceManager.GetObject("i1", resourceCulture);
			return (Bitmap)@object;
		}
	}

	internal Resources()
	{
	}
}