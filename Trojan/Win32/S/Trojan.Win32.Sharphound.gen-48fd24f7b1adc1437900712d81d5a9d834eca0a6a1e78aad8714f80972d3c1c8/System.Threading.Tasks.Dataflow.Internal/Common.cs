using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks.Dataflow.Internal.Threading;

namespace System.Threading.Tasks.Dataflow.Internal;

internal static class Common
{
	internal delegate bool KeepAlivePredicate<TStateIn, TStateOut>(TStateIn stateIn, out TStateOut stateOut);

	private static class CachedGenericDelegates<T>
	{
		internal static readonly Func<T> DefaultTResultFunc = () => default(T);

		internal static readonly Action<object, TargetRegistry<T>, ITargetBlock<T>> CreateUnlinkerShimAction = delegate(object syncObj, TargetRegistry<T> registry, ITargetBlock<T> target)
		{
			lock (syncObj)
			{
				registry.Remove(target);
			}
		};
	}

	internal const long INVALID_REORDERING_ID = -1L;

	internal const int SINGLE_MESSAGE_ID = 1;

	internal static readonly DataflowMessageHeader SingleMessageHeader = new DataflowMessageHeader(1L);

	internal static readonly Task<bool> CompletedTaskWithTrueResult = CreateCachedBooleanTask(value: true);

	internal static readonly Task<bool> CompletedTaskWithFalseResult = CreateCachedBooleanTask(value: false);

	internal static readonly TaskCompletionSource<VoidResult> CompletedVoidResultTaskCompletionSource = CreateCachedTaskCompletionSource<VoidResult>();

	internal const int KEEP_ALIVE_NUMBER_OF_MESSAGES_THRESHOLD = 1;

	internal const int KEEP_ALIVE_BAN_COUNT = 1000;

	internal const string EXCEPTIONDATAKEY_DATAFLOWMESSAGEVALUE = "DataflowMessageValue";

	internal static readonly TimeSpan InfiniteTimeSpan = Timeout.InfiniteTimeSpan;

	internal static readonly Action<Exception> AsyncExceptionHandler = ThrowAsync;

	[Conditional("DEBUG")]
	internal static void ContractAssertMonitorStatus(object syncObj, bool held)
	{
	}

	internal static bool TryKeepAliveUntil<TStateIn, TStateOut>(KeepAlivePredicate<TStateIn, TStateOut> predicate, TStateIn stateIn, out TStateOut stateOut)
	{
		int num = 16;
		while (true)
		{
			if (num > 0)
			{
				if (!System.Threading.Tasks.Dataflow.Internal.Threading.Thread.Yield() && predicate(stateIn, out stateOut))
				{
					break;
				}
				num--;
				continue;
			}
			stateOut = default(TStateOut);
			return false;
		}
		return true;
	}

	internal static T UnwrapWeakReference<T>(object state) where T : class
	{
		WeakReference<T> weakReference = state as WeakReference<T>;
		if (!weakReference.TryGetTarget(out var target))
		{
			return null;
		}
		return target;
	}

	internal static int GetBlockId(IDataflowBlock block)
	{
		return GetPotentiallyNotSupportedCompletionTask(block)?.Id ?? 0;
	}

	internal static string GetNameForDebugger(IDataflowBlock block, DataflowBlockOptions options = null)
	{
		if (block == null)
		{
			return string.Empty;
		}
		string name = block.GetType().get_Name();
		if (options == null)
		{
			return name;
		}
		int blockId = GetBlockId(block);
		try
		{
			return string.Format(options.NameFormat, new object[2] { name, blockId });
		}
		catch (Exception ex)
		{
			return ex.Message;
		}
	}

	internal static bool IsCooperativeCancellation(Exception exception)
	{
		return exception is OperationCanceledException;
	}

