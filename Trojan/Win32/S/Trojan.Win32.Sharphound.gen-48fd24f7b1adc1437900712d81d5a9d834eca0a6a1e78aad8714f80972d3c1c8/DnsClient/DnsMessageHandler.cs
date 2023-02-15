using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using DnsClient.Protocol;
using DnsClient.Protocol.Options;

namespace DnsClient;

internal abstract class DnsMessageHandler
{
	public abstract DnsResponseMessage Query(IPEndPoint endpoint, DnsRequestMessage request, TimeSpan timeout);

	public abstract Task<DnsResponseMessage> QueryAsync(IPEndPoint server, DnsRequestMessage request, CancellationToken cancellationToken, Action<Action> cancelationCallback);

	public abstract bool IsTransientException<T>(T exception) where T : Exception;

	public virtual void GetRequestData(DnsRequestMessage request, DnsDatagramWriter writer)
	{
		DnsQuestion question = request.Question;
		writer.WriteInt16NetworkOrder((short)request.Header.Id);
		writer.WriteUInt16NetworkOrder(request.Header.RawFlags);
		writer.WriteInt16NetworkOrder(1);
		writer.WriteInt16NetworkOrder(0);
		writer.WriteInt16NetworkOrder(0);
		writer.WriteInt16NetworkOrder(1);
		writer.WriteHostName(question.QueryName);
		writer.WriteUInt16NetworkOrder((ushort)question.QuestionType);
		writer.WriteUInt16NetworkOrder((ushort)question.QuestionClass);
		OptRecord optRecord = new OptRecord();
		writer.WriteHostName("");
		writer.WriteUInt16NetworkOrder((ushort)optRecord.RecordType);
		writer.WriteUInt16NetworkOrder((ushort)optRecord.RecordClass);
		writer.WriteUInt32NetworkOrder((ushort)optRecord.InitialTimeToLive);
		writer.WriteUInt16NetworkOrder(0);
	}

	public virtual DnsResponseMessage GetResponseMessage(ArraySegment<byte> responseData)
	{
		DnsDatagramReader dnsDatagramReader = new DnsDatagramReader(responseData);
		DnsRecordFactory dnsRecordFactory = new DnsRecordFactory(dnsDatagramReader);
		ushort id = dnsDatagramReader.ReadUInt16NetworkOrder();
		ushort flags = dnsDatagramReader.ReadUInt16NetworkOrder();
		ushort num = dnsDatagramReader.ReadUInt16NetworkOrder();
		ushort num2 = dnsDatagramReader.ReadUInt16NetworkOrder();
		ushort num3 = dnsDatagramReader.ReadUInt16NetworkOrder();
		ushort num4 = dnsDatagramReader.ReadUInt16NetworkOrder();
		DnsResponseMessage dnsResponseMessage = new DnsResponseMessage(new DnsResponseHeader(id, flags, num, num2, num4, num3), responseData.Count);
		for (int i = 0; i < num; i++)
		{
			DnsQuestion question = new DnsQuestion(dnsDatagramReader.ReadQuestionQueryString(), (QueryType)dnsDatagramReader.ReadUInt16NetworkOrder(), (QueryClass)dnsDatagramReader.ReadUInt16NetworkOrder());
			dnsResponseMessage.AddQuestion(question);
		}
		for (int j = 0; j < num2; j++)
		{
			ResourceRecordInfo info = dnsRecordFactory.ReadRecordInfo();
			DnsResourceRecord record = dnsRecordFactory.GetRecord(info);
			dnsResponseMessage.AddAnswer(record);
		}
		for (int k = 0; k < num3; k++)
		{
			ResourceRecordInfo info2 = dnsRecordFactory.ReadRecordInfo();
			DnsResourceRecord record2 = dnsRecordFactory.GetRecord(info2);
			dnsResponseMessage.AddAuthority(record2);
		}
		for (int l = 0; l < num4; l++)
		{
			ResourceRecordInfo info3 = dnsRecordFactory.ReadRecordInfo();
			DnsResourceRecord record3 = dnsRecordFactory.GetRecord(info3);
			dnsResponseMessage.AddAdditional(record3);
		}
		return dnsResponseMessage;
	}
}
