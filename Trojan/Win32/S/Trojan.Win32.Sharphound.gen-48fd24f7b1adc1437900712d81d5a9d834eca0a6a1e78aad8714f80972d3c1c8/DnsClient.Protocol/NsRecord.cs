using System;

namespace DnsClient.Protocol;

public class NsRecord : DnsResourceRecord
{
	public DnsString NSDName { get; }

	public NsRecord(ResourceRecordInfo info, DnsString name)
		: base(info)
	{
		NSDName = name ?? throw new ArgumentNullException("name");
	}

	private protected override string RecordToString()
	{
		return NSDName.Value;
	}
}
