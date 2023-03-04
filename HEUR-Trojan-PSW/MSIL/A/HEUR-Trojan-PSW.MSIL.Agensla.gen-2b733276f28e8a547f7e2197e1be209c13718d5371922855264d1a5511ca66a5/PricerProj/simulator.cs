using System;

namespace PricerProj;

public class simulator
{
	public static double simulate(int steps, double initialPrice, int seed, IDescretized bm)
	{
		double num = initialPrice;
		RandomGen randomGen = new RandomGen(seed);
		for (int i = 0; i < steps; i++)
		{
			num = bm.NextPrice(num, randomGen.NextDouble(bm.mean, bm.sigma));
		}
		return num;
	}

	public static double[] simulateHist(int steps, double initialPrice, int seed, IDescretized bm)
	{
		new Random();
		double[] array = new double[steps];
		RandomGen randomGen = new RandomGen(seed);
		array[0] = initialPrice;
		for (int i = 1; i < steps; i++)
		{
			array[i] = bm.NextPrice(array[i - 1], randomGen.NextDouble(bm.mean, bm.sigma));
		}
		return array;
	}
}
