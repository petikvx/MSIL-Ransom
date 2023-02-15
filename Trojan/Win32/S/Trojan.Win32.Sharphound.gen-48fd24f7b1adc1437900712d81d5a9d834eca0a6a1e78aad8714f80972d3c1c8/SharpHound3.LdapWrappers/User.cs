using System.DirectoryServices.Protocols;
using SharpHound3.JSON;

namespace SharpHound3.LdapWrappers;

internal class User : LdapWrapper
{
	public string[] AllowedToDelegate { get; set; }

	public SPNTarget[] SPNTargets { get; set; }

	public string PrimaryGroupSid { get; set; }

	public GenericMember[] HasSIDHistory { get; set; }

	internal User(SearchResultEntry entry)
		: base(entry)
	{
		AllowedToDelegate = new string[0];
		SPNTargets = new SPNTarget[0];
	}
}
