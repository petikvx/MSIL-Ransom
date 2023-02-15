using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.DirectoryServices.Protocols;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.XPath;
using SharpHound3.Enums;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;

namespace SharpHound3.Tasks;

internal class GPOGroupTasks
{
	private class GroupAction
	{
		internal GroupActionOperation Action { get; set; }

		internal GroupActionTarget Target { get; set; }

		internal string TargetSid { get; set; }

		internal LdapTypeEnum TargetType { get; set; }

		internal LocalGroupRids TargetRid { get; set; }

		public override string ToString()
		{
			return string.Format("{0}: {1}, {2}: {3}, {4}: {5}, {6}: {7}, {8}: {9}", "Action", Action, "Target", Target, "TargetSid", TargetSid, "TargetType", TargetType, "TargetRid", TargetRid);
		}
	}

	public class GroupResults
	{
		public List<GenericMember> RestrictedMemberOf = new List<GenericMember>();

		public List<GenericMember> RestrictedMember = new List<GenericMember>();

		public List<GenericMember> LocalGroups = new List<GenericMember>();
	}

	private enum GroupActionOperation
	{
		Add,
		Delete,
		DeleteUsers,
		DeleteGroups
	}

	private enum GroupActionTarget
	{
		RestrictedMemberOf,
		RestrictedMember,
		LocalGroup
	}

	private static readonly Regex KeyRegex = new Regex("(.+?)\\s*=(.*)", RegexOptions.Compiled);

	private static readonly Regex MemberRegex = new Regex("\\[Group Membership\\](.*)(?:\\[|$)", RegexOptions.Compiled | RegexOptions.Singleline);

