using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading.Tasks;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;

namespace SharpHound3.Tasks;

internal static class ACLTasks
{
	private static readonly Dictionary<Type, string> BaseGuids;

	private const string AllGuid = "00000000-0000-0000-0000-000000000000";

	static ACLTasks()
	{
		BaseGuids = new Dictionary<Type, string>
		{
			{
				typeof(User),
				"bf967aba-0de6-11d0-a285-00aa003049e2"
			},
			{
				typeof(Computer),
				"bf967a86-0de6-11d0-a285-00aa003049e2"
			},
			{
				typeof(Group),
				"bf967a9c-0de6-11d0-a285-00aa003049e2"
			},
			{
				typeof(Domain),
				"19195a5a-6da0-11d0-afd3-00c04fd930c9"
			},
			{
				typeof(GPO),
				"f30e3bc2-9ff0-11d1-b603-0000f80367c1"
			},
			{
				typeof(OU),
				"bf967aa5-0de6-11d0-a285-00aa003049e2"
			}
		};
	}

	internal static async Task<LdapWrapper> ProcessAces(LdapWrapper wrapper)
	{
		wrapper.Aces = Enumerable.ToArray(Enumerable.Concat(await ProcessDACL(wrapper), await ProcessGMSA(wrapper)));
		return wrapper;
	}

