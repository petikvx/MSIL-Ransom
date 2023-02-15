using System;

namespace DnsClient;

internal class DnsRequestMessage
{
	public DnsRequestHeader Header { get; }

	public DnsQuestion Question { get; }

	public DnsRequestMessage(DnsRequestHeader header, DnsQuestion question)
	{
		Header = header ?? throw new ArgumentNullException("header");
		Question = question ?? throw new ArgumentNullException("question");
	}
}
