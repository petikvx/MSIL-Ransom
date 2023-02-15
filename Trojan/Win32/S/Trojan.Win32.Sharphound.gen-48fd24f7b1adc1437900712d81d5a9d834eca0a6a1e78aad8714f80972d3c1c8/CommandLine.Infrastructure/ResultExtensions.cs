using System.Collections.Generic;
using System.Linq;
using CSharpx;
using RailwaySharp.ErrorHandling;

namespace CommandLine.Infrastructure;

internal static class ResultExtensions
{
	public static IEnumerable<TMessage> SuccessfulMessages<TSuccess, TMessage>(this Result<TSuccess, TMessage> result)
	{
		if (result.Tag == ResultType.Ok)
		{
			return ((Ok<TSuccess, TMessage>)result).Messages;
		}
		return Enumerable.Empty<TMessage>();
	}

	public static Maybe<TSuccess> ToMaybe<TSuccess, TMessage>(this Result<TSuccess, TMessage> result)
	{
		if (result.Tag == ResultType.Ok)
		{
			return Maybe.Just(((Ok<TSuccess, TMessage>)result).Success);
		}
		return Maybe.Nothing<TSuccess>();
	}
}