	private static async Task<List<ACL>> ProcessGMSA(LdapWrapper wrapper)
	{
		List<ACL> aces = new List<ACL>();
		byte[] securityDescriptor = wrapper.SearchResult.GetPropertyAsBytes("msds-groupmsamembership");
		if (securityDescriptor == null)
		{
			return aces;
		}
		ActiveDirectorySecurity descriptor = new ActiveDirectorySecurity();
		((ObjectSecurity)(object)descriptor).SetSecurityDescriptorBinaryForm(securityDescriptor);
		foreach (ActiveDirectoryAccessRule accessRule in ((DirectoryObjectSecurity)(object)descriptor).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier)))
		{
			ActiveDirectoryAccessRule ace = accessRule;
			if (ace != null && ((AccessRule)(object)ace).AccessControlType != AccessControlType.Deny)
			{
				string principalSid = FilterAceSids(((AuthorizationRule)(object)ace).IdentityReference.Value);
				if (principalSid != null)
				{
					var (finalSid, type) = await ResolutionHelpers.ResolveSidAndGetType(principalSid, wrapper.Domain);
					aces.Add(new ACL
					{
						RightName = "ReadGMSAPassword",
						AceType = "",
						PrincipalSID = finalSid,
						PrincipalType = type,
						IsInherited = false
					});
				}
			}
		}
		return aces;
	}

	private static async Task<List<ACL>> ProcessDACL(LdapWrapper wrapper)
	{
		List<ACL> aces = new List<ACL>();
		byte[] ntSecurityDescriptor = wrapper.SearchResult.GetPropertyAsBytes("ntsecuritydescriptor");
		if (ntSecurityDescriptor == null)
		{
			return aces;
		}
		ActiveDirectorySecurity descriptor = new ActiveDirectorySecurity();
		((ObjectSecurity)(object)descriptor).SetSecurityDescriptorBinaryForm(ntSecurityDescriptor);
		string ownerSid = FilterAceSids(((ObjectSecurity)(object)descriptor).GetOwner(typeof(SecurityIdentifier))!.Value);
		if (ownerSid != null)
		{
			var (finalSid, type) = await ResolutionHelpers.ResolveSidAndGetType(ownerSid, wrapper.Domain);
			if (finalSid != null)
			{
				aces.Add(new ACL
				{
					PrincipalSID = finalSid,
					RightName = "Owner",
					AceType = "",
					PrincipalType = type,
					IsInherited = false
				});
			}
		}
		foreach (ActiveDirectoryAccessRule accessRule in ((DirectoryObjectSecurity)(object)descriptor).GetAccessRules(includeExplicit: true, includeInherited: true, typeof(SecurityIdentifier)))
		{
			ActiveDirectoryAccessRule ace = accessRule;
			if (ace == null || ((AccessRule)(object)ace).AccessControlType == AccessControlType.Deny || !IsAceInherited((ObjectAccessRule)(object)ace, BaseGuids[wrapper.GetType()]))
			{
				continue;
			}
			string principalSid = FilterAceSids(((AuthorizationRule)(object)ace).IdentityReference.Value);
			if (principalSid == null)
			{
				continue;
			}
			var (finalSid2, type2) = await ResolutionHelpers.ResolveSidAndGetType(principalSid, wrapper.Domain);
			if (finalSid2 == null)
			{
				continue;
			}
			ActiveDirectoryRights rights = ace.get_ActiveDirectoryRights();
			string objectAceType = ((ObjectAccessRule)(object)ace).ObjectType.ToString();
			bool isInherited = ((AuthorizationRule)(object)ace).IsInherited;
			if (((Enum)rights).HasFlag((Enum)(object)(ActiveDirectoryRights)983551))
			{
				if (objectAceType == "00000000-0000-0000-0000-000000000000" || objectAceType == "")
				{
					aces.Add(new ACL
					{
						PrincipalSID = finalSid2,
						RightName = "GenericAll",
						AceType = "",
						PrincipalType = type2,
						IsInherited = isInherited
					});
				}
				continue;
			}
			if (((Enum)rights).HasFlag((Enum)(object)(ActiveDirectoryRights)262144))
			{
				aces.Add(new ACL
				{
					PrincipalSID = finalSid2,
					AceType = "",
					RightName = "WriteDacl",
					PrincipalType = type2,
					IsInherited = isInherited
				});
			}
			if (((Enum)rights).HasFlag((Enum)(object)(ActiveDirectoryRights)524288))
			{
				aces.Add(new ACL
				{
					RightName = "WriteOwner",
					AceType = "",
					PrincipalSID = finalSid2,
					PrincipalType = type2,
					IsInherited = isInherited
				});
			}
			if (((Enum)rights).HasFlag((Enum)(object)(ActiveDirectoryRights)256))
			{
				if (wrapper is Domain)
				{
					string text = objectAceType;
					string text2 = text;
					switch (text2)
					{
					default:
						if (text2.Length != 0)
						{
							break;
						}
						goto case "00000000-0000-0000-0000-000000000000";
					case "00000000-0000-0000-0000-000000000000":
						aces.Add(new ACL
						{
							AceType = "All",
							RightName = "ExtendedRight",
							PrincipalSID = finalSid2,
							PrincipalType = type2,
							IsInherited = isInherited
						});
						break;
					case "1131f6ad-9c07-11d1-f79f-00c04fc2dcd2":
						aces.Add(new ACL
						{
							AceType = "GetChangesAll",
							RightName = "ExtendedRight",
							PrincipalSID = finalSid2,
							PrincipalType = type2,
							IsInherited = isInherited
						});
						break;
					case "1131f6aa-9c07-11d1-f79f-00c04fc2dcd2":
						aces.Add(new ACL
						{
							AceType = "GetChanges",
							RightName = "ExtendedRight",
							PrincipalSID = finalSid2,
							PrincipalType = type2,
							IsInherited = isInherited
						});
						break;
					case null:
						break;
					}
				}
				else if (wrapper is User)
				{
					string text3 = objectAceType;
					string text2 = text3;
					switch (text2)
					{
					default:
						if (text2.Length != 0)
						{
							break;
						}
						goto case "00000000-0000-0000-0000-000000000000";
					case "00000000-0000-0000-0000-000000000000":
						aces.Add(new ACL
						{
							AceType = "All",
							PrincipalSID = finalSid2,
							RightName = "ExtendedRight",
							PrincipalType = type2,
							IsInherited = isInherited
						});
						break;
					case "00299570-246d-11d0-a768-00aa006e0529":
						aces.Add(new ACL
						{
							AceType = "User-Force-Change-Password",
							PrincipalSID = finalSid2,
							RightName = "ExtendedRight",
							PrincipalType = type2,
							IsInherited = isInherited
						});
						break;
					case null:
						break;
					}
				}
				else if (wrapper is Computer)
				{
					Helpers.GetDirectorySearcher(wrapper.Domain).GetAttributeFromGuid(objectAceType, out var mappedGuid);
					if (wrapper.SearchResult.GetProperty("ms-mcs-admpwdexpirationtime") != null)
					{
						if (objectAceType == "00000000-0000-0000-0000-000000000000" || objectAceType == "")
						{
							aces.Add(new ACL
							{
								AceType = "All",
								RightName = "ExtendedRight",
								PrincipalSID = finalSid2,
								PrincipalType = type2,
								IsInherited = isInherited
							});
						}
						else if (mappedGuid != null && mappedGuid.ToLower() == "ms-mcs-admpwd")
						{
							aces.Add(new ACL
							{
								AceType = "",
								RightName = "ReadLAPSPassword",
								PrincipalSID = finalSid2,
								PrincipalType = type2,
								IsInherited = isInherited
							});
						}
					}
					mappedGuid = null;
				}
			}
			if (!((Enum)rights).HasFlag((Enum)(object)(ActiveDirectoryRights)131112) && !((Enum)rights).HasFlag((Enum)(object)(ActiveDirectoryRights)32))
			{
				continue;
			}
			if ((wrapper is User || wrapper is Group || wrapper is Computer || wrapper is GPO) && (objectAceType == "00000000-0000-0000-0000-000000000000" || objectAceType == ""))
			{
				aces.Add(new ACL
				{
					AceType = "",
					RightName = "GenericWrite",
					PrincipalSID = finalSid2,
					PrincipalType = type2,
					IsInherited = isInherited
				});
			}
			if (wrapper is User)
			{
				if (objectAceType == "f3a64788-5306-11d1-a9c5-0000f80367c1")
				{
					aces.Add(new ACL
					{
						AceType = "WriteSPN",
						RightName = "WriteProperty",
						PrincipalSID = finalSid2,
						PrincipalType = type2,
						IsInherited = isInherited
					});
				}
			}
			else if (wrapper is Group)
			{
				if (objectAceType == "bf9679c0-0de6-11d0-a285-00aa003049e2")
				{
					aces.Add(new ACL
					{
						AceType = "AddMember",
						RightName = "WriteProperty",
						PrincipalSID = finalSid2,
						PrincipalType = type2,
						IsInherited = isInherited
					});
				}
			}
			else if (wrapper is Computer && objectAceType == "3f78c3e5-f79a-46bd-a0b8-9d18116ddc79")
			{
				aces.Add(new ACL
				{
					AceType = "AllowedToAct",
					RightName = "WriteProperty",
					PrincipalSID = finalSid2,
					PrincipalType = type2,
					IsInherited = isInherited
				});
			}
		}
		return aces;
	}

	private static bool IsAceInherited(ObjectAccessRule ace, string guid)
	{
		bool isInherited = ace.IsInherited;
		string text = ace.InheritedObjectType.ToString();
		if (!(isInherited = isInherited && (text == "00000000-0000-0000-0000-000000000000" || text == guid)) && (ace.PropagationFlags & PropagationFlags.InheritOnly) != PropagationFlags.InheritOnly && !ace.IsInherited)
		{
			isInherited = true;
		}
		return isInherited;
	}

	private static string FilterAceSids(string sid)
	{
		if (sid == "S-1-5-18" || sid == "S-1-3-0" || sid == "S-1-5-10")
		{
			return null;
		}
		return sid.ToUpper();
	}
}
