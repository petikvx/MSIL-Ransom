using System;

namespace DnsClient.Protocol;

public class MInfoRecord : DnsResourceRecord
{
	public DnsString RMailBox { get; }

	public DnsString EmailBox { get; }

	public MInfoRecord(ResourceRecordInfo info, DnsString rmailBox, DnsString emailBox)
		: base(info)
	{
		RMailBox = rmailBox ?? throw new ArgumentNullException("rmailBox");
		EmailBox = emailBox ?? throw new ArgumentNullException("emailBox");
	}

	private protected override string RecordToString()
	{
		return $"{RMailBox} {EmailBox}";
	}
}
