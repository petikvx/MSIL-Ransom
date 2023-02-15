using SharpHound3.Enums;

namespace SharpHound3;

internal class CommonPrincipal
{
	private string _principalName;

	internal LdapTypeEnum Type { get; set; }

	internal string Name
	{
		get
		{
			return _principalName;
		}
		set
		{
			_principalName = value.ToUpper();
		}
	}

	public CommonPrincipal(string name, LdapTypeEnum type)
	{
		Name = name;
		Type = type;
	}

	public static bool GetCommonSid(string sid, out CommonPrincipal commonPrincipal)
	{
		switch (sid)
		{
		case "S-1-5-32-573":
			commonPrincipal = new CommonPrincipal("Event Log Readers", LdapTypeEnum.Group);
			break;
		case "S-1-5-80-0":
			commonPrincipal = new CommonPrincipal("All Services ", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-577":
			commonPrincipal = new CommonPrincipal("RDS Management Servers", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-546":
			commonPrincipal = new CommonPrincipal("Guests", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-576":
			commonPrincipal = new CommonPrincipal("RDS Endpoint Servers", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-547":
			commonPrincipal = new CommonPrincipal("Power Users", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-575":
			commonPrincipal = new CommonPrincipal("RDS Remote Access Servers", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-544":
			commonPrincipal = new CommonPrincipal("Administrators", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-559":
			commonPrincipal = new CommonPrincipal("Performance Log Users", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-545":
			commonPrincipal = new CommonPrincipal("Users", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-558":
			commonPrincipal = new CommonPrincipal("Performance Monitor Users", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-574":
			commonPrincipal = new CommonPrincipal("Certificate Service DCOM Access", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-578":
			commonPrincipal = new CommonPrincipal("Hyper-V Administrators", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-579":
			commonPrincipal = new CommonPrincipal("Access Control Assistance Operators", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-550":
			commonPrincipal = new CommonPrincipal("Print Operators", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-551":
			commonPrincipal = new CommonPrincipal("Backup Operators", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-552":
			commonPrincipal = new CommonPrincipal("Replicators", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-548":
			commonPrincipal = new CommonPrincipal("Account Operators", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-555":
			commonPrincipal = new CommonPrincipal("Remote Desktop Users", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-549":
			commonPrincipal = new CommonPrincipal("Server Operators", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-557":
			commonPrincipal = new CommonPrincipal("Incoming Forest Trust Builders", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-554":
			commonPrincipal = new CommonPrincipal("Pre-Windows 2000 Compatible Access", LdapTypeEnum.Group);
			break;
		case "S-1-0-0":
			commonPrincipal = new CommonPrincipal("Nobody", LdapTypeEnum.User);
			break;
		case "S-1-5-32-556":
			commonPrincipal = new CommonPrincipal("Network Configuration Operators", LdapTypeEnum.Group);
			break;
		case "S-1-1-0":
			commonPrincipal = new CommonPrincipal("Everyone", LdapTypeEnum.Group);
			break;
		case "S-1-5-20":
			commonPrincipal = new CommonPrincipal("NT Authority", LdapTypeEnum.User);
			break;
		case "S-1-2-1":
			commonPrincipal = new CommonPrincipal("Console Logon", LdapTypeEnum.Group);
			break;
		case "S-1-2-0":
			commonPrincipal = new CommonPrincipal("Local", LdapTypeEnum.Group);
			break;
		case "S-1-2":
			commonPrincipal = new CommonPrincipal("Local Authority", LdapTypeEnum.User);
			break;
		case "S-1-3":
			commonPrincipal = new CommonPrincipal("Creator Authority", LdapTypeEnum.User);
			break;
		case "S-1-0":
			commonPrincipal = new CommonPrincipal("Null Authority", LdapTypeEnum.User);
			break;
		case "S-1-1":
			commonPrincipal = new CommonPrincipal("World Authority", LdapTypeEnum.User);
			break;
		case "S-1-4":
			commonPrincipal = new CommonPrincipal("Non-unique Authority", LdapTypeEnum.User);
			break;
		case "S-1-5":
			commonPrincipal = new CommonPrincipal("NT Authority", LdapTypeEnum.User);
			break;
		case "S-1-5-7":
			commonPrincipal = new CommonPrincipal("Anonymous", LdapTypeEnum.Group);
			break;
		case "S-1-5-4":
			commonPrincipal = new CommonPrincipal("Interactive", LdapTypeEnum.Group);
			break;
		case "S-1-5-1":
			commonPrincipal = new CommonPrincipal("Dialup", LdapTypeEnum.Group);
			break;
		case "S-1-5-6":
			commonPrincipal = new CommonPrincipal("Service", LdapTypeEnum.Group);
			break;
		case "S-1-3-4":
			commonPrincipal = new CommonPrincipal("Owner Rights", LdapTypeEnum.Group);
			break;
		case "S-1-5-3":
			commonPrincipal = new CommonPrincipal("Batch", LdapTypeEnum.Group);
			break;
		case "S-1-3-3":
			commonPrincipal = new CommonPrincipal("Creator Group Server", LdapTypeEnum.Computer);
			break;
		case "S-1-5-2":
			commonPrincipal = new CommonPrincipal("Network", LdapTypeEnum.Group);
			break;
		case "S-1-3-1":
			commonPrincipal = new CommonPrincipal("Creator Group", LdapTypeEnum.Group);
			break;
		case "S-1-3-2":
			commonPrincipal = new CommonPrincipal("Creator Owner Server", LdapTypeEnum.Computer);
			break;
		case "S-1-5-9":
			commonPrincipal = new CommonPrincipal("Enterprise Domain Controllers", LdapTypeEnum.Group);
			break;
		case "S-1-3-0":
			commonPrincipal = new CommonPrincipal("Creator Owner", LdapTypeEnum.User);
			break;
		case "S-1-5-32-560":
			commonPrincipal = new CommonPrincipal("Windows Authorization Access Group", LdapTypeEnum.Group);
			break;
		case "S-1-5-8":
			commonPrincipal = new CommonPrincipal("Proxy", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-562":
			commonPrincipal = new CommonPrincipal("Distributed COM Users", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-561":
			commonPrincipal = new CommonPrincipal("Terminal Server License Servers", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-569":
			commonPrincipal = new CommonPrincipal("Cryptographic Operators", LdapTypeEnum.Group);
			break;
		case "S-1-5-32-568":
			commonPrincipal = new CommonPrincipal("IIS_IUSRS", LdapTypeEnum.Group);
			break;
		case "S-1-5-18":
			commonPrincipal = new CommonPrincipal("Local System", LdapTypeEnum.User);
			break;
		case "S-1-5-32-580":
			commonPrincipal = new CommonPrincipal("Remote Management Users", LdapTypeEnum.Group);
			break;
		case "S-1-5-114":
			commonPrincipal = new CommonPrincipal("Local Account and Member of Administrators Group", LdapTypeEnum.User);
			break;
		case "S-1-5-19":
			commonPrincipal = new CommonPrincipal("NT Authority", LdapTypeEnum.User);
			break;
		case "S-1-5-14":
			commonPrincipal = new CommonPrincipal("Remote Interactive Logon", LdapTypeEnum.Group);
			break;
		case "S-1-5-113":
			commonPrincipal = new CommonPrincipal("Local Account", LdapTypeEnum.User);
			break;
		case "S-1-5-17":
			commonPrincipal = new CommonPrincipal("This Organization ", LdapTypeEnum.Group);
			break;
		case "S-1-5-15":
			commonPrincipal = new CommonPrincipal("This Organization ", LdapTypeEnum.Group);
			break;
		case "S-1-5-11":
			commonPrincipal = new CommonPrincipal("Authenticated Users", LdapTypeEnum.Group);
			break;
		case "S-1-5-10":
			commonPrincipal = new CommonPrincipal("Principal Self", LdapTypeEnum.User);
			break;
		case "S-1-5-13":
			commonPrincipal = new CommonPrincipal("Terminal Server Users", LdapTypeEnum.Group);
			break;
		default:
			commonPrincipal = null;
			break;
		case "S-1-5-12":
			commonPrincipal = new CommonPrincipal("Restricted Code", LdapTypeEnum.Group);
			break;
		}
		return commonPrincipal != null;
	}
}
