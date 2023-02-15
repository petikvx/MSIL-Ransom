namespace System.Threading.Tasks.Dataflow.Internal.Threading;

internal sealed class ThreadPool
{
	private static readonly SynchronizationContext _ctx = new SynchronizationContext();

	internal static void QueueUserWorkItem(WaitCallback callback, object state)
	{
		_ctx.Post(delegate(object s)
		{
			Tuple<WaitCallback, object> tuple = (Tuple<WaitCallback, object>)s;
			tuple.Item1(tuple.Item2);
		}, Tuple.Create(callback, state));
	}
}
