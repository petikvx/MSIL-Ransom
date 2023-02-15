using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Threading.Tasks;
using SharpHound3.Enums;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;

namespace SharpHound3.Tasks;

internal class ContainerTasks
{
	internal static async Task<LdapWrapper> EnumerateContainer(LdapWrapper wrapper)
	{
		if (wrapper is OU ou)
		{
			await ProcessOUObject(ou);
		}
		else if (wrapper is Domain domain)
		{
			await ProcessDomainObject(domain);
		}
		return wrapper;
	}

	private static async Task ProcessDomainObject(Domain domain)
	{
		SearchResultEntry searchResult = domain.SearchResult;
		List<GPLink> resolvedLinks = new List<GPLink>();
		string gpLinks = searchResult.GetProperty("gplink");
		if (gpLinks != null)
		{
			foreach (string link in Enumerable.Where(gpLinks.Split(']', '['), (string l) => l.StartsWith("LDAP")))
			{
				string[] splitLink = link.Split(new char[1] { ';' });
				string distinguishedName2 = splitLink[0];
				distinguishedName2 = distinguishedName2.Substring(distinguishedName2.IndexOf("CN=", StringComparison.OrdinalIgnoreCase));
				string status = splitLink[1];
				if (!(status == "1") && !(status == "3"))
				{
					bool enforced = status == "2";
					var (success, guid) = await ResolutionHelpers.OUDistinguishedNameToGuid(distinguishedName2);
					if (success)
					{
						resolvedLinks.Add(new GPLink
						{
							IsEnforced = enforced,
							Guid = guid
						});
					}
				}
			}
		}
		List<string> users = new List<string>();
		List<string> computers = new List<string>();
		List<string> ous = new List<string>();
		DirectorySearch searcher = Helpers.GetDirectorySearcher(domain.Domain);
		foreach (SearchResultEntry containedObject in searcher.QueryLdap("(|(samAccountType=805306368)(samAccountType=805306369)(objectclass=organizationalUnit))", Helpers.ResolutionProps, (SearchScope)1, domain.DistinguishedName))
		{
			LdapTypeEnum type2 = containedObject.GetLdapType();
			string id2 = containedObject.GetObjectIdentifier();
			if (id2 != null)
			{
				switch (type2)
				{
				case LdapTypeEnum.OU:
					ous.Add(id2);
					break;
				case LdapTypeEnum.Computer:
					computers.Add(id2);
					break;
				case LdapTypeEnum.User:
					users.Add(id2);
					break;
				}
			}
		}
		using (IEnumerator<SearchResultEntry> enumerator3 = searcher.QueryLdap("(objectclass=container)", Helpers.ResolutionProps, (SearchScope)1, domain.DistinguishedName).GetEnumerator())
		{
			while (enumerator3.MoveNext())
			{
				foreach (SearchResultEntry subObject in searcher.QueryLdap(adsPath: enumerator3.Current.get_DistinguishedName(), ldapFilter: "(|(samAccountType=805306368)(samAccountType=805306369))", props: Helpers.ResolutionProps, scope: (SearchScope)2))
				{
					LdapTypeEnum type = subObject.GetLdapType();
					string id = subObject.GetObjectIdentifier();
					if (id != null)
					{
						switch (type)
						{
						case LdapTypeEnum.OU:
							ous.Add(id);
							break;
						case LdapTypeEnum.Computer:
							computers.Add(id);
							break;
						case LdapTypeEnum.User:
							users.Add(id);
							break;
						}
					}
				}
			}
		}
		domain.Computers = computers.ToArray();
		domain.Users = users.ToArray();
		domain.ChildOus = ous.ToArray();
		domain.Links = resolvedLinks.ToArray();
	}

	private static async Task ProcessOUObject(OU ou)
	{
		SearchResultEntry searchResult = ou.SearchResult;
		string gpOptions = searchResult.GetProperty("gpoptions");
		ou.Properties.Add("blocksinheritance", gpOptions != null && gpOptions == "1");
		List<GPLink> resolvedLinks = new List<GPLink>();
		string gpLinks = searchResult.GetProperty("gplink");
		if (gpLinks != null)
		{
			foreach (string link in Enumerable.Where(gpLinks.Split(']', '['), (string l) => l.StartsWith("LDAP")))
			{
				string[] splitLink = link.Split(new char[1] { ';' });
				string distinguishedName2 = splitLink[0];
				distinguishedName2 = distinguishedName2.Substring(distinguishedName2.IndexOf("CN=", StringComparison.OrdinalIgnoreCase));
				string status = splitLink[1];
				if (!(status == "1") && !(status == "3"))
				{
					bool enforced = status == "2";
					var (success, guid) = await ResolutionHelpers.OUDistinguishedNameToGuid(distinguishedName2);
					if (success)
					{
						resolvedLinks.Add(new GPLink
						{
							IsEnforced = enforced,
							Guid = guid
						});
					}
				}
			}
		}
		List<string> users = new List<string>();
		List<string> computers = new List<string>();
		List<string> ous = new List<string>();
		DirectorySearch searcher = Helpers.GetDirectorySearcher(ou.Domain);
		foreach (SearchResultEntry containedObject in searcher.QueryLdap("(|(samAccountType=805306368)(samAccountType=805306369)(objectclass=organizationalUnit))", Helpers.ResolutionProps, (SearchScope)1, ou.DistinguishedName))
		{
			LdapTypeEnum type = containedObject.GetLdapType();
			string id = containedObject.GetObjectIdentifier();
			if (id != null)
			{
				switch (type)
				{
				case LdapTypeEnum.OU:
					ous.Add(id);
					break;
				case LdapTypeEnum.Computer:
					computers.Add(id);
					break;
				case LdapTypeEnum.User:
					users.Add(id);
					break;
				}
			}
		}
		ou.Computers = computers.ToArray();
		ou.Users = users.ToArray();
		ou.ChildOus = ous.ToArray();
		ou.Links = resolvedLinks.ToArray();
	}
}
