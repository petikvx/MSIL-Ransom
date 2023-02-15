using System;

namespace DnsClient.Protocol;

public class AfsDbRecord : DnsResourceRecord
{
	public AfsType SubType { get; }

	public DnsString Hostname { get; }

	public AfsDbRecord(ResourceRecordInfo info, AfsType type, DnsString name)
		: base(info)
	{
		SubType = type;
		Hostname = name ?? throw new ArgumentNullException("name");
	}

	private protected override string RecordToString()
	{
		return $"{(int)SubType} {Hostname}";
	}
}
