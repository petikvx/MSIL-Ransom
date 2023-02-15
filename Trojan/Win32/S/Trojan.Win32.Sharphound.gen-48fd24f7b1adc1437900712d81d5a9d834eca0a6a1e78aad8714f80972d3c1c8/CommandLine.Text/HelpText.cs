using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using CSharpx;
using CommandLine.Core;
using CommandLine.Infrastructure;

namespace CommandLine.Text;

public class HelpText
{
	public static Comparison<ComparableOption> RequiredThenAlphaComparison = delegate(ComparableOption attr1, ComparableOption attr2)
	{
		if (attr1.IsOption && attr2.IsOption)
		{
			if (attr1.Required && !attr2.Required)
			{
				return -1;
			}
			if (!attr1.Required && attr2.Required)
			{
				return 1;
			}
			return string.Compare(attr1.LongName, attr2.LongName, StringComparison.Ordinal);
		}
		return (!attr1.IsOption || !attr2.IsValue) ? 1 : (-1);
	};

	private const int BuilderCapacity = 128;

	private const int DefaultMaximumLength = 80;

	private const int OptionToHelpTextSeparatorWidth = 4;

	private const int OptionPrefixWidth = 2;

	private const int TotalOptionPadding = 6;

	private readonly StringBuilder preOptionsHelp;

	private readonly StringBuilder postOptionsHelp;

	private readonly SentenceBuilder sentenceBuilder;

	private int maximumDisplayWidth;

	private string heading;

	private string copyright;

	private bool additionalNewLineAfterOption;

	private StringBuilder optionsHelp;

	private bool addDashesToOption;

	private bool addEnumValuesToHelpText;

	private bool autoHelp;

	private bool autoVersion;

	private bool addNewLineBetweenHelpSections;

	public Comparison<ComparableOption> OptionComparison { get; set; }

	public string Heading
	{
		get
		{
			return heading;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			heading = value;
		}
	}

	public string Copyright
	{
		get
		{
			return copyright;
		}
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("value");
			}
			copyright = value;
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

	public bool AddDashesToOption
	{
		get
		{
			return addDashesToOption;
		}
		set
		{
			addDashesToOption = value;
		}
	}

	public bool AdditionalNewLineAfterOption
	{
		get
		{
			return additionalNewLineAfterOption;
		}
		set
		{
			additionalNewLineAfterOption = value;
		}
	}

	public bool AddNewLineBetweenHelpSections
	{
		get
		{
			return addNewLineBetweenHelpSections;
		}
		set
		{
			addNewLineBetweenHelpSections = value;
		}
	}

	public bool AddEnumValuesToHelpText
	{
		get
		{
			return addEnumValuesToHelpText;
		}
		set
		{
			addEnumValuesToHelpText = value;
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
			autoHelp = value;
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
			autoVersion = value;
		}
	}

	public SentenceBuilder SentenceBuilder => sentenceBuilder;

	private ComparableOption ToComparableOption(Specification spec, int index)
	{
		OptionSpecification optionSpecification = spec as OptionSpecification;
		ValueSpecification valueSpecification = spec as ValueSpecification;
		bool required = optionSpecification?.Required ?? false;
		ComparableOption result = default(ComparableOption);
		result.Required = required;
		result.IsOption = optionSpecification != null;
		result.IsValue = valueSpecification != null;
		object obj;
		if (optionSpecification == null)
		{
			obj = null;
		}
		else
		{
			obj = optionSpecification.LongName;
			if (obj != null)
			{
				goto IL_005f;
			}
		}
		obj = valueSpecification?.MetaName;
		goto IL_005f;
		IL_005f:
		result.LongName = (string)obj;
		result.ShortName = optionSpecification?.ShortName;
		result.Index = index;
		return result;
	}

	public HelpText()
		: this(SentenceBuilder.Create(), string.Empty, string.Empty)
	{
	}

	public HelpText(SentenceBuilder sentenceBuilder)
		: this(sentenceBuilder, string.Empty, string.Empty)
	{
	}

	public HelpText(string heading)
		: this(SentenceBuilder.Create(), heading, string.Empty)
	{
	}

	public HelpText(SentenceBuilder sentenceBuilder, string heading)
		: this(sentenceBuilder, heading, string.Empty)
	{
	}

	public HelpText(string heading, string copyright)
		: this(SentenceBuilder.Create(), heading, copyright)
	{
	}

