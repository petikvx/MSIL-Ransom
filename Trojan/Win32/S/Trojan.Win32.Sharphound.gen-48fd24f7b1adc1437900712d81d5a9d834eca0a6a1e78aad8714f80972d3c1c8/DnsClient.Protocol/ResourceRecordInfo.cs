using System;

namespace DnsClient.Protocol;

public class ResourceRecordInfo
{
	private readonly int _ticks;

	public DnsString DomainName { get; }

	public ResourceRecordType RecordType { get; }

	public QueryClass RecordClass { get; }

	public int TimeToLive
	{
		get
		{
			int num = Environment.TickCount & 0x7FFFFFFF;
			if (num < _ticks)
			{
				return 0;
			}
			int num2 = InitialTimeToLive - (num - _ticks) / 1000;
			if (num2 >= 0)
			{
				return num2;
			}
			return 0;
		}
	}

	public int InitialTimeToLive { get; internal set; }

	public int RawDataLength { get; }

	public ResourceRecordInfo(string domainName, ResourceRecordType recordType, QueryClass recordClass, int timeToLive, int rawDataLength)
		: this(DnsString.Parse(domainName), recordType, recordClass, timeToLive, rawDataLength)
	{
	}

	public ResourceRecordInfo(DnsString domainName, ResourceRecordType recordType, QueryClass recordClass, int timeToLive, int rawDataLength)
	{
		DomainName = domainName ?? throw new ArgumentNullException("domainName");
		RecordType = recordType;
		RecordClass = recordClass;
		RawDataLength = rawDataLength;
		InitialTimeToLive = timeToLive;
		_ticks = Environment.TickCount;
	}
}
