using System.Drawing;
using System.Windows.Forms;

namespace TankBattle;

public class Shield : PictureBox
{
	public Shield(Form1 form, int xLocation, int yLocation)
	{
		((Control)this).set_Tag((object)"Shield");
		((PictureBox)this).set_Image(Image.FromFile("Items\\shield.png"));
		((Control)this).set_Location(new Point(xLocation, yLocation));
		((PictureBox)this).set_SizeMode((PictureBoxSizeMode)1);
		((Control)this).set_Size(new Size(20, 20));
		((PictureBox)this).set_TabStop(false);
		((Control)form).get_Controls().Add((Control)(object)this);
		form.shieldOnForm = true;
	}
}