	public HelpText(SentenceBuilder sentenceBuilder, string heading, string copyright)
	{
		if (sentenceBuilder == null)
		{
			throw new ArgumentNullException("sentenceBuilder");
		}
		if (heading == null)
		{
			throw new ArgumentNullException("heading");
		}
		if (copyright == null)
		{
			throw new ArgumentNullException("copyright");
		}
		preOptionsHelp = new StringBuilder(128);
		postOptionsHelp = new StringBuilder(128);
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
		this.sentenceBuilder = sentenceBuilder;
		this.heading = heading;
		this.copyright = copyright;
		autoHelp = true;
		autoVersion = true;
	}

	public static HelpText AutoBuild<T>(ParserResult<T> parserResult, Func<HelpText, HelpText> onError, Func<Example, Example> onExample, bool verbsIndex = false, int maxDisplayWidth = 80)
	{
		HelpText auto = new HelpText
		{
			Heading = HeadingInfo.Empty,
			Copyright = CopyrightInfo.Empty,
			AdditionalNewLineAfterOption = true,
			AddDashesToOption = !verbsIndex,
			MaximumDisplayWidth = maxDisplayWidth
		};
		try
		{
			auto.Heading = HeadingInfo.Default;
			auto.Copyright = CopyrightInfo.Default;
		}
		catch (Exception)
		{
			auto = onError(auto);
		}
		IEnumerable<Error> enumerable = Enumerable.Empty<Error>();
		if (onError != null && parserResult.Tag == ParserResultType.NotParsed)
		{
			enumerable = ((NotParsed<T>)parserResult).Errors;
			if (enumerable.IsHelp() || Enumerable.Any(enumerable.OnlyMeaningfulOnes()))
			{
				auto = onError(auto);
			}
		}
		ReflectionHelper.GetAttribute<AssemblyLicenseAttribute>().Do(delegate(AssemblyLicenseAttribute license)
		{
			license.AddToHelpText(auto, before: true);
		});
		Maybe<AssemblyUsageAttribute> attribute = ReflectionHelper.GetAttribute<AssemblyUsageAttribute>();
		Maybe<IEnumerable<string>> maybe = RenderUsageTextAsLines(parserResult, onExample).ToMaybe();
		if (attribute.IsJust() || maybe.IsJust())
		{
			string text = auto.SentenceBuilder.UsageHeadingText();
			if (text.Length > 0)
			{
				if (auto.AddNewLineBetweenHelpSections)
				{
					text = Environment.NewLine + text;
				}
				auto.AddPreOptionsLine(text);
			}
		}
		attribute.Do(delegate(AssemblyUsageAttribute usage)
		{
			usage.AddToHelpText(auto, before: true);
		});
		maybe.Do(delegate(IEnumerable<string> lines)
		{
			auto.AddPreOptionsLines(lines);
		});
		if ((verbsIndex && Enumerable.Any(parserResult.TypeInfo.Choices)) || Enumerable.Any(enumerable, (Error e) => e.Tag == ErrorType.NoVerbSelectedError))
		{
			auto.AddDashesToOption = false;
			auto.AddVerbs(Enumerable.ToArray(parserResult.TypeInfo.Choices));
		}
		else
		{
			auto.AddOptions(parserResult);
		}
		return auto;
	}

	public static HelpText AutoBuild<T>(ParserResult<T> parserResult, int maxDisplayWidth = 80)
	{
		return AutoBuild(parserResult, (HelpText h) => h, maxDisplayWidth);
	}

