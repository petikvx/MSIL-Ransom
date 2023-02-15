using System;

namespace CommandLine.Text;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public sealed class UsageAttribute : Attribute
{
	public string ApplicationAlias { get; set; }
}
