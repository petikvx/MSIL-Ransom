using System;

namespace DnsClient.Protocol;

[CLSCompliant(false)]
public class MxRecord : DnsResourceRecord
{
	public ushort Preference { get; }

	public DnsString Exchange { get; }

	public MxRecord(ResourceRecordInfo info, ushort preference, DnsString domainName)
		: base(info)
	{
		Preference = preference;
		Exchange = domainName ?? throw new ArgumentNullException("domainName");
	}

	private protected override string RecordToString()
	{
		return $"{Preference} {Exchange}";
	}
}
