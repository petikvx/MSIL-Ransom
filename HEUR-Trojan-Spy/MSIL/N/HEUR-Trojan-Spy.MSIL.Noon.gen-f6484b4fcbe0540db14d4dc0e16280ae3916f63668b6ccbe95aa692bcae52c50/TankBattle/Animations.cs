using System;
using System.Drawing;
using System.Windows.Forms;

namespace TankBattle;

public static class Animations
{
	public static void Explose(int x, int y, Form1 form)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		PictureBox pBExplose = new PictureBox();
		((Control)pBExplose).set_Location(new Point(x, y));
		((Control)pBExplose).set_Name("Bum");
		((Control)pBExplose).set_Tag((object)"Bum");
		((Control)pBExplose).set_Size(new Size(100, 100));
		pBExplose.set_TabStop(false);
		pBExplose.set_SizeMode((PictureBoxSizeMode)1);
		((Control)form).get_Controls().Add((Control)(object)pBExplose);
		Timer timer = new Timer();
		timer.set_Interval(30);
		Bitmap bitmap = new Bitmap(Image.FromFile("Animations\\explose.png"));
		int iImage = 0;
		int jImage = 0;
		timer.add_Tick((EventHandler)delegate
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Expected O, but got Unknown
			if (iImage > 7)
			{
				iImage = 0;
				jImage++;
			}
			Image val = (Image)new Bitmap(100, 100);
			Graphics val2 = Graphics.FromImage(val);
			val2.DrawImage((Image)(object)bitmap, 0, 0, new Rectangle(iImage * 100, jImage * 100, iImage * 100 + 100, jImage * 100 + 100), (GraphicsUnit)2);
			pBExplose.set_Image(val);
			if (iImage == 7 && jImage == 5)
			{
				((Control)form).get_Controls().Remove((Control)(object)pBExplose);
				timer.Stop();
			}
			iImage++;
		});
		timer.Start();
	}

	public static void Fire(int x, int y, Form1 form)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		PictureBox pBExplose = new PictureBox();
		((Control)pBExplose).set_Location(new Point(x, y));
		((Control)pBExplose).set_Name("FireBum");
		((Control)pBExplose).set_Tag((object)"FireBum");
		int widthImage = 192;
		int heightImage = 192;
		((Control)pBExplose).set_Size(new Size(50, 50));
		pBExplose.set_TabStop(false);
		pBExplose.set_SizeMode((PictureBoxSizeMode)1);
		((Control)form).get_Controls().Add((Control)(object)pBExplose);
		Timer timer = new Timer();
		timer.set_Interval(30);
		Bitmap bitmap = new Bitmap(Image.FromFile("Animations\\fire.png"));
		int iImage = 0;
		int jImage = 0;
		timer.add_Tick((EventHandler)delegate
		{
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			if (iImage > 4)
			{
				iImage = 0;
				jImage++;
			}
			Image val = (Image)new Bitmap(widthImage, heightImage);
			Graphics val2 = Graphics.FromImage(val);
			val2.DrawImage((Image)(object)bitmap, 0, 0, new Rectangle(iImage * widthImage, jImage * heightImage, iImage * widthImage + widthImage, jImage * heightImage + heightImage), (GraphicsUnit)2);
			pBExplose.set_Image(val);
			if (iImage == 4 && jImage == 3)
			{
				((Control)form).get_Controls().Remove((Control)(object)pBExplose);
				timer.Stop();
			}
			iImage++;
		});
		timer.Start();
	}
}
