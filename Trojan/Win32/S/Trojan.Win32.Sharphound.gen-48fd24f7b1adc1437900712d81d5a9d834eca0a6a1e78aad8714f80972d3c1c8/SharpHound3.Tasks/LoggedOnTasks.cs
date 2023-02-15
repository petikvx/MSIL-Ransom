using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.Win32;
using SharpHound3.Enums;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;

namespace SharpHound3.Tasks;

internal class LoggedOnTasks
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct WKSTA_USER_INFO_1
	{
		public string wkui1_username;

		public string wkui1_logon_domain;

		public string wkui1_oth_domains;

		public string wkui1_logon_server;
	}

	private static readonly Regex SidRegex = new Regex("S-1-5-21-[0-9]+-[0-9]+-[0-9]+-[0-9]+$", RegexOptions.Compiled);

	internal static async Task<LdapWrapper> ProcessLoggedOn(LdapWrapper wrapper)
	{
		if (wrapper is Computer computer && computer.IsWindows && !computer.PingFailed)
		{
			List<Session> sessions = new List<Session>();
			List<Session> list = sessions;
			list.AddRange(await GetLoggedOnUsersAPI(computer));
			List<Session> temp = Enumerable.ToList(computer.Sessions);
			temp.AddRange(sessions);
			computer.Sessions = Enumerable.ToArray(Enumerable.Distinct(temp));
		}
		await Helpers.DoDelay();
		return wrapper;
	}

	private static async Task<List<Session>> GetLoggedOnUsersAPI(Computer computer)
	{
		int resumeHandle = 0;
		Type workstationInfoType = typeof(WKSTA_USER_INFO_1);
		IntPtr ptrInfo = IntPtr.Zero;
		int entriesRead = 0;
		List<Session> sessionList = new List<Session>();
		try
		{
			int totalentries;
			Task<int> task = Task.Run(() => NetWkstaUserEnum(computer.APIName, 1, out ptrInfo, -1, out entriesRead, out totalentries, ref resumeHandle));
			if (await Task.WhenAny(new Task[2]
			{
				task,
				Task.Delay(10000)
			}) != task)
			{
				if (Options.Instance.DumpComputerStatus)
				{
					OutputTasks.AddComputerStatus(new ComputerStatus
					{
						ComputerName = computer.DisplayName,
						Status = "Timeout",
						Task = "NetWkstaUserEnum"
					});
				}
				return sessionList;
			}
			int taskResult = task.Result;
			if (taskResult != 0 && taskResult != 234)
			{
				if (Options.Instance.DumpComputerStatus)
				{
					ComputerStatus obj = new ComputerStatus
					{
						ComputerName = computer.DisplayName
					};
					NetApiStatus netApiStatus = (NetApiStatus)taskResult;
					obj.Status = netApiStatus.ToString();
					obj.Task = "NetWkstaUserEnum";
					OutputTasks.AddComputerStatus(obj);
				}
				return sessionList;
			}
			IntPtr iterator = ptrInfo;
			if (Options.Instance.DumpComputerStatus)
			{
				OutputTasks.AddComputerStatus(new ComputerStatus
				{
					ComputerName = computer.DisplayName,
					Status = "Success",
					Task = "NetWkstaUserEnum"
				});
			}
			for (int i = 0; i < entriesRead; i++)
			{
				WKSTA_USER_INFO_1 data = (WKSTA_USER_INFO_1)Marshal.PtrToStructure(iterator, workstationInfoType);
				iterator = (IntPtr)(iterator.ToInt64() + Marshal.SizeOf(workstationInfoType));
				string domain = data.wkui1_logon_domain;
				string username = data.wkui1_username;
				if (!domain.Equals(computer.SamAccountName, StringComparison.CurrentCultureIgnoreCase) && !(username.Trim() == "") && !username.EndsWith("$") && !(username == "ANONYMOUS LOGON") && !(username == Options.Instance.CurrentUserName) && !domain.Contains(" "))
				{
					var (rSuccess, sid, _) = await ResolutionHelpers.ResolveAccountNameToSidAndType(username, domain);
					if (rSuccess)
					{
						sessionList.Add(new Session
						{
							UserId = sid,
							ComputerId = computer.ObjectIdentifier
						});
					}
					else
					{
						sessionList.Add(new Session
						{
							UserId = (username + "@" + Helpers.NormalizeDomainName(domain)).ToUpper(),
							ComputerId = computer.ObjectIdentifier
						});
					}
				}
			}
			return sessionList;
		}
		finally
		{
			if (ptrInfo != IntPtr.Zero)
			{
				NetApiBufferFree(ptrInfo);
			}
		}
	}

	private static async Task<List<Session>> GetLoggedOnUsersRegistry(Computer computer)
	{
		List<Session> sessionList = new List<Session>();
		if (!Options.Instance.NoRegistryLoggedOn)
		{
			RegistryKey key = null;
			try
			{
				Task<RegistryKey> task = Task.Run(() => RegistryKey.OpenRemoteBaseKey(RegistryHive.Users, computer.APIName));
				if (await Task.WhenAny(new Task[2]
				{
					task,
					Task.Delay(10000)
				}) != task)
				{
					if (Options.Instance.DumpComputerStatus)
					{
						OutputTasks.AddComputerStatus(new ComputerStatus
						{
							ComputerName = computer.DisplayName,
							Status = "Timeout",
							Task = "RegistryLoggedOn"
						});
					}
					return sessionList;
				}
				key = task.Result;
				IEnumerable<string> filteredKeys = Enumerable.Where(key.GetSubKeyNames(), (string subkey) => SidRegex.IsMatch(subkey));
				foreach (string sid in filteredKeys)
				{
					sessionList.Add(new Session
					{
						ComputerId = computer.ObjectIdentifier,
						UserId = sid
					});
				}
				if (Options.Instance.DumpComputerStatus)
				{
					OutputTasks.AddComputerStatus(new ComputerStatus
					{
						ComputerName = computer.DisplayName,
						Status = "Success",
						Task = "RegistryLoggedOn"
					});
				}
				return sessionList;
			}
			catch (Exception ex)
			{
				Exception e = ex;
				if (Options.Instance.DumpComputerStatus)
				{
					OutputTasks.AddComputerStatus(new ComputerStatus
					{
						ComputerName = computer.DisplayName,
						Status = e.Message,
						Task = "RegistryLoggedOn"
					});
				}
				return sessionList;
			}
			finally
			{
				key?.Dispose();
			}
		}
		return sessionList;
	}

	[DllImport("netapi32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	private static extern int NetWkstaUserEnum(string servername, int level, out IntPtr bufptr, int prefmaxlen, out int entriesread, out int totalentries, ref int resume_handle);

	[DllImport("netapi32.dll")]
	private static extern int NetApiBufferFree(IntPtr Buff);
}
