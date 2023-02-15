using System.Collections.Generic;
using System.Linq;

namespace CommandLine.Text;

internal static class ExampleExtensions
{
	public static IEnumerable<UnParserSettings> GetFormatStylesOrDefault(this Example example)
	{
		if (!Enumerable.Any(example.FormatStyles))
		{
			return new UnParserSettings[1]
			{
				new UnParserSettings
				{
					Consumed = true
				}
			};
		}
		return example.FormatStyles;
	}
}
