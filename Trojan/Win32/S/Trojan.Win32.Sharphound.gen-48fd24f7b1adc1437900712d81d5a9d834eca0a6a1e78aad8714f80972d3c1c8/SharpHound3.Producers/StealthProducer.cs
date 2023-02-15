using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using SharpHound3.Tasks;

namespace SharpHound3.Producers;

internal class StealthProducer : BaseProducer
{
	private static Dictionary<string, SearchResultEntry> _stealthTargetSids;

	private bool _stealthTargetsBuilt;

	public StealthProducer(string domainName, string query, string[] props)
		: base(domainName, query, props)
	{
	}

	private static void SetStealthTargetSids(Dictionary<string, SearchResultEntry> targets)
	{
		if (_stealthTargetSids == null)
		{
			_stealthTargetSids = targets;
			return;
		}
		foreach (KeyValuePair<string, SearchResultEntry> target in targets)
		{
			_stealthTargetSids.Add(target.Key, target.Value);
		}
	}

	internal static bool IsSidStealthTarget(string sid)
	{
		return _stealthTargetSids.ContainsKey(sid);
	}

	protected override async Task ProduceLdap(ITargetBlock<SearchResultEntry> queue)
	{
		CancellationToken token = Helpers.GetCancellationToken();
		if (!_stealthTargetsBuilt)
		{
			Console.WriteLine("[+] Finding Stealth Targets from LDAP Properties");
			Console.WriteLine();
			SetStealthTargetSids(await FindPathTargetSids());
			_stealthTargetsBuilt = true;
			OutputTasks.StartOutputTimer();
			foreach (SearchResultEntry searchResult2 in Searcher.QueryLdap(Query, Props, (SearchScope)2, Options.Instance.SearchBase))
			{
				if (token.IsCancellationRequested)
				{
					Console.WriteLine("[-] Terminating Producer as cancellation was requested. Waiting for pipeline to finish");
					break;
				}
				await queue.SendAsync(searchResult2);
			}
			queue.Complete();
			return;
		}
		OutputTasks.StartOutputTimer();
		List<SearchResultEntry> targets = new List<SearchResultEntry>();
		targets.AddRange(_stealthTargetSids.Values);
		if (!Options.Instance.ExcludeDomainControllers)
		{
			targets.AddRange(BaseProducer.DomainControllerSids.Values);
		}
		foreach (SearchResultEntry searchResult in targets)
		{
			if (token.IsCancellationRequested)
			{
				break;
			}
			await queue.SendAsync(searchResult);
		}
		queue.Complete();
	}

	private async Task<Dictionary<string, SearchResultEntry>> FindPathTargetSids()
	{
		ConcurrentDictionary<string, byte> paths = new ConcurrentDictionary<string, byte>();
		Dictionary<string, SearchResultEntry> sids = new Dictionary<string, SearchResultEntry>();
		Parallel.ForEach(Searcher.QueryLdap("(&(samAccountType=805306368)(!(userAccountControl:1.2.840.113556.1.4.803:=2))(|(homedirectory=*)(scriptpath=*)(profilepath=*)))", new string[3] { "homedirectory", "scriptpath", "profilepath" }, (SearchScope)2), delegate(SearchResultEntry searchResult)
		{
			IEnumerable<string> enumerable = Enumerable.Where(new string[3]
			{
				searchResult.GetProperty("homedirectory"),
				searchResult.GetProperty("scriptpath"),
				searchResult.GetProperty("profilepath")
			}, (string s) => s != null);
			foreach (string item in enumerable)
			{
				string[] array = item?.Split(new char[1] { '\\' });
				if (array != null && array.Length >= 3)
				{
					string key = array[2];
					paths.TryAdd(key, 0);
				}
			}
		});
		foreach (string path in paths.Keys)
		{
			string sid = await ResolutionHelpers.ResolveHostToSid(path, DomainName);
			if (sid != null)
			{
				sids.Add(sid, await Searcher.GetOne("(objectsid=" + Helpers.ConvertSidToHexSid(sid) + ")", Props, (SearchScope)2));
			}
		}
		return sids;
	}
}
