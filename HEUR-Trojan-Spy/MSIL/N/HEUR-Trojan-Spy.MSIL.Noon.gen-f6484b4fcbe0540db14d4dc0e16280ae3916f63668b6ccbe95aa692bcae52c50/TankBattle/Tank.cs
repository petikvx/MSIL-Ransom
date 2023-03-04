using System.Drawing;
using System.Windows.Forms;

namespace TankBattle;

public class Tank : PictureBox
{
	private int hp = 10;

	private bool isShielded;

	private int tankPower;

	private int ammoSplash = 0;

	protected Form1 form;

	public bool isLeft;

	public bool isRight;

	public bool isUp;

	public bool isDown;

	public virtual int HP
	{
		get
		{
			return hp;
		}
		set
		{
			hp = value;
			((Control)form.labelHP).set_Text($"{value}HP".ToString());
		}
	}

	public bool HaveSplashGun { get; set; }

	public int TankPower
	{
		get
		{
			return tankPower;
		}
		set
		{
			tankPower = value;
			IsShielded = IsShielded;
		}
	}

	public int AmmoSplash
	{
		get
		{
			return ammoSplash;
		}
		set
		{
			ammoSplash = value;
			((Control)form.labelAmmoSplash).set_Text($"Splash (Z): {value}".ToString());
		}
	}

	public bool IsShielded
	{
		get
		{
			return isShielded;
		}
		set
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Expected O, but got Unknown
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Expected O, but got Unknown
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Expected O, but got Unknown
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Expected O, but got Unknown
			//IL_010a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Expected O, but got Unknown
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Expected O, but got Unknown
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Expected O, but got Unknown
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_016e: Expected O, but got Unknown
			if (!value)
			{
				((Control)form.labelShield).set_Text("");
				string text = "";
				if (TankPower == 0)
				{
					text = "Tank\\greenTank.png";
				}
				if (TankPower == 1)
				{
					text = "Tank\\V2greenTank.png";
				}
				TankUpImage = (Bitmap)Image.FromFile(text);
				TankRightImage = (Bitmap)((Image)TankUpImage).Clone();
				((Image)TankRightImage).RotateFlip((RotateFlipType)1);
				TankDownImage = (Bitmap)((Image)TankUpImage).Clone();
				((Image)TankDownImage).RotateFlip((RotateFlipType)2);
				TankLeftImage = (Bitmap)((Image)TankUpImage).Clone();
				((Image)TankLeftImage).RotateFlip((RotateFlipType)3);
			}
			else
			{
				((Control)form.labelShield).set_Text("Shield ON");
				string text2 = "";
				if (TankPower == 0)
				{
					text2 = "Tank\\greenTankShield.png";
				}
				if (TankPower == 1)
				{
					text2 = "Tank\\V2greenTankShield.png";
				}
				TankUpImage = (Bitmap)Image.FromFile(text2);
				TankRightImage = (Bitmap)((Image)TankUpImage).Clone();
				((Image)TankRightImage).RotateFlip((RotateFlipType)1);
				TankDownImage = (Bitmap)((Image)TankUpImage).Clone();
				((Image)TankDownImage).RotateFlip((RotateFlipType)2);
				TankLeftImage = (Bitmap)((Image)TankUpImage).Clone();
				((Image)TankLeftImage).RotateFlip((RotateFlipType)3);
			}
			isShielded = value;
		}
	}

	protected int Speed { get; set; }

	public Bitmap TankUpImage { get; set; }

	public Bitmap TankDownImage { get; set; }

	public Bitmap TankLeftImage { get; set; }

	public Bitmap TankRightImage { get; set; }

	public Bullet bullet { get; set; }

	protected Direction CurrentDirection { get; set; }

	public Tank(Form1 form, int speed, int xLocation, int yLocation)
	{
		this.form = form;
		Speed = speed;
		((Control)this).set_Location(new Point(xLocation, yLocation));
		((PictureBox)this).set_SizeMode((PictureBoxSizeMode)1);
		((Control)this).set_Size(new Size(50, 50));
		((PictureBox)this).set_TabStop(false);
	}

	public virtual void AddTankOnForm()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		((Control)this).set_Tag((object)"Tank");
		TankUpImage = (Bitmap)Image.FromFile("Tank\\greenTank.png");
		TankRightImage = (Bitmap)((Image)TankUpImage).Clone();
		((Image)TankRightImage).RotateFlip((RotateFlipType)1);
		TankDownImage = (Bitmap)((Image)TankUpImage).Clone();
		((Image)TankDownImage).RotateFlip((RotateFlipType)2);
		TankLeftImage = (Bitmap)((Image)TankUpImage).Clone();
		((Image)TankLeftImage).RotateFlip((RotateFlipType)3);
		((PictureBox)this).set_Image((Image)(object)TankUpImage);
		((Control)this).BringToFront();
		((Control)form.labelHP).set_Text($"{HP}HP".ToString());
		((Control)form).get_Controls().Add((Control)(object)this);
	}

	public virtual void MoveTank()
	{
		if (isLeft)
		{
			((PictureBox)this).set_Image((Image)(object)TankLeftImage);
			((Control)this).set_Location(new Point(((Control)this).get_Location().X - Speed, ((Control)this).get_Location().Y));
		}
		if (isRight)
		{
			((PictureBox)this).set_Image((Image)(object)TankRightImage);
			((Control)this).set_Location(new Point(((Control)this).get_Location().X + Speed, ((Control)this).get_Location().Y));
		}
		if (isUp)
		{
			((PictureBox)this).set_Image((Image)(object)TankUpImage);
			((Control)this).set_Location(new Point(((Control)this).get_Location().X, ((Control)this).get_Location().Y - Speed));
		}
		if (isDown)
		{
			((PictureBox)this).set_Image((Image)(object)TankDownImage);
			((Control)this).set_Location(new Point(((Control)this).get_Location().X, ((Control)this).get_Location().Y + Speed));
		}
	}

	public virtual void Fire(Bullet bullet)
	{
		this.bullet = bullet;
		bullet.StartFlyStraight();
	}

	public virtual void FireSplash(BulletSplash bulletSplash)
	{
		bulletSplash.StartFly();
	}

	public virtual void FireSin(Bullet bullet)
	{
		this.bullet = bullet;
		bullet.StartFlySin();
	}
}