	internal static void WireCancellationToComplete(CancellationToken cancellationToken, Task completionTask, Action<object> completeAction, object completeState)
	{
		if (cancellationToken.IsCancellationRequested)
		{
			completeAction(completeState);
		}
		else if (cancellationToken.CanBeCanceled)
		{
			CancellationTokenRegistration cancellationTokenRegistration = cancellationToken.Register(completeAction, completeState);
			completionTask.ContinueWith(delegate(Task completed, object state)
			{
				((CancellationTokenRegistration)state).Dispose();
			}, cancellationTokenRegistration, cancellationToken, GetContinuationOptions(), TaskScheduler.Default);
		}
	}

	internal static Exception InitializeStackTrace(Exception exception)
	{
		try
		{
			throw exception;
		}
		catch
		{
			return exception;
		}
	}

	internal static void StoreDataflowMessageValueIntoExceptionData<T>(Exception exc, T messageValue, bool targetInnerExceptions = false)
	{
		string text = messageValue as string;
		if (text == null && messageValue != null)
		{
			try
			{
				text = messageValue.ToString();
			}
			catch
			{
			}
		}
		if (text == null)
		{
			return;
		}
		StoreStringIntoExceptionData(exc, "DataflowMessageValue", text);
		if (!targetInnerExceptions)
		{
			return;
		}
		if (exc is AggregateException ex)
		{
			{
				foreach (Exception innerException in ex.InnerExceptions)
				{
					StoreStringIntoExceptionData(innerException, "DataflowMessageValue", text);
				}
				return;
			}
		}
		if (exc.InnerException != null)
		{
			StoreStringIntoExceptionData(exc.InnerException, "DataflowMessageValue", text);
		}
	}

	private static void StoreStringIntoExceptionData(Exception exception, string key, string value)
	{
		try
		{
			IDictionary data = exception.Data;
			if (data != null && !data.IsFixedSize && !data.IsReadOnly && data[key] == null)
			{
				data[key] = value;
			}
		}
		catch
		{
		}
	}

	internal static void ThrowAsync(Exception error)
	{
		ExceptionDispatchInfo state2 = ExceptionDispatchInfo.Capture(error);
		System.Threading.Tasks.Dataflow.Internal.Threading.ThreadPool.QueueUserWorkItem(delegate(object state)
		{
			((ExceptionDispatchInfo)state).Throw();
		}, state2);
	}

	internal static void AddException(ref List<Exception> list, Exception exception, bool unwrapInnerExceptions = false)
	{
		if (list == null)
		{
			list = new List<Exception>();
		}
		if (unwrapInnerExceptions)
		{
			if (exception is AggregateException ex)
			{
				list.AddRange(ex.InnerExceptions);
			}
			else
			{
				list.Add(exception.InnerException);
			}
		}
		else
		{
			list.Add(exception);
		}
	}

	private static Task<bool> CreateCachedBooleanTask(bool value)
	{
		AsyncTaskMethodBuilder<bool> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<bool>.Create();
		asyncTaskMethodBuilder.SetResult(value);
		return asyncTaskMethodBuilder.Task;
	}

	private static TaskCompletionSource<T> CreateCachedTaskCompletionSource<T>()
	{
		TaskCompletionSource<T> taskCompletionSource = new TaskCompletionSource<T>();
		taskCompletionSource.SetResult(default(T));
		return taskCompletionSource;
	}

	internal static Task<TResult> CreateTaskFromException<TResult>(Exception exception)
	{
		AsyncTaskMethodBuilder<TResult> asyncTaskMethodBuilder = AsyncTaskMethodBuilder<TResult>.Create();
		asyncTaskMethodBuilder.SetException(exception);
		return asyncTaskMethodBuilder.Task;
	}

	internal static Task<TResult> CreateTaskFromCancellation<TResult>(CancellationToken cancellationToken)
	{
		return new Task<TResult>(CachedGenericDelegates<TResult>.DefaultTResultFunc, cancellationToken);
	}

