using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.Protocols;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading.Tasks;
using SharpHound3.Enums;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;

namespace SharpHound3.Tasks;

internal class ObjectPropertyTasks
{
	[Flags]
	private enum IsTextUnicodeFlags
	{
		IS_TEXT_UNICODE_ASCII16 = 1,
		IS_TEXT_UNICODE_REVERSE_ASCII16 = 0x10,
		IS_TEXT_UNICODE_STATISTICS = 2,
		IS_TEXT_UNICODE_REVERSE_STATISTICS = 0x20,
		IS_TEXT_UNICODE_CONTROLS = 4,
		IS_TEXT_UNICODE_REVERSE_CONTROLS = 0x40,
		IS_TEXT_UNICODE_SIGNATURE = 8,
		IS_TEXT_UNICODE_REVERSE_SIGNATURE = 0x80,
		IS_TEXT_UNICODE_ILLEGAL_CHARS = 0x100,
		IS_TEXT_UNICODE_ODD_LENGTH = 0x200,
		IS_TEXT_UNICODE_DBCS_LEADBYTE = 0x400,
		IS_TEXT_UNICODE_NULL_BYTES = 0x1000,
		IS_TEXT_UNICODE_UNICODE_MASK = 0xF,
		IS_TEXT_UNICODE_REVERSE_MASK = 0xF0,
		IS_TEXT_UNICODE_NOT_UNICODE_MASK = 0xF00,
		IS_TEXT_UNICODE_NOT_ASCII_MASK = 0xF000
	}

	private static readonly DateTime WindowsEpoch = new DateTime(1970, 1, 1);

	private static readonly string[] ReservedAttributes = new string[40]
	{
		"pwdlastset", "lastlogon", "lastlogontimestamp", "objectsid", "sidhistory", "useraccountcontrol", "operatingsystem", "operatingsystemservicepack", "serviceprincipalname", "displayname",
		"mail", "title", "homedirectory", "description", "admincount", "userpassword", "gpcfilesyspath", "objectclass", "msds-behavior-version", "objectguid",
		"name", "gpoptions", "msds-allowedtodelegateto", "msDS-allowedtoactonbehalfofotheridentity", "displayname", "sidhistory", "samaccountname", "samaccounttype", "objectsid", "objectguid",
		"objectclass", "samaccountname", "msds-groupmsamembership", "distinguishedname", "memberof", "logonhours", "ntsecuritydescriptor", "dsasignature", "repluptodatevector", "member"
	};

	internal static async Task<LdapWrapper> ResolveObjectProperties(LdapWrapper wrapper)
	{
		SearchResultEntry result = wrapper.SearchResult;
		wrapper.Properties.Add("description", result.GetProperty("description"));
		if (wrapper is Domain domain)
		{
			ParseDomainProperties(domain);
		}
		else if (wrapper is Computer computer)
		{
			await ParseComputerProperties(computer);
		}
		else if (wrapper is User user)
		{
			await ParseUserProperties(user);
		}
		else if (wrapper is GPO gpo)
		{
			ParseGPOProperties(gpo);
		}
		else if (wrapper is OU ou)
		{
			ParseOUProperties(ou);
		}
		else if (wrapper is Group group)
		{
			ParseGroupProperties(group);
		}
		if (Options.Instance.CollectAllProperties)
		{
			ParseAllProperties(wrapper);
		}
		return wrapper;
	}

