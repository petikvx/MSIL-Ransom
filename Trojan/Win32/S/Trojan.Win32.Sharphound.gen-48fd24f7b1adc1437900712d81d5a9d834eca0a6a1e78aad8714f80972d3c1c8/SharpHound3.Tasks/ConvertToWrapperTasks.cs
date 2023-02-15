using System;
using System.DirectoryServices.Protocols;
using System.Linq;
using SharpHound3.Enums;
using SharpHound3.LdapWrappers;
using SharpHound3.Producers;

namespace SharpHound3.Tasks;

internal static class ConvertToWrapperTasks
{
	internal static LdapWrapper CreateLdapWrapper(SearchResultEntry searchResultEntry)
	{
		string distinguishedName = searchResultEntry.get_DistinguishedName();
		if (distinguishedName == null)
		{
			return null;
		}
		string text = searchResultEntry.GetProperty("samaccountname");
		string property = searchResultEntry.GetProperty("samaccounttype");
		string text2 = Helpers.DistinguishedNameToDomain(distinguishedName);
		string sid = searchResultEntry.GetSid();
		string objectIdentifier = searchResultEntry.GetObjectIdentifier();
		if (sid == null && objectIdentifier == null)
		{
			return null;
		}
		LdapTypeEnum ldapTypeEnum = LdapTypeEnum.Unknown;
		string text3;
		if (sid != null && CommonPrincipal.GetCommonSid(sid, out var commonPrincipal))
		{
			text = commonPrincipal.Name;
			ldapTypeEnum = commonPrincipal.Type;
			text3 = Helpers.ConvertCommonSid(sid, text2);
		}
		else
		{
			if (property != null)
			{
				if (property == "805306370")
				{
					return null;
				}
				ldapTypeEnum = Helpers.SamAccountTypeToType(property);
			}
			else
			{
				string[] propertyAsArray = searchResultEntry.GetPropertyAsArray("objectClass");
				if (propertyAsArray == null)
				{
					ldapTypeEnum = LdapTypeEnum.Unknown;
				}
				else if (Enumerable.Contains(propertyAsArray, "groupPolicyContainer"))
				{
					ldapTypeEnum = LdapTypeEnum.GPO;
				}
				else if (Enumerable.Contains(propertyAsArray, "organizationalUnit"))
				{
					ldapTypeEnum = LdapTypeEnum.OU;
				}
				else if (Enumerable.Contains(propertyAsArray, "domain"))
				{
					ldapTypeEnum = LdapTypeEnum.Domain;
				}
			}
			text3 = objectIdentifier;
		}
		if (searchResultEntry.GetPropertyAsBytes("msds-groupmsamembership") != null)
		{
			ldapTypeEnum = LdapTypeEnum.User;
			text = text?.TrimEnd(new char[1] { '$' });
		}
		LdapWrapper ldapWrapper;
		switch (ldapTypeEnum)
		{
		default:
			throw new ArgumentOutOfRangeException();
		case LdapTypeEnum.User:
			ldapWrapper = new User(searchResultEntry)
			{
				DisplayName = (text + "@" + text2).ToUpper()
			};
			ldapWrapper.Properties.Add("highvalue", false);
			break;
		case LdapTypeEnum.Computer:
		{
			text = text?.TrimEnd(new char[1] { '$' });
			ldapWrapper = new Computer(searchResultEntry)
			{
				DisplayName = (text + "." + text2).ToUpper(),
				SamAccountName = text
			};
			bool flag = searchResultEntry.GetProperty("ms-mcs-admpwdexpirationtime") != null;
			ldapWrapper.Properties.Add("haslaps", flag);
			ldapWrapper.Properties.Add("highvalue", false);
			break;
		}
		case LdapTypeEnum.Group:
			ldapWrapper = new Group(searchResultEntry)
			{
				DisplayName = (text + "@" + text2).ToUpper()
			};
			if (text3.EndsWith("-512") || text3.EndsWith("-516") || text3.EndsWith("-519") || text3.EndsWith("S-1-5-32-544") || text3.EndsWith("S-1-5-32-550") || text3.EndsWith("S-1-5-32-549") || text3.EndsWith("S-1-5-32-551") || text3.EndsWith("S-1-5-32-548"))
			{
				ldapWrapper.Properties.Add("highvalue", true);
			}
			else
			{
				ldapWrapper.Properties.Add("highvalue", false);
			}
			break;
		case LdapTypeEnum.GPO:
			text = searchResultEntry.GetProperty("displayname");
			ldapWrapper = new GPO(searchResultEntry)
			{
				DisplayName = (text + "@" + text2).ToUpper()
			};
			ldapWrapper.Properties.Add("highvalue", false);
			break;
		case LdapTypeEnum.Domain:
			ldapWrapper = new Domain(searchResultEntry)
			{
				DisplayName = text2.ToUpper()
			};
			ldapWrapper.Properties.Add("highvalue", true);
			break;
		case LdapTypeEnum.OU:
			text = searchResultEntry.GetProperty("name");
			ldapWrapper = new OU(searchResultEntry)
			{
				DisplayName = (text + "@" + text2).ToUpper()
			};
			ldapWrapper.Properties.Add("highvalue", false);
			break;
		case LdapTypeEnum.Unknown:
			ldapWrapper = null;
			break;
		}
		if (ldapWrapper == null)
		{
			Console.WriteLine("Null Wrapper: " + distinguishedName);
			return null;
		}
		ldapWrapper.DistinguishedName = distinguishedName;
		ldapWrapper.Properties.Add("name", ldapWrapper.DisplayName);
		ldapWrapper.Properties.Add("domain", ldapWrapper.Domain);
		ldapWrapper.Properties.Add("objectid", text3.ToUpper());
		ldapWrapper.Properties.Add("distinguishedname", distinguishedName);
		ldapWrapper.ObjectIdentifier = text3;
		PostProcessWrapper(ldapWrapper);
		Cache.Instance.Add(ldapWrapper.DistinguishedName, new ResolvedPrincipal
		{
			ObjectIdentifier = ldapWrapper.ObjectIdentifier,
			ObjectType = ldapTypeEnum
		});
		if (text3.StartsWith("S-1-5"))
		{
			Cache.Instance.Add(ldapWrapper.ObjectIdentifier, ldapTypeEnum);
		}
		return ldapWrapper;
	}

	private static void PostProcessWrapper(LdapWrapper wrapper)
	{
		Options instance = Options.Instance;
		if (wrapper is Computer computer)
		{
			if (instance.Stealth && StealthProducer.IsSidStealthTarget(computer.ObjectIdentifier))
			{
				computer.IsStealthTarget = true;
			}
			if (instance.ExcludeDomainControllers && BaseProducer.IsSidDomainController(computer.ObjectIdentifier))
			{
				computer.IsDomainController = true;
			}
		}
	}
}
