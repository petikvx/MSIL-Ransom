using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace DnsClient;

internal class DnsDatagramReader
{
	public const int IPv6Length = 16;

	public const int IPv4Length = 4;

	private const byte ReferenceByte = 192;

	private const string ACEPrefix = "xn--";

	private readonly ArraySegment<byte> _data;

	private int _index;

	public int Index
	{
		get
		{
			return _index;
		}
		set
		{
			if (value >= 0)
			{
				ArraySegment<byte> data = _data;
				if (value <= data.Count)
				{
					_index = value;
					return;
				}
			}
			throw new ArgumentOutOfRangeException("value");
		}
	}

	public DnsDatagramReader(ArraySegment<byte> data, int startIndex = 0)
	{
		_data = data;
		Index = startIndex;
	}

	public string ReadString()
	{
		byte b = ReadByte();
		Encoding aSCII = Encoding.ASCII;
		ArraySegment<byte> data = _data;
		byte[]? array = data.Array;
		data = _data;
		string @string = aSCII.GetString(array, data.Offset + _index, b);
		_index += b;
		return @string;
	}

	public string ReadString(int length)
	{
		Encoding aSCII = Encoding.ASCII;
		ArraySegment<byte> data = _data;
		byte[]? array = data.Array;
		data = _data;
		string @string = aSCII.GetString(array, data.Offset + _index, length);
		_index += length;
		return @string;
	}

	public static string ParseString(ArraySegment<byte> data)
	{
		return ParseString(new DnsDatagramReader(data), data.Count);
	}

