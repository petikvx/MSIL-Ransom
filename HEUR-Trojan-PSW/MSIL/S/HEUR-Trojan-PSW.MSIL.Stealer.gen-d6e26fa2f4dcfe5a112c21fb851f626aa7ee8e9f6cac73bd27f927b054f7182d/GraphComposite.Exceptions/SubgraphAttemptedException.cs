namespace GraphComposite.Exceptions;

public class SubgraphAttemptedException : GraphException
{
	public SubgraphAttemptedException(string s)
		: base(s)
	{
	}
}
