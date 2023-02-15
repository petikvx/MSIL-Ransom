using DnsClient.Protocol;

namespace DnsClient;

internal class DnsRequestHeader
{
	public const int HeaderLength = 12;

	private ushort _flags;

	public ushort RawFlags => _flags;

	internal DnsHeaderFlag HeaderFlags
	{
		get
		{
			return (DnsHeaderFlag)_flags;
		}
		set
		{
			_flags &= 65519;
			_flags &= 65503;
			_flags &= 65471;
			_flags &= 32767;
			_flags &= 64511;
			_flags &= 65023;
			_flags &= 65279;
			_flags &= 65407;
			_flags |= (ushort)value;
		}
	}

	public int Id { get; set; }

	public DnsOpCode OpCode
	{
		get
		{
			return (DnsOpCode)((DnsHeader.OPCodeMask & _flags) >> (int)DnsHeader.OPCodeShift);
		}
		set
		{
			_flags &= (ushort)(~DnsHeader.OPCodeMask);
			_flags |= (ushort)(((ushort)value << (int)DnsHeader.OPCodeShift) & DnsHeader.OPCodeMask);
		}
	}

	public ushort RCode
	{
		get
		{
			return (ushort)(DnsHeader.RCodeMask & _flags);
		}
		set
		{
			_flags &= (ushort)(~DnsHeader.RCodeMask);
			_flags |= (ushort)(value & DnsHeader.RCodeMask);
		}
	}

	public bool UseRecursion
	{
		get
		{
			return HeaderFlags.HasFlag(DnsHeaderFlag.RecursionDesired);
		}
		set
		{
			if (value)
			{
				_flags |= 256;
			}
			else
			{
				_flags &= 65279;
			}
		}
	}

	public DnsRequestHeader(int id, DnsOpCode queryKind)
		: this(id, useRecursion: true, queryKind)
	{
	}

	public DnsRequestHeader(int id, bool useRecursion, DnsOpCode queryKind)
	{
		Id = id;
		OpCode = queryKind;
		UseRecursion = useRecursion;
	}

	public override string ToString()
	{
		return $"{Id} - Qs: {1} Recursion: {UseRecursion} OpCode: {OpCode}";
	}
}
