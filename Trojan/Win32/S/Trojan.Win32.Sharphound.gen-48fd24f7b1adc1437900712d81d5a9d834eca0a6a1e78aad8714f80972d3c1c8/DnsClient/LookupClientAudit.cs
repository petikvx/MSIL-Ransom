using System;
using System.Diagnostics;
using System.Globalization;
using System.Text;
using DnsClient.Protocol;

namespace DnsClient;

internal class LookupClientAudit
{
	private const string c_placeHolder = "$$REPLACEME$$";

	private static readonly int s_printOffset = -32;

	private StringBuilder _auditWriter = new StringBuilder();

	private Stopwatch _swatch;

	public void StartTimer()
	{
		_swatch = Stopwatch.StartNew();
		_swatch.Restart();
	}

	public void AuditResolveServers(int count)
	{
		_auditWriter.AppendLine($"; ({count} server found)");
	}

	public string Build(IDnsQueryResponse queryResponse)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (queryResponse != null)
		{
			if (queryResponse.Questions.Count > 0)
			{
				stringBuilder.AppendLine(";; QUESTION SECTION:");
				foreach (DnsQuestion question in queryResponse.Questions)
				{
					stringBuilder.AppendLine(question.ToString(s_printOffset));
				}
				stringBuilder.AppendLine();
			}
			if (queryResponse.Answers.Count > 0)
			{
				stringBuilder.AppendLine(";; ANSWER SECTION:");
				foreach (DnsResourceRecord answer in queryResponse.Answers)
				{
					stringBuilder.AppendLine(answer.ToString(s_printOffset));
				}
				stringBuilder.AppendLine();
			}
			if (queryResponse.Authorities.Count > 0)
			{
				stringBuilder.AppendLine(";; AUTHORITIES SECTION:");
				foreach (DnsResourceRecord authority in queryResponse.Authorities)
				{
					stringBuilder.AppendLine(authority.ToString(s_printOffset));
				}
				stringBuilder.AppendLine();
			}
			if (queryResponse.Additionals.Count > 0)
			{
				stringBuilder.AppendLine(";; ADDITIONALS SECTION:");
				foreach (DnsResourceRecord additional in queryResponse.Additionals)
				{
					stringBuilder.AppendLine(additional.ToString(s_printOffset));
				}
				stringBuilder.AppendLine();
			}
		}
		string text = _auditWriter.ToString();
		string newValue = stringBuilder.ToString();
		return text.Replace("$$REPLACEME$$", newValue);
	}

	public void AuditTruncatedRetryTcp()
	{
		_auditWriter.AppendLine(";; Truncated, retrying in TCP mode.");
		_auditWriter.AppendLine();
	}

	public void AuditResponseError(DnsResponseCode responseCode)
	{
		_auditWriter.AppendLine($";; ERROR: {DnsResponseCodeText.GetErrorText(responseCode)}");
	}

	public void AuditOptPseudo()
	{
		_auditWriter.AppendLine(";; OPT PSEUDOSECTION:");
	}

	public void AuditResponseHeader(DnsResponseHeader header)
	{
		_auditWriter.AppendLine(";; Got answer:");
		_auditWriter.AppendLine(header.ToString());
		if (header.RecursionDesired && !header.RecursionAvailable)
		{
			_auditWriter.AppendLine(";; WARNING: recursion requested but not available");
		}
		_auditWriter.AppendLine();
	}

	public void AuditEdnsOpt(short udpSize, byte version, DnsResponseCode responseCodeEx)
	{
		_auditWriter.AppendLine($"; EDNS: version: {version}, flags:; udp: {udpSize}");
	}

	public void AuditResponse()
	{
		_auditWriter.AppendLine("$$REPLACEME$$");
	}

	public void AuditEnd(DnsQueryResponse queryResponse)
	{
		long elapsedMilliseconds = _swatch.ElapsedMilliseconds;
		_auditWriter.AppendLine($";; Query time: {elapsedMilliseconds} msec");
		_auditWriter.AppendLine($";; SERVER: {queryResponse.NameServer.Endpoint.Address}#{queryResponse.NameServer.Endpoint.Port}");
		_auditWriter.AppendLine(string.Format(";; WHEN: {0}", DateTime.UtcNow.ToString("ddd MMM dd HH:mm:ss K yyyy", CultureInfo.InvariantCulture)));
		_auditWriter.AppendLine($";; MSG SIZE  rcvd: {queryResponse.MessageSize}");
	}

	public void AuditException(Exception ex)
	{
		AggregateException ex2 = ex as AggregateException;
		StringBuilder auditWriter;
		string errorText;
		object obj;
		if (ex is DnsResponseException ex3)
		{
			auditWriter = _auditWriter;
			errorText = DnsResponseCodeText.GetErrorText(ex3.Code);
			Exception? innerException = ex3.InnerException;
			if (innerException == null)
			{
				obj = null;
			}
			else
			{
				obj = innerException!.Message;
				if (obj != null)
				{
					goto IL_0043;
				}
			}
			obj = ex3.Message;
			goto IL_0043;
		}
		StringBuilder auditWriter2;
		object obj2;
		if (ex2 != null)
		{
			auditWriter2 = _auditWriter;
			Exception? innerException2 = ex2.InnerException;
			if (innerException2 == null)
			{
				obj2 = null;
			}
			else
			{
				obj2 = innerException2!.Message;
				if (obj2 != null)
				{
					goto IL_007a;
				}
			}
			obj2 = ex2.Message;
			goto IL_007a;
		}
		_auditWriter.AppendLine($";; Error: {ex.Message}");
		goto IL_00a3;
		IL_0043:
		auditWriter.AppendLine($";; Error: {errorText} {obj}");
		goto IL_00a3;
		IL_007a:
		auditWriter2.AppendLine($";; Error: {obj2}");
		goto IL_00a3;
		IL_00a3:
		if (Debugger.IsAttached)
		{
			_auditWriter.AppendLine(ex.ToString());
		}
	}

	public void AuditRetryNextServer(NameServer current)
	{
		_auditWriter.AppendLine();
		_auditWriter.AppendLine($"; SERVER: {current.Endpoint.Address}#{current.Endpoint.Port} failed; Retrying with the next server.");
	}
}
