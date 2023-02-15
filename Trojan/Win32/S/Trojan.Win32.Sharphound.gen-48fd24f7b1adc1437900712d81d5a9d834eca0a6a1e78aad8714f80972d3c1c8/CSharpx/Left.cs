namespace CSharpx;

internal sealed class Left<TLeft, TRight> : Either<TLeft, TRight>
{
	private readonly TLeft value;

	public TLeft Value => value;

	internal Left(TLeft value)
		: base(EitherType.Left)
	{
		this.value = value;
	}
}
