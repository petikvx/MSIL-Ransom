using System;

namespace DnsClient.Protocol;

[CLSCompliant(false)]
public class SoaRecord : DnsResourceRecord
{
	public uint Expire { get; }

	public uint Minimum { get; }

	public DnsString MName { get; }

	public uint Refresh { get; }

	public uint Retry { get; }

	public DnsString RName { get; }

	public uint Serial { get; }

	public SoaRecord(ResourceRecordInfo info, DnsString mName, DnsString rName, uint serial, uint refresh, uint retry, uint expire, uint minimum)
		: base(info)
	{
		MName = mName ?? throw new ArgumentNullException("mName");
		RName = rName ?? throw new ArgumentNullException("rName");
		Serial = serial;
		Refresh = refresh;
		Retry = retry;
		Expire = expire;
		Minimum = minimum;
	}

	private protected override string RecordToString()
	{
		return $"{MName} {RName} {Serial} {Refresh} {Retry} {Expire} {Minimum}";
	}
}
