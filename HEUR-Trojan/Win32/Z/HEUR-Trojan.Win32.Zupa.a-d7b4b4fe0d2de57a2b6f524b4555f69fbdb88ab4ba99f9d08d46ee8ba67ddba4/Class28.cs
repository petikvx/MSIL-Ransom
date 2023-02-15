using System;
using System.Windows.Forms;

internal static class Class28
{
	[STAThread]
	private static void Main(string[] args)
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		if (args.Length != 0 && !string.IsNullOrEmpty(args[0]) && !string.IsNullOrEmpty(args[1]) && args[0].Equals(Class60.smethod_0(-2050226604)) && (args[1].Equals(Class60.smethod_0(-2050205567)) || args[1].Equals(Class60.smethod_0(-2050205550))))
		{
			Application.Run((Form)(object)new GForm0(args[0] + Class60.smethod_0(-2050226643) + args[1]));
		}
		else
		{
			Application.Run((Form)(object)new GForm0(string.Empty));
		}
	}
}
