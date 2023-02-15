using System;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using SharpHound3.Enums;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;

namespace SharpHound3.Tasks;

internal class GroupEnumerationTasks
{
	private static readonly Cache AppCache = Cache.Instance;

	internal static async Task<LdapWrapper> ProcessGroupMembership(LdapWrapper wrapper)
	{
		if (wrapper is Group group)
		{
			await GetGroupMembership(group);
		}
		else if (wrapper is Computer || wrapper is User)
		{
			GetPrimaryGroupInfo(wrapper);
		}
		return wrapper;
	}

	private static void GetPrimaryGroupInfo(LdapWrapper wrapper)
	{
		string property = wrapper.SearchResult.GetProperty("primarygroupid");
		if (property != null)
		{
			string text = wrapper.ObjectIdentifier.Substring(0, wrapper.ObjectIdentifier.LastIndexOf("-", StringComparison.Ordinal));
			string primaryGroupSid = text + "-" + property;
			if (wrapper is Computer computer)
			{
				computer.PrimaryGroupSid = primaryGroupSid;
			}
			else if (wrapper is User user)
			{
				user.PrimaryGroupSid = primaryGroupSid;
			}
		}
	}

	private static async Task GetGroupMembership(Group group)
	{
		List<GenericMember> finalMembers = new List<GenericMember>();
		SearchResultEntry searchResult = group.SearchResult;
		AppCache.Add(group.DistinguishedName, new ResolvedPrincipal
		{
			ObjectIdentifier = group.ObjectIdentifier,
			ObjectType = LdapTypeEnum.Group
		});
		string[] groupMembers = searchResult.GetPropertyAsArray("member");
		if (groupMembers.Length == 0)
		{
			Timer timer = null;
			int count = 0;
			DirectorySearch searcher = Helpers.GetDirectorySearcher(group.Domain);
			List<string> range = await searcher.RangedRetrievalAsync(group.DistinguishedName, "member");
			if (range == null)
			{
				group.Members = finalMembers.ToArray();
				return;
			}
			if (range.Count > 1000 && Options.Instance.Verbose)
			{
				timer = new Timer(30000.0);
				timer.Elapsed += delegate
				{
					Console.WriteLine($"Group Enumeration - {group.DisplayName} {count} / {range.Count}");
				};
				timer.AutoReset = true;
				timer.Start();
			}
			foreach (string groupMemberDistinguishedName2 in range)
			{
				var (sid2, type2) = await ResolutionHelpers.ResolveDistinguishedName(groupMemberDistinguishedName2);
				if (sid2 == null)
				{
					sid2 = groupMemberDistinguishedName2;
				}
				finalMembers.Add(new GenericMember
				{
					MemberId = sid2,
					MemberType = type2
				});
				count++;
			}
			timer?.Stop();
			timer?.Dispose();
		}
		else
		{
			string[] array = groupMembers;
			foreach (string groupMemberDistinguishedName in array)
			{
				var (sid, type) = await ResolutionHelpers.ResolveDistinguishedName(groupMemberDistinguishedName);
				if (sid == null)
				{
					sid = groupMemberDistinguishedName;
				}
				finalMembers.Add(new GenericMember
				{
					MemberId = sid,
					MemberType = type
				});
			}
		}
		group.Members = Enumerable.ToArray(Enumerable.Distinct(finalMembers));
	}
}
