using System;
using System.Collections.Generic;
using System.Linq;

namespace CommandLine.Text;

public sealed class Example : IEquatable<Example>
{
	private readonly string helpText;

	private readonly IEnumerable<UnParserSettings> formatStyles;

	private readonly object sample;

	public string HelpText => helpText;

	public IEnumerable<UnParserSettings> FormatStyles => formatStyles;

	public object Sample => sample;

	public Example(string helpText, IEnumerable<UnParserSettings> formatStyles, object sample)
	{
		if (string.IsNullOrEmpty(helpText))
		{
			throw new ArgumentException("helpText can't be null or empty", "helpText");
		}
		if (formatStyles == null)
		{
			throw new ArgumentNullException("formatStyles");
		}
		if (sample == null)
		{
			throw new ArgumentNullException("sample");
		}
		this.helpText = helpText;
		this.formatStyles = formatStyles;
		this.sample = sample;
	}

	public Example(string helpText, UnParserSettings formatStyle, object sample)
		: this(helpText, new UnParserSettings[1] { formatStyle }, sample)
	{
	}

	public Example(string helpText, object sample)
		: this(helpText, Enumerable.Empty<UnParserSettings>(), sample)
	{
	}

	public override bool Equals(object obj)
	{
		if (obj is Example other)
		{
			return Equals(other);
		}
		return base.Equals(obj);
	}

	public override int GetHashCode()
	{
		return new { HelpText, FormatStyles, Sample }.GetHashCode();
	}

	public bool Equals(Example other)
	{
		if (other == null)
		{
			return false;
		}
		if (HelpText.Equals(other.HelpText) && Enumerable.SequenceEqual(FormatStyles, other.FormatStyles))
		{
			return Sample.Equals(other.Sample);
		}
		return false;
	}
}
