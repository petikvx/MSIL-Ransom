using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.DirectoryServices.Protocols;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using DnsClient;
using DnsClient.Protocol;
using SharpHound3.Enums;
using SharpHound3.Tasks;

namespace SharpHound3;

internal class Helpers
{
	private struct WorkstationInfo100
	{
		public int platform_id;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string computer_name;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string lan_group;

		public int ver_major;

		public int ver_minor;
	}

	[Flags]
	private enum DSGETDCNAME_FLAGS : uint
	{
		DS_FORCE_REDISCOVERY = 1u,
		DS_DIRECTORY_SERVICE_REQUIRED = 0x10u,
		DS_DIRECTORY_SERVICE_PREFERRED = 0x20u,
		DS_GC_SERVER_REQUIRED = 0x40u,
		DS_PDC_REQUIRED = 0x80u,
		DS_BACKGROUND_ONLY = 0x100u,
		DS_IP_REQUIRED = 0x200u,
		DS_KDC_REQUIRED = 0x400u,
		DS_TIMESERV_REQUIRED = 0x800u,
		DS_WRITABLE_REQUIRED = 0x1000u,
		DS_GOOD_TIMESERV_PREFERRED = 0x2000u,
		DS_AVOID_SELF = 0x4000u,
		DS_ONLY_LDAP_NEEDED = 0x8000u,
		DS_IS_FLAT_NAME = 0x10000u,
		DS_IS_DNS_NAME = 0x20000u,
		DS_RETURN_DNS_NAME = 0x40000000u,
		DS_RETURN_FLAT_NAME = 0x80000000u
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	private struct DOMAIN_CONTROLLER_INFO
	{
		[MarshalAs(UnmanagedType.LPTStr)]
		public string DomainControllerName;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string DomainControllerAddress;

		public uint DomainControllerAddressType;

		public Guid DomainGuid;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string DomainName;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string DnsForestName;

		public uint Flags;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string DcSiteName;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string ClientSiteName;
	}

	private enum EXTENDED_NAME_FORMAT
	{
		NameUnknown = 0,
		NameFullyQualifiedDN = 1,
		NameSamCompatible = 2,
		NameDisplay = 3,
		NameUniqueId = 6,
		NameCanonical = 7,
		NameUserPrincipal = 8,
		NameCanonicalEx = 9,
		NameServicePrincipal = 10,
		NameDnsDomain = 12
	}

	private enum SID_NAME_USE
	{
		SidTypeUser = 1,
		SidTypeGroup,
		SidTypeDomain,
		SidTypeAlias,
		SidTypeWellKnownGroup,
		SidTypeDeletedAccount,
		SidTypeInvalid,
		SidTypeUnknown,
		SidTypeComputer
	}

	private const string NullKey = "NULLDOMAIN";

	private static readonly HashSet<string> Groups = new HashSet<string> { "268435456", "268435457", "536870912", "536870913" };

	private static readonly HashSet<string> Computers = new HashSet<string> { "805306369" };

	private static readonly HashSet<string> Users = new HashSet<string> { "805306368" };

	private static readonly ConcurrentDictionary<string, DirectorySearch> DirectorySearchMap = new ConcurrentDictionary<string, DirectorySearch>();

	private static readonly ConcurrentDictionary<string, LookupClient> DNSResolverCache = new ConcurrentDictionary<string, LookupClient>();

	private static readonly ConcurrentDictionary<string, bool> PingCache = new ConcurrentDictionary<string, bool>();

	private static readonly Random RandomGen = new Random();

	private static readonly CancellationTokenSource CancellationTokenSource = new CancellationTokenSource();

