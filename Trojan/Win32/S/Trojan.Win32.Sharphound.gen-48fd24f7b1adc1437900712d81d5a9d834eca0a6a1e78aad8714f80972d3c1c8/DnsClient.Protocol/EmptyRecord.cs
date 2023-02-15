namespace DnsClient.Protocol;

public class EmptyRecord : DnsResourceRecord
{
	public EmptyRecord(ResourceRecordInfo info)
		: base(info)
	{
	}

	private protected override string RecordToString()
	{
		return string.Empty;
	}
}
