using System;
using System.Collections.Generic;
using System.Linq;
using CommandLine;
using SharpHound3.Enums;

namespace SharpHound3;

public class Options
{
	public static Options Instance { get; set; }

	[Option('c', "CollectionMethod", Default = new string[] { "Default" }, HelpText = "Collection Methods: Container, Group, LocalGroup, GPOLocalGroup, Session, LoggedOn, ObjectProps, ACL, ComputerOnly, Trusts, Default, RDP, DCOM, DCOnly")]
	public IEnumerable<string> CollectionMethods { get; set; }

	[Option(HelpText = "Use Stealth Targetting/Enumeration Options", Default = false)]
	public bool Stealth { get; set; }

	[Option('d', "Domain", HelpText = "Specify domain for enumeration", Default = null)]
	public string Domain { get; set; }

	[Option(HelpText = "Limit collection to Windows hosts only", Default = false)]
	public bool WindowsOnly { get; set; }

	[Option(HelpText = "Path to textfile containing line seperated computer names/sids", Default = null)]
	public string ComputerFile { get; set; }

	[Option(HelpText = "Don't output data from this run. Used for debugging purposes", Hidden = true)]
	public bool NoOutput { get; set; }

	[Option(HelpText = "Folder to output files too", Default = ".")]
	public string OutputDirectory { get; set; }

	[Option(HelpText = "Prefix for output files", Default = null)]
	public string OutputPrefix { get; set; }

	[Option(HelpText = "Output pretty(formatted) JSON", Default = false)]
	public bool PrettyJson { get; set; }

	[Option(HelpText = "Filename for the cache file (defaults to b64 of machine sid)", Default = null)]
	public string CacheFilename { get; set; }

	[Option(HelpText = "Randomize filenames for JSON files", Default = false)]
	public bool RandomizeFilenames { get; set; }

	[Option(HelpText = "Filename for the Zip file", Default = null)]
	public string ZipFilename { get; set; }

	[Option(HelpText = "Don't save cache to disk. Caching will still be done in memory", Default = false)]
	public bool NoSaveCache { get; set; }

	[Option(HelpText = "Encrypt zip file using a random password", Default = false)]
	public bool EncryptZip { get; set; }

	[Option(HelpText = "Don't zip JSON files")]
	public bool NoZip { get; set; }

	[Option(HelpText = "Invalidate and rebuild the cache")]
	public bool InvalidateCache { get; set; }

	[Option(HelpText = "Custom LDAP Filter to append to the search. Use this to filter collection", Default = null)]
	public string LdapFilter { get; set; }

	[Option(HelpText = "Domain Controller to connect too. Specifying this value can result in data loss", Default = null)]
	public string DomainController { get; set; }

	[Option(HelpText = "Port LDAP is running on. Defaults to 389/636 for LDAPS", Default = 0)]
	public int LdapPort { get; set; }

	[Option(HelpText = "Connect to LDAPS (LDAP SSL) instead of regular LDAP", Default = false)]
	public bool SecureLDAP { get; set; }

	[Option(HelpText = "Disables Kerberos Signing/Sealing making LDAP traffic viewable", Default = false)]
	public bool DisableKerberosSigning { get; set; }

	[Option(HelpText = "Username to use for LDAP", Default = null)]
	public string LdapUsername { get; set; }

	[Option(HelpText = "Password to use for LDAP", Default = null)]
	public string LdapPassword { get; set; }

	[Option(HelpText = "Base DistinguishedName to start search at. Use this to limit your search. Equivalent to the old --OU option", Default = null)]
	public string SearchBase { get; set; }

	[Option(HelpText = "Skip SMB port checks when connecting to computers", Default = false)]
	public bool SkipPortScan { get; set; }

	[Option(HelpText = "Timeout for SMB port check", Default = 2000)]
	public int PortScanTimeout { get; set; }

	[Option(HelpText = "Exclude domain controllers from enumeration (useful to avoid Microsoft ATP/ATA)", Default = false)]
	public bool ExcludeDomainControllers { get; set; }

	[Option(HelpText = "Throttle requests to computers in milliseconds")]
	public int Throttle { get; set; }

