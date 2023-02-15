using System;
using System.Collections.Generic;

public sealed class GClass11
{
	public static List<GClass7> smethod_0(GClass2 gclass2_0, GClass7 gclass7_0, GClass7 gclass7_1)
	{
		List<GClass4> list = smethod_1(gclass2_0, gclass7_0, gclass7_1);
		List<GClass7> list2 = new List<GClass7>();
		if (list != null)
		{
			foreach (GClass4 item in list)
			{
				list2.Add(new GClass7(item.int_0, item.int_1));
			}
			return list2;
		}
		return list2;
	}

	private static List<GClass4> smethod_1(GClass2 gclass2_0, GClass7 gclass7_0, GClass7 gclass7_1)
	{
		GClass4 gClass = gclass2_0.gclass4_0[gclass7_0.int_0, gclass7_0.int_1];
		GClass4 gClass2 = gclass2_0.gclass4_0[gclass7_1.int_0, gclass7_1.int_1];
		List<GClass4> list = new List<GClass4>();
		HashSet<GClass4> hashSet = new HashSet<GClass4>();
		list.Add(gClass);
		while (true)
		{
			if (list.Count > 0)
			{
				GClass4 gClass3 = list[0];
				for (int i = 1; i < list.Count; i++)
				{
					if (list[i].method_0() < gClass3.method_0() || (list[i].method_0() == gClass3.method_0() && list[i].int_3 < gClass3.int_3))
					{
						gClass3 = list[i];
					}
				}
				list.Remove(gClass3);
				hashSet.Add(gClass3);
				if (gClass3 == gClass2)
				{
					break;
				}
				foreach (GClass4 item in gclass2_0.method_0(gClass3))
				{
					if (!item.bool_0 || hashSet.Contains(item))
					{
						continue;
					}
					int num = gClass3.int_2 + smethod_3(gClass3, item) * (int)(10f * item.float_0);
					if (num < item.int_2 || !list.Contains(item))
					{
						item.int_2 = num;
						item.int_3 = smethod_3(item, gClass2);
						item.gclass4_0 = gClass3;
						if (!list.Contains(item))
						{
							list.Add(item);
						}
					}
				}
				continue;
			}
			return null;
		}
		return smethod_2(gclass2_0, gClass, gClass2);
	}

	private static List<GClass4> smethod_2(GClass2 gclass2_0, GClass4 gclass4_0, GClass4 gclass4_1)
	{
		List<GClass4> list = new List<GClass4>();
		for (GClass4 gClass = gclass4_1; gClass != gclass4_0; gClass = gClass.gclass4_0)
		{
			list.Add(gClass);
		}
		list.Reverse();
		return list;
	}

	private static int smethod_3(GClass4 gclass4_0, GClass4 gclass4_1)
	{
		int num = Math.Abs(gclass4_0.int_0 - gclass4_1.int_0);
		int num2 = Math.Abs(gclass4_0.int_1 - gclass4_1.int_1);
		if (num > num2)
		{
			return 14 * num2 + 10 * (num - num2);
		}
		return 14 * num + 10 * (num2 - num);
	}
}
