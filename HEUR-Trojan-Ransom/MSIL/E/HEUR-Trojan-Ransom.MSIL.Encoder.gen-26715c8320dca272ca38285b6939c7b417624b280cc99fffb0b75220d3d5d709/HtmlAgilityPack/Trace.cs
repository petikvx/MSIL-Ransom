namespace HtmlAgilityPack;

internal class Trace
{
	internal static Trace _current;

	internal static Trace Current
	{
		get
		{
			if (_current == null)
			{
				_current = new Trace();
			}
			return _current;
		}
	}

	private void WriteLineIntern(string message, string category)
	{
	}

	public static void WriteLine(string message, string category)
	{
		Current.WriteLineIntern(message, category);
	}
}