	[Option(HelpText = "Jitter between requests to computers")]
	public int Jitter { get; set; }

	[Option(HelpText = "Override username to filter for NetSessionEnum", Default = null)]
	public string OverrideUserName { get; set; }

	[Option(HelpText = "Disable remote registry check in LoggedOn collection", Default = false)]
	public bool NoRegistryLoggedOn { get; set; }

	[Option(HelpText = "Dump success/failures related to computer enumeration to a CSV file", Default = false)]
	public bool DumpComputerStatus { get; set; }

	[Option(HelpText = "Override DNS name for API calls", Default = null)]
	public string RealDNSName { get; set; }

	[Option(HelpText = "Collect all LDAP properties from objects instead of a subset during ObjectProps", Default = false)]
	public bool CollectAllProperties { get; set; }

	[Option(HelpText = "Interval in which to display status in milliseconds", Default = 30000)]
	public int StatusInterval { get; set; }

	[Option('v', HelpText = "Enable Verbose Output", Default = false)]
	public bool Verbose { get; set; }

	[Option(HelpText = "Loop Computer Collection", Default = false)]
	public bool Loop { get; set; }

	[Option(HelpText = "Duration to perform looping (Default 02:00:00)")]
	public TimeSpan LoopDuration { get; set; }

	[Option(HelpText = "Interval to sleep between loops")]
	public TimeSpan LoopInterval { get; set; }

	internal CollectionMethodResolved ResolvedCollectionMethods { get; set; }

	internal string CurrentUserName { get; set; }

