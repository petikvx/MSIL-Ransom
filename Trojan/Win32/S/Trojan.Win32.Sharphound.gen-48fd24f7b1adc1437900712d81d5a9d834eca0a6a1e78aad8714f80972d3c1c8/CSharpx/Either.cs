using System;

namespace CSharpx;

internal abstract class Either<TLeft, TRight>
{
	private readonly EitherType tag;

	public EitherType Tag => tag;

	protected Either(EitherType tag)
	{
		this.tag = tag;
	}

	public bool MatchLeft(out TLeft value)
	{
		value = ((Tag == EitherType.Left) ? ((Left<TLeft, TRight>)this).Value : default(TLeft));
		return Tag == EitherType.Left;
	}

	public bool MatchRight(out TRight value)
	{
		value = ((Tag == EitherType.Right) ? ((Right<TLeft, TRight>)this).Value : default(TRight));
		return Tag == EitherType.Right;
	}
}
internal static class Either
{
	public static Either<TLeft, TRight> Left<TLeft, TRight>(TLeft value)
	{
		return new Left<TLeft, TRight>(value);
	}

	public static Either<TLeft, TRight> Right<TLeft, TRight>(TRight value)
	{
		return new Right<TLeft, TRight>(value);
	}

	public static Either<string, TRight> Return<TRight>(TRight value)
	{
		return Right<string, TRight>(value);
	}

	public static Either<string, TRight> Fail<TRight>(string message)
	{
		throw new Exception(message);
	}

	public static Either<TLeft, TResult> Bind<TLeft, TRight, TResult>(Either<TLeft, TRight> either, Func<TRight, Either<TLeft, TResult>> func)
	{
		if (either.MatchRight(out var value))
		{
			return func(value);
		}
		return Left<TLeft, TResult>(either.GetLeft());
	}

	public static Either<TLeft, TResult> Map<TLeft, TRight, TResult>(Either<TLeft, TRight> either, Func<TRight, TResult> func)
	{
		if (either.MatchRight(out var value))
		{
			return Right<TLeft, TResult>(func(value));
		}
		return Left<TLeft, TResult>(either.GetLeft());
	}

	public static Either<TLeft1, TRight1> Bimap<TLeft, TRight, TLeft1, TRight1>(Either<TLeft, TRight> either, Func<TLeft, TLeft1> mapLeft, Func<TRight, TRight1> mapRight)
	{
		if (either.MatchRight(out var value))
		{
			return Right<TLeft1, TRight1>(mapRight(value));
		}
		return Left<TLeft1, TRight1>(mapLeft(either.GetLeft()));
	}

	public static Either<TLeft, TResult> Select<TLeft, TRight, TResult>(this Either<TLeft, TRight> either, Func<TRight, TResult> selector)
	{
		return Map(either, selector);
	}

	public static Either<TLeft, TResult> SelectMany<TLeft, TRight, TResult>(this Either<TLeft, TRight> result, Func<TRight, Either<TLeft, TResult>> func)
	{
		return Bind(result, func);
	}

	public static TRight GetOrFail<TLeft, TRight>(Either<TLeft, TRight> either)
	{
		if (!either.MatchRight(out var value))
		{
			throw new ArgumentException("either", $"The either value was Left {either}");
		}
		return value;
	}

	public static TLeft GetLeftOrDefault<TLeft, TRight>(Either<TLeft, TRight> either, TLeft @default)
	{
		if (!either.MatchLeft(out var value))
		{
			return @default;
		}
		return value;
	}

	public static TRight GetRightOrDefault<TLeft, TRight>(Either<TLeft, TRight> either, TRight @default)
	{
		if (!either.MatchRight(out var value))
		{
			return @default;
		}
		return value;
	}

	public static Either<Exception, TRight> Try<TRight>(Func<TRight> func)
	{
		try
		{
			return new Right<Exception, TRight>(func());
		}
		catch (Exception value)
		{
			return new Left<Exception, TRight>(value);
		}
	}

	public static Either<Exception, TRight> Cast<TRight>(object obj)
	{
		return Try(() => (TRight)obj);
	}

	public static Either<TLeft, TRight> OfMaybe<TLeft, TRight>(Maybe<TRight> maybe, TLeft left)
	{
		if (maybe.Tag == MaybeType.Just)
		{
			return Right<TLeft, TRight>(((Just<TRight>)maybe).Value);
		}
		return Left<TLeft, TRight>(left);
	}

	private static TLeft GetLeft<TLeft, TRight>(this Either<TLeft, TRight> either)
	{
		return ((Left<TLeft, TRight>)either).Value;
	}
}
