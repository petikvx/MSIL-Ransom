using System;

namespace StandAloneMD;

public class Gold : Atom
{
	public override string atomName => "Gold";

	public override int atomID => 1;

	public override float epsilon => 7116.155f * (float)Math.Pow(10.0, -23.0);

	public override float sigma => 2.6367f;

	public override float massamu => 196.967f;

	public override float buck_A => (float)Math.PI * 206659f * (float)Math.Pow(10.0, -19.0);

	public override float buck_B => 4.207408f;

	public override float buck_C => 115.840004f * (float)Math.Pow(10.0, -19.0);

	public override float buck_D => 232.68001f * (float)Math.Pow(10.0, -19.0);

	public override float Q_eff => -1.6f * (float)Math.Pow(10.0, -19.0);
}
