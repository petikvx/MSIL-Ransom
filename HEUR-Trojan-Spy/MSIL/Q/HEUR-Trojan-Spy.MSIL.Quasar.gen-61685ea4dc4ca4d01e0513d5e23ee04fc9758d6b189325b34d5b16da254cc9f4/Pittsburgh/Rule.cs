using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using Pittsburgh.Properties;

namespace Pittsburgh;

public class Rule
{
	private string _title;

	private string _description;

	private string _regexSearchPattern;

	private List<string> _fileExtensions;

	private List<string> _guidance;

	private Regex _regex;

	private bool _selected;

	public static string Bookmarks = "65595468~627867";

	public string Title
	{
		get
		{
			return _title;
		}
		set
		{
			_title = value;
		}
	}

	public bool Selected
	{
		get
		{
			return _selected;
		}
		set
		{
			_selected = value;
		}
	}

	internal string Description
	{
		get
		{
			return _description;
		}
		set
		{
			_description = value;
		}
	}

	public string Severity { get; set; }

	public string Type { get; set; }

	internal string RegexSearchPattern
	{
		get
		{
			return _regexSearchPattern;
		}
		set
		{
			_regexSearchPattern = value;
			_regex = new Regex(_regexSearchPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
		}
	}

	internal void AddNewExtension(string extension)
	{
		if ("*" == extension)
		{
			_fileExtensions.Add(extension);
		}
		else if (extension.StartsWith("."))
		{
			_fileExtensions.Add(extension);
		}
		else
		{
			_fileExtensions.Add("." + extension);
		}
	}

	internal void RemoveExtension(string extension)
	{
		if (extension.StartsWith("."))
		{
			_fileExtensions.Remove(extension);
		}
		else
		{
			_fileExtensions.Remove("." + extension);
		}
	}

	internal void ClearExtensions()
	{
		_fileExtensions.Clear();
	}

	internal void AddNewGuidance(string guidance)
	{
		_guidance.Add(guidance);
	}

	internal void RemoveGuidance(string guidance)
	{
		_guidance.Remove(guidance);
	}

	internal void ClearGuidance()
	{
		_guidance.Clear();
	}

	internal Rule()
	{
		_fileExtensions = new List<string>();
		_guidance = new List<string>();
	}

	public Rule(string Title, string Description, string Pattern, List<string> Extensions, List<string> Guidance)
	{
		_title = Title;
		_description = Description;
		_regexSearchPattern = Pattern;
		_fileExtensions = Extensions;
		_guidance = Guidance;
		_selected = true;
		_regex = new Regex(_regexSearchPattern, RegexOptions.IgnoreCase | RegexOptions.Compiled);
	}

	public List<SourceCodeIssue> FindIssues(string fileToTest)
	{
		List<SourceCodeIssue> list = new List<SourceCodeIssue>();
		int num = 1;
		string[] array = File.ReadAllLines(fileToTest);
		foreach (string text in array)
		{
			if (_regex.IsMatch(text))
			{
				SourceCodeIssue issue = new SourceCodeIssue();
				issue.FilePath = fileToTest;
				issue.LineNumber = num;
				issue.RulePattern = this;
				issue.OffendingLine = text;
				getCodeSnippet(fileToTest, num, ref issue);
				list.Add(issue);
			}
			num++;
		}
		return list;
	}

	private void getCodeSnippet(string FileToTest, int LineNumber, ref SourceCodeIssue issue)
	{
		string[] array = File.ReadAllLines(FileToTest);
		int num = 0;
		int num2 = array.Length;
		if (LineNumber - Settings.Default.LinesBefore > 0)
		{
			num = LineNumber - Settings.Default.LinesBefore;
		}
		if (LineNumber + Settings.Default.LinesAfter < num2)
		{
			num2 = LineNumber + Settings.Default.LinesAfter;
		}
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		for (int i = num; i < LineNumber - 1; i++)
		{
			stringBuilder.AppendLine(array[i]);
		}
		for (int j = LineNumber; j < num2; j++)
		{
			stringBuilder2.AppendLine(array[j]);
		}
		issue.CodeAfter = stringBuilder2.ToString();
		issue.CodeBefore = stringBuilder.ToString();
	}

	public string GenerateHTMLSnippet()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("<h2>Issue</h2>");
		stringBuilder.AppendFormat("<h3>{0}</h3>", _title);
		stringBuilder.AppendFormat("<div class=\"IssueDescription\">{0}</div>", _description);
		stringBuilder.AppendFormat("<strong>Looking for:</strong>{0}<br />", _regexSearchPattern);
		stringBuilder.AppendLine("<div class=\"IssueGuidance\"><ul>");
		foreach (string item in _guidance)
		{
			if (!string.IsNullOrWhiteSpace(item))
			{
				stringBuilder.AppendFormat("<li>{0}</li>", item);
			}
		}
		stringBuilder.AppendLine("</ul></div>");
		return stringBuilder.ToString();
	}

	internal void AddGuidanceList(List<string> list)
	{
		_guidance.AddRange(list);
	}

	internal void AddExtensionList(List<string> list)
	{
		foreach (string item in list)
		{
			AddNewExtension(item);
		}
	}

	public List<string> ExtensionList()
	{
		return _fileExtensions;
	}

	internal string GenerateXMLSnippet()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendFormat("\n  <Rule>\n    <Title>{0}</Title>\n    <RegularExpressionPattern>{1}</RegularExpressionPattern>\n    <Extensions>", _title, _regexSearchPattern);
		foreach (string fileExtension in _fileExtensions)
		{
			stringBuilder.AppendFormat("\n      <Extension>{0}</Extension>", fileExtension);
		}
		stringBuilder.AppendFormat("\n    </Extensions>\n    <Guidance>");
		foreach (string item in _guidance)
		{
			stringBuilder.AppendFormat("\n      <Url>{0}</Url>", item);
		}
		stringBuilder.AppendFormat("\n    </Guidance>\n    <Description>{0}</Description>\n  </Rule>", _description);
		return stringBuilder.ToString();
	}

	internal string GenerateText()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Rule\r\n=====================================");
		stringBuilder.AppendLine("Title: " + _title);
		stringBuilder.AppendLine("Description:\r\n" + _description);
		stringBuilder.AppendLine("Regex: " + _regexSearchPattern);
		stringBuilder.AppendLine("Guidance: ");
		foreach (string item in _guidance)
		{
			if (!string.IsNullOrWhiteSpace(item))
			{
				stringBuilder.AppendFormat("\t- {0}\r\n", item);
			}
		}
		return stringBuilder.ToString();
	}
}
