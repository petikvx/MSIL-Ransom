using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow.Internal;

namespace System.Threading.Tasks.Dataflow;

[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
[DebuggerTypeProxy(typeof(WriteOnceBlock<>.DebugView))]
public sealed class WriteOnceBlock<T> : IPropagatorBlock<T, T>, ITargetBlock<T>, ISourceBlock<T>, IReceivableSourceBlock<T>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class DebugView
	{
		private readonly WriteOnceBlock<T> _writeOnceBlock;

		public bool IsCompleted => _writeOnceBlock.Completion.IsCompleted;

		public int Id => Common.GetBlockId(_writeOnceBlock);

		public bool HasValue => _writeOnceBlock.HasValue;

		public T Value => _writeOnceBlock.Value;

		public DataflowBlockOptions DataflowBlockOptions => _writeOnceBlock._dataflowBlockOptions;

		public TargetRegistry<T> LinkedTargets => _writeOnceBlock._targetRegistry;

		public DebugView(WriteOnceBlock<T> writeOnceBlock)
		{
			_writeOnceBlock = writeOnceBlock;
		}
	}

	private readonly TargetRegistry<T> _targetRegistry;

	private readonly Func<T, T> _cloningFunction;

	private readonly DataflowBlockOptions _dataflowBlockOptions;

	private TaskCompletionSource<VoidResult> _lazyCompletionTaskSource;

	private bool _decliningPermanently;

	private bool _completionReserved;

	private DataflowMessageHeader _header;

	private T _value;

	private object ValueLock => _targetRegistry;

	public Task Completion => CompletionTaskSource.Task;

	private TaskCompletionSource<VoidResult> CompletionTaskSource
	{
		get
		{
			if (_lazyCompletionTaskSource == null)
			{
				Interlocked.CompareExchange(ref _lazyCompletionTaskSource, new TaskCompletionSource<VoidResult>(), null);
			}
			return _lazyCompletionTaskSource;
		}
	}

	private bool HasValue => _header.IsValid;

	private T Value
	{
		get
		{
			if (!_header.IsValid)
			{
				return default(T);
			}
			return _value;
		}
	}

	private object DebuggerDisplayContent => string.Format("{0}, HasValue={1}, Value={2}", new object[3]
	{
		Common.GetNameForDebugger(this, _dataflowBlockOptions),
		HasValue,
		Value
	});

	object IDebuggerDisplay.Content => DebuggerDisplayContent;

	public WriteOnceBlock(Func<T, T> cloningFunction)
		: this(cloningFunction, DataflowBlockOptions.Default)
	{
	}

	public WriteOnceBlock(Func<T, T> cloningFunction, DataflowBlockOptions dataflowBlockOptions)
	{
		if (dataflowBlockOptions == null)
		{
			throw new ArgumentNullException("dataflowBlockOptions");
		}
		_cloningFunction = cloningFunction;
		_dataflowBlockOptions = dataflowBlockOptions.DefaultOrClone();
		_targetRegistry = new TargetRegistry<T>(this);
		if (dataflowBlockOptions.CancellationToken.CanBeCanceled)
		{
			_lazyCompletionTaskSource = new TaskCompletionSource<VoidResult>();
			if (dataflowBlockOptions.CancellationToken.IsCancellationRequested)
			{
				_decliningPermanently = true;
				_completionReserved = true;
				_lazyCompletionTaskSource.SetCanceled();
			}
			else
			{
				Common.WireCancellationToComplete(dataflowBlockOptions.CancellationToken, _lazyCompletionTaskSource.Task, delegate(object state)
				{
					((WriteOnceBlock<T>)state).Complete();
				}, this);
			}
		}
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockCreated(this, dataflowBlockOptions);
		}
	}

	private void CompleteBlockAsync(IList<Exception> exceptions)
	{
		if (exceptions == null)
		{
			Task task = new Task(delegate(object state)
			{
				((WriteOnceBlock<T>)state).OfferToTargetsAndCompleteBlock();
			}, this, Common.GetCreationOptionsForTask());
			DataflowEtwProvider log = DataflowEtwProvider.Log;
			if (log.IsEnabled())
			{
				log.TaskLaunchedForMessageHandling(this, task, DataflowEtwProvider.TaskLaunchedReason.OfferingOutputMessages, _header.IsValid ? 1 : 0);
			}
			Exception ex = Common.StartTaskSafe(task, _dataflowBlockOptions.TaskScheduler);
			if (ex != null)
			{
				CompleteCore(ex, storeExceptionEvenIfAlreadyCompleting: true);
			}
		}
		else
		{
			Task.Factory.StartNew(delegate(object state)
			{
				Tuple<WriteOnceBlock<T>, IList<Exception>> tuple = (Tuple<WriteOnceBlock<T>, IList<Exception>>)state;
				tuple.Item1.CompleteBlock(tuple.Item2);
			}, Tuple.Create(this, exceptions), CancellationToken.None, Common.GetCreationOptionsForTask(), TaskScheduler.Default);
		}
	}

	private void OfferToTargetsAndCompleteBlock()
	{
		List<Exception> exceptions = OfferToTargets();
		CompleteBlock(exceptions);
	}

	private void CompleteBlock(IList<Exception> exceptions)
	{
		TargetRegistry<T>.LinkedTargetInfo firstTarget = _targetRegistry.ClearEntryPoints();
		if (exceptions != null && exceptions.Count > 0)
		{
			CompletionTaskSource.TrySetException(exceptions);
		}
		else if (_dataflowBlockOptions.CancellationToken.IsCancellationRequested)
		{
			CompletionTaskSource.TrySetCanceled();
		}
		else if (Interlocked.CompareExchange(ref _lazyCompletionTaskSource, Common.CompletedVoidResultTaskCompletionSource, null) != null)
		{
			_lazyCompletionTaskSource.TrySetResult(default(VoidResult));
		}
		_targetRegistry.PropagateCompletion(firstTarget);
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockCompleted(this);
		}
	}

	void IDataflowBlock.Fault(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		CompleteCore(exception, storeExceptionEvenIfAlreadyCompleting: false);
	}

	public void Complete()
	{
		CompleteCore(null, storeExceptionEvenIfAlreadyCompleting: false);
	}

	private void CompleteCore(Exception exception, bool storeExceptionEvenIfAlreadyCompleting)
	{
		bool flag = false;
		lock (ValueLock)
		{
			if (_decliningPermanently && !storeExceptionEvenIfAlreadyCompleting)
			{
				return;
			}
			_decliningPermanently = true;
			if (!_completionReserved || storeExceptionEvenIfAlreadyCompleting)
			{
				_completionReserved = true;
				flag = true;
			}
		}
		if (flag)
		{
			List<Exception> list = null;
			if (exception != null)
			{
				list = new List<Exception>();
				list.Add(exception);
			}
			CompleteBlockAsync(list);
		}
	}

	public bool TryReceive(Predicate<T> filter, out T item)
	{
		if (_header.IsValid && (filter == null || filter(_value)))
		{
			item = CloneItem(_value);
			return true;
		}
		item = default(T);
		return false;
	}

	bool IReceivableSourceBlock<T>.TryReceiveAll(out IList<T> items)
	{
		if (TryReceive(null, out var item))
		{
			items = new T[1] { item };
			return true;
		}
		items = null;
		return false;
	}

	public IDisposable LinkTo(ITargetBlock<T> target, DataflowLinkOptions linkOptions)
	{
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (linkOptions == null)
		{
			throw new ArgumentNullException("linkOptions");
		}
		bool hasValue;
		lock (ValueLock)
		{
			hasValue = HasValue;
			bool completionReserved = _completionReserved;
			if (!hasValue && !completionReserved)
			{
				_targetRegistry.Add(ref target, linkOptions);
				return Common.CreateUnlinker(ValueLock, _targetRegistry, target);
			}
		}
		if (hasValue)
		{
			bool consumeToAccept = _cloningFunction != null;
			target.OfferMessage(_header, _value, this, consumeToAccept);
		}
		if (linkOptions.PropagateCompletion)
		{
			Common.PropagateCompletionOnceCompleted(Completion, target);
		}
		return Disposables.Nop;
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
		bool flag = false;
		lock (ValueLock)
		{
			if (_decliningPermanently)
			{
				return DataflowMessageStatus.DecliningPermanently;
			}
			if (consumeToAccept)
			{
				messageValue = source.ConsumeMessage(messageHeader, this, out var messageConsumed);
				if (!messageConsumed)
				{
					return DataflowMessageStatus.NotAvailable;
				}
			}
			_header = Common.SingleMessageHeader;
			_value = messageValue;
			_decliningPermanently = true;
			if (!_completionReserved)
			{
				_completionReserved = true;
				flag = true;
			}
		}
		if (flag)
		{
			CompleteBlockAsync(null);
		}
		return DataflowMessageStatus.Accepted;
	}

	T ISourceBlock<T>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target, out bool messageConsumed)
	{
		if (!messageHeader.IsValid)
		{
			throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (_header.Id == messageHeader.Id)
		{
			messageConsumed = true;
			return CloneItem(_value);
		}
		messageConsumed = false;
		return default(T);
	}

	bool ISourceBlock<T>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target)
	{
		if (!messageHeader.IsValid)
		{
			throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		return _header.Id == messageHeader.Id;
	}

	void ISourceBlock<T>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<T> target)
	{
		if (!messageHeader.IsValid)
		{
			throw new ArgumentException(SR1.Argument_InvalidMessageHeader, "messageHeader");
		}
		if (target == null)
		{
			throw new ArgumentNullException("target");
		}
		if (_header.Id != messageHeader.Id)
		{
			throw new InvalidOperationException(SR1.InvalidOperation_MessageNotReservedByTarget);
		}
		bool consumeToAccept = _cloningFunction != null;
		target.OfferMessage(_header, _value, this, consumeToAccept);
	}

	private T CloneItem(T item)
	{
		if (_cloningFunction == null)
		{
			return item;
		}
		return _cloningFunction(item);
	}

	private List<Exception> OfferToTargets()
	{
		List<Exception> list = null;
		if (HasValue)
		{
			TargetRegistry<T>.LinkedTargetInfo linkedTargetInfo = _targetRegistry.FirstTargetNode;
			while (linkedTargetInfo != null)
			{
				TargetRegistry<T>.LinkedTargetInfo next = linkedTargetInfo.Next;
				ITargetBlock<T> target = linkedTargetInfo.Target;
				try
				{
					bool consumeToAccept = _cloningFunction != null;
					target.OfferMessage(_header, _value, this, consumeToAccept);
				}
				catch (Exception ex)
				{
					Common.StoreDataflowMessageValueIntoExceptionData(ex, _value);
					Common.AddException(ref list, ex);
				}
				linkedTargetInfo = next;
			}
		}
		return list;
	}

	public override string ToString()
	{
		return Common.GetNameForDebugger(this, _dataflowBlockOptions);
	}
}
