using System.Collections.Generic;
using System.Diagnostics;

namespace System.Threading.Tasks.Dataflow.Internal;

[DebuggerTypeProxy(typeof(TargetRegistry<>.DebugView))]
[DebuggerDisplay("Count={Count}")]
internal sealed class TargetRegistry<T>
{
	internal sealed class LinkedTargetInfo
	{
		internal readonly ITargetBlock<T> Target;

		internal readonly bool PropagateCompletion;

		internal int RemainingMessages;

		internal LinkedTargetInfo Previous;

		internal LinkedTargetInfo Next;

		internal LinkedTargetInfo(ITargetBlock<T> target, DataflowLinkOptions linkOptions)
		{
			Target = target;
			PropagateCompletion = linkOptions.PropagateCompletion;
			RemainingMessages = linkOptions.MaxMessages;
		}
	}

	[DebuggerDisplay("{DebuggerDisplayContent,nq}")]
	[DebuggerTypeProxy(typeof(TargetRegistry<>.NopLinkPropagator.DebugView))]
	private sealed class NopLinkPropagator : IPropagatorBlock<T, T>, ITargetBlock<T>, ISourceBlock<T>, IDataflowBlock, IDebuggerDisplay
	{
		private sealed class DebugView
		{
			private readonly NopLinkPropagator _passthrough;

			public ITargetBlock<T> LinkedTarget => _passthrough._target;

			public DebugView(NopLinkPropagator passthrough)
			{
				_passthrough = passthrough;
			}
		}

		private readonly ISourceBlock<T> _owningSource;

		private readonly ITargetBlock<T> _target;

		Task IDataflowBlock.Completion => _owningSource.Completion;

		private object DebuggerDisplayContent
		{
			get
			{
				IDebuggerDisplay debuggerDisplay = _owningSource as IDebuggerDisplay;
				IDebuggerDisplay debuggerDisplay2 = _target as IDebuggerDisplay;
				return string.Format("{0} Source=\"{1}\", Target=\"{2}\"", new object[3]
				{
					Common.GetNameForDebugger(this),
					(debuggerDisplay != null) ? debuggerDisplay.Content : _owningSource,
					(debuggerDisplay2 != null) ? debuggerDisplay2.Content : _target
				});
			}
		}

		object IDebuggerDisplay.Content => DebuggerDisplayContent;

		internal NopLinkPropagator(ISourceBlock<T> owningSource, ITargetBlock<T> target)
		{
			_owningSource = owningSource;
			_target = target;
		}

		DataflowMessageStatus ITargetBlock<T>.OfferMessage(DataflowMessageHeader messageHeader, T messageValue, ISourceBlock<T> source, bool consumeToAccept)
		{
			return _target.OfferMessage(messageHeader, messageValue, this, consumeToAccept);
		}

		T ISourceBlock<T>.ConsumeMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target, out bool messageConsumed)
		{
			return _owningSource.ConsumeMessage(messageHeader, this, out messageConsumed);
		}

		bool ISourceBlock<T>.ReserveMessage(DataflowMessageHeader messageHeader, ITargetBlock<T> target)
		{
			return _owningSource.ReserveMessage(messageHeader, this);
		}

