using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PricerProj;

public class MCGenerator
{
	private IDescretized bm;

	private static object _lock = new object();

	private static object _lock2 = new object();

	public MCGenerator(double inMean, double inSigma, double inDeltaT = 1.0)
	{
		bm = new BrownianMotion(inMean, inSigma, inDeltaT);
	}

	public ConcurrentBag<double> generatePaths(double initialPrice, int numberOfPaths, double timeToExpiry)
	{
		ConcurrentBag<double> toReturn = new ConcurrentBag<double>();
		Random random = new Random(42);
		ConcurrentStack<int> concurrentStack = new ConcurrentStack<int>();
		for (int i = 0; i < numberOfPaths; i++)
		{
			concurrentStack.Push(random.Next(1, numberOfPaths - 1));
		}
		int steps = Convert.ToInt32(Math.Floor(timeToExpiry / bm.deltaT));
		Parallel.ForEach(concurrentStack, delegate(int seed)
		{
			Thread.Sleep(1);
			simulate simulate2 = simulator.simulate;
			double num = 0.0;
			num = simulate2(steps, initialPrice, seed, bm);
			toReturn.Add(num);
		});
		return toReturn;
	}

	public ConcurrentBag<double[]> generatePathsHist(double initialPrice, int numberOfPaths, double timeToExpiry)
	{
		int timeSteps = Convert.ToInt32(Math.Floor(timeToExpiry / bm.deltaT));
		ConcurrentBag<double[]> toReturn = new ConcurrentBag<double[]>();
		IEnumerable<int> source = Enumerable.Range(0, numberOfPaths);
		Random random = new Random(42);
		List<int> seeds = new List<int> { numberOfPaths };
		for (int i = 0; i < numberOfPaths; i++)
		{
			seeds.Add(random.Next(1, numberOfPaths));
		}
		Parallel.ForEach(source, new ParallelOptions
		{
			MaxDegreeOfParallelism = 1
		}, delegate(int ind)
		{
			_ = seeds[ind];
			Thread.Sleep(10);
			simulateHist simulateHist2 = simulator.simulateHist;
			double[] array = new double[timeSteps];
			array = simulateHist2(timeSteps, initialPrice, seeds[ind], bm);
			toReturn.Add(array);
		});
		return toReturn;
	}
}
