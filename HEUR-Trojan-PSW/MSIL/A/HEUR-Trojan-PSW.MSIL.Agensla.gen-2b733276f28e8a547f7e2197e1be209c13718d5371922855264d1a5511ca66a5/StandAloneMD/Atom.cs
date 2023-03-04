using System.Collections.Generic;

namespace StandAloneMD;

public abstract class Atom
{
	protected static List<Atom> m_AllAtoms = new List<Atom>();

	public static List<Atom> templateAtoms = new List<Atom>();

	public float verletRadius = 0f;

	public List<Atom> neighborList = new List<Atom>();

	public float[] velocity = new float[3];

	public float[] position = new float[3];

	public float[] accelerationNew = new float[3];

	public float[] accelerationOld = new float[3];

	public abstract float epsilon { get; }

	public abstract float sigma { get; }

	public abstract float massamu { get; }

	public abstract string atomName { get; }

	public abstract int atomID { get; }

	public abstract float buck_A { get; }

	public abstract float buck_B { get; }

	public abstract float buck_C { get; }

	public abstract float buck_D { get; }

	public abstract float Q_eff { get; }

	public static List<Atom> AllAtoms => m_AllAtoms;

	public Atom()
	{
		m_AllAtoms.Add(this);
	}
}
