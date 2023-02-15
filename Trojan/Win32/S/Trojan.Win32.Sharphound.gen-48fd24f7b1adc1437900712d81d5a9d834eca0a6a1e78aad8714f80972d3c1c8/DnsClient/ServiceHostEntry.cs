using System.Net;

namespace DnsClient;

public class ServiceHostEntry : IPHostEntry
{
	public int Port { get; set; }
}
