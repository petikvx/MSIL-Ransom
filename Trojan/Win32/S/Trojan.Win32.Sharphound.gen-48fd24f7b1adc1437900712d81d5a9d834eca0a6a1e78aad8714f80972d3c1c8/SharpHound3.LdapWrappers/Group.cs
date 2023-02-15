using System.DirectoryServices.Protocols;
using SharpHound3.JSON;

namespace SharpHound3.LdapWrappers;

internal class Group : LdapWrapper
{
	public GenericMember[] Members { get; set; }

	internal Group(SearchResultEntry entry)
		: base(entry)
	{
		Members = new GenericMember[0];
	}
}
