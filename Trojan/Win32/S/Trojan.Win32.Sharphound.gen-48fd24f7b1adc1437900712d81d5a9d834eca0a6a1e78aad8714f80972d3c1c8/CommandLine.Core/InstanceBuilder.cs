using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using CSharpx;
using CommandLine.Infrastructure;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Core;

internal static class InstanceBuilder
{
	public static ParserResult<T> Build<T>(Maybe<Func<T>> factory, Func<IEnumerable<string>, IEnumerable<OptionSpecification>, Result<IEnumerable<Token>, Error>> tokenizer, IEnumerable<string> arguments, StringComparer nameComparer, bool ignoreValueCase, CultureInfo parsingCulture, bool autoHelp, bool autoVersion, IEnumerable<ErrorType> nonFatalErrors)
	{
		Type typeInfo = factory.MapValueOrDefault<Func<T>, Type>((Func<T> f) => f().GetType(), typeof(T));
		IEnumerable<SpecificationProperty> specProps = typeInfo.GetSpecifications((PropertyInfo pi) => SpecificationProperty.Create(Specification.FromProperty(pi), pi, Maybe.Nothing<object>())).Memorize();
		IEnumerable<Specification> specifications = Enumerable.Select(specProps, (SpecificationProperty pt) => pt.Specification);
		IEnumerable<OptionSpecification> optionSpecs = Enumerable.OfType<OptionSpecification>(specifications.ThrowingValidate(SpecificationGuards.Lookup)).Memorize();
		Func<T> makeDefault = () => (!typeof(T).IsMutable()) ? ReflectionHelper.CreateDefaultImmutableInstance<T>(Enumerable.ToArray(Enumerable.Select(specProps, (SpecificationProperty p) => p.Specification.ConversionType))) : factory.MapValueOrDefault((Func<T> f) => f(), Activator.CreateInstance<T>());
		Func<IEnumerable<Error>, ParserResult<T>> func = (IEnumerable<Error> errs) => new NotParsed<T>(makeDefault().GetType().ToTypeInfo(), errs);
		IEnumerable<string> argumentsList = arguments.Memorize();
		Func<ParserResult<T>> func2 = delegate
		{
			Result<IEnumerable<Token>, Error> result = tokenizer(argumentsList, optionSpecs);
			IEnumerable<Token> tokens = result.SucceededWith().Memorize();
			Tuple<IEnumerable<KeyValuePair<string, IEnumerable<string>>>, IEnumerable<string>, IEnumerable<Token>> tuple = TokenPartitioner.Partition(tokens, (string name) => TypeLookup.FindTypeDescriptorAndSibling(name, optionSpecs, nameComparer));
			IEnumerable<KeyValuePair<string, IEnumerable<string>>> options = tuple.Item1.Memorize();
			IEnumerable<string> values = tuple.Item2.Memorize();
			IEnumerable<Token> source = tuple.Item3.Memorize();
			Result<IEnumerable<SpecificationProperty>, Error> result2 = OptionMapper.MapValues(Enumerable.Where(specProps, (SpecificationProperty pt) => pt.Specification.IsOption()), options, (IEnumerable<string> vals, Type type, bool isScalar) => TypeConverter.ChangeType(vals, type, isScalar, parsingCulture, ignoreValueCase), nameComparer);
			Result<IEnumerable<SpecificationProperty>, Error> result3 = ValueMapper.MapValues(Enumerable.OrderBy(Enumerable.Where(specProps, (SpecificationProperty pt) => pt.Specification.IsValue()), (SpecificationProperty pt) => ((ValueSpecification)pt.Specification).Index), values, (IEnumerable<string> vals, Type type, bool isScalar) => TypeConverter.ChangeType(vals, type, isScalar, parsingCulture, ignoreValueCase));
			IEnumerable<MissingValueOptionError> second = Enumerable.Select(source, (Token token) => new MissingValueOptionError(Enumerable.Single(optionSpecs, (OptionSpecification o) => token.Text.MatchName(o.ShortName, o.LongName, nameComparer)).FromOptionSpecification()));
			IEnumerable<SpecificationProperty> enumerable2 = Enumerable.Concat(result2.SucceededWith(), result3.SucceededWith()).Memorize();
			List<Error> list = new List<Error>();
			T instance = ((!typeInfo.IsMutable()) ? BuildImmutable(typeInfo, factory, specProps, enumerable2, list) : BuildMutable(factory, enumerable2, list));
			IEnumerable<Error> enumerable3 = Enumerable.Concat(Enumerable.Concat(second: enumerable2.Validate(SpecificationPropertyRules.Lookup(tokens)), first: Enumerable.Concat(Enumerable.Concat(Enumerable.Concat(result.SuccessfulMessages(), second), result2.SuccessfulMessages()), result3.SuccessfulMessages())), list).Memorize();
			IEnumerable<Error> second3 = Enumerable.Where(enumerable3, (Error e) => Enumerable.Contains(nonFatalErrors, e.Tag));
			return Enumerable.Except(enumerable3, second3).ToParserResult(instance);
		};
		IEnumerable<Error> enumerable = (Enumerable.Any(argumentsList) ? arguments.Preprocess(PreprocessorGuards.Lookup(nameComparer, autoHelp, autoVersion)) : Enumerable.Empty<Error>()).Memorize();
		if (!Enumerable.Any(argumentsList))
		{
			return func2();
		}
		if (!Enumerable.Any(enumerable))
		{
			return func2();
		}
		return func(enumerable);
	}

