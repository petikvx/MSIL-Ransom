using System;
using System.Collections.Generic;
using System.Linq;
using CSharpx;

namespace CommandLine.Core;

internal static class SpecificationPropertyRules
{
	public static IEnumerable<Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>>> Lookup(IEnumerable<Token> tokens)
	{
		return new List<Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>>>
		{
			EnforceMutuallyExclusiveSet(),
			EnforceGroup(),
			EnforceRequired(),
			EnforceRange(),
			EnforceSingle(tokens)
		};
	}

	private static Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> EnforceGroup()
	{
		return delegate(IEnumerable<SpecificationProperty> specProps)
		{
			var source = Enumerable.Where(Enumerable.Select(Enumerable.GroupBy(Enumerable.Select(Enumerable.Where(Enumerable.Select(Enumerable.Where(specProps, (SpecificationProperty sp) => sp.Specification.IsOption()), (SpecificationProperty sp) => new
			{
				sp = sp,
				o = (OptionSpecification)sp.Specification
			}), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.Group.Length > 0), _003C_003Eh__TransparentIdentifier0 => new
			{
				Option = _003C_003Eh__TransparentIdentifier0.o,
				Value = _003C_003Eh__TransparentIdentifier0.sp.Value
			}), o => o.Option.Group), g => g), gr => Enumerable.All(gr, g => g.Value.IsNothing()));
			return Enumerable.Any(source) ? Enumerable.Select(source, gr => new MissingGroupOptionError(gr.Key, Enumerable.Select(gr, g => new NameInfo(g.Option.ShortName, g.Option.LongName)))) : Enumerable.Empty<Error>();
		};
	}

	private static Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> EnforceMutuallyExclusiveSet()
	{
		return delegate(IEnumerable<SpecificationProperty> specProps)
		{
			IEnumerable<OptionSpecification> source = Enumerable.Select(Enumerable.Where(Enumerable.Select(Enumerable.Where(Enumerable.Where(specProps, (SpecificationProperty sp) => sp.Specification.IsOption()), (SpecificationProperty sp) => sp.Value.IsJust()), (SpecificationProperty sp) => new
			{
				sp = sp,
				o = (OptionSpecification)sp.Specification
			}), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.SetName.Length > 0), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o);
			return (Enumerable.Count(Enumerable.Select(Enumerable.GroupBy(source, (OptionSpecification o) => o.SetName), (IGrouping<string, OptionSpecification> g) => g)) > 1) ? Enumerable.Select(source, (OptionSpecification o) => new MutuallyExclusiveSetError(o.FromOptionSpecification(), o.SetName)) : Enumerable.Empty<Error>();
		};
	}

	private static Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> EnforceRequired()
	{
		return delegate(IEnumerable<SpecificationProperty> specProps)
		{
			IEnumerable<Specification> enumerable = Enumerable.Select(Enumerable.Where(Enumerable.Select(Enumerable.Where(Enumerable.Where(Enumerable.Where(specProps, (SpecificationProperty sp) => sp.Specification.IsOption()), (SpecificationProperty sp) => sp.Specification.Required), (SpecificationProperty sp) => sp.Value.IsJust()), (SpecificationProperty sp) => new
			{
				sp = sp,
				o = (OptionSpecification)sp.Specification
			}), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.SetName.Length > 0), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.sp.Specification);
			IEnumerable<string> setWithRequiredValue = Enumerable.Distinct(Enumerable.Select(Enumerable.Where(Enumerable.Select(enumerable, (Specification s) => new
			{
				s = s,
				o = (OptionSpecification)s
			}), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.SetName.Length > 0), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.SetName));
			return Enumerable.Select(Enumerable.Concat(Enumerable.Concat(Enumerable.Except(Enumerable.Select(Enumerable.Where(Enumerable.Where(Enumerable.Where(Enumerable.Select(Enumerable.Where(Enumerable.Where(Enumerable.Where(specProps, (SpecificationProperty sp) => sp.Specification.IsOption()), (SpecificationProperty sp) => sp.Specification.Required), (SpecificationProperty sp) => sp.Value.IsNothing()), (SpecificationProperty sp) => new
			{
				sp = sp,
				o = (OptionSpecification)sp.Specification
			}), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.SetName.Length > 0), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.Group.Length == 0), _003C_003Eh__TransparentIdentifier0 => setWithRequiredValue.ContainsIfNotEmpty(_003C_003Eh__TransparentIdentifier0.o.SetName)), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.sp.Specification), enumerable), Enumerable.Select(Enumerable.Where(Enumerable.Where(Enumerable.Select(Enumerable.Where(Enumerable.Where(Enumerable.Where(specProps, (SpecificationProperty sp) => sp.Specification.IsOption()), (SpecificationProperty sp) => sp.Specification.Required), (SpecificationProperty sp) => sp.Value.IsNothing()), (SpecificationProperty sp) => new
			{
				sp = sp,
				o = (OptionSpecification)sp.Specification
			}), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.SetName.Length == 0), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.o.Group.Length == 0), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.sp.Specification)), Enumerable.Select(Enumerable.Where(Enumerable.Where(Enumerable.Where(specProps, (SpecificationProperty sp) => sp.Specification.IsValue()), (SpecificationProperty sp) => sp.Specification.Required), (SpecificationProperty sp) => sp.Value.IsNothing()), (SpecificationProperty sp) => sp.Specification)), (Specification sp) => new MissingRequiredOptionError(sp.FromSpecification()));
		};
	}

