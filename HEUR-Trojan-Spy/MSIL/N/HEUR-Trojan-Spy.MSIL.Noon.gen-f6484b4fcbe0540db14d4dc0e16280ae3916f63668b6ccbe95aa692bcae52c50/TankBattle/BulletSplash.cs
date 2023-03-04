using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TankBattle;

public class BulletSplash : PictureBox
{
	private readonly Form1 form;

	private List<Bullet> bulletSplashes = new List<Bullet>();

	private Timer timerFlyBullet = new Timer();

	public int Speed { get; set; }

	public string ImagePath { get; set; }

	public Bitmap BulletUpImage { get; private set; }

	public Bitmap BulletDownImage { get; private set; }

	public Bitmap BulletLeftImage { get; private set; }

	public Bitmap BulletRightImage { get; private set; }

	public Tank CurrentTank { get; set; }

	public BulletSplash(Form1 form, Tank currentTank, int bulletWidth, int bulletHeight, int speed, string imageBullet)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		this.form = form;
		CurrentTank = currentTank;
		Speed = speed;
		bulletSplashes.Add(new Bullet(form, CurrentTank, bulletWidth, bulletHeight, Speed, imageBullet));
		bulletSplashes.Add(new Bullet(form, CurrentTank, bulletWidth, bulletHeight, Speed, imageBullet));
		bulletSplashes.Add(new Bullet(form, CurrentTank, bulletWidth, bulletHeight, Speed, imageBullet));
	}

	public void StartFly()
	{
		foreach (Bullet bulletSplash in bulletSplashes)
		{
			((Control)form).get_Controls().Add((Control)(object)bulletSplash);
		}
		timerFlyBullet.set_Interval(5);
		timerFlyBullet.add_Tick((EventHandler)BulletFlyTick);
		timerFlyBullet.Start();
	}

	private void BulletFlyTick(object sender, EventArgs e)
	{
		if (((PictureBox)bulletSplashes[0]).get_Image() == bulletSplashes[0].BulletLeftImage)
		{
			Bullet bullet = bulletSplashes[0];
			((Control)bullet).set_Left(((Control)bullet).get_Left() - Speed);
		}
		else if (((PictureBox)bulletSplashes[0]).get_Image() == bulletSplashes[0].BulletRightImage)
		{
			Bullet bullet2 = bulletSplashes[0];
			((Control)bullet2).set_Left(((Control)bullet2).get_Left() + Speed);
		}
		else if (((PictureBox)bulletSplashes[0]).get_Image() == bulletSplashes[0].BulletUpImage)
		{
			Bullet bullet3 = bulletSplashes[0];
			((Control)bullet3).set_Top(((Control)bullet3).get_Top() - Speed);
		}
		else if (((PictureBox)bulletSplashes[0]).get_Image() == bulletSplashes[0].BulletDownImage)
		{
			Bullet bullet4 = bulletSplashes[0];
			((Control)bullet4).set_Top(((Control)bullet4).get_Top() + Speed);
		}
		if (((Control)bulletSplashes[0]).get_Left() < 0 || ((Control)bulletSplashes[0]).get_Left() > ((Control)form).get_Width() || ((Control)bulletSplashes[0]).get_Top() < 0 || ((Control)bulletSplashes[0]).get_Top() > ((Control)form).get_Height())
		{
			((Control)form).get_Controls().Remove((Control)(object)bulletSplashes[0]);
		}
		if (((PictureBox)bulletSplashes[1]).get_Image() == bulletSplashes[1].BulletLeftImage)
		{
			((Control)bulletSplashes[1]).set_Location(new Point(((Control)bulletSplashes[1]).get_Location().X - Speed, ((Control)bulletSplashes[1]).get_Location().Y - Speed / 2));
		}
		else if (((PictureBox)bulletSplashes[1]).get_Image() == bulletSplashes[1].BulletRightImage)
		{
			((Control)bulletSplashes[1]).set_Location(new Point(((Control)bulletSplashes[1]).get_Location().X + Speed, ((Control)bulletSplashes[1]).get_Location().Y - Speed / 2));
		}
		else if (((PictureBox)bulletSplashes[1]).get_Image() == bulletSplashes[1].BulletUpImage)
		{
			((Control)bulletSplashes[1]).set_Location(new Point(((Control)bulletSplashes[1]).get_Location().X + Speed / 2, ((Control)bulletSplashes[1]).get_Location().Y - Speed));
		}
		else if (((PictureBox)bulletSplashes[1]).get_Image() == bulletSplashes[1].BulletDownImage)
		{
			((Control)bulletSplashes[1]).set_Location(new Point(((Control)bulletSplashes[1]).get_Location().X + Speed / 2, ((Control)bulletSplashes[1]).get_Location().Y + Speed));
		}
		if (((Control)bulletSplashes[1]).get_Left() < 0 || ((Control)bulletSplashes[1]).get_Left() > ((Control)form).get_Width() || ((Control)bulletSplashes[1]).get_Top() < 0 || ((Control)bulletSplashes[1]).get_Top() > ((Control)form).get_Height())
		{
			((Control)form).get_Controls().Remove((Control)(object)bulletSplashes[1]);
		}
		if (((PictureBox)bulletSplashes[2]).get_Image() == bulletSplashes[2].BulletLeftImage)
		{
			((Control)bulletSplashes[2]).set_Location(new Point(((Control)bulletSplashes[2]).get_Location().X - Speed, ((Control)bulletSplashes[2]).get_Location().Y + Speed / 2));
		}
		else if (((PictureBox)bulletSplashes[2]).get_Image() == bulletSplashes[2].BulletRightImage)
		{
			((Control)bulletSplashes[2]).set_Location(new Point(((Control)bulletSplashes[2]).get_Location().X + Speed, ((Control)bulletSplashes[2]).get_Location().Y + Speed / 2));
		}
		else if (((PictureBox)bulletSplashes[2]).get_Image() == bulletSplashes[2].BulletUpImage)
		{
			((Control)bulletSplashes[2]).set_Location(new Point(((Control)bulletSplashes[2]).get_Location().X - Speed / 2, ((Control)bulletSplashes[2]).get_Location().Y - Speed));
		}
		else if (((PictureBox)bulletSplashes[2]).get_Image() == bulletSplashes[2].BulletDownImage)
		{
			((Control)bulletSplashes[2]).set_Location(new Point(((Control)bulletSplashes[2]).get_Location().X - Speed / 2, ((Control)bulletSplashes[2]).get_Location().Y + Speed));
		}
		if (((Control)bulletSplashes[2]).get_Left() < 0 || ((Control)bulletSplashes[2]).get_Left() > ((Control)form).get_Width() || ((Control)bulletSplashes[2]).get_Top() < 0 || ((Control)bulletSplashes[2]).get_Top() > ((Control)form).get_Height())
		{
			((Control)form).get_Controls().Remove((Control)(object)bulletSplashes[2]);
		}
		if (!((Control)form).get_Controls().Contains((Control)(object)bulletSplashes[0]) && !((Control)form).get_Controls().Contains((Control)(object)bulletSplashes[1]) && !((Control)form).get_Controls().Contains((Control)(object)bulletSplashes[2]))
		{
			timerFlyBullet.Stop();
		}
	}
}
