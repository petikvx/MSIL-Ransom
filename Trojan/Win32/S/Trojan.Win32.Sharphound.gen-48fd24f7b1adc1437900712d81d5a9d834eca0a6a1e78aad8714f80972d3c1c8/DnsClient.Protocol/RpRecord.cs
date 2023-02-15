using System;

namespace DnsClient.Protocol;

public class RpRecord : DnsResourceRecord
{
	public DnsString MailboxDomainName { get; }

	public DnsString TextDomainName { get; }

	public RpRecord(ResourceRecordInfo info, DnsString mailbox, DnsString textName)
		: base(info)
	{
		MailboxDomainName = mailbox ?? throw new ArgumentNullException("mailbox");
		TextDomainName = textName ?? throw new ArgumentNullException("textName");
	}

	private protected override string RecordToString()
	{
		return $"{MailboxDomainName} {TextDomainName}";
	}
}