	private static readonly Regex DCReplaceRegex = new Regex("DC=", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	internal static readonly string[] ResolutionProps = new string[6] { "samaccounttype", "objectsid", "objectguid", "objectclass", "samaccountname", "msds-groupmsamembership" };

	private static readonly Regex SPNRegex = new Regex(".*\\/.*", RegexOptions.Compiled);

	private static readonly string ProcStartTime = $"{DateTime.Now:yyyyMMddHHmmss}";

	private static string _currentLoopTime = $"{DateTime.Now:yyyyMMddHHmmss}";

	internal static CancellationToken GetCancellationToken()
	{
		return CancellationTokenSource.Token;
	}

	internal static void InvokeCancellation()
	{
		CancellationTokenSource.Cancel();
	}

	internal static void StartNewRun()
	{
		PingCache.Clear();
		_currentLoopTime = $"{DateTime.Now:yyyyMMddHHmmss}";
	}

	internal static string ConvertSidToHexSid(string sid)
	{
		SecurityIdentifier securityIdentifier = new SecurityIdentifier(sid);
		byte[] array = new byte[securityIdentifier.BinaryLength];
		securityIdentifier.GetBinaryForm(array, 0);
		return "\\" + BitConverter.ToString(array).Replace('-', '\\');
	}

	internal static string DistinguishedNameToDomain(string distinguishedName)
	{
		string input = distinguishedName.Substring(distinguishedName.IndexOf("DC=", StringComparison.CurrentCultureIgnoreCase));
		return DCReplaceRegex.Replace(input, "").Replace(",", ".").ToUpper();
	}

	internal static SecurityIdentifier CreateSecurityIdentifier(byte[] sid)
	{
		try
		{
			return new SecurityIdentifier(sid, 0);
		}
		catch (ArgumentException ex)
		{
			Console.WriteLine(ex.ToString());
			Console.WriteLine($"Failed to create SID from {sid}. Please report this to the developer");
			return null;
		}
	}

	internal static string GetForestName(string domain = null)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Expected O, but got Unknown
		try
		{
			if (domain == null)
			{
				return Forest.GetCurrentForest().get_Name();
			}
			Domain domain2 = Domain.GetDomain(new DirectoryContext((DirectoryContextType)0, domain));
			return domain2.get_Forest().get_Name();
		}
		catch
		{
			return domain;
		}
	}

	internal static LdapTypeEnum SamAccountTypeToType(string samAccountType)
	{
		if (Groups.Contains(samAccountType))
		{
			return LdapTypeEnum.Group;
		}
		if (Users.Contains(samAccountType))
		{
			return LdapTypeEnum.User;
		}
		if (Computers.Contains(samAccountType))
		{
			return LdapTypeEnum.Computer;
		}
		return LdapTypeEnum.Unknown;
	}

	internal static DirectorySearch GetDirectorySearcher(string domain)
	{
		string text = NormalizeDomainName(domain) ?? "NULLDOMAIN";
		if (DirectorySearchMap.TryGetValue(text, out var value))
		{
			return value;
		}
		value = new DirectorySearch(text);
		DirectorySearchMap.TryAdd(text, value);
		return value;
	}

	internal static string StripSPN(string target)
	{
		return SPNRegex.IsMatch(target) ? target.Split(new char[1] { '/' })[1].Split(new char[1] { ':' })[0] : target;
	}

	internal static string ConvertCommonSid(string sid, string domain)
	{
		if (CommonPrincipal.GetCommonSid(sid, out var _))
		{
			if (sid == "S-1-5-9")
			{
				string forestName = GetForestName(domain);
				return (forestName + "-" + sid).ToUpper();
			}
			string text = NormalizeDomainName(domain);
			if (sid != "S-1-1-0" && sid != "S-1-5-11")
			{
				OutputTasks.SeenCommonPrincipals.TryAdd(text, sid);
			}
			return text + "-" + sid;
		}
		return sid;
	}

	internal static LookupClient GetDNSResolver(string domain)
	{
		string text = NormalizeDomainName(domain);
		string key = text ?? "NULLDOMAIN";
		if (DNSResolverCache.TryGetValue(key, out var value))
		{
			return value;
		}
		value = new LookupClient();
		List<IPEndPoint> list = new List<IPEndPoint>();
		string text2 = FindDomainDNSServer(text);
		if (text2 != null)
		{
			IDnsQueryResponse dnsQueryResponse = value.Query(text2, QueryType.A);
			IPAddress iPAddress = Enumerable.FirstOrDefault(Enumerable.DefaultIfEmpty(dnsQueryResponse.Answers.ARecords(), null), (ARecord record) => record.Address.AddressFamily == AddressFamily.InterNetwork)?.Address;
			if (iPAddress != null)
			{
				list.Add(new IPEndPoint(iPAddress, 53));
			}
		}
		list.AddRange(Enumerable.Select(value.NameServers, (NameServer server) => server.Endpoint));
		value = new LookupClient(list.ToArray());
		DNSResolverCache.TryAdd(key, value);
		return value;
	}

	private static string FindDomainDNSServer(string domain)
	{
		DirectorySearch directorySearcher = GetDirectorySearcher(domain);
		domain = NormalizeDomainName(domain);
		string text = null;
		foreach (SearchResultEntry item in directorySearcher.QueryLdap("(&(objectclass=computer)(userAccountControl:1.2.840.113556.1.4.803:=8192))", new string[2] { "samaccountname", "dnshostname" }, (SearchScope)2))
		{
			text = item.GetProperty("dnshostname") ?? item.GetProperty("samaccountname");
			if (text != null)
			{
				text = text + "." + domain;
				if (CheckHostPort(text, 53))
				{
					break;
				}
				text = null;
			}
		}
		return text;
	}

