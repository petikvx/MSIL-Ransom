using System;
using System.Drawing;
using System.Windows.Forms;

namespace TankBattle;

public class Bullet : PictureBox
{
	private readonly Form1 form;

	public int Speed { get; set; }

	public string ImagePath { get; set; }

	public Bitmap BulletUpImage { get; private set; }

	public Bitmap BulletDownImage { get; private set; }

	public Bitmap BulletLeftImage { get; private set; }

	public Bitmap BulletRightImage { get; private set; }

	public Tank CurrentTank { get; set; }

	public Bullet(Form1 form, Tank currentTank, int bulletWidth, int bulletHeight, int speed, string imagePath)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		ImagePath = imagePath;
		this.form = form;
		CurrentTank = currentTank;
		Speed = speed;
		((Control)this).set_Tag((object)"Bullet");
		BulletUpImage = (Bitmap)Image.FromFile(imagePath);
		BulletRightImage = (Bitmap)((Image)BulletUpImage).Clone();
		((Image)BulletRightImage).RotateFlip((RotateFlipType)1);
		BulletDownImage = (Bitmap)((Image)BulletUpImage).Clone();
		((Image)BulletDownImage).RotateFlip((RotateFlipType)2);
		BulletLeftImage = (Bitmap)((Image)BulletUpImage).Clone();
		((Image)BulletLeftImage).RotateFlip((RotateFlipType)3);
		if (((PictureBox)CurrentTank).get_Image() == CurrentTank.TankUpImage)
		{
			((Control)this).set_Location(new Point(((Control)CurrentTank).get_Location().X + ((Control)CurrentTank).get_Width() / 2 - bulletWidth / 2, ((Control)CurrentTank).get_Location().Y - bulletHeight - 10));
			((PictureBox)this).set_Image((Image)(object)BulletUpImage);
			((Control)this).set_Size(new Size(bulletWidth, bulletHeight));
		}
		if (((PictureBox)CurrentTank).get_Image() == CurrentTank.TankDownImage)
		{
			((Control)this).set_Location(new Point(((Control)CurrentTank).get_Location().X + ((Control)CurrentTank).get_Width() / 2 - bulletWidth / 2, ((Control)CurrentTank).get_Location().Y + ((Control)CurrentTank).get_Height() + 10));
			((PictureBox)this).set_Image((Image)(object)BulletDownImage);
			((Control)this).set_Size(new Size(bulletWidth, bulletHeight));
		}
		if (((PictureBox)CurrentTank).get_Image() == CurrentTank.TankLeftImage)
		{
			((Control)this).set_Location(new Point(((Control)CurrentTank).get_Location().X - bulletHeight - 10, ((Control)CurrentTank).get_Location().Y + ((Control)CurrentTank).get_Height() / 2 - bulletWidth / 2));
			((PictureBox)this).set_Image((Image)(object)BulletLeftImage);
			((Control)this).set_Size(new Size(bulletHeight, bulletWidth));
		}
		if (((PictureBox)CurrentTank).get_Image() == CurrentTank.TankRightImage)
		{
			((Control)this).set_Location(new Point(((Control)CurrentTank).get_Location().X + ((Control)CurrentTank).get_Width() + 10, ((Control)CurrentTank).get_Location().Y + ((Control)CurrentTank).get_Height() / 2 - bulletWidth / 2));
			((PictureBox)this).set_Image((Image)(object)BulletRightImage);
			((Control)this).set_Size(new Size(bulletHeight, bulletWidth));
		}
		((PictureBox)this).set_SizeMode((PictureBoxSizeMode)1);
		((PictureBox)this).set_TabStop(false);
	}

	public void StartFlyStraight()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		Timer timerFlyBullet = new Timer();
		((Control)form).get_Controls().Add((Control)(object)this);
		timerFlyBullet.set_Interval(5);
		timerFlyBullet.add_Tick((EventHandler)delegate
		{
			if (((PictureBox)this).get_Image() == BulletLeftImage)
			{
				((Control)this).set_Left(((Control)this).get_Left() - Speed);
			}
			else if (((PictureBox)this).get_Image() == BulletRightImage)
			{
				((Control)this).set_Left(((Control)this).get_Left() + Speed);
			}
			else if (((PictureBox)this).get_Image() == BulletUpImage)
			{
				((Control)this).set_Top(((Control)this).get_Top() - Speed);
			}
			else if (((PictureBox)this).get_Image() == BulletDownImage)
			{
				((Control)this).set_Top(((Control)this).get_Top() + Speed);
			}
			if (((Control)this).get_Left() < 0 || ((Control)this).get_Left() > ((Control)form).get_Width() || ((Control)this).get_Top() < 0 || ((Control)this).get_Top() > ((Control)form).get_Height())
			{
				((Control)form).get_Controls().Remove((Control)(object)this);
				timerFlyBullet.Stop();
			}
		});
		timerFlyBullet.Start();
	}

	public void StartFlySin()
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Expected O, but got Unknown
		Timer timerFlyBullet = new Timer();
		((Control)form).get_Controls().Add((Control)(object)this);
		int topStartFire = ((Control)this).get_Top();
		int leftStartFire = ((Control)this).get_Left();
		timerFlyBullet.set_Interval(8);
		timerFlyBullet.add_Tick((EventHandler)delegate
		{
			if (((PictureBox)this).get_Image() == BulletLeftImage)
			{
				((Control)this).set_Left(((Control)this).get_Left() - Speed);
				((Control)this).set_Top(topStartFire + (int)(40.0 * Math.Sin((double)(2 * ((Control)this).get_Left()) * Math.PI / 180.0)));
			}
			else if (((PictureBox)this).get_Image() == BulletRightImage)
			{
				((Control)this).set_Left(((Control)this).get_Left() + Speed);
				((Control)this).set_Top(topStartFire + (int)(40.0 * Math.Sin((double)(2 * ((Control)this).get_Left()) * Math.PI / 180.0)));
			}
			else if (((PictureBox)this).get_Image() == BulletUpImage)
			{
				((Control)this).set_Top(((Control)this).get_Top() - Speed);
				((Control)this).set_Left(leftStartFire + (int)(40.0 * Math.Sin((double)(2 * ((Control)this).get_Top()) * Math.PI / 180.0)));
			}
			else if (((PictureBox)this).get_Image() == BulletDownImage)
			{
				((Control)this).set_Top(((Control)this).get_Top() + Speed);
				((Control)this).set_Left(leftStartFire + (int)(40.0 * Math.Sin((double)(2 * ((Control)this).get_Top()) * Math.PI / 180.0)));
			}
			if (((Control)this).get_Left() < 0 || ((Control)this).get_Left() > ((Control)form).get_Width() || ((Control)this).get_Top() < 0 || ((Control)this).get_Top() > ((Control)form).get_Height())
			{
				((Control)form).get_Controls().Remove((Control)(object)this);
				timerFlyBullet.Stop();
			}
		});
		timerFlyBullet.Start();
	}
}
