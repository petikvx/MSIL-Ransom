namespace CommandLine.Core;

internal abstract class Token
{
	private readonly TokenType tag;

	private readonly string text;

	public TokenType Tag => tag;

	public string Text => text;

	protected Token(TokenType tag, string text)
	{
		this.tag = tag;
		this.text = text;
	}

	public static Token Name(string text)
	{
		return new Name(text);
	}

	public static Token Value(string text)
	{
		return new Value(text);
	}

	public static Token Value(string text, bool explicitlyAssigned)
	{
		return new Value(text, explicitlyAssigned);
	}
}