	private static readonly Regex MemberLeftRegex = new Regex("(.*(?:S-1-5-32-544|S-1-5-32-555|S-1-5-32-562)__Members)", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	private static readonly Regex MemberRightRegex = new Regex("(S-1-5-32-544|S-1-5-32-555|S-1-5-32-562)", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	private static readonly Regex ExtractRid = new Regex("S-1-5-32-([0-9]{3})", RegexOptions.IgnoreCase | RegexOptions.Compiled);

	private static readonly ConcurrentDictionary<string, List<GroupAction>> GpoActionCache = new ConcurrentDictionary<string, List<GroupAction>>();

	private static readonly (string groupName, LocalGroupRids rid)[] ValidGroupNames = new(string, LocalGroupRids)[4]
	{
		("Administrators", LocalGroupRids.Administrators),
		("Remote Desktop Users", LocalGroupRids.RemoteDesktopUsers),
		("Remote Management Users", LocalGroupRids.PSRemote),
		("Distributed COM Users", LocalGroupRids.DcomUsers)
	};

	internal static async Task<LdapWrapper> ParseGPOLocalGroups(LdapWrapper wrapper)
	{
		if (wrapper is OU || wrapper is Domain)
		{
			await ParseLinkedObject(wrapper);
		}
		return wrapper;
	}

	private static async Task ParseLinkedObject(LdapWrapper target)
	{
		SearchResultEntry searchResultEntry = target.SearchResult;
		string gpLinks = searchResultEntry.GetProperty("gplink");
		if (gpLinks == null)
		{
			return;
		}
		DirectorySearch searcher = Helpers.GetDirectorySearcher(target.Domain);
		List<string> affectedComputers = new List<string>();
		Domain testDomain = target as Domain;
		if (testDomain != null && testDomain.Computers.Length != 0)
		{
			affectedComputers = new List<string>(testDomain.Computers);
		}
		else
		{
			OU testOu = target as OU;
			if (testOu != null && testOu.Computers.Length != 0)
			{
				affectedComputers = new List<string>(testOu.Computers);
			}
			else
			{
				foreach (SearchResultEntry computerResult in searcher.QueryLdap("(samaccounttype=805306369)", new string[1] { "objectsid" }, (SearchScope)2, target.DistinguishedName))
				{
					string sid = computerResult.GetSid();
					if (sid != null)
					{
						affectedComputers.Add(sid);
					}
				}
			}
		}
		if (affectedComputers.Count == 0)
		{
			return;
		}
		List<string> links = Enumerable.ToList(Enumerable.Where(gpLinks.Split(']', '['), (string link) => link.StartsWith("LDAP", ignoreCase: true, null)));
		List<string> enforced = new List<string>();
		List<string> unenforced = new List<string>();
		foreach (string link2 in links)
		{
			string status = link2.Split(new char[1] { ';' })[1];
			if (!(status == "1") && !(status == "3"))
			{
				if (status == "0")
				{
					unenforced.Add(link2);
				}
				if (status == "2")
				{
					enforced.Add(link2);
				}
			}
		}
		links = new List<string>();
		links.AddRange(unenforced);
		links.AddRange(enforced);
		Dictionary<LocalGroupRids, GroupResults> data = new Dictionary<LocalGroupRids, GroupResults>();
		foreach (object rid in Enum.GetValues(typeof(LocalGroupRids)))
		{
			data[(LocalGroupRids)rid] = new GroupResults();
		}
		foreach (string link3 in links)
		{
			string[] split = link3.Split(new char[1] { ';' });
			string gpoDistinguishedName = split[0];
			gpoDistinguishedName = gpoDistinguishedName.Substring(gpoDistinguishedName.IndexOf("CN=", StringComparison.OrdinalIgnoreCase));
			if (!GpoActionCache.TryGetValue(gpoDistinguishedName, out var actions))
			{
				actions = new List<GroupAction>();
				string gpoDomain = Helpers.DistinguishedNameToDomain(gpoDistinguishedName);
				string baseFilePath = (await searcher.GetOne("(objectclass=*)", new string[1] { "gpcfilesyspath" }, (SearchScope)0, gpoDistinguishedName))?.GetProperty("gpcfilesyspath");
				if (baseFilePath == null)
				{
					GpoActionCache.TryAdd(gpoDistinguishedName, actions);
					continue;
				}
				List<GroupAction> list = actions;
				list.AddRange(await ProcessGPOXml(baseFilePath, gpoDomain));
				List<GroupAction> list2 = actions;
				list2.AddRange(await ProcessGPOTmpl(baseFilePath, gpoDomain));
			}
			GpoActionCache.TryAdd(gpoDistinguishedName, actions);
			if (actions.Count == 0)
			{
				continue;
			}
			IEnumerable<IGrouping<LocalGroupRids, (LocalGroupRids TargetRid, string TargetSid, LdapTypeEnum TargetType)>> restrictedMemberSets = Enumerable.GroupBy<(LocalGroupRids, string, LdapTypeEnum), LocalGroupRids>(Enumerable.Select(Enumerable.Where(actions, (GroupAction x) => x.Target == GroupActionTarget.RestrictedMember), (GroupAction x) => (x.TargetRid, x.TargetSid, x.TargetType)), ((LocalGroupRids TargetRid, string TargetSid, LdapTypeEnum TargetType) x) => x.TargetRid);
			foreach (IGrouping<LocalGroupRids, (LocalGroupRids, string, LdapTypeEnum)> set3 in restrictedMemberSets)
			{
				GroupResults results3 = data[set3.Key];
				List<GenericMember> members2 = (results3.RestrictedMember = Enumerable.ToList(Enumerable.Select<(LocalGroupRids, string, LdapTypeEnum), GenericMember>(set3, ((LocalGroupRids TargetRid, string TargetSid, LdapTypeEnum TargetType) x) => new GenericMember
				{
					MemberId = x.TargetSid,
					MemberType = x.TargetType
				})));
				data[set3.Key] = results3;
			}
			IEnumerable<IGrouping<LocalGroupRids, (LocalGroupRids TargetRid, string TargetSid, LdapTypeEnum TargetType)>> restrictedMemberOfSets = Enumerable.GroupBy<(LocalGroupRids, string, LdapTypeEnum), LocalGroupRids>(Enumerable.Select(Enumerable.Where(actions, (GroupAction x) => x.Target == GroupActionTarget.RestrictedMemberOf), (GroupAction x) => (x.TargetRid, x.TargetSid, x.TargetType)), ((LocalGroupRids TargetRid, string TargetSid, LdapTypeEnum TargetType) x) => x.TargetRid);
			foreach (IGrouping<LocalGroupRids, (LocalGroupRids, string, LdapTypeEnum)> set2 in restrictedMemberOfSets)
			{
				GroupResults results2 = data[set2.Key];
				List<GenericMember> members = Enumerable.ToList(Enumerable.Select<(LocalGroupRids, string, LdapTypeEnum), GenericMember>(set2, ((LocalGroupRids TargetRid, string TargetSid, LdapTypeEnum TargetType) x) => new GenericMember
				{
					MemberId = x.TargetSid,
					MemberType = x.TargetType
				}));
				results2.RestrictedMemberOf.AddRange(members);
				data[set2.Key] = results2;
			}
			IEnumerable<IGrouping<LocalGroupRids, (LocalGroupRids TargetRid, string TargetSid, LdapTypeEnum TargetType, GroupActionOperation Action)>> restrictedLocalGroupSets = Enumerable.GroupBy<(LocalGroupRids, string, LdapTypeEnum, GroupActionOperation), LocalGroupRids>(Enumerable.Select(Enumerable.Where(actions, (GroupAction x) => x.Target == GroupActionTarget.LocalGroup), (GroupAction x) => (x.TargetRid, x.TargetSid, x.TargetType, x.Action)), ((LocalGroupRids TargetRid, string TargetSid, LdapTypeEnum TargetType, GroupActionOperation Action) x) => x.TargetRid);
			foreach (IGrouping<LocalGroupRids, (LocalGroupRids, string, LdapTypeEnum, GroupActionOperation)> set in restrictedLocalGroupSets)
			{
				GroupResults results = data[set.Key];
				foreach (var item in set)
				{
					string targetSid = item.Item2;
					LdapTypeEnum targetType = item.Item3;
					GroupActionOperation action = item.Item4;
					List<GenericMember> groupResults = results.LocalGroups;
					if (action == GroupActionOperation.DeleteGroups)
					{
						groupResults.RemoveAll((GenericMember x) => x.MemberType == LdapTypeEnum.Group);
					}
					if (action == GroupActionOperation.DeleteUsers)
					{
						groupResults.RemoveAll((GenericMember x) => x.MemberType == LdapTypeEnum.User);
					}
					if (action == GroupActionOperation.Add)
					{
						groupResults.Add(new GenericMember
						{
							MemberType = targetType,
							MemberId = targetSid
						});
					}
					if (action == GroupActionOperation.Delete)
					{
						groupResults.RemoveAll((GenericMember x) => x.MemberId == targetSid);
					}
					data[set.Key].LocalGroups = groupResults;
				}
			}
			actions = null;
		}
		bool affectsComputers = false;
		if (target is Domain domain)
		{
			foreach (KeyValuePair<LocalGroupRids, GroupResults> x3 in data)
			{
				List<GenericMember> restrictedMember2 = x3.Value.RestrictedMember;
				List<GenericMember> restrictedMemberOf2 = x3.Value.RestrictedMemberOf;
				List<GenericMember> groupMember2 = x3.Value.LocalGroups;
				List<GenericMember> finalMembers4 = new List<GenericMember>();
				if (restrictedMember2.Count > 0)
				{
					finalMembers4.AddRange(restrictedMember2);
					finalMembers4.AddRange(restrictedMemberOf2);
				}
				else
				{
					finalMembers4.AddRange(restrictedMemberOf2);
					finalMembers4.AddRange(groupMember2);
				}
				finalMembers4 = Enumerable.ToList(Enumerable.Distinct(finalMembers4));
				if (finalMembers4.Count > 0)
				{
					affectsComputers = true;
				}
				switch (x3.Key)
				{
				case LocalGroupRids.RemoteDesktopUsers:
					domain.RemoteDesktopUsers = finalMembers4.ToArray();
					break;
				case LocalGroupRids.Administrators:
					domain.LocalAdmins = finalMembers4.ToArray();
					break;
				case LocalGroupRids.PSRemote:
					domain.PSRemoteUsers = finalMembers4.ToArray();
					break;
				case LocalGroupRids.DcomUsers:
					domain.DcomUsers = finalMembers4.ToArray();
					break;
				default:
					throw new ArgumentOutOfRangeException();
				}
			}
			if (affectsComputers && domain.Computers.Length == 0)
			{
				domain.Computers = affectedComputers.ToArray();
			}
		}
		if (!(target is OU ou))
		{
			return;
		}
		foreach (KeyValuePair<LocalGroupRids, GroupResults> x2 in data)
		{
			List<GenericMember> restrictedMember = x2.Value.RestrictedMember;
			List<GenericMember> restrictedMemberOf = x2.Value.RestrictedMemberOf;
			List<GenericMember> groupMember = x2.Value.LocalGroups;
			List<GenericMember> finalMembers2 = new List<GenericMember>();
			if (restrictedMember.Count > 0)
			{
				finalMembers2.AddRange(restrictedMember);
				finalMembers2.AddRange(restrictedMemberOf);
			}
			else
			{
				finalMembers2.AddRange(restrictedMemberOf);
				finalMembers2.AddRange(groupMember);
			}
			finalMembers2 = Enumerable.ToList(Enumerable.Distinct(finalMembers2));
			if (finalMembers2.Count > 0)
			{
				affectsComputers = true;
			}
			switch (x2.Key)
			{
			case LocalGroupRids.RemoteDesktopUsers:
				ou.RemoteDesktopUsers = finalMembers2.ToArray();
				break;
			case LocalGroupRids.Administrators:
				ou.LocalAdmins = finalMembers2.ToArray();
				break;
			case LocalGroupRids.PSRemote:
				ou.PSRemoteUsers = finalMembers2.ToArray();
				break;
			case LocalGroupRids.DcomUsers:
				ou.DcomUsers = finalMembers2.ToArray();
				break;
			default:
				throw new ArgumentOutOfRangeException();
			}
		}
		if (affectsComputers && ou.Computers.Length == 0)
		{
			ou.Computers = affectedComputers.ToArray();
		}
	}

	private static async Task<List<GroupAction>> ProcessGPOTmpl(string basePath, string gpoDomain)
	{
		List<GroupAction> actions = new List<GroupAction>();
		string templatePath = basePath + "\\MACHINE\\Microsoft\\Windows NT\\SecEdit\\GptTmpl.inf";
		if (File.Exists(templatePath))
		{
			using StreamReader reader = new StreamReader(new FileStream(templatePath, FileMode.Open, FileAccess.Read));
			string content = await reader.ReadToEndAsync();
			Match memberMatch = MemberRegex.Match(content);
			if (memberMatch.Success)
			{
				string memberText = memberMatch.Groups[1].Value;
				string[] memberLines = Regex.Split(memberText.Trim(), "\\r\\n|\\r|\\n");
				string[] array = memberLines;
				foreach (string memberLine in array)
				{
					Match keyMatch = KeyRegex.Match(memberLine);
					string key = keyMatch.Groups[1].Value.Trim();
					string val = keyMatch.Groups[2].Value.Trim();
					Match leftMatch = MemberLeftRegex.Match(key);
					MatchCollection rightMatches = MemberRightRegex.Matches(val);
					if (leftMatch.Success)
					{
						Match extracted = ExtractRid.Match(leftMatch.Value);
						int rid2 = int.Parse(extracted.Groups[1].Value);
						if (Enum.IsDefined(typeof(LocalGroupRids), rid2))
						{
							string[] array2 = val.Split(new char[1] { ',' });
							foreach (string member in array2)
							{
								var (success3, sid3, type2) = await GetSid(member.Trim(new char[1] { '*' }), gpoDomain);
								if (success3)
								{
									actions.Add(new GroupAction
									{
										Target = GroupActionTarget.RestrictedMember,
										Action = GroupActionOperation.Add,
										TargetSid = sid3,
										TargetType = type2,
										TargetRid = (LocalGroupRids)rid2
									});
								}
							}
						}
					}
					int index = key.IndexOf("MemberOf", StringComparison.CurrentCultureIgnoreCase);
					if (rightMatches.Count <= 0 || index <= 0)
					{
						continue;
					}
					string sid2 = key.Trim(new char[1] { '*' }).Substring(0, index - 3).ToUpper();
					LdapTypeEnum type;
					if (!sid2.StartsWith("S-1-5", StringComparison.OrdinalIgnoreCase))
					{
						LdapTypeEnum lType2;
						bool success2;
						string aSid3;
						(success2, aSid3, lType2) = await ResolutionHelpers.ResolveAccountNameToSidAndType(sid2, gpoDomain);
						if (!success2)
						{
							(bool success, string sid, LdapTypeEnum type) tuple3 = await ResolutionHelpers.ResolveAccountNameToSidAndType(sid2 + "$", gpoDomain);
							success2 = tuple3.success;
							aSid3 = tuple3.sid;
							lType2 = tuple3.type;
							sid2 = ((!success2) ? null : aSid3);
						}
						else
						{
							sid2 = aSid3;
						}
						type = lType2;
					}
					else
					{
						(string finalSid, LdapTypeEnum type) tuple4 = await ResolutionHelpers.ResolveSidAndGetType(sid2, gpoDomain);
						string aSid = tuple4.finalSid;
						LdapTypeEnum lType = tuple4.type;
						sid2 = aSid;
						type = lType;
					}
					if (sid2 == null)
					{
						continue;
					}
					foreach (object match in rightMatches)
					{
						int rid = int.Parse(ExtractRid.Match(match.ToString()).Groups[1].Value);
						if (Enum.IsDefined(typeof(LocalGroupRids), rid))
						{
							LocalGroupRids targetGroup = (LocalGroupRids)rid;
							actions.Add(new GroupAction
							{
								Target = GroupActionTarget.RestrictedMemberOf,
								Action = GroupActionOperation.Add,
								TargetRid = targetGroup,
								TargetSid = sid2,
								TargetType = type
							});
						}
					}
				}
			}
		}
		return actions;
	}

	private static async Task<List<GroupAction>> ProcessGPOXml(string basePath, string gpoDomain)
	{
		List<GroupAction> actions = new List<GroupAction>();
		string xmlPath = basePath + "\\MACHINE\\Preferences\\Groups\\Groups.xml";
		if (File.Exists(xmlPath))
		{
			XPathDocument doc = new XPathDocument(xmlPath);
			XPathNavigator navigator = doc.CreateNavigator();
			XPathNodeIterator groupsNodes = navigator.Select("/Groups");
			while (groupsNodes.MoveNext())
			{
				if (groupsNodes.Current!.GetAttribute("disabled", "") == "1")
				{
					continue;
				}
				XPathNodeIterator groupNodes = groupsNodes.Current!.Select("Group");
				while (groupNodes.MoveNext())
				{
					XPathNodeIterator groupProperties = groupNodes.Current!.Select("Properties");
					while (groupProperties.MoveNext())
					{
						XPathNavigator currentProperties = groupProperties.Current;
						string action = currentProperties.GetAttribute("action", "");
						if (!action.Equals("u", StringComparison.OrdinalIgnoreCase))
						{
							continue;
						}
						string groupSid = currentProperties.GetAttribute("groupSid", "");
						string groupName = currentProperties.GetAttribute("groupName", "");
						LocalGroupRids? targetGroup = null;
						if (!string.IsNullOrEmpty(groupSid))
						{
							Match sidMatch = ExtractRid.Match(groupSid);
							if (sidMatch.Success)
							{
								int rid = int.Parse(sidMatch.Groups[1].Value);
								if (Enum.IsDefined(typeof(LocalGroupRids), rid))
								{
									targetGroup = (LocalGroupRids)rid;
								}
							}
						}
						if (!targetGroup.HasValue && !string.IsNullOrEmpty(groupName))
						{
							(string groupName, LocalGroupRids rid) group = Enumerable.FirstOrDefault(ValidGroupNames, ((string groupName, LocalGroupRids rid) g) => g.groupName.Equals(groupName, StringComparison.OrdinalIgnoreCase));
							(string, LocalGroupRids) tuple = group;
							if (tuple.Item1 != null || tuple.Item2 != 0)
							{
								targetGroup = group.rid;
							}
						}
						if (!targetGroup.HasValue)
						{
							continue;
						}
						bool deleteUsers = currentProperties.GetAttribute("deleteAllUsers", "") == "1";
						bool deleteGroups = currentProperties.GetAttribute("deleteAllGroups", "") == "1";
						if (deleteUsers)
						{
							actions.Add(new GroupAction
							{
								Action = GroupActionOperation.DeleteUsers,
								Target = GroupActionTarget.LocalGroup,
								TargetRid = targetGroup.Value
							});
						}
						if (deleteGroups)
						{
							actions.Add(new GroupAction
							{
								Action = GroupActionOperation.DeleteGroups,
								Target = GroupActionTarget.LocalGroup,
								TargetRid = targetGroup.Value
							});
						}
						XPathNodeIterator members = currentProperties.Select("Members/Member");
						while (members.MoveNext())
						{
							GroupActionOperation memberAction = ((!members.Current!.GetAttribute("action", "").Equals("ADD", StringComparison.CurrentCulture)) ? GroupActionOperation.Delete : GroupActionOperation.Add);
							string memberName2 = members.Current!.GetAttribute("name", "");
							string memberSid = members.Current!.GetAttribute("sid", "");
							if (string.IsNullOrEmpty(memberSid))
							{
								if (!string.IsNullOrEmpty(memberName2) && memberName2.Contains("\\"))
								{
									string[] splitMember = memberName2.Split(new char[1] { '\\' });
									memberName2 = splitMember[1];
									string memberDomain = splitMember[0];
									var (success, lookupSid, lType) = await ResolutionHelpers.ResolveAccountNameToSidAndType(memberName2, memberDomain);
									if (success)
									{
										actions.Add(new GroupAction
										{
											Action = memberAction,
											Target = GroupActionTarget.LocalGroup,
											TargetSid = lookupSid,
											TargetType = lType,
											TargetRid = targetGroup.Value
										});
									}
								}
							}
							else
							{
								LdapTypeEnum memberType = await ResolutionHelpers.LookupSidType(memberSid, gpoDomain);
								actions.Add(new GroupAction
								{
									Action = memberAction,
									Target = GroupActionTarget.LocalGroup,
									TargetSid = memberSid,
									TargetType = memberType,
									TargetRid = targetGroup.Value
								});
							}
						}
					}
				}
			}
		}
		return actions;
	}

	private static async Task<(bool success, string sid, LdapTypeEnum type)> GetSid(string element, string domainName)
	{
		if (!element.StartsWith("S-1-", StringComparison.CurrentCulture))
		{
			string domain;
			string user2;
			if (Enumerable.Contains(element, '\\'))
			{
				string[] split = element.Split(new char[1] { '\\' });
				domain = split[0];
				user2 = split[1];
			}
			else
			{
				domain = domainName;
				user2 = element;
			}
			user2 = user2.ToUpper();
			string sid;
			LdapTypeEnum type;
			bool success2;
			(success2, sid, type) = await ResolutionHelpers.ResolveAccountNameToSidAndType(user2, domain);
			if (!success2)
			{
				(success2, sid, type) = await ResolutionHelpers.ResolveAccountNameToSidAndType(user2 + "$", domain);
				if (!success2)
				{
					return (false, null, LdapTypeEnum.Unknown);
				}
			}
			return (true, sid, type);
		}
		return (true, element, await ResolutionHelpers.LookupSidType(element, domainName));
	}
}
