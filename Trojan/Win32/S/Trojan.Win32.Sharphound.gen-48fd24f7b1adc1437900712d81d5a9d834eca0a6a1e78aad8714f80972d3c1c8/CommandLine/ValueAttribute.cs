using System;

namespace CommandLine;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
public sealed class ValueAttribute : BaseAttribute
{
	private readonly int index;

	private string metaName;

	public int Index => index;

	public string MetaName
	{
		get
		{
			return metaName;
		}
		set
		{
			metaName = value ?? throw new ArgumentNullException("value");
		}
	}

	public ValueAttribute(int index)
	{
		this.index = index;
		metaName = string.Empty;
	}
}
