using System;
using System.Drawing;
using System.Windows.Forms;

namespace TankBattle;

public class EnemyTankLogic1 : Tank, IEnemy
{
	private int hp = 2;

	public Timer TimerDirectionGenerate { get; set; }

	public Timer TimerTankAutoFire { get; set; }

	public Timer TimerTankMove { get; set; }

	private Random random { get; set; } = new Random();


	public override int HP
	{
		get
		{
			return hp;
		}
		set
		{
			hp = value;
		}
	}

	object IEnemy.Tag
	{
		get
		{
			return ((Control)this).get_Tag();
		}
		set
		{
			((Control)this).set_Tag(value);
		}
	}

	public EnemyTankLogic1(Form1 form, int speed, int xLocation, int yLocation)
		: base(form, speed, xLocation, yLocation)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		TimerDirectionGenerate = new Timer();
		TimerDirectionGenerate.set_Interval(100);
		TimerDirectionGenerate.add_Tick((EventHandler)TimerDirectionGenerate_Tick);
		TimerTankAutoFire = new Timer();
		TimerTankAutoFire.set_Interval(500);
		TimerTankAutoFire.add_Tick((EventHandler)TimerTankAutoFire_Tick);
		TimerTankMove = new Timer();
		TimerTankMove.set_Interval(speed);
		TimerTankMove.add_Tick((EventHandler)TimerTankMove_Tick);
	}

	public override void AddTankOnForm()
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		((Control)this).set_Tag((object)"EnemyTank");
		base.TankUpImage = (Bitmap)Image.FromFile("EnemyTank\\redTank1.png");
		base.TankRightImage = (Bitmap)((Image)base.TankUpImage).Clone();
		((Image)base.TankRightImage).RotateFlip((RotateFlipType)1);
		base.TankDownImage = (Bitmap)((Image)base.TankUpImage).Clone();
		((Image)base.TankDownImage).RotateFlip((RotateFlipType)2);
		base.TankLeftImage = (Bitmap)((Image)base.TankUpImage).Clone();
		((Image)base.TankLeftImage).RotateFlip((RotateFlipType)3);
		((PictureBox)this).set_Image((Image)(object)base.TankUpImage);
		((Control)form).get_Controls().Add((Control)(object)this);
		TimerTankMove.Start();
		TimerTankAutoFire.Start();
		TimerDirectionGenerate.Start();
	}

	public void TimerTankMove_Tick(object sender, EventArgs e)
	{
		MoveTank();
	}

	public void TimerTankAutoFire_Tick(object sender, EventArgs e)
	{
		if (!form.enemyV2List.Contains(this) || form.tank == null)
		{
			TimerTankAutoFire.Stop();
			TimerDirectionGenerate.Stop();
			TimerTankMove.Stop();
		}
		else if ((((Control)this).get_Location().X > ((Control)form.tank).get_Location().X - ((Control)form.tank).get_Width() / 2 && ((Control)this).get_Location().X < ((Control)form.tank).get_Location().X + ((Control)form.tank).get_Width() / 2) || (((Control)this).get_Location().Y > ((Control)form.tank).get_Location().Y - ((Control)form.tank).get_Width() / 2 && ((Control)this).get_Location().Y < ((Control)form.tank).get_Location().Y + ((Control)form.tank).get_Width() / 2))
		{
			Fire(new Bullet(form, this, 17, 17, 6, "Bullet\\bullet.png"));
		}
	}

	public void TimerDirectionGenerate_Tick(object sender, EventArgs e)
	{
		if (form.tank == null || HP < 1)
		{
			TimerTankMove.Stop();
			TimerDirectionGenerate.Stop();
			TimerTankAutoFire.Stop();
			return;
		}
		int num = Math.Abs(((Control)form.tank).get_Location().X - ((Control)this).get_Location().X);
		int num2 = Math.Abs(((Control)form.tank).get_Location().Y - ((Control)this).get_Location().Y);
		if (num > num2)
		{
			if (((Control)this).get_Location().X < ((Control)form.tank).get_Location().X - ((Control)this).get_Width())
			{
				base.CurrentDirection = Direction.Right;
			}
			else
			{
				base.CurrentDirection = Direction.Left;
			}
		}
		else if (((Control)this).get_Location().Y < ((Control)form.tank).get_Location().Y - ((Control)this).get_Width())
		{
			base.CurrentDirection = Direction.Down;
		}
		else
		{
			base.CurrentDirection = Direction.Up;
		}
	}

	public override void MoveTank()
	{
		if (form.tank != null)
		{
			if (((Control)this).get_Location().X <= 0)
			{
				base.CurrentDirection = Direction.Right;
			}
			if (((Control)this).get_Location().X >= ((Control)form).get_Width() - ((Control)this).get_Width())
			{
				base.CurrentDirection = Direction.Left;
			}
			if (((Control)this).get_Location().Y <= 0)
			{
				base.CurrentDirection = Direction.Down;
			}
			if (((Control)this).get_Location().Y >= ((Control)form).get_Height() - 2 * ((Control)this).get_Height())
			{
				base.CurrentDirection = Direction.Up;
			}
			if (base.CurrentDirection == Direction.Left)
			{
				((PictureBox)this).set_Image((Image)(object)base.TankLeftImage);
				((Control)this).set_Location(new Point(((Control)this).get_Location().X - 1, ((Control)this).get_Location().Y));
			}
			if (base.CurrentDirection == Direction.Right)
			{
				((PictureBox)this).set_Image((Image)(object)base.TankRightImage);
				((Control)this).set_Location(new Point(((Control)this).get_Location().X + 1, ((Control)this).get_Location().Y));
			}
			if (base.CurrentDirection == Direction.Up)
			{
				((PictureBox)this).set_Image((Image)(object)base.TankUpImage);
				((Control)this).set_Location(new Point(((Control)this).get_Location().X, ((Control)this).get_Location().Y - 1));
			}
			if (base.CurrentDirection == Direction.Down)
			{
				((PictureBox)this).set_Image((Image)(object)base.TankDownImage);
				((Control)this).set_Location(new Point(((Control)this).get_Location().X, ((Control)this).get_Location().Y + 1));
			}
		}
	}

	public void Destroy()
	{
		((Control)form).get_Controls().Remove((Control)(object)this);
		form.enemyV2List.Remove(this);
		Animations.Explose(((Control)this).get_Location().X - ((Control)this).get_Width() / 2, ((Control)this).get_Location().Y - ((Control)this).get_Height() / 2, form);
		int num = random.Next(2);
		if (num == 1 && form.tank.HaveSplashGun)
		{
			new AmmoSplash(form, ((Control)this).get_Location().X - ((Control)this).get_Width() / 2, ((Control)this).get_Location().Y - ((Control)this).get_Height() / 2);
		}
	}
}
