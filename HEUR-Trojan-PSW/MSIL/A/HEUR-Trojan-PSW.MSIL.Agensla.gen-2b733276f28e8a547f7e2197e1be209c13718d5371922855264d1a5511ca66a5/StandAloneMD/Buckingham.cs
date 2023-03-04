using System;

namespace StandAloneMD;

internal class Buckingham
{
	private static float cutoff = 10f;

	private static float cutoffSqr = cutoff * cutoff;

	private static float rSpline = cutoff - 2f;

	private static float dR = 0.0001f;

	private static float[,,] preBuckinghamAcceleration;

	private static float[,,] PreBuckinghamPotential;

	private static float[,] coeff_A = new float[3, 3];

	private static float[,] coeff_B = new float[3, 3];

	private static float[,] coeff_C = new float[3, 3];

	private static float[,] coeff_D = new float[3, 3];

	public static void preCompute()
	{
		int num = (int)(cutoff / dR) + 1;
		preBuckinghamAcceleration = new float[3, 3, num];
		PreBuckinghamPotential = new float[3, 3, num];
		for (int i = 0; i < Atom.templateAtoms.Count; i++)
		{
			Atom atom = Atom.templateAtoms[i];
			for (int j = 0; j < Atom.templateAtoms.Count; j++)
			{
				Atom atom2 = Atom.templateAtoms[j];
				float num2 = (float)Math.Sqrt(atom.buck_A * atom2.buck_A);
				coeff_A[atom.atomID, atom2.atomID] = num2;
				float num3 = (float)Math.Sqrt(atom.buck_B * atom2.buck_B);
				coeff_B[atom.atomID, atom2.atomID] = num3;
				float num4 = (float)Math.Sqrt(atom.buck_C * atom2.buck_C);
				coeff_C[atom.atomID, atom2.atomID] = num4;
				float num5 = (float)Math.Sqrt(atom.buck_D * atom2.buck_D);
				coeff_D[atom.atomID, atom2.atomID] = num5;
				for (int k = 0; k < num; k++)
				{
					float num6 = (float)k * dR;
					if (num6 < 0.5f)
					{
						num6 = 0.5f;
					}
					preBuckinghamAcceleration[atom.atomID, atom2.atomID, k] = calcAcceleration(num6, atom, atom2);
					PreBuckinghamPotential[atom.atomID, atom2.atomID, k] = calcPotential(num6, atom, atom2);
				}
			}
		}
	}

	private static float calcAcceleration(float distance, Atom firstAtom, Atom secondAtom)
	{
		float num = 1f / distance / distance;
		float num2 = num * num * num;
		float num3 = num2 / distance;
		float num4 = num * num * num * num;
		float num5 = num4 / distance;
		float num6 = 1f / rSpline / rSpline;
		float num7 = num6 * num6 * num6;
		float num8 = num7 / rSpline;
		float num9 = num8 / rSpline;
		float num10 = num9 / rSpline;
		float num11 = coeff_A[firstAtom.atomID, secondAtom.atomID];
		float num12 = coeff_B[firstAtom.atomID, secondAtom.atomID];
		float num13 = coeff_C[firstAtom.atomID, secondAtom.atomID];
		float num14 = coeff_D[firstAtom.atomID, secondAtom.atomID];
		float num15 = num11 * (float)Math.Exp((0f - num12) * rSpline) - num13 * num7 - num14 * num9 + firstAtom.Q_eff * secondAtom.Q_eff / (4f * StaticVariables.epsilon0 * (float)Math.PI * StaticVariables.angstromsToMeters) / rSpline;
		float num16 = 0f;
		float num17 = (0f - num11) * num12 * (float)Math.Exp((0f - num12) * rSpline) + 6f * num13 * num8 + 8f * num14 * num10 - firstAtom.Q_eff * secondAtom.Q_eff / (4f * StaticVariables.epsilon0 * (float)Math.PI * StaticVariables.angstromsToMeters) * num6;
		float num18 = 0f;
		float num19 = 0f;
		if (distance <= rSpline)
		{
			num19 = (0f - num11) * num12 * (float)Math.Exp((0f - num12) * distance) / StaticVariables.angstromsToMeters + 6f * num13 * num3 / StaticVariables.angstromsToMeters + 8f * num14 * num5 / StaticVariables.angstromsToMeters - firstAtom.Q_eff * secondAtom.Q_eff / (4f * StaticVariables.epsilon0 * (float)Math.PI * StaticVariables.angstromsToMeters * StaticVariables.angstromsToMeters) * num;
		}
		else if (distance <= cutoff)
		{
			float num20 = (distance - rSpline) / (cutoff - rSpline);
			float num21 = num17 * (cutoff - rSpline) - (num16 - num15);
			float num22 = (0f - num18) * (cutoff - rSpline) + (num16 - num15);
			num19 = (0f - num15 + num16 + (1f - 2f * num20) * (num21 * (1f - num20) + num22 * num20) + (num20 - num20 * num20) * (num22 - num21)) / (cutoff - rSpline) / StaticVariables.angstromsToMeters;
		}
		else
		{
			num19 = 0f;
		}
		float num23 = -1f * num19 / distance;
		return num23 / (firstAtom.massamu * StaticVariables.amuToKg * StaticVariables.angstromsToMeters);
	}

