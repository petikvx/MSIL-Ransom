using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommandLine.Infrastructure;

namespace CommandLine.Text;

public abstract class SentenceBuilder
{
	private class DefaultSentenceBuilder : SentenceBuilder
	{
		public override Func<string> RequiredWord => () => "Required.";

		public override Func<string> ErrorsHeadingText => () => "ERROR(S):";

		public override Func<string> UsageHeadingText => () => "USAGE:";

		public override Func<string> OptionGroupWord => () => "Group";

		public override Func<bool, string> HelpCommandText => (bool isOption) => (!isOption) ? "Display more information on a specific command." : "Display this help screen.";

		public override Func<bool, string> VersionCommandText => (bool _) => "Display version information.";

		public override Func<Error, string> FormatError => delegate(Error error)
		{
			switch (error.Tag)
			{
			case ErrorType.BadFormatTokenError:
				return "Token '".JoinTo(((BadFormatTokenError)error).Token, "' is not recognized.");
			case ErrorType.MissingValueOptionError:
				return "Option '".JoinTo(((MissingValueOptionError)error).NameInfo.NameText, "' has no value.");
			case ErrorType.UnknownOptionError:
				return "Option '".JoinTo(((UnknownOptionError)error).Token, "' is unknown.");
			case ErrorType.MissingRequiredOptionError:
			{
				MissingRequiredOptionError missingRequiredOptionError = (MissingRequiredOptionError)error;
				if (!missingRequiredOptionError.NameInfo.Equals(NameInfo.EmptyName))
				{
					return "Required option '".JoinTo(missingRequiredOptionError.NameInfo.NameText, "' is missing.");
				}
				return "A required value not bound to option name is missing.";
			}
			case ErrorType.BadFormatConversionError:
			{
				BadFormatConversionError badFormatConversionError = (BadFormatConversionError)error;
				if (!badFormatConversionError.NameInfo.Equals(NameInfo.EmptyName))
				{
					return "Option '".JoinTo(badFormatConversionError.NameInfo.NameText, "' is defined with a bad format.");
				}
				return "A value not bound to option name is defined with a bad format.";
			}
			case ErrorType.SequenceOutOfRangeError:
			{
				SequenceOutOfRangeError sequenceOutOfRangeError = (SequenceOutOfRangeError)error;
				if (!sequenceOutOfRangeError.NameInfo.Equals(NameInfo.EmptyName))
				{
					return "A sequence option '".JoinTo(sequenceOutOfRangeError.NameInfo.NameText, "' is defined with fewer or more items than required.");
				}
				return "A sequence value not bound to option name is defined with few items than required.";
			}
			case ErrorType.RepeatedOptionError:
				return "Option '".JoinTo(((RepeatedOptionError)error).NameInfo.NameText, "' is defined multiple times.");
			case ErrorType.NoVerbSelectedError:
				return "No verb selected.";
			case ErrorType.BadVerbSelectedError:
				return "Verb '".JoinTo(((BadVerbSelectedError)error).Token, "' is not recognized.");
			case ErrorType.SetValueExceptionError:
			{
				SetValueExceptionError setValueExceptionError = (SetValueExceptionError)error;
				return "Error setting value to option '".JoinTo(setValueExceptionError.NameInfo.NameText, "': ", setValueExceptionError.Exception.Message);
			}
			default:
				throw new InvalidOperationException();
			case ErrorType.MissingGroupOptionError:
			{
				MissingGroupOptionError missingGroupOptionError = (MissingGroupOptionError)error;
				return "At least one option from group '".JoinTo(missingGroupOptionError.Group, "' (", string.Join(", ", Enumerable.Select(missingGroupOptionError.Names, (NameInfo n) => n.NameText)), ") is required.");
			}
			}
		};

		public override Func<IEnumerable<MutuallyExclusiveSetError>, string> FormatMutuallyExclusiveSetErrors => delegate(IEnumerable<MutuallyExclusiveSetError> errors)
		{
			var bySet = Enumerable.Select(Enumerable.GroupBy(errors, (MutuallyExclusiveSetError e) => e.SetName), (IGrouping<string, MutuallyExclusiveSetError> g) => new
			{
				SetName = g.Key,
				Errors = Enumerable.ToList(g)
			});
			string[] value = Enumerable.ToArray(Enumerable.Select(bySet, set =>
			{
				string text = string.Join(string.Empty, Enumerable.ToArray(Enumerable.Select(set.Errors, (MutuallyExclusiveSetError e) => "'".JoinTo(e.NameInfo.NameText, "', "))));
				int num = Enumerable.Count(set.Errors);
				string text2 = string.Join(string.Empty, Enumerable.ToArray(Enumerable.Select(Enumerable.Distinct(Enumerable.SelectMany(Enumerable.Where(bySet, s => !s.SetName.Equals(set.SetName)), s => s.Errors, (s, MutuallyExclusiveSetError e) => e)), (MutuallyExclusiveSetError x) => "'".JoinTo(x.NameInfo.NameText, "', "))));
				return new StringBuilder("Option").AppendWhen(num > 1, "s").Append(": ").Append(text.Substring(0, text.Length - 2))
					.Append(' ')
					.AppendIf(num > 1, "are", "is")
					.Append(" not compatible with: ")
					.Append(text2.Substring(0, text2.Length - 2))
					.Append('.')
					.ToString();
			}));
			return string.Join(Environment.NewLine, value);
		};
	}

	public static Func<SentenceBuilder> Factory { get; set; } = () => new DefaultSentenceBuilder();


	public abstract Func<string> RequiredWord { get; }

	public abstract Func<string> OptionGroupWord { get; }

	public abstract Func<string> ErrorsHeadingText { get; }

	public abstract Func<string> UsageHeadingText { get; }

	public abstract Func<bool, string> HelpCommandText { get; }

	public abstract Func<bool, string> VersionCommandText { get; }

	public abstract Func<Error, string> FormatError { get; }

	public abstract Func<IEnumerable<MutuallyExclusiveSetError>, string> FormatMutuallyExclusiveSetErrors { get; }

	public static SentenceBuilder Create()
	{
		return Factory();
	}
}
