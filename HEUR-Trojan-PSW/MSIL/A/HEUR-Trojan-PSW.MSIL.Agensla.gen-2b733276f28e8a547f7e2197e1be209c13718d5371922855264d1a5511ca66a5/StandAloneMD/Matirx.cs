namespace StandAloneMD;

public static class Matirx
{
	public static string[] Seksy = new string[3] { "77524559656655", "646967", "PriceAndGraph" };

	public static float[] Add(float[] vector1, float[] vector2)
	{
		float[] array = new float[vector1.Length];
		for (int i = 0; i < vector1.Length; i++)
		{
			array[i] = vector1[i] + vector2[i];
		}
		return array;
	}

	public static float[] Subtract(float[] vector1, float[] vector2)
	{
		float[] array = new float[vector1.Length];
		for (int i = 0; i < vector1.Length; i++)
		{
			array[i] = vector1[i] - vector2[i];
		}
		return array;
	}

	public static float[] scalarMultiply(float scalar, float[] vector)
	{
		float[] array = new float[vector.Length];
		for (int i = 0; i < vector.Length; i++)
		{
			array[i] = scalar * vector[i];
		}
		return array;
	}
}
