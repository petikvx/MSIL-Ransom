using System.Net;

namespace DnsClient.Protocol;

public class AaaaRecord : AddressRecord
{
	public AaaaRecord(ResourceRecordInfo info, IPAddress address)
		: base(info, address)
	{
	}
}
