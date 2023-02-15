namespace DnsClient.Protocol.Options;

internal class OptRecord : DnsResourceRecord
{
	private const uint ResponseCodeMask = 4278190080u;

	private const int ResponseCodeShift = 20;

	private const uint VersionMask = 16711680u;

	private const int VersionShift = 16;

	public DnsResponseCode ResponseCodeEx
	{
		get
		{
			return (DnsResponseCode)((base.InitialTimeToLive & 0xFF000000L) >> 20);
		}
		set
		{
			base.InitialTimeToLive &= 16777215;
			base.InitialTimeToLive |= (int)(((int)value << 20) & 0xFF000000L);
		}
	}

	public short UdpSize => (short)base.RecordClass;

	public byte Version
	{
		get
		{
			return (byte)((base.InitialTimeToLive & 0xFF0000L) >> 16);
		}
		set
		{
			base.InitialTimeToLive &= -16711681;
			base.InitialTimeToLive |= (int)((value << 16) & 0xFF0000L);
		}
	}

	public bool IsDnsSecOk
	{
		get
		{
			return (base.InitialTimeToLive & 0x8000) != 0;
		}
		set
		{
			if (value)
			{
				base.InitialTimeToLive |= 32768;
			}
			else
			{
				base.InitialTimeToLive &= 32767;
			}
		}
	}

	public OptRecord(int size = 4096, int version = 0, int length = 0)
		: base(new ResourceRecordInfo(DnsString.RootLabel, ResourceRecordType.OPT, (QueryClass)size, version, length))
	{
	}

	private protected override string RecordToString()
	{
		return $"OPT {base.RecordClass}.";
	}
}
