using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwaySharp.ErrorHandling;

internal static class Trial
{
	public static Result<TSuccess, TMessage> Ok<TSuccess, TMessage>(TSuccess value)
	{
		return new Ok<TSuccess, TMessage>(value, Enumerable.Empty<TMessage>());
	}

	public static Result<TSuccess, TMessage> Pass<TSuccess, TMessage>(TSuccess value)
	{
		return new Ok<TSuccess, TMessage>(value, Enumerable.Empty<TMessage>());
	}

	public static Result<TSuccess, TMessage> Warn<TSuccess, TMessage>(TMessage message, TSuccess value)
	{
		return new Ok<TSuccess, TMessage>(value, new TMessage[1] { message });
	}

	public static Result<TSuccess, TMessage> Fail<TSuccess, TMessage>(TMessage message)
	{
		return new Bad<TSuccess, TMessage>(new TMessage[1] { message });
	}

	public static bool Failed<TSuccess, TMessage>(Result<TSuccess, TMessage> result)
	{
		return result.Tag == ResultType.Bad;
	}

	public static TResult Either<TSuccess, TMessage, TResult>(Func<TSuccess, IEnumerable<TMessage>, TResult> successFunc, Func<IEnumerable<TMessage>, TResult> failureFunc, Result<TSuccess, TMessage> trialResult)
	{
		if (trialResult is Ok<TSuccess, TMessage> ok)
		{
			return successFunc(ok.Success, ok.Messages);
		}
		Bad<TSuccess, TMessage> bad = (Bad<TSuccess, TMessage>)trialResult;
		return failureFunc(bad.Messages);
	}

	public static TSuccess ReturnOrFail<TSuccess, TMessage>(Result<TSuccess, TMessage> result)
	{
		Func<IEnumerable<TMessage>, TSuccess> failureFunc = delegate(IEnumerable<TMessage> msgs)
		{
			throw new Exception(string.Join(Environment.NewLine, Enumerable.Select(msgs, (TMessage m) => m.ToString())));
		};
		return Either((TSuccess succ, IEnumerable<TMessage> _) => succ, failureFunc, result);
	}

	public static Result<TSuccess, TMessage> MergeMessages<TSuccess, TMessage>(IEnumerable<TMessage> messages, Result<TSuccess, TMessage> result)
	{
		Func<TSuccess, IEnumerable<TMessage>, Result<TSuccess, TMessage>> successFunc = (TSuccess succ, IEnumerable<TMessage> msgs) => new Ok<TSuccess, TMessage>(succ, Enumerable.Concat(messages, msgs));
		Func<IEnumerable<TMessage>, Result<TSuccess, TMessage>> failureFunc = (IEnumerable<TMessage> errors) => new Bad<TSuccess, TMessage>(Enumerable.Concat(errors, messages));
		return Either(successFunc, failureFunc, result);
	}

	public static Result<TSuccess, TMessage> Bind<TValue, TSuccess, TMessage>(Func<TValue, Result<TSuccess, TMessage>> func, Result<TValue, TMessage> result)
	{
		Func<TValue, IEnumerable<TMessage>, Result<TSuccess, TMessage>> successFunc = (TValue succ, IEnumerable<TMessage> msgs) => MergeMessages(msgs, func(succ));
		Func<IEnumerable<TMessage>, Result<TSuccess, TMessage>> failureFunc = (IEnumerable<TMessage> messages) => new Bad<TSuccess, TMessage>(messages);
		return Either(successFunc, failureFunc, result);
	}

	public static Result<TSuccess, TMessage> Flatten<TSuccess, TMessage>(Result<Result<TSuccess, TMessage>, TMessage> result)
	{
		return Bind((Result<TSuccess, TMessage> x) => x, result);
	}

