namespace CSharpx;

internal sealed class Just<T> : Maybe<T>
{
	private readonly T value;

	public T Value => value;

	internal Just(T value)
		: base(MaybeType.Just)
	{
		this.value = value;
	}
}
