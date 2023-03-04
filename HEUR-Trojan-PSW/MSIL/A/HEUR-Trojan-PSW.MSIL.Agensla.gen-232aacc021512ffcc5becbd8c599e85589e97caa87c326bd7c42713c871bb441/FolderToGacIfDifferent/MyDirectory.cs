using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace FolderToGacIfDifferent;

public static class MyDirectory
{
	public static IEnumerable<string> GetFiles(string path, string searchPatternExpression = "", SearchOption searchOption = SearchOption.TopDirectoryOnly)
	{
		Regex reSearchPattern = new Regex(searchPatternExpression);
		return from file in Directory.EnumerateFiles(path, "*", searchOption)
			where reSearchPattern.IsMatch(Path.GetExtension(file))
			select file;
	}

	public static IEnumerable<string> GetFiles(string path, string[] searchPatterns, SearchOption searchOption = SearchOption.TopDirectoryOnly)
	{
		return searchPatterns.AsParallel().SelectMany((string searchPattern) => Directory.EnumerateFiles(path, searchPattern, searchOption));
	}
}
