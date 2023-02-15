using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading.Tasks;
using SharpHound3.Enums;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;

namespace SharpHound3.Tasks;

internal class LocalGroupTasks
{
	internal enum NtStatus
	{
		StatusSuccess = 0,
		StatusMoreEntries = 261,
		StatusSomeMapped = 263,
		StatusInvalidHandle = -1073741816,
		StatusInvalidParameter = -1073741811,
		StatusAccessDenied = -1073741790,
		StatusObjectTypeMismatch = -1073741788,
		StatusNoSuchDomain = -1073741601,
		StatusRpcServerUnavailable = -1073610729,
		StatusRpcCallFailedDidNotExecute = -1073610724
	}

	internal struct UNICODE_STRING
	{
		public ushort Length;

		public ushort MaximumLength;

		[MarshalAs(UnmanagedType.LPWStr)]
		private string buffer;

		internal UNICODE_STRING(string s)
		{
			if (string.IsNullOrEmpty(s))
			{
				buffer = string.Empty;
			}
			else
			{
				buffer = s;
			}
			Length = (ushort)(2 * buffer.Length);
			MaximumLength = Length;
		}

		public override string ToString()
		{
			if (Length != 0)
			{
				return buffer.Substring(0, (int)Length / 2);
			}
			return string.Empty;
		}
	}

	internal struct OBJECT_ATTRIBUTES
	{
		public int Length;

		public IntPtr RootDirectory;

		public uint Attributes;

		public IntPtr SecurityDescriptor;

		public IntPtr QualityOfService;

		private IntPtr _objectName;

		public UNICODE_STRING ObjectName;

		public void Dispose()
		{
			if (!(_objectName == IntPtr.Zero))
			{
				Marshal.DestroyStructure(_objectName, typeof(UNICODE_STRING));
				Marshal.FreeHGlobal(_objectName);
				_objectName = IntPtr.Zero;
			}
		}
	}

	internal struct SamSidEnumeration
	{
		public IntPtr sid;

		public UNICODE_STRING Name;
	}

	private static readonly Lazy<byte[]> LocalSidBytes = new Lazy<byte[]>(delegate
	{
		SecurityIdentifier securityIdentifier = new SecurityIdentifier("S-1-5-32");
		byte[] array = new byte[securityIdentifier.BinaryLength];
		securityIdentifier.GetBinaryForm(array, 0);
		return array;
	});

	internal static async Task<LdapWrapper> GetLocalGroupMembers(LdapWrapper wrapper)
	{
		Computer computer = wrapper as Computer;
		if (computer != null && computer.IsWindows && !computer.PingFailed)
		{
			CollectionMethodResolved opts = Options.Instance.ResolvedCollectionMethods;
			if ((opts & CollectionMethodResolved.DCOM) != 0)
			{
				List<GenericMember> temp4 = Enumerable.ToList(computer.DcomUsers);
				List<GenericMember> list = temp4;
				list.AddRange(Enumerable.Distinct(await GetNetLocalGroupMembers(computer, LocalGroupRids.DcomUsers)));
				computer.DcomUsers = temp4.ToArray();
				await Helpers.DoDelay();
			}
			if ((opts & CollectionMethodResolved.LocalAdmin) != 0)
			{
				List<GenericMember> temp3 = Enumerable.ToList(computer.LocalAdmins);
				List<GenericMember> list2 = temp3;
				list2.AddRange(Enumerable.Distinct(await GetNetLocalGroupMembers(computer, LocalGroupRids.Administrators)));
				computer.LocalAdmins = temp3.ToArray();
				await Helpers.DoDelay();
			}
			if ((opts & CollectionMethodResolved.RDP) != 0)
			{
				List<GenericMember> temp2 = Enumerable.ToList(computer.RemoteDesktopUsers);
				List<GenericMember> list3 = temp2;
				list3.AddRange(Enumerable.Distinct(await GetNetLocalGroupMembers(computer, LocalGroupRids.RemoteDesktopUsers)));
				computer.RemoteDesktopUsers = temp2.ToArray();
				await Helpers.DoDelay();
			}
			if ((opts & CollectionMethodResolved.PSRemote) != 0)
			{
				List<GenericMember> temp = Enumerable.ToList(computer.PSRemoteUsers);
				List<GenericMember> list4 = temp;
				list4.AddRange(Enumerable.Distinct(await GetNetLocalGroupMembers(computer, LocalGroupRids.PSRemote)));
				computer.PSRemoteUsers = temp.ToArray();
				await Helpers.DoDelay();
			}
		}
		return wrapper;
	}

