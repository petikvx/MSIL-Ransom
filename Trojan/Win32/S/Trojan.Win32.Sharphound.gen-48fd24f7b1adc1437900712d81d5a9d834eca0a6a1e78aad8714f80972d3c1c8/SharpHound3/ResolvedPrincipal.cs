using SharpHound3.Enums;

namespace SharpHound3;

public class ResolvedPrincipal
{
	public string ObjectIdentifier { get; set; }

	public LdapTypeEnum ObjectType { get; set; }
}
