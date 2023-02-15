using System;
using System.Collections.Generic;
using System.Linq;
using DnsClient.Protocol;

namespace DnsClient;

public class DnsQueryResponse : IDnsQueryResponse
{
	private int? _hashCode;

	public NameServer NameServer { get; }

	public IReadOnlyList<DnsResourceRecord> Additionals { get; }

	public IEnumerable<DnsResourceRecord> AllRecords => Enumerable.Concat(Enumerable.Concat(Answers, Additionals), Authorities);

	public string AuditTrail => Audit.Build(this);

	public IReadOnlyList<DnsResourceRecord> Answers { get; }

	public IReadOnlyList<DnsResourceRecord> Authorities { get; }

	public string ErrorMessage => DnsResponseCodeText.GetErrorText(Header.ResponseCode);

	public bool HasError
	{
		get
		{
			DnsResponseHeader header = Header;
			if (header == null)
			{
				return true;
			}
			return header.ResponseCode != DnsResponseCode.NoError;
		}
	}

	public DnsResponseHeader Header { get; }

	public IReadOnlyList<DnsQuestion> Questions { get; }

	public int MessageSize { get; }

	internal LookupClientAudit Audit { get; }

	internal DnsQueryResponse(DnsResponseMessage dnsResponseMessage, NameServer nameServer, LookupClientAudit audit)
	{
		if (dnsResponseMessage == null)
		{
			throw new ArgumentNullException("dnsResponseMessage");
		}
		Header = dnsResponseMessage.Header;
		MessageSize = dnsResponseMessage.MessageSize;
		Questions = dnsResponseMessage.Questions.ToArray();
		Answers = dnsResponseMessage.Answers.ToArray();
		Additionals = dnsResponseMessage.Additionals.ToArray();
		Authorities = dnsResponseMessage.Authorities.ToArray();
		NameServer = nameServer ?? throw new ArgumentNullException("nameServer");
		Audit = audit ?? throw new ArgumentNullException("audit");
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is DnsQueryResponse dnsQueryResponse))
		{
			return false;
		}
		if (Header.ToString().Equals(dnsQueryResponse.Header.ToString()) && string.Join("", Questions).Equals(string.Join("", dnsQueryResponse.Questions)))
		{
			return string.Join("", AllRecords).Equals(string.Join("", dnsQueryResponse.AllRecords));
		}
		return false;
	}

	public override int GetHashCode()
	{
		if (!_hashCode.HasValue)
		{
			_hashCode = (Header.ToString() + string.Join("", Questions) + string.Join("", AllRecords)).GetHashCode();
		}
		return _hashCode.Value;
	}
}
