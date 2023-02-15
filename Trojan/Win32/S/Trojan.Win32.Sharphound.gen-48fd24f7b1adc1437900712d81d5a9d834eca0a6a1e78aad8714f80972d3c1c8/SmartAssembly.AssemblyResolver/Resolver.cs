using System;

namespace SmartAssembly.AssemblyResolver;

public class Resolver
{
	public static void AttachResolver(AppDomain domain)
	{
		domain.AssemblyResolve += AssemblyResolverHelper.ResolveAssembly;
	}
}
