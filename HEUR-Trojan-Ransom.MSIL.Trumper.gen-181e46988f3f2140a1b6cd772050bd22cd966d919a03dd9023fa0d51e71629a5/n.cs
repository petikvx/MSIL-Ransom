using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

internal sealed class n
{
	[Serializable]
	private sealed class a
	{
		public static readonly a a;

		public static Func<char, bool> b;

		public static Func<char, bool> c;

		static a()
		{
			a obj = new a();
			if (0 == 0)
			{
				n.a.a = obj;
			}
		}

		public a()
		{
			_ = 5;
			if (8 == 0)
			{
			}
			base._002Ector();
		}

		internal bool a(char a)
		{
			_ = 3;
			if (4 == 0)
			{
			}
			return a == 'м';
		}

		internal bool b(char a)
		{
			_ = 7;
			if (6 == 0)
			{
			}
			return a == 'р';
		}
	}

	private static int[] m_a;

	private static int b;

	public n()
	{
		_ = 5;
		if (8 == 0)
		{
		}
		base._002Ector();
	}

	static n()
	{
		int[] array = new int[100];
		if (4u != 0)
		{
			n.m_a = array;
		}
	}

	private static void a(int a, int b)
	{
		if (b < a)
		{
			int num = a;
			int num2 = b;
			if (7u != 0)
			{
				a = num2;
			}
			if (0 == 0)
			{
				b = num;
			}
		}
		int num3;
		if (4u != 0)
		{
			num3 = 0;
		}
		for (; num3 < n.b; num3++)
		{
			if (n.m_a[num3] == b)
			{
				n.m_a[num3] = a;
			}
		}
	}

