using System.Net;

namespace DnsClient.Protocol;

public class ARecord : AddressRecord
{
	public ARecord(ResourceRecordInfo info, IPAddress address)
		: base(info, address)
	{
	}
}