	public static Result<TSuccess, TMessage> Apply<TValue, TSuccess, TMessage>(Result<Func<TValue, TSuccess>, TMessage> wrappedFunction, Result<TValue, TMessage> result)
	{
		if (wrappedFunction.Tag == ResultType.Ok && result.Tag == ResultType.Ok)
		{
			Ok<Func<TValue, TSuccess>, TMessage> ok = (Ok<Func<TValue, TSuccess>, TMessage>)wrappedFunction;
			Ok<TValue, TMessage> ok2 = (Ok<TValue, TMessage>)result;
			return new Ok<TSuccess, TMessage>(ok.Success(ok2.Success), Enumerable.Concat(ok.Messages, ok2.Messages));
		}
		if (wrappedFunction.Tag == ResultType.Bad && result.Tag == ResultType.Ok)
		{
			return new Bad<TSuccess, TMessage>(((Bad<TValue, TMessage>)result).Messages);
		}
		if (wrappedFunction.Tag == ResultType.Ok && result.Tag == ResultType.Bad)
		{
			return new Bad<TSuccess, TMessage>(((Bad<TValue, TMessage>)result).Messages);
		}
		Bad<Func<TValue, TSuccess>, TMessage> obj = (Bad<Func<TValue, TSuccess>, TMessage>)wrappedFunction;
		return new Bad<TSuccess, TMessage>(Enumerable.Concat(second: ((Bad<TValue, TMessage>)result).Messages, first: obj.Messages));
	}

	public static Result<TSuccess, TMessage> Lift<TValue, TSuccess, TMessage>(Func<TValue, TSuccess> func, Result<TValue, TMessage> result)
	{
		return Apply(Ok<Func<TValue, TSuccess>, TMessage>(func), result);
	}

	public static Result<TSuccess1, TMessage1> Lift2<TSuccess, TMessage, TSuccess1, TMessage1>(Func<TSuccess, Func<TMessage, TSuccess1>> func, Result<TSuccess, TMessage1> a, Result<TMessage, TMessage1> b)
	{
		return Apply(Lift(func, a), b);
	}

	public static Result<IEnumerable<TSuccess>, TMessage> Collect<TSuccess, TMessage>(IEnumerable<Result<TSuccess, TMessage>> xs)
	{
		return Lift(Enumerable.Reverse, Enumerable.Aggregate<Result<TSuccess, TMessage>, Result<IEnumerable<TSuccess>, TMessage>, Result<IEnumerable<TSuccess>, TMessage>>(xs, null, delegate(Result<IEnumerable<TSuccess>, TMessage> result, Result<TSuccess, TMessage> next)
		{
			if (result.Tag == ResultType.Ok && next.Tag == ResultType.Ok)
			{
				Ok<IEnumerable<TSuccess>, TMessage> ok = (Ok<IEnumerable<TSuccess>, TMessage>)result;
				Ok<TSuccess, TMessage> ok2 = (Ok<TSuccess, TMessage>)next;
				return new Ok<IEnumerable<TSuccess>, TMessage>(Enumerable.Concat(Enumerable.Concat(Enumerable.Empty<TSuccess>(), new TSuccess[1] { ok2.Success }), ok.Success), Enumerable.Concat(ok.Messages, ok2.Messages));
			}
			if ((result.Tag == ResultType.Ok && next.Tag == ResultType.Bad) || (result.Tag == ResultType.Bad && next.Tag == ResultType.Ok))
			{
				IEnumerable<TMessage> first = ((result.Tag == ResultType.Ok) ? ((Ok<IEnumerable<TSuccess>, TMessage>)result).Messages : ((Bad<TSuccess, TMessage>)next).Messages);
				IEnumerable<TMessage> second = ((result.Tag == ResultType.Bad) ? ((Bad<IEnumerable<TSuccess>, TMessage>)result).Messages : ((Ok<TSuccess, TMessage>)next).Messages);
				return new Bad<IEnumerable<TSuccess>, TMessage>(Enumerable.Concat(first, second));
			}
			Bad<IEnumerable<TSuccess>, TMessage> obj = (Bad<IEnumerable<TSuccess>, TMessage>)result;
			return new Bad<IEnumerable<TSuccess>, TMessage>(Enumerable.Concat(second: ((Bad<TSuccess, TMessage>)next).Messages, first: obj.Messages));
		}, (Result<IEnumerable<TSuccess>, TMessage> x) => x));
	}
}
