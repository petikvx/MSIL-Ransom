namespace System.Threading.Tasks;

internal static class TaskExtensions
{
	public static async Task<T> WithCancellation<T>(this Task<T> task, CancellationToken cancellationToken, Action onCancel)
	{
		TaskCompletionSource<bool> taskCompletionSource = new TaskCompletionSource<bool>();
		using (cancellationToken.Register(delegate(object s)
		{
			((TaskCompletionSource<bool>)s).TrySetResult(result: true);
		}, taskCompletionSource))
		{
			if (task != await Task.WhenAny(new Task[2] { task, taskCompletionSource.Task }).ConfigureAwait(continueOnCapturedContext: false))
			{
				try
				{
					onCancel();
				}
				catch
				{
				}
				throw new OperationCanceledException(cancellationToken);
			}
		}
		return await task.ConfigureAwait(continueOnCapturedContext: false);
	}
}
