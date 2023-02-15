using System;
using System.Buffers;

namespace DnsClient.Internal;

public class PooledBytes : IDisposable
{
	private static readonly ArrayPool<byte> _pool = ArrayPool<byte>.Create(16384, 100);

	private int _length;

	private ArraySegment<byte> _buffer;

	private bool _disposed;

	public byte[] Buffer
	{
		get
		{
			if (_disposed)
			{
				throw new ObjectDisposedException("PooledBytes");
			}
			return _buffer.Array;
		}
	}

	public ArraySegment<byte> BufferSegment
	{
		get
		{
			if (_disposed)
			{
				throw new ObjectDisposedException("PooledBytes");
			}
			return _buffer;
		}
	}

	public PooledBytes(int length)
	{
		if (length <= 0)
		{
			throw new ArgumentOutOfRangeException("length");
		}
		_length = length;
		_buffer = new ArraySegment<byte>(_pool.Rent(length), 0, _length);
	}

	public void Extend(int length)
	{
		byte[] array = _pool.Rent(_length + length);
		System.Buffer.BlockCopy(_buffer.Array, 0, array, 0, _length);
		_pool.Return(_buffer.Array);
		_length += length;
		_buffer = new ArraySegment<byte>(array, 0, _length);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			_disposed = true;
			_pool.Return(_buffer.Array);
		}
	}
}
