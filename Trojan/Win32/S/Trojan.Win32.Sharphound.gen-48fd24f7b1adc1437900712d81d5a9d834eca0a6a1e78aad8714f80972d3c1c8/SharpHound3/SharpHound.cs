using System;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.Protocols;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Timers;
using CommandLine;
using SharpHound3.Tasks;

namespace SharpHound3;

internal class SharpHound
{
	private static async Task Main(string[] args)
	{
		Parser parser = new Parser(delegate(ParserSettings with)
		{
			with.CaseInsensitiveEnumValues = true;
			with.CaseSensitive = false;
			with.HelpWriter = Console.Error;
		});
		parser.ParseArguments<Options>(args).WithParsed(delegate(Options o)
		{
			DateTime now = DateTime.Now;
			string text = "Initializing SharpHound at " + now.ToShortTimeString() + " on " + now.ToShortDateString();
			Console.WriteLine(new string('-', text.Length));
			Console.WriteLine(text);
			Console.WriteLine(new string('-', text.Length));
			Console.WriteLine();
			if (o.OverrideUserName != null)
			{
				o.CurrentUserName = o.OverrideUserName;
			}
			else
			{
				o.CurrentUserName = WindowsIdentity.GetCurrent().Name.Split(new char[1] { '\\' })[1];
			}
			if (o.Loop)
			{
				if (o.LoopDuration == TimeSpan.Zero)
				{
					Console.WriteLine("Loop specified without a duration. Defaulting to 2 hours!");
					o.LoopDuration = TimeSpan.FromHours(2.0);
				}
				if (o.LoopInterval == TimeSpan.Zero)
				{
					o.LoopInterval = TimeSpan.FromSeconds(30.0);
				}
			}
			Options.Instance = o;
		}).WithNotParsed(delegate
		{
		});
		parser.Dispose();
		Options options = Options.Instance;
		if (options == null || !options.ResolveCollectionMethods())
		{
			return;
		}
		if (options.Domain == null)
		{
			try
			{
				options.Domain = ((ActiveDirectoryPartition)Domain.GetCurrentDomain()).get_Name().ToUpper();
			}
			catch (Exception ex)
			{
				Exception e2 = ex;
				Console.WriteLine(e2);
				Console.WriteLine("Unable to determine user's domain. Please manually specify it with the --domain flag");
				return;
			}
		}
		if ((options.LdapPassword != null && options.LdapUsername == null) || (options.LdapUsername != null && options.LdapPassword == null))
		{
			Console.WriteLine("You must specify both LdapUsername and LdapPassword if using these options!");
			return;
		}
		DirectorySearch searcher = Helpers.GetDirectorySearcher(options.Domain);
		if (await searcher.GetOne("(objectclass=domain)", new string[1] { "objectsid" }, (SearchScope)2) == null)
		{
			Console.WriteLine("LDAP Connection Test Failed. Check if you're in a domain context!");
			return;
		}
		bool initialCompleted = false;
		bool needsCancellation = false;
		Timer timer = null;
		DateTime loopEnd = DateTime.Now;
		if (options.Loop)
		{
			loopEnd = loopEnd.AddMilliseconds(options.LoopDuration.TotalMilliseconds);
			timer = new Timer();
			timer.Elapsed += delegate
			{
				if (initialCompleted)
				{
					Helpers.InvokeCancellation();
				}
				else
				{
					needsCancellation = true;
				}
			};
			timer.Interval = options.LoopDuration.TotalMilliseconds;
			timer.AutoReset = false;
			timer.Start();
		}
		Cache.CreateInstance();
		OutputTasks.StartComputerStatusTask();
		Task pipelineCompletionTask2 = PipelineBuilder.GetBasePipelineForDomain(options.Domain);
		await pipelineCompletionTask2;
		await OutputTasks.CompleteOutput();
		initialCompleted = true;
		if (needsCancellation)
		{
			Helpers.InvokeCancellation();
		}
		if (Options.Instance.Loop)
		{
			if (Helpers.GetCancellationToken().IsCancellationRequested)
			{
				Console.WriteLine("Skipping looping because loop duration has already passed");
			}
			else
			{
				Console.WriteLine();
				Console.WriteLine("Waiting 30 seconds before starting loops");
				try
				{
					await Task.Delay(TimeSpan.FromSeconds(30.0), Helpers.GetCancellationToken());
				}
				catch (TaskCanceledException)
				{
					Console.WriteLine("Skipped wait because loop duration has completed!");
				}
				if (!Helpers.GetCancellationToken().IsCancellationRequested)
				{
					Console.WriteLine();
					Console.WriteLine($"Loop Enumeration Methods: {options.GetLoopCollectionMethods()}");
					Console.WriteLine("Looping scheduled to stop at " + loopEnd.ToLongTimeString() + " on " + loopEnd.ToShortDateString());
					Console.WriteLine();
				}
				int count = 0;
				while (!Helpers.GetCancellationToken().IsCancellationRequested)
				{
					count++;
					DateTime currentTime = DateTime.Now;
					Console.WriteLine($"Starting loop #{count} at {currentTime.ToShortTimeString()} on {currentTime.ToShortDateString()}");
					Helpers.StartNewRun();
					pipelineCompletionTask2 = PipelineBuilder.GetLoopPipelineForDomain(Options.Instance.Domain);
					await pipelineCompletionTask2;
					await OutputTasks.CompleteOutput();
					if (!Helpers.GetCancellationToken().IsCancellationRequested)
					{
						Console.WriteLine();
						Console.WriteLine($"Waiting {options.LoopInterval.TotalSeconds} seconds for next loop");
						Console.WriteLine();
						try
						{
							await Task.Delay(options.LoopInterval, Helpers.GetCancellationToken());
						}
						catch (TaskCanceledException)
						{
							Console.WriteLine("Skipping wait as loop duration has expired");
						}
					}
				}
				if (count > 0)
				{
					Console.WriteLine($"Looping finished! Looped a total of {count} times");
				}
				await OutputTasks.CollapseLoopZipFiles();
			}
		}
		timer?.Dispose();
		Cache.Instance.SaveCache();
		DateTime currTime = DateTime.Now;
		Console.WriteLine();
		Console.WriteLine("SharpHound Enumeration Completed at " + currTime.ToShortTimeString() + " on " + currTime.ToShortDateString() + "! Happy Graphing!");
		Console.WriteLine();
	}

	public static void InvokeSharpHound(string[] args)
	{
		Main(args).Wait();
	}
}
