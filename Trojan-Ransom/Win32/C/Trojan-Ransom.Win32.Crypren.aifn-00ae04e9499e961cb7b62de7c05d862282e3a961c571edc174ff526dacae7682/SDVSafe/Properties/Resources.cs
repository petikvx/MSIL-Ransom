using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet.Properties
{
	// Token: 0x02000016 RID: 22
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Resources
	{
		// Token: 0x06000139 RID: 313 RVA: 0x00006044 File Offset: 0x00004244
		internal Resources()
		{
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600013A RID: 314 RVA: 0x000102C8 File Offset: 0x0000E4C8
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("M_POST_for_EBDS_Demo_In_CSharp_DotNet.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00010310 File Offset: 0x0000E510
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00010327 File Offset: 0x0000E527
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x04000117 RID: 279
		private static ResourceManager resourceMan;

		// Token: 0x04000118 RID: 280
		private static CultureInfo resourceCulture;
	}
}
