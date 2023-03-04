using System;

namespace StandAloneMD;

internal class LennardJones
{
	public static float cutoff = 2.5f;

	public static float cutoffSqr = cutoff * cutoff;

	private static float dR = 1E-06f;

	private static float rMinMultiplier = 0.75f;

	private static float[,] sigmaValues = new float[3, 3];

	private static float[,] accelCoefficient = new float[3, 3];

	private static float[] preLennardJonesForce;

	private static float[] preLennardJonesPotential;

	public static void preCompute()
	{
		for (int i = 0; i < Atom.templateAtoms.Count; i++)
		{
			Atom atom = Atom.templateAtoms[i];
			for (int j = 0; j < Atom.templateAtoms.Count; j++)
			{
				Atom atom2 = Atom.templateAtoms[j];
				float num = (float)Math.Sqrt(atom.sigma * atom2.sigma);
				sigmaValues[atom.atomID, atom2.atomID] = num;
				float num2 = 24f * atom.epsilon / (num * num * StaticVariables.angstromsToMeters * StaticVariables.angstromsToMeters * atom.massamu * StaticVariables.amuToKg);
				accelCoefficient[atom.atomID, atom2.atomID] = num2;
			}
		}
		int num3 = (int)(cutoff / dR) + 1;
		preLennardJonesForce = new float[num3];
		preLennardJonesPotential = new float[num3];
		for (int k = 0; k < num3; k++)
		{
			float distance = (float)k * dR;
			preLennardJonesForce[k] = calcForce(distance);
			preLennardJonesPotential[k] = calcPotential(distance);
		}
	}

	private static float calcForce(float distance)
	{
		float num = 1f / distance / distance;
		float num2 = num * num * num;
		float num3 = 1f / cutoff / cutoff;
		float num4 = num3 * num3 * num3;
		float num5 = rMinMultiplier;
		float num6 = 0f;
		if (distance > num5)
		{
			return num * (2f * num2 * num2 - num2 - num3 / num * (2f * num4 * num4 - num4));
		}
		float num7 = 1f / num5;
		float num8 = num7 * num7;
		float num9 = num8 * num8 * num8;
		float num10 = num8 * (2f * num9 * num9 - num9 - num3 / num8 * (2f * num4 * num4 - num4));
		float num11 = num5 / 1.5f;
		float num12 = 1f / num11 / num11;
		float num13 = num12 * num12 * num12;
		float num14 = num12 * (2f * num13 * num13 - num13 - num3 / num12 * (2f * num4 * num4 - num4));
		float num15 = distance / num5 * (float)Math.Exp(distance - num5);
		float num16 = num14 - num10;
		return num14 - num15 * num16;
	}

	private static float calcPotential(float distance)
	{
		float num = 1f / distance / distance;
		float num2 = num * num * num;
		float num3 = 1f / cutoff / cutoff;
		float num4 = num3 * num3 * num3;
		float result = 0f;
		if (distance > 0f)
		{
			result = 4f * (num2 * num2 - num2 + (6f * num4 * num4 - 3f * num4) * (num3 / num) - 7f * num4 * num4 + 4f * num4);
		}
		return result;
	}

	public static void getForce(Atom firstAtom, Atom secondAtom)
	{
		float[] array = new float[3];
		for (int i = 0; i < 3; i++)
		{
			array[i] = firstAtom.position[i] - secondAtom.position[i];
		}
		float num = array[0] * array[0] + array[1] * array[1] + array[2] * array[2];
		float num2 = sigmaValues[firstAtom.atomID, secondAtom.atomID];
		float num3 = num / num2 / num2;
		if (num3 <= cutoffSqr)
		{
			int num4 = (int)((float)Math.Sqrt(num3) / dR);
			for (int j = 0; j < 3; j++)
			{
				firstAtom.accelerationNew[j] = firstAtom.accelerationNew[j] + preLennardJonesForce[num4] * accelCoefficient[firstAtom.atomID, secondAtom.atomID] * array[j];
				secondAtom.accelerationNew[j] = secondAtom.accelerationNew[j] - preLennardJonesForce[num4] * accelCoefficient[secondAtom.atomID, firstAtom.atomID] * array[j];
			}
		}
	}

	public static float getPotential(Atom firstAtom, Atom secondAtom)
	{
		float result = 0f;
		float[] array = new float[3];
		for (int i = 0; i < 3; i++)
		{
			array[i] = firstAtom.position[i] - secondAtom.position[i];
		}
		float num = array[0] * array[0] + array[1] * array[1] + array[2] * array[2];
		float num2 = sigmaValues[firstAtom.atomID, secondAtom.atomID];
		float num3 = num / num2 / num2;
		if (num3 <= cutoffSqr)
		{
			int num4 = (int)((float)Math.Sqrt(num3) / dR);
			result = firstAtom.epsilon * preLennardJonesPotential[num4];
		}
		return result;
	}

	public static void calculateVerletRadius()
	{
		for (int i = 0; i < Atom.AllAtoms.Count - 1; i++)
		{
			Atom atom = Atom.AllAtoms[i];
			atom.verletRadius = cutoff + 1f;
		}
	}

	public static void calculateNeighborList()
	{
		for (int i = 0; i < Atom.AllAtoms.Count - 1; i++)
		{
			Atom atom = Atom.AllAtoms[i];
			atom.neighborList.Clear();
		}
		for (int j = 0; j < Atom.AllAtoms.Count - 1; j++)
		{
			Atom atom2 = Atom.AllAtoms[j];
			for (int k = j + 1; k < Atom.AllAtoms.Count; k++)
			{
				Atom atom3 = Atom.AllAtoms[k];
				float[] array = new float[3];
				for (int l = 0; l < 3; l++)
				{
					array[l] = atom2.position[l] - atom3.position[l];
				}
				float num = array[0] * array[0] + array[1] * array[1] + array[2] * array[2];
				float num2 = sigmaValues[atom2.atomID, atom3.atomID];
				float num3 = num / num2 / num2;
				if (num3 < atom2.verletRadius * atom2.verletRadius)
				{
					atom2.neighborList.Add(atom3);
				}
			}
		}
	}
}