	public static HelpText AutoBuild<T>(ParserResult<T> parserResult, Func<HelpText, HelpText> onError, int maxDisplayWidth = 80)
	{
		if (parserResult.Tag != ParserResultType.NotParsed)
		{
			throw new ArgumentException("Excepting NotParsed<T> type.", "parserResult");
		}
		IEnumerable<Error> errors = ((NotParsed<T>)parserResult).Errors;
		if (Enumerable.Any(errors, (Error e) => e.Tag == ErrorType.VersionRequestedError))
		{
			return new HelpText($"{HeadingInfo.Default}{Environment.NewLine}")
			{
				MaximumDisplayWidth = maxDisplayWidth
			}.AddPreOptionsLine(Environment.NewLine);
		}
		if (!Enumerable.Any(errors, (Error e) => e.Tag == ErrorType.HelpVerbRequestedError))
		{
			return AutoBuild(parserResult, delegate(HelpText current)
			{
				onError?.Invoke(current);
				return DefaultParsingErrorsHandler(parserResult, current);
			}, (Example e) => e, verbsIndex: false, maxDisplayWidth);
		}
		HelpVerbRequestedError helpVerbRequestedError = Enumerable.Single(Enumerable.OfType<HelpVerbRequestedError>(errors));
		NotParsed<object> pr = new NotParsed<object>(TypeInfo.Create(helpVerbRequestedError.Type), new Error[1] { helpVerbRequestedError });
		if (!helpVerbRequestedError.Matched)
		{
			return AutoBuild(parserResult, delegate(HelpText current)
			{
				onError?.Invoke(current);
				return DefaultParsingErrorsHandler(parserResult, current);
			}, (Example e) => e, verbsIndex: true, maxDisplayWidth);
		}
		return AutoBuild(pr, delegate(HelpText current)
		{
			onError?.Invoke(current);
			return DefaultParsingErrorsHandler(pr, current);
		}, (Example e) => e, verbsIndex: false, maxDisplayWidth);
	}

	public static HelpText DefaultParsingErrorsHandler<T>(ParserResult<T> parserResult, HelpText current)
	{
		if (parserResult == null)
		{
			throw new ArgumentNullException("parserResult");
		}
		if (current == null)
		{
			throw new ArgumentNullException("current");
		}
		if (((NotParsed<T>)parserResult).Errors.OnlyMeaningfulOnes().Empty())
		{
			return current;
		}
		IEnumerable<string> enumerable = RenderParsingErrorsTextAsLines(parserResult, current.SentenceBuilder.FormatError, current.SentenceBuilder.FormatMutuallyExclusiveSetErrors, 2);
		if (enumerable.Empty())
		{
			return current;
		}
		return current.AddPreOptionsLine(Environment.NewLine + current.SentenceBuilder.ErrorsHeadingText()).AddPreOptionsLines(enumerable);
	}

	public static implicit operator string(HelpText info)
	{
		return info.ToString();
	}

	public HelpText AddPreOptionsLine(string value)
	{
		return AddPreOptionsLine(value, MaximumDisplayWidth);
	}

	public HelpText AddPostOptionsLine(string value)
	{
		return AddLine(postOptionsHelp, value);
	}

	public HelpText AddPreOptionsLines(IEnumerable<string> lines)
	{
		lines.ForEach(delegate(string line)
		{
			AddPreOptionsLine(line);
		});
		return this;
	}

	public HelpText AddPostOptionsLines(IEnumerable<string> lines)
	{
		lines.ForEach(delegate(string line)
		{
			AddPostOptionsLine(line);
		});
		return this;
	}

