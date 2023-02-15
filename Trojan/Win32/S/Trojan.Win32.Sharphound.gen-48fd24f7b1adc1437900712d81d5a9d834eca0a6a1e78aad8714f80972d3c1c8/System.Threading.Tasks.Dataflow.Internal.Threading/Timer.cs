namespace System.Threading.Tasks.Dataflow.Internal.Threading;

internal sealed class Timer : CancellationTokenSource, IDisposable
{
	internal Timer(TimerCallback callback, object state, int dueTime, int period)
	{
		Task.Delay(dueTime, base.Token).ContinueWith(delegate(Task t, object s)
		{
			Tuple<TimerCallback, object> tuple = (Tuple<TimerCallback, object>)s;
			tuple.Item1(tuple.Item2);
		}, Tuple.Create(callback, state), CancellationToken.None, TaskContinuationOptions.OnlyOnRanToCompletion | TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);
	}

	public new void Dispose()
	{
		Cancel();
	}
}
