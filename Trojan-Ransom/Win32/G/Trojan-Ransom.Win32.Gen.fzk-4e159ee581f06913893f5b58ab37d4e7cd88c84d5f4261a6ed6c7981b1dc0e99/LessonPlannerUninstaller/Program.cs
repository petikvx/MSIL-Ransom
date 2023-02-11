using System;
using System.Windows.Forms;

namespace LessonPlannerUninstaller;

internal static class Program
{
	[STAThread]
	private static void Main()
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Invalid comparison between Unknown and I4
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		UninstallerManager uninstallerManager = new UninstallerManager();
		DialogResult val = MessageBox.Show("Are you sure you want to uninstall " + uninstallerManager.DisplayName, "UnInstall " + uninstallerManager.DisplayName, (MessageBoxButtons)4);
		if ((int)val == 6)
		{
			uninstallerManager.Uninstall();
		}
	}
}
