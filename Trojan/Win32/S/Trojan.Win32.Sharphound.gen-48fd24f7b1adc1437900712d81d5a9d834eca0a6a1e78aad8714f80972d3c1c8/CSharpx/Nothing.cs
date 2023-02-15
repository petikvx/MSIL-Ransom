namespace CSharpx;

internal sealed class Nothing<T> : Maybe<T>
{
	internal Nothing()
		: base(MaybeType.Nothing)
	{
	}
}
