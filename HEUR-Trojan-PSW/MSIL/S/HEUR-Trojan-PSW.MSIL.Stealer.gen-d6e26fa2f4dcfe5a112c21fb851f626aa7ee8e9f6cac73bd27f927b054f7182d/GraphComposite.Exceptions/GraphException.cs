using System;

namespace GraphComposite.Exceptions;

public class GraphException : Exception
{
	public GraphException(string s)
		: base(s)
	{
	}
}
