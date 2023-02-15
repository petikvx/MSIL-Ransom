using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using SharpHound3.Enums;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;

namespace SharpHound3.Tasks;

internal class NetSessionTasks
{
	public struct SESSION_INFO_10
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string sesi10_cname;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string sesi10_username;

		public uint sesi10_time;

		public uint sesi10_idle_time;
	}

	internal static async Task<LdapWrapper> ProcessNetSessions(LdapWrapper wrapper)
	{
		Computer computer = wrapper as Computer;
		if (computer != null && computer.IsWindows && !computer.PingFailed)
		{
			if (Options.Instance.ExcludeDomainControllers && computer.IsDomainController)
			{
				return wrapper;
			}
			if (Options.Instance.Stealth && !computer.IsStealthTarget)
			{
				return wrapper;
			}
			List<Session> sessions = await GetNetSessions(computer);
			List<Session> temp = Enumerable.ToList(computer.Sessions);
			temp.AddRange(sessions);
			computer.Sessions = Enumerable.ToArray(Enumerable.Distinct(temp));
			await Helpers.DoDelay();
		}
		return wrapper;
	}

	private static async Task<List<Session>> GetNetSessions(Computer computer)
	{
		IntPtr resumeHandle = IntPtr.Zero;
		Type sessionInfoType = typeof(SESSION_INFO_10);
		int entriesRead = 0;
		IntPtr ptrInfo = IntPtr.Zero;
		List<Session> sessionList = new List<Session>();
		try
		{
			int totalentries;
			Task<int> task = Task.Run(() => NetSessionEnum(computer.APIName, null, null, 10, out ptrInfo, -1, out entriesRead, out totalentries, ref resumeHandle));
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
						Task = "NetSessionEnum"
					});
				}
				return sessionList;
			}
			int taskResult = task.Result;
			if (taskResult != 0)
			{
				if (Options.Instance.DumpComputerStatus)
				{
					ComputerStatus obj = new ComputerStatus
					{
						ComputerName = computer.DisplayName
					};
					NetApiStatus netApiStatus = (NetApiStatus)taskResult;
					obj.Status = netApiStatus.ToString();
					obj.Task = "NetSessionEnum";
					OutputTasks.AddComputerStatus(obj);
				}
				return sessionList;
			}
			SESSION_INFO_10[] sessions = new SESSION_INFO_10[entriesRead];
			IntPtr iterator = ptrInfo;
			for (int i = 0; i < entriesRead; i++)
			{
				sessions[i] = (SESSION_INFO_10)Marshal.PtrToStructure(iterator, sessionInfoType);
				iterator = (IntPtr)(iterator.ToInt64() + Marshal.SizeOf(sessionInfoType));
			}
			if (Options.Instance.DumpComputerStatus)
			{
				OutputTasks.AddComputerStatus(new ComputerStatus
				{
					ComputerName = computer.DisplayName,
					Status = "Success",
					Task = "NetSessionEnum"
				});
			}
			SESSION_INFO_10[] array = sessions;
			for (int j = 0; j < array.Length; j++)
			{
				SESSION_INFO_10 session = array[j];
				string sessionUsername = session.sesi10_username;
				string computerName = session.sesi10_cname;
				if (computerName == null)
				{
					continue;
				}
				string computerSid2 = null;
				if (sessionUsername.EndsWith("$") || sessionUsername.Trim() == "" || sessionUsername == "$" || sessionUsername == Options.Instance.CurrentUserName || sessionUsername == "ANONYMOUS LOGON")
				{
					continue;
				}
				if (computerName.StartsWith("\\"))
				{
					computerName = computerName.TrimStart(new char[1] { '\\' });
				}
				if (string.IsNullOrEmpty(computerName))
				{
					continue;
				}
				if (computerName.Equals("[::1]") || computerName.Equals("127.0.0.1"))
				{
					computerSid2 = computer.ObjectIdentifier;
				}
				string text = computerSid2;
				string text2 = text;
				if (text2 == null)
				{
					text2 = await ResolutionHelpers.ResolveHostToSid(computerName, computer.Domain);
				}
				computerSid2 = text2;
				DirectorySearch searcher = Helpers.GetDirectorySearcher(computer.Domain);
				string[] sids = await searcher.LookupUserInGC(sessionUsername);
				if (sids != null && sids.Length != 0)
				{
					string[] array2 = sids;
					foreach (string sid2 in array2)
					{
						sessionList.Add(new Session
						{
							ComputerId = computerSid2,
							UserId = sid2
						});
					}
					continue;
				}
				var (success, sid, _) = await ResolutionHelpers.ResolveAccountNameToSidAndType(sessionUsername, computer.Domain);
				if (!success)
				{
					sessionList.Add(new Session
					{
						ComputerId = computerSid2,
						UserId = sessionUsername
					});
				}
				else
				{
					sessionList.Add(new Session
					{
						ComputerId = computerSid2,
						UserId = sid
					});
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

	[DllImport("NetAPI32.dll", SetLastError = true)]
	private static extern int NetSessionEnum([MarshalAs(UnmanagedType.LPWStr)] string ServerName, [MarshalAs(UnmanagedType.LPWStr)] string UncClientName, [MarshalAs(UnmanagedType.LPWStr)] string UserName, int Level, out IntPtr bufptr, int prefmaxlen, out int entriesread, out int totalentries, ref IntPtr resume_handle);

	[DllImport("netapi32.dll")]
	private static extern int NetApiBufferFree(IntPtr Buff);
}
