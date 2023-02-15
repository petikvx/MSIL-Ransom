using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SmartAssembly.AssemblyResolver;

internal sealed class AssemblyResolverHelper
{
	internal struct AssemblyInfo
	{
		public string Name;

		public Version Version;

		public string Culture;

		public string PublicKeyToken;

		public string GetAssemblyFullName(bool includeVersion)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}

		public AssemblyInfo(string assemblyFullName)
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}
	}

	internal const string BindList = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	private const int MOVEFILE_DELAY_UNTIL_REBOOT = 4;

	private static Dictionary<string, Assembly> hashtable;

	internal static bool IsWebApplication
	{
		get
		{
		//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
		}
	}

	[DllImport("kernel32")]
	private static extern bool MoveFileEx(string existingFileName, string newFileName, int flags);

	internal static void Attach()
	{
	//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
	}

	internal static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
	{
	//Invalid MethodBodyBlock: Image is either too small or contains an invalid byte offset or count.
	}
}