	internal static Task GetPotentiallyNotSupportedCompletionTask(IDataflowBlock block)
	{
		try
		{
			return block.Completion;
		}
		catch (NotImplementedException)
		{
		}
		catch (NotSupportedException)
		{
		}
		return null;
	}

	internal static IDisposable CreateUnlinker<TOutput>(object outgoingLock, TargetRegistry<TOutput> targetRegistry, ITargetBlock<TOutput> targetBlock)
	{
		return Disposables.Create(CachedGenericDelegates<TOutput>.CreateUnlinkerShimAction, outgoingLock, targetRegistry, targetBlock);
	}

	internal static bool IsValidTimeout(TimeSpan timeout)
	{
		long num = (long)timeout.TotalMilliseconds;
		if (num >= -1L)
		{
			return num <= 2147483647L;
		}
		return false;
	}

	internal static TaskContinuationOptions GetContinuationOptions(TaskContinuationOptions toInclude = TaskContinuationOptions.None)
	{
		return toInclude | TaskContinuationOptions.DenyChildAttach;
	}

	internal static TaskCreationOptions GetCreationOptionsForTask(bool isReplacementReplica = false)
	{
		TaskCreationOptions taskCreationOptions = TaskCreationOptions.DenyChildAttach;
		if (isReplacementReplica)
		{
			taskCreationOptions |= TaskCreationOptions.PreferFairness;
		}
		return taskCreationOptions;
	}

	internal static Exception StartTaskSafe(Task task, TaskScheduler scheduler)
	{
		if (scheduler == TaskScheduler.Default)
		{
			task.Start(scheduler);
			return null;
		}
		return StartTaskSafeCore(task, scheduler);
	}

	private static Exception StartTaskSafeCore(Task task, TaskScheduler scheduler)
	{
		Exception result = null;
		try
		{
			task.Start(scheduler);
			return result;
		}
		catch (Exception result2)
		{
			_ = task.Exception;
			return result2;
		}
	}

	internal static void ReleaseAllPostponedMessages<T>(ITargetBlock<T> target, QueuedMap<ISourceBlock<T>, DataflowMessageHeader> postponedMessages, ref List<Exception> exceptions)
	{
		_ = postponedMessages.Count;
		int num = 0;
		KeyValuePair<ISourceBlock<T>, DataflowMessageHeader> item;
		while (postponedMessages.TryPop(out item))
		{
			try
			{
				if (item.Key.ReserveMessage(item.Value, target))
				{
					item.Key.ReleaseReservation(item.Value, target);
				}
			}
			catch (Exception exception)
			{
				AddException(ref exceptions, exception);
			}
			num++;
		}
	}

	internal static void PropagateCompletion(Task sourceCompletionTask, IDataflowBlock target, Action<Exception> exceptionHandler)
	{
		AggregateException ex = (sourceCompletionTask.IsFaulted ? sourceCompletionTask.Exception : null);
		try
		{
			if (ex != null)
			{
				target.Fault(ex);
			}
			else
			{
				target.Complete();
			}
		}
		catch (Exception obj)
		{
			if (exceptionHandler == null)
			{
				throw;
			}
			exceptionHandler(obj);
		}
	}

	private static void PropagateCompletionAsContinuation(Task sourceCompletionTask, IDataflowBlock target)
	{
		sourceCompletionTask.ContinueWith(delegate(Task task, object state)
		{
			PropagateCompletion(task, (IDataflowBlock)state, AsyncExceptionHandler);
		}, target, CancellationToken.None, GetContinuationOptions(), TaskScheduler.Default);
	}

	internal static void PropagateCompletionOnceCompleted(Task sourceCompletionTask, IDataflowBlock target)
	{
		if (sourceCompletionTask.IsCompleted)
		{
			PropagateCompletion(sourceCompletionTask, target, null);
		}
		else
		{
			PropagateCompletionAsContinuation(sourceCompletionTask, target);
		}
	}
}
