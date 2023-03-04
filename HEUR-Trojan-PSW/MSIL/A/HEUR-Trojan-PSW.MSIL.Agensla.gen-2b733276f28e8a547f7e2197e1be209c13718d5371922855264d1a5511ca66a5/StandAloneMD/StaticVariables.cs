using System;

namespace StandAloneMD;

public class StaticVariables
{
	public enum Potential
	{
		LennardJones,
		Buckingham
	}

	public static float MDTimestep = 0.5f * (float)Math.Pow(10.0, -15.0);

	public static float MDTimestepSqr = MDTimestep * MDTimestep;

	public static float fixedDeltaTime = MDTimestep;

	public static float currentTime = 0f;

	public static int iTime = 0;

	public static float alphaDrag = 0.001f;

	public static float kB = 1.381f * (float)Math.Pow(10.0, -23.0);

	public static float epsilon0 = 8.85f * (float)Math.Pow(10.0, -12.0);

	public static float amuToKg = 1.6605f * (float)Math.Pow(10.0, -27.0);

	public static float mass100amuToKg = 100f * amuToKg;

	public static float angstromsToMeters = (float)Math.Pow(10.0, -10.0);

	public static int nVerlet = 100;

	public static float tempRangeLow = 0.01f;

	public static float tempRangeHigh = 5000f;

	public static float desiredTemperature = 300f;

	public static Potential currentPotential = Potential.Buckingham;

	public static CreateEnvironment myEnvironment;

	public static float kineticEnergy = 0f;

	public static float potentialEnergy = 0f;

	public static float currentTemperature = 0f;

	public static float sqrtAlpha = 1f;
}
