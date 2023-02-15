using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text;
using CSharpx;
using CommandLine.Core;
using CommandLine.Infrastructure;

namespace CommandLine;

public static class UnParserExtensions
{
	public static string FormatCommandLine<T>(this Parser parser, T options)
	{
		return parser.FormatCommandLine(options, delegate
		{
		});
	}

	public static string FormatCommandLine<T>(this Parser parser, T options, Action<UnParserSettings> configuration)
	{
		if (options == null)
		{
			throw new ArgumentNullException("options");
		}
		UnParserSettings settings = new UnParserSettings();
		configuration(settings);
		settings.Consumed = true;
		Type type = options.GetType();
		StringBuilder builder = new StringBuilder();
		type.GetVerbSpecification().MapValueOrDefault<VerbAttribute, StringBuilder>((VerbAttribute verb) => builder.Append(verb.Name).Append(' '), builder);
		var source = Enumerable.Where(type.GetSpecifications((PropertyInfo pi) => new
		{
			Specification = Specification.FromProperty(pi),
			Value = pi.GetValue(options, null).NormalizeValue(),
			PropertyValue = pi.GetValue(options, null)
		}), info => !info.PropertyValue.IsEmpty(info.Specification, settings.SkipDefault)).Memorize();
		var enumerable = Enumerable.Select(Enumerable.OrderBy(Enumerable.Where(Enumerable.Where(Enumerable.Select(Enumerable.Where(source, i => i.Specification.Tag == SpecificationType.Option), info => new
		{
			info = info,
			o = (OptionSpecification)info.Specification
		}), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.TargetType != 0 || (_003C_003Eh__TransparentIdentifier0.o.TargetType == TargetType.Switch && (bool)_003C_003Eh__TransparentIdentifier0.info.Value)), _003C_003Eh__TransparentIdentifier0 => !_003C_003Eh__TransparentIdentifier0.o.Hidden || settings.ShowHidden), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.UniqueName()), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.info);
		var shortSwitches = Enumerable.Select(Enumerable.OrderBy(Enumerable.Where(Enumerable.Where(Enumerable.Select(enumerable, info => new
		{
			info = info,
			o = (OptionSpecification)info.Specification
		}), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.TargetType == TargetType.Switch), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.ShortName.Length > 0), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.UniqueName()), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.info);
		var source2 = (settings.GroupSwitches ? Enumerable.Where(enumerable, info => !Enumerable.Contains(shortSwitches, info)) : enumerable);
		var source3 = Enumerable.Select(Enumerable.OrderBy(Enumerable.Select(Enumerable.Where(source, i => i.Specification.Tag == SpecificationType.Value), info => new
		{
			info = info,
			v = (ValueSpecification)info.Specification
		}), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.v.Index), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.info);
		builder = ((!settings.GroupSwitches || !Enumerable.Any(shortSwitches)) ? builder : builder.Append('-').Append(string.Join(string.Empty, Enumerable.ToArray(Enumerable.Select(shortSwitches, info => ((OptionSpecification)info.Specification).ShortName)))).Append(' '));
		source2.ForEach(opt =>
		{
			builder.Append(FormatOption((OptionSpecification)opt.Specification, opt.Value, settings)).Append(' ');
		});
		builder.AppendWhen(Enumerable.Any(source3) && parser.Settings.EnableDashDash, "-- ");
		source3.ForEach(val =>
		{
			builder.Append(FormatValue(val.Specification, val.Value)).Append(' ');
		});
		return builder.ToString().TrimEnd(new char[1] { ' ' });
	}

	private static string FormatValue(Specification spec, object value)
	{
		StringBuilder stringBuilder = new StringBuilder();
		switch (spec.TargetType)
		{
		case TargetType.Sequence:
		{
			char sep = spec.SeperatorOrSpace();
			Func<object, object> func = (object v) => (sep != ' ') ? v : FormatWithQuotesIfString(v);
			IEnumerator enumerator = ((IEnumerable)value).GetEnumerator();
			while (enumerator.MoveNext())
			{
				stringBuilder.Append(func(enumerator.Current)).Append(sep);
			}
			stringBuilder.TrimEndIfMatch(sep);
			break;
		}
		case TargetType.Scalar:
			stringBuilder.Append(FormatWithQuotesIfString(value));
			break;
		}
		return stringBuilder.ToString();
	}

	private static object FormatWithQuotesIfString(object value)
	{
		if (!(value is DateTime) && !(value is TimeSpan) && !(value is DateTimeOffset))
		{
			Func<string, string> doubQt = (string v) => (!v.Contains("\"")) ? v : v.Replace("\"", "\\\"");
			return (value as string).ToMaybe().MapValueOrDefault((string v) => (!Enumerable.Contains(v, ' ') && !v.Contains("\"")) ? v : "\"".JoinTo(doubQt(v), "\""), value);
		}
		return $"\"{value}\"";
	}

	private static char SeperatorOrSpace(this Specification spec)
	{
		return (spec as OptionSpecification).ToMaybe().MapValueOrDefault((OptionSpecification o) => (o.Separator == '\0') ? ' ' : o.Separator, ' ');
	}

	private static string FormatOption(OptionSpecification spec, object value, UnParserSettings settings)
	{
		return new StringBuilder().Append(spec.FormatName(settings)).AppendWhen(spec.TargetType != TargetType.Switch, FormatValue(spec, value)).ToString();
	}

	private static string FormatName(this OptionSpecification optionSpec, UnParserSettings settings)
	{
		bool flag;
		return new StringBuilder((flag = (optionSpec.LongName.Length > 0 && !settings.PreferShortName) || optionSpec.ShortName.Length == 0) ? "--".JoinTo(optionSpec.LongName) : "-".JoinTo(optionSpec.ShortName)).AppendWhen(optionSpec.TargetType != TargetType.Switch, (!flag || !settings.UseEqualToken) ? " " : "=").ToString();
	}

	private static object NormalizeValue(this object value)
	{
		return value;
	}

	private static bool IsEmpty(this object value, Specification specification, bool skipDefault)
	{
		if (value == null)
		{
			return true;
		}
		if (skipDefault && value.Equals(specification.DefaultValue.FromJust()))
		{
			return true;
		}
		if (Nullable.GetUnderlyingType(specification.ConversionType) != null)
		{
			return false;
		}
		if (value is ValueType && value.Equals(value.GetType().GetDefaultValue()))
		{
			return true;
		}
		if (value is string && ((string)value).Length == 0)
		{
			return true;
		}
		if (value is IEnumerable && !((IEnumerable)value).GetEnumerator().MoveNext())
		{
			return true;
		}
		return false;
	}
}
