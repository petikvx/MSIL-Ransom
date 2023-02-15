using System.Collections.Generic;
using DnsClient.Protocol;

namespace DnsClient;

public interface IDnsQueryResponse
{
	IReadOnlyList<DnsQuestion> Questions { get; }

	IReadOnlyList<DnsResourceRecord> Additionals { get; }

	IEnumerable<DnsResourceRecord> AllRecords { get; }

	IReadOnlyList<DnsResourceRecord> Answers { get; }

	IReadOnlyList<DnsResourceRecord> Authorities { get; }

	string AuditTrail { get; }

	string ErrorMessage { get; }

	bool HasError { get; }

	DnsResponseHeader Header { get; }

	int MessageSize { get; }

	NameServer NameServer { get; }
}