	private static float calcPotential(float distance, Atom firstAtom, Atom secondAtom)
	{
		float num = 1f / distance / distance;
		float num2 = num * num * num;
		float num3 = num * num * num * num;
		float num4 = 1f / rSpline / rSpline;
		float num5 = num4 * num4 * num4;
		float num6 = num5 / rSpline;
		float num7 = num6 / rSpline;
		float num8 = num7 / rSpline;
		float num9 = coeff_A[firstAtom.atomID, secondAtom.atomID];
		float num10 = coeff_B[firstAtom.atomID, secondAtom.atomID];
		float num11 = coeff_C[firstAtom.atomID, secondAtom.atomID];
		float num12 = coeff_D[firstAtom.atomID, secondAtom.atomID];
		float num13 = num9 * (float)Math.Exp((0f - num10) * rSpline) - num11 * num5 - num12 * num7 + firstAtom.Q_eff * secondAtom.Q_eff / (4f * StaticVariables.epsilon0 * (float)Math.PI * StaticVariables.angstromsToMeters) / rSpline;
		float num14 = 0f;
		float num15 = (0f - num9) * num10 * (float)Math.Exp((0f - num10) * rSpline) + 6f * num11 * num6 + 8f * num12 * num8 - firstAtom.Q_eff * secondAtom.Q_eff / (4f * StaticVariables.epsilon0 * (float)Math.PI * StaticVariables.angstromsToMeters) * num4;
		float num16 = 0f;
		float num17 = 0f;
		if (distance <= rSpline)
		{
			return num9 * (float)Math.Exp((0f - num10) * distance) - num11 * num2 - num12 * num3 + firstAtom.Q_eff * secondAtom.Q_eff / (4f * StaticVariables.epsilon0 * (float)Math.PI * StaticVariables.angstromsToMeters) / distance;
		}
		if (distance <= cutoff)
		{
			float num18 = (distance - rSpline) / (cutoff - rSpline);
			float num19 = num15 * (cutoff - rSpline) - (num14 - num13);
			float num20 = (0f - num16) * (cutoff - rSpline) + (num14 - num13);
			return (1f - num18) * num13 + num18 * num14 + num18 * (1f - num18) * (num19 * (1f - num18) + num20 * num18);
		}
		return 0f;
	}

	public static void getForce(Atom firstAtom, Atom secondAtom)
	{
		float[] array = new float[3];
		for (int i = 0; i < 3; i++)
		{
			array[i] = firstAtom.position[i] - secondAtom.position[i];
		}
		float num = array[0] * array[0] + array[1] * array[1] + array[2] * array[2];
		if (num <= cutoffSqr)
		{
			int num2 = (int)((float)Math.Sqrt(num) / dR);
			for (int j = 0; j < 3; j++)
			{
				firstAtom.accelerationNew[j] = firstAtom.accelerationNew[j] + preBuckinghamAcceleration[firstAtom.atomID, secondAtom.atomID, num2] * array[j];
				secondAtom.accelerationNew[j] = secondAtom.accelerationNew[j] - preBuckinghamAcceleration[secondAtom.atomID, firstAtom.atomID, num2] * array[j];
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
		if (num <= cutoffSqr)
		{
			int num2 = (int)((float)Math.Sqrt(num) / dR);
			result = (PreBuckinghamPotential[firstAtom.atomID, secondAtom.atomID, num2] + PreBuckinghamPotential[firstAtom.atomID, secondAtom.atomID, num2]) / 2f;
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
				if (num < atom2.verletRadius * atom2.verletRadius)
				{
					atom2.neighborList.Add(atom3);
				}
			}
		}
	}
}
