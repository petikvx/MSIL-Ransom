using System;
using SmartAssembly.Shared;

namespace SmartAssembly.License;

public class License
{
	public static bool Validate()
	{
		return smethod_0();
	}

	public static void ValidateDLL()
	{
		smethod_0();
	}

	private static bool smethod_0()
	{
		DateTime dateTime = DateTime.Parse("2021-10-06T18:29:43");
		if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
		{
			if (AppPathFinder.ReadInstalledSaPath() == null)
			{
				try
				{
					smethod_1();
				}
				catch
				{
				}
			}
			return true;
		}
		throw new Exception(string.Format("This assembly has been built with SmartAssembly {0}, which has expired.", "Evaluation Version"));
	}

	private static void smethod_1()
	{
		Console.WriteLine("This assembly has been built with SmartAssembly {0}, and therefore cannot be distributed.", "Evaluation Version");
	}
}
