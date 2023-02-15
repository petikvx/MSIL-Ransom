using System.Text;
using System.Text.RegularExpressions;

namespace SharpHound3.JSON;

internal class ComputerStatus
{
	internal string ComputerName { get; set; }

	internal string Task { get; set; }

	internal string Status { get; set; }

	internal string ToCsv()
	{
		return StringToCsvCell(ComputerName) + ", " + StringToCsvCell(Task) + ", " + StringToCsvCell(Status);
	}

	private static string StringToCsvCell(string str)
	{
		if (str == null)
		{
			return null;
		}
		str = Regex.Replace(str, "\\t|\\n|\\r", "");
		if (!str.Contains(",") && !str.Contains("\"") && !str.Contains("\r") && !str.Contains("\n"))
		{
			return str;
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("\"");
		string text = str;
		foreach (char c in text)
		{
			stringBuilder.Append(c);
			if (c == '"')
			{
				stringBuilder.Append("\"");
			}
		}
		stringBuilder.Append("\"");
		return stringBuilder.ToString();
	}
}
