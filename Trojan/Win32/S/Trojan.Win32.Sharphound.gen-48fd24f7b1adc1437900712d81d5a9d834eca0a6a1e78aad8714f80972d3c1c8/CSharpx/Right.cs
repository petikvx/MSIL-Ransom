namespace CSharpx;

internal sealed class Right<TLeft, TRight> : Either<TLeft, TRight>
{
	private readonly TRight value;

	public TRight Value => value;

	internal Right(TRight value)
		: base(EitherType.Right)
	{
		this.value = value;
	}
}
