using System.Collections.Generic;
using System.IO;

namespace Pittsburgh;

public class SourceFile
{
	public int lines;

	public int commentedLines;

	public string path;

	public List<SourceCodeIssue> issues;

	public SourceFile(string file)
	{
		issues = new List<SourceCodeIssue>();
		path = file;
		string[] array = File.ReadAllLines(path);
		foreach (string text in array)
		{
			bool flag = false;
			if (text.StartsWith("//"))
			{
				commentedLines++;
			}
			else if (text.StartsWith("/*"))
			{
				flag = true;
				commentedLines++;
			}
			else if (text.Contains("*/"))
			{
				flag = false;
				commentedLines++;
			}
			else if (flag)
			{
				commentedLines++;
			}
			lines++;
		}
	}
}
