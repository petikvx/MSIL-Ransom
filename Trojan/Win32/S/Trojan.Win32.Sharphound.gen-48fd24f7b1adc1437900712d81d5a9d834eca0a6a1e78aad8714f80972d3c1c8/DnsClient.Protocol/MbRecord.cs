using System;

namespace DnsClient.Protocol;

public class MbRecord : DnsResourceRecord
{
	public DnsString MadName { get; }

	public MbRecord(ResourceRecordInfo info, DnsString domainName)
		: base(info)
	{
		MadName = domainName ?? throw new ArgumentNullException("domainName");
	}

	private protected override string RecordToString()
	{
		return MadName.Value;
	}
}
