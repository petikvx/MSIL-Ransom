using System;

namespace DnsClient.Protocol;

public class MrRecord : DnsResourceRecord
{
	public DnsString NewName { get; }

	public MrRecord(ResourceRecordInfo info, DnsString name)
		: base(info)
	{
		NewName = name ?? throw new ArgumentNullException("name");
	}

	private protected override string RecordToString()
	{
		return NewName.Value;
	}
}