	internal bool ResolveCollectionMethods()
	{
		string[] array = Enumerable.ToArray(CollectionMethods);
		if (array.Length == 1)
		{
			array = array[0].Split(new char[1] { ',' });
		}
		CollectionMethodResolved collectionMethodResolved = CollectionMethodResolved.None;
		string[] array2 = array;
		foreach (string text in array2)
		{
			CollectionMethodOptions collectionMethodOptions = CollectionMethodOptions.None;
			try
			{
				collectionMethodOptions = (CollectionMethodOptions)Enum.Parse(typeof(CollectionMethodOptions), text, ignoreCase: true);
			}
			catch
			{
				Console.WriteLine("Failed to parse Collection Method " + text + ".");
				return false;
			}
			collectionMethodResolved = collectionMethodOptions switch
			{
				CollectionMethodOptions.Group => collectionMethodResolved | CollectionMethodResolved.Group, 
				CollectionMethodOptions.Session => collectionMethodResolved | CollectionMethodResolved.Sessions, 
				CollectionMethodOptions.LoggedOn => collectionMethodResolved | CollectionMethodResolved.LoggedOn, 
				CollectionMethodOptions.Trusts => collectionMethodResolved | CollectionMethodResolved.Trusts, 
				CollectionMethodOptions.ACL => collectionMethodResolved | CollectionMethodResolved.ACL, 
				CollectionMethodOptions.ObjectProps => collectionMethodResolved | CollectionMethodResolved.ObjectProps, 
				CollectionMethodOptions.RDP => collectionMethodResolved | CollectionMethodResolved.RDP, 
				CollectionMethodOptions.DCOM => collectionMethodResolved | CollectionMethodResolved.DCOM, 
				CollectionMethodOptions.LocalAdmin => collectionMethodResolved | CollectionMethodResolved.LocalAdmin, 
				CollectionMethodOptions.PSRemote => collectionMethodResolved | CollectionMethodResolved.PSRemote, 
				CollectionMethodOptions.SPNTargets => collectionMethodResolved | CollectionMethodResolved.SPNTargets, 
				CollectionMethodOptions.Container => collectionMethodResolved | CollectionMethodResolved.Container, 
				CollectionMethodOptions.GPOLocalGroup => collectionMethodResolved | CollectionMethodResolved.GPOLocalGroup, 
				CollectionMethodOptions.LocalGroup => collectionMethodResolved | CollectionMethodResolved.LocalGroups, 
				CollectionMethodOptions.Default => collectionMethodResolved | CollectionMethodResolved.ACL | CollectionMethodResolved.Container | CollectionMethodResolved.Group | CollectionMethodResolved.LocalGroups | CollectionMethodResolved.ObjectProps | CollectionMethodResolved.Sessions | CollectionMethodResolved.Trusts | CollectionMethodResolved.SPNTargets, 
				CollectionMethodOptions.DCOnly => collectionMethodResolved | CollectionMethodResolved.ACL | CollectionMethodResolved.Container | CollectionMethodResolved.Group | CollectionMethodResolved.ObjectProps | CollectionMethodResolved.Trusts | CollectionMethodResolved.DCOnly | CollectionMethodResolved.GPOLocalGroup, 
				CollectionMethodOptions.ComputerOnly => collectionMethodResolved | CollectionMethodResolved.LocalGroups | CollectionMethodResolved.Sessions, 
				CollectionMethodOptions.All => collectionMethodResolved | CollectionMethodResolved.ACL | CollectionMethodResolved.Container | CollectionMethodResolved.Group | CollectionMethodResolved.LocalGroups | CollectionMethodResolved.ObjectProps | CollectionMethodResolved.Sessions | CollectionMethodResolved.Trusts | CollectionMethodResolved.LoggedOn | CollectionMethodResolved.SPNTargets, 
				_ => throw new ArgumentOutOfRangeException(), 
			};
		}
		if (Stealth)
		{
			List<string> list = new List<string>();
			if ((collectionMethodResolved & CollectionMethodResolved.LoggedOn) != 0)
			{
				collectionMethodResolved ^= CollectionMethodResolved.LoggedOn;
				list.Add("[-] Removed LoggedOn Collection");
			}
			bool flag = false;
			if ((collectionMethodResolved & CollectionMethodResolved.RDP) != 0)
			{
				flag = true;
				collectionMethodResolved ^= CollectionMethodResolved.RDP;
				list.Add("[-] Removed RDP Collection");
			}
			if ((collectionMethodResolved & CollectionMethodResolved.DCOM) != 0)
			{
				flag = true;
				collectionMethodResolved ^= CollectionMethodResolved.DCOM;
				list.Add("[-] Removed DCOM Collection");
			}
			if ((collectionMethodResolved & CollectionMethodResolved.PSRemote) != 0)
			{
				flag = true;
				collectionMethodResolved ^= CollectionMethodResolved.PSRemote;
				list.Add("[-] Removed PSRemote Collection");
			}
			if ((collectionMethodResolved & CollectionMethodResolved.LocalAdmin) != 0)
			{
				flag = true;
				collectionMethodResolved ^= CollectionMethodResolved.LocalAdmin;
				list.Add("[-] Removed LocalAdmin Collection");
			}
			if (flag)
			{
				collectionMethodResolved |= CollectionMethodResolved.GPOLocalGroup;
				list.Add("[+] Added GPOLocalGroup");
			}
			if (list.Count > 0)
			{
				Console.WriteLine("Updated Collection Methods to Reflect Stealth Options");
				foreach (string item in list)
				{
					Console.WriteLine(item);
				}
				Console.WriteLine();
			}
		}
		Console.WriteLine($"Resolved Collection Methods: {collectionMethodResolved}");
		Console.WriteLine();
		ResolvedCollectionMethods = collectionMethodResolved;
		return true;
	}

	internal CollectionMethodResolved GetLoopCollectionMethods()
	{
		CollectionMethodResolved resolvedCollectionMethods = ResolvedCollectionMethods;
		return resolvedCollectionMethods & (CollectionMethodResolved.LocalGroups | CollectionMethodResolved.Sessions | CollectionMethodResolved.LoggedOn);
	}

	internal bool IsComputerCollectionSet()
	{
		return (ResolvedCollectionMethods & CollectionMethodResolved.Sessions) != 0 || (ResolvedCollectionMethods & CollectionMethodResolved.LocalAdmin) != 0 || (ResolvedCollectionMethods & CollectionMethodResolved.RDP) != 0 || (ResolvedCollectionMethods & CollectionMethodResolved.DCOM) != 0 || (ResolvedCollectionMethods & CollectionMethodResolved.PSRemote) != 0 || (ResolvedCollectionMethods & CollectionMethodResolved.LoggedOn) != 0;
	}
}
