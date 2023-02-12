using System;
using System.Windows.Forms;

namespace M_POST_for_EBDS_Demo_In_CSharp_DotNet
{
	// Token: 0x02000012 RID: 18
	internal static class Program
	{
		// Token: 0x0600011B RID: 283 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmInitialPage());
		}
	}
}
