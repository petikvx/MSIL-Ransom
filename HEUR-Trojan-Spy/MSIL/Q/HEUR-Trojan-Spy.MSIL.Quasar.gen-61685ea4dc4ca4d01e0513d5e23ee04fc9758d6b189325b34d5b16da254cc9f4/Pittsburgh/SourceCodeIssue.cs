using System.Collections.Generic;
using System.Text;

namespace Pittsburgh;

public class SourceCodeIssue
{
	private string _filePath;

	private int _lineNumber;

	private string _offendingLine;

	private string _codeBefore;

	private string _codeAfter;

	private Rule _rule;

	internal string FilePath
	{
		get
		{
			return _filePath;
		}
		set
		{
			_filePath = value;
		}
	}

	internal int LineNumber
	{
		get
		{
			return _lineNumber;
		}
		set
		{
			_lineNumber = value;
		}
	}

	internal string OffendingLine
	{
		get
		{
			return _offendingLine;
		}
		set
		{
			_offendingLine = value;
		}
	}

	internal string CodeBefore
	{
		get
		{
			return _codeBefore;
		}
		set
		{
			_codeBefore = value;
		}
	}

	internal string CodeAfter
	{
		get
		{
			return _codeAfter;
		}
		set
		{
			_codeAfter = value;
		}
	}

	internal Rule RulePattern
	{
		get
		{
			return _rule;
		}
		set
		{
			_rule = value;
		}
	}

	public string GenerateSmallHTMLSnippet()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("<div>" + _rule.Title + "<br/>");
		stringBuilder.Append(_lineNumber + ": ");
		stringBuilder.Append("<code>" + HtmlEncode(_offendingLine) + "</code></div>");
		return stringBuilder.ToString();
	}

	public string GenerateHTMLSnippet()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(_rule.GenerateHTMLSnippet());
		stringBuilder.Append("<h2>Code</h2>");
		stringBuilder.Append("<div>" + _filePath + ":");
		stringBuilder.Append("<strong>" + _lineNumber + "</strong><br />");
		stringBuilder.Append("<strong>Offending Line: <br /><strong><code>" + HtmlEncode(_offendingLine) + "</strong></code></strong><hr />");
		stringBuilder.Append("<pre><code>");
		stringBuilder.Append(HtmlEncode(_codeBefore));
		stringBuilder.Append("<span class=\"offendingLine\">" + HtmlEncode(_offendingLine) + "</span>\r\n");
		stringBuilder.Append(HtmlEncode(_codeAfter));
		stringBuilder.Append("</code></pre></div>");
		return stringBuilder.ToString();
	}

	private string HtmlEncode(string _offendingLine)
	{
		return _offendingLine.Replace("&", "&amp;").Replace(">", "&gt;").Replace("<", "&lt;")
			.Replace("\"", "&quot;");
	}

	public string GenerateMarkDown()
	{
		return "";
	}

	public string GenerateCsv()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(PrepareCSVString(_rule.Title));
		stringBuilder.Append(PrepareCSVString(_rule.Type));
		stringBuilder.Append(PrepareCSVString(_rule.Severity));
		stringBuilder.Append(PrepareCSVString(_rule.RegexSearchPattern));
		stringBuilder.Append(PrepareCSVString(_rule.Description));
		stringBuilder.Append(PrepareCSVString(_rule.ExtensionList()));
		stringBuilder.Append(PrepareCSVString(_filePath));
		stringBuilder.Append(_lineNumber);
		stringBuilder.Append(PrepareCSVString(_offendingLine));
		stringBuilder.Append(PrepareCSVString(_codeBefore));
		stringBuilder.Append(PrepareCSVString(_offendingLine));
		stringBuilder.Append(PrepareCSVString(_codeAfter));
		return stringBuilder.ToString();
	}

	private string PrepareCSVString(List<string> input)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string item in input)
		{
			if (item != null)
			{
				stringBuilder.Append(item + "; ");
			}
		}
		return PrepareCSVString(stringBuilder.ToString());
	}

	private string PrepareCSVString(string input)
	{
		string result = "\"\",";
		if (input != null)
		{
			result = input.Replace("\"", "\"\"");
			result = "\"" + result + "\",";
		}
		return result;
	}

	public string GenerateText()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(_rule.GenerateText());
		stringBuilder.AppendLine("");
		stringBuilder.AppendLine("Code\r\n=====================================");
		stringBuilder.AppendLine("File: " + _filePath);
		stringBuilder.AppendLine("Line Number: " + _lineNumber);
		stringBuilder.AppendLine("Offending Line: " + _offendingLine.Trim());
		stringBuilder.AppendLine("-----------------------------------------------------------------");
		stringBuilder.AppendLine(_codeBefore);
		stringBuilder.AppendLine("==>>" + _offendingLine);
		stringBuilder.AppendLine(_codeAfter);
		stringBuilder.AppendLine("------------------------------------------------------------------");
		return stringBuilder.ToString();
	}
}
