using System;
using CommandLine.Infrastructure;

namespace CommandLine;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
public class VerbAttribute : Attribute
{
	private readonly string name;

	private LocalizableAttributeProperty helpText;

	private Type resourceType;

	public string Name => name;

	public bool Hidden { get; set; }

	public string HelpText
	{
		get
		{
			return helpText.Value ?? string.Empty;
		}
		set
		{
			helpText.Value = value ?? throw new ArgumentNullException("value");
		}
	}

	public Type ResourceType
	{
		get
		{
			return resourceType;
		}
		set
		{
			Type type2 = (resourceType = (helpText.ResourceType = value));
		}
	}

	public VerbAttribute(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			throw new ArgumentException("name");
		}
		this.name = name;
		helpText = new LocalizableAttributeProperty("HelpText");
		resourceType = null;
	}
}
