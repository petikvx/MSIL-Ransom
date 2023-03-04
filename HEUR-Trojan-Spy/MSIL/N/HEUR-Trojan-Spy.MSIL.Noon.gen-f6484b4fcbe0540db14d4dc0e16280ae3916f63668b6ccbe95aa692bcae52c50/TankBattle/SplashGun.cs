using System.Drawing;
using System.Windows.Forms;

namespace TankBattle;

internal class SplashGun : PictureBox
{
	public SplashGun(Form1 form, int xLocation, int yLocation)
	{
		((Control)this).set_Tag((object)"SplashGun");
		((PictureBox)this).set_Image(Image.FromFile("Items\\splashGun.png"));
		((Control)this).set_Location(new Point(xLocation, yLocation));
		((PictureBox)this).set_SizeMode((PictureBoxSizeMode)1);
		((Control)this).set_Size(new Size(48, 48));
		((PictureBox)this).set_TabStop(false);
		((Control)form).get_Controls().Add((Control)(object)this);
	}
}
