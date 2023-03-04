namespace GraphComposite.Exceptions;

public class KeyNotFoundGraphException : GraphException
{
	public KeyNotFoundGraphException(string s)
		: base(s)
	{
	}
}
