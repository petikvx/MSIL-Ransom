using System;
using System.Drawing;
using System.Windows.Forms;

namespace TankBattle;

public class EnemyBoss1 : Tank, IEnemy
{
	private ProgressBar progressHP;

	private int hp = 10;

	public Timer TimerDirectionGenerate { get; set; } = new Timer();


	public Timer TimerTankAutoFire { get; set; } = new Timer();


	public Timer TimerTankMove { get; set; } = new Timer();


	public override int HP
	{
		get
		{
			return hp;
		}
		set
		{
			hp = value;
			progressHP.set_Value(hp);
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

	public EnemyBoss1(Form1 form, int speed, int xLocation, int yLocation)
		: base(form, speed, xLocation, yLocation)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		((Control)this).set_Tag((object)"EnemyBoss1");
		((Control)this).set_Size(new Size(50, 50));
		progressHP = new ProgressBar();
		((Control)progressHP).set_Size(new Size(((Control)form).get_Width(), 20));
		progressHP.set_Maximum(HP);
		progressHP.set_Value(HP);
		progressHP.set_Step(HP / 10);
		((Control)progressHP).set_Location(new Point(0, 0));
		TimerDirectionGenerate = new Timer();
		TimerDirectionGenerate.set_Interval(325);
		TimerDirectionGenerate.add_Tick((EventHandler)TimerDirectionGenerate_Tick);
		TimerTankAutoFire = new Timer();
		TimerTankAutoFire.set_Interval(777);
		TimerTankAutoFire.add_Tick((EventHandler)TimerTankAutoFire_Tick);
		TimerTankMove = new Timer();
		TimerTankMove.set_Interval(speed);
		TimerTankMove.add_Tick((EventHandler)TimerTankMove_Tick);
	}

	public override void AddTankOnForm()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		base.TankDownImage = (Bitmap)Image.FromFile("Boss\\boss1.png");
		((PictureBox)this).set_Image((Image)(object)base.TankDownImage);
		((Control)form).get_Controls().Add((Control)(object)progressHP);
		((Control)form).get_Controls().Add((Control)(object)this);
		TimerDirectionGenerate.Start();
		TimerTankAutoFire.Start();
		TimerTankMove.Start();
	}

	public void TimerDirectionGenerate_Tick(object sender, EventArgs e)
	{
		if (form.tank == null || HP < 1)
		{
			TimerTankAutoFire.Stop();
			TimerDirectionGenerate.Stop();
			TimerTankMove.Stop();
		}
		else if (((Control)this).get_Location().X + ((Control)this).get_Width() / 2 < ((Control)form.tank).get_Location().X + ((Control)form.tank).get_Width() / 2)
		{
			base.CurrentDirection = Direction.Right;
		}
		else if (((Control)this).get_Location().X + ((Control)this).get_Width() / 2 > ((Control)form.tank).get_Location().X + ((Control)form.tank).get_Width() / 2)
		{
			base.CurrentDirection = Direction.Left;
		}
		else
		{
			base.CurrentDirection = Direction.Stop;
		}
	}

	public void TimerTankAutoFire_Tick(object sender, EventArgs e)
	{
		((PictureBox)this).set_Image((Image)(object)base.TankLeftImage);
		Fire(new Bullet(form, this, 17, 17, 10, "Bullet\\bullet.png"));
		((PictureBox)this).set_Image((Image)(object)base.TankRightImage);
		Fire(new Bullet(form, this, 17, 17, 10, "Bullet\\bullet.png"));
		((PictureBox)this).set_Image((Image)(object)base.TankDownImage);
		FireSplash(new BulletSplash(form, this, 8, 32, 4, "Bullet\\bulletSplash.png"));
	}

	public void TimerTankMove_Tick(object sender, EventArgs e)
	{
		MoveTank();
	}

	public override void MoveTank()
	{
		if (form.tank != null)
		{
			if (base.CurrentDirection == Direction.Left)
			{
				((PictureBox)this).set_Image((Image)(object)base.TankDownImage);
				((Control)this).set_Location(new Point(((Control)this).get_Location().X - 5, ((Control)this).get_Location().Y));
			}
			if (base.CurrentDirection == Direction.Right)
			{
				((PictureBox)this).set_Image((Image)(object)base.TankDownImage);
				((Control)this).set_Location(new Point(((Control)this).get_Location().X + 5, ((Control)this).get_Location().Y));
			}
		}
	}

	public void Destroy()
	{
		((Control)form).get_Controls().Remove((Control)(object)progressHP);
		((Control)form).get_Controls().Remove((Control)(object)this);
		Animations.Explose(((Control)this).get_Location().X - ((Control)this).get_Width() / 2, ((Control)this).get_Location().Y - ((Control)this).get_Height() / 2, form);
	}
}
