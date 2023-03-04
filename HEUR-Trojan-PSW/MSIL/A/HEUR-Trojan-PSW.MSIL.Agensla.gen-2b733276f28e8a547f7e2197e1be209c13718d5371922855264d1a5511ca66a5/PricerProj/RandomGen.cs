using System;

namespace PricerProj;

public class RandomGen
{
	private Random _rng = new Random();

	private double? _spareValue = null;

	public RandomGen(int seed)
	{
		new Random(seed);
	}

	public double NextDouble()
	{
		if (_spareValue.HasValue)
		{
			double value = _spareValue.Value;
			_spareValue = null;
			return value;
		}
		double num;
		double num2;
		double num3;
		do
		{
			num = 2.0 * _rng.NextDouble() - 1.0;
			num2 = 2.0 * _rng.NextDouble() - 1.0;
			num3 = num * num + num2 * num2;
		}
		while (num3 > 1.0 || num3 == 0.0);
		double num4 = Math.Sqrt(-2.0 * Math.Log(num3) / num3);
		_spareValue = num * num4;
		return num2 * num4;
	}

	public double NextDouble(double mu, double sigma)
	{
		return mu + NextDouble() * sigma;
	}
}