	private static async Task<List<GenericMember>> GetNetLocalGroupMembers(Computer computer, LocalGroupRids rid)
	{
		IntPtr[] sids = new IntPtr[0];
		List<GenericMember> groupMemberList = new List<GenericMember>();
		Task<bool> task = Task.Run(() => CallLocalGroupApi(computer, rid, out sids));
		if (await Task.WhenAny(new Task[2]
		{
			task,
			Task.Delay(10000)
		}) != task)
		{
			OutputTasks.AddComputerStatus(new ComputerStatus
			{
				ComputerName = computer.DisplayName,
				Status = "Timeout",
				Task = $"GetNetLocalGroup-{rid}"
			});
			return groupMemberList;
		}
		if (!task.Result)
		{
			return groupMemberList;
		}
		if (Options.Instance.DumpComputerStatus)
		{
			OutputTasks.AddComputerStatus(new ComputerStatus
			{
				ComputerName = computer.DisplayName,
				Status = "Success",
				Task = $"GetNetLocalGroup-{rid}"
			});
		}
		List<string> convertedSids = new List<string>();
		for (int i = 0; i < sids.Length; i++)
		{
			try
			{
				string sid = new SecurityIdentifier(sids[i]).Value;
				convertedSids.Add(sid);
			}
			catch
			{
			}
			finally
			{
				sids[i] = IntPtr.Zero;
			}
		}
		sids = null;
		string domainSid = computer.ObjectIdentifier.Substring(0, computer.ObjectIdentifier.LastIndexOf('-'));
		string machineSid = Enumerable.FirstOrDefault(Enumerable.DefaultIfEmpty(convertedSids, "DUMMYSTRING"), (string x) => x.EndsWith("-500") && !x.StartsWith(domainSid)) ?? "DUMMYSTRING";
		if (machineSid.StartsWith("S-1-5-21"))
		{
			machineSid = machineSid.Substring(0, machineSid.LastIndexOf('-'));
		}
		foreach (string sid2 in convertedSids)
		{
			if (!sid2.StartsWith(machineSid))
			{
				var (finalSid, type) = await ResolutionHelpers.ResolveSidAndGetType(sid2, computer.Domain);
				if (finalSid != null)
				{
					groupMemberList.Add(new GenericMember
					{
						MemberType = type,
						MemberId = finalSid
					});
				}
			}
		}
		return groupMemberList;
	}

