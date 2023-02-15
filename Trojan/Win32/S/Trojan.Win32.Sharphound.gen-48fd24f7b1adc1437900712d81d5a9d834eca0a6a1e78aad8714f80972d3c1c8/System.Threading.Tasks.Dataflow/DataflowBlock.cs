using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks.Dataflow.Internal;
using System.Threading.Tasks.Dataflow.Internal.Threading;

namespace System.Threading.Tasks.Dataflow;

public static class DataflowBlock
{
	[DebuggerTypeProxy(typeof(FilteredLinkPropagator<>.DebugView))]
	[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
	private sealed class FilteredLinkPropagator<T> : IPropagatorBlock<T, T>, ITargetBlock<T>, ISourceBlock<T>, IDataflowBlock, IDebuggerDisplay
	{
		private sealed class DebugView
		{
			private readonly FilteredLinkPropagator<T> _filter;

			public ITargetBlock<T> LinkedTarget => _filter._target;

			public DebugView(FilteredLinkPropagator<T> filter)
			{
				_filter = filter;
			}
		}

		private readonly ISourceBlock<T> _source;

		private readonly ITargetBlock<T> _target;

		private readonly Predicate<T> _userProvidedPredicate;

		Task IDataflowBlock.Completion => _source.Completion;

		private object DebuggerDisplayContent
		{
			get
			{
				IDebuggerDisplay debuggerDisplay = _source as IDebuggerDisplay;
				IDebuggerDisplay debuggerDisplay2 = _target as IDebuggerDisplay;
				return string.Format("{0} Source=\"{1}\", Target=\"{2}\"", new object[3]
				{
					Common.GetNameForDebugger(this),
					(debuggerDisplay != null) ? debuggerDisplay.Content : _source,
					(debuggerDisplay2 != null) ? debuggerDisplay2.Content : _target
				});
			}
		}

		object IDebuggerDisplay.Content => DebuggerDisplayContent;

		internal FilteredLinkPropagator(ISourceBlock<T> source, ITargetBlock<T> target, Predicate<T> predicate)
		{
			_source = source;
			_target = target;
			_userProvidedPredicate = predicate;
		}

		private bool RunPredicate(T item)
		{
			return _userProvidedPredicate(item);
		}

		DataflowMessageStatus ITargetBlock<T>.OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept)
		{
			if (!messageHeader.IsValid)
			{
				throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
			}
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			if (RunPredicate(messageValue))
			{
				return _target.OfferMessage(messageHeader, messageValue, this, consumeToAccept);
			}
			return DataflowMessageStatus.Declined;
		}

		T ISourceBlock<T>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target, out bool messageConsumed)
		{
			return _source.ConsumeMessage(messageHeader, this, out messageConsumed);
		}

