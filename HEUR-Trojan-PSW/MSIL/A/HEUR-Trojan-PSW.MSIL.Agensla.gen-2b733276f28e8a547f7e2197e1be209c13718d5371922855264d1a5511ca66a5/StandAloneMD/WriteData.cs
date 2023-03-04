using System;
using System.IO;

namespace StandAloneMD;

internal class WriteData
{
	private int writeFlag;

	private StreamWriter positionFile;

	private StreamWriter energyFile;

	private StreamWriter temperatureFile;

	public WriteData()
	{
		positionFile = new StreamWriter("position.txt");
		energyFile = new StreamWriter("energy.txt");
		temperatureFile = new StreamWriter("temperature.txt");
		writeFlag = 1;
	}

	public void WritePosition()
	{
		writeFlag--;
		if (writeFlag == 0)
		{
			for (int i = 0; i < Atom.AllAtoms.Count; i++)
			{
				Console.WriteLine("iTime = " + StaticVariables.iTime);
				energyFile.WriteLine(StaticVariables.potentialEnergy + "    " + StaticVariables.kineticEnergy);
				temperatureFile.WriteLine(StaticVariables.currentTemperature);
			}
			writeFlag = 20;
		}
	}

	public void WritePairDistribution()
	{
		StreamWriter streamWriter = new StreamWriter("pairDistribution.txt");
		for (int i = 0; i < PairDistributionFunction.PairDistributionAverage.Length; i++)
		{
			streamWriter.WriteLine(PairDistributionFunction.PairDistributionAverage[i]);
		}
	}
}
