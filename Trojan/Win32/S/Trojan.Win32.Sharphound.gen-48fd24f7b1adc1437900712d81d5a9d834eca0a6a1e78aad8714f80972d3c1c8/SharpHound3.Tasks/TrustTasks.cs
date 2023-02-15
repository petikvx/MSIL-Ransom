using System;
using System.DirectoryServices.Protocols;
using System.Linq;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;

namespace SharpHound3.Tasks;

internal class TrustTasks
{
	[Flags]
	private enum TrustAttributes
	{
		NonTransitive = 1,
		UplevelOnly = 2,
		FilterSids = 4,
		ForestTransitive = 8,
		CrossOrganization = 0x10,
		WithinForest = 0x20,
		TreatAsExternal = 0x40,
		TrustUsesRc4 = 0x80,
		TrustUsesAes = 0x100,
		CrossOrganizationNoTGTDelegation = 0x200,
		PIMTrust = 0x400
	}

	private static readonly string[] LookupProps = new string[5] { "trustattributes", "securityidentifier", "trustdirection", "trusttype", "cn" };

	internal static LdapWrapper ResolveDomainTrusts(LdapWrapper wrapper)
	{
		if (wrapper is Domain domain)
		{
			DoTrustEnumeration(domain);
		}
		return wrapper;
	}

	private static void DoTrustEnumeration(Domain domain)
	{
		DirectorySearch directorySearcher = Helpers.GetDirectorySearcher(domain.Domain);
		Trust[] array2 = (domain.Trusts = Enumerable.ToArray(Enumerable.Where(Enumerable.Select(directorySearcher.QueryLdap("(objectclass=trusteddomain)", LookupProps, (SearchScope)2), delegate(SearchResultEntry trustedDomain)
		{
			byte[] propertyAsBytes = trustedDomain.GetPropertyAsBytes("securityIdentifier");
			if (propertyAsBytes == null || propertyAsBytes.Length == 0)
			{
				return null;
			}
			string text = Helpers.CreateSecurityIdentifier(propertyAsBytes)?.Value;
			if (text == null)
			{
				return null;
			}
			TrustDirection trustDirection = (TrustDirection)int.Parse(trustedDomain.GetProperty("trustdirection"));
			TrustAttributes trustAttributes = (TrustAttributes)int.Parse(trustedDomain.GetProperty("trustattributes"));
			bool isTransitive = (trustAttributes & TrustAttributes.NonTransitive) == 0;
			string targetDomainName = trustedDomain.GetProperty("cn").ToUpper();
			bool sidFilteringEnabled = (trustAttributes & TrustAttributes.FilterSids) != 0;
			TrustType trustType = (((trustAttributes & TrustAttributes.WithinForest) == 0) ? (((trustAttributes & TrustAttributes.ForestTransitive) != 0) ? TrustType.Forest : (((trustAttributes & TrustAttributes.TreatAsExternal) == 0 && (trustAttributes & TrustAttributes.CrossOrganization) == 0) ? TrustType.Unknown : TrustType.External)) : TrustType.ParentChild);
			return new Trust
			{
				IsTransitive = isTransitive,
				TrustDirection = trustDirection,
				TargetDomainSid = text,
				TrustType = trustType,
				TargetDomainName = targetDomainName,
				SidFilteringEnabled = sidFilteringEnabled
			};
		}), (Trust trust) => trust != null)));
	}
}
