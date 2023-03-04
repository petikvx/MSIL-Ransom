using System.Collections.Generic;

namespace Pittsburgh;

public class ProjectInfo
{
	public List<SourceFile> files = new List<SourceFile>();

	public int GetIssuesCount()
	{
		int num = 0;
		foreach (SourceFile file in files)
		{
			num += file.issues.Count;
		}
		return num;
	}

	public int EstimateCodeReviewTime()
	{
		return EstimateCodeReviewTime("h");
	}

	public int EstimateCodeReviewTime(string format)
	{
		int num = 0;
		int num2 = 15;
		int num3 = 1500;
		foreach (SourceFile file in files)
		{
			num += file.issues.Count * num2;
			num += file.lines / num3 * 60;
		}
		int num4 = 0;
		return format.ToLower() switch
		{
			"d" => num / 60 / 8, 
			"h" => num / 60, 
			"m" => num, 
			_ => num / 60, 
		};
	}

	public int getTotalLinesOfCode()
	{
		int num = 0;
		foreach (SourceFile file in files)
		{
			num += file.lines;
		}
		return num;
	}
}
