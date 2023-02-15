using System;
using System.Linq;
using System.Reflection;

namespace ns0;

internal class Class1
{
	private static Assembly assembly_0;

	private static string[] string_0 = new string[0];

	internal static void smethod_0()
	{
		try
		{
			AppDomain.CurrentDomain.ResourceResolve += smethod_1;
		}
		catch
		{
		}
	}

	private static Assembly smethod_1(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (assembly_0 == null)
		{
			lock (string_0)
			{
				assembly_0 = Assembly.Load("{657a94db-02e2-483d-b576-4f6e6bf796d7}, PublicKeyToken=3e56350693f7355e");
				if (assembly_0 != null)
				{
					string_0 = assembly_0.GetManifestResourceNames();
				}
			}
		}
		if (!Enumerable.Contains(string_0, resolveEventArgs_0.Name))
		{
			return null;
		}
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (!resolveEventArgs_0.RequestingAssembly!.Equals(executingAssembly))
		{
			return null;
		}
		return assembly_0;
	}
}
