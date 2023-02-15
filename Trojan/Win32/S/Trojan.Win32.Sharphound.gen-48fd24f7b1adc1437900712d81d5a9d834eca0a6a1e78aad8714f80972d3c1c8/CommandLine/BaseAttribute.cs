using System;
using CommandLine.Infrastructure;

namespace CommandLine;

public abstract class BaseAttribute : Attribute
{
	private int min;

	private int max;

	private object @default;

	private LocalizableAttributeProperty helpText;

	private string metaValue;

	private Type resourceType;

	public bool Required { get; set; }

	public int Min
	{
		get
		{
			return min;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentNullException("value");
			}
			min = value;
		}
	}

	public int Max
	{
		get
		{
			return max;
		}
		set
		{
			if (value < 0)
			{
				throw new ArgumentNullException("value");
			}
			max = value;
		}
	}

	public object Default
	{
		get
		{
			return @default;
		}
		set
		{
			@default = value;
		}
	}

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

	public string MetaValue
	{
		get
		{
			return metaValue;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			metaValue = value;
		}
	}

	public bool Hidden { get; set; }

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

	protected internal BaseAttribute()
	{
		min = -1;
		max = -1;
		helpText = new LocalizableAttributeProperty("HelpText");
		metaValue = string.Empty;
		resourceType = null;
	}
}
