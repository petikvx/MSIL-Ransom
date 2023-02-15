using System;
using System.Collections.Concurrent;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using DnsClient;
using SharpHound3.Enums;

namespace SharpHound3;

internal class ResolutionHelpers
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

	[StructLayout(LayoutKind.Sequential)]
	public class GuidClass
	{
		public Guid TheGuid;
	}

	[Flags]
	public enum DSGETDCNAME_FLAGS : uint
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

	private static readonly ConcurrentDictionary<string, string> SidToDomainNameCache = new ConcurrentDictionary<string, string>();

	private static readonly ConcurrentDictionary<string, string> NetbiosDomainNameCache = new ConcurrentDictionary<string, string>();

	private static readonly ConcurrentDictionary<string, string> DomainControllerCache = new ConcurrentDictionary<string, string>();

	private static readonly ConcurrentDictionary<string, string> HostResolutionMap = new ConcurrentDictionary<string, string>();

	private static readonly string[] GroupMembershipLookupProps = new string[3] { "samaccounttype", "objectsid", "objectclass" };

	private static readonly string[] OUGuidLookupProps = new string[1] { "objectguid" };

	private static readonly string[] ResolutionProps = new string[6] { "samaccounttype", "objectsid", "objectguid", "objectclass", "samaccountname", "msds-groupmsamembership" };

	private static readonly byte[] NameRequest = new byte[50]
	{
		128, 148, 0, 0, 0, 1, 0, 0, 0, 0,
		0, 0, 32, 67, 75, 65, 65, 65, 65, 65,
		65, 65, 65, 65, 65, 65, 65, 65, 65, 65,
		65, 65, 65, 65, 65, 65, 65, 65, 65, 65,
		65, 65, 65, 65, 65, 0, 0, 33, 0, 1
	};

	internal static async Task<string> ResolveHostToSid(string hostname, string domain)
	{
		string normalizedHostname = Helpers.StripSPN(hostname).ToUpper().TrimEnd(new char[1] { '$' });
		if (HostResolutionMap.TryGetValue(normalizedHostname, out var resolvedHost))
		{
			return resolvedHost;
		}
		string normalizedDomain = Helpers.NormalizeDomainName(domain);
		string tempName6 = null;
		string tempDomain4 = null;
		if (!IPAddress.TryParse(normalizedHostname, out var _))
		{
			if (normalizedHostname.Contains("."))
			{
				string[] splitName2 = normalizedHostname.Split(new char[1] { '.' });
				tempName6 = splitName2[0];
				tempDomain4 = string.Join(".", Enumerable.Skip(splitName2, 1));
			}
			else
			{
				tempName6 = normalizedHostname;
				tempDomain4 = normalizedDomain;
			}
			tempName6 = (tempName6 + "$").ToUpper();
			var (success4, sid4, _) = await ResolveAccountNameToSidAndType(tempName6, tempDomain4);
			if (success4)
			{
				HostResolutionMap.TryAdd(normalizedHostname, sid4);
				return sid4;
			}
		}
		var (wkstaSuccess, workstationInfo) = await CallNetWkstaGetInfo(normalizedHostname);
		if (wkstaSuccess)
		{
			tempName6 = workstationInfo.computer_name;
			tempDomain4 = workstationInfo.lan_group;
			if (string.IsNullOrEmpty(tempDomain4))
			{
				tempDomain4 = normalizedDomain;
			}
			if (!string.IsNullOrEmpty(tempName6))
			{
				tempName6 = (tempName6 + "$").ToUpper();
				var (success3, sid3, _) = await ResolveAccountNameToSidAndType(tempName6, tempDomain4);
				if (success3)
				{
					HostResolutionMap.TryAdd(normalizedHostname, sid3);
					return sid3;
				}
			}
		}
		if (RequestNetbiosNameFromComputer(normalizedHostname, normalizedDomain, out tempName6))
		{
			tempDomain4 = tempDomain4 ?? normalizedDomain;
			tempName6 = (tempName6 + "$").ToUpper();
			var (success2, sid2, _) = await ResolveAccountNameToSidAndType(tempName6, tempDomain4);
			if (success2)
			{
				HostResolutionMap.TryAdd(normalizedHostname, sid2);
				return sid2;
			}
		}
		LookupClient resolver = Helpers.GetDNSResolver(normalizedDomain);
		string resolvedHostName;
		try
		{
			resolvedHostName = (await resolver.GetHostEntryAsync(normalizedHostname))?.HostName;
		}
		catch
		{
			resolvedHostName = null;
		}
		if (resolvedHostName != null)
		{
			string[] splitName = resolvedHostName.Split(new char[1] { '.' });
			tempName6 = (splitName[0] + "$").ToUpper();
			tempDomain4 = string.Join(".", Enumerable.Skip(splitName, 1));
			var (success, sid, _) = await ResolveAccountNameToSidAndType(tempName6, normalizedDomain);
			if (!success)
			{
				(success, sid, _) = await ResolveAccountNameToSidAndType(tempName6, tempDomain4);
			}
			if (success)
			{
				HostResolutionMap.TryAdd(normalizedHostname, sid);
				return sid;
			}
		}
		tempName6 = normalizedHostname;
		tempDomain4 = normalizedDomain;
		if (tempName6.Contains("."))
		{
			HostResolutionMap.TryAdd(normalizedHostname, tempName6);
			return tempName6;
		}
		tempName6 = tempName6 + "." + tempDomain4;
		HostResolutionMap.TryAdd(normalizedHostname, tempName6);
		return tempName6;
	}

	internal static string ResolveDomainNetbiosToDns(string domainName)
	{
		string key = domainName.ToUpper();
		if (NetbiosDomainNameCache.TryGetValue(key, out var value))
		{
			return value;
		}
		string computerName = Options.Instance.DomainController ?? GetDomainControllerForDomain(domainName);
		IntPtr pDOMAIN_CONTROLLER_INFO;
		int num = DsGetDcName(computerName, domainName, null, null, 1073807360u, out pDOMAIN_CONTROLLER_INFO);
		try
		{
			if (num == 0)
			{
				value = Marshal.PtrToStructure<DOMAIN_CONTROLLER_INFO>(pDOMAIN_CONTROLLER_INFO)!.DomainName;
			}
		}
		finally
		{
			if (pDOMAIN_CONTROLLER_INFO != IntPtr.Zero)
			{
				NetApiBufferFree(pDOMAIN_CONTROLLER_INFO);
			}
		}
		NetbiosDomainNameCache.TryAdd(key, value);
		return value;
	}

	private static string GetDomainControllerForDomain(string domainName)
	{
		string key = domainName.ToUpper();
		if (DomainControllerCache.TryGetValue(key, out var value))
		{
			return value;
		}
		IntPtr pDOMAIN_CONTROLLER_INFO;
		int num = DsGetDcName(null, domainName, null, null, 32u, out pDOMAIN_CONTROLLER_INFO);
		try
		{
			if (num == 0)
			{
				value = Marshal.PtrToStructure<DOMAIN_CONTROLLER_INFO>(pDOMAIN_CONTROLLER_INFO)!.DomainControllerName;
			}
		}
		finally
		{
			if (pDOMAIN_CONTROLLER_INFO != IntPtr.Zero)
			{
				NetApiBufferFree(pDOMAIN_CONTROLLER_INFO);
			}
		}
		DomainControllerCache.TryAdd(key, value);
		return value;
	}

	internal static async Task<(bool success, string sid, LdapTypeEnum type)> ResolveAccountNameToSidAndType(string accountName, string accountDomain)
	{
		string domain = Helpers.NormalizeDomainName(accountDomain);
		if (domain.Contains(" "))
		{
			return (false, null, LdapTypeEnum.Unknown);
		}
		UserDomainKey key = new UserDomainKey
		{
			AccountDomain = domain,
			AccountName = accountName
		};
		if (Cache.Instance.GetResolvedAccount(key, out var principal))
		{
			return (principal.ObjectIdentifier != null, principal.ObjectIdentifier, principal.ObjectType);
		}
		DirectorySearch searcher = Helpers.GetDirectorySearcher(domain);
		SearchResultEntry result = await searcher.GetOne("(samaccountname=" + accountName + ")", ResolutionProps, (SearchScope)2);
		if (result == null)
		{
			Cache.Instance.Add(key, new ResolvedPrincipal
			{
				ObjectIdentifier = null,
				ObjectType = LdapTypeEnum.Unknown
			});
			return (false, null, LdapTypeEnum.Unknown);
		}
		string sid = result.GetSid();
		LdapTypeEnum type = result.GetLdapType();
		Cache.Instance.Add(key, new ResolvedPrincipal
		{
			ObjectIdentifier = sid,
			ObjectType = type
		});
		return (sid != null, sid, type);
	}

	internal static async Task<(bool success, string guid)> OUDistinguishedNameToGuid(string distinguishedName)
	{
		if (Cache.Instance.GetResolvedDistinguishedName(distinguishedName, out var resolved))
		{
			return (resolved.ObjectIdentifier != null, resolved.ObjectIdentifier);
		}
		string domain = Helpers.DistinguishedNameToDomain(distinguishedName);
		DirectorySearch searcher = Helpers.GetDirectorySearcher(domain);
		byte[] guidBytes = (await searcher.GetOne("(objectclass=*)", OUGuidLookupProps, (SearchScope)0, distinguishedName))?.GetPropertyAsBytes("objectguid");
		if (guidBytes == null)
		{
			Cache.Instance.Add(distinguishedName, new ResolvedPrincipal
			{
				ObjectIdentifier = null,
				ObjectType = LdapTypeEnum.OU
			});
			return (false, null);
		}
		string guid = new Guid(guidBytes).ToString().ToUpper();
		return (true, guid);
	}

	internal static async Task<(string sid, LdapTypeEnum type)> ResolveDistinguishedName(string distinguishedName)
	{
		if (Cache.Instance.GetResolvedDistinguishedName(distinguishedName, out var resolved))
		{
			return (resolved.ObjectIdentifier, resolved.ObjectType);
		}
		string domain = Helpers.DistinguishedNameToDomain(distinguishedName);
		if (distinguishedName.Contains("ForeignSecurityPrincipals"))
		{
			string sid = distinguishedName.Split(new char[1] { ',' })[0].Substring(3);
			if (!sid.Contains("S-1-5"))
			{
				return (null, LdapTypeEnum.Unknown);
			}
			var (finalSid, type) = await ResolveSidAndGetType(sid, domain);
			Cache.Instance.Add(distinguishedName, new ResolvedPrincipal
			{
				ObjectIdentifier = finalSid,
				ObjectType = type
			});
			return (finalSid, type);
		}
		var (resolvedSid, resolvedType) = await ResolveDistinguishedNameLdap(distinguishedName);
		Cache.Instance.Add(distinguishedName, new ResolvedPrincipal
		{
			ObjectIdentifier = resolvedSid,
			ObjectType = resolvedType
		});
		return (resolvedSid, resolvedType);
	}

	private static async Task<(string sid, LdapTypeEnum type)> ResolveDistinguishedNameLdap(string distinguishedName)
	{
		string domain = Helpers.DistinguishedNameToDomain(distinguishedName);
		DirectorySearch searcher = Helpers.GetDirectorySearcher(domain);
		SearchResultEntry result = await searcher.GetOne("(objectclass=*)", GroupMembershipLookupProps, (SearchScope)0, distinguishedName);
		if (result == null)
		{
			return (null, LdapTypeEnum.Unknown);
		}
		string sid = result.GetSid();
		LdapTypeEnum type = result.GetLdapType();
		return (sid, type);
	}

	internal static async Task<(string finalSid, LdapTypeEnum type)> ResolveSidAndGetType(string sid, string domain)
	{
		if (sid.Contains("0ACNF"))
		{
			return (null, LdapTypeEnum.Unknown);
		}
		if (CommonPrincipal.GetCommonSid(sid, out var commonPrincipal))
		{
			string newSid = Helpers.ConvertCommonSid(sid, domain);
			return (newSid, commonPrincipal.Type);
		}
		if (Cache.Instance.GetSidType(sid, out var type2))
		{
			return (sid, type2);
		}
		type2 = await LookupSidType(sid, domain);
		Cache.Instance.Add(sid, type2);
		return (sid, type2);
	}

	internal static async Task<LdapTypeEnum> LookupSidType(string sid, string domain)
	{
		string hexSid = ConvertSidToHexSid(sid);
		if (hexSid == null)
		{
			return LdapTypeEnum.Unknown;
		}
		string resolvedDomain = (await GetDomainNameFromSid(sid)) ?? domain;
		DirectorySearch searcher = Helpers.GetDirectorySearcher(resolvedDomain);
		return (await searcher.GetOne("(objectsid=" + hexSid + ")", ResolutionProps, (SearchScope)2))?.GetLdapType() ?? LdapTypeEnum.Unknown;
	}

	private static string ConvertSidToHexSid(string sid)
	{
		try
		{
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(sid);
			byte[] array = new byte[securityIdentifier.BinaryLength];
			securityIdentifier.GetBinaryForm(array, 0);
			return "\\" + BitConverter.ToString(array).Replace('-', '\\');
		}
		catch
		{
			return null;
		}
	}

	private static async Task<string> GetDomainNameFromSid(string sid)
	{
		try
		{
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(sid);
			string domainSid = securityIdentifier.AccountDomainSid?.Value.ToUpper();
			if (domainSid == null)
			{
				return null;
			}
			if (SidToDomainNameCache.TryGetValue(domainSid, out var domainName))
			{
				return domainName;
			}
			string domain = await GetDomainNameFromSidLdap(domainSid);
			SidToDomainNameCache.TryAdd(domainSid, domain);
			return domain;
		}
		catch
		{
			return null;
		}
	}

	private static async Task<string> GetDomainNameFromSidLdap(string sid)
	{
		DirectorySearch searcher = Helpers.GetDirectorySearcher(Options.Instance.Domain);
		string hexSid = ConvertSidToHexSid(sid);
		if (hexSid == null)
		{
			return null;
		}
		SearchResultEntry result = await searcher.GetOne("(&(objectclass=domain)(objectsid=" + hexSid + "))", new string[1] { "distinguishedname" }, (SearchScope)2, null, globalCatalog: true);
		if (result != null)
		{
			return Helpers.DistinguishedNameToDomain(result.get_DistinguishedName());
		}
		return (await searcher.GetOne("(&(objectclass=trusteddomain)(securityidentifier=" + sid + "))", new string[1] { "cn" }, (SearchScope)2, null, globalCatalog: true))?.GetProperty("cn");
	}

	private static async Task<(bool success, WorkstationInfo100 info)> CallNetWkstaGetInfo(string hostname)
	{
		if (!Helpers.CheckPort(hostname, 445))
		{
			return (false, default(WorkstationInfo100));
		}
		IntPtr wkstaData = IntPtr.Zero;
		Task<int> netWkstaTask = Task.Run(() => NetWkstaGetInfo(hostname, 100u, out wkstaData));
		if (await Task.WhenAny(new Task[2]
		{
			Task.Delay(5000),
			netWkstaTask
		}) != netWkstaTask)
		{
			return (false, default(WorkstationInfo100));
		}
		if (netWkstaTask.Result == 0)
		{
			try
			{
				WorkstationInfo100 wkstaInfo = Marshal.PtrToStructure<WorkstationInfo100>(wkstaData);
				return (true, wkstaInfo);
			}
			finally
			{
				if (wkstaData != IntPtr.Zero)
				{
					NetApiBufferFree(wkstaData);
				}
			}
		}
		return (false, default(WorkstationInfo100));
	}

	private static bool RequestNetbiosNameFromComputer(string server, string domain, out string netbios)
	{
		byte[] array = new byte[1024];
		Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
		try
		{
			socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReceiveTimeout, 1000);
			EndPoint remoteEP;
			if (IPAddress.TryParse(server, out var address))
			{
				remoteEP = new IPEndPoint(address, 137);
			}
			else
			{
				try
				{
					IPAddress iPAddress;
					if (server.Contains("."))
					{
						iPAddress = Enumerable.First(Dns.GetHostAddresses(server), (IPAddress x) => x.AddressFamily == AddressFamily.InterNetwork);
					}
					else
					{
						string text = Options.Instance.RealDNSName ?? domain;
						iPAddress = Dns.GetHostAddresses(server + "." + text)[0];
					}
					if (iPAddress == null)
					{
						netbios = null;
						return false;
					}
					remoteEP = new IPEndPoint(iPAddress, 137);
				}
				catch
				{
					netbios = null;
					return false;
				}
			}
			IPEndPoint localEP = new IPEndPoint(IPAddress.Any, 0);
			socket.Bind(localEP);
			try
			{
				socket.SendTo(NameRequest, remoteEP);
				int num = socket.ReceiveFrom(array, ref remoteEP);
				if (num >= 90)
				{
					netbios = new ASCIIEncoding().GetString(array, 57, 16).Trim('\0', ' ');
					return true;
				}
				netbios = null;
				return false;
			}
			catch (SocketException)
			{
				netbios = null;
				return false;
			}
		}
		finally
		{
			socket.Close();
		}
	}

	[DllImport("netapi32.dll", SetLastError = true)]
	private static extern int NetWkstaGetInfo([MarshalAs(UnmanagedType.LPWStr)] string serverName, uint level, out IntPtr bufPtr);

	[DllImport("Netapi32.dll", SetLastError = true)]
	private static extern int NetApiBufferFree(IntPtr Buffer);

	[DllImport("Netapi32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int DsGetDcName([MarshalAs(UnmanagedType.LPTStr)] string ComputerName, [MarshalAs(UnmanagedType.LPTStr)] string DomainName, [In] GuidClass DomainGuid, [MarshalAs(UnmanagedType.LPTStr)] string SiteName, uint Flags, out IntPtr pDOMAIN_CONTROLLER_INFO);
}
