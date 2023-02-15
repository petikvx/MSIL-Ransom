using System.DirectoryServices.Protocols;
using Newtonsoft.Json;
using SharpHound3.JSON;

namespace SharpHound3.LdapWrappers;

internal class Computer : LdapWrapper
{
	[JsonIgnore]
	public string SamAccountName { get; set; }

	public string[] AllowedToDelegate { get; set; }

	public GenericMember[] AllowedToAct { get; set; }

	public string PrimaryGroupSid { get; set; }

	public Session[] Sessions { get; set; }

	public GenericMember[] LocalAdmins { get; set; }

	public GenericMember[] RemoteDesktopUsers { get; set; }

	public GenericMember[] DcomUsers { get; set; }

	public GenericMember[] PSRemoteUsers { get; set; }

	[JsonIgnore]
	internal bool PingFailed { get; set; }

	[JsonIgnore]
	internal bool IsStealthTarget { get; set; }

	[JsonIgnore]
	internal bool IsDomainController { get; set; }

	[JsonIgnore]
	internal bool IsWindows { get; set; }

	[JsonIgnore]
	public string APIName => (Options.Instance.RealDNSName != null) ? (SamAccountName + "." + Options.Instance.RealDNSName) : base.DisplayName;

	internal Computer(SearchResultEntry entry)
		: base(entry)
	{
		AllowedToAct = new GenericMember[0];
		AllowedToDelegate = new string[0];
		Sessions = new Session[0];
		PingFailed = false;
		LocalAdmins = new GenericMember[0];
		RemoteDesktopUsers = new GenericMember[0];
		DcomUsers = new GenericMember[0];
		PSRemoteUsers = new GenericMember[0];
		IsStealthTarget = false;
		IsDomainController = false;
		IsWindows = true;
	}
}
