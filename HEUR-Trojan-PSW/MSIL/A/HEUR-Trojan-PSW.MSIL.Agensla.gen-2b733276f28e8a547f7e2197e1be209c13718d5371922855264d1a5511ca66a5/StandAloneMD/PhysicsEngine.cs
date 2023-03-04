using System;

namespace StandAloneMD;

public class PhysicsEngine
{
	public static void VelocityVerlet()
	{
		for (int i = 0; i < Atom.AllAtoms.Count; i++)
		{
			Atom atom = Atom.AllAtoms[i];
			for (int j = 0; j < 3; j++)
			{
				atom.position[j] = atom.position[j] + atom.velocity[j] * StaticVariables.MDTimestep + 0.5f * StaticVariables.MDTimestepSqr * atom.accelerationNew[j];
			}
			atom.accelerationOld = atom.accelerationNew;
			atom.accelerationNew = new float[3];
		}
		if (StaticVariables.currentPotential == StaticVariables.Potential.LennardJones)
		{
			if (StaticVariables.iTime % StaticVariables.nVerlet == 0)
			{
				LennardJones.calculateNeighborList();
			}
			for (int k = 0; k < Atom.AllAtoms.Count - 1; k++)
			{
				Atom atom2 = Atom.AllAtoms[k];
				for (int l = 0; l < atom2.neighborList.Count; l++)
				{
					Atom secondAtom = atom2.neighborList[l];
					LennardJones.getForce(atom2, secondAtom);
				}
			}
		}
		else if (StaticVariables.currentPotential == StaticVariables.Potential.Buckingham)
		{
			if (StaticVariables.iTime % StaticVariables.nVerlet == 0)
			{
				Buckingham.calculateNeighborList();
			}
			for (int m = 0; m < Atom.AllAtoms.Count - 1; m++)
			{
				Atom atom3 = Atom.AllAtoms[m];
				for (int n = 0; n < atom3.neighborList.Count; n++)
				{
					Atom secondAtom2 = atom3.neighborList[n];
					Buckingham.getForce(atom3, secondAtom2);
				}
			}
		}
		for (int num = 0; num < Atom.AllAtoms.Count; num++)
		{
			Atom atom4 = Atom.AllAtoms[num];
			for (int num2 = 0; num2 < 3; num2++)
			{
				atom4.velocity[num2] = atom4.velocity[num2] + 0.5f * (atom4.accelerationOld[num2] + atom4.accelerationNew[num2]) * StaticVariables.MDTimestep;
				atom4.velocity[num2] = atom4.velocity[num2] * StaticVariables.sqrtAlpha;
			}
		}
	}

	public static void ReflectFromWalls()
	{
		float[] array = new float[3]
		{
			StaticVariables.myEnvironment.depth,
			StaticVariables.myEnvironment.width,
			StaticVariables.myEnvironment.height
		};
		for (int i = 0; i < Atom.AllAtoms.Count; i++)
		{
			Atom atom = Atom.AllAtoms[i];
			for (int j = 0; j < 3; j++)
			{
				float num = Math.Sign(atom.position[j]);
				float num2 = (Math.Abs(atom.position[j]) + array[j] / 2f) % (2f * array[j]);
				if (num2 < array[j])
				{
					atom.position[j] = num2 - array[j] / 2f;
					atom.velocity[j] = atom.velocity[j];
				}
				else
				{
					atom.position[j] = 3f * array[j] / 2f - num2;
					atom.velocity[j] = -1f * atom.velocity[j];
				}
				atom.position[j] = num * atom.position[j];
			}
		}
	}

	public static void CalculateEnergy()
	{
		StaticVariables.potentialEnergy = 0f;
		StaticVariables.kineticEnergy = 0f;
		StaticVariables.currentTemperature = 0f;
		for (int i = 0; i < Atom.AllAtoms.Count - 1; i++)
		{
			Atom atom = Atom.AllAtoms[i];
			float num = atom.velocity[0] * atom.velocity[0] + atom.velocity[1] * atom.velocity[1] + atom.velocity[2] * atom.velocity[2];
			StaticVariables.kineticEnergy += 0.5f * atom.massamu * StaticVariables.amuToKg * num * StaticVariables.angstromsToMeters * StaticVariables.angstromsToMeters;
			if (StaticVariables.currentPotential == StaticVariables.Potential.LennardJones)
			{
				for (int j = 0; j < atom.neighborList.Count; j++)
				{
					Atom secondAtom = atom.neighborList[j];
					StaticVariables.potentialEnergy += LennardJones.getPotential(atom, secondAtom);
				}
			}
			else if (StaticVariables.currentPotential == StaticVariables.Potential.Buckingham)
			{
				for (int k = 0; k < atom.neighborList.Count; k++)
				{
					Atom secondAtom2 = atom.neighborList[k];
					StaticVariables.potentialEnergy += Buckingham.getPotential(atom, secondAtom2);
				}
			}
		}
		StaticVariables.currentTemperature = StaticVariables.kineticEnergy / 1.5f / (float)Atom.AllAtoms.Count / StaticVariables.kB;
		calculateSqrtAlpha();
	}

	private static void calculateSqrtAlpha()
	{
		float num = StaticVariables.desiredTemperature / StaticVariables.currentTemperature;
		float num2 = 0f;
		float num3 = 0f;
		if (StaticVariables.currentTemperature < 1E-12f)
		{
			num2 = 1f;
		}
		else if (StaticVariables.currentTemperature > 5000f)
		{
			num2 = num;
		}
		else if (num > 1f)
		{
			num3 = (StaticVariables.desiredTemperature - StaticVariables.currentTemperature) * StaticVariables.alphaDrag + StaticVariables.currentTemperature;
			num2 = num3 / StaticVariables.currentTemperature;
		}
		else if (num < 1f)
		{
			num3 = StaticVariables.currentTemperature - (StaticVariables.currentTemperature - StaticVariables.desiredTemperature) * StaticVariables.alphaDrag;
			num2 = num3 / StaticVariables.currentTemperature;
		}
		else
		{
			num2 = 1f;
		}
		StaticVariables.sqrtAlpha = (float)Math.Pow(num2, 0.5);
	}
}