	private static bool CallLocalGroupApi(Computer computer, LocalGroupRids rid, out IntPtr[] sids)
	{
		IntPtr serverHandle = IntPtr.Zero;
		IntPtr domainHandle = IntPtr.Zero;
		IntPtr aliasHandle = IntPtr.Zero;
		IntPtr members = IntPtr.Zero;
		sids = new IntPtr[0];
		UNICODE_STRING serverName = new UNICODE_STRING(computer.APIName);
		OBJECT_ATTRIBUTES objectAttributes = default(OBJECT_ATTRIBUTES);
		try
		{
			NtStatus ntStatus = SamConnect(ref serverName, out serverHandle, 33, ref objectAttributes);
			switch (ntStatus)
			{
			default:
				if (Options.Instance.DumpComputerStatus)
				{
					OutputTasks.AddComputerStatus(new ComputerStatus
					{
						ComputerName = computer.DisplayName,
						Status = ntStatus.ToString(),
						Task = $"GetNetLocalGroup-{rid}"
					});
				}
				return false;
			case NtStatus.StatusSuccess:
			{
				ntStatus = SamOpenDomain(serverHandle, 512, LocalSidBytes.Value, out domainHandle);
				if (ntStatus != 0)
				{
					if (Options.Instance.DumpComputerStatus)
					{
						OutputTasks.AddComputerStatus(new ComputerStatus
						{
							ComputerName = computer.DisplayName,
							Status = ntStatus.ToString(),
							Task = $"GetNetLocalGroup-{rid}"
						});
					}
					return false;
				}
				ntStatus = SamOpenAlias(domainHandle, 4, (int)rid, out aliasHandle);
				if (ntStatus != 0 && Options.Instance.DumpComputerStatus)
				{
					OutputTasks.AddComputerStatus(new ComputerStatus
					{
						ComputerName = computer.DisplayName,
						Status = ntStatus.ToString(),
						Task = $"GetNetLocalGroup-{rid}"
					});
				}
				ntStatus = SamGetMembersInAlias(aliasHandle, out members, out var count);
				if (ntStatus != 0)
				{
					if (Options.Instance.DumpComputerStatus)
					{
						OutputTasks.AddComputerStatus(new ComputerStatus
						{
							ComputerName = computer.DisplayName,
							Status = ntStatus.ToString(),
							Task = $"GetNetLocalGroup-{rid}"
						});
					}
					return false;
				}
				if (count == 0)
				{
					return false;
				}
				sids = new IntPtr[count];
				Marshal.Copy(members, sids, 0, count);
				return true;
			}
			case NtStatus.StatusRpcServerUnavailable:
				if (Options.Instance.DumpComputerStatus)
				{
					OutputTasks.AddComputerStatus(new ComputerStatus
					{
						ComputerName = computer.DisplayName,
						Status = ntStatus.ToString(),
						Task = $"GetNetLocalGroup-{rid}"
					});
				}
				return false;
			}
		}
		finally
		{
			if (serverHandle != IntPtr.Zero)
			{
				SamCloseHandle(serverHandle);
			}
			if (domainHandle != IntPtr.Zero)
			{
				SamCloseHandle(domainHandle);
			}
			if (aliasHandle != IntPtr.Zero)
			{
				SamCloseHandle(aliasHandle);
			}
			if (members != IntPtr.Zero)
			{
				SamFreeMemory(members);
			}
		}
	}

	[DllImport("samlib.dll")]
	internal static extern NtStatus SamConnect(ref UNICODE_STRING serverName, out IntPtr serverHandle, int desiredAccess, ref OBJECT_ATTRIBUTES objectAttributes);

	[DllImport("samlib.dll")]
	internal static extern NtStatus SamOpenDomain(IntPtr serverHandle, int desiredAccess, IntPtr domainId, out IntPtr domainHandle);

	[DllImport("samlib.dll")]
	internal static extern NtStatus SamLookupDomainInSamServer(IntPtr serverHandle, ref UNICODE_STRING name, out IntPtr securityIdentifier);

	[DllImport("samlib.dll")]
	internal static extern NtStatus SamOpenDomain(IntPtr serverHandle, int desiredAccess, [MarshalAs(UnmanagedType.LPArray)] byte[] securityIdentifierBytes, out IntPtr domainHandle);

	[DllImport("samlib.dll")]
	internal static extern NtStatus SamOpenAlias(IntPtr domainHandle, int desiredAccess, int aliasId, out IntPtr aliasHandle);

	[DllImport("samlib.dll")]
	internal static extern NtStatus SamGetMembersInAlias(IntPtr aliasHandle, out IntPtr members, out int count);

	[DllImport("samlib.dll")]
	internal static extern NtStatus SamCloseHandle(IntPtr handle);

	[DllImport("samlib.dll")]
	internal static extern NtStatus SamFreeMemory(IntPtr pointer);

	[DllImport("samlib.dll")]
	internal static extern NtStatus SamEnumerateDomainsInSamServer(IntPtr serverHandle, ref int enumerationContext, out IntPtr domains, int PrefMaxLen, out int count);
}
