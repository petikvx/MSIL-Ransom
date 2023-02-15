using CommandLine.Infrastructure;

namespace CommandLine;

public class UnParserSettings
{
	private bool preferShortName;

	private bool groupSwitches;

	private bool useEqualToken;

	private bool showHidden;

	private bool skipDefault;

	public bool PreferShortName
	{
		get
		{
			return preferShortName;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref preferShortName, value);
		}
	}

	public bool GroupSwitches
	{
		get
		{
			return groupSwitches;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref groupSwitches, value);
		}
	}

	public bool UseEqualToken
	{
		get
		{
			return useEqualToken;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref useEqualToken, value);
		}
	}

	public bool ShowHidden
	{
		get
		{
			return showHidden;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref showHidden, value);
		}
	}

	public bool SkipDefault
	{
		get
		{
			return skipDefault;
		}
		set
		{
			PopsicleSetter.Set(Consumed, ref skipDefault, value);
		}
	}

	internal bool Consumed { get; set; }

	public static UnParserSettings WithGroupSwitchesOnly()
	{
		return new UnParserSettings
		{
			GroupSwitches = true
		};
	}

	public static UnParserSettings WithUseEqualTokenOnly()
	{
		return new UnParserSettings
		{
			UseEqualToken = true
		};
	}
}
