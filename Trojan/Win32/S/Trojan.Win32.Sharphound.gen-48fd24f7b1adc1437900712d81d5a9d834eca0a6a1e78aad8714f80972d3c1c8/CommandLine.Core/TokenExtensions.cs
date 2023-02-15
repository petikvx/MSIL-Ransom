namespace CommandLine.Core;

internal static class TokenExtensions
{
	public static bool IsName(this Token token)
	{
		return token.Tag == TokenType.Name;
	}

	public static bool IsValue(this Token token)
	{
		return token.Tag == TokenType.Value;
	}
}