	public static string ParseString(DnsDatagramReader reader, int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < length; i++)
		{
			byte b = reader.ReadByte();
			char c = (char)b;
			if (b >= 32 && b <= 126)
			{
				switch (c)
				{
				case ';':
					stringBuilder.Append("\\;");
					break;
				case '\\':
					stringBuilder.Append("\\\\");
					break;
				case '"':
					stringBuilder.Append("\\\"");
					break;
				default:
					stringBuilder.Append(c);
					break;
				}
			}
			else
			{
				stringBuilder.Append("\\" + b.ToString("000"));
			}
		}
		return stringBuilder.ToString();
	}

	public static string ReadUTF8String(ArraySegment<byte> data)
	{
		return Encoding.UTF8.GetString(data.Array, data.Offset, data.Count);
	}

	public byte ReadByte()
	{
		ArraySegment<byte> data = _data;
		if (data.Count < _index + 1)
		{
			throw new IndexOutOfRangeException($"Cannot read byte {_index + 1}, out of range.");
		}
		data = _data;
		byte[]? array = data.Array;
		data = _data;
		return array[data.Offset + _index++];
	}

	public ArraySegment<byte> ReadBytes(int length)
	{
		ArraySegment<byte> data = _data;
		if (data.Count < _index + length)
		{
			throw new IndexOutOfRangeException($"Cannot read that many bytes: '{length}'.");
		}
		data = _data;
		byte[]? array = data.Array;
		data = _data;
		ArraySegment<byte> result = new ArraySegment<byte>(array, data.Offset + _index, length);
		_index += length;
		return result;
	}

	private byte[] ReadByteArray(int length)
	{
		byte[] array = new byte[length];
		ArraySegment<byte> data = _data;
		byte[]? array2 = data.Array;
		data = _data;
		Buffer.BlockCopy(array2, data.Offset + Index, array, 0, length);
		_index += length;
		return array;
	}

	public IPAddress ReadIPAddress()
	{
		ArraySegment<byte> data = _data;
		if (data.Count < _index + 4)
		{
			throw new IndexOutOfRangeException($"Reading IPv4 address, expected {4} bytes.");
		}
		return new IPAddress(ReadByteArray(4));
	}

	public IPAddress ReadIPv6Address()
	{
		ArraySegment<byte> data = _data;
		if (data.Count < _index + 16)
		{
			throw new IndexOutOfRangeException($"Reading IPv6 address, expected {16} bytes.");
		}
		return new IPAddress(ReadByteArray(16));
	}

	public DnsString ReadDnsName()
	{
		StringBuilder stringBuilder = new StringBuilder();
		StringBuilder stringBuilder2 = new StringBuilder();
		foreach (ArraySegment<byte> item in ReadLabels())
		{
			foreach (byte item2 in (IEnumerable<byte>)item)
			{
				char c = (char)item2;
				if (item2 >= 32 && item2 <= 126)
				{
					switch (c)
					{
					case ';':
						stringBuilder.Append("\\;");
						break;
					case '\\':
						stringBuilder.Append("\\\\");
						break;
					case '"':
						stringBuilder.Append("\\\"");
						break;
					default:
						stringBuilder.Append(c);
						break;
					}
				}
				else
				{
					stringBuilder.Append("\\" + item2.ToString("000"));
				}
			}
			stringBuilder.Append(".");
			string text = Encoding.UTF8.GetString(item.Array, item.Offset, item.Count);
			if (text.Contains("xn--"))
			{
				try
				{
					text = DnsString.IDN.GetUnicode(text);
				}
				catch
				{
				}
			}
			stringBuilder2.Append(text);
			stringBuilder2.Append(".");
		}
		string text2 = stringBuilder.ToString();
		if (text2.Length == 0 || text2[text2.Length - 1] != '.')
		{
			text2 += ".";
		}
		string text3 = stringBuilder2.ToString();
		if (text3.Length == 0 || text3[text3.Length - 1] != '.')
		{
			text3 += ".";
		}
		return new DnsString(text3, text2);
	}

	public DnsString ReadQuestionQueryString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (ArraySegment<byte> item in ReadLabels())
		{
			string @string = Encoding.UTF8.GetString(item.Array, item.Offset, item.Count);
			stringBuilder.Append(@string);
			stringBuilder.Append(".");
		}
		return DnsString.FromResponseQueryString(stringBuilder.ToString());
	}

	public ICollection<ArraySegment<byte>> ReadLabels()
	{
		List<ArraySegment<byte>> list = new List<ArraySegment<byte>>();
		int num;
		while (true)
		{
			byte b;
			if ((b = ReadByte()) != 0)
			{
				if ((b & 0xC0u) != 0)
				{
					num = ((b & 0x3F) << 8) | ReadByte();
					ArraySegment<byte> data = _data;
					if (num < data.Array!.Length - 1)
					{
						break;
					}
					Index--;
					list.Add(_data.SubArray(Index, b));
					Index += b;
				}
				else
				{
					int num2 = Index + b;
					ArraySegment<byte> data = _data;
					if (num2 >= data.Count)
					{
						throw new IndexOutOfRangeException($"Found invalid label position '{Index - 1}' with length '{b}' in the source data.");
					}
					ArraySegment<byte> item = _data.SubArray(Index, b);
					list.Add(item);
					Index += b;
				}
				continue;
			}
			return list;
		}
		ICollection<ArraySegment<byte>> collection = new DnsDatagramReader(_data.SubArrayFromOriginal(num)).ReadLabels();
		list.AddRange(collection);
		return list;
	}

	public ushort ReadUInt16()
	{
		ArraySegment<byte> data = _data;
		if (data.Count < Index + 2)
		{
			throw new IndexOutOfRangeException("Cannot read more data.");
		}
		data = _data;
		byte[]? array = data.Array;
		data = _data;
		ushort result = BitConverter.ToUInt16(array, data.Offset + _index);
		_index += 2;
		return result;
	}

	public ushort ReadUInt16NetworkOrder()
	{
		ArraySegment<byte> data = _data;
		if (data.Count < Index + 2)
		{
			throw new IndexOutOfRangeException("Cannot read more data.");
		}
		data = _data;
		byte[]? array = data.Array;
		data = _data;
		byte num = array[data.Offset + _index++];
		data = _data;
		byte[]? array2 = data.Array;
		data = _data;
		byte b = array2[data.Offset + _index++];
		return (ushort)((num << 8) | b);
	}

	public uint ReadUInt32NetworkOrder()
	{
		return (uint)((ReadUInt16NetworkOrder() << 16) | ReadUInt16NetworkOrder());
	}
}
