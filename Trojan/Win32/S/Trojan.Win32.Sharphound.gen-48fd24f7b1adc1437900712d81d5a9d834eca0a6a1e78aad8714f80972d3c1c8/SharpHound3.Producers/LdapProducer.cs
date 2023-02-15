using System;
using System.DirectoryServices.Protocols;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using SharpHound3.Tasks;

namespace SharpHound3.Producers;

internal class LdapProducer : BaseProducer
{
	public LdapProducer(string domainName, string query, string[] props)
		: base(domainName, query, props)
	{
	}

	protected override async Task ProduceLdap(ITargetBlock<SearchResultEntry> queue)
	{
		CancellationToken token = Helpers.GetCancellationToken();
		OutputTasks.StartOutputTimer();
		foreach (SearchResultEntry searchResult in Searcher.QueryLdap(Query, Props, (SearchScope)2, Options.Instance.SearchBase))
		{
			if (token.IsCancellationRequested)
			{
				Console.WriteLine("[-] Terminating Producer as cancellation was requested. Waiting for pipeline to finish");
				break;
			}
			await queue.SendAsync(searchResult);
		}
		queue.Complete();
	}
}
