using System.Collections.Generic;
using System.Diagnostics;

namespace System.Threading.Tasks.Dataflow.Internal;

[DebuggerTypeProxy(typeof(JoinBlockTarget<>.DebugView))]
[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
internal sealed class JoinBlockTarget<T> : JoinBlockTargetBase, ITargetBlock<T>, IDataflowBlock, IDebuggerDisplay
{
	private sealed class NonGreedyState
	{
		internal readonly QueuedMap<ISourceBlock<T>, DataflowMessageHeader> PostponedMessages = new QueuedMap<ISourceBlock<T>, DataflowMessageHeader>();

		internal KeyValuePair<ISourceBlock<T>, DataflowMessageHeader> ReservedMessage;

		internal KeyValuePair<bool, T> ConsumedMessage;
	}

	private sealed class DebugView
	{
		private readonly JoinBlockTarget<T> _joinBlockTarget;

		public IEnumerable<T> InputQueue => _joinBlockTarget._messages;

		public bool IsDecliningPermanently
		{
			get
			{
				if (!_joinBlockTarget._decliningPermanently)
				{
					return _joinBlockTarget._sharedResources._decliningPermanently;
				}
				return true;
			}
		}

		public DebugView(JoinBlockTarget<T> joinBlockTarget)
		{
			_joinBlockTarget = joinBlockTarget;
		}
	}

	private readonly JoinBlockTargetSharedResources _sharedResources;

	private readonly TaskCompletionSource<VoidResult> _completionTask = new TaskCompletionSource<VoidResult>();

	private readonly Queue<T> _messages;

	private readonly NonGreedyState _nonGreedy;

	private bool _decliningPermanently;

	internal override bool IsDecliningPermanently => _decliningPermanently;

	internal override bool HasAtLeastOneMessageAvailable
	{
		get
		{
			if (_sharedResources._dataflowBlockOptions.Greedy)
			{
				return _messages.Count > 0;
			}
			return _nonGreedy.ConsumedMessage.Key;
		}
	}

	internal override bool HasAtLeastOnePostponedMessage
	{
		get
		{
			if (_nonGreedy != null)
			{
				return _nonGreedy.PostponedMessages.Count > 0;
			}
			return false;
		}
	}

	internal override int NumberOfMessagesAvailableOrPostponed
	{
		get
		{
			if (_sharedResources._dataflowBlockOptions.Greedy)
			{
				return _messages.Count;
			}
			return _nonGreedy.PostponedMessages.Count;
		}
	}

	internal override bool HasTheHighestNumberOfMessagesAvailable
	{
		get
		{
			int count = _messages.Count;
			JoinBlockTargetBase[] targets = _sharedResources._targets;
			int num = 0;
			while (true)
			{
				if (num < targets.Length)
				{
					JoinBlockTargetBase joinBlockTargetBase = targets[num];
					if (joinBlockTargetBase != this && joinBlockTargetBase.NumberOfMessagesAvailableOrPostponed > count)
					{
						break;
					}
					num++;
					continue;
				}
				return true;
			}
			return false;
		}
	}

	public Task Completion
	{
		get
		{
			throw new NotSupportedException(SR1.NotSupported_MemberNotNeeded);
		}
	}

	internal Task CompletionTaskInternal => _completionTask.Task;

	private int InputCountForDebugger
	{
		get
		{
			if (_messages == null)
			{
				if (!_nonGreedy.ConsumedMessage.Key)
				{
					return 0;
				}
				return 1;
			}
			return _messages.Count;
		}
	}

	private object DebuggerDisplayContent
	{
		get
		{
			IDebuggerDisplay debuggerDisplay = _sharedResources._ownerJoin as IDebuggerDisplay;
			return string.Format("{0} InputCount={1}, Join=\"{2}\"", new object[3]
			{
				Common.GetNameForDebugger(this),
				InputCountForDebugger,
				(debuggerDisplay != null) ? debuggerDisplay.Content : _sharedResources._ownerJoin
			});
		}
	}

	object IDebuggerDisplay.Content => DebuggerDisplayContent;

	internal JoinBlockTarget(JoinBlockTargetSharedResources sharedResources)
	{
		GroupingDataflowBlockOptions dataflowBlockOptions = sharedResources._dataflowBlockOptions;
		_sharedResources = sharedResources;
		if (!dataflowBlockOptions.Greedy || dataflowBlockOptions.BoundedCapacity > 0)
		{
			_nonGreedy = new NonGreedyState();
		}
		if (dataflowBlockOptions.Greedy)
		{
			_messages = new Queue<T>();
		}
	}

	internal T GetOneMessage()
	{
		if (_sharedResources._dataflowBlockOptions.Greedy)
		{
			return _messages.Dequeue();
		}
		T value = _nonGreedy.ConsumedMessage.Value;
		_nonGreedy.ConsumedMessage = new KeyValuePair<bool, T>(key: false, default(T));
		return value;
	}

	internal override bool ReserveOneMessage()
	{
		KeyValuePair<ISourceBlock<T>, DataflowMessageHeader> item;
		lock (_sharedResources.IncomingLock)
		{
			if (!_nonGreedy.PostponedMessages.TryPop(out item))
			{
				return false;
			}
		}
		while (!item.Key.ReserveMessage(item.Value, this))
		{
			lock (_sharedResources.IncomingLock)
			{
				if (!_nonGreedy.PostponedMessages.TryPop(out item))
				{
					return false;
				}
			}
		}
		_nonGreedy.ReservedMessage = item;
		return true;
	}

	internal override bool ConsumeReservedMessage()
	{
		bool messageConsumed;
		T value = _nonGreedy.ReservedMessage.Key.ConsumeMessage(_nonGreedy.ReservedMessage.Value, this, out messageConsumed);
		_nonGreedy.ReservedMessage = default(KeyValuePair<ISourceBlock<T>, DataflowMessageHeader>);
		if (!messageConsumed)
		{
			_sharedResources._exceptionAction(new InvalidOperationException(SR1.InvalidOperation_FailedToConsumeReservedMessage));
			CompleteOncePossible();
			return false;
		}
		lock (_sharedResources.IncomingLock)
		{
			_nonGreedy.ConsumedMessage = new KeyValuePair<bool, T>(key: true, value);
			CompleteIfLastJoinIsFeasible();
		}
		return true;
	}

	internal override bool ConsumeOnePostponedMessage()
	{
		bool hasTheHighestNumberOfMessagesAvailable;
		T item2;
		bool messageConsumed;
		do
		{
			KeyValuePair<ISourceBlock<T>, DataflowMessageHeader> item;
			lock (_sharedResources.IncomingLock)
			{
				hasTheHighestNumberOfMessagesAvailable = HasTheHighestNumberOfMessagesAvailable;
				bool flag = _sharedResources._boundingState.CountIsLessThanBound || !hasTheHighestNumberOfMessagesAvailable;
				if (_decliningPermanently || _sharedResources._decliningPermanently || !flag || !_nonGreedy.PostponedMessages.TryPop(out item))
				{
					return false;
				}
			}
			item2 = item.Key.ConsumeMessage(item.Value, this, out messageConsumed);
		}
		while (!messageConsumed);
		lock (_sharedResources.IncomingLock)
		{
			if (hasTheHighestNumberOfMessagesAvailable)
			{
				_sharedResources._boundingState.CurrentCount++;
			}
			_messages.Enqueue(item2);
			CompleteIfLastJoinIsFeasible();
			return true;
		}
	}

	private void CompleteIfLastJoinIsFeasible()
	{
		int num = (_sharedResources._dataflowBlockOptions.Greedy ? _messages.Count : (_nonGreedy.ConsumedMessage.Key ? 1 : 0));
		if (_sharedResources._joinsCreated + num < _sharedResources._dataflowBlockOptions.ActualMaxNumberOfGroups)
		{
			return;
		}
		_decliningPermanently = true;
		bool flag = true;
		JoinBlockTargetBase[] targets = _sharedResources._targets;
		foreach (JoinBlockTargetBase joinBlockTargetBase in targets)
		{
			if (!joinBlockTargetBase.IsDecliningPermanently)
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			_sharedResources._decliningPermanently = true;
		}
	}

	internal override void ReleaseReservedMessage()
	{
		if (_nonGreedy != null && _nonGreedy.ReservedMessage.Key != null)
		{
			try
			{
				_nonGreedy.ReservedMessage.Key.ReleaseReservation(_nonGreedy.ReservedMessage.Value, this);
			}
			finally
			{
				ClearReservation();
			}
		}
	}

	internal override void ClearReservation()
	{
		_nonGreedy.ReservedMessage = default(KeyValuePair<ISourceBlock<T>, DataflowMessageHeader>);
	}

	internal override void CompleteOncePossible()
	{
		lock (_sharedResources.IncomingLock)
		{
			_decliningPermanently = true;
			if (_messages != null)
			{
				_messages.Clear();
			}
		}
		List<Exception> exceptions = null;
		if (_nonGreedy != null)
		{
			Common.ReleaseAllPostponedMessages(this, _nonGreedy.PostponedMessages, ref exceptions);
		}
		if (exceptions != null)
		{
			foreach (Exception item in exceptions)
			{
				_sharedResources._exceptionAction(item);
			}
		}
		_completionTask.TrySetResult(default(VoidResult));
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
		lock (_sharedResources.IncomingLock)
		{
			if (!_decliningPermanently && !_sharedResources._decliningPermanently)
			{
				if (_sharedResources._dataflowBlockOptions.Greedy && (_sharedResources._boundingState == null || ((_sharedResources._boundingState.CountIsLessThanBound || !HasTheHighestNumberOfMessagesAvailable) && _nonGreedy.PostponedMessages.Count == 0 && _sharedResources._taskForInputProcessing == null)))
				{
					if (consumeToAccept)
					{
						messageValue = source.ConsumeMessage(messageHeader, this, out var messageConsumed);
						if (!messageConsumed)
						{
							return DataflowMessageStatus.NotAvailable;
						}
					}
					if (_sharedResources._boundingState != null && HasTheHighestNumberOfMessagesAvailable)
					{
						_sharedResources._boundingState.CurrentCount++;
					}
					_messages.Enqueue(messageValue);
					CompleteIfLastJoinIsFeasible();
					if (_sharedResources.AllTargetsHaveAtLeastOneMessage)
					{
						_sharedResources._joinFilledAction();
						_sharedResources._joinsCreated++;
					}
					_sharedResources.CompleteBlockIfPossible();
					return DataflowMessageStatus.Accepted;
				}
				if (source != null)
				{
					_nonGreedy.PostponedMessages.Push(source, messageHeader);
					_sharedResources.ProcessAsyncIfNecessary();
					return DataflowMessageStatus.Postponed;
				}
				return DataflowMessageStatus.Declined;
			}
			_sharedResources.CompleteBlockIfPossible();
			return DataflowMessageStatus.DecliningPermanently;
		}
	}

	internal override void CompleteCore(Exception exception, bool dropPendingMessages, bool releaseReservedMessages)
	{
		bool greedy = _sharedResources._dataflowBlockOptions.Greedy;
		lock (_sharedResources.IncomingLock)
		{
			if (exception != null && ((!_decliningPermanently && !_sharedResources._decliningPermanently) || releaseReservedMessages))
			{
				_sharedResources._exceptionAction(exception);
			}
			if (dropPendingMessages && greedy)
			{
				_messages.Clear();
			}
		}
		if (releaseReservedMessages && !greedy)
		{
			JoinBlockTargetBase[] targets = _sharedResources._targets;
			foreach (JoinBlockTargetBase joinBlockTargetBase in targets)
			{
				try
				{
					joinBlockTargetBase.ReleaseReservedMessage();
				}
				catch (Exception obj)
				{
					_sharedResources._exceptionAction(obj);
				}
			}
		}
		lock (_sharedResources.IncomingLock)
		{
			_decliningPermanently = true;
			_sharedResources.CompleteBlockIfPossible();
		}
	}

	void IDataflowBlock.Fault(Exception exception)
	{
		if (exception == null)
		{
			throw new ArgumentNullException("exception");
		}
		CompleteCore(exception, dropPendingMessages: true, releaseReservedMessages: false);
	}
}