		void ISourceBlock<T>.ReleaseReservation(DataflowMessageHeader messageHeader, ITargetBlock<T> target)
		{
			_owningSource.ReleaseReservation(messageHeader, this);
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

	private sealed class DebugView
	{
		private readonly TargetRegistry<T> _registry;

		[DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
		public ITargetBlock<T>[] Targets => _registry.TargetsForDebugger;

		public DebugView(TargetRegistry<T> registry)
		{
			_registry = registry;
		}
	}

	private readonly ISourceBlock<T> _owningSource;

	private readonly Dictionary<ITargetBlock<T>, LinkedTargetInfo> _targetInformation;

	private LinkedTargetInfo _firstTarget;

	private LinkedTargetInfo _lastTarget;

	private int _linksWithRemainingMessages;

	internal LinkedTargetInfo FirstTargetNode => _firstTarget;

	private int Count => _targetInformation.Count;

	private ITargetBlock<T>[] TargetsForDebugger
	{
		get
		{
			ITargetBlock<T>[] array = new ITargetBlock<T>[Count];
			int num = 0;
			for (LinkedTargetInfo linkedTargetInfo = _firstTarget; linkedTargetInfo != null; linkedTargetInfo = linkedTargetInfo.Next)
			{
				array[num++] = linkedTargetInfo.Target;
			}
			return array;
		}
	}

	internal TargetRegistry(ISourceBlock<T> owningSource)
	{
		_owningSource = owningSource;
		_targetInformation = new Dictionary<ITargetBlock<T>, LinkedTargetInfo>();
	}

	internal void Add(ref ITargetBlock<T> target, DataflowLinkOptions linkOptions)
	{
		if (_targetInformation.TryGetValue(target, out var _))
		{
			target = new NopLinkPropagator(_owningSource, target);
		}
		LinkedTargetInfo linkedTargetInfo = new LinkedTargetInfo(target, linkOptions);
		AddToList(linkedTargetInfo, linkOptions.Append);
		_targetInformation.Add(target, linkedTargetInfo);
		if (linkedTargetInfo.RemainingMessages > 0)
		{
			_linksWithRemainingMessages++;
		}
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockLinking(_owningSource, target);
		}
	}

	internal bool Contains(ITargetBlock<T> target)
	{
		return _targetInformation.ContainsKey(target);
	}

	internal void Remove(ITargetBlock<T> target, bool onlyIfReachedMaxMessages = false)
	{
		if (!onlyIfReachedMaxMessages || _linksWithRemainingMessages != 0)
		{
			Remove_Slow(target, onlyIfReachedMaxMessages);
		}
	}

	private void Remove_Slow(ITargetBlock<T> target, bool onlyIfReachedMaxMessages)
	{
		if (!_targetInformation.TryGetValue(target, out var value))
		{
			return;
		}
		if (onlyIfReachedMaxMessages && value.RemainingMessages != 1)
		{
			if (value.RemainingMessages > 0)
			{
				value.RemainingMessages--;
			}
			return;
		}
		RemoveFromList(value);
		_targetInformation.Remove(target);
		if (value.RemainingMessages == 0)
		{
			_linksWithRemainingMessages--;
		}
		DataflowEtwProvider log = DataflowEtwProvider.Log;
		if (log.IsEnabled())
		{
			log.DataflowBlockUnlinking(_owningSource, target);
		}
	}

	internal LinkedTargetInfo ClearEntryPoints()
	{
		LinkedTargetInfo firstTarget = _firstTarget;
		_firstTarget = (_lastTarget = null);
		_targetInformation.Clear();
		_linksWithRemainingMessages = 0;
		return firstTarget;
	}

	internal void PropagateCompletion(LinkedTargetInfo firstTarget)
	{
		Task completion = _owningSource.Completion;
		for (LinkedTargetInfo linkedTargetInfo = firstTarget; linkedTargetInfo != null; linkedTargetInfo = linkedTargetInfo.Next)
		{
			if (linkedTargetInfo.PropagateCompletion)
			{
				Common.PropagateCompletion(completion, linkedTargetInfo.Target, Common.AsyncExceptionHandler);
			}
		}
	}

	internal void AddToList(LinkedTargetInfo node, bool append)
	{
		if (_firstTarget == null && _lastTarget == null)
		{
			_firstTarget = (_lastTarget = node);
		}
		else if (append)
		{
			node.Previous = _lastTarget;
			_lastTarget.Next = node;
			_lastTarget = node;
		}
		else
		{
			node.Next = _firstTarget;
			_firstTarget.Previous = node;
			_firstTarget = node;
		}
	}

	internal void RemoveFromList(LinkedTargetInfo node)
	{
		LinkedTargetInfo previous = node.Previous;
		LinkedTargetInfo next = node.Next;
		if (node.Previous != null)
		{
			node.Previous.Next = next;
			node.Previous = null;
		}
		if (node.Next != null)
		{
			node.Next.Previous = previous;
			node.Next = null;
		}
		if (_firstTarget == node)
		{
			_firstTarget = next;
		}
		if (_lastTarget == node)
		{
			_lastTarget = previous;
		}
	}
}
