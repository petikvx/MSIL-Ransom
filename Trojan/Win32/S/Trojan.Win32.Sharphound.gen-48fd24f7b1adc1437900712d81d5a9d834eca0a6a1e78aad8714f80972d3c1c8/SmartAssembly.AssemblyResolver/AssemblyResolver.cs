using System;

namespace SmartAssembly.AssemblyResolver;

public class AssemblyResolver
{
	public static void AttachApp()
	{
		try
		{
			AssemblyResolverHelper.Attach();
		}
		catch (Exception)
		{
		}
	}
}
