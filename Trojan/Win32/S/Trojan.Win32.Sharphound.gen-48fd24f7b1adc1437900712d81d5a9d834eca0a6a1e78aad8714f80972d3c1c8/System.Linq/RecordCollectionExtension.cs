using System.Collections.Generic;
using DnsClient.Protocol;

namespace System.Linq;

public static class RecordCollectionExtension
{
	public static IEnumerable<ARecord> ARecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<ARecord>(records);
	}

	public static IEnumerable<NsRecord> NsRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<NsRecord>(records);
	}

	public static IEnumerable<CNameRecord> CnameRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<CNameRecord>(records);
	}

	[CLSCompliant(false)]
	public static IEnumerable<SoaRecord> SoaRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<SoaRecord>(records);
	}

	public static IEnumerable<MbRecord> MbRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<MbRecord>(records);
	}

	public static IEnumerable<MgRecord> MgRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<MgRecord>(records);
	}

	public static IEnumerable<MrRecord> MrRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<MrRecord>(records);
	}

	public static IEnumerable<NullRecord> NullRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<NullRecord>(records);
	}

	public static IEnumerable<WksRecord> WksRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<WksRecord>(records);
	}

	public static IEnumerable<PtrRecord> PtrRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<PtrRecord>(records);
	}

	public static IEnumerable<HInfoRecord> HInfoRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<HInfoRecord>(records);
	}

	[CLSCompliant(false)]
	public static IEnumerable<MxRecord> MxRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<MxRecord>(records);
	}

	public static IEnumerable<TxtRecord> TxtRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<TxtRecord>(records);
	}

	public static IEnumerable<RpRecord> RpRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<RpRecord>(records);
	}

	public static IEnumerable<AfsDbRecord> AfsDbRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<AfsDbRecord>(records);
	}

	public static IEnumerable<AaaaRecord> AaaaRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<AaaaRecord>(records);
	}

	[CLSCompliant(false)]
	public static IEnumerable<SrvRecord> SrvRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<SrvRecord>(records);
	}

	public static IEnumerable<UriRecord> UriRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<UriRecord>(records);
	}

	public static IEnumerable<CaaRecord> CaaRecords(this IEnumerable<DnsResourceRecord> records)
	{
		return Enumerable.OfType<CaaRecord>(records);
	}

	public static IEnumerable<DnsResourceRecord> OfRecordType(this IEnumerable<DnsResourceRecord> records, ResourceRecordType type)
	{
		return Enumerable.Where(records, (DnsResourceRecord p) => p.RecordType == type);
	}
}
