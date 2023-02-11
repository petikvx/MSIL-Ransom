using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Apjmqciddnbbpsnfq.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
internal class Resources
{
	private static ResourceManager role;

	private static CultureInfo global;

	internal static Resources DefineSingleton;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
		{
			if (role == null)
			{
				role = new ResourceManager("Apjmqciddnbbpsnfq.Properties.Resources", typeof(Resources).Assembly);
			}
			return role;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			return global;
		}
		set
		{
			global = value;
		}
	}

	internal static Bitmap _26_Kissy => (Bitmap)ResourceManager.GetObject("_26_Kissy", global);

	internal static Bitmap _27_Goatse => (Bitmap)ResourceManager.GetObject("_27_Goatse", global);

	internal static Bitmap _28_Nomnomnom => (Bitmap)ResourceManager.GetObject("_28_Nomnomnom", global);

	internal static Bitmap _29_Zzz => (Bitmap)ResourceManager.GetObject("_29_Zzz", global);

	internal static Bitmap _30_Total_shock => (Bitmap)ResourceManager.GetObject("_30_Total_shock", global);

	internal Resources()
	{
	}

	internal static bool ManageSingleton()
	{
		return DefineSingleton == null;
	}

	internal static Resources CloneSingleton()
	{
		return DefineSingleton;
	}
}
