using System;
using System.Net;

namespace DnsClient.Protocol;

public class AddressRecord : DnsResourceRecord
{
	public IPAddress Address { get; }

	public AddressRecord(ResourceRecordInfo info, IPAddress address)
		: base(info)
	{
		Address = address ?? throw new ArgumentNullException("address");
	}

	private protected override string RecordToString()
	{
		return Address.ToString();
	}
}