		bool ISourceBlock<T>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target)
		{
			return _source.ReserveMessage(messageHeader, this);
		}

		void ISourceBlock<T>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<T> target)
		{
			_source.ReleaseReservation(messageHeader, this);
		}

		void IDataflowBlock.Complete()
		{
			_target.Complete();
		}

		void IDataflowBlock.Fault(Exception exception)
		{
			_target.Fault(exception);
		}

		IDisposable ISourceBlock<T>.LinkTo(ITargetBlock<T> target, DataflowLinkOptions linkOptions)
		{
			throw new NotSupportedException(SR1.NotSupported_MemberNotNeeded);
		}
	}

	[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
	[DebuggerTypeProxy(typeof(SendAsyncSource<>.DebugView))]
	private sealed class SendAsyncSource<TOutput> : TaskCompletionSource<bool>, ISourceBlock<TOutput>, IDataflowBlock, IDebuggerDisplay
	{
		private sealed class DebugView
		{
			private readonly SendAsyncSource<TOutput> _source;

			public ITargetBlock<TOutput> Target => _source._target;

			public TOutput Message => _source._messageValue;

			public Task<bool> Completion => _source.Task;

			public DebugView(SendAsyncSource<TOutput> source)
			{
				_source = source;
			}
		}

		private readonly ITargetBlock<TOutput> _target;

		private readonly TOutput _messageValue;

		private CancellationToken _cancellationToken;

		private CancellationTokenRegistration _cancellationRegistration;

		private int _cancellationState;

		private const int CANCELLATION_STATE_NONE = 0;

		private const int CANCELLATION_STATE_REGISTERED = 1;

		private const int CANCELLATION_STATE_RESERVED = 2;

		private const int CANCELLATION_STATE_COMPLETING = 3;

		private static readonly Action<object> _cancellationCallback = CancellationHandler;

		Task IDataflowBlock.Completion => base.Task;

		private object DebuggerDisplayContent
		{
			get
			{
				IDebuggerDisplay debuggerDisplay = _target as IDebuggerDisplay;
				return string.Format("{0} Message={1}, Target=\"{2}\"", new object[3]
				{
					Common.GetNameForDebugger(this),
					_messageValue,
					(debuggerDisplay != null) ? debuggerDisplay.Content : _target
				});
			}
		}

		object IDebuggerDisplay.Content => DebuggerDisplayContent;

		internal SendAsyncSource(ITargetBlock<TOutput> target, TOutput messageValue, CancellationToken cancellationToken)
		{
			_target = target;
			_messageValue = messageValue;
			if (cancellationToken.CanBeCanceled)
			{
				_cancellationToken = cancellationToken;
				_cancellationState = 1;
				try
				{
					_cancellationRegistration = cancellationToken.Register(_cancellationCallback, new WeakReference<SendAsyncSource<TOutput>>(this));
				}
				catch
				{
					GC.SuppressFinalize(this);
					throw;
				}
			}
		}

		~SendAsyncSource()
		{
			if (!Environment.HasShutdownStarted)
			{
				CompleteAsDeclined(runAsync: true);
			}
		}

		private void CompleteAsAccepted(bool runAsync)
		{
			RunCompletionAction(delegate(object state)
			{
				try
				{
					((SendAsyncSource<TOutput>)state).TrySetResult(result: true);
				}
				catch (ObjectDisposedException)
				{
				}
			}, this, runAsync);
		}

		private void CompleteAsDeclined(bool runAsync)
		{
			RunCompletionAction(delegate(object state)
			{
				try
				{
					((SendAsyncSource<TOutput>)state).TrySetResult(result: false);
				}
				catch (ObjectDisposedException)
				{
				}
			}, this, runAsync);
		}

		private void CompleteAsFaulted(Exception exception, bool runAsync)
		{
			RunCompletionAction(delegate(object state)
			{
				Tuple<SendAsyncSource<TOutput>, Exception> tuple = (Tuple<SendAsyncSource<TOutput>, Exception>)state;
				try
				{
					tuple.Item1.TrySetException(tuple.Item2);
				}
				catch (ObjectDisposedException)
				{
				}
			}, Tuple.Create(this, exception), runAsync);
		}

		private void CompleteAsCanceled(bool runAsync)
		{
			RunCompletionAction(delegate(object state)
			{
				try
				{
					((SendAsyncSource<TOutput>)state).TrySetCanceled();
				}
				catch (ObjectDisposedException)
				{
				}
			}, this, runAsync);
		}

		private void RunCompletionAction(Action<object> completionAction, object completionActionState, bool runAsync)
		{
			GC.SuppressFinalize(this);
			if (_cancellationState != 0)
			{
				_cancellationRegistration.Dispose();
			}
			if (runAsync)
			{
				System.Threading.Tasks.Task.Factory.StartNew(completionAction, completionActionState, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
			}
			else
			{
				completionAction(completionActionState);
			}
		}

		private void OfferToTargetAsync()
		{
			System.Threading.Tasks.Task.Factory.StartNew(delegate(object state)
			{
				((SendAsyncSource<TOutput>)state).OfferToTarget();
			}, this, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}

		private static void CancellationHandler(object state)
		{
			SendAsyncSource<TOutput> sendAsyncSource = Common.UnwrapWeakReference<SendAsyncSource<TOutput>>(state);
			if (sendAsyncSource != null && sendAsyncSource._cancellationState == 1 && Interlocked.CompareExchange(ref sendAsyncSource._cancellationState, 3, 1) == 1)
			{
				sendAsyncSource.CompleteAsCanceled(runAsync: true);
			}
		}

		internal void OfferToTarget()
		{
			try
			{
				bool flag = _cancellationState != 0;
				switch (_target.OfferMessage(Common.SingleMessageHeader, _messageValue, this, flag))
				{
				case DataflowMessageStatus.Accepted:
					if (!flag)
					{
						CompleteAsAccepted(runAsync: false);
					}
					break;
				case DataflowMessageStatus.Declined:
				case DataflowMessageStatus.DecliningPermanently:
					CompleteAsDeclined(runAsync: false);
					break;
				case DataflowMessageStatus.Postponed:
				case DataflowMessageStatus.NotAvailable:
					break;
				}
			}
			catch (Exception ex)
			{
				Common.StoreDataflowMessageValueIntoExceptionData(ex, _messageValue);
				CompleteAsFaulted(ex, runAsync: false);
			}
		}

		TOutput ISourceBlock<TOutput>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target, out bool messageConsumed)
		{
			if (!messageHeader.IsValid)
			{
				throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
			}
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (base.Task.IsCompleted)
			{
				messageConsumed = false;
				return default(TOutput);
			}
			if (messageHeader.Id == 1L)
			{
				int cancellationState = _cancellationState;
				if (cancellationState == 0 || (cancellationState != 3 && Interlocked.CompareExchange(ref _cancellationState, 3, cancellationState) == cancellationState))
				{
					CompleteAsAccepted(runAsync: true);
					messageConsumed = true;
					return _messageValue;
				}
			}
			messageConsumed = false;
			return default(TOutput);
		}

		bool ISourceBlock<TOutput>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target)
		{
			if (!messageHeader.IsValid)
			{
				throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
			}
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (base.Task.IsCompleted)
			{
				return false;
			}
			if (messageHeader.Id == 1L)
			{
				if (_cancellationState != 0)
				{
					return Interlocked.CompareExchange(ref _cancellationState, 2, 1) == 1;
				}
				return true;
			}
			return false;
		}

		void ISourceBlock<TOutput>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target)
		{
			if (!messageHeader.IsValid)
			{
				throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
			}
			if (target == null)
			{
				throw new ArgumentNullException("target");
			}
			if (messageHeader.Id != 1L)
			{
				throw new InvalidOperationException(SR1.InvalidOperation_MessageNotReservedByTarget);
			}
			if (base.Task.IsCompleted)
			{
				return;
			}
			if (_cancellationState != 0)
			{
				if (Interlocked.CompareExchange(ref _cancellationState, 1, 2) != 2)
				{
					throw new InvalidOperationException(SR1.InvalidOperation_MessageNotReservedByTarget);
				}
				if (_cancellationToken.IsCancellationRequested)
				{
					CancellationHandler(new WeakReference<SendAsyncSource<TOutput>>(this));
				}
			}
			OfferToTargetAsync();
		}

		IDisposable ISourceBlock<TOutput>.LinkTo(ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions)
		{
			throw new NotSupportedException(SR1.NotSupported_MemberNotNeeded);
		}

		void IDataflowBlock.Complete()
		{
			throw new NotSupportedException(SR1.NotSupported_MemberNotNeeded);
		}

		void IDataflowBlock.Fault(Exception exception)
		{
			throw new NotSupportedException(SR1.NotSupported_MemberNotNeeded);
		}
	}

	private enum ReceiveCoreByLinkingCleanupReason
	{
		Success,
		Timer,
		Cancellation,
		SourceCompletion,
		SourceProtocolError,
		ErrorDuringCleanup
	}

	[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
	private sealed class ReceiveTarget<T> : TaskCompletionSource<T>, ITargetBlock<T>, IDataflowBlock, IDebuggerDisplay
	{
		internal static readonly System.Threading.Tasks.Dataflow.Internal.Threading.TimerCallback CachedLinkingTimerCallback = delegate(object state)
		{
			ReceiveTarget<T> receiveTarget2 = (ReceiveTarget<T>)state;
			receiveTarget2.TryCleanupAndComplete(ReceiveCoreByLinkingCleanupReason.Timer);
		};

		internal static readonly Action<object> CachedLinkingCancellationCallback = delegate(object state)
		{
			ReceiveTarget<T> receiveTarget = (ReceiveTarget<T>)state;
			receiveTarget.TryCleanupAndComplete(ReceiveCoreByLinkingCleanupReason.Cancellation);
		};

		private T _receivedValue;

		internal readonly CancellationTokenSource _cts = new CancellationTokenSource();

		internal bool _cleanupReserved;

		internal CancellationToken _externalCancellationToken;

		internal CancellationTokenRegistration _regFromExternalCancellationToken;

		internal System.Threading.Tasks.Dataflow.Internal.Threading.Timer _timer;

		internal IDisposable _unlink;

		internal Exception _receivedException;

		internal object IncomingLock => _cts;

		Task IDataflowBlock.Completion
		{
			get
			{
				throw new NotSupportedException(SR1.NotSupported_MemberNotNeeded);
			}
		}

		private object DebuggerDisplayContent => string.Format("{0} IsCompleted={1}", new object[2]
		{
			Common.GetNameForDebugger(this),
			base.Task.IsCompleted
		});

		object IDebuggerDisplay.Content => DebuggerDisplayContent;

		internal ReceiveTarget()
		{
		}

		DataflowMessageStatus ITargetBlock<T>.OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept)
		{
			if (!messageHeader.IsValid)
			{
				throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
			}
			if (source == null && consumeToAccept)
			{
				throw new ArgumentException(SR1.Argument_CantConsumeFromANullSource, "consumeToAccept");
			}
			DataflowMessageStatus dataflowMessageStatus = DataflowMessageStatus.NotAvailable;
			if (Volatile.Read(ref _cleanupReserved))
			{
				return DataflowMessageStatus.DecliningPermanently;
			}
			lock (IncomingLock)
			{
				if (_cleanupReserved)
				{
					return DataflowMessageStatus.DecliningPermanently;
				}
				try
				{
					bool messageConsumed = true;
					T receivedValue = (consumeToAccept ? source.ConsumeMessage(messageHeader, this, out messageConsumed) : messageValue);
					if (messageConsumed)
					{
						dataflowMessageStatus = DataflowMessageStatus.Accepted;
						_receivedValue = receivedValue;
						_cleanupReserved = true;
					}
				}
				catch (Exception ex)
				{
					dataflowMessageStatus = DataflowMessageStatus.DecliningPermanently;
					Common.StoreDataflowMessageValueIntoExceptionData(ex, messageValue);
					_receivedException = ex;
					_cleanupReserved = true;
				}
			}
			switch (dataflowMessageStatus)
			{
			case DataflowMessageStatus.Accepted:
				CleanupAndComplete(ReceiveCoreByLinkingCleanupReason.Success);
				break;
			case DataflowMessageStatus.DecliningPermanently:
				CleanupAndComplete(ReceiveCoreByLinkingCleanupReason.SourceProtocolError);
				break;
			}
			return dataflowMessageStatus;
		}

		internal bool TryCleanupAndComplete(ReceiveCoreByLinkingCleanupReason reason)
		{
			if (Volatile.Read(ref _cleanupReserved))
			{
				return false;
			}
			lock (IncomingLock)
			{
				if (_cleanupReserved)
				{
					return false;
				}
				_cleanupReserved = true;
			}
			CleanupAndComplete(reason);
			return true;
		}

		private void CleanupAndComplete(ReceiveCoreByLinkingCleanupReason reason)
		{
			IDisposable unlink = _unlink;
			if (reason != ReceiveCoreByLinkingCleanupReason.SourceCompletion && unlink != null)
			{
				IDisposable disposable = Interlocked.CompareExchange(ref _unlink, null, unlink);
				if (disposable != null)
				{
					try
					{
						disposable.Dispose();
					}
					catch (Exception receivedException)
					{
						Exception ex = (_receivedException = receivedException);
						reason = ReceiveCoreByLinkingCleanupReason.SourceProtocolError;
					}
				}
			}
			if (_timer != null)
			{
				_timer.Dispose();
			}
			if (reason != ReceiveCoreByLinkingCleanupReason.Cancellation)
			{
				if (reason == ReceiveCoreByLinkingCleanupReason.SourceCompletion && (_externalCancellationToken.IsCancellationRequested || _cts.IsCancellationRequested))
				{
					reason = ReceiveCoreByLinkingCleanupReason.Cancellation;
				}
				_cts.Cancel();
			}
			_regFromExternalCancellationToken.Dispose();
			switch (reason)
			{
			case ReceiveCoreByLinkingCleanupReason.Success:
				System.Threading.Tasks.Task.Factory.StartNew(delegate(object state)
				{
					ReceiveTarget<T> receiveTarget2 = (ReceiveTarget<T>)state;
					try
					{
						receiveTarget2.TrySetResult(receiveTarget2._receivedValue);
					}
					catch (ObjectDisposedException)
					{
					}
				}, this, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default);
				return;
			case ReceiveCoreByLinkingCleanupReason.Timer:
				if (_receivedException == null)
				{
					_receivedException = CreateExceptionForTimeout();
				}
				break;
			default:
				System.Threading.Tasks.Task.Factory.StartNew(delegate(object state)
				{
					ReceiveTarget<T> receiveTarget3 = (ReceiveTarget<T>)state;
					try
					{
						receiveTarget3.TrySetCanceled();
					}
					catch (ObjectDisposedException)
					{
					}
				}, this, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default);
				return;
			case ReceiveCoreByLinkingCleanupReason.SourceCompletion:
				if (_receivedException == null)
				{
					_receivedException = CreateExceptionForSourceCompletion();
				}
				break;
			case ReceiveCoreByLinkingCleanupReason.SourceProtocolError:
			case ReceiveCoreByLinkingCleanupReason.ErrorDuringCleanup:
				break;
			}
			System.Threading.Tasks.Task.Factory.StartNew(delegate(object state)
			{
				ReceiveTarget<T> receiveTarget = (ReceiveTarget<T>)state;
				try
				{
					receiveTarget.TrySetException(receiveTarget._receivedException ?? new InvalidOperationException(SR1.InvalidOperation_ErrorDuringCleanup));
				}
				catch (ObjectDisposedException)
				{
				}
			}, this, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default);
		}

		internal static Exception CreateExceptionForSourceCompletion()
		{
			return Common.InitializeStackTrace(new InvalidOperationException(SR1.InvalidOperation_DataNotAvailableForReceive));
		}

		internal static Exception CreateExceptionForTimeout()
		{
			return Common.InitializeStackTrace(new TimeoutException());
		}

		void IDataflowBlock.Complete()
		{
			TryCleanupAndComplete(ReceiveCoreByLinkingCleanupReason.SourceCompletion);
		}

		void IDataflowBlock.Fault(Exception exception)
		{
			((IDataflowBlock)this).Complete();
		}
	}

	[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
	private sealed class OutputAvailableAsyncTarget<T> : TaskCompletionSource<bool>, ITargetBlock<T>, IDataflowBlock, IDebuggerDisplay
	{
		internal static readonly Func<Task<bool>, object, bool> s_handleCompletion = delegate(Task<bool> antecedent, object state)
		{
			OutputAvailableAsyncTarget<T> outputAvailableAsyncTarget = state as OutputAvailableAsyncTarget<T>;
			outputAvailableAsyncTarget._ctr.Dispose();
			return antecedent.GetAwaiter().GetResult();
		};

		internal static readonly Action<object> s_cancelAndUnlink = CancelAndUnlink;

		internal IDisposable _unlinker;

		internal CancellationTokenRegistration _ctr;

		Task IDataflowBlock.Completion
		{
			get
			{
				throw new NotSupportedException(SR1.NotSupported_MemberNotNeeded);
			}
		}

		private object DebuggerDisplayContent => string.Format("{0} IsCompleted={1}", new object[2]
		{
			Common.GetNameForDebugger(this),
			base.Task.IsCompleted
		});

		object IDebuggerDisplay.Content => DebuggerDisplayContent;

		private static void CancelAndUnlink(object state)
		{
			OutputAvailableAsyncTarget<T> state2 = state as OutputAvailableAsyncTarget<T>;
			System.Threading.Tasks.Task.Factory.StartNew(delegate(object tgt)
			{
				OutputAvailableAsyncTarget<T> outputAvailableAsyncTarget = (OutputAvailableAsyncTarget<T>)tgt;
				outputAvailableAsyncTarget.TrySetCanceled();
				outputAvailableAsyncTarget.AttemptThreadSafeUnlink();
			}, state2, CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}

		internal void AttemptThreadSafeUnlink()
		{
			IDisposable unlinker = _unlinker;
			if (unlinker != null && Interlocked.CompareExchange(ref _unlinker, null, unlinker) == unlinker)
			{
				unlinker.Dispose();
			}
		}

		DataflowMessageStatus ITargetBlock<T>.OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept)
		{
			if (!messageHeader.IsValid)
			{
				throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
			}
			if (source == null)
			{
				throw new ArgumentNullException("source");
			}
			TrySetResult(result: true);
			return DataflowMessageStatus.DecliningPermanently;
		}

		void IDataflowBlock.Complete()
		{
			TrySetResult(result: false);
		}

		void IDataflowBlock.Fault(Exception exception)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			TrySetResult(result: false);
		}
	}

	[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
	[DebuggerTypeProxy(typeof(EncapsulatingPropagator<, >.DebugView))]
	private sealed class EncapsulatingPropagator<TInput, TOutput> : ITargetBlock<TInput>, ISourceBlock<TOutput>, IPropagatorBlock<TInput, TOutput>, IReceivableSourceBlock<TOutput>, IDataflowBlock, IDebuggerDisplay
	{
		private sealed class DebugView
		{
			private readonly EncapsulatingPropagator<TInput, TOutput> _propagator;

			public ITargetBlock<TInput> Target => _propagator._target;

			public ISourceBlock<TOutput> Source => _propagator._source;

			public DebugView(EncapsulatingPropagator<TInput, TOutput> propagator)
			{
				_propagator = propagator;
			}
		}

		private ITargetBlock<TInput> _target;

		private ISourceBlock<TOutput> _source;

		public Task Completion => _source.Completion;

		private object DebuggerDisplayContent
		{
			get
			{
				IDebuggerDisplay debuggerDisplay = _target as IDebuggerDisplay;
				IDebuggerDisplay debuggerDisplay2 = _source as IDebuggerDisplay;
				return string.Format("{0} Target=\"{1}\", Source=\"{2}\"", new object[3]
				{
					Common.GetNameForDebugger(this),
					(debuggerDisplay != null) ? debuggerDisplay.Content : _target,
					(debuggerDisplay2 != null) ? debuggerDisplay2.Content : _source
				});
			}
		}

		object IDebuggerDisplay.Content => DebuggerDisplayContent;

		public EncapsulatingPropagator(ITargetBlock<TInput> target, ISourceBlock<TOutput> source)
		{
			_target = target;
			_source = source;
		}

		public void Complete()
		{
			_target.Complete();
		}

		void IDataflowBlock.Fault(Exception exception)
		{
			if (exception == null)
			{
				throw new ArgumentNullException("exception");
			}
			_target.Fault(exception);
		}

		public DataflowMessageStatus OfferMessage(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept)
		{
			return _target.OfferMessage(messageHeader, messageValue, source, consumeToAccept);
		}

		public IDisposable LinkTo(ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions)
		{
			return _source.LinkTo(target, linkOptions);
		}

		public bool TryReceive(Predicate<TOutput> filter, out TOutput item)
		{
			if (_source is IReceivableSourceBlock<TOutput> receivableSourceBlock)
			{
				return receivableSourceBlock.TryReceive(filter, out item);
			}
			item = default(TOutput);
			return false;
		}

		public bool TryReceiveAll(out IList<TOutput> items)
		{
			if (_source is IReceivableSourceBlock<TOutput> receivableSourceBlock)
			{
				return receivableSourceBlock.TryReceiveAll(out items);
			}
			items = null;
			return false;
		}

		public TOutput ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target, out bool messageConsumed)
		{
			return _source.ConsumeMessage(messageHeader, target, out messageConsumed);
		}

		public bool ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target)
		{
			return _source.ReserveMessage(messageHeader, target);
		}

		public void ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<TOutput> target)
		{
			_source.ReleaseReservation(messageHeader, target);
		}
	}

	[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
	private sealed class ChooseTarget<T> : TaskCompletionSource<T>, ITargetBlock<T>, IDataflowBlock, IDebuggerDisplay
	{
		internal static readonly Func<object, int> s_processBranchFunction = delegate(object state)
		{
			Tuple<Action<T>, T, int> tuple = (Tuple<Action<T>, T, int>)state;
			tuple.Item1(tuple.Item2);
			return tuple.Item3;
		};

		private StrongBox<Task> _completed;

		Task IDataflowBlock.Completion
		{
			get
			{
				throw new NotSupportedException(SR1.NotSupported_MemberNotNeeded);
			}
		}

		private object DebuggerDisplayContent => string.Format("{0} IsCompleted={1}", new object[2]
		{
			Common.GetNameForDebugger(this),
			base.Task.IsCompleted
		});

		object IDebuggerDisplay.Content => DebuggerDisplayContent;

		internal ChooseTarget(StrongBox<Task> completed, CancellationToken cancellationToken)
		{
			_completed = completed;
			Common.WireCancellationToComplete(cancellationToken, base.Task, delegate(object state)
			{
				ChooseTarget<T> chooseTarget = (ChooseTarget<T>)state;
				lock (chooseTarget._completed)
				{
					chooseTarget.TrySetCanceled();
				}
			}, this);
		}

		public DataflowMessageStatus OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept)
		{
			if (!messageHeader.IsValid)
			{
				throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
			}
			if (source == null && consumeToAccept)
			{
				throw new ArgumentException(SR1.Argument_CantConsumeFromANullSource, "consumeToAccept");
			}
			lock (_completed)
			{
				if (_completed.Value == null && !base.Task.IsCompleted)
				{
					if (consumeToAccept)
					{
						messageValue = source.ConsumeMessage(messageHeader, this, out var messageConsumed);
						if (!messageConsumed)
						{
							return DataflowMessageStatus.NotAvailable;
						}
					}
					TrySetResult(messageValue);
					_completed.Value = base.Task;
					return DataflowMessageStatus.Accepted;
				}
				return DataflowMessageStatus.DecliningPermanently;
			}
		}

		void IDataflowBlock.Complete()
		{
			lock (_completed)
			{
				TrySetCanceled();
			}
		}

		void IDataflowBlock.Fault(Exception exception)
		{
			((IDataflowBlock)this).Complete();
		}
	}

	[DebuggerTypeProxy(typeof(SourceObservable<>.DebugView))]
	[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
	private sealed class SourceObservable<TOutput> : IObservable<TOutput>, IDebuggerDisplay
	{
		private sealed class DebugView
		{
			private readonly SourceObservable<TOutput> _observable;

			[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
			public IObserver<TOutput>[] Observers => _observable._observersState.Observers.ToArray();

			public DebugView(SourceObservable<TOutput> observable)
			{
				_observable = observable;
			}
		}

		private sealed class ObserversState
		{
			internal readonly SourceObservable<TOutput> Observable;

			internal readonly ActionBlock<TOutput> Target;

			internal readonly CancellationTokenSource Canceler = new CancellationTokenSource();

			internal ImmutableArray<IObserver<TOutput>> Observers = ImmutableArray<IObserver<TOutput>>.Empty;

			internal IDisposable Unlinker;

			private List<Task<bool>> _tempSendAsyncTaskList;

			internal ObserversState(SourceObservable<TOutput> observable)
			{
				Observable = observable;
				Target = new ActionBlock<TOutput>((Func<TOutput, Task>)ProcessItemAsync, _nonGreedyExecutionOptions);
				Target.Completion.ContinueWith(delegate(Task t, object state)
				{
					((ObserversState)state).NotifyObserversOfCompletion(t.Exception);
				}, this, CancellationToken.None, Common.GetContinuationOptions(TaskContinuationOptions.OnlyOnFaulted | TaskContinuationOptions.ExecuteSynchronously), TaskScheduler.Default);
				Common.GetPotentiallyNotSupportedCompletionTask(Observable._source)?.ContinueWith(delegate(Task _1, object state1)
				{
					ObserversState observersState = (ObserversState)state1;
					observersState.Target.Complete();
					observersState.Target.Completion.ContinueWith(delegate(Task _2, object state2)
					{
						((ObserversState)state2).NotifyObserversOfCompletion();
					}, state1, CancellationToken.None, Common.GetContinuationOptions(TaskContinuationOptions.NotOnFaulted | TaskContinuationOptions.ExecuteSynchronously), TaskScheduler.Default);
				}, this, Canceler.Token, Common.GetContinuationOptions(TaskContinuationOptions.ExecuteSynchronously), TaskScheduler.Default);
			}

			private Task ProcessItemAsync(TOutput item)
			{
				ImmutableArray<IObserver<TOutput>> observers;
				lock (Observable._SubscriptionLock)
				{
					observers = Observers;
				}
				try
				{
					foreach (IObserver<TOutput> item2 in observers)
					{
						if (item2 is TargetObserver<TOutput> targetObserver)
						{
							Task<bool> task = targetObserver.SendAsyncToTarget(item);
							if (task.Status != TaskStatus.RanToCompletion)
							{
								if (_tempSendAsyncTaskList == null)
								{
									_tempSendAsyncTaskList = new List<Task<bool>>();
								}
								_tempSendAsyncTaskList.Add(task);
							}
						}
						else
						{
							item2.OnNext(item);
						}
					}
					if (_tempSendAsyncTaskList != null && _tempSendAsyncTaskList.Count > 0)
					{
						Task<bool[]> result = Task.WhenAll(_tempSendAsyncTaskList);
						_tempSendAsyncTaskList.Clear();
						return result;
					}
				}
				catch (Exception exception)
				{
					return Common.CreateTaskFromException<VoidResult>(exception);
				}
				return Common.CompletedTaskWithTrueResult;
			}

			private void NotifyObserversOfCompletion(Exception targetException = null)
			{
				ImmutableArray<IObserver<TOutput>> observers;
				lock (Observable._SubscriptionLock)
				{
					observers = Observers;
					if (targetException != null)
					{
						Observable.ResetObserverState();
					}
					Observers = ImmutableArray<IObserver<TOutput>>.Empty;
				}
				if (observers.Count <= 0)
				{
					return;
				}
				Exception ex = targetException ?? Observable.GetCompletionError();
				try
				{
					if (ex != null)
					{
						foreach (IObserver<TOutput> item in observers)
						{
							item.OnError(ex);
						}
						return;
					}
					foreach (IObserver<TOutput> item2 in observers)
					{
						item2.OnCompleted();
					}
				}
				catch (Exception error)
				{
					Common.ThrowAsync(error);
				}
			}
		}

		private static readonly ConditionalWeakTable<ISourceBlock<TOutput>, SourceObservable<TOutput>> _table = new ConditionalWeakTable<ISourceBlock<TOutput>, SourceObservable<TOutput>>();

		private readonly object _SubscriptionLock = new object();

		private readonly ISourceBlock<TOutput> _source;

		private ObserversState _observersState;

		private object DebuggerDisplayContent
		{
			get
			{
				IDebuggerDisplay debuggerDisplay = _source as IDebuggerDisplay;
				return string.Format("Observers={0}, Block=\"{1}\"", new object[2]
				{
					_observersState.Observers.Count,
					(debuggerDisplay != null) ? debuggerDisplay.Content : _source
				});
			}
		}

		object IDebuggerDisplay.Content => DebuggerDisplayContent;

		internal static IObservable<TOutput> From(ISourceBlock<TOutput> source)
		{
			return _table.GetValue(source, (ISourceBlock<TOutput> s) => new SourceObservable<TOutput>(s));
		}

		internal SourceObservable(ISourceBlock<TOutput> source)
		{
			_source = source;
			_observersState = new ObserversState(this);
		}

		private AggregateException GetCompletionError()
		{
			Task potentiallyNotSupportedCompletionTask = Common.GetPotentiallyNotSupportedCompletionTask(_source);
			if (potentiallyNotSupportedCompletionTask != null && potentiallyNotSupportedCompletionTask.IsFaulted)
			{
				return potentiallyNotSupportedCompletionTask.Exception;
			}
			return null;
		}

		IDisposable IObservable<TOutput>.Subscribe(IObserver<TOutput> observer)
		{
			if (observer == null)
			{
				throw new ArgumentNullException("observer");
			}
			Task potentiallyNotSupportedCompletionTask = Common.GetPotentiallyNotSupportedCompletionTask(_source);
			Exception ex = null;
			lock (_SubscriptionLock)
			{
				if (potentiallyNotSupportedCompletionTask == null || !potentiallyNotSupportedCompletionTask.IsCompleted || !_observersState.Target.Completion.IsCompleted)
				{
					_observersState.Observers = _observersState.Observers.Add(observer);
					if (_observersState.Observers.Count == 1)
					{
						_observersState.Unlinker = _source.LinkTo(_observersState.Target);
						if (_observersState.Unlinker == null)
						{
							_observersState.Observers = ImmutableArray<IObserver<TOutput>>.Empty;
							return null;
						}
					}
					return Disposables.Create(delegate(SourceObservable<TOutput> s, IObserver<TOutput> o)
					{
						s.Unsubscribe(o);
					}, this, observer);
				}
				ex = GetCompletionError();
			}
			if (ex != null)
			{
				observer.OnError(ex);
			}
			else
			{
				observer.OnCompleted();
			}
			return Disposables.Nop;
		}

		private void Unsubscribe(IObserver<TOutput> observer)
		{
			lock (_SubscriptionLock)
			{
				ObserversState observersState = _observersState;
				if (observersState.Observers.Contains(observer))
				{
					if (observersState.Observers.Count == 1)
					{
						ResetObserverState();
					}
					else
					{
						observersState.Observers = observersState.Observers.Remove(observer);
					}
				}
			}
		}

		private ImmutableArray<IObserver<TOutput>> ResetObserverState()
		{
			ObserversState observersState = _observersState;
			ImmutableArray<IObserver<TOutput>> observers = observersState.Observers;
			_observersState = new ObserversState(this);
			observersState.Unlinker.Dispose();
			observersState.Canceler.Cancel();
			return observers;
		}
	}

	[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
	private sealed class TargetObserver<TInput> : IObserver<TInput>, IDebuggerDisplay
	{
		private readonly ITargetBlock<TInput> _target;

		private object DebuggerDisplayContent
		{
			get
			{
				IDebuggerDisplay debuggerDisplay = _target as IDebuggerDisplay;
				return $"Block=\"{((debuggerDisplay != null) ? debuggerDisplay.Content : _target)}\"";
			}
		}

		object IDebuggerDisplay.Content => DebuggerDisplayContent;

		internal TargetObserver(ITargetBlock<TInput> target)
		{
			_target = target;
		}

		void IObserver<TInput>.OnNext(TInput value)
		{
			Task<bool> task = SendAsyncToTarget(value);
			task.GetAwaiter().GetResult();
		}

		void IObserver<TInput>.OnCompleted()
		{
			_target.Complete();
		}

		void IObserver<TInput>.OnError(Exception error)
		{
			_target.Fault(error);
		}

		internal Task<bool> SendAsyncToTarget(TInput value)
		{
			return _target.SendAsync(value);
		}
	}

	private class NullTargetBlock<TInput> : ITargetBlock<TInput>, IDataflowBlock
	{
		private Task _completion;

		Task IDataflowBlock.Completion => LazyInitializer.EnsureInitialized(ref _completion, () => new TaskCompletionSource<VoidResult>().Task);

		DataflowMessageStatus ITargetBlock<TInput>.OfferMessage(DataflowMessageHeader messageHeader, TInput messageValue, ISourceBlock<TInput> source, bool consumeToAccept)
		{
			if (!messageHeader.IsValid)
			{
				throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
			}
			if (consumeToAccept)
			{
				if (source == null)
				{
					throw new ArgumentException(SR1.Argument_CantConsumeFromANullSource, "consumeToAccept");
				}
				source.ConsumeMessage(messageHeader, this, out var messageConsumed);
				if (!messageConsumed)
				{
					return DataflowMessageStatus.NotAvailable;
				}
			}
			return DataflowMessageStatus.Accepted;
		}

		void IDataflowBlock.Complete()
		{
		}

		void IDataflowBlock.Fault(Exception exception)
		{
		}
	}

	private static readonly Action<object> _cancelCts = delegate(object state)
	{
		((CancellationTokenSource)state).Cancel();
	};

	private static readonly ExecutionDataflowBlockOptions _nonGreedyExecutionOptions = new ExecutionDataflowBlockOptions
	{
		BoundedCapacity = 1
	};

	public static IDisposable LinkTo<TOutput>(this ISourceBlock<TOutput> source, ITargetBlock<TOutput> target)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		return source.LinkTo(target, DataflowLinkOptions.Default);
	}

	public static IDisposable LinkTo<TOutput>(this ISourceBlock<TOutput> source, ITargetBlock<TOutput> target, Predicate<TOutput> predicate)
	{
		return source.LinkTo(target, DataflowLinkOptions.Default, predicate);
	}

	public static IDisposable LinkTo<TOutput>(this ISourceBlock<TOutput> source, ITargetBlock<TOutput> target, DataflowLinkOptions linkOptions, Predicate<TOutput> predicate)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (linkOptions == null)
		{
			throw new ArgumentNullException("linkOptions");
		}
		if (predicate == null)
		{
			throw new ArgumentNullException("predicate");
		}
		FilteredLinkPropagator<TOutput> target2 = new FilteredLinkPropagator<TOutput>(source, target, predicate);
		return source.LinkTo(target2, linkOptions);
	}

	public static bool Post<TInput>(this ITargetBlock<TInput> target, TInput item)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		return target.OfferMessage(Common.SingleMessageHeader, item, null, consumeToAccept: false) == DataflowMessageStatus.Accepted;
	}

	public static Task<bool> SendAsync<TInput>(this ITargetBlock<TInput> target, TInput item)
	{
		return target.SendAsync(item, CancellationToken.None);
	}

	public static Task<bool> SendAsync<TInput>(this ITargetBlock<TInput> target, TInput item, CancellationToken cancellationToken)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (cancellationToken.IsCancellationRequested)
		{
			return Common.CreateTaskFromCancellation<bool>(cancellationToken);
		}
		SendAsyncSource<TInput> sendAsyncSource;
		try
		{
			switch (target.OfferMessage(Common.SingleMessageHeader, item, null, consumeToAccept: false))
			{
			default:
				sendAsyncSource = new SendAsyncSource<TInput>(target, item, cancellationToken);
				break;
			case DataflowMessageStatus.DecliningPermanently:
				return Common.CompletedTaskWithFalseResult;
			case DataflowMessageStatus.Accepted:
				return Common.CompletedTaskWithTrueResult;
			}
		}
		catch (Exception ex)
		{
			Common.StoreDataflowMessageValueIntoExceptionData(ex, item);
			return Common.CreateTaskFromException<bool>(ex);
		}
		sendAsyncSource.OfferToTarget();
		return sendAsyncSource.Task;
	}

	public static bool TryReceive<TOutput>(this IReceivableSourceBlock<TOutput> source, out TOutput item)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return source.TryReceive(null, out item);
	}

	public static Task<TOutput> ReceiveAsync<TOutput>(this ISourceBlock<TOutput> source)
	{
		return source.ReceiveAsync(Common.InfiniteTimeSpan, CancellationToken.None);
	}

	public static Task<TOutput> ReceiveAsync<TOutput>(this ISourceBlock<TOutput> source, CancellationToken cancellationToken)
	{
		return source.ReceiveAsync(Common.InfiniteTimeSpan, cancellationToken);
	}

	public static Task<TOutput> ReceiveAsync<TOutput>(this ISourceBlock<TOutput> source, TimeSpan timeout)
	{
		return source.ReceiveAsync(timeout, CancellationToken.None);
	}

	public static Task<TOutput> ReceiveAsync<TOutput>(this ISourceBlock<TOutput> source, TimeSpan timeout, CancellationToken cancellationToken)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (!Common.IsValidTimeout(timeout))
		{
			throw new ArgumentOutOfRangeException("timeout", SR1.ArgumentOutOfRange_NeedNonNegOrNegative1);
		}
		return source.ReceiveCore(attemptTryReceive: true, timeout, cancellationToken);
	}

	public static TOutput Receive<TOutput>(this ISourceBlock<TOutput> source)
	{
		return source.Receive(Common.InfiniteTimeSpan, CancellationToken.None);
	}

	public static TOutput Receive<TOutput>(this ISourceBlock<TOutput> source, CancellationToken cancellationToken)
	{
		return source.Receive(Common.InfiniteTimeSpan, cancellationToken);
	}

	public static TOutput Receive<TOutput>(this ISourceBlock<TOutput> source, TimeSpan timeout)
	{
		return source.Receive(timeout, CancellationToken.None);
	}

	public static TOutput Receive<TOutput>(this ISourceBlock<TOutput> source, TimeSpan timeout, CancellationToken cancellationToken)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (!Common.IsValidTimeout(timeout))
		{
			throw new ArgumentOutOfRangeException("timeout", SR1.ArgumentOutOfRange_NeedNonNegOrNegative1);
		}
		cancellationToken.ThrowIfCancellationRequested();
		if (source is IReceivableSourceBlock<TOutput> receivableSourceBlock && receivableSourceBlock.TryReceive(null, out var item))
		{
			return item;
		}
		Task<TOutput> task = source.ReceiveCore(attemptTryReceive: false, timeout, cancellationToken);
		try
		{
			return task.GetAwaiter().GetResult();
		}
		catch
		{
			if (task.IsCanceled)
			{
				cancellationToken.ThrowIfCancellationRequested();
			}
			throw;
		}
	}

	private static Task<TOutput> ReceiveCore<TOutput>(this ISourceBlock<TOutput> source, bool attemptTryReceive, TimeSpan timeout, CancellationToken cancellationToken)
	{
		if (cancellationToken.IsCancellationRequested)
		{
			return Common.CreateTaskFromCancellation<TOutput>(cancellationToken);
		}
		if (attemptTryReceive && source is IReceivableSourceBlock<TOutput> receivableSourceBlock)
		{
			try
			{
				if (receivableSourceBlock.TryReceive(null, out var item))
				{
					return Task.FromResult(item);
				}
			}
			catch (Exception exception)
			{
				return Common.CreateTaskFromException<TOutput>(exception);
			}
		}
		int num = (int)timeout.TotalMilliseconds;
		if (num == 0)
		{
			return Common.CreateTaskFromException<TOutput>(ReceiveTarget<TOutput>.CreateExceptionForTimeout());
		}
		return ReceiveCoreByLinking(source, num, cancellationToken);
	}

	private static Task<TOutput> ReceiveCoreByLinking<TOutput>(ISourceBlock<TOutput> source, int millisecondsTimeout, CancellationToken cancellationToken)
	{
		ReceiveTarget<TOutput> receiveTarget = new ReceiveTarget<TOutput>();
		try
		{
			if (cancellationToken.CanBeCanceled)
			{
				receiveTarget._externalCancellationToken = cancellationToken;
				receiveTarget._regFromExternalCancellationToken = cancellationToken.Register(_cancelCts, receiveTarget._cts);
			}
			if (millisecondsTimeout > 0)
			{
				receiveTarget._timer = new System.Threading.Tasks.Dataflow.Internal.Threading.Timer(ReceiveTarget<TOutput>.CachedLinkingTimerCallback, receiveTarget, millisecondsTimeout, -1);
			}
			if (receiveTarget._cts.Token.CanBeCanceled)
			{
				receiveTarget._cts.Token.Register(ReceiveTarget<TOutput>.CachedLinkingCancellationCallback, receiveTarget);
			}
			IDisposable comparand = (receiveTarget._unlink = source.LinkTo(receiveTarget, DataflowLinkOptions.UnlinkAfterOneAndPropagateCompletion));
			if (Volatile.Read(ref receiveTarget._cleanupReserved))
			{
				Interlocked.CompareExchange(ref receiveTarget._unlink, null, comparand)?.Dispose();
			}
		}
		catch (Exception receivedException)
		{
			Exception ex = (receiveTarget._receivedException = receivedException);
			receiveTarget.TryCleanupAndComplete(ReceiveCoreByLinkingCleanupReason.SourceProtocolError);
		}
		return receiveTarget.Task;
	}

	public static Task<bool> OutputAvailableAsync<TOutput>(this ISourceBlock<TOutput> source)
	{
		return source.OutputAvailableAsync(CancellationToken.None);
	}

	public static Task<bool> OutputAvailableAsync<TOutput>(this ISourceBlock<TOutput> source, CancellationToken cancellationToken)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		if (cancellationToken.IsCancellationRequested)
		{
			return Common.CreateTaskFromCancellation<bool>(cancellationToken);
		}
		OutputAvailableAsyncTarget<TOutput> outputAvailableAsyncTarget = new OutputAvailableAsyncTarget<TOutput>();
		try
		{
			outputAvailableAsyncTarget._unlinker = source.LinkTo(outputAvailableAsyncTarget, DataflowLinkOptions.UnlinkAfterOneAndPropagateCompletion);
			if (outputAvailableAsyncTarget.Task.IsCompleted)
			{
				return outputAvailableAsyncTarget.Task;
			}
			if (cancellationToken.CanBeCanceled)
			{
				outputAvailableAsyncTarget._ctr = cancellationToken.Register(OutputAvailableAsyncTarget<TOutput>.s_cancelAndUnlink, outputAvailableAsyncTarget);
			}
			return outputAvailableAsyncTarget.Task.ContinueWith(OutputAvailableAsyncTarget<TOutput>.s_handleCompletion, outputAvailableAsyncTarget, CancellationToken.None, Common.GetContinuationOptions() | TaskContinuationOptions.NotOnCanceled, TaskScheduler.Default);
		}
		catch (Exception exception)
		{
			outputAvailableAsyncTarget.TrySetException(exception);
			outputAvailableAsyncTarget.AttemptThreadSafeUnlink();
			return outputAvailableAsyncTarget.Task;
		}
	}

	public static IPropagatorBlock<TInput, TOutput> Encapsulate<TInput, TOutput>(ITargetBlock<TInput> target, ISourceBlock<TOutput> source)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return new EncapsulatingPropagator<TInput, TOutput>(target, source);
	}

	public static Task<int> Choose<T1, T2>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2)
	{
		return Choose(source1, action1, source2, action2, DataflowBlockOptions.Default);
	}

	public static Task<int> Choose<T1, T2>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2, DataflowBlockOptions dataflowBlockOptions)
	{
		if (source1 == null)
		{
			throw new ArgumentNullException("source1");
		}
		if (action1 == null)
		{
			throw new ArgumentNullException("action1");
		}
		if (source2 == null)
		{
			throw new ArgumentNullException("source2");
		}
		if (action2 == null)
		{
			throw new ArgumentNullException("action2");
		}
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		return ChooseCore<T1, T2, VoidResult>(source1, action1, source2, action2, null, null, dataflowBlockOptions);
	}

	public static Task<int> Choose<T1, T2, T3>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2, ISourceBlock<T3> source3, Action<T3> action3)
	{
		return Choose(source1, action1, source2, action2, source3, action3, DataflowBlockOptions.Default);
	}

	public static Task<int> Choose<T1, T2, T3>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2, ISourceBlock<T3> source3, Action<T3> action3, DataflowBlockOptions dataflowBlockOptions)
	{
		if (source1 == null)
		{
			throw new ArgumentNullException("source1");
		}
		if (action1 == null)
		{
			throw new ArgumentNullException("action1");
		}
		if (source2 == null)
		{
			throw new ArgumentNullException("source2");
		}
		if (action2 == null)
		{
			throw new ArgumentNullException("action2");
		}
		if (source3 == null)
		{
			throw new ArgumentNullException("source3");
		}
		if (action3 == null)
		{
			throw new ArgumentNullException("action3");
		}
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		return ChooseCore(source1, action1, source2, action2, source3, action3, dataflowBlockOptions);
	}

	private static Task<int> ChooseCore<T1, T2, T3>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2, ISourceBlock<T3> source3, Action<T3> action3, DataflowBlockOptions dataflowBlockOptions)
	{
		bool flag = source3 != null;
		if (dataflowBlockOptions.CancellationToken.IsCancellationRequested)
		{
			return Common.CreateTaskFromCancellation<int>(dataflowBlockOptions.CancellationToken);
		}
		try
		{
			TaskScheduler taskScheduler = dataflowBlockOptions.TaskScheduler;
			if (TryChooseFromSource(source1, action1, 0, taskScheduler, out var task) || TryChooseFromSource(source2, action2, 1, taskScheduler, out task) || (flag && TryChooseFromSource(source3, action3, 2, taskScheduler, out task)))
			{
				return task;
			}
		}
		catch (Exception exception)
		{
			return Common.CreateTaskFromException<int>(exception);
		}
		return ChooseCoreByLinking(source1, action1, source2, action2, source3, action3, dataflowBlockOptions);
	}

	private static bool TryChooseFromSource<T>(ISourceBlock<T> source, Action<T> action, int branchId, TaskScheduler scheduler, out Task<int> task)
	{
		if (source is IReceivableSourceBlock<T> source2 && source2.TryReceive(out var item))
		{
			task = Task.Factory.StartNew(ChooseTarget<T>.s_processBranchFunction, Tuple.Create(action, item, branchId), CancellationToken.None, Common.GetCreationOptionsForTask(), scheduler);
			return true;
		}
		task = null;
		return false;
	}

	private static Task<int> ChooseCoreByLinking<T1, T2, T3>(ISourceBlock<T1> source1, Action<T1> action1, ISourceBlock<T2> source2, Action<T2> action2, ISourceBlock<T3> source3, Action<T3> action3, DataflowBlockOptions dataflowBlockOptions)
	{
		bool flag = source3 != null;
		StrongBox<Task> boxedCompleted = new StrongBox<Task>();
		CancellationTokenSource cts = CancellationTokenSource.CreateLinkedTokenSource(dataflowBlockOptions.CancellationToken, CancellationToken.None);
		TaskScheduler taskScheduler = dataflowBlockOptions.TaskScheduler;
		Task<int>[] array = new Task<int>[flag ? 3 : 2];
		array[0] = CreateChooseBranch(boxedCompleted, cts, taskScheduler, 0, source1, action1);
		array[1] = CreateChooseBranch(boxedCompleted, cts, taskScheduler, 1, source2, action2);
		if (flag)
		{
			array[2] = CreateChooseBranch(boxedCompleted, cts, taskScheduler, 2, source3, action3);
		}
		TaskCompletionSource<int> result = new TaskCompletionSource<int>();
		Task.Factory.ContinueWhenAll(array, delegate(Task<int>[] tasks)
		{
			List<Exception> list = null;
			int num = -1;
			foreach (Task<int> task in tasks)
			{
				switch (task.Status)
				{
				case TaskStatus.Faulted:
					Common.AddException(ref list, task.Exception, unwrapInnerExceptions: true);
					break;
				case TaskStatus.RanToCompletion:
				{
					int result2 = task.Result;
					if (result2 >= 0)
					{
						num = result2;
					}
					break;
				}
				}
			}
			if (list != null)
			{
				result.TrySetException(list);
			}
			else if (num >= 0)
			{
				result.TrySetResult(num);
			}
			else
			{
				result.TrySetCanceled();
			}
			cts.Dispose();
		}, CancellationToken.None, Common.GetContinuationOptions(), TaskScheduler.Default);
		return result.Task;
	}

	private static Task<int> CreateChooseBranch<T>(StrongBox<Task> boxedCompleted, CancellationTokenSource cts, TaskScheduler scheduler, int branchId, ISourceBlock<T> source, Action<T> action)
	{
		if (cts.IsCancellationRequested)
		{
			return Common.CreateTaskFromCancellation<int>(cts.Token);
		}
		ChooseTarget<T> chooseTarget = new ChooseTarget<T>(boxedCompleted, cts.Token);
		IDisposable unlink;
		try
		{
			unlink = source.LinkTo(chooseTarget, DataflowLinkOptions.UnlinkAfterOneAndPropagateCompletion);
		}
		catch (Exception exception)
		{
			cts.Cancel();
			return Common.CreateTaskFromException<int>(exception);
		}
		return chooseTarget.Task.ContinueWith(delegate(Task<T> completed)
		{
			try
			{
				if (completed.Status == TaskStatus.RanToCompletion)
				{
					cts.Cancel();
					action(completed.Result);
					return branchId;
				}
				return -1;
			}
			finally
			{
				unlink.Dispose();
			}
		}, CancellationToken.None, Common.GetContinuationOptions(), scheduler);
	}

	public static IObservable<TOutput> AsObservable<TOutput>(this ISourceBlock<TOutput> source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source");
		}
		return SourceObservable<TOutput>.From(source);
	}

	public static IObserver<TInput> AsObserver<TInput>(this ITargetBlock<TInput> target)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		return new TargetObserver<TInput>(target);
	}

	public static ITargetBlock<TInput> NullTarget<TInput>()
	{
		return new NullTargetBlock<TInput>();
	}
}
