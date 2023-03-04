using System;

namespace StandAloneMD;

public class Copper : Atom
{
	public override string atomName => "Copper";

	public override int atomID => 0;

	public override float epsilon => (float)(6.537 * Math.Pow(10.0, -20.0));

	public override float sigma => 2.3374f;

	public override float massamu => 63.546f;

	public override float buck_A => 779.2f * (float)Math.Pow(10.0, -19.0);

	public override float buck_B => 4.207408f;

	public override float buck_C => 1.6768f * (float)Math.Pow(10.0, -19.0);

	public override float buck_D => 0.79840004f * (float)Math.Pow(10.0, -19.0);

	public override float Q_eff => 1.6f * (float)Math.Pow(10.0, -19.0);
}
