using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;

namespace Hbisjtsryhowltszkcgwhxxu;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
[DebuggerNonUserCode]
internal sealed class i
{
	private static ResourceManager m_a;

	private static CultureInfo m_b;

	internal i()
	{
	}

	internal static ResourceManager a()
	{
		if (i.m_a == null)
		{
			i.m_a = new ResourceManager("Hbisjtsryhowltszkcgwhxxu.Properties.Resources", typeof(i).Assembly);
		}
		return i.m_a;
	}

	internal static CultureInfo a()
	{
		return i.m_b;
	}

	internal static void a(CultureInfo a)
	{
		i.m_b = a;
	}

	internal static Bitmap a()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)i.a().GetObject("_20_Meow", i.m_b);
	}

	internal static Bitmap b()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)i.a().GetObject("_21_Zip_it", i.m_b);
	}

	internal static Bitmap c()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)i.a().GetObject("_22_Annoyed", i.m_b);
	}

	internal static Bitmap d()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)i.a().GetObject("_23_Please", i.m_b);
	}

	internal static Bitmap e()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Expected O, but got Unknown
		return (Bitmap)i.a().GetObject("_24_Hay", i.m_b);
	}

	internal static byte[] a()
	{
		return (byte[])i.a().GetObject("basic_link_1", i.m_b);
	}
}
