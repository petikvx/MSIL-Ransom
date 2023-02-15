using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using DnsClient.Protocol;
using DnsClient.Protocol.Options;

namespace DnsClient;

internal class DnsRecordFactory
{
	private readonly DnsDatagramReader _reader;

	public DnsRecordFactory(DnsDatagramReader reader)
	{
		_reader = reader ?? throw new ArgumentNullException("reader");
	}

	public ResourceRecordInfo ReadRecordInfo()
	{
		return new ResourceRecordInfo(_reader.ReadQuestionQueryString(), (ResourceRecordType)_reader.ReadUInt16NetworkOrder(), (QueryClass)_reader.ReadUInt16NetworkOrder(), (int)_reader.ReadUInt32NetworkOrder(), _reader.ReadUInt16NetworkOrder());
	}

	public DnsResourceRecord GetRecord(ResourceRecordInfo info)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		int index = _reader.Index;
		DnsResourceRecord result;
		switch (info.RecordType)
		{
		case ResourceRecordType.OPT:
			result = ResolveOptRecord(info);
			break;
		case ResourceRecordType.A:
			result = new ARecord(info, _reader.ReadIPAddress());
			break;
		case ResourceRecordType.NS:
			result = new NsRecord(info, _reader.ReadDnsName());
			break;
		case ResourceRecordType.CNAME:
			result = new CNameRecord(info, _reader.ReadDnsName());
			break;
		case ResourceRecordType.SOA:
			result = ResolveSoaRecord(info);
			break;
		case ResourceRecordType.MB:
			result = new MbRecord(info, _reader.ReadDnsName());
			break;
		case ResourceRecordType.MG:
			result = new MgRecord(info, _reader.ReadDnsName());
			break;
		case ResourceRecordType.MR:
			result = new MrRecord(info, _reader.ReadDnsName());
			break;
		case ResourceRecordType.NULL:
			result = new NullRecord(info, Enumerable.ToArray(_reader.ReadBytes(info.RawDataLength)));
			break;
		case ResourceRecordType.WKS:
			result = ResolveWksRecord(info);
			break;
		case ResourceRecordType.PTR:
			result = new PtrRecord(info, _reader.ReadDnsName());
			break;
		case ResourceRecordType.HINFO:
			result = new HInfoRecord(info, _reader.ReadString(), _reader.ReadString());
			break;
		case ResourceRecordType.MINFO:
			result = new MInfoRecord(info, _reader.ReadDnsName(), _reader.ReadDnsName());
			break;
		case ResourceRecordType.MX:
			result = ResolveMXRecord(info);
			break;
		case ResourceRecordType.TXT:
			result = ResolveTXTRecord(info);
			break;
		case ResourceRecordType.RP:
			result = new RpRecord(info, _reader.ReadDnsName(), _reader.ReadDnsName());
			break;
		case ResourceRecordType.AFSDB:
			result = new AfsDbRecord(info, (AfsType)_reader.ReadUInt16NetworkOrder(), _reader.ReadDnsName());
			break;
		case ResourceRecordType.AAAA:
			result = new AaaaRecord(info, _reader.ReadIPv6Address());
			break;
		case ResourceRecordType.SRV:
			result = ResolveSrvRecord(info);
			break;
		default:
			_reader.Index += info.RawDataLength;
			result = new EmptyRecord(info);
			break;
		case ResourceRecordType.CAA:
			result = ResolveCaaRecord(info);
			break;
		case ResourceRecordType.URI:
			result = ResolveUriRecord(info);
			break;
		case ResourceRecordType.SSHFP:
			result = ResolveSshfpRecord(info);
			break;
		}
		if (_reader.Index != index + info.RawDataLength)
		{
			throw new InvalidOperationException("Record reader index out of sync.");
		}
		return result;
	}

	private DnsResourceRecord ResolveUriRecord(ResourceRecordInfo info)
	{
		ushort priority = _reader.ReadUInt16NetworkOrder();
		ushort weight = _reader.ReadUInt16NetworkOrder();
		string target = _reader.ReadString(info.RawDataLength - 4);
		return new UriRecord(info, priority, weight, target);
	}

	private DnsResourceRecord ResolveOptRecord(ResourceRecordInfo info)
	{
		return new OptRecord((int)info.RecordClass, info.InitialTimeToLive, info.RawDataLength);
	}

	private DnsResourceRecord ResolveWksRecord(ResourceRecordInfo info)
	{
		IPAddress address = _reader.ReadIPAddress();
		byte protocol = _reader.ReadByte();
		ArraySegment<byte> arraySegment = _reader.ReadBytes(info.RawDataLength - 5);
		return new WksRecord(info, address, protocol, Enumerable.ToArray(arraySegment));
	}

	private DnsResourceRecord ResolveMXRecord(ResourceRecordInfo info)
	{
		ushort preference = _reader.ReadUInt16NetworkOrder();
		DnsString domainName = _reader.ReadDnsName();
		return new MxRecord(info, preference, domainName);
	}

	private DnsResourceRecord ResolveSoaRecord(ResourceRecordInfo info)
	{
		DnsString mName = _reader.ReadDnsName();
		DnsString rName = _reader.ReadDnsName();
		uint serial = _reader.ReadUInt32NetworkOrder();
		uint refresh = _reader.ReadUInt32NetworkOrder();
		uint retry = _reader.ReadUInt32NetworkOrder();
		uint expire = _reader.ReadUInt32NetworkOrder();
		uint minimum = _reader.ReadUInt32NetworkOrder();
		return new SoaRecord(info, mName, rName, serial, refresh, retry, expire, minimum);
	}

	private DnsResourceRecord ResolveSrvRecord(ResourceRecordInfo info)
	{
		ushort priority = _reader.ReadUInt16NetworkOrder();
		ushort weigth = _reader.ReadUInt16NetworkOrder();
		ushort port = _reader.ReadUInt16NetworkOrder();
		DnsString target = _reader.ReadDnsName();
		return new SrvRecord(info, priority, weigth, port, target);
	}

	private DnsResourceRecord ResolveTXTRecord(ResourceRecordInfo info)
	{
		int index = _reader.Index;
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		while (_reader.Index - index < info.RawDataLength)
		{
			byte b = _reader.ReadByte();
			ArraySegment<byte> data = _reader.ReadBytes(b);
			new ArraySegment<byte>(data.Array, data.Offset, b);
			string item = DnsDatagramReader.ParseString(data);
			string item2 = DnsDatagramReader.ReadUTF8String(data);
			list.Add(item);
			list2.Add(item2);
		}
		return new TxtRecord(info, list.ToArray(), list2.ToArray());
	}

	private DnsResourceRecord ResolveSshfpRecord(ResourceRecordInfo info)
	{
		SshfpAlgorithm algorithm = (SshfpAlgorithm)_reader.ReadByte();
		SshfpFingerprintType fingerprintType = (SshfpFingerprintType)_reader.ReadByte();
		byte[] source = Enumerable.ToArray(_reader.ReadBytes(info.RawDataLength - 2));
		string fingerprint = string.Join(string.Empty, Enumerable.Select(source, (byte b) => b.ToString("X2")));
		return new SshfpRecord(info, algorithm, fingerprintType, fingerprint);
	}

	private DnsResourceRecord ResolveCaaRecord(ResourceRecordInfo info)
	{
		byte flags = _reader.ReadByte();
		string text = _reader.ReadString();
		string value = DnsDatagramReader.ParseString(_reader, info.RawDataLength - 2 - text.Length);
		return new CaaRecord(info, flags, text, value);
	}
}
