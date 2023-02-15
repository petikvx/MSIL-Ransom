using System.Collections.Generic;
using System.Linq;
using SharpHound3.Enums;

namespace SharpHound3;

internal class LdapBuilder
{
	internal static LdapQueryData BuildLdapQuery(CollectionMethodResolved methods)
	{
		List<string> list = new List<string>();
		List<string> list2 = new List<string>();
		list2.AddRange(Helpers.ResolutionProps);
		list2.Add("samaccountname");
		list2.Add("msds-groupmsamembership");
		list2.Add("ms-mcs-admpwdexpirationtime");
		if (Options.Instance.WindowsOnly)
		{
			list2.Add("operatingsystem");
		}
		if (methods.HasFlag(CollectionMethodResolved.Group))
		{
			list.Add("(|(samaccounttype=268435456)(samaccounttype=268435457)(samaccounttype=536870912)(samaccounttype=536870913)(primarygroupid=*))");
			list2.AddRange(new string[2] { "member", "primarygroupid" });
		}
		if (methods.HasFlag(CollectionMethodResolved.LocalAdmin) || methods.HasFlag(CollectionMethodResolved.Sessions) || methods.HasFlag(CollectionMethodResolved.LoggedOn) || methods.HasFlag(CollectionMethodResolved.RDP) || methods.HasFlag(CollectionMethodResolved.DCOM) || methods.HasFlag(CollectionMethodResolved.PSRemote))
		{
			list.Add("(&(sAMAccountType=805306369)(!(UserAccountControl:1.2.840.113556.1.4.803:=2)))");
		}
		if (methods.HasFlag(CollectionMethodResolved.ACL))
		{
			list.Add("(|(samAccountType=805306368)(samAccountType=805306369)(samAccountType=268435456)(samAccountType=268435457)(samAccountType=536870912)(samAccountType=536870913)(objectClass=domain)(&(objectcategory=groupPolicyContainer)(flags=*))(objectcategory=organizationalUnit))");
			list2.AddRange(new string[3] { "ntsecuritydescriptor", "displayname", "name" });
		}
		if (methods.HasFlag(CollectionMethodResolved.Trusts))
		{
			list.Add("(objectclass=domain)");
		}
		if (methods.HasFlag(CollectionMethodResolved.ObjectProps))
		{
			list.Add("(|(samaccounttype=268435456)(samaccounttype=268435457)(samaccounttype=536870912)(samaccounttype=536870913)(samaccounttype=805306368)(samaccounttype=805306369)(objectclass=domain)(objectclass=organizationalUnit)(&(objectcategory=groupPolicyContainer)(flags=*)))");
			list2.AddRange(new string[25]
			{
				"pwdlastset", "lastlogon", "lastlogontimestamp", "sidhistory", "useraccountcontrol", "operatingsystem", "operatingsystemservicepack", "serviceprincipalname", "displayname", "mail",
				"title", "homedirectory", "description", "admincount", "userpassword", "gpcfilesyspath", "objectclass", "msds-behavior-version", "objectguid", "name",
				"gpoptions", "msds-allowedToDelegateTo", "msDS-AllowedToActOnBehalfOfOtherIdentity", "displayname", "sidhistory"
			});
		}
		if (methods.HasFlag(CollectionMethodResolved.Container))
		{
			list.Add("(|(&(&(objectcategory=groupPolicyContainer)(flags=*))(name=*)(gpcfilesyspath=*))(objectcategory=organizationalUnit)(objectClass=domain))");
			list2.AddRange(new string[4] { "gplink", "gpoptions", "name", "displayname" });
		}
		if (methods.HasFlag(CollectionMethodResolved.GPOLocalGroup))
		{
			list.Add("(&(|(objectcategory=organizationalUnit)(objectclass=domain))(gplink=*)(flags=*))");
			list2.AddRange(new string[2] { "gplink", "name" });
		}
		if (methods.HasFlag(CollectionMethodResolved.SPNTargets))
		{
			list.Add("(&(samaccounttype=805306368)(serviceprincipalname=*))");
			list2.AddRange(new string[1] { "serviceprincipalname" });
		}
		string text = string.Join("", list.ToArray());
		text = ((list.Count == 1) ? list[0] : ("(|" + text + ")"));
		string ldapFilter = Options.Instance.LdapFilter;
		if (ldapFilter != null)
		{
			text = "(&(" + text + ")(" + ldapFilter + "))";
		}
		if (Options.Instance.CollectAllProperties)
		{
			list2 = new List<string>();
			list2.Add("*");
		}
		return new LdapQueryData
		{
			LdapFilter = text,
			LdapProperties = Enumerable.ToArray(Enumerable.Distinct(list2))
		};
	}
}
