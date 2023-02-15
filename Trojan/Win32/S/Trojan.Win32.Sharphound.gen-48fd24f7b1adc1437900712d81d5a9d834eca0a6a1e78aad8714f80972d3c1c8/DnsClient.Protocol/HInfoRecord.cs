namespace DnsClient.Protocol;

public class HInfoRecord : DnsResourceRecord
{
	public string Cpu { get; }

	public string OS { get; }

	public HInfoRecord(ResourceRecordInfo info, string cpu, string os)
		: base(info)
	{
		Cpu = cpu;
		OS = os;
	}

	private protected override string RecordToString()
	{
		return $"\"{Cpu}\" \"{OS}\"";
	}
}
