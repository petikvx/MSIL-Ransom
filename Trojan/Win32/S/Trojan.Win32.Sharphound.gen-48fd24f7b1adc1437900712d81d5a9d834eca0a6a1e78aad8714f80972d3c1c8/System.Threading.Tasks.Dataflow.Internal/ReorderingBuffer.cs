using System.Collections.Generic;
using System.Diagnostics;

namespace System.Threading.Tasks.Dataflow.Internal;

[DebuggerTypeProxy(typeof(ReorderingBuffer<>.DebugView))]
[DebuggerDisplay("Count={CountForDebugging}")]
internal sealed class ReorderingBuffer<TOutput> : IReorderingBuffer
{
	private sealed class DebugView
	{
		private readonly ReorderingBuffer<TOutput> _buffer;

		public Dictionary<long, KeyValuePair<bool, TOutput>> ItemsBuffered => _buffer._reorderingBuffer;

		public long NextIdRequired => _buffer._nextReorderedIdToOutput;

		public DebugView(ReorderingBuffer<TOutput> buffer)
		{
			_buffer = buffer;
		}
	}

	private readonly object _owningSource;

	private readonly Dictionary<long, KeyValuePair<bool, TOutput>> _reorderingBuffer = new Dictionary<long, KeyValuePair<bool, TOutput>>();

	private readonly Action<object, TOutput> _outputAction;

	private long _nextReorderedIdToOutput;

	private object ValueLock => _reorderingBuffer;

	private int CountForDebugging => _reorderingBuffer.Count;

	internal ReorderingBuffer(object owningSource, Action<object, TOutput> outputAction)
	{
		_owningSource = owningSource;
		_outputAction = outputAction;
	}

	internal void AddItem(long id, TOutput item, bool itemIsValid)
	{
		lock (ValueLock)
		{
			if (_nextReorderedIdToOutput == id)
			{
				OutputNextItem(item, itemIsValid);
			}
			else
			{
				_reorderingBuffer.Add(id, new KeyValuePair<bool, TOutput>(itemIsValid, item));
			}
		}
	}

	internal bool? AddItemIfNextAndTrusted(long id, TOutput item, bool isTrusted)
	{
		lock (ValueLock)
		{
			if (_nextReorderedIdToOutput == id)
			{
				if (isTrusted)
				{
					OutputNextItem(item, itemIsValid: true);
					return null;
				}
				return true;
			}
			return false;
		}
	}

	public void IgnoreItem(long id)
	{
		AddItem(id, default(TOutput), itemIsValid: false);
	}

	private void OutputNextItem(TOutput theNextItem, bool itemIsValid)
	{
		_nextReorderedIdToOutput++;
		if (itemIsValid)
		{
			_outputAction(_owningSource, theNextItem);
		}
		KeyValuePair<bool, TOutput> value;
		while (_reorderingBuffer.TryGetValue(_nextReorderedIdToOutput, out value))
		{
			_reorderingBuffer.Remove(_nextReorderedIdToOutput);
			_nextReorderedIdToOutput++;
			if (value.Key)
			{
				_outputAction(_owningSource, value.Value);
			}
		}
	}
}
