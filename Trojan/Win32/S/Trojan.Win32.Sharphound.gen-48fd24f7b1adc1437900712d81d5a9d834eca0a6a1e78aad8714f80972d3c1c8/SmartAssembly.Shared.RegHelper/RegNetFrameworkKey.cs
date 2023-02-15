using System;
using ns2;

namespace SmartAssembly.Shared.RegHelper;

public class RegNetFrameworkKey : RegKey
{
	public RegNetFrameworkKey()
		: base(UIntPtr.Zero)
	{
	}

	public RegNetFrameworkKey(UIntPtr hKey)
		: base(hKey)
	{
	}

	public override void Dispose()
	{
		Class2.smethod_2(base.HKey);
	}

	public override object GetValue(string lpValueName)
	{
		return Class2.smethod_1(base.HKey, lpValueName);
	}

	public override bool TryGetValue(string lpValueName, out object value)
	{
		value = Class2.smethod_1(base.HKey, lpValueName);
		return value != null;
	}
}
