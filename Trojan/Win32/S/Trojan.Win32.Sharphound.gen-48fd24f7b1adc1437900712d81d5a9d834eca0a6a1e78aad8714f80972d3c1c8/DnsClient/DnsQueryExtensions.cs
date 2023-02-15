using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using DnsClient.Protocol;

namespace DnsClient;

public static class DnsQueryExtensions
{
	public static IPHostEntry GetHostEntry(this IDnsQuery query, string hostNameOrAddress)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (string.IsNullOrWhiteSpace(hostNameOrAddress))
		{
			throw new ArgumentNullException("hostNameOrAddress");
		}
		if (IPAddress.TryParse(hostNameOrAddress, out var address))
		{
			return query.GetHostEntry(address);
		}
		return GetHostEntryFromName(query, hostNameOrAddress);
	}

	public static Task<IPHostEntry> GetHostEntryAsync(this IDnsQuery query, string hostNameOrAddress)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (string.IsNullOrWhiteSpace(hostNameOrAddress))
		{
			throw new ArgumentNullException("hostNameOrAddress");
		}
		if (IPAddress.TryParse(hostNameOrAddress, out var address))
		{
			return query.GetHostEntryAsync(address);
		}
		return GetHostEntryFromNameAsync(query, hostNameOrAddress);
	}

	public static IPHostEntry GetHostEntry(this IDnsQuery query, IPAddress address)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		string hostName = query.GetHostName(address);
		if (string.IsNullOrWhiteSpace(hostName))
		{
			return null;
		}
		return GetHostEntryFromName(query, hostName);
	}

	public static async Task<IPHostEntry> GetHostEntryAsync(this IDnsQuery query, IPAddress address)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		string text = await query.GetHostNameAsync(address).ConfigureAwait(continueOnCapturedContext: false);
		if (string.IsNullOrWhiteSpace(text))
		{
			return null;
		}
		return await GetHostEntryFromNameAsync(query, text).ConfigureAwait(continueOnCapturedContext: false);
	}

	private static IPHostEntry GetHostEntryFromName(IDnsQuery query, string hostName)
	{
		if (string.IsNullOrWhiteSpace(hostName))
		{
			throw new ArgumentNullException("hostName");
		}
		DnsString dnsString = DnsString.FromResponseQueryString(hostName);
		IDnsQueryResponse dnsQueryResponse = query.Query(dnsString, QueryType.A);
		DnsResourceRecord[] allRecords = Enumerable.ToArray(Enumerable.Concat(second: query.Query(dnsString, QueryType.AAAA).Answers, first: dnsQueryResponse.Answers));
		return GetHostEntryProcessResult(dnsString, allRecords);
	}

	private static async Task<IPHostEntry> GetHostEntryFromNameAsync(IDnsQuery query, string hostName)
	{
		if (string.IsNullOrWhiteSpace(hostName))
		{
			throw new ArgumentNullException("hostName");
		}
		DnsString hostString = DnsString.FromResponseQueryString(hostName);
		Task<IDnsQueryResponse> ipv4Result = query.QueryAsync(hostString, QueryType.A);
		Task<IDnsQueryResponse> ipv6Result = query.QueryAsync(hostString, QueryType.AAAA);
		await Task.WhenAll<IDnsQueryResponse>(ipv4Result, ipv6Result).ConfigureAwait(continueOnCapturedContext: false);
		DnsResourceRecord[] allRecords = Enumerable.ToArray(Enumerable.Concat(ipv4Result.Result.Answers, ipv6Result.Result.Answers));
		return GetHostEntryProcessResult(hostString, allRecords);
	}

	private static IPHostEntry GetHostEntryProcessResult(DnsString hostString, DnsResourceRecord[] allRecords)
	{
		var array = Enumerable.ToArray(Enumerable.Select(Enumerable.OfType<AddressRecord>(allRecords), (AddressRecord p) => new
		{
			Address = p.Address,
			Alias = DnsString.FromResponseQueryString(p.DomainName)
		}));
		IPHostEntry iPHostEntry = new IPHostEntry
		{
			Aliases = new string[0],
			AddressList = Enumerable.ToArray(Enumerable.Select(array, p => p.Address))
		};
		if (array.Length > 1)
		{
			if (Enumerable.Any(array, p => !p.Alias.Equals(hostString)))
			{
				iPHostEntry.Aliases = Enumerable.ToArray(Enumerable.Distinct(Enumerable.Select(Enumerable.Select(array, p => p.Alias.ToString()), (string p) => p.Substring(0, p.Length - 1))));
			}
		}
		else if (array.Length == 1 && Enumerable.Any(allRecords, (DnsResourceRecord p) => !DnsString.FromResponseQueryString(p.DomainName).Equals(hostString)))
		{
			iPHostEntry.Aliases = Enumerable.ToArray(Enumerable.Distinct(Enumerable.Select(Enumerable.Select(allRecords, (DnsResourceRecord p) => p.DomainName.ToString()), (string p) => p.Substring(0, p.Length - 1))));
		}
		iPHostEntry.HostName = hostString.Value.Substring(0, hostString.Value.Length - 1);
		return iPHostEntry;
	}

	public static string GetHostName(this IDnsQuery query, IPAddress address)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		return GetHostNameAsyncProcessResult(query.QueryReverse(address));
	}

	public static async Task<string> GetHostNameAsync(this IDnsQuery query, IPAddress address)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (address == null)
		{
			throw new ArgumentNullException("address");
		}
		return GetHostNameAsyncProcessResult(await query.QueryReverseAsync(address).ConfigureAwait(continueOnCapturedContext: false));
	}

	private static string GetHostNameAsyncProcessResult(IDnsQueryResponse result)
	{
		if (result.HasError)
		{
			return null;
		}
		DnsString dnsString = Enumerable.FirstOrDefault(result.Answers.PtrRecords())?.PtrDomainName;
		if (string.IsNullOrWhiteSpace(dnsString))
		{
			return null;
		}
		return dnsString.Value.Substring(0, dnsString.Value.Length - 1);
	}

	public static ServiceHostEntry[] ResolveService(this IDnsQuery query, string baseDomain, string serviceName, ProtocolType protocol)
	{
		if (protocol != 0 && protocol != ProtocolType.Unknown)
		{
			return query.ResolveService(baseDomain, serviceName, protocol.ToString());
		}
		return query.ResolveService(baseDomain, serviceName);
	}

	public static Task<ServiceHostEntry[]> ResolveServiceAsync(this IDnsQuery query, string baseDomain, string serviceName, ProtocolType protocol)
	{
		if (protocol != 0 && protocol != ProtocolType.Unknown)
		{
			return query.ResolveServiceAsync(baseDomain, serviceName, protocol.ToString());
		}
		return query.ResolveServiceAsync(baseDomain, serviceName);
	}

	public static ServiceHostEntry[] ResolveService(this IDnsQuery query, string baseDomain, string serviceName, string tag = null)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (baseDomain == null)
		{
			throw new ArgumentNullException("baseDomain");
		}
		if (string.IsNullOrWhiteSpace(serviceName))
		{
			throw new ArgumentNullException("serviceName");
		}
		string query2 = ConcatResolveServiceName(baseDomain, serviceName, tag);
		return ResolveServiceProcessResult(query.Query(query2, QueryType.SRV));
	}

	public static async Task<ServiceHostEntry[]> ResolveServiceAsync(this IDnsQuery query, string baseDomain, string serviceName, string tag = null)
	{
		if (query == null)
		{
			throw new ArgumentNullException("query");
		}
		if (baseDomain == null)
		{
			throw new ArgumentNullException("baseDomain");
		}
		if (string.IsNullOrWhiteSpace(serviceName))
		{
			throw new ArgumentNullException("serviceName");
		}
		string query2 = ConcatResolveServiceName(baseDomain, serviceName, tag);
		return ResolveServiceProcessResult(await query.QueryAsync(query2, QueryType.SRV).ConfigureAwait(continueOnCapturedContext: false));
	}

	private static string ConcatResolveServiceName(string baseDomain, string serviceName, string tag)
	{
		if (!string.IsNullOrWhiteSpace(tag))
		{
			return $"_{serviceName}._{tag}.{baseDomain}.";
		}
		return $"{serviceName}.{baseDomain}.";
	}

	private static ServiceHostEntry[] ResolveServiceProcessResult(IDnsQueryResponse result)
	{
		List<ServiceHostEntry> list = new List<ServiceHostEntry>();
		if (result.HasError)
		{
			return list.ToArray();
		}
		foreach (SrvRecord entry in result.Answers.SrvRecords())
		{
			IEnumerable<IPAddress> source = Enumerable.Select(Enumerable.Where(Enumerable.OfType<AddressRecord>(result.Additionals), (AddressRecord p) => p.DomainName.Equals(entry.Target)), (AddressRecord p) => p.Address);
			DnsString dnsString = Enumerable.FirstOrDefault(Enumerable.Select(Enumerable.Where(Enumerable.OfType<CNameRecord>(result.Additionals), (CNameRecord p) => p.DomainName.Equals(entry.Target)), (CNameRecord p) => p.CanonicalName));
			list.Add(new ServiceHostEntry
			{
				AddressList = Enumerable.ToArray(source),
				HostName = dnsString,
				Port = entry.Port
			});
		}
		return list.ToArray();
	}
}
