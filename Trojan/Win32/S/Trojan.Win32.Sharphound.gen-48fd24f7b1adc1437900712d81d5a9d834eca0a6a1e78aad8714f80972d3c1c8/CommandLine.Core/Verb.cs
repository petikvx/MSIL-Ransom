using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace CommandLine.Core;

internal sealed class Verb
{
	private readonly string name;

	private readonly string helpText;

	private readonly bool hidden;

	public string Name => name;

	public string HelpText => helpText;

	public bool Hidden => hidden;

	public Verb(string name, string helpText, bool hidden = false)
	{
		this.name = name ?? throw new ArgumentNullException("name");
		this.helpText = helpText ?? throw new ArgumentNullException("helpText");
		this.hidden = hidden;
	}

	public static Verb FromAttribute(VerbAttribute attribute)
	{
		return new Verb(attribute.Name, attribute.HelpText, attribute.Hidden);
	}

	public static IEnumerable<Tuple<Verb, Type>> SelectFromTypes(IEnumerable<Type> types)
	{
		return Enumerable.Select(Enumerable.Where(Enumerable.Select(types, (Type type) => new
		{
			type = type,
			attrs = Enumerable.ToArray(type.GetTypeInfo().GetCustomAttributes(typeof(VerbAttribute), inherit: true))
		}), _003C_003Eh__TransparentIdentifier0 => _003C_003Eh__TransparentIdentifier0.attrs.Length == 1), _003C_003Eh__TransparentIdentifier0 => Tuple.Create(FromAttribute((VerbAttribute)Enumerable.Single(_003C_003Eh__TransparentIdentifier0.attrs)), _003C_003Eh__TransparentIdentifier0.type));
	}
}
