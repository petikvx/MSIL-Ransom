using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices.Protocols;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using ICSharpCode.SharpZipLib.Zip;
using Newtonsoft.Json;
using SharpHound3.Enums;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;
using SharpHound3.Producers;

namespace SharpHound3.Tasks;

internal class OutputTasks
{
	private class JsonFileWriter
	{
		private readonly string _baseFileName;

		private static readonly JsonSerializer Serializer = new JsonSerializer
		{
			NullValueHandling = NullValueHandling.Include
		};

		private int Count { get; set; }

		private JsonTextWriter JsonWriter { get; }

		internal JsonFileWriter(string baseFilename)
		{
			Count = 0;
			JsonWriter = CreateFile(baseFilename);
			_baseFileName = baseFilename;
		}

		internal void CloseWriter()
		{
			JsonWriter.Flush();
			JsonWriter.WriteEndArray();
			JsonWriter.WritePropertyName("meta");
			JsonWriter.WriteStartObject();
			JsonWriter.WritePropertyName("count");
			JsonWriter.WriteValue(Count);
			JsonWriter.WritePropertyName("type");
			JsonWriter.WriteValue(_baseFileName);
			JsonWriter.WritePropertyName("version");
			JsonWriter.WriteValue(3);
			JsonWriter.WriteEndObject();
			JsonWriter.Close();
		}

		internal void WriteObject(LdapWrapper json)
		{
			Serializer.Serialize(JsonWriter, json);
			Count++;
			if (Count % 100 == 0)
			{
				JsonWriter.Flush();
			}
		}

		private static JsonTextWriter CreateFile(string baseName)
		{
			string text = Helpers.ResolveFileName(baseName, "json", addTimestamp: true);
			UsedFileNames.Add(text);
			if (File.Exists(text))
			{
				throw new FileExistsException("File " + text + " already exists. This should never happen!");
			}
			StreamWriter textWriter = new StreamWriter(text, append: false, Encoding.UTF8);
			Formatting formatting = (Options.Instance.PrettyJson ? Formatting.Indented : Formatting.None);
			JsonTextWriter jsonTextWriter = new JsonTextWriter(textWriter)
			{
				Formatting = formatting
			};
			jsonTextWriter.WriteStartObject();
			jsonTextWriter.WritePropertyName(baseName);
			jsonTextWriter.WriteStartArray();
			return jsonTextWriter;
		}
	}

	private static readonly List<string> UsedFileNames = new List<string>();

	private static readonly List<string> ZipFileNames = new List<string>();