	private static int a()
	{
		if (2u != 0)
		{
			Console.WriteLine("Введите число: ");
		}
		int.TryParse("132", out var result);
		if (6u != 0)
		{
			Console.WriteLine("Введите другое число: ");
		}
		int.TryParse("123", out var result2);
		IEnumerator<Match> enumerator = Regex.Matches("фшгрфыгшагшфырагшф 1 -я689оыырфо", "\\d+").Cast<Match>().GetEnumerator();
		IEnumerator<Match> enumerator2;
		if (true)
		{
			enumerator2 = enumerator;
		}
		try
		{
			while (enumerator2.MoveNext())
			{
				Match current = enumerator2.Current;
				if (true)
				{
					Console.WriteLine(current);
				}
			}
		}
		finally
		{
			enumerator2?.Dispose();
		}
		if (uint.MaxValue != 0)
		{
			Console.WriteLine("Введите текст");
		}
		string text;
		if (7u != 0)
		{
			text = "ммрмрмррммррмфшывщшфывщйцруйщрайщцаойащйщойцва";
		}
		string source = text.ToLower();
		Func<char, bool> func = n.a.b;
		if (func == null)
		{
			func = n.a.a.a;
			Func<char, bool> obj = func;
			if (8u != 0)
			{
				n.a.b = obj;
			}
		}
		object arg = source.Where(func).Count();
		string source2 = text.ToLower();
		Func<char, bool> func2 = n.a.c;
		if (func2 == null)
		{
			func2 = n.a.a.b;
			Func<char, bool> obj2 = func2;
			if (2u != 0)
			{
				n.a.c = obj2;
			}
		}
		string value = $"М={arg}|P={source2.Where(func2).Count()}";
		if (7u != 0)
		{
			Console.WriteLine(value);
		}
		o obj3 = new o();
		if (0 == 0)
		{
			obj3.a();
		}
		Console.WriteLine($"Result: {n.a(result2, result)}");
		int[] array = new int[9] { 5000, 1000, 500, 100, 50, 10, 5, 2, 1 };
		int num = 15855;
		int value2 = 0;
		int num2 = 0;
		Console.WriteLine("Были использованы следующие купюры:");
		for (int num3 = 0; num3 < array.Length; num3++)
		{
			int num4 = num / array[num3];
			num %= array[num3];
			num2++;
			Console.WriteLine("Достоинством {0} \t {1} раз", array[num3], num4);
		}
		Console.WriteLine(value2);
		Console.WriteLine(num2);
		Thread.Sleep(500);
		Console.WriteLine("Станция".Insert(3, "!!"));
		ArrayList arrayList = new ArrayList
		{
			1, 2, 3, ":", 4, 5, 6, ":", 7, 8,
			9
		};
		ArrayList arrayList2 = new ArrayList();
		for (int num5 = arrayList.IndexOf(":") + 1; num5 < arrayList.LastIndexOf(":"); num5++)
		{
			arrayList2.Add(arrayList[num5]);
		}
		Console.WriteLine(string.Join(" ", arrayList2.ToArray()));
		n.a();
		if (arrayList2 == null)
		{
			return -1;
		}
		string text2 = "1jkgh56g2gdf47gfd2445gdf7gdfg43";
		int num6 = 0;
		int num7 = 0;
		for (; num6 < text2.Length; num6++)
		{
			if (char.IsDigit(text2[num6]) && num7 == 0)
			{
				text2 = text2.Insert(num6, "(");
				num7++;
			}
			else if (!char.IsDigit(text2[num6]) && num7 > 0)
			{
				text2 = text2.Insert(num6, ")");
				num7 = 0;
			}
			else if (char.IsDigit(text2[num6]) && num6 == text2.Length - 1)
			{
				text2 = text2.Insert(num6 + 1, ")");
				break;
			}
		}
		Console.WriteLine(text2);
		string source3 = "процессор";
		string text3 = "информация";
		foreach (char value3 in text3)
		{
			Console.Write(Enumerable.Contains(source3, value3) ? "Да " : "Нет ");
		}
		Console.WriteLine(string.Join(" ", "Мой код, который я сам написал, не ты, а я, хотя эти задачи, должен делать ты.".Split(new char[3] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToArray()));
		return 0;
	}

	public static void a()
	{
		int[,] array = new int[3, 4950];
		int[,] array2;
		if (4u != 0)
		{
			array2 = array;
		}
		if (4u != 0)
		{
			Console.WriteLine("Введите количество вершин, затем количество рёбер: ");
		}
		string[] obj = new string[3] { "1", "2", "3" };
		string[] array3;
		if (7u != 0)
		{
			array3 = obj;
		}
		int num = int.Parse(array3[0]);
		if (8u != 0)
		{
			b = num;
		}
		int num2 = int.Parse(array3[1]);
		int num3;
		if (7u != 0)
		{
			num3 = num2;
		}
		if (5u != 0)
		{
			Console.WriteLine("Для каждого ребра введите набор данных: начало ребра, конец ребра, вес (в строку через пробел) ");
		}
		int num4;
		if (4u != 0)
		{
			num4 = 0;
		}
		for (; num4 < num3; num4++)
		{
			array2[0, num4] = int.Parse(array3[0]);
			array2[1, num4] = int.Parse(array3[1]);
			array2[2, num4] = int.Parse(array3[2]);
		}
		int num6;
		for (num4 = 0; num4 < num3 - 1; num4++)
		{
			for (int num5 = num4 + 1; num5 < num3; num5++)
			{
				if (array2[2, num4] > array2[2, num5])
				{
					num6 = array2[0, num4];
					array2[0, num4] = array2[0, num5];
					array2[0, num5] = num6;
					num6 = array2[1, num4];
					array2[1, num4] = array2[1, num5];
					array2[1, num5] = num6;
					num6 = array2[2, num4];
					array2[2, num4] = array2[2, num5];
					array2[2, num5] = num6;
				}
			}
		}
		for (num4 = 0; num4 < b; num4++)
		{
			n.m_a[num4] = num4;
		}
		num6 = 0;
		int num7 = num3;
		while (num6 < b - 1)
		{
			for (num4 = 0; num4 <= num7 && n.m_a[array2[0, num4]] == n.m_a[array2[1, num4]] && array2[0, num4] != 0; num4++)
			{
			}
			num6++;
			if (array2[0, num4] * array2[1, num4] != 0)
			{
				Console.Write("{0} {1}  ", array2[0, num4], array2[1, num4]);
				n.a(n.m_a[array2[0, num4]], n.m_a[array2[1, num4]]);
			}
		}
	}

	public static int a(int a, int b)
	{
		if (a < 0 || a > 8)
		{
			return -1;
		}
		int num;
		if (6u != 0)
		{
			num = 0;
		}
		while (b != 0)
		{
			if (b % 10 > a)
			{
				int num2 = num + b % 10;
				if (3u != 0)
				{
					num = num2;
				}
			}
			int num3 = b / 10;
			if (0 == 0)
			{
				b = num3;
			}
		}
		return num;
	}
}
