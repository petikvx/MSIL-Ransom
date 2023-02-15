using System.Collections.Generic;
using System.Threading;

namespace ns0;

internal class Class0
{
	private static readonly IList<Thread> ilist_0 = new List<Thread>();

	private readonly Thread thread_0;

	private readonly ParameterizedThreadStart parameterizedThreadStart_0;

	private readonly ThreadStart threadStart_0;

	public Thread Thread => thread_0;

	private void method_0(object object_0)
	{
		try
		{
			parameterizedThreadStart_0(object_0);
		}
		finally
		{
			lock (ilist_0)
			{
				ilist_0.Remove(thread_0);
			}
		}
	}

	private void method_1()
	{
		try
		{
			threadStart_0();
		}
		finally
		{
			lock (ilist_0)
			{
				ilist_0.Remove(thread_0);
			}
		}
	}
}
