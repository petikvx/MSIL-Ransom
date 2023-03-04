namespace Pittsburgh;

public class FindResults
{
	protected int Found { get; set; }

	protected int NotFound { get; set; }

	protected int TotalCount { get; set; }

	public decimal FoundPercent => (decimal)Found / (decimal)(Found + NotFound);

	public decimal NotFoundPercent => (decimal)NotFound / (decimal)(Found + NotFound);

	public FindResults()
	{
		Found = 0;
		NotFound = 0;
		TotalCount = 0;
	}

	public void FoundItem()
	{
		Found++;
		TotalCount++;
	}

	public void NotFoundItem()
	{
		NotFound++;
		TotalCount++;
	}
}
