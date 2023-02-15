using System.Collections.Generic;

public sealed class GClass2
{
	public GClass4[,] gclass4_0;

	private int int_0;

	private int int_1;

	public GClass2(int int_2, int int_3, float[,] float_0)
	{
		int_0 = int_2;
		int_1 = int_3;
		gclass4_0 = new GClass4[int_2, int_3];
		for (int i = 0; i < int_2; i++)
		{
			for (int j = 0; j < int_3; j++)
			{
				gclass4_0[i, j] = new GClass4(float_0[i, j], i, j);
			}
		}
	}

	public GClass2(int int_2, int int_3, bool[,] bool_0)
	{
		int_0 = int_2;
		int_1 = int_3;
		gclass4_0 = new GClass4[int_2, int_3];
		for (int i = 0; i < int_2; i++)
		{
			for (int j = 0; j < int_3; j++)
			{
				gclass4_0[i, j] = new GClass4(bool_0[i, j] ? 1f : 0f, i, j);
			}
		}
	}

	public List<GClass4> method_0(GClass4 gclass4_1)
	{
		List<GClass4> list = new List<GClass4>();
		for (int i = -1; i <= 1; i++)
		{
			for (int j = -1; j <= 1; j++)
			{
				if (i != 0 || j != 0)
				{
					int num = gclass4_1.int_0 + i;
					int num2 = gclass4_1.int_1 + j;
					if (num >= 0 && num < int_0 && num2 >= 0 && num2 < int_1)
					{
						list.Add(gclass4_0[num, num2]);
					}
				}
			}
		}
		return list;
	}
}
