using System;

namespace DnsClient.Protocol;

public class CNameRecord : DnsResourceRecord
{
	public DnsString CanonicalName { get; }

	public CNameRecord(ResourceRecordInfo info, DnsString canonicalName)
		: base(info)
	{
		CanonicalName = canonicalName ?? throw new ArgumentNullException("canonicalName");
	}

	private protected override string RecordToString()
	{
		return CanonicalName.Value;
	}
}