	private static void ParseAllProperties(LdapWrapper wrapper)
	{
		SearchResultEntry searchResult = wrapper.SearchResult;
		IsTextUnicodeFlags opt = IsTextUnicodeFlags.IS_TEXT_UNICODE_STATISTICS;
		foreach (object attributeName in searchResult.get_Attributes().get_AttributeNames())
		{
			string text = attributeName.ToString()!.ToLower();
			if (Enumerable.Contains(ReservedAttributes, text))
			{
				continue;
			}
			DirectoryAttribute val = searchResult.get_Attributes().get_Item(text);
			if (((CollectionBase)(object)val).Count == 0)
			{
				continue;
			}
			if (((CollectionBase)(object)val).Count == 1)
			{
				byte[] propertyAsBytes = searchResult.GetPropertyAsBytes(text);
				if (propertyAsBytes == null || propertyAsBytes.Length == 0 || !IsTextUnicode(propertyAsBytes, propertyAsBytes.Length, ref opt))
				{
					continue;
				}
				string property = searchResult.GetProperty(text);
				if (!string.IsNullOrEmpty(property))
				{
					if (text == "badpasswordtime")
					{
						wrapper.Properties.Add(text, ConvertToUnixEpoch(property));
					}
					else
					{
						wrapper.Properties.Add(text, BestGuessConvert(property));
					}
				}
				continue;
			}
			byte[][] propertyAsArrayOfBytes = searchResult.GetPropertyAsArrayOfBytes(text);
			if (propertyAsArrayOfBytes.Length != 0 && IsTextUnicode(propertyAsArrayOfBytes[0], propertyAsArrayOfBytes[0].Length, ref opt))
			{
				string[] propertyAsArray = searchResult.GetPropertyAsArray(text);
				if (propertyAsArray.Length != 0)
				{
					wrapper.Properties.Add(text, Enumerable.ToArray(Enumerable.Select(propertyAsArray, BestGuessConvert)));
				}
			}
		}
	}

	private static object BestGuessConvert(string property)
	{
		if (bool.TryParse(property, out var result))
		{
			return result;
		}
		if (property.EndsWith("0Z"))
		{
			return (long)DateTime.ParseExact(property, "yyyyMMddHHmmss.0K", CultureInfo.CurrentCulture).Subtract(WindowsEpoch).TotalSeconds;
		}
		if (property == "9223372036854775807")
		{
			return -1;
		}
		return property;
	}

	private static void ParseGroupProperties(LdapWrapper wrapper)
	{
		SearchResultEntry searchResult = wrapper.SearchResult;
		string property = searchResult.GetProperty("admincount");
		if (property != null)
		{
			int num = int.Parse(property);
			wrapper.Properties.Add("admincount", num != 0);
		}
		else
		{
			wrapper.Properties.Add("admincount", false);
		}
	}

	private static void ParseGPOProperties(GPO wrapper)
	{
		SearchResultEntry searchResult = wrapper.SearchResult;
		wrapper.Properties.Add("gpcpath", searchResult.GetProperty("gpcfilesyspath"));
	}

	private static void ParseOUProperties(OU wrapper)
	{
	}

