using System;

namespace DnsClient.Protocol;

public class CaaRecord : DnsResourceRecord
{
	public byte Flags { get; }

	public string Tag { get; }

	public string Value { get; }

	public CaaRecord(ResourceRecordInfo info, byte flags, string tag, string value)
		: base(info)
	{
		Flags = flags;
		Tag = tag ?? throw new ArgumentNullException("tag");
		Value = value ?? throw new ArgumentNullException("value");
	}

	private protected override string RecordToString()
	{
		return $"{Flags} {Tag} \"{Value}\"";
	}
}