	private static T BuildMutable<T>(Maybe<Func<T>> factory, IEnumerable<SpecificationProperty> specPropsWithValue, List<Error> setPropertyErrors)
	{
		T val = factory.MapValueOrDefault((Func<T> f) => f(), Activator.CreateInstance<T>());
		setPropertyErrors.AddRange(val.SetProperties(specPropsWithValue, (SpecificationProperty sp) => sp.Value.IsJust(), (SpecificationProperty sp) => sp.Value.FromJustOrFail()));
		setPropertyErrors.AddRange(val.SetProperties(specPropsWithValue, (SpecificationProperty sp) => sp.Value.IsNothing() && sp.Specification.DefaultValue.IsJust(), (SpecificationProperty sp) => sp.Specification.DefaultValue.FromJustOrFail()));
		setPropertyErrors.AddRange(val.SetProperties(specPropsWithValue, (SpecificationProperty sp) => sp.Value.IsNothing() && sp.Specification.TargetType == TargetType.Sequence && sp.Specification.DefaultValue.MatchNothing(), (SpecificationProperty sp) => Enumerable.Single(sp.Property.PropertyType.GetTypeInfo().GetGenericArguments()).CreateEmptyArray()));
		return val;
	}

	private static T BuildImmutable<T>(Type typeInfo, Maybe<Func<T>> factory, IEnumerable<SpecificationProperty> specProps, IEnumerable<SpecificationProperty> specPropsWithValue, List<Error> setPropertyErrors)
	{
		_003C_003Ec__DisplayClass2_0<T> CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0<T>();
		CS_0024_003C_003E8__locals0.specProps = specProps;
		CS_0024_003C_003E8__locals0.typeInfo = typeInfo;
		ConstructorInfo constructor = CS_0024_003C_003E8__locals0.typeInfo.GetTypeInfo().GetConstructor(Enumerable.ToArray(Enumerable.Select(CS_0024_003C_003E8__locals0.specProps, (SpecificationProperty sp) => sp.Property.PropertyType)));
		if (constructor == null)
		{
			throw new InvalidOperationException("Type " + CS_0024_003C_003E8__locals0.typeInfo.FullName + " appears to be immutable, but no constructor found to accept values.");
		}
		try
		{
			object[] parameters = Enumerable.ToArray(Enumerable.SelectMany(Enumerable.GroupJoin(constructor.GetParameters(), specPropsWithValue, (ParameterInfo prms) => prms.Name!.ToLower(), (SpecificationProperty sp) => sp.Property.Name.ToLower(), (ParameterInfo prms, IEnumerable<SpecificationProperty> spv) => new { prms, spv }), _003C_003Eh__TransparentIdentifier0 => Enumerable.DefaultIfEmpty(_003C_003Eh__TransparentIdentifier0.spv), (_003C_003Eh__TransparentIdentifier0, SpecificationProperty sp) => (sp != null) ? sp.Value.GetValueOrDefault(sp.Specification.DefaultValue.GetValueOrDefault(sp.Specification.ConversionType.CreateDefaultForImmutable())) : Enumerable.First(CS_0024_003C_003E8__locals0.specProps, (SpecificationProperty s) => string.Equals(s.Property.Name, _003C_003Eh__TransparentIdentifier0.prms.Name, StringComparison.CurrentCultureIgnoreCase)).Property.PropertyType.GetDefaultValue()));
			return (T)constructor.Invoke(parameters);
		}
		catch (Exception)
		{
			string[] s2 = Enumerable.ToArray(Enumerable.Select(specPropsWithValue, (SpecificationProperty x) => x.Property.Name.ToLowerInvariant()));
			throw CS_0024_003C_003E8__locals0.method_0(s2);
		}
	}
}
