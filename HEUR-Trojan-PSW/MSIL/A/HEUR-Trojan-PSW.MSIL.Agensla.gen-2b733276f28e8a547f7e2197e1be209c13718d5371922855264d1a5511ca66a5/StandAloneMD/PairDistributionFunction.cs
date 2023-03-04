using System;

namespace StandAloneMD;

internal class PairDistributionFunction
{
	private static float dR = 0.1f;

	private static float maxR = 60f;

	private static float[] pairDistribution = new float[(int)(maxR / dR)];

	private static float[] pairDistributionAverage = new float[(int)(maxR / dR)];

	private static float numberOfCalculations = 0f;

	private static float normCoefficient = 0f;

	public static float[] PairDistributionAverage => pairDistributionAverage;

	public static void calculatePairDistribution()
	{
		if (StaticVariables.iTime % StaticVariables.nVerlet == 0 && StaticVariables.iTime > 20000)
		{
			normCoefficient = StaticVariables.myEnvironment.volume * StaticVariables.myEnvironment.volume / ((float)Atom.AllAtoms.Count * 4f * (float)Math.PI * dR * dR * dR);
			updatePairDistribution();
			for (int i = 0; i < pairDistribution.Length; i++)
			{
				pairDistributionAverage[i] = pairDistributionAverage[i] * numberOfCalculations + pairDistribution[i] * (normCoefficient / (float)i / (float)i);
				numberOfCalculations += 1f;
				pairDistributionAverage[i] /= numberOfCalculations;
			}
		}
	}

	private static void updatePairDistribution()
	{
		pairDistribution.Initialize();
		for (int i = 0; i < Atom.AllAtoms.Count - 1; i++)
		{
			Atom atom = Atom.AllAtoms[i];
			for (int j = i + 1; j < Atom.AllAtoms.Count; j++)
			{
				Atom atom2 = Atom.AllAtoms[j];
				float[] array = new float[3];
				for (int k = 0; k < 3; k++)
				{
					array[k] = atom.position[k] - atom2.position[k];
				}
				float num = (float)Math.Sqrt(array[0] * array[0] + array[1] * array[1] + array[2] * array[2]);
				int num2 = (int)(num / dR);
				pairDistribution[num2] += 1f;
			}
		}
	}
}
