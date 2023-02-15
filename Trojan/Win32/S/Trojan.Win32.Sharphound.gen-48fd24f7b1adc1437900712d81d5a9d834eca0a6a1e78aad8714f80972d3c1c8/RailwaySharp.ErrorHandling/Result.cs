using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwaySharp.ErrorHandling;

internal abstract class Result<TSuccess, TMessage>
{
	private readonly ResultType tag;

	public ResultType Tag => tag;

	protected Result(ResultType tag)
	{
		this.tag = tag;
	}

	public override string ToString()
	{
		if (Tag == ResultType.Ok)
		{
			Ok<TSuccess, TMessage> ok = (Ok<TSuccess, TMessage>)this;
			return $"OK: {ok.Success} - {string.Join(Environment.NewLine, Enumerable.Select(ok.Messages, (TMessage v) => v.ToString()))}";
		}
		Bad<TSuccess, TMessage> bad = (Bad<TSuccess, TMessage>)this;
		return $"Error: {string.Join(Environment.NewLine, Enumerable.Select(bad.Messages, (TMessage v) => v.ToString()))}";
	}
}
internal static class Result
{
	public static Result<TSuccess, TMessage> FailWith<TSuccess, TMessage>(IEnumerable<TMessage> messages)
	{
		return new Bad<TSuccess, TMessage>(messages);
	}

	public static Result<TSuccess, TMessage> FailWith<TSuccess, TMessage>(TMessage message)
	{
		return new Bad<TSuccess, TMessage>(new TMessage[1] { message });
	}

	public static Result<TSuccess, TMessage> Succeed<TSuccess, TMessage>(TSuccess value)
	{
		return new Ok<TSuccess, TMessage>(value, Enumerable.Empty<TMessage>());
	}

	public static Result<TSuccess, TMessage> Succeed<TSuccess, TMessage>(TSuccess value, TMessage message)
	{
		return new Ok<TSuccess, TMessage>(value, new TMessage[1] { message });
	}

	public static Result<TSuccess, TMessage> Succeed<TSuccess, TMessage>(TSuccess value, IEnumerable<TMessage> messages)
	{
		return new Ok<TSuccess, TMessage>(value, messages);
	}

	public static Result<TSuccess, Exception> Try<TSuccess>(Func<TSuccess> func)
	{
		try
		{
			return new Ok<TSuccess, Exception>(func(), Enumerable.Empty<Exception>());
		}
		catch (Exception ex)
		{
			return new Bad<TSuccess, Exception>(new Exception[1] { ex });
		}
	}
}
