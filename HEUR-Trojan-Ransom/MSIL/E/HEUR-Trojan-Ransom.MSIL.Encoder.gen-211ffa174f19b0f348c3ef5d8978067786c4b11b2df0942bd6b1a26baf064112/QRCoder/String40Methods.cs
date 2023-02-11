namespace QRCoder;

internal static class String40Methods
{
	public static bool IsNullOrWhiteSpace(string value)
	{
		if (value == null)
		{
			return true;
		}
		int num = 0;
		while (true)
		{
			if (num < value.Length)
			{
				if (!char.IsWhiteSpace(value[num]))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}

	public static string ReverseString(string str)
	{
		char[] array = str.ToCharArray();
		char[] array2 = new char[array.Length];
		int num = 0;
		int num2 = str.Length - 1;
		while (num < str.Length)
		{
			array2[num] = array[num2];
			num++;
			num2--;
		}
		return new string(array2);
	}

	public static bool IsAllDigit(string str)
	{
		int num = 0;
		while (true)
		{
			if (num < str.Length)
			{
				char c = str[num];
				if (!char.IsDigit(c))
				{
					break;
				}
				num++;
				continue;
			}
			return true;
		}
		return false;
	}
}
