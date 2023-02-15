using System.Threading;

namespace System.Buffers;

public abstract class ArrayPool<T>
{
	private static ArrayPool<T> s_sharedInstance;

	public static ArrayPool<T> Shared => Volatile.Read(ref s_sharedInstance) ?? EnsureSharedCreated();

	private static ArrayPool<T> EnsureSharedCreated()
	{
		Interlocked.CompareExchange(ref s_sharedInstance, Create(), null);
		return s_sharedInstance;
	}

	public static ArrayPool<T> Create()
	{
		return new DefaultArrayPool<T>();
	}

	public static ArrayPool<T> Create(int maxArrayLength, int maxArraysPerBucket)
	{
		return new DefaultArrayPool<T>(maxArrayLength, maxArraysPerBucket);
	}

	public abstract T[] Rent(int minimumLength);

	public abstract void Return(T[] array, bool clearArray = false);
}
