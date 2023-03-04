using System;
using System.Drawing;
using System.Windows.Forms;

namespace TankBattle;

internal interface IEnemy
{
	Bitmap TankUpImage { get; set; }

	Bitmap TankDownImage { get; set; }

	Bitmap TankLeftImage { get; set; }

	Bitmap TankRightImage { get; set; }

	Timer TimerDirectionGenerate { get; set; }

	Timer TimerTankAutoFire { get; set; }

	Timer TimerTankMove { get; set; }

	int HP { get; set; }

	object Tag { get; set; }

	void TimerDirectionGenerate_Tick(object sender, EventArgs e);

	void TimerTankMove_Tick(object sender, EventArgs e);

	void TimerTankAutoFire_Tick(object sender, EventArgs e);

	void MoveTank();

	void Destroy();

	void AddTankOnForm();
}
