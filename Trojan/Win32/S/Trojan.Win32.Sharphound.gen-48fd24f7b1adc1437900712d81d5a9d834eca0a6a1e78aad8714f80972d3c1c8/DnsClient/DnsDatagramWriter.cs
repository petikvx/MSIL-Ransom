using System;
using System.Net;
using System.Text;
using DnsClient.Internal;

namespace DnsClient;

internal class DnsDatagramWriter : IDisposable
{
	public const int BufferSize = 1024;

	private const byte DotByte = 46;

	private readonly PooledBytes _pooledBytes;

	private ArraySegment<byte> _buffer;

	public ArraySegment<byte> Data => new ArraySegment<byte>(_buffer.Array, 0, Index);

	public int Index { get; set; }

	public DnsDatagramWriter()
	{
		_pooledBytes = new PooledBytes(1024);
		_buffer = new ArraySegment<byte>(_pooledBytes.Buffer, 0, 1024);
	}

	public DnsDatagramWriter(ArraySegment<byte> useBuffer)
	{
		_buffer = useBuffer;
	}

	public void WriteHostName(string queryName)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(queryName);
		int num = 0;
		int num2 = 0;
		if (bytes.Length <= 1)
		{
			WriteByte(0);
			return;
		}
		byte[] array = bytes;
		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == 46)
			{
				WriteByte((byte)(num2 - num));
				WriteBytes(bytes, num, num2 - num);
				num = num2 + 1;
			}
			num2++;
		}
		WriteByte(0);
	}

	public void WriteByte(byte b)
	{
		_buffer.Array[_buffer.Offset + Index++] = b;
	}

	public void WriteBytes(byte[] data, int length)
	{
		WriteBytes(data, 0, length);
	}

	public void WriteBytes(byte[] data, int dataOffset, int length)
	{
		Buffer.BlockCopy(data, dataOffset, _buffer.Array, _buffer.Offset + Index, length);
		Index += length;
	}

	public void WriteInt16NetworkOrder(short value)
	{
		byte[] bytes = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(value));
		WriteBytes(bytes, bytes.Length);
	}

	public void WriteInt32NetworkOrder(int value)
	{
		byte[] bytes = BitConverter.GetBytes(IPAddress.HostToNetworkOrder(value));
		WriteBytes(bytes, bytes.Length);
	}

	public void WriteUInt16NetworkOrder(ushort value)
	{
		WriteInt16NetworkOrder((short)value);
	}

	public void WriteUInt32NetworkOrder(uint value)
	{
		WriteInt32NetworkOrder((int)value);
	}

	protected virtual void Dispose(bool disposing)
	{
		if (disposing)
		{
			_pooledBytes?.Dispose();
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}
}