	private static Lazy<JsonFileWriter> _userOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("users"), isThreadSafe: false);

	private static Lazy<JsonFileWriter> _groupOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("groups"), isThreadSafe: false);

	private static Lazy<JsonFileWriter> _computerOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("computers"), isThreadSafe: false);

	private static Lazy<JsonFileWriter> _domainOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("domains"), isThreadSafe: false);

	private static Lazy<JsonFileWriter> _gpoOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("gpos"), isThreadSafe: false);

	private static Lazy<JsonFileWriter> _ouOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("ous"), isThreadSafe: false);

	private static int _lastCount;

	private static int _currentCount;

	private static Timer _statusTimer;

	private static Stopwatch _runTimer;

	private static Task _computerStatusTask;

	private static readonly ConcurrentDictionary<string, int> ComputerStatusCount = new ConcurrentDictionary<string, int>();

	private static readonly BlockingCollection<ComputerStatus> ComputerStatusQueue = new BlockingCollection<ComputerStatus>();

	internal static readonly Lazy<string> ZipPasswords = new Lazy<string>(GenerateZipPassword);

	internal static ConcurrentDictionary<string, string> SeenCommonPrincipals = new ConcurrentDictionary<string, string>();

	internal static void StartOutputTimer()
	{
		PrintStatus();
		_statusTimer = new Timer(Options.Instance.StatusInterval);
		_runTimer = new Stopwatch();
		_runTimer.Start();
		_statusTimer.Elapsed += delegate
		{
			PrintStatus();
			_lastCount = _currentCount;
		};
		_statusTimer.AutoReset = true;
		_statusTimer.Start();
	}

	internal static void PrintStatus()
	{
		Console.WriteLine((_runTimer != null) ? $"Status: {_currentCount} objects finished (+{_currentCount - _lastCount} {(float)_currentCount / (float)(_runTimer.ElapsedMilliseconds / 1000L)})/s -- Using {Process.GetCurrentProcess().PrivateMemorySize64 / 1024L / 1024L} MB RAM" : $"Status: {_currentCount} objects finished (+{_currentCount - _lastCount}) -- Using {Process.GetCurrentProcess().PrivateMemorySize64 / 1024L / 1024L} MB RAM");
	}

	internal static void WriteJsonOutput(LdapWrapper wrapper)
	{
		if (!(wrapper is Computer json))
		{
			if (!(wrapper is Domain json2))
			{
				if (!(wrapper is GPO json3))
				{
					if (!(wrapper is SharpHound3.LdapWrappers.Group json4))
					{
						if (!(wrapper is OU json5))
						{
							if (wrapper is User json6)
							{
								_userOutput.Value.WriteObject(json6);
							}
						}
						else
						{
							_ouOutput.Value.WriteObject(json5);
						}
					}
					else
					{
						_groupOutput.Value.WriteObject(json4);
					}
				}
				else
				{
					_gpoOutput.Value.WriteObject(json3);
				}
			}
			else
			{
				_domainOutput.Value.WriteObject(json2);
			}
		}
		else
		{
			_computerOutput.Value.WriteObject(json);
		}
		_currentCount++;
	}

	internal static async Task CompleteOutput()
	{
		PrintStatus();
		Console.WriteLine($"Enumeration finished in {_runTimer.Elapsed}");
		if (Options.Instance.DumpComputerStatus)
		{
			CompleteComputerStatusOutput();
			await _computerStatusTask;
		}
		string domainName = Helpers.NormalizeDomainName(Options.Instance.Domain);
		string forestName = Helpers.GetForestName(domainName).ToUpper();
		Dictionary<string, SearchResultEntry> dcSids = BaseProducer.GetDomainControllers();
		string domainSid = new SecurityIdentifier(Enumerable.First(dcSids).Key).AccountDomainSid!.Value.ToUpper();
		SharpHound3.LdapWrappers.Group enterpriseDomainControllers = new SharpHound3.LdapWrappers.Group(null)
		{
			ObjectIdentifier = forestName + "-S-1-5-9",
			Domain = forestName,
			Members = Enumerable.ToArray(Enumerable.Select(BaseProducer.GetDomainControllers().Keys, (string sid) => new GenericMember
			{
				MemberId = sid,
				MemberType = LdapTypeEnum.Computer
			}))
		};
		enterpriseDomainControllers.Properties.Add("name", "ENTERPRISE DOMAIN CONTROLLERS@" + forestName);
		enterpriseDomainControllers.Properties.Add("domain", forestName);
		_groupOutput.Value.WriteObject(enterpriseDomainControllers);
		GenericMember[] members = new GenericMember[2]
		{
			new GenericMember
			{
				MemberType = LdapTypeEnum.Group,
				MemberId = domainSid + "-515"
			},
			new GenericMember
			{
				MemberType = LdapTypeEnum.Group,
				MemberId = domainSid + "-513"
			}
		};
		SharpHound3.LdapWrappers.Group everyone = new SharpHound3.LdapWrappers.Group(null)
		{
			ObjectIdentifier = domainName + "-S-1-1-0",
			Domain = domainName,
			Members = members
		};
		everyone.Properties.Add("name", "EVERYONE@" + domainName);
		everyone.Properties.Add("domain", domainName);
		_groupOutput.Value.WriteObject(everyone);
		SharpHound3.LdapWrappers.Group authUsers = new SharpHound3.LdapWrappers.Group(null)
		{
			ObjectIdentifier = domainName + "-S-1-5-11",
			Domain = domainName,
			Members = members
		};
		authUsers.Properties.Add("name", "AUTHENTICATED USERS@" + domainName);
		authUsers.Properties.Add("domain", domainName);
		_groupOutput.Value.WriteObject(authUsers);
		foreach (KeyValuePair<string, string> seen in SeenCommonPrincipals)
		{
			string domain = seen.Key;
			string sid3 = seen.Value;
			CommonPrincipal.GetCommonSid(sid3, out var principal);
			sid3 = Helpers.ConvertCommonSid(sid3, domain);
			switch (principal.Type)
			{
			case LdapTypeEnum.User:
			{
				User u = new User(null)
				{
					ObjectIdentifier = sid3
				};
				u.Properties.Add("name", (principal.Name + "@" + domain).ToUpper());
				u.Properties.Add("domain", domain);
				_userOutput.Value.WriteObject(u);
				break;
			}
			case LdapTypeEnum.Computer:
			{
				Computer c = new Computer(null)
				{
					ObjectIdentifier = sid3
				};
				c.Properties.Add("name", (principal.Name + "@" + domain).ToUpper());
				c.Properties.Add("domain", domain);
				_computerOutput.Value.WriteObject(c);
				break;
			}
			case LdapTypeEnum.Group:
			{
				SharpHound3.LdapWrappers.Group g = new SharpHound3.LdapWrappers.Group(null)
				{
					ObjectIdentifier = sid3
				};
				g.Properties.Add("name", (principal.Name + "@" + domain).ToUpper());
				g.Properties.Add("domain", domain);
				_groupOutput.Value.WriteObject(g);
				break;
			}
			default:
				throw new ArgumentOutOfRangeException();
			}
			principal = null;
		}
		_runTimer.Stop();
		_statusTimer.Stop();
		if (_userOutput.IsValueCreated)
		{
			_userOutput.Value.CloseWriter();
		}
		if (_computerOutput.IsValueCreated)
		{
			_computerOutput.Value.CloseWriter();
		}
		if (_groupOutput.IsValueCreated)
		{
			_groupOutput.Value.CloseWriter();
		}
		if (_domainOutput.IsValueCreated)
		{
			_domainOutput.Value.CloseWriter();
		}
		if (_gpoOutput.IsValueCreated)
		{
			_gpoOutput.Value.CloseWriter();
		}
		if (_ouOutput.IsValueCreated)
		{
			_ouOutput.Value.CloseWriter();
		}
		_userOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("users"), isThreadSafe: false);
		_groupOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("groups"), isThreadSafe: false);
		_computerOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("computers"), isThreadSafe: false);
		_domainOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("domains"), isThreadSafe: false);
		_gpoOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("gpos"), isThreadSafe: false);
		_ouOutput = new Lazy<JsonFileWriter>(() => new JsonFileWriter("ous"), isThreadSafe: false);
		Options options = Options.Instance;
		if (options.NoZip || options.NoOutput)
		{
			return;
		}
		string finalName = ((options.ZipFilename == null) ? Helpers.ResolveFileName("BloodHound", "zip", addTimestamp: true) : Helpers.ResolveFileName(Options.Instance.ZipFilename, "zip", addTimestamp: true));
		Console.WriteLine("Compressing data to " + finalName);
		byte[] buffer = new byte[4096];
		if (File.Exists(finalName))
		{
			Console.WriteLine("Zip File already exists, randomizing filename");
			finalName = Helpers.ResolveFileName(Path.GetRandomFileName(), "zip", addTimestamp: true);
			Console.WriteLine("New filename is " + finalName);
		}
		using (ZipOutputStream zipStream = new ZipOutputStream(File.Create(finalName)))
		{
			zipStream.SetLevel(9);
			if (options.EncryptZip)
			{
				if (!options.Loop)
				{
					string password = (zipStream.Password = ZipPasswords.Value);
					Console.WriteLine("Password for Zip file is " + password + ". Unzip files manually to upload to interface");
				}
			}
			else
			{
				Console.WriteLine("You can upload this file directly to the UI");
			}
			foreach (string file in UsedFileNames)
			{
				ZipEntry entry = new ZipEntry(Path.GetFileName(file))
				{
					DateTime = DateTime.Now
				};
				zipStream.PutNextEntry(entry);
				using (FileStream fileStream = File.OpenRead(file))
				{
					int source;
					do
					{
						source = await fileStream.ReadAsync(buffer, 0, buffer.Length);
						zipStream.Write(buffer, 0, source);
					}
					while (source > 0);
				}
				File.Delete(file);
			}
			zipStream.Finish();
		}
		if (options.Loop)
		{
			ZipFileNames.Add(finalName);
		}
		UsedFileNames.Clear();
	}

	internal static async Task CollapseLoopZipFiles()
	{
		Options options = Options.Instance;
		if (options.NoOutput || options.NoZip)
		{
			return;
		}
		string finalName = Helpers.GetLoopFileName();
		Console.WriteLine("Compressing zip files to " + finalName);
		byte[] buffer = new byte[4096];
		if (File.Exists(finalName))
		{
			Console.WriteLine("Zip File already exists, randomizing filename");
			finalName = Helpers.ResolveFileName(Path.GetRandomFileName(), "zip", addTimestamp: true);
			Console.WriteLine("New filename is " + finalName);
		}
		using ZipOutputStream zipStream = new ZipOutputStream(File.Create(finalName));
		zipStream.SetLevel(0);
		if (options.EncryptZip)
		{
			string password = (zipStream.Password = ZipPasswords.Value);
			Console.WriteLine("Password for zip file is " + password + ". Unzip files manually to upload to interface");
		}
		else
		{
			Console.WriteLine("Unzip the zip file and upload the other zips to the interface");
		}
		foreach (string file in ZipFileNames)
		{
			ZipEntry entry = new ZipEntry(Path.GetFileName(file))
			{
				DateTime = DateTime.Now
			};
			zipStream.PutNextEntry(entry);
			using (FileStream fileStream = File.OpenRead(file))
			{
				int source;
				do
				{
					source = await fileStream.ReadAsync(buffer, 0, buffer.Length);
					zipStream.Write(buffer, 0, source);
				}
				while (source > 0);
			}
			File.Delete(file);
		}
		zipStream.Finish();
	}

	private static string GenerateZipPassword()
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		for (int i = 0; i < 10; i++)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
		}
		return stringBuilder.ToString();
	}

	internal static void StartComputerStatusTask()
	{
		if (!Options.Instance.DumpComputerStatus)
		{
			_computerStatusTask = null;
			return;
		}
		_computerStatusTask = Task.Factory.StartNew(delegate
		{
			string text = Helpers.ResolveFileName("computerstatus", "csv", addTimestamp: true);
			UsedFileNames.Add(text);
			int num = 0;
			using StreamWriter streamWriter = new StreamWriter(text, append: false);
			streamWriter.WriteLine("ComputerName, Task, Status");
			foreach (ComputerStatus item in ComputerStatusQueue.GetConsumingEnumerable())
			{
				streamWriter.WriteLine(item.ToCsv());
				num++;
				if (num % 100 == 0)
				{
					streamWriter.Flush();
				}
			}
			streamWriter.Flush();
		}, TaskCreationOptions.LongRunning);
	}

	internal static void AddComputerStatus(ComputerStatus status)
	{
		ComputerStatusQueue.Add(status);
		string key = status.Task + "-" + Regex.Replace(status.Status, "\\t|\\n|\\r", "");
		ComputerStatusCount.AddOrUpdate(key, 1, (string id, int count) => count + 1);
	}

	private static void CompleteComputerStatusOutput()
	{
		ComputerStatusQueue.CompleteAdding();
		Console.WriteLine();
		Console.WriteLine("-------Computer Status Count-------");
		foreach (KeyValuePair<string, int> item in ComputerStatusCount)
		{
			Console.WriteLine($"{item.Key}: {item.Value}");
		}
		Console.WriteLine("-----------------------------------");
	}
}