	internal static async Task DoDelay()
	{
		Options opts = Options.Instance;
		if (opts.Throttle != 0)
		{
			if (opts.Jitter == 0)
			{
				await Task.Delay(opts.Throttle);
				return;
			}
			int percent = (int)Math.Floor((double)(opts.Jitter * (opts.Throttle / 100)));
			int delay = opts.Throttle + RandomGen.Next(-percent, percent);
			await Task.Delay(delay);
		}
	}

	internal static bool CheckPort(string hostname, int port)
	{
		if (Options.Instance.SkipPortScan)
		{
			return true;
		}
		string key = $"{hostname}-{port}".ToUpper();
		if (PingCache.TryGetValue(key, out var value))
		{
			return value;
		}
		value = CheckHostPort(hostname, port);
		PingCache.TryAdd(key, value);
		return value;
	}

	private static bool CheckHostPort(string hostname, int port)
	{
		using TcpClient tcpClient = new TcpClient();
		try
		{
			IAsyncResult asyncResult = tcpClient.BeginConnect(hostname, port, null, null);
			if (!asyncResult.AsyncWaitHandle.WaitOne(Options.Instance.PortScanTimeout))
			{
				return false;
			}
			tcpClient.EndConnect(asyncResult);
		}
		catch
		{
			return false;
		}
		return true;
	}

	internal static string NormalizeDomainName(string domain)
	{
		string text = domain;
		if (text.Contains("."))
		{
			return domain.ToUpper();
		}
		text = ResolutionHelpers.ResolveDomainNetbiosToDns(domain) ?? domain;
		return text.ToUpper();
	}

	internal static string GetLoopFileName()
	{
		Options instance = Options.Instance;
		string text = ((instance.ZipFilename == null) ? "BloodHoundLoopResults.zip" : (instance.ZipFilename + ".zip"));
		if (instance.RandomizeFilenames)
		{
			text = Path.GetRandomFileName() + ".zip";
		}
		text = ProcStartTime + "_" + text;
		if (instance.OutputPrefix != null)
		{
			text = instance.OutputPrefix + "_" + text;
		}
		return Path.Combine(instance.OutputDirectory, text);
	}

	internal static string ResolveFileName(string filename, string extension, bool addTimestamp)
	{
		string text = filename;
		if (!filename.EndsWith(extension))
		{
			text = filename + "." + extension;
		}
		if ((extension == "json" || extension == "zip") && Options.Instance.RandomizeFilenames)
		{
			text = Path.GetRandomFileName() ?? "";
		}
		if (addTimestamp)
		{
			text = _currentLoopTime + "_" + text;
		}
		if (Options.Instance.OutputPrefix != null)
		{
			text = Options.Instance.OutputPrefix + "_" + text;
		}
		return Path.Combine(Options.Instance.OutputDirectory, text);
	}

	internal static string Base64(string input)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(input);
		return Convert.ToBase64String(bytes);
	}

	[DllImport("netapi32.dll", SetLastError = true)]
	private static extern int NetWkstaGetInfo([MarshalAs(UnmanagedType.LPWStr)] string serverName, uint level, out IntPtr bufPtr);

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr Buffer);

	[DllImport("Netapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int DsGetDcName([MarshalAs(UnmanagedType.LPTStr)] string ComputerName, [MarshalAs(UnmanagedType.LPTStr)] string DomainName, [In] int DomainGuid, [MarshalAs(UnmanagedType.LPTStr)] string SiteName, [MarshalAs(UnmanagedType.U4)] DSGETDCNAME_FLAGS flags, out IntPtr pDOMAIN_CONTROLLER_INFO);

	[DllImport("secur32.dll", SetLastError = true)]
	private static extern int TranslateName(string accountName, EXTENDED_NAME_FORMAT accountNameFormat, EXTENDED_NAME_FORMAT desiredFormat, StringBuilder translatedName, ref int userNameSize);

	[DllImport("advapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern bool LookupAccountSid(string lpSystemName, [MarshalAs(UnmanagedType.LPArray)] byte[] Sid, StringBuilder lpName, ref uint cchName, StringBuilder ReferencedDomainName, ref uint cchReferencedDomainName, out SID_NAME_USE peUse);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool LookupAccountName(string systemName, string accountName, [MarshalAs(UnmanagedType.LPArray)] byte[] Sid, ref uint sidLength, StringBuilder domainName, ref uint domainNameLength, out SID_NAME_USE type);
}
