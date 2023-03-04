using System;

namespace GraphComposite.Exceptions;

public class CycleAttemptedException : Exception
{
	public CycleAttemptedException(string s)
		: base(s)
	{
	}
}
