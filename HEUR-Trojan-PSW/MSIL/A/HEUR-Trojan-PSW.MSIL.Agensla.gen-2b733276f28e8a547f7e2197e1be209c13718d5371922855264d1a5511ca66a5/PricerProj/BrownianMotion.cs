using System;

namespace PricerProj;

public class BrownianMotion : IDescretized
{
	public double mean { get; set; }

	public double sigma { get; set; }

	public double deltaT { get; set; }

	public BrownianMotion(double inMean, double inSigma, double inDeltaT)
	{
		mean = inMean;
		sigma = inSigma;
		deltaT = inDeltaT;
	}

	private double PriceChange(double currentPrice, double randomMove)
	{
		return currentPrice * mean * deltaT + sigma * Math.Sqrt(deltaT) * currentPrice * randomMove;
	}

	public double NextPrice(double currentPrice, double randomMove)
	{
		return Math.Max(currentPrice + PriceChange(currentPrice, randomMove), 0.0);
	}
}
