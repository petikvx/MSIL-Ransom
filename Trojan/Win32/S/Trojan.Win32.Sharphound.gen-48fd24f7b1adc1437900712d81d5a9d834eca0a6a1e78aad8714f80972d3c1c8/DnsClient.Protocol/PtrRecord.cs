using System;

namespace DnsClient.Protocol;

public class PtrRecord : DnsResourceRecord
{
	public DnsString PtrDomainName { get; }

	public PtrRecord(ResourceRecordInfo info, DnsString ptrDomainName)
		: base(info)
	{
		PtrDomainName = ptrDomainName ?? throw new ArgumentNullException("ptrDomainName");
	}

	private protected override string RecordToString()
	{
		return PtrDomainName.Value;
	}
}