	public HelpText AddPreOptionsText(string text)
	{
		text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None).ForEach(delegate(string line)
		{
			AddPreOptionsLine(line);
		});
		return this;
	}

	public HelpText AddPostOptionsText(string text)
	{
		text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None).ForEach(delegate(string line)
		{
			AddPostOptionsLine(line);
		});
		return this;
	}

	public HelpText AddOptions<T>(ParserResult<T> result)
	{
		if (result == null)
		{
			throw new ArgumentNullException("result");
		}
		return AddOptionsImpl(GetSpecificationsFromType(result.TypeInfo.Current), SentenceBuilder.RequiredWord(), SentenceBuilder.OptionGroupWord(), MaximumDisplayWidth);
	}

	public HelpText AddVerbs(params Type[] types)
	{
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		if (types.Length == 0)
		{
			throw new ArgumentOutOfRangeException("types");
		}
		return AddOptionsImpl(AdaptVerbsToSpecifications(types), SentenceBuilder.RequiredWord(), SentenceBuilder.OptionGroupWord(), MaximumDisplayWidth);
	}

	public HelpText AddOptions<T>(int maximumLength, ParserResult<T> result)
	{
		if (result == null)
		{
			throw new ArgumentNullException("result");
		}
		return AddOptionsImpl(GetSpecificationsFromType(result.TypeInfo.Current), SentenceBuilder.RequiredWord(), SentenceBuilder.OptionGroupWord(), maximumLength);
	}

	public HelpText AddVerbs(int maximumLength, params Type[] types)
	{
		if (types == null)
		{
			throw new ArgumentNullException("types");
		}
		if (types.Length == 0)
		{
			throw new ArgumentOutOfRangeException("types");
		}
		return AddOptionsImpl(AdaptVerbsToSpecifications(types), SentenceBuilder.RequiredWord(), SentenceBuilder.OptionGroupWord(), maximumLength);
	}

	public static string RenderParsingErrorsText<T>(ParserResult<T> parserResult, Func<Error, string> formatError, Func<IEnumerable<MutuallyExclusiveSetError>, string> formatMutuallyExclusiveSetErrors, int indent)
	{
		return string.Join(Environment.NewLine, RenderParsingErrorsTextAsLines(parserResult, formatError, formatMutuallyExclusiveSetErrors, indent));
	}

	public static IEnumerable<string> RenderParsingErrorsTextAsLines<T>(ParserResult<T> parserResult, Func<Error, string> formatError, Func<IEnumerable<MutuallyExclusiveSetError>, string> formatMutuallyExclusiveSetErrors, int indent)
	{
		if (parserResult == null)
		{
			throw new ArgumentNullException("parserResult");
		}
		IEnumerable<Error> meaningfulErrors = ((NotParsed<T>)parserResult).Errors.OnlyMeaningfulOnes();
		if (meaningfulErrors.Empty())
		{
			yield break;
		}
		foreach (Error item in Enumerable.Where(meaningfulErrors, (Error e) => e.Tag != ErrorType.MutuallyExclusiveSetError))
		{
			StringBuilder stringBuilder = new StringBuilder(indent.Spaces()).Append(formatError(item));
			yield return stringBuilder.ToString();
		}
		string text = formatMutuallyExclusiveSetErrors(Enumerable.OfType<MutuallyExclusiveSetError>(meaningfulErrors));
		if (text.Length > 0)
		{
			string[] array = text.Split(new string[1] { Environment.NewLine }, StringSplitOptions.None);
			string[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				yield return array2[i];
			}
		}
	}

	public static string RenderUsageText<T>(ParserResult<T> parserResult)
	{
		return RenderUsageText(parserResult, (Example example) => example);
	}

	public static string RenderUsageText<T>(ParserResult<T> parserResult, Func<Example, Example> mapperFunc)
	{
		return string.Join(Environment.NewLine, RenderUsageTextAsLines(parserResult, mapperFunc));
	}

	public static IEnumerable<string> RenderUsageTextAsLines<T>(ParserResult<T> parserResult, Func<Example, Example> mapperFunc)
	{
		if (parserResult == null)
		{
			throw new ArgumentNullException("parserResult");
		}
		Maybe<Tuple<UsageAttribute, IEnumerable<Example>>> usageFromType = GetUsageFromType(parserResult.TypeInfo.Current);
		if (usageFromType.MatchNothing())
		{
			yield break;
		}
		Tuple<UsageAttribute, IEnumerable<Example>> tuple = usageFromType.FromJustOrFail();
		IEnumerable<Example> item = tuple.Item2;
		string appAlias = tuple.Item1.ApplicationAlias ?? ReflectionHelper.GetAssemblyName();
		foreach (Example item2 in item)
		{
			Example example = mapperFunc(item2);
			StringBuilder stringBuilder = new StringBuilder(example.HelpText).Append(':');
			yield return stringBuilder.ToString();
			IEnumerable<UnParserSettings> formatStylesOrDefault = example.GetFormatStylesOrDefault();
			foreach (UnParserSettings s in formatStylesOrDefault)
			{
				StringBuilder stringBuilder2 = new StringBuilder(2.Spaces()).Append(appAlias).Append(' ').Append(Parser.Default.FormatCommandLine(example.Sample, delegate(UnParserSettings config)
				{
					config.PreferShortName = s.PreferShortName;
					config.GroupSwitches = s.GroupSwitches;
					config.UseEqualToken = s.UseEqualToken;
				}));
				yield return stringBuilder2.ToString();
			}
		}
	}

	public override string ToString()
	{
		_003C_003Ec__DisplayClass79_0 _003C_003Ec__DisplayClass79_0_ = default(_003C_003Ec__DisplayClass79_0);
		_003C_003Ec__DisplayClass79_0_._003C_003E4__this = this;
		int capacity = heading.SafeLength() + copyright.SafeLength() + preOptionsHelp.SafeLength() + optionsHelp.SafeLength() + postOptionsHelp.SafeLength() + 10;
		_003C_003Ec__DisplayClass79_0_.result = new StringBuilder(capacity);
		_003C_003Ec__DisplayClass79_0_.result.Append(heading).AppendWhen(!string.IsNullOrEmpty(copyright), Environment.NewLine, copyright).AppendWhen(preOptionsHelp.SafeLength() > 0, method_0(preOptionsHelp, ref _003C_003Ec__DisplayClass79_0_), Environment.NewLine, preOptionsHelp.ToString())
			.AppendWhen(optionsHelp.SafeLength() > 0, Environment.NewLine, Environment.NewLine, optionsHelp.SafeToString())
			.AppendWhen(postOptionsHelp.SafeLength() > 0, method_0(postOptionsHelp, ref _003C_003Ec__DisplayClass79_0_), Environment.NewLine, postOptionsHelp.ToString());
		return _003C_003Ec__DisplayClass79_0_.result.ToString();
	}

	internal static void AddLine(StringBuilder builder, string value, int maximumLength)
	{
		if (builder == null)
		{
			throw new ArgumentNullException("builder");
		}
		if (value == null)
		{
			throw new ArgumentNullException("value");
		}
		if (maximumLength < 1)
		{
			throw new ArgumentOutOfRangeException("value");
		}
		value = value.TrimEnd(new char[0]);
		builder.AppendWhen(builder.Length > 0, Environment.NewLine);
		builder.Append(TextWrapper.WrapAndIndentText(value, 0, maximumLength));
	}

	private IEnumerable<Specification> GetSpecificationsFromType(Type type)
	{
		IEnumerable<Specification> specifications = type.GetSpecifications(Specification.FromProperty);
		IEnumerable<OptionSpecification> enumerable = Enumerable.OfType<OptionSpecification>(specifications);
		if (autoHelp)
		{
			enumerable = Enumerable.Concat(enumerable, new OptionSpecification[1] { MakeHelpEntry() });
		}
		if (autoVersion)
		{
			enumerable = Enumerable.Concat(enumerable, new OptionSpecification[1] { MakeVersionEntry() });
		}
		IOrderedEnumerable<ValueSpecification> second = Enumerable.OrderBy(Enumerable.OfType<ValueSpecification>(specifications), (ValueSpecification v) => v.Index);
		return Enumerable.Concat(Enumerable.Concat(Enumerable.Empty<Specification>(), enumerable), second);
	}

	private static Maybe<Tuple<UsageAttribute, IEnumerable<Example>>> GetUsageFromType(Type type)
	{
		return type.GetUsageData().Map(delegate(Tuple<PropertyInfo, UsageAttribute> tuple)
		{
			PropertyInfo item = tuple.Item1;
			UsageAttribute item2 = tuple.Item2;
			IEnumerable<Example> item3 = (IEnumerable<Example>)item.GetValue(null, BindingFlags.Static | BindingFlags.Public | BindingFlags.GetProperty, null, null, null);
			return Tuple.Create(item2, item3);
		});
	}

	private IEnumerable<Specification> AdaptVerbsToSpecifications(IEnumerable<Type> types)
	{
		IEnumerable<OptionSpecification> enumerable = Enumerable.Select(Verb.SelectFromTypes(types), (Tuple<Verb, Type> verbTuple) => OptionSpecification.NewSwitch(string.Empty, verbTuple.Item1.Name, required: false, verbTuple.Item1.HelpText, string.Empty, verbTuple.Item1.Hidden));
		if (autoHelp)
		{
			enumerable = Enumerable.Concat(enumerable, new OptionSpecification[1] { MakeHelpEntry() });
		}
		if (autoVersion)
		{
			enumerable = Enumerable.Concat(enumerable, new OptionSpecification[1] { MakeVersionEntry() });
		}
		return enumerable;
	}

	private HelpText AddOptionsImpl(IEnumerable<Specification> specifications, string requiredWord, string optionGroupWord, int maximumLength)
	{
		int maxLength = GetMaxLength(specifications);
		optionsHelp = new StringBuilder(128);
		int remainingSpace = maximumLength - (maxLength + 6);
		if (OptionComparison != null)
		{
			int i = -1;
			List<ComparableOption> list = Enumerable.ToList(Enumerable.Select(Enumerable.ToList(specifications), delegate(Specification s)
			{
				i++;
				return ToComparableOption(s, i);
			}));
			list.Sort(OptionComparison);
			{
				foreach (ComparableOption item in list)
				{
					Specification specification = Enumerable.ElementAt(specifications, item.Index);
					AddOption(requiredWord, optionGroupWord, maxLength, specification, remainingSpace);
				}
				return this;
			}
		}
		specifications.ForEach(delegate(Specification option)
		{
			AddOption(requiredWord, optionGroupWord, maxLength, option, remainingSpace);
		});
		return this;
	}

	private OptionSpecification MakeHelpEntry()
	{
		return OptionSpecification.NewSwitch(string.Empty, "help", required: false, sentenceBuilder.HelpCommandText(AddDashesToOption), string.Empty);
	}

	private OptionSpecification MakeVersionEntry()
	{
		return OptionSpecification.NewSwitch(string.Empty, "version", required: false, sentenceBuilder.VersionCommandText(AddDashesToOption), string.Empty);
	}

	private HelpText AddPreOptionsLine(string value, int maximumLength)
	{
		AddLine(preOptionsHelp, value, maximumLength);
		return this;
	}

	private HelpText AddOption(string requiredWord, string optionGroupWord, int maxLength, Specification specification, int widthOfHelpText)
	{
		_003C_003Ec__DisplayClass88_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass88_0();
		CS_0024_003C_003E8__locals0.specification = specification;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.maxLength = maxLength;
		if (CS_0024_003C_003E8__locals0.specification.Hidden)
		{
			return this;
		}
		optionsHelp.Append("  ");
		StringBuilder stringBuilder = new StringBuilder(CS_0024_003C_003E8__locals0.maxLength).BimapIf(CS_0024_003C_003E8__locals0.specification.Tag == SpecificationType.Option, (StringBuilder it) => it.Append(CS_0024_003C_003E8__locals0._003C_003E4__this.AddOptionName(CS_0024_003C_003E8__locals0.maxLength, (OptionSpecification)CS_0024_003C_003E8__locals0.specification)), (StringBuilder it) => it.Append(CS_0024_003C_003E8__locals0._003C_003E4__this.AddValueName(CS_0024_003C_003E8__locals0.maxLength, (ValueSpecification)CS_0024_003C_003E8__locals0.specification)));
		optionsHelp.Append((stringBuilder.Length < CS_0024_003C_003E8__locals0.maxLength) ? stringBuilder.ToString().PadRight(CS_0024_003C_003E8__locals0.maxLength) : stringBuilder.ToString()).Append(4.Spaces());
		CS_0024_003C_003E8__locals0.optionHelpText = CS_0024_003C_003E8__locals0.specification.HelpText;
		if (addEnumValuesToHelpText && Enumerable.Any(CS_0024_003C_003E8__locals0.specification.EnumValues))
		{
			CS_0024_003C_003E8__locals0.optionHelpText = CS_0024_003C_003E8__locals0.optionHelpText + " Valid values: " + string.Join(", ", CS_0024_003C_003E8__locals0.specification.EnumValues);
		}
		CS_0024_003C_003E8__locals0.specification.DefaultValue.Do(delegate(object defaultValue)
		{
			CS_0024_003C_003E8__locals0.optionHelpText = "(Default: {0}) ".FormatInvariant(FormatDefaultValue(defaultValue)) + CS_0024_003C_003E8__locals0.optionHelpText;
		});
		OptionSpecification optionSpecification = CS_0024_003C_003E8__locals0.method_0();
		if (CS_0024_003C_003E8__locals0.specification.Required && optionSpecification == null)
		{
			CS_0024_003C_003E8__locals0.optionHelpText = "{0} ".FormatInvariant(requiredWord) + CS_0024_003C_003E8__locals0.optionHelpText;
		}
		if (optionSpecification != null)
		{
			CS_0024_003C_003E8__locals0.optionHelpText = "({0}: {1}) ".FormatInvariant(optionGroupWord, optionSpecification.Group) + CS_0024_003C_003E8__locals0.optionHelpText;
		}
		string value = TextWrapper.WrapAndIndentText(CS_0024_003C_003E8__locals0.optionHelpText, CS_0024_003C_003E8__locals0.maxLength + 6, widthOfHelpText).TrimStart(new char[0]);
		optionsHelp.Append(value).Append(Environment.NewLine).AppendWhen(additionalNewLineAfterOption, Environment.NewLine);
		return this;
	}

	private string AddOptionName(int maxLength, OptionSpecification specification)
	{
		return new StringBuilder(maxLength).MapIf(specification.ShortName.Length > 0, (StringBuilder it) => it.AppendWhen(addDashesToOption, '-').AppendFormat("{0}", specification.ShortName).AppendFormatWhen(specification.MetaValue.Length > 0, " {0}", specification.MetaValue)
			.AppendWhen(specification.LongName.Length > 0, ", ")).MapIf(specification.LongName.Length > 0, (StringBuilder it) => it.AppendWhen(addDashesToOption, "--").AppendFormat("{0}", specification.LongName).AppendFormatWhen(specification.MetaValue.Length > 0, "={0}", specification.MetaValue)).ToString();
	}

	private string AddValueName(int maxLength, ValueSpecification specification)
	{
		return new StringBuilder(maxLength).BimapIf(specification.MetaName.Length > 0, (StringBuilder it) => it.AppendFormat("{0} (pos. {1})", specification.MetaName, specification.Index), (StringBuilder it) => it.AppendFormat("value pos. {0}", specification.Index)).AppendFormatWhen(specification.MetaValue.Length > 0, " {0}", specification.MetaValue).ToString();
	}

	private HelpText AddLine(StringBuilder builder, string value)
	{
		AddLine(builder, value, MaximumDisplayWidth);
		return this;
	}

	private int GetMaxLength(IEnumerable<Specification> specifications)
	{
		return Enumerable.Aggregate(specifications, 0, delegate(int length, Specification spec)
		{
			if (spec.Hidden)
			{
				return length;
			}
			int val = ((spec.Tag == SpecificationType.Option) ? GetMaxOptionLength((OptionSpecification)spec) : GetMaxValueLength((ValueSpecification)spec));
			return Math.Max(length, val);
		});
	}

	private int GetMaxOptionLength(OptionSpecification spec)
	{
		int num = 0;
		bool num2 = spec.ShortName.Length > 0;
		bool flag = spec.LongName.Length > 0;
		int num3 = 0;
		if (spec.MetaValue.Length > 0)
		{
			num3 = spec.MetaValue.Length + 1;
			if (num2)
			{
				goto IL_0045;
			}
		}
		else if (num2)
		{
			goto IL_0045;
		}
		goto IL_0059;
		IL_0045:
		num++;
		if (AddDashesToOption)
		{
			num++;
		}
		num += num3;
		goto IL_0059;
		IL_0059:
		if (flag)
		{
			num += spec.LongName.Length;
			if (AddDashesToOption)
			{
				num += 2;
			}
			num += num3;
		}
		if (num2 && flag)
		{
			num += 2;
		}
		return num;
	}

	private int GetMaxValueLength(ValueSpecification spec)
	{
		int num = 0;
		bool num2 = spec.MetaName.Length > 0;
		int num3 = 0;
		if (spec.MetaValue.Length > 0)
		{
			num3 = spec.MetaValue.Length + 1;
		}
		num = ((!num2) ? (num + (spec.Index.ToStringInvariant().Length + 11)) : (num + (spec.MetaName.Length + spec.Index.ToStringInvariant().Length + 8)));
		return num + num3;
	}

	private static string FormatDefaultValue<T>(T value)
	{
		if (value is bool)
		{
			return value.ToStringLocal().ToLowerInvariant();
		}
		if (value is string)
		{
			return value.ToStringLocal();
		}
		if (!((object)value is IEnumerable enumerable))
		{
			return value.ToStringLocal();
		}
		StringBuilder stringBuilder = new StringBuilder();
		foreach (object item in enumerable)
		{
			stringBuilder.Append(item.ToStringLocal()).Append(" ");
		}
		if (stringBuilder.Length <= 0)
		{
			return string.Empty;
		}
		return stringBuilder.ToString(0, stringBuilder.Length - 1);
	}

	[CompilerGenerated]
	private string method_0(StringBuilder sb, ref _003C_003Ec__DisplayClass79_0 _003C_003Ec__DisplayClass79_0_0)
	{
		if (AddNewLineBetweenHelpSections && _003C_003Ec__DisplayClass79_0_0.result.Length > 0 && !_003C_003Ec__DisplayClass79_0_0.result.SafeEndsWith(Environment.NewLine) && !sb.SafeStartsWith(Environment.NewLine))
		{
			return Environment.NewLine;
		}
		return null;
	}
}
