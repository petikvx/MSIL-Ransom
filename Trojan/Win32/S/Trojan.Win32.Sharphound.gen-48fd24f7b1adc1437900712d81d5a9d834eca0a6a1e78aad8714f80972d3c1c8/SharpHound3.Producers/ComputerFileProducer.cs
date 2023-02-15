using System;
using System.DirectoryServices.Protocols;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using SharpHound3.Tasks;

namespace SharpHound3.Producers;

internal class ComputerFileProducer : BaseProducer
{
	public ComputerFileProducer(string domainName, string query, string[] props)
		: base(domainName, query, props)
	{
	}

	protected override async Task ProduceLdap(ITargetBlock<SearchResultEntry> queue)
	{
		string computerFile = Options.Instance.ComputerFile;
		CancellationToken token = Helpers.GetCancellationToken();
		OutputTasks.StartOutputTimer();
		try
		{
			using StreamReader fileStream = new StreamReader(new FileStream(computerFile, FileMode.Open, FileAccess.Read));
			while (true)
			{
				string text;
				string computer = (text = fileStream.ReadLine());
				if (text == null || token.IsCancellationRequested)
				{
					break;
				}
				string sid = (computer.StartsWith("S-1-5-21") ? computer : (await ResolutionHelpers.ResolveHostToSid(computer, DomainName)));
				try
				{
					string hexSid = Helpers.ConvertSidToHexSid(sid);
					SearchResultEntry entry = await Searcher.GetOne("(objectsid=" + hexSid + ")", Props, (SearchScope)2);
					if (entry != null)
					{
						await queue.SendAsync(entry);
					}
					else
					{
						Console.WriteLine("Failed to resolve " + computer);
					}
				}
				catch
				{
					Console.WriteLine("Failed to resolve " + computer);
				}
			}
		}
		catch
		{
			Console.WriteLine("Error in opening file " + computerFile);
		}
		finally
		{
			queue.Complete();
		}
	}
}
