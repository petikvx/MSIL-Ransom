using System.Collections.Generic;
using System.Linq;

namespace Pittsburgh;

public class TestClass
{
	private string[] searchItems;

	private string[] searchTerms;

	private int searchCount;

	public TestClass(string[] SearchItems, string[] SearchTerms, int SearchCount)
	{
		searchItems = SearchItems;
		searchTerms = SearchTerms;
		searchCount = SearchCount;
	}

	public FindResults DoFind()
	{
		FindResults findResults = new FindResults();
		List<string> list = new List<string>(searchItems);
		int i;
		for (i = 0; i < searchCount; i++)
		{
			if (string.IsNullOrEmpty(list.Find((string test) => test == searchTerms[i % searchTerms.Length])))
			{
				findResults.NotFoundItem();
			}
			else
			{
				findResults.FoundItem();
			}
		}
		return findResults;
	}

	public FindResults DoContains()
	{
		FindResults findResults = new FindResults();
		List<string> list = new List<string>(searchItems);
		for (int i = 0; i < searchCount; i++)
		{
			if (list.Contains(searchTerms[i % searchTerms.Length]))
			{
				findResults.FoundItem();
			}
			else
			{
				findResults.NotFoundItem();
			}
		}
		return findResults;
	}

	public FindResults DoWhere()
	{
		FindResults findResults = new FindResults();
		List<string> source = new List<string>(searchItems);
		int i;
		for (i = 0; i < searchCount; i++)
		{
			if (source.Where((string test) => test == searchTerms[i % searchTerms.Length]).Count() > 0)
			{
				findResults.FoundItem();
			}
			else
			{
				findResults.NotFoundItem();
			}
		}
		return findResults;
	}

	public FindResults DoAny()
	{
		FindResults findResults = new FindResults();
		List<string> source = new List<string>(searchItems);
		int i;
		for (i = 0; i < searchCount; i++)
		{
			if (source.Any((string test) => test == searchTerms[i % searchTerms.Length]))
			{
				findResults.FoundItem();
			}
			else
			{
				findResults.NotFoundItem();
			}
		}
		return findResults;
	}
}
