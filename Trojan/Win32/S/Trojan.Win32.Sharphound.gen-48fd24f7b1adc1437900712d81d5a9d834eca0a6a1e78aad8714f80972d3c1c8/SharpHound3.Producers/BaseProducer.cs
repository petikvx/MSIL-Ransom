using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace SharpHound3.Producers;

internal abstract class BaseProducer
{
	protected static Dictionary<string, SearchResultEntry> DomainControllerSids;

	protected readonly DirectorySearch Searcher;

	protected readonly string Query;

	protected readonly string[] Props;

	protected readonly string DomainName;

	protected BaseProducer(string domainName, string query, string[] props)
	{
		Searcher = Helpers.GetDirectorySearcher(domainName);
		Query = query;
		Props = props;
		DomainName = domainName;
		SetDomainControllerSids(GetDomainControllerSids());
	}

	private static void SetDomainControllerSids(Dictionary<string, SearchResultEntry> dcs)
	{
		if (DomainControllerSids == null)
		{
			DomainControllerSids = dcs;
			return;
		}
		foreach (KeyValuePair<string, SearchResultEntry> dc in dcs)
		{
			try
			{
				DomainControllerSids.Add(dc.Key, dc.Value);
			}
			catch
			{
			}
		}
	}

	internal static bool IsSidDomainController(string sid)
	{
		return DomainControllerSids.ContainsKey(sid);
	}

	internal static Dictionary<string, SearchResultEntry> GetDomainControllers()
	{
		return DomainControllerSids;
	}

	internal Task StartProducer(ITargetBlock<SearchResultEntry> queue)
	{
		return Task.Run(async delegate
		{
			await ProduceLdap(queue);
		});
	}

	protected Dictionary<string, SearchResultEntry> GetDomainControllerSids()
	{
		Console.WriteLine("[+] Pre-populating Domain Controller SIDS");
		Dictionary<string, SearchResultEntry> dictionary = new Dictionary<string, SearchResultEntry>();
		foreach (SearchResultEntry item in Searcher.QueryLdap("(&(objectclass=computer)(userAccountControl:1.2.840.113556.1.4.803:=8192))", new string[2] { "objectsid", "samaccountname" }, (SearchScope)2))
		{
			string sid = item.GetSid();
			if (sid != null)
			{
				dictionary.Add(sid, item);
			}
		}
		return dictionary;
	}

	protected abstract Task ProduceLdap(ITargetBlock<SearchResultEntry> queue);
}
