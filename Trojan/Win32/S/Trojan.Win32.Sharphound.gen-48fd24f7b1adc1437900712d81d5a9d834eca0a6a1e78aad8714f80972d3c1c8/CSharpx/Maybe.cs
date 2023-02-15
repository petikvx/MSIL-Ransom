using System;

namespace CSharpx;

internal abstract class Maybe<T>
{
	private readonly MaybeType tag;

	public MaybeType Tag => tag;

	protected Maybe(MaybeType tag)
	{
		this.tag = tag;
	}

	public bool MatchJust(out T value)
	{
		value = ((Tag == MaybeType.Just) ? ((Just<T>)this).Value : default(T));
		return Tag == MaybeType.Just;
	}

	public bool MatchNothing()
	{
		return Tag == MaybeType.Nothing;
	}
}
internal static class Maybe
{
	public static Maybe<T> Nothing<T>()
	{
		return new Nothing<T>();
	}

	public static Just<T> Just<T>(T value)
	{
		return new Just<T>(value);
	}

	public static Maybe<T> Return<T>(T value)
	{
		if (!object.Equals(value, default(T)))
		{
			return Just(value);
		}
		return Nothing<T>();
	}

	public static Maybe<T2> Bind<T1, T2>(Maybe<T1> maybe, Func<T1, Maybe<T2>> func)
	{
		if (!maybe.MatchJust(out var value))
		{
			return Nothing<T2>();
		}
		return func(value);
	}

	public static Maybe<T2> Map<T1, T2>(Maybe<T1> maybe, Func<T1, T2> func)
	{
		if (!maybe.MatchJust(out var value))
		{
			return Nothing<T2>();
		}
		return Just(func(value));
	}

	public static Maybe<Tuple<T1, T2>> Merge<T1, T2>(Maybe<T1> first, Maybe<T2> second)
	{
		if (first.MatchJust(out var value) && second.MatchJust(out var value2))
		{
			return Just(Tuple.Create(value, value2));
		}
		return Nothing<Tuple<T1, T2>>();
	}
}
