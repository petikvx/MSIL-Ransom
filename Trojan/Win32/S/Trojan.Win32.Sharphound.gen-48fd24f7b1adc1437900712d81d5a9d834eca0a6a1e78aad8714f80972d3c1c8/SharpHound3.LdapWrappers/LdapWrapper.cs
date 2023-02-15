using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using Newtonsoft.Json;
using SharpHound3.JSON;

namespace SharpHound3.LdapWrappers;

internal class LdapWrapper
{
	private string _domain;

	public Dictionary<string, object> Properties = new Dictionary<string, object>();

	[JsonIgnore]
	public string DisplayName { get; set; }

	public string ObjectIdentifier { get; set; }

	[JsonIgnore]
	public string DistinguishedName { get; set; }

	public ACL[] Aces { get; set; }

	[JsonIgnore]
	internal string Domain
	{
		get
		{
			return _domain ?? (_domain = Helpers.DistinguishedNameToDomain(DistinguishedName));
		}
		set
		{
			_domain = value.ToUpper();
		}
	}

	[JsonIgnore]
	internal SearchResultEntry SearchResult { get; }

	internal LdapWrapper(SearchResultEntry entry)
	{
		SearchResult = entry;
		Aces = new ACL[0];
	}

	public override string ToString()
	{
		return DisplayName ?? "";
	}
}
