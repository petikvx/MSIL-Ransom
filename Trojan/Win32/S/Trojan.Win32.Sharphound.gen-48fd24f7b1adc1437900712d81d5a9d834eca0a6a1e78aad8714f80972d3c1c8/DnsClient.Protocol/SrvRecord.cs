using System;

namespace DnsClient.Protocol;

[CLSCompliant(false)]
public class SrvRecord : DnsResourceRecord
{
	public ushort Port { get; }

	public ushort Priority { get; }

	public DnsString Target { get; }

	public ushort Weight { get; }

	public SrvRecord(ResourceRecordInfo info, ushort priority, ushort weigth, ushort port, DnsString target)
		: base(info)
	{
		Priority = priority;
		Weight = weigth;
		Port = port;
		Target = target ?? throw new ArgumentNullException("target");
	}

	private protected override string RecordToString()
	{
		return $"{Priority} {Weight} {Port} {Target}";
	}
}
