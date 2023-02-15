namespace System.IO;

internal struct RowConfigReader
{
	private readonly string _buffer;

	private readonly StringComparison _comparisonKind;

	private int _currentIndex;

	public RowConfigReader(string buffer)
	{
		_buffer = buffer;
		_comparisonKind = StringComparison.Ordinal;
		_currentIndex = 0;
	}

	public RowConfigReader(string buffer, StringComparison comparisonKind)
	{
		_buffer = buffer;
		_comparisonKind = comparisonKind;
		_currentIndex = 0;
	}

	public string GetNextValue(string key)
	{
		if (!TryGetNextValue(key, out var value))
		{
			throw new InvalidOperationException("Couldn't get next value with key " + key);
		}
		return value;
	}

	public bool TryGetNextValue(string key, out string value)
	{
		if (_currentIndex >= _buffer.Length)
		{
			value = null;
			return false;
		}
		if (!TryFindNextKeyOccurrence(key, _currentIndex, out var keyIndex))
		{
			value = null;
			return false;
		}
		int startIndex = keyIndex + key.Length;
		int num = _buffer.IndexOf(Environment.NewLine, startIndex, _comparisonKind);
		int num2;
		if (num == -1)
		{
			num = _buffer.Length - 1;
			num2 = num;
		}
		else
		{
			num2 = num - 1;
		}
		int count = num - keyIndex;
		int num3 = _buffer.LastIndexOf('\t', num, count);
		if (num3 == -1)
		{
			num3 = _buffer.LastIndexOf(' ', num, count);
		}
		int num4 = num3 + 1;
		int num5 = num2 - num3;
		if (num4 > keyIndex && num4 != -1 && num5 != 0)
		{
			value = _buffer.Substring(num4, num5);
			_currentIndex = num + 1;
			return true;
		}
		value = null;
		return false;
	}

	private bool TryFindNextKeyOccurrence(string key, int startIndex, out int keyIndex)
	{
		while (true)
		{
			keyIndex = _buffer.IndexOf(key, startIndex, _comparisonKind);
			if (keyIndex != -1)
			{
				if ((keyIndex == 0 || (keyIndex >= Environment.NewLine.Length && _buffer.Substring(keyIndex - Environment.NewLine.Length, Environment.NewLine.Length) == Environment.NewLine)) && HasFollowingWhitespace(keyIndex, key.Length))
				{
					break;
				}
				startIndex += key.Length;
				continue;
			}
			return false;
		}
		return true;
	}

	private bool HasFollowingWhitespace(int keyIndex, int length)
	{
		if (keyIndex + length < _buffer.Length)
		{
			if (_buffer[keyIndex + length] != ' ')
			{
				return _buffer[keyIndex + length] == '\t';
			}
			return true;
		}
		return false;
	}

	public int GetNextValueAsInt32(string key)
	{
		string nextValue = GetNextValue(key);
		if (!int.TryParse(nextValue, out var result))
		{
			throw new InvalidOperationException("Unable to parse value " + nextValue + " of key " + key + " as an Int32.");
		}
		return result;
	}

	public static string ReadFirstValueFromString(string data, string key)
	{
		return new RowConfigReader(data).GetNextValue(key);
	}
}
