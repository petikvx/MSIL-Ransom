using System;
using System.Collections.Generic;
using System.Reflection;
using System.Security;
using ns0;

namespace ns1;

internal sealed class Class13
{
	public static long long_0;

	public static List<string> list_0;

	public static List<string> list_1;

	public static List<string> list_2;

	static Class13()
	{
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace("%", "%25").Replace("#", "%23"));
		if (!Class27.StrongNameSignatureVerificationEx_7(uri.LocalPath, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith("a459aa267b8f616b"))
		{
			throw new SecurityException("Assembly has been tampered");
		}
		long_0 = 0L;
		list_0 = new List<string>();
		list_1 = new List<string>();
		list_2 = new List<string>();
	}
}
