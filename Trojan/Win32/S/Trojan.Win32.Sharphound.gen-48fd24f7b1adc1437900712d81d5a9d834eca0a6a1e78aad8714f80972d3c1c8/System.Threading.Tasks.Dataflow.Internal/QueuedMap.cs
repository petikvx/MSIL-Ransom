using System.Collections.Generic;
using System.Diagnostics;

namespace System.Threading.Tasks.Dataflow.Internal;

[DebuggerDisplay("Count = {Count}")]
[DebuggerTypeProxy(typeof(EnumerableDebugView<, >))]
internal sealed class QueuedMap<TKey, TValue>
{
	private sealed class ArrayBasedLinkedQueue<T>
	{
		private const int TERMINATOR_INDEX = -1;

		private readonly List<KeyValuePair<int, T>> _storage;

		private int _headIndex = -1;

		private int _tailIndex = -1;

		private int _freeIndex = -1;

		internal bool IsEmpty => _headIndex == -1;

		internal ArrayBasedLinkedQueue()
		{
			_storage = new List<KeyValuePair<int, T>>();
		}

		internal ArrayBasedLinkedQueue(int capacity)
		{
			_storage = new List<KeyValuePair<int, T>>(capacity);
		}

		internal int Enqueue(T item)
		{
			int num;
			if (_freeIndex != -1)
			{
				num = _freeIndex;
				_freeIndex = _storage[_freeIndex].Key;
				_storage[num] = new KeyValuePair<int, T>(-1, item);
			}
			else
			{
				num = _storage.Count;
				_storage.Add(new KeyValuePair<int, T>(-1, item));
			}
			if (_headIndex == -1)
			{
				_headIndex = num;
			}
			else
			{
				_storage[_tailIndex] = new KeyValuePair<int, T>(num, _storage[_tailIndex].Value);
			}
			_tailIndex = num;
			return num;
		}

		internal bool TryDequeue(out T item)
		{
			if (_headIndex == -1)
			{
				item = default(T);
				return false;
			}
			item = _storage[_headIndex].Value;
			int key = _storage[_headIndex].Key;
			_storage[_headIndex] = new KeyValuePair<int, T>(_freeIndex, default(T));
			_freeIndex = _headIndex;
			_headIndex = key;
			if (_headIndex == -1)
			{
				_tailIndex = -1;
			}
			return true;
		}

		internal void Replace(int index, T item)
		{
			_storage[index] = new KeyValuePair<int, T>(_storage[index].Key, item);
		}
	}

	private readonly ArrayBasedLinkedQueue<KeyValuePair<TKey, TValue>> _queue;

	private readonly Dictionary<TKey, int> _mapKeyToIndex;

	internal int Count => _mapKeyToIndex.Count;

	internal QueuedMap()
	{
		_queue = new ArrayBasedLinkedQueue<KeyValuePair<TKey, TValue>>();
		_mapKeyToIndex = new Dictionary<TKey, int>();
	}

	internal QueuedMap(int capacity)
	{
		_queue = new ArrayBasedLinkedQueue<KeyValuePair<TKey, TValue>>(capacity);
		_mapKeyToIndex = new Dictionary<TKey, int>(capacity);
	}

	internal void Push(TKey key, TValue value)
	{
		if (!_queue.IsEmpty && _mapKeyToIndex.TryGetValue(key, out var value2))
		{
			_queue.Replace(value2, new KeyValuePair<TKey, TValue>(key, value));
			return;
		}
		value2 = _queue.Enqueue(new KeyValuePair<TKey, TValue>(key, value));
		_mapKeyToIndex.Add(key, value2);
	}

	internal bool TryPop(out KeyValuePair<TKey, TValue> item)
	{
		bool result;
		if (result = _queue.TryDequeue(out item))
		{
			_mapKeyToIndex.Remove(item.Key);
		}
		return result;
	}

	internal int PopRange(KeyValuePair<TKey, TValue>[] items, int arrayOffset, int count)
	{
		int i = 0;
		int num = arrayOffset;
		for (; i < count; i++)
		{
			if (!TryPop(out var item))
			{
				break;
			}
			items[num] = item;
			num++;
		}
		return i;
	}
}
