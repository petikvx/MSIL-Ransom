using System.Security.Principal;

namespace SmartAssembly.Shared.IdentityHelper;

public static class WinIdentity
{
	public static string GetUser()
	{
		return WindowsIdentity.GetCurrent().User!.ToString();
	}
}
