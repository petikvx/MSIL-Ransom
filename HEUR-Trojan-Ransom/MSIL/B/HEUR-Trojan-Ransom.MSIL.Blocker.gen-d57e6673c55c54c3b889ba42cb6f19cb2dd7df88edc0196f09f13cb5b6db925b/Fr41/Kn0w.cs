using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Fr41;

public class Kn0w : Button
{
	public Kn0w()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		((Control)this).add_Click((EventHandler)delegate
		{
			Az1c();
		});
		((ButtonBase)this).set_AutoSize(false);
		((Control)this).set_Dock((DockStyle)1);
		((ButtonBase)this).set_BackColor(Color.AliceBlue);
		((ButtonBase)this).set_FlatStyle((FlatStyle)0);
		((ButtonBase)this).get_FlatAppearance().set_BorderSize(0);
		((Control)this).set_Margin(new Padding(4, 4, 4, 0));
		((Control)this).set_Size(new Size(450, 30));
		((ButtonBase)this).set_TextAlign((ContentAlignment)16);
	}

	private void Az1c()
	{
	}

	[SpecialName]
	[CompilerGenerated]
	[DebuggerHidden]
	private void c2FZ(object sender, EventArgs e)
	{
		Az1c();
	}
}
