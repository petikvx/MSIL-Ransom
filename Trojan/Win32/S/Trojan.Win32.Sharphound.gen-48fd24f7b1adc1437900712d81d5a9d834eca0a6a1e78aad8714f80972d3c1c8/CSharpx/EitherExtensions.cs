using System;

namespace CSharpx;

internal static class EitherExtensions
{
	public static void Match<TLeft, TRight>(this Either<TLeft, TRight> either, Action<TLeft> ifLeft, Action<TRight> ifRight)
	{
		if (either.MatchLeft(out var value))
		{
			ifLeft(value);
		}
		else
		{
			ifRight(((Right<TLeft, TRight>)either).Value);
		}
	}

	public static Either<string, TRight> ToEither<TRight>(this TRight value)
	{
		return Either.Return(value);
	}

	public static Either<TLeft, TResult> Bind<TLeft, TRight, TResult>(this Either<TLeft, TRight> either, Func<TRight, Either<TLeft, TResult>> func)
	{
		return Either.Bind(either, func);
	}

	public static Either<TLeft, TResult> Map<TLeft, TRight, TResult>(this Either<TLeft, TRight> either, Func<TRight, TResult> func)
	{
		return Either.Map(either, func);
	}

	public static Either<TLeft1, TRight1> Bimap<TLeft, TRight, TLeft1, TRight1>(this Either<TLeft, TRight> either, Func<TLeft, TLeft1> mapLeft, Func<TRight, TRight1> mapRight)
	{
		return Either.Bimap(either, mapLeft, mapRight);
	}

	public static bool IsLeft<TLeft, TRight>(this Either<TLeft, TRight> either)
	{
		return either.Tag == EitherType.Left;
	}

	public static bool IsRight<TLeft, TRight>(this Either<TLeft, TRight> either)
	{
		return either.Tag == EitherType.Right;
	}
}
