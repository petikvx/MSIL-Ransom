using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SharpHound3.JSON;
using SharpHound3.LdapWrappers;

namespace SharpHound3.Tasks;

internal class SPNTasks
{
	internal static async Task<LdapWrapper> ProcessSPNS(LdapWrapper wrapper)
	{
		if (wrapper is User user)
		{
			await ProcessUserSPNs(user);
		}
		return wrapper;
	}

	private static async Task ProcessUserSPNs(User user)
	{
		string[] servicePrincipalNames = user.SearchResult.GetPropertyAsArray("serviceprincipalname");
		string domain = user.Domain;
		List<SPNTarget> resolved = new List<SPNTarget>();
		foreach (string spn in Enumerable.Where(servicePrincipalNames, (string x) => x.StartsWith("mssqlsvc", StringComparison.OrdinalIgnoreCase)))
		{
			int port;
			if (spn.Contains(":"))
			{
				if (!int.TryParse(spn.Split(new char[1] { ':' })[1], out port))
				{
					port = 1433;
				}
			}
			else
			{
				port = 1433;
			}
			string hostSid = await ResolutionHelpers.ResolveHostToSid(spn, domain);
			if (hostSid.StartsWith("S-1-5"))
			{
				resolved.Add(new SPNTarget
				{
					ComputerSid = hostSid,
					Port = port,
					Service = "SQLAdmin"
				});
			}
		}
		user.SPNTargets = Enumerable.ToArray(Enumerable.Distinct(resolved));
	}
}
