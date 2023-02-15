using System;

namespace DnsClient.Protocol;

public class UriRecord : DnsResourceRecord
{
	public string Target { get; set; }

	public int Priority { get; set; }

	public int Weigth { get; set; }

	[CLSCompliant(false)]
	public UriRecord(ResourceRecordInfo info, ushort priority, ushort weight, string target)
		: base(info)
	{
		Target = target ?? throw new ArgumentNullException("target");
		Priority = priority;
		Weigth = weight;
	}

	private protected override string RecordToString()
	{
		return $"{Priority} {Weigth} \"{Target}\"";
	}
}
