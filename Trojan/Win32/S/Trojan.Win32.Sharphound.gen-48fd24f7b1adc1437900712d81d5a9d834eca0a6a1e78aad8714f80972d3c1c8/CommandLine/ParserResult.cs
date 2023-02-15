namespace CommandLine;

public abstract class ParserResult<T>
{
	private readonly ParserResultType tag;

	private readonly TypeInfo typeInfo;

	public ParserResultType Tag => tag;

	public TypeInfo TypeInfo => typeInfo;

	internal ParserResult(ParserResultType tag, TypeInfo typeInfo)
	{
		this.tag = tag;
		this.typeInfo = typeInfo;
	}
}
