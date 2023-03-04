using System;

namespace StandAloneMD;

public class CreateEnvironment
{
	public int numAtoms = 100;

	public float width;

	public float height;

	public float depth;

	public float volume;

	private Random rnd = new Random();

	public void PreCompute()
	{
		Atom.templateAtoms.Add(new Copper());
		Atom.templateAtoms.Add(new Gold());
		Atom.templateAtoms.Add(new Platinum());
		for (int i = 0; i < Atom.templateAtoms.Count; i++)
		{
			Atom.AllAtoms.Clear();
		}
		if (StaticVariables.currentPotential == StaticVariables.Potential.LennardJones)
		{
			LennardJones.preCompute();
		}
		if (StaticVariables.currentPotential == StaticVariables.Potential.Buckingham)
		{
			Buckingham.preCompute();
		}
	}

	public void InitAtoms()
	{
		width = 30f;
		depth = 30f;
		height = 30f;
		volume = width * depth * height;
		if (StaticVariables.currentPotential == StaticVariables.Potential.LennardJones)
		{
			for (int i = 0; i < numAtoms; i++)
			{
				Atom atom = new Copper();
				bool flag = false;
				while (!flag)
				{
					float num = 3f * (float)Math.Pow(10.0, 12.0);
					atom.velocity = new float[3]
					{
						randomFloat(-1f * num, 1f * num),
						randomFloat(-1f * num, 1f * num),
						randomFloat(-1f * num, 1f * num)
					};
					atom.position = new float[3]
					{
						randomFloat((0f - depth) / 2f, depth / 2f),
						randomFloat((0f - width) / 2f, width / 2f),
						randomFloat((0f - height) / 2f, height / 2f)
					};
					flag = checkProximity(atom);
				}
			}
		}
		else if (StaticVariables.currentPotential == StaticVariables.Potential.Buckingham)
		{
			for (int j = 0; j < numAtoms / 2; j++)
			{
				Atom atom2 = new Copper();
				bool flag2 = false;
				while (!flag2)
				{
					atom2.velocity = new float[3];
					atom2.position = new float[3]
					{
						randomFloat((0f - depth) / 2f, depth / 2f),
						randomFloat((0f - width) / 2f, width / 2f),
						randomFloat((0f - height) / 2f, height / 2f)
					};
					flag2 = checkProximity(atom2);
				}
			}
			for (int k = numAtoms / 2; k < numAtoms; k++)
			{
				Atom atom3 = new Gold();
				bool flag3 = false;
				while (!flag3)
				{
					atom3.velocity = new float[3];
					atom3.position = new float[3]
					{
						randomFloat((0f - depth) / 2f, depth / 2f),
						randomFloat((0f - width) / 2f, width / 2f),
						randomFloat((0f - height) / 2f, height / 2f)
					};
					flag3 = checkProximity(atom3);
				}
			}
		}
		width = 30f;
		depth = 30f;
		height = 30f;
		volume = width * depth * height;
	}

	private float randomFloat(float minValue, float maxValue)
	{
		return (maxValue - minValue) * (float)rnd.NextDouble() + minValue;
	}

	private bool checkProximity(Atom currAtom)
	{
		bool result = true;
		for (int i = 0; i < Atom.AllAtoms.Count - 1; i++)
		{
			float num = 2f;
			Atom atom = Atom.AllAtoms[i];
			float[] array = new float[3];
			for (int j = 0; j < 3; j++)
			{
				array[j] = currAtom.position[j] - atom.position[j];
			}
			float num2 = array[0] * array[0] + array[1] * array[1] + array[2] * array[2];
			if (num2 < num * num)
			{
				result = false;
			}
		}
		return result;
	}
}