	private static Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> EnforceRange()
	{
		return delegate(IEnumerable<SpecificationProperty> specProps)
		{
			IEnumerable<SpecificationProperty> source = Enumerable.Where(Enumerable.Where(Enumerable.Where(specProps, (SpecificationProperty sp) => sp.Specification.TargetType == TargetType.Sequence), (SpecificationProperty sp) => sp.Value.IsJust()), delegate(SpecificationProperty sp)
			{
				if (sp.Specification.Min.IsJust() && ((Array)sp.Value.FromJustOrFail()).Length < sp.Specification.Min.FromJustOrFail())
				{
					return true;
				}
				return sp.Specification.Max.IsJust() && ((Array)sp.Value.FromJustOrFail()).Length > sp.Specification.Max.FromJustOrFail();
			});
			return Enumerable.Any(source) ? Enumerable.Select(source, (SpecificationProperty s) => new SequenceOutOfRangeError(s.Specification.FromSpecification())) : Enumerable.Empty<Error>();
		};
	}

	private static Func<IEnumerable<SpecificationProperty>, IEnumerable<Error>> EnforceSingle(IEnumerable<Token> tokens)
	{
		return delegate(IEnumerable<SpecificationProperty> specProps)
		{
			IEnumerable<OptionSpecification> inner = Enumerable.Select(Enumerable.Where(Enumerable.Where(specProps, (SpecificationProperty sp) => sp.Specification.IsOption()), (SpecificationProperty sp) => sp.Value.IsJust()), (SpecificationProperty sp) => (OptionSpecification)sp.Specification);
			var first = Enumerable.Select(Enumerable.Where(Enumerable.SelectMany(Enumerable.GroupJoin(Enumerable.Where(tokens, (Token t) => t.IsName()), inner, (Token t) => t.Text, (OptionSpecification o) => o.ShortName, (Token t, IEnumerable<OptionSpecification> to) => new { t, to }), _003C_003Eh__TransparentIdentifier0 => Enumerable.DefaultIfEmpty(_003C_003Eh__TransparentIdentifier0.to), (_003C_003Eh__TransparentIdentifier0, OptionSpecification o) => new { _003C_003Eh__TransparentIdentifier0, o }), _003C_003Eh__TransparentIdentifier1 => _003C_003Eh__TransparentIdentifier1.o != null), _003C_003Eh__TransparentIdentifier1 => new
			{
				_003C_003Eh__TransparentIdentifier1.o.ShortName,
				_003C_003Eh__TransparentIdentifier1.o.LongName
			});
			var second = Enumerable.Select(Enumerable.Where(Enumerable.SelectMany(Enumerable.GroupJoin(Enumerable.Where(tokens, (Token t) => t.IsName()), inner, (Token t) => t.Text, (OptionSpecification o) => o.LongName, (Token t, IEnumerable<OptionSpecification> to) => new { t, to }), _003C_003Eh__TransparentIdentifier0 => Enumerable.DefaultIfEmpty(_003C_003Eh__TransparentIdentifier0.to), (_003C_003Eh__TransparentIdentifier0, OptionSpecification o) => new { _003C_003Eh__TransparentIdentifier0, o }), _003C_003Eh__TransparentIdentifier1 => _003C_003Eh__TransparentIdentifier1.o != null), _003C_003Eh__TransparentIdentifier1 => new
			{
				_003C_003Eh__TransparentIdentifier1.o.ShortName,
				_003C_003Eh__TransparentIdentifier1.o.LongName
			});
			return Enumerable.Select(Enumerable.Where(Enumerable.Select(Enumerable.Select(Enumerable.GroupBy(Enumerable.Concat(first, second), x => x), g => new
			{
				g = g,
				count = Enumerable.Count(g)
			}), _003C_003Eh__TransparentIdentifier0 => new
			{
				Value = _003C_003Eh__TransparentIdentifier0.g.Key,
				Count = _003C_003Eh__TransparentIdentifier0.count
			}), y => y.Count > 1), y => new RepeatedOptionError(new NameInfo(y.Value.ShortName, y.Value.LongName)));
		};
	}

	private static bool ContainsIfNotEmpty<T>(this IEnumerable<T> sequence, T value)
	{
		if (Enumerable.Any(sequence))
		{
			return Enumerable.Contains(sequence, value);
		}
		return true;
	}
}
