using System;
using System.Runtime.CompilerServices;

namespace SmartAssembly.Shared.RegHelper;

public abstract class RegKey : IDisposable
{
	[CompilerGenerated]
	private UIntPtr uintptr_0;

	public UIntPtr HKey
	{
		[CompilerGenerated]
		get
		{
			return uintptr_0;
		}
		[CompilerGenerated]
		set
		{
			uintptr_0 = value;
		}
	}

	public RegKey(UIntPtr hKey)
	{
		HKey = hKey;
	}

	public abstract object GetValue(string lpValueName);

	public abstract bool TryGetValue(string lpValueName, out object value);

	public abstract void Dispose();
}
