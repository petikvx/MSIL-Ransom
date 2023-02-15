using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;

namespace System.Threading.Tasks;

[DebuggerDisplay("Count = {Count}")]
internal sealed class MultiProducerMultiConsumerQueue<T> : ConcurrentQueue<T>, IEnumerable<T>, IProducerConsumerQueue<T>, IEnumerable
{
	bool IProducerConsumerQueue<T>.IsEmpty => base.IsEmpty;

	int IProducerConsumerQueue<T>.Count => base.Count;

	void IProducerConsumerQueue<T>.Enqueue(T item)
	{
		Enqueue(item);
	}

	bool IProducerConsumerQueue<T>.TryDequeue(out T result)
	{
		return TryDequeue(out result);
	}

	int IProducerConsumerQueue<T>.GetCountSafe(object syncObj)
	{
		return base.Count;
	}
}
