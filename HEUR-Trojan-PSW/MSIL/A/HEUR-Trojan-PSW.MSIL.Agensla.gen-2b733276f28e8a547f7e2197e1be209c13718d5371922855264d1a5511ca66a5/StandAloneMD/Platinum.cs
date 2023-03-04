using System;

namespace StandAloneMD;

public class Platinum : Atom
{
	public override string atomName => "Platinum";

	public override int atomID => 2;

	public override float epsilon => (float)(1.0922 * Math.Pow(10.0, -19.0));

	public override float sigma => 2.5394f;

	public override float massamu => 195.084f;

	public override float buck_A => 0f;

	public override float buck_B => 0f;

	public override float buck_C => 0f;

	public override float buck_D => 0f;

	public override float Q_eff => 0f;
}
