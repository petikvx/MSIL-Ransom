using System;
using System.Globalization;
using System.IO;
using CommandLine.Infrastructure;

namespace CommandLine;

public class ParserSettings : IDisposable
{
	private const int DefaultMaximumLength = 80;

	private bool disposed;

	private bool caseSensitive;

	private bool caseInsensitiveEnumValues;

	private TextWriter helpWriter;

	private bool ignoreUnknownArguments;

	private bool autoHelp;

	private bool autoVersion;

	private CultureInfo parsingCulture;

	private bool enableDashDash;

	private int maximumDisplayWidth;

	public bool CaseSensitive
	{
		get
		{
			return caseSensitive;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref caseSensitive, value);
		}
	}

	public bool CaseInsensitiveEnumValues
	{
		get
		{
			return caseInsensitiveEnumValues;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref caseInsensitiveEnumValues, value);
		}
	}

	public CultureInfo ParsingCulture
	{
		get
		{
			return parsingCulture;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			PopsicleSetter.Set(Consumed, ref parsingCulture, value);
		}
	}

	public TextWriter HelpWriter
	{
		get
		{
			return helpWriter;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref helpWriter, value);
		}
	}

	public bool IgnoreUnknownArguments
	{
		get
		{
			return ignoreUnknownArguments;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref ignoreUnknownArguments, value);
		}
	}

	public bool AutoHelp
	{
		get
		{
			return autoHelp;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref autoHelp, value);
		}
	}

	public bool AutoVersion
	{
		get
		{
			return autoVersion;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref autoVersion, value);
		}
	}

	public bool EnableDashDash
	{
		get
		{
			return enableDashDash;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref enableDashDash, value);
		}
	}

	public int MaximumDisplayWidth
	{
		get
		{
			return maximumDisplayWidth;
		}
		set
		{
			maximumDisplayWidth = value;
		}
	}

	internal StringComparer NameComparer
	{
		get
		{
			if (!CaseSensitive)
			{
				return StringComparer.OrdinalIgnoreCase;
			}
			return StringComparer.Ordinal;
		}
	}

	internal bool Consumed { get; set; }

	public ParserSettings()
	{
		caseSensitive = true;
		caseInsensitiveEnumValues = false;
		autoHelp = true;
		autoVersion = true;
		parsingCulture = CultureInfo.InvariantCulture;
		try
		{
			maximumDisplayWidth = Console.WindowWidth;
			if (maximumDisplayWidth < 1)
			{
				maximumDisplayWidth = 80;
			}
		}
		catch (IOException)
		{
			maximumDisplayWidth = 80;
		}
	}

	~ParserSettings()
	{
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void Dispose(bool disposing)
	{
		if (!disposed && disposing)
		{
			disposed = true;
		}
	}
}
