using System;
using System.Collections.Generic;
using System.Linq;
using DnsClient.Protocol;

namespace DnsClient;

internal class DnsResponseMessage
{
	public List<DnsResourceRecord> Additionals { get; } = new List<DnsResourceRecord>();


	public List<DnsResourceRecord> Answers { get; } = new List<DnsResourceRecord>();


	public List<DnsResourceRecord> Authorities { get; } = new List<DnsResourceRecord>();


	public DnsResponseHeader Header { get; }

	public int MessageSize { get; }

	public List<DnsQuestion> Questions { get; } = new List<DnsQuestion>();


	public LookupClientAudit Audit { get; set; } = new LookupClientAudit();


	public DnsResponseMessage(DnsResponseHeader header, int messageSize)
	{
		Header = header ?? throw new ArgumentNullException("header");
		MessageSize = messageSize;
	}

	public void AddAdditional(DnsResourceRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		Additionals.Add(record);
	}

	public void AddAnswer(DnsResourceRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		Answers.Add(record);
	}

	public void AddAuthority(DnsResourceRecord record)
	{
		if (record == null)
		{
			throw new ArgumentNullException("record");
		}
		Authorities.Add(record);
	}

	public void AddQuestion(DnsQuestion question)
	{
		if (question == null)
		{
			throw new ArgumentNullException("question");
		}
		Questions.Add(question);
	}

	public DnsQueryResponse AsQueryResponse(NameServer nameServer)
	{
		return new DnsQueryResponse(this, nameServer, Audit);
	}

	public static DnsResponseMessage Combine(params DnsResponseMessage[] messages)
	{
		if (messages.Length <= 1)
		{
			return Enumerable.FirstOrDefault(messages);
		}
		DnsResponseMessage dnsResponseMessage = Enumerable.First(messages);
		DnsResponseMessage dnsResponseMessage2 = new DnsResponseMessage(new DnsResponseHeader(dnsResponseMessage.Header.Id, (ushort)dnsResponseMessage.Header.HeaderFlags, dnsResponseMessage.Header.QuestionCount, Enumerable.Sum(messages, (DnsResponseMessage p) => p.Header.AnswerCount), Enumerable.Sum(messages, (DnsResponseMessage p) => p.Header.AdditionalCount), dnsResponseMessage.Header.NameServerCount), Enumerable.Sum(messages, (DnsResponseMessage p) => p.MessageSize));
		dnsResponseMessage2.Questions.AddRange(dnsResponseMessage.Questions);
		dnsResponseMessage2.Additionals.AddRange(Enumerable.SelectMany(messages, (DnsResponseMessage p) => p.Additionals));
		dnsResponseMessage2.Answers.AddRange(Enumerable.SelectMany(messages, (DnsResponseMessage p) => p.Answers));
		dnsResponseMessage2.Authorities.AddRange(Enumerable.SelectMany(messages, (DnsResponseMessage p) => p.Authorities));
		return dnsResponseMessage2;
	}
}
