using System;
using System.Collections.Generic;

namespace DnsClient;

public interface ILookupClient : IDnsQuery
{
	bool EnableAuditTrail { get; set; }

	bool UseCache { get; set; }

	TimeSpan? MinimumCacheTimeout { get; set; }

	IReadOnlyCollection<NameServer> NameServers { get; }

	bool Recursion { get; set; }

	int Retries { get; set; }

	bool ThrowDnsErrors { get; set; }

	bool UseRandomNameServer { get; set; }

	bool ContinueOnDnsError { get; set; }

	TimeSpan Timeout { get; set; }

	bool UseTcpFallback { get; set; }

	bool UseTcpOnly { get; set; }
}
