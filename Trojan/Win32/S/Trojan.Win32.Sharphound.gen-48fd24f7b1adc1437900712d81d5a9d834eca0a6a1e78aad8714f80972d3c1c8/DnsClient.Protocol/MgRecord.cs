using System;

namespace DnsClient.Protocol;

public class MgRecord : DnsResourceRecord
{
	public DnsString MgName { get; }

	public MgRecord(ResourceRecordInfo info, DnsString domainName)
		: base(info)
	{
		MgName = domainName ?? throw new ArgumentNullException("domainName");
	}

	private protected override string RecordToString()
	{
		return MgName.Value;
	}
}