	private static async Task ParseComputerProperties(Computer wrapper)
	{
		SearchResultEntry result = wrapper.SearchResult;
		string userAccountControl = result.GetProperty("useraccountcontrol");
		bool enabled = true;
		bool trustedToAuth = false;
		bool unconstrained = false;
		if (int.TryParse(userAccountControl, out var baseFlags))
		{
			UacFlags uacFlags = (UacFlags)baseFlags;
			enabled = (uacFlags & UacFlags.AccountDisable) == 0;
			trustedToAuth = (uacFlags & UacFlags.TrustedToAuthForDelegation) != 0;
			unconstrained = (uacFlags & UacFlags.TrustedForDelegation) != 0;
		}
		wrapper.Properties.Add("enabled", enabled);
		wrapper.Properties.Add("unconstraineddelegation", unconstrained);
		List<string> trustedToAuthComputers = new List<string>();
		if (trustedToAuth)
		{
			string[] delegates = result.GetPropertyAsArray("msds-AllowedToDelegateTo");
			wrapper.Properties.Add("allowedtodelegate", delegates);
			string[] array = delegates;
			foreach (string computerName in array)
			{
				trustedToAuthComputers.Add(await ResolutionHelpers.ResolveHostToSid(computerName, wrapper.Domain));
			}
		}
		wrapper.AllowedToDelegate = Enumerable.ToArray(Enumerable.Distinct(trustedToAuthComputers));
		byte[] allowedToAct = result.GetPropertyAsBytes("msDS-AllowedToActOnBehalfOfOtherIdentity");
		List<GenericMember> allowedToActPrincipals = new List<GenericMember>();
		if (allowedToAct != null)
		{
			ActiveDirectorySecurity securityDescriptor = new ActiveDirectorySecurity();
			((ObjectSecurity)(object)securityDescriptor).SetSecurityDescriptorBinaryForm(allowedToAct);
			foreach (ActiveDirectoryAccessRule accessRule in ((DirectoryObjectSecurity)(object)securityDescriptor).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier)))
			{
				ActiveDirectoryAccessRule ace = accessRule;
				string sid = ((AuthorizationRule)(object)ace).IdentityReference.Value;
				LdapTypeEnum type;
				if (CommonPrincipal.GetCommonSid(sid, out var principal))
				{
					type = principal.Type;
					sid = Helpers.ConvertCommonSid(sid, wrapper.Domain);
				}
				else
				{
					type = await ResolutionHelpers.LookupSidType(sid, wrapper.Domain);
				}
				allowedToActPrincipals.Add(new GenericMember
				{
					MemberType = type,
					MemberId = sid
				});
				principal = null;
			}
		}
		wrapper.AllowedToAct = Enumerable.ToArray(Enumerable.Distinct(allowedToActPrincipals));
		wrapper.Properties.Add("serviceprincipalnames", result.GetPropertyAsArray("serviceprincipalname"));
		wrapper.Properties.Add("lastlogontimestamp", ConvertToUnixEpoch(result.GetProperty("lastlogontimestamp")));
		wrapper.Properties.Add("pwdlastset", ConvertToUnixEpoch(result.GetProperty("pwdlastset")));
		string os = result.GetProperty("operatingsystem");
		string sp = result.GetProperty("operatingsystemservicepack");
		if (sp != null)
		{
			os = os + " " + sp;
		}
		wrapper.Properties.Add("operatingsystem", os);
	}

	private static void ParseDomainProperties(Domain wrapper)
	{
		SearchResultEntry searchResult = wrapper.SearchResult;
		if (!int.TryParse(searchResult.GetProperty("msds-behavior-version"), out var result))
		{
			result = -1;
			int num = -1;
			int num2 = -1;
		}
		else
		{
			switch (result)
			{
			case 0:
				goto IL_0059;
			case 1:
				goto IL_0062;
			case 2:
				goto IL_006b;
			case 3:
				goto IL_0074;
			case 4:
				goto IL_007d;
			case 5:
				goto IL_0086;
			case 6:
				goto IL_008f;
			case 7:
				goto IL_0098;
			}
		}
		string value = "Unknown";
		goto IL_009f;
		IL_0059:
		value = "2000 Mixed/Native";
		goto IL_009f;
		IL_009f:
		wrapper.Properties.Add("functionallevel", value);
		return;
		IL_0062:
		value = "2003 Interim";
		goto IL_009f;
		IL_0098:
		value = "2016";
		goto IL_009f;
		IL_008f:
		value = "2012 R2";
		goto IL_009f;
		IL_0086:
		value = "2012";
		goto IL_009f;
		IL_007d:
		value = "2008 R2";
		goto IL_009f;
		IL_0074:
		value = "2008";
		goto IL_009f;
		IL_006b:
		value = "2003";
		goto IL_009f;
	}

	private static async Task ParseUserProperties(User wrapper)
	{
		SearchResultEntry result = wrapper.SearchResult;
		string userAccountControl = result.GetProperty("useraccountcontrol");
		bool enabled = true;
		bool trustedToAuth = false;
		bool sensitive = false;
		bool dontReqPreAuth = false;
		bool passwdNotReq = false;
		bool unconstrained = false;
		bool pwdNeverExires = false;
		if (int.TryParse(userAccountControl, out var baseFlags))
		{
			UacFlags uacFlags = (UacFlags)baseFlags;
			enabled = (uacFlags & UacFlags.AccountDisable) == 0;
			trustedToAuth = (uacFlags & UacFlags.TrustedToAuthForDelegation) != 0;
			sensitive = (uacFlags & UacFlags.NotDelegated) != 0;
			dontReqPreAuth = (uacFlags & UacFlags.DontReqPreauth) != 0;
			passwdNotReq = (uacFlags & UacFlags.PasswordNotRequired) != 0;
			unconstrained = (uacFlags & UacFlags.TrustedForDelegation) != 0;
			pwdNeverExires = (uacFlags & UacFlags.DontExpirePassword) != 0;
		}
		wrapper.Properties.Add("dontreqpreauth", dontReqPreAuth);
		wrapper.Properties.Add("passwordnotreqd", passwdNotReq);
		wrapper.Properties.Add("unconstraineddelegation", unconstrained);
		wrapper.Properties.Add("sensitive", sensitive);
		wrapper.Properties.Add("enabled", enabled);
		wrapper.Properties.Add("pwdneverexpires", pwdNeverExires);
		List<string> trustedToAuthComputers = new List<string>();
		if (trustedToAuth)
		{
			string[] delegates = result.GetPropertyAsArray("msds-AllowedToDelegateTo");
			wrapper.Properties.Add("allowedtodelegate", delegates);
			string[] array = delegates;
			foreach (string computerName in array)
			{
				trustedToAuthComputers.Add(await ResolutionHelpers.ResolveHostToSid(computerName, wrapper.Domain));
			}
		}
		wrapper.AllowedToDelegate = Enumerable.ToArray(Enumerable.Distinct(trustedToAuthComputers));
		wrapper.Properties.Add("lastlogon", ConvertToUnixEpoch(result.GetProperty("lastlogon")));
		wrapper.Properties.Add("lastlogontimestamp", ConvertToUnixEpoch(result.GetProperty("lastlogontimestamp")));
		wrapper.Properties.Add("pwdlastset", ConvertToUnixEpoch(result.GetProperty("pwdlastset")));
		string[] servicePrincipalNames = result.GetPropertyAsArray("serviceprincipalname");
		wrapper.Properties.Add("serviceprincipalnames", servicePrincipalNames);
		wrapper.Properties.Add("hasspn", servicePrincipalNames.Length != 0);
		wrapper.Properties.Add("displayname", result.GetProperty("displayname"));
		wrapper.Properties.Add("email", result.GetProperty("mail"));
		wrapper.Properties.Add("title", result.GetProperty("title"));
		wrapper.Properties.Add("homedirectory", result.GetProperty("homedirectory"));
		wrapper.Properties.Add("userpassword", result.GetProperty("userpassword"));
		string adminCount = result.GetProperty("admincount");
		if (adminCount != null)
		{
			int a = int.Parse(adminCount);
			wrapper.Properties.Add("admincount", a != 0);
		}
		else
		{
			wrapper.Properties.Add("admincount", false);
		}
		byte[][] sidHistory = result.GetPropertyAsArrayOfBytes("sidhistory");
		List<string> sidHistoryList = new List<string>();
		List<GenericMember> sidHistoryPrincipals = new List<GenericMember>();
		byte[][] array2 = sidHistory;
		foreach (byte[] sid in array2)
		{
			string s = Helpers.CreateSecurityIdentifier(sid)?.Value;
			if (s != null)
			{
				sidHistoryList.Add(s);
				LdapTypeEnum sidType = await ResolutionHelpers.LookupSidType(s, wrapper.Domain);
				if (sidType != LdapTypeEnum.Unknown)
				{
					sidHistoryPrincipals.Add(new GenericMember
					{
						MemberId = s,
						MemberType = sidType
					});
				}
			}
		}
		wrapper.HasSIDHistory = sidHistoryPrincipals.ToArray();
		wrapper.Properties.Add("sidhistory", sidHistoryList.ToArray());
	}

	private static long ConvertToUnixEpoch(string ldapTime)
	{
		if (ldapTime == null)
		{
			return -1L;
		}
		long num = long.Parse(ldapTime);
		if (num == 0L)
		{
			return -1L;
		}
		long result;
		try
		{
			result = (long)Math.Floor(DateTime.FromFileTimeUtc(num).Subtract(WindowsEpoch).TotalSeconds);
		}
		catch
		{
			result = -1L;
		}
		return result;
	}

	[DllImport("Advapi32")]
	private static extern bool IsTextUnicode(byte[] buf, int len, ref IsTextUnicodeFlags opt);
}
