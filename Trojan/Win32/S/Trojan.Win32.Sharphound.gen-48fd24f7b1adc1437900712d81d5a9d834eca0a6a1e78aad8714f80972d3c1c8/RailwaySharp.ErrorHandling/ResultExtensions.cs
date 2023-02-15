using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwaySharp.ErrorHandling;

internal static class ResultExtensions
{
	public static void Match<TSuccess, TMessage>(this Result<TSuccess, TMessage> result, Action<TSuccess, IEnumerable<TMessage>> ifSuccess, Action<IEnumerable<TMessage>> ifFailure)
	{
		if (result is Ok<TSuccess, TMessage> ok)
		{
			ifSuccess(ok.Success, ok.Messages);
			return;
		}
		Bad<TSuccess, TMessage> bad = (Bad<TSuccess, TMessage>)result;
		ifFailure(bad.Messages);
	}

	public static TResult Either<TSuccess, TMessage, TResult>(this Result<TSuccess, TMessage> result, Func<TSuccess, IEnumerable<TMessage>, TResult> ifSuccess, Func<IEnumerable<TMessage>, TResult> ifFailure)
	{
		if (result is Ok<TSuccess, TMessage> ok)
		{
			return ifSuccess(ok.Success, ok.Messages);
		}
		Bad<TSuccess, TMessage> bad = (Bad<TSuccess, TMessage>)result;
		return ifFailure(bad.Messages);
	}

	public static Result<TResult, TMessage> Map<TSuccess, TMessage, TResult>(this Result<TSuccess, TMessage> result, Func<TSuccess, TResult> func)
	{
		return Trial.Lift(func, result);
	}

	public static Result<IEnumerable<TSuccess>, TMessage> Collect<TSuccess, TMessage>(this IEnumerable<Result<TSuccess, TMessage>> values)
	{
		return Trial.Collect(values);
	}

	public static Result<IEnumerable<TSuccess>, TMessage> Flatten<TSuccess, TMessage>(this Result<IEnumerable<Result<TSuccess, TMessage>>, TMessage> result)
	{
		if (result.Tag == ResultType.Ok)
		{
			Result<IEnumerable<TSuccess>, TMessage> result2 = ((Ok<IEnumerable<Result<TSuccess, TMessage>>, TMessage>)result).Success.Collect();
			if (result2.Tag == ResultType.Ok)
			{
				Ok<IEnumerable<TSuccess>, TMessage> ok = (Ok<IEnumerable<TSuccess>, TMessage>)result2;
				return new Ok<IEnumerable<TSuccess>, TMessage>(ok.Success, ok.Messages);
			}
			return new Bad<IEnumerable<TSuccess>, TMessage>(((Bad<IEnumerable<TSuccess>, TMessage>)result2).Messages);
		}
		return new Bad<IEnumerable<TSuccess>, TMessage>(((Bad<IEnumerable<Result<TSuccess, TMessage>>, TMessage>)result).Messages);
	}

	public static Result<TResult, TMessage> SelectMany<TSuccess, TMessage, TResult>(this Result<TSuccess, TMessage> result, Func<TSuccess, Result<TResult, TMessage>> func)
	{
		return Trial.Bind(func, result);
	}

	public static Result<TResult, TMessage> SelectMany<TSuccess, TMessage, TValue, TResult>(this Result<TSuccess, TMessage> result, Func<TSuccess, Result<TValue, TMessage>> func, Func<TSuccess, TValue, TResult> mapperFunc)
	{
		Func<TSuccess, Func<TValue, TResult>> curriedMapper = (TSuccess suc) => (TValue val) => mapperFunc(suc, val);
		Func<Result<TSuccess, TMessage>, Result<TValue, TMessage>, Result<TResult, TMessage>> obj = (Result<TSuccess, TMessage> a, Result<TValue, TMessage> b) => Trial.Lift2(curriedMapper, a, b);
		Result<TValue, TMessage> arg = Trial.Bind(func, result);
		return obj(result, arg);
	}

	public static Result<TResult, TMessage> Select<TSuccess, TMessage, TResult>(this Result<TSuccess, TMessage> result, Func<TSuccess, TResult> func)
	{
		return Trial.Lift(func, result);
	}

	public static IEnumerable<TMessage> FailedWith<TSuccess, TMessage>(this Result<TSuccess, TMessage> result)
	{
		if (result.Tag == ResultType.Ok)
		{
			Ok<TSuccess, TMessage> ok = (Ok<TSuccess, TMessage>)result;
			throw new Exception($"Result was a success: {ok.Success} - {string.Join(Environment.NewLine, Enumerable.Select(ok.Messages, (TMessage m) => m.ToString()))}");
		}
		return ((Bad<TSuccess, TMessage>)result).Messages;
	}

	public static TSuccess SucceededWith<TSuccess, TMessage>(this Result<TSuccess, TMessage> result)
	{
		if (result.Tag != 0)
		{
			Bad<TSuccess, TMessage> bad = (Bad<TSuccess, TMessage>)result;
			throw new Exception($"Result was an error: {string.Join(Environment.NewLine, Enumerable.Select(bad.Messages, (TMessage m) => m.ToString()))}");
		}
		return ((Ok<TSuccess, TMessage>)result).Success;
	}
}
